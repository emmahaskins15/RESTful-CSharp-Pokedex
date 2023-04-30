using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<TypeItem> Types { get; set; }
        public List<StatsItem> Stats { get; set; }

        public string GetSpriteURL()
        {
            string spriteURL = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{ID}.png";
            return spriteURL;
        }

        public async Task LoadData(int pokemonID)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonID}/";
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    string json = await response.Content.ReadAsStringAsync();

                    PokemonData pokemonData = JsonSerializer.Deserialize<PokemonData>(json, options);
                    Name = pokemonData.Name;
                    ID = pokemonData.ID;
                    Height = pokemonData.Height;
                    Weight = pokemonData.Weight;
                    Types = pokemonData.types;
                    Stats = pokemonData.stats;
                }
                else
                {
                    throw new HttpRequestException($"HTTP error: {response.StatusCode}");
                }
            }
        }

    }
    public class PokemonData
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<TypeItem> types { get; set; }
        public List<StatsItem> stats { get; set; }
    }
    public class PokemonStats
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
    }

    public class TypeItem
    {
        public Type type { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
    }

    public class Stat
    {
        public string name { get; set; }
    }
    public class StatsItem
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
        public Stat stat { get; set; }
    }

}
