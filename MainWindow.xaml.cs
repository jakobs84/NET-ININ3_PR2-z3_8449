using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace NET_ININ3_PR2_Z3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<Filmy>();

            InitializeComponent();
        }

        private ObservableCollection<Filmy> entries;

        public ObservableCollection<Filmy> Entries
        {
            get { return entries; }
            set { entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Entries.Add(txtEnter.Text);
            Entries.Add(new Filmy());

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
  ///          Entries.Remove(new Filmy());
   //         string selectedItem = (string)lvEntries.SelectedItem;
  //          Entries.Remove(selectedItem);
            Filmy selectedItem = (Filmy)lvEntries.SelectedItem;
            Entries.Remove(selectedItem);
        }
    }

    public class Filmy
    {
        public Filmy()
        {
            title = "";
            director = "";
            studio = "";
            medium = "";
            releaseDate = DateTime.Parse("12.12.2000");
        }

        public string title { get; set; } 
        public string director { get; set; }
        public string studio { get; set; }
        public string medium { get; set; }
        public DateTime releaseDate { get; set; }
    }
}
