﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Notifications operations.
    /// </summary>
    public partial interface INotifications
    {
        /// <summary>
        /// Creates a new Notification and returns it.
        /// </summary>
        /// <param name='newItem'>
        /// Definition of how the Notification will be created.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<NotificationModel>> CreateWithHttpMessagesAsync(NewNotificationModel newItem, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all Notification which fit the filter criteria supplied.
        /// All filter parameters are optional. Notification will be ordered
        /// and paged as requested.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Return only Notification with this SubscriptionId value.
        /// </param>
        /// <param name='orderBy'>
        /// Notification will be returned in this order.  CreatedOnAscending
        /// by default. Possible values include: 'CreatedOnAscending',
        /// 'CreatedOnDescending'
        /// </param>
        /// <param name='take'>
        /// Number of Notification that should be returned.  200 by default.
        /// </param>
        /// <param name='skip'>
        /// Number of Notification that should be skipped before items are
        /// returned.  0 by default.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<NotificationModel>>> RetrieveWithHttpMessagesAsync(string subscriptionId = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Notification with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Notification requested.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<NotificationModel>> RetrieveByIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the CreatedOn property for the Notification with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Notification whose CreatedOn property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveCreatedOnWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns NotificationItem for the Notification with the Id
        /// provided.
        /// Sort Order for the returned items depends on Subscription Type.
        /// For ValueItemChanged and HierarchyChanged, the sort order is by
        /// ChangedAt.  For AlarmEventChanged, the sort order is by
        /// ChangedItemId.
        /// </summary>
        /// <param name='id'>
        /// Id of the Notification whose items are to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='take'>
        /// Number of NotificationItems that should be returned.  200 by
        /// default.
        /// </param>
        /// <param name='skip'>
        /// Number of NotificationItems that should be skipped before items
        /// are returned.  0 by default.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<NotificationItemModel>>> RetrieveNotificationsWithHttpMessagesAsync(string id, int? take = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Subscription for the Notification with the Id supplied.
        /// </summary>
        /// <param name='id'>
        /// Id of the Notification whose Subscription is to be returned.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SubscriptionModel>> RetrieveSubscriptionWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the SubscriptionId property for the Notification with the
        /// Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Notification whose SubscriptionId property is to be
        /// returned.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveSubscriptionIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the Notification with the Id provided.  All
        /// NotificationItems will also be deleted.
        /// </summary>
        /// <param name='id'>
        /// Id of the Notification to be deleted.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}