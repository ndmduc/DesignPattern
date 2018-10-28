
// STEP 2

namespace Adapter
{
    using System;

    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public string playVlc(string fileName)
        {
            return string.Format("Playing Vlc file {0}", fileName);
        }

        public string playMp4(string fileName)
        {
            return "Invalid format file";
        }
    }
}
