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

namespace EsercitazioneGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Brano> brani;
        Cd cd;
        public MainWindow()
        {
            InitializeComponent();
            Brano b = new Brano("WAKA WAKA", "SHAKIRA", 240);
            Brano b1 = new Brano("LEGGINS DI PELLE", "BELLO FIGO", 180);
            Brano b2 = new Brano("CAN'T SAY", "TRAVIS SCOTT", 200);
            //
            brani = new List<Brano>();

            brani.Add(b);
            brani.Add(b1);
            brani.Add(b2);
            cd = new Cd("ESOTICO", "DJ FUSCO", brani);

            txt_DurataVerifica.Visibility = Visibility.Hidden;
            lbl_Frase.Visibility = Visibility.Hidden;
            btn_Conferma.Visibility = Visibility.Hidden;
            lbl_Risposta.Visibility = Visibility.Hidden;
            PopulaLista();
        }

        private void PopulaLista()
        {
            lst_Cd.Items.Clear();
            foreach(Brano b in brani)
            {
                lst_Cd.Items.Add(b);
            }
        }
        private void lst_Cd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_Aggiungi.IsEnabled = false;
            Brano b = lst_Cd.SelectedItem as Brano;
            txt_Autore.Text = b.Autore;
            txt_Durata.Text = Convert.ToString(b.Durata);
            txt_Titolo.Text = b.Titolo;
        }

        private void btn_Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txt_Titolo.Text;
            string autore = txt_Autore.Text;
            int durata = int.Parse(txt_Durata.Text);
            Brano b = new Brano(titolo, autore, durata);
            brani.Add(b);
        }

        private void btn_Modifca_Click(object sender, RoutedEventArgs e)
        {
            Brano b = lst_Cd.SelectedItem as Brano;
            foreach(Brano brano in brani)
            {
                if(b == brano)
                {
                    b.Titolo = txt_Titolo.Text;
                    b.Autore = txt_Autore.Text;
                    b.Durata = int.Parse(txt_Durata.Text);
                }
            }
        }

        private void btn_Elimina_Click(object sender, RoutedEventArgs e)
        {
            Brano b = lst_Cd.SelectedItem as Brano;
            brani.Remove(b);
        }

        private void btn_ShortSong_Click(object sender, RoutedEventArgs e)
        {
            txt_DurataVerifica.Visibility = Visibility.Visible;
            lbl_Frase.Visibility = Visibility.Visible;
            btn_Conferma.Visibility = Visibility.Visible;
        }

        private void btn_Conferma_Click(object sender, RoutedEventArgs e)
        {
            lbl_Risposta.Visibility = Visibility.Visible;
            Brano b = lst_Cd.SelectedItem as Brano;
            int durataDaSuperare = int.Parse(txt_DurataVerifica.Text);
            bool supera = b.ShortSong(durataDaSuperare, b);
            if (supera == false)
                lbl_Risposta.Content = lbl_Risposta.Content +" NON LO SUPERA";
            else
                lbl_Risposta.Content = lbl_Risposta.Content + " LO SUPERA";

        }


    }
}
