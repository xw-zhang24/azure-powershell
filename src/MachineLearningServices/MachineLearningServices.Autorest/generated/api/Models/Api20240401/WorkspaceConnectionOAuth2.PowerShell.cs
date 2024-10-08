// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>
    /// ClientId and ClientSecret are required. Other properties are optional
    /// depending on each OAuth2 provider's implementation.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(WorkspaceConnectionOAuth2TypeConverter))]
    public partial class WorkspaceConnectionOAuth2
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.WorkspaceConnectionOAuth2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2 DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkspaceConnectionOAuth2(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.WorkspaceConnectionOAuth2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2 DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WorkspaceConnectionOAuth2(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkspaceConnectionOAuth2" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="WorkspaceConnectionOAuth2" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2 FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.WorkspaceConnectionOAuth2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkspaceConnectionOAuth2(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AuthUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).AuthUrl = (string) content.GetValueForProperty("AuthUrl",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).AuthUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientSecret = (string) content.GetValueForProperty("ClientSecret",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientSecret, global::System.Convert.ToString);
            }
            if (content.Contains("DeveloperToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).DeveloperToken = (string) content.GetValueForProperty("DeveloperToken",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).DeveloperToken, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Password = (string) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Password, global::System.Convert.ToString);
            }
            if (content.Contains("RefreshToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).RefreshToken = (string) content.GetValueForProperty("RefreshToken",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).RefreshToken, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("Username"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Username = (string) content.GetValueForProperty("Username",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Username, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.WorkspaceConnectionOAuth2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WorkspaceConnectionOAuth2(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AuthUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).AuthUrl = (string) content.GetValueForProperty("AuthUrl",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).AuthUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientSecret = (string) content.GetValueForProperty("ClientSecret",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).ClientSecret, global::System.Convert.ToString);
            }
            if (content.Contains("DeveloperToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).DeveloperToken = (string) content.GetValueForProperty("DeveloperToken",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).DeveloperToken, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Password = (string) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Password, global::System.Convert.ToString);
            }
            if (content.Contains("RefreshToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).RefreshToken = (string) content.GetValueForProperty("RefreshToken",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).RefreshToken, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("Username"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Username = (string) content.GetValueForProperty("Username",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionOAuth2Internal)this).Username, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// ClientId and ClientSecret are required. Other properties are optional
    /// depending on each OAuth2 provider's implementation.
    [System.ComponentModel.TypeConverter(typeof(WorkspaceConnectionOAuth2TypeConverter))]
    public partial interface IWorkspaceConnectionOAuth2

    {

    }
}