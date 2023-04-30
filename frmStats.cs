using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pokedex.frmMain;
using static Pokedex.PokemonStats;

namespace Pokedex
{
    public partial class frmStats : Form
    {
        
        public frmStats()
        {
            InitializeComponent();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            
            //string curDir = Directory.GetCurrentDirectory();
            //webBrowserStats.Navigate(new Uri(String.Format('file:///{0}/stats.html', curDir)));

            //Define HTML document
            string html = 
            @"<!DOCTYPE html>
            <html>
            <head>
                <style>
                    @Model Pokemon;
                    .bar {
                        width: 200px;
                        height: 20px;
                        background-color: #ddd;
                        margin-bottom: 5px;
                        position: relative;
                        overflow: hidden;
                    }

                    .bar-fill {
                        position: absolute;
                        top: 0;
                        left: 0;
                        height: 100%;
                        background-color: #4CAF50;
                    }

                    .hp {
                        background-color: #FF0000;
                    }

                    .attack {
                        background-color: #FFA500;
                    }

                    .defense {
                        background-color: #808080;
                    }

                    .sp_atk {
                        background-color: #FF00FF;
                    }

                    .sp_def {
                        background-color: #00FFFF;
                    }

                    .speed {
                        background-color: #00FF00;
                    }

                    .label {
                        display: inline-block;
                        margin-bottom: 5px;
                        width: 100px;
                        font-weight: bold;
                    }
                </style>
            </head>

            <body>
                <h1>Pokemon Stats Chart</h1>
                <div class='hp label'>HP</div>
                <div class='bar'>
                    <div class='bar-fill hp' style='width: @Model.HpPercent%;'></div>
                </div>
                <div class='attack label'>Attack</div>
                <div class='bar'>
                    <div class='bar-fill attack' style='width: @Model.AttackPercent%;'></div>
                </div>
                <div class='defense label'>Defense</div>
                <div class='bar'>
                    <div class='bar-fill defense' style='width: @Model.DefensePercent%;'></div>
                </div>
                <div class='sp_atk label'>Special Attack</div>
                <div class='bar'>
                    <div class='bar-fill sp_atk' style='width: @Model.SpAtkPercent%;'></div>
                </div>
                <div class='sp_def label'>Special Defense</div>
                <div class='bar'>
                    <div class='bar-fill sp_def' style='width: @Model.SpDefPercent%;'></div>
                </div>
                <div class='speed label'>Speed</div>
                <div class='bar'>
                    <div class='bar-fill speed' style='width: @Model.SpeedPercent%;'></div>
                </div>
            </body>
            </html>";
            

            // Render HTML
            webBrowserStats.Document.Write(html);

        }

       PokemonStats LoadPokemonStats(PokemonData pokemonData)
        {
            PokemonStats stats = new PokemonStats
            {
                HP = pokemonData.stats[0].BaseStat,
                Attack = pokemonData.stats[1].BaseStat,
                Defense = pokemonData.stats[2].BaseStat,
                SpecialAttack = pokemonData.stats[3].BaseStat,
                SpecialDefense = pokemonData.stats[4].BaseStat,
                Speed = pokemonData.stats[5].BaseStat
            };
            return stats;
        }
    }
}
