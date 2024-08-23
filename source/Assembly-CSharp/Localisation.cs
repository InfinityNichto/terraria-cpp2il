using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using UnityEngine;

// Token: 0x02000037 RID: 55
[global::Cpp2ILInjected.Token(Token = "0x2000059")]
public class Localisation
{
	// Token: 0x06000156 RID: 342 RVA: 0x00021F7A File Offset: 0x0002017A
	[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
	[global::Cpp2ILInjected.Address(RVA = "0x709CA8", Offset = "0x709CA8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static SystemLanguage GetPS4SystemLanguage()
	{
		throw null;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00021F7D File Offset: 0x0002017D
	[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
	[global::Cpp2ILInjected.Address(RVA = "0x709CB0", Offset = "0x709CB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static SystemLanguage GetSwitchSystemLanguage()
	{
		throw null;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00021F80 File Offset: 0x00020180
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

	// Token: 0x06000159 RID: 345 RVA: 0x00021F83 File Offset: 0x00020183
	[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
	[global::Cpp2ILInjected.Address(RVA = "0x709E6C", Offset = "0x709E6C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Localisation()
	{
		throw null;
	}

	// Token: 0x02000784 RID: 1924
	[global::Cpp2ILInjected.Token(Token = "0x200005A")]
	public enum SupportedLanguages
	{
		// Token: 0x040078D0 RID: 30928
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		English = 1,
		// Token: 0x040078D1 RID: 30929
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		German,
		// Token: 0x040078D2 RID: 30930
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		Italian,
		// Token: 0x040078D3 RID: 30931
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		French,
		// Token: 0x040078D4 RID: 30932
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		Spanish,
		// Token: 0x040078D5 RID: 30933
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		Russian,
		// Token: 0x040078D6 RID: 30934
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		Portuguese = 8,
		// Token: 0x040078D7 RID: 30935
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		Japanese = 10
	}
}
