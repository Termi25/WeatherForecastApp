/* 
 * Weather API
 *
 *  # Introduction  WeatherAPI.com provides access to weather and geo data via a JSON/XML restful API. It allows developers to create desktop, web and mobile applications using this data very easy.   We provide following data through our API:    * Real-time weather<br />    * 14 day weather forecast<br />    * Astronomy<br />    * Time zone<br />    * Location data<br />    * Search or Autocomplete API<br />    * NEW: Historical weather      * NEW: Future Weather (Upto 300 days ahead)      * Weather Alerts      * Air Quality Data  # Getting Started  You need to [signup](https://www.weatherapi.com/signup.aspx) and then you can find your API key under [your account](https://www.weatherapi.com/login.aspx), and start using API right away!  We have [code libraries](https://www.weatherapi.com/docs/code-libraries.aspx) for different programming languages like PHP, .net, JAVA, etc.  If you find any features missing or have any suggestions, please [contact us](https://www.weatherapi.com/contact.aspx).  # Authentication  API access to the data is protected by an API key. If at anytime, you find the API key has become vulnerable, please regenerate the key using Regenerate button next to the API key.  Authentication to the WeatherAPI.com API is provided by passing your API key as request parameter through an API .    ##  key parameter   key=\\<YOUR API KEY\\> 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
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
    /// ForecastAstro
    /// </summary>
    [DataContract]
        public partial class ForecastAstro :  IEquatable<ForecastAstro>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastAstro" /> class.
        /// </summary>
        /// <param name="sunrise">sunrise.</param>
        /// <param name="sunset">sunset.</param>
        /// <param name="moonrise">moonrise.</param>
        /// <param name="moonset">moonset.</param>
        /// <param name="moonPhase">moonPhase.</param>
        /// <param name="moonIllumination">moonIllumination.</param>
        public ForecastAstro(string sunrise = default(string), string sunset = default(string), string moonrise = default(string), string moonset = default(string), string moonPhase = default(string), string moonIllumination = default(string))
        {
            this.Sunrise = sunrise;
            this.Sunset = sunset;
            this.Moonrise = moonrise;
            this.Moonset = moonset;
            this.MoonPhase = moonPhase;
            this.MoonIllumination = moonIllumination;
        }
        
        /// <summary>
        /// Gets or Sets Sunrise
        /// </summary>
        [DataMember(Name="sunrise", EmitDefaultValue=false)]
        public string Sunrise { get; set; }

        /// <summary>
        /// Gets or Sets Sunset
        /// </summary>
        [DataMember(Name="sunset", EmitDefaultValue=false)]
        public string Sunset { get; set; }

        /// <summary>
        /// Gets or Sets Moonrise
        /// </summary>
        [DataMember(Name="moonrise", EmitDefaultValue=false)]
        public string Moonrise { get; set; }

        /// <summary>
        /// Gets or Sets Moonset
        /// </summary>
        [DataMember(Name="moonset", EmitDefaultValue=false)]
        public string Moonset { get; set; }

        /// <summary>
        /// Gets or Sets MoonPhase
        /// </summary>
        [DataMember(Name="moon_phase", EmitDefaultValue=false)]
        public string MoonPhase { get; set; }

        /// <summary>
        /// Gets or Sets MoonIllumination
        /// </summary>
        [DataMember(Name="moon_illumination", EmitDefaultValue=false)]
        public string MoonIllumination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastAstro {\n");
            sb.Append("  Sunrise: ").Append(Sunrise).Append("\n");
            sb.Append("  Sunset: ").Append(Sunset).Append("\n");
            sb.Append("  Moonrise: ").Append(Moonrise).Append("\n");
            sb.Append("  Moonset: ").Append(Moonset).Append("\n");
            sb.Append("  MoonPhase: ").Append(MoonPhase).Append("\n");
            sb.Append("  MoonIllumination: ").Append(MoonIllumination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ForecastAstro);
        }

        /// <summary>
        /// Returns true if ForecastAstro instances are equal
        /// </summary>
        /// <param name="input">Instance of ForecastAstro to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastAstro input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sunrise == input.Sunrise ||
                    (this.Sunrise != null &&
                    this.Sunrise.Equals(input.Sunrise))
                ) && 
                (
                    this.Sunset == input.Sunset ||
                    (this.Sunset != null &&
                    this.Sunset.Equals(input.Sunset))
                ) && 
                (
                    this.Moonrise == input.Moonrise ||
                    (this.Moonrise != null &&
                    this.Moonrise.Equals(input.Moonrise))
                ) && 
                (
                    this.Moonset == input.Moonset ||
                    (this.Moonset != null &&
                    this.Moonset.Equals(input.Moonset))
                ) && 
                (
                    this.MoonPhase == input.MoonPhase ||
                    (this.MoonPhase != null &&
                    this.MoonPhase.Equals(input.MoonPhase))
                ) && 
                (
                    this.MoonIllumination == input.MoonIllumination ||
                    (this.MoonIllumination != null &&
                    this.MoonIllumination.Equals(input.MoonIllumination))
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
                int hashCode = 41;
                if (this.Sunrise != null)
                    hashCode = hashCode * 59 + this.Sunrise.GetHashCode();
                if (this.Sunset != null)
                    hashCode = hashCode * 59 + this.Sunset.GetHashCode();
                if (this.Moonrise != null)
                    hashCode = hashCode * 59 + this.Moonrise.GetHashCode();
                if (this.Moonset != null)
                    hashCode = hashCode * 59 + this.Moonset.GetHashCode();
                if (this.MoonPhase != null)
                    hashCode = hashCode * 59 + this.MoonPhase.GetHashCode();
                if (this.MoonIllumination != null)
                    hashCode = hashCode * 59 + this.MoonIllumination.GetHashCode();
                return hashCode;
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