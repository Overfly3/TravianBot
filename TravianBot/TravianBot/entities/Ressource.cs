using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravianBot.entities
{
    class Ressource
    {
        public RessourcesEnum ressourceType;
        public int ressourceWeight;

        public Ressource(RessourcesEnum ressourceType, int ressourceWeight)
        {
            this.ressourceType = ressourceType;
            this.ressourceWeight = ressourceWeight;
        }
    }
}
