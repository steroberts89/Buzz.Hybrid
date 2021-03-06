﻿namespace Buzz.Hybrid.Models
{
    using Umbraco.Core.Models;

    /// <summary>
    /// Represents an image.
    /// </summary>
    public class Image : IImage
    {
        /// <summary>
        /// Gets or sets the <see cref="IPublishedContent"/> that this image represents
        /// </summary>
        public IPublishedContent Content { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        public int Bytes { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string Extension { get; set; }
    }
}