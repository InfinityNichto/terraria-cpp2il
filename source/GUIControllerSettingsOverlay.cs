using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000074 RID: 116
[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
public class GUIControllerSettingsOverlay : GUIControllerItem
{
	// Token: 0x06000357 RID: 855 RVA: 0x0002254A File Offset: 0x0002074A
	[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82C8C", Offset = "0xA82C8C", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "SettingOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void SelectedSetting(int index)
	{
		throw null;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0002254D File Offset: 0x0002074D
	[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82C98", Offset = "0xA82C98", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00022550 File Offset: 0x00020750
	[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82EC4", Offset = "0xA82EC4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00022553 File Offset: 0x00020753
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

	// Token: 0x0600035B RID: 859 RVA: 0x00022556 File Offset: 0x00020756
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

	// Token: 0x0600035C RID: 860 RVA: 0x00022559 File Offset: 0x00020759
	[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83144", Offset = "0xA83144", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x0002255C File Offset: 0x0002075C
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

	// Token: 0x0600035E RID: 862 RVA: 0x0002255F File Offset: 0x0002075F
	[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83160", Offset = "0xA83160", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	public bool OverlayActive()
	{
		throw null;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00022562 File Offset: 0x00020762
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

	// Token: 0x06000360 RID: 864 RVA: 0x00022565 File Offset: 0x00020765
	[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA83594", Offset = "0xA83594", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerSettingsOverlay()
	{
		throw null;
	}

	// Token: 0x04000288 RID: 648
	[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIPulldownSetting _overlayEntry;

	// Token: 0x04000289 RID: 649
	[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Rectangle _overlayRegion;

	// Token: 0x0400028A RID: 650
	[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _overlayIndex;

	// Token: 0x0400028B RID: 651
	[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float _overlayOffset;

	// Token: 0x0400028C RID: 652
	[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIControllerSettingsOverlay.Controls selectedControl;

	// Token: 0x0400028D RID: 653
	[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private int _selectedItem;

	// Token: 0x02000795 RID: 1941
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	private enum Controls
	{
		// Token: 0x04007924 RID: 31012
		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		PageSettings,
		// Token: 0x04007925 RID: 31013
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		PageInterface,
		// Token: 0x04007926 RID: 31014
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		PageVideo,
		// Token: 0x04007927 RID: 31015
		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		PageSound,
		// Token: 0x04007928 RID: 31016
		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		PageControls,
		// Token: 0x04007929 RID: 31017
		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		PageTouch,
		// Token: 0x0400792A RID: 31018
		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		PageController,
		// Token: 0x0400792B RID: 31019
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		PageKeyboard,
		// Token: 0x0400792C RID: 31020
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		Element,
		// Token: 0x0400792D RID: 31021
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		Reset,
		// Token: 0x0400792E RID: 31022
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		Back
	}
}
