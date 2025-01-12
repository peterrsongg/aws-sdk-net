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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetUnfilteredTableMetadata operation.
    /// Retrieves table metadata from the Data Catalog that contains unfiltered metadata.
    /// 
    ///  
    /// <para>
    /// For IAM authorization, the public IAM action associated with this API is <c>glue:GetTable</c>.
    /// </para>
    /// </summary>
    public partial class GetUnfilteredTableMetadataRequest : AmazonGlueRequest
    {
        private AuditContext _auditContext;
        private string _catalogId;
        private string _databaseName;
        private string _name;
        private List<string> _permissions = new List<string>();
        private QuerySessionContext _querySessionContext;
        private string _region;
        private SupportedDialect _supportedDialect;
        private List<string> _supportedPermissionTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// A structure containing Lake Formation audit context information.
        /// </para>
        /// </summary>
        public AuditContext AuditContext
        {
            get { return this._auditContext; }
            set { this._auditContext = value; }
        }

        // Check to see if AuditContext property is set
        internal bool IsSetAuditContext()
        {
            return this._auditContext != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID where the table resides.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// (Required) Specifies the name of a database that contains the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// (Required) Specifies the name of a table for which you are requesting metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The Lake Formation data permissions of the caller on the table. Used to authorize
        /// the call when no view context is found.
        /// </para>
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QuerySessionContext. 
        /// <para>
        /// A structure used as a protocol between query engines and Lake Formation or Glue. Contains
        /// both a Lake Formation generated authorization identifier and information from the
        /// request's authorization context.
        /// </para>
        /// </summary>
        public QuerySessionContext QuerySessionContext
        {
            get { return this._querySessionContext; }
            set { this._querySessionContext = value; }
        }

        // Check to see if QuerySessionContext property is set
        internal bool IsSetQuerySessionContext()
        {
            return this._querySessionContext != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Specified only if the base tables belong to a different Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedDialect. 
        /// <para>
        /// A structure specifying the dialect and dialect version used by the query engine.
        /// </para>
        /// </summary>
        public SupportedDialect SupportedDialect
        {
            get { return this._supportedDialect; }
            set { this._supportedDialect = value; }
        }

        // Check to see if SupportedDialect property is set
        internal bool IsSetSupportedDialect()
        {
            return this._supportedDialect != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedPermissionTypes. 
        /// <para>
        /// (Required) A list of supported permission types. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public List<string> SupportedPermissionTypes
        {
            get { return this._supportedPermissionTypes; }
            set { this._supportedPermissionTypes = value; }
        }

        // Check to see if SupportedPermissionTypes property is set
        internal bool IsSetSupportedPermissionTypes()
        {
            return this._supportedPermissionTypes != null && this._supportedPermissionTypes.Count > 0; 
        }

    }
}