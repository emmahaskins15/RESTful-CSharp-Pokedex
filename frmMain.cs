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
        public int currentPokemonID;

        public frmMain()
        {
            InitializeComponent();
            instance = this;
            currentPokemonID = 1;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Pokemon selectedPokemon = new Pokemon();
            //await selectedPokemon.LoadData(currentPokemonID);
            LoadSelectedPokemon(currentPokemonID);
            //PokemonStats pokemonStats = new PokemonStats()
            //{
            //    HP = selectedPokemon.Stats[0].BaseStat,
            //    Attack = selectedPokemon.Stats[1].BaseStat,
            //    Defense = selectedPokemon.Stats[2].BaseStat,
            //    SpecialAttack = selectedPokemon.Stats[3].BaseStat,
            //    SpecialDefense = selectedPokemon.Stats[4].BaseStat,
            //    Speed = selectedPokemon.Stats[5].BaseStat,
            //};
        }

        async void LoadSelectedPokemon(int pokemonID)
        {
            Pokemon selectedPokemon = new Pokemon();
            await selectedPokemon.LoadData(pokemonID);
            lblNumber.Text = selectedPokemon.ID.ToString();
            lblName.Text = ParsePokemonName(selectedPokemon.Name);
            spriteBoxMain.ImageLocation = selectedPokemon.GetSpriteURL();
            lblType1.Text = (selectedPokemon.Height * 10).ToString() + " cm";
            lblType2.Text = (selectedPokemon.Weight * .1).ToString() + " kg";
        }

        //void LoadSelectedPokemon(Pokemon pokemon)
        //{
        //    lblNumber.Text = pokemon.ID.ToString();
        //    lblName.Text = ParsePokemonName(pokemon.Name);
        //    spriteBoxMain.ImageLocation = pokemon.GetSpriteURL();
        //    lblType1.Text = (pokemon.Height * 10).ToString() + " cm";
        //    lblType2.Text = (pokemon.Weight * .1).ToString() + " kg";
        //}

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
            Form frmStats = new frmStats();
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
