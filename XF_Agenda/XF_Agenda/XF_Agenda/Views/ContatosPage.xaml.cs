using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_Agenda.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContatosPage : ContentPage
    {
        public ContatosPage()
        {
            InitializeComponent();
        }

        private void On_Click(object sender, EventArgs e)
        {
            lvwContatos.ItemsSource = ContatoService.GetContatos(txtNome.Text);
        }
    }
}