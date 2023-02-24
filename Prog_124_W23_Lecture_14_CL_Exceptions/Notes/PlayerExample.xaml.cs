using MyLibraryExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_14_CL_Exceptions.Notes
{
    /// <summary>
    /// Interaction logic for PlayerExample.xaml
    /// </summary>
    public partial class PlayerExample : Window
    {
        Player player = null;

        public PlayerExample()
        {
            InitializeComponent();


            try
            {
                new Player("", "");
            }
            catch
            {
                MessageBox.Show("An Error Happened");
            }
        }

        private void btnMakePlayer_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string name = txtName.Text;
                string number = txtNumber.Text;

                player = new Player(name, number);
            }
            catch(PlayerException pe)
            {
                runDisplay.Text = pe.Message;
            }

            DisplayPlayer(player);

        } // btnMakePlayer_Click

        private void btnDisposeOfPlayer_Click(object sender, RoutedEventArgs e)
        {
            if(player != null)
            {
                player = null;
            }
            else
            {
                MessageBox.Show("There is not player");
            }
        }

        private void DisplayPlayer(Player player)
        {
            if(player == null)
            {
                runDisplay.Text = "Player is null";
            }
            else
            {
                runDisplay.Text = player.ToString();
            }
        } 
    }
}
