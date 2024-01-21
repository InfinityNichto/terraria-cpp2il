using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001EE")]
public class GUIOpenUIButtonSetting : GUISettingEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001658")]
	private float scale;

	[Cpp2IlInjected.Token(Token = "0x6000E30")]
	[Cpp2IlInjected.Address(RVA = "0xFF7D74", Offset = "0xFF7D74", VA = "0xFF7D74")]
	public GUIOpenUIButtonSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E31")]
	[Cpp2IlInjected.Address(RVA = "0xFF7D7C", Offset = "0xFF7D7C", VA = "0xFF7D7C", Slot = "7")]
	protected virtual SettingsOverlayListOption_Layout GetLayout()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E32")]
	[Cpp2IlInjected.Address(RVA = "0xFF7DD8", Offset = "0xFF7DD8", VA = "0xFF7DD8", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E33")]
	[Cpp2IlInjected.Address(RVA = "0xFF8CAC", Offset = "0xFF8CAC", VA = "0xFF8CAC", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E34")]
	[Cpp2IlInjected.Address(RVA = "0xFF84C4", Offset = "0xFF84C4", VA = "0xFF84C4")]
	private string GetButtonCaption()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E35")]
	[Cpp2IlInjected.Address(RVA = "0xFF80F8", Offset = "0xFF80F8", VA = "0xFF80F8")]
	private string GetOption()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E36")]
	[Cpp2IlInjected.Address(RVA = "0xFF8620", Offset = "0xFF8620", VA = "0xFF8620")]
	private void OpenUI()
	{
	}
}
