using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001DC")]
public class GUIPlayerAndGameModeMismatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40014D2")]
	public bool WarningDisplayed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40014D3")]
	private float statusScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40014D4")]
	private float backScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40014D5")]
	private string messageText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40014D6")]
	private GUIControllerPlayerAndGameModeMistmatch _inputController;

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x1140C9C", Offset = "0x1140C9C", VA = "0x1140C9C")]
	public bool CheckMismatch(int playerGameMode, int worldGameMode)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x1140D60", Offset = "0x1140D60", VA = "0x1140D60")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x1140FC8", Offset = "0x1140FC8", VA = "0x1140FC8")]
	private void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x11410FC", Offset = "0x11410FC", VA = "0x11410FC")]
	public GUIPlayerAndGameModeMismatch()
	{
	}
}
