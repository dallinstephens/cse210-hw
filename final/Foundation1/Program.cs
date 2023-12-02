// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit06/project-plan.html

using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference for Video 1 and comments pasted from the following link: 
        // https://www.youtube.com/watch?v=ZghD9LplPug
        Video video1 = new Video("Think Celestial! | October 2023 General Conference", "Russell M. Nelson", 1155);
        Comment comment1Video1 = new Comment("Kevin Ferguson", "I am a baptised non denomination christian. Ive read your churches books and i truly believe President Nelson as modern day prophet he is truly and gifted by heavenly father. Thank you church of Jesus Christ of latter day saints. God Bless America 🇺🇸");
        Comment comment2Video1 = new Comment("Cyndi Podell", "i am not a member of the lds church but i love to listen to pres. nelson. he gives me peace. i pray for his recovery!");
        Comment comment3Video1 = new Comment("Michael Vitta", "This really hits home, I am so blessed to have found the restored gospel 2 years ago.");
        Comment comment4Video1 = new Comment("Bethony Theodor", "I live in Haiti. Thank you, President Nelson for your powerful message. I pray for your prompt recovery ! I am engaging in the journey of thinking celestial!");
        video1.AddComment(comment1Video1);
        video1.AddComment(comment2Video1);
        video1.AddComment(comment3Video1);
        video1.AddComment(comment4Video1);

        // Reference for Video 1 and comments pasted from the following link:
        // https://www.youtube.com/watch?v=o-Ts8kOpipQ
        Video video2 = new Video("Kingdoms of Glory | October 2023 General Conference", "Dallin H. Oaks", 973);
        Comment comment1Video2 = new Comment("Neil Horne", "Such an outstanding talk. One of my favorite talks from President Oaks. He taught the doctrine clearly and powerfully.");
        Comment comment2Video2 = new Comment("Kathy Wallace", "Thank you for this beautifully delivered message. I pray all who hear it will have an open heart and receive it and seek after exaltation.");
        Comment comment3Video2 = new Comment("Trevor Evans", "Clear and pure. You feel peace as he speaks of the doctrine like light from above.");
        Comment comment4Video2 = new Comment("Steve Quincy", "Love President Oaks, speaks clearly on the Church doctrine without apology or fear. We need this kind of leadership in this crazy, crazy world.");
        video2.AddComment(comment1Video2);
        video2.AddComment(comment2Video2);
        video2.AddComment(comment3Video2);
        video2.AddComment(comment4Video2);

        Video video3 = new Video("Our Constant Companion | October 2023 General Conference", "Henry B. Eyring", 1084);
        Comment comment1Video3 = new Comment("Laura Stennett", "I love President Eyring. He is a spiritual giant.");
        Comment comment2Video3 = new Comment("Dee Gold", "Thank you President Eyring. You're words speak deeply to my heart.");
        Comment comment3Video3 = new Comment("Doreen Liebenberg", "Amen, we need to strife daily to become a better people in every way that we can, thank you brother Eyring, blessings.");
        Comment comment4Video3 = new Comment("Motso Karametse", "The companionship of the holy ghost, has given me power on high. I stand all amazed at the influence and the direction of the Holy Ghost, it protects one from the enemy of righteousness.");
        video3.AddComment(comment1Video3);
        video3.AddComment(comment2Video3);
        video3.AddComment(comment3Video3);
        video3.AddComment(comment4Video3);

        Video video4 = new Video("The Prodigal and the Road That Leads Home | October 2023 General Conference", "Dieter F. Uchtdorf", 871);
        Comment comment1Video4 = new Comment("Dee Gold", "What a beautiful talk by our beloved Apostle Uchtdorf! The Father does forgive the lost sheep, I was one.");
        Comment comment2Video4 = new Comment("Troy Perry", "One of the best speakers in the LDS movement! He just has such incredible insights in all of the sermons  he preachers.");
        Comment comment3Video4 = new Comment("Steve Brown", "A wonderful explication of an incredible story of love, forgiveness and understanding. At some point in our lives we're all Prodigals, in one way or another.");
        Comment comment4Video4 = new Comment("Ron Smith", "Thank you Elder Uchtdorf for this talk.");
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