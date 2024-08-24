using System;
using Cpp2ILInjected;

// Token: 0x02000203 RID: 515
[global::Cpp2ILInjected.Token(Token = "0x20002A8")]
public interface IPlatformAwardNotifier
{
	// Token: 0x06000E8D RID: 3725
	[global::Cpp2ILInjected.Token(Token = "0x6000FBD")]
	void Initialize(LocalUser user);

	// Token: 0x06000E8E RID: 3726
	[global::Cpp2ILInjected.Token(Token = "0x6000FBE")]
	void NoteSlimeDefeated(eSlimeKillStatistics slimeID);

	// Token: 0x06000E8F RID: 3727
	[global::Cpp2ILInjected.Token(Token = "0x6000FBF")]
	void NoteItemCrafted(eCraftingStatistics craftingID);

	// Token: 0x06000E90 RID: 3728
	[global::Cpp2ILInjected.Token(Token = "0x6000FC0")]
	void NoteTraveled(eDistanceStatistics distanceID);

	// Token: 0x06000E91 RID: 3729
	[global::Cpp2ILInjected.Token(Token = "0x6000FC1")]
	void NoteMined(eMiningStatistics miningID, int amount);

	// Token: 0x06000E92 RID: 3730
	[global::Cpp2ILInjected.Token(Token = "0x6000FC2")]
	void NoteBossKill(eBossKillStatistics bossID);

	// Token: 0x06000E93 RID: 3731
	[global::Cpp2ILInjected.Token(Token = "0x6000FC3")]
	void NoteTrigger(eTrigger triggerType);
}
