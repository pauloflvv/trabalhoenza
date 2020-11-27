using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Faculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string Salting = "s4lt1ngp4ssw0rd";
        public const string connString = "Server=localhost;Database=faculdade;Uid=root;Pwd=root";

        private void btnCad_Click(object sender, EventArgs e)
        {
            //Verifica se o usuário esta vazio
            if(string.IsNullOrWhiteSpace(txtUsuarioCad.Text))
            {
                MessageBox.Show("Digite o usuário");
                return;
            }

            //Verifica se a senha esta vazio
            if (string.IsNullOrWhiteSpace(txtSenhaCad.Text))
            {
                MessageBox.Show("Digite a senha");
                return;
            }

            
            string senha = txtSenhaCad.Text;
            string senhaComSalt = Salting + senha;
            Hash hash = new Hash();

            //Criptografa a senha
            string senhaCodificada = hash.CriptografarSenha(senhaComSalt);

            //Conecta no banco de dados
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO login (usuario, senha) VALUES ('{txtUsuarioCad.Text}','{senhaCodificada}');";
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text))
            {
                MessageBox.Show("Digite o usuário");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenhaLogin.Text))
            {
                MessageBox.Show("Digite a senha");
                return;
            }

            string senha = txtSenhaLogin.Text;
            string senhaComSalt = Salting + senha;

            //Busca do banco de dados
            string sql = $"SELECT l.senha as senha FROM login l WHERE l.usuario = '{txtUsuarioLogin.Text}';";
            MySqlConnection con = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            string senhaDoBancoDeDados = null;
            while (reader.Read())
            {
                senhaDoBancoDeDados = $"{reader.GetString("senha")}";
            }

            Hash hash = new Hash();
            string senhaCodificada = hash.CriptografarSenha(senhaComSalt);

            //Verifica se a senha confere
            if (senhaCodificada.Equals(senhaDoBancoDeDados))
            {
                MessageBox.Show("Usuário logado com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
    }
}
