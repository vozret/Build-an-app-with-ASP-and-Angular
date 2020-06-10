namespace BabyApp.API.Models
{
    public class Like
    {
        // user liking another user
        public int LikerId { get; set; }
        // user being liked by another user
        public int LikeeId { get; set; }
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}