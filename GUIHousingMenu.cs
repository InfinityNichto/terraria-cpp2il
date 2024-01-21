using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class GUIHousingMenu
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private bool _visible;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	public int LastNPCHousingHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public int NPCHousingHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public List<int> _activeNPCEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	public string npcString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private int _lastNPCOVer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private bool _npcOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private int over;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private Texture2D _npcHeadTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public float scrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private float scrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private int scrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private Vector2 dragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private float scrollDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private int _npcCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public int ActiveNPCCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private float HousingQueryScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	public bool menuTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private DateTime NavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private bool hotbarActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private float ScrollAmount;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool Visible
	{
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0xDDAA9C", Offset = "0xDDAA9C", VA = "0xDDAA9C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0xDDAAA4", Offset = "0xDDAAA4", VA = "0xDDAAA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xDDACA0", Offset = "0xDDACA0", VA = "0xDDACA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private Texture2D _npcHeadTextureEmpty
	{
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xDDAD20", Offset = "0xDDAD20", VA = "0xDDAD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xDDAD84", Offset = "0xDDAD84", VA = "0xDDAD84")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0xDDAB60", Offset = "0xDDAB60", VA = "0xDDAB60")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0xDDAC60", Offset = "0xDDAC60", VA = "0xDDAC60")]
	private void DrawPageIcons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0xDDAE5C", Offset = "0xDDAE5C", VA = "0xDDAE5C")]
	private void RefreshNPCEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0xDDB220", Offset = "0xDDB220", VA = "0xDDB220")]
	public float NPCScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0xDDB278", Offset = "0xDDB278", VA = "0xDDB278")]
	public void NPCOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0xDDB9D4", Offset = "0xDDB9D4", VA = "0xDDB9D4")]
	public void NPCDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0xDDCE88", Offset = "0xDDCE88", VA = "0xDDCE88")]
	public void UpdateHotbarNavigation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0xDDD4BC", Offset = "0xDDD4BC", VA = "0xDDD4BC")]
	private void PreviousItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0xDDD3A8", Offset = "0xDDD3A8", VA = "0xDDD3A8")]
	private void NextItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0xDDD5D0", Offset = "0xDDD5D0", VA = "0xDDD5D0")]
	private void UpdateHotbarScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0xDDD7BC", Offset = "0xDDD7BC", VA = "0xDDD7BC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0xDDDF30", Offset = "0xDDDF30", VA = "0xDDDF30")]
	public GUIHousingMenu()
	{
	}
}
