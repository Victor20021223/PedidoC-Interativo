using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UMFG.Venda.Aprensetacao.Classes;
using UMFG.Venda.Aprensetacao.Interfaces;

namespace UMFG.Venda.Aprensetacao.ViewModels
{
    internal sealed class ListarProdutosViewModel : AbstractViewModel
    {
        public ListarProdutosViewModel(UserControl userControl, IObserver observer)
            :base("Lista de Produtos")
        {
            UserControl = userControl;
            MainUserControl = observer;

            Add(observer);
        }
    }
}
