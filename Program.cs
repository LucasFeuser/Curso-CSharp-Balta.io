using System; //Necessario para utilizar o Writeline.

namespace dev
{

    class Program
    {
        //void = vazio, sem retorno, não é bosta nenhuma.
        static void Main(String[] args)
        {

            /* 
            //Char

            //Cada char ocupa 16-bits
            char primeiraLetra = 'D'; //Sempre definir com aspas '' simples.
            var segundaLetra = 'C';

            Console.WriteLine(primeiraLetra);
            Console.WriteLine(segundaLetra);
            Console.WriteLine(primeiraLetra / segundaLetra);
            Console.WriteLine(segundaLetra / primeiraLetra);
            Console.WriteLine(primeiraLetra * segundaLetra);
            Console.WriteLine(primeiraLetra + segundaLetra);
            Console.WriteLine(primeiraLetra - segundaLetra);
            
            //String

            string primeiraLetra = "C"; //Sempre utilizar aspas duplas.]
            string meuNome = "Lucas";
            var docuemento = "15453474";
            */

            //Objects
            // object quantidade; //Object pode ser definido qualquer coisa.

            /* 
            //NULLS   
            int? idade = null; //Sempre marcar com interrogação, para marcar o valor nulo.
            Console.WriteLine(idade);
            idade = 20;
            Console.WriteLine(idade);
            */

            //Alias

            /*Valores Padrões
               Todo tipo built-in possui valor padrão.
               Se nenhum valor for definido, será então:
               int => 0
               float => 0
               decimal => 0
               bool => false
               char => '\0'
               String => "";

            */

            //Implicita =  Esconde o tipo

            //Parse: Numeros acompanham a extensão chamada .Parse: Converte o tipo, no caso do Parse, sempre espera uma string.

            /*
                Transcrevendo uma string para um tipo;    
            int rinteiro = int.Parse("100");
            Console.WriteLine(rinteiro);

            Convert: um objeto que permite converter um tipo para o outro;
            Permite converter varios tipos;

            int intero = Convert.ToInt32("100");
            Console.WriteLine(intero);
            */

            /* 
            Convertendo tipos
            
            int inteiro = 100;
            float real = 25.5f; //f = declaração de ponto flutuante;

            real = inteiro; //Passando o numero real para inteiro; Conversão implicita;
            inteiro = (int)real; //() declara conversão explicita;

            string valorReal = real.ToString();
            inteiro = int.Parse(real.ToString()); //Todo objeto pode ser convertido para String
            inteiro = Convert.ToInt32(real);

            Console.WriteLine(valorReal);
            Console.WriteLine(inteiro);
            Console.WriteLine(real);
            Console.WriteLine(Convert.ToBoolean(1));
            */

            /*
            Operadores Aritméticos
            Numeros inteiros tem arredondamento
            Operadores de atribuição
             += : Soma, -=: Subtrai, *= Multiplica e /=: Divisão, ++ e --;
            */

            //Operadores de Comparação
            //Numeros, Strings, Arrays de bytes, etc...
            //Comparação sempre retorna Boolean.
            // ==: Igual, !=: Diferente, >: Maior que, <: Menor que, >=: Maior igual a, <=: Menor igual que;

            /*Utilizando operadores

            int w = 22;
            int x = 2;
            int z = 3;
            int y = 4;

            x += 3;
            z -= 1;
            y *= 20;
            w /= 12;
            Console.WriteLine(x + " " + z + " " + y + " " + w);
            */

            //Operações Lógicas
            //E: && = And, OR: || = Or e Negação: ! = Not;

            /*Estruturas Condicionais: Switch;
            var name = "Lucas Foda";
            switch (name)
            {
                case "Joao": Console.WriteLine("Não é esse maldito"); break;
                case "Lucas Foda": Console.WriteLine("Messi messi messi messi messi, Aakara messi."); break;
                case "Messi": Console.WriteLine("Não é esse maldito"); break;
                default: Console.WriteLine("Seu lixooo"); break;
            }
            */

            /* Utilizando For
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /* Metodo
            MeuMetodo(); //Sempre começando o metado com maiuscula. 

            string nome = MyName("Lucas", "Fodao", 23 + 1);
            Console.WriteLine(nome);
        }
        static void MeuMetodo()
        {
            Console.WriteLine("C# is cool!");
        }
        static string MyName(
            string nome,
            string sobrenome,
            int idade = 24, //Sempre por ultimo o opcional.
            double salario = 1.500f,
            Boolean gender = false
            )
        {
                       return nome + " " + sobrenome + " tem " + idade.ToString() + " " + salario + " " + gender;
        */
            //Structs = Value Type != do Refecence Types


            Product mouse = new Product(1, "Mouse gamer", 299.97);

            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product //Fica fora de Class, pois compete com a mesma.
    {
        public Product(int id, string name, double price)//Constructor
        {
            Id = id; //Case sensitive, os ids definidos são diferentes;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name; //Criar Property iniciando sempre com maiusculo;
        public double Price;
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}