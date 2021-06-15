using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinalTest
{
    public partial class Sign_up_Page : Form
    {
        public Sign_up_Page()
        {
            InitializeComponent();
        }
        public string path = "C:/Users/Shin/Desktop/hosp_doc.db";
        private void Sign_Up_button_Click(object sender, EventArgs e)
        {
            if (Overlap())//중복되는게 나올시 메세지 창 띄우고 clear하기
            {
                MessageBox.Show("ID가 중복됩니다.");
                clear();
            }
            else
            {
                string insert_ID = "insert into Doc_ID values ('" + Name_textbox.Text+"', '" + PW_textbox.Text+"');";
                var insert_inID = new SQLiteConnection("Data Source=" + path);
                insert_inID.Open();

                SQLiteCommand insert = new SQLiteCommand(insert_ID, insert_inID);
                insert.ExecuteNonQuery();
                insert_inID.Close();
                MessageBox.Show("완료되었습니다.");
                clear();
            }
            
        }
        private bool Overlap()
        {
            string find = "select * from Doc_ID";//sql명령어
            var find_id = new SQLiteConnection("Data Source=" + path);
            find_id.Open();//DB 열기

            SQLiteCommand DB_log = new SQLiteCommand(find, find_id);//명령어 커맨드 입력

            SQLiteDataReader rdr_log = DB_log.ExecuteReader();//나온 데이터 읽기
            bool overl = false;//아이디 중복시 true

            while (rdr_log.Read())//행 읽기
            {
                if ((string)rdr_log["ID"] == Name_textbox.Text)//아이디 비번 확인
                    overl = true;
            }

            rdr_log.Close();
            find_id.Close();//닫기
            return overl;
        }
        private void clear()
        {
            Name_textbox.Clear();
            PW_textbox.Clear();
        }
    }
}
