using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;

// Token: 0x020000DF RID: 223
[global::Cpp2ILInjected.Token(Token = "0x2000142")]
public class GUIEvents
{
	// Token: 0x060007B2 RID: 1970 RVA: 0x0002325B File Offset: 0x0002145B
	[global::Cpp2ILInjected.Token(Token = "0x60008AC")]
	[global::Cpp2ILInjected.Address(RVA = "0x7FDAC0", Offset = "0x7FDAC0", Length = "0x660")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInvasionProgress", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Events_Layout), Member = "get_Instance", ReturnType = typeof(Events_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Color?),
		typeof(Color?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEvents), Member = "DrawProgressBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEvents), Member = "DrawInfiniteProgressBar", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
	public void DrawInvasionInfo(Color panel, string title, string waveProgressString, Texture2D icon, float progressScale)
	{
		throw null;
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0002325E File Offset: 0x0002145E
	[global::Cpp2ILInjected.Token(Token = "0x60008AD")]
	[global::Cpp2ILInjected.Address(RVA = "0x7FE120", Offset = "0x7FE120", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEvents), Member = "DrawInvasionInfo", MemberParameters = new object[]
	{
		typeof(Color),
		typeof(string),
		typeof(string),
		typeof(Texture2D),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Events_Layout), Member = "get_Instance", ReturnType = typeof(Events_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Color?),
		typeof(Color?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawHorizontalFill", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Rectangle),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void DrawProgressBar(float progress)
	{
		throw null;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00023261 File Offset: 0x00021461
	[global::Cpp2ILInjected.Token(Token = "0x60008AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x7FE32C", Offset = "0x7FE32C", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEvents), Member = "DrawInvasionInfo", MemberParameters = new object[]
	{
		typeof(Color),
		typeof(string),
		typeof(string),
		typeof(Texture2D),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Events_Layout), Member = "get_Instance", ReturnType = typeof(Events_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Color?),
		typeof(Color?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawHorizontalFill", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Rectangle),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void DrawInfiniteProgressBar()
	{
		throw null;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00023264 File Offset: 0x00021464
	[global::Cpp2ILInjected.Token(Token = "0x60008AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x7FE4FC", Offset = "0x7FE4FC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIEvents()
	{
		throw null;
	}

	// Token: 0x04000526 RID: 1318
	[global::Cpp2ILInjected.Token(Token = "0x400077A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float testProgress;
}
