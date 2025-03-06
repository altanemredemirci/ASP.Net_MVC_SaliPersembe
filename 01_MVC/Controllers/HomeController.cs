using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_MVC.Controllers
{
    public class HomeController : Controller
    {
        //Controller i�indeki IActionResult d�nd�ren b�t�n metotlar bir view i olu�turur.
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
 
ASP.Net Microsoft firmas� taraf�ndan web geli�tiricilere sunulan bir frameworkt�r.

ASP Web geli�tirme komutlar�n�n tan�mland��� aland�r.

.Net: C# dili ile geli�tirilen Web,Mobile,Console,Desktop,Game,IOT,WPF,Machine Learning gibi proje �ablonlar�n�n ortak bir platform da geli�tirilmesine ve ileti�im-data transfer yap�lmas� sa�lar.

Design pattern: B�t�nl�k olu�turan bir yap�n�n mant�kl� ve i�levsel b�l�mlere ayr�lmas�d�r. B�l�mlere ay�rarak geli�tirlebilirli�i ve kontrol� artt�r�l�r.

MVC 1979 y�l�nda geli�tirilmi� bir design patternd�r ama ASP.net 2009 y�l�nda geli�tirilmi�tir.

MVC bir User Interface mimarisidir.
 
Model:UI k�sm�dan kullan�lan class tan�mlar�n�n oldu�u klas�r.
View :Kullan�c�n�n g�rd��� html,css lerden olu�an web tasar�m sayfalar�n�n oldu�u klas�r.
Controller: Kullan�c�dan gelen requestleri y�neten UI proje y�netim klas�r�.
 
 
 
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