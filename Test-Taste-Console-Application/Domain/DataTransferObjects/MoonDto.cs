namespace Test_Taste_Console_Application.Domain.DataTransferObjects
{
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using Test_Taste_Console_Application.Constants;
    using Test_Taste_Console_Application.Domain.DataTransferObjects.JsonObjects;

    /* The converter is needed for this DTO. Because of the converter,
     * all the properties need to get the JsonProperty annotation. */
    [Newtonsoft.Json.JsonConverter(typeof(JsonPathConverter))]
    public class MoonDto
    {
        [JsonProperty("id")] public string Id { get; set; }

        //The property moon is used to set the Id property. 
        [JsonProperty("moon")]
        public string Moon
        {
            get => Id;
            set => Id = value;
        }

        //The path of the specific moon
        [JsonProperty("rel")] public string Rel { get; set; }
        public string URLId { get => Rel.Split('/').Last(); }

        //The path to the nested property is created by using a dot. 
        [JsonProperty("mass.massValue")] public float? MassValue { get; set; }

        [JsonProperty("mass.massExponent")] public float? MassExponent { get; set; }

        [JsonProperty("meanRadius")] public float? MeanRadius { get; set; }

        [JsonProperty("gravity")]
        public double? Gravity
        {
            get
            {
                // To find Gravity of a planet, we can use the formula
                // (gravitational_constant * mass) / radius^2
                double gravitationalConstant = ValueConstants.UniversalGravityConstant * Math.Pow(10, -11);

                if (MassExponent.HasValue && MassValue.HasValue && MeanRadius.HasValue)
                {
                    double massOfthePlanet = MassValue.Value * Math.Pow(10, MassExponent.Value);
                    double radiusOfThePlanet = MeanRadius.Value * 1000;


                    return ((gravitationalConstant * massOfthePlanet) / (Math.Pow(radiusOfThePlanet, 2)));
                }

                return null;
            }
        }
    }
}
