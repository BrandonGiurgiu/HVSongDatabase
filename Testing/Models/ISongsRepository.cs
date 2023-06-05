using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public interface ISongsRepository
    {
        public IEnumerable<Songs> GetAllSongs();

        public Songs GetSongs(int id);

        public void UpdateSong(Songs songs);

        public void InsertSong(Songs songToInsert);
        public void DeleteSongs(int id);

    }
}


