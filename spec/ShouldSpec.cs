using System;
using NUnit.Framework;

[TestFixture]
public class NUnitShouldSpec {

	[Test] public void Should_Be_EqualTo() { 1.Should(Be.EqualTo(1)); }

	[Test] public void ShouldNot_Be_EqualTo() { 1.ShouldNot(Be.EqualTo(6)); }

	[Test] public void Should_Be_False() { false.Should(Be.False); }

	[Test] public void Should_Be_True() { true.Should(Be.True); }

	[Test]
	public void Should_Have_Length() {
		new string[] { "hi", "there" }.Should(Have.Member("hi"));
		new string[] { "hi", "there" }.Should(Contain.Item("hi"));
	}
}

[TestFixture]
public class HelperMethodsSpec {

	[Test] public void ShouldEqual() { 1.ShouldEqual(1); }

	[Test] public void ShouldNotEqual() { 1.ShouldNotEqual(2); }

	[Test] public void ShouldContain_TEnum() { new string[] { "hi", "there" }.ShouldContain("hi"); }

	[Test] public void ShouldContain_Strings() { "Foo Bar".ShouldContain("Bar"); }

	[Test] public void ShouldBeFalse() { false.ShouldBeFalse(); }

	[Test] public void ShouldBeTrue() { true.ShouldBeTrue(); }
}
