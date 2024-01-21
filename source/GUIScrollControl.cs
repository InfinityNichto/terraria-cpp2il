using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000101")]
public class GUIScrollControl
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007AC")]
	private DraggableItemGrid_Layout currentScrollGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40007AD")]
	private int currentItemFrame;

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0xEE3AB4", Offset = "0xEE3AB4", VA = "0xEE3AB4")]
	public void SetScrollWindow(DraggableItemGrid_Layout item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0xEE3B3C", Offset = "0xEE3B3C", VA = "0xEE3B3C")]
	public bool IsGlobalScrollValid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0xEE3BCC", Offset = "0xEE3BCC", VA = "0xEE3BCC")]
	public GUIScrollControl()
	{
	}
}
