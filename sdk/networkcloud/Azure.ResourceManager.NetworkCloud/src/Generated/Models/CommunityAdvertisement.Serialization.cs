// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class CommunityAdvertisement : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("communities"u8);
            writer.WriteStartArray();
            foreach (var item in Communities)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("subnetPrefix"u8);
            writer.WriteStringValue(SubnetPrefix);
            writer.WriteEndObject();
        }

        internal static CommunityAdvertisement DeserializeCommunityAdvertisement(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> communities = default;
            string subnetPrefix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("communities"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    communities = array;
                    continue;
                }
                if (property.NameEquals("subnetPrefix"u8))
                {
                    subnetPrefix = property.Value.GetString();
                    continue;
                }
            }
            return new CommunityAdvertisement(communities, subnetPrefix);
        }
    }
}
