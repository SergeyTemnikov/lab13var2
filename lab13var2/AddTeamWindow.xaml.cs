using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;

namespace lab13var2
{
    /// <summary>
    /// Логика взаимодействия для AddTeamWindow.xaml
    /// </summary>
    public partial class AddTeamWindow : Window
    {

        FootballEntities db;
        byte[] image;

        public AddTeamWindow(FootballEntities db)
        {
            InitializeComponent();
            this.db=db;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txbName.Text.Length == 0 ||
                txbPlayersCount.Text.Length == 0 ||
                txbAddress.Text.Length == 0 ||
                image == null)
            {
                MessageBox.Show("Не все данные введены!");
            }
            string name = txbName.Text;
            bool flag = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (!(Char.IsDigit(name[i]) || name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z'))
                {
                    flag = false;
                    MessageBox.Show("Введены недопустимые символы!");
                    return;
                }             
            }

            int number = 0;
            try
            {
                number = int.Parse(txbPlayersCount.Text);
                if(number < 20)
                {
                    MessageBox.Show("Количество игроков не может быть меньше 20!");
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Количество игроков введено неправильно!");
                return;
            }

            Team team = new Team();

            team.Name = txbName.Text;
            team.PlayersCount = number;
            team.Address = txbAddress.Text;
            team.Logo = image;

            try
            {
                db.Team.Add(team);
                db.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось записать игрока");
            }

        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                image = File.ReadAllBytes(openFile.FileName);
                imgTeam.Source = new ImageSourceConverter().ConvertFrom(openFile.FileName) as ImageSource;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
