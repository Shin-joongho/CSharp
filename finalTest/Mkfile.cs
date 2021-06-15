using System;
using System.Data.SQLite;

namespace FinalTest//새 파일 만들기
{
    public class Mkfile
    {
        public void mk(string path)
        {
            SQLiteConnection.CreateFile(path);
            string create_str_data = "create table Doc_DB('Name' Text,'Age' Integer, 'Gender' Text, 'Allerige' Text, 'What_sick' Text, 'Minif' Text, 'Doc' Text, 'Date' Text)";
            var mk_table = new SQLiteConnection("Data Source=" + path);//data table 만들기
            mk_table.Open();

            SQLiteCommand con_table = new SQLiteCommand(create_str_data, mk_table);
            con_table.ExecuteNonQuery();
            mk_table.Close();

            string create_str_ID = "create table Doc_ID('ID' Text,'PW' Text)";//ID table 만들기
            var mk_table_ID = new SQLiteConnection("Data Source=" + path);
            mk_table_ID.Open();

            SQLiteCommand con_table_ID = new SQLiteCommand(create_str_ID, mk_table_ID);
            con_table_ID.ExecuteNonQuery();
            mk_table_ID.Close();

            string insert_f = "insert into Doc_ID values ('User', '1234')";//처음시작하자 마자 기본 계정 만들기
            var insert_first = new SQLiteConnection("Data Source=" + path);
            insert_first.Open();

            SQLiteCommand insert = new SQLiteCommand(insert_f, insert_first);
            insert.ExecuteNonQuery();
            insert_first.Close();
        }
    }
}
