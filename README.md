https://refactoring.guru/design-patterns
https://www.dofactory.com/net/design-patterns 
   
 # 1-Chain of Responsibility Design Pattern    
Chain of Responsibility (Sorumluluk Zinciri) tasarım deseni, isteklerin işleyici nesnelerden oluşan bir zincir boyunca iletilmesini sağlayan bir **davranışsal** tasarım desenidir. Bu desen, her işleyicinin isteği işleyip işleyemeyeceğine karar vermesine ve isteği gerektiğinde zincirdeki bir sonraki işleyiciye iletmesine olanak tanır. Bu yapı sayesinde, istekler bir zincir boyunca iletilir ve uygun işleyici tarafından ele alınır.
## Amaç    
Chain of Responsibility deseni, isteklerin hiyerarşik bir şekilde işlenmesini sağlar. İşleyiciler, belirli bir işleme yeteneğine sahip nesnelerdir ve bu istek zincir boyunca dolaşarak uygun işleyiciye ulaşır.
## Temel Bileşenler 
- **Handler (İşleyici)**: Gelen isteği işleyen ya da bir sonraki işleyiciye ileten nesne.
- **ConcreteHandler (Somut İşleyici)**: Gerçek işleme mantığını barındıran sınıflar.
- **Client (Müşteri)**: İsteği başlatan ve zinciri harekete geçiren sınıf.
Chain of Responsibility deseni, bir isteğin sıralı olarak işlenmesi gereken senaryolar için idealdir. Bu deseni aşağıdaki gibi durumlarda kullanabilirsiniz:
- **Kredi Onay Süreci**: Veznedar, şube müdürü, bölge müdürü gibi yetkililerin sırasıyla kredi talebini onaylaması.
## Örnek Proje: Kredi Onay Süreci 
 
Bir bankanın kredi onay sürecini simüle eden örnek senaryoda, müşterinin talep ettiği kredi tutarına göre işlem yetkisi olan kişilere sırasıyla başvurulur:

1. **Müşteri** 1.250.000 TL kredi talep eder.
2. **Veznedar**, limiti 50.000 TL olduğu için bu talebi işleyemez ve bir üst seviyeye, **şube müdür yardımcısına** iletir.
3. **Şube müdür yardımcısı** 150.000 TL limiti aşan talebi işleyemez, bu nedenle talebi **şube müdürüne** iletir.
4. **Şube müdürü**, limiti 19050.000 TL'yi aştığı için işleyemez ve talebi **bölge müdürüne** yönlendirir.
5. **Bölge müdürü**, maksimum limiti 1.600.000 TL olduğu için bu isteği onaylar ve işlem tamamlanır.

Bu senaryoda her işleyici, talebi ya işleyip onaylar ya da bir üst yetkiliye iletir. Bu yapı, sistemin esnek ve genişletilebilir olmasını sağlar.

## Avantajlar

1. **Esneklik**: Yeni işleyiciler zincire kolayca eklenebilir veya çıkartılabilir.
2. **Bağımlılığı Azaltır**: İstek gönderen nesne, hangi işleyicinin isteği işleyeceğini bilmek zorunda kalmaz.
3. **Karmaşık İşlemleri Düzenler**: Çok adımlı ve hiyerarşik işlemleri yönetmek için ideal bir yapıdır.


## 2- CQRS (Command Query Responsibility Segregation) Design Pattern :

CQRS (Command Query Responsibility Segregation), yazılım uygulamalarında veri okuma ve yazma işlemlerini ayrı sorumluluklarla yönetmeyi sağlayan bir tasarım desenidir. Bu sayede uygulama performansı, ölçeklenebilirliği ve sürdürülebilirliği artırılabilir.

## CQRS'nin Temel Bileşenleri
1. **Commands (Komutlar)**: Uygulamanın durumunu değiştiren işlemlerden sorumludur. Veri ekleme, güncelleme veya silme işlemlerini içerir. Commands, geriye veri döndürmez; yalnızca işlem sonucunu bildirir.
2. **Queries (Sorgular)**: Sistemin durumunu değiştirmeden veri okuma işlemlerini yönetir. Queries yalnızca belirtilen veri modelini döner ve veriyi değiştirmez.
## CQRS Kullanım Senaryoları
- **Yüksek veri trafiği** olan sistemlerde performans artırımı.
- **Kompleks iş kuralları** veya sık değişen iş kuralları.
- **Hata toleransının yüksek olduğu sistemler**: Bir serviste hata oluştuğunda diğer servislerin etkilenmemesi gerektiğinde.
## Örnek CQRS Yapısı
Bu örnek, **Kullanıcı Yönetimi** uygulaması için CQRS'nin temel yapısını gösterir.
### Komut: Kullanıcı Ekleme
Kullanıcı eklemek, sistemin durumunu değiştirdiği için **Command** olarak ele alınır. Bu işlemde:
- **Command**: Kullanıcı bilgilerini (Ad, Soyad, E-posta) içerir.
- **Command Handler**: Kullanıcıyı veritabanına ekler.
- **Sonuç**: Geriye işlem sonucu döner, veri döndürülmez.
### Sorgu: Kullanıcı Bilgisi Getirme
Kullanıcı bilgisi almak, sistemin durumunu değiştirmediği için **Query** olarak ele alınır. Bu işlemde:
- **Query**: Kullanıcı ID’sini içerir.
- **Query Handler**: Kullanıcı bilgisini veritabanından getirir.
- **Sonuç**: Kullanıcı verisi döner, herhangi bir değişiklik yapılmaz.
## CQRS'nin Avantajları

- **Performans ve Ölçeklenebilirlik**: Yazma ve okuma işlemlerini ayırarak her işlemi ayrı optimize etme imkanı sağlar.
- **Sürdürülebilirlik**: Her bir model kendi sorumluluğunu ele aldığı için daha modüler bir yapı oluşturur.
- **Deneyim Odaklı Tasarım**: Komut ve sorgu işlemleri, bağımsız olarak en uygun araç ve tekniklerle ele alınabilir.
## Sonuç
-  CQRS, karmaşık veri yönetimi gereksinimlerini olan projelerde oldukça etkilidir. Ancak, bu tasarım deseni küçük projeler için gereksiz karmaşıklık yaratabileceğinden, büyük ve karmaşık projelerde tercih edilmelidir.
---


# 3- Template Method Design Pattern
Template Method, bir algoritmanın veya sürecin genel yapısını belirleyen, ancak bazı adımların alt sınıflar tarafından özelleştirilmesine izin veren bir davranışsal tasarım desenidir. Bu desen, **abstract** bir sınıf (şablon sınıf) ve ona bağlı bir veya birden fazla **concrete** sınıf (somut sınıf) ile uygulanır.
## Template Method Deseninin Temel Bileşenleri

1. **Abstract Class (Şablon Sınıf)**: Sürecin genel akışını tanımlar ve sırasını belirler. Bazı adımlar abstract (soyut) metotlar olarak belirtilir, bu metotların implementasyonu alt sınıflara bırakılır.
   
2. **Concrete Class (Somut Sınıflar)**: Şablon sınıfta tanımlanan abstract metotları kendi ihtiyaçlarına göre özelleştirir. Böylece her alt sınıf aynı genel akışa bağlı kalırken kendine has detayları uygulayabilir.

## Template Method Kullanım Senaryoları

- Bir algoritmanın temel yapısı sabittir, ancak bazı adımların alt sınıflar tarafından farklı şekillerde uygulanması gerekiyorsa.
- Kod tekrarını azaltmak ve ortak işlemleri merkezi bir sınıfta toplamak istendiğinde.
- Belirli bir süreç için temel yapıyı koruyup, detayları alt sınıflara bırakmak isteniyorsa.

## Örnek: Alışveriş Sepetinde Ödeme Süreci

Bu örnekte, **alışveriş sepetindeki ürünlerin satın alma süreci** için Template Method deseni kullanacağız. Süreç her ürün için dört temel adımdan oluşur:

1. **Başlangıç**: İşlemin başlatılması.
2. **Ürün Seçimi**: Ürünün kullanıcı tarafından seçilmesi.
3. **Ödeme**: Ödeme işleminin yapılması.
4. **Bitiş**: İşlemin tamamlanması.

Örneğimizde televizyon ve buzdolabı satın alma işlemleri aynı akışa sahip olacak; ancak her bir ürünün seçim ve ödeme adımları farklılık gösterecek.

## Örnek Akış

### Şablon Sınıf: `ShoppingProcess`

Bu sınıf, satın alma sürecinin adımlarını ve sırasını belirler. **Ürün Seçimi** ve **Ödeme** adımları soyut olarak tanımlanır, böylece her ürün için bu adımlar alt sınıflarda özelleştirilebilir.

### Alt Sınıf: `TVPurchase`

Televizyon satın alma süreci, `ShoppingProcess` şablon sınıfını temel alır, ancak **Ürün Seçimi** ve **Ödeme** adımlarını televizyon için özelleştirir.

### Alt Sınıf: `RefrigeratorPurchase`

Buzdolabı satın alma süreci de `ShoppingProcess` şablon sınıfını temel alır ve bu adımları buzdolabı için özelleştirir.

## Template Method Deseninin Avantajları

- **Kod Tekrarını Azaltma**: Ortak adımlar bir yerde toplanarak kod tekrarı azaltılır.
- **Modülerlik ve Sürdürülebilirlik**: Farklı ürünlerin kendi özel süreç adımlarını tanımlaması sağlanır, bu da her alt sınıfın yalnızca kendi özelleştirilmiş adımlarını içermesine olanak tanır.
- **Esneklik**: Temel akış sabit kalırken, her ürün için süreç adımları farklılaştırılabilir.

## Sonuç

Template Method deseni, algoritmanın veya sürecin genel yapısını koruyarak, alt sınıfların yalnızca değişen veya spesifik adımları uyarlamasını sağlar. Bu desen, özellikle aynı sürecin farklı detaylar gerektirdiği durumlarda esneklik ve kod temizliği sağlar.

--- 







