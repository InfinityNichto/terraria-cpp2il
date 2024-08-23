using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;

// Token: 0x02000075 RID: 117
[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
public class GUIControllerWiresUI : GUIControllerItem
{
	// Token: 0x06000361 RID: 865 RVA: 0x00022568 File Offset: 0x00020768
	[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA835A4", Offset = "0xA835A4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x0002256B File Offset: 0x0002076B
	[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA835A8", Offset = "0xA835A8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x0002256E File Offset: 0x0002076E
	[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA835B0", Offset = "0xA835B0", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolAllowActuators", ReturnType = typeof(bool))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00022571 File Offset: 0x00020771
	[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83644", Offset = "0xA83644", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolAllowActuators", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WireUI_Layout), Member = "get_Instance", ReturnType = typeof(WireUI_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00022574 File Offset: 0x00020774
	[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA837E0", Offset = "0xA837E0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerWiresUI()
	{
		throw null;
	}

	// Token: 0x0400028E RID: 654
	[global::Cpp2ILInjected.Token(Token = "0x40003D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int _selectedRow;

	// Token: 0x0400028F RID: 655
	[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int _selectedColumn;
}
