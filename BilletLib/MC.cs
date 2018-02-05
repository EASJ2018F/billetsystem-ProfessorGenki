using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    class MC : Base
    {
        private string _nummerplade;
        private DateTime _dato;
        private bool _brobizz;
        private bool _øresund;

        public string Nummerplade { get { return _nummerplade; } }
        public DateTime Dato { get { return _dato; } }
        public bool Brobizz { get { return _brobizz; } }
        public bool Øresund { get { return _øresund; } }
        
        public MC(string nummerplade, DateTime dato, bool brobizz, bool øresund)
        {
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerpladen kan ikke være længere end 7 tegn");
            }
            _nummerplade = nummerplade;
            _dato = dato;
            _brobizz = brobizz;
            _øresund = øresund;
        }

        public override string Vehicles()
        {
            if (_øresund == true)
            {
                return "Øresund MC";
            }
            return "MC";
        }

        public override int Pris()
        {
            int femprocentRabat = 5 * Convert.ToInt32(2.4);
            int result = 125;
            int result2 = 210;

            if (_brobizz == true)
            {
                result = result - femprocentRabat;
            }

            if (_øresund)
            {
                result = result2;
            }

            if (_øresund == true && _brobizz == true)
            {
                result = 73;
            }

            return result;
        }
    }
}
