using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Speelkaarten
{
    public partial class FormSpeelkaarten : Form
    {
        private readonly Speelkaart kaart = new Speelkaart();
        private readonly List<Speelkaart> Deck = new List<Speelkaart>();

        public FormSpeelkaarten()
        {
            InitializeComponent();
            kaart.CreateDeck(Deck);

            lblDeck.Text = GetDeck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (Deck.Count == 1)
            {
                btnDraw.Enabled = false;
                btnShuffle.Enabled = true;
            }
            Random rand = new Random();
            int random = rand.Next(0, Deck.Count);
            lblDrawn.Text += $"\n{Deck[random].GetInfo()}";
            Deck.RemoveAt(random);
            lblDeck.Text = GetDeck();
        }

        private string GetDeck()
        {
            string deck = "Deck:";
            foreach (var card in Deck)
            {
                deck += $"\n{card.GetInfo()}";
            }
            return deck;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            kaart.CreateDeck(Deck);
            btnShuffle.Enabled = false;
            btnDraw.Enabled = true;
            lblDrawn.Text = "Drawn:";
            lblDeck.Text = GetDeck();
        }
    }
}