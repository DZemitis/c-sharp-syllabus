namespace VideoStore
{
    class VideoStore
    {
        public int UserRating;
        public int AvarageUserRating;
        public int UsersRated;
        public VideoStore()
        {

        }

        public void AddVideo(string title)
        {
        }

        public void Checkout(string title)
        {

        }

        public void ReturnVideo(string title)
        {
        }

        public void TakeUsersRating(double rating, string title)
        {
            UsersRated++;
            UserRating += UserRating;
            AvarageUserRating = UserRating / UsersRated;
        }

        public void ListInventory()
        {

        }
    }
}
