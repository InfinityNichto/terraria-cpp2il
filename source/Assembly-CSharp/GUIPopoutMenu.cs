using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Initializers;
using Terraria.UI.Chat;

// Token: 0x020000BE RID: 190
[global::Cpp2ILInjected.Token(Token = "0x2000112")]
public static class GUIPopoutMenu
{
	// Token: 0x060005FA RID: 1530 RVA: 0x00022D33 File Offset: 0x00020F33
	[global::Cpp2ILInjected.Token(Token = "0x60006E4")]
	[global::Cpp2ILInjected.Address(RVA = "0xF670AC", Offset = "0xF670AC", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00022D36 File Offset: 0x00020F36
	[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
	[global::Cpp2ILInjected.Address(RVA = "0xF67170", Offset = "0xF67170", Length = "0x7C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "Draw", MemberParameters = new object[]
	{
		typeof(PopoutMenu_Layout),
		typeof(string[]),
		typeof(ref bool),
		typeof(ref float),
		typeof(ref Rectangle)
	}, ReturnType = typeof(int))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Rectangle),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(SpriteFont),
		typeof(string),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	private static int DrawMenu(PopoutMenu_Layout layout, string[] options, ref Rectangle menuRegion)
	{
		throw null;
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00022D39 File Offset: 0x00020F39
	[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
	[global::Cpp2ILInjected.Address(RVA = "0xF67934", Offset = "0xF67934", Length = "0x1CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPopoutMenu), Member = "DrawMenu", MemberParameters = new object[]
	{
		typeof(PopoutMenu_Layout),
		typeof(string[]),
		typeof(ref Rectangle)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "RegisterPickingRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static int Draw(PopoutMenu_Layout layout, string[] options, ref bool menuOpen, ref float scale, ref Rectangle menuRegion)
	{
		throw null;
	}

	// Token: 0x04000382 RID: 898
	[global::Cpp2ILInjected.Token(Token = "0x4000568")]
	public static Texture2D _menuClosed;

	// Token: 0x04000383 RID: 899
	[global::Cpp2ILInjected.Token(Token = "0x4000569")]
	public static Texture2D _menuOpen;
}
