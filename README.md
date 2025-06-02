# 🔐 Kripto Şifreleme Uygulaması

---

## 🚀 Proje Hakkında

Bu proje, **RSA algoritması** ve **SHA-256 hashleme** gibi temel kriptografi işlemlerini web ortamında gerçekleştiren tam kapsamlı bir uygulamadır.  
Kullanıcılar, kolay arayüz ile RSA anahtar çifti oluşturabilir, metinlerini şifreleyip çözebilir ve SHA-256 hashleme yapabilirler.

---

## 🎥 Demo Görüntüleri ve Sayfa Açıklamaları

### Ana Sayfa

![image](https://github.com/user-attachments/assets/6ab4d2e5-cdff-4ee7-bd86-74c4631ff36b)
![image](https://github.com/user-attachments/assets/b5da2153-0a77-4f76-a16f-ff792ab4958f)

  
_Kullanıcıların tüm işlem modüllerine hızlı ve kolay erişim sağladığı, üstte 5 saniyede otomatik kayan interaktif kartların bulunduğu modern ve şık ana sayfa.
Kartlar sırasıyla RSA Anahtar Üretimi, Metin Şifreleme, Şifre Çözme ve SHA-256 Hashleme modüllerini tanıtarak kullanıcı deneyimini zenginleştirir.
Alt kısımda ise neon temalı, canlı renklerle desteklenen ve butonları hizalanmış menü kartlarıyla tüm özelliklere direkt yönlendirme imkanı sunar._

---

### Anahtar Üretimi

![image](https://github.com/user-attachments/assets/47a87c82-1147-4c7c-bbe1-328c776b98e1)
![image](https://github.com/user-attachments/assets/6febedc7-552b-413a-b39c-31c3501132ed)

 
_2048 bit güvenlik seviyesine sahip RSA public ve private anahtar çiftlerini kullanıcı dostu bir arayüzde hızlıca oluşturabileceğiniz sayfa.
Anahtarlar, modern kriptografi standartlarına uygun şekilde üretilir ve Base64 formatında görüntülenir; böylece farklı platformlarda kolayca kullanılabilir.
Her anahtarın yanında bulunan “Kopyala” butonları sayesinde, tek tıkla anahtarlar panoya kopyalanabilir, böylece işlem hızlanır ve kullanıcı deneyimi artar.
Minimalist neon temalı tasarımıyla teknik karmaşıklığı gizler, güvenli anahtar oluşturma işlemini herkes için erişilebilir hale getirir._

---

### Metin Şifreleme

![image](https://github.com/user-attachments/assets/04f18885-00e6-4178-a9ff-74967f86be84)
![image](https://github.com/user-attachments/assets/1e307a8c-cc72-4689-8b20-20cb91198ba2)

  
_Public key kullanarak metinlerinizi güvenli bir şekilde şifreleyebileceğiniz bir sayfa.
Kullanıcıların girdikleri düz metin, seçtikleri RSA public anahtarı ile güçlü asimetrik algoritma kullanılarak şifrelenir.
Şifrelenmiş metin, Base64 formatında çıktı olarak sunulur ve kolayca kopyalanabilir, böylece güvenli veri transferi sağlanır.
Modern neon temalı arayüz, karmaşık şifreleme işlemlerini sade ve anlaşılır hale getirirken, kullanıcı deneyimini üst düzeye çıkarır._

---

### Şifre Çözme

![image](https://github.com/user-attachments/assets/c98c61da-d3a4-42e4-8321-092c4c31c194)
![image](https://github.com/user-attachments/assets/80b3a520-94ef-469c-8a05-2499ade70c11)

_Private key kullanarak şifrelenmiş metinlerinizi kolayca çözüp orijinal haline getirebileceğiniz güvenli bir sayfa.
Kullanıcılar, ellerindeki RSA private anahtarı ve şifrelenmiş Base64 formatındaki metni girerek hızlıca çözümleme yapabilirler.
Çözümleme sonucu orijinal metin anında görüntülenir ve kolayca kopyalanabilir, böylece veri güvenliği ve kullanım kolaylığı sağlanır.
Neon temalı modern arayüz, karmaşık şifre çözme işlemlerini sadeleştirerek, her seviyeden kullanıcı için erişilebilir hale getirir._

---

### SHA-256 Hashleme

![image](https://github.com/user-attachments/assets/c6543806-57b3-46ef-b20a-0425fbba720b)
![image](https://github.com/user-attachments/assets/4cbd040c-c0a8-4c2a-9740-0f3ee8c0d71a)
![image](https://github.com/user-attachments/assets/316f0503-4080-442e-95f4-6d5e9cbaaad4)
![image](https://github.com/user-attachments/assets/a5331fd2-7d20-4f6b-bd44-4313822a10cc)

_Metin ya da dosya kullanarak benzersiz ve güvenli SHA-256 hash değeri oluşturabileceğiniz bir sayfa.
Kullanıcılar, metin modunda istedikleri yazıyı doğrudan girebilir; veya dosya modunda herhangi bir dosya yükleyerek içeriğinin hash’ini hızlıca hesaplatabilirler.
Sayfa, iki modu kolayca seçebilmek için kullanıcı dostu butonlarla modlar arasında geçiş imkanı sunar.
Hash sonucu anında görüntülenir, Base16 (hex) formatında gösterilir ve kolayca kopyalanabilir.
Modern neon temasıyla şık tasarım sunan arayüz, kriptografi kavramlarını herkes için erişilebilir ve anlaşılır kılar.
Dosya ve metin girdisi seçenekleriyle esnek kullanım sağlayarak, farklı ihtiyaçlara yönelik güçlü bir hashleme çözümü sunar._

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
