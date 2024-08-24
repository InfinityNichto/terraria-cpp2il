using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

// Token: 0x02000238 RID: 568
[global::Cpp2ILInjected.Token(Token = "0x20002F1")]
public class TutorialStep_02_CopperPickaxe : TutorialStep
{
	// Token: 0x06001021 RID: 4129 RVA: 0x00024B45 File Offset: 0x00022D45
	[global::Cpp2ILInjected.Token(Token = "0x6001170")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C020", Offset = "0xA6C020", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00024B48 File Offset: 0x00022D48
	[global::Cpp2ILInjected.Token(Token = "0x6001171")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C028", Offset = "0xA6C028", Length = "0x1EC")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00024B4B File Offset: 0x00022D4B
	[global::Cpp2ILInjected.Token(Token = "0x6001172")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C214", Offset = "0xA6C214", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00024B4E File Offset: 0x00022D4E
	[global::Cpp2ILInjected.Token(Token = "0x6001173")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C21C", Offset = "0xA6C21C", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "SetTime", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "SetSpawnRate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "GiveItem", MemberParameters = new object[]
	{
		typeof(short),
		typeof(int)
	}, ReturnType = typeof(void))]
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

	// Token: 0x06001025 RID: 4133 RVA: 0x00024B51 File Offset: 0x00022D51
	[global::Cpp2ILInjected.Token(Token = "0x6001174")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C308", Offset = "0xA6C308", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00024B54 File Offset: 0x00022D54
	[global::Cpp2ILInjected.Token(Token = "0x6001175")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B7F4", Offset = "0xA6B7F4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_02_CopperPickaxe()
	{
		throw null;
	}

	// Token: 0x04001B7F RID: 7039
	[global::Cpp2ILInjected.Token(Token = "0x4002133")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool givenAxe;
}
