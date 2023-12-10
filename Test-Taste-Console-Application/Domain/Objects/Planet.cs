namespace Test_Taste_Console_Application.Domain.Objects
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Test_Taste_Console_Application.Domain.DataTransferObjects;

    public class Planet
    {
        public Planet(PlanetDto planetDto)
        {
            Id = planetDto.Id;
            SemiMajorAxis = planetDto.SemiMajorAxis;
            Moons = new Collection<Moon>();
            if (planetDto.Moons != null)
            {
                foreach (MoonDto moonDto in planetDto.Moons)
                {
                    Moons.Add(new Moon(moonDto));
                }
            }
        }

        public string Id { get; set; }

        public float SemiMajorAxis { get; set; }

        public ICollection<Moon> Moons { get; set; }

        public float AverageMoonGravity
        {
            get => (float)Moons.Where(x => x.Gravity.HasValue).Average(x => x.Gravity);
        }

        public bool HasMoons()
        {
            return (Moons != null && Moons.Count > 0);
        }
    }
}
