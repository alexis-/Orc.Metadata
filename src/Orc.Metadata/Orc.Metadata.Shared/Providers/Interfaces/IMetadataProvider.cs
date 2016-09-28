// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMetadataProvider.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Orc.Metadata
{
    using System.Threading.Tasks;

    /// <summary>
    ///     Factory-pattern interface which generates a <see cref="IObjectWithMetadata" />
    ///     with the provided model instance.
    /// </summary>
    public interface IMetadataProvider
    {
        #region Methods

        /// <summary>
        ///     Synchronously generates a <see cref="IObjectWithMetadata" /> with the given object
        ///     instance.
        /// </summary>
        /// <param name="obj">Object instance.</param>
        /// <returns>Generated object.</returns>
        [ObsoleteEx(RemoveInVersion = "2.0.0", TreatAsErrorFromVersion = "1.1.0", ReplacementTypeOrMember = "GetMetadataAsync")]
        IObjectWithMetadata GetMetadata(object obj);

        /// <summary>
        ///     Asynchronously generates a <see cref="IObjectWithMetadata" /> with the given object
        ///     instance.
        /// </summary>
        /// <param name="obj">Object instance.</param>
        /// <returns>Waitable task.</returns>
        Task<IObjectWithMetadata> GetMetadataAsync(object obj);
        #endregion
    }
}