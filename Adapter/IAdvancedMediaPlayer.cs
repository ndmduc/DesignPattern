
// STEP 1

namespace Adapter
{
    public interface IAdvancedMediaPlayer
    {
        string playVlc(string fileName);

        string playMp4(string fileName);
    }
}
