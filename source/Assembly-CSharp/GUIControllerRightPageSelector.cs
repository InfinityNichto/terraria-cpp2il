using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x020000A0 RID: 160
[global::Cpp2ILInjected.Token(Token = "0x20000DB")]
public class GUIControllerRightPageSelector : GUIControllerItem
{
	// Token: 0x06000512 RID: 1298 RVA: 0x00022A7B File Offset: 0x00020C7B
	[global::Cpp2ILInjected.Token(Token = "0x60005AC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22874", Offset = "0xB22874", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00022A7E File Offset: 0x00020C7E
	[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB228F4", Offset = "0xB228F4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00022A81 File Offset: 0x00020C81
	[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
	[global::Cpp2ILInjected.Address(RVA = "0xB228FC", Offset = "0xB228FC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00022A84 File Offset: 0x00020C84
	[global::Cpp2ILInjected.Token(Token = "0x60005AF")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22904", Offset = "0xB22904", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00022A87 File Offset: 0x00020C87
	[global::Cpp2ILInjected.Token(Token = "0x60005B0")]
	[global::Cpp2ILInjected.Address(RVA = "0xB229E4", Offset = "0xB229E4", Length = "0x268")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00022A8A File Offset: 0x00020C8A
	[global::Cpp2ILInjected.Token(Token = "0x60005B1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB203F4", Offset = "0xB203F4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerRightPageSelector()
	{
		throw null;
	}

	// Token: 0x04000326 RID: 806
	[global::Cpp2ILInjected.Token(Token = "0x40004B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int selectedIndex;
}
