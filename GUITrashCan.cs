using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000106")]
public class GUITrashCan
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private bool itemDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40007CF")]
	private bool overTrashCan;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40007D0")]
	private bool cursorOverTrashCan;

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0xECEE18", Offset = "0xECEE18", VA = "0xECEE18")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600099E")]
	[Cpp2IlInjected.Address(RVA = "0xECEE70", Offset = "0xECEE70", VA = "0xECEE70")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0xECF1D0", Offset = "0xECF1D0", VA = "0xECF1D0")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0xECF4E4", Offset = "0xECF4E4", VA = "0xECF4E4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0xECF800", Offset = "0xECF800", VA = "0xECF800")]
	public GUITrashCan()
	{
	}
}
