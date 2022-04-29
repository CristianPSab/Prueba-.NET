using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiliconPowerWebClient.Models;

namespace SiliconPowerWebClient.Controllers
{
    public class RegistroController : Controller
    {
        private object _context;

        // GET: RegistroController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegistroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Guid id, [Bind("Id, Usuario, Email, Password")] RegistroViewModel registro)
        {
            try
            {
                if (id != registro.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    //try
                    //{
                    //    //_context.(registro);
                    //    //await _context.SaveChangesAsync();
                    //}
                    //catch (DbUpdateConcurrencyException)
                    //{
                    //    if (!RegistroExists(movie.Id))
                    //    {
                    //        return NotFound();
                    //    }
                    //    else
                    //    {
                    //        throw;
                    //    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
