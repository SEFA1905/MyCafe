﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCafeApp;
using MyCafeDAL.Concrete.EF;
using MyCafeDAL.Entities;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCafeMVCApp.Controllers
{


    public class ImageController : Controller
    {


        public async Task<ActionResult> ImageSef()
        {
            

            


            //byte[] photoBack = item.ProductImage;
            //string imreBase64Data = Convert.ToBase64String(photoBack);
            //string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
            ////Passing image data in viewbag to view  
            //ViewBag.ImageData = imgDataURL;
            return View();



        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


       
    }
}

