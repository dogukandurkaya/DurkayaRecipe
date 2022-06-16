using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Business.Concrete;
using DurkayaRecipe.Entity;
using DurkayaRecipe.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using DurkayaRecipe.WebUI.Identity;

namespace DurkayaRecipe.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]

    public class AdminController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;

        public AdminController(IFoodService foodService, ICategoryService categoryService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _foodService = foodService;
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        public IActionResult UserCreate()
        {
            var roles = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserCreate(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = model.EmailConfirmed
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded)
                {
                    selectedRoles = selectedRoles ?? new string[] { };
                    await _userManager.AddToRolesAsync(user, selectedRoles);
                    return Redirect("~/admin/user/list");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(model);
            }
            var roles2 = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles2;
            return View(model);
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/admin/user/list");
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());
                        return Redirect("~/admin/user/list");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var roles = _roleManager.Roles.Select(i => i.Name);
                    ViewBag.Roles = roles;
                    return View(model);
                }
                ModelState.AddModelError("", "Böyle bir kullanıcı yok!");
                var roles2 = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles2;
                return View(model);
            }
            var roles3 = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles3;
            return View(model);
        }

        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }


        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(
                    new IdentityRole(model.Name)
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }

                //Geri kalan kısmına yarın devam edeceğiz.
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                //if (await _userManager.IsInRoleAsync(user,role.Name))
                //{
                //    members.Add(user);
                //}
                //else
                //{
                //    nonMembers.Add(user);
                //}

                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/admin/role/" + model.RoleId);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FoodList()
        {
            return View(_foodService.GetAll());
        }
        public IActionResult CategoryList()
        {
            return View(_categoryService.GetAll());
        }
        public IActionResult FoodCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult FoodCreate(FoodModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && file != null)
            {
                JobManager urlGenerate = new JobManager();
                var url = urlGenerate.MakeUrl(model.FoodName);

                model.ImageUrl = urlGenerate.UploadImage(file, url);

                var food = new Food()
                {
                    FoodName = model.FoodName,
                    Url = url,
                    FoodMaterial = model.FoodMaterial,
                    ImageUrl = model.ImageUrl,
                    FoodDescription = model.FoodDescription,
                    IsApproved = model.IsApproved,
                    IsHome = model.IsHome
                };
                _foodService .Create(food, categoryIds);

                CreateMessage("Ürün başarıyla eklenmiştir", "success");
                return RedirectToAction("FoodList");
            }
            CreateMessage("Ürün kaydedilememiştir. Lütfen ilgili alanları kontrol edip, yeniden deneyiniz.", "warning");
            ViewBag.Categories = _categoryService.GetAll();
            if (categoryIds.Length > 0)
            {
                model.SelectedCategories = categoryIds.Select(catId => new Category()
                {
                    CategoryId = catId
                }).ToList();
            }
            else
            {
                ViewBag.CategoryMessage = "Lütfen bir kategori seçimi yapınız!";
            }
            if (file == null)
            {
                ViewBag.ImageMessage = "Lütfen resim seçiniz!";
            }
            return View(model);
        }

        public IActionResult CategoryCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model, int[] categoryIds)
        {
            if (ModelState.IsValid)
            {
                JobManager urlGenerate = new JobManager();
                var url = urlGenerate.MakeUrl(model.CategoryName);
                var category = new Category()
                {
                    CategoryName = model.CategoryName,
                    Url = url,
                    CategoryDescription = model.CategoryDescription,
                };
                _categoryService.Create(category, categoryIds);

                CreateMessage("Ürün başarıyla eklenmiştir", "success");
                return RedirectToAction("CategoryList");
            }
            CreateMessage("Ürün kaydedilememiştir. Lütfen ilgili alanları kontrol edip, yeniden deneyiniz.", "warning");
            ViewBag.Categories = _categoryService.GetAll();
            if (categoryIds.Length > 0)
            {
                model.SelectedCategories = categoryIds.Select(catId => new Category()
                {
                    CategoryId = catId
                }).ToList();
            }
            else
            {
                ViewBag.CategoryMessage = "Lütfen bir kategori seçimi yapınız!";
            }

            return View(model);
        }
        public IActionResult FoodEdit(int? id)
        {
            var entity = _foodService.GetByIdWithCategories((int)id);
            var model = new FoodModel()
            {
                FoodId = entity.FoodId,
                FoodName = entity.FoodName,
                FoodMaterial = entity.FoodMaterial,
                Url = entity.Url,
                FoodDescription = entity.FoodDescription,
                ImageUrl = entity.ImageUrl,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity
                    .FoodCategories
                    .Select(i => i.Category)
                    .ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult FoodEdit(FoodModel model, int[] categoryIds, IFormFile file)
        {
            JobManager urlGenerate = new JobManager();
            var url = urlGenerate.MakeUrl(model.FoodName);
            var entity = _foodService.GetById(model.FoodId);

            if (file != null)
            {
                entity.ImageUrl = urlGenerate.UploadImage(file, url);
            }
            entity.FoodName = model.FoodName;
            entity.FoodMaterial = model.FoodMaterial;
            entity.Url = url;
            entity.FoodDescription = model.FoodDescription;
            entity.IsApproved = model.IsApproved;
            entity.IsHome = model.IsHome;
            entity.ImageUrl = entity.ImageUrl;
            _foodService.Update(entity, categoryIds);
            return RedirectToAction("FoodList");
        }
        public IActionResult CategoryEdit(int id)
        {
            var entity = _categoryService.GetById(id);
            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                CategoryName = entity.CategoryName,
                CategoryDescription = entity.CategoryDescription,
                Url = entity.Url,
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult CategoryEdit(CategoryModel model, int[] categoryIds)
        {
            JobManager urlGenerate = new JobManager();
            var url = urlGenerate.MakeUrl(model.CategoryName);

            var entity = _categoryService.GetById(model.CategoryId);
            entity.CategoryName = model.CategoryName;
            entity.CategoryDescription = model.CategoryDescription;
            entity.Url = url;
            _categoryService.Update(entity, categoryIds);
            return RedirectToAction("CategoryList");
        }
        public IActionResult FoodDelete(int foodId)
        {
            var entity = _foodService.GetById(foodId);
            _foodService.Delete(entity);
            return RedirectToAction("FoodList");
        }
        public IActionResult CategoryDelete(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            _categoryService.Delete(entity);
            return RedirectToAction("CategoryList");
        }
        private void CreateMessage(string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
