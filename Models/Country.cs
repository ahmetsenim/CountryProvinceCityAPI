namespace CountryProvinceCityAPI.Models
{
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string iso3 { get; set; }
        public string iso2 { get; set; }
        public string phone_code { get; set; }
        public string currency { get; set; }
        public string currency_name { get; set; }
        public Dictionary<string, string> translations { get; set; }
        public List<Province> states { get; set; }
    }
}
