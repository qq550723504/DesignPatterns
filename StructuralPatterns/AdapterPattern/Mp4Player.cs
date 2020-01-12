using System;

namespace AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4  file. Name: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
