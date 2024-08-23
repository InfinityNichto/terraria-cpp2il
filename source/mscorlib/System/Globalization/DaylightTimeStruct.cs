using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004B0 RID: 1200
	[global::Cpp2ILInjected.Token(Token = "0x2000590")]
	internal readonly struct DaylightTimeStruct
	{
		// Token: 0x060027ED RID: 10221 RVA: 0x0001B461 File Offset: 0x00019661
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

		// Token: 0x0400140F RID: 5135
		[global::Cpp2ILInjected.Token(Token = "0x4001773")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly global::System.DateTime Start;

		// Token: 0x04001410 RID: 5136
		[global::Cpp2ILInjected.Token(Token = "0x4001774")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly global::System.DateTime End;

		// Token: 0x04001411 RID: 5137
		[global::Cpp2ILInjected.Token(Token = "0x4001775")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly global::System.TimeSpan Delta;
	}
}
