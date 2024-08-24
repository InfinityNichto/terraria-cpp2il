using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.UI.Chat;

namespace Terraria.Initializers
{
	// Token: 0x020003D4 RID: 980
	[global::Cpp2ILInjected.Token(Token = "0x2000589")]
	public static class ChatInitializer
	{
		// Token: 0x0600300D RID: 12301 RVA: 0x0002A971 File Offset: 0x00028B71
		[global::Cpp2ILInjected.Token(Token = "0x6003493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1377930", Offset = "0x1377930", Length = "0x6C8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "Register", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "AddCommand", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(ChatCommandProcessor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "AddDefaultCommand", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(ChatCommandProcessor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
		public static void Load()
		{
			throw null;
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0002A974 File Offset: 0x00028B74
		[global::Cpp2ILInjected.Token(Token = "0x6003494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1377FF8", Offset = "0x1377FF8", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "LoadLanguage", MemberParameters = new object[]
		{
			typeof(GameCulture),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "ClearAliases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromFormattable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "AddAlias", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(NetworkText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void PrepareAliases()
		{
			throw null;
		}
	}
}
