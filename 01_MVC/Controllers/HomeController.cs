using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_MVC.Controllers
{
    public class HomeController : Controller
    {
        //Controller içindeki IActionResult döndüren bütün metotlar bir view i oluþturur.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

/*
 
ASP.Net Microsoft firmasý tarafýndan web geliþtiricilere sunulan bir frameworktür.

ASP Web geliþtirme komutlarýnýn tanýmlandýðý alandýr.

.Net: C# dili ile geliþtirilen Web,Mobile,Console,Desktop,Game,IOT,WPF,Machine Learning gibi proje þablonlarýnýn ortak bir platform da geliþtirilmesine ve iletiþim-data transfer yapýlmasý saðlar.

Design pattern: Bütünlük oluþturan bir yapýnýn mantýklý ve iþlevsel bölümlere ayrýlmasýdýr. Bölümlere ayýrarak geliþtirlebilirliði ve kontrolü arttýrýlýr.

MVC 1979 yýlýnda geliþtirilmiþ bir design patterndýr ama ASP.net 2009 yýlýnda geliþtirilmiþtir.

MVC bir User Interface mimarisidir.
 
Model:UI kýsmýdan kullanýlan class tanýmlarýnýn olduðu klasör.
View :Kullanýcýnýn gördüðü html,css lerden oluþan web tasarým sayfalarýnýn olduðu klasör.
Controller: Kullanýcýdan gelen requestleri yöneten UI proje yönetim klasörü.
 
 
 
**NTIER

#Entity
User.cs{
Id
name
username
email
password
address
 }

#UI
login.html  loginModel.cs {Username,Password}
register.html  registerModel.cs{Username,name,email,address,password,repassword}

 
 */