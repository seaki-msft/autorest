namespace Fixtures.Azure.SwaggerBatResourceFlattening
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using System.Linq;
    using Microsoft.Azure;
    using Models;

    /// <summary>
    /// Resource Flattening for AutoRest
    /// </summary>
    public partial interface IAutoRestResourceFlatteningTestService
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }        

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription.
        /// </summary>
        SubscriptionCloudCredentials Credentials { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout for Long Running Operations.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }


        /// <summary>
        /// Put External Resource as an Array
        /// </summary>
        /// <param name='resourceArray'>
        /// External Resource as an Array to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>        
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PutArrayWithHttpMessagesAsync(IList<Resource> resourceArray = default(IList<Resource>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get External Resource as an Array
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>        
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<FlattenedProduct>>> GetArrayWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Put External Resource as a Dictionary
        /// </summary>
        /// <param name='resourceDictionary'>
        /// External Resource as a Dictionary to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>        
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PutDictionaryWithHttpMessagesAsync(IDictionary<string, FlattenedProduct> resourceDictionary = default(IDictionary<string, FlattenedProduct>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get External Resource as a Dictionary
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>        
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IDictionary<string, FlattenedProduct>>> GetDictionaryWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Put External Resource as a ResourceCollection
        /// </summary>
        /// <param name='resourceComplexObject'>
        /// External Resource as a ResourceCollection to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>        
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PutResourceCollectionWithHttpMessagesAsync(ResourceCollection resourceComplexObject = default(ResourceCollection), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get External Resource as a ResourceCollection
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>        
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceCollection>> GetResourceCollectionWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
