// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A SQL Analytics pool. </summary>
    public partial class SqlPool : TrackedResource
    {
        /// <summary> Initializes a new instance of SqlPool. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public SqlPool(string location) : base(location)
        {
            Argument.AssertNotNull(location, nameof(location));
        }

        /// <summary> Initializes a new instance of SqlPool. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="sku"> SQL pool SKU. </param>
        /// <param name="maxSizeBytes"> Maximum size in bytes. </param>
        /// <param name="collation"> Collation mode. </param>
        /// <param name="sourceDatabaseId"> Source database to create from. </param>
        /// <param name="recoverableDatabaseId"> Backup database to restore from. </param>
        /// <param name="provisioningState"> Resource state. </param>
        /// <param name="status"> Resource status. </param>
        /// <param name="restorePointInTime"> Snapshot time to restore. </param>
        /// <param name="createMode">
        /// Specifies the mode of sql pool creation.
        /// 
        /// Default: regular sql pool creation.
        /// 
        /// PointInTimeRestore: Creates a sql pool by restoring a point in time backup of an existing sql pool. sourceDatabaseId must be specified as the resource ID of the existing sql pool, and restorePointInTime must be specified.
        /// 
        /// Recovery: Creates a sql pool by a geo-replicated backup. sourceDatabaseId  must be specified as the recoverableDatabaseId to restore.
        /// 
        /// Restore: Creates a sql pool by restoring a backup of a deleted sql  pool. SourceDatabaseId should be the sql pool&apos;s original resource ID. SourceDatabaseId and sourceDatabaseDeletionDate must be specified.
        /// </param>
        /// <param name="creationDate"> Date the SQL pool was created. </param>
        internal SqlPool(string id, string name, string type, IDictionary<string, string> tags, string location, Sku sku, long? maxSizeBytes, string collation, string sourceDatabaseId, string recoverableDatabaseId, string provisioningState, string status, string restorePointInTime, CreateMode? createMode, DateTimeOffset? creationDate) : base(id, name, type, tags, location)
        {
            Sku = sku;
            MaxSizeBytes = maxSizeBytes;
            Collation = collation;
            SourceDatabaseId = sourceDatabaseId;
            RecoverableDatabaseId = recoverableDatabaseId;
            ProvisioningState = provisioningState;
            Status = status;
            RestorePointInTime = restorePointInTime;
            CreateMode = createMode;
            CreationDate = creationDate;
        }

        /// <summary> SQL pool SKU. </summary>
        public Sku Sku { get; set; }
        /// <summary> Maximum size in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> Collation mode. </summary>
        public string Collation { get; set; }
        /// <summary> Source database to create from. </summary>
        public string SourceDatabaseId { get; set; }
        /// <summary> Backup database to restore from. </summary>
        public string RecoverableDatabaseId { get; set; }
        /// <summary> Resource state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Resource status. </summary>
        public string Status { get; set; }
        /// <summary> Snapshot time to restore. </summary>
        public string RestorePointInTime { get; set; }
        /// <summary>
        /// Specifies the mode of sql pool creation.
        /// 
        /// Default: regular sql pool creation.
        /// 
        /// PointInTimeRestore: Creates a sql pool by restoring a point in time backup of an existing sql pool. sourceDatabaseId must be specified as the resource ID of the existing sql pool, and restorePointInTime must be specified.
        /// 
        /// Recovery: Creates a sql pool by a geo-replicated backup. sourceDatabaseId  must be specified as the recoverableDatabaseId to restore.
        /// 
        /// Restore: Creates a sql pool by restoring a backup of a deleted sql  pool. SourceDatabaseId should be the sql pool&apos;s original resource ID. SourceDatabaseId and sourceDatabaseDeletionDate must be specified.
        /// </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> Date the SQL pool was created. </summary>
        public DateTimeOffset? CreationDate { get; set; }
    }
}
