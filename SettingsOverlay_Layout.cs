using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000191")]
public class SettingsOverlay_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x400103E")]
	public static SettingsOverlay_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400103F")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001040")]
	public StringButton_Layout Titlewide1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001041")]
	public StringButton_Layout Titlewide2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001042")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001043")]
	public DraggableItemGrid_Layout OptionGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001044")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001045")]
	public Panel_Layout MenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001046")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001047")]
	public TransactionButton_Layout Home;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001048")]
	public TransactionButton_Layout Achievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001049")]
	public TransactionButton_Layout ResetSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400104A")]
	public String_Layout ServerIPAddress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400104B")]
	public SettingsOverlayOptionCategories_Layout.Category DefaultCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400104C")]
	public SettingsOverlayCategories_Layout Categories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400104D")]
	public SettingsOverlayOptionCategories_Layout OptionCategories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400104E")]
	public SettingsOverlayLink_Layout LinkTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400104F")]
	public SettingsOverlayListOption_Layout ListOptionTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001050")]
	public SettingsOverlaySlider_Layout SliderTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001051")]
	public SettingsOverlayToggle_Layout ToggleTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001052")]
	public SettingsOverlayToggle_Layout DisabledToggleTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001053")]
	public SettingsOverlayCycle_Layout CycleTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001054")]
	public SettingsOverlayPulldown_Layout PulldownTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001055")]
	public SettingsOverlayListOption_Layout UIButtonOptionTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001056")]
	public TransactionButton_Layout PulldownLBOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001057")]
	public TransactionButton_Layout PulldownLTOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001058")]
	public TransactionButton_Layout PulldownRBOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001059")]
	public TransactionButton_Layout PulldownRTOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400105A")]
	public TransactionButton_Layout PulldownAction1Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400105B")]
	public TransactionButton_Layout PulldownAction2Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400105C")]
	public TransactionButton_Layout PulldownAction3Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400105D")]
	public TransactionButton_Layout PulldownAction4Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400105E")]
	public Vector2 PulldownMainButtonOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400105F")]
	public int PulldownButtonLineWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001060")]
	public int InGameOffset;

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x105F5FC", Offset = "0x105F5FC", VA = "0x105F5FC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x105F658", Offset = "0x105F658", VA = "0x105F658")]
	public SettingsOverlay_Layout()
	{
	}
}
