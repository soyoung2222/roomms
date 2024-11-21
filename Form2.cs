﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace roomms
{
    public partial class main : Form
    {
        string room_Num; // 방 번호 검색시 사용 변수
        string roomsql; // 쿼리문 저장 변수
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        DataRow currRow; //DS의 현재 행 저장 변수
        public main()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//*
        }
        public void sql_execute(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "room");
            dsstr.Tables["room"].Clear();
            dbc.DA.Fill(dsstr, "room");
            dataGridView1.DataSource = dsstr.Tables["room"].DefaultView;
            room_header();     //함수 호출 

        }
        public void room_header()
        {
            dataGridView1.Columns[0].HeaderText = "번호";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "상태";
            dataGridView1.Columns[3].HeaderText = "수용인원";
            dataGridView1.Columns[4].HeaderText = "청소상태";

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 100;
        }
        public void list_search(String Find, String Sort)
        {
            if (Find == "" && Sort == "")  //기본
            {
                roomsql = "Select * From room ORDER BY room_id ASC";
                sql_execute(roomsql, dbc.DS);
            }
            else if (Find != "")  //검색
            {
                roomsql = "Select * From room Where room_id Like '%" + Find + "%'";

                sql_execute(roomsql, dbc.DS);
                if (dbc.DS.Tables["room"].Rows.Count == 0)
                {
                    MessageBox.Show("방이 존재하지 않습니다");
                    roomsql = "Select * From room ORDER BY room_id ASC";
                    sql_execute(roomsql, dbc.DS);
                }
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            list_search("", "");
            usage_id();
            c_id();
            this.Left = 0;
            this.Top = 0;
        }
        private void Findbtn_Click(object sender, EventArgs e)
        {
            if (Findtxt.Text.Trim() == "")
                MessageBox.Show("검색 미입력");
            else
                list_search(Findtxt.Text.Trim(), "");

        }
        public void sql_execute2(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {

            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;

            dbc.DA.Fill(dsstr, "usage");
            dsstr.Tables["usage"].Clear(); 
            dbc.DA.Fill(dsstr, "usage");

            dataGridView2.DataSource = dsstr.Tables["usage"].DefaultView;
            usager_header();
        }
        public void usager_header()
        {
            dataGridView2.Columns[0].HeaderText = "이용번호";
            dataGridView2.Columns[1].HeaderText = "방 번호";
            dataGridView2.Columns[2].HeaderText = "회원번호";
            dataGridView2.Columns[3].HeaderText = "시작시간";
            dataGridView2.Columns[4].HeaderText = "종료시간";

            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 80;
            dataGridView2.Columns[2].Width = 80;
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[4].Width = 80;
        }
        public void usage_id()
        {
            roomsql = "Select * From usage Where usage_id <> '0' ORDER BY room_id ASC";
            sql_execute2(roomsql, dbc.DS);
        }
        public void sql_execute3(String sqlstr, DataSet dsstr)    //사용자 함수 정의   =>DR 이용
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "customer");
            dsstr.Tables["customer"].Clear();  //***** 방법1 :DS를 하나만 정의한 상태에서 기존의 DS의 book만 제거            
            dbc.DA.Fill(dsstr, "customer");

            dataGridView3.DataSource = dsstr.Tables["customer"].DefaultView;

            c_header();
        }
        public void c_header()
        {
            dataGridView3.Columns[0].HeaderText = "회원번호";
            dataGridView3.Columns[1].HeaderText = "이름";
            dataGridView3.Columns[2].HeaderText = "전화번호";
            dataGridView3.Columns[3].HeaderText = "누적 이용시간";

            dataGridView3.Columns[0].Width = 80;
            dataGridView3.Columns[1].Width = 60;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[3].Width = 80;
        }
        public void c_id()
        {
             roomsql = "Select * From customer A Inner Join usage B on A.c_id = B.c_id ";
            sql_execute3(roomsql, dbc.DS);
        }
    }
}
