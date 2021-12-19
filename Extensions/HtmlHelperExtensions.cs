using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dnw.TechDiamonds.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static bool IsActiveMenuLink(this IHtmlHelper htmlHelper, string controllerName)
        {
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");
            var isCurrentController =
                string.Compare(controllerName, currentController, StringComparison.OrdinalIgnoreCase) == 0;

            return isCurrentController;
        }
    }
}