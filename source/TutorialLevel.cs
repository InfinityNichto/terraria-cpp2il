using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[global::Cpp2ILInjected.Token(Token = "0x20002ED")]
public class TutorialLevel
{
	[global::Cpp2ILInjected.Token(Token = "0x6001158")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B290", Offset = "0xA6B290", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Begin()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001159")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B2F0", Offset = "0xA6B2F0", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600115A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B370", Offset = "0xA6B370", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HoverOverNPCs", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600115B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B3A0", Offset = "0xA6B3A0", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public string GetGuideString()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600115C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B41C", Offset = "0xA6B41C", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "SetupButtonText", MemberParameters = new object[]
	{
		typeof(ref string),
		typeof(ref Texture2D),
		typeof(ref string),
		typeof(ref Texture2D),
		typeof(ref int),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public bool IsComplete()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600115D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B434", Offset = "0xA6B434", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HoverOverNPCs", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void OnGuideDialogueOpen()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600115E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B460", Offset = "0xA6B460", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_PlaceIt", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(TileObject),
		typeof(int)
	}, ReturnType = typeof(TileObject))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void OnItemPlaced(int itemId, int tileType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600115F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B48C", Offset = "0xA6B48C", Length = "0x360")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialLevel), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep_11_Complete), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
	public TutorialLevel()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001160")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B83C", Offset = "0xA6B83C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialLevel), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	static TutorialLevel()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4002128")]
	public static TutorialLevel Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4002129")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public readonly TutorialStep[] Steps;

	[global::Cpp2ILInjected.Token(Token = "0x400212A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool JMSettingsDisabled;

	[global::Cpp2ILInjected.Token(Token = "0x400212B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
	public bool Enabled;

	[global::Cpp2ILInjected.Token(Token = "0x400212C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int activeStep;

	[global::Cpp2ILInjected.Token(Token = "0x400212D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string TutorialPopupText;
}
