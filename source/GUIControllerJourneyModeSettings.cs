using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000067 RID: 103
[global::Cpp2ILInjected.Token(Token = "0x2000094")]
public class GUIControllerJourneyModeSettings : GUIControllerItem
{
	// Token: 0x060002F5 RID: 757 RVA: 0x00022424 File Offset: 0x00020624
	[global::Cpp2ILInjected.Token(Token = "0x600038F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C50A4", Offset = "0x9C50A4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "SettingOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void SelectedSetting(int index)
	{
		throw null;
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00022427 File Offset: 0x00020627
	[global::Cpp2ILInjected.Token(Token = "0x6000390")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C50B0", Offset = "0x9C50B0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0002242A File Offset: 0x0002062A
	[global::Cpp2ILInjected.Token(Token = "0x6000391")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C52D4", Offset = "0x9C52D4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0002242D File Offset: 0x0002062D
	[global::Cpp2ILInjected.Token(Token = "0x6000392")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C50B8", Offset = "0x9C50B8", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerJourneyModeSettings), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

	// Token: 0x060002F9 RID: 761 RVA: 0x00022430 File Offset: 0x00020630
	[global::Cpp2ILInjected.Token(Token = "0x6000393")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C52DC", Offset = "0x9C52DC", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "GetNumberOfOptions", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerJourneyModeSettings), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00022433 File Offset: 0x00020633
	[global::Cpp2ILInjected.Token(Token = "0x6000394")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C548C", Offset = "0x9C548C", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyPulldownSetting), Member = "ActivateOverlay", MemberParameters = new object[]
	{
		typeof(GUIPulldownSetting),
		typeof(Rectangle),
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00022436 File Offset: 0x00020636
	[global::Cpp2ILInjected.Token(Token = "0x6000395")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C54A0", Offset = "0x9C54A0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyPulldownSetting), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateOverlay()
	{
		throw null;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00022439 File Offset: 0x00020639
	[global::Cpp2ILInjected.Token(Token = "0x6000396")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C54A8", Offset = "0x9C54A8", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool OverlayActive()
	{
		throw null;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0002243C File Offset: 0x0002063C
	[global::Cpp2ILInjected.Token(Token = "0x6000397")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C54B8", Offset = "0x9C54B8", Length = "0x358")]
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

	// Token: 0x060002FE RID: 766 RVA: 0x0002243F File Offset: 0x0002063F
	[global::Cpp2ILInjected.Token(Token = "0x6000398")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5810", Offset = "0x9C5810", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerJourneyModeSettings()
	{
		throw null;
	}

	// Token: 0x04000253 RID: 595
	[global::Cpp2ILInjected.Token(Token = "0x4000376")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIPulldownSetting _overlayEntry;

	// Token: 0x04000254 RID: 596
	[global::Cpp2ILInjected.Token(Token = "0x4000377")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Rectangle _overlayRegion;

	// Token: 0x04000255 RID: 597
	[global::Cpp2ILInjected.Token(Token = "0x4000378")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _overlayIndex;

	// Token: 0x04000256 RID: 598
	[global::Cpp2ILInjected.Token(Token = "0x4000379")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float _overlayOffset;

	// Token: 0x04000257 RID: 599
	[global::Cpp2ILInjected.Token(Token = "0x400037A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerJourneyModeSettings.Controls selectedControl;

	// Token: 0x04000258 RID: 600
	[global::Cpp2ILInjected.Token(Token = "0x400037B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private int _selectedItem;

	// Token: 0x0200078F RID: 1935
	[global::Cpp2ILInjected.Token(Token = "0x2000095")]
	public enum Controls
	{
		// Token: 0x04007909 RID: 30985
		[global::Cpp2ILInjected.Token(Token = "0x400037D")]
		Time,
		// Token: 0x0400790A RID: 30986
		[global::Cpp2ILInjected.Token(Token = "0x400037E")]
		Weather,
		// Token: 0x0400790B RID: 30987
		[global::Cpp2ILInjected.Token(Token = "0x400037F")]
		Power,
		// Token: 0x0400790C RID: 30988
		[global::Cpp2ILInjected.Token(Token = "0x4000380")]
		Element,
		// Token: 0x0400790D RID: 30989
		[global::Cpp2ILInjected.Token(Token = "0x4000381")]
		Back
	}
}
