using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Video
    {
        public string Title;
        private bool _checkedOut;
        private List<double> _rating;

        public Video(string title)
        {
            Title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _checkedOut = true;
        }

        public void BeingReturned()
        {
            _checkedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public string DisplayProcentageLiked()
        {
            var positive = 0;
            var negative = 0;
            foreach (var n in _rating)
            {
                if (n > 5)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            var total = positive + negative;
            return $"{positive * 100 / total}";
        }

        public double AverageRating()
        {
            return _rating.Average();
        }

        public override string ToString()
        {
            if (_checkedOut == false)
            {
                return $"Available: {Title}. With average rating of: {AverageRating()}, positivity of {DisplayProcentageLiked()}%";
            }
            else
            {
                return $"{Title} is not available right now!";
            }
        }
    }
}
