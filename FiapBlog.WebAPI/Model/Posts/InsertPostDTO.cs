namespace FiapBlog.WebAPI.Model.Posts
{
    public class InsertPostDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int[] Categories { get; set; }
    }
}
