using FocusTimer.Data;
using FocusTimer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FocusTimer.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly AppDbContext _context;

        public HistoryModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<PomodoroSession> Sessions { get; set; }

        public async Task OnGetAsync()
        {
            Sessions = await _context.PomodoroSessions
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
