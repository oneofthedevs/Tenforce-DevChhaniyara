namespace Test_Taste_Console_Application.Domain.Objects
{
    using Test_Taste_Console_Application.Domain.DataTransferObjects;

    public class Moon
    {
        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
            MeanRadius = moonDto.MeanRadius;
            Gravity = (moonDto.Gravity.HasValue) ? (float)moonDto.Gravity : null;
        }

        public string Id { get; set; }

        public float? MassValue { get; set; }

        public float? MassExponent { get; set; }

        public float? MeanRadius { get; set; }

        public float? Gravity { get; set; } = 0.0f;
    }
}
