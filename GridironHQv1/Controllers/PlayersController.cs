using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GridironHQv1.Data;
using GridironHQv1.Entities;

namespace GridironHQv1.Controllers
{
    public class PlayersController : Controller
    {
        private readonly DataContext _context;

        public PlayersController(DataContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
              return View(await _context.Players.ToListAsync());
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(m => m.PlayerID == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Active,Age,AverageDraftPosition,BirthDate,College,CurrentStatus,CurrentTeam,DeclaredInactive,DepthDisplayOrder,DepthOrder,DepthPosition,DepthPositionCategory,DraftKingsName,DraftKingsPlayerID,Experience,ExperienceString,FanDuelName,FanDuelPlayerID,FantasyAlarmPlayerID,FantasyDraftName,FantasyDraftPlayerID,FantasyPosition,FantasyPositionDepthOrder,FirstName,GlobalTeamID,Height,HeightFeet,HeightInches,InjuryBodyPart,InjuryNotes,InjuryPractice,InjuryPracticeDescription,InjuryStartDate,InjuryStatus,IsUndraftedFreeAgent,LastName,Name,Number,PhotoUrl,PlayerID,Position,PositionCategory,RotoWirePlayerID,RotoworldPlayerID,ShortName,SportRadarPlayerID,SportsDirectPlayerID,StatsPlayerID,Status,Team,TeamID,UpcomingDraftKingsSalary,UpcomingFanDuelSalary,UpcomingGameOpponent,UpcomingGameWeek,UpcomingOpponentPositionRank,UpcomingOpponentRank,UpcomingSalary,UpcomingYahooSalary,UsaTodayHeadshotNoBackgroundUpdated,UsaTodayHeadshotNoBackgroundUrl,UsaTodayHeadshotUpdated,UsaTodayHeadshotUrl,UsaTodayPlayerID,Weight,XmlTeamPlayerID,YahooName,YahooPlayerID")] Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Active,Age,AverageDraftPosition,BirthDate,College,CurrentStatus,CurrentTeam,DeclaredInactive,DepthDisplayOrder,DepthOrder,DepthPosition,DepthPositionCategory,DraftKingsName,DraftKingsPlayerID,Experience,ExperienceString,FanDuelName,FanDuelPlayerID,FantasyAlarmPlayerID,FantasyDraftName,FantasyDraftPlayerID,FantasyPosition,FantasyPositionDepthOrder,FirstName,GlobalTeamID,Height,HeightFeet,HeightInches,InjuryBodyPart,InjuryNotes,InjuryPractice,InjuryPracticeDescription,InjuryStartDate,InjuryStatus,IsUndraftedFreeAgent,LastName,Name,Number,PhotoUrl,PlayerID,Position,PositionCategory,RotoWirePlayerID,RotoworldPlayerID,ShortName,SportRadarPlayerID,SportsDirectPlayerID,StatsPlayerID,Status,Team,TeamID,UpcomingDraftKingsSalary,UpcomingFanDuelSalary,UpcomingGameOpponent,UpcomingGameWeek,UpcomingOpponentPositionRank,UpcomingOpponentRank,UpcomingSalary,UpcomingYahooSalary,UsaTodayHeadshotNoBackgroundUpdated,UsaTodayHeadshotNoBackgroundUrl,UsaTodayHeadshotUpdated,UsaTodayHeadshotUrl,UsaTodayPlayerID,Weight,XmlTeamPlayerID,YahooName,YahooPlayerID")] Player player)
        {
            if (id != player.PlayerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.PlayerID))
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
            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(m => m.PlayerID == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Players == null)
            {
                return Problem("Entity set 'DataContext.Players'  is null.");
            }
            var player = await _context.Players.FindAsync(id);
            if (player != null)
            {
                _context.Players.Remove(player);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
          return _context.Players.Any(e => e.PlayerID == id);
        }
    }
}
