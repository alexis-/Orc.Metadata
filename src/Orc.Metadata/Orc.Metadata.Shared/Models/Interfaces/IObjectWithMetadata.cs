// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObjectWithMetadata.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Metadata
{
    public interface IObjectWithMetadata
    {
        object Instance { get; }
        IMetadataCollection MetadataCollection { get; }

        object GetMetadataValue(string key);
        bool SetMetadataValue(string key, object value);

        /// <summary>
        ///     Gets or sets the value of the specified <see cref="IMetadata"/> by property key on
        ///     the associated model.
        /// </summary>
        /// <value>The value.</value>
        /// <param name="propertyKey">The property key.</param>
        /// <returns><see cref="IMetadata"/> value for associated model if available, null otherwise.</returns>
        object this[string propertyKey] { get; set; }
    }
}