using System;
using System.Collections.Generic;
using System.Text;

namespace PostoPOO
{
    class Abastecimento
    {
        private BombaCombustivel _bomba;
        private float _quantidade;
        private float _preco;
        private bool _isPago;

        public BombaCombustivel Bomba { get => _bomba; private set => _bomba = value; }
        public float Quantidade { get => _quantidade; 
            set 
            {
                _quantidade = value;
                if (value < 0) _quantidade = 0; 
            } 
        }
        public float Preco { get => _preco; private set => _preco = value; }
        public bool IsPago { get => _isPago; private set => _isPago = value; }
        public float Valor { get => Quantidade * Preco; }

        public Abastecimento(BombaCombustivel bomba, float quantidade, float preco)
        {
            Bomba = bomba;
            Quantidade = quantidade;
            Preco = preco;
            IsPago = false;
        }
        public void MarcarPago(bool pago)
        {
            IsPago = pago;
        }
    }
}
