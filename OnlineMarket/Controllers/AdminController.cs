using OnlineMarket.Models;
using OnlineMarket.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMarket.Controllers
{
    public class AdminController : Controller
    {

        private IAdminRepository _adminRepository;
        

        public AdminController(IAdminRepository adminRepository)
        {
             _adminRepository = adminRepository;
        }

       
        public async Task<IActionResult> Index()
        {
            var result = await _adminRepository.GetAllAsync();
            return View(result);
        }
        public async Task<IActionResult> Details(int id)
        {
            var result = await _adminRepository.GetByIdAsync(id);
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Admin admin)
        {
            if (ModelState.IsValid)
            {

                await _adminRepository.Create(admin);
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var admin = await _adminRepository.GetByIdAsync(id);
            return View(_adminRepository);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Admin admin)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    admin.Id = id;

                    await _adminRepository.GetByIdAsync(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var _admin = await _adminRepository.GetByIdAsync(id);
            return View(_admin);
        }

        [HttpDelete, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _adminRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

