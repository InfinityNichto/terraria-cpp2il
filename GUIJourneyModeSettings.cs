using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000EC")]
public class GUIJourneyModeSettings
{
	[Cpp2IlInjected.Token(Token = "0x20007BE")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x4007A21")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x4007A22")]
		Weather,
		[Cpp2IlInjected.Token(Token = "0x4007A23")]
		Powers
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public bool OpenedFromInv;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private float jwButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	public List<GUISettingEntry> _categorySettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	public List<GUISettingEntry> _timeSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	public List<GUISettingEntry> _weatherSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	public List<GUISettingEntry> _powerSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	public GUIControllerJourneyModeSettings _controllerInput;

	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private static Texture2D infinitePowersMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private GUISettingEntry overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private Rectangle overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private float titleScale;

	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private static Category[] TabOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private Category Selected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private float PowerButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private float TimeButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private float WeatherButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private float CloseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private bool hasFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private GUIInputRegionExclusive _categoriesBlocker;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x13729E4", Offset = "0x13729E4", VA = "0x13729E4")]
	public void Init()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x13723AC", Offset = "0x13723AC", VA = "0x13723AC")]
	public static Texture2D GetIconTexture(GUISettingID id, out Rectangle frame)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x1372F28", Offset = "0x1372F28", VA = "0x1372F28")]
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x1372F50", Offset = "0x1372F50", VA = "0x1372F50")]
	public void DrawButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x13732BC", Offset = "0x13732BC", VA = "0x13732BC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x1374164", Offset = "0x1374164", VA = "0x1374164")]
	private float SettingScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x137416C", Offset = "0x137416C", VA = "0x137416C")]
	private void SettingOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x137422C", Offset = "0x137422C", VA = "0x137422C")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x1374378", Offset = "0x1374378", VA = "0x1374378")]
	private Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x13737BC", Offset = "0x13737BC", VA = "0x13737BC")]
	private void DrawCategoryOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x1373990", Offset = "0x1373990", VA = "0x1373990")]
	private void DrawTitle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x13736B0", Offset = "0x13736B0", VA = "0x13736B0")]
	public void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x1373128", Offset = "0x1373128", VA = "0x1373128")]
	public void SetCategory(Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x1373A30", Offset = "0x1373A30", VA = "0x1373A30")]
	public void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x1374440", Offset = "0x1374440", VA = "0x1374440")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x13731B4", Offset = "0x13731B4", VA = "0x13731B4")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x13746E8", Offset = "0x13746E8", VA = "0x13746E8")]
	public void LooseFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x13735F4", Offset = "0x13735F4", VA = "0x13735F4")]
	private void GainFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x1374770", Offset = "0x1374770", VA = "0x1374770")]
	private bool IsOverCategories(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x13748F0", Offset = "0x13748F0", VA = "0x13748F0")]
	public GUIJourneyModeSettings()
	{
	}
}
