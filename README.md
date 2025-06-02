# :boom: C# Eğitim Kampı (YouTube)

Merhabalar. Bu repomda Murat Yücedağ'ın Udemy üzerinden vermiş olduğu Asp.Net Core ile Portfolio Uygulamanızı Geliştirin Part 1 & Part 2 eğitimlerini tamamlayarak projeyi en kullanılabilir hale getirmeye çalıştım. Aşağıya projede yapılan işlemler ve resimler eklenmiştir :blush: 


# :sunny: Proje 28  Proje: Finansal Crm Uygulaması 1
Bu projede; Entity framework kullandık ve Dbfirst ile ilerledik. MsSql de FinancialCrmDb isimli bir veri tabanı oluşturup gerekli tablolarımızı(Categories, Banks, BankProcesses, Bills, Spendings, Users) oluşturduk. C# tarafında FinancialCrm isimli yeni bir form projesi açıp çerisine de FrmBanks isimli form oluşturduk. Bu formu bir banka sayfası tasarımına benzetmeye çalıştık. Ayrıca son 5 banka işlemini de bu formda gösterdik.

![FrmBanks](https://github.com/DemirbasAlperen/CSharpEgitimKampiFinancialCrm/blob/master/FrmBanks.png)

# :sunny: Proje 29  Proje: Finansal Crm Uygulaması 2
Bu projede; ilk olarak proje içine Models isimli bir klasör ekledik. Sonra bu klasör içine Entity Framework dersinde kullandığımız Model ekleme işlemini burada uyguladık ve Entityframework paketlerini yüklemiş olduk. Sql de oluşturduğumuz diyagram kod sayfamıza da eklenmiş oldu. Sonrasında FrmBilling isimli yeni bir form açıp FrmBanks ile aynı tasarımı kullanarak formu düzenledik. Burada ödeme işlemleri ile ilgili kısımlar tamamlandı. Son olarak FrmBanks ve FrmBilling formunu birbiri ile ilişkilendirip formlar arasında geçişler yapabildik.

![FrmBilling](https://github.com/DemirbasAlperen/CSharpEgitimKampiFinancialCrm/blob/master/FrmBilling.png)

# :sunny: Proje 30  Proje: Finansal Crm Uygulaması Final Dersi
Bu projede; projemize kaldığımız yerden devam ederek FrmDashboard isimli yeni form sayfası açıp tasarımını diğer fromlar ile aynı şekilde düzenledik. Burada önce toplam bakiyemizi gösterdik, faturalarımızı her saniyede biri ekranda görünecek şekilde(form içine timer ekleyerek) ayarladık, gelen son havaleyi göstermesi için de bir ekran tasarladık. Son olarak formumuza 2 tane grafik ekleyerek verilerimizi grafik üzerinde gösterdik.  

![FrmDashboard](https://github.com/DemirbasAlperen/CSharpEgitimKampiFinancialCrm/blob/master/FrmDashboard.png)

# :sunny: C# Eğitim Kampı Final Case
Final Case ini Login(FrmLogin) ve Kategoriler(FrmCategory) formunu yaparak tamamladım. Formlar arasında ilişki kurarak tüm formlar arasında geçiş sağladım. Kategoriler formuna da listeleme, ekleme, silme, güncelleme gibi buton işlemlerini de ekledim. Son olarak form sayfalarında bulunan Çıkış Yap butonu da aktifleştirildi, bu butona basınca Login sayfası açılıyor. Kullanıcı adı: admin, Şifre: 1234 olarak Sql tarafında ayarlanmıştı. 

![FrmCategory](https://github.com/DemirbasAlperen/CSharpEgitimKampiFinancialCrm/blob/master/FrmCategory.png)

![FrmLogin](https://github.com/DemirbasAlperen/CSharpEgitimKampiFinancialCrm/blob/master/FrmLogin.png)

