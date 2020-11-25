using System;
using System.Collections.Generic;
using System.Text;

namespace testInterface2
{
    class MusicFile
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public int YearOfReleas { get; set; }

        public int Duration { get; set; }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSec)
        {
            this.Title = title;
            this.Artist = artist;
            this.YearOfReleas = yearOfRelease;
            this.Duration = durationInSec;
        }
    }
}
