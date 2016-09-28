// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMetadataValue.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Orc.Metadata
{
    /// <summary>
    ///   Maps a <see cref="IMetadata"/> with its corresponding value computed from a given instance.
    /// </summary>
    public interface IMetadataValue
    {
        #region Properties
        /// <summary>The metadata.</summary>
        IMetadata Metadata { get; }

        /// <summary>Mapped value.</summary>
        object Value { get; set; }
        #endregion
    }
}