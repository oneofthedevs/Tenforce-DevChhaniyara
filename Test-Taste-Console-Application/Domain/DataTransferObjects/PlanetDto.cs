namespace Test_Taste_Console_Application.Domain.DataTransferObjects
{
    using System.Collections.Generic;

    public class PlanetDto
    {
        public string Id { get; set; }

        public float SemiMajorAxis { get; set; }

        public float Gravity { get; set; }

        public ICollection<MoonDto> Moons { get; set; }
    }
}