# .NET Core 8.0 Ülke, İl ve İlçe Apisi

Bu proje, yerel bir JSON dosyasından ülke, il ve ilçe bilgilerini sağlayan bir .NET Core 8 API uygulamasıdır. API, belirli ülke ve il kodlarına göre veri dönen yöntemler sunar ve dil desteğiyle birlikte temiz kodlama prensiplerine göre yapılandırılmıştır.

## Özellikler

- **GetAllCountry**: Tüm ülkeleri adları ve ISO2 kodları ile listeler. İsteğe bağlı olarak `lang` parametresi ile ülke adını belirli bir dilde dönebilir.
- **GetAllProvince**: Ülke koduna göre illeri (ad ve kod ile) listeler.
- **GetAllCity**: Ülke ve il koduna göre ilçeleri (ad ve kod ile) listeler.
