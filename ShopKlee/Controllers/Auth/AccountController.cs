using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopKlee.Controllers.DBContext;
using ShopKlee.Models;
using ShopKlee.Models.ViewModel;

namespace ShopKlee.Controllers.Auth
{
    public class AccountController : Controller
    {
        private readonly UserManager<InfoUserModel> userManager;
        private readonly SignInManager<InfoUserModel> signInManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        public AccountController(UserManager<InfoUserModel> userManager,SignInManager<InfoUserModel> signInManager, IHostingEnvironment hostingEnvironment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this._hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            //string appid = "40a77097a77d46fab5fa913aa86033f6";
            //string url = "https://newsapi.org/v2/top-headlines?country=us&pageSize=10&apiKey=" + appid;
            //var json = new WebClient().DownloadString(url);
            //NewsAPIModel model = JsonConvert.DeserializeObject<NewsAPIModel>(json);
            //ViewBag.Data = model;
            return View("../Auth/LoginView");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.Rememberme, false);
                if (result.Succeeded)
                {

                    return RedirectToAction("index", "home");
                }
                ModelState.AddModelError("", "Invalid Login Attempt!");
            }
            return View("../Auth/LoginView",model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("../Auth/RegisterView");
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Photo != null)
                {
                    string UpLoadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img/UserIMG");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string FilePath = Path.Combine(UpLoadFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                }
                //1 for Male 0 for Female
                bool uGender = false;
                if (model.Gender == 1) uGender = true;
                var user = new InfoUserModel {UserName = model.UserName,FirstName=model.FirstName,LastName=model.LastName,Email = model.Email, PhoneNumber = model.PhoneNumber, Address = model.Address, Gender = uGender,IMG_url = uniqueFileName };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                   await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("../Auth/RegisterView",model);
        }
        [HttpGet]
        public async Task<IActionResult> EditProfile(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user == null)
            {
                ViewBag.ErrorMsg = "Can not find user with Id: " + Id;
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = "Can not find user with id" + Id
                };
                return View("Error",error);
            }
            var model = new UserProfileViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                Gender = user.Gender,
                UserName = user.UserName,
                PhotoName = user.IMG_url
            };
            ViewBag.Data = model;
            return View("../Auth/EditProfileView");
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                ViewBag.ErrorMsg = "Can not find user with Id: " + model.Id;
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = "Can not find user with id" + model.Id
                };
                return View("Error", error);
            }
            else
            {
                bool uGender = false;
                if (model.Gender == 1) uGender = true;
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Gender = uGender;
                user.PhoneNumber = model.PhoneNumber;
                user.Address = model.Address;
                user.UserName = model.UserName;
                //Delete Exist Photo
                if (user.IMG_url != null)
                {
                    string objectPath = Path.Combine(_hostingEnvironment.WebRootPath, user.IMG_url);
                    FileInfo fi = new FileInfo(objectPath);
                    if (fi != null)
                    {
                        System.IO.File.Delete(objectPath);
                        fi.Delete();
                    }
                }
                //End Delete
                //Upload new Photo
                string uniqueFileName = null;
                if (model.Photo != null)
                {
                    string UpLoadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img/UserIMG");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string FilePath = Path.Combine(UpLoadFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                }
                user.IMG_url = uniqueFileName;
                //end Update Photo
                var Result = await userManager.UpdateAsync(user);
                UserProfileViewModel modelreturn = new UserProfileViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    Gender = user.Gender,
                    UserName = user.UserName,
                    PhotoName = user.IMG_url
                };
                if (Result.Succeeded)
                {
                    ViewBag.Data = modelreturn;
                    return View("../Auth/EditProfileView");
                }
                ViewBag.Data = modelreturn;
                foreach (var errror in Result.Errors)
                {
                    ModelState.AddModelError("", errror.Description);
                }
                return View("../Auth/EditProfileView");
            }
        }
        //xàm xàm
    }
}
