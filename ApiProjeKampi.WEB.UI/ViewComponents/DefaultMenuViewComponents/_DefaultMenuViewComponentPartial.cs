using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEB.UI.ViewComponents.DefaultMenuViewComponents
{
    public class _DefaultMenuViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
