using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000095")]
public class GUIControllerItemDuplication : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public int scrollOffset;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int MinRow
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xF6930C", Offset = "0xF6930C", VA = "0xF6930C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int MinColumns
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xF68F80", Offset = "0xF68F80", VA = "0xF68F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xF68BA4", Offset = "0xF68BA4", VA = "0xF68BA4")]
	public GUIControllerItemDuplication()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xF68BB0", Offset = "0xF68BB0", VA = "0xF68BB0", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0xF68BB8", Offset = "0xF68BB8", VA = "0xF68BB8", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xF68D10", Offset = "0xF68D10", VA = "0xF68D10", Slot = "14")]
	public virtual void RefreshScrollOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0xF69064", Offset = "0xF69064", VA = "0xF69064", Slot = "15")]
	protected virtual void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xF69390", Offset = "0xF69390", VA = "0xF69390", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0xF6948C", Offset = "0xF6948C", VA = "0xF6948C", Slot = "16")]
	protected virtual void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xF69618", Offset = "0xF69618", VA = "0xF69618", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
