using System.Web;
using System.Web.Mvc;

namespace ASP_Code_First_Specificities
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
