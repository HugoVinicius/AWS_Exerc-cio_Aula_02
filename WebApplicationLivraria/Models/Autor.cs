/*
 * API Livraria Virtual - Hugo Vinicius
 *
 * API para manutenção da Livraria Vitual
 *
 * OpenAPI spec version: 1.0.0
 * Contact: hugo.desenvolvimento@outlook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplicationLivraria.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Autor : IEquatable<Autor>
    { 
        /// <summary>
        /// Gets or Sets IdAutor
        /// </summary>
        [Required]
        [DataMember(Name="idAutor")]
        public int? IdAutor { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [Required]
        [DataMember(Name="descricao")]
        public string Descricao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Autor {\n");
            sb.Append("  IdAutor: ").Append(IdAutor).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Autor)obj);
        }

        /// <summary>
        /// Returns true if Autor instances are equal
        /// </summary>
        /// <param name="other">Instance of Autor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Autor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdAutor == other.IdAutor ||
                    IdAutor != null &&
                    IdAutor.Equals(other.IdAutor)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Descricao == other.Descricao ||
                    Descricao != null &&
                    Descricao.Equals(other.Descricao)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (IdAutor != null)
                    hashCode = hashCode * 59 + IdAutor.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Descricao != null)
                    hashCode = hashCode * 59 + Descricao.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Autor left, Autor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Autor left, Autor right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
