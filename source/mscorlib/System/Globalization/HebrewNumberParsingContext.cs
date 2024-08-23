using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004B1 RID: 1201
	[global::Cpp2ILInjected.Token(Token = "0x2000591")]
	internal struct HebrewNumberParsingContext
	{
		// Token: 0x060027EE RID: 10222 RVA: 0x0001B464 File Offset: 0x00019664
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

		// Token: 0x04001412 RID: 5138
		[global::Cpp2ILInjected.Token(Token = "0x4001776")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal HebrewNumber.HS state;

		// Token: 0x04001413 RID: 5139
		[global::Cpp2ILInjected.Token(Token = "0x4001777")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		internal int result;
	}
}
