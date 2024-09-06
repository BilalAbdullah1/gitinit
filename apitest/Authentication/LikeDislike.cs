namespace apitest.Authentication
{
    public class LikeDislike
    {
        public int Id { get; set; }
        public string UserId { get; set; } // From JWT Token
        public int ItemId { get; set; } // Post, Comment, etc.
        public bool IsLike { get; set; }
        public DateTime ActionDate { get; set; }
    }

}
