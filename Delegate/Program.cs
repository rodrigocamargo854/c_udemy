using System;

delegate int op(int a, int b);

namespace Delegate
{


    class Program
    {
        static void Main(string[] args)
        {
            //variavel result recebe o retorno do delgate>>d1
            var result = 0;

            // cria-se objeto calculos para acesso dos metodos
            var a = new Calculos();
            // cria-se objeto do tipo op para acesso do delegate
            op d1 = new op(a.Soma);
            op d2 = new op (a.Sub);

            result = d1(5,3);
            result = d2(7,3);

            //result deve retornar dois valores diferentes
            // valor 8
            //valor 4



            
        }
    }
}
