using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EccomUpload.Controllers
{
    public class productuploadController : Controller
    {
      private  MaliMaliEntities db = new MaliMaliEntities();
        // GET: productupload
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(product productTable)
        {
            
                string fileName = Path.GetFileNameWithoutExtension(productTable.ImageFile.FileName);
                string extension = Path.GetExtension(productTable.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                productTable.Product_Image = "http://192.168.43.182:91" + "/Image/" + fileName;
                fileName = Path.Combine(Server.MapPath("/Image/"), fileName);
                productTable.ImageFile.SaveAs(fileName);
                db.products.Add(productTable);
                db.SaveChanges();
                
               

           
            
            ModelState.Clear();
            return View();

        }
       



    }
    
}