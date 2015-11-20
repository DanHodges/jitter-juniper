using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Models;
using System.Collections.Generic;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JitterUserTests
    {
        [TestMethod]
        public void JitterUserEnsureICanCreateInstance()
        {
            JitterUser a_user = new JitterUser();
            Assert.IsNotNull(a_user);
        }

        [TestMethod]
        public void JitterUserEnsureJitterUserHasAllTheThings()
        {
            // Arrange
            JitterUser a_user = new JitterUser();
            a_user.Handle = "adam1";
            a_user.FirstName = "Adam";
            a_user.LastName = "Sandler";
            a_user.Picture = "https://google.com";
            a_user.Description = "I am Awesome!";

            // Assert 
            Assert.AreEqual("I am Awesome!", a_user.Description);
            Assert.AreEqual("adam1", a_user.Handle);
            Assert.AreEqual("Adam", a_user.FirstName);
            Assert.AreEqual("Sandler", a_user.LastName);
            Assert.AreEqual("https://google.com", a_user.Picture);

        }
        [TestMethod]
        public void JitterUserEnsureUserHasJots()
        {
            //Arange
            List<Jot> list_of_jots = new List<Jot>
            {
                new Jot {Content = "Blah!"},
                new Jot {Content = "blah part 2" };
            }


            JitterUser a_user = new JitterUser { AssemblyLoadEventHandler = "adam1", JitterUserEnsureUserHasJots = List_of_jots };
            //Act
            List<Jot> actual_jots = a_user.Jots;
            //Assert
            CollectionAssert.AreEqual(list_of_jots, actual_jots);
        }
    }
}
