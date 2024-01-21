using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001E3")]
public class GUISettingsOverlay
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001552")]
	private List<GUISettingEntry> _allSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001553")]
	public List<GUISettingEntry> _categorySettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001554")]
	public GUIControllerSettingsOverlay _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001555")]
	public SettingsOverlayOptionCategories_Layout.Category Selected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001556")]
	public int PendingSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001557")]
	private int disableScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001558")]
	private GUISettingEntry overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001559")]
	private Rectangle overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400155A")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400155B")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400155C")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400155D")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400155E")]
	private bool unconfiguredControllerAttached;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400155F")]
	private float titleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001560")]
	private float GeneralButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001561")]
	private float CursorButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001562")]
	private float VideoButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001563")]
	private float LanguageButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001564")]
	private float SaveAndCloseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001565")]
	private float AchievementsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001566")]
	private float InterfaceButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001567")]
	private float InfoButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001568")]
	private float ResetSettingsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001569")]
	private float KeyboardMouseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400156A")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400156B")]
	private SettingsOverlayOptionCategories_Layout.Category[] TabOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400156C")]
	private bool hasFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400156D")]
	private GUIInputRegionExclusive _categoriesBlocker;

	[Cpp2IlInjected.Token(Token = "0x6000D66")]
	[Cpp2IlInjected.Address(RVA = "0xEE68BC", Offset = "0xEE68BC", VA = "0xEE68BC")]
	public void Init()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0xEE8154", Offset = "0xEE8154", VA = "0xEE8154")]
	public void UpdateScroll(GUISettingID _id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0xEE83D8", Offset = "0xEE83D8", VA = "0xEE83D8")]
	public bool IsFullyVisible(GUISettingID _id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D69")]
	[Cpp2IlInjected.Address(RVA = "0xEE865C", Offset = "0xEE865C", VA = "0xEE865C")]
	private bool IsHidden(GUISettingID id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D6A")]
	[Cpp2IlInjected.Address(RVA = "0xEE8A58", Offset = "0xEE8A58", VA = "0xEE8A58")]
	public bool IsDisabled(GUISettingID id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D6B")]
	[Cpp2IlInjected.Address(RVA = "0xEE5F80", Offset = "0xEE5F80", VA = "0xEE5F80")]
	public void SetCategory(SettingsOverlayOptionCategories_Layout.Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D6C")]
	[Cpp2IlInjected.Address(RVA = "0xEE8BE4", Offset = "0xEE8BE4", VA = "0xEE8BE4")]
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D6D")]
	[Cpp2IlInjected.Address(RVA = "0xEE8C0C", Offset = "0xEE8C0C", VA = "0xEE8C0C")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D6E")]
	[Cpp2IlInjected.Address(RVA = "0xEE6254", Offset = "0xEE6254", VA = "0xEE6254")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D6F")]
	[Cpp2IlInjected.Address(RVA = "0xEEBC6C", Offset = "0xEEBC6C", VA = "0xEEBC6C")]
	private float SettingScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D70")]
	[Cpp2IlInjected.Address(RVA = "0xEEBC74", Offset = "0xEEBC74", VA = "0xEEBC74")]
	private void SettingOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D71")]
	[Cpp2IlInjected.Address(RVA = "0xEEBD34", Offset = "0xEEBD34", VA = "0xEEBD34")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D72")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE80", Offset = "0xEEBE80", VA = "0xEEBE80")]
	private void DummyDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D73")]
	[Cpp2IlInjected.Address(RVA = "0xEEBFA0", Offset = "0xEEBFA0", VA = "0xEEBFA0")]
	private void DummyOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D74")]
	[Cpp2IlInjected.Address(RVA = "0xEEBAA0", Offset = "0xEEBAA0", VA = "0xEEBAA0")]
	public void RefreshInputRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D75")]
	[Cpp2IlInjected.Address(RVA = "0xEEBFA4", Offset = "0xEEBFA4", VA = "0xEEBFA4")]
	private Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D76")]
	[Cpp2IlInjected.Address(RVA = "0xEEA384", Offset = "0xEEA384", VA = "0xEEA384")]
	private void DrawCategoryOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D77")]
	[Cpp2IlInjected.Address(RVA = "0xEEA278", Offset = "0xEEA278", VA = "0xEEA278")]
	private void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D78")]
	[Cpp2IlInjected.Address(RVA = "0xEEB6D8", Offset = "0xEEB6D8", VA = "0xEEB6D8")]
	private void DrawTitle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D79")]
	[Cpp2IlInjected.Address(RVA = "0xEEC06C", Offset = "0xEEC06C", VA = "0xEEC06C")]
	private void ResetSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D7A")]
	[Cpp2IlInjected.Address(RVA = "0xEED9E4", Offset = "0xEED9E4", VA = "0xEED9E4")]
	private void ResetPageSettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D7B")]
	[Cpp2IlInjected.Address(RVA = "0xEEB2C0", Offset = "0xEEB2C0", VA = "0xEEB2C0")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D7C")]
	[Cpp2IlInjected.Address(RVA = "0xEEA16C", Offset = "0xEEA16C", VA = "0xEEA16C")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D7D")]
	[Cpp2IlInjected.Address(RVA = "0xEEA5C4", Offset = "0xEEA5C4", VA = "0xEEA5C4")]
	private void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D7E")]
	[Cpp2IlInjected.Address(RVA = "0xEE3DFC", Offset = "0xEE3DFC", VA = "0xEE3DFC")]
	public void LooseFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D7F")]
	[Cpp2IlInjected.Address(RVA = "0xEEA0B0", Offset = "0xEEA0B0", VA = "0xEEA0B0")]
	private void GainFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D80")]
	[Cpp2IlInjected.Address(RVA = "0xEEDA74", Offset = "0xEEDA74", VA = "0xEEDA74")]
	private bool IsOverCategories(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D81")]
	[Cpp2IlInjected.Address(RVA = "0xEEDD18", Offset = "0xEEDD18", VA = "0xEEDD18")]
	public GUISettingsOverlay()
	{
	}
}
