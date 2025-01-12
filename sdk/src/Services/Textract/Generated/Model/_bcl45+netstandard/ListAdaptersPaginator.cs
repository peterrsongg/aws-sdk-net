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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Base class for ListAdapters paginators.
    /// </summary>
    internal sealed partial class ListAdaptersPaginator : IPaginator<ListAdaptersResponse>, IListAdaptersPaginator
    {
        private readonly IAmazonTextract _client;
        private readonly ListAdaptersRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListAdaptersResponse> Responses => new PaginatedResponse<ListAdaptersResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Adapters
        /// </summary>
        public IPaginatedEnumerable<AdapterOverview> Adapters => 
            new PaginatedResultKeyResponse<ListAdaptersResponse, AdapterOverview>(this, (i) => i.Adapters);

        internal ListAdaptersPaginator(IAmazonTextract client, ListAdaptersRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListAdaptersResponse> IPaginator<ListAdaptersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListAdaptersResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListAdapters(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListAdaptersResponse> IPaginator<ListAdaptersResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListAdaptersResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListAdaptersAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}