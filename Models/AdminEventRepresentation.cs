// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AdminEventRepresentation : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The authDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AuthDetailsRepresentation? AuthDetails { get; set; }
#nullable restore
#else
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AuthDetailsRepresentation AuthDetails { get; set; }
#endif
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Error { get; set; }
#nullable restore
#else
        public string Error { get; set; }
#endif
        /// <summary>The operationType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperationType { get; set; }
#nullable restore
#else
        public string OperationType { get; set; }
#endif
        /// <summary>The realmId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RealmId { get; set; }
#nullable restore
#else
        public string RealmId { get; set; }
#endif
        /// <summary>The representation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Representation { get; set; }
#nullable restore
#else
        public string Representation { get; set; }
#endif
        /// <summary>The resourcePath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourcePath { get; set; }
#nullable restore
#else
        public string ResourcePath { get; set; }
#endif
        /// <summary>The resourceType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType { get; set; }
#nullable restore
#else
        public string ResourceType { get; set; }
#endif
        /// <summary>The time property</summary>
        public long? Time { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AdminEventRepresentation"/> and sets the default values.
        /// </summary>
        public AdminEventRepresentation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AdminEventRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AdminEventRepresentation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AdminEventRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authDetails", n => { AuthDetails = n.GetObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AuthDetailsRepresentation>(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AuthDetailsRepresentation.CreateFromDiscriminatorValue); } },
                { "error", n => { Error = n.GetStringValue(); } },
                { "operationType", n => { OperationType = n.GetStringValue(); } },
                { "realmId", n => { RealmId = n.GetStringValue(); } },
                { "representation", n => { Representation = n.GetStringValue(); } },
                { "resourcePath", n => { ResourcePath = n.GetStringValue(); } },
                { "resourceType", n => { ResourceType = n.GetStringValue(); } },
                { "time", n => { Time = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.AuthDetailsRepresentation>("authDetails", AuthDetails);
            writer.WriteStringValue("error", Error);
            writer.WriteStringValue("operationType", OperationType);
            writer.WriteStringValue("realmId", RealmId);
            writer.WriteStringValue("representation", Representation);
            writer.WriteStringValue("resourcePath", ResourcePath);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteLongValue("time", Time);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
