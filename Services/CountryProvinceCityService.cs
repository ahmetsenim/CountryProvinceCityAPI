using CountryProvinceCityAPI.Models;
using Newtonsoft.Json;

namespace CountryProvinceCityAPI.Services
{
    public class CountryProvinceCityService
    {
        private readonly List<Country> _countries;
        public CountryProvinceCityService()
        {
            // JSON dosyasını okuyup deserializasyon işlemi yapılır
            var jsonData = File.ReadAllText("Data/CountryProvinceCity.json");
            _countries = JsonConvert.DeserializeObject<List<Country>>(jsonData);
        }

        // Tüm ülkeleri getirir, dil kodu varsa translations'dan çeker
        public IEnumerable<object> GetAllCountries(string? lang = null)
        {
            return _countries.Select(c => new
            {
                Name = !string.IsNullOrEmpty(lang) && c.translations.ContainsKey(lang) ? c.translations[lang] : c.name,
                Code = c.iso2
            });
        }

        // Ülke Kodu ile İlleri Döndürür (İl İsmi ve Kodu)
        public IEnumerable<object> GetProvinces(string countryCode)
        {
            var country = _countries.FirstOrDefault(c => c.iso2 == countryCode.ToUpper());

            if (country == null) return Enumerable.Empty<object>();

            return country.states.Select(s => new
            {
                Name = s.name,
                Code = s.state_code
            });
        }

        // Ülke Kodu ve İl Kodu ile İlçeleri Döndürür (İlçe İsmi ve Kodu)
        public IEnumerable<object> GetCities(string countryCode, string provinceCode)
        {
            var country = _countries.FirstOrDefault(c => c.iso2 == countryCode.ToUpper());

            if (country == null) return Enumerable.Empty<object>();

            var province = country.states.FirstOrDefault(s => s.state_code == provinceCode);

            if (province == null) return Enumerable.Empty<object>();

            return province.cities.Select(c => new
            {
                Name = c.name,
                Code = c.id
            });
        }

    }
}
