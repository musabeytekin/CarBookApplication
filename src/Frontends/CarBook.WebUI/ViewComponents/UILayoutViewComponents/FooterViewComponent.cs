using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents;

public class FooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}