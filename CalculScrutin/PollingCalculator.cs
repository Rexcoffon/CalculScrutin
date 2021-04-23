using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculScrutin
{
    public class PollingCalculator
    {
        public PollingCalculator()
        {
            Candidates = new List<Candidate>();
            Votes = new List<string>();
            SecondRound = false;
        }

        private List<Candidate> Candidates { get; set; }
        private List<string> Votes { get; set; }

        private bool SecondRound { get; set; }

        public void AddCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }

        public void AddVote(string vote)
        {
            Votes.Add(vote);
        }

        public Candidate CalculatePolling(out List<Candidate> candidates)
        {
            foreach (var vote in Votes.GroupBy(v => v))
            {
                if(vote.Key != "")
                {
                    Candidates.Where(c => c.Name == vote.Key).Select(v => { v.NbVotes = vote.Count(); return v; }).ToList();
                }                
            }

            Candidate result = null;
            if (!SecondRound)
            {
                result = Candidates.Find(c => c.NbVotes >= Votes.Count * 0.5);
            }
            else
            {
                result = Candidates.Aggregate((i1, i2) => i1.NbVotes > i2.NbVotes ? i1 : i1.NbVotes != i2.NbVotes? i2 : null);                
            }

            candidates = Candidates;
            return result;
        }

        public void SetPollToSecondRound()
        {
            SecondRound = true;
        }
    }
}
