using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] names = new string[] { "Татьяна", "Никита", "Мирослав", "Артем", "Алевтина", "Максим", "Марина", "Григорий", "Екатерина", "Оксана", "Марина", "Инесса", "Алиса", "Влада", "Дарья", "Сергей", "Степан", "Ольга", "Михаил", "Григорий", "Инесса", "Юрий", "Григорий", "Игорь", "Ольга", "Юрий", "Татьяна", "Михаил", "Дарья" };
            string[] surnames = new string[] { "Степанова", "Жарков", "Петров", "Тихонов", "Тихонова", "Степанов", "Батова", "Сидоров", "Чехова", "Кристиан", "Пономарева", "Смирнова", "Распутина", "Степанова", "Пономарева", "Тихонов", "Иванов", "Зайцева", "Иванов", "Ушаков", "Лисицына", "Иванов", "Козлов", "Петров", "Тихонова", "Иванов", "Чехова", "Свиридов", "Павлова" };
            Blue_1.Response[] Rname = new Blue_1.Response[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                Rname[i] = new Blue_1.HumanResponse(names[i], surnames[i]);

            }
            for (int i = 0; i < names.Length; i++)
            {
                Rname[i].CountVotes(Rname);
                Rname[i].Print();
            }

            //2
            //string[] names = new string[] { "Александр", "Артем", "Мария", "Игорь", "Николай", "Инесса", "Марина", "Александр", "Сергей", "Александра" };
            //string[] surnames = new string[] { "Петров", "Луговой", "Свиридова", "Смирнов", "Зайцев", "Кристиан", "Свиридова", "Петров", "Батов", "Сидорова" };

            //int[][] firstJump = new int[][]
            //{
            //    new int[] { 11, 0, 8, 7, 12 },
            //    new int[] { 18, 17, 20, 7, 11 },
            //    new int[] { 17, 13, 2, 19, 2 },
            //    new int[] { 15, 7, 14, 19, 15 },
            //    new int[] { 20, 5, 4, 3, 0 },
            //    new int[] { 5, 17, 20, 2, 11 },
            //    new int[] { 18, 1, 10, 5, 20 },
            //    new int[] { 2, 17, 5, 11, 3 },
            //    new int[] { 2, 0, 5, 18, 20 },
            //    new int[] { 12, 2, 17, 5, 7 }
            //};
            //int[][] secondJump = new int[][]
            //{
            //    new int[] { 2, 3, 10, 13, 16 },
            //    new int[] { 3, 7, 12, 19, 2 },
            //    new int[] { 10, 0, 0, 6, 5 },
            //    new int[] { 5, 13, 16, 18, 16 },
            //    new int[] { 18, 4, 12, 18, 7 },
            //    new int[] { 10, 18, 9, 7, 12 },
            //    new int[] { 19, 1, 5, 1, 18 },
            //    new int[] { 7, 18, 3, 5, 3 },
            //    new int[] { 3, 12, 4, 2, 10 },
            //    new int[] { 5, 15, 15, 5, 11 }
            //};

            //Blue_2.Participant[] participants = new Blue_2.Participant[names.Length];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    participants[i] = new Blue_2.Participant(names[i], surnames[i]);
            //    participants[i].Jump(firstJump[i]);
            //    participants[i].Jump(secondJump[i]);
            //}
            //Blue_2.Participant.Sort(participants);
            //foreach (var participant in participants)
            //{
            //    participant.Print();
            //}


            //3
            //string[] names = new string[]{ "Инна", "Юрий", "Дмитрий", "Иван", "Татьяна", "Александра", "Дарья", "Мирослав", "Юлия", "Дарья" };
            //string[] surnames = new string[] { "Пономарева", "Ушаков", "Иванов", "Кристиан", "Ушакова", "Козлова", "Павлова", "Лисицын", "Чехова", "Лисицына" };
            //int[][] penaltyTimes = new int[10][]
            //{
            //    new int[] { 2, 2, 0, 2, 0, 0, 0, 5, 2, 5 },       
            //    new int[] { 0, 10, 10, 0, 5, 5, 2, 10, 10, 10 }, 
            //    new int[] { 2, 5, 5, 2, 0, 10, 5, 2, 0, 0 },
            //    new int[] { 2, 10, 2, 5, 2, 2, 10, 10, 5, 0 },
            //    new int[] { 5, 2, 0, 10, 10, 2, 10, 5, 0, 2 },
            //    new int[] { 5, 2, 5, 0, 0, 10, 5, 5, 2, 10 },
            //    new int[] { 0, 2, 0, 2, 5, 5, 5, 5, 2, 5 },
            //    new int[] { 0, 2, 2, 10, 10, 2, 5, 2, 5, 0 },
            //    new int[] { 0, 10, 5, 10, 5, 5, 5, 2, 5, 2 },
            //    new int[] { 5, 2, 5, 0, 10, 10, 0, 0, 0, 2 }
            //};
            //Blue_3.Participant[] participants = new Blue_3.Participant[names.Length];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    participants[i] = new Blue_3.Participant(names[i], surnames[i]);
            //    for (int j = 0; j < penaltyTimes[i].Length; j++)
            //    {
            //        participants[i].PlayMatch(penaltyTimes[i][j]);
            //    }
            //}
            //Blue_3.Participant.Sort(participants);
            //foreach (var participant in participants)
            //{
            //    participant.Print();
            //}

            //4
            //string[] teamsA = { "энергия", "спартак", "барс", "нефтехим", "байкал", "василек", "урал", "быки", "метеор", "быки", "цска", "русь" };
            //int[][] scoresA = new int[][]
            //{
            //    new int[] { 1, 0, 0, 0, 3, 0, 1, 0, 1, 3, 0, 0 },
            //    new int[] { 0, 0, 1, 3, 3, 1, 0, 3, 0, 3, 1, 3, 3, 0, 1, 1, 1, 1, 0, 1 },
            //    new int[] { 0, 3, 0, 0, 3, 1, 0, 1, 0, 3, 0, 0, 3, 1, 1, 3, 0, 1, 0, 0 },
            //    new int[] { 3, 1, 1, 0, 1, 0, 1, 3, 1, 3, 1, 0, 1, 1, 0, 1, 3, 3, 3, 0 },
            //    new int[] { 1, 0, 1, 0, 0, 1, 3, 1, 3, 3, 3, 1, 3, 3, 0, 1, 0, 0, 0, 0 },
            //    new int[] { 1, 3, 3, 3, 3, 3, 1, 3, 3, 0, 1, 3, 3, 0, 1, 0, 0, 3, 0, 3 },
            //    new int[] { 0, 1, 3, 1, 1, 0, 0, 0, 3, 3, 1, 3, 3, 3, 0, 0, 3, 3, 3, 0 },
            //    new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 },
            //    new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 },
            //    new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 },
            //    new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 },
            //    new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }
            //};
            //string[] teamsB = { "Локомотив", "СКА", "Энергия", "Нефтехим", "Ак-барс", "Барс", "СПБ", "Быки", "Метеор", "Быки", "ЦСКА", "Русь" };
            //int[][] scoresB = new int[][]
            //{
            //    new int[] { 1, 1, 3, 0, 3, 0, 1, 0, 3, 3, 3, 3 },
            //    new int[] { 0, 0, 1, 0, 3, 1, 0, 3, 1, 3, 1, 3, 3, 1, 1, 1, 0, 3, 1, 1 },
            //    new int[] { 1, 1, 3, 3, 0, 0, 3, 3, 1, 0, 3, 0, 0, 1, 0, 3, 1, 1, 0, 1 },
            //    new int[] { 1, 3, 3, 1, 1, 3, 3, 1, 3, 3, 1, 1, 0, 3, 0, 3, 1, 3, 1, 1 },
            //    new int[] { 0, 3, 1, 1, 1, 0, 3, 1, 0, 3, 0, 0, 1, 3, 3, 1, 1, 3, 0, 0 },
            //    new int[] { 3, 1, 0, 0, 3, 1, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 3, 0, 3, 1 },
            //    new int[] { 0, 1, 1, 3, 0, 1, 3, 0, 3, 3, 0, 0, 0, 3, 3, 1, 1, 0, 3, 1 },
            //    new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 },
            //    new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 },
            //    new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 },
            //    new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 },
            //    new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }
            //};

            //Blue_4.Group groupA = new Blue_4.Group("Группа A");
            //Blue_4.Group groupB = new Blue_4.Group("Группа B");

            //for (int i = 0; i < teamsA.Length; i++)
            //{
            //    Blue_4.Team team = new Blue_4.Team(teamsA[i]);
            //    for (int j = 0; j < scoresA[i].Length; j++)
            //    {
            //        team.PlayMatch(scoresA[i][j]);
            //    }
            //    groupA.Add(team);

            //}
            //for (int i = 0; i < teamsB.Length; i++)
            //{
            //    Blue_4.Team team = new Blue_4.Team(teamsB[i]);
            //    for (int j = 0; j < scoresB[i].Length; j++)
            //    {
            //        team.PlayMatch(scoresB[i][j]);
            //    }
            //    groupB.Add(team);

            //}

            //groupA.Sort();
            //groupB.Sort();

            //groupA.Print();
            //groupB.Print();

            //Blue_4.Group finalGroup = Blue_4.Group.Merge(groupA, groupB, 6);

            //finalGroup.Print();

            //5
            //string[] Lnames = { "Мирослав", "Игорь", "Полина", "Савелий", "Николай", "Юлия" };
            //string[] Lsurnames = { "Распутин", "Павлов", "Свиридова", "Луговой", "Козлов", "Сидорова" };
            //int[] Lplaces = { 12, 2, 17, 13, 5, 6 };
            //string[] Dnames = { "Полина", "Светлана", "Александр", "Игорь", "Савелий", "Мария" };
            //string[] Dsurnames = { "Луговая", "Иванова", "Петров", "Распутин", "Свиридов", "Свиридова" };
            //int[] Dplaces = { 7, 8, 9, 10, 11, 1 };
            //string[] Snames = { "Дмитрий", "Светлана", "Екатерина", "Степан", "Степан", "Дарья" };
            //string[] Ssurnames = { "Свиридов", "Козлова", "Луговая", "Жарков", "Распутин", "Свиридова" };
            //int[] Splaces = { 4, 14, 15, 16, 3, 18 };

            //Blue_5.Team lokomotiv = new Blue_5.Team("Локомотив");
            //Blue_5.Team dinamo = new Blue_5.Team("Динамо");
            //Blue_5.Team spartak = new Blue_5.Team("Спартак");

            //for (int i = 0; i < Lnames.Length; i++)
            //{
            //    Blue_5.Sportsman sportsman = new Blue_5.Sportsman(Lnames[i], Lsurnames[i]);
            //    sportsman.SetPlace(Lplaces[i]);
            //    lokomotiv.Add(sportsman);
            //}

            //for (int i = 0; i < Dnames.Length; i++)
            //{
            //    Blue_5.Sportsman sportsman = new Blue_5.Sportsman(Dnames[i], Dsurnames[i]);
            //    sportsman.SetPlace(Dplaces[i]);
            //    dinamo.Add(sportsman);
            //}

            //for (int i = 0; i < Snames.Length; i++)
            //{
            //    Blue_5.Sportsman sportsman = new Blue_5.Sportsman(Snames[i], Ssurnames[i]);
            //    sportsman.SetPlace(Splaces[i]);
            //    spartak.Add(sportsman);
            //}

            //Blue_5.Team[] teams = { lokomotiv, dinamo, spartak };

            //Blue_5.Team.Sort(teams);

            //Console.WriteLine("Teams SummaryScore TopPlace");
            //foreach (var team in teams)
            //{
            //    team.Print();
            //}

        }
    }
}
