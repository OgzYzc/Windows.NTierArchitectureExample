using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BL;

namespace Windows.NTierArchitectureExample
{
    public partial class AyakkabiEkle : Form
    {
        SqlConnection cn = null;
        public int stokid = 0;
        public AyakkabiEkle()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                BL bl = new BL();
                bool sonuc = bl.AyakkabiEkle(new Ayakkabi(txt_Marka.Text.Trim(), txt_Model.Text.Trim(), txt_Numara.Text.Trim()));
                if (sonuc)
                {
                    MessageBox.Show("İşlem başarılı");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız. Tekrar deneyin");
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2601:
                        MessageBox.Show("Aynı numaraya sahip bir ayakkabı zaten mevcut");
                        break;
                    case 2627:
                        MessageBox.Show("Veritabanı bağlantısı kurulamadı. Lütfen tekrar deneyiniz.");
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Sistem hatası" + ex);
                //ex.Message loglanacak
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu");

            }
            finally
            {
                CloseConnection();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (stokid == 0)
            {
                MessageBox.Show("Önce ayakkabı seçmelisiniz");
            }
            else
            {
                DialogResult cvp = MessageBox.Show("Ayakkabıyı silmek istediğinizden emin misiniz", "Kayıt Silme onayı", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from tblAyakkabiStok where StokID=@StokID", cn))
                        {
                            SqlParameter[] p = { new SqlParameter("@StokID", stokid) };
                            cmd.Parameters.AddRange(p);
                            if (cn != null && cn.State != ConnectionState.Open)
                            {
                                cn.Open();
                            }
                            int sonuc = cmd.ExecuteNonQuery();
                            if (sonuc > 0)
                            {
                                MessageBox.Show("İşlem başarılı");
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("İşlem başarısız");
                            }
                        }
                    }
                }
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=.;Integrated Security=TRUE;Initial Catalog=OkulDB"))
            {
                using (SqlCommand cmd = new SqlCommand("Update tblAyakkabiStok set Marka=@Marka,Model=@Model,Numara=@Numara where StokID=@StokID", cn))
                {
                    SqlParameter[] p = { new SqlParameter("@Marka", txt_Marka.Text.Trim()), new SqlParameter("@Model", txt_Model.Text.Trim()), new SqlParameter("@Numara", txt_Numara.Text.Trim()),new SqlParameter("@StokID",stokid
                        ) };

                    cmd.Parameters.AddRange(p);

                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşlem başarılı");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız");
                    }
                }

            }
        }
        void CloseConnection()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn.Dispose();
            }

        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            AyakkabiAra frm = new AyakkabiAra();
            frm.ShowDialog();
        }

        void Temizle()
        {

        }
    }
}
}
