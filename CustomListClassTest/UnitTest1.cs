using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddMethod_AddOneInt_CountIs1()
        {

            //Arrange (declaring variables)

            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act (the method that is under test)
            list.Add(1);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void AddMethod_AddOneInt_5IsInZeroIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            list.Add(5);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_AddOneInt_2IsIn1Index() //will we find 2 in the 1 index?
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            list.Add(5);
            list.Add(2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_AddOneInt_4IsIn3Index() //will we find 4 in the 3 index?
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            list.Add(1); //0 index
            list.Add(2); //1 
            list.Add(3); //2 
            list.Add(4); //3
            list.Add(5); //4
            list.Add(6); //5
            actual = list[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void AddMethod_AddOneInt_CountIs5()
        {

            //Arrange (declaring variables)

            CustomList<int> list = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act (the method that is under test)
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);

            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]

        public void AddMethod_AddOneInt_CountIs10()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 10;
            int actual;

            //Arrange
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            actual = list.Count;



            //Act
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddMethod_AddOneInt_WrongIndex100Is0()

        //yes or no? Since the value is never set will it just be 0? will throw an exception

        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 0;
            int actual;

            //act
            list.Add(10);
            actual = list[100];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add5Int_Capacity8() //capicity
        {

            //Arrange (declaring variables)

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 8;
            int actual;

            //Act (the method that is under test)
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);


            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddMethod_AddFiveInts_CheckIndex4Is5() //is 5 in the 4th index?
        {

            //Arrange (declaring variables)

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 5;
            int actual;

            //Act (the method that is under test)
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5); // <------

            actual = list[4];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddMethod_AddFiveInts_CountIs3() //test 1-4 to make sure their values did not change
        {

            //Arrange (declaring variables)

            CustomList<string> list = new CustomList<string>();


            string expected = "earth";
            string actual;

            //Act (the method that is under test)
            list.Add("moon");
            list.Add("sun");
            list.Add("earth"); // <-----
            list.Add("mercury");
            list.Add("saturn");
            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        // ------ remove methods
        [TestMethod]
        public void RemoveMethod_Add5Remove1_CapacityIs8()
        {
            //Remove value 5 from list and the capacity will remain at 8.

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 8;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);


            list.Remove(value2);
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add5Remove1_CountIs4()
        {
            //Remove value 5 from list and changing the count to 4

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 4;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);


            list.Remove(value5);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add5Remove4_CountIs1()
        {
            //Remove value 5,4,3,2 from list and changing it's count to 1.

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            int expected = 1;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);


            list.Remove(value5);
            list.Remove(value4);
            list.Remove(value3);
            list.Remove(value2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add6RemoveVal5_Index4Is6()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 6;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);

            list.Remove(value5);
            actual = list[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add6RemoveVal1_Index0Is2()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 2;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);

            list.Remove(value1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add6RemoveVal2_Index1Is3()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 3;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);

            list.Remove(value2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add6RemoveIndex6_Index0Is3()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 1;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value1);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);

            list.Remove(value1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Add6RemoveIndex6_Index0Is0()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            int expected = 1;
            int actual;

            //Action

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);

            list.Remove(120);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //ToString Test ---------------------------------------------

        [TestMethod]
        public void ToStringMethod_Add5Ints_Returns1StringWith5Numbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "12345";
            string actual;

            //Action
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            actual = ToString();


            //Asset
            Assert.AreEqual(expected, actual);
        }

        public void ToStringMethod_Add5Ints_Returns1StringWith5Numbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "12345";
            string actual;

            //Action
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            actual = ToString();


            //Asset
            Assert.AreEqual(expected, actual);
        }

        public void ToStringMethod_Add5Ints_Returns1StringWith5Numbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "12345";
            string actual;

            //Action
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            actual = ToString();


            //Asset
            Assert.AreEqual(expected, actual);
        }

        public void ToStringMethod_Add5Ints_Returns1StringWith5Numbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "12345";
            string actual;

            //Action
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            actual = ToString();


            //Asset
            Assert.AreEqual(expected, actual);
        }

        public void ToStringMethod_Add5Ints_Returns1StringWith5Numbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "12345";
            string actual;

            //Action
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            actual = ToString();


            //Asset
            Assert.AreEqual(expected, actual);
        }
    }
}




