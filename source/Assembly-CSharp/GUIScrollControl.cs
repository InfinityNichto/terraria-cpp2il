using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000100 RID: 256
[global::Cpp2ILInjected.Token(Token = "0x200016F")]
public class GUIScrollControl
{
	// Token: 0x0600096E RID: 2414 RVA: 0x0002378F File Offset: 0x0002198F
	[global::Cpp2ILInjected.Token(Token = "0x6000A6E")]
	[global::Cpp2ILInjected.Address(RVA = "0x989B48", Offset = "0x989B48", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SetScrollWindow(DraggableItemGrid_Layout item)
	{
		throw null;
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00023792 File Offset: 0x00021992
	[global::Cpp2ILInjected.Token(Token = "0x6000A6F")]
	[global::Cpp2ILInjected.Address(RVA = "0x989DF4", Offset = "0x989DF4", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsGlobalScrollValid()
	{
		throw null;
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00023795 File Offset: 0x00021995
	[global::Cpp2ILInjected.Token(Token = "0x6000A70")]
	[global::Cpp2ILInjected.Address(RVA = "0x989E60", Offset = "0x989E60", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIScrollControl()
	{
		throw null;
	}

	// Token: 0x040007A3 RID: 1955
	[global::Cpp2ILInjected.Token(Token = "0x4000A56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private DraggableItemGrid_Layout currentScrollGrid;

	// Token: 0x040007A4 RID: 1956
	[global::Cpp2ILInjected.Token(Token = "0x4000A57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int currentItemFrame;
}
