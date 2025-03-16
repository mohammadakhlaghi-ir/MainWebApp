using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MainWebApp.ViewComponents
{
    public class AppInfoViewComponent : ViewComponent
    {
        private readonly IAppInfo _appInfoService;

        public AppInfoViewComponent(IAppInfo appInfoService) => _appInfoService = appInfoService;
        public async Task<IViewComponentResult> InvokeAsync(string viewName = "Default")
        {
            var appInfo = await _appInfoService.GetAppInfo();
            return View(viewName,appInfo);
        }
    }
}
