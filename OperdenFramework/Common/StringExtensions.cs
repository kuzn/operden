﻿using System;
using System.Collections.Generic;
using System.IO;

namespace OperFramework.Utils
{
	public static class StringExtensions
	{
		/// <summary>
		/// Indicates whether the string is null or empty (equals to "").
		/// </summary>
		/// <returns></returns>
		public static bool IsNullOrEmpty(this string value)
		{
			return string.IsNullOrEmpty(value);
		}

		/// <summary>
		/// Indicates whether the string is null or empty (equals to ""), or consists of white-space characters only.
		/// </summary>
		/// <returns></returns>
		public static bool IsNullOrWhiteSpace(this string value)
		{
			return string.IsNullOrWhiteSpace(value);
		}
		
		/// <summary>
		/// Splits string into lines.
		/// </summary>
		public static IEnumerable<string> GetLines(this string str)
		{
			if (str == null)
			{
				yield break;
			}

			using (StringReader sr = new StringReader(str))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					yield return line;
				}
			}
			yield break;
		}
	}
}
