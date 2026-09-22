namespace ApiProjeKampi.WEB.UI.ViewComponents;
using Microsoft.AspNetCore.Mvc;
    public class _NavbarDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
