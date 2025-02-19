// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Search.Models
{

    /// <summary>
    /// Defines values for SearchEncryptionWithCmk.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchEncryptionWithCmk
    {
        /// <summary>
        /// No enforcement will be made and the search service can have non customer encrypted resources.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Disabled")]
        Disabled,
        /// <summary>
        /// Search service will be marked as non-compliant if there are one or more non customer encrypted resources.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Enabled")]
        Enabled,
        /// <summary>
        /// Enforcement policy is not explicitly specified, with the behavior being the same as if it were set to 'Disabled'.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Unspecified")]
        Unspecified
    }
    internal static class SearchEncryptionWithCmkEnumExtension
    {
        internal static string ToSerializedValue(this SearchEncryptionWithCmk? value)
        {
            return value == null ? null : ((SearchEncryptionWithCmk)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this SearchEncryptionWithCmk value)
        {
            switch( value )
            {
                case SearchEncryptionWithCmk.Disabled:
                    return "Disabled";
                case SearchEncryptionWithCmk.Enabled:
                    return "Enabled";
                case SearchEncryptionWithCmk.Unspecified:
                    return "Unspecified";
            }
            return null;
        }
        internal static SearchEncryptionWithCmk? ParseSearchEncryptionWithCmk(this string value)
        {
            switch( value )
            {
                case "Disabled":
                    return SearchEncryptionWithCmk.Disabled;
                case "Enabled":
                    return SearchEncryptionWithCmk.Enabled;
                case "Unspecified":
                    return SearchEncryptionWithCmk.Unspecified;
            }
            return null;
        }
    }
}