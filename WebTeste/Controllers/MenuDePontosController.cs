using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTeste.Models;

namespace WebTeste.Controllers
{
    public class MenuDePontosController : Controller
    {
        private readonly BancoDeDados _context;

        public MenuDePontosController(BancoDeDados context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
              return _context.Jogador != null ? 
                          View(await _context.Jogador.ToListAsync()) :
                          Problem("Entity set 'BancoDeDados.Jogador'  is null.");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Jogador == null)
            {
                return NotFound();
            }

            var menuDePontos = await _context.Jogador
                .FirstOrDefaultAsync(m => m.id == id);
            if (menuDePontos == null)
            {
                return NotFound();
            }

            return View(menuDePontos);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Jogador,Inserir_Data,Inserir_Pontuação")] MenuDePontos menuDePontos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menuDePontos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menuDePontos);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Jogador == null)
            {
                return NotFound();
            }

            var menuDePontos = await _context.Jogador.FindAsync(id);
            if (menuDePontos == null)
            {
                return NotFound();
            }
            return View(menuDePontos);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Jogador,Inserir_Data,Inserir_Pontuação")] MenuDePontos menuDePontos)
        {
            if (id != menuDePontos.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menuDePontos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuDePontosExists(menuDePontos.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(menuDePontos);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Jogador == null)
            {
                return NotFound();
            }

            var menuDePontos = await _context.Jogador
                .FirstOrDefaultAsync(m => m.id == id);
            if (menuDePontos == null)
            {
                return NotFound();
            }

            return View(menuDePontos);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Jogador == null)
            {
                return Problem("Entity set 'BancoDeDados.Jogador'  is null.");
            }
            var menuDePontos = await _context.Jogador.FindAsync(id);
            if (menuDePontos != null)
            {
                _context.Jogador.Remove(menuDePontos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuDePontosExists(int id)
        {
          return (_context.Jogador?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
