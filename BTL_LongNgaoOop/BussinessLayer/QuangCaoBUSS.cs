using BussinessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public partial class QuangCaoBUSS : IQuangCaoBUSS
    {
        public IQuangCaoResponsitory QC_Responsitory;

        public QuangCaoBUSS(IQuangCaoResponsitory quangCaoResponsitory )
        {
             QC_Responsitory= quangCaoResponsitory;
        }
        public List<QuangCaoModel> GetallQuangCao()
        {
            return QC_Responsitory.GetallQuangCao();
        }
    }

}
