using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class BusinessLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public bool AyakkabiEkle(Ayakkabi ayk)
        {
            try
            {
                if (ayk == null)
                {
                    throw new NullReferenceException("Öğrenci referansı null geldi");
                }
                SqlParameter[] p = { new SqlParameter("@Marka", ayk.Marka), new SqlParameter("@Model", ayk.Model), new SqlParameter("@Numara", ayk.Numara) };

                dal = new DataAccessLayer();
                return dal.ExecuteNonQuery("Insert into tblAyakkabiStok values(@Marka,@Model,@Numara)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable AyakkabiTablosu(string cmdtext, SqlParameter[] p = null)
        {
            return dal.MyDataTable(cmdtext, p);
        }
    }
}
