using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

// Token: 0x02000241 RID: 577
[global::Cpp2ILInjected.Token(Token = "0x20002FA")]
public class TutorialStep_11_Complete : TutorialStep
{
	// Token: 0x0600105F RID: 4191 RVA: 0x00024BFF File Offset: 0x00022DFF
	[global::Cpp2ILInjected.Token(Token = "0x60011AE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E068", Offset = "0xA6E068", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00024C02 File Offset: 0x00022E02
	[global::Cpp2ILInjected.Token(Token = "0x60011AF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E070", Offset = "0xA6E070", Length = "0xF0")]
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

	// Token: 0x06001061 RID: 4193 RVA: 0x00024C05 File Offset: 0x00022E05
	[global::Cpp2ILInjected.Token(Token = "0x60011B0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E230", Offset = "0xA6E230", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00024C08 File Offset: 0x00022E08
	[global::Cpp2ILInjected.Token(Token = "0x60011B1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E238", Offset = "0xA6E238", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00024C0B File Offset: 0x00022E0B
	[global::Cpp2ILInjected.Token(Token = "0x60011B2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E23C", Offset = "0xA6E23C", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteTriggerForPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(eTrigger)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00024C0E File Offset: 0x00022E0E
	[global::Cpp2ILInjected.Token(Token = "0x60011B3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E2E4", Offset = "0xA6E2E4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00024C11 File Offset: 0x00022E11
	[global::Cpp2ILInjected.Token(Token = "0x60011B4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E2EC", Offset = "0xA6E2EC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialLevel), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_11_Complete()
	{
		throw null;
	}

	// Token: 0x04001B9E RID: 7070
	[global::Cpp2ILInjected.Token(Token = "0x4002152")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool complete;
}
