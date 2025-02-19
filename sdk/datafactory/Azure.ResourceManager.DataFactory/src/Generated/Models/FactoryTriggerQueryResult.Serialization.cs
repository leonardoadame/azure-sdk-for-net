// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class FactoryTriggerQueryResult
    {
        internal static FactoryTriggerQueryResult DeserializeFactoryTriggerQueryResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FactoryTriggerData> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<FactoryTriggerData> array = new List<FactoryTriggerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FactoryTriggerData.DeserializeFactoryTriggerData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new FactoryTriggerQueryResult(value, continuationToken.Value);
        }
    }
}
