using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_7.Blue_4;
using static Lab_7.Blue_5;

namespace Lab_7
{
    public class Blue_4
    {
        public abstract class Team
        {
            private string _Name;
            private int[] _Scores;

            public string Name { get { return _Name; } }
            public int[] Scores
            {
                get
                {
                    if (_Scores == null) return null;
                    int[] Nscores = new int[_Scores.Length];
                    for (int i = 0; i < Nscores.Length; i++)
                    {
                        Nscores[i] = _Scores[i];
                    }
                    return Nscores;
                }
            }

            public Team(string name)
            {
                _Name = name;
                _Scores = new int[0];
            }

            public int TotalScore
            {
                get
                {
                    if (_Scores == null) return 0;
                    int ts = 0;
                    for (int i = 0; i < _Scores.Length; i++)
                    {
                        ts += _Scores[i];
                    }
                    return ts;
                }
            }

            public void PlayMatch(int result)
            {
                if (_Scores == null) return;
                int[] NScores = new int[_Scores.Length + 1];
                for (int i = 0; i < _Scores.Length; i++)
                {
                    NScores[i] = _Scores[i];
                }
                NScores[NScores.Length - 1] = result;
                _Scores = NScores;
            }

            public void Print()
            {
                Console.WriteLine($"{Name}: {TotalScore}");
            }

        }
        public class ManTeam : Team
        {
            public ManTeam(string name) : base(name)
            {
            }
        }
        public class WomanTeam : Team
        {
            public WomanTeam(string name) : base(name)
            {
            }

        }
        public class Group
        {
            private string _name;
            private ManTeam[] _manteams;
            private WomanTeam[] _womanteams;

            private int _qmanteams;
            private int _qwomanteams;

            public string Name { get { return _name; } }
            public Team[] ManTeams {  get { return _manteams; } }
            public Team[] WomanTeams {  get  { return _womanteams; } }
            public Group(string name)
            {
                _name = name;
                _manteams = new ManTeam[12];
                _womanteams = new WomanTeam[12];
                _qmanteams = 0;
                _qwomanteams = 0;
            }
            public void Add(Team nteam)
            {
                if (nteam is ManTeam manteam)
                {
                    if (_qmanteams >= 12 || _manteams == null) return;
                    _manteams[_qmanteams++] = manteam;
                }
                else if (nteam is WomanTeam womanteam)
                {
                    if (_qwomanteams >= 12 || _womanteams == null) return;
                    _womanteams[_qwomanteams++] = womanteam;
                }
            }
            public void Add(Team[] teams)
            {
                if (teams == null) return;

                for (int i = 0; i < teams.Length; i++)
                {
                    Add(teams[i]);
                }
            }
            private static Team[] Sortirovochka(Team[] presortedteams)
            {
                Team[] sortedteams = new Team[presortedteams.Length];
                if (sortedteams == null) return null;
                for (int i = 0 ; i < presortedteams.Length; i++)
                {
                    sortedteams[i] = presortedteams[i];
                }
                for (int i = 0; i < sortedteams.Length; i++)
                {
                    for (int j = 0; j < sortedteams.Length - i - 1; j++)
                    {
                        if (sortedteams[j].TotalScore < sortedteams[j + 1].TotalScore)
                        {
                            Team tempteam = sortedteams[j];
                            sortedteams[j] = sortedteams[j + 1];
                            sortedteams[j + 1] = tempteam;
                        }
                    }
                }
                return sortedteams;
            }
            public void SortManWoman(Team[] _teams)
            {
                if (_teams == null) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j + 1].TotalScore)
                        {
                            Team tempteam = _teams[j];
                            _teams[j] = _teams[j + 1];
                            _teams[j + 1] = tempteam;
                        }
                    }
                }
            }
            public void Sort()
            {
                SortManWoman(_manteams);
                SortManWoman(_womanteams);
            }
            public static Team[] Mergeteam(Team[] teams1, Team[] teams2, int size)
            {
                if (teams1 == null || teams2 == null) return null;
                Team[] nteams = new Team[size];
                teams1 = Sortirovochka(teams1);
                teams2 = Sortirovochka(teams2);
                int j = 0;
                for (int i = 0; i < size/2; i++)
                {
                    nteams[j] = teams1[i];
                    j++;
                }
                for (int i = 0; i < size / 2; i++)
                {
                    nteams[j] = teams2[i];
                    j++;
                }
                nteams = Sortirovochka(nteams);
                return nteams;

            }
            public static Group Merge(Group group1, Group group2, int size)
            {
                Group finalteam = new Group("Финалисты");
                finalteam.Add(Mergeteam(group1._manteams, group2._manteams, size));
                finalteam.Add(Mergeteam(group1._womanteams, group2._womanteams, size));
                return finalteam;
            }
            //public static Group Merge(Group group1, Group group2, int size)
            //{
            //    Group ngroup = new Group("Финалисты");


            //    if (size != 12) return ngroup;
            //    group1.Sort();
            //    group2.Sort();


            //    for (int i = 0; i < size / 2; i++)
            //    {
            //        ngroup.Add(group1.Teams[i]);
            //    }

            //    for (int i = 0; i < size / 2; i++)
            //    {
            //        ngroup.Add(group2.Teams[i]);
            //    }
            //    ngroup.Sort();
            //    return ngroup;
            //}

            public void Print(Team[] _teams)
            {
                Console.WriteLine($"{Name} {_teams}");
            }

        }
    }
}
