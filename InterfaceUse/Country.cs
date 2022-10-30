namespace InterfaceUse
{
    public class Country
    {
        // Create fields.
        public string countryName;
        public double areaOfTheCountry;

        // Create a class constructor with multiple parameters.
        public Country(string countryName, double areaOfTheCountry)
        {
            CountryName = countryName;
            AreaOfTheCountry = areaOfTheCountry;
        }

        public string CountryName { get; set; }
        public double AreaOfTheCountry { get; set; }
    }
}