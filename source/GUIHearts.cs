using System;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x020000E2 RID: 226
[global::Cpp2ILInjected.Token(Token = "0x2000146")]
public class GUIHearts
{
	// Token: 0x060007D9 RID: 2009 RVA: 0x000232D0 File Offset: 0x000214D0
	[global::Cpp2ILInjected.Token(Token = "0x60008D3")]
	[global::Cpp2ILInjected.Address(RVA = "0x803B10", Offset = "0x803B10", Length = "0x238")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
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
	public GUIHearts()
	{
		throw null;
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060007DA RID: 2010 RVA: 0x000232D3 File Offset: 0x000214D3
	[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
	public ItemGrid_Layout HeartsGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x803D48", Offset = "0x803D48", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x000232D6 File Offset: 0x000214D6
	[global::Cpp2ILInjected.Token(Token = "0x60008D5")]
	[global::Cpp2ILInjected.Address(RVA = "0x803E18", Offset = "0x803E18", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_Right_Root", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "get_HeartsGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "AdjustForTouchReturn", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedGridLayoutSettings), Member = "Dirty", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedGridLayoutSettings), Member = "Cache", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "RestoreForTouchButton", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public Rectangle GetHeartsRegion()
	{
		throw null;
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x000232D9 File Offset: 0x000214D9
	[global::Cpp2ILInjected.Token(Token = "0x60008D6")]
	[global::Cpp2ILInjected.Address(RVA = "0x80413C", Offset = "0x80413C", Length = "0x3D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFadeString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(StringBuilder),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	private void DrawLifeString()
	{
		throw null;
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x000232DC File Offset: 0x000214DC
	[global::Cpp2ILInjected.Token(Token = "0x60008D7")]
	[global::Cpp2ILInjected.Address(RVA = "0x804514", Offset = "0x804514", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float HeartScale(int index)
	{
		throw null;
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000232DF File Offset: 0x000214DF
	[global::Cpp2ILInjected.Token(Token = "0x60008D8")]
	[global::Cpp2ILInjected.Address(RVA = "0x804560", Offset = "0x804560", Length = "0x1EC")]
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
	private void HeartOver(int index)
	{
		throw null;
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x000232E2 File Offset: 0x000214E2
	[global::Cpp2ILInjected.Token(Token = "0x60008D9")]
	[global::Cpp2ILInjected.Address(RVA = "0x80474C", Offset = "0x80474C", Length = "0xD3C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
	private void HeartDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x000232E5 File Offset: 0x000214E5
	[global::Cpp2ILInjected.Token(Token = "0x60008DA")]
	[global::Cpp2ILInjected.Address(RVA = "0x804024", Offset = "0x804024", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReturnToTouch), Member = "get_Visible", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
		throw null;
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x000232E8 File Offset: 0x000214E8
	[global::Cpp2ILInjected.Token(Token = "0x60008DB")]
	[global::Cpp2ILInjected.Address(RVA = "0x8040B0", Offset = "0x8040B0", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReturnToTouch), Member = "get_Visible", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
		throw null;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x000232EB File Offset: 0x000214EB
	[global::Cpp2ILInjected.Token(Token = "0x60008DC")]
	[global::Cpp2ILInjected.Address(RVA = "0x805488", Offset = "0x805488", Length = "0x378")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GUIBarsDrawInner", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "DrawLifeString", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "get_HeartsGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "AdjustForTouchReturn", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "RestoreForTouchButton", MemberParameters = new object[] { typeof(ItemGrid_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x04000544 RID: 1348
	[global::Cpp2ILInjected.Token(Token = "0x400079B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIHearts.ResourceSet ActiveSet;

	// Token: 0x04000545 RID: 1349
	[global::Cpp2ILInjected.Token(Token = "0x400079C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float heartLife;

	// Token: 0x04000546 RID: 1350
	[global::Cpp2ILInjected.Token(Token = "0x400079D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int heartCountOriginal;

	// Token: 0x04000547 RID: 1351
	[global::Cpp2ILInjected.Token(Token = "0x400079E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int heartCount;

	// Token: 0x04000548 RID: 1352
	[global::Cpp2ILInjected.Token(Token = "0x400079F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int fruitHearts;

	// Token: 0x04000549 RID: 1353
	[global::Cpp2ILInjected.Token(Token = "0x40007A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int lastHeartCount;

	// Token: 0x0400054A RID: 1354
	[global::Cpp2ILInjected.Token(Token = "0x40007A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private CachedGridLayoutSettings LayoutCache;

	// Token: 0x0400054B RID: 1355
	[global::Cpp2ILInjected.Token(Token = "0x40007A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private Microsoft.Xna.Framework.Vector2 lastAnchorPoint;

	// Token: 0x0400054C RID: 1356
	[global::Cpp2ILInjected.Token(Token = "0x40007A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Rectangle HeartsRegion;

	// Token: 0x0400054D RID: 1357
	[global::Cpp2ILInjected.Token(Token = "0x40007A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private Microsoft.Xna.Framework.Vector2 heartBackingSingleOffset;

	// Token: 0x0400054E RID: 1358
	[global::Cpp2ILInjected.Token(Token = "0x40007A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private Microsoft.Xna.Framework.Vector2 heartBackingLeftOffset;

	// Token: 0x0400054F RID: 1359
	[global::Cpp2ILInjected.Token(Token = "0x40007A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private Microsoft.Xna.Framework.Vector2 heartBackingRightOffset;

	// Token: 0x04000550 RID: 1360
	[global::Cpp2ILInjected.Token(Token = "0x40007A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private Microsoft.Xna.Framework.Vector2 heartBackingRightFancyOffset;

	// Token: 0x04000551 RID: 1361
	[global::Cpp2ILInjected.Token(Token = "0x40007A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private Microsoft.Xna.Framework.Vector2 heartBackingMidOffset;

	// Token: 0x04000552 RID: 1362
	[global::Cpp2ILInjected.Token(Token = "0x40007A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private Microsoft.Xna.Framework.Vector2 heartBackingLeftBarOffset;

	// Token: 0x04000553 RID: 1363
	[global::Cpp2ILInjected.Token(Token = "0x40007AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private Microsoft.Xna.Framework.Vector2 heartBackingMidBarOffset;

	// Token: 0x04000554 RID: 1364
	[global::Cpp2ILInjected.Token(Token = "0x40007AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private Microsoft.Xna.Framework.Vector2 heartBackingRightBarOffset;

	// Token: 0x04000555 RID: 1365
	[global::Cpp2ILInjected.Token(Token = "0x40007AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private float TimeSinceChange;

	// Token: 0x04000556 RID: 1366
	[global::Cpp2ILInjected.Token(Token = "0x40007AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private int LastValue;

	// Token: 0x04000557 RID: 1367
	[global::Cpp2ILInjected.Token(Token = "0x40007AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private GUIItemGrid.GetItemScaleHandler heartScale;

	// Token: 0x04000558 RID: 1368
	[global::Cpp2ILInjected.Token(Token = "0x40007AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private GUIItemGrid.CursorOver heartOver;

	// Token: 0x04000559 RID: 1369
	[global::Cpp2ILInjected.Token(Token = "0x40007B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private GUIItemGrid.DrawItemHandler heartDraw;

	// Token: 0x020007C5 RID: 1989
	[global::Cpp2ILInjected.Token(Token = "0x2000147")]
	public enum ResourceSet
	{
		// Token: 0x04007A22 RID: 31266
		[global::Cpp2ILInjected.Token(Token = "0x40007B2")]
		Default,
		// Token: 0x04007A23 RID: 31267
		[global::Cpp2ILInjected.Token(Token = "0x40007B3")]
		New,
		// Token: 0x04007A24 RID: 31268
		[global::Cpp2ILInjected.Token(Token = "0x40007B4")]
		HorizontalBars
	}
}
