using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000103")]
public class GUISettingsPauseMenu
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007B4")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40007B5")]
	private GUIContollerTransactionButtonList _controllerList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007B6")]
	private float settingsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40007B7")]
	private float HomeButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007B8")]
	private float AchievementsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	private float BestiaryButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007BA")]
	private float JourneySettingsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40007BB")]
	private float CloseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007BC")]
	private bool creativeModeActive;

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0xEEDEBC", Offset = "0xEEDEBC", VA = "0xEEDEBC")]
	private void SetupCreavieModeOffset(bool setup)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0xEE8E20", Offset = "0xEE8E20", VA = "0xEE8E20")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0xEEDF84", Offset = "0xEEDF84", VA = "0xEEDF84")]
	public GUISettingsPauseMenu()
	{
	}
}
