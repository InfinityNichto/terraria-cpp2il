using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

// Token: 0x0200023F RID: 575
[global::Cpp2ILInjected.Token(Token = "0x20002F8")]
public class TutorialStep_09_Bestiary : TutorialStep
{
	// Token: 0x06001051 RID: 4177 RVA: 0x00024BD5 File Offset: 0x00022DD5
	[global::Cpp2ILInjected.Token(Token = "0x60011A0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DD40", Offset = "0xA6DD40", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00024BD8 File Offset: 0x00022DD8
	[global::Cpp2ILInjected.Token(Token = "0x60011A1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DD48", Offset = "0xA6DD48", Length = "0x12C")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00024BDB File Offset: 0x00022DDB
	[global::Cpp2ILInjected.Token(Token = "0x60011A2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DE74", Offset = "0xA6DE74", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override void Begin()
	{
		throw null;
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00024BDE File Offset: 0x00022DDE
	[global::Cpp2ILInjected.Token(Token = "0x60011A3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DED0", Offset = "0xA6DED0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00024BE1 File Offset: 0x00022DE1
	[global::Cpp2ILInjected.Token(Token = "0x60011A4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DED8", Offset = "0xA6DED8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00024BE4 File Offset: 0x00022DE4
	[global::Cpp2ILInjected.Token(Token = "0x60011A5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6DEDC", Offset = "0xA6DEDC", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00024BE7 File Offset: 0x00022DE7
	[global::Cpp2ILInjected.Token(Token = "0x60011A6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B82C", Offset = "0xA6B82C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_09_Bestiary()
	{
		throw null;
	}

	// Token: 0x04001B9C RID: 7068
	[global::Cpp2ILInjected.Token(Token = "0x4002150")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool openedBestiary;
}
