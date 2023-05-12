using System;
namespace Testing.Models
{
    public class Songs
    {
        public Songs()
        {
        }

        public int PerformanceID { get; set; }
        public string SongTitle { get; set; }
        public string Arranger { get; set; }
        public string Occasion { get; set; }
        public string LastPerformed { get; set; }
        public int TimesPerformed { get; set; }

    }
}


