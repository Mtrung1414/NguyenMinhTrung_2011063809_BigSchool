using System.Web;
using System.Web.Mvc;

namespace NguyenMinhTrung_2011063809
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
