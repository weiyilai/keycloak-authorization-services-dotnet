// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\organizations\members
    /// </summary>
    public class MembersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Keycloak.AuthServices.Sdk.Kiota.Admin.admin.realms.item.organizations.members.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members.Item.MembersItemRequestBuilder"/></returns>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members.Item.MembersItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members.Item.MembersItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members.MembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/organizations/members", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Organizations.Members.MembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/organizations/members", rawUrl)
        {
        }
    }
}
