// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of Provisioning Issue
    /// </summary>
    public partial class ProvisioningIssueProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProvisioningIssueProperties class.
        /// </summary>
        public ProvisioningIssueProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProvisioningIssueProperties class.
        /// </summary>

        /// <param name="issueType">Type of Issue
        /// </param>

        /// <param name="description">Description of the issue
        /// </param>
        public ProvisioningIssueProperties(string issueType = default(string), string description = default(string))

        {
            this.IssueType = issueType;
            this.Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets type of Issue
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "issueType")]
        public string IssueType {get; set; }

        /// <summary>
        /// Gets or sets description of the issue
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }
    }
}