using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
   [HttpGet("/")]
   public ActionResult Index()
   {
     return View();
   }
   [HttpPost("/outputresult")]
     public ActionResult OutputResult()
     {
       CountRepeats newWord = new CountRepeats (
       Request.Form["UserInputWord"],
       Request.Form["UserInputString"]);
       return View (newWord);
     }
   }
 }
