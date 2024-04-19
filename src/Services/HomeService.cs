namespace CodingExercise.Services
{
    public class HomeService
    {
        public async Task<string> GetUsersAsync()
        {
            var httpClient = new HttpClient();
            
            var json = await httpClient.GetStringAsync("https://dummyjson.com/users");

            // TODO: didn't not have time to finish this
            return json;
        }
    }
}
