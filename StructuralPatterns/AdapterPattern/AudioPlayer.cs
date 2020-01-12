using System;

namespace AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            //播放 mp3 音乐文件的内置支持
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine($"Playing mp3 file. Name: {fileName}");
            }
            //mediaAdapter 提供了播放其他文件格式的支持
            else if (audioType.Equals("vlc") || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Invalid media. {audioType} format not supported");
            }
        }
    }
}
