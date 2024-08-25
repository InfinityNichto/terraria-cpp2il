using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x200021C")]
public class SettingsOverlay_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CCC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D03CC", Offset = "0x9D03CC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CCD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0418", Offset = "0x9D0418", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SettingsOverlay_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001499")]
	public static SettingsOverlay_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400149A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400149B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Titlewide1;

	[global::Cpp2ILInjected.Token(Token = "0x400149C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Titlewide2;

	[global::Cpp2ILInjected.Token(Token = "0x400149D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400149E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout OptionGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400149F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40014A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x40014A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x40014A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Home;

	[global::Cpp2ILInjected.Token(Token = "0x40014A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Achievements;

	[global::Cpp2ILInjected.Token(Token = "0x40014A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ResetSettings;

	[global::Cpp2ILInjected.Token(Token = "0x40014A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout ServerIPAddress;

	[global::Cpp2ILInjected.Token(Token = "0x40014A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public SettingsOverlayOptionCategories_Layout.Category DefaultCategory;

	[global::Cpp2ILInjected.Token(Token = "0x40014A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SettingsOverlayCategories_Layout Categories;

	[global::Cpp2ILInjected.Token(Token = "0x40014A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SettingsOverlayOptionCategories_Layout OptionCategories;

	[global::Cpp2ILInjected.Token(Token = "0x40014A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public SettingsOverlayLink_Layout LinkTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SettingsOverlayListOption_Layout ListOptionTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public SettingsOverlaySlider_Layout SliderTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public SettingsOverlayToggle_Layout ToggleTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public SettingsOverlayToggle_Layout DisabledToggleTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public SettingsOverlayCycle_Layout CycleTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public SettingsOverlayPulldown_Layout PulldownTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public SettingsOverlayListOption_Layout UIButtonOptionTemplate;

	[global::Cpp2ILInjected.Token(Token = "0x40014B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout PulldownLBOption;

	[global::Cpp2ILInjected.Token(Token = "0x40014B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout PulldownLTOption;

	[global::Cpp2ILInjected.Token(Token = "0x40014B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout PulldownRBOption;

	[global::Cpp2ILInjected.Token(Token = "0x40014B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout PulldownRTOption;

	[global::Cpp2ILInjected.Token(Token = "0x40014B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout PulldownAction1Option;

	[global::Cpp2ILInjected.Token(Token = "0x40014B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout PulldownAction2Option;

	[global::Cpp2ILInjected.Token(Token = "0x40014B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout PulldownAction3Option;

	[global::Cpp2ILInjected.Token(Token = "0x40014B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout PulldownAction4Option;

	[global::Cpp2ILInjected.Token(Token = "0x40014B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Vector2 PulldownMainButtonOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40014BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public int PulldownButtonLineWidth;

	[global::Cpp2ILInjected.Token(Token = "0x40014BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
	public int InGameOffset;
}
