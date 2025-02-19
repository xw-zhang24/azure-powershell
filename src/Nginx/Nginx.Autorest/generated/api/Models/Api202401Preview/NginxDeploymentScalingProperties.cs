// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    /// <summary>Information on how the deployment will be scaled.</summary>
    public partial class NginxDeploymentScalingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoScaleSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesAutoScaleSettings _autoScaleSetting;

        /// <summary>
        /// The settings for enabling automatic scaling of the deployment. If this field is specified, 'scale.capacity' must be empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesAutoScaleSettings AutoScaleSetting { get => (this._autoScaleSetting = this._autoScaleSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.NginxDeploymentScalingPropertiesAutoScaleSettings()); set => this._autoScaleSetting = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.IScaleProfile[] AutoScaleSettingProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesAutoScaleSettingsInternal)AutoScaleSetting).Profile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesAutoScaleSettingsInternal)AutoScaleSetting).Profile = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private int? _capacity;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public int? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Internal Acessors for AutoScaleSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesAutoScaleSettings Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesInternal.AutoScaleSetting { get => (this._autoScaleSetting = this._autoScaleSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.NginxDeploymentScalingPropertiesAutoScaleSettings()); set { {_autoScaleSetting = value;} } }

        /// <summary>Creates an new <see cref="NginxDeploymentScalingProperties" /> instance.</summary>
        public NginxDeploymentScalingProperties()
        {

        }
    }
    /// Information on how the deployment will be scaled.
    public partial interface INginxDeploymentScalingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"profiles",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.IScaleProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.IScaleProfile[] AutoScaleSettingProfile { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? Capacity { get; set; }

    }
    /// Information on how the deployment will be scaled.
    internal partial interface INginxDeploymentScalingPropertiesInternal

    {
        /// <summary>
        /// The settings for enabling automatic scaling of the deployment. If this field is specified, 'scale.capacity' must be empty.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentScalingPropertiesAutoScaleSettings AutoScaleSetting { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.IScaleProfile[] AutoScaleSettingProfile { get; set; }

        int? Capacity { get; set; }

    }
}