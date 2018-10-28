
// STEP 2

namespace Adapter
{
    using System;

    public class Mp4Player :IAdvancedMediaPlayer
    {
        public string playVlc(string fileName)
        {
            return "Invalid format file";
        }

        public string playMp4(string fileName)
        {
            return string.Format("Playing Mp4 file {0}", fileName);
        }
    }
}
