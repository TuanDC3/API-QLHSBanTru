using API_QLHSBanTru.Models;
using API_QLHSBanTru.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_QLHSBanTru.Controllers
{
    [RoutePrefix("api/foodGroup")]
    public class FoodGroupController : ApiController
    {
        [Route("getall")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            IList<FoodGroupVm> lstFoodGroup = null;

            using (var ctx = new QLHSBanTruEntities())
            {
                lstFoodGroup = ctx.FoodGroups.Select(s => new FoodGroupVm()
                {
                    FoodGroupID = s.FoodGroupID,
                    Name = s.Name,
                    MinKcal = s.MinKcal,
                    MaxKcal = s.MaxKcal,
                    Status = s.Status
                }).ToList<FoodGroupVm>();
            }

            if (lstFoodGroup.Count == 0)
            {
                return NotFound();
            }

            return Ok(lstFoodGroup);
        }

        //[Route("detail/{id:int}")]
        //[HttpGet]
        //public HttpResponseMessage GetById(HttpRequestMessage request, int id)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        var model = _productService.GetById(id);

        //        var responseData = Mapper.Map<Product, ProductViewModel>(model);

        //        var response = request.CreateResponse(HttpStatusCode.OK, responseData);

        //        return response;
        //    });
        //}

        //[HttpPost]
        //[Route("add")]
        //public IHttpActionResult Create(StudentViewModel student)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest("Not a valid data");

        //    using (var ctx = new SchoolDBEntities())
        //    {
        //        ctx.Students.Add(new Student()
        //        {
        //            StudentID = student.Id,
        //            FirstName = student.FirstName,
        //            LastName = student.LastName
        //        });

        //        ctx.SaveChanges();
        //    }
        //    return Ok();
        //}

        //[HttpPost]
        //[Route("update")]
        //public IHttpActionResult Update(StudentViewModel student)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest("Not a valid data");

        //    using (var ctx = new SchoolDBEntities())
        //    {
        //        var existingStudent = ctx.Students.Where(s => s.StudentID == student.Id).FirstOrDefault<Student>();

        //        if (existingStudent != null)
        //        {
        //            existingStudent.FirstName = student.FirstName;
        //            existingStudent.LastName = student.LastName;

        //            ctx.SaveChanges();
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }
        //    }
        //    return Ok();
        //}

        //[HttpDelete]
        //[Route("delete")]
        //public IHttpActionResult Delete(int id)
        //{
        //    if (id <= 0)
        //        return BadRequest("Not a valid studet id");

        //    using (var ctx = new SchoolDBEntities())
        //    {
        //        var student = ctx.Students
        //            .Where(s => s.StudentID == id)
        //            .FirstOrDefault();

        //        ctx.Entry(student).State = System.Data.Entity.EntityState.Deleted;
        //        ctx.SaveChanges();
        //    }
        //    return Ok();
        //}

        //[Route("deletemulti")]
        //[HttpDelete]
        //public HttpResponseMessage DeleteMulti(HttpRequestMessage request, string checkedProducts)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        HttpResponseMessage response = null;
        //        if (!ModelState.IsValid)
        //        {
        //            response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        //        }
        //        else
        //        {
        //            var listProductCategory = new JavaScriptSerializer().Deserialize<List<int>>(checkedProducts);
        //            foreach (var item in listProductCategory)
        //            {
        //                _productService.Delete(item);
        //            }

        //            _productService.Save();

        //            response = request.CreateResponse(HttpStatusCode.OK, listProductCategory.Count);
        //        }

        //        return response;
        //    });
        //}

        //[Route("import")]
        //[HttpPost]
        //public async Task<HttpResponseMessage> Import()
        //{
        //    if (!Request.Content.IsMimeMultipartContent())
        //    {
        //        Request.CreateErrorResponse(HttpStatusCode.UnsupportedMediaType, "Định dạng không được server hỗ trợ");
        //    }

        //    var root = HttpContext.Current.Server.MapPath("~/UploadedFiles/Excels");
        //    if (!Directory.Exists(root))
        //    {
        //        Directory.CreateDirectory(root);
        //    }

        //    var provider = new MultipartFormDataStreamProvider(root);
        //    var result = await Request.Content.ReadAsMultipartAsync(provider);
        //    //do stuff with files if you wish
        //    if (result.FormData["categoryId"] == null)
        //    {
        //        Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bạn chưa chọn danh mục sản phẩm.");
        //    }

        //    //Upload files
        //    int addedCount = 0;
        //    int categoryId = 0;
        //    int.TryParse(result.FormData["categoryId"], out categoryId);
        //    foreach (MultipartFileData fileData in result.FileData)
        //    {
        //        if (string.IsNullOrEmpty(fileData.Headers.ContentDisposition.FileName))
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Yêu cầu không đúng định dạng");
        //        }
        //        string fileName = fileData.Headers.ContentDisposition.FileName;
        //        if (fileName.StartsWith("\"") && fileName.EndsWith("\""))
        //        {
        //            fileName = fileName.Trim('"');
        //        }
        //        if (fileName.Contains(@"/") || fileName.Contains(@"\"))
        //        {
        //            fileName = Path.GetFileName(fileName);
        //        }

        //        var fullPath = Path.Combine(root, fileName);
        //        File.Copy(fileData.LocalFileName, fullPath, true);

        //        //insert to DB
        //        var listProduct = this.ReadProductFromExcel(fullPath, categoryId);
        //        if (listProduct.Count > 0)
        //        {
        //            foreach (var product in listProduct)
        //            {
        //                _productService.Add(product);
        //                addedCount++;
        //            }
        //            _productService.Save();
        //        }
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, "Đã nhập thành công " + addedCount + " sản phẩm thành công.");
        //}

        //[HttpGet]
        //[Route("ExportXls")]
        //public async Task<HttpResponseMessage> ExportXls(HttpRequestMessage request, string filter = null)
        //{
        //    string fileName = string.Concat("Product_" + DateTime.Now.ToString("yyyyMMddhhmmsss") + ".xlsx");
        //    var folderReport = ConfigHelper.GetByKey("ReportFolder");
        //    string filePath = HttpContext.Current.Server.MapPath(folderReport);
        //    if (!Directory.Exists(filePath))
        //    {
        //        Directory.CreateDirectory(filePath);
        //    }
        //    string fullPath = Path.Combine(filePath, fileName);
        //    try
        //    {
        //        var data = _productService.GetListProduct(filter).ToList();
        //        await ReportHelper.GenerateXls(data, fullPath);
        //        return request.CreateErrorResponse(HttpStatusCode.OK, Path.Combine(folderReport, fileName));
        //    }
        //    catch (Exception ex)
        //    {
        //        return request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
        //    }
        //}

        //[HttpGet]
        //[Route("ExportPdf")]
        //public async Task<HttpResponseMessage> ExportPdf(HttpRequestMessage request, int id)
        //{
        //    string fileName = string.Concat("Product" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + ".pdf");
        //    var folderReport = ConfigHelper.GetByKey("ReportFolder");
        //    string filePath = HttpContext.Current.Server.MapPath(folderReport);
        //    if (!Directory.Exists(filePath))
        //    {
        //        Directory.CreateDirectory(filePath);
        //    }
        //    string fullPath = Path.Combine(filePath, fileName);
        //    try
        //    {
        //        var template = File.ReadAllText(HttpContext.Current.Server.MapPath("/Assets/admin/templates/product-detail.html"));
        //        var replaces = new Dictionary<string, string>();
        //        var product = _productService.GetById(id);

        //        replaces.Add("{{ProductName}}", product.Name);
        //        replaces.Add("{{Price}}", product.Price.ToString("N0"));
        //        replaces.Add("{{Description}}", product.Description);
        //        replaces.Add("{{Warranty}}", product.Warranty + " tháng");

        //        template = template.Parse(replaces);

        //        await ReportHelper.GeneratePdf(template, fullPath);
        //        return request.CreateErrorResponse(HttpStatusCode.OK, Path.Combine(folderReport, fileName));
        //    }
        //    catch (Exception ex)
        //    {
        //        return request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
        //    }
        //}

        //private List<Product> ReadProductFromExcel(string fullPath, int categoryId)
        //{
        //    using (var package = new ExcelPackage(new FileInfo(fullPath)))
        //    {
        //        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
        //        List<Product> listProduct = new List<Product>();
        //        ProductViewModel productViewModel;
        //        Product product;

        //        decimal originalPrice = 0;
        //        decimal price = 0;
        //        decimal promotionPrice;

        //        bool status = false;
        //        bool showHome = false;
        //        bool isHot = false;
        //        int warranty;

        //        for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
        //        {
        //            productViewModel = new ProductViewModel();
        //            product = new Product();

        //            productViewModel.Name = workSheet.Cells[i, 1].Value.ToString();
        //            productViewModel.Alias = StringHelper.ToUnsignString(productViewModel.Name);
        //            productViewModel.Description = workSheet.Cells[i, 2].Value.ToString();

        //            if (int.TryParse(workSheet.Cells[i, 3].Value.ToString(), out warranty))
        //            {
        //                productViewModel.Warranty = warranty;
        //            }

        //            decimal.TryParse(workSheet.Cells[i, 4].Value.ToString().Replace(",", ""), out originalPrice);
        //            productViewModel.OriginalPrice = originalPrice;

        //            decimal.TryParse(workSheet.Cells[i, 5].Value.ToString().Replace(",", ""), out price);
        //            productViewModel.Price = price;

        //            if (decimal.TryParse(workSheet.Cells[i, 6].Value.ToString(), out promotionPrice))
        //            {
        //                productViewModel.PromotionPrice = promotionPrice;
        //            }

        //            productViewModel.Content = workSheet.Cells[i, 7].Value.ToString();
        //            productViewModel.MetaKeyword = workSheet.Cells[i, 8].Value.ToString();
        //            productViewModel.MetaDescription = workSheet.Cells[i, 9].Value.ToString();

        //            productViewModel.CategoryID = categoryId;

        //            bool.TryParse(workSheet.Cells[i, 10].Value.ToString(), out status);
        //            productViewModel.Status = status;

        //            bool.TryParse(workSheet.Cells[i, 11].Value.ToString(), out showHome);
        //            productViewModel.HomeFlag = showHome;

        //            bool.TryParse(workSheet.Cells[i, 12].Value.ToString(), out isHot);
        //            productViewModel.HotFlag = isHot;

        //            product.UpdateProduct(productViewModel);
        //            listProduct.Add(product);
        //        }
        //        return listProduct;
        //    }
        //}

        //[Route("gettags")]
        //[HttpGet]
        //public HttpResponseMessage GetTags(HttpRequestMessage request, string text)
        //{
        //    Func<HttpResponseMessage> func = () =>
        //    {
        //        var model = _productService.GetListProductTag(text);

        //        var responseData = Mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(model);

        //        var response = request.CreateResponse(HttpStatusCode.OK, responseData);
        //        return response;
        //    };
        //    return CreateHttpResponse(request, func);
        //}
    }
}