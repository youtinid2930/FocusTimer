using FocusTimer.Data;
using FocusTimer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace FocusTimer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string TaskName { get; set; }

        [BindProperty]
        public DateTime StartTime { get; set; }

        [BindProperty]
        public int DurationMinutes { get; set; }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(TaskName))
            {
                ModelState.AddModelError("", "Le nom de la tâche est requis.");
                return Page();
            }

            var session = new PomodoroSession
            {
                TaskName = TaskName,
                StartTime = StartTime,
                DurationMinutes = DurationMinutes
            };

            _context.PomodoroSessions.Add(session);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
