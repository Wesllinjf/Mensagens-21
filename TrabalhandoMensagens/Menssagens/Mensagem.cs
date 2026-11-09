using Mensagemaula20.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.Menssagens
{
    public abstract class Mensagem
    {
        public string Remetente { get; set; }
        public DateTime Data { get; set; }
        public string Corpo { get; set; }

        public override int GetHashCode()
        {
            return Remetente.GetHashCode();
        }
        public bool Equals(Mensagem outra)
        {
            return Remetente == outra.Remetente;
        }
        public abstract void Exibir(); 
        /*public abstract void Exibir() Estava dando 11 erros de compilação
        {
            Console.WriteLine($"\n{Remetente}: {Corpo}");
            
            Ela precisa ser abstrata para poder sobrescrevê-la, poderíamos usar o virtual também, mas a diferença é que o virtual exige um corpo e a abstrata não.
        }*/
    }
}
