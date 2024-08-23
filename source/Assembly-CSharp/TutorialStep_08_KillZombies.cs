using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

// Token: 0x0200023E RID: 574
[global::Cpp2ILInjected.Token(Token = "0x20002F7")]
public class TutorialStep_08_KillZombies : TutorialStep
{
	// Token: 0x0600104A RID: 4170 RVA: 0x00024BC0 File Offset: 0x00022DC0
	[global::Cpp2ILInjected.Token(Token = "0x6001199")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D83C", Offset = "0xA6D83C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00024BC3 File Offset: 0x00022DC3
	[global::Cpp2ILInjected.Token(Token = "0x600119A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D844", Offset = "0xA6D844", Length = "0x2C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControlsKeyboardTagHandler.MappingType) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00024BC6 File Offset: 0x00022DC6
	[global::Cpp2ILInjected.Token(Token = "0x600119B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DB08", Offset = "0xA6DB08", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00024BC9 File Offset: 0x00022DC9
	[global::Cpp2ILInjected.Token(Token = "0x600119C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DB14", Offset = "0xA6DB14", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00024BCC File Offset: 0x00022DCC
	[global::Cpp2ILInjected.Token(Token = "0x600119D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DB18", Offset = "0xA6DB18", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "GiveItem", MemberParameters = new object[]
	{
		typeof(short),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "SetTime", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00024BCF File Offset: 0x00022DCF
	[global::Cpp2ILInjected.Token(Token = "0x600119E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DBE0", Offset = "0xA6DBE0", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x00024BD2 File Offset: 0x00022DD2
	[global::Cpp2ILInjected.Token(Token = "0x600119F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B824", Offset = "0xA6B824", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_08_KillZombies()
	{
		throw null;
	}

	// Token: 0x04001B96 RID: 7062
	[global::Cpp2ILInjected.Token(Token = "0x400214A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool armourHead;

	// Token: 0x04001B97 RID: 7063
	[global::Cpp2ILInjected.Token(Token = "0x400214B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool armourBody;

	// Token: 0x04001B98 RID: 7064
	[global::Cpp2ILInjected.Token(Token = "0x400214C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool armourLegs;

	// Token: 0x04001B99 RID: 7065
	[global::Cpp2ILInjected.Token(Token = "0x400214D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13")]
	private bool complete;

	// Token: 0x04001B9A RID: 7066
	[global::Cpp2ILInjected.Token(Token = "0x400214E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool killing;

	// Token: 0x04001B9B RID: 7067
	[global::Cpp2ILInjected.Token(Token = "0x400214F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private DateTime killStart;
}
