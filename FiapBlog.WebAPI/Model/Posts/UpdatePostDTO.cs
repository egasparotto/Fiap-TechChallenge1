namespace FiapBlog.WebAPI.Model.Posts
{
    public class UpdatePostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int[] Categories { get; set; }
    }
}
