using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using DevExpressAPI.DataSource;
using System;

namespace DevExpressAPI.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<Costume> Costumes
        {
            get => GetValue<ObservableCollection<Costume>>();
            private set => SetValue(value);
        }

        public ObservableCollection<Maker> Makers
        {
            get => GetValue<ObservableCollection<Maker>>();
            private set => SetValue(value);
        }

        private DelegateCommand addCommand;
        public DelegateCommand AddComand
        {
            get
            {
                return addCommand ??
                    (addCommand = new DelegateCommand(() =>
                    {
                        Costume costume = new Costume();
                        Costumes.Add(costume);
                    }));
            }
        }
        public ViewModel()
        {
            Makers = new ObservableCollection<Maker>
            {
                new Maker("Coco Chanel"),
                new Maker("Karl Lagerfeld"),
                new Maker("Elsa Schiaparelli"),
                new Maker("Chritian Dore"),
                new Maker("Giorgio Armani")
            };

            Costumes = new ObservableCollection<Costume>
            {
                new Costume("Custom name", true, 30, "Coco Chanel"),
                new Costume("Custom name #2", false, 40, "Coco Chanel")
            };
        }
    }
}