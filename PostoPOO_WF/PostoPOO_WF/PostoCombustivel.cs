using System;
using System.Collections.Generic;
using System.Text;

namespace PostoPOO
{
    public class PostoCombustivel
    {
        private string _nome;
        private List<BombaCombustivel> _bombas;
        private List<Abastecimento> _abastecimentos;
        private float _precoGasolina;
        private float _precoEtanol;

        public string Nome { get => _nome; private set => _nome = value; }
        public List<BombaCombustivel> Bombas { get => _bombas; private set => _bombas = value; }
        public List<Abastecimento> Abastecimentos { get => _abastecimentos; private set => _abastecimentos = value; }
        public float PrecoGasolina { get => _precoGasolina; 
            set
            {
                if (value < 0) value = 0;
                _precoGasolina = value;
            }
        }
        public float PrecoEtanol { get => _precoEtanol;
            set
            {
                if (value < 0) value = 0;
                _precoEtanol = value; 
            } 
        }

        public PostoCombustivel(string nome, TipoCombustivel[] tiposBombas, 
            float precoGasolina, float precoEtanol)
        {
            Nome = nome;
            int num = 1;
            Bombas = new List<BombaCombustivel>(); 
            foreach(TipoCombustivel tipo in tiposBombas)
            {
                BombaCombustivel b = new BombaCombustivel(num++, tipo, 100f);
                Bombas.Add(b);
            }
            Abastecimentos = new List<Abastecimento>();
            PrecoGasolina = precoGasolina;
            PrecoEtanol = precoEtanol;
        }

        public PostoCombustivel(string nome, List<BombaCombustivel> bombas,
            float precoGasolina, float precoEtanol)
        {
            Nome = nome;
            Bombas = bombas;
            Abastecimentos = new List<Abastecimento>();
            PrecoGasolina = precoGasolina;
            PrecoEtanol = precoEtanol;
        }

        public Abastecimento Abastecer(float quantidade, int numeroBomba)
        {
            //buscar a bomba pelo seu número
            BombaCombustivel bomba = null ;
            foreach(BombaCombustivel b in Bombas)
            {
                if (b.Numero == numeroBomba) bomba = b;
            }
            if (bomba != null) 
            {
                //buscar o tipo de combustível para saber o preço
                float preco = 0;
                switch (bomba.Tipo)
                {
                    case TipoCombustivel.Gasolina:
                        preco = PrecoGasolina;
                        break;
                    case TipoCombustivel.Etanol:
                        preco = PrecoEtanol;
                        break;
                }
                Abastecimento abastecimento = bomba.Abastecer(quantidade, preco);
                Abastecimentos.Add(abastecimento);
                return abastecimento;
            }
            else
            {
                throw new Exception("Bomba não encontrada pelo número!");
            }
        }

        public Dictionary<TipoCombustivel,float> GerarRelatorio()
        {
            Dictionary<TipoCombustivel, float> precos = new Dictionary<TipoCombustivel, float>();
            precos.Add(TipoCombustivel.Gasolina, 0f);
            precos.Add(TipoCombustivel.Etanol, 0f);

            foreach(Abastecimento a in Abastecimentos)
            {
                if (a.IsPago)
                {
                    TipoCombustivel tipo = a.Bomba.Tipo;
                    float valor = a.Valor;
                    precos[tipo] += valor;
                }
            }
            return precos;
        }
    }
}
