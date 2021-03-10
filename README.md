<h1 align="center">Rent A Car Project </h1> 

<p align="center">
  <img src="http://clipart-library.com/images/8czr74qEi.jpg" width="600" alt="Rent A Car">
</p>


## Project Presentation
##### - Rent A Car Project , içerisinde bir çok dinamik metot barındıran ve sürdürülebilir bir kod mimarisi ile tasarlanan 'Araba Kiralama Sistemi' projesidir.   
##### - Proje Temelde [Business](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Business) , [Console](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Console) , [Core](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Core) ,[DataAccess](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/DataAccess) , [Entities](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Entities) , [WepApi](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/WepAPI) kısımlarından oluşan çok katmanlı bir mimari üzerine inşa edilmiştir.
##### - Proje tasarımı sürecinde SOLİD prensipleri dikkate alınmıştır ve temel amaç CleanCode olmak üzere bir çok yeniden düzenleme yapılmıştır ve yapılmaya devam ediyor.
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

☑️ Autofac Desteği Eklendi.    

☑️ FluentValidation Desteği Eklendi.    

☑️ AOP Desteği Eklendi.    

☑️ JWT Entegrasyonu Yapıldı.    

☑️ Cache Transaction Ve Performance Aspectleri Eklendi.    

☑️ Performance Aspectler Tüm Metotlara Tanımlandı Ve Olası Performans Bilgileri Email Yoluyla Loglanabilmesi Amacıyla SendMail Operasyonu Geliştirildi.    

❗ İncelemek isterseniz ilgili kodlar burada : [PerformanceAspect](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs) , [SendMail](https://github.com/u9urturk/ReCapProject-Rent-A-Car/tree/master/Core/Utilities/SendMail)     

![SendMail](https://user-images.githubusercontent.com/77547474/110551225-3150ba00-8146-11eb-94e6-97bd155291dc.PNG)        
         <br>
      <br>
       
       
        
☑️ Temel Metotlara Ek Kira Süreci Tamamlanmış Araçların Dönüşü Durumunda Kullanılmak Üzere [UpdateAndMove](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) Metodu Geliştirildi.    
<br>
      ↘️ Method İle İlgili Görseller      
            ![UpdateAndMove](https://user-images.githubusercontent.com/77547474/110555188-3107ed00-814d-11eb-9f7e-29d75b79f773.PNG)     
            ![ReturnedCar](https://user-images.githubusercontent.com/77547474/110555522-c7d4a980-814d-11eb-845c-a24e008eb037.PNG)    
            
<br>
☑️ Geliştirilen Metotları Test Etmek Amacıyla Bir Metot Tester Oluşturuldu  
    
   ↘️ Method Tester Görselleri    
   ![KIZOA-Movie-Maker-n6i6jcxg](https://media.giphy.com/media/HvKsU2ARRo4mnn46QB/giphy.gif)
     
<br>   

##SQL Query    
📘 [Query](https://github.com/u9urturk/ReCapProject-Rent-A-Car/blob/master/SQLQuery.sql)     


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
  </tr>
  <tr>
    <td>
      
Variable Name | Data Type
------------ | -------------
Id | INT
BrandName | NVARCHAR(25)

   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
CarImagesDate | DATETIME
ImagePath | NVARCHAR(MAX)
   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
BrandId | INT
ColorId | INT
ModelYear | NVARCHAR(25)
DailyPrice | DECIMAL
Description | NVARCHAR(25)

   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
ColorName | NVARCHAR(25)

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
CustomerName | NVARCHAR(25)

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
  </tr>
 </table>




    



