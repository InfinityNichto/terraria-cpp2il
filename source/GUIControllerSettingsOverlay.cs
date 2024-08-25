using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
public class GUIControllerSettingsOverlay : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82C8C", Offset = "0xA82C8C", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "SettingOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void SelectedSetting(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82C98", Offset = "0xA82C98", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82EC4", Offset = "0xA82EC4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82CA8", Offset = "0xA82CA8", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSettingsOverlay), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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
	public void UpdateScroll()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82ECC", Offset = "0xA82ECC", Length = "0x278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "GetNumberOfOptions", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSettingsOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83144", Offset = "0xA83144", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83158", Offset = "0xA83158", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "CloseOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "DisablePulldown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	public void DeactivateOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83160", Offset = "0xA83160", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	public bool OverlayActive()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83170", Offset = "0xA83170", Length = "0x424")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsOverlayPulldown_Layout), Member = "GetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TransactionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83594", Offset = "0xA83594", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerSettingsOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIPulldownSetting _overlayEntry;

	[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Rectangle _overlayRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _overlayIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float _overlayOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIControllerSettingsOverlay.Controls selectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private int _selectedItem;

	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	private enum Controls
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		PageSettings,
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		PageInterface,
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		PageVideo,
		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		PageSound,
		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		PageControls,
		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		PageTouch,
		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		PageController,
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		PageKeyboard,
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		Element,
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		Reset,
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		Back
	}
}
