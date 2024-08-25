using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x20005AB")]
	[global::System.Serializable]
	internal class EraInfo
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400185E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int era;

		[global::Cpp2ILInjected.Token(Token = "0x400185F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long ticks;

		[global::Cpp2ILInjected.Token(Token = "0x4001860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int yearOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4001861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int minEraYear;

		[global::Cpp2ILInjected.Token(Token = "0x4001862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int maxEraYear;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string eraName;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string abbrevEraName;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string englishEraName;
	}
}
