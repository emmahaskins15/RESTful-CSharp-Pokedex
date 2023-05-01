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
    public class Pokemon
    {

        private static Dictionary<int, PokemonData> cache = new Dictionary<int, PokemonData>();
        /// <summary>
        /// Takes int pokemonID
        /// Instantiates HttpClient and makes a GET request to PokeAPI, returns JSON string
        /// If success: deserializes JSON string into PokemonData instance pokemonData, returns pokemonData
        /// </summary>
        /// <param name="pokemonID"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public static PokemonData LoadPokemon(int pokemonID)
        {
            if (Pokemon.cache.ContainsKey(pokemonID))
            {
                return Pokemon.cache[pokemonID];
            }
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonID}/";
                HttpResponseMessage response =  httpClient.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    string json = response.Content.ReadAsStringAsync().Result;

                    PokemonData pokemonData = JsonSerializer.Deserialize<PokemonData>(json, options);
                    Pokemon.cache[pokemonID] = pokemonData;
                    return pokemonData;
                }
                else
                {
                    throw new HttpRequestException($"HTTP error: {response.StatusCode}");
                }
            }
        }
    }
    /// <summary>
    /// Represents data for a Pokemon.
    /// </summary>
    public class PokemonData
    {
        /// <summary>
        /// Gets or sets the name of the Pokemon.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Pokemon.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the height of the Pokemon.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the weight of the Pokemon.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the types of the Pokemon.
        /// </summary>
        public List<TypeItem> types { get; set; }

        /// <summary>
        /// Gets or sets the stats of the Pokemon.
        /// </summary>
        public List<StatsItem> stats { get; set; }
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
