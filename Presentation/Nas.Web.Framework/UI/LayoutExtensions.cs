﻿using System.Web.Mvc;
using Nas.Core.Infrastructure;

namespace Nas.Web.Framework.UI
{
    public static class LayoutExtensions
    {
        public static void AddTitleParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder  = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AddTitleParts(part);
        }
        public static void AppendTitleParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder  = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AppendTitleParts(part);
        }
        public static MvcHtmlString NasTitle(this HtmlHelper html, bool addDefaultTitle, string part = "")
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            html.AppendTitleParts(part);
            return MvcHtmlString.Create(html.Encode(pageHeadBuilder.GenerateTitle(addDefaultTitle)));
        }


        public static void AddMetaDescriptionParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AddMetaDescriptionParts(part);
        }
        public static void AppendMetaDescriptionParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AppendMetaDescriptionParts(part);
        }
        public static MvcHtmlString NasMetaDescription(this HtmlHelper html, string part = "")
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            html.AppendMetaDescriptionParts(part);
            return MvcHtmlString.Create(html.Encode(pageHeadBuilder.GenerateMetaDescription()));
        }


        public static void AddMetaKeywordParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AddMetaKeywordParts(part);
        }
        public static void AppendMetaKeywordParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AppendMetaKeywordParts(part);
        }
        public static MvcHtmlString NasMetaKeywords(this HtmlHelper html, string part = "")
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            html.AppendMetaKeywordParts(part);
            return MvcHtmlString.Create(html.Encode(pageHeadBuilder.GenerateMetaKeywords()));
        }



        public static void AddScriptParts(this HtmlHelper html, string part, bool excludeFromBundle = false)
        {
            AddScriptParts(html, ResourceLocation.Head, part, excludeFromBundle);
        }
        public static void AddScriptParts(this HtmlHelper html, ResourceLocation location, string part, bool excludeFromBundle = false)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AddScriptParts(location, part, excludeFromBundle);
        }
        public static void AppendScriptParts(this HtmlHelper html, string part, bool excludeFromBundle = false)
        {
            AppendScriptParts(html, ResourceLocation.Head, part, excludeFromBundle);
        }
        public static void AppendScriptParts(this HtmlHelper html, ResourceLocation location, string part, bool excludeFromBundle = false)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AppendScriptParts(location, part, excludeFromBundle);
        }
        public static MvcHtmlString NasScripts(this HtmlHelper html, UrlHelper urlHelper, 
            ResourceLocation location, bool? bundleFiles = null)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            return MvcHtmlString.Create(pageHeadBuilder.GenerateScripts(urlHelper, location, bundleFiles));
        }



        public static void AddCssFileParts(this HtmlHelper html, string part)
        {
            AddCssFileParts(html, ResourceLocation.Head, part);
        }
        public static void AddCssFileParts(this HtmlHelper html, ResourceLocation location, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AddCssFileParts(location, part);
        }
        public static void AppendCssFileParts(this HtmlHelper html, string part)
        {
            AppendCssFileParts(html, ResourceLocation.Head, part);
        }
        public static void AppendCssFileParts(this HtmlHelper html, ResourceLocation location, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AppendCssFileParts(location, part);
        }
        public static MvcHtmlString NasCssFiles(this HtmlHelper html, UrlHelper urlHelper, 
            ResourceLocation location)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            return MvcHtmlString.Create(pageHeadBuilder.GenerateCssFiles(urlHelper, location));
        }



        public static void AddCanonicalUrlParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AddCanonicalUrlParts(part);
        }
        public static void AppendCanonicalUrlParts(this HtmlHelper html, string part)
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            pageHeadBuilder.AppendCanonicalUrlParts(part);
        }
        public static MvcHtmlString NasCanonicalUrls(this HtmlHelper html, string part = "")
        {
            var pageHeadBuilder = EngineContext.Current.Resolve<IPageHeadBuilder>();
            html.AppendCanonicalUrlParts(part);
            return MvcHtmlString.Create(pageHeadBuilder.GenerateCanonicalUrls());
        }
    }
}
