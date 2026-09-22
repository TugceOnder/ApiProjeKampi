using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEB.UI.ViewComponents
{
    public class _DefaultMenuViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
