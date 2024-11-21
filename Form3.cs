using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomms
{
    public partial class room : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();
        public room()
        {
            InitializeComponent();
        }
        public void room_header()
        {
            DataGridView1.Columns[0].HeaderText = "방 번호";
            DataGridView1.Columns[1].HeaderText = "기계 번호";
            DataGridView1.Columns[2].HeaderText = "상태";
            DataGridView1.Columns[3].HeaderText = "수용 인원";
            DataGridView1.Columns[4].HeaderText = "청소 상태";

            DataGridView1.Columns[0].Width = 60;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 80;
            DataGridView1.Columns[3].Width = 80;
            DataGridView1.Columns[4].Width = 80;
        }

        private void room_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void room_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                sqlstr = "Select * From room ORDER BY room_id ASC";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "room");
                dbc.DS.Tables["room"].Clear();
                dbc.DA.Fill(dbc.DS, "room");
                DataGridView1.DataSource = dbc.DS.Tables["room"].DefaultView;
                room_header();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}
