using System;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x020000EE RID: 238
[global::Cpp2ILInjected.Token(Token = "0x2000155")]
public class GUIMana
{
	// Token: 0x06000856 RID: 2134 RVA: 0x00023447 File Offset: 0x00021647
	[global::Cpp2ILInjected.Token(Token = "0x6000950")]
	[global::Cpp2ILInjected.Address(RVA = "0x94E99C", Offset = "0x94E99C", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedGridLayoutSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public GUIMana()
	{
		throw null;
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000857 RID: 2135 RVA: 0x0002344A File Offset: 0x0002164A
	[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
	public ItemGrid_Layout ManaGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000951")]
		[global::Cpp2ILInjected.Address(RVA = "0x94EBD0", Offset = "0x94EBD0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000858 RID: 2136 RVA: 0x0002344D File Offset: 0x0002164D
	[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
	public String_Layout ManaTitle
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000952")]
		[global::Cpp2ILInjected.Address(RVA = "0x94ECA8", Offset = "0x94ECA8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000859 RID: 2137 RVA: 0x00023450 File Offset: 0x00021650
	[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
	public String_Layout ManaValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000953")]
		[global::Cpp2ILInjected.Address(RVA = "0x94ED80", Offset = "0x94ED80", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00023453 File Offset: 0x00021653
	[global::Cpp2ILInjected.Token(Token = "0x6000954")]
	[global::Cpp2ILInjected.Address(RVA = "0x94EE58", Offset = "0x94EE58", Length = "0x1C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_Right_Root", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "get_ManaGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "AdjustForTouchReturn", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedGridLayoutSettings), Member = "Dirty", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedGridLayoutSettings), Member = "Cache", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "RestoreForTouchButton", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Rectangle GetManaRegion()
	{
		throw null;
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00023456 File Offset: 0x00021656
	[global::Cpp2ILInjected.Token(Token = "0x6000955")]
	[global::Cpp2ILInjected.Address(RVA = "0x94F01C", Offset = "0x94F01C", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReturnToTouch), Member = "get_Visible", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
		throw null;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00023459 File Offset: 0x00021659
	[global::Cpp2ILInjected.Token(Token = "0x6000956")]
	[global::Cpp2ILInjected.Address(RVA = "0x94F0BC", Offset = "0x94F0BC", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReturnToTouch), Member = "get_Visible", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
		throw null;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002345C File Offset: 0x0002165C
	[global::Cpp2ILInjected.Token(Token = "0x6000957")]
	[global::Cpp2ILInjected.Address(RVA = "0x94F15C", Offset = "0x94F15C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float StarScale(int index)
	{
		throw null;
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0002345F File Offset: 0x0002165F
	[global::Cpp2ILInjected.Token(Token = "0x6000958")]
	[global::Cpp2ILInjected.Address(RVA = "0x94F1A8", Offset = "0x94F1A8", Length = "0x1EC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMap", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMiniMapToggle", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void StarOver(int index)
	{
		throw null;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00023462 File Offset: 0x00021662
	[global::Cpp2ILInjected.Token(Token = "0x6000959")]
	[global::Cpp2ILInjected.Address(RVA = "0x94F394", Offset = "0x94F394", Length = "0xD10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00023465 File Offset: 0x00021665
	[global::Cpp2ILInjected.Token(Token = "0x600095A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9500A4", Offset = "0x9500A4", Length = "0x590")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GUIBarsDrawInner", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "get_ManaTitle", ReturnType = typeof(String_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFadeString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderExtensions), Member = "AppendInt", MemberParameters = new object[]
	{
		typeof(StringBuilder),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "get_ManaValue", ReturnType = typeof(String_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFadeString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(StringBuilder),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "get_ManaGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "AdjustForTouchReturn", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "RestoreForTouchButton", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x0400068B RID: 1675
	[global::Cpp2ILInjected.Token(Token = "0x40008F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int starMana;

	// Token: 0x0400068C RID: 1676
	[global::Cpp2ILInjected.Token(Token = "0x40008F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int starCount;

	// Token: 0x0400068D RID: 1677
	[global::Cpp2ILInjected.Token(Token = "0x40008FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int lastStarCount;

	// Token: 0x0400068E RID: 1678
	[global::Cpp2ILInjected.Token(Token = "0x40008FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private CachedGridLayoutSettings LayoutCache;

	// Token: 0x0400068F RID: 1679
	[global::Cpp2ILInjected.Token(Token = "0x40008FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private Rectangle StarsRegion;

	// Token: 0x04000690 RID: 1680
	[global::Cpp2ILInjected.Token(Token = "0x40008FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Microsoft.Xna.Framework.Vector2 lastAnchorPoint;

	// Token: 0x04000691 RID: 1681
	[global::Cpp2ILInjected.Token(Token = "0x40008FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Microsoft.Xna.Framework.Vector2 manaBackingSingleOffset;

	// Token: 0x04000692 RID: 1682
	[global::Cpp2ILInjected.Token(Token = "0x40008FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private Microsoft.Xna.Framework.Vector2 manaBackingTopOffset;

	// Token: 0x04000693 RID: 1683
	[global::Cpp2ILInjected.Token(Token = "0x4000900")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private Microsoft.Xna.Framework.Vector2 manaBackingBottomOffset;

	// Token: 0x04000694 RID: 1684
	[global::Cpp2ILInjected.Token(Token = "0x4000901")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private Microsoft.Xna.Framework.Vector2 manaBackingMidOffset;

	// Token: 0x04000695 RID: 1685
	[global::Cpp2ILInjected.Token(Token = "0x4000902")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private Microsoft.Xna.Framework.Vector2 manaBackingLeftBarOffset;

	// Token: 0x04000696 RID: 1686
	[global::Cpp2ILInjected.Token(Token = "0x4000903")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private Microsoft.Xna.Framework.Vector2 manaBackingMidBarOffset;

	// Token: 0x04000697 RID: 1687
	[global::Cpp2ILInjected.Token(Token = "0x4000904")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private Microsoft.Xna.Framework.Vector2 manaBackingRightBarOffset;

	// Token: 0x04000698 RID: 1688
	[global::Cpp2ILInjected.Token(Token = "0x4000905")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private GUIItemGrid.CursorOver starOver;

	// Token: 0x04000699 RID: 1689
	[global::Cpp2ILInjected.Token(Token = "0x4000906")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private GUIItemGrid.GetItemScaleHandler starScale;

	// Token: 0x0400069A RID: 1690
	[global::Cpp2ILInjected.Token(Token = "0x4000907")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private GUIItemGrid.DrawItemHandler starDraw;

	// Token: 0x0400069B RID: 1691
	[global::Cpp2ILInjected.Token(Token = "0x4000908")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private float TimeSinceChange;

	// Token: 0x0400069C RID: 1692
	[global::Cpp2ILInjected.Token(Token = "0x4000909")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private int LastValue;
}
