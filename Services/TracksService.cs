using System.Linq;
using Lab3_.Data;
using Lab3_.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Lab3_.Services
{
    // Класс выборки 10 записей из таблиц 
    public class TracksService : ITracksService
    {
        private readonly RadiostationContext _db;

        public TracksService(RadiostationContext db)
        {
            _db = db;
        }

        public HomeViewModel GetHomeViewModel(int numberRows = 10)
        {
            var genres = _db.Genres.AsNoTracking().Take(numberRows).ToList();
            var performers = _db.Performers.AsNoTracking().Take(numberRows).ToList();
            var cars = _db.Tracks
                .Include(t => t.Genre)
                .Include(t => t.Performer)
                .Select(t => new TrackViewModel
                {
                    Id = t.Id,
                    Duration = t.Duration,
                    CreationDate = t.CreationDate,
                    Genre = t.Genre.Name,
                    Name = t.Name,
                    Performer = t.Performer.Name,
                    Rating = t.Rating
                })
                .Take(numberRows)
                .ToList();

            var homeViewModel = new HomeViewModel
            {
                Performers = performers,
                Genres = genres,
                Tracks = cars
            };
            return homeViewModel;
        }
    }
}