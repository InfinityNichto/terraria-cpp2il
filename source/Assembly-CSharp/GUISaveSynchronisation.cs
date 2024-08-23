using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020001F4 RID: 500
[global::Cpp2ILInjected.Token(Token = "0x2000298")]
public class GUISaveSynchronisation
{
	// Token: 0x06000E5D RID: 3677 RVA: 0x0002465C File Offset: 0x0002285C
	[global::Cpp2ILInjected.Token(Token = "0x6000F8D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32F10", Offset = "0xA32F10", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void Open()
	{
		throw null;
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x0002465F File Offset: 0x0002285F
	[global::Cpp2ILInjected.Token(Token = "0x6000F8E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA33134", Offset = "0xA33134", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void Close()
	{
		throw null;
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00024662 File Offset: 0x00022862
	[global::Cpp2ILInjected.Token(Token = "0x6000F8F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3321C", Offset = "0xA3321C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation), Member = "DrawClientState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation_Lobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation), Member = "DrawConnectingState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation), Member = "DrawHostedState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void Draw()
	{
		throw null;
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00024665 File Offset: 0x00022865
	[global::Cpp2ILInjected.Token(Token = "0x6000F90")]
	[global::Cpp2ILInjected.Address(RVA = "0xA33610", Offset = "0xA33610", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation_Status), Member = "DrawStatus", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void DrawConnectingState()
	{
		throw null;
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00024668 File Offset: 0x00022868
	[global::Cpp2ILInjected.Token(Token = "0x6000F91")]
	[global::Cpp2ILInjected.Address(RVA = "0xA33650", Offset = "0xA33650", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation_FileList), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation_Status), Member = "DrawStatus", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static void DrawHostedState()
	{
		throw null;
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0002466B File Offset: 0x0002286B
	[global::Cpp2ILInjected.Token(Token = "0x6000F92")]
	[global::Cpp2ILInjected.Address(RVA = "0xA336E8", Offset = "0xA336E8", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation_FileList), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static void DrawClientState()
	{
		throw null;
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0002466E File Offset: 0x0002286E
	[global::Cpp2ILInjected.Token(Token = "0x6000F93")]
	[global::Cpp2ILInjected.Address(RVA = "0xA33A5C", Offset = "0xA33A5C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUISaveSynchronisation()
	{
		throw null;
	}

	// Token: 0x0400170E RID: 5902
	[global::Cpp2ILInjected.Token(Token = "0x4001C30")]
	public static bool Enabled;
}
