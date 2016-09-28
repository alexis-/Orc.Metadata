// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMetadataCollection.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Orc.Metadata
{
    using System.Collections.Generic;

    /// <summary>
    /// A collection of <see cref="IMetadata"/>.
    /// </summary>
    public interface IMetadataCollection : IEnumerable<IMetadata>
    {
        #region Properties

        /// <summary>All available <see cref="IMetadata" /></summary>
        IEnumerable<IMetadata> All { get; }
        #endregion



        #region Methods

        /// <summary>Retrieves the metadata with the given name if available.</summary>
        /// <param name="propertyName">Name of the metadata.</param>
        /// <returns>Metadata if available or NULL.</returns>
        IMetadata GetMetadata(string propertyName);
        #endregion
    }
}