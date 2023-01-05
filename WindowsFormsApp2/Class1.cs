using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    class agent : Iagent
    {
        public string die(string file_location)
        {
            return file_location;

        }

        public string shoot(string file_location)
        {
            return file_location;
        }

        public string talk(string file_location)
        {
            return file_location;
        }
    }

    class duelists : Iduelists, Iagent
    {
        public string dash(string file_location)
        {
            return file_location;
        }

        public string die(string file_location)
        {
            return file_location;

        }

        public string shoot(string file_location)
        {
            return file_location;
        }

        public string talk(string file_location)
        {
            return file_location;
        }

    }

    class controllers : Iagent,Icontrollers
    {

        public string die(string file_location)
        {
            return file_location;

        }

        public string flash(string file_location)
        {
            return file_location;
        }

        public string shoot(string file_location)
        {
            return file_location;
        }

        public string talk(string file_location)
        {
            return file_location;
        }

       

    }


}
