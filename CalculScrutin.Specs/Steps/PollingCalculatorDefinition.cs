using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculScrutin.Specs.Steps
{
    [Binding]
    public sealed class PollingCalculatorDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private PollingCalculator _pollingCalculator = null;

        private Candidate _Winner;
        private List<Candidate> _CandidatesResult;

        public PollingCalculatorDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"The following candidates")]
        public void GivenTheFollowingCandidates(Table table)
        {
            _pollingCalculator = new PollingCalculator();

            foreach (TableRow row in table.Rows)
            {
                _pollingCalculator.AddCandidate(new Candidate(row[0]));
            }
        }

        [Given(@"Add the votes")]
        public void GivenAddTheVotes(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                _pollingCalculator.AddVote(row[0]);
            }
        }

        [Given(@"Close the poll")]
        public void GivenCloseThePoll()
        {

        }

        [Given(@"Set the for a second round")]
        public void GivenSetTheForASecondRound()
        {
            _pollingCalculator.SetPollToSecondRound();
        }


        [When(@"Calculate the polling")]
        public void WhenCalculateThePolling()
        {
            _Winner = _pollingCalculator.CalculatePolling(out _CandidatesResult);
        }

        [Then(@"The result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string result)
        {
            _Winner.Name.Should().Be(result);
        }

        [Then(@"The number of votes per candidate should be")]
        public void ThenTheNumberOfVotesPerCandidateShouldBe(Table table)
        {
            List<Candidate> predicate = new List<Candidate>();
            foreach (TableRow row in table.Rows)
            {
                predicate.Add(new Candidate
                {
                    Name = row[1],
                    NbVotes = int.Parse(row[0]),
                });
            }

            _CandidatesResult.Should().BeEquivalentTo(predicate);
        }

        [Then(@"The result should be null")]
        public void ThenTheResultShouldBeNull()
        {
            _Winner.Should().Be(null);
        }

    }
}
