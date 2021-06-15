using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace FinalTest
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            PW_Text.PasswordChar = '*';//비밀번화 입력시 * 표시
            this.ActiveControl = ID_Text; //
            ID_Text.Focus();              //여기까지 폼 시작시 ID 텍스트 박스에 초점이 가게 만들기

        }
        public string path = "C:/Users/Shin/Desktop/hosp_doc.db";//파일 경로
        int log = 0;
        public static string doctor_name;//ID를 메인페이지 담당의사로 값을 넘기기 위함
        private void Login_button_Click(object sender, EventArgs e)
        {
            if (ID_Text.TextLength == 0 && PW_Text.TextLength == 0)//아이디와 비밀번호를 아무것도 입력하지 않고 로그인 버튼 누를시
            {                                                      //입력해달라는 메세지 호출, 이건 입력이 틀렸다고 하지 않음
                MessageBox.Show("아이디와 비밀번호를 입력해주세요");
            }
            else
            {
                if (Login(ID_Text.Text, PW_Text.Text))
                {
                    doctor_name = ID_Text.Text;//메인페이지로 의사 아이디 값 넘기기
                    this.Hide();//새 페이지 나오기 전에 숨기기
                    log = 0;
                    MainPage Mp = new MainPage();//새 페이지 부르기
                    Mp.ShowDialog();
                    this.Close();//숨긴 페이지는 닫기
                }
                else if (log > 1)
                {
                    MessageBox.Show("3회 이상 틀렸습니다 종료합니다");//카운트를 세고 3회이상 틀릴시 경고창 띄우고 창 닫기
                    Close();
                }
                else
                {
                    log++;
                    MessageBox.Show("로그인 실패했습니다\n" + log + "회");
                }
            }
        }
        private bool Login(string ID, string PW)//DB연동해서 로그인하기
        {
            string sql_log = "select * from Doc_ID";//sql명령어
            var con = new SQLiteConnection("Data Source="+path);
            con.Open();//DB 열기
            
            SQLiteCommand DB_log = new SQLiteCommand(sql_log, con);//명령어 커맨드 입력

            SQLiteDataReader rdr_log = DB_log.ExecuteReader();//나온 데이터 읽기
            bool check = false;//아이디 비번 나올시 true

            while (rdr_log.Read())//행 읽기
            {
                if ((string)rdr_log["ID"] == ID && (string)rdr_log["PW"]==PW)//아이디 비번 확인
                    check = true;
            }

            rdr_log.Close();
            con.Close();//닫기
            return check;
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            Sign_up_Page SP = new Sign_up_Page();
            SP.ShowDialog();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            FileInfo FI = new FileInfo(path);
            if (!FI.Exists)//파일이 있는지 확인 후 없으면 새 파일 만들기
            {
                Mkfile mk = new Mkfile();
                mk.mk(path);
            }
            
        }
    }
}
