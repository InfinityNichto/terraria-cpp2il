using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000093")]
public class GUIControllerInventory : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public int toolRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public int toolColumn;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private static int MaxRowIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xF67928", Offset = "0xF67928", VA = "0xF67928")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private static int MaxColumnIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xF679E0", Offset = "0xF679E0", VA = "0xF679E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xF6760C", Offset = "0xF6760C", VA = "0xF6760C")]
	public GUIControllerInventory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0xF67618", Offset = "0xF67618", VA = "0xF67618", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xF67754", Offset = "0xF67754", VA = "0xF67754")]
	public static GUIControllerItem NavigateIntoCoinsAmmo(int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xF67840", Offset = "0xF67840", VA = "0xF67840", Slot = "13")]
	public virtual void NavigateToItem(int item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0xF67A64", Offset = "0xF67A64", VA = "0xF67A64", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0xF67CF4", Offset = "0xF67CF4", VA = "0xF67CF4", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
