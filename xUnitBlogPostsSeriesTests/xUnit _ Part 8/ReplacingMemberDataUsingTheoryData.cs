using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_8
{
    public class ReplacingMemberDataUsingTheoryData
    {
        public bool IsAboveFourteen(Person person)
        {
            return person.Age > 14;
        }

        public static TheoryData<Person> PersonData =>
            new TheoryData<Person>
            {
                new Person {Name = "Tribbiani", Age = 56},
                new Person {Name = "Gotti", Age = 16},
                new Person {Name = "Sopranos", Age = 15},
                new Person {Name = "Corleone", Age = 27},
                new Person {Name = "Mancini", Age = 79},
                new Person {Name = "Vivaldi", Age = 16},
                new Person {Name = "Serpico", Age = 19},
                new Person {Name = "Salieri", Age = 20}
            };

        [Theory]
        [MemberData(nameof(PersonData), MemberType = typeof(ReplacingMemberDataUsingTheoryData))]
        public void AllPersons_AreAbove14_WithTheoryData_FromDataGenerator(Person a)
        {
            Assert.True(IsAboveFourteen(a));
        }
    }
}
