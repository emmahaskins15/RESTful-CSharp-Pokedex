using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
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

namespace Pokedex
{
    public partial class frmStats : Form
    {
        public PokemonData CurrentPokemon { get; set; }

        public frmStats(PokemonData pokemonData, string parsedPokemonName)
        {
            InitializeComponent();
            this.CurrentPokemon = pokemonData;
            this.CurrentPokemon.Name = parsedPokemonName;
        }

        private async void frmStats_Load(object sender, EventArgs e)
        {

            //string curDir = Directory.GetCurrentDirectory();
            //webBrowserStats.Navigate(new Uri(String.Format('file:///{0}/stats.html', curDir)));
            //WebView2 statsWebView = new WebView2();
            statsWebView.CoreWebView2InitializationCompleted += statsWebView_CoreWebView2InitializationCompleted;
            await statsWebView.EnsureCoreWebView2Async(null);


        }

       //PokemonStats LoadPokemonStats(PokemonData pokemonData)
       // {
       //     PokemonStats stats = new PokemonStats
       //     {
       //         HP = pokemonData.stats[0].BaseStat,
       //         Attack = pokemonData.stats[1].BaseStat,
       //         Defense = pokemonData.stats[2].BaseStat,
       //         SpecialAttack = pokemonData.stats[3].BaseStat,
       //         SpecialDefense = pokemonData.stats[4].BaseStat,
       //         Speed = pokemonData.stats[5].BaseStat
       //     };
       //     return stats;
       // }

        private void statsWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {

            string htmlTest = CurrentPokemon.Name;
            //double maxStatValue = Math.Max(CurrentPokemon.stats[0], Math.Max(CurrentPokemon.stats[1], Math.Max(CurrentPokemon.stats[2], Math.Max(CurrentPokemon.stats[3], Math.Max(CurrentPokemon.stats[4], CurrentPokemon.stats[5])))));
            double hpAsPercent = (double)CurrentPokemon.stats[0].BaseStat / 255 * 100;
            double atkAsPercent = (double)CurrentPokemon.stats[1].BaseStat / 255 * 100;
            double defAsPercent = (double)CurrentPokemon.stats[2].BaseStat / 255 * 100;
            double spAtkAsPercent = (double)CurrentPokemon.stats[3].BaseStat / 255 * 100;
            double spDefAsPercent = (double)CurrentPokemon.stats[4].BaseStat / 255 * 100;
            double spdAsPercent = (double)CurrentPokemon.stats[5].BaseStat / 255 * 100;

            //Define HTML document
            string html =
            @"<!DOCTYPE html>
            <html>
            <head>
                <style>
                    * {
                        font-family: Arial, Helvetica, sans-serif;
                        padding: 5px;
                    }
                    body {
                        border: 2px solid black;
                    }
                    .bar {
                        width: 200px;
                        height: 20px;
                        background-color: #ddd;
                        position: relative;
                        overflow: hidden;
                        border: 2px solid black;
                        border-radius: 25px;
                        margin: 3px;
                    }

                    .bar-fill{
                        position: absolute;
                        top: 0;
                        left: 0;
                        height: 100%;
                        font-weight: bold;
                        background-color: #4CAF50;
                    }

                    .hp {
                        background-color: #fe0000;
                    }

                    .attack {
                        background-color: #ef7e30;
                    }

                    .defense {
                        background-color: #f8d030;
                    }

                    .sp_atk {
                        background-color: #6890f2;
                    }

                    .sp_def {
                        background-color: #78c750;
                    }

                    .speed {
                        background-color: #f85687;
                    }

                    .label {
                        display: inline-block;
                        width: fit-content;
                        border: 2px solid black;
                        border-radius: 12px;
                    }
                </style>
            </head>

            <body>
                <h1>" + CurrentPokemon.Name + @" Stats Chart</h1>
                <div class='hp label'>HP</div>
                <div class='bar'>
                    <div class='bar-fill hp' style='width: " + hpAsPercent + @"%;'>" + CurrentPokemon.stats[0].BaseStat + @"</div>
                </div>
                <div class='attack label'>Attack</div>
                <div class='bar'>
                    <div class='bar-fill attack' style='width: " + atkAsPercent + @"%;'>" + CurrentPokemon.stats[1].BaseStat + @"</div>
                </div>
                <div class='defense label'>Defense</div>
                <div class='bar'>
                    <div class='bar-fill defense' style='width: " + defAsPercent + @"%;'>" + CurrentPokemon.stats[2].BaseStat + @"</div>
                </div>
                <div class='sp_atk label'>Special Attack</div>
                <div class='bar'>
                    <div class='bar-fill sp_atk' style='width: " + spAtkAsPercent + @"%;'>" + CurrentPokemon.stats[3].BaseStat + @"</div>
                </div>
                <div class='sp_def label'>Special Defense</div>
                <div class='bar'>
                    <div class='bar-fill sp_def' style='width: " + spDefAsPercent + @"%;'>" + CurrentPokemon.stats[4].BaseStat + @"</div>
                </div>
                <div class='speed label'>Speed</div>
                <div class='bar'>
                    <div class='bar-fill speed' style='width: " + spdAsPercent + @"%;'>" + CurrentPokemon.stats[5].BaseStat + @"</div>
                </div>
            </body>
            </html>";


            // Render HTML
            //webBrowserStats.Document.Write(html);
            statsWebView.NavigateToString(html);
            //webBrowserStats.Document.Write(htmlTest);
        }
    }
}
