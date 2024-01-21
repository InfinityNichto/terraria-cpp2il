using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class DrKeyboard_IME : DrKeyboard_Base
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int _lastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private string _lastIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private string _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool _wasCanceled;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool active
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x20CD678", Offset = "0x20CD678", VA = "0x20CD678", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20CD698", Offset = "0x20CD698", VA = "0x20CD698", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override bool done
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20CD6AC", Offset = "0x20CD6AC", VA = "0x20CD6AC", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override string text
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x20CD6B4", Offset = "0x20CD6B4", VA = "0x20CD6B4", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x20CD6BC", Offset = "0x20CD6BC", VA = "0x20CD6BC", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override bool wasCanceled
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x20CD6C4", Offset = "0x20CD6C4", VA = "0x20CD6C4", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20CD168", Offset = "0x20CD168", VA = "0x20CD168")]
	public DrKeyboard_IME(string initialText, int maxChars, string title, string prompt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x20CD6CC", Offset = "0x20CD6CC", VA = "0x20CD6CC", Slot = "10")]
	public override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x20CD924", Offset = "0x20CD924", VA = "0x20CD924")]
	private void Append(string input)
	{
	}
}
