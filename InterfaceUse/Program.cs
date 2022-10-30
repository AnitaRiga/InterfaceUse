namespace InterfaceUse
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                IMeasurable _measurable = new Measurable();

                Country[] countries = new Country[] {
                    new Country("France", 640679),
                    new Country("Austria", 83871),
                    new Country("Uzbekistan", 447400),
                    new Country("Norway", 385207),
                    new Country("Nepal", 147516),
                    new Country("Brazil", 8515767),
                    new Country("Switzerland", 41284),
                    new Country("Monaco", 202),
                    new Country("Malta", 316),
                    new Country("Canada", 9984670),
                };

                foreach (var country in countries)
                {
                    _measurable.DisplayListOfCountries(country);
                }

                IEnumerable<Country> selectedTheLargestArea = countries.Where(c => c.AreaOfTheCountry == countries.Max(c => c.AreaOfTheCountry));

                foreach (Country c in selectedTheLargestArea)
                {
                    _measurable.DispalyTheLargestCountryByArea(c);
                }

                IEnumerable<Country> arrangedByCountryName = countries.OrderBy(c => c.CountryName);

                Console.WriteLine("Alphabetical list of the countries:");

                foreach (Country c in arrangedByCountryName)
                {
                    _measurable.ArrangeDataByCountryName(c);
                }

                IEnumerable<Country> arrangedByAreaSize = countries.OrderBy(c => c.AreaOfTheCountry);

                Console.WriteLine("\r\n" + "Sort countries in ascending order of the area:");

                foreach (Country c in arrangedByAreaSize)
                {
                    _measurable.ArrangedCountryByAreaSize(c);
                }
            }
        }
    }
}