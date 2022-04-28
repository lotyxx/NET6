using PlayGround.Model;
using PlayGround.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace WpfApp1
{
    internal class PeopleDataset
    {
        public static List<Person> People = new List<Person> ();

        public static string PeopleAPIUrl = "https://localhost:7171";
        public static void GeneratePeople(int cnt)
        {
            RandomPersonGenerator.GetPeople(cnt);
        }
        public static async Task LoadPeopleFromAPI(int cnt)
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetAsync(PeopleAPIUrl + "/people" + cnt.ToString());
            if(result.IsSuccessStatusCode)
            {
                People = await result.Content.ReadFromJsonAsync<List<Person>>();
            }
        }
    }

}
