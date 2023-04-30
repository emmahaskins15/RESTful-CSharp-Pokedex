using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

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
            Pokemon selectedPokemon = new Pokemon();
            await selectedPokemon.LoadData(currentPokemonID);
            loadSelectedPokemon(selectedPokemon);
        }
        public void loadSelectedPokemon(Pokemon pokemon)
        {
            lblNumber.Text = pokemon.ID.ToString();
            lblName.Text = ParsePokemonName(pokemon.Name);
            spriteBoxMain.ImageLocation = pokemon.GetSpriteURL();
            lblType1.Text = (pokemon.Height * 10).ToString() + " cm";
            lblType2.Text = (pokemon.Weight * .1).ToString() + " kg";
        }

        public static string ParsePokemonName(string name)
                {
                    string parsedName = name.Replace("-", " ");
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    parsedName = textInfo.ToTitleCase(parsedName);
                    return parsedName;
                }


        public class Pokemon
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

                        // Format for returning type name eg "grass" and stat BaseStat eg "45"
                        // stats[0] = "hp". stats[1] = "attack", 2 = Def, 3 = Sp.Atk, 4 = Sp.Def, 5 = Speed
                        var typesTest = pokemonData.types[0].type.name.ToString();
                        var statsTest = pokemonData.stats[0].BaseStat.ToString() + " hp";

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
            Pokemon selectedPokemon = new Pokemon();
            await selectedPokemon.LoadData(currentPokemonID);
            loadSelectedPokemon(selectedPokemon);
        }

        private async void btnDecrement_Click(object sender, EventArgs e)
        {
            if (currentPokemonID == 1)
            {
                currentPokemonID = 10263;
            }
            else
            {  
                currentPokemonID--;
            }
            Pokemon selectedPokemon = new Pokemon();
            await selectedPokemon.LoadData(currentPokemonID);
            loadSelectedPokemon(selectedPokemon);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Form frmStats = new Form();
            frmStats.ShowDialog();
        }
    }
}



// Captains log
//Types still don't work
//    Should probably just use the CSV
//    omg you deleted it wtf bro
//    like actually wtf
//    okay
//    this is fine
//    I need to deserialize stats and GUI them up into a bar graph or w/e
//    And I also need to implement an HTML thing, maybe a bar graph? or a cry played in a webframe?

