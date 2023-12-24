using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppDomainLayer.Data;
using AppDomainLayer.Models.ViewModel;
using AppDomainLayer.Models;

namespace AppDomainLayer.Controllers
{
    public class UploadController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;

        public UploadController(ApplicationDbContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        //GET: Upload
        public async Task<IActionResult> Index()
        {
            var imageList = await _context.ImageUpload.ToListAsync();
            return View(imageList);
            //return _context.ImageUpload != null ?
            //            View(await _context.ImageUpload.ToListAsync()) :
            //            Problem("Entity set 'ApplicationDbContext.ImageUpload'  is null.");
        }

        // GET: Upload/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ImageUpload == null)
            {
                return NotFound();
            }

            var imageUpload = await _context.ImageUpload
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imageUpload == null)
            {
                return NotFound();
            }

            return View(imageUpload);
        }

        // GET: Upload/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Upload/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ImageUploadViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Generate a unique filename for the image
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.ImageFile.FileName);

                    // Specify the directory where you want to save the image
                    var directoryPath = Path.Combine(_environment.ContentRootPath, "Images");

                    // Create the directory if it does not exist
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    var filePath = Path.Combine(directoryPath, fileName);

                    // Save the image to the specified path
                    UploadFile(model.ImageFile, filePath);

                    // Save the image information to the database
                    var data = new ImageUpload()
                    {
                        Name = model.Name,
                        ImagePath = fileName, // Save the filename in the database
                    };

                    await _context.AddAsync(data);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (logging, error message, etc.)
                return RedirectToAction("Error");
            }
            //try
            //{
            //    if (ModelState.IsValid)
            //    {
            //        var path = _environment.WebRootPath;
            //        var filePath = "Content/Image/" + model.ImageFile.FileName;
            //        var fullPath = Path.Combine(path, filePath);
            //        UploadFile(model.ImageFile, fullPath);
            //        var data = new ImageUpload()
            //        {
            //            Name = model.Name,
            //            ImagePath = filePath,
            //        };
            //        await _context.AddAsync(data);
            //        await _context.SaveChangesAsync();
            //        return RedirectToAction("Index");
            //    }
            //    return View(model);
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }
        public void UploadFile(IFormFile file, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);
        }
        // GET: Upload/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ImageUpload == null)
            {
                return NotFound();
            }

            var imageUpload = await _context.ImageUpload
                .Select(i => new ImageUploadViewModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    //ImageFile = i.ImagePath,
                }).FirstOrDefaultAsync();
            if (imageUpload == null)
            {
                return NotFound();
            }
            return View(imageUpload);
        }

        // POST: Upload/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ImageUploadViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingData = await _context.ImageUpload.FindAsync(id);

                    if (existingData == null)
                    {
                        return NotFound();
                    }

                    existingData.Name = model.Name;

                    if (model.ImageFile != null)
                    {
                        var path = _environment.WebRootPath;
                        var filePath = "Content/Image/" + model.ImageFile.FileName;
                        var fullPath = Path.Combine(path, filePath);

                        // Delete the existing full Path if it exists
                        if (System.IO.File.Exists(fullPath))
                        {
                            System.IO.File.Delete(fullPath);
                        }
                        // Delete the existing file if it exists
                        if (System.IO.File.Exists(Path.Combine(path, existingData.ImagePath)))
                        {
                            System.IO.File.Delete(Path.Combine(path, existingData.ImagePath));
                        }

                        // Upload the new file
                        UploadFile(model.ImageFile, fullPath);

                        // Update the ImagePath property
                        existingData.ImagePath = filePath;
                    }

                    _context.Update(existingData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageUploadExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        private bool ImageUploadExists(int id)
        {
            return _context.ImageUpload.Any(e => e.Id == id);
        }


        // GET: Upload/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ImageUploadViewModel == null)
            {
                return NotFound();
            }

            var imageUploadViewModel = await _context.ImageUploadViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imageUploadViewModel == null)
            {
                return NotFound();
            }

            return View(imageUploadViewModel);
        }

        // POST: Upload/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ImageUploadViewModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ImageUploadViewModel'  is null.");
            }
            var imageUploadViewModel = await _context.ImageUploadViewModel.FindAsync(id);
            if (imageUploadViewModel != null)
            {
                _context.ImageUploadViewModel.Remove(imageUploadViewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageUploadViewModelExists(int id)
        {
            return (_context.ImageUploadViewModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
