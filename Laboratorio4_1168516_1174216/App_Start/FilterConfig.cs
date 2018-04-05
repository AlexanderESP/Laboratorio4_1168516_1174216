using System.Web;
using System.Web.Mvc;

namespace Laboratorio4_1168516_1174216
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
