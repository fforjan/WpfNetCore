using System;
using System.Collections.Generic;
using ServiceInterfaces;

namespace WpfNetCore.ViewModel {

    public class MainWindowViewModel {        

        public MainWindowViewModel(IEnumerable<IAddInStartup> addins, IServiceProvider serviceProvider) {
            this.Addins = addins;
            this.ServiceProvider = serviceProvider;
        }

        public IEnumerable<IAddInStartup> Addins {get;}

        public IServiceProvider ServiceProvider {get;}
    }
}