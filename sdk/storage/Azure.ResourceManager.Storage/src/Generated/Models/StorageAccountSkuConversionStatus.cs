// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> This defines the sku conversion status object for asynchronous sku conversions. </summary>
    public partial class StorageAccountSkuConversionStatus
    {
        /// <summary> Initializes a new instance of StorageAccountSkuConversionStatus. </summary>
        public StorageAccountSkuConversionStatus()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountSkuConversionStatus. </summary>
        /// <param name="skuConversionStatus"> This property indicates the current sku conversion status. </param>
        /// <param name="targetSkuName"> This property represents the target sku name to which the account sku is being converted asynchronously. </param>
        /// <param name="startOn"> This property represents the sku conversion start time. </param>
        /// <param name="endOn"> This property represents the sku conversion end time. </param>
        internal StorageAccountSkuConversionStatus(StorageAccountSkuConversionState? skuConversionStatus, StorageSkuName? targetSkuName, DateTimeOffset? startOn, DateTimeOffset? endOn)
        {
            SkuConversionStatus = skuConversionStatus;
            TargetSkuName = targetSkuName;
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> This property indicates the current sku conversion status. </summary>
        public StorageAccountSkuConversionState? SkuConversionStatus { get; }
        /// <summary> This property represents the target sku name to which the account sku is being converted asynchronously. </summary>
        public StorageSkuName? TargetSkuName { get; set; }
        /// <summary> This property represents the sku conversion start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> This property represents the sku conversion end time. </summary>
        public DateTimeOffset? EndOn { get; }
    }
}
