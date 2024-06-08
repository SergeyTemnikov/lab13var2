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

namespace lab13var2
{
    /// <summary>
    /// Логика взаимодействия для TeamPlayersWindow.xaml
    /// </summary>
    public partial class TeamPlayersWindow : Window
    {
        FootballEntities db;
        Team team;

        public TeamPlayersWindow(FootballEntities db, Team team)
        {
            InitializeComponent();
            this.db=db;
            this.team=team;

            var teamPlayers = db.Player.Where(x => x.IdTeam == team.Id).ToList();
            dgPlayers.ItemsSource = teamPlayers;

            txtName.Text += team.Name;
            txtPlayersCount.Text += teamPlayers.Count();
        }
    }
}
