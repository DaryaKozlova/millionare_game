using WMPLib;

namespace MillionareGame.Services
{
    public static class MusicService
    {
        private static readonly WindowsMediaPlayer MusicPlayer = new WindowsMediaPlayer();
        private static readonly string SoundPath = System.IO.Path.GetFullPath("../../sounds/");

        public static void StartMusic(string songName)
        {
            try
            {
                MusicPlayer.URL = MusicPlayer.URL = SoundPath + songName + ".mp3";
                MusicPlayer.controls.play();
            }
            catch
            {
                // ignored
            }
        }

        public static void StopMusic()
        {
            MusicPlayer.controls.stop();
        }
    }
}