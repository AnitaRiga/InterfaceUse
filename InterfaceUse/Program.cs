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

                _measurable.DispalyTheLargestCountryByArea(countries);

                _measurable.DisplayListOfCountries(countries);

                _measurable.ArrangeDataByCountryName(countries);

                _measurable.ArrangeCountryByAreaSize(countries);
            }
        }
    }
}