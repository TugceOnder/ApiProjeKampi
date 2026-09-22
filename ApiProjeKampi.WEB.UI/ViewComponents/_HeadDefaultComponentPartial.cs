namespace ApiProjeKampi.WEB.UI.ViewComponents;
using Microsoft.AspNetCore.Mvc;
    public class _HeadDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

