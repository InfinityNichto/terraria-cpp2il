using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001F0")]
public class GUISettingEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001663")]
	public GUISettingID _id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001664")]
	public int _sortId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001665")]
	public SettingsOverlayOptionCategories_Layout.Category _category;

	[Cpp2IlInjected.Token(Token = "0x6000E49")]
	[Cpp2IlInjected.Address(RVA = "0xEE3BDC", Offset = "0xEE3BDC", VA = "0xEE3BDC")]
	public GUISettingEntry(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E4A")]
	[Cpp2IlInjected.Address(RVA = "0xEE3BFC", Offset = "0xEE3BFC", VA = "0xEE3BFC", Slot = "4")]
	public virtual void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E4B")]
	[Cpp2IlInjected.Address(RVA = "0xEE3C00", Offset = "0xEE3C00", VA = "0xEE3C00", Slot = "5")]
	public virtual float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E4C")]
	[Cpp2IlInjected.Address(RVA = "0xEE3C08", Offset = "0xEE3C08", VA = "0xEE3C08", Slot = "6")]
	public virtual void DrawOverlay()
	{
	}
}
