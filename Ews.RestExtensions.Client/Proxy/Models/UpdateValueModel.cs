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
    /// Describes how a Value will be patched.
    /// </summary>
    public partial class UpdateValueModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateValueModel class.
        /// </summary>
        public UpdateValueModel() { }

        /// <summary>
        /// Initializes a new instance of the UpdateValueModel class.
        /// </summary>
        public UpdateValueModel(string name = default(string), string description = default(string), string type = default(string), string writeable = default(string), string forceable = default(string), string state = default(string), string unit = default(string), string value = default(string), string parentId = default(string), string id = default(string))
        {
            Name = name;
            Description = description;
            Type = type;
            Writeable = writeable;
            Forceable = forceable;
            State = state;
            Unit = unit;
            Value = value;
            ParentId = parentId;
            Id = id;
        }

        /// <summary>
        /// Name of the Value.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the Value.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Implied type of the Values value property. Possible values
        /// include: 'DateTime', 'Boolean', 'String', 'Double', 'Long',
        /// 'Integer', 'Duration'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Set restrictions for the Value. Possible values include:
        /// 'ReadOnly', 'Writeable'
        /// </summary>
        [JsonProperty(PropertyName = "Writeable")]
        public string Writeable { get; set; }

        /// <summary>
        /// Force restrictions for the Value. Possible values include:
        /// 'NotForceable', 'Forceable'
        /// </summary>
        [JsonProperty(PropertyName = "Forceable")]
        public string Forceable { get; set; }

        /// <summary>
        /// Validity of the Value. Possible values include: 'Good',
        /// 'Uncertain', 'Forced', 'Offline', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// Unit of the Value.
        /// </summary>
        [JsonProperty(PropertyName = "Unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Actual value of the Value.  This is always represented as a string
        /// regardless of Type.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// Id of the Container which the Value is found in.
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
