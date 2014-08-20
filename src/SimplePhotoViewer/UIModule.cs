﻿using Caliburn.Micro;
using Ninject.Modules;
using SimplePhotoViewer.UI;
using SimplePhotoViewer.UI.ViewModels;

namespace SimplePhotoViewer
{
    public class UIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWindowManager>().To<WindowManager>();
            Bind<IWindowStateHelper>().To<WindowStateHelper>();
            Bind<IShellViewModel>().To<ShellViewModel>();
            Bind<IImageViewModel>().To<ImageViewModel>();
        }
    }
}