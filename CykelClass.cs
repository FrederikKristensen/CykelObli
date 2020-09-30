using System;

namespace CykelObli
{
    public class CykelClass
    {
        public class Cykel
        {
            private int _id;
            private string _farver;
            private int _pris;
            private int _gear;


            public Cykel(int id, string farver, int pris, int gear)
            {
                Id = id;
                Farver = farver;
                Pris = pris;
                Gear = gear;
            }

            public int Id
            {
                get => _id;
                set
                {
                    if (value == null) throw new ArgumentNullException("Id", "Remeber to enter Id!");
                    if (Id.GetType() != value.GetType()) throw new ArgumentException("Id have to be a int!");
                    _id = value;
                }
            }

            public string Farver
            {
                get => _farver;
                set
                {
                    if (value == null) throw new ArgumentNullException("Farver", "Remeber to enter Farver!");
                    else
                    {
                        if (typeof(string) != value.GetType())
                        {
                            throw  new ArgumentException("Farver have to be a string!");
                        }
                    };
                    if (value.Length < 1) throw new ArgumentOutOfRangeException("Farver is too short!");
                    _farver = value;
                }
            }

            public int Pris
            {
                get => _pris;
                set
                {
                    if (value == null) throw new ArgumentNullException("Pris", "Remeber to enter pris!");
                    if (_pris.GetType() != value.GetType()) throw new ArgumentException("Pris have to be a int!");
                    if (value < 0) throw new ArgumentOutOfRangeException("Pris have to be above 0!");
                    _pris = value;
                }
            }

            public int Gear
            {
                get => _gear;
                set
                {
                    if (3 <= value && value <= 32 && value != null)
                    {
                        _gear = value;
                    }
                    else
                    {
                        throw new Exception("Plz enter a valid Gear");
                    }

                }
            }


            
        }
    }
}
