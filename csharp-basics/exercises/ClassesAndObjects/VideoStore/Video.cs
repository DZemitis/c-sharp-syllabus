using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace VideoStore
{
   public class Video
    {
        public string Title;
        public bool CheckedOut;
        public List<double> _rating;
        public Video(string title)
        {
            Title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            CheckedOut = true;
        }

        public void BeingReturned()
        {
            CheckedOut = false;
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
            return CheckedOut = false;
        }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
