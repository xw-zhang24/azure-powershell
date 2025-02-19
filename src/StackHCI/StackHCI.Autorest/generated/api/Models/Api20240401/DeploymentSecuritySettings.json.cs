// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>The SecuritySettings of AzureStackHCI Cluster.</summary>
    public partial class DeploymentSecuritySettings
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject into a new instance of <see cref="DeploymentSecuritySettings" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DeploymentSecuritySettings(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hvciProtection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("hvciProtection"), out var __jsonHvciProtection) ? (bool?)__jsonHvciProtection : HvciProtection;}
            {_drtmProtection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("drtmProtection"), out var __jsonDrtmProtection) ? (bool?)__jsonDrtmProtection : DrtmProtection;}
            {_driftControlEnforced = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("driftControlEnforced"), out var __jsonDriftControlEnforced) ? (bool?)__jsonDriftControlEnforced : DriftControlEnforced;}
            {_credentialGuardEnforced = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("credentialGuardEnforced"), out var __jsonCredentialGuardEnforced) ? (bool?)__jsonCredentialGuardEnforced : CredentialGuardEnforced;}
            {_smbSigningEnforced = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("smbSigningEnforced"), out var __jsonSmbSigningEnforced) ? (bool?)__jsonSmbSigningEnforced : SmbSigningEnforced;}
            {_smbClusterEncryption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("smbClusterEncryption"), out var __jsonSmbClusterEncryption) ? (bool?)__jsonSmbClusterEncryption : SmbClusterEncryption;}
            {_sideChannelMitigationEnforced = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("sideChannelMitigationEnforced"), out var __jsonSideChannelMitigationEnforced) ? (bool?)__jsonSideChannelMitigationEnforced : SideChannelMitigationEnforced;}
            {_bitlockerBootVolume = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("bitlockerBootVolume"), out var __jsonBitlockerBootVolume) ? (bool?)__jsonBitlockerBootVolume : BitlockerBootVolume;}
            {_bitlockerDataVolume = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("bitlockerDataVolumes"), out var __jsonBitlockerDataVolumes) ? (bool?)__jsonBitlockerDataVolumes : BitlockerDataVolume;}
            {_wdacEnforced = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean>("wdacEnforced"), out var __jsonWdacEnforced) ? (bool?)__jsonWdacEnforced : WdacEnforced;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IDeploymentSecuritySettings.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IDeploymentSecuritySettings.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IDeploymentSecuritySettings FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json ? new DeploymentSecuritySettings(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DeploymentSecuritySettings" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DeploymentSecuritySettings" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._hvciProtection ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._hvciProtection) : null, "hvciProtection" ,container.Add );
            AddIf( null != this._drtmProtection ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._drtmProtection) : null, "drtmProtection" ,container.Add );
            AddIf( null != this._driftControlEnforced ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._driftControlEnforced) : null, "driftControlEnforced" ,container.Add );
            AddIf( null != this._credentialGuardEnforced ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._credentialGuardEnforced) : null, "credentialGuardEnforced" ,container.Add );
            AddIf( null != this._smbSigningEnforced ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._smbSigningEnforced) : null, "smbSigningEnforced" ,container.Add );
            AddIf( null != this._smbClusterEncryption ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._smbClusterEncryption) : null, "smbClusterEncryption" ,container.Add );
            AddIf( null != this._sideChannelMitigationEnforced ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._sideChannelMitigationEnforced) : null, "sideChannelMitigationEnforced" ,container.Add );
            AddIf( null != this._bitlockerBootVolume ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._bitlockerBootVolume) : null, "bitlockerBootVolume" ,container.Add );
            AddIf( null != this._bitlockerDataVolume ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._bitlockerDataVolume) : null, "bitlockerDataVolumes" ,container.Add );
            AddIf( null != this._wdacEnforced ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonBoolean((bool)this._wdacEnforced) : null, "wdacEnforced" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}