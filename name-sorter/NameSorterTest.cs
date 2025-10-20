using System;
using name_sorter.Model;
using name_sorter.Name_Sorter;
using name_sorter.Services;
using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{

    public class NameSorterTests
    {
        [Fact]
        public void Sort_ShouldOrderByLastNameThenGivenNames()
        {
            // Arrange
            var unsorted = new List<Name>
            {
                new("Janet Parsons"),
                new("Vaughn Lewis"),
                new("Adonis Julius Archer"),
                new("Jane Mary Ann Smith"),
                new("Marin Alvarez"),
                new("Alice Brown"),
                new("Beau Tristan Bentleyr"),
                new("Leo Gardner"),
                new("Hunter Uriah Mathew Clarke"),
                new("Mikayla Lopez"),
                new("Frankie Conner Ritter")
            };

            var sorter = new NameSorter();

            // Act
            var result = sorter.Sort(unsorted).Select(n => n.ToString()).ToList();

            // Assert
            var expected = new List<string>
            {
                new("Marin Alvarez"),
                new("Adonis Julius Archer"),
                new("Beau Tristan Bentley"),
                new("Hunter Uriah Mathew Clarke"),
                new("Mikayla Lopez"),
                new("Vaughn Lewis"),
                new("London Lindsey"),
                new("Janet Parsons"),
                new("Frankie Conner Ritter"),
                new("Mikayla Lopez"),
                new("Shelby Nathan Yoder")
            };

            Assert.Equals(expected, result);
        }

        [Fact]
        public void PersonName_ShouldThrow_WhenNameHasTooManyParts()
        {
            Assert.Throws<System.ArgumentException>(() => new Name("A B C D E"));
        }

        [Fact]
        public void PersonName_ShouldFormatCorrectly()
        {
            var name = new Name("Hunter Uriah Mathew Clarke");
            Assert.Equals("Hunter Uriah Mathew Clarke", name.ToString());
        }
    }


}
