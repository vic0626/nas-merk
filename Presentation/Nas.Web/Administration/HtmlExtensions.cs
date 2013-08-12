﻿using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Nas.Web.Framework;

namespace Nas.Admin
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString NasField<TModel>(this HtmlHelper<TModel> helper, 
            System.Linq.Expressions.Expression<Func<TModel, string>> expression)
        {
            return helper.NasCommonField(expression, (x => helper.TextBoxFor(x)));
        }

        private static MvcHtmlString NasCommonField<TModel, TValue>(this HtmlHelper<TModel> helper, 
            System.Linq.Expressions.Expression<Func<TModel, TValue>> expression,
            Func<System.Linq.Expressions.Expression<Func<TModel, TValue>>,MvcHtmlString> editor)
        {
            var sb = new StringBuilder();
            var tr = new TagBuilder("tr");

            sb.Append(tr.ToString(TagRenderMode.StartTag));

            var builder = new TagBuilder("td");
            builder.Attributes.Add("class", "adminTitle");
            sb.Append(builder.ToString(TagRenderMode.StartTag));
            sb.Append(helper.NasLabelFor(expression).ToHtmlString() + ":");
            sb.Append(builder.ToString(TagRenderMode.EndTag));

            builder = new TagBuilder("td");
            builder.Attributes.Add("class", "adminData");
            sb.Append(builder.ToString(TagRenderMode.StartTag));
            sb.Append(editor.Invoke(expression).ToHtmlString());
            sb.Append(helper.ValidationMessageFor(expression).ToHtmlString());
            sb.Append(builder.ToString(TagRenderMode.EndTag));

            sb.Append(tr.ToString(TagRenderMode.EndTag));

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}