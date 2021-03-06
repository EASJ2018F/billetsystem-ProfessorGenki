﻿using System;

namespace BilletLib
{
    public class Bil : Base
    {
        private string _nummerplade;
        private DateTime _dato;
        private bool _brobizz;
        private bool _øresund;
        
        public string Nummerplade { get { return _nummerplade; } }
        public DateTime Dato { get { return _dato; } }
        public bool Brobizz { get { return _brobizz; } }
        public bool Øresund { get { return _øresund; } }

        public Bil(string nummerplade, DateTime dato, bool brobizz, bool øresund)
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
                return "Øresund Bil";
            }
            return "Bil";
        }

        public override int Pris()
        {

            int result = 240;
            int result2 = 410;

            if (_dato.DayOfWeek == DayOfWeek.Saturday || _dato.DayOfWeek == DayOfWeek.Sunday)
            {
                result = (int)(result * 0.8);
            }

            if (_brobizz == true)
            {
                result = (int)(result * 0.95);
            }

            if (_øresund == true)
            {
                result = result2;
            }

            if (_øresund && _brobizz == true)
            {
                result = 161;
            }
            return result;
        }
    }
}
