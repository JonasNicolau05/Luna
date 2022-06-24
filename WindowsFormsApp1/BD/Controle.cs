using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Controle
    {
        public bool tem ;
        public String mensagem = "";
        public bool acessar (String login , String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }

            return tem;
        }

        public String cadastrar (String nome , String csenha , String confirma ,  string usuadm, string senhadm,int luz,int vent,int cel,int garagem,int cadastrar)
        {
            
            LoginDaoComandos loginDao = new LoginDaoComandos();
            
                this.mensagem = loginDao.cadastrar(nome, csenha, confirma,  usuadm, senhadm);
                loginDao.cadastropermi(nome, csenha, luz, vent, cel, garagem, cadastrar,usuadm,senhadm);
                if (loginDao.tem)
                {
                    this.tem = true;
                }
                
              
            return mensagem;
        }
    }
}
