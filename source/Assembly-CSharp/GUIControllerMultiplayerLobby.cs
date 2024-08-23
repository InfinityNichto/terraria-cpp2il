using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200006B RID: 107
[global::Cpp2ILInjected.Token(Token = "0x200009A")]
public class GUIControllerMultiplayerLobby : GUIControllerItem
{
	// Token: 0x06000314 RID: 788 RVA: 0x00022481 File Offset: 0x00020681
	[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5BD4", Offset = "0x9C5BD4", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00022484 File Offset: 0x00020684
	[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5C60", Offset = "0x9C5C60", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00022487 File Offset: 0x00020687
	[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5C68", Offset = "0x9C5C68", Length = "0x230")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMultiplayerLobby), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0002248A File Offset: 0x0002068A
	[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5E98", Offset = "0x9C5E98", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMultiplayerLobby), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0002248D File Offset: 0x0002068D
	[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C60B4", Offset = "0x9C60B4", Length = "0x148")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00022490 File Offset: 0x00020690
	[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C61FC", Offset = "0x9C61FC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerMultiplayerLobby()
	{
		throw null;
	}

	// Token: 0x0400025F RID: 607
	[global::Cpp2ILInjected.Token(Token = "0x400038B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int selectedControl;

	// Token: 0x02000791 RID: 1937
	[global::Cpp2ILInjected.Token(Token = "0x200009B")]
	public enum Controls
	{
		// Token: 0x04007912 RID: 30994
		[global::Cpp2ILInjected.Token(Token = "0x400038D")]
		Local,
		// Token: 0x04007913 RID: 30995
		[global::Cpp2ILInjected.Token(Token = "0x400038E")]
		Dedicated,
		// Token: 0x04007914 RID: 30996
		[global::Cpp2ILInjected.Token(Token = "0x400038F")]
		Delete,
		// Token: 0x04007915 RID: 30997
		[global::Cpp2ILInjected.Token(Token = "0x4000390")]
		Favourite,
		// Token: 0x04007916 RID: 30998
		[global::Cpp2ILInjected.Token(Token = "0x4000391")]
		Play,
		// Token: 0x04007917 RID: 30999
		[global::Cpp2ILInjected.Token(Token = "0x4000392")]
		Back,
		// Token: 0x04007918 RID: 31000
		[global::Cpp2ILInjected.Token(Token = "0x4000393")]
		New
	}
}
