using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Data;
using OnlineShopCMS.Models;

namespace OnlineShopCMS.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ProductsController : Controller
    {
        private readonly OnlineShopContext _context;

        public ProductsController(OnlineShopContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var result = from m in _context.Product select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Name.Contains(searchString));
            }
<<<<<<< HEAD
            var userName = User.Identity.Name;
            ViewData["UserName"] = userName;
=======

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            int pageSize = 5;
            return View(await PaginatedList<Product>.CreateAsync(result.Include(p => p.Category).AsNoTracking(), pageNumber ?? 1, pageSize));
        }

<<<<<<< HEAD
        // GET: Products/Details/
        public async Task<IActionResult> Details(int? id)
        {
=======
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            DetailViewModel dvm = new DetailViewModel();

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            DetailViewModel dvm = new DetailViewModel();  

            var product = await _context.Product
                        .Include(p => p.Category)
                        .FirstOrDefaultAsync(m => m.Id == id);
=======
            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                dvm.product = product;
                if (product.Image != null)
                {
                    dvm.imgsrc = ViewImage(product.Image);
                }
            }
<<<<<<< HEAD
            return View(dvm); 
        }
=======

            return View(dvm);
        }

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = new SelectList(_context.Set<Category>(), "Id", "Name");
            return View();
        }

<<<<<<< HEAD
       
=======
        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Content,Price,Stock,Image,CategoryId")] Product product, IFormFile myimg)
        {
            if (ModelState.IsValid)
            {
                if (myimg != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        myimg.CopyTo(ms);
                        product.Image = ms.ToArray();
                    }
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Categories"] = new SelectList(
                _context.Set<Category>(), "Id", "Name", product.CategoryId);
            return View(product);
        }

<<<<<<< HEAD
        // GET: Products/EditOrder/5
=======
        // GET: Products/Edit/5
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                if (product.Image != null)
                {
                    ViewBag.Image = ViewImage(product.Image);
                }
            }
            ViewData["Categories"] = new SelectList(_context.Set<Category>(), "Id", "Name", product.CategoryId); //設定seleccted項目

            return View(product);
        }

<<<<<<< HEAD
      
=======
        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Content,Price,Stock,Image,CategoryId")] Product product, IFormFile myimg)
        {
<<<<<<< HEAD
            var prod = new Product();

=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
<<<<<<< HEAD
=======
                    var productToUpdate = await _context.Product.FindAsync(id);

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
                    if (myimg != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            myimg.CopyTo(ms);
<<<<<<< HEAD
                            product.Image = ms.ToArray();
                        }
                    }
                    _context.Update(product);
=======
                            productToUpdate.Image = ms.ToArray();
                        }
                    }

                    productToUpdate.Name = product.Name;
                    productToUpdate.Description = product.Description;
                    productToUpdate.Content = product.Content;
                    productToUpdate.Price = product.Price;
                    productToUpdate.Stock = product.Stock;
                    productToUpdate.CategoryId = product.CategoryId;

                    _context.Update(productToUpdate);
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var product = await _context.Product.FindAsync(id);
=======
            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            if (product == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product
                .Include(p => p.Comments) // 確保載入評論
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            // 刪除所有相關的評論
            _context.Comment.RemoveRange(product.Comments);
            await _context.SaveChangesAsync();

            // 現在刪除產品
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }





=======
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            return View();
        }

<<<<<<< HEAD
        public async Task<IActionResult> ListCategories(int? id)
        {
            var categories = await _context.Category.ToListAsync();
            return View(categories);

        }
        public async Task<IActionResult> EditCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(int id, [Bind("Id,Name,Description")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("ListCategories");
            }
            return View(category);
        }

        [HttpPost, ActionName("DeleteCategory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListCategories));
            }
            return NotFound();
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.Id == id);
        }


=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

        private string ViewImage(byte[] arrayImage)
        {
            string base64String = Convert.ToBase64String(arrayImage, 0, arrayImage.Length);
            return "data:image/png;base64," + base64String;
<<<<<<< HEAD

        }

=======
        }
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
    }
}
