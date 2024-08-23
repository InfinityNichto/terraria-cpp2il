using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004BE RID: 1214
	[global::Cpp2ILInjected.Token(Token = "0x20005AB")]
	[global::System.Serializable]
	internal class EraInfo
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x0001B572 File Offset: 0x00019772
		[global::Cpp2ILInjected.Token(Token = "0x6002BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE414", Offset = "0x1BEE414", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
		{
			throw null;
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0001B575 File Offset: 0x00019775
		[global::Cpp2ILInjected.Token(Token = "0x6002BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE4B0", Offset = "0x1BEE4B0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
		{
			throw null;
		}

		// Token: 0x0400149A RID: 5274
		[global::Cpp2ILInjected.Token(Token = "0x400185E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int era;

		// Token: 0x0400149B RID: 5275
		[global::Cpp2ILInjected.Token(Token = "0x400185F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long ticks;

		// Token: 0x0400149C RID: 5276
		[global::Cpp2ILInjected.Token(Token = "0x4001860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int yearOffset;

		// Token: 0x0400149D RID: 5277
		[global::Cpp2ILInjected.Token(Token = "0x4001861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int minEraYear;

		// Token: 0x0400149E RID: 5278
		[global::Cpp2ILInjected.Token(Token = "0x4001862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int maxEraYear;

		// Token: 0x0400149F RID: 5279
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string eraName;

		// Token: 0x040014A0 RID: 5280
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string abbrevEraName;

		// Token: 0x040014A1 RID: 5281
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string englishEraName;
	}
}
