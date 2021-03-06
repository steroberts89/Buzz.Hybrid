﻿namespace Buzz.Hybrid.Models
{
    using System.Globalization;
    using System.Web;
    using System.Web.Mvc;
    using Umbraco.Web;
    using Umbraco.Web.Models;

    /// <summary>
    /// Represents the BaseModel Class
    /// </summary>
    public class BaseModel : RenderModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel"/> class.
        /// </summary>
        public BaseModel() 
            : base(UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {
        }

        /// <summary>
        /// Gets the page title
        /// </summary>
        public IHtmlString PageTitle
        {
            get { return MvcHtmlString.Create(Content.GetSafeString("pageTitle", Content.Name)); }
        }

        /// <summary>
        /// Gets the meta description
        /// </summary>
        public string MetaDescription
        {
            get { return Content.GetSafeString("metaDescription"); }
        }

        /// <summary>
        /// Gets the meta keywords
        /// </summary>
        public string MetaKeywords
        {
            get { return Content.GetSafeString("metaKeywords"); }
        }

        /// <summary>
        /// Gets the body CSS override
        /// </summary>
        public string BodyCss
        {
            get
            {
                var cssclass = Content.GetSafeString("bodyCSS", Content.DocumentTypeAlias);

                cssclass = Content.DocumentTypeAlias.Equals(cssclass)
                    ? cssclass
                    : string.Format("{0} {1}", Content.DocumentTypeAlias, cssclass);

                return string.Format("{0} {1}", cssclass, CultureInfo.CurrentCulture.Name);
            }
        }

        /// <summary>
        /// Gets a value indicating whether or not this page is to be displayed in the navigation
        /// </summary>
        /// <remarks>
        /// This is umbracoNaviHide
        /// </remarks>
        public bool HiddenInNavigation
        {
            get { return !Content.IsVisible(); }
        }
    }
}