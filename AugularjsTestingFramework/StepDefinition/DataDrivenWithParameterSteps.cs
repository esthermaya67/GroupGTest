using System;
using TechTalk.SpecFlow;

namespace AugularjsTestingFramework.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on Signup Button")]
        public void GivenIClickOnSignupButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter username  text ""(.*)""")]
        public void GivenIEnterUsernameText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter  my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter  my password""(.*)""")]
        public void GivenIEnterMyPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the signup button")]
        public void WhenIClickOnTheSignupButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
