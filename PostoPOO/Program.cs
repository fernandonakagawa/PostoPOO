using System;
using System.Collections.Generic;
using System.Linq;

namespace PostoPOO
{
    class Program
    {
        

        static void Main(string[] args)
        {
            PostoCombustivel posto1;
            Abastecimento abastecimento1;

            TipoCombustivel[] tiposBombas =
            {
                TipoCombustivel.Gasolina,
                TipoCombustivel.Etanol,
                TipoCombustivel.Gasolina,
                TipoCombustivel.Etanol,
            };
            posto1 = new PostoCombustivel("Posto Quack", tiposBombas, 5.60f, 4.09f);
            MostrarStatusBombas(posto1);

            abastecimento1 = posto1.Abastecer(40, 1);
            Abastecimento a2 = posto1.Abastecer(20, 1);
            Abastecimento a3 = posto1.Abastecer(60, 2);
            Abastecimento a4 = posto1.Abastecer(100, 1);
            abastecimento1.MarcarPago(true);
            a2.MarcarPago(true);
            a3.MarcarPago(true);
            a4.MarcarPago(true);
            MostrarStatusBombas(posto1);

            MudarPreco(posto1);
            MostrarRelatorio(posto1);

            Abastecimento a5 = posto1.Abastecer(34, 3);
            Abastecimento a6 = posto1.Abastecer(42.3f, 4);
            Abastecimento a7 = posto1.Abastecer(37.9f, 4);
            a5.MarcarPago(true);
            a6.MarcarPago(true);
            a7.MarcarPago(true);
            MostrarStatusBombas(posto1);
            MostrarRelatorio(posto1);
        }

        static void MostrarStatusBombas(PostoCombustivel posto)
        {
            Console.WriteLine($"Status das Bombas do posto {posto.Nome}");
            foreach (BombaCombustivel b in posto.Bombas)
            {
                Console.WriteLine($"Bomba {b.Numero} de {b.Tipo}: capacidade: {b.Capacidade}");
            }
            Console.WriteLine();
        }

        static void MudarPreco(PostoCombustivel posto)
        {
            TipoCombustivel tipo;
            float preco;
            int comando = -1;
            do
            {
                Console.WriteLine("Digite 0 para mudar o preco da gasolina e 1 para etanol:");
                comando = int.Parse(Console.ReadLine());
            } while (comando != 0 && comando != 1);
            if (comando == 0) tipo = TipoCombustivel.Gasolina;
            else tipo = TipoCombustivel.Etanol;

            Console.WriteLine($"Digite o novo valor do combustível {tipo}:");
            preco = float.Parse(Console.ReadLine());
            if (tipo == TipoCombustivel.Gasolina) posto.PrecoGasolina = preco;
            else if (tipo == TipoCombustivel.Etanol) posto.PrecoEtanol = preco;
        }

        static void MostrarRelatorio(PostoCombustivel posto)
        {
            Console.WriteLine($"Relatório de vendas do posto {posto.Nome}");
            Dictionary<TipoCombustivel, float> valores = posto.GerarRelatorio();
            for (int i = 0; i < valores.Count; i++)
            {
                Console.WriteLine($"{valores.ElementAt(i).Key}: R${valores.ElementAt(i).Value}");
            }
            Console.WriteLine();
        }
    }
}
