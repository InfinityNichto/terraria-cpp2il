using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GUIControllerSettingsOverlay : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x200078C")]
	private enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x4007911")]
		PageSettings,
		[Cpp2IlInjected.Token(Token = "0x4007912")]
		PageInterface,
		[Cpp2IlInjected.Token(Token = "0x4007913")]
		PageVideo,
		[Cpp2IlInjected.Token(Token = "0x4007914")]
		PageSound,
		[Cpp2IlInjected.Token(Token = "0x4007915")]
		PageControls,
		[Cpp2IlInjected.Token(Token = "0x4007916")]
		PageTouch,
		[Cpp2IlInjected.Token(Token = "0x4007917")]
		PageController,
		[Cpp2IlInjected.Token(Token = "0x4007918")]
		PageKeyboard,
		[Cpp2IlInjected.Token(Token = "0x4007919")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x400791A")]
		Reset,
		[Cpp2IlInjected.Token(Token = "0x400791B")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public GUIPulldownSetting _overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public Rectangle _overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public int _overlayIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public float _overlayOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private int _selectedItem;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x121BE84", Offset = "0x121BE84", VA = "0x121BE84")]
	public void SelectedSetting(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x121BE94", Offset = "0x121BE94", VA = "0x121BE94", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x121C114", Offset = "0x121C114", VA = "0x121C114", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x121BEA8", Offset = "0x121BEA8", VA = "0x121BEA8")]
	public void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x121C11C", Offset = "0x121C11C", VA = "0x121C11C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x121C42C", Offset = "0x121C42C", VA = "0x121C42C")]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x121C454", Offset = "0x121C454", VA = "0x121C454")]
	public void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x121C460", Offset = "0x121C460", VA = "0x121C460")]
	public bool OverlayActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x121C470", Offset = "0x121C470", VA = "0x121C470", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x121CA7C", Offset = "0x121CA7C", VA = "0x121CA7C")]
	public GUIControllerSettingsOverlay()
	{
	}
}
