using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ControleDeJogos
{
    public class ListaDeJogos
    {
        private List<Jogo> jogos;
        public List<Jogo> Jogos { get { return jogos; } }

        public ListaDeJogos()
        {
            jogos = new List<Jogo>();
        }

        public Boolean Inserir( Jogo jogo)
        {
            Boolean resultado= true;

            try
            {
                Jogo j = jogos.Find(x => x.Id == jogo.Id);
                if( j == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }

            }
            catch(Exception erro)
            {
                resultado = false;
            }

            return resultado;
        }

        public Boolean Alterar( Jogo jogo)
        {
            Boolean resultado = false;
            Jogo j = jogos.Find(x => x.Id == jogo.Id);
            if(j!= null)
            {
                j.Nome = jogo.Nome;
                j.Descricao = jogo.Descricao;
                j.Genero = jogo.Genero;
                j.Console = jogo.Console;
                resultado = true;

            }
            return resultado;
        }

        public Boolean Excluir(int id)
        {
            Boolean resultado= false;
            Jogo j = jogos.Find(x => x.Id == id);
            if(j!= null)
            {
                resultado = jogos.Remove(j);
            }
            return resultado;
        }

        public List<Jogo> Localizar(string nome)
        {
            List<Jogo> lj = jogos.FindAll(x => x.Nome.Contains(nome.ToUpper()));

            return lj;
        }

        public List<Jogo> ListarPorGenero(tipoGenero genero)
        {
            List<Jogo> lj = jogos.FindAll(x => x.Genero.Equals(genero));

            return lj;
        }

        public List<Jogo> ListarPorConsole(tipoConsole console)
        {
            List<Jogo> lj = jogos.FindAll(x => x.Console.Equals(console));

            return lj;
        }



    }
}
