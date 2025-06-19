# SignalR Restoran Yönetim Sistemi

Bu proje, ASP.NET Core ve SignalR ile oluşturulmuş kapsamlı bir restoran yönetim sistemidir. Restoranın rezervasyonlar, siparişler, menü öğeleri ve anlık bildirimler gibi çeşitli yönlerini yönetmek için tam özellikli bir backend API'si ve web tabanlı bir kullanıcı arayüzü sunar.

## Kullanılan Teknolojiler

- **Backend:** ASP.NET Core Web API
- **Anlık İletişim:** SignalR
- **Mimari:** Çok Katmanlı Mimari 
- **Veritabanı:** Entity Framework Core (Code-First Yaklaşımı)
- **Frontend:** ASP.NET Core MVC (`SignalRWebUI` projesinden anlaşıldığı üzere)

## Proje Mimarisi

Çözüm, sorumlulukların ayrılması, sürdürülebilirlik ve ölçeklenebilirlik sağlamak için katmanlı bir mimariyi takip eder. Katmanlar aşağıdaki gibi organize edilmiştir:

- `SignalR.DataAccessLayer`: Entity Framework Core kullanarak tüm veritabanı etkileşimlerini yönetir. DbContext ve repository implementasyonlarını içerir.
- `SignalR.EntityLayer`: Veritabanı modellerini (varlıkları) içerir.
- `SignalR.BusinessLayer`: Uygulamanın iş mantığını ve servislerini uygular. API ve veri erişim katmanı arasında bir köprü görevi görür.
- `SignalR.DtoLayer`: API ve istemciler arasında veri aktarımı için kullanılan Veri Aktarım Nesnelerini (DTO'ları) içerir.
- `SignalRApi`: Uygulamanın işlevselliğini RESTful endpoint'ler ve bir SignalR hub'ı aracılığıyla sunan ASP.NET Core Web API projesi.
- `SignalRWebUI`: API'yi tüketen ve bir kullanıcı arayüzü sağlayan ASP.NET Core MVC projesi olan frontend uygulaması.

## API Endpoint'leri

API, restoran verilerini yönetmek için zengin bir endpoint seti sunar:

- **About (Hakkında):** 'Hakkımızda' bölümü içeriğini yönetir.
- **Basket (Sepet):** Siparişler için alışveriş sepeti işlemlerini yönetir.
- **Booking (Rezervasyon):** Müşteri rezervasyonlarını yönetir.
- **Category (Kategori):** Menü öğesi kategorilerini yönetir.
- **Contact (İletişim):** İletişim bilgilerini ve mesajları yönetir.
- **Discount (İndirim):** Promosyon indirimlerini yönetir.
- **MenuTables (Menü Masaları):** Restoran masa bilgilerini ve durumunu yönetir.
- **Message (Mesaj):** Kullanıcı mesajlarını yönetir.
- **MoneyCases (Kasa):** Finansal özetler sunar.
- **Notification (Bildirim):** Anlık bildirimleri yönetir.
- **Orders (Siparişler):** Müşteri siparişlerini yönetir.
- **Product (Ürün):** Menü ürünlerini/öğelerini yönetir.
- **Slider (Kaydırıcı):** Ana sayfa kaydırıcıları için içeriği yönetir.
- **SocialMedia (Sosyal Medya):** Sosyal medya bağlantılarını yönetir.
- **Testimonial (Referans):** Müşteri referanslarını yönetir.

## Projeyi Başlatma

Projeyi yerel makinenizde çalışır duruma getirmek için aşağıdaki adımları izleyin:

1.  **Depoyu klonlayın:**
    ```bash
    git clone <repository-url>
    ```
2.  **Veritabanı bağlantısını yapılandırın:**
    - `SignalRApi` projesindeki `appsettings.json` dosyasını açın.
    - `ConnectionStrings` bölümünü yerel SQL Server örneğinize işaret edecek şekilde değiştirin.

3.  **Veritabanı migration'larını uygulayın:**
    - Visual Studio'da Package Manager Console'u açın.
    - Varsayılan proje olarak `SignalR.DataAccessLayer`'ı ayarlayın.
    - Migration'ları oluşturmak ve uygulamak için aşağıdaki komutu çalıştırın:
      ```powershell
      Update-Database
      ```

4.  **Uygulamayı çalıştırın:**
    - Visual Studio'da `SignalRApi` ve `SignalRWebUI`'ı başlangıç projeleri olarak ayarlayın.
    - Hem API'yi hem de web arayüzünü başlatmak için F5'e basın veya 'Çalıştır' düğmesine tıklayın.
