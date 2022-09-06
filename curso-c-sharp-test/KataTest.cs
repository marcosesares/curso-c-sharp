using System;
using NUnit.Framework;

namespace curso_c_sharp.CodeWars
{
  [TestFixture]
  public class KataTest
  {
    [Test]
    public void KataTests()
    {
      Assert.Multiple(() =>
      {
        Assert.That(Kata.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.That(Kata.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
      });
    }

    [Test]
    public void KataTestSelect()
    {
      Assert.Multiple(() =>
      {
        Assert.That(Kata.ToCamelCaseSelect("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.That(Kata.ToCamelCaseSelect("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
      });
    }

    [Test]
    public void KataTestReplace()
    {
      Assert.Multiple(() =>
      {
        Assert.That(Kata.ToCamelCaseSelect("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.That(Kata.ToCamelCaseSelect("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
      });
    }

    [Test]
    public void GetVowelCount()
    {
      Assert.Multiple(() =>
      {
        Assert.That(Kata.GetVowelCount("abracadabra"), Is.EqualTo(5), "Nope!");
        Assert.That(Kata.GetVowelCount("comida"), Is.EqualTo(3), "Nope!");
        Assert.That(Kata.GetVowelCount("abraço"), Is.EqualTo(3), "Nope!");
      });
    }
  }
}

