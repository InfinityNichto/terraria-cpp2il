using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000AD RID: 173
[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
public class GUIPlayerCreateController_ItemColour : GUIControllerItem
{
	// Token: 0x060005A1 RID: 1441 RVA: 0x00022C28 File Offset: 0x00020E28
	[global::Cpp2ILInjected.Token(Token = "0x6000667")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16D90", Offset = "0xD16D90", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_ItemColour(GUIPlayerCreateController controller)
	{
		throw null;
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00022C2B File Offset: 0x00020E2B
	[global::Cpp2ILInjected.Token(Token = "0x6000668")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17F48", Offset = "0xD17F48", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00022C2E File Offset: 0x00020E2E
	[global::Cpp2ILInjected.Token(Token = "0x6000669")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17F50", Offset = "0xD17F50", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00022C31 File Offset: 0x00020E31
	[global::Cpp2ILInjected.Token(Token = "0x600066A")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17F58", Offset = "0xD17F58", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "Activate", ReturnType = typeof(void))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00022C34 File Offset: 0x00020E34
	[global::Cpp2ILInjected.Token(Token = "0x600066B")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17FCC", Offset = "0xD17FCC", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "GetRegion", MemberParameters = new object[] { typeof(Slider_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x04000361 RID: 865
	[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000362 RID: 866
	[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int selectionIndex;
}
