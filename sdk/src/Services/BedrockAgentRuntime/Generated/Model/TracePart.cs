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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Trace Part which contains intermidate response for customer
    /// </summary>
    public partial class TracePart
        : IEventStreamEvent
    {
        private string _agentAliasId;
        private string _agentId;
        private string _sessionId;
        private Trace _trace;

        /// <summary>
        /// Gets and sets the property AgentAliasId.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string AgentAliasId
        {
            get { return this._agentAliasId; }
            set { this._agentAliasId = value; }
        }

        // Check to see if AgentAliasId property is set
        internal bool IsSetAgentAliasId()
        {
            return this._agentAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId.
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Trace.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Trace Trace
        {
            get { return this._trace; }
            set { this._trace = value; }
        }

        // Check to see if Trace property is set
        internal bool IsSetTrace()
        {
            return this._trace != null;
        }

    }
}