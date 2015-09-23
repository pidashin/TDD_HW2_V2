using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PotterShoppingCart.Tests.Tests
{
    [TestClass()]
    public class HarryPotterCartTests
    {
        [TestMethod()]
        public void 第一集買了一本_價格應100元()
        {
            //Arrange
            var books = new List<Book> { new Book { Serial = "HarryPotter", Episode = 1, price = 100 } };
            var target = new HarryPotterCart();
            var expected = 100;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            //Arrange
            var books = new List<Book> { 
                new Book { Serial = "HarryPotter", Episode = 1, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 } 
            };
            var target = new HarryPotterCart();
            var expected = 190;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三集各買了一本_價格應為270()
        {
            //Arrange
            var books = new List<Book> { 
                new Book { Serial = "HarryPotter", Episode = 1, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 }, 
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 }
            };
            var target = new HarryPotterCart();
            var expected = 270;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void 一二三四集各買了一本_價格應為320()
        {
            //Arrange
            var books = new List<Book> { 
                new Book { Serial = "HarryPotter", Episode = 1, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 }, 
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 4, price = 100 }
            };
            var target = new HarryPotterCart();
            var expected = 320;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四五集各買了一本_價格應為375()
        {
            //Arrange
            var books = new List<Book> { 
                new Book { Serial = "HarryPotter", Episode = 1, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 }, 
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 4, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 5, price = 100 }
            };
            var target = new HarryPotterCart();
            var expected = 375;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二集各買了一本_第三集買了兩本_價格應為370()
        {
            //Arrange
            var books = new List<Book> { 
                new Book { Serial = "HarryPotter", Episode = 1, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 }, 
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 }
            };
            var target = new HarryPotterCart();
            var expected = 370;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            //Arrange
            var books = new List<Book> { 
                new Book { Serial = "HarryPotter", Episode = 1, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 }, 
                new Book { Serial = "HarryPotter", Episode = 2, price = 100 }, 
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 },
                new Book { Serial = "HarryPotter", Episode = 3, price = 100 }
            };
            var target = new HarryPotterCart();
            var expected = 460;

            //Act
            var actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }


}
