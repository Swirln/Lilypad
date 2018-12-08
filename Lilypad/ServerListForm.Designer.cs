namespace Lilypad
{
    partial class ServerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerListForm));
            this.ServerList = new System.Windows.Forms.ListBox();
            this.JoinServer = new System.Windows.Forms.PictureBox();
            this.FavoriteServer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.JoinServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteServer)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Location = new System.Drawing.Point(12, 12);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(228, 381);
            this.ServerList.TabIndex = 0;
            // 
            // JoinServer
            // 
            this.JoinServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JoinServer.BackgroundImage")));
            this.JoinServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JoinServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinServer.Location = new System.Drawing.Point(246, 12);
            this.JoinServer.Name = "JoinServer";
            this.JoinServer.Size = new System.Drawing.Size(149, 43);
            this.JoinServer.TabIndex = 1;
            this.JoinServer.TabStop = false;
            // 
            // FavoriteServer
            // 
            this.FavoriteServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FavoriteServer.BackgroundImage")));
            this.FavoriteServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavoriteServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoriteServer.Location = new System.Drawing.Point(246, 61);
            this.FavoriteServer.Name = "FavoriteServer";
            this.FavoriteServer.Size = new System.Drawing.Size(149, 23);
            this.FavoriteServer.TabIndex = 2;
            this.FavoriteServer.TabStop = false;
            // 
            // ServerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 410);
            this.Controls.Add(this.FavoriteServer);
            this.Controls.Add(this.JoinServer);
            this.Controls.Add(this.ServerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Master Server";
            ((System.ComponentModel.ISupportInitialize)(this.JoinServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ServerList;
        private System.Windows.Forms.PictureBox JoinServer;
        private System.Windows.Forms.PictureBox FavoriteServer;
    }
}