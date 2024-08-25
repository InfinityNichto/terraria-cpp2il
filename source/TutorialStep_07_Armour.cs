using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

[global::Cpp2ILInjected.Token(Token = "0x20002F6")]
public class TutorialStep_07_Armour : TutorialStep
{
	[global::Cpp2ILInjected.Token(Token = "0x6001192")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D32C", Offset = "0xA6D32C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001193")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D334", Offset = "0xA6D334", Length = "0x2FC")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public override string GetGuideString()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001194")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D630", Offset = "0xA6D630", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001195")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D638", Offset = "0xA6D638", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001196")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D668", Offset = "0xA6D668", Length = "0x74")]
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
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001197")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D6DC", Offset = "0xA6D6DC", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override bool Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001198")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B81C", Offset = "0xA6B81C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_07_Armour()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4002142")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool furnacePlaced;

	[global::Cpp2ILInjected.Token(Token = "0x4002143")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool collectedBars;

	[global::Cpp2ILInjected.Token(Token = "0x4002144")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool anvilPlaced;

	[global::Cpp2ILInjected.Token(Token = "0x4002145")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13")]
	private bool copperGiven;

	[global::Cpp2ILInjected.Token(Token = "0x4002146")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool armourHead;

	[global::Cpp2ILInjected.Token(Token = "0x4002147")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	private bool armourBody;

	[global::Cpp2ILInjected.Token(Token = "0x4002148")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
	private bool armourLegs;

	[global::Cpp2ILInjected.Token(Token = "0x4002149")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x17")]
	private bool complete;
}
