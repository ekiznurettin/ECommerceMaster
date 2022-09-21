using ECommerceMaster.Business.Abstract;
using ECommerceMaster.Core.Utilities.Results.ComplexTypes;
using ECommerceMaster.Entities.Dtos;
using ECommerceMaster.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMaster.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthService _authService;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IAuthService authService, IProductService productService)
        {
            _logger = logger;
            _authService = authService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var result = _productService.GetAllByNonDeletedAsync();
            var viewProduct = new ProductViewModel
            {
                FeatureProducts = result.Result,
                RecentProducts =result.Result

            };
            return View(viewProduct);
        }
        [HttpGet]
        public IActionResult LoginAndRegister()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            _authService.Logout();
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.Login(userLoginDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Message = "Lütfen Girdiğiniz Bilgilerinizi Kontrol Ediniz";
                return RedirectToAction("LoginAndRegister");
            }
            ViewBag.Message = "Lütfen Girdiğiniz Bilgilerinizi Kontrol Ediniz";
            return RedirectToAction("LoginAndRegister");
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.Register(userRegisterDto, userRegisterDto.Password);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Message = "Kayıt Yapılırken hata oluştu";
                return RedirectToAction("LoginAndRegister");
            }
            else
            {
                ViewBag.Message = "Lütfen Girdiğiniz Bilgilerinizi Kontrol Ediniz";
                return RedirectToAction("LoginAndRegister");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
