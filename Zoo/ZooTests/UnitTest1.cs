using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class UnitTest1
    {
        [Fact]
        public void CowCanPlowField()
        {
            Cow cow = new Cow();
            Assert.Equal("I help plow the fields.", cow.PlowField());
        }

        [Fact]
        public void CowCanInheritSound()
        {
            Cow cow = new Cow();
            Assert.Equal("Moo! Moo! Moo!", cow.Sound());
        }

        [Fact]
        public void CowCanInheritHibernate()
        {
            Cow cow = new Cow();
            Assert.False(cow.Hibernate());
        }

        [Fact]
        public void CowCanInheritEat()
        {
            Cow cow = new Cow();
            Assert.Equal("I like to eat grass!", cow.Eat());
        }

        [Fact]
        public void PolarBearHasHuntingGround()
        {
            PolarBear polarBear = new PolarBear();
            Assert.Equal("Underwater & on land", polarBear.HuntingGround());
        }

        [Fact]
        public void PolarBearCanInheritSleep()
        {
            PolarBear polarBear = new PolarBear();
            Assert.Equal("ZZZ... ZZZ... ZZZ...", polarBear.Sleep());
        }

        [Fact]
        public void PolarBearCanInheritEat()
        {
            PolarBear polarBear = new PolarBear();
            Assert.Equal("I like to eat meat!!!", polarBear.Eat());
        }

        [Fact]
        public void BlackBearCanClimbTree()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("Let's climb a tree!", blackBear.ClimbTree());
        }

        [Fact]
        public void BlackBearInheritBirth()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("I have to nurse my young.", blackBear.Birth());
        }

        [Fact]
        public void BlackBearCanInheritEat()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("I like to eat meat!!!", blackBear.Eat());
        }

        [Fact]
        public void BlackBearCanInheritSleep()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("ZZZ... ZZZ... ZZZ...", blackBear.Sleep());
        }

        [Fact]
        public void OstrichCanSprint()
        {
            Ostrich ostrich = new Ostrich();
            Assert.Equal("I run really fast!!!", ostrich.Sprint());
        }

        [Fact]
        public void OstrichCanBuryHead()
        {
            Ostrich ostrich = new Ostrich();
            Assert.True(ostrich.BuryHead());
        }

        [Fact]
        public void OstrichCanInheritEat()
        {
            Ostrich ostrich = new Ostrich();
            Assert.Equal("I like to eat bugs!!!", ostrich.Eat());
        }

        [Fact]
        public void OstrichCanInheritSound()
        {
            Ostrich ostrich = new Ostrich();
            Assert.Equal("Wenk! Wenk! Wenk!", ostrich.Sound());
        }

        [Fact]
        public void OstrichCanRace()
        {
            Ostrich ostrich = new Ostrich();
            Assert.Equal("I am the fastest bird on Earth!", ostrich.Race());
        }
        
        [Fact]
        public void GooseCanInheritSound()
        {
            Goose goose = new Goose();
            Assert.Equal("Quack! Quack! Quack!", goose.Sound());
        }

        [Fact]
        public void GooseCanInheritEat()
        {
            Goose goose = new Goose();
            Assert.Equal("I like to eat bread!!!", goose.Eat());
        }

        [Fact]
        public void TortiseCanInheritEat()
        {
            Tortise tortise = new Tortise();
            Assert.Equal("I like to eat plants!!!", tortise.Eat());
        }

        [Fact]
        public void TortiseCanSleep()
        {
            Tortise tortise = new Tortise();
            Assert.Equal("ZZZ... ZZZ... ZZZ...", tortise.Sleep());
        }

        [Fact]
        public void TortiseCanHideInShell()
        {
            Tortise tortise = new Tortise();
            Assert.Equal("I hide in my shell when there is danger", tortise.HideInShell());
        }

        [Fact]
        public void TortiseCanInheritSwim()
        {
            Tortise tortise = new Tortise();
            Assert.False(tortise.Swim());
        }

        [Fact]
        public void TortiseCanInheritSound()
        {
            Tortise tortise = new Tortise();
            Assert.Equal("Tuuuuurtle, tuuuuuurtle.", tortise.Sound());
        }

        [Fact]
        public void TortiseCanInheritHunt()
        {
            Tortise tortise = new Tortise();
            Assert.False(tortise.Hunt());
        }

        [Fact]
        public void CrocodileCanBirdTeethClean()
        {
            Crocodile crocodile = new Crocodile();
            Assert.Equal("Little birds clean my teeth!", crocodile.BirdTeethClean());
        }

        [Fact]
        public void CrocodileCanInheritEat()
        {
            Crocodile crocodile = new Crocodile();
            Assert.Equal("I like to eat meat!!!", crocodile.Eat());
        }

        [Fact]
        public void CrocodileCanInheritHunt()
        {
            Crocodile crocodile = new Crocodile();
            Assert.True(crocodile.Hunt());
        }

        [Fact]
        public void CrocodileCanSleep()
        {
            Crocodile crocodile = new Crocodile();
            Assert.Equal("ZZZ... ZZZ... ZZZ...", crocodile.Sleep());
        }

        [Fact]
        public void CrocodileCanInheritSound()
        {
            Crocodile crocodile = new Crocodile();
            Assert.Equal("Hiss! Hiss! Hiss!", crocodile.Sound());
        }

        [Fact]
        public void CrocodileCanInheritSwim()
        {
            Crocodile crocodile = new Crocodile();
            Assert.True(crocodile.Swim());
        }
    }
}
