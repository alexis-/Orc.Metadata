// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMetadata.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Orc.Metadata
{
    using System;

    /// <summary>
    ///   A single metadata item which can be applied to an object.
    ///   Metadata type and content may be of any form and is dependant on the implementation :
    ///   meta-description, property value reflection, etc.
    /// </summary>
    public interface IMetadata
    {
        #region Properties

        /// <summary>
        /// Gets the property name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        string DisplayName { get; set; }

        /// <summary>
        /// Gets the type of the metadata.
        /// </summary>
        /// <value>The type.</value>
        Type Type { get; }
        #endregion



        #region Methods

        /// <summary>
        /// Extract the value from the given object instance if available.
        /// </summary>
        /// <param name="instance">Target object instance.</param>
        /// <returns>Value if available or NULL.</returns>
        object GetValue(object instance);

        /// <summary>
        /// Sets the value on the given object instance if available.
        /// </summary>
        /// <param name="instance">Target object instance.</param>
        /// <param name="value">Value to be set.</param>
        void SetValue(object instance, object value);
        #endregion
    }
}