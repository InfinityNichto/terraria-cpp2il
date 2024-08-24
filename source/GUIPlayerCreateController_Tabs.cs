using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000AF RID: 175
[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
public class GUIPlayerCreateController_Tabs : GUIControllerItem
{
	// Token: 0x060005AC RID: 1452 RVA: 0x00022C49 File Offset: 0x00020E49
	[global::Cpp2ILInjected.Token(Token = "0x6000672")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16CE8", Offset = "0xD16CE8", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_Tabs(GUIPlayerCreateController controller)
	{
		throw null;
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00022C4C File Offset: 0x00020E4C
	[global::Cpp2ILInjected.Token(Token = "0x6000673")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1722C", Offset = "0xD1722C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Gender), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Info), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_ItemColour), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00022C4F File Offset: 0x00020E4F
	[global::Cpp2ILInjected.Token(Token = "0x6000674")]
	[global::Cpp2ILInjected.Address(RVA = "0xD182A8", Offset = "0xD182A8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00022C52 File Offset: 0x00020E52
	[global::Cpp2ILInjected.Token(Token = "0x6000675")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16DD8", Offset = "0xD16DD8", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Tabs), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Gender), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Info), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "get_currentScrollOffset", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem NavigateIntoCurrentPage(bool fromTabSwitch = false)
	{
		throw null;
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00022C55 File Offset: 0x00020E55
	[global::Cpp2ILInjected.Token(Token = "0x6000676")]
	[global::Cpp2ILInjected.Address(RVA = "0xD182B0", Offset = "0xD182B0", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00022C58 File Offset: 0x00020E58
	[global::Cpp2ILInjected.Token(Token = "0x6000677")]
	[global::Cpp2ILInjected.Address(RVA = "0xD182F4", Offset = "0xD182F4", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x04000365 RID: 869
	[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000366 RID: 870
	[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIPlayerCreateMenu.ItemSelection HighlightedTab;
}
