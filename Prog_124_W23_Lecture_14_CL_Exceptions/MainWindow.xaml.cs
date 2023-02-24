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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyLibrary;

namespace Prog_124_W23_Lecture_14_CL_Exceptions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> numbers = new List<int> {1 ,34, 76,3,43 , 2,5,34,65456};

        public MainWindow()
        {
            InitializeComponent();
            // Class Libraries
            // Exceptions
            // Deconstructors

            Team seahawks = new Team("Seahawks");

            seahawks = null;

        }

        public void Example()
        {
            try
            {
                "a".RollTheDie().ToString();
            }
            catch (DiceRollException dre)
            {
                MessageBox.Show(dre.Message, "What is this");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This was a regular exception " + ex.StackTrace);
            }
        }
    }
}
