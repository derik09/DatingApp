namespace DatingApp.API.Models
{
    public class Like
    {
        //User likes another user
        public int LikerId { get; set; }

        //User being liked by another user
        public int LikeeId { get; set; }

        public User Liker { get; set; }

        public User Likee { get; set; }
    }
}