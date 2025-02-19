// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing the StreamingJobFunction data model.
    /// A function object, containing all information associated with the named function. All functions are contained under a streaming job.
    /// </summary>
    public partial class StreamingJobFunctionData : StreamAnalyticsSubResource
    {
        /// <summary> Initializes a new instance of StreamingJobFunctionData. </summary>
        public StreamingJobFunctionData()
        {
        }

        /// <summary> Initializes a new instance of StreamingJobFunctionData. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="properties">
        /// The properties that are associated with a function.
        /// Please note <see cref="StreamingJobFunctionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateFunctionProperties"/> and <see cref="ScalarFunctionProperties"/>.
        /// </param>
        internal StreamingJobFunctionData(ResourceIdentifier id, string name, ResourceType? resourceType, StreamingJobFunctionProperties properties) : base(id, name, resourceType)
        {
            Properties = properties;
        }

        /// <summary>
        /// The properties that are associated with a function.
        /// Please note <see cref="StreamingJobFunctionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateFunctionProperties"/> and <see cref="ScalarFunctionProperties"/>.
        /// </summary>
        public StreamingJobFunctionProperties Properties { get; set; }
    }
}
