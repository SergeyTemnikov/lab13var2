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

namespace lab13var2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        FootballEntities db = new FootballEntities();

        public MainWindow()
        {
            InitializeComponent();

            dgTeams.ItemsSource = db.Team.ToList();
        }

        private void btnAddComand_Click(object sender, RoutedEventArgs e)
        {
            AddTeamWindow window = new AddTeamWindow(db);
            window.ShowDialog();
            dgTeams.ItemsSource = null;
            dgTeams.ItemsSource = db.Team.ToList();
        }

        private void btnSeePlayers_Click(object sender, RoutedEventArgs e)
        {
            var team = dgTeams.SelectedValue as Team;
            if(team == null) 
            {
                MessageBox.Show("Выберите команду!");
                return;
            }
            TeamPlayersWindow window = new TeamPlayersWindow(db, team);
            window.ShowDialog();
        }
    }
}
