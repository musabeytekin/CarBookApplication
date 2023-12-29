using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents;

public class MainCoverUILayoutViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}