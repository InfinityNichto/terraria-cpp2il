using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000084")]
public class GUIControllerCrafting : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public int scrollOffset;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private int MinRow
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x12919BC", Offset = "0x12919BC", VA = "0x12919BC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int MinColumns
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1291630", Offset = "0x1291630", VA = "0x1291630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1291240", Offset = "0x1291240", VA = "0x1291240")]
	public GUIControllerCrafting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x129124C", Offset = "0x129124C", VA = "0x129124C", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x1291254", Offset = "0x1291254", VA = "0x1291254", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x12913C0", Offset = "0x12913C0", VA = "0x12913C0", Slot = "14")]
	public virtual void RefreshScrollOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1291714", Offset = "0x1291714", VA = "0x1291714", Slot = "15")]
	protected virtual void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1291A40", Offset = "0x1291A40", VA = "0x1291A40", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1291B3C", Offset = "0x1291B3C", VA = "0x1291B3C", Slot = "16")]
	protected virtual void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1291CC8", Offset = "0x1291CC8", VA = "0x1291CC8", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
