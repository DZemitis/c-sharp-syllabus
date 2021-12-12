using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {

        private List<Video> _videos = new List<Video>();


        public VideoStore()
        {

        }

        public void AddVideo(string title)
        {
            _videos.Add(new Video(title));
        }

        public void Checkout(string title)
        {
            foreach (Video video in _videos)
            {
                if (video.Title == title)
                {
                    video.BeingCheckedOut();
                    return;
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (Video video in _videos)
            {
                if (video.Title == title)
                {
                    video.BeingReturned();
                    return;
                }
            }

        }


        public void TakeUsersRating(double rating, string title)
        {
            foreach (Video video in _videos)
            {
                if (video.Title == title)
                {
                    video.ReceivingRating(rating);
                    return;
                }
            }

            Console.WriteLine("Video not found");
        }

        public void ListInventory()
        {
            foreach (var c in _videos)
            {
                Console.WriteLine(c);
            }
        }
    }
}
