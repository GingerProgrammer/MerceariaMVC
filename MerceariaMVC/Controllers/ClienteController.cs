using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MerceariaMVC.Models;
using MerceariaMVC.Data;

public class ClienteController : Controller
{
    private readonly MerceariaMVCContext _context;

    public ClienteController(MerceariaMVCContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Clientes.ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var cliente = await _context.Clientes
            .FirstOrDefaultAsync(c => c.Id == id);

        if (cliente == null)
        {
            return NotFound();
        }

        return View(cliente);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nome,Email,Idade,Ativo")] Cliente cliente)
    {
        if (!ModelState.IsValid)
        {
            return View(cliente);
        }

        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente == null)
        {
            return NotFound();
        }

        return View(cliente);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Idade,Ativo")] Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(cliente);
        }

        var clienteBanco = await _context.Clientes.FindAsync(id);

        if (clienteBanco == null)
        {
            return NotFound();
        }

        clienteBanco.Nome = cliente.Nome;
        clienteBanco.Email = cliente.Email;
        clienteBanco.Idade = cliente.Idade;
        clienteBanco.Ativo = cliente.Ativo;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var cliente = await _context.Clientes
            .FirstOrDefaultAsync(c => c.Id == id);

        if (cliente == null)
        {
            return NotFound();
        }

        return View(cliente);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente != null)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool ClienteExists(int id)
    {
        return _context.Clientes.Any(c => c.Id == id);
    }
}