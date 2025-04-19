using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Blue_3
    {
        public class Participant
        {
            private string _Name;
            private string _Surname;
            protected int[] _penalties;
            protected bool _is_expelled;

            public string Name { get { return _Name; } }
            public string Surname { get { return _Surname; } }

            public int[] Penalties
            {
                get
                {
                    if (_penalties == null) return null;
                    int[] NPenaltyTimes = new int[_penalties.Length];
                    for (int i = 0; i < _penalties.Length; i++)
                    {
                        NPenaltyTimes[i] = _penalties[i];
                    }
                    return NPenaltyTimes;

                }
            }
            public int Total
            {
                get
                {
                    if (_penalties == null) return 0;
                    int total = 0;
                    for (int i = 0; i < _penalties.Length; i++)
                    {
                        total += _penalties[i];
                    }
                    return total;

                }
            }

            public Participant(string Name1, string Surname1)
            {
                _Name = Name1;
                _Surname = Surname1;
                _penalties = new int[0];
                _is_expelled = false;
            }



            public virtual bool IsExpelled
            {
                get
                {
                    if (_penalties == null || _penalties.Length == 0) return false;
                    bool expelled = false;
                    for (int i = 0; i < _penalties.Length; i++)
                    {
                        if (_penalties[i] == 10)
                        {
                            expelled = true;
                            return expelled;
                        }
                    }
                    return expelled;
                }
            }
            public virtual void PlayMatch(int time)
            {
                if (_penalties == null) return;
                int[] newPenalties = new int[_penalties.Length + 1];
                for (int i = 0; i < _penalties.Length; i++)
                {
                    newPenalties[i] = _penalties[i];
                }
                _penalties = newPenalties;
                _penalties[_penalties.Length - 1] = time;
            }

            public static void Sort(Participant[] array)
            {
                if (array.Length < 0) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].Total > array[j + 1].Total)
                        {
                            Participant temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{_Name} {_Surname} : {Total} {IsExpelled}");
                for (int i = 0; i < _penalties.Length; i++)
                {
                    Console.WriteLine(_penalties[i]);
                }
                Console.WriteLine();
            }
        }
        public class BasketballPlayer : Participant
        {
           
            public BasketballPlayer(string name, string surname) : base(name, surname)
            {
                _penalties = new int[0];
            }
            public override void PlayMatch(int time)
            {
                if (_penalties == null || time < 0 || time > 5) return;
                base.PlayMatch(time);
            }
            public override bool IsExpelled
            {
                get
                {
                    if (_penalties == null || _penalties.Length == 0) return false;
                    int foul5matches = 0;
                    for (int i = 0; i < _penalties.Length; i++)
                    {
                        if (_penalties[i] == 5) foul5matches++;
                    }
                    if (Total > 2 * _penalties.Length || foul5matches > 0.1 * _penalties.Length)
                    {
                        return true;
                    }
                    return false;
                }

            }

        }

        public class HockeyPlayer : Participant
        {
            private static int _timesum = 0;
            private static int _qplayers = 0;

            public HockeyPlayer(string name, string surname) : base(name, surname)
            {
                _penalties = new int[0];
                _qplayers++;
                _is_expelled = false;
                
            }

            
            public override void PlayMatch(int time)
            {
                if (_penalties == null) return;
                base.PlayMatch(time);
                _timesum += time;
            }

            public override bool IsExpelled
            {
                get
                {
                    if (_penalties == null) return false;
                    for (int i = 0; i < _penalties.Length; i++)
                    {
                        if (_penalties[i] == 10)
                        {
                            
                            _is_expelled = true;
                        }
                    }
                    if (Total > 0.1 * _timesum / _qplayers) _is_expelled = true;
                    return _is_expelled;

                }
            }
        }
    }
}

