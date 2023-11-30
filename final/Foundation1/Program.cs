// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit06/project-plan.html

using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title1", "Author1", 30);
        Comment comment1Video1 = new Comment("Name 1 Video 1", "comment 1 Video 1");
        Comment comment2Video1 = new Comment("Name 2 Video 1", "comment 2 Video 1");
        Comment comment3Video1 = new Comment("Name 3 Video 1", "comment 3 Video 1");
        Comment comment4Video1 = new Comment("Name 4 Video 1", "comment 4 Video 1");
        video1.AddComment(comment1Video1);
        video1.AddComment(comment2Video1);
        video1.AddComment(comment3Video1);
        video1.AddComment(comment4Video1);

        Video video2 = new Video("Title2", "Author2", 60);
        Comment comment1Video2 = new Comment("Name 1 Video 2", "comment 1 Video 2");
        Comment comment2Video2 = new Comment("Name 2 Video 2", "comment 2 Video 2");
        Comment comment3Video2 = new Comment("Name 3 Video 2", "comment 3 Video 2");
        Comment comment4Video2 = new Comment("Name 4 Video 2", "comment 4 Video 2");
        video2.AddComment(comment1Video2);
        video2.AddComment(comment2Video2);
        video2.AddComment(comment3Video2);
        video2.AddComment(comment4Video2);

        Video video3 = new Video("Title3", "Author3", 90);
        Comment comment1Video3 = new Comment("Name 1 Video 3", "comment 1 Video 3");
        Comment comment2Video3 = new Comment("Name 2 Video 3", "comment 2 Video 3");
        Comment comment3Video3 = new Comment("Name 3 Video 3", "comment 3 Video 3");
        Comment comment4Video3 = new Comment("Name 4 Video 3", "comment 4 Video 3");
        video3.AddComment(comment1Video3);
        video3.AddComment(comment2Video3);
        video3.AddComment(comment3Video3);
        video3.AddComment(comment4Video3);

        Video video4 = new Video("Title4", "Author4", 120);
        Comment comment1Video4 = new Comment("Name 1 Video 4", "comment 1 Video 4");
        Comment comment2Video4 = new Comment("Name 2 Video 4", "comment 2 Video 4");
        Comment comment3Video4 = new Comment("Name 3 Video 4", "comment 3 Video 4");
        Comment comment4Video4 = new Comment("Name 4 Video 4", "comment 4 Video 4");
        video4.AddComment(comment1Video4);
        video4.AddComment(comment2Video4);
        video4.AddComment(comment3Video4);
        video4.AddComment(comment4Video4);

        Videos videos = new Videos();
        videos.AddVideo(video1);
        videos.AddVideo(video2);
        videos.AddVideo(video3);
        videos.AddVideo(video4);
        Console.WriteLine(videos.ReturnVideos());
    }
}