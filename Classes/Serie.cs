using System;
namespace DIO.Series

{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie (int id, Genero genero, string tituto, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = tituto;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Genero + Environment.NewLine;
            retorno += "Descrição: " + this.Genero + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaI()
        {
            return this.Id;
        }
    
}