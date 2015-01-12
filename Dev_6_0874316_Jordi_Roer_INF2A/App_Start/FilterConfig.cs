using System.Web;
using System.Web.Mvc;

namespace Dev_6_0874316_Jordi_Roer_INF2A
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters )
        {
            filters.Add( new HandleErrorAttribute( ) );
        }
    }
}
