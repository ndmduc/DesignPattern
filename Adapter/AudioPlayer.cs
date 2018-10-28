
// STEP 4

namespace Adapter
{
    using System;

    /// <summary>
    /// The audio player.
    /// </summary>
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public string play(string audioType, string fileName)
        {
            // inbuilt support to play mp3 music files
            if (audioType.Equals("mp3"))
            {
                return string.Format("Playing mp3 file. Name: {0}", fileName);
            }
            else if (audioType.Equals("vlc") || audioType.Equals("mp4"))
            {
                // mediaAdapter is providing support to play other file formats
                this.mediaAdapter = new MediaAdapter(audioType);
                return this.mediaAdapter.play(audioType, fileName);
            }
            else
            {
                return string.Format("Invalid media {0} format not supported", audioType);
            }
        }
    }
}
