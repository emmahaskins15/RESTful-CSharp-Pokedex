using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pokedex
{
    public partial class frmMain : Form
    {
        public int currentPokemonID = 1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCaught_Click(object sender, EventArgs e)
        {
            frmCaught frmCaught = new frmCaught();
            frmCaught.Show();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            //readCSVFile();
            //List<string[]> pokemonList = readCSVFile();
            Pokemon selectedPokemon = await GetPokemonDataAsync(currentPokemonID);
            loadSelectedPokemon(selectedPokemon);
        }
        public void loadSelectedPokemon(Pokemon pokemon)
        {
            lblNumber.Text = pokemon.ID.ToString();
            lblName.Text = pokemon.Name;
        }
        static async Task<Pokemon> GetPokemonDataAsync(int pokemonID)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync($"{pokemonID}");

                Console.WriteLine("GetAsyncPokeAPI: " + response.EnsureSuccessStatusCode().ToString());


                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };


                    Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(responseBody, options);
                    return pokemon;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null;
                }


            }
        }
        public class Pokemon
        {
            [JsonPropertyName("id")]
            public int ID { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("types")]
            public
        }

        //private List<string[]> readCSVFile()
        //{
        //    List<string[]> pokemonList = new List<string[]>();

        //    try
        //    {
        //        var reader = new StreamReader("Pokemon.csv");

        //        while (!reader.EndOfStream)
        //        {
        //            string line = reader.ReadLine();
        //            string[] values = line.Split(',');
        //            pokemonList.Add(values);
        //        }
        //        reader.Close();

        //        // Console.WriteLine(pokemonList[1][1].ToString());
        //        // > 'Bulbsaur'

        //    }
        //    catch (FileNotFoundException e)
        //    {
        //        MessageBox.Show(e.Message, "Error: pokemon.csv not found.");
        //        Close();
        //    }
        //    return pokemonList;
        //}

        private async void btnIncrement_Click(object sender, EventArgs e)
        {
            if (currentPokemonID == 10271)
            {
                currentPokemonID = 1;
            }
            else
            {
                currentPokemonID++;
            }
            Pokemon selectedPokemon = await GetPokemonDataAsync(currentPokemonID);
            loadSelectedPokemon(selectedPokemon);
        }

        private async void btnDecrement_Click(object sender, EventArgs e)
        {
            if (currentPokemonID == 1)
            {
                currentPokemonID = 10271;
            }
            else
            {  
                currentPokemonID--;
            }
            Pokemon selectedPokemon = await GetPokemonDataAsync(currentPokemonID);
            loadSelectedPokemon(selectedPokemon);
        }
    }
}
