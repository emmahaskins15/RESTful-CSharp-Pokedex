﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
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
        public List<PokemonData> caughtPokemonList;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.caughtPokemonList = new List<PokemonData>();
            LoadSelectedPokemon(this.currentPokemonID);
        }
        /// <summary>
        /// Takes int pokemonID and instantiates a new instance of Pokemon.
        /// Passes pokemonID into to Pokemon.LoadPokemon(int pokemonID).
        /// Finally, calls DisplayStats, passing PokemonData currentPokemon
        /// </summary>
        /// <param name="pokemonID"></param>
        public void LoadSelectedPokemon(int pokemonID)
        {
            this.currentPokemon = Pokemon.LoadPokemon(pokemonID);
            DisplayStats(this.currentPokemon);
        }
        /// <summary>
        /// Takes PokemonData pokemon and assigns properties from pokemon to controls on frmMain
        /// </summary>
        /// <param name="pokemon"></param>
        public void DisplayStats(PokemonData pokemon)
        {
            lblNumber.Text = this.currentPokemon.ID.ToString();
            lblName.Text = ParsePokemonName(this.currentPokemon.Name);
            spriteBoxMain.ImageLocation = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{currentPokemon.ID}.png";
            lblType1.Text = (currentPokemon.Height * 10).ToString() + " cm";
            lblType2.Text = (currentPokemon.Weight * .1).ToString() + " kg";
        }
        /// <summary>
        /// Takes string name, removes dashes and replaces them with spaces, assigned to parsedName.
        /// Finally capitalizes and returns parsedName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string ParsePokemonName(string name)
                {
                    string parsedName = name.Replace("-", " ");
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    parsedName = textInfo.ToTitleCase(parsedName);
                    return parsedName;
                }
        /// <summary>
        /// Incrememnts currentPokemonID and calls LoadSelectedPokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncrement_Click(object sender, EventArgs e)
        {
            if (this.currentPokemonID == 10263)
            {
                this.currentPokemonID = 1;
            }
            else
            {
                this.currentPokemonID++;
            }
            LoadSelectedPokemon(this.currentPokemonID);

        }
        /// <summary>
        /// Decrements currentPokemonID and calls LoadSelectedPokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecrement_Click(object sender, EventArgs e)
        {
            if (this.currentPokemonID == 1)
            {
                currentPokemonID = 10263;
            }
            else
            {
                this.currentPokemonID--;
            }
            LoadSelectedPokemon(this.currentPokemonID);
        }
        /// <summary>
        /// Instantiates frmStats, passing PokemonData currentPokemon and the parsed string currentPokemon.Nam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStats_Click(object sender, EventArgs e)
        {
            Form frmStats = new frmStats(this.currentPokemon, ParsePokemonName(this.currentPokemon.Name));
            frmStats.ShowDialog();
        }
        /// <summary>
        /// Instantiates frmCaught, passing List of PokemonData caughtPokemonList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaught_Click(object sender, EventArgs e)
        {
            frmCaught frmCaught = new frmCaught(this.caughtPokemonList);
            frmCaught.Show();
        }

        /// <summary>
        /// Adds currentPokemon to caughtPokemonList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToCaught_Click(object sender, EventArgs e)
        {
            this.caughtPokemonList.Add(this.currentPokemon);
        }
    }
}
