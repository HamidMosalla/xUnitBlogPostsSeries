using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_8
{
    public class TestDataGenerator2 : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetNumbersFromDataGenerator()
        {
            yield return new object[] { 5, 1, 3, 9 };
            yield return new object[] { 7, 1, 5, 3 };
        }

        public static IEnumerable<object[]> GetPersonFromDataGenerator()
        {
            yield return new object[]
            {
            new Person {Name = "Tribbiani", Age = 56},
            new Person {Name = "Gotti", Age = 16},
            new Person {Name = "Sopranos", Age = 15},
            new Person {Name = "Corleone", Age = 27}
            };

            yield return new object[]
            {
            new Person {Name = "Mancini", Age = 79},
            new Person {Name = "Vivaldi", Age = 16},
            new Person {Name = "Serpico", Age = 19},
            new Person {Name = "Salieri", Age = 20}
            };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ParameterizedTests2
    {
        public bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        public bool IsAboveFourteen(Person person)
        {
            return person.Age > 14;
        }

        public static IEnumerable<object[]> GetNumbers()
        {
            yield return new object[] { 5, 1, 3, 9 };
            yield return new object[] { 7, 1, 5, 3 };
        }

        [Theory]
        [MemberData(nameof(GetNumbers))]
        public void AllNumbers_AreOdd_WithMemberData(int a, int b, int c, int d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(IsOddNumber(d));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator2.GetNumbersFromDataGenerator), MemberType = typeof(TestDataGenerator2))]
        public void AllNumbers_AreOdd_WithMemberData_FromDataGenerator(int a, int b, int c, int d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(IsOddNumber(d));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator2.GetPersonFromDataGenerator), MemberType = typeof(TestDataGenerator2))]
        public void AllPersons_AreAbove14_WithMemberData_FromDataGenerator(Person a, Person b, Person c, Person d)
        {
            Assert.True(IsAboveFourteen(a));
            Assert.True(IsAboveFourteen(b));
            Assert.True(IsAboveFourteen(c));
            Assert.True(IsAboveFourteen(d));
        }
    }
}
