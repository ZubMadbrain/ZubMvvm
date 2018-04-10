using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZubMvvmc.Controls;

namespace ZubMvvmc.Core
{
    public abstract class Controller
    {
        protected abstract View GetObjectView(Model model);
        protected abstract View GetObjectsView(ObservableCollection<Model> models);
        //protected abstract Page GetObjectPage();
        //protected abstract Page GetObjectsPage();

        // Add
        public virtual Model Add(Model model)
        {
            throw new NotImplementedException();
        }

        // Show
        public virtual void Show(Model model, bool modal = false)
        {
            View objectView = GetObjectView(model);

            if (modal)
            {
                NavigationController.Navigation.PushModalAsync(new Xamarin.Forms.ContentPage() { Content = objectView });
            }
            else
            {
                NavigationController.Navigation.PushAsync(new Xamarin.Forms.ContentPage() { Content = objectView });
            }
        }

        public virtual void Show(ObservableCollection<Model> models, bool modal = false)
        {
            View objectView = GetObjectsView(models);

            if (modal)
            {
                NavigationController.Navigation.PushModalAsync(new Xamarin.Forms.ContentPage() { Content = objectView });
            }
            else
            {
                NavigationController.Navigation.PushAsync(new Xamarin.Forms.ContentPage() { Content = objectView });
            }
        }

        // Update
        public virtual Model Update(Model model)
        {
            throw new NotImplementedException();
        }

        // Delete
        public virtual bool Delete(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
