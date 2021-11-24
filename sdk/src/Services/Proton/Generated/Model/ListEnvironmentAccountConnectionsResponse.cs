/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the ListEnvironmentAccountConnections operation.
    /// </summary>
    public partial class ListEnvironmentAccountConnectionsResponse : AmazonWebServiceResponse
    {
        private List<EnvironmentAccountConnectionSummary> _environmentAccountConnections = new List<EnvironmentAccountConnectionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountConnections. 
        /// <para>
        /// An array of environment account connections with details that's returned by Proton.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EnvironmentAccountConnectionSummary> EnvironmentAccountConnections
        {
            get { return this._environmentAccountConnections; }
            set { this._environmentAccountConnections = value; }
        }

        // Check to see if EnvironmentAccountConnections property is set
        internal bool IsSetEnvironmentAccountConnections()
        {
            return this._environmentAccountConnections != null && this._environmentAccountConnections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to indicate the location of the next environment account connection in the
        /// array of environment account connections, after the current requested list of environment
        /// account connections.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}