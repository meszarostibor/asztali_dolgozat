using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static List<Cellovo> cellovok = new List<Cellovo>();
        public MainWindow()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("lovesek.csv");
            while (!sr.EndOfStream)
            {
                cellovok.Add(new Cellovo(sr.ReadLine()));
            }
            sr.Close();

            dataGrid1.ItemsSource = cellovok;
            dataGrid1.Items.Refresh();  

        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            bool error = false;

            try {
                if (tbxNev.Text == "")
                {
                    error = true;
                    MessageBox.Show("A név mező nem lehet üres!");
                }

                if (int.Parse(tbxLoves1.Text) < 0 || int.Parse(tbxLoves1.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("Az eredménynek 0 és 99 közé kell esnie!");
                }

                if (int.Parse(tbxLoves2.Text) < 0 || int.Parse(tbxLoves2.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("Az eredménynek 0 és 99 közé kell esnie!");
                }
                if (int.Parse(tbxLoves3.Text) < 0 || int.Parse(tbxLoves3.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("Az eredménynek 0 és 99 közé kell esnie!");
                }
                if (int.Parse(tbxLoves4.Text) < 0 || int.Parse(tbxLoves4.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("Az eredménynek 0 és 99 közé kell esnie!");
                }

            }
            catch { 
                error = true;  
                MessageBox.Show("Hibás adatbevitel!");
            }



            if (error == false)
            {
                cellovok.Add(new Cellovo($"{tbxNev.Text};{tbxLoves1.Text};{tbxLoves2.Text};{tbxLoves3.Text};{tbxLoves4.Text}"));
            }


            dataGrid1.Items.Refresh();








        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            try {
                StreamWriter sw = new StreamWriter("lovesek2.csv");
                foreach (var item in dataGrid1.Items)
                {
                    sw.WriteLine(item.ToString());
                }

                sw.Close();
                MessageBox.Show("A mentés sikeresen megtörtént!");
            }
            catch(Exception ex) {            
                MessageBox.Show(ex.Message);
            }





        }
    }
}