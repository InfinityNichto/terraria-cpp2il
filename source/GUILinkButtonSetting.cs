using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001ED")]
public class GUILinkButtonSetting : GUISettingEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001657")]
	private float scale;

	[Cpp2IlInjected.Token(Token = "0x6000E2A")]
	[Cpp2IlInjected.Address(RVA = "0xDF03F0", Offset = "0xDF03F0", VA = "0xDF03F0")]
	public GUILinkButtonSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E2B")]
	[Cpp2IlInjected.Address(RVA = "0xDF03F8", Offset = "0xDF03F8", VA = "0xDF03F8")]
	private string GetButtonCaption()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E2C")]
	[Cpp2IlInjected.Address(RVA = "0xDF0488", Offset = "0xDF0488", VA = "0xDF0488", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E2D")]
	[Cpp2IlInjected.Address(RVA = "0xDF0D64", Offset = "0xDF0D64", VA = "0xDF0D64", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E2E")]
	[Cpp2IlInjected.Address(RVA = "0xDF07A0", Offset = "0xDF07A0", VA = "0xDF07A0")]
	private string GetDisplayString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E2F")]
	[Cpp2IlInjected.Address(RVA = "0xDF0B20", Offset = "0xDF0B20", VA = "0xDF0B20")]
	private string GetLink()
	{
		return null;
	}
}
