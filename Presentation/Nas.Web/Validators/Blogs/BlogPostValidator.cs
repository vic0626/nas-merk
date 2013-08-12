﻿using FluentValidation;
using Nas.Services.Localization;
using Nas.Web.Models.Blogs;

namespace Nas.Web.Validators.Blogs
{
    public class BlogPostValidator : AbstractValidator<BlogPostModel>
    {
        public BlogPostValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.AddNewComment.CommentText).NotEmpty().WithMessage(localizationService.GetResource("Blog.Comments.CommentText.Required")).When(x => x.AddNewComment != null);
        }}
}