using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000079")]
public class GUIControllerMappingOverlay : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x716CDC", Offset = "0x716CDC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x71CF04", Offset = "0x71CF04", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
	[global::Cpp2ILInjected.Address(RVA = "0x71CCEC", Offset = "0x71CCEC", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingOverlay), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingOverlay), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void UpdateScroll()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
	[global::Cpp2ILInjected.Address(RVA = "0x71CF0C", Offset = "0x71CF0C", Length = "0x28C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPulldownEntry), Member = "GetNumberOfOptions", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
	[global::Cpp2ILInjected.Address(RVA = "0x7137E8", Offset = "0x7137E8", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void ActivateOverlay(GUIControllerMappingEntry overlayEntry, Rectangle overlayRegion)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D198", Offset = "0x71D198", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPulldownEntry), Member = "ActivateOverlay", MemberParameters = new object[]
	{
		typeof(GUIPulldownSetting),
		typeof(Rectangle),
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateOverlay(GUIControllerPulldownEntry overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
	[global::Cpp2ILInjected.Address(RVA = "0x7138A0", Offset = "0x7138A0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPulldownEntry), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void DeactivateOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D1AC", Offset = "0x71D1AC", Length = "0x48C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsOverlayPulldown_Layout), Member = "GetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TransactionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
	[global::Cpp2ILInjected.Address(RVA = "0x71CC64", Offset = "0x71CC64", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerMappingOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000304")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingEntryBase _overlayEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4000305")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Rectangle _overlayRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000306")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _overlayIndex;

	[global::Cpp2ILInjected.Token(Token = "0x4000307")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float _overlayOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000308")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerMappingOverlay.Controls selectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000309")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int _selectedItem;

	[global::Cpp2ILInjected.Token(Token = "0x200007A")]
	public enum Controls
	{
		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		PageGeneral,
		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		PageExplore,
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		PageFight,
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		PageMisc,
		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		PageInventory,
		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		PageChest,
		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		PageEquipment,
		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		PageShopsCraft,
		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		PagePVP,
		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		PageMap,
		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		Element,
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		Reset,
		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		Back
	}
}
