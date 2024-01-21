using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GUIControllerChat : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000785")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x40078EC")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40078ED")]
		RPS,
		[Cpp2IlInjected.Token(Token = "0x40078EE")]
		Items,
		[Cpp2IlInjected.Token(Token = "0x40078EF")]
		BiomesAndEvents,
		[Cpp2IlInjected.Token(Token = "0x40078F0")]
		TownNPCs,
		[Cpp2IlInjected.Token(Token = "0x40078F1")]
		Critters,
		[Cpp2IlInjected.Token(Token = "0x40078F2")]
		Bosses,
		[Cpp2IlInjected.Token(Token = "0x40078F3")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x40078F4")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Controls selectedControl;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static float maxScrollOffset;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int lineSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int SelectedRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private int SelectedColumn;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private static int maxRowIndex
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xF8F954", Offset = "0xF8F954", VA = "0xF8F954")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private static int maxRowColumn
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xF8FA04", Offset = "0xF8FA04", VA = "0xF8FA04")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xF8F858", Offset = "0xF8F858", VA = "0xF8F858", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xF8F94C", Offset = "0xF8F94C", VA = "0xF8F94C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xF8FAB0", Offset = "0xF8FAB0", VA = "0xF8FAB0")]
	private void UpdateEmoteScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0xF8FD9C", Offset = "0xF8FD9C", VA = "0xF8FD9C")]
	private static void UpdateScrollRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xF900E8", Offset = "0xF900E8", VA = "0xF900E8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0xF907B4", Offset = "0xF907B4", VA = "0xF907B4", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xF90EA0", Offset = "0xF90EA0", VA = "0xF90EA0")]
	public GUIControllerChat()
	{
	}
}
