using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvmc.Controls;

namespace ZubMvvmc.Core
{
    public class ObjectViewModel : ViewModel
    {
        private Model _model;
        public Model Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged(nameof(Model)); }
        }

        public ObjectViewModel(Model model)
        {
            Model = model;
        }
    }
}
