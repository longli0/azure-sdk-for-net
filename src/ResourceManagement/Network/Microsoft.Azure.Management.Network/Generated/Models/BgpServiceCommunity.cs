// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service Community Properties.
    /// </summary>
    [JsonTransformation]
    public partial class BgpServiceCommunity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BgpServiceCommunity class.
        /// </summary>
        public BgpServiceCommunity() { }

        /// <summary>
        /// Initializes a new instance of the BgpServiceCommunity class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="serviceName">The name of the bgp community. e.g.
        /// Skype.</param>
        /// <param name="bgpCommunities">Get a list of bgp communities.</param>
        public BgpServiceCommunity(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string serviceName = default(string), IList<BGPCommunity> bgpCommunities = default(IList<BGPCommunity>))
            : base(id, name, type, location, tags)
        {
            ServiceName = serviceName;
            BgpCommunities = bgpCommunities;
        }

        /// <summary>
        /// Gets or sets the name of the bgp community. e.g. Skype.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets get a list of bgp communities.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpCommunities")]
        public IList<BGPCommunity> BgpCommunities { get; set; }

    }
}

