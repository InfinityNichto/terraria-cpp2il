using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000590")]
	internal readonly struct DaylightTimeStruct
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1084", Offset = "0x1BE1084", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public DaylightTimeStruct(global::System.DateTime start, global::System.DateTime end, global::System.TimeSpan delta)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001773")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly global::System.DateTime Start;

		[global::Cpp2ILInjected.Token(Token = "0x4001774")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly global::System.DateTime End;

		[global::Cpp2ILInjected.Token(Token = "0x4001775")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly global::System.TimeSpan Delta;
	}
}
