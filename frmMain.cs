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
        public static frmMain instance;
        public int currentPokemonID = 1;
        public PokemonData currentPokemon;
        public frmMain()
        {
            InitializeComponent();
            this.currentPokemon = Pokemon.LoadPokemon(this.currentPokemonID);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSelectedPokemon(currentPokemonID);
        }

        async void LoadSelectedPokemon(int pokemonID)
        {
            Pokemon selectedPokemon = new Pokemon();
            await selectedPokemon.LoadData(pokemonID);
            DisplayStats(selectedPokemon);
        }

        public void DisplayStats(Pokemon pokemon)
        {
            lblNumber.Text = currentPokemon.ID.ToString();
            lblName.Text = ParsePokemonName(currentPokemon.Name);
            spriteBoxMain.ImageLocation = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{currentPokemon.ID}.png";
            lblType1.Text = (currentPokemon.Height * 10).ToString() + " cm";
            lblType2.Text = (currentPokemon.Weight * .1).ToString() + " kg";
        }

        public static string ParsePokemonName(string name)
                {
                    string parsedName = name.Replace("-", " ");
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    parsedName = textInfo.ToTitleCase(parsedName);
                    return parsedName;
                }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            if (currentPokemonID == 10263)
            {
                currentPokemonID = 1;
            }
            else
            {
                currentPokemonID++;
            }
            LoadSelectedPokemon(currentPokemonID);
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            if (currentPokemonID == 1)
            {
                currentPokemonID = 10263;
            }
            else
            {  
                currentPokemonID--;
            }
            LoadSelectedPokemon(currentPokemonID);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Form frmStats = new frmStats(this.currentPokemon);
            frmStats.ShowDialog();
        }
        private void btnCaught_Click(object sender, EventArgs e)
        {
            frmCaught frmCaught = new frmCaught();
            frmCaught.Show();
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

// Format for returning type name eg "grass" and stat BaseStat eg "45"
// stats[0] = "hp". stats[1] = "attack", 2 = Def, 3 = Sp.Atk, 4 = Sp.Def, 5 = Speed
//var typesTest = pokemonData.types[0].type.name.ToString();
//var statsTest = pokemonData.stats[0].BaseStat.ToString() + " hp";
