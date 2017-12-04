using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2.UserInterface
{
    class RotaFormBackEnd
    {
        private MetaLayer ml = MetaLayer.Instance();
        public List<Rota> LoadRota()
        {
            return ml.GetStaffRota();
        }
    }
}
