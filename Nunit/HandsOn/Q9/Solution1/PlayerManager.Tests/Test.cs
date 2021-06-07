using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void EmptyName_Test()
        {
            var mock = new Mock<IPlayerMapper>();

            Player player = Player.RegisterNewPlayer(null, mock.Object);
        }

        [Test]

        public void Player_AlreadyExistsInDatabase_Test()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            Player player = Player.RegisterNewPlayer("Test", mock.Object);
        }


        [Test]
        public void CreateNewPlayer_Test()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            Player player = Player.RegisterNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(25, player.Age);
            Assert.AreEqual("India", player.Country);
            Assert.AreEqual(37, player.NoOfMatches);
        }
    }
}
