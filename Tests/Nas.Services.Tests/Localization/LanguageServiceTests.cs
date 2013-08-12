using System.Collections.Generic;
using System.Linq;
using Nas.Core.Caching;
using Nas.Core.Data;
using Nas.Core.Domain.Localization;
using Nas.Core.Domain.Stores;
using Nas.Services.Configuration;
using Nas.Services.Customers;
using Nas.Services.Events;
using Nas.Services.Localization;
using Nas.Tests;
using NUnit.Framework;
using Rhino.Mocks;

namespace Nas.Services.Tests.Localization
{
    [TestFixture]
    public class LanguageServiceTests : ServiceTest
    {
        IRepository<Language> _languageRepo;
        IRepository<StoreMapping> _storeMappingRepo;
        ILanguageService _languageService;
        ISettingService _settingService;
        IEventPublisher _eventPublisher;
        LocalizationSettings _localizationSettings;

        [SetUp]
        public new void SetUp()
        {
            _languageRepo = MockRepository.GenerateMock<IRepository<Language>>();
            var lang1 = new Language
            {
                Name = "English",
                LanguageCulture = "en-Us",
                FlagImageFileName = "us.png",
                Published = true,
                DisplayOrder = 1
            };
            var lang2 = new Language
            {
                Name = "Russian",
                LanguageCulture = "ru-Ru",
                FlagImageFileName = "ru.png",
                Published = true,
                DisplayOrder = 2
            };

            _languageRepo.Expect(x => x.Table).Return(new List<Language>() { lang1, lang2 }.AsQueryable());

            _storeMappingRepo = MockRepository.GenerateMock<IRepository<StoreMapping>>();

            var cacheManager = new NasNullCache();

            _settingService = MockRepository.GenerateMock<ISettingService>();

            _eventPublisher = MockRepository.GenerateMock<IEventPublisher>();
            _eventPublisher.Expect(x => x.Publish(Arg<object>.Is.Anything));

            _localizationSettings = new LocalizationSettings();
            _languageService = new LanguageService(cacheManager, _languageRepo, _storeMappingRepo,
                _settingService, _localizationSettings, _eventPublisher);
        }

        [Test]
        public void Can_get_all_languages()
        {
            var languages = _languageService.GetAllLanguages();
            languages.ShouldNotBeNull();
            (languages.Count > 0).ShouldBeTrue();
        }
    }
}
