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
    /// TableSchemas
    /// </summary>
    [DataContract]
    public partial class TableSchemas :  IEquatable<TableSchemas>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableSchemas" /> class.
        /// </summary>
        /// <param name="Resource">An array of table definitions..</param>
        public TableSchemas(List<TableSchema> Resource = default(List<TableSchema>))
        {
            this.Resource = Resource;
        }
        
        /// <summary>
        /// An array of table definitions.
        /// </summary>
        /// <value>An array of table definitions.</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public List<TableSchema> Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableSchemas {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(obj as TableSchemas);
        }

        /// <summary>
        /// Returns true if TableSchemas instances are equal
        /// </summary>
        /// <param name="other">Instance of TableSchemas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableSchemas other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Resource == other.Resource ||
                    this.Resource != null &&
                    this.Resource.SequenceEqual(other.Resource)
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