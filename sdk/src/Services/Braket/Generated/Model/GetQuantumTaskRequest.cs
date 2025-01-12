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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the GetQuantumTask operation.
    /// Retrieves the specified quantum task.
    /// </summary>
    public partial class GetQuantumTaskRequest : AmazonBraketRequest
    {
        private List<string> _additionalAttributeNames = new List<string>();
        private string _quantumTaskArn;

        /// <summary>
        /// Gets and sets the property AdditionalAttributeNames. 
        /// <para>
        /// A list of attributes to return information for.
        /// </para>
        /// </summary>
        public List<string> AdditionalAttributeNames
        {
            get { return this._additionalAttributeNames; }
            set { this._additionalAttributeNames = value; }
        }

        // Check to see if AdditionalAttributeNames property is set
        internal bool IsSetAdditionalAttributeNames()
        {
            return this._additionalAttributeNames != null && this._additionalAttributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QuantumTaskArn. 
        /// <para>
        /// The ARN of the task to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string QuantumTaskArn
        {
            get { return this._quantumTaskArn; }
            set { this._quantumTaskArn = value; }
        }

        // Check to see if QuantumTaskArn property is set
        internal bool IsSetQuantumTaskArn()
        {
            return this._quantumTaskArn != null;
        }

    }
}