using System;
using System.Collections.Generic;
using System.Text;

namespace CalculScrutin
{
    public class Candidate
    {
        public Candidate()
        {
        }

        public Candidate(string name)
        {
            Name = name;
            NbVotes = 0;
        }

        public string Name { get; set; }
        public int NbVotes { get; set; }
    }
}
