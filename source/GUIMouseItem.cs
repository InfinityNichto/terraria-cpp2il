using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class GUIMouseItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private int mouseDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private bool mouseItemHoldDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private bool disableDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private int disableDragStart;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool HoldingItem
	{
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x11E04C0", Offset = "0x11E04C0", VA = "0x11E04C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool BeingDragged
	{
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x11E057C", Offset = "0x11E057C", VA = "0x11E057C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool IsItemDropped
	{
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x11E0584", Offset = "0x11E0584", VA = "0x11E0584")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0x11E0848", Offset = "0x11E0848", VA = "0x11E0848")]
	public void BeginDrag(bool dragging)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0x11E08D0", Offset = "0x11E08D0", VA = "0x11E08D0")]
	public void DisableDrag()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088A")]
	[Cpp2IlInjected.Address(RVA = "0x11E0958", Offset = "0x11E0958", VA = "0x11E0958")]
	public GUIMouseItem()
	{
	}
}
