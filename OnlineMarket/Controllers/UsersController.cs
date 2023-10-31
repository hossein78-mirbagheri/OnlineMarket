using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Models;
using OnlineMarket.Repository;

namespace OnlineMarket.Controllers
{
    public class UsersController : Controller
    {
        private IUsersRepository _UsersRepository;


        public UsersController(IUsersRepository usersRepository)
        {
            _UsersRepository = usersRepository;
        }


        public async Task<IActionResult> Index()
        {
            var result = await _UsersRepository.GetAllAsync();
            return View(result);
        }
        public async Task<IActionResult> Details(int id)
        {
            var result = await _UsersRepository.GetByIdAsync(id);
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Users users)
        {
            if (ModelState.IsValid)
            {

                await _UsersRepository.Create(users);
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var _Bank = await _UsersRepository.GetByIdAsync(id);
            return View(_UsersRepository);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Users users)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    users.Id = id;

                    await _UsersRepository.Update(users);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var _Branch = await _UsersRepository.GetByIdAsync(id);
            return View(_Branch);
        }

        [HttpDelete, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _UsersRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
