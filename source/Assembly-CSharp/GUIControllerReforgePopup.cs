using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200009E RID: 158
[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
public class GUIControllerReforgePopup : GUIControllerItem
{
	// Token: 0x060004FE RID: 1278 RVA: 0x00022A3F File Offset: 0x00020C3F
	[global::Cpp2ILInjected.Token(Token = "0x6000598")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2215C", Offset = "0xB2215C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00022A42 File Offset: 0x00020C42
	[global::Cpp2ILInjected.Token(Token = "0x6000599")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22164", Offset = "0xB22164", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00022A45 File Offset: 0x00020C45
	[global::Cpp2ILInjected.Token(Token = "0x600059A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2216C", Offset = "0xB2216C", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00022A48 File Offset: 0x00020C48
	[global::Cpp2ILInjected.Token(Token = "0x600059B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2218C", Offset = "0xB2218C", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReforgePopup), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00022A4B File Offset: 0x00020C4B
	[global::Cpp2ILInjected.Token(Token = "0x600059C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22248", Offset = "0xB22248", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerReforgePopup()
	{
		throw null;
	}

	// Token: 0x04000324 RID: 804
	[global::Cpp2ILInjected.Token(Token = "0x40004AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerReforgePopup.Controls selectedControl;

	// Token: 0x0200079C RID: 1948
	[global::Cpp2ILInjected.Token(Token = "0x20000D9")]
	public enum Controls
	{
		// Token: 0x04007970 RID: 31088
		[global::Cpp2ILInjected.Token(Token = "0x40004B0")]
		Reforge,
		// Token: 0x04007971 RID: 31089
		[global::Cpp2ILInjected.Token(Token = "0x40004B1")]
		Back
	}
}
