using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200008C")]
public class GUIControllerEquipment : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public bool inAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public bool inLoadout;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private int MinColumnAccesories
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x129883C", Offset = "0x129883C", VA = "0x129883C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private int MinRowLastColumnAccesories
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x12988B4", Offset = "0x12988B4", VA = "0x12988B4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1298614", Offset = "0x1298614", VA = "0x1298614")]
	public GUIControllerEquipment()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1298620", Offset = "0x1298620", VA = "0x1298620", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1298624", Offset = "0x1298624", VA = "0x1298624", Slot = "13")]
	public virtual void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1298628", Offset = "0x1298628", VA = "0x1298628", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1298934", Offset = "0x1298934", VA = "0x1298934", Slot = "14")]
	public virtual void ClampAccessories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x12989D4", Offset = "0x12989D4", VA = "0x12989D4", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
