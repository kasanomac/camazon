using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using camazon.Models;
using camazon.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace camazon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly camazonIdentityDbContext _context;

    public HomeController(ILogger<HomeController> logger, camazonIdentityDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index(string searchQuery)
    {
        // 検索クエリが空またはnullの場合は全データを取得
        var products = _context.Product.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            // 部分一致検索
            products = products.Where(p => p.ProductName.Contains(searchQuery));
        }

        // 検索クエリをViewに渡す
        ViewData["SearchQuery"] = searchQuery;

        // フィルタリングした結果をビューに渡す
        return View(products.ToList());
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

    //Product
    
    
}