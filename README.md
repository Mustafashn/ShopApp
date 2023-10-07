# ShopApp

Projenin amacı .net bilgilerimi geliştirmek ve öğrenmektir.
Uygulama online alışveriş sitesi mantığında çalışmaktadır. Kullanıcı olarak kayıt olup giriş yapabilir, ürünleri kategorilerine göre arayabilir, arama çubuğu ile arayabilir ve sepete ekleyebilirsiniz. Sepetten sonra alışveriş tamamlama kısmına geçiş yapılır. Burada iyzico 
developer test kredi kartı entegrasyonunu kullandım.

Projeyi geliştirirken bootstrap,html,css ile tasarımı, c#, .net core ile arka plan işlemlerini gerçekleştirdim.

Uygulamada şu anlık 2 adet rol bulunmaktadır. Admin ve customer olarak. Admin panel üzerinden bütün kullanıcıların bilgilerine, rollerine ulaşabilir, ürünleri ekleyip silebilir, rolleri ve kategorileri düzenleyebilir konumdadır.
Customer sadece alışveriş sepetine, ürünleri görüntülemeye erişebilir.

Giriş yap ve kayıt ol kısmındaki kontroller önce tarayıcı üzerinde yapılır ve uyarı verilir , tarayıcı üzerinden geçtikten sonra server tarafında tekrar kontrol edilir. Amaç ilk olarak ön plandaki hataları arka plana aktarmadan çözüp arka planı yormamaktır.

Projeyi geliştirirken

-Entity Framework Core
-LINQ Queries
-Model Validation
-N Tier Architecture
-Repository Design Pattern
-Data Annotations & Fluent Api
-MVC
-Unit of Work
-Identity
-Rolleme
-Kredi Kartı Entegrasyonu
-Migrations
