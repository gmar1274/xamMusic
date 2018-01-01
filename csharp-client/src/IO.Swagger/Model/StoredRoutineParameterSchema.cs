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
    /// StoredRoutineParameterSchema
    /// </summary>
    [DataContract]
    public partial class StoredRoutineParameterSchema :  IEquatable<StoredRoutineParameterSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredRoutineParameterSchema" /> class.
        /// </summary>
        /// <param name="Name">Identifier/Name for the parameter..</param>
        /// <param name="Position">Displayable singular name for the parameter..</param>
        /// <param name="ParamType">Displayable plural name for the parameter..</param>
        /// <param name="Type">The DreamFactory abstract data type for this parameter..</param>
        /// <param name="DbType">The native database type used for this parameter..</param>
        /// <param name="Length">The maximum length allowed (in characters for string, displayed for numbers)..</param>
        /// <param name="Precision">Total number of places for numbers..</param>
        /// <param name="Scale">Number of decimal places allowed for numbers..</param>
        /// <param name="_Default">Default value for this parameter..</param>
        public StoredRoutineParameterSchema(string Name = default(string), string Position = default(string), string ParamType = default(string), string Type = default(string), string DbType = default(string), int? Length = default(int?), int? Precision = default(int?), int? Scale = default(int?), string _Default = default(string))
        {
            this.Name = Name;
            this.Position = Position;
            this.ParamType = ParamType;
            this.Type = Type;
            this.DbType = DbType;
            this.Length = Length;
            this.Precision = Precision;
            this.Scale = Scale;
            this._Default = _Default;
        }
        
        /// <summary>
        /// Identifier/Name for the parameter.
        /// </summary>
        /// <value>Identifier/Name for the parameter.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Displayable singular name for the parameter.
        /// </summary>
        /// <value>Displayable singular name for the parameter.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Displayable plural name for the parameter.
        /// </summary>
        /// <value>Displayable plural name for the parameter.</value>
        [DataMember(Name="param_type", EmitDefaultValue=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// The DreamFactory abstract data type for this parameter.
        /// </summary>
        /// <value>The DreamFactory abstract data type for this parameter.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The native database type used for this parameter.
        /// </summary>
        /// <value>The native database type used for this parameter.</value>
        [DataMember(Name="db_type", EmitDefaultValue=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The maximum length allowed (in characters for string, displayed for numbers).
        /// </summary>
        /// <value>The maximum length allowed (in characters for string, displayed for numbers).</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// Total number of places for numbers.
        /// </summary>
        /// <value>Total number of places for numbers.</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public int? Precision { get; set; }

        /// <summary>
        /// Number of decimal places allowed for numbers.
        /// </summary>
        /// <value>Number of decimal places allowed for numbers.</value>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public int? Scale { get; set; }

        /// <summary>
        /// Default value for this parameter.
        /// </summary>
        /// <value>Default value for this parameter.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public string _Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredRoutineParameterSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ParamType: ").Append(ParamType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DbType: ").Append(DbType).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
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
            return this.Equals(obj as StoredRoutineParameterSchema);
        }

        /// <summary>
        /// Returns true if StoredRoutineParameterSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of StoredRoutineParameterSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredRoutineParameterSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.ParamType == other.ParamType ||
                    this.ParamType != null &&
                    this.ParamType.Equals(other.ParamType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.DbType == other.DbType ||
                    this.DbType != null &&
                    this.DbType.Equals(other.DbType)
                ) && 
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
                ) && 
                (
                    this.Precision == other.Precision ||
                    this.Precision != null &&
                    this.Precision.Equals(other.Precision)
                ) && 
                (
                    this.Scale == other.Scale ||
                    this.Scale != null &&
                    this.Scale.Equals(other.Scale)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.ParamType != null)
                    hash = hash * 59 + this.ParamType.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.DbType != null)
                    hash = hash * 59 + this.DbType.GetHashCode();
                if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();
                if (this.Precision != null)
                    hash = hash * 59 + this.Precision.GetHashCode();
                if (this.Scale != null)
                    hash = hash * 59 + this.Scale.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
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
