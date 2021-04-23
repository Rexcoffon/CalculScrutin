﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CalculScrutin.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("PollingCalculator", Description="\tReturns the winner of a poll", SourceFile="Features\\PollingCalculator.feature", SourceLine=0)]
    public partial class PollingCalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PollingCalculator.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "PollingCalculator", "\tReturns the winner of a poll", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the winner of a poll", SourceLine=4)]
        public virtual void GetTheWinnerOfAPoll()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the winner of a poll", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Candidate"});
                table1.AddRow(new string[] {
                            "Bob"});
                table1.AddRow(new string[] {
                            "Toto"});
                table1.AddRow(new string[] {
                            "Pierre"});
#line 6
 testRunner.Given("The following candidates", ((string)(null)), table1, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Vote"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Toto"});
                table2.AddRow(new string[] {
                            "Pierre"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Toto"});
                table2.AddRow(new string[] {
                            "Toto"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Pierre"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Pierre"});
                table2.AddRow(new string[] {
                            "Pierre"});
                table2.AddRow(new string[] {
                            "Toto"});
                table2.AddRow(new string[] {
                            "Pierre"});
                table2.AddRow(new string[] {
                            "Pierre"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Bob"});
                table2.AddRow(new string[] {
                            "Bob"});
#line 11
 testRunner.And("Add the votes", ((string)(null)), table2, "And ");
#line hidden
#line 37
 testRunner.And("Close the poll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.When("Calculate the polling", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("The result should be \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "number of votes",
                            "Candidate"});
                table3.AddRow(new string[] {
                            "11",
                            "Bob"});
                table3.AddRow(new string[] {
                            "4",
                            "Toto"});
                table3.AddRow(new string[] {
                            "6",
                            "Pierre"});
#line 40
 testRunner.And("The number of votes per candidate should be", ((string)(null)), table3, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the winner of a poll of 2 rounds", SourceLine=46)]
        public virtual void GetTheWinnerOfAPollOf2Rounds()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the winner of a poll of 2 rounds", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Candidate"});
                table4.AddRow(new string[] {
                            "Bob"});
                table4.AddRow(new string[] {
                            "Toto"});
                table4.AddRow(new string[] {
                            "Pierre"});
#line 48
 testRunner.Given("The following candidates", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Vote"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Toto"});
                table5.AddRow(new string[] {
                            "Pierre"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Toto"});
                table5.AddRow(new string[] {
                            "Toto"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Pierre"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Bob"});
                table5.AddRow(new string[] {
                            "Pierre"});
                table5.AddRow(new string[] {
                            "Pierre"});
                table5.AddRow(new string[] {
                            "Toto"});
                table5.AddRow(new string[] {
                            "Pierre"});
                table5.AddRow(new string[] {
                            "Pierre"});
#line 53
 testRunner.And("Add the votes", ((string)(null)), table5, "And ");
#line hidden
#line 76
 testRunner.And("Close the poll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.When("Calculate the polling", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.Then("The result should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "number of votes",
                            "Candidate"});
                table6.AddRow(new string[] {
                            "8",
                            "Bob"});
                table6.AddRow(new string[] {
                            "4",
                            "Toto"});
                table6.AddRow(new string[] {
                            "6",
                            "Pierre"});
#line 79
 testRunner.And("The number of votes per candidate should be", ((string)(null)), table6, "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Candidate"});
                table7.AddRow(new string[] {
                            "Bob"});
                table7.AddRow(new string[] {
                            "Pierre"});
#line 84
 testRunner.Given("The following candidates", ((string)(null)), table7, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Vote"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Bob"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Pierre"});
                table8.AddRow(new string[] {
                            "Pierre"});
#line 88
 testRunner.And("Add the votes", ((string)(null)), table8, "And ");
#line hidden
#line 110
 testRunner.And("Set the for a second round", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("Close the poll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.When("Calculate the polling", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.Then("The result should be \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "number of votes",
                            "Candidate"});
                table9.AddRow(new string[] {
                            "10",
                            "Bob"});
                table9.AddRow(new string[] {
                            "8",
                            "Pierre"});
#line 114
 testRunner.And("The number of votes per candidate should be", ((string)(null)), table9, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the winner of a poll of 2 rounds with ties on the 2nd and 3rd", SourceLine=121)]
        public virtual void GetTheWinnerOfAPollOf2RoundsWithTiesOnThe2NdAnd3Rd()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the winner of a poll of 2 rounds with ties on the 2nd and 3rd", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 122
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Candidate"});
                table10.AddRow(new string[] {
                            "Bob"});
                table10.AddRow(new string[] {
                            "Toto"});
                table10.AddRow(new string[] {
                            "Pierre"});
#line 123
 testRunner.Given("The following candidates", ((string)(null)), table10, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Vote"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Toto"});
                table11.AddRow(new string[] {
                            "Toto"});
                table11.AddRow(new string[] {
                            "Toto"});
                table11.AddRow(new string[] {
                            "Pierre"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Toto"});
                table11.AddRow(new string[] {
                            "Toto"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Pierre"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Bob"});
                table11.AddRow(new string[] {
                            "Pierre"});
                table11.AddRow(new string[] {
                            "Pierre"});
                table11.AddRow(new string[] {
                            "Toto"});
                table11.AddRow(new string[] {
                            "Pierre"});
                table11.AddRow(new string[] {
                            "Pierre"});
#line 128
 testRunner.And("Add the votes", ((string)(null)), table11, "And ");
#line hidden
#line 153
 testRunner.And("Close the poll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.When("Calculate the polling", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 155
 testRunner.Then("The result should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "number of votes",
                            "Candidate"});
                table12.AddRow(new string[] {
                            "8",
                            "Bob"});
                table12.AddRow(new string[] {
                            "6",
                            "Toto"});
                table12.AddRow(new string[] {
                            "6",
                            "Pierre"});
#line 156
 testRunner.And("The number of votes per candidate should be", ((string)(null)), table12, "And ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Candidate"});
                table13.AddRow(new string[] {
                            "Bob"});
                table13.AddRow(new string[] {
                            "Toto"});
                table13.AddRow(new string[] {
                            "Pierre"});
#line 161
 testRunner.Given("The following candidates", ((string)(null)), table13, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "Vote"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Toto"});
                table14.AddRow(new string[] {
                            "Toto"});
                table14.AddRow(new string[] {
                            "Toto"});
                table14.AddRow(new string[] {
                            "Toto"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Bob"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Pierre"});
                table14.AddRow(new string[] {
                            "Pierre"});
#line 166
 testRunner.And("Add the votes", ((string)(null)), table14, "And ");
#line hidden
#line 193
 testRunner.And("Set the for a second round", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 194
 testRunner.And("Close the poll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 195
 testRunner.When("Calculate the polling", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 196
 testRunner.Then("The result should be \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "number of votes",
                            "Candidate"});
                table15.AddRow(new string[] {
                            "10",
                            "Bob"});
                table15.AddRow(new string[] {
                            "8",
                            "Pierre"});
                table15.AddRow(new string[] {
                            "4",
                            "Toto"});
#line 197
 testRunner.And("The number of votes per candidate should be", ((string)(null)), table15, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the winner of a poll with blank vote", SourceLine=204)]
        public virtual void GetTheWinnerOfAPollWithBlankVote()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the winner of a poll with blank vote", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 205
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "Candidate"});
                table16.AddRow(new string[] {
                            "Bob"});
                table16.AddRow(new string[] {
                            "Toto"});
                table16.AddRow(new string[] {
                            "Pierre"});
#line 206
 testRunner.Given("The following candidates", ((string)(null)), table16, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Vote"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Toto"});
                table17.AddRow(new string[] {
                            "Pierre"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "tutu"});
                table17.AddRow(new string[] {
                            ""});
                table17.AddRow(new string[] {
                            "Toto"});
                table17.AddRow(new string[] {
                            "Toto"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Pierre"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Pierre"});
                table17.AddRow(new string[] {
                            "Pierre"});
                table17.AddRow(new string[] {
                            "Toto"});
                table17.AddRow(new string[] {
                            "Pierre"});
                table17.AddRow(new string[] {
                            "Pierre"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "tutu"});
                table17.AddRow(new string[] {
                            "tutu"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
                table17.AddRow(new string[] {
                            "Bob"});
#line 211
 testRunner.And("Add the votes", ((string)(null)), table17, "And ");
#line hidden
#line 247
 testRunner.And("Close the poll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 248
 testRunner.When("Calculate the polling", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 249
 testRunner.Then("The result should be \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "number of votes",
                            "Candidate"});
                table18.AddRow(new string[] {
                            "15",
                            "Bob"});
                table18.AddRow(new string[] {
                            "4",
                            "Toto"});
                table18.AddRow(new string[] {
                            "6",
                            "Pierre"});
#line 250
 testRunner.And("The number of votes per candidate should be", ((string)(null)), table18, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion