using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lunes_Assignment3_MVC.Models;
using Microsoft.Extensions.Localization;

namespace Lunes_Assignment3_MVC.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly IStringLocalizer<TransactionsController> _localizer;

        private readonly TransactionContext _context;

        public TransactionsController(TransactionContext context, IStringLocalizer<TransactionsController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            ViewData["YourTransactions"] = _localizer["Your Transactions"];
            return View(await _context.Transactions.ToListAsync());
        }


        // GET: Transactions/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            { 
                return View(new Transaction());
            }
            else
            { 
                return View(_context.Transactions.Find(id));
            }
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("TransactionId,TransactionName,TransactionAmount")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                if (transaction.TransactionId ==0)
                {
                    _context.Add(transaction);
                }
                else
                {
                    _context.Update(transaction);
                }
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
