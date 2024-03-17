using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebBanHangLaptop.Models;
using WebBanHangLaptop.Repository;

namespace WebBanHangLaptop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        //public IActionResult Add()
        //{
        //    var categories = _categoryRepository.GetAllCategories();
        //    ViewBag.Categories = new SelectList(categories, "Id", "Name");
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Add(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productRepository.Add(product);
        //        return RedirectToAction("Index"); 
        //    }
        //    return View(product);
        //}
        // Các actions khác như Display, Update, Delete
        // Display a list of products
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }
        //// Display a single product
        //public IActionResult Display(int id)
        //{
        //    var product = _productRepository.GetById(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}
        //// Show the product update form
        //public IActionResult Update(int id)
        //{
        //    var product = _productRepository.GetById(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}
        //// Process the product update
        //[HttpPost]
        //public IActionResult Update(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productRepository.Update(product);
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}
        //// Show the product delete confirmation
        //public IActionResult Delete(int id)
        //{
        //    var product = _productRepository.GetById(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}
        //// Process the product deletion
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    _productRepository.Delete(id);
        //    return RedirectToAction("Index");
        //}
    }
}
