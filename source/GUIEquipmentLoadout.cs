using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class GUIEquipmentLoadout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public bool Expanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private GUIInputRegionExclusive pickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private float buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private int loadoutOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private float HideShowButtonScale;

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x13823B0", Offset = "0x13823B0", VA = "0x13823B0")]
	public void CloseExpandedFilter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x138245C", Offset = "0x138245C", VA = "0x138245C")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x13825BC", Offset = "0x13825BC", VA = "0x13825BC")]
	public void DrawToggles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x1383C18", Offset = "0x1383C18", VA = "0x1383C18")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x1383A98", Offset = "0x1383A98", VA = "0x1383A98")]
	private void DrawLoadouts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x1383D5C", Offset = "0x1383D5C", VA = "0x1383D5C")]
	public float LoadoutScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x1383DB4", Offset = "0x1383DB4", VA = "0x1383DB4")]
	public void LoadoutOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x1383EFC", Offset = "0x1383EFC", VA = "0x1383EFC")]
	public void LoadoutDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x13845DC", Offset = "0x13845DC", VA = "0x13845DC")]
	public GUIEquipmentLoadout()
	{
	}
}
