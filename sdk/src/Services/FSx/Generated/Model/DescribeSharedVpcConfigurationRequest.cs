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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSharedVpcConfiguration operation.
    /// Indicates whether participant accounts in your organization can create Amazon FSx
    /// for NetApp ONTAP Multi-AZ file systems in subnets that are shared by a virtual private
    /// cloud (VPC) owner. For more information, see the <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/maz-shared-vpc.html">Amazon
    /// FSx for NetApp ONTAP User Guide</a>.
    /// </summary>
    public partial class DescribeSharedVpcConfigurationRequest : AmazonFSxRequest
    {

    }
}