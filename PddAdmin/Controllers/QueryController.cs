using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PddAdmin.Models;

namespace PddAdmin.Controllers
{
    public class QueryController : Controller
    {
        private IHostingEnvironment _env;
        private PDDContext _pDDContext;


        public QueryController(IHostingEnvironment env, PDDContext pDDContext)
        {
            _env = env;
            _pDDContext = pDDContext;
        }

        public IActionResult GetAllResources() {

            var allQuery = _pDDContext.QueryItem.ToList();
            foreach (var qr in allQuery)
            {
                qr.Responses = _pDDContext.Responses.Where(elm => elm.QueryId == qr.Id).ToList();
            }
            var jsonSerialized = JsonConvert.SerializeObject(allQuery);
            return Ok(jsonSerialized);
        }

        // GET: Query
        public ActionResult AllQueries()
        {
            var allQuery = _pDDContext.QueryItem.ToList();
            foreach (var qr in allQuery) {
                qr.Responses = _pDDContext.Responses.Where(elm => elm.QueryId == qr.Id).ToList();
            }
            var groupedTests = allQuery.GroupBy(el => el.ChapterKey).ToList();
            return View("AllQueries", groupedTests);
        }

        public ActionResult AllQueriesOld()
        {
            var allQuery = _pDDContext.QueryItem.ToList();
            foreach (var qr in allQuery)
            {
                qr.Responses = _pDDContext.Responses.Where(elm => elm.QueryId == qr.Id).ToList();
            }
            return View("AllQueriesOld", allQuery);
        }

        // Get: All images 
        public ActionResult AllImages() 
        {
            var allQuery = _pDDContext.QueryItem.ToList();
            return View(allQuery);
        }

        [HttpGet]
        public ActionResult ViewQuery(int Id)
        {
            PddAdmin.Model.QueryItem queryItem = new Model.QueryItem();
            var model = _pDDContext.QueryItem.FirstOrDefault(it => it.Id == Id);
            if (model != null)
            {
                model.Responses = _pDDContext.Responses.Where(el => el.QueryId == model.Id).ToList();
                queryItem.Id = model.Id;
                queryItem.ChapterKey = model.ChapterKey;
                queryItem.ImageUri = model.ImageUri;
                queryItem.Query = model.Query;
                queryItem.Responses = model.Responses.Select(el => new Model.Responses { IsRight = el.IsRight, Id = el.Id,QueryId=el.QueryId, Response=el.Response }).ToList();
                queryItem.Thema = model.Thema;
                queryItem.Comment = model.Comment;
            }

            return CreateQuery(queryItem);
        }

        [HttpGet]
        public ActionResult CreateQuery(PddAdmin.Model.QueryItem query)
        {

            return View("CreateQuery",query);
        }

        [HttpPost]
        public ActionResult Create(PddAdmin.Model.QueryItem model)
        {
            try
            {

                var resp = model.Responses.Select(itm => new Responses
                {
                    Id = itm.Id,
                    IsRight = itm.IsRight,
                    Response = itm.Response,
                }).ToList();

                var istrue=ModelState.IsValid;

                string imagePath = model.ImageUri ?? UploadedFile(model.ImageFile, model.ChapterKey);

                QueryItem modelTemp = new QueryItem
                {
                    Comment = model.Comment,
                    Id = model.Id,
                    ImageUri = imagePath,//model.ImageUri,
                    ChapterKey=model.ChapterKey,
                    Query = model.Query,
                    Thema = model.Thema,
                    Responses=resp.ToList(),
                };
                _pDDContext.QueryItem.Add(modelTemp);
                _pDDContext.SaveChanges();
                model.Id = modelTemp.Id;
            }
            catch (Exception ex)
            {
                var exMes = ex.Message;
            }
            return ViewQuery(model.Id);
        }

        [HttpPost]
        public ActionResult UpdateQuery(PddAdmin.Model.QueryItem model) {

            var query = _pDDContext.QueryItem.FirstOrDefault(el=>el.Id==model.Id);
            if (query!=null)
            {
                if (!string.IsNullOrEmpty(query.ImageUri) && model.ImageFile!=null)
                {
                    string BasePath = _env.WebRootPath + "\\img\\";
                    FileInfo imagePdd = new FileInfo(BasePath + query?.ImageUri.Split("/").LastOrDefault());
                    if (!string.IsNullOrEmpty(query.ImageUri) && imagePdd.Exists)
                        imagePdd.Delete();
                }
                

                var remoVeres = _pDDContext.Responses.Where(el => el.QueryId == model.Id).ToList();
                _pDDContext.RemoveRange(remoVeres);

                var respUpdated = model.Responses.Select(el => new Responses { IsRight = el.IsRight, Response = el.Response }).ToList();
                string imagePath = model.ImageUri ?? UploadedFile(model.ImageFile, model.ChapterKey);

                query.Comment = model.Comment;
                query.Id = model.Id;
                query.ImageUri = model.ImageFile != null ? imagePath : query.ImageUri;
                query.ChapterKey = model.ChapterKey;
                query.Query = model.Query;
                query.Thema = model.Thema;
                query.Responses = respUpdated;
                _pDDContext.SaveChanges();
            }
            return AllQueries();
        }

        public ActionResult Delete(int Id)
        {
            var elm = _pDDContext.QueryItem.FirstOrDefault(el => el.Id == Id);
            if (elm!=null) {
                _pDDContext.QueryItem.Remove(elm);
                _pDDContext.SaveChanges();
                string BasePath = _env.WebRootPath + "\\img\\";

                if(string.IsNullOrEmpty(elm.ImageUri))
                    return AllQueries();

                FileInfo imagePdd = new FileInfo(BasePath + elm?.ImageUri.Split("/").LastOrDefault());
                if (!string.IsNullOrEmpty(elm.ImageUri) && imagePdd.Exists)
                    imagePdd.Delete();
            }
            return AllQueries();
        }

        #region private Models
        private string UploadedFile(IFormFile image, string key = "defVal")
        {
            string BasePath = _env.WebRootPath+ "\\img\\" + key;
            string uniqueImageName="";
            if (image != null)
            {
                try
                {
                    var extension = "." + image.FileName.Split('.')[image.FileName.Split('.').Length - 1];
                    uniqueImageName = Guid.NewGuid().ToString() + extension; //Create a new Name for the file due to security reasons.
                    var path = Path.Combine(BasePath, uniqueImageName);
                    if (!Directory.Exists(BasePath))
                    {
                        Directory.CreateDirectory(BasePath);
                    }

                    using (var bits = new FileStream(path, FileMode.Create))
                    {
                        //await image.CopyToAsync(bits);
                        image.CopyTo(bits);
                    }
                }
                catch (Exception e)
                {
                    return e.Message;
                }
                return "/" + key + "/" + uniqueImageName;
            }
            return null;
        }
        #endregion



    }
}