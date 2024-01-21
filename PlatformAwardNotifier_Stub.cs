using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001FB")]
public class PlatformAwardNotifier_Stub : IPlatformAwardNotifier
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001762")]
	private int lastTraveledPercent;

	[Cpp2IlInjected.Token(Token = "0x6000E98")]
	[Cpp2IlInjected.Address(RVA = "0x10B6550", Offset = "0x10B6550", VA = "0x10B6550", Slot = "4")]
	public void Initialize(LocalUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E99")]
	[Cpp2IlInjected.Address(RVA = "0x10B6554", Offset = "0x10B6554", VA = "0x10B6554", Slot = "5")]
	public void NoteSlimeDefeated(eSlimeKillStatistics slimeID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E9A")]
	[Cpp2IlInjected.Address(RVA = "0x10B6558", Offset = "0x10B6558", VA = "0x10B6558", Slot = "6")]
	public void NoteItemCrafted(eCraftingStatistics craftingID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E9B")]
	[Cpp2IlInjected.Address(RVA = "0x10B655C", Offset = "0x10B655C", VA = "0x10B655C", Slot = "7")]
	public void NoteTraveled(eDistanceStatistics distanceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E9C")]
	[Cpp2IlInjected.Address(RVA = "0x10B66B0", Offset = "0x10B66B0", VA = "0x10B66B0", Slot = "8")]
	public void NoteMined(eMiningStatistics miningID, int amount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E9D")]
	[Cpp2IlInjected.Address(RVA = "0x10B66B4", Offset = "0x10B66B4", VA = "0x10B66B4", Slot = "9")]
	public void NoteBossKill(eBossKillStatistics bossID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E9E")]
	[Cpp2IlInjected.Address(RVA = "0x10B66B8", Offset = "0x10B66B8", VA = "0x10B66B8", Slot = "10")]
	public void NoteTrigger(eTrigger triggerType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E9F")]
	[Cpp2IlInjected.Address(RVA = "0x10B4D30", Offset = "0x10B4D30", VA = "0x10B4D30")]
	public PlatformAwardNotifier_Stub()
	{
	}
}
