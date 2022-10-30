namespace InterfaceUse
{
    public class Measurable : IMeasurable
    {
        public void DisplayListOfCountries(Country country)
        {
                Console.WriteLine($"The area of {country.CountryName} is {country.AreaOfTheCountry} km2.");
        }

        public void DispalyTheLargestCountryByArea(Country country)
        {
            Console.WriteLine("\r\n" + $"The Largest Country By Area is {country.CountryName} - {country.AreaOfTheCountry} km2." + "\r\n");
        }

        public void ArrangeDataByCountryName(Country country)
        {
            Console.WriteLine($"{country.CountryName} - {country.AreaOfTheCountry} km2.");
        }

        public void ArrangedCountryByAreaSize(Country country) 
        {
            Console.WriteLine($"{country.AreaOfTheCountry} km2 - {country.CountryName}.");
        }
    }
}
