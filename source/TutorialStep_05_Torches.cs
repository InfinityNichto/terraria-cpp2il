using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200023B RID: 571
[global::Cpp2ILInjected.Token(Token = "0x20002F4")]
public class TutorialStep_05_Torches : TutorialStep
{
	// Token: 0x06001035 RID: 4149 RVA: 0x00024B81 File Offset: 0x00022D81
	[global::Cpp2ILInjected.Token(Token = "0x6001184")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CB64", Offset = "0xA6CB64", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00024B84 File Offset: 0x00022D84
	[global::Cpp2ILInjected.Token(Token = "0x6001185")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CB6C", Offset = "0xA6CB6C", Length = "0x294")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00024B87 File Offset: 0x00022D87
	[global::Cpp2ILInjected.Token(Token = "0x6001186")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CE00", Offset = "0xA6CE00", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x00024B8A File Offset: 0x00022D8A
	[global::Cpp2ILInjected.Token(Token = "0x6001187")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CE08", Offset = "0xA6CE08", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00024B8D File Offset: 0x00022D8D
	[global::Cpp2ILInjected.Token(Token = "0x6001188")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CE84", Offset = "0xA6CE84", Length = "0x7C")]
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
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00024B90 File Offset: 0x00022D90
	[global::Cpp2ILInjected.Token(Token = "0x6001189")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6CF00", Offset = "0xA6CF00", Length = "0x24C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "StartRoomCheck", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RoomNeeds", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00024B93 File Offset: 0x00022D93
	[global::Cpp2ILInjected.Token(Token = "0x600118A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B80C", Offset = "0xA6B80C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_05_Torches()
	{
		throw null;
	}

	// Token: 0x04001B87 RID: 7047
	[global::Cpp2ILInjected.Token(Token = "0x400213B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool givenSword;

	// Token: 0x04001B88 RID: 7048
	[global::Cpp2ILInjected.Token(Token = "0x400213C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool collectedGels;

	// Token: 0x04001B89 RID: 7049
	[global::Cpp2ILInjected.Token(Token = "0x400213D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool craftedTorches;

	// Token: 0x04001B8A RID: 7050
	[global::Cpp2ILInjected.Token(Token = "0x400213E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13")]
	private bool torchesPlaced;
}
