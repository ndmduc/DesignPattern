
// STEP 3

namespace Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMediaPlayer=new Mp4Player();
            }
        }

        public string play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                return advancedMediaPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                return advancedMediaPlayer.playMp4(fileName);
            }

            return "---";
        }
    }
}
