using System.Collections.Generic;
using ServiceInterfaces;

namespace WpfNetCore.ViewModel {

    public class MainWindowViewModel {        

        public MainWindowViewModel(IEnumerable<IAddInStartup> addins) {
            this.Addins = addins;
        }

        public IEnumerable<IAddInStartup> Addins {get;}
    }
}