using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хистограма
{
    public class Test
    {
        private int[] sample;

        [SetUp]
        public void Setup()
        {
           
            sample = new int[] { 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65 };
        }

        [Test]
        public void Histogram_Returns_CorrectPercentages_ForExample()
        {
            var result = HistogramLogic.CalculatePercentages(sample);
            
            Assert.That(60.00, result[0], 0.01, Is.EqualTo);
            Assert.Equals(10.00, result[1], 0.01);
            Assert.Equals(5.00, result[2], 0.01);
            Assert.Equals(15.00, result[3], 0.01);
            Assert.Equals(10.00, result[4], 0.01);
        }

       
        [Test]
        public void Histogram_CustomTest_EqualDistribution()
        {
            int[] nums = { 100, 250, 450, 650, 900 };
            var result = HistogramLogic.CalculatePercentages(nums);
            Assert.(20.0, result[0], 0.01);
            Assert.Equals(20.0, result[1], 0.01);
            Assert.Equals(20.0, result[2], 0.01);
            Assert.Equals(20.0, result[3], 0.01);
            Assert.Equals(20.0, result[4], 0.01);
        }

       
        [Test]
        public void Histogram_Throws_OnNullInput()
        {
            Assert.Throws<System.ArgumentNullException>(() => HistogramLogic.CalculatePercentages(null));
        }
    }
}
