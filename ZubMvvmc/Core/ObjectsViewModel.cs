using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZubMvvmc.Controls;

namespace ZubMvvmc.Core
{
    public class ObjectsViewModel : View
    {
        private ObservableCollection<Model> _models;
        public ObservableCollection<Model> Models
        {
            get { return _models; }
            set { _models = value; OnPropertyChanged(nameof(Models)); }
        }

        public ObjectsViewModel(ObservableCollection<Model> models)
        {
            Models = models;
        }
    }
}
