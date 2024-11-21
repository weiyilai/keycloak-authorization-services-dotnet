// <auto-generated/>
#pragma warning disable CS0618
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Evaluate;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Providers;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Search;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\clients\{client-uuid}\authz\resource-server\permission
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PermissionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The evaluate property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Evaluate.EvaluateRequestBuilder Evaluate
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Evaluate.EvaluateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The providers property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Providers.ProvidersRequestBuilder Providers
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Providers.ProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Search.SearchRequestBuilder Search
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/clients/{client%2Duuid}/authz/resource-server/permission{?fields*,first*,max*,name*,owner*,permission*,policyId*,resource*,scope*,type*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/clients/{client%2Duuid}/authz/resource-server/permission{?fields*,first*,max*,name*,owner*,permission*,policyId*,resource*,scope*,type*}", rawUrl)
        {
        }
        /// <returns>A List&lt;global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AbstractPolicyRepresentation&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AbstractPolicyRepresentation>?> GetAsync(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder.PermissionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AbstractPolicyRepresentation>> GetAsync(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder.PermissionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AbstractPolicyRepresentation>(requestInfo, global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AbstractPolicyRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(string body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(string body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            if(string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder.PermissionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder.PermissionRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(string body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(string body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            if(string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromScalar(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.Authz.ResourceServer.Permission.PermissionRequestBuilder(rawUrl, RequestAdapter);
        }
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        #pragma warning disable CS1591
        public partial class PermissionRequestBuilderGetQueryParameters 
        #pragma warning restore CS1591
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
            [QueryParameter("first")]
            public int? First { get; set; }
            [QueryParameter("max")]
            public int? Max { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("owner")]
            public string? Owner { get; set; }
#nullable restore
#else
            [QueryParameter("owner")]
            public string Owner { get; set; }
#endif
            [QueryParameter("permission")]
            public bool? Permission { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("policyId")]
            public string? PolicyId { get; set; }
#nullable restore
#else
            [QueryParameter("policyId")]
            public string PolicyId { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("resource")]
            public string? Resource { get; set; }
#nullable restore
#else
            [QueryParameter("resource")]
            public string Resource { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("scope")]
            public string? Scope { get; set; }
#nullable restore
#else
            [QueryParameter("scope")]
            public string Scope { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
