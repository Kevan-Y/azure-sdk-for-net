// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RoleInstanceNetworkProfile
    {
        internal static RoleInstanceNetworkProfile DeserializeRoleInstanceNetworkProfile(JsonElement element)
        {
            Optional<IReadOnlyList<SubResource>> networkInterfaces = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubResource.DeserializeSubResource(item));
                    }
                    networkInterfaces = array;
                    continue;
                }
            }
            return new RoleInstanceNetworkProfile(Optional.ToList(networkInterfaces));
        }
    }
}
