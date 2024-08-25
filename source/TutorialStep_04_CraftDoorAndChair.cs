using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

[global::Cpp2ILInjected.Token(Token = "0x20002F3")]
public class TutorialStep_04_CraftDoorAndChair : TutorialStep
{
	[global::Cpp2ILInjected.Token(Token = "0x600117D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C9E4", Offset = "0xA6C9E4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600117E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6C9EC", Offset = "0xA6C9EC", Length = "0xF4")]
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

	[global::Cpp2ILInjected.Token(Token = "0x600117F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CAE0", Offset = "0xA6CAE0", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001180")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CAEC", Offset = "0xA6CAEC", Length = "0x10")]
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

	[global::Cpp2ILInjected.Token(Token = "0x6001181")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CAFC", Offset = "0xA6CAFC", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001182")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CB3C", Offset = "0xA6CB3C", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override bool Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001183")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B804", Offset = "0xA6B804", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_04_CraftDoorAndChair()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4002137")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool doorPlaced;

	[global::Cpp2ILInjected.Token(Token = "0x4002138")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool chairPlaced;

	[global::Cpp2ILInjected.Token(Token = "0x4002139")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool tablePlaced;

	[global::Cpp2ILInjected.Token(Token = "0x400213A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13")]
	private bool complete;
}
