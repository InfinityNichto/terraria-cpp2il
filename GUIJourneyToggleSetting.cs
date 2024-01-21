using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000112")]
public class GUIJourneyToggleSetting : GUIToggleSetting
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400087F")]
	private float iconScale;

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0xDE96B0", Offset = "0xDE96B0", VA = "0xDE96B0")]
	public GUIJourneyToggleSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xDE96B8", Offset = "0xDE96B8", VA = "0xDE96B8", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0xDE9830", Offset = "0xDE9830", VA = "0xDE9830", Slot = "7")]
	protected override SettingsOverlayToggle_Layout GetLayout()
	{
		return null;
	}
}
