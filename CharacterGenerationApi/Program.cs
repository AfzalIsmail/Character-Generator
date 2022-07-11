using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;

namespace CharacterGenerationApi
{
    class Program
    {

        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {

            var streamTask = client.GetStreamAsync("https://randomuser.me/api/");
            var repositories = await JsonSerializer.DeserializeAsync<Repository>(await streamTask);

            var results = repositories.Results;

            Console.WriteLine(results);

            Character newCharacter = new Character();

            newCharacter.gender = results[0].Gender;
            newCharacter.firstName = results[0].Name.First;
            newCharacter.lastName = results[0].Name.Last;
            newCharacter.city = results[0].Location.City;
            newCharacter.country = results[0].Location.Country;
            newCharacter.email = results[0].Email;
            newCharacter.username = results[0].Login.Username;
            newCharacter.password = results[0].Login.Password;
            newCharacter.age = results[0].Dob.Age;
            newCharacter.phone = results[0].Phone;

            Console.WriteLine(newCharacter.generateJson());

            WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder();
            WebApplication webApplication = webApplicationBuilder.Build();

            webApplication.MapGet("api/character", (Func<string>)(() => newCharacter.generateJson()));

            webApplication.Run();

        }
    }


}
