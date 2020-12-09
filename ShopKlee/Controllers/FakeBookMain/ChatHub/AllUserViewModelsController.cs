using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopKlee.Controllers.DBContext;
using ShopKlee.Models;
using ShopKlee.Models.MainModels;
using ShopKlee.Models.ViewModel;

namespace ShopKlee.Controllers.FakeBookMain.ChatHub
{
    public class AllUserViewModelsController : Controller
    {
        private readonly UserManager<InfoUserModel> userManager;
        private readonly ShopKleeDBContext _context;

        public AllUserViewModelsController(ShopKleeDBContext context,UserManager<InfoUserModel> userManager)
        {
            this._context = context;
            this.userManager = userManager;
        }

        // GET: AllUserViewModels
        public async Task<IActionResult> Index(string Id)
        {
            var users = await userManager.Users.ToListAsync();
            List<ShortUser> ListUser = new List<ShortUser>();
            foreach (var User in users)
            {
                ShortUser u = new ShortUser
                {
                    id = User.Id,
                    Username = User.UserName,
                    urlIMG = User.IMG_url
                };
                var checkF = _context.Friends.FirstOrDefault(opts => opts.IdFriend == u.id && opts.IdUser == Id);
                if (u.id != Id && checkF != null) ListUser.Add(u);
                //ko phải người dùng và không có trong list bạn
            }
            ChatHubViewModel a = new ChatHubViewModel
            {
                shortUsers = ListUser
            };
            return View("../ChatHub/ChatHub",a);
        }
        public void AddFriend(string idU,string idF)
        {
            var succes = _context.Friends.FirstOrDefault(opts => opts.IdFriend == idF && opts.IdUser == idU);
            if (succes == null)
            {
                Friends a = new Friends
                {
                    Id = Guid.NewGuid().ToString(),
                    IdUser = idU,
                    IdFriend = idF,
                    DateCreate = DateTime.Now
                };
                _context.Friends.AddAsync(a);
                _context.SaveChangesAsync();
            }else { 
            }
        }

        //// GET: AllUserViewModels/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var allUserViewModel = await _context.AllUserViewModel
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (allUserViewModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(allUserViewModel);
        //}

        //// GET: AllUserViewModels/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: AllUserViewModels/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("id")] AllUserViewModel allUserViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(allUserViewModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(allUserViewModel);
        //}

        //// GET: AllUserViewModels/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var allUserViewModel = await _context.AllUserViewModel.FindAsync(id);
        //    if (allUserViewModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(allUserViewModel);
        //}

        //// POST: AllUserViewModels/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("id")] AllUserViewModel allUserViewModel)
        //{
        //    if (id != allUserViewModel.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(allUserViewModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AllUserViewModelExists(allUserViewModel.id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(allUserViewModel);
        //}

        //// GET: AllUserViewModels/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var allUserViewModel = await _context.AllUserViewModel
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (allUserViewModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(allUserViewModel);
        //}

        //// POST: AllUserViewModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var allUserViewModel = await _context.AllUserViewModel.FindAsync(id);
        //    _context.AllUserViewModel.Remove(allUserViewModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AllUserViewModelExists(int id)
        //{
        //    return _context.AllUserViewModel.Any(e => e.id == id);
        //}
    }
}
