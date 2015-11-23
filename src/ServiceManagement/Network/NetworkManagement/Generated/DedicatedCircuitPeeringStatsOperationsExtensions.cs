// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.ExpressRoute;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute
{
    /// <summary>
    /// The Express Route API provides programmatic access to the functionality
    /// needed by the customer to set up Dedicated Circuits and Dedicated
    /// Circuit Links. The Express Route Customer API is a REST API. All API
    /// operations are performed over SSL and mutually authenticated using
    /// X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class DedicatedCircuitPeeringStatsOperationsExtensions
    {
        /// <summary>
        /// The Get Dedicated Circuit Stats operation retrieves the
        /// bytesin/bytesout of the dedicated circuit on primary/secondary
        /// devices for specified peering type.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.IDedicatedCircuitPeeringStatsOperations.
        /// </param>
        /// <param name='serviceKey'>
        /// Required. The service key representing the circuit.
        /// </param>
        /// <param name='accessType'>
        /// Required. Whether the peering is private or public or microsoft.
        /// </param>
        /// <returns>
        /// The Get Dedicated Circuit Stats operation response.
        /// </returns>
        public static DedicatedCircuitPeeringStatsGetResponse Get(this IDedicatedCircuitPeeringStatsOperations operations, string serviceKey, BgpPeeringAccessType accessType)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDedicatedCircuitPeeringStatsOperations)s).GetAsync(serviceKey, accessType);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Dedicated Circuit Stats operation retrieves the
        /// bytesin/bytesout of the dedicated circuit on primary/secondary
        /// devices for specified peering type.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.IDedicatedCircuitPeeringStatsOperations.
        /// </param>
        /// <param name='serviceKey'>
        /// Required. The service key representing the circuit.
        /// </param>
        /// <param name='accessType'>
        /// Required. Whether the peering is private or public or microsoft.
        /// </param>
        /// <returns>
        /// The Get Dedicated Circuit Stats operation response.
        /// </returns>
        public static Task<DedicatedCircuitPeeringStatsGetResponse> GetAsync(this IDedicatedCircuitPeeringStatsOperations operations, string serviceKey, BgpPeeringAccessType accessType)
        {
            return operations.GetAsync(serviceKey, accessType, CancellationToken.None);
        }
    }
}
