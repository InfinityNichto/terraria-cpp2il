using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class GUIPlayerCreateController_HairStyle : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly GUIPlayerCreateController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public int maxRowIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public int maxRowColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public int currentScrollOffset
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x11421E4", Offset = "0x11421E4", VA = "0x11421E4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x11413E4", Offset = "0x11413E4", VA = "0x11413E4")]
	public GUIPlayerCreateController_HairStyle(GUIPlayerCreateController controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x1141D28", Offset = "0x1141D28", VA = "0x1141D28", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x11420A0", Offset = "0x11420A0", VA = "0x11420A0", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x11420A8", Offset = "0x11420A8", VA = "0x11420A8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x1141E4C", Offset = "0x1141E4C", VA = "0x1141E4C")]
	public void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x1142370", Offset = "0x1142370", VA = "0x1142370", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
