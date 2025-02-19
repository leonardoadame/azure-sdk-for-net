// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    internal partial class ArmResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _selfHelpDiagnosticDiagnosticsClientDiagnostics;
        private DiagnosticsRestOperations _selfHelpDiagnosticDiagnosticsRestClient;
        private ClientDiagnostics _discoverySolutionClientDiagnostics;
        private DiscoverySolutionRestOperations _discoverySolutionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class for mocking. </summary>
        protected ArmResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArmResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SelfHelpDiagnosticDiagnosticsClientDiagnostics => _selfHelpDiagnosticDiagnosticsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", SelfHelpDiagnosticResource.ResourceType.Namespace, Diagnostics);
        private DiagnosticsRestOperations SelfHelpDiagnosticDiagnosticsRestClient => _selfHelpDiagnosticDiagnosticsRestClient ??= new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SelfHelpDiagnosticResource.ResourceType));
        private ClientDiagnostics DiscoverySolutionClientDiagnostics => _discoverySolutionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DiscoverySolutionRestOperations DiscoverySolutionRestClient => _discoverySolutionRestClient ??= new DiscoverySolutionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SelfHelpDiagnosticResources in the ArmResource. </summary>
        /// <returns> An object representing collection of SelfHelpDiagnosticResources and their operations over a SelfHelpDiagnosticResource. </returns>
        public virtual SelfHelpDiagnosticCollection GetSelfHelpDiagnostics()
        {
            return GetCachedClient(Client => new SelfHelpDiagnosticCollection(Client, Id));
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic check.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for availability check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SelfHelpNameAvailabilityResult>> CheckSelfHelpNameAvailabilityAsync(SelfHelpNameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = SelfHelpDiagnosticDiagnosticsClientDiagnostics.CreateScope("ArmResourceExtensionClient.CheckSelfHelpNameAvailability");
            scope.Start();
            try
            {
                var response = await SelfHelpDiagnosticDiagnosticsRestClient.CheckNameAvailabilityAsync(Id, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic check.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for availability check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SelfHelpNameAvailabilityResult> CheckSelfHelpNameAvailability(SelfHelpNameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = SelfHelpDiagnosticDiagnosticsClientDiagnostics.CreateScope("ArmResourceExtensionClient.CheckSelfHelpNameAvailability");
            scope.Start();
            try
            {
                var response = SelfHelpDiagnosticDiagnosticsRestClient.CheckNameAvailability(Id, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Can be used to filter solutionIds by &apos;ProblemClassificationId&apos;. The filter supports only &apos;and&apos; and &apos;eq&apos; operators. Example: $filter=ProblemClassificationId eq &apos;1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e&apos; and ProblemClassificationId eq &apos;0a9673c2-7af6-4e19-90d3-4ee2461076d9&apos;. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SelfHelpSolutionMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SelfHelpSolutionMetadata> GetSelfHelpDiscoverySolutionsAsync(string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionRestClient.CreateListRequest(Id, filter, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiscoverySolutionRestClient.CreateListNextPageRequest(nextLink, Id, filter, skiptoken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SelfHelpSolutionMetadata.DeserializeSelfHelpSolutionMetadata, DiscoverySolutionClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetSelfHelpDiscoverySolutions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Can be used to filter solutionIds by &apos;ProblemClassificationId&apos;. The filter supports only &apos;and&apos; and &apos;eq&apos; operators. Example: $filter=ProblemClassificationId eq &apos;1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e&apos; and ProblemClassificationId eq &apos;0a9673c2-7af6-4e19-90d3-4ee2461076d9&apos;. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SelfHelpSolutionMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SelfHelpSolutionMetadata> GetSelfHelpDiscoverySolutions(string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionRestClient.CreateListRequest(Id, filter, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiscoverySolutionRestClient.CreateListNextPageRequest(nextLink, Id, filter, skiptoken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SelfHelpSolutionMetadata.DeserializeSelfHelpSolutionMetadata, DiscoverySolutionClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetSelfHelpDiscoverySolutions", "value", "nextLink", cancellationToken);
        }
    }
}
