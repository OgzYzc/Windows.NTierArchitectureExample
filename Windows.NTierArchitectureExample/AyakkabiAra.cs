using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.NTierArchitectureExample
{
    public partial class AyakkabiAra : Form
    {
        public AyakkabiAra()
        {
            InitializeComponent();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=.;Integrated Security=TRUE;Initial Catalog=OkulDB"))
            {
                using (SqlCommand cmd = new SqlCommand("Select StokID,Marka,Model,Numara from tblAyakkabiStok where Numara=@Numara", cn))
                {
                    SqlParameter[] p = { new SqlParameter("@Numara", txt_AyakkabiStokNo.Text.Trim()) };

                    cmd.Parameters.AddRange(p);

                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form1 frm = (Form1)Application.OpenForms["Form1"];
                        frm.txt_Marka.Text = dr["Marka"].ToString();
                        frm.txt_Model.Text = dr["Model"].ToString();
                        frm.txt_Num.Text = dr["Numara"].ToString();
                        frm.stokid = Convert.ToInt32(dr["StokID"]);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ayakkabı bulunamadı!");
                    }
                    dr.Close();
                }

            }
            cn.Dispose();
        }
    }
}
