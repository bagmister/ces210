using System;

class Program
{
    static void Main(string[] args)
    {   
        var video1 = new Video();
        var video1Comment1 = new Comment();
        var video1Comment2 = new Comment();
        var video1Comment3 = new Comment();
        
        var video2 = new Video();
        var video2Comment1 = new Comment();
        var video2Comment2 = new Comment();
        var video2Comment3 = new Comment();
        
        var video3 = new Video();
        var video3Comment1 = new Comment();
        var video3Comment2 = new Comment();
        var video3Comment3 = new Comment();

        video1.SetTitle("How to buy quality and avoid RV lemons in 2023 - from a RV tech");
        video1.SetAuthor("Rigor RV Repair");
        video1.SetLength(257);
        video1Comment1.SetName("walterrafolski5662");
        video1Comment1.SetText("I’m going to bet the manufacturers don’t like you, but thank God the consumers have you and folks like you!");
        video1Comment2.SetName("fit4ya1975");
        video1Comment2.SetText("For the amount of money these manufactures are charging us, these units should all be 10/10 and have a 7 year bumper to bumper warranty period.");
        video1Comment3.SetName("williamtoney2599");
        video1Comment3.SetText("I’m not a RV tech by no long means, but i do have 20 years as a diesel truck mechanic and another 20 plus years as an industrial maintenance mechanic, and I can tell you that no matter what brand or model you buy, spend hours looking your new RV a over. The last 3 campers I’ve owned I can’t tell you how many hours I spent fixing stuff that weren’t broke, but would have caused problems later on. If you don’t know that much about wiring, plumbing, carpentry, etc., then pay someone a couple hundred bucks to look you new camper or RV over for potential problems. You’ll thank me later. You wouldn’t believe some of the things I found….");
        video1.AddCommentToList(video1Comment1);
        video1.AddCommentToList(video1Comment2);
        video1.AddCommentToList(video1Comment3);
        
        video2.SetTitle("The dirty truth about RV plumbing codes");
        video2.SetAuthor("Rigor RV Repair");
        video2.SetLength(428);
        video2Comment1.SetName("rvingandtheopenroad");
        video2Comment1.SetText("Jacob, your video’s are top notch quality gold. You are doing an incredible service to the entire RV industry by educating us and highlighting poor design in build quality. This is exactly what we the consumer needs to help hold the manufacturers accountable, keep these videos coming. I recorded and published a coupe recent video on my YouTube channel on this very topic, my freshwater fill was so bad it not only leaked but it has a kink which lead to fill issues. After thar video is when I discovered you, which helped me correct my leaks and fittings");
        video2Comment2.SetName("terranncegilmore");
        video2Comment2.SetText("Someone should share this video with certain YouTubers that are breaking their backs carrying water (no pun intended) for the RV manufacturers");
        video2Comment3.SetName("steveborchello4744");
        video2Comment3.SetText("Thank you Jacob! We appreciate your up front and straightforward information!  I have recently experienced a small drip / leak at one of my connections (flexible tubing, pex clamp, on a copper manifold). Per your video - a complete “no no”! This was on my 2018 Tiffin Open Road - just started leaking in 2024. We bought some stainless steel hose clamps…and fixed! I do watch it like a hawk…but it has been great / no issues. I have now gone through the entire RV and have checked the plumbing connections in an attempt to prevent any further leaks / issues.");
        video2.AddCommentToList(video2Comment1);
        video2.AddCommentToList(video2Comment2);
        video2.AddCommentToList(video2Comment3);
        
        video3.SetTitle("RV tech reviews Alliance Delta travel trailer - honest review!");
        video3.SetAuthor("Rigor RV Repair");
        video3.SetLength(387);
        video3Comment1.SetName("roadtripwarriors7458");
        video3Comment1.SetText("We watch a number of YouTube RV type channels but your channel is always a \"\\Must Watch\"\\ when you post a new video! We are not even in the market for an RV now (we bought a 2019 flagstaff E-Pro 19BH about 1 1/2 years ago, which so far after about 17,000 miles has given us no major problem) but we find your videos so informative and helpful now, and will certainly help us going forward. Never knew anything about bad plumbing until we started watching your videos.  Your channel will continue to grow rapidly, particularly with all of the junk RV manufacturers are pushing out now.");
        video3Comment2.SetName("JeffinTD");
        video3Comment2.SetText("Well that’s hugely disappointing.  I was really hoping Alliance would do better.  Thanks for doing this video.");
        video3Comment3.SetName("judeg.8101");
        video3Comment3.SetText("I live full time in a RV for work. And I have to buy a new one. I don't want to buy any of them watching your channel.");
        video3.AddCommentToList(video3Comment1);
        video3.AddCommentToList(video3Comment2);
        video3.AddCommentToList(video3Comment3);
        

        video1.DisplayVideosWithComments(video1);
        video2.DisplayVideosWithComments(video2);
        video3.DisplayVideosWithComments(video3);


    }
}