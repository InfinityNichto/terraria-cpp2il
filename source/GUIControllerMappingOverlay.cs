using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GUIControllerMappingOverlay : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000782")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x40078D7")]
		PageGeneral,
		[Cpp2IlInjected.Token(Token = "0x40078D8")]
		PageExplore,
		[Cpp2IlInjected.Token(Token = "0x40078D9")]
		PageFight,
		[Cpp2IlInjected.Token(Token = "0x40078DA")]
		PageMisc,
		[Cpp2IlInjected.Token(Token = "0x40078DB")]
		PageInventory,
		[Cpp2IlInjected.Token(Token = "0x40078DC")]
		PageChest,
		[Cpp2IlInjected.Token(Token = "0x40078DD")]
		PageEquipment,
		[Cpp2IlInjected.Token(Token = "0x40078DE")]
		PageShopsCraft,
		[Cpp2IlInjected.Token(Token = "0x40078DF")]
		PagePVP,
		[Cpp2IlInjected.Token(Token = "0x40078E0")]
		PageMap,
		[Cpp2IlInjected.Token(Token = "0x40078E1")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x40078E2")]
		Reset,
		[Cpp2IlInjected.Token(Token = "0x40078E3")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public GUIControllerMappingEntryBase _overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Rectangle _overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public int _overlayIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public float _overlayOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public int _selectedItem;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xF6E4E0", Offset = "0xF6E4E0", VA = "0xF6E4E0", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0xF6E744", Offset = "0xF6E744", VA = "0xF6E744", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xF6E4EC", Offset = "0xF6E4EC", VA = "0xF6E4EC")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xF6E74C", Offset = "0xF6E74C", VA = "0xF6E74C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xF6DD9C", Offset = "0xF6DD9C", VA = "0xF6DD9C")]
	public void ActivateOverlay(GUIControllerMappingEntry overlayEntry, Rectangle overlayRegion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xF6EA30", Offset = "0xF6EA30", VA = "0xF6EA30")]
	public void ActivateOverlay(GUIControllerPulldownEntry overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xF6DE8C", Offset = "0xF6DE8C", VA = "0xF6DE8C")]
	public void DeactivateOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xF6EA58", Offset = "0xF6EA58", VA = "0xF6EA58", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0xF6F0F8", Offset = "0xF6F0F8", VA = "0xF6F0F8")]
	public GUIControllerMappingOverlay()
	{
	}
}
