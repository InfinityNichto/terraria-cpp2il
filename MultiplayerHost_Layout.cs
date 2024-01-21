using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200017A")]
public class MultiplayerHost_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E7F")]
	public static MultiplayerHost_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E80")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E81")]
	public Panel_Layout Greyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E82")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000E83")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000E84")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000E85")]
	public TransactionButton_Layout Host;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000E86")]
	public MaxPlayersSlider_Layout MaxPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000E87")]
	public TransactionButton_Layout Password;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000E88")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000E89")]
	public Button_Layout ItemPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000E8A")]
	public Button_Layout ItemDelete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000E8B")]
	public Button_Layout ItemFavourite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000E8C")]
	public Button_Layout ItemDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000E8D")]
	public String_Layout ItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000E8E")]
	public Panel_Layout ItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000E8F")]
	public Panel_Layout ItemTimeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000E90")]
	public String_Layout ItemTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000E91")]
	public Panel_Layout ItemModeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000E92")]
	public String_Layout ItemMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000E93")]
	public Panel_Layout ItemSizeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000E94")]
	public String_Layout ItemSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000E95")]
	public Panel_Layout ItemImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000E96")]
	public String_Layout PlayerCountTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000E97")]
	public String_Layout PlayerCountLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000E98")]
	public Slider_Layout PlayerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000E99")]
	public String_Layout ServerPasswordTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000E9A")]
	public String_Layout ServerPasswordEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000E9B")]
	public SettingsOverlayToggle_Layout InviteOpenToggle;

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x10B2630", Offset = "0x10B2630", VA = "0x10B2630")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x10B268C", Offset = "0x10B268C", VA = "0x10B268C")]
	public MultiplayerHost_Layout()
	{
	}
}
