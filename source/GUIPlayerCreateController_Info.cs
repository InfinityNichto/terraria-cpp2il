using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000AC RID: 172
[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
public class GUIPlayerCreateController_Info : GUIControllerItem
{
	// Token: 0x06000598 RID: 1432 RVA: 0x00022C0D File Offset: 0x00020E0D
	[global::Cpp2ILInjected.Token(Token = "0x600065E")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16D10", Offset = "0xD16D10", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_Info(GUIPlayerCreateController controller)
	{
		throw null;
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00022C10 File Offset: 0x00020E10
	[global::Cpp2ILInjected.Token(Token = "0x600065F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17C8C", Offset = "0xD17C8C", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PendingPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00022C13 File Offset: 0x00020E13
	[global::Cpp2ILInjected.Token(Token = "0x6000660")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17D2C", Offset = "0xD17D2C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00022C16 File Offset: 0x00020E16
	[global::Cpp2ILInjected.Token(Token = "0x6000661")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17D34", Offset = "0xD17D34", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "Activate", ReturnType = typeof(void))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00022C19 File Offset: 0x00020E19
	[global::Cpp2ILInjected.Token(Token = "0x6000662")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17D20", Offset = "0xD17D20", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateOptions(int selectedOption)
	{
		throw null;
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00022C1C File Offset: 0x00020E1C
	[global::Cpp2ILInjected.Token(Token = "0x6000663")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17DD4", Offset = "0xD17DD4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "CloseOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void DeactivateOptions()
	{
		throw null;
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00022C1F File Offset: 0x00020E1F
	[global::Cpp2ILInjected.Token(Token = "0x6000664")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17DE0", Offset = "0xD17DE0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "EnterName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateName()
	{
		throw null;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00022C22 File Offset: 0x00020E22
	[global::Cpp2ILInjected.Token(Token = "0x6000665")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17DE8", Offset = "0xD17DE8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void DeactivateName()
	{
		throw null;
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00022C25 File Offset: 0x00020E25
	[global::Cpp2ILInjected.Token(Token = "0x6000666")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17DF0", Offset = "0xD17DF0", Length = "0x158")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0400035F RID: 863
	[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000360 RID: 864
	[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int element;
}
