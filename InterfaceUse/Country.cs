namespace InterfaceUse
{
    public class Country
    {
        // Create a class constructor with multiple parameters.
        public Country(string countryName, double areaOfTheCountry)
        {
            CountryName = countryName;
            AreaOfTheCountry = areaOfTheCountry;
        }

        public string CountryName { get;}
        public double AreaOfTheCountry { get;}
    }
}