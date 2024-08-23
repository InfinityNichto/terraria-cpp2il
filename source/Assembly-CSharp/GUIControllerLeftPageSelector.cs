using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000097 RID: 151
[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
public class GUIControllerLeftPageSelector : GUIControllerItem
{
	// Token: 0x060004A3 RID: 1187 RVA: 0x0002292E File Offset: 0x00020B2E
	[global::Cpp2ILInjected.Token(Token = "0x600053D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EA2C", Offset = "0xB1EA2C", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00022931 File Offset: 0x00020B31
	[global::Cpp2ILInjected.Token(Token = "0x600053E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EAAC", Offset = "0xB1EAAC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00022934 File Offset: 0x00020B34
	[global::Cpp2ILInjected.Token(Token = "0x600053F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EAB4", Offset = "0xB1EAB4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00022937 File Offset: 0x00020B37
	[global::Cpp2ILInjected.Token(Token = "0x6000540")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EABC", Offset = "0xB1EABC", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x0002293A File Offset: 0x00020B3A
	[global::Cpp2ILInjected.Token(Token = "0x6000541")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EB9C", Offset = "0xB1EB9C", Length = "0x260")]
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

	// Token: 0x060004A8 RID: 1192 RVA: 0x0002293D File Offset: 0x00020B3D
	[global::Cpp2ILInjected.Token(Token = "0x6000542")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EDFC", Offset = "0xB1EDFC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerLeftPageSelector()
	{
		throw null;
	}

	// Token: 0x040002F3 RID: 755
	[global::Cpp2ILInjected.Token(Token = "0x400047D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int selectedIndex;
}
