// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Paginated list of operations</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Url to get the next page of items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationResponse[] _value;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationResponse[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// Paginated list of operations
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Url to get the next page of items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Url to get the next page of items.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationResponse) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationResponse[] Value { get; set; }

    }
    /// Paginated list of operations
    internal partial interface IOperationListInternal

    {
        /// <summary>Url to get the next page of items.</summary>
        string NextLink { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IOperationResponse[] Value { get; set; }

    }
}