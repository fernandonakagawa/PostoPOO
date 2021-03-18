using System;
using System.Collections.Generic;
using System.Text;

namespace PostoPOO
{
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
    public class BombaCombustivel
    {
        private int _numero;
        private TipoCombustivel _tipo;
        private float _capacidade;

        public int Numero { get => _numero; private set => _numero = value; }
        public TipoCombustivel Tipo { get => _tipo; private set => _tipo = value; }
        public float Capacidade { get => _capacidade; set => _capacidade = value; }

        public BombaCombustivel(int numero, TipoCombustivel tipo, float capacidade)
        {
            Numero = numero;
            Tipo = tipo;
            Capacidade = capacidade;
        }

        public Abastecimento Abastecer(float quantidade, float preco)
        {
            if (quantidade > Capacidade) quantidade = Capacidade;
            Capacidade -= quantidade;
            Abastecimento abastecimento = new Abastecimento(this, quantidade, preco);
            return abastecimento;
        }
    }
}
