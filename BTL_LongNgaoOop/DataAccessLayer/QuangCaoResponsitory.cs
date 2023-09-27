using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class QuangCaoResponsitory:IQuangCaoResponsitory
    {
        public IDatabaseHelper _dbHelper;
        public QuangCaoResponsitory(IDatabaseHelper DataBaseHelper)
        {
            _dbHelper = DataBaseHelper;
        }
        public List<QuangCaoModel>GetallQuangCao()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_quangcao");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<QuangCaoModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
