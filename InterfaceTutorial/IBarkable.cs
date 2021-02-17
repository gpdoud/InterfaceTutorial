using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial {
    
    interface IBarkable {

        string Bark();
        string GetName();
        void SetName(string name);
    }
}
