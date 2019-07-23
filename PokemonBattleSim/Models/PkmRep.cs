//using PokemonBattleSim.Models;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PokemonBattleSim.Models
//{
//    public interface PkmnRepo
//    {
       
//        int Insert(Pokemon pkmn);
//        int Update(Pokemon pkmn);
//        int Delete(int Id);
//    }
//}

//    public class AdoNetPersonRepository : PkmnRepo
//    {
//        public int Insert(Pokemon pkmn)
//        {
//        SqlCommand tCommand = new SqlCommand();
//        tCommand.Connection = new SqlConnection("YourConnectionString");
//        tCommand.CommandText = "UPDATE players SET name = @name, score = @score, active = @active WHERE jerseyNum = @jerseyNum";

//        tCommand.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.VarChar).Value = "Smith, Steve");
//        tCommand.Parameters.Add(new SqlParameter("@score", System.Data.SqlDbType.Int).Value = "42");
//        tCommand.Parameters.Add(new SqlParameter("@active", System.Data.SqlDbType.Bit).Value = true);
//        tCommand.Parameters.Add(new SqlParameter("@jerseyNum", System.Data.SqlDbType.Int).Value = "99");

//        tCommand.ExecuteNonQuery();
//    }

//        public int Update(Pokemon pkmn)
//        { /* SQL goes here */ }

//        public int Delete(Pokemon pkmn)
//        { /* SQL goes here */ }

//    public int Delete(int Id)
//    {
//        throw new NotImplementedException();
//    }

//    //public int Update(Pokemon pkmn)
//    //{
//    //    throw new NotImplementedException();
//    //}
//}

//}
