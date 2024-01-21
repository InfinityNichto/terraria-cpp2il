using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class GUIAccessoryInfoToggles
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public bool Expanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private GUIInputRegionExclusive pickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private float buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private int accOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private float HideShowButtonScale;

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x1348DE0", Offset = "0x1348DE0", VA = "0x1348DE0")]
	public void CloseExpandedFilter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x1348E8C", Offset = "0x1348E8C", VA = "0x1348E8C")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x134900C", Offset = "0x134900C", VA = "0x134900C")]
	public void DrawToggles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x1349C30", Offset = "0x1349C30", VA = "0x1349C30")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x1349A78", Offset = "0x1349A78", VA = "0x1349A78")]
	private void DrawInfoAccesoriesToggles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x1349D74", Offset = "0x1349D74", VA = "0x1349D74")]
	public float InfoAccScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x1349DCC", Offset = "0x1349DCC", VA = "0x1349DCC")]
	public void InfoAccOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x134A16C", Offset = "0x134A16C", VA = "0x134A16C")]
	public void InfoAccDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x134AB68", Offset = "0x134AB68", VA = "0x134AB68")]
	public GUIAccessoryInfoToggles()
	{
	}
}
