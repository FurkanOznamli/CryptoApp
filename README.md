# 🔐 Kripto Şifreleme Uygulaması

![Ana Görsel](docs/ana-gorsel.png)  
*Projenin genel görünümünü gösterebileceğin yer.*

---

## 🚀 Proje Hakkında

Bu proje, **RSA algoritması** ve **SHA-256 hashleme** gibi temel kriptografi işlemlerini web ortamında gerçekleştiren tam kapsamlı bir uygulamadır.  
Kullanıcılar, kolay arayüz ile RSA anahtar çifti oluşturabilir, metinlerini şifreleyip çözebilir ve SHA-256 hashleme yapabilirler.

---

## 🎥 Demo Görüntüleri ve Sayfa Açıklamaları

### Ana Sayfa

![Ana Sayfa](docs/anasayfa.png)  
_Kullanıcıların tüm işlem modüllerine hızlı erişim sağladığı modern ve şık ana sayfa._

---

### Anahtar Üretimi

![Anahtar Üretimi](docs/anahtar-uretimi.png)  
_Bu sayfada kullanıcılar 2048 bit RSA public ve private anahtar çiftlerini oluşturabilir. Anahtarlar güvenli biçimde Base64 formatında gösterilir ve kolayca kopyalanabilir._

---

### Metin Şifreleme

![Metin Şifreleme](docs/metin-sifreleme.png)  
_Kullanıcıların public key kullanarak metinlerini güvenli bir şekilde şifrelediği arayüz. Şifrelenmiş metin Base64 formatında çıktı olarak sunulur ve kopyalanabilir._

---

### Şifre Çözme

![Şifre Çözme](docs/sifre-cozme.png)  
_Private key kullanarak şifrelenmiş metinleri orijinal haline getiren sayfa. Kolay kullanım ve anında sonuç gösterimi özellikleriyle kullanıcı dostudur._

---

### SHA-256 Hashleme

![SHA256 Hashleme](docs/sha256-hashleme.png)  
_Metin veya dosya kullanılarak benzersiz SHA-256 hash üretim işleminin yapıldığı sayfa. Kullanıcılar metin yazabilir veya dosya yükleyebilir, sonuç anında gösterilir._

---

## ⚙️ Teknolojiler

- ASP.NET Core MVC  
- C#  
- Bootstrap 5  
- FontAwesome  
- SHA-256 & RSA Kriptografi standartları  

---

## 📁 Dosya Yapısı

```plaintext
/Controllers       # controllerlar
/Views             # Razor sayfalar
/wwwroot           # Statik dosyalar (CSS, JS, resimler)
/Models            # Veri modelleri
