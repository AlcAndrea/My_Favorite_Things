
namespace _3333_ConnerA_Lab02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.favoriteSong = new System.Windows.Forms.Label();
            this.favoriteMovie = new System.Windows.Forms.Label();
            this.favoriteDrink = new System.Windows.Forms.Label();
            this.favoriteThing = new System.Windows.Forms.Label();
            this.favoriteSongButton = new System.Windows.Forms.Button();
            this.favoriteMovieButton = new System.Windows.Forms.Button();
            this.favoriteDrinkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.videogamePictureBox = new System.Windows.Forms.PictureBox();
            this.aestheticPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videogamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Favorite Things";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click on Image to Change it!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteSong
            // 
            this.favoriteSong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteSong.Location = new System.Drawing.Point(209, 61);
            this.favoriteSong.Name = "favoriteSong";
            this.favoriteSong.Size = new System.Drawing.Size(246, 30);
            this.favoriteSong.TabIndex = 2;
            this.favoriteSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteMovie
            // 
            this.favoriteMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteMovie.Location = new System.Drawing.Point(209, 106);
            this.favoriteMovie.Name = "favoriteMovie";
            this.favoriteMovie.Size = new System.Drawing.Size(246, 30);
            this.favoriteMovie.TabIndex = 3;
            this.favoriteMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteDrink
            // 
            this.favoriteDrink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteDrink.Location = new System.Drawing.Point(209, 150);
            this.favoriteDrink.Name = "favoriteDrink";
            this.favoriteDrink.Size = new System.Drawing.Size(246, 30);
            this.favoriteDrink.TabIndex = 4;
            this.favoriteDrink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteThing
            // 
            this.favoriteThing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteThing.Location = new System.Drawing.Point(148, 313);
            this.favoriteThing.Name = "favoriteThing";
            this.favoriteThing.Size = new System.Drawing.Size(172, 33);
            this.favoriteThing.TabIndex = 5;
            this.favoriteThing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // favoriteSongButton
            // 
            this.favoriteSongButton.Location = new System.Drawing.Point(12, 61);
            this.favoriteSongButton.Name = "favoriteSongButton";
            this.favoriteSongButton.Size = new System.Drawing.Size(191, 30);
            this.favoriteSongButton.TabIndex = 6;
            this.favoriteSongButton.Text = "Display my favorite song";
            this.favoriteSongButton.UseVisualStyleBackColor = true;
            this.favoriteSongButton.Click += new System.EventHandler(this.favoriteSongButton_Click);
            // 
            // favoriteMovieButton
            // 
            this.favoriteMovieButton.Location = new System.Drawing.Point(12, 106);
            this.favoriteMovieButton.Name = "favoriteMovieButton";
            this.favoriteMovieButton.Size = new System.Drawing.Size(191, 30);
            this.favoriteMovieButton.TabIndex = 7;
            this.favoriteMovieButton.Text = "Display my favorite movie";
            this.favoriteMovieButton.UseVisualStyleBackColor = true;
            this.favoriteMovieButton.Click += new System.EventHandler(this.favoriteMovieButton_Click);
            // 
            // favoriteDrinkButton
            // 
            this.favoriteDrinkButton.Location = new System.Drawing.Point(12, 150);
            this.favoriteDrinkButton.Name = "favoriteDrinkButton";
            this.favoriteDrinkButton.Size = new System.Drawing.Size(191, 30);
            this.favoriteDrinkButton.TabIndex = 8;
            this.favoriteDrinkButton.Text = "Display my favorite drink";
            this.favoriteDrinkButton.UseVisualStyleBackColor = true;
            this.favoriteDrinkButton.Click += new System.EventHandler(this.favoriteDrinkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(30, 333);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 333);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // videogamePictureBox
            // 
            this.videogamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("videogamePictureBox.Image")));
            this.videogamePictureBox.Location = new System.Drawing.Point(165, 219);
            this.videogamePictureBox.Name = "videogamePictureBox";
            this.videogamePictureBox.Size = new System.Drawing.Size(128, 85);
            this.videogamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videogamePictureBox.TabIndex = 11;
            this.videogamePictureBox.TabStop = false;
            this.videogamePictureBox.Visible = false;
            this.videogamePictureBox.Click += new System.EventHandler(this.videogamePictureBox_Click);
            // 
            // aestheticPictureBox
            // 
            this.aestheticPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aestheticPictureBox.Image")));
            this.aestheticPictureBox.Location = new System.Drawing.Point(165, 219);
            this.aestheticPictureBox.Name = "aestheticPictureBox";
            this.aestheticPictureBox.Size = new System.Drawing.Size(128, 85);
            this.aestheticPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aestheticPictureBox.TabIndex = 12;
            this.aestheticPictureBox.TabStop = false;
            this.aestheticPictureBox.Click += new System.EventHandler(this.aestheticPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 368);
            this.Controls.Add(this.aestheticPictureBox);
            this.Controls.Add(this.videogamePictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.favoriteDrinkButton);
            this.Controls.Add(this.favoriteMovieButton);
            this.Controls.Add(this.favoriteSongButton);
            this.Controls.Add(this.favoriteThing);
            this.Controls.Add(this.favoriteDrink);
            this.Controls.Add(this.favoriteMovie);
            this.Controls.Add(this.favoriteSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Favorite Things";
            ((System.ComponentModel.ISupportInitialize)(this.videogamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label favoriteSong;
        private System.Windows.Forms.Label favoriteMovie;
        private System.Windows.Forms.Label favoriteDrink;
        private System.Windows.Forms.Label favoriteThing;
        private System.Windows.Forms.Button favoriteSongButton;
        private System.Windows.Forms.Button favoriteMovieButton;
        private System.Windows.Forms.Button favoriteDrinkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox videogamePictureBox;
        private System.Windows.Forms.PictureBox aestheticPictureBox;
    }
}

