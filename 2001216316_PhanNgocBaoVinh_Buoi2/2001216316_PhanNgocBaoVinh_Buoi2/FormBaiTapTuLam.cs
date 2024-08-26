using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomConnection;
namespace _2001216316_PhanNgocBaoVinh_Buoi2
{
    public partial class FormBaiTapTuLam : Form
    {
       SqlClass dbContext;
        public FormBaiTapTuLam()
        {
            InitializeComponent();
            dbContext = new SqlClass("A202PC28","hehe");
            //string constr = "Data Source=A202PC28;Initial Catalog=hehe;Integrated Security=True";
            //dbContext.CreateConnection(constr);
            try
            {
                MessageBox.Show(dbContext.TestConnection() + "ket noi duoc =))");

            }
            catch (Exception)
            {
                MessageBox.Show(dbContext.TestConnection() + "ket noi that bai=))");
            }
            load_data();
        }

        private void FormBaiTapTuLam_Load(object sender, EventArgs e)
        {

        }
        public void load_data()
        {
            string constr = "SELECT*FROM TEST";
            dbContext.Reader = dbContext.ExcuteQuery(constr);
            while(dbContext.Reader.Read())
            {
                dataGridView1.Rows.Add(dbContext.Reader["id"].ToString(), dbContext.Reader["name"].ToString());
            }

            

        }

        
    }
}
