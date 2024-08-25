using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
public class GUIControllerDresser : GUIPageContentController
{
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

	[global::Cpp2ILInjected.Token(Token = "0x400044B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public GUIControllerDresser.Controls selectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x400044C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int Item;

	[global::Cpp2ILInjected.Token(Token = "0x20000C3")]
	public enum Controls
	{
		[global::Cpp2ILInjected.Token(Token = "0x400044E")]
		Style,
		[global::Cpp2ILInjected.Token(Token = "0x400044F")]
		Skin,
		[global::Cpp2ILInjected.Token(Token = "0x4000450")]
		Eyes,
		[global::Cpp2ILInjected.Token(Token = "0x4000451")]
		Shirt,
		[global::Cpp2ILInjected.Token(Token = "0x4000452")]
		Undershirt,
		[global::Cpp2ILInjected.Token(Token = "0x4000453")]
		Pants,
		[global::Cpp2ILInjected.Token(Token = "0x4000454")]
		Shoes,
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		Element,
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		Back,
		[global::Cpp2ILInjected.Token(Token = "0x4000457")]
		Change
	}
}
