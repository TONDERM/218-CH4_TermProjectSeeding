using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SCP_Foundation.Models;

namespace SCP_Foundation.Controllers
{
    public class SCPcontroller : Controller
    {
        private readonly SCPcontext _context;

        public SCPcontroller(SCPcontext ctx)
        {
            _context = ctx;
        }

        // GET: SCPcontroller
        public async Task<IActionResult> Index()
        {
            return View(await _context.SCPs.ToListAsync());
        }

        // GET: SCPcontroller/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scp = await _context.SCPs
                .FirstOrDefaultAsync(m => m.SCPID == id);
            if (scp == null)
            {
                return NotFound();
            }

            return View(scp);
        }

        // GET: SCPcontroller/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SCPcontroller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SCPID,IdNumber,Name,ObjectClass,ThreatLevel")] SCP scp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scp);
        }

        // GET: SCPcontroller/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scp = await _context.SCPs.FindAsync(id);
            if (scp == null)
            {
                return NotFound();
            }
            return View(scp);
        }

        // POST: SCPcontroller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SCPID,IdNumber,Name,ObjectClass,ThreatLevel")] SCP scp)
        {
            if (id != scp.SCPID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SCPExists(scp.SCPID))
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
            return View(scp);
        }

        // GET: SCPcontroller/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scp = await _context.SCPs
                .FirstOrDefaultAsync(m => m.SCPID == id);
            if (scp == null)
            {
                return NotFound();
            }

            return View(scp);
        }

        // POST: SCPcontroller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scp = await _context.SCPs.FindAsync(id);
            _context.SCPs.Remove(scp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SCPExists(int id)
        {
            return _context.SCPs.Any(e => e.SCPID == id);
        }
    }
}
