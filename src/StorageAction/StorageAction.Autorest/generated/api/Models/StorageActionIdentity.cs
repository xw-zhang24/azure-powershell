// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.Extensions;

    public partial class StorageActionIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Models.IStorageActionIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Models.IStorageActionIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAction.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location to perform preview of the actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAction.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAction.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="StorageTaskName" /> property.</summary>
        private string _storageTaskName;

        /// <summary>
        /// The name of the storage task within the specified resource group. Storage task names must be between 3 and 18 characters
        /// in length and use numbers and lower-case letters only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAction.PropertyOrigin.Owned)]
        public string StorageTaskName { get => this._storageTaskName; set => this._storageTaskName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAction.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="StorageActionIdentity" /> instance.</summary>
        public StorageActionIdentity()
        {

        }
    }
    public partial interface IStorageActionIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.IJsonSerializable
    {
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The location to perform preview of the actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The location to perform preview of the actions.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The name of the storage task within the specified resource group. Storage task names must be between 3 and 18 characters
        /// in length and use numbers and lower-case letters only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the storage task within the specified resource group. Storage task names must be between 3 and 18 characters in length and use numbers and lower-case letters only.",
        SerializedName = @"storageTaskName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageTaskName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IStorageActionIdentityInternal

    {
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The location to perform preview of the actions.</summary>
        string Location { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The name of the storage task within the specified resource group. Storage task names must be between 3 and 18 characters
        /// in length and use numbers and lower-case letters only.
        /// </summary>
        string StorageTaskName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}