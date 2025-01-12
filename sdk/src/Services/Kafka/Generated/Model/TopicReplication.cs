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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details about topic replication.
    /// </summary>
    public partial class TopicReplication
    {
        private bool? _copyAccessControlListsForTopics;
        private bool? _copyTopicConfigurations;
        private bool? _detectAndCopyNewTopics;
        private List<string> _topicsToExclude = new List<string>();
        private List<string> _topicsToReplicate = new List<string>();

        /// <summary>
        /// Gets and sets the property CopyAccessControlListsForTopics. 
        /// <para>
        /// Whether to periodically configure remote topic ACLs to match their corresponding upstream
        /// topics.
        /// </para>
        /// </summary>
        public bool CopyAccessControlListsForTopics
        {
            get { return this._copyAccessControlListsForTopics.GetValueOrDefault(); }
            set { this._copyAccessControlListsForTopics = value; }
        }

        // Check to see if CopyAccessControlListsForTopics property is set
        internal bool IsSetCopyAccessControlListsForTopics()
        {
            return this._copyAccessControlListsForTopics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTopicConfigurations. 
        /// <para>
        /// Whether to periodically configure remote topics to match their corresponding upstream
        /// topics.
        /// </para>
        /// </summary>
        public bool CopyTopicConfigurations
        {
            get { return this._copyTopicConfigurations.GetValueOrDefault(); }
            set { this._copyTopicConfigurations = value; }
        }

        // Check to see if CopyTopicConfigurations property is set
        internal bool IsSetCopyTopicConfigurations()
        {
            return this._copyTopicConfigurations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectAndCopyNewTopics. 
        /// <para>
        /// Whether to periodically check for new topics and partitions.
        /// </para>
        /// </summary>
        public bool DetectAndCopyNewTopics
        {
            get { return this._detectAndCopyNewTopics.GetValueOrDefault(); }
            set { this._detectAndCopyNewTopics = value; }
        }

        // Check to see if DetectAndCopyNewTopics property is set
        internal bool IsSetDetectAndCopyNewTopics()
        {
            return this._detectAndCopyNewTopics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicsToExclude. 
        /// <para>
        /// List of regular expression patterns indicating the topics that should not be replicated.
        /// </para>
        /// </summary>
        public List<string> TopicsToExclude
        {
            get { return this._topicsToExclude; }
            set { this._topicsToExclude = value; }
        }

        // Check to see if TopicsToExclude property is set
        internal bool IsSetTopicsToExclude()
        {
            return this._topicsToExclude != null && this._topicsToExclude.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TopicsToReplicate. 
        /// <para>
        /// List of regular expression patterns indicating the topics to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TopicsToReplicate
        {
            get { return this._topicsToReplicate; }
            set { this._topicsToReplicate = value; }
        }

        // Check to see if TopicsToReplicate property is set
        internal bool IsSetTopicsToReplicate()
        {
            return this._topicsToReplicate != null && this._topicsToReplicate.Count > 0; 
        }

    }
}