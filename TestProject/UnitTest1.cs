using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    public class UnitTest1
    {
        public void IsTodayFifthSaturday_Correct_true()
        {
            //Arrange
            string password = "Q%b5nY&3o";
            bool result = true;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);
        }
    }
}