using NUnit.Framework;
using GameOfLife.Rules;

namespace Tests
{
    public class RulesTests
    {
        
        private RulesImpl _rules;
        
        [SetUp]
        public void Setup()
        {
            _rules = new RulesImpl();
        }

        [Test]
        public void EnforceRules_Underpop_Test()
        {
            Assert.False(_rules.EnforceRules(true,2));
        }

        [Test]
        public void EnforceRules_Liveon_Test()
        {
            Assert.True(_rules.EnforceRules(true,3));
        }

        [Test]
        public void EnforceRules_Overpop_Test()
        {
            Assert.False(_rules.EnforceRules(true,5));
        }

        [Test]
        public void EnforceRules_Resurrection_Test()
        {
            Assert.True(_rules.EnforceRules(false,3));
        }
        
    }
}