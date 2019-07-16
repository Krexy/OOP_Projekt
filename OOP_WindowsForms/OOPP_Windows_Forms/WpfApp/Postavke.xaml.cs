using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Postavke.xaml
    /// </summary>
    public partial class Postavke : Window
    {

        public Postavke()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FileManager.ApplicationLanguage);
            InitializeComponent();
            SetComponentLanguage();
        }

        private void SetComponentLanguage()
        {
            Hrvatski.Content = Properties.Resources.pHL;
            Engleski.Content = Properties.Resources.pEL;
            lblNaslov.Content = Properties.Resources.pTitle;
            chbFull.Content = Properties.Resources.pScreen;
            lblWidth.Content = Properties.Resources.pWidth;
            lblHeight.Content = Properties.Resources.pHeight;
        }

        private void BtnLanguage_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(Properties.Resources.wMsg, Properties.Resources.wTitle, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                if (!File.Exists(FileManager.SETTINGS_PATH))
                {
                    using (File.Create(FileManager.SETTINGS_PATH)) { }
                }
                var btn = sender as Button;

                if (chbFull.IsChecked == true)
                {
                    FileManager.SaveLanguage(btn.Name, -1, -1);
                    OpenMainWindow();
                }
                else
                {
                    FileManager.SaveLanguage(btn.Name, (int)sliderWidth.Value, (int)sliderHeight.Value);
                    OpenMainWindow();
                }
            }
        }

        private void OpenMainWindow()
        {
            var temp = new MainWindow();
            temp.Show();
            this.Close();
        }

        private void ChbFull_Checked(object sender, RoutedEventArgs e)
        {
            ChangeWindowSizeState(false);
        }

        private void ChangeWindowSizeState(bool state)
        {
            gSize.IsEnabled = state;
            sliderWidth.IsEnabled = state;
            sliderHeight.IsEnabled = state;
            sliderHeight.Opacity = state ? 1 : 0;
            sliderWidth.Opacity = state ? 1 : 0;
        }

        private void ChbFull_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeWindowSizeState(true);
        }

    }
}
