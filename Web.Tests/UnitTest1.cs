using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Web.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var i = 1;
			Assert.IsTrue(i == 1);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Assert.Fail("Ooooops, failed unit test");
		}
	}
}
