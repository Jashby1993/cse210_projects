//for each video, I added a video summary description summary intuitively, then saw that it wasn't in the program description. Please don't count points against that!
using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("GrillMasterMike","This video made me so hungry! I can't wait to try making my own churrasco this weekend. Thanks for the tips!");
        Comment comment2 = new Comment("FoodieAdventures","The seasoning techniques were spot on! I tried it with picanha, and it was a huge hit at my BBQ party. Obrigado!");
        Comment comment3 = new Comment("BBQLover87","What an incredible guide! I've always wanted to learn how to make authentic Brazilian churrasco. The step-by-step instructions were super helpful.");
        Comment comment4 = new Comment("ChefAntonio","Fantastic video! I loved the detailed explanation of each meat cut. This is definitely going to elevate my grilling game.");
        Video video1 = new Video
        (
            "The Ultimate Guide to Brazilian Churrasco",
            "Chef Silva",
            "15:48",
            "Join us as we explore the rich flavors and traditions of Brazilian churrasco. Learn the secrets of preparing and grilling various cuts of meat to perfection. Get tips on creating authentic Brazilian barbecue at home, complete with sides and sauces."
        );
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment3);

        Video video2 = new Video
        (
            "C# for Beginners: Complete Programming Tutorial",
            "Ask a Coding Ninja",
            "49:16",
            "Dive into the world of C# programming with our comprehensive tutorial designed for beginners. Learn the basics of C# syntax, variables, loops, and more. Perfect for aspiring developers looking to start their journey in software development."
        );
        Comment comment5 = new Comment("CodeNinja","This tutorial is exactly what I needed! The explanations are clear, and the examples are easy to follow. Great job!");
        Comment comment6 = new Comment("TechGuru99","As someone new to programming, I found this tutorial incredibly helpful. The pace is perfect, and I appreciate the detailed explanations.");
        Comment comment7 = new Comment("DevJourney","Awesome tutorial! I love how you break down complex concepts into simple terms. This is a must-watch for anyone starting with C#.");
        Comment comment8 = new Comment("ByteMaster","Thank you for this amazing tutorial! It's so comprehensive and beginner-friendly. Looking forward to more videos like this.");
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);

        Video video3 = new Video
        (
            "Mastering Spades: A Beginner’s Guide",
            "Card Counter",
            "11:23",
            "Learn the basics of Spades, a classic card game. This tutorial covers the rules, strategies, and tips to help you become a skilled player. Perfect for beginners and those looking to refine their gameplay."
        );
        Comment comment9 = new Comment("CardKing23","This tutorial was super helpful! I finally understand how to play Spades. Thanks for the clear instructions!");
        Comment comment10 = new Comment("GameNightGuru","Great video! The examples and explanations made it easy to follow. Can't wait to try these strategies with my friends.");
        Comment comment11 = new Comment("SpadesLover","I appreciate the detailed walkthrough. The tips on bidding and trump cards were especially useful. Awesome job!");
        Comment comment12 = new Comment("AcePlayer","Fantastic tutorial! I’ve been struggling with Spades, but this video made it so much clearer. Looking forward to more card game tutorials from you.");
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);

        Video video4 = new Video
        (
            "Effective Strategies for Managing Stress,",
            "Dr Chill",
            "34:10",
            "Discover practical techniques for managing stress in your daily life. This video provides insights into stress reduction methods such as mindfulness, exercise, and time management. Learn how to improve your mental well-being and maintain a balanced lifestyle."
        );
        Comment comment13 = new Comment("WellnessWarrior","This video came at the perfect time. The tips on mindfulness and breathing exercises are already helping me feel more relaxed. Thank you!");
        Comment comment14 = new Comment("CalmMind","Excellent strategies for managing stress. I’ve been struggling with work stress, and these tips are very practical. Great video!");
        Comment comment15 = new Comment("HealthyLiving","I love the holistic approach you took. Combining exercise with mindfulness is a game changer for me. Thanks for sharing!");
        Comment comment16 = new Comment("StressFreeMe","This video is so helpful! The time management tips are exactly what I needed to hear. Keep up the great work!");

        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);

        List<Video> ContentLibrary = new List<Video>();
        ContentLibrary.Add(video1);
        ContentLibrary.Add(video2);
        ContentLibrary.Add(video3);
        ContentLibrary.Add(video4);

        foreach (Video video in ContentLibrary)
        {
            video.DisplayFullDetails();
        }    
    }

}