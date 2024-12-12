using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Examen_MVVM.Models;

namespace Examen_MVVM.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private decimal _producto1;
        private decimal _producto2;
        private decimal _producto3;
        private decimal _subtotal;
        private decimal _descuento;
        private decimal _total;

        private decimal Producto1
        {
            get => _producto1;
            set => SetProperty(ref _producto1, value);
        }

        public decimal Producto2
        {
            get => _producto2;
            set => SetProperty(ref _producto2, value);
        }

        public decimal Producto3
        {
            get => _producto3;
            set => SetProperty(ref _producto3, value);
        }

        public decimal Subtotal
        {
            get => _subtotal;
            set => SetProperty(ref _subtotal, value);
        }
    }
}