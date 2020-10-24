using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}