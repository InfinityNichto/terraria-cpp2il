using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Achievements;

[global::Cpp2ILInjected.Token(Token = "0x200029F")]
public class PlatformAwardNotifier_Stub : IPlatformAwardNotifier
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FB5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39B70", Offset = "0xA39B70", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Initialize(LocalUser user)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FB6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39B74", Offset = "0xA39B74", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void NoteSlimeDefeated(eSlimeKillStatistics slimeID)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FB7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39B78", Offset = "0xA39B78", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void NoteItemCrafted(eCraftingStatistics craftingID)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FB8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39B7C", Offset = "0xA39B7C", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(AchievementCondition))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void NoteTraveled(eDistanceStatistics distanceID)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FB9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39CA4", Offset = "0xA39CA4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void NoteMined(eMiningStatistics miningID, int amount)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FBA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39CA8", Offset = "0xA39CA8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void NoteBossKill(eBossKillStatistics bossID)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FBB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39CAC", Offset = "0xA39CAC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void NoteTrigger(eTrigger triggerType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FBC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39CB0", Offset = "0xA39CB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public PlatformAwardNotifier_Stub()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001C80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int lastTraveledPercent;
}
