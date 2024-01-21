using Cpp2IlInjected;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class GUIInventoryTransactions
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private float sellButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private float equipButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private float depositButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	public bool canBeDeposited;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Item SelectedItem
	{
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x1368040", Offset = "0x1368040", VA = "0x1368040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x13680F4", Offset = "0x13680F4", VA = "0x13680F4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x13680F8", Offset = "0x13680F8", VA = "0x13680F8")]
	public void SellItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0x13682F0", Offset = "0x13682F0", VA = "0x13682F0")]
	public void EquipItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0x13686E8", Offset = "0x13686E8", VA = "0x13686E8")]
	public void PlaceItemDoll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x13689E0", Offset = "0x13689E0", VA = "0x13689E0")]
	public void PlaceItemHat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x1368C44", Offset = "0x1368C44", VA = "0x1368C44")]
	public void DepositItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000832")]
	[Cpp2IlInjected.Address(RVA = "0x1368D2C", Offset = "0x1368D2C", VA = "0x1368D2C")]
	public GUIInventoryTransactions()
	{
	}
}
