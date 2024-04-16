using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Test_6
{
        public interface IUserPro
        {
            int ID { get; } // Index of the User, start from 1 to n
            string Name { get; } // User Name
            string Password { get; } // Password
            int? this[int index] { get; set; } // Indexer

        void Display();
    }
}
