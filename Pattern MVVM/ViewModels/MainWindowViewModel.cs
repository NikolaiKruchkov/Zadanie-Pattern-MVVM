using Pattern_MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pattern_MVVM.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }
        private double dlina;
        public double Dlina
        {
            get => dlina;
            set
            {
                dlina = value;
                OnPropertyChanged();
            }
        }
        private double ploshad;
        public double Ploshad
        {
            get => ploshad;
            set
            {
                ploshad = value;
                OnPropertyChanged();
            }
        }
        public ICommand PoschitaemDlinu { get; }
        private void OnPoschitaemDlinuExecute(object p)
        {
            Dlina = Okr.RaschetDlina(Radius);
            
        }
        private bool CanPoschitaemDlinuIPloshadExecuted(object p)
        {
            if (Radius != 0)
                return true;
            else
                return false;
        }
        public ICommand PoschitaemPloshad { get; }
        private void OnPoschitaemPloshadExecute(object p)
        {
            
            Ploshad = Okr.RaschetPloshad(Radius);
        }
        
        public MainWindowViewModel()
        {
            PoschitaemDlinu = new RelayCommand(OnPoschitaemDlinuExecute, CanPoschitaemDlinuIPloshadExecuted);
            PoschitaemPloshad = new RelayCommand(OnPoschitaemPloshadExecute, CanPoschitaemDlinuIPloshadExecuted);
        }
    }
}
