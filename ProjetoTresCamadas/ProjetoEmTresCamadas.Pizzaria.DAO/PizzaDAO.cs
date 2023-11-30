using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

namespace ProjetoEmTresCamadas.Pizzaria.DAO
{
    public class PizzaDAO
    {
        public const string ConnectionString = "Data Source=Pizza.db";
        public PizzaDAO()
        {
            CriarBancoDeDados();
        }

        public void CriarBancoDeDados()
        {
            using (var sqlConnection = new SqliteConnection(ConnectionString))
            {
                sqlConnection.Open();
                using (var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tb_Pizza (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SABOR VARCHAR(50) NOT NULL,
                        DESCRICAO VARCHAR(100),
                        TamanhoPizza INTEGER NOT NULL
                        )";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CriaPizza(Pizza pizzaVo)
        {
            using (var sqlConnection = new SqliteConnection(ConnectionString))
            {
                sqlConnection.Open();
                using (var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @$"insert into tb_Pizza (Sabor, Descricao, TamanhoPizza)
                        Values ('{pizzaVo.Sabor}','{pizzaVo.Descricao}', {(int)pizzaVo.TamanhoDaPizza})";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Pizza> ObterPizza()
        {
            List<Pizza> pizzas = new List<Pizza>();

            using (var sqlConnection = new SqliteConnection(ConnectionString))
            {
                sqlConnection.Open();
                using (var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @"Select * from tb_pizza";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pizza pizza = new Pizza
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Sabor = reader["Sabor"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                TamanhoDaPizza = (TamanhoDaPizza)Convert.ToInt32(reader["TamanhoDaPizza"].ToString()
                                )
                            };
                            pizzas.Add(pizza);
                        }
                        
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            return pizzas;
        }        
    }
}
