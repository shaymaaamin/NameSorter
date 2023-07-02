using NUnit.Framework;


namespace NameSorter.Tests;

public class Tests
{
    [Test]
    public void Sort_ShouldSortLinesByLastNameThenFirstName()
    {
        // Arrange
        var sorter = new Sorter();
        var lines = new[]
        {
                "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer",
                "Shelby Nathan Yoder", "Marin Alvarez", "London Lindsey",
                "Beau Tristan Bentley", "Leo Gardner", "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez", "Frankie Conner Ritter"
            };

        // Act
        var sortedLines = sorter.Sort(lines);

        // Assert
        Assert.That(sortedLines, Is.EqualTo(new[]
        {
                "Marin Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke", "Leo Gardner", "Vaughn Lewis",
                "London Lindsey", "Mikayla Lopez", "Janet Parsons",
                "Frankie Conner Ritter", "Shelby Nathan Yoder"
            }));
    }
}
