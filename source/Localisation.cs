using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000059")]
public class Localisation
{
	[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
	[global::Cpp2ILInjected.Address(RVA = "0x709CA8", Offset = "0x709CA8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static SystemLanguage GetPS4SystemLanguage()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
	[global::Cpp2ILInjected.Address(RVA = "0x709CB0", Offset = "0x709CB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static SystemLanguage GetSwitchSystemLanguage()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
	[global::Cpp2ILInjected.Address(RVA = "0x709CB8", Offset = "0x709CB8", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_systemLanguage", ReturnType = typeof(SystemLanguage))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(string)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public static int GetLanguage()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
	[global::Cpp2ILInjected.Address(RVA = "0x709E6C", Offset = "0x709E6C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Localisation()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x200005A")]
	public enum SupportedLanguages
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		English = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		German,
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		Italian,
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		French,
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		Spanish,
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		Russian,
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		Portuguese = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		Japanese = 10
	}
}
