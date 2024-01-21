using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000099")]
public class GUIControllerPVP : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public bool insideSideIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public int sideRow;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int MaxRow
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x1213EB8", Offset = "0x1213EB8", VA = "0x1213EB8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int MaxColumns
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1213F2C", Offset = "0x1213F2C", VA = "0x1213F2C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1213E34", Offset = "0x1213E34", VA = "0x1213E34")]
	public GUIControllerPVP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1213E40", Offset = "0x1213E40", VA = "0x1213E40", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1213EB0", Offset = "0x1213EB0", VA = "0x1213EB0", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1213F9C", Offset = "0x1213F9C", VA = "0x1213F9C", Slot = "14")]
	protected virtual void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1213FF4", Offset = "0x1213FF4", VA = "0x1213FF4")]
	private int SideToRow(int side)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1214018", Offset = "0x1214018", VA = "0x1214018")]
	private int RowToSide(int row)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x121403C", Offset = "0x121403C", VA = "0x121403C", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x12146E4", Offset = "0x12146E4", VA = "0x12146E4", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
