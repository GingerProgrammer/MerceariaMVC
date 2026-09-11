using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MerceariaMVC.Models;
using MerceariaMVC.Data;

public class ProdutoController : Controller
{
    private readonly MerceariaMVCContext _context;

    public ProdutoController(MerceariaMVCContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Produtos.ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var produto = await _context.Produtos
            .FirstOrDefaultAsync(p => p.IdProduto == id);

        if (produto == null)
        {
            return NotFound();
        }

        return View(produto);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("IdProduto,Nome,Preco,Estoque")] Produto produto)
    {
        if (!ModelState.IsValid)
        {
            return View(produto);
        }

        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var produto = await _context.Produtos.FindAsync(id);

        if (produto == null)
        {
            return NotFound();
        }

        return View(produto);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("IdProduto,Nome,Preco,Estoque")] Produto produto)
    {
        if (id != produto.IdProduto)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(produto);
        }

        var produtoBanco = await _context.Produtos.FindAsync(id);

        if (produtoBanco == null)
        {
            return NotFound();
        }

        produtoBanco.Nome = produto.Nome;
        produtoBanco.Preco = produto.Preco;
        produtoBanco.Estoque = produto.Estoque;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var produto = await _context.Produtos
            .FirstOrDefaultAsync(p => p.IdProduto == id);

        if (produto == null)
        {
            return NotFound();
        }

        return View(produto);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        if (produto != null)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool ProdutoExists(int id)
    {
        return _context.Produtos.Any(p => p.IdProduto == id);
    }
}