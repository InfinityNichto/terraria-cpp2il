using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200009D")]
public class GUIControllerReforge : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int MinRow
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1218AA8", Offset = "0x1218AA8", VA = "0x1218AA8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int MinColumns
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1218B2C", Offset = "0x1218B2C", VA = "0x1218B2C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x1217FCC", Offset = "0x1217FCC", VA = "0x1217FCC")]
	public GUIControllerReforge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x1218AA4", Offset = "0x1218AA4", VA = "0x1218AA4", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x1218BF0", Offset = "0x1218BF0", VA = "0x1218BF0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x1218CCC", Offset = "0x1218CCC", VA = "0x1218CCC")]
	private void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x1218D24", Offset = "0x1218D24", VA = "0x1218D24", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x1218F90", Offset = "0x1218F90", VA = "0x1218F90", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}
}
