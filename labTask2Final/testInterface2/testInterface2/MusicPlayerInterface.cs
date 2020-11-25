using System;
using System.Collections.Generic;
using System.Text;

namespace testInterface2
{
    interface MusicPlayerInterface
    {
        void Switch(Boolean on);
        void Play(Boolean on);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();
    }
}
