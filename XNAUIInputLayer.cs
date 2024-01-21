using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001F4")]
public class XNAUIInputLayer
{
	[Cpp2IlInjected.Token(Token = "0x400170D")]
	public static XNAUIInputLayer Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400170E")]
	public CursorInputLayer _inputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400170F")]
	public CursorInputLayer _inputLayer2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001710")]
	public CursorInputLayer _worldInputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001711")]
	public int UICrusorDraggingFromAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001712")]
	public bool UICrusorDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4001713")]
	public bool HadUICursor;

	[Cpp2IlInjected.Token(Token = "0x4001714")]
	private const float TimeForUIMouseFade = 1f;

	[Cpp2IlInjected.Token(Token = "0x4001715")]
	private const float TimeForFullUIMouse = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001716")]
	public float _timeWithoutUICursor;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public static float UITextAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0x14FED38", Offset = "0x14FED38", VA = "0x14FED38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000E63")]
	[Cpp2IlInjected.Address(RVA = "0x14FE158", Offset = "0x14FE158", VA = "0x14FE158")]
	public XNAUIInputLayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E64")]
	[Cpp2IlInjected.Address(RVA = "0x14FE2D8", Offset = "0x14FE2D8", VA = "0x14FE2D8")]
	public void CaptureUICrusorDrag(int dragFromAxis = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E65")]
	[Cpp2IlInjected.Address(RVA = "0x14FE2F4", Offset = "0x14FE2F4", VA = "0x14FE2F4")]
	public void CancelUICrusorDrag()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E66")]
	[Cpp2IlInjected.Address(RVA = "0x14FE300", Offset = "0x14FE300", VA = "0x14FE300")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E67")]
	[Cpp2IlInjected.Address(RVA = "0x14FE600", Offset = "0x14FE600", VA = "0x14FE600")]
	public void UpdateCursorSecondary(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E68")]
	[Cpp2IlInjected.Address(RVA = "0x14FE748", Offset = "0x14FE748", VA = "0x14FE748")]
	public void CaptureWorldCursor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E69")]
	[Cpp2IlInjected.Address(RVA = "0x14FE89C", Offset = "0x14FE89C", VA = "0x14FE89C")]
	public void WorldUpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E6A")]
	[Cpp2IlInjected.Address(RVA = "0x14FE8A0", Offset = "0x14FE8A0", VA = "0x14FE8A0")]
	public void ResetTimeWithoutCursor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E6B")]
	[Cpp2IlInjected.Address(RVA = "0x14FE8AC", Offset = "0x14FE8AC", VA = "0x14FE8AC")]
	public void Update(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E6D")]
	[Cpp2IlInjected.Address(RVA = "0x14FEDFC", Offset = "0x14FEDFC", VA = "0x14FEDFC")]
	public static float UITextAlphaCustom(float _timeForFullUIMouse, float _timeForUIMouseFade = 1f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E6E")]
	[Cpp2IlInjected.Address(RVA = "0x14FEAD8", Offset = "0x14FEAD8", VA = "0x14FEAD8")]
	public Cursor GetUICursor()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E6F")]
	[Cpp2IlInjected.Address(RVA = "0x14FE768", Offset = "0x14FE768", VA = "0x14FE768")]
	public Cursor GetWorldCursor()
	{
		return null;
	}
}
