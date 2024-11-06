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

## CQRS (Command Query Responsibility Segregation) Design Pattern :
