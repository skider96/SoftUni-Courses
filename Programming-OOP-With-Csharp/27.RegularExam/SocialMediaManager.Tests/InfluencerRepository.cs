using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaManager.Tests
{
    public class Tests
    {
        [TestCase("danito", 1000)]
        public void RegisterInfluencerValidInfluencerSuccessfullyAdded(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);

            // Act
            string result = repository.RegisterInfluencer(influencer);

            // Assert
            Assert.That(result, Is.EqualTo($"Successfully added influencer {influencer.Username} with {influencer.Followers}"));
            Assert.That(repository.Influencers, Contains.Item(influencer));
        }

        [TestCase("danito", 1000)]
        public void RegisterInfluencerInfluencerWithSameUsernameThrowsException(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act & Assert
            Assert.That(() => repository.RegisterInfluencer(influencer),
                Throws.InvalidOperationException.With.Message.EqualTo($"Influencer with username {influencer.Username} already exists"));
        }

        [TestCase("danito", 1000)]
        public void RemoveInfluencerExistingUsernameReturnsTrue(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act
            bool result = repository.RemoveInfluencer(influencer.Username);

            // Assert
            Assert.IsTrue(result);
            Assert.That(repository.Influencers, Does.Not.Contain(influencer));
        }

        [TestCase("danito", 1000)]
        public void RemoveInfluencerNonExistingUsername_ReturnsFalse(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);

            // Act
            bool result = repository.RemoveInfluencer(influencer.Username);

            // Assert
            Assert.IsFalse(result);
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void GetInfluencerWithMostFollowers_ValidData_ReturnsInfluencerWithMostFollowers(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act
            var result = repository.GetInfluencerWithMostFollowers();

            // Assert
            Assert.That(result, Is.EqualTo(influencer));
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void GetInfluencerValidUsernameReturnsCorrectInfluencer(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act
            var result = repository.GetInfluencer(username);

            // Assert
            Assert.That(result, Is.EqualTo(influencer));
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void GetInfluencer_NonExistingUsername_ReturnsNull(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();

            // Act
            var result = repository.GetInfluencer(username);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void GetInfluencerEmptyRepository_ReturnsNull()
        {
            // Arrange
            var repository = new InfluencerRepository();

            // Act
            var result = repository.GetInfluencer("non_existing_username");

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void ConstructorInitializes()
        {
            // Arrange & Act
            var repository = new InfluencerRepository();

            // Assert
            Assert.That(repository.Influencers, Is.Not.Null.And.Empty);
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void RegisterInfluencer_ValidInfluencer_ReturnsSuccessMessage(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);

            // Act
            string result = repository.RegisterInfluencer(influencer);

            // Assert
            Assert.AreEqual($"Successfully added influencer {influencer.Username} with {influencer.Followers}", result);
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void RegisterInfluencer_DuplicateUsername_ThrowsInvalidOperationException(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => repository.RegisterInfluencer(influencer));
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void RemoveInfluencer_ExistingUsername_ReturnsTrue(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act
            bool result = repository.RemoveInfluencer(username);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void RemoveInfluencerNonExistingUsername_ReturnsFalse()
        {
            // Arrange
            var repo = new InfluencerRepository();

            // Act
            bool result = repo.RemoveInfluencer("nonExistingUser");

            // Assert
            Assert.IsFalse(result);
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void GetInfluencerWithMostFollowers_ReturnsInfluencerWithMostFollowers(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer("user1", 20000);
            repository.RegisterInfluencer(influencer);

            // Act
            var result = repository.GetInfluencerWithMostFollowers();

            // Assert
            Assert.AreEqual(influencer, result);
        }

        [TestCase("danito", 1000)]
        [TestCase("mishito", 2000)]
        public void GetInfluencerExistingUsernameReturnsInfluencer(string username, int followers)
        {
            // Arrange
            var repository = new InfluencerRepository();
            var influencer = new Influencer(username, followers);
            repository.RegisterInfluencer(influencer);

            // Act
            var result = repository.GetInfluencer(username);

            // Assert
            Assert.AreEqual(influencer, result);
        }

        [Test]
        public void GetInfluencerNonExistingUsernameReturnsNull()
        {
            // Arrange
            var repository = new InfluencerRepository();

            // Act
            var result = repository.GetInfluencer("nonExistingUser");

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void RegisterInfluencerNullInfluencerThrowsArgumentNullException()
        {
            // Arrange
            var repository = new InfluencerRepository();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => repository.RegisterInfluencer(null));
        }

        [Test]
        public void RemoveInfluencerNullUsernameThrowsArgumentException()
        {
            // Arrange
            var repository = new InfluencerRepository();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => repository.RemoveInfluencer(null));
        }

        [Test]
        public void GetInfluencerNonExistingUsername_ReturnsNull()
        {
            // Arrange
            var repository = new InfluencerRepository();

            // Act
            var result = repository.GetInfluencer("nonExistingUser");

            // Assert
            Assert.IsNull(result);
        }
    }
}
