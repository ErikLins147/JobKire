using System;
namespace Api.Models
{
    public class Livro
    {
        public Livro () => CriadoEm = DateTime.Now;
       
        

        public  string   Nome       { get ; set ;}
        public  double   Preco      { get ; set ;}
        public  string   Titulo     { get ; set ;}
        public  int      Quantidade { get ; set ;}
        public  string   Sinopse    { get ; set ;}
        public  DateTime CriadoEm   { get ; set ;}

        public override string ToString() =>
        $"Nome: {Nome} | Preco : {Preco.ToString("C2")}";
    }
     
}
