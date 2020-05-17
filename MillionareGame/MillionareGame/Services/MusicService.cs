using System;
using WMPLib;

namespace MillionareGame.Services
{
    public static class MusicService
    {
        public enum Sounds
        {
            ButtonWaitAnswer,
            CorrectAnswer,
            MainTheme,
            QuestionThreeMusic,
            WrongAnswer
        };

        private static readonly WindowsMediaPlayer MusicPlayer = new WindowsMediaPlayer();
        private static readonly string SoundPath = System.IO.Path.GetFullPath("../../sounds/");

        public static void SetMusic(Sounds sound)
        {
            var soundName = "";

            switch (sound)
            {
                case Sounds.ButtonWaitAnswer:
                    soundName = "buttonWaitAnswer";
                    break;
                case Sounds.CorrectAnswer:
                    soundName = "correctAnswer";
                    break;
                case Sounds.MainTheme:
                    soundName = "mainTheme";
                    break;
                case Sounds.QuestionThreeMusic:
                    soundName = "questionThreeMusic";
                    break;
                case Sounds.WrongAnswer:
                    soundName = "wrongAnswer";
                    break;
            }

            try
            {
                MusicPlayer.URL = MusicPlayer.URL = SoundPath + soundName + ".mp3";
            }
            catch
            { }
        }

        public static void PlayMusic()
        {
            MusicPlayer.controls.play();
        }

        public static void StopMusic()
        {
            MusicPlayer.controls.stop();
        }
    }
}