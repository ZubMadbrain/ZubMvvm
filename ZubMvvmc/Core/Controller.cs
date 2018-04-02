using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvmc.Controls;

namespace ZubMvvmc.Core
{
    public abstract class Controller
    {
        public abstract View GetObjectView();
        public abstract View GetObjectsView();

        // Add
        public virtual void Add(Model model)
        {

        }

        // Show
        public virtual void Show(Model model)
        {

        }

        // Update
        public virtual void Update(Model model)
        {

        }

        // Delete
        public virtual void Delete(Model model)
        {

        }
    }
}
