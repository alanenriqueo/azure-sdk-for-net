// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="LabUserServicefabricScheduleResource" /> and their operations.
    /// Each <see cref="LabUserServicefabricScheduleResource" /> in the collection will belong to the same instance of <see cref="ServiceFabricResource" />.
    /// To get a <see cref="LabUserServicefabricScheduleCollection" /> instance call the GetLabUserServicefabricSchedules method from an instance of <see cref="ServiceFabricResource" />.
    /// </summary>
    public partial class LabUserServicefabricScheduleCollection : ArmCollection, IEnumerable<LabUserServicefabricScheduleResource>, IAsyncEnumerable<LabUserServicefabricScheduleResource>
    {
        private readonly ClientDiagnostics _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics;
        private readonly ServiceFabricSchedulesRestOperations _labUserServicefabricScheduleServiceFabricSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabUserServicefabricScheduleCollection"/> class for mocking. </summary>
        protected LabUserServicefabricScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabUserServicefabricScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LabUserServicefabricScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", LabUserServicefabricScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LabUserServicefabricScheduleResource.ResourceType, out string labUserServicefabricScheduleServiceFabricSchedulesApiVersion);
            _labUserServicefabricScheduleServiceFabricSchedulesRestClient = new ServiceFabricSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labUserServicefabricScheduleServiceFabricSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules/{name}
        /// Operation Id: ServiceFabricSchedules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LabUserServicefabricScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, ScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _labUserServicefabricScheduleServiceFabricSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<LabUserServicefabricScheduleResource>(Response.FromValue(new LabUserServicefabricScheduleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules/{name}
        /// Operation Id: ServiceFabricSchedules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LabUserServicefabricScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string name, ScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _labUserServicefabricScheduleServiceFabricSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<LabUserServicefabricScheduleResource>(Response.FromValue(new LabUserServicefabricScheduleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules/{name}
        /// Operation Id: ServiceFabricSchedules_Get
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<LabUserServicefabricScheduleResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _labUserServicefabricScheduleServiceFabricSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabUserServicefabricScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules/{name}
        /// Operation Id: ServiceFabricSchedules_Get
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<LabUserServicefabricScheduleResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _labUserServicefabricScheduleServiceFabricSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabUserServicefabricScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List schedules in a given service fabric.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules
        /// Operation Id: ServiceFabricSchedules_List
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabUserServicefabricScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabUserServicefabricScheduleResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<LabUserServicefabricScheduleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labUserServicefabricScheduleServiceFabricSchedulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabUserServicefabricScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LabUserServicefabricScheduleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labUserServicefabricScheduleServiceFabricSchedulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabUserServicefabricScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List schedules in a given service fabric.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules
        /// Operation Id: ServiceFabricSchedules_List
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabUserServicefabricScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabUserServicefabricScheduleResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<LabUserServicefabricScheduleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labUserServicefabricScheduleServiceFabricSchedulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabUserServicefabricScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LabUserServicefabricScheduleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labUserServicefabricScheduleServiceFabricSchedulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabUserServicefabricScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules/{name}
        /// Operation Id: ServiceFabricSchedules_Get
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _labUserServicefabricScheduleServiceFabricSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{serviceFabricName}/schedules/{name}
        /// Operation Id: ServiceFabricSchedules_Get
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _labUserServicefabricScheduleServiceFabricSchedulesClientDiagnostics.CreateScope("LabUserServicefabricScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _labUserServicefabricScheduleServiceFabricSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LabUserServicefabricScheduleResource> IEnumerable<LabUserServicefabricScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LabUserServicefabricScheduleResource> IAsyncEnumerable<LabUserServicefabricScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
