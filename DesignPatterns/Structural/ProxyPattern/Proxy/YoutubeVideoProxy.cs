using System;

namespace DesignPatterns.Structural.ProxyPattern;

public class YoutubeVideoProxy : Video
{
    private string _videoId;
    private YoutubeVideo _youtubeVideo;

    public YoutubeVideoProxy(string videoId)
    {
        _videoId = videoId;

    }

    public void Render(){
        if(_youtubeVideo == null){
            _youtubeVideo = new YoutubeVideo(_videoId);
        }

        _youtubeVideo.Render();
    }
}
