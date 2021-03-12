<h1 align="center">Rent A Car Project </h1> 

<p align="center">
  <img src="![7ea95489e10ca7ae9a4a6e9b4a322b16](https://user-images.githubusercontent.com/77547474/110973340-31cb9980-836e-11eb-9bb2-74a85590c845.gif)
" width="550" alt="Rent A Car">
</p>


## Project Presentation
##### - Rent A Car Project , içerisinde bir çok dinamik metot barındıran ve sürdürülebilir bir kod mimarisi ile tasarlanan 'Araba Kiralama Sistemi' projesidir.   
##### - Proje Temelde [Business](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Business) , [Console](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Console) ,[DataAccess](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/DataAccess) ve [Entities](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Entities) kısımlarından oluşan çok katmanlı bir mimari üzerine inşa edilmiştir.
##### - Proje tasarımı sürecinde SOLID prensipleri dikkate alınmış ve temel amaç CleanCode olmak üzere bir çok yeniden düzenleme yapılmıştır ve yapılmaya devam ediyor.
##### - Projenin çıkış noktası [Kodlama.io](https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi) platformu üzerinden [Engin Demiroğ](https://github.com/engindemirog) tarafından oluşturulan ' Yazılım Geliştirici Yetiştirme Kampıdır. '
<br>
<br>

## Installation

```bash
# Clone to repository
$ git clone https://github.com/u9urturk/ReCapProject-Rent-A-Car.git

# Go to the folder you cloned
$ cd ReCapProject-Rent-A-Car

# Install dependencies
$ dotnet restore
```


## Project Development Process
☑️ CRUD Operasyonları Oluşturuldu.   

☑️ WebAPI katmanı Kuruldu.   
      ➕ Projeyi WebAPI Katmanı Üzerinde [Set as Start Up Project](https://user-images.githubusercontent.com/77547474/110627242-c7222e80-81b2-11eb-8970-6b5da04cd913.png) Diyerek  Çalıştırabilir Ve [PostMan](https://www.postman.com/) Aracılığıyla Sisteme İstekte Bulunabilirsiniz.
     ↘️ ![wepapi](https://user-images.githubusercontent.com/77547474/110627242-c7222e80-81b2-11eb-8970-6b5da04cd913.png)

☑️ Autofac Desteği Eklendi.    

☑️ FluentValidation Desteği Eklendi.    

☑️ AOP Desteği Eklendi.    

☑️ JWT Entegrasyonu Yapıldı.    

☑️ Cache Transaction Ve Performance Aspectleri Eklendi.    

☑️ Performance Aspectler Tüm Metotlara Tanımlandı Ve Olası Performans Bilgileri Email Yoluyla Loglanabilmesi Amacıyla SendMail Operasyonu Geliştirildi.    

❗ İncelemek isterseniz ilgili kodlar burada : [PerformanceAspect](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs) , [SendMail](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Core/Utilities/SendMail)     

![SendMail](https://user-images.githubusercontent.com/77547474/110551225-3150ba00-8146-11eb-94e6-97bd155291dc.PNG)        
         <br>
 ##### Sunucu Gmail Olarak Ayarlanmıştır..
  ↘️
  ![SendMailInfo](https://user-images.githubusercontent.com/77547474/110622852-15343380-81ad-11eb-9f35-fbed3252ee60.PNG)

##### ❗ Operasyonun Verimli Çalışabilmesi İçin Alıcı Ve Gönderici Gmail Hesapları Üzerinde Bazı Değişikler Yapılması Gerekmekte.    
   ↘️ Gönderici Gmail Üzerinde Yapılması Gerekenler    
   ![Gönderici](https://user-images.githubusercontent.com/77547474/110623428-de125200-81ad-11eb-83b1-0e89a58ba0ec.PNG)
   <br>
   <br>
   ↘️ Alıcı Gmail Üzerinde Yapılması Gerekenler     
   ![Alıcı](https://user-images.githubusercontent.com/77547474/110624338-1bc3aa80-81af-11eb-9719-9c36e44ed4b1.PNG)


       
       
        
☑️ Temel Metotlara Ek Kira Süreci Tamamlanmış Araçların Dönüşü Durumunda Kullanılmak Üzere [UpdateAndMove](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) Metodu Geliştirildi.    
<br>
      ↘️ Method İle İlgili Görseller      
            ![UpdateAndMove](https://user-images.githubusercontent.com/77547474/110555188-3107ed00-814d-11eb-9f7e-29d75b79f773.PNG)     
            ![ReturnedCar](https://user-images.githubusercontent.com/77547474/110555522-c7d4a980-814d-11eb-845c-a24e008eb037.PNG)    
            

☑️ Geliştirilen Metotları Test Etmek Amacıyla Bir MetotTester Oluşturuldu           
📙 ilgili Kodlar : [MetotTester](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/Console/Program.cs/)      
    
   ↘️ Method Tester Görselleri 
   <p align="center">
  <img src="https://media.giphy.com/media/2S2EyOrlLl0A6dLLjP/giphy.gif" width="600"<br>
  
☑️ Cors Servisi Eklendi<br>
<br>
☑️ Projenin [FrontEnd](https://github.com/u9urturk/ReCapProject-Rent-A-Car-Front-end) Geliştirme Süreci Başladı
   
     
<br>   

## SQL Query    
📘 [Query](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/SQLQuery.sql)  ❗ İncelemek İsteyenler İçin Tablolarım.


## Tables in Database
<table>
  <tr>
     <td>Brands</td>
     <td>CarImages</td>
     <td>Cars</td>
     <td>Colors</td>
     <td>Customers</td>
     <td>OperationClaims</td>
     <td>Rentals</td>
     <td>UserOperationClaims</td>
     <td>Users</td>
    <td>RentArchives</td>
  </tr>
  <tr>
    <td>
      
Variable Name | Data Type
------------ | -------------
Id | INT
BrandName | NVARCHAR(20)

   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
ImagePath | NVARCHAR(MAX)
Date | DATETİME
   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
CarId | INT
CarName | NCHAR(20)
BrandId | INT
ColorId | INT
ModelYear | NVARCHAR(25)
DailyPrice | DECIMAL(18)
Description | NCHAR(50)

   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
ColorId | INT
ColorName | NVARCHAR(20)

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
CompanyName | NVARCHAR(50)

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
Name  | VARCHAR(250)

   </td>
   <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
CustomerId | INT
RentDate | DATETIME
ReturnDate | DATETIME

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
OperationId | INT

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
FirstName | VARCHAR(50)
LastName | VARCHAR(50)
Email | VARCHAR(50)
PasswordHash | VARBINARY (500)
PasswordSalt | VARBINARY (500)
Status | BIT

   </td>
    <td>
  
variable Name | Data Type
------------ | -------------
Id|INT
CarId|INT
CustomerId|INT
RentDate|DATETİME
ReturnDate|DATETİME

   </td>
  </tr>
 </table>

<br>
<br>
<br>
<br>


## License
[MIT©Uğur Türk](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/LICENSE)





    



