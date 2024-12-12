using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Examen_MVVM.Models;
using System.Windows.Input;

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

        public decimal Descuento
        {
            get => _descuento;
            set => SetProperty(ref _descuento, value);
        }

        public decimal Total
        {
            get => _total;
            set => SetProperty(ref _total, value);
        }

        public ICommand CalcularCommand { get; }
        public ICommand LimpiarCommand { get; }

        public MainPageViewModel()
        {
            CalcularCommand = new RelayCommand(Calcular);
            LimpiarCommand = new RelayCommand(Limpiar);
        }

        private void Calcular()
        {
            try
            {
                var subtotal = Producto1 + Producto2 + Producto3;
                var descuento = CalcularDescuento(subtotal);
                var total = subtotal - descuento;

                Subtotal = subtotal;
                Descuento = descuento;
                Total = total;
            }
            catch (Exception ex)
            {
            }
        }

        private decimal CalcularDescuento(decimal subtotal)
        {
            if (subtotal >= 1000 && subtotal <= 4999.99m)
                return subtotal * 0.10m;
            else if (subtotal >= 5000 && subtotal <= 9999.99m)
                return subtotal * 0.20m;
            else if (subtotal >= 10000)
                return subtotal * 0.30m;
            else
                return 0;
        }

        private void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}