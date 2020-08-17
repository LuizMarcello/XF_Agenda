using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XF_Agenda.Model;
using System.Windows.Input;
using Xamarin.Forms;
using XF_Agenda.Services;

namespace XF_Agenda.ViewModels
{
    public class ContatosViewModel
    {
        public ObservableCollection<Contato> Contatos
        {
            get;
            private set;
        }

        List<Contato> listaContatos;

        public string txtNome { get; set; }

        public ICommand ExibirCommand
        {
            get;
            private set;
        }

        public ContatosViewModel()
        {
            Contatos = new ObservableCollection<Contato>();

            ExibirCommand = new Command(() =>
            {
                listaContatos = ContatoService.GetContatos(txtNome);
                Contatos.Clear();
                foreach (var item in listaContatos)
                {
                    Contatos.Add(item);
                }
            });
        }
    }
}

