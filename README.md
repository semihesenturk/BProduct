# BProduct
Product Project
Kullanılan Teknolojiler
- .Net Core 6 Web Api (DI Implementation)
- Clean Architecture (Onion Architecture)
- EF Core CodeFirst Implementation
- Generic Repository Pattern
- CQRS Mediator Implementation (with MediatR)
- AutoMapper
- Bogus Fake Data Generator


Uygulama docker üzerinde çalışacak şekilde configure edilmiştir. Migration proje içerisinde mevcut olup, PM Console üzerinden, update-database komutu ile ayağa kaldırılabilir.

Uygulamada Onion Arch kullanılmıştır.
Katmanlar ve içerikleri şu şekildedir;
Domain
- Domain entitylerini içeren katman.

Infrastructure.Persistence
- Context'i entityconfiguration classları migration classları ve repositorylerin concrete classlarını barındırır.

Application
- Features altında CQRS için kullanılan Command Query ve Handler classları, Repository interfaceleri ve Automapper mapping classını barındırır.

Common
- Katmanlar arasında ortak kullanılacak olan request objeleri viewmodelleri enumları ve constanst classlarını barındırır.

Api
- controller ve tüm register işlemlerinin bulunduğu katman.

Notlar:
Tüm katmanlarda DI Container için Registration extension classları mevcuttur. 
İlerideki ihtiyaçlar için rabbitmq altyapısı hazır hale getirilmiştir.
