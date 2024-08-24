using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000235 RID: 565
[global::Cpp2ILInjected.Token(Token = "0x20002ED")]
public class TutorialLevel
{
	// Token: 0x06001009 RID: 4105 RVA: 0x00024AFD File Offset: 0x00022CFD
	[global::Cpp2ILInjected.Token(Token = "0x6001158")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B290", Offset = "0xA6B290", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Begin()
	{
		throw null;
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00024B00 File Offset: 0x00022D00
	[global::Cpp2ILInjected.Token(Token = "0x6001159")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B2F0", Offset = "0xA6B2F0", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00024B03 File Offset: 0x00022D03
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

	// Token: 0x0600100C RID: 4108 RVA: 0x00024B06 File Offset: 0x00022D06
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

	// Token: 0x0600100D RID: 4109 RVA: 0x00024B09 File Offset: 0x00022D09
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

	// Token: 0x0600100E RID: 4110 RVA: 0x00024B0C File Offset: 0x00022D0C
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

	// Token: 0x0600100F RID: 4111 RVA: 0x00024B0F File Offset: 0x00022D0F
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

	// Token: 0x06001010 RID: 4112 RVA: 0x00024B12 File Offset: 0x00022D12
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

	// Token: 0x06001011 RID: 4113 RVA: 0x00024B15 File Offset: 0x00022D15
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

	// Token: 0x04001B78 RID: 7032
	[global::Cpp2ILInjected.Token(Token = "0x4002128")]
	public static TutorialLevel Instance;

	// Token: 0x04001B79 RID: 7033
	[global::Cpp2ILInjected.Token(Token = "0x4002129")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public readonly TutorialStep[] Steps;

	// Token: 0x04001B7A RID: 7034
	[global::Cpp2ILInjected.Token(Token = "0x400212A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool JMSettingsDisabled;

	// Token: 0x04001B7B RID: 7035
	[global::Cpp2ILInjected.Token(Token = "0x400212B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
	public bool Enabled;

	// Token: 0x04001B7C RID: 7036
	[global::Cpp2ILInjected.Token(Token = "0x400212C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int activeStep;

	// Token: 0x04001B7D RID: 7037
	[global::Cpp2ILInjected.Token(Token = "0x400212D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string TutorialPopupText;
}
