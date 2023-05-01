using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex;

namespace Pokedex
{
    public partial class frmCaught : Form
    {
        public List<PokemonData> caughtPokemonList { get; set; }
        public string caughtPokemonName { get; set; }
        public string caughtPokemonSprite { get; set; }

        /// <summary>
        /// Takes  List of PokemonData and assigns values to frmCaught.caughtPokemonList
        /// </summary>
        /// <param name="caughtPokemonList"></param>
        public frmCaught(List<PokemonData> caughtPokemonList)
        {
            InitializeComponent();
            this.caughtPokemonName = caughtPokemonName;
            this.caughtPokemonSprite = caughtPokemonSprite;
            this.caughtPokemonList = caughtPokemonList;
        }

        private void frmCaught_Load(object sender, EventArgs e)
        {
            lstCaughtPokemon.Items.Clear();
            if (caughtPokemonList != null)
            {
                foreach (PokemonData pokemon in caughtPokemonList)
                {
                    lstCaughtPokemon.Items.Add(pokemon.Name);
                }

            }

        }
    }
}
