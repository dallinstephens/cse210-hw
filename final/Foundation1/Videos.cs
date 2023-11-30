public class Videos
{
    private List<Video> _videos = new List<Video>();

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public string ReturnVideos()
    {
        string videos = "";

        foreach (Video video in _videos)
        {
            videos += video.ToString();
        }

        return videos;
    }
}