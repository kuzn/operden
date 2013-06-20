using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OperdenFramework.Common;

namespace UnitTests.Common
{
	[TestFixture]
	public class StringExtensions
	{
		[Test]
		public void TestStringIsNullOrEmpty()
		{
			string nullString = null;
			Assert.IsTrue("".IsNullOrEmpty());
			Assert.IsFalse("a".IsNullOrEmpty());
			Assert.IsFalse(" ".IsNullOrEmpty());
			Assert.IsTrue(nullString.IsNullOrEmpty());
		}

		[Test]
		public void TestStringIsNullOrWhiteSpace()
		{
			string nullString = null;
			Assert.IsTrue("".IsNullOrWhiteSpace());
			Assert.IsTrue("  ".IsNullOrWhiteSpace());
			Assert.IsTrue("\r\n".IsNullOrWhiteSpace());
			Assert.IsFalse("  a ".IsNullOrWhiteSpace());
			Assert.IsTrue(nullString.IsNullOrWhiteSpace());
		}

		[Test]
		public void TestStringGetLines()
		{
			string nullString = null;
			Assert.AreEqual(new List<string>(new string [] {"abcd", "efgh"}), "abcd\r\nefgh".GetLines().ToList());
			Assert.AreEqual(new List<string>(), nullString.GetLines());
			Assert.AreEqual(new List<string>(), string.Empty.GetLines());
			Assert.AreEqual(new List<string>(new string [] {"abcd"}), "abcd".GetLines());
		}
	}
}
