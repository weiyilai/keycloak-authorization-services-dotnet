// <auto-generated/>
#pragma warning disable CS0618
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Count;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Item;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GroupsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The count property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Count.CountRequestBuilder Count
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Keycloak.AuthServices.Sdk.Kiota.Admin.admin.realms.item.groups.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Item.GroupItemRequestBuilder"/></returns>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Item.GroupItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("group%2Did", position);
                return new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.Item.GroupItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/groups{?briefRepresentation*,exact*,first*,max*,populateHierarchy*,q*,search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/groups{?briefRepresentation*,exact*,first*,max*,populateHierarchy*,q*,search*}", rawUrl)
        {
        }
        /// <summary>
        /// Get group hierarchy.  Only name and ids are returned.
        /// </summary>
        /// <returns>A List&lt;global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation>?> GetAsync(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation>> GetAsync(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation>(requestInfo, global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// This will update the group and set the parent if it exists. Create it and set the parent if the group doesn’t exist.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PostAsync(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get group hierarchy.  Only name and ids are returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder.GroupsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This will update the group and set the parent if it exists. Create it and set the parent if the group doesn’t exist.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.GroupRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get group hierarchy.  Only name and ids are returned.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GroupsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("briefRepresentation")]
            public bool? BriefRepresentation { get; set; }
            [QueryParameter("exact")]
            public bool? Exact { get; set; }
            [QueryParameter("first")]
            public int? First { get; set; }
            [QueryParameter("max")]
            public int? Max { get; set; }
            [QueryParameter("populateHierarchy")]
            public bool? PopulateHierarchy { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
