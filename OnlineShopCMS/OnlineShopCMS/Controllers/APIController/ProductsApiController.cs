using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration;
using OnlineShopCMS.Data;
using OnlineShopCMS.DTO;
using OnlineShopCMS.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ProductsApiController : ControllerBase
{
    private readonly OnlineShopContext _context;

    public ProductsApiController(OnlineShopContext context)
    {
        _context = context;
    }

    // POST: api/Products/Create
    [HttpPost("Create")]
    [HttpPost("Create")]
    [Authorize(Roles = "Vendor")]
    public async Task<IActionResult> CreateProduct([FromForm] ProductCreateDTO productDto, IFormFile imageFile)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (imageFile != null && imageFile.Length > 0)
        {
            using (var memoryStream = new MemoryStream())
            {
                await imageFile.CopyToAsync(memoryStream);
                productDto.Image = memoryStream.ToArray();
            }
        }

        var product = new Product
        {
            Name = productDto.Name,
            Description = productDto.Description,
            Price = (int)productDto.Price,
            Stock = productDto.Stock,
            Image = productDto.Image,
            CategoryId = productDto.CategoryId,
            IsActive = true 
        };

        _context.Product.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetProduct", new { id = product.Id }, productDto);
    }

    // PUT: api/Products/5/Activate
    [HttpPut("{id}/Activate")]
    [Authorize(Roles = "Vendor")]
    public async Task<IActionResult> ActivateProduct(int id)
    {
        var product = await _context.Product
                                     .Where(p => p.Id == id)
                                     .FirstOrDefaultAsync();
        if (product == null)
        {
            return NotFound();
        }

        // Code to activate the product (e.g., setting an IsActive flag)
        product.IsActive = true;

        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // PUT: api/Products/5/Deactivate
    [HttpPut("{id}/Deactivate")]
    [Authorize(Roles = "Vendor")]
    public async Task<ActionResult<ProductUpdateDTO>> DeactivateProduct(int id)
    {
        var product = await _context.Product.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        // Code to deactivate the product
        product.IsActive = false;

        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        var productUpdateDTO = new ProductUpdateDTO
        {
            Id = product.Id,
            IsActive = product.IsActive,
            // 其他可能需要更新的字段
        };

        return Ok(productUpdateDTO);
    }


    // DELETE: api/Products/5
    [HttpDelete("{id}")]
    [Authorize(Roles = "Vendor")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _context.Product.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        _context.Product.Remove(product);
        await _context.SaveChangesAsync();

        return NoContent();
    }

   
}
