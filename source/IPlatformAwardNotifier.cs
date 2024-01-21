using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000205")]
public interface IPlatformAwardNotifier
{
	[Cpp2IlInjected.Token(Token = "0x6000EA0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(LocalUser user);

	[Cpp2IlInjected.Token(Token = "0x6000EA1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NoteSlimeDefeated(eSlimeKillStatistics slimeID);

	[Cpp2IlInjected.Token(Token = "0x6000EA2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NoteItemCrafted(eCraftingStatistics craftingID);

	[Cpp2IlInjected.Token(Token = "0x6000EA3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NoteTraveled(eDistanceStatistics distanceID);

	[Cpp2IlInjected.Token(Token = "0x6000EA4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NoteMined(eMiningStatistics miningID, int amount);

	[Cpp2IlInjected.Token(Token = "0x6000EA5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NoteBossKill(eBossKillStatistics bossID);

	[Cpp2IlInjected.Token(Token = "0x6000EA6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NoteTrigger(eTrigger triggerType);
}
