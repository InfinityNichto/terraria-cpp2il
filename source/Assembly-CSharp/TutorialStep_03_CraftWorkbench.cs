using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

// Token: 0x02000239 RID: 569
[global::Cpp2ILInjected.Token(Token = "0x20002F2")]
public class TutorialStep_03_CraftWorkbench : TutorialStep
{
	// Token: 0x06001027 RID: 4135 RVA: 0x00024B57 File Offset: 0x00022D57
	[global::Cpp2ILInjected.Token(Token = "0x6001176")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C390", Offset = "0xA6C390", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00024B5A File Offset: 0x00022D5A
	[global::Cpp2ILInjected.Token(Token = "0x6001177")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C398", Offset = "0xA6C398", Length = "0x3FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControlsKeyboardTagHandler.MappingType) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00024B5D File Offset: 0x00022D5D
	[global::Cpp2ILInjected.Token(Token = "0x6001178")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C794", Offset = "0xA6C794", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00024B60 File Offset: 0x00022D60
	[global::Cpp2ILInjected.Token(Token = "0x6001179")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C7A0", Offset = "0xA6C7A0", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "SetTime", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00024B63 File Offset: 0x00022D63
	[global::Cpp2ILInjected.Token(Token = "0x600117A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C7CC", Offset = "0xA6C7CC", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[]
	{
		typeof(short[]),
		typeof(short)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override void OnItemPlaced(int itemId, int tileType)
	{
		throw null;
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00024B66 File Offset: 0x00022D66
	[global::Cpp2ILInjected.Token(Token = "0x600117B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C864", Offset = "0xA6C864", Length = "0x180")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[]
	{
		typeof(short[]),
		typeof(short)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00024B69 File Offset: 0x00022D69
	[global::Cpp2ILInjected.Token(Token = "0x600117C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B7FC", Offset = "0xA6B7FC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_03_CraftWorkbench()
	{
		throw null;
	}

	// Token: 0x04001B80 RID: 7040
	[global::Cpp2ILInjected.Token(Token = "0x4002134")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool got10Wood;

	// Token: 0x04001B81 RID: 7041
	[global::Cpp2ILInjected.Token(Token = "0x4002135")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool craftedWorkbench;

	// Token: 0x04001B82 RID: 7042
	[global::Cpp2ILInjected.Token(Token = "0x4002136")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool placedWorkbench;
}
