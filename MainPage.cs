using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinalTest
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public string path = "C:/Users/Shin/Desktop/hosp_doc.db";//파일 경로

        private void save_button_Click(object sender, EventArgs e)
        {
            if (name_textbox.TextLength == 0 || age_textbox.TextLength == 0 || what_sick_textbox.TextLength == 0 ||
                (male_radio.Checked == false && female_radio.Checked == false))//필수 기입 정보 이름, 나이, 병명, 성별을 입력했는지 확인
            {
                MessageBox.Show("필수 정보를 입력하지 않았습니다.");
            }
            else
            {
     
                string gender;
                int age = Convert.ToInt32(age_textbox.Text);
                if (male_radio.Checked)//남성인지 여성인지 체크확인 후 문자열로 변환
                {
                    gender = "남성";
                }
                else
                {
                    gender = "여성";
                }
                string aller;
                if (Allergie_none_checkbox.Checked)//알레르기에 없음 버튼 누르면 없다고 문자열로 변환 아니면 텍스트 상자
                {
                    aller = "없음";
                }
                else
                {
                    aller = Allergie_textbox.Text;
                }
                string command = "'" + name_textbox.Text + "','" + age + "','" + gender + "','" + aller + "','" +
                                what_sick_textbox.Text + "','" + manifi_textbox.Text + "','" + LoginPage.doctor_name + "','" + DateTime.Now.ToString("yyyyMMdd") + "'";
                string constr = "Data Source=" + path;//연동하는 DB파일
                string sql_DB = "insert into Doc_DB values (" + command + ");";      //sql명령어
                var con = new SQLiteConnection(constr);
                con.Open();//DB 열기

                SQLiteCommand DB_DB = new SQLiteCommand(sql_DB, con);//명령어 커맨드 입력
                DB_DB.ExecuteNonQuery();

                con.Close();
                Datagrid_refresh(constr);//추가될시 새로고침
                All_clear();
            }
            
        }
        private void Datagrid_refresh(string constr)//datagridtable 새로고침하기
        {
            string sql_DB = "select * from Doc_DB";//sql명령어
            var con = new SQLiteConnection(constr);
            con.Open();//DB 열기

            SQLiteCommand DB_DB = new SQLiteCommand(sql_DB, con);//명령어 커맨드 입력

            using (SQLiteDataReader rdr_DB = DB_DB.ExecuteReader())//데이터 테이블 db랑 연동하기
            {
                DataTable Dt = new DataTable();
                Dt.Load(rdr_DB);
                rdr_DB.Close();
                con.Close();
                dataGridView1.DataSource = Dt;
            }
        }
        public void All_clear()//저장 버튼을 누르면 텍스트박스와 라디오 버튼을 모드 초기화하도록 만듬
        {
            name_textbox.Clear();
            age_textbox.Clear();
            male_radio.Checked = false;
            female_radio.Checked = false;
            Allergie_none_checkbox.Checked = false;
            Allergie_textbox.Clear();
            what_sick_textbox.Clear();
            manifi_textbox.Clear();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=" + path;
            Datagrid_refresh(constr);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            name_label.Font = fontDialog1.Font;
            name_textbox.Font= fontDialog1.Font;
            age_label.Font= fontDialog1.Font;
            age_textbox.Font= fontDialog1.Font;
            gender_label.Font= fontDialog1.Font;
            male_radio.Font= fontDialog1.Font;
            female_radio.Font= fontDialog1.Font;
            Allergie_label.Font= fontDialog1.Font;
            Allergie_none_checkbox.Font= fontDialog1.Font;
            Allergie_textbox.Font= fontDialog1.Font;
            what_sick_label.Font= fontDialog1.Font;
            what_sick_textbox.Font= fontDialog1.Font;
            manifi_label.Font= fontDialog1.Font;
            manifi_textbox.Font= fontDialog1.Font;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string[] search = { "Name","Age","What_sick","Doc","Date" };
            string selectbox= search_combobox.SelectedItem as string;
            string str="None";

            switch (selectbox)
            {
                case "이름":
                    str = search[0];
                    break;
                case "나이":
                    str = search[1];
                    break;
                case "병명":
                    str = search[2];
                    break;
                case "담당의사":
                    str = search[3];
                    break;
                case "진료일자":
                    str = search[4];
                    break;
                default:
                    MessageBox.Show("검색항목을 선택하십시오");
                    break;
            }
            if (!str.Equals("None"))
            {
                string sql_log = "select * from Doc_DB where "+str+"='"+search_text.Text+"'";
                var con = new SQLiteConnection("Data Source=" + path);
                con.Open();//DB 열기

                SQLiteCommand DB_log = new SQLiteCommand(sql_log, con);//명령어 커맨드 입력

                using (SQLiteDataReader rdr_DB = DB_log.ExecuteReader())//데이터 테이블 db랑 연동하기
                {
                    DataTable Dt = new DataTable();
                    Dt.Load(rdr_DB);
                    rdr_DB.Close();
                    con.Close();
                    dataGridView2.DataSource = Dt;
                }
            }
        }

        private void toolStripMenuItem1_3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "DB파일 (*.db)|*.db|모든 파일(*.*)|*.*";//db파일 선택
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            foreach (string strTmp in openFileDialog1.FileNames)
            {
                path=strTmp;
            }
            try
            {
                Datagrid_refresh("Data Source=" + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("환자 DB를 선택해주세요");//환자db가 아니면 오류메세지 출력
            }

        }

        private void toolStripMenuItem1_2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = path;
            saveFileDialog1.Filter = "DB파일 (*.db)|*.db|모든 파일(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName.ToString();//경로에 새로운 경로 저장
            }
            Mkfile mk = new Mkfile();
            mk.mk(path);
            Datagrid_refresh("Data Source="+path);//새로고침
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)//도움말 출력
        {
            HelpPage hp = new HelpPage();
            hp.Show();
        }
    }
}
