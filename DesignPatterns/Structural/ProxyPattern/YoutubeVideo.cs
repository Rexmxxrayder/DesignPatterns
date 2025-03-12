using System;

namespace DesignPatterns.Structural.ProxyPattern;

public class YoutubeVideo : Video
{
    private string _videoId;

    public YoutubeVideo(string videoId)
    {
        _videoId = videoId;
        Download();
    }

    private void Download()
    {
        Console.WriteLine("Downloading video with id " + _videoId);
    }

    public void Render()
    {
        Console.WriteLine("Render Video" + _videoId);
    }
}
