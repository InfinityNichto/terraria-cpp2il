using System;
using Cpp2ILInjected;

[global::Cpp2ILInjected.Token(Token = "0x20002A8")]
public interface IPlatformAwardNotifier
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FBD")]
	void Initialize(LocalUser user);

	[global::Cpp2ILInjected.Token(Token = "0x6000FBE")]
	void NoteSlimeDefeated(eSlimeKillStatistics slimeID);

	[global::Cpp2ILInjected.Token(Token = "0x6000FBF")]
	void NoteItemCrafted(eCraftingStatistics craftingID);

	[global::Cpp2ILInjected.Token(Token = "0x6000FC0")]
	void NoteTraveled(eDistanceStatistics distanceID);

	[global::Cpp2ILInjected.Token(Token = "0x6000FC1")]
	void NoteMined(eMiningStatistics miningID, int amount);

	[global::Cpp2ILInjected.Token(Token = "0x6000FC2")]
	void NoteBossKill(eBossKillStatistics bossID);

	[global::Cpp2ILInjected.Token(Token = "0x6000FC3")]
	void NoteTrigger(eTrigger triggerType);
}
