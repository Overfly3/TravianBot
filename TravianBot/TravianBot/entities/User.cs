using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravianBot.entities
{
    class User
    {
        public List<Village> Villages
        {
            get
            {
                return getAllVillages();
            }
        }

        private List<Village> getAllVillages()
        {
            throw new NotImplementedException();
        }
    }
}
