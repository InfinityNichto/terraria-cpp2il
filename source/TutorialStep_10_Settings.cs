using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

// Token: 0x02000240 RID: 576
[global::Cpp2ILInjected.Token(Token = "0x20002F9")]
public class TutorialStep_10_Settings : TutorialStep
{
	// Token: 0x06001058 RID: 4184 RVA: 0x00024BEA File Offset: 0x00022DEA
	[global::Cpp2ILInjected.Token(Token = "0x60011A7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DF4C", Offset = "0xA6DF4C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00024BED File Offset: 0x00022DED
	[global::Cpp2ILInjected.Token(Token = "0x60011A8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DF54", Offset = "0xA6DF54", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControlsKeyboardTagHandler.MappingType) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00024BF0 File Offset: 0x00022DF0
	[global::Cpp2ILInjected.Token(Token = "0x60011A9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E048", Offset = "0xA6E048", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00024BF3 File Offset: 0x00022DF3
	[global::Cpp2ILInjected.Token(Token = "0x60011AA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E050", Offset = "0xA6E050", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00024BF6 File Offset: 0x00022DF6
	[global::Cpp2ILInjected.Token(Token = "0x60011AB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E054", Offset = "0xA6E054", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00024BF9 File Offset: 0x00022DF9
	[global::Cpp2ILInjected.Token(Token = "0x60011AC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E060", Offset = "0xA6E060", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x00024BFC File Offset: 0x00022DFC
	[global::Cpp2ILInjected.Token(Token = "0x60011AD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B834", Offset = "0xA6B834", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_10_Settings()
	{
		throw null;
	}

	// Token: 0x04001B9D RID: 7069
	[global::Cpp2ILInjected.Token(Token = "0x4002151")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool complete;
}
