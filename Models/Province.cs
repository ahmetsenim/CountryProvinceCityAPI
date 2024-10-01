namespace CountryProvinceCityAPI.Models
{
    public class Province
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state_code { get; set; }
        public List<City> cities { get; set; }
    }
}
