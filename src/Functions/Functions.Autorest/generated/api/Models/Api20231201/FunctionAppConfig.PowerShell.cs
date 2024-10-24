// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Function app configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(FunctionAppConfigTypeConverter))]
    public partial class FunctionAppConfig
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionAppConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfig" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfig DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FunctionAppConfig(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionAppConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfig" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfig DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FunctionAppConfig(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FunctionAppConfig" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FunctionAppConfig" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfig FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionAppConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FunctionAppConfig(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Deployment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Deployment = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeployment) content.GetValueForProperty("Deployment",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Deployment, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeploymentTypeConverter.ConvertFrom);
            }
            if (content.Contains("Runtime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Runtime = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntime) content.GetValueForProperty("Runtime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Runtime, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsRuntimeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScaleAndConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrency = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrency) content.GetValueForProperty("ScaleAndConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrency, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RuntimeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeName = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName?) content.GetValueForProperty("RuntimeName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeName, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName.CreateFrom);
            }
            if (content.Contains("DeploymentStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).DeploymentStorage = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorage) content.GetValueForProperty("DeploymentStorage",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).DeploymentStorage, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeploymentStorageTypeConverter.ConvertFrom);
            }
            if (content.Contains("RuntimeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeVersion = (string) content.GetValueForProperty("RuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ScaleAndConcurrencyTrigger"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyTrigger = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggers) content.GetValueForProperty("ScaleAndConcurrencyTrigger",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyTrigger, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTriggersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScaleAndConcurrencyAlwaysReady"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyAlwaysReady = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig[]) content.GetValueForProperty("ScaleAndConcurrencyAlwaysReady",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyAlwaysReady, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsAlwaysReadyConfigTypeConverter.ConvertFrom));
            }
            if (content.Contains("ScaleAndConcurrencyMaximumInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyMaximumInstanceCount = (float?) content.GetValueForProperty("ScaleAndConcurrencyMaximumInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyMaximumInstanceCount, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("ScaleAndConcurrencyInstanceMemoryMb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyInstanceMemoryMb = (float?) content.GetValueForProperty("ScaleAndConcurrencyInstanceMemoryMb",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyInstanceMemoryMb, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("StorageAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageAuthentication = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorageAuthentication) content.GetValueForProperty("StorageAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageAuthentication, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeploymentStorageAuthenticationTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType?) content.GetValueForProperty("StorageType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType.CreateFrom);
            }
            if (content.Contains("StorageValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageValue = (string) content.GetValueForProperty("StorageValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageValue, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType?) content.GetValueForProperty("AuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType.CreateFrom);
            }
            if (content.Contains("TriggerHttp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).TriggerHttp = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp) content.GetValueForProperty("TriggerHttp",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).TriggerHttp, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTriggersHttpTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthenticationUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationUserAssignedIdentityResourceId = (string) content.GetValueForProperty("AuthenticationUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationStorageAccountConnectionStringName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationStorageAccountConnectionStringName = (string) content.GetValueForProperty("AuthenticationStorageAccountConnectionStringName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationStorageAccountConnectionStringName, global::System.Convert.ToString);
            }
            if (content.Contains("HttpPerInstanceConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).HttpPerInstanceConcurrency = (float?) content.GetValueForProperty("HttpPerInstanceConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).HttpPerInstanceConcurrency, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionAppConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FunctionAppConfig(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Deployment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Deployment = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeployment) content.GetValueForProperty("Deployment",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Deployment, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeploymentTypeConverter.ConvertFrom);
            }
            if (content.Contains("Runtime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Runtime = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntime) content.GetValueForProperty("Runtime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).Runtime, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsRuntimeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScaleAndConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrency = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrency) content.GetValueForProperty("ScaleAndConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrency, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RuntimeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeName = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName?) content.GetValueForProperty("RuntimeName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeName, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName.CreateFrom);
            }
            if (content.Contains("DeploymentStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).DeploymentStorage = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorage) content.GetValueForProperty("DeploymentStorage",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).DeploymentStorage, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeploymentStorageTypeConverter.ConvertFrom);
            }
            if (content.Contains("RuntimeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeVersion = (string) content.GetValueForProperty("RuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).RuntimeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ScaleAndConcurrencyTrigger"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyTrigger = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggers) content.GetValueForProperty("ScaleAndConcurrencyTrigger",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyTrigger, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTriggersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScaleAndConcurrencyAlwaysReady"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyAlwaysReady = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig[]) content.GetValueForProperty("ScaleAndConcurrencyAlwaysReady",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyAlwaysReady, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsAlwaysReadyConfigTypeConverter.ConvertFrom));
            }
            if (content.Contains("ScaleAndConcurrencyMaximumInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyMaximumInstanceCount = (float?) content.GetValueForProperty("ScaleAndConcurrencyMaximumInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyMaximumInstanceCount, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("ScaleAndConcurrencyInstanceMemoryMb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyInstanceMemoryMb = (float?) content.GetValueForProperty("ScaleAndConcurrencyInstanceMemoryMb",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).ScaleAndConcurrencyInstanceMemoryMb, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("StorageAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageAuthentication = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorageAuthentication) content.GetValueForProperty("StorageAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageAuthentication, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeploymentStorageAuthenticationTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType?) content.GetValueForProperty("StorageType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType.CreateFrom);
            }
            if (content.Contains("StorageValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageValue = (string) content.GetValueForProperty("StorageValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).StorageValue, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType?) content.GetValueForProperty("AuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType.CreateFrom);
            }
            if (content.Contains("TriggerHttp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).TriggerHttp = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp) content.GetValueForProperty("TriggerHttp",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).TriggerHttp, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTriggersHttpTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthenticationUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationUserAssignedIdentityResourceId = (string) content.GetValueForProperty("AuthenticationUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationStorageAccountConnectionStringName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationStorageAccountConnectionStringName = (string) content.GetValueForProperty("AuthenticationStorageAccountConnectionStringName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).AuthenticationStorageAccountConnectionStringName, global::System.Convert.ToString);
            }
            if (content.Contains("HttpPerInstanceConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).HttpPerInstanceConcurrency = (float?) content.GetValueForProperty("HttpPerInstanceConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal)this).HttpPerInstanceConcurrency, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Function app configuration.
    [System.ComponentModel.TypeConverter(typeof(FunctionAppConfigTypeConverter))]
    public partial interface IFunctionAppConfig

    {

    }
}