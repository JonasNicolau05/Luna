using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr ;
        public string LoginAdm { get; set; }
        public string SenhaAdm { get; set; }

        public bool verificarLogin ( String login , String senha)
        {
            String criptoSenha = Criptografia(senha);
            cmd.CommandText = "SELECT * from usuarios WHERE nome = @login AND senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", criptoSenha);
            
            try
            {
                cmd.Connection = con.conectar();
                
                dr  = cmd.ExecuteReader();
                if (dr.HasRows )
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
                
            }

            return tem;
        }


        public String cadastrar (String nome, String senha, String confimar, string usuAdm, string senhaAdm)
        {

            tem = false;
            verificarLogin(nome, senha);
            if (tem == true)
            {
                this.mensagem = "Usuário já cadastrado!";
            }
            else
            {
                 
                    if (senha.Equals(confimar))
                    {
                        int adm = acharid(usuAdm, senhaAdm);
                        String criptosenha = Criptografia(senha);
                        cmd.CommandText = "insert into usuarios (nome, senha, owner ) values (@n, @c,@z); ";
                        cmd.Parameters.AddWithValue("@n", nome);
                        cmd.Parameters.AddWithValue("@c", criptosenha);
                        cmd.Parameters.AddWithValue("@z", adm);

                        try
                        {
                            cmd.Connection = con.conectar();
                            cmd.ExecuteNonQuery();
                            con.desconectar();
                            this.mensagem = "Novo Usuário Cadastrado!";
                            tem = true;
                        }
                        catch (SqlException)
                        {

                            this.mensagem = "Erro ao cadastrar!";
                        }
                    }
                
                else
                {
                    this.mensagem = "Senhas não correspondem!";
                }
            }
            return mensagem;
        }
        public void cadastropermi (String nomeUsu,String senhaUsu,int luz, int vent, int cel, int garagem, int cadastrar, string usuAdm, string senhaAdm)
        {
            int usu = acharid(nomeUsu, senhaUsu);
            int adm = acharid(usuAdm, senhaAdm);
            cmd.CommandText = "insert into permissao(luz, ventilador,garagem,celular,cadastrar,idusu,idadm ) values (@a, @b,@c, @d, @e, @f, @g); ";
            cmd.Parameters.AddWithValue("@a", luz);
            cmd.Parameters.AddWithValue("@b", vent);
            cmd.Parameters.AddWithValue("@c", cel);
            cmd.Parameters.AddWithValue("@d", garagem);
            cmd.Parameters.AddWithValue("@e", cadastrar);
            cmd.Parameters.AddWithValue("@f", usu);
            cmd.Parameters.AddWithValue("@g", adm);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                
               
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            
        }
        public int acharid(String login, String senha)
        {
            LoginAdm = login;
            SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("select id from usuarios where nome ='" + login + "' and senha = '" + SenhaAdm + "'", con.conectar());
            
            try
            {
                
                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["id"]);
                }

                
                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 0;
        }
        public String Criptografia(String criptosenha)
        {

            var senhaCriptografada = "";
            try
            {
                UnicodeEncoding encode = new UnicodeEncoding();
                byte[] Bytes, mensagemBytes = encode.GetBytes(criptosenha);

                SHA512Managed sha512Manager = new SHA512Managed();

                Bytes = sha512Manager.ComputeHash(mensagemBytes);

                foreach (byte b in Bytes)
                {
                    senhaCriptografada += String.Format("{0:x2}", b);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return senhaCriptografada;
        }

        public int Permissaoluz (String login, String senha)
        {
            LoginAdm = login;
            SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("SELECT u.nome, u.senha, p.luz FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu where nome ='" + login + "' and senha = '" + SenhaAdm + "'", con.conectar());
             

            try
            {

                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["luz"]);
                }

                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 2;
        }

        public int PermissaoVent(String login, String senha)
        {
            LoginAdm = login;
            SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("SELECT u.nome, u.senha, p.ventilador FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu where nome ='" + login + "' and senha = '" + SenhaAdm + "' and ventilador = '1'", con.conectar());


            try
            {

                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["ventilador"]);
                }

                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 2;
        }

        public int PermissaoGaragem(String login, String senha)
        {
            LoginAdm = login;
            SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("SELECT u.nome, u.senha, p.garagem FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu where nome ='" + login + "' and senha = '" + SenhaAdm + "' and garagem = '1'", con.conectar());


            try
            {

                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["garagem"]);
                }

                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 2;
        }

        public int PermissaoCelular(String login, String senha)
        {
            LoginAdm = login;
            SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("SELECT u.nome, u.senha, p.celular FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu where nome ='" + login + "' and senha = '" + SenhaAdm + "' and celular = '1'", con.conectar());


            try
            {

                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["celular"]);
                }

                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 2;
        }

        public int PermissaoCadastro(String login, String senha)
        {
            LoginAdm = login;
            SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("SELECT u.nome, u.senha, p.cadastrar FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu where nome ='" + login + "' and senha = '" + SenhaAdm + "' and cadastrar = '1'", con.conectar());


            try
            {

                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["cadastrar"]);
                }

                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 2;
        }

        public void logusuario(String usuario, String comando, String data, String hora)
        {

            //cmd.CommandText = "insert into logusu (Usuario, Comando, Hora, Data ) values (@a, @b,@c, @d); ";
            cmd.CommandText = "InserirComando";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", usuario);
            cmd.Parameters.AddWithValue("@b", comando);
            cmd.Parameters.AddWithValue("@c", hora);
            cmd.Parameters.AddWithValue("@d", data);
         

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.desconectar();


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }


        }
        public DataTable ListaUsuarios()
        {
            SqlDataReader leer;
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.conectar();
            // cmd.CommandText = "SELECT u.id, u.nome, p.luz, p.ventilador,p.garagem, p.celular, p.idadm FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu";
            cmd.CommandText = "SELECT * FROM usuarios u INNER JOIN permissao p ON u.id = p.idusu where nome != 'admin' ";
            leer = cmd.ExecuteReader();
            tabela.Load(leer);
            con.desconectar();
            return tabela;
        }

        public DataTable Log()
        {
            SqlDataReader leer;
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.conectar();
            cmd.CommandText = "SELECT Usuario , Comando , Hora , Data FROM logusu";
            leer = cmd.ExecuteReader();
            tabela.Load(leer);
            con.desconectar();
            return tabela;
        }
        public String atualizarcadastro(String nome, String senha,String novoNome , String novaSenha ,  string usuAdm, string senhaAdm)
        {

            

                
                    int adm = acharid(usuAdm, senhaAdm);
                    int usu = acharidedi(nome, senha);
                    String criptosenha = Criptografia(novaSenha);
                    cmd.CommandText = "EditarClientes";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@n", novoNome);
                    cmd.Parameters.AddWithValue("@c", criptosenha);
                    cmd.Parameters.AddWithValue("@a", adm);
                    cmd.Parameters.AddWithValue("@u", usu);

                    try
                    {
                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "Cadastrado Atualizado";
                        tem = true;
                    }
                    catch (SqlException)
                    {

                        this.mensagem = "Erro ao cadastrar!";
                    }
                
                
            
            return mensagem;
        }
        public void atualizarpermi(String nomeUsu, String senhaUsu, int luz, int vent, int cel, int garagem, int cadastrar, string usuAdm, string senhaAdm)
        {
            String cripto = Criptografia(senhaUsu);
            int usu = acharidedi(nomeUsu, cripto);
            int adm = acharid(usuAdm, senhaAdm);
            //cmd.CommandText = "update permissao set luz = @a , ventilador= @b,garagem=@c,celular=@d,cadastrar=@e,idadm=@g where id = @f ";
            cmd.CommandText = "AtualizarPermissao";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", luz);
            cmd.Parameters.AddWithValue("@b", vent);
            cmd.Parameters.AddWithValue("@c", cel);
            cmd.Parameters.AddWithValue("@d", garagem);
            cmd.Parameters.AddWithValue("@e", cadastrar);
            cmd.Parameters.AddWithValue("@f", usu);
            cmd.Parameters.AddWithValue("@g", adm);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }


        }
        public int acharidedi(String login, String senha)
        {
            LoginAdm = login;
            //SenhaAdm = Criptografia(senha);

            cmd = new SqlCommand("select id from usuarios where nome ='" + login + "' and senha = '" + senha + "'", con.conectar());

            try
            {

                dr = cmd.ExecuteReader();
                int idInteiro = 0;
                while (dr.Read())
                {
                    idInteiro = Convert.ToInt32(dr["id"]);
                }


                con.desconectar();
                dr.Close();

                return idInteiro;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";

            }

            return 0;
        }

        public void ExcluirPermissao(int id)
        {
            cmd.Connection = con.conectar();
            cmd.CommandText = "ExcluirPermissao";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void ExcluirCliente(int id)
        {
            cmd.Connection = con.conectar();
            cmd.CommandText = "ExcluirCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }
    }
}
