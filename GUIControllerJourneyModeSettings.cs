using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GUIControllerJourneyModeSettings : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000786")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x40078F6")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x40078F7")]
		Weather,
		[Cpp2IlInjected.Token(Token = "0x40078F8")]
		Power,
		[Cpp2IlInjected.Token(Token = "0x40078F9")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x40078FA")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public GUIPulldownSetting _overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public Rectangle _overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public int _overlayIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public float _overlayOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private int _selectedItem;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xF6A118", Offset = "0xF6A118", VA = "0xF6A118")]
	public void SelectedSetting(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xF6A128", Offset = "0xF6A128", VA = "0xF6A128", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xF6A3A0", Offset = "0xF6A3A0", VA = "0xF6A3A0", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xF6A134", Offset = "0xF6A134", VA = "0xF6A134")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xF6A3A8", Offset = "0xF6A3A8", VA = "0xF6A3A8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xF6A594", Offset = "0xF6A594", VA = "0xF6A594")]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xF6A5BC", Offset = "0xF6A5BC", VA = "0xF6A5BC")]
	public void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0xF6A5C8", Offset = "0xF6A5C8", VA = "0xF6A5C8")]
	public bool OverlayActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xF6A5D8", Offset = "0xF6A5D8", VA = "0xF6A5D8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xF6AA4C", Offset = "0xF6AA4C", VA = "0xF6AA4C")]
	public GUIControllerJourneyModeSettings()
	{
	}
}
