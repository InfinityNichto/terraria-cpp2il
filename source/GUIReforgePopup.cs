using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000FB")]
public class GUIReforgePopup
{
	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private static int reforgeItemNamePos;

	[Cpp2IlInjected.Token(Token = "0x4000754")]
	private static int reforgeTextPos;

	[Cpp2IlInjected.Token(Token = "0x4000755")]
	private static int reforgeTextBackingSize;

	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private static int defaultBackingWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private int OpenedFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	public bool PopupDisplayed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	private float CachedLayoutSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	private float CachedLayoutWrapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	private int CachedMinTextHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private Vector2 CachedTextSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	private int CachedTextLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	public GUIControllerReforgePopup _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private int numLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private string[] toolTipLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private bool[] badPreFixLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private Item tooltipPrefixComparisonItem;

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0x114E014", Offset = "0x114E014", VA = "0x114E014")]
	private void SetupBackingSize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x114E334", Offset = "0x114E334", VA = "0x114E334")]
	public void LoadRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x114CC54", Offset = "0x114CC54", VA = "0x114CC54")]
	public void OpenPopup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000932")]
	[Cpp2IlInjected.Address(RVA = "0x114E3F4", Offset = "0x114E3F4", VA = "0x114E3F4")]
	public void ClosePopup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000933")]
	[Cpp2IlInjected.Address(RVA = "0x114E47C", Offset = "0x114E47C", VA = "0x114E47C")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0x115051C", Offset = "0x115051C", VA = "0x115051C")]
	private void UpdateText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0x1150648", Offset = "0x1150648", VA = "0x1150648")]
	public void LoadPanelRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000936")]
	[Cpp2IlInjected.Address(RVA = "0x1150708", Offset = "0x1150708", VA = "0x1150708")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x11507B0", Offset = "0x11507B0", VA = "0x11507B0")]
	private void DrawItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x114E758", Offset = "0x114E758", VA = "0x114E758")]
	private void UpdatePrefixes(Item reforgeItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x11514CC", Offset = "0x11514CC", VA = "0x11514CC")]
	public void DrawPrefixes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x1151B9C", Offset = "0x1151B9C", VA = "0x1151B9C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x1152AEC", Offset = "0x1152AEC", VA = "0x1152AEC")]
	public GUIReforgePopup()
	{
	}
}
