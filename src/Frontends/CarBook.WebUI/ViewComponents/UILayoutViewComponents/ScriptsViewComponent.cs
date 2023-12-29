using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents;

public class ScriptsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}