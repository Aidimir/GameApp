using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
namespace GameApp.models
{
    public class MusicPlayer
    {
        private const string PathToMusic = @"music\gameMusic.wav";
        private readonly SoundPlayer simpleSound;
        public bool IsPlaying { get; private set; }

        public MusicPlayer()
        {
            if (!File.Exists(PathToMusic))
                return;
            simpleSound = new SoundPlayer(PathToMusic);
        }

        public void Start()
        {
            IsPlaying = true;
            simpleSound.PlayLooping();
        }

        public void Stop()
        {
            IsPlaying = false;
            simpleSound.Stop();
        }
    }
}
