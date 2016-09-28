// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObjectWithMetadata.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Orc.Metadata
{
    /// <summary>
    /// Holds a <see cref="IMetadataCollection"/> with its associated target object instance.
    /// </summary>
    public interface IObjectWithMetadata
    {
        #region Properties

        /// <summary>Target object instance.</summary>
        object Instance { get; }

        /// <summary><see cref="IMetadata"/> properties which can be applied to the given <see cref="Instance"/>.</summary>
        IMetadataCollection MetadataCollection { get; }

        #endregion



        #region Methods
        /// <summary>Retrieves the value from the metadata with the given name if available.</summary>
        /// <param name="key">The property name.</param>
        /// <returns>Value if available or NULL.</returns>
        object GetMetadataValue(string key);

        /// <summary>Sets the value of the metadata with the given name if available.</summary>
        /// <param name="key">The property name.</param>
        /// <param name="value">The value to be set.</param>
        /// <returns>Whether the operation succeeded.</returns>
        bool SetMetadataValue(string key, object value);
        #endregion
    }
}