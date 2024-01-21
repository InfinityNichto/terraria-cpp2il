using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200010F")]
public class GUIJourneyButtonSetting : GUIOpenUIButtonSetting
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400087A")]
	private float iconScale;

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x1372238", Offset = "0x1372238", VA = "0x1372238")]
	public GUIJourneyButtonSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x1372240", Offset = "0x1372240", VA = "0x1372240", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x1372988", Offset = "0x1372988", VA = "0x1372988", Slot = "7")]
	protected override SettingsOverlayListOption_Layout GetLayout()
	{
		return null;
	}
}
