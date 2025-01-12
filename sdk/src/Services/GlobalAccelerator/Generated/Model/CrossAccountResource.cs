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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// An endpoint (Amazon Web Services resource) that is listed in a cross-account attachment
    /// and can be added to an accelerator by specified principals, that are also listed in
    /// the attachment.
    /// </summary>
    public partial class CrossAccountResource
    {
        private string _attachmentArn;
        private string _endpointId;

        /// <summary>
        /// Gets and sets the property AttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cross-account attachment that specifies the
        /// endpoints (resources) that can be added to accelerators and principals that have permission
        /// to add the endpoints to accelerators.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string AttachmentArn
        {
            get { return this._attachmentArn; }
            set { this._attachmentArn = value; }
        }

        // Check to see if AttachmentArn property is set
        internal bool IsSetAttachmentArn()
        {
            return this._attachmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The endpoint ID for the endpoint that is listed in a cross-account attachment and
        /// can be added to an accelerator by specified principals.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

    }
}