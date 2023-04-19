namespace CodingExercise.Services
{
    public class HomeService
    {
        public async Task<string> GetUsersAsync()
        {
            var httpClient = new HttpClient();
            
            return await httpClient.GetStringAsync("https://dummyjson.com/users");
        }
    }
}
