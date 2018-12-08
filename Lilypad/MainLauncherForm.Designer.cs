namespace Lilypad
{
    partial class MainLauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLauncherForm));
            this.Jumbotron = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServersButton = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CharacterButton = new System.Windows.Forms.PictureBox();
            this.OptionsButton = new System.Windows.Forms.PictureBox();
            this.FavoritePage = new System.Windows.Forms.TabPage();
            this.ResetFavorites = new System.Windows.Forms.Button();
            this.FavoriteSelected = new System.Windows.Forms.Label();
            this.AddFavorite = new System.Windows.Forms.Button();
            this.RemoveFavorite = new System.Windows.Forms.Button();
            this.EditFavorite = new System.Windows.Forms.Button();
            this.JoinFavorite = new System.Windows.Forms.Button();
            this.FavoriteList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VersionPage = new System.Windows.Forms.TabPage();
            this.HostPage = new System.Windows.Forms.TabPage();
            this.JoinPage = new System.Windows.Forms.TabPage();
            this.FavoriteButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerPortInput = new System.Windows.Forms.NumericUpDown();
            this.ServerIPInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.AboutPage = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Jumbotron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsButton)).BeginInit();
            this.FavoritePage.SuspendLayout();
            this.JoinPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            this.AboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Jumbotron
            // 
            this.Jumbotron.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Jumbotron.BackgroundImage")));
            this.Jumbotron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jumbotron.Location = new System.Drawing.Point(0, 0);
            this.Jumbotron.Name = "Jumbotron";
            this.Jumbotron.Size = new System.Drawing.Size(647, 150);
            this.Jumbotron.TabIndex = 0;
            this.Jumbotron.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 1);
            this.label2.TabIndex = 5;
            // 
            // ServersButton
            // 
            this.ServersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ServersButton.BackgroundImage")));
            this.ServersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ServersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServersButton.Location = new System.Drawing.Point(94, 156);
            this.ServersButton.Name = "ServersButton";
            this.ServersButton.Size = new System.Drawing.Size(150, 41);
            this.ServersButton.TabIndex = 6;
            this.ServersButton.TabStop = false;
            this.ServersButton.Click += new System.EventHandler(this.ServersButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VersionLabel.Location = new System.Drawing.Point(6, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 9);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "Lilypad ";
            // 
            // CharacterButton
            // 
            this.CharacterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterButton.BackgroundImage")));
            this.CharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CharacterButton.Location = new System.Drawing.Point(250, 158);
            this.CharacterButton.Name = "CharacterButton";
            this.CharacterButton.Size = new System.Drawing.Size(150, 41);
            this.CharacterButton.TabIndex = 8;
            this.CharacterButton.TabStop = false;
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionsButton.BackgroundImage")));
            this.OptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsButton.Location = new System.Drawing.Point(406, 158);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(150, 41);
            this.OptionsButton.TabIndex = 9;
            this.OptionsButton.TabStop = false;
            // 
            // FavoritePage
            // 
            this.FavoritePage.Controls.Add(this.ResetFavorites);
            this.FavoritePage.Controls.Add(this.FavoriteSelected);
            this.FavoritePage.Controls.Add(this.AddFavorite);
            this.FavoritePage.Controls.Add(this.RemoveFavorite);
            this.FavoritePage.Controls.Add(this.EditFavorite);
            this.FavoritePage.Controls.Add(this.JoinFavorite);
            this.FavoritePage.Controls.Add(this.FavoriteList);
            this.FavoritePage.Controls.Add(this.label1);
            this.FavoritePage.Location = new System.Drawing.Point(4, 22);
            this.FavoritePage.Name = "FavoritePage";
            this.FavoritePage.Padding = new System.Windows.Forms.Padding(3);
            this.FavoritePage.Size = new System.Drawing.Size(617, 249);
            this.FavoritePage.TabIndex = 3;
            this.FavoritePage.Text = "Favorites";
            this.FavoritePage.UseVisualStyleBackColor = true;
            // 
            // ResetFavorites
            // 
            this.ResetFavorites.Location = new System.Drawing.Point(330, 222);
            this.ResetFavorites.Name = "ResetFavorites";
            this.ResetFavorites.Size = new System.Drawing.Size(75, 23);
            this.ResetFavorites.TabIndex = 7;
            this.ResetFavorites.Text = "Reset";
            this.ResetFavorites.UseVisualStyleBackColor = true;
            // 
            // FavoriteSelected
            // 
            this.FavoriteSelected.AutoSize = true;
            this.FavoriteSelected.Location = new System.Drawing.Point(411, 227);
            this.FavoriteSelected.Name = "FavoriteSelected";
            this.FavoriteSelected.Size = new System.Drawing.Size(133, 13);
            this.FavoriteSelected.TabIndex = 6;
            this.FavoriteSelected.Text = "Currently Selected: NONE ";
            // 
            // AddFavorite
            // 
            this.AddFavorite.Location = new System.Drawing.Point(249, 222);
            this.AddFavorite.Name = "AddFavorite";
            this.AddFavorite.Size = new System.Drawing.Size(75, 23);
            this.AddFavorite.TabIndex = 5;
            this.AddFavorite.Text = "Add";
            this.AddFavorite.UseVisualStyleBackColor = true;
            this.AddFavorite.Click += new System.EventHandler(this.AddFavorite_Click);
            // 
            // RemoveFavorite
            // 
            this.RemoveFavorite.Location = new System.Drawing.Point(168, 222);
            this.RemoveFavorite.Name = "RemoveFavorite";
            this.RemoveFavorite.Size = new System.Drawing.Size(75, 23);
            this.RemoveFavorite.TabIndex = 4;
            this.RemoveFavorite.Text = "Remove";
            this.RemoveFavorite.UseVisualStyleBackColor = true;
            this.RemoveFavorite.Click += new System.EventHandler(this.RemoveFavorite_Click);
            // 
            // EditFavorite
            // 
            this.EditFavorite.Location = new System.Drawing.Point(87, 222);
            this.EditFavorite.Name = "EditFavorite";
            this.EditFavorite.Size = new System.Drawing.Size(75, 23);
            this.EditFavorite.TabIndex = 3;
            this.EditFavorite.Text = "Edit";
            this.EditFavorite.UseVisualStyleBackColor = true;
            this.EditFavorite.Click += new System.EventHandler(this.EditFavorite_Click);
            // 
            // JoinFavorite
            // 
            this.JoinFavorite.Location = new System.Drawing.Point(6, 222);
            this.JoinFavorite.Name = "JoinFavorite";
            this.JoinFavorite.Size = new System.Drawing.Size(75, 23);
            this.JoinFavorite.TabIndex = 2;
            this.JoinFavorite.Text = "Play";
            this.JoinFavorite.UseVisualStyleBackColor = true;
            // 
            // FavoriteList
            // 
            this.FavoriteList.FormattingEnabled = true;
            this.FavoriteList.Location = new System.Drawing.Point(6, 19);
            this.FavoriteList.Name = "FavoriteList";
            this.FavoriteList.Size = new System.Drawing.Size(600, 199);
            this.FavoriteList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here you can put all your favorite servers.";
            // 
            // VersionPage
            // 
            this.VersionPage.Location = new System.Drawing.Point(4, 22);
            this.VersionPage.Name = "VersionPage";
            this.VersionPage.Padding = new System.Windows.Forms.Padding(3);
            this.VersionPage.Size = new System.Drawing.Size(617, 249);
            this.VersionPage.TabIndex = 2;
            this.VersionPage.Text = "Versions";
            this.VersionPage.UseVisualStyleBackColor = true;
            // 
            // HostPage
            // 
            this.HostPage.Location = new System.Drawing.Point(4, 22);
            this.HostPage.Name = "HostPage";
            this.HostPage.Padding = new System.Windows.Forms.Padding(3);
            this.HostPage.Size = new System.Drawing.Size(617, 249);
            this.HostPage.TabIndex = 1;
            this.HostPage.Text = "Host";
            this.HostPage.UseVisualStyleBackColor = true;
            // 
            // JoinPage
            // 
            this.JoinPage.BackColor = System.Drawing.Color.Transparent;
            this.JoinPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JoinPage.BackgroundImage")));
            this.JoinPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JoinPage.Controls.Add(this.FavoriteButton);
            this.JoinPage.Controls.Add(this.panel1);
            this.JoinPage.Controls.Add(this.PlayButton);
            this.JoinPage.Location = new System.Drawing.Point(4, 22);
            this.JoinPage.Name = "JoinPage";
            this.JoinPage.Padding = new System.Windows.Forms.Padding(3);
            this.JoinPage.Size = new System.Drawing.Size(617, 249);
            this.JoinPage.TabIndex = 0;
            this.JoinPage.Text = "Play";
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FavoriteButton.BackgroundImage")));
            this.FavoriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavoriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoriteButton.Location = new System.Drawing.Point(198, 202);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(197, 30);
            this.FavoriteButton.TabIndex = 10;
            this.FavoriteButton.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ServerPortInput);
            this.panel1.Controls.Add(this.ServerIPInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(165, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 74);
            this.panel1.TabIndex = 9;
            // 
            // ServerPortInput
            // 
            this.ServerPortInput.Location = new System.Drawing.Point(79, 41);
            this.ServerPortInput.Name = "ServerPortInput";
            this.ServerPortInput.Size = new System.Drawing.Size(170, 20);
            this.ServerPortInput.TabIndex = 3;
            // 
            // ServerIPInput
            // 
            this.ServerIPInput.Location = new System.Drawing.Point(79, 12);
            this.ServerIPInput.Name = "ServerIPInput";
            this.ServerIPInput.Size = new System.Drawing.Size(170, 20);
            this.ServerIPInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Server Port";
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Location = new System.Drawing.Point(198, 137);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(197, 59);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.TabStop = false;
            // 
            // AboutPage
            // 
            this.AboutPage.Controls.Add(this.JoinPage);
            this.AboutPage.Controls.Add(this.HostPage);
            this.AboutPage.Controls.Add(this.VersionPage);
            this.AboutPage.Controls.Add(this.FavoritePage);
            this.AboutPage.Location = new System.Drawing.Point(12, 221);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.SelectedIndex = 0;
            this.AboutPage.Size = new System.Drawing.Size(625, 275);
            this.AboutPage.TabIndex = 1;
            // 
            // MainLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 510);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.CharacterButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ServersButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AboutPage);
            this.Controls.Add(this.Jumbotron);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lilypad";
            ((System.ComponentModel.ISupportInitialize)(this.Jumbotron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsButton)).EndInit();
            this.FavoritePage.ResumeLayout(false);
            this.FavoritePage.PerformLayout();
            this.JoinPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            this.AboutPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Jumbotron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ServersButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.PictureBox CharacterButton;
        private System.Windows.Forms.PictureBox OptionsButton;
        private System.Windows.Forms.TabPage FavoritePage;
        private System.Windows.Forms.Button ResetFavorites;
        private System.Windows.Forms.Label FavoriteSelected;
        private System.Windows.Forms.Button AddFavorite;
        private System.Windows.Forms.Button RemoveFavorite;
        private System.Windows.Forms.Button EditFavorite;
        private System.Windows.Forms.Button JoinFavorite;
        private System.Windows.Forms.ListBox FavoriteList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage VersionPage;
        private System.Windows.Forms.TabPage HostPage;
        private System.Windows.Forms.TabPage JoinPage;
        private System.Windows.Forms.TextBox ServerIPInput;
        private System.Windows.Forms.TabControl AboutPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown ServerPortInput;
        private System.Windows.Forms.PictureBox FavoriteButton;
    }
}

