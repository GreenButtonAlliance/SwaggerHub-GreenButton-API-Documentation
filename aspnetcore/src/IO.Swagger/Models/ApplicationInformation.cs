/*
 * Green Button Resource Server API Documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * Contact: dcoffin@greenbuttonalliance.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApplicationInformation : IEquatable<ApplicationInformation>
    { 
        /// <summary>
        /// Data Custodian Id
        /// </summary>
        /// <value>Data Custodian Id</value>
        [Required]
        [DataMember(Name="dataCustodianId")]
        public string DataCustodianId { get; set; }

        /// <summary>
        /// Code indicating the current status of the Data Custodian application
        /// </summary>
        /// <value>Code indicating the current status of the Data Custodian application</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DataCustodianApplicationStatusEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 0,
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 1,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 2,
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 3        }

        /// <summary>
        /// Code indicating the current status of the Data Custodian application
        /// </summary>
        /// <value>Code indicating the current status of the Data Custodian application</value>
        [Required]
        [DataMember(Name="dataCustodianApplicationStatus")]
        public DataCustodianApplicationStatusEnum? DataCustodianApplicationStatus { get; set; }

        /// <summary>
        /// Description of the Third Party application
        /// </summary>
        /// <value>Description of the Third Party application</value>
        [DataMember(Name="thirdPartyApplicationDescription")]
        public string ThirdPartyApplicationDescription { get; set; }

        /// <summary>
        /// Code indicating the current status of the Third Party application
        /// </summary>
        /// <value>Code indicating the current status of the Third Party application</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ThirdPartyApplicationStatusEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 0,
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 1,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 2,
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 3        }

        /// <summary>
        /// Code indicating the current status of the Third Party application
        /// </summary>
        /// <value>Code indicating the current status of the Third Party application</value>
        [DataMember(Name="thirdPartyApplicationStatus")]
        public ThirdPartyApplicationStatusEnum? ThirdPartyApplicationStatus { get; set; }

        /// <summary>
        /// Code indicating the Third Party application type
        /// </summary>
        /// <value>Code indicating the Third Party application type</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ThirdPartyApplicationTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 0,
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 1,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 2,
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 3        }

        /// <summary>
        /// Code indicating the Third Party application type
        /// </summary>
        /// <value>Code indicating the Third Party application type</value>
        [DataMember(Name="thirdPartyApplicationType")]
        public ThirdPartyApplicationTypeEnum? ThirdPartyApplicationType { get; set; }

        /// <summary>
        /// Code indicating the expected use of the Third Party application
        /// </summary>
        /// <value>Code indicating the expected use of the Third Party application</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ThirdPartyApplicationUseEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 0,
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 1,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 2,
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 3,
            /// <summary>
            /// Enum NUMBER_5 for 5
            /// </summary>
            [EnumMember(Value = "5")]
            NUMBER_5 = 4        }

        /// <summary>
        /// Code indicating the expected use of the Third Party application
        /// </summary>
        /// <value>Code indicating the expected use of the Third Party application</value>
        [DataMember(Name="thirdPartyApplicationUse")]
        public ThirdPartyApplicationUseEnum? ThirdPartyApplicationUse { get; set; }

        /// <summary>
        /// Third Party Application Technical Support phone number
        /// </summary>
        /// <value>Third Party Application Technical Support phone number</value>
        [DataMember(Name="thirdPartyPhone")]
        public string ThirdPartyPhone { get; set; }

        /// <summary>
        /// Base URI of the OAuth 2.0 Authorization Server
        /// </summary>
        /// <value>Base URI of the OAuth 2.0 Authorization Server</value>
        [DataMember(Name="authorizationServerUri")]
        public string AuthorizationServerUri { get; set; }

        /// <summary>
        /// URI value used to notify the Third Party application the Data Custodian has data available
        /// </summary>
        /// <value>URI value used to notify the Third Party application the Data Custodian has data available</value>
        [Required]
        [DataMember(Name="thirdPartyNotifyUri")]
        public string ThirdPartyNotifyUri { get; set; }

        /// <summary>
        /// OAuth 2.0 Authorization Server&#x27;s Authorization Endpoint
        /// </summary>
        /// <value>OAuth 2.0 Authorization Server&#x27;s Authorization Endpoint</value>
        [Required]
        [DataMember(Name="authorizationServerAuthorizationEndpoint")]
        public string AuthorizationServerAuthorizationEndpoint { get; set; }

        /// <summary>
        /// OAuth 2.0 Authorization Server&#x27;s Dynamic Client Registration Endpoint
        /// </summary>
        /// <value>OAuth 2.0 Authorization Server&#x27;s Dynamic Client Registration Endpoint</value>
        [DataMember(Name="authorizationServerRegistrationEndpoint")]
        public string AuthorizationServerRegistrationEndpoint { get; set; }

        /// <summary>
        /// OAuth 2.0 Authorization Server&#x27;s Token Endpoint
        /// </summary>
        /// <value>OAuth 2.0 Authorization Server&#x27;s Token Endpoint</value>
        [Required]
        [DataMember(Name="authorizationServerTokenEndpoint")]
        public string AuthorizationServerTokenEndpoint { get; set; }

        /// <summary>
        /// URI used by the Data Custodian to support Bulk API Request
        /// </summary>
        /// <value>URI used by the Data Custodian to support Bulk API Request</value>
        [Required]
        [DataMember(Name="dataCustodianBulkRequestURI")]
        public string DataCustodianBulkRequestURI { get; set; }

        /// <summary>
        /// Base value of Data Custodian Resource API URIs
        /// </summary>
        /// <value>Base value of Data Custodian Resource API URIs</value>
        [Required]
        [DataMember(Name="dataCustodianResourceEndpoint")]
        public string DataCustodianResourceEndpoint { get; set; }

        /// <summary>
        /// \\[DEPRECATED\\] URI of the Third Party&#x27;s Scope Selection API used by Data Custodian Applications to initiate OAuth 2.0 Authorization Code Request
        /// </summary>
        /// <value>\\[DEPRECATED\\] URI of the Third Party&#x27;s Scope Selection API used by Data Custodian Applications to initiate OAuth 2.0 Authorization Code Request</value>
        [DataMember(Name="thirdPartyScopeSelectionURI")]
        public string ThirdPartyScopeSelectionURI { get; set; }

        /// <summary>
        /// URI of the Third Party Application&#x27;s starting screen
        /// </summary>
        /// <value>URI of the Third Party Application&#x27;s starting screen</value>
        [DataMember(Name="thirdPartyUserPortalScreenURI")]
        public string ThirdPartyUserPortalScreenURI { get; set; }

        /// <summary>
        /// OAuth 2.0 assigned **secret** provided by the Data Custodian during the Third Party Application registration process.
        /// </summary>
        /// <value>OAuth 2.0 assigned **secret** provided by the Data Custodian during the Third Party Application registration process.</value>
        [Required]
        [DataMember(Name="client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// URI of Third Party logo
        /// </summary>
        /// <value>URI of Third Party logo</value>
        [DataMember(Name="logo_uri")]
        public string LogoUri { get; set; }

        /// <summary>
        /// The name of the registered Third Party Application
        /// </summary>
        /// <value>The name of the registered Third Party Application</value>
        [Required]
        [DataMember(Name="client_name")]
        public string ClientName { get; set; }

        /// <summary>
        /// URI of the Third Party Application&#x27;s starting screen
        /// </summary>
        /// <value>URI of the Third Party Application&#x27;s starting screen</value>
        [DataMember(Name="client_uri")]
        public string ClientUri { get; set; }

        /// <summary>
        /// Third Party Application&#x27;s default OAuth 2.0 **Authorization Code** Request redirect_uri parameter value
        /// </summary>
        /// <value>Third Party Application&#x27;s default OAuth 2.0 **Authorization Code** Request redirect_uri parameter value</value>
        [Required]
        [DataMember(Name="redirect_uri")]
        public List<string> RedirectUri { get; set; }

        /// <summary>
        /// Third Party Application Unique Identifier provided by the Data Custodian during the Third Party Application registration process.
        /// </summary>
        /// <value>Third Party Application Unique Identifier provided by the Data Custodian during the Third Party Application registration process.</value>
        [Required]
        [DataMember(Name="client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInformation {\n");
            sb.Append("  DataCustodianId: ").Append(DataCustodianId).Append("\n");
            sb.Append("  DataCustodianApplicationStatus: ").Append(DataCustodianApplicationStatus).Append("\n");
            sb.Append("  ThirdPartyApplicationDescription: ").Append(ThirdPartyApplicationDescription).Append("\n");
            sb.Append("  ThirdPartyApplicationStatus: ").Append(ThirdPartyApplicationStatus).Append("\n");
            sb.Append("  ThirdPartyApplicationType: ").Append(ThirdPartyApplicationType).Append("\n");
            sb.Append("  ThirdPartyApplicationUse: ").Append(ThirdPartyApplicationUse).Append("\n");
            sb.Append("  ThirdPartyPhone: ").Append(ThirdPartyPhone).Append("\n");
            sb.Append("  AuthorizationServerUri: ").Append(AuthorizationServerUri).Append("\n");
            sb.Append("  ThirdPartyNotifyUri: ").Append(ThirdPartyNotifyUri).Append("\n");
            sb.Append("  AuthorizationServerAuthorizationEndpoint: ").Append(AuthorizationServerAuthorizationEndpoint).Append("\n");
            sb.Append("  AuthorizationServerRegistrationEndpoint: ").Append(AuthorizationServerRegistrationEndpoint).Append("\n");
            sb.Append("  AuthorizationServerTokenEndpoint: ").Append(AuthorizationServerTokenEndpoint).Append("\n");
            sb.Append("  DataCustodianBulkRequestURI: ").Append(DataCustodianBulkRequestURI).Append("\n");
            sb.Append("  DataCustodianResourceEndpoint: ").Append(DataCustodianResourceEndpoint).Append("\n");
            sb.Append("  ThirdPartyScopeSelectionURI: ").Append(ThirdPartyScopeSelectionURI).Append("\n");
            sb.Append("  ThirdPartyUserPortalScreenURI: ").Append(ThirdPartyUserPortalScreenURI).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  LogoUri: ").Append(LogoUri).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  ClientUri: ").Append(ClientUri).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ApplicationInformation)obj);
        }

        /// <summary>
        /// Returns true if ApplicationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInformation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DataCustodianId == other.DataCustodianId ||
                    DataCustodianId != null &&
                    DataCustodianId.Equals(other.DataCustodianId)
                ) && 
                (
                    DataCustodianApplicationStatus == other.DataCustodianApplicationStatus ||
                    DataCustodianApplicationStatus != null &&
                    DataCustodianApplicationStatus.Equals(other.DataCustodianApplicationStatus)
                ) && 
                (
                    ThirdPartyApplicationDescription == other.ThirdPartyApplicationDescription ||
                    ThirdPartyApplicationDescription != null &&
                    ThirdPartyApplicationDescription.Equals(other.ThirdPartyApplicationDescription)
                ) && 
                (
                    ThirdPartyApplicationStatus == other.ThirdPartyApplicationStatus ||
                    ThirdPartyApplicationStatus != null &&
                    ThirdPartyApplicationStatus.Equals(other.ThirdPartyApplicationStatus)
                ) && 
                (
                    ThirdPartyApplicationType == other.ThirdPartyApplicationType ||
                    ThirdPartyApplicationType != null &&
                    ThirdPartyApplicationType.Equals(other.ThirdPartyApplicationType)
                ) && 
                (
                    ThirdPartyApplicationUse == other.ThirdPartyApplicationUse ||
                    ThirdPartyApplicationUse != null &&
                    ThirdPartyApplicationUse.Equals(other.ThirdPartyApplicationUse)
                ) && 
                (
                    ThirdPartyPhone == other.ThirdPartyPhone ||
                    ThirdPartyPhone != null &&
                    ThirdPartyPhone.Equals(other.ThirdPartyPhone)
                ) && 
                (
                    AuthorizationServerUri == other.AuthorizationServerUri ||
                    AuthorizationServerUri != null &&
                    AuthorizationServerUri.Equals(other.AuthorizationServerUri)
                ) && 
                (
                    ThirdPartyNotifyUri == other.ThirdPartyNotifyUri ||
                    ThirdPartyNotifyUri != null &&
                    ThirdPartyNotifyUri.Equals(other.ThirdPartyNotifyUri)
                ) && 
                (
                    AuthorizationServerAuthorizationEndpoint == other.AuthorizationServerAuthorizationEndpoint ||
                    AuthorizationServerAuthorizationEndpoint != null &&
                    AuthorizationServerAuthorizationEndpoint.Equals(other.AuthorizationServerAuthorizationEndpoint)
                ) && 
                (
                    AuthorizationServerRegistrationEndpoint == other.AuthorizationServerRegistrationEndpoint ||
                    AuthorizationServerRegistrationEndpoint != null &&
                    AuthorizationServerRegistrationEndpoint.Equals(other.AuthorizationServerRegistrationEndpoint)
                ) && 
                (
                    AuthorizationServerTokenEndpoint == other.AuthorizationServerTokenEndpoint ||
                    AuthorizationServerTokenEndpoint != null &&
                    AuthorizationServerTokenEndpoint.Equals(other.AuthorizationServerTokenEndpoint)
                ) && 
                (
                    DataCustodianBulkRequestURI == other.DataCustodianBulkRequestURI ||
                    DataCustodianBulkRequestURI != null &&
                    DataCustodianBulkRequestURI.Equals(other.DataCustodianBulkRequestURI)
                ) && 
                (
                    DataCustodianResourceEndpoint == other.DataCustodianResourceEndpoint ||
                    DataCustodianResourceEndpoint != null &&
                    DataCustodianResourceEndpoint.Equals(other.DataCustodianResourceEndpoint)
                ) && 
                (
                    ThirdPartyScopeSelectionURI == other.ThirdPartyScopeSelectionURI ||
                    ThirdPartyScopeSelectionURI != null &&
                    ThirdPartyScopeSelectionURI.Equals(other.ThirdPartyScopeSelectionURI)
                ) && 
                (
                    ThirdPartyUserPortalScreenURI == other.ThirdPartyUserPortalScreenURI ||
                    ThirdPartyUserPortalScreenURI != null &&
                    ThirdPartyUserPortalScreenURI.Equals(other.ThirdPartyUserPortalScreenURI)
                ) && 
                (
                    ClientSecret == other.ClientSecret ||
                    ClientSecret != null &&
                    ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    LogoUri == other.LogoUri ||
                    LogoUri != null &&
                    LogoUri.Equals(other.LogoUri)
                ) && 
                (
                    ClientName == other.ClientName ||
                    ClientName != null &&
                    ClientName.Equals(other.ClientName)
                ) && 
                (
                    ClientUri == other.ClientUri ||
                    ClientUri != null &&
                    ClientUri.Equals(other.ClientUri)
                ) && 
                (
                    RedirectUri == other.RedirectUri ||
                    RedirectUri != null &&
                    RedirectUri.SequenceEqual(other.RedirectUri)
                ) && 
                (
                    ClientId == other.ClientId ||
                    ClientId != null &&
                    ClientId.Equals(other.ClientId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (DataCustodianId != null)
                    hashCode = hashCode * 59 + DataCustodianId.GetHashCode();
                    if (DataCustodianApplicationStatus != null)
                    hashCode = hashCode * 59 + DataCustodianApplicationStatus.GetHashCode();
                    if (ThirdPartyApplicationDescription != null)
                    hashCode = hashCode * 59 + ThirdPartyApplicationDescription.GetHashCode();
                    if (ThirdPartyApplicationStatus != null)
                    hashCode = hashCode * 59 + ThirdPartyApplicationStatus.GetHashCode();
                    if (ThirdPartyApplicationType != null)
                    hashCode = hashCode * 59 + ThirdPartyApplicationType.GetHashCode();
                    if (ThirdPartyApplicationUse != null)
                    hashCode = hashCode * 59 + ThirdPartyApplicationUse.GetHashCode();
                    if (ThirdPartyPhone != null)
                    hashCode = hashCode * 59 + ThirdPartyPhone.GetHashCode();
                    if (AuthorizationServerUri != null)
                    hashCode = hashCode * 59 + AuthorizationServerUri.GetHashCode();
                    if (ThirdPartyNotifyUri != null)
                    hashCode = hashCode * 59 + ThirdPartyNotifyUri.GetHashCode();
                    if (AuthorizationServerAuthorizationEndpoint != null)
                    hashCode = hashCode * 59 + AuthorizationServerAuthorizationEndpoint.GetHashCode();
                    if (AuthorizationServerRegistrationEndpoint != null)
                    hashCode = hashCode * 59 + AuthorizationServerRegistrationEndpoint.GetHashCode();
                    if (AuthorizationServerTokenEndpoint != null)
                    hashCode = hashCode * 59 + AuthorizationServerTokenEndpoint.GetHashCode();
                    if (DataCustodianBulkRequestURI != null)
                    hashCode = hashCode * 59 + DataCustodianBulkRequestURI.GetHashCode();
                    if (DataCustodianResourceEndpoint != null)
                    hashCode = hashCode * 59 + DataCustodianResourceEndpoint.GetHashCode();
                    if (ThirdPartyScopeSelectionURI != null)
                    hashCode = hashCode * 59 + ThirdPartyScopeSelectionURI.GetHashCode();
                    if (ThirdPartyUserPortalScreenURI != null)
                    hashCode = hashCode * 59 + ThirdPartyUserPortalScreenURI.GetHashCode();
                    if (ClientSecret != null)
                    hashCode = hashCode * 59 + ClientSecret.GetHashCode();
                    if (LogoUri != null)
                    hashCode = hashCode * 59 + LogoUri.GetHashCode();
                    if (ClientName != null)
                    hashCode = hashCode * 59 + ClientName.GetHashCode();
                    if (ClientUri != null)
                    hashCode = hashCode * 59 + ClientUri.GetHashCode();
                    if (RedirectUri != null)
                    hashCode = hashCode * 59 + RedirectUri.GetHashCode();
                    if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApplicationInformation left, ApplicationInformation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApplicationInformation left, ApplicationInformation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
