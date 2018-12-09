using Lilypad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lilypad
{
    public partial class MainLauncherForm : Form
    {
        public MainLauncherForm()
        {
            InitializeComponent();
            VersionLabel.Parent = Jumbotron;
            VersionLabel.Text += BuildInfo.Version + " r" + BuildInfo.Revision + "\nby Carrot";
        }

        #region Game

        #endregion
        #region Buttons

        private void ServersButton_Click(object sender, EventArgs e)
        {
            Form Servers = new ServerListForm();
            Servers.Show();
        }

        private void AddFavorite_Click(object sender, EventArgs e)
        {
            Form AddFavorite = new AddFavoriteForm();
            AddFavorite.Show();
        }


        private void EditFavorite_Click(object sender, EventArgs e)
        {
            if (FavoriteList.SelectedIndex == -1)
            {
                MessageBox.Show("You don't have a favorite selected!", "Lilypad");
                return;
            }

            // TODO
        }

        private void RemoveFavorite_Click(object sender, EventArgs e)
        {
            if (FavoriteList.SelectedIndex == -1)
            {
                MessageBox.Show("You don't have a favorite selected!", "Lilypad");
                return;
            }

        }

        // For some reason, the process doesn't close when the form closes.
        // Actually I think I know the reason but whatever xd
        private void MainLauncherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
