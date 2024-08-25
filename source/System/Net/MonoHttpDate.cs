using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000269")]
	internal class MonoHttpDate
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E003EC", Offset = "0x1E003EC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "get_IfModifiedSince", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_LastModified", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static DateTime Parse(string dateStr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001097")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03780", Offset = "0x1E03780", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoHttpDate()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001098")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03788", Offset = "0x1E03788", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static MonoHttpDate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D19")]
		private static readonly string rfc1123_date;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1A")]
		private static readonly string rfc850_date;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1B")]
		private static readonly string asctime_date;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1C")]
		private static readonly string[] formats;
	}
}
