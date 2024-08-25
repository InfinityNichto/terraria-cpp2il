using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.GameContent.Creative;

[global::Cpp2ILInjected.Token(Token = "0x20002EE")]
public class TutorialStep
{
	[global::Cpp2ILInjected.Token(Token = "0x6001161")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B894", Offset = "0xA6B894", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Reset()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001162")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B898", Offset = "0xA6B898", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Begin()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001163")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B89C", Offset = "0xA6B89C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001164")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B8A4", Offset = "0xA6B8A4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001165")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B8AC", Offset = "0xA6B8AC", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public virtual string GetGuideString()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001166")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B8F4", Offset = "0xA6B8F4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void OnGuideDialogueOpen()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001167")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B8F8", Offset = "0xA6B8F8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void OnItemPlaced(int itemId, int tileType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001168")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B8FC", Offset = "0xA6B8FC", Length = "0x158")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_01_WelcomeDialogue), Member = "Update", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_02_CopperPickaxe), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_03_CraftWorkbench), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_04_CraftDoorAndChair), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_05_Torches), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_07_Armour), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_08_KillZombies), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	protected void SetTime(int hour, int min, bool freeze)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001169")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6BA54", Offset = "0xA6BA54", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_01_WelcomeDialogue), Member = "Update", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_02_CopperPickaxe), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_05_Torches), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "AttemptPushingChange", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	protected void SetSpawnRate(float spawnRate)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600116A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6BACC", Offset = "0xA6BACC", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_02_CopperPickaxe), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_05_Torches), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_06_Mining), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_07_Armour), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_08_KillZombies), Member = "OnGuideDialogueOpen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "DepositHeldItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	protected void GiveItem(short item, int stackCount)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600116B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6BC20", Offset = "0xA6BC20", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_11_Complete), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20002EF")]
	public enum GuideOverLoadState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400212F")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4002130")]
		StepInProgessDialogue,
		[global::Cpp2ILInjected.Token(Token = "0x4002131")]
		StepCompleteDialogue
	}
}
