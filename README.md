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
4. **Şube müdürü**, limiti 150.000 TL'yi aştığı için işleyemez ve talebi **bölge müdürüne** yönlendirir.
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

# 4 - Observer Design Pattern

**Observer Design Pattern** (Gözlemci Tasarım Deseni), bir nesne değiştiğinde ona bağlı diğer nesnelerin otomatik olarak güncellenmesini sağlayan bir **davranışsal tasarım desenidir**. Bu desen, **one-to-many (birden çoğa)** ilişkilerin olduğu durumlarda nesneler arasındaki bağımlılığı azaltır ve böylece bir nesnenin durumundaki değişiklikleri diğer nesnelere otomatik olarak bildirir.

## Observer Design Pattern’in Temel Bileşenleri

1. **Subject (Özne)**: Durumu takip edilen ve gözlemcilere güncelleme gönderen ana nesnedir. Subject, değişiklik olduğunda tüm bağlı gözlemcilere (observer) bildirim yapar.

2. **Observer (Gözlemci)**: Subject’i izleyen ve durum değişikliklerinden haberdar olmak isteyen nesnedir. Gözlemciler, Subject’in güncellemelerini alır ve buna göre kendi durumlarını günceller.

## Observer Design Pattern Kullanım Senaryoları

- **Finans Sektörü**: Örneğin, borsa sistemlerinde borsacıların, finansal kağıtlardaki değişikliklerden anında haberdar olması gereken bir yapı kurmak için kullanılır. Finans kağıtlarındaki herhangi bir değişiklik tüm borsacılara bildirilir.
  
- **Hava Durumu Uygulamaları**: Bir hava durumu istasyonu, anlık hava durumu bilgilerini çeşitli medya platformlarına (televizyon, radyo, internet siteleri) iletebilir. Hava durumu istasyonu “Subject”, medya platformları ise “Observer” olur. Hava durumu güncellenince tüm gözlemciler bilgilendirilir.

## Observer Design Pattern’in Sağladığı Avantajlar

- **Bağımlılıkları Azaltır**: Gözlemciler, Subject’e gevşek bir bağlılık ile bağlıdır, bu da daha esnek bir yapı sağlar.
- **Dinamik Bildirim**: Subject’in durumu değiştiğinde tüm gözlemciler otomatik olarak güncellenir.
- **Sürdürülebilirlik ve Modülerlik**: Yeni gözlemciler kolayca eklenebilir ve mevcut gözlemciler üzerinde değişiklik yapılmadan çıkarılabilir.

## Örnek Senaryo: Borsa Sisteminde Finans Kağıtlarının İzlenmesi

Bu örnek senaryoda bir borsa sisteminde finans kağıtlarının izlenmesi için Observer deseni kullanılır:

- **Subject (Özne): Finans Kağıdı**  
  Borsa sisteminde finansal bir kağıdın fiyatını takip eden sınıftır. Fiyat değiştiğinde bağlı olan gözlemcilere bu değişiklikleri bildirir.

- **Observer (Gözlemci): Yatırımcılar**  
  Yatırımcılar, finans kağıdını izleyen nesnelerdir. Fiyat değişikliği olduğunda, yatırımcılar bu değişiklikten haberdar edilir ve buna göre kendi işlemlerini planlar.

### Akış:

1. **Finans Kağıdı**, tüm yatırımcıları izleyici (observer) olarak kayıt eder.
2. **Finans Kağıdı** üzerinde fiyat değişikliği meydana geldiğinde, tüm gözlemciler durum güncellemesi alır.
3. Her **Yatırımcı** güncelleme alır ve bu yeni fiyat bilgisine göre işlem yapabilir veya stratejisini değiştirebilir.

Bu yapıyla birlikte, yatırımcılar finans kağıdının fiyatını sürekli sorgulamak yerine, fiyat değiştiğinde otomatik olarak bilgilendirilmiş olur.

# 5 - Unit of Work Design Pattern

**Unit of Work Design Pattern**, veri tabanı işlemlerini bir araya toplayarak tek bir işlem (transaction) olarak yönetilmesini sağlayan bir **davranışsal tasarım desenidir**. Bu desen, tüm işlemlerin başarılı olması durumunda veritabanına yazılmasını, aksi takdirde hiçbir işlemin gerçekleştirilmemesini sağlar.

## Unit of Work Tasarım Deseni’nin Temel Bileşenleri

1. **Unit of Work (Çalışma Birimi)**: Veritabanı işlemlerini koordine eden ana sınıftır. İşlemleri gruplar, sıraya koyar ve başarılı bir şekilde tamamlanmalarını sağlar. Tüm işlemler tek bir transaction altında gerçekleştirilir, bu sayede işlemlerin güvenliği sağlanır.

2. **Repository (Depo)**: Veritabanı işlemleri için kullanılan özel sınıflardır. Her veri tabanı nesnesi için bir repository sınıfı bulunabilir. Bu sınıflar, veritabanına erişim işlemlerini ve sorguları gerçekleştirir. Repository Pattern ile uyumlu çalışır ve veri tabanına erişimle ilgili tüm işlemleri içerir.

3. **Entity (Varlık)**: Veritabanındaki tablolara karşılık gelen sınıflardır. Bu nesneler Repository sınıfları aracılığıyla CRUD (Create, Read, Update, Delete) işlemlerinde kullanılır.

## Unit of Work Tasarım Deseni’nin Amaçları

- **Veritabanı İşlemlerini Gruplama**: Tüm işlemleri bir araya toplayarak tek bir iş birimi olarak ele alır. Böylece işlemler daha kolay yönetilir ve koordine edilir.
  
- **İşlemlerin Sırasını Belirleme**: İşlemlerin belirli bir sıra ile gerçekleşmesini sağlar. Bu sıraya göre veritabanı üzerinde gerekli güncellemeleri yapar.
  
- **Tutarlılığı Sağlama**: Veritabanı işlemleri sırasında bir hata oluşursa, tüm işlemler geri alınır. Bu sayede veritabanının tutarlılığı korunmuş olur.

- **Tekrar Kullanılabilirlik**: Daha modüler ve yeniden kullanılabilir bir yapı sağlar. Veritabanı işlemleri tek bir yapı altında toplandığından, kodun bakımı daha kolay hale gelir.

## Kullanım Alanları

Unit of Work tasarım deseni, özellikle **büyük ve karmaşık** veri tabanına sahip uygulamalarda sıkça kullanılır. Örneğin:

- **E-Ticaret Siteleri**: Yoğun veri işlemlerinin bulunduğu ve işlemlerin bir bütün olarak yapılması gereken sistemlerde.
  
- **Finansal Uygulamalar**: Farklı işlemlerin toplu şekilde gerçekleştiği ve hata durumunda geri alınması gereken uygulamalarda.

## Unit of Work Tasarım Deseni’nin Sağladığı Avantajlar

- **Performans**: Veritabanı işlemleri toplu halde gerçekleştirildiğinden maliyetleri düşürür ve performansı artırır.
  
- **Bakım Kolaylığı**: Tüm veri tabanı işlemleri tek bir yapı içinde toplandığı için bakımı ve genişletilmesi daha kolaydır.
  
- **Güvenlik ve Tutarlılık**: Hata durumunda tüm işlemleri geri alarak veri tabanının güvenliğini ve tutarlılığını sağlar.

**Örnek Senaryo: E-Ticaret Sipariş İşlemleri**

Bu senaryoda, bir e-ticaret uygulamasında bir sipariş süreci ele alınır. Bir siparişin başarılı bir şekilde kaydedilmesi, envanterin güncellenmesi ve kullanıcıya bildirim gönderilmesi gerekmektedir. Eğer bu işlemlerden herhangi birinde hata oluşursa, tüm işlemler geri alınmalıdır. 

**Akış**:

1. Sipariş oluşturulur ve işleme alınır.
2. Ürün envanteri güncellenir.
3. Kullanıcıya sipariş bilgisi gönderilir.
4. Eğer tüm işlemler başarılı ise, transaction tamamlanır.
5. Bir hata durumunda ise tüm işlemler geri alınır.


# 6 - Repository Design Pattern

**Repository Design Pattern**, yazılım geliştirme süreçlerinde veri erişimini düzenlemek ve yönetmek amacıyla kullanılan bir tasarım desenidir. Bu desenin temel amacı, veri tabanı işlemlerini soyutlamak, veri erişim işlemlerini daha modüler hale getirmek ve veri erişimini iş mantığından ayırmaktır. Repository deseni, veritabanıyla ilgili tüm işlemleri tek bir merkezi yapı altında toplar ve veri erişimini kolaylaştırır.

## Repository Tasarım Deseni’nin Amacı ve Avantajları

### 1. Veri Erişimini Soyutlama ve İzolasyon
Repository deseni, veri erişimini soyutlayarak uygulama kodunu veritabanı detaylarından ayırır. Bu sayede, iş mantığını yazarken veri tabanı ile ilgili işlemlerle uğraşmaya gerek kalmaz ve veri erişim kodları bağımsız hale gelir. 

### 2. Kodun Daha Bakımı Kolay Olması
Veri erişim kodları tek bir yerde toplandığı için, veritabanında yapılan bir değişikliğin iş mantığına etkisi minimize edilir. Veritabanı yapısında bir değişiklik gerektiğinde yalnızca repository sınıflarında düzenleme yaparak ilgili işlemler güncellenebilir.

### 3. Daha İyi Test Edilebilirlik
Veri erişim işlemlerini soyutladığı için, iş mantığını test etmek istediğinizde veri tabanı detayları ile uğraşmanıza gerek kalmaz. Repository sınıflarını mock ederek veya sahte veri kaynaklarıyla çalıştırarak kolayca birim testi yapılabilir. 

### 4. Yeniden Kullanılabilirlik
Veri erişim kodunu merkezi bir yere toplamak, farklı uygulama bölümlerinin aynı veri kaynaklarına erişimini sağlar. Bu, tekrar kullanılabilir kod yapısına olanak tanır ve genel kod kalitesini artırır.

## Repository Tasarım Deseni’nin Bileşenleri

1. **Repository Interface (Depo Arayüzü)**: Veritabanı nesneleri için gerekli veri erişim işlemlerini tanımlar. Genellikle `Add`, `Update`, `Delete`, `GetById`, ve `GetAll` gibi temel CRUD işlemleri bu arayüzde yer alır.

2. **Concrete Repository (Somut Depo Sınıfı)**: Interface’de tanımlanan veri erişim işlemlerini gerçekleyen sınıftır. Veri tabanına erişimi sağlar ve interface’in gerektirdiği yöntemleri uygular. 

3. **Entity (Varlık)**: Veritabanındaki tablolara karşılık gelen nesnelerdir. Bu nesneler, repository sınıfında yapılan veri işlemlerinde kullanılır.

4. **Service Layer (Hizmet Katmanı)**: İş mantığını temsil eden katmandır. Service Layer, repository sınıfını kullanarak veri erişim işlemlerini gerçekleştirir.

## Repository Tasarım Deseni’nin Kullanım Alanları

- **Büyük ve Karmaşık Uygulamalar**: Çok sayıda veri tabanı tablosu bulunan, veri işlemlerinin yoğun olduğu uygulamalarda.
- **E-Ticaret Uygulamaları**: Müşteri, ürün, sipariş gibi çoklu veri kaynaklarının bulunduğu sistemlerde.
- **Finansal Uygulamalar**: Finansal verilerin sık güncellenmesi gereken sistemlerde veri erişimini kolaylaştırır.

## Repository Pattern’in Çalışma Akışı

1. **Veri Erişim İşlemlerinin Tanımlanması**: Repository arayüzü, CRUD işlemlerini tanımlar.
2. **Veritabanı İşlemlerinin Gerçeklenmesi**: Concrete Repository sınıfı, bu CRUD işlemlerini gerçekleştirir.
3. **İş Mantığı Katmanının Kullanması**: İş mantığı katmanı, Repository arayüzünü kullanarak veri işlemlerini gerçekleştirir ve veri erişim detaylarından izole edilir.
4. **Birden Fazla Uygulama Katmanında Kullanımı**: Repository sınıfları, farklı uygulama katmanları tarafından veri erişimi için kullanılabilir.

## Repository Design Pattern Kullanmanın Avantajları

- **Bakımı Kolaylaştırır**: Veri erişim kodları tek bir noktada toplandığı için bakım daha kolay hale gelir.
- **Kodun Test Edilebilirliğini Artırır**: Mock sınıflarla veri tabanına ihtiyaç duymadan test yapılabilir.
- **Kodun Modüler Yapıda Olmasını Sağlar**: Veri erişim ve iş mantığı ayrıldığı için kod daha düzenli hale gelir ve daha kolay genişletilebilir.

Repository Pattern, yazılım geliştirme süreçlerinde veri tabanı işlemlerini düzenleyerek kodun daha temiz, modüler ve test edilebilir olmasını sağlar.


# 7 - Composite Design Pattern

**Composite Design Pattern**, bir "bütün ve parçaları" ilişkisini temsil eden ve nesneler arası hiyerarşik bir yapı oluşturan bir tasarım desenidir. Bu desen, bir nesnenin içinde diğer nesneleri içerebileceği, bu nesnelerin gruplarını oluşturabileceği ve böylece tekil nesnelerin veya nesne gruplarının aynı şekilde ele alınabilmesini sağlar. Yapısal bir tasarım deseni olarak Composite, özellikle hiyerarşik yapılarda, yani nesnelerin ağaç yapısında organize edildiği durumlarda kullanılır.

## Composite Tasarım Deseni’nin Amacı ve Avantajları

### 1. Bütün-Parça İlişkisini Yönetme
Composite deseni, istemcinin hem tekil nesnelerle hem de nesne gruplarıyla aynı arayüz aracılığıyla etkileşime girmesini sağlar. Böylece, istemci kodu bir nesnenin tekil bir nesne mi yoksa grup mu olduğunu ayırt etmek zorunda kalmaz.

### 2. Kodun Basitleştirilmesi
Bu desen, istemci kodunu basitleştirerek karmaşıklığı azaltır. Tek bir nesne veya nesne grubu üzerinde işlem yapılması gerektiğinde istemcinin yalnızca ana nesneye erişmesi yeterlidir; alt bileşenlere tek tek erişmesi gerekmez.

### 3. Kod Tekrarını Azaltma ve Bakımı Kolaylaştırma
Tekil nesneler ve kompozit yapılar aynı arayüz aracılığıyla yönetildiği için kod tekrarını azaltır ve bakımı kolaylaştırır. Yeni nesne türleri eklemek gerektiğinde sadece yeni bir **Leaf** veya **Composite** türü oluşturmak yeterlidir.

## Composite Tasarım Deseni’nin Bileşenleri

1. **Component (Bileşen)**: Tekil nesnelerin ve kompozit yapıların ortak özelliklerini tanımlar. Bu bileşen, **Leaf** ve **Composite** nesnelerin kullanacağı ortak bir arayüzdür. Örneğin, bir `display` veya `add` metodu burada tanımlanabilir.

2. **Leaf (Yaprak)**: Kompozit yapının en alt seviyesinde yer alan ve kendi başına işlem yapabilen bağımsız bileşenlerdir. Genellikle, alt bileşen içermezler ve en temel işlemleri sağlarlar.

3. **Composite (Kompozit)**: Diğer bileşenleri içerebilen bir bileşendir. Alt bileşenleri listeleyebilir, yeni bileşenler ekleyebilir veya mevcut bileşenleri çıkarabilir. Böylece, bir ağaç yapısındaki dalları temsil eder.

## Composite Tasarım Desenini Kullanma Durumları

- **Düzensiz Bir Nesne Yapısı Varsa**: Nesnelerden oluşan bir grup ve tekil nesnelerle çalışılıyorsa.
- **Tekil ve Gruplu Nesnelerin Aynı İşlemleri Yapması Gerekiyorsa**: Örneğin, tek bir dosyanın açılması veya bir dosya grubunun topluca açılması gibi.
- **Hiyerarşik Nesneler Gerekiyorsa**: Menü yapıları, grafik nesneleri, belge ağaçları gibi hiyerarşik yapılar oluşturulması gereken durumlarda.

## Composite Design Pattern Çalışma Akışı

1. **Arayüz Tanımlama**: `Component` arayüzü, tüm bileşenler için ortak olan işlemleri tanımlar.
2. **Leaf ve Composite Nesnelerinin Oluşturulması**: `Leaf` sınıfı tekil nesneleri tanımlar; `Composite` sınıfı ise birden fazla bileşeni tutarak işlemleri gruplar.
3. **Ağaç Yapısının Oluşturulması**: `Composite` nesneleri içine `Leaf` nesneleri eklenerek bir ağaç yapısı oluşturulur.
4. **İstemci Kodunun Basitleştirilmesi**: İstemci kodu, her bir nesnenin kompozit mi yoksa yaprak mı olduğunu ayırt etmek zorunda kalmadan, ağaç yapısındaki tüm nesnelerle tek bir arayüz üzerinden işlem yapabilir.

## Composite Design Pattern Kullanmanın Avantajları

- **Kodun Basit ve Okunabilir Olması**: İstemci kodunun ağaç yapısındaki alt bileşenlerle tek tek uğraşmasına gerek kalmaz.
- **Modüler ve Genişletilebilir Yapı**: Yeni bileşen türleri eklemek ve hiyerarşiyi genişletmek kolaydır.
- **Karmaşıklığı Azaltma**: Ağaç yapısı sayesinde, nesneler arası ilişkiler basitçe yönetilebilir.
  
**Composite Design Pattern**, hiyerarşik yapıları ve nesneler arası bağımlılıkları yönetmek isteyen yazılımlar için oldukça yararlı ve esnek bir çözümdür.







