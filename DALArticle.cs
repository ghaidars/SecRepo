using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; //pour liste
namespace tpp5bd{
    class DALArticle{ //p92
        public static void Add(Article a){
            DBConnection Connection=new DBConnection();
            MySqlConnection cnn=Connection.GetConnection();
            if (cnn!=null){
                string query='INSERT INTO ARTICLE VALUES()';
            }



            string sql='INSERT INTO ARTICLE VALUES(1,"chaise",200)';
            MySqlCommand command =new MySqlCommand;
            command.Connection=cnn;
            command.CommandText=sql;
            try{
                command.ExecuteNonQuery();
                Console.WriteLine("Larticle est ajout avec success");
            }
            catch(Exception e)
        }
        public static void Delete(int Ref){

        }
        public static void Update(int Ref,Article a){

        }
        public static void SelectByRef(int Ref){

        }
        public static List<Article>SelectAll(){

        }

    }
    
}