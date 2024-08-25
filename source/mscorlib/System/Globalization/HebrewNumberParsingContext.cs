using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000591")]
	internal struct HebrewNumberParsingContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1090", Offset = "0x1BE1090", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public HebrewNumberParsingContext(int result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001776")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal HebrewNumber.HS state;

		[global::Cpp2ILInjected.Token(Token = "0x4001777")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		internal int result;
	}
}
