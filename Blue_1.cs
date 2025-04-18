using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_7
{
    public class Blue_1
    {
        public class Response
        {
            private string _name;
            protected int _votes;

            public string Name { get { return _name; } }
            public int Votes => _votes;

            public Response(string name)
            {
                _name = name;
                _votes = 0;
            }
            public virtual int CountVotes(Response[] responses)
            {
                if (responses == null)  return 0; 
                _votes = 0;
                for (int i = 0; i < responses.Length; i++)
                {
                    if ((responses[i].Name == _name))
                    {
                        _votes++;
                    }
                }
                return _votes;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Name: {_name} , Votes: {_votes}");
            }
        }
        public class HumanResponse : Response
        {
            private string _surname;
            public string Surname { get { return _surname; } }

            public HumanResponse(string name, string surname) : base (name)
            {
                _surname = surname;
            }
            public override int CountVotes(Response[] responses)
            {
                if (responses == null) return 0;
                int nv = 0;
                for (int i = 0; i < responses.Length; i++)
                {
                    var humanResponse = responses[i] as HumanResponse;
                    if (humanResponse == null)
                    {
                        _votes = nv;
                        return _votes;
                    }
                    if ((humanResponse.Name == Name) && (humanResponse.Surname == Surname)) { nv++; }
                }
                _votes = nv;
                return _votes;
            }
            public override void Print()
            {
                Console.WriteLine($"Name: {Name} {Surname} , Votes: {Votes}");
            }

        }


    }
}
