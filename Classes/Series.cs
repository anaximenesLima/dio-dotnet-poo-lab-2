namespace DioSeries
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descrição { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Metodos

        public Serie (int id, Genero genero, string Titulo, string Descrição,  int Ano)
        {
        this.id = id;
        this.Genero = genero;
        this.Titulo = Titulo;
        this.Descrição = Descrição;
        this.Ano = Ano;
        this.Excluido = false;
        }
        public override string ToString()
        {
        //
        string retorno = "";
        retorno +=  "Genero:  " + this.Genero + Environment.NewLine;
        retorno +=  "Titulo:  " + this.Titulo + Environment.NewLine;
        retorno +=  "Descrição :  " + this.Descrição + Environment.NewLine;
        retorno +=  "Ano de inicio:  " + this.Ano + Environment.NewLine;
        retorno += "Excluido: " + this.Excluido;
        return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }


    } 
}