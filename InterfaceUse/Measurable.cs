namespace InterfaceUse
{
    public class Measurable : IMeasurable
    {
        public void DispalyTheLargestCountryByArea(Country[] countries)
        {
            Country selectedTheLargestArea = countries.First(c => c.AreaOfTheCountry == countries.Max(c => c.AreaOfTheCountry));

            Console.WriteLine($"The Largest Country By Area is {selectedTheLargestArea.CountryName} - {selectedTheLargestArea.AreaOfTheCountry} km2." + "\r\n");
        }

        public void DisplayListOfCountries(Country[] countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine($"The area of {country.CountryName} is {country.AreaOfTheCountry} km2.");
            }
        }

        public void ArrangeDataByCountryName(Country[] countries)
        {
            IEnumerable<Country> arrangedByCountryName = countries.OrderBy(c => c.CountryName);

            Console.WriteLine("\r\n" + "Alphabetical list of the countries:"); 

            foreach (var country in arrangedByCountryName)
            {
                Console.WriteLine($"{country.CountryName} - {country.AreaOfTheCountry} km2.");
            }
        }

        public void ArrangeCountryByAreaSize(Country[] countries)
        {
            IEnumerable<Country> arrangedByAreaSize = countries.OrderBy(c => c.AreaOfTheCountry);

            Console.WriteLine("\r\n" + "Sort countries in ascending order of the area:");

            foreach (var country in arrangedByAreaSize)
            {
                Console.WriteLine($"{country.AreaOfTheCountry} km2 - {country.CountryName}.");
            }
        }
    }
}