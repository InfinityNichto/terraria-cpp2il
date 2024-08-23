using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.Initializers
{
	// Token: 0x020003D6 RID: 982
	[global::Cpp2ILInjected.Token(Token = "0x200058C")]
	public static class LaunchInitializer
	{
		// Token: 0x06003019 RID: 12313 RVA: 0x0002A995 File Offset: 0x00028B95
		[global::Cpp2ILInjected.Token(Token = "0x60034AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x137D208", Offset = "0x137D208", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "LoadSharedParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "LoadServerParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "LoadClientParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LoadParameters(Main game)
		{
			throw null;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x0002A998 File Offset: 0x00028B98
		[global::Cpp2ILInjected.Token(Token = "0x60034AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x137D27C", Offset = "0x137D27C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "TryParameter", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "loadLib", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void LoadSharedParameters(Main game)
		{
			throw null;
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0002A99B File Offset: 0x00028B9B
		[global::Cpp2ILInjected.Token(Token = "0x60034AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x137DEF4", Offset = "0x137DEF4", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "TryParameter", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "AutoJoin", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ConvertFromSafeArgument", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "AutoPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "HasParameter", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "AutoHost", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static void LoadClientParameters(Main game)
		{
			throw null;
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0002A99E File Offset: 0x00028B9E
		[global::Cpp2ILInjected.Token(Token = "0x60034AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x137D404", Offset = "0x137D404", Length = "0xAF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "TryParameter", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "set_PriorityClass", MemberParameters = new object[] { typeof(ProcessPriorityClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SetNetPlayers", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ConvertFromSafeArgument", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SetWorldName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewMOTD", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LaunchInitializer), Member = "HasParameter", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "EnableAutoShutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "setServerWorldRollbacks", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "autoCreate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SetWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 88)]
		private static void LoadServerParameters(Main game)
		{
			throw null;
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x0002A9A1 File Offset: 0x00028BA1
		[global::Cpp2ILInjected.Token(Token = "0x60034B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x137E234", Offset = "0x137E234", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadClientParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadServerParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool HasParameter(params string[] keys)
		{
			throw null;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x0002A9A4 File Offset: 0x00028BA4
		[global::Cpp2ILInjected.Token(Token = "0x60034B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x137E14C", Offset = "0x137E14C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadSharedParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadClientParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LaunchInitializer), Member = "LoadServerParameters", MemberParameters = new object[] { typeof(Main) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string TryParameter(params string[] keys)
		{
			throw null;
		}
	}
}
