/* Created by: R
 * Date Created : 17/11/17
 * Last Edit: 17/11/17 16:22
 * Last Edit by: R
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2.Controllers
{
    public class RotaController
    {
        Rota r;

        private List<Rota> m_rotas;

        public List<Rota> Rotas { get { return m_rotas; } }

        MetaLayer ml;

        private static RotaController m_instance;
        public static RotaController Instance()
        {
            if (null == m_instance)
            {
                m_instance = new RotaController();
            }
            return m_instance;
        }

        /// <summary>
        /// Create brand new rota entry
        /// </summary>
        public void AddNewRotaEntry(Rota rota)
        {
            ml.AddRota(rota);
        }

        /// <summary>
        /// Update existing rota information
        /// </summary>
        public void UpdateRota(Rota rota)
        {
            ml.UpdateRota(rota);
        }

        /// <summary>
        /// Get the rota from the metalayer
        /// </summary>
        public void GetRota()
        {
            ml.GetStaffRota();
        }

        /// <summary>
        /// Get a specific rota entry
        /// </summary>
        public void GetRotaEntry(Rota rota)
        {
            ml.GetStaffRotaByID(rota);
        }
    }
}
