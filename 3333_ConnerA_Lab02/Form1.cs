using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_ConnerA_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void favoriteSongButton_Click(object sender, EventArgs e)
        {
            // display the favorite song in message window and label 

            MessageBox.Show("Sugar Rush Ride by TXT");
            favoriteSong.Visible = true;
            favoriteSong.Text = "Sugar Rush Ride by TXT";
        }

        private void favoriteMovieButton_Click(object sender, EventArgs e)
        {
            // display the favorite movie in message window and label

            MessageBox.Show("Harry Potter and the Chamber of Secrets");
            favoriteMovie.Visible = true;
            favoriteMovie.Text = "Harry Potter and the Chamber of Secrets";
        }

        private void favoriteDrinkButton_Click(object sender, EventArgs e)
        {
            // display the favorite drink in message window and label

            MessageBox.Show("Dragonfruit Bubble Tea");
            favoriteDrink.Visible = true;
            favoriteDrink.Text = "Dragonfruit Bubble Tea";
        }

        private void aestheticPictureBox_Click(object sender, EventArgs e)
        {
            // display the videogamePictureBox with the corresponding videogame in the label
            // when clicking the aestheticPictureBox

            aestheticPictureBox.Visible = false;

            videogamePictureBox.Visible = true;
            favoriteThing.Text = "The Last of Us";
        }

        private void videogamePictureBox_Click(object sender, EventArgs e)
        {
            // display the aestheticPictureBox with the corresponding aesthetic in the label
            // when clicking the videogamePictureBox

            videogamePictureBox.Visible = true;

            aestheticPictureBox.Visible = true;
            favoriteThing.Text = "8-Bit Aesthetic";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // when clicking the "Clear" button, it clears all of the labels from all four label controls

            clearButton.Text = "Clear";
            favoriteSong.Text = "";
            favoriteMovie.Text = "";
            favoriteDrink.Text = "";
            favoriteThing.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            
            this.Close();
        }

        // Alcaeus Andrea Conner, 001031349, 02052023, 02052023,
        // This program displays my favorite things like song, movie, and drink.
        // It also displays my favorite videogame and aesthetic when clicking the pictures on the bottom
    }
}
