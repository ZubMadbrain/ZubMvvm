using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZubMvvmc.Core;

namespace ZubMvvmc.Controls
{
    public class ObjectView : View
    {
        public static readonly BindableProperty ModelProperty =
            BindableProperty.Create("Models", typeof(Model), typeof(ObjectsView), null);

        public Model Model
        {
            get { return (Model)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        public ObjectView()
        {
            BindingContext = new ObjectViewModel(new Model());
        }
    }
}
