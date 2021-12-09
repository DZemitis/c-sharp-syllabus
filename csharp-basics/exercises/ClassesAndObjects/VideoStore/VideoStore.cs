using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        public List<string> VideoList;
        public List<Video> Videos;


        public VideoStore()
        {
            VideoList = new List<string>();
            Videos = new List<Video>();
        }

        public void AddVideo(string title)
        {
            VideoList.Add(title);
        }

        public void Checkout(string title)
        {
            VideoList.Remove(title);
        }

        public void ReturnVideo(string title, double userRating)
        {
            VideoList.Add(title);
            TakeUsersRating(userRating, title);
        }


        public void TakeUsersRating(double rating, string title)
        {
            foreach (Video video in Videos)
            {
                if (video.Title == title) { video.ReceivingRating(rating); return; }
            }

            Console.WriteLine("Video not found");
        }

        public void ListInventory()
        {
            foreach (var c in VideoList)
            {
                Console.WriteLine(c);
            }
        }
    }
}
