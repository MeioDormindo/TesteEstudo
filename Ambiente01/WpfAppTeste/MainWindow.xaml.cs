using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;


namespace WpfAppTeste
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnSortear_Click(object sender, RoutedEventArgs e)
        {
            int inicio;
            int fim;

            int.TryParse(txtInicio.Text, out inicio);
            int.TryParse(txtFim.Text, out fim);



            if (inicio > 0 && fim > 0)
            {
                if (inicio < fim)
                {
                    Random gerador = new Random();
                    int num = gerador.Next(inicio, fim + 1);

                    lblSorteio.Content = $"Sorteando entre {inicio} e {fim}...";
                    lblSorteio.Visibility = Visibility.Visible;
                    await Task.Delay(3000);
                    lblSorteio.Content = $"O Número do sorteio é {num}!!!!";
                }
                else if (fim < inicio)
                {
                    lblSorteio.Content = $"Sorteando entre {inicio} e {fim}...";
                    lblSorteio.Visibility = Visibility.Visible;
                    await Task.Delay(3000);
                    lblSorteio.Content = $"Voce digitou {fim} no fim e ele é maior que {inicio} que está no inicio";
                }

                else if (inicio == fim)
                {
                    lblSorteio.Content = $"Sorteando entre {inicio} e {fim}...";
                    lblSorteio.Visibility = Visibility.Visible;
                    await Task.Delay(3000);
                    lblSorteio.Content = $"Voce digitou {inicio} nos dois campos e eles precisam ser diferentes";
                    
                }
            }
            else
            {
                if(inicio == 0 && fim > 0)
                {
                    lblSorteio.Content = $"Sorteando entre {inicio} e {fim}...";
                    lblSorteio.Visibility = Visibility.Visible;
                    await Task.Delay(3000);
                    lblSorteio.Content = $"Voce digitou {txtInicio.Text} no inicio e este valor possuir caracteres ou valor zero";
                   
                }else if(inicio > 0 && fim == 0)
                {
                    lblSorteio.Content = $"Sorteando entre {inicio} e {fim}...";
                    lblSorteio.Visibility = Visibility.Visible;
                    await Task.Delay(3000);
                    lblSorteio.Content = $"Voce digitou {txtFim.Text} no fim e este valor possuir caracteres ou valor zerado";
                    
                }
                else if (inicio == 0 && fim == 0)
                {
                    lblSorteio.Content = $"Sorteando entre {inicio} e {fim}...";
                    lblSorteio.Visibility = Visibility.Visible;
                    await Task.Delay(3000);
                    lblSorteio.Content = $"Voce digitou {txtInicio.Text} no inicio e {txtFim.Text} no fim e estes valores possuem caracteres ou estao zerados";
                   
                }
            }

        }
    }
}

