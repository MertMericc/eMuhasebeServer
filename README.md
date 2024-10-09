## Proje Amacı

Muhasebe Uygulaması, küçük ve orta ölçekli işletmelerin finansal süreçlerini düzenlemek ve yönetmek amacıyla geliştirilmiştir. Kullanıcı dostu arayüzü ve modüler yapısı ile tüm muhasebe işlemlerini tek bir platformda toplar.


## Modüller

Proje kapsamında geliştirilen başlıca modüller şunlardır:

- **Kullanıcı Yönetimi**: Sistem kullanıcılarının yönetimi, yetkilendirme ve kimlik doğrulama işlemlerini sağlar.
- **Şirket Yönetimi**: Şirket bilgilerini ve şirketler arası ilişkileri yönetir.
- **Kasa Yönetimi**: Şirket kasalarının takibi, kasa işlemlerinin kaydedilmesi ve raporlanmasını sağlar.
- **Banka Yönetimi**: Şirket banka hesaplarının takibi ve banka işlemlerinin kaydedilmesi.
- **Cari Yönetimi**: Müşteri ve tedarikçi hesaplarının takibi, ödeme ve tahsilat işlemlerinin yönetimi.
- **Stok Yönetimi**: Ürün envanterlerinin yönetimi, stok giriş/çıkış işlemleri.
- **Fatura Yönetimi (Alış ve Satış)**: Alım ve satım faturalarının oluşturulması ve takibi.
- **Raporlar**: Sistemdeki tüm işlemlerle ilgili detaylı raporlar oluşturulması.

## Kullanılan Teknoloji ve Kütüphaneler

Bu proje, aşağıdaki teknolojiler ve kütüphaneler kullanılarak geliştirilmiştir:

- **.NET 8**
- **Clean Architecture**: Projede kullanılan temiz mimari deseni, bağımlılıkları minimuma indirir ve uygulamanın farklı katmanlar arasında bağımsızca çalışmasını sağlar.
- **CQRS Pattern**: Komut ve sorgu işlemlerinin ayrı olarak yönetilmesi ile uygulamanın okunabilirliği ve performansı artırılmıştır.
- **Result Pattern**: İşlemlerden dönen sonuçların daha okunabilir ve anlaşılır bir şekilde yönetilmesini sağlar.
- **Repository Pattern (with Unit Of Work)**: Veri erişim katmanında repository ve unit of work desenleri ile veri işlemleri izole edilmiştir.
- **Smart Enum**: Akıllı enum yapıları kullanılarak sabit veri yönetimi yapılmıştır.
- **SMTP (Fake SMTP)**: Proje geliştirme ve test süreçlerinde sahte e-posta gönderimi için Fake SMTP kullanılmıştır.
- **Entity Framework Core (EF Core)**: Veritabanı işlemlerinde ORM (Object-Relational Mapping) olarak kullanılmıştır.
- **AutoMapper**: Veri transfer işlemlerinde DTO'lar (Data Transfer Objects) ile entity sınıfları arasındaki dönüşümler için kullanılmıştır.
- **FluentValidation**: Model doğrulama işlemleri için FluentValidation kütüphanesi kullanılmıştır.
- **JWT**: Kimlik doğrulama ve yetkilendirme işlemlerinde JSON Web Token kullanılmıştır.
