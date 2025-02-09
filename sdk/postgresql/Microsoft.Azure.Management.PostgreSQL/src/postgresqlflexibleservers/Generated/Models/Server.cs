// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Server : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The Azure Active Directory identity of the
        /// server.</param>
        /// <param name="sku">The SKU (pricing tier) of the server.</param>
        /// <param name="administratorLogin">The administrator's login name of
        /// a server. Can only be specified when the server is being created
        /// (and is required for creation).</param>
        /// <param name="administratorLoginPassword">The administrator login
        /// password (required for server creation).</param>
        /// <param name="version">PostgreSQL Server version. Possible values
        /// include: '13', '12', '11'</param>
        /// <param name="minorVersion">The minor version of the server.</param>
        /// <param name="state">A state of a server that is visible to user.
        /// Possible values include: 'Ready', 'Dropping', 'Disabled',
        /// 'Starting', 'Stopping', 'Stopped', 'Updating'</param>
        /// <param name="fullyQualifiedDomainName">The fully qualified domain
        /// name of a server.</param>
        /// <param name="storage">Storage properties of a server.</param>
        /// <param name="backup">Backup properties of a server.</param>
        /// <param name="network">Network properties of a server.</param>
        /// <param name="highAvailability">High availability properties of a
        /// server.</param>
        /// <param name="maintenanceWindow">Maintenance window properties of a
        /// server.</param>
        /// <param name="sourceServerResourceId">The source server resource ID
        /// to restore from. It's required when 'createMode' is
        /// 'PointInTimeRestore'.</param>
        /// <param name="pointInTimeUTC">Restore point creation time (ISO8601
        /// format), specifying the time to restore from. It's required when
        /// 'createMode' is 'PointInTimeRestore'.</param>
        /// <param name="availabilityZone">availability zone information of the
        /// server.</param>
        /// <param name="createMode">The mode to create a new PostgreSQL
        /// server. Possible values include: 'Default', 'Create', 'Update',
        /// 'PointInTimeRestore'</param>
        /// <param name="serverTags">Application-specific metadata in the form
        /// of key-value pairs.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        public Server(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity), Sku sku = default(Sku), string administratorLogin = default(string), string administratorLoginPassword = default(string), string version = default(string), string minorVersion = default(string), string state = default(string), string fullyQualifiedDomainName = default(string), Storage storage = default(Storage), Backup backup = default(Backup), Network network = default(Network), HighAvailability highAvailability = default(HighAvailability), MaintenanceWindow maintenanceWindow = default(MaintenanceWindow), string sourceServerResourceId = default(string), System.DateTime? pointInTimeUTC = default(System.DateTime?), string availabilityZone = default(string), string createMode = default(string), IDictionary<string, string> serverTags = default(IDictionary<string, string>), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            Sku = sku;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            MinorVersion = minorVersion;
            State = state;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            Storage = storage;
            Backup = backup;
            Network = network;
            HighAvailability = highAvailability;
            MaintenanceWindow = maintenanceWindow;
            SourceServerResourceId = sourceServerResourceId;
            PointInTimeUTC = pointInTimeUTC;
            AvailabilityZone = availabilityZone;
            CreateMode = createMode;
            ServerTags = serverTags;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory identity of the server.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets the SKU (pricing tier) of the server.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the administrator's login name of a server. Can only
        /// be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the administrator login password (required for server
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets postgreSQL Server version. Possible values include:
        /// '13', '12', '11'
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets the minor version of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minorVersion")]
        public string MinorVersion { get; private set; }

        /// <summary>
        /// Gets a state of a server that is visible to user. Possible values
        /// include: 'Ready', 'Dropping', 'Disabled', 'Starting', 'Stopping',
        /// 'Stopped', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain name of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets or sets storage properties of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storage")]
        public Storage Storage { get; set; }

        /// <summary>
        /// Gets or sets backup properties of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backup")]
        public Backup Backup { get; set; }

        /// <summary>
        /// Gets or sets network properties of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.network")]
        public Network Network { get; set; }

        /// <summary>
        /// Gets or sets high availability properties of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.highAvailability")]
        public HighAvailability HighAvailability { get; set; }

        /// <summary>
        /// Gets or sets maintenance window properties of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Gets or sets the source server resource ID to restore from. It's
        /// required when 'createMode' is 'PointInTimeRestore'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceServerResourceId")]
        public string SourceServerResourceId { get; set; }

        /// <summary>
        /// Gets or sets restore point creation time (ISO8601 format),
        /// specifying the time to restore from. It's required when
        /// 'createMode' is 'PointInTimeRestore'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pointInTimeUTC")]
        public System.DateTime? PointInTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets availability zone information of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilityZone")]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the mode to create a new PostgreSQL server. Possible
        /// values include: 'Default', 'Create', 'Update', 'PointInTimeRestore'
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> ServerTags { get; set; }

        /// <summary>
        /// Gets the system metadata relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
