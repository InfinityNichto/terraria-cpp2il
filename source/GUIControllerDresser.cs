using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200008A RID: 138
[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
public class GUIControllerDresser : GUIPageContentController
{
	// Token: 0x06000422 RID: 1058 RVA: 0x000227AB File Offset: 0x000209AB
	[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8BF98", Offset = "0xA8BF98", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerDresser()
	{
		throw null;
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x000227AE File Offset: 0x000209AE
	[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8BFAC", Offset = "0xA8BFAC", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_selClothes", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClothesWindow), Member = "GetSelectedStyle", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x000227B1 File Offset: 0x000209B1
	[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C040", Offset = "0xA8C040", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_selClothes", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClothesWindow), Member = "GetSelectedStyle", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x000227B4 File Offset: 0x000209B4
	[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8C258", Offset = "0xA8C258", Length = "0x2BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_selClothes", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "GetRegion", MemberParameters = new object[] { typeof(Slider_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002D2 RID: 722
	[global::Cpp2ILInjected.Token(Token = "0x400044B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public GUIControllerDresser.Controls selectedControl;

	// Token: 0x040002D3 RID: 723
	[global::Cpp2ILInjected.Token(Token = "0x400044C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int Item;

	// Token: 0x0200079A RID: 1946
	[global::Cpp2ILInjected.Token(Token = "0x20000C3")]
	public enum Controls
	{
		// Token: 0x0400795F RID: 31071
		[global::Cpp2ILInjected.Token(Token = "0x400044E")]
		Style,
		// Token: 0x04007960 RID: 31072
		[global::Cpp2ILInjected.Token(Token = "0x400044F")]
		Skin,
		// Token: 0x04007961 RID: 31073
		[global::Cpp2ILInjected.Token(Token = "0x4000450")]
		Eyes,
		// Token: 0x04007962 RID: 31074
		[global::Cpp2ILInjected.Token(Token = "0x4000451")]
		Shirt,
		// Token: 0x04007963 RID: 31075
		[global::Cpp2ILInjected.Token(Token = "0x4000452")]
		Undershirt,
		// Token: 0x04007964 RID: 31076
		[global::Cpp2ILInjected.Token(Token = "0x4000453")]
		Pants,
		// Token: 0x04007965 RID: 31077
		[global::Cpp2ILInjected.Token(Token = "0x4000454")]
		Shoes,
		// Token: 0x04007966 RID: 31078
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		Element,
		// Token: 0x04007967 RID: 31079
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		Back,
		// Token: 0x04007968 RID: 31080
		[global::Cpp2ILInjected.Token(Token = "0x4000457")]
		Change
	}
}
