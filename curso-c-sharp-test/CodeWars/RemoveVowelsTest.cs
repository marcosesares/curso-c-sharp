using System;
using curso_c_sharp.CodeWars;

namespace curso_c_sharp_test.CodeWars
{
  [TestFixture]
  public class RemoveVowelsTest
  {
    public RemoveVowelsTest()
    {
    }

    [Test]
    public void ShouldRemoveAllVowels()
    {
      Assert.That(RemoveVowels.Disemvowel("This website is for losers LOL!"), Is.EqualTo("Ths wbst s fr lsrs LL!"));
    }

    [Test]
    public void MultilineString()
    {
      Assert.That(RemoveVowels.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"), Is.EqualTo("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"));
    }

    [Test]
    public void OneMoreForGoodMeasure()
    {
      Assert.That(RemoveVowels.Disemvowel("What are you, a communist?"), Is.EqualTo("Wht r y,  cmmnst?"));
    }
  }
}

