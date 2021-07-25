using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyAgenda.Data;
using MyAgenda.Models;

namespace MyAgenda.Controllers
{
    public class AgendasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AgendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Agendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contatos.ToListAsync());
        }

        // GET: Agendas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Contatos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // GET: Agendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone,Endereco")] Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                agenda.Id = Guid.NewGuid();
                _context.Add(agenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        // GET: Agendas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Contatos.FindAsync(id);
            if (agenda == null)
            {
                return NotFound();
            }
            return View(agenda);
        }

        // POST: Agendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,Telefone,Endereco")] Agenda agenda)
        {
            if (id != agenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendaExists(agenda.Id))
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
            return View(agenda);
        }

        // GET: Agendas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Contatos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // POST: Agendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var agenda = await _context.Contatos.FindAsync(id);
            _context.Contatos.Remove(agenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendaExists(Guid id)
        {
            return _context.Contatos.Any(e => e.Id == id);
        }
    }
}
