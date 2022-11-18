using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MineraliSQL {
	internal class Program {
		static void Main(string[] args) {
			//string connectionString = "Data Source=ZVER\\MSSQLSERVER2016;Initial Catalog=Minerali_DB;User ID=sa;Password=1234";
			try {
				Console.WriteLine("Unesite podatke: Naziv minerala, Kompoziciju, Kristalni oblik, tvrdocu i boju");
				InsertMinerals(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToString(Console.ReadLine()));
				PrintMinerals();
				Console.WriteLine("Unesite ID broj reda koji zelite da izmenite. Nakon toga unesite: Naziv minerala, Kompoziciju, Kristalni oblik, tvrdocu i boju");
				UpdateMinerals(Convert.ToInt32(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToString(Console.ReadLine()));
				PrintMinerals();
				Console.WriteLine("Unesite broj reda koji zelite da obrisete");
				DeleteMinerals(Convert.ToInt32(Console.ReadLine()));
				PrintMinerals();
			}
			catch (Exception ex) {

				Console.WriteLine($"{ex}");
			}
			Console.ReadLine();
		}
		static void InsertMinerals(string naziv, string kompozicija, string kristalniOblik, int tvrdoca, string boja) {
			string connectionString = "Data Source=ZVER\\MSSQLSERVER2016;Initial Catalog=Minerali_DB;User ID=sa;Password=1234";
			try {
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				string sqlQuery = $"INSERT INTO Minerali_Tabela (Naziv, Kompozicija, KristalniOblik, Tvrdoca, Boja) VALUES ('{naziv}', '{kompozicija}', '{kristalniOblik}', '{tvrdoca}', '{boja}');";
				SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
				int result = command.ExecuteNonQuery();
				Console.WriteLine($"Insert completed, number of rows changed: {result}");
				sqlConnection.Close();
			}
			catch (Exception ex) {
				Console.WriteLine($"{ex}");
			}
		}
		static void UpdateMinerals(int Id, string naziv, string kompozicija, string kristalniOblik, int tvrdoca, string boja) {
			string connectionString = "Data Source=ZVER\\MSSQLSERVER2016;Initial Catalog=Minerali_DB;User ID=sa;Password=1234";
			try {
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				string sqlQuery = $"UPDATE Minerali_Tabela SET Naziv = '{naziv}', Kompozicija = '{kompozicija}', KristalniOblik = '{kristalniOblik}', Tvrdoca = '{tvrdoca}', Boja = '{boja}' WHERE Id = {Id};";
				SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
				int result = command.ExecuteNonQuery();
				Console.WriteLine($"Update completed, number of rows changed: {result}");
				sqlConnection.Close();
			}
			catch (Exception ex) {
				Console.WriteLine($"{ex}");
			}
		}
		static void DeleteMinerals(int startingId) {
			string connectionString = "Data Source=ZVER\\MSSQLSERVER2016;Initial Catalog=Minerali_DB;User ID=sa;Password=1234";
			try {
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				string sqlQuery = $"DELETE FROM Minerali_Tabela WHERE Id >= {startingId};";
				SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
				int result = command.ExecuteNonQuery();
				Console.WriteLine($"Delete completed, number of rows changed: {result}");
				sqlConnection.Close();
			}
			catch (Exception ex) {
				Console.WriteLine($"{ex}");
			}
		}
		static void PrintMinerals() {
			string connectionString = "Data Source=ZVER\\MSSQLSERVER2016;Initial Catalog=Minerali_DB;User ID=sa;Password=1234";
			try {
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Minerali_Tabela;", sqlConnection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read()) {
					int id = reader.GetInt32(0);
					string naziv = reader.GetString(1);
					string kompozicija = reader.GetString(2);
					string kristalniOblik = reader.GetString(3);
					int tvrdoca = reader.GetInt32(4);
					string boja = reader.GetString(5);
					Console.WriteLine($"{id}; {naziv}; {kompozicija}; {kristalniOblik}; {tvrdoca}; {boja}");
				}
				sqlConnection.Close();
			}
			catch (Exception ex) {
				Console.WriteLine($"{ex}");
			}
		}


	}
}
