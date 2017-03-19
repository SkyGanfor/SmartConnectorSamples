﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Describes how a Trend will be patched.
    /// </summary>
    public partial class UpdateTrendModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateTrendModel class.
        /// </summary>
        public UpdateTrendModel() { }

        /// <summary>
        /// Initializes a new instance of the UpdateTrendModel class.
        /// </summary>
        public UpdateTrendModel(string name = default(string), string description = default(string), string parentId = default(string), string id = default(string))
        {
            Name = name;
            Description = description;
            ParentId = parentId;
            Id = id;
        }

        /// <summary>
        /// Name of the Trend.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the Trend.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Id of the Container which the Trend is found in.
        /// </summary>
        [JsonProperty(PropertyName = "ParentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// Case sensitive identifier for the entity.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

    }
}
