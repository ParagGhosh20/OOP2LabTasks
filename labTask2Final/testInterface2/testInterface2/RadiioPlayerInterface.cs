using System;
using System.Collections.Generic;
using System.Text;

namespace testInterface2
{
    interface RadiioPlayerInterface
    {
        void Switch(Boolean on);
        void Retune(double frequency);
        void SetVolume(int loudness);
        void ChangeChannel();
    }
}
