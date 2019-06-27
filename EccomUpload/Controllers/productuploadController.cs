using EccomUpload.DAL;
using EccomUpload.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EccomUpload.Controllers
{
    public class productuploadController : Controller
    {
      private  MaliMaliEntities db = new MaliMaliEntities();
        string URL =  ConfigurationManager.AppSettings["PicURL"]+"";
        // GET: productupload
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Products_Table productTable)
        {
            
                string fileName = Path.GetFileNameWithoutExtension(productTable.ImageFile.FileName);
                string extension = Path.GetExtension(productTable.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                productTable.Product_Image = URL + "/Image/" + fileName;
                fileName = Path.Combine(Server.MapPath("/Image/"), fileName);
                productTable.ImageFile.SaveAs(fileName);
                db.products.Add(productTable);
                db.SaveChanges();
            
            ModelState.Clear();
            return View();

        }
       



    }
    
}