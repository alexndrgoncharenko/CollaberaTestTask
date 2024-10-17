namespace CollaberaTestTask.Services
{
    public interface IHackerNewsService
    {
        Task<List<Story>> GetBestStoriesAsync(int count);
    }
}
