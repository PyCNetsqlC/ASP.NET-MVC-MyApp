using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using System.Diagnostics;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        [Route("/Home/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // 在這裡處理登入邏輯
                return RedirectToAction("MapAPI", "Home");
                //return View("/Views/MFWeb/MapAPI.cshtml");
            }

            return View(model);
        }

        [HttpGet]
        [Route("/Home/Register")]
        public IActionResult Register()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == null || model.Password == null || model.ConfirmPassword == null || model.Email == null)
                {
                    ViewData["ErrorMessage"] = "請勿空白!!!";
                }
                // 在這裡處理註冊邏輯
                else if (model.Password != null && model.ConfirmPassword != null && model.Password == model.ConfirmPassword)
                {
                    // 儲存用戶數據到數據庫
                    return RedirectToAction("Login", "Home");
                }

                else if (model.Password != model.ConfirmPassword) 
                {
                    ViewData["ErrorMessage"] = "確認密碼與密碼不服，請重新確認!";
                }
                //ModelState.AddModelError("", "Passwords do not match");
                //ViewData["ErrorMessage"] = "Passwords do not match";


            }
            return View(model);
        }*//*/舊版保留/*/

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            // 在這裡處理用戶註冊的請求，包括創建新用戶、保存用戶信息等操作
            if (ModelState.IsValid)
            {
                // 註冊成功，執行相應的操作，例如重定向到登入頁面
                //return RedirectToAction("Login","Home");

                if (model.Username == null || model.Username == string.Empty)
                {
                    ViewData["ErrorMessage"] = "使用者名稱不可空白!!";
                }

                else if (model.Password == null)
                {
                    ViewData["ErrorMessage"] = "密碼不可空白!!";
                }

                else if (model.ConfirmPassword == null && model.Password != null)
                {
                    ViewData["ErrorMessage"] = "確認密碼不可空白!!";
                }

                else if (model.Password != model.ConfirmPassword) 
                {
                    ViewData["ErrorMessage"] = "密碼與確認密碼不相同!!";
                }

                else if (model.Email == null)
                {
                    ViewData["ErrorMessage"] = "郵件信箱不可空白";
                }

                /*else 
                {
                    ViewData["ErrorMessage"] = "請檢查是否有遺漏資料。";
                }*/

                if (model.Password != null && model.ConfirmPassword != null && model.Password == model.ConfirmPassword && model.Username != null && model.Email != null ) 
                {
                    return RedirectToAction("Login", "Home");
                }
                
                
            }

            // 如果註冊失敗，返回註冊頁面，並顯示驗證錯誤消息
            return View(model);
        }


        [HttpGet]
        public IActionResult MapAPI()
        {
            //return View();
            return View("/Views/MFWeb/MapAPI.cshtml");
        }
        [HttpPost]
        public IActionResult MapAPI(MapAPIViewModel model)
        {
            if (ModelState.IsValid)
            {
                // 在這裡處理登入邏輯
            }

            return View(model);
        }

        public IActionResult BackHome()
        {
            //MapAPI.cshtml中的Back Home Button 事件
            return RedirectToAction("Index", "Home");//return RedirectToAction("控制器中對應的定義物件", "控制器名稱")
        }


    }
}


/*namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
*/