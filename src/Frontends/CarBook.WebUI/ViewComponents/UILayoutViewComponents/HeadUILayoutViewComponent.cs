using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents;

public class HeadUILayoutViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}