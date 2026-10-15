using Microsoft.AspNetCore.Mvc;
using CrmWeb.Models;
namespace CrmWeb.Controllers;
public sealed class HomeController : Controller
{
    public IActionResult Index() => View(new DashboardViewModel
    {
        ApplicationName = "CRM",
        Pages =
        [
            ("/manage/segments", "Segment Tanımları", "segments kayıtlarını görüntüle ve yönet"),
            ("/manage/employees", "Çalışan Yönetimi", "employees kayıtlarını görüntüle ve yönet"),
            ("/manage/portfolios", "Portföy Yönetimi", "portfolios kayıtlarını görüntüle ve yönet"),
            ("/manage/customers", "Müşteri Yönetimi", "customers kayıtlarını görüntüle ve yönet")
        ]
    });
}
