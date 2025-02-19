// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.PowerShell;

    /// <summary>The action delay result.</summary>
    [System.ComponentModel.TypeConverter(typeof(DevBoxActionDelayResultTypeConverter))]
    public partial class DevBoxActionDelayResult
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxActionDelayResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DevBoxActionDelayResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxActionDelayResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResult DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DevBoxActionDelayResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxActionDelayResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DevBoxActionDelayResult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxAction) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Action, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Result"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Result = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionDelayResultStatus) content.GetValueForProperty("Result",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Result, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionDelayResultStatus.CreateFrom);
            }
            if (content.Contains("ActionNext"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionNext = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxNextAction) content.GetValueForProperty("ActionNext",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionNext, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxNextActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ActionUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionUri = (string) content.GetValueForProperty("ActionUri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionUri, global::System.Convert.ToString);
            }
            if (content.Contains("ActionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionName = (string) content.GetValueForProperty("ActionName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionName, global::System.Convert.ToString);
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionType = (string) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionType, global::System.Convert.ToString);
            }
            if (content.Contains("ActionSourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceId = (string) content.GetValueForProperty("ActionSourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ActionSourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceUri = (string) content.GetValueForProperty("ActionSourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("ActionSourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionSourceType) content.GetValueForProperty("ActionSourceType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceType, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionSourceType.CreateFrom);
            }
            if (content.Contains("ActionSuspendedUntil"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSuspendedUntil = (global::System.DateTime?) content.GetValueForProperty("ActionSuspendedUntil",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSuspendedUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Innererror"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Innererror = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsInnerError) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Innererror, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsInnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("NextScheduledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).NextScheduledTime = (global::System.DateTime) content.GetValueForProperty("NextScheduledTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).NextScheduledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxActionDelayResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DevBoxActionDelayResult(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxAction) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Action, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Result"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Result = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionDelayResultStatus) content.GetValueForProperty("Result",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Result, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionDelayResultStatus.CreateFrom);
            }
            if (content.Contains("ActionNext"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionNext = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxNextAction) content.GetValueForProperty("ActionNext",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionNext, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.DevBoxNextActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ActionUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionUri = (string) content.GetValueForProperty("ActionUri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionUri, global::System.Convert.ToString);
            }
            if (content.Contains("ActionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionName = (string) content.GetValueForProperty("ActionName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionName, global::System.Convert.ToString);
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionType = (string) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionType, global::System.Convert.ToString);
            }
            if (content.Contains("ActionSourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceId = (string) content.GetValueForProperty("ActionSourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ActionSourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceUri = (string) content.GetValueForProperty("ActionSourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("ActionSourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionSourceType) content.GetValueForProperty("ActionSourceType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSourceType, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxActionSourceType.CreateFrom);
            }
            if (content.Contains("ActionSuspendedUntil"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSuspendedUntil = (global::System.DateTime?) content.GetValueForProperty("ActionSuspendedUntil",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).ActionSuspendedUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Innererror"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Innererror = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsInnerError) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).Innererror, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsInnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("NextScheduledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).NextScheduledTime = (global::System.DateTime) content.GetValueForProperty("NextScheduledTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResultInternal)this).NextScheduledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DevBoxActionDelayResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DevBoxActionDelayResult" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IDevBoxActionDelayResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The action delay result.
    [System.ComponentModel.TypeConverter(typeof(DevBoxActionDelayResultTypeConverter))]
    public partial interface IDevBoxActionDelayResult

    {

    }
}