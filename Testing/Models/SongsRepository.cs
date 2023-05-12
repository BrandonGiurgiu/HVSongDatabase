using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Testing.Models
{
	public class SongsRepository : ISongsRepository
	{
        private readonly IDbConnection _conn;
		public SongsRepository(IDbConnection conn)
		{
            _conn = conn;
		}

        public IEnumerable<Songs> GetAllSongs()
        {
            return _conn.Query<Songs>("SELECT * FROM performance_history");
        }

        public Songs GetSongs(int id)
        {
            return _conn.QuerySingle<Songs>("SELECT * FROM performance_history WHERE PerformanceID = @id",
                new { id = id });
        }

        public void UpdateSong(Songs songs)
        {
            _conn.Execute("UPDATE performance_history SET SongTitle = @songtitle, Arranger = @arranger," +
                "Occasion = @occasion, LastPerformed = @lastperformed, TimesPerformed = @timesperformed" +
                " WHERE PerformanceID = @id",
                new { songtitle = songs.SongTitle, arranger = songs.Arranger, occasion = songs.Occasion,
                    lastperformed = songs.LastPerformed, timesperformed = songs.TimesPerformed, id = songs.PerformanceID });
        }
    }
}

