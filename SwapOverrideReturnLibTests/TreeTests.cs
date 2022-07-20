using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwapOverrideReturnLib.Tests
{
    [TestClass()]
    public class TreeTests
    {
        [TestMethod()]
        public void GetAllNamesTest()
        {
            Tree tree = new Tree
            {
                Name = "1",
                Children = new Tree[]
                { 
                    new Tree { Name = "2", Children = new Tree[]
                        {
                            new Tree { Name = "7", Children = new Tree[]
                                {
                                    new Tree { Name = "8" }
                                }
                            }
                        }
                    },
                    new Tree { Name = "3" },
                    new Tree { Name = "4", Children = new Tree[]
                        { 
                            new Tree { Name = "5" },
                            new Tree { Name = "6" }
                        }
                    }
                }
            };
            string names = tree.GetAllNames();
            Assert.IsTrue(string.Equals(names, "12783456"));
        }
    }
}