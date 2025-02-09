// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Common resource representation. </summary>
    public partial class Resource : WritableSubResource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal Resource(string id, string name, string type, string location, IDictionary<string, string> tags) : base(id)
        {
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
