using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeJogos
{
    public enum tipoGenero { Acao, Aventura, Casual, Puzzle, Estrategia, Outros }

    public enum tipoConsole { PS5, PS4, NSwitch, Xbox, Xbox360, XboxOne, PC, Outros }


    public class Jogo
    {
        public Jogo()
        {
            this.Id = 1;
            this.Nome = "";
            this.Descricao = "";
            this.Genero = tipoGenero.Outros;
            this.Console = tipoConsole.Outros;
        }

        public Jogo(int id, string nome, string descricao,tipoConsole console, tipoGenero genero)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Console = console;
            this.Genero = genero;
            
        }



        private int id;

        public int Id
        {
            get { return id; }
            set { 
                
                if(value > 0)  id = value;
                else
                {
                    throw new Exception("Permitido apenas números positivos!");
                }           
            
            }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }


        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public tipoConsole Console { get; set; }
        public tipoGenero Genero { get; set; }




    }
}
