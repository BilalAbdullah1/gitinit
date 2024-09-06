using apitest.Authentication;

namespace apitest.Model
{
    public class LikeDisLikes
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Foreign key to ApplicationUser
        public int ItemId { get; set; }
        public bool IsLike { get; set; }
        public ApplicationUser User { get; set; }
    }
}
