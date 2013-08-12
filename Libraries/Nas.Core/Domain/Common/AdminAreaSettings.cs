
using Nas.Core.Configuration;

namespace Nas.Core.Domain.Common
{
    public class AdminAreaSettings : ISettings
    {
        public int GridPageSize { get; set; }

        public bool DisplayProductPictures { get; set; }
    }
}