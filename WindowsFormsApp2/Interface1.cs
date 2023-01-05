using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{ 
    interface Iagent 
    {
        string shoot(string file_location);
        string talk(string file_location);
        string die(string file_location);

    }

    interface Iduelists
    {
        string dash(string file_location);
    }
    interface Icontrollers
    {
        string flash(string file_location);


    }
    interface Isup
    {
        string heal(string file_location);
    }



}
