using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PlayerStats.xaml
    /// </summary>
    public partial class PlayerStats : Window
    {
        public PlayerStats(Podatkovni_sloj.Modals.Player player, ImageSource source,Matches match)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FileManager.ApplicationLanguage);
            InitializeComponent();
            SetStats(player,source,match);
        }

        private void SetStats(Podatkovni_sloj.Modals.Player player,ImageSource source,Matches match)
        {
            pImage.Source = source;
            pName.Content = player.Name;
            pNumber.Content = $"{Properties.Resources.pNumber}{player.Shirt_Number}";
            pPosition.Content = player.Position;
            pRole.Content = $"{Properties.Resources.pCaptain}{((player.Captain == true) ? Properties.Resources .pYes: Properties.Resources.pNo)}";


            int yellowCardsCount = 0;
            int goalsScoredCount = 0;
            foreach (var other in match.Home_Team_Statistics.Starting_Eleven)
            {
                if (other.Name == player.Name)
                {
                    foreach (var evt in match.Home_Team_Events)
                    {
                        if (evt.Type_Of_Event == "yellow-card" && evt.Player == player.Name)
                        {
                            yellowCardsCount++;
                        }
                        if (evt.Type_Of_Event == "goal-penalty"  && evt.Player == player.Name ||
                            evt.Type_Of_Event == "goal-own" && evt.Player == player.Name || 
                            evt.Type_Of_Event=="goal" && evt.Player == player.Name)
                        {
                            goalsScoredCount++;
                        }
                    }
                }
            }
            foreach (var other in match.Away_Team_Statistics.Starting_Eleven)
            {
                if (other.Name == player.Name)
                {
                    foreach (var evt in match.Away_Team_Events)
                    {
                        if (evt.Type_Of_Event == "yellow-card" && evt.Player == player.Name)
                        {
                            yellowCardsCount++;
                        }
                        if (evt.Type_Of_Event == "goal-penalty" && evt.Player == player.Name ||
                            evt.Type_Of_Event == "goal-own" && evt.Player == player.Name ||
                            evt.Type_Of_Event == "goal" && evt.Player == player.Name)
                        {
                            goalsScoredCount++;
                        }
                    }
                }
            }

            pGoalsScored.Content = $"{Properties.Resources.pGoals}{goalsScoredCount}";
            pYellowCards.Content = $"{Properties.Resources.pCards}{yellowCardsCount}";
        }
    }
}
