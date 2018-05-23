using System.Web;
using System.Web.Mvc;

namespace Lab21_CoffeShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
