using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3claseElemental
{
    internal class cuenta
    {
        ulong CBU;
        string cliente;
        float saldo;

        // CONSTRUCTORES
        public cuenta(ulong CBU, string cliente, float saldo)
        {
            this.CBU = CBU;
            this.cliente = cliente;
            this.saldo = saldo;
        }

        public cuenta(ulong CBU, string cliente)
        {
            this.CBU = CBU;
            this.cliente = cliente;
            this.saldo = 0;
        }

        public cuenta()
        {
            this.CBU = 0;
            this.cliente = "";
            this.saldo = 0;
        }


        // SETTERS
        public void setCBU(ulong CBU)
        {
            if (CBU >= 100 && CBU < 1000000 )
            {
                this.CBU = CBU;
            }
            else
            {
                this.CBU = 0;
            }
        }

        public void setCliente(string nombre)
        {
            cliente = nombre;
        }

        public void setSaldo()
        {
            this.saldo = saldo;
        }

        // GETTERS
        
        public ulong getCBU()
        {
            return this.CBU;
        }

        public string getCliente()
        {
            return this.cliente;
        }

        public float getSaldo()
        {
            return this.saldo;
        }


        // FUNCIONALIDADES
        public bool depositar(float saldoRecibido)
        {
            if (saldoRecibido < 0)
            {
                return false;
            }
            else
            {
                this.saldo += saldoRecibido;
            }
            return true;            
        }

        public bool extraer(float saldoExtraible)
        {
            if (saldo < saldoExtraible)
            {
                return false;
            }
            else
            {
                this.saldo -= saldoExtraible;
            }
            return true;
        }

        public string darDatos()
        {
            return "Nombre: " + this.cliente + ", CBU: " + this.CBU + ", Saldo en cuenta: " + this.saldo.ToString();
        }

    }



}
