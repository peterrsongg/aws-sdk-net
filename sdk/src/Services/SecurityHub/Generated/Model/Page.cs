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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An occurrence of sensitive data in an Adobe Portable Document Format (PDF) file.
    /// </summary>
    public partial class Page
    {
        private Range _lineRange;
        private Range _offsetRange;
        private long? _pageNumber;

        /// <summary>
        /// Gets and sets the property LineRange. 
        /// <para>
        /// An occurrence of sensitive data detected in a non-binary text file or a Microsoft
        /// Word file. Non-binary text files include files such as HTML, XML, JSON, and TXT files.
        /// </para>
        /// </summary>
        public Range LineRange
        {
            get { return this._lineRange; }
            set { this._lineRange = value; }
        }

        // Check to see if LineRange property is set
        internal bool IsSetLineRange()
        {
            return this._lineRange != null;
        }

        /// <summary>
        /// Gets and sets the property OffsetRange. 
        /// <para>
        /// An occurrence of sensitive data detected in a binary text file.
        /// </para>
        /// </summary>
        public Range OffsetRange
        {
            get { return this._offsetRange; }
            set { this._offsetRange = value; }
        }

        // Check to see if OffsetRange property is set
        internal bool IsSetOffsetRange()
        {
            return this._offsetRange != null;
        }

        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// The page number of the page that contains the sensitive data.
        /// </para>
        /// </summary>
        public long PageNumber
        {
            get { return this._pageNumber.GetValueOrDefault(); }
            set { this._pageNumber = value; }
        }

        // Check to see if PageNumber property is set
        internal bool IsSetPageNumber()
        {
            return this._pageNumber.HasValue; 
        }

    }
}