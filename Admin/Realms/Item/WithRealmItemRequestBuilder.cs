// <auto-generated/>
#pragma warning disable CS0618
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AdminEvents;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AttackDetection;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientDescriptionConverter;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientRegistrationPolicy;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientScopes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientSessionStats;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTemplates;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTypes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientsInitialAccess;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Components;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.CredentialRegistrators;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultDefaultClientScopes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultGroups;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultOptionalClientScopes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Events;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.GroupByPath;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Keys;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Localization;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.LogoutAll;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialExport;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialImport;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PushRevocation;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Roles;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.RolesById;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Sessions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.TestSMTPConnection;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.UsersManagementPermissions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithRealmItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The adminEvents property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AdminEvents.AdminEventsRequestBuilder AdminEvents
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AdminEvents.AdminEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The attackDetection property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AttackDetection.AttackDetectionRequestBuilder AttackDetection
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AttackDetection.AttackDetectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authentication property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.AuthenticationRequestBuilder Authentication
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientDescriptionConverter property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientDescriptionConverter.ClientDescriptionConverterRequestBuilder ClientDescriptionConverter
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientDescriptionConverter.ClientDescriptionConverterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientPolicies property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.ClientPoliciesRequestBuilder ClientPolicies
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.ClientPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientRegistrationPolicy property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientRegistrationPolicy.ClientRegistrationPolicyRequestBuilder ClientRegistrationPolicy
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientRegistrationPolicy.ClientRegistrationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clients property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.ClientsRequestBuilder Clients
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.ClientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientScopes property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientScopes.ClientScopesRequestBuilder ClientScopes
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientScopes.ClientScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientSessionStats property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientSessionStats.ClientSessionStatsRequestBuilder ClientSessionStats
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientSessionStats.ClientSessionStatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientsInitialAccess property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientsInitialAccess.ClientsInitialAccessRequestBuilder ClientsInitialAccess
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientsInitialAccess.ClientsInitialAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientTemplates property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTemplates.ClientTemplatesRequestBuilder ClientTemplates
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTemplates.ClientTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientTypes property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTypes.ClientTypesRequestBuilder ClientTypes
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTypes.ClientTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The components property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Components.ComponentsRequestBuilder Components
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Components.ComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The credentialRegistrators property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.CredentialRegistrators.CredentialRegistratorsRequestBuilder CredentialRegistrators
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.CredentialRegistrators.CredentialRegistratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultDefaultClientScopes property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultDefaultClientScopes.DefaultDefaultClientScopesRequestBuilder DefaultDefaultClientScopes
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultDefaultClientScopes.DefaultDefaultClientScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultGroups property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultGroups.DefaultGroupsRequestBuilder DefaultGroups
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultGroups.DefaultGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultOptionalClientScopes property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultOptionalClientScopes.DefaultOptionalClientScopesRequestBuilder DefaultOptionalClientScopes
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultOptionalClientScopes.DefaultOptionalClientScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Events.EventsRequestBuilder Events
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupByPath property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.GroupByPath.GroupByPathRequestBuilder GroupByPath
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.GroupByPath.GroupByPathRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groups property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder Groups
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups.GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProvider property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.IdentityProviderRequestBuilder IdentityProvider
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.IdentityProviderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Keys.KeysRequestBuilder Keys
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Keys.KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The localization property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Localization.LocalizationRequestBuilder Localization
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Localization.LocalizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logoutAll property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.LogoutAll.LogoutAllRequestBuilder LogoutAll
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.LogoutAll.LogoutAllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizations property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.OrganizationsRequestBuilder Organizations
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.OrganizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The partialExport property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialExport.PartialExportRequestBuilder PartialExport
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialExport.PartialExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The partialImport property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialImport.PartialImportRequestBuilder PartialImport
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialImport.PartialImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pushRevocation property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PushRevocation.PushRevocationRequestBuilder PushRevocation
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PushRevocation.PushRevocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roles property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Roles.RolesRequestBuilder Roles
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Roles.RolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rolesById property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.RolesById.RolesByIdRequestBuilder RolesById
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.RolesById.RolesByIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sessions property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Sessions.SessionsRequestBuilder Sessions
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Sessions.SessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The testSMTPConnection property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.TestSMTPConnection.TestSMTPConnectionRequestBuilder TestSMTPConnection
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.TestSMTPConnection.TestSMTPConnectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.UsersRequestBuilder Users
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The usersManagementPermissions property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.UsersManagementPermissions.UsersManagementPermissionsRequestBuilder UsersManagementPermissions
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.UsersManagementPermissions.UsersManagementPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.WithRealmItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRealmItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.WithRealmItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRealmItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}", rawUrl)
        {
        }
        /// <summary>
        /// Delete the realm
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the top-level representation of the realm It will not include nested information like User and Client representations.
        /// </summary>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation>(requestInfo, global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PutAsync(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete the realm
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Get the top-level representation of the realm It will not include nested information like User and Client representations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.WithRealmItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.WithRealmItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.WithRealmItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
