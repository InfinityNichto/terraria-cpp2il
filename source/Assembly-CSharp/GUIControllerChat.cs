using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200005E RID: 94
[global::Cpp2ILInjected.Token(Token = "0x200008A")]
public class GUIControllerChat : GUIControllerItem
{
	// Token: 0x060002C5 RID: 709 RVA: 0x000223A0 File Offset: 0x000205A0
	[global::Cpp2ILInjected.Token(Token = "0x600035F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C2404", Offset = "0x9C2404", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x000223A3 File Offset: 0x000205A3
	[global::Cpp2ILInjected.Token(Token = "0x6000360")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C24A4", Offset = "0x9C24A4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060002C7 RID: 711 RVA: 0x000223A6 File Offset: 0x000205A6
	[global::Cpp2ILInjected.Token(Token = "0x17000078")]
	private static int maxRowIndex
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C24AC", Offset = "0x9C24AC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060002C8 RID: 712 RVA: 0x000223A9 File Offset: 0x000205A9
	[global::Cpp2ILInjected.Token(Token = "0x17000079")]
	private static int maxRowColumn
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000362")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C252C", Offset = "0x9C252C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x000223AC File Offset: 0x000205AC
	[global::Cpp2ILInjected.Token(Token = "0x6000363")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C25A8", Offset = "0x9C25A8", Length = "0x238")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private void UpdateEmoteScroll()
	{
		throw null;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x000223AF File Offset: 0x000205AF
	[global::Cpp2ILInjected.Token(Token = "0x6000364")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C27E0", Offset = "0x9C27E0", Length = "0x210")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "ChatSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private static void UpdateScrollRegion()
	{
		throw null;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x000223B2 File Offset: 0x000205B2
	[global::Cpp2ILInjected.Token(Token = "0x6000365")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C29F0", Offset = "0x9C29F0", Length = "0x364")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChat), Member = "UpdateScrollRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChat), Member = "get_maxRowIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChat), Member = "get_maxRowColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChat), Member = "UpdateEmoteScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x000223B5 File Offset: 0x000205B5
	[global::Cpp2ILInjected.Token(Token = "0x6000366")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C2D54", Offset = "0x9C2D54", Length = "0x3AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_Instance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_MiniChatInstance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x000223B8 File Offset: 0x000205B8
	[global::Cpp2ILInjected.Token(Token = "0x6000367")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3100", Offset = "0x9C3100", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerChat()
	{
		throw null;
	}

	// Token: 0x04000238 RID: 568
	[global::Cpp2ILInjected.Token(Token = "0x4000351")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerChat.Controls selectedControl;

	// Token: 0x04000239 RID: 569
	[global::Cpp2ILInjected.Token(Token = "0x4000352")]
	private static float maxScrollOffset;

	// Token: 0x0400023A RID: 570
	[global::Cpp2ILInjected.Token(Token = "0x4000353")]
	private static int lineSpacing;

	// Token: 0x0400023B RID: 571
	[global::Cpp2ILInjected.Token(Token = "0x4000354")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int SelectedRow;

	// Token: 0x0400023C RID: 572
	[global::Cpp2ILInjected.Token(Token = "0x4000355")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int SelectedColumn;

	// Token: 0x0200078E RID: 1934
	[global::Cpp2ILInjected.Token(Token = "0x200008B")]
	public enum Controls
	{
		// Token: 0x040078FF RID: 30975
		[global::Cpp2ILInjected.Token(Token = "0x4000357")]
		General,
		// Token: 0x04007900 RID: 30976
		[global::Cpp2ILInjected.Token(Token = "0x4000358")]
		RPS,
		// Token: 0x04007901 RID: 30977
		[global::Cpp2ILInjected.Token(Token = "0x4000359")]
		Items,
		// Token: 0x04007902 RID: 30978
		[global::Cpp2ILInjected.Token(Token = "0x400035A")]
		BiomesAndEvents,
		// Token: 0x04007903 RID: 30979
		[global::Cpp2ILInjected.Token(Token = "0x400035B")]
		TownNPCs,
		// Token: 0x04007904 RID: 30980
		[global::Cpp2ILInjected.Token(Token = "0x400035C")]
		Critters,
		// Token: 0x04007905 RID: 30981
		[global::Cpp2ILInjected.Token(Token = "0x400035D")]
		Bosses,
		// Token: 0x04007906 RID: 30982
		[global::Cpp2ILInjected.Token(Token = "0x400035E")]
		Element,
		// Token: 0x04007907 RID: 30983
		[global::Cpp2ILInjected.Token(Token = "0x400035F")]
		Back
	}
}
