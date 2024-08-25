using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000AC")]
public class GUIKeyboardMappingOverlay : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x6000406")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83CDC", Offset = "0xA83CDC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000407")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83F18", Offset = "0xA83F18", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000408")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83CE4", Offset = "0xA83CE4", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingOverlay), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "GetElementHeight", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void UpdateScroll()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000409")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83F20", Offset = "0xA83F20", Length = "0x1E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84108", Offset = "0xA84108", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateOverlay(GUIKeyboardMappingEntry overlayEntry, Rectangle overlayRegion)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84114", Offset = "0xA84114", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	public void DeactivateOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8411C", Offset = "0xA8411C", Length = "0x38C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "GetElementHeight", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844A8", Offset = "0xA844A8", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIKeyboardMappingOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIKeyboardMappingEntry _overlayEntry;

	[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Rectangle _overlayRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _overlayIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float _overlayOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIKeyboardMappingOverlay.Controls selectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x40003E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int _selectedItem;

	[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
	public enum Controls
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003EA")]
		PageGeneral,
		[global::Cpp2ILInjected.Token(Token = "0x40003EB")]
		PageExplore,
		[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
		PageFight,
		[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
		PageMisc,
		[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
		PageMap,
		[global::Cpp2ILInjected.Token(Token = "0x40003EF")]
		Element,
		[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
		Reset,
		[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
		Default,
		[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
		Back
	}
}
