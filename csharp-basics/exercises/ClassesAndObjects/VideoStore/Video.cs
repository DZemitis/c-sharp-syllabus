using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
   public class Video
    {
        private string Title;
        public bool BeeingCheckedOut;
        private List<double> _rating;
        public Video(string title)
        {
            Title = title;
            _rating = new List<double>();
        }

        public Video(string title, int rating) : this(title)
        {
            
        }

        public void BeingCheckedOut()
        {
            BeeingCheckedOut = true;
        }

        public void BeingReturned()
        {

        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return _rating.Average();
        }

        public bool Available()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
