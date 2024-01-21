using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GUIKeyboardMappingOverlay : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x200078E")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x4007925")]
		PageGeneral,
		[Cpp2IlInjected.Token(Token = "0x4007926")]
		PageExplore,
		[Cpp2IlInjected.Token(Token = "0x4007927")]
		PageFight,
		[Cpp2IlInjected.Token(Token = "0x4007928")]
		PageMisc,
		[Cpp2IlInjected.Token(Token = "0x4007929")]
		PageMap,
		[Cpp2IlInjected.Token(Token = "0x400792A")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x400792B")]
		Reset,
		[Cpp2IlInjected.Token(Token = "0x400792C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400792D")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public GUIKeyboardMappingEntry _overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public Rectangle _overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public int _overlayIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public float _overlayOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public int _selectedItem;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xDEAD9C", Offset = "0xDEAD9C", VA = "0xDEAD9C", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xDEB0BC", Offset = "0xDEB0BC", VA = "0xDEB0BC", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xDEADA8", Offset = "0xDEADA8", VA = "0xDEADA8")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0xDEB0C4", Offset = "0xDEB0C4", VA = "0xDEB0C4", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0xDEA99C", Offset = "0xDEA99C", VA = "0xDEA99C")]
	public void ActivateOverlay(GUIKeyboardMappingEntry overlayEntry, Rectangle overlayRegion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xDEA958", Offset = "0xDEA958", VA = "0xDEA958")]
	public void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xDEB308", Offset = "0xDEB308", VA = "0xDEB308", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xDEB884", Offset = "0xDEB884", VA = "0xDEB884")]
	public GUIKeyboardMappingOverlay()
	{
	}
}
