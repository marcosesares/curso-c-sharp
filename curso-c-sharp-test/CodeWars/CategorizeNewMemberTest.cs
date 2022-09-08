using System;
using curso_c_sharp.CodeWars;

namespace curso_c_sharp_test.CodeWars
{
    [TestFixture]
  public class CategorizeNewMemberTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.Multiple(() =>
      {
        Assert.That(CategorizeNewMember.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
        Assert.That(CategorizeNewMember.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
        Assert.That(CategorizeNewMember.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
      });
    }

    [Test]
    public void OpenOrSeniorSelectTest()
    {
      Assert.Multiple(() =>
      {
        Assert.That(CategorizeNewMember.OpenOrSeniorSelect(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
        Assert.That(CategorizeNewMember.OpenOrSeniorSelect(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
        Assert.That(CategorizeNewMember.OpenOrSeniorSelect(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
      });
    }
  }
}

