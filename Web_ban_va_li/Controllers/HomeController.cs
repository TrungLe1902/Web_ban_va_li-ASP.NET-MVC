using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Web_ban_va_li.Models;
using X.PagedList;

namespace Web_ban_va_li.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlbanVaLiContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(QlbanVaLiContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null ||page<0?1:page.Value;
            var lstsanpham = _context.TDanhMucSps.AsNoTracking().OrderBy(x=>x.TenSp);//orderby sắp xếp theo tên
            PagedList<TDanhMucSp>lst = new PagedList<TDanhMucSp>(lstsanpham,pageNumber,pageSize);
            return View(lst);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
