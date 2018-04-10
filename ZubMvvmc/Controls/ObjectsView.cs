using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ZubMvvmc.Core;

namespace ZubMvvmc.Controls
{
    public class ObjectsView : View
    {
        public static readonly BindableProperty ModelsProperty =
            BindableProperty.Create("Models", typeof(ObservableCollection<Model>), typeof(ObjectsView), null);

        public ObservableCollection<Model> Models
        {
            get { return (ObservableCollection<Model>)GetValue(ModelsProperty); }
            set { SetValue(ModelsProperty, value); }
        }

        public ObjectsView()
        {
            BindingContext = new ObjectsViewModel(new ObservableCollection<Model>() { new Model() });
        }
    }
}
