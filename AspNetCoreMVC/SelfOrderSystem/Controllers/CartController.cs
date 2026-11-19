using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Services;

namespace SelfOrderSystem.Controllers;
public class CartController : Controller {
    private readonly AppDbContext _db;  //商品確認用
    private readonly CartService _cart; //カート操作用

    public CartController(AppDbContext db, CartService cart) {
        _db = db;
        _cart = cart;
    }

    public IActionResult Index() {
        return View(_cart.GetItems());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Add(int productId) {
        var product = await _db.Products.FindAsync(productId);

        if (product == null) {
            return NotFound();
        }

        _cart.Add(product);

        return RedirectToAction("Index", "Menu");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Update(int productId, int quantity) {
        _cart.SetQuantity(productId, quantity); // 指定商品の数量を変更
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Remove(int productId) {
        _cart.Remove(productId); // 指定商品をカートから削除
        return RedirectToAction(nameof(Index));
    }

}
