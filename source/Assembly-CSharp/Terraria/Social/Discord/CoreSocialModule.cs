using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Discord
{
	// Token: 0x02000386 RID: 902
	[global::Cpp2ILInjected.Token(Token = "0x2000515")]
	public class CoreSocialModule : ISocialModule
	{
		// Token: 0x06002D33 RID: 11571 RVA: 0x0002A1B8 File Offset: 0x000283B8
		[global::Cpp2ILInjected.Token(Token = "0x600316C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1327E40", Offset = "0x1327E40", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordHooks), Member = "RegisterTo", MemberParameters = new object[] { typeof(ref DiscordRpc.EventHandlers) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref DiscordRpc.EventHandlers),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x0002A1BB File Offset: 0x000283BB
		[global::Cpp2ILInjected.Token(Token = "0x600316D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13283E4", Offset = "0x13283E4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "remove_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordHooks), Member = "UnRegisterFrom", MemberParameters = new object[] { typeof(ref DiscordRpc.EventHandlers) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Shutdown()
		{
			throw null;
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x0002A1BE File Offset: 0x000283BE
		[global::Cpp2ILInjected.Token(Token = "0x600316E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328854", Offset = "0x1328854", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Pulse()
		{
			throw null;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0002A1C1 File Offset: 0x000283C1
		[global::Cpp2ILInjected.Token(Token = "0x600316F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13288BC", Offset = "0x13288BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CoreSocialModule()
		{
			throw null;
		}

		// Token: 0x040031C1 RID: 12737
		[global::Cpp2ILInjected.Token(Token = "0x4003B1D")]
		private const string TERRARIA_STEAM_APPLICATION_ID = "105600";

		// Token: 0x040031C2 RID: 12738
		[global::Cpp2ILInjected.Token(Token = "0x4003B1E")]
		private const string TERRARIA_DISCORD_APPLICATION_ID = "356943499456937984";

		// Token: 0x040031C3 RID: 12739
		[global::Cpp2ILInjected.Token(Token = "0x4003B1F")]
		private const bool AUTO_REGISTER_STEAM = false;

		// Token: 0x040031C4 RID: 12740
		[global::Cpp2ILInjected.Token(Token = "0x4003B20")]
		public static DiscordHooks Hooks;

		// Token: 0x040031C5 RID: 12741
		[global::Cpp2ILInjected.Token(Token = "0x4003B21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DiscordRpc.EventHandlers _handlers;
	}
}
