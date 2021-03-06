/* 
 * Automated Music Promoter
 *
 * acba automated music promoter
 *
 * OpenAPI spec version: 2.0
 * Contact: support@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// RecordsRequest
    /// </summary>
    [DataContract]
    public partial class RecordsRequest :  IEquatable<RecordsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordsRequest" /> class.
        /// </summary>
        /// <param name="Resource">Array of records..</param>
        /// <param name="Ids">Array of record identifiers..</param>
        /// <param name="Filter">SQL or native filter to determine records where modifications will be applied..</param>
        /// <param name="_Params">Array of name-value pairs, used for parameter replacement on filters..</param>
        public RecordsRequest(List<RecordRequest> Resource = default(List<RecordRequest>), List<int?> Ids = default(List<int?>), string Filter = default(string), List<string> _Params = default(List<string>))
        {
            this.Resource = Resource;
            this.Ids = Ids;
            this.Filter = Filter;
            this._Params = _Params;
        }
        
        /// <summary>
        /// Array of records.
        /// </summary>
        /// <value>Array of records.</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public List<RecordRequest> Resource { get; set; }

        /// <summary>
        /// Array of record identifiers.
        /// </summary>
        /// <value>Array of record identifiers.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<int?> Ids { get; set; }

        /// <summary>
        /// SQL or native filter to determine records where modifications will be applied.
        /// </summary>
        /// <value>SQL or native filter to determine records where modifications will be applied.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Array of name-value pairs, used for parameter replacement on filters.
        /// </summary>
        /// <value>Array of name-value pairs, used for parameter replacement on filters.</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public List<string> _Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordsRequest {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecordsRequest);
        }

        /// <summary>
        /// Returns true if RecordsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Resource == other.Resource ||
                    this.Resource != null &&
                    this.Resource.SequenceEqual(other.Resource)
                ) && 
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.SequenceEqual(other._Params)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Resource != null)
                    hash = hash * 59 + this.Resource.GetHashCode();
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
