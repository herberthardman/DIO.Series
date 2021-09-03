using System;

namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        private Genero _genero {get; set;}

        private string _titulo {get; set;}

        private string _descircao {get; set;}

        private int _ano {get; set;}

        private bool _excluido {get; set;}

        public Series(int _id, Genero _genero, string _titulo, string _descircao, int _ano) 
        {
            this._id = _id;
            this._genero = _genero;
            this._titulo = _titulo;
            this._descircao = _descircao;
            this._ano = _ano;
            this._excluido = false;
        }

        public string retornaTitulo()
        {
            return this._titulo;
        }

        public int retornaId()
        {
            return this._id;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Código: " + this._id + Environment.NewLine;
            retorno += "Genero: " + this._genero + Environment.NewLine;
            retorno += "Titulo: " + this._titulo + Environment.NewLine;
            retorno += "Descrição: "+ this._descircao + Environment.NewLine;
            retorno += "Ano de Início: " + this._ano + Environment.NewLine;
            retorno += "Excluído: " + this._excluido + Environment.NewLine;
            return retorno;
        }

        public void Excluir()
        {
            this._excluido = true;
        }
    }
}