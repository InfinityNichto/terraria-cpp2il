using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Initializers;
using Terraria.UI;
using Terraria.UI.Chat;

// Token: 0x02000164 RID: 356
[global::Cpp2ILInjected.Token(Token = "0x20001EC")]
public static class LayoutCalculator
{
	// Token: 0x06000B3F RID: 2879 RVA: 0x00023D02 File Offset: 0x00021F02
	[global::Cpp2ILInjected.Token(Token = "0x6000C54")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBDB8", Offset = "0x9CBDB8", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00023D05 File Offset: 0x00021F05
	[global::Cpp2ILInjected.Token(Token = "0x6000C55")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBE8C", Offset = "0x9CBE8C", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float),
		typeof(int),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawCentredPickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00023D08 File Offset: 0x00021F08
	[global::Cpp2ILInjected.Token(Token = "0x6000C56")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBFF4", Offset = "0x9CBFF4", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUITransactionButton.DrawItemHandler),
		typeof(Vector2),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "DrawCentredPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawCentredPickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00023D0B File Offset: 0x00021F0B
	[global::Cpp2ILInjected.Token(Token = "0x6000C57")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC0F4", Offset = "0x9CC0F4", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float),
		typeof(int),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawCentredCirclePickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00023D0E File Offset: 0x00021F0E
	[global::Cpp2ILInjected.Token(Token = "0x6000C58")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC194", Offset = "0x9CC194", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUITransactionButton.DrawItemHandler),
		typeof(Vector2),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawCentredCirclePickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00023D11 File Offset: 0x00021F11
	[global::Cpp2ILInjected.Token(Token = "0x6000C59")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC294", Offset = "0x9CC294", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawPickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00023D14 File Offset: 0x00021F14
	[global::Cpp2ILInjected.Token(Token = "0x6000C5A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC424", Offset = "0x9CC424", Length = "0x16C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "DrawCursorOverlay", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void DrawPickPoint(SpriteBatch batch, Vector2 position)
	{
		throw null;
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00023D17 File Offset: 0x00021F17
	[global::Cpp2ILInjected.Token(Token = "0x6000C5B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC334", Offset = "0x9CC334", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDPad), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DPad_Layout),
		typeof(Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "ClippedDrawItemHandler", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISlider), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Slider_Layout),
		typeof(bool),
		typeof(ref float),
		typeof(GUISlider.DragState),
		typeof(GUISlider.DrawBackingHandler),
		typeof(bool),
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInGame", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawPickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
		throw null;
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00023D1A File Offset: 0x00021F1A
	[global::Cpp2ILInjected.Token(Token = "0x6000C5C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC590", Offset = "0x9CC590", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void DrawSafeRegion(SpriteBatch batch, Vector2 position, Vector2 size, Color color)
	{
		throw null;
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x00023D1D File Offset: 0x00021F1D
	[global::Cpp2ILInjected.Token(Token = "0x6000C5D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC684", Offset = "0x9CC684", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDPad), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DPad_Layout),
		typeof(Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Rectangle?),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void Draw(SpriteBatch batch, Vector2 position, float rotation, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00023D20 File Offset: 0x00021F20
	[global::Cpp2ILInjected.Token(Token = "0x6000C5E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC874", Offset = "0x9CC874", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void Draw(SpriteBatch batch, Vector2 position, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00023D23 File Offset: 0x00021F23
	[global::Cpp2ILInjected.Token(Token = "0x6000C5F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CC9C8", Offset = "0x9CC9C8", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void DrawCentred(SpriteBatch batch, Vector2 position, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00023D26 File Offset: 0x00021F26
	[global::Cpp2ILInjected.Token(Token = "0x6000C60")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CCB44", Offset = "0x9CCB44", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float),
		typeof(int),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawBacking", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Texture2D),
		typeof(Color),
		typeof(Color),
		typeof(Texture2D),
		typeof(Color),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetLayoutRect", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void DrawCentred(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00023D29 File Offset: 0x00021F29
	[global::Cpp2ILInjected.Token(Token = "0x6000C61")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CCDE0", Offset = "0x9CCDE0", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetLayoutRect", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Rectangle?),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public static void DrawCentred(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Rectangle srcRect, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x00023D2C File Offset: 0x00021F2C
	[global::Cpp2ILInjected.Token(Token = "0x6000C62")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD014", Offset = "0x9CD014", Length = "0x228")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(ref Vector2),
		typeof(ref Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Rectangle?),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void DrawCentred(SpriteBatch batch, Vector2 position, Rectangle srcRect, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00023D2F File Offset: 0x00021F2F
	[global::Cpp2ILInjected.Token(Token = "0x6000C63")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD23C", Offset = "0x9CD23C", Length = "0x170")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetLayoutRect", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void Draw(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, float scale, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00023D32 File Offset: 0x00021F32
	[global::Cpp2ILInjected.Token(Token = "0x6000C64")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD3AC", Offset = "0x9CD3AC", Length = "0x150")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetLayoutRect", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void Draw(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size, Texture2D texture, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00023D35 File Offset: 0x00021F35
	[global::Cpp2ILInjected.Token(Token = "0x6000C65")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD4FC", Offset = "0x9CD4FC", Length = "0x148")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static bool IsOverIcon(Vector2 position, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 anchorPosition, Texture2D texture, float textureScale, Vector2 pickingBorder)
	{
		throw null;
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00023D38 File Offset: 0x00021F38
	[global::Cpp2ILInjected.Token(Token = "0x6000C66")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD644", Offset = "0x9CD644", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(TextSnippet[]),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(TextSnippet[]),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static Vector2 GetChatManagerAlignmentOffset(SpriteFont font, TextSnippet[] text, float scale, LayoutCalculator.AnchorType stringAlignment, float maxWidth = -1f)
	{
		throw null;
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00023D3B File Offset: 0x00021F3B
	[global::Cpp2ILInjected.Token(Token = "0x6000C67")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD7A4", Offset = "0x9CD7A4", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Vector2 GetAlignmentOffset(SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		throw null;
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00023D3E File Offset: 0x00021F3E
	[global::Cpp2ILInjected.Token(Token = "0x6000C68")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD89C", Offset = "0x9CD89C", Length = "0x15C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredChatManagerStringPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static Vector2 GetChatManagerAlignmentOffset(SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		throw null;
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00023D41 File Offset: 0x00021F41
	[global::Cpp2ILInjected.Token(Token = "0x6000C69")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CD9F8", Offset = "0x9CD9F8", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(float),
		typeof(LayoutCalculator.AnchorType)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Vector2 GetAlignmentOffset(SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		throw null;
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00023D44 File Offset: 0x00021F44
	[global::Cpp2ILInjected.Token(Token = "0x6000C6A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CDAF0", Offset = "0x9CDAF0", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "DrawMenu", MemberParameters = new object[]
	{
		typeof(PopoutMenu_Layout),
		typeof(string[]),
		typeof(ref Rectangle)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringButtonPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(ref bool),
		typeof(ref Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Vector2 GetAlignmentOffset(SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment, out Vector2 stringDimensions)
	{
		throw null;
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00023D47 File Offset: 0x00021F47
	[global::Cpp2ILInjected.Token(Token = "0x6000C6B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CDC00", Offset = "0x9CDC00", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringButtonPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(ref bool),
		typeof(ref Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Vector2 GetAlignmentOffset(SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment, out Vector2 stringDimensions)
	{
		throw null;
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00023D4A File Offset: 0x00021F4A
	[global::Cpp2ILInjected.Token(Token = "0x6000C6C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CDD10", Offset = "0x9CDD10", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "DrawPrefixes", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAlignmentOffset", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		throw null;
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00023D4D File Offset: 0x00021F4D
	[global::Cpp2ILInjected.Token(Token = "0x6000C6D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CDE0C", Offset = "0x9CDE0C", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(TextSnippet[]),
		typeof(ref int),
		typeof(float),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetChatManagerAlignmentOffset", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(TextSnippet[]),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, TextSnippet[] text, float scale, LayoutCalculator.AnchorType stringAlignment, float maxWidth = -1f)
	{
		throw null;
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00023D50 File Offset: 0x00021F50
	[global::Cpp2ILInjected.Token(Token = "0x6000C6E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CDF10", Offset = "0x9CDF10", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetChatManagerAlignmentOffset", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Vector2 GetAnchoredChatManagerStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		throw null;
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00023D53 File Offset: 0x00021F53
	[global::Cpp2ILInjected.Token(Token = "0x6000C6F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE00C", Offset = "0x9CE00C", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(StringBuilder),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAlignmentOffset", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(float),
		typeof(LayoutCalculator.AnchorType)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		throw null;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00023D56 File Offset: 0x00021F56
	[global::Cpp2ILInjected.Token(Token = "0x6000C70")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE108", Offset = "0x9CE108", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Color)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAlignmentOffset", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(ref Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static Vector2 GetAnchoredStringButtonPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment, out bool over, out Vector2 dimensions)
	{
		throw null;
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00023D59 File Offset: 0x00021F59
	[global::Cpp2ILInjected.Token(Token = "0x6000C71")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE284", Offset = "0x9CE284", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAlignmentOffset", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(ref Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static Vector2 GetAnchoredStringButtonPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment, out bool over, out Vector2 dimensions)
	{
		throw null;
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00023D5C File Offset: 0x00021F5C
	[global::Cpp2ILInjected.Token(Token = "0x6000C72")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBF2C", Offset = "0x9CBF2C", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 239)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	public static Vector2 GetAnchoredPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position)
	{
		throw null;
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00023D5F File Offset: 0x00021F5F
	[global::Cpp2ILInjected.Token(Token = "0x6000C73")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CCCD4", Offset = "0x9CCCD4", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsTouchAxisHandler), Member = "MeasureInline", MemberParameters = new object[]
	{
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawBacking", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Texture2D),
		typeof(Color),
		typeof(Color),
		typeof(Texture2D),
		typeof(Color),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawControlIcon", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Color),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUITransactionButton.DrawItemHandler),
		typeof(Vector2),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "GetOverloadedPickingRegion", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(float)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "LoadButtonRegion", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(float)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawItem", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Texture2D),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "DrawCentred", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(float),
		typeof(Texture2D),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "DrawCentred", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Rectangle),
		typeof(float),
		typeof(Texture2D),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(float),
		typeof(Texture2D),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Texture2D),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Rectangle GetLayoutRect(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size, Texture2D texture)
	{
		throw null;
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00023D62 File Offset: 0x00021F62
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000C74")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE400", Offset = "0x9CE400", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static LayoutCalculator()
	{
		throw null;
	}

	// Token: 0x04000DAB RID: 3499
	[global::Cpp2ILInjected.Token(Token = "0x40011E7")]
	public static bool DrawSafeRegions;

	// Token: 0x04000DAC RID: 3500
	[global::Cpp2ILInjected.Token(Token = "0x40011E8")]
	public static bool DrawPickingRegions;

	// Token: 0x04000DAD RID: 3501
	[global::Cpp2ILInjected.Token(Token = "0x40011E9")]
	private static Texture2D _pickingRegion;

	// Token: 0x04000DAE RID: 3502
	[global::Cpp2ILInjected.Token(Token = "0x40011EA")]
	private static Texture2D _pickingRegionCircle;

	// Token: 0x04000DAF RID: 3503
	[global::Cpp2ILInjected.Token(Token = "0x40011EB")]
	private static Color _pickingRegionColour;

	// Token: 0x020007E9 RID: 2025
	[global::Cpp2ILInjected.Token(Token = "0x20001ED")]
	public enum AnchorFlags
	{
		// Token: 0x04007C07 RID: 31751
		[global::Cpp2ILInjected.Token(Token = "0x40011ED")]
		Left = 1,
		// Token: 0x04007C08 RID: 31752
		[global::Cpp2ILInjected.Token(Token = "0x40011EE")]
		CentreHorizontal,
		// Token: 0x04007C09 RID: 31753
		[global::Cpp2ILInjected.Token(Token = "0x40011EF")]
		Right = 4,
		// Token: 0x04007C0A RID: 31754
		[global::Cpp2ILInjected.Token(Token = "0x40011F0")]
		Top = 8,
		// Token: 0x04007C0B RID: 31755
		[global::Cpp2ILInjected.Token(Token = "0x40011F1")]
		CentreVertical = 16,
		// Token: 0x04007C0C RID: 31756
		[global::Cpp2ILInjected.Token(Token = "0x40011F2")]
		Bottom = 32
	}

	// Token: 0x020007EA RID: 2026
	[global::Cpp2ILInjected.Token(Token = "0x20001EE")]
	public enum AnchorType
	{
		// Token: 0x04007C0E RID: 31758
		[global::Cpp2ILInjected.Token(Token = "0x40011F4")]
		TopLeft = 9,
		// Token: 0x04007C0F RID: 31759
		[global::Cpp2ILInjected.Token(Token = "0x40011F5")]
		TopCentre,
		// Token: 0x04007C10 RID: 31760
		[global::Cpp2ILInjected.Token(Token = "0x40011F6")]
		TopRight = 12,
		// Token: 0x04007C11 RID: 31761
		[global::Cpp2ILInjected.Token(Token = "0x40011F7")]
		CentreLeft = 17,
		// Token: 0x04007C12 RID: 31762
		[global::Cpp2ILInjected.Token(Token = "0x40011F8")]
		CentreBoth,
		// Token: 0x04007C13 RID: 31763
		[global::Cpp2ILInjected.Token(Token = "0x40011F9")]
		CentreRight = 20,
		// Token: 0x04007C14 RID: 31764
		[global::Cpp2ILInjected.Token(Token = "0x40011FA")]
		BottomLeft = 33,
		// Token: 0x04007C15 RID: 31765
		[global::Cpp2ILInjected.Token(Token = "0x40011FB")]
		BottomCentre,
		// Token: 0x04007C16 RID: 31766
		[global::Cpp2ILInjected.Token(Token = "0x40011FC")]
		BottomRight = 36
	}
}
