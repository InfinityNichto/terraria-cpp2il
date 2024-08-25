using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000203")]
public class MultiplayerHost_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CA5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF43C", Offset = "0x9CF43C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CA6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF488", Offset = "0x9CF488", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerHost_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012C3")]
	public static MultiplayerHost_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40012C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	[global::Cpp2ILInjected.Token(Token = "0x40012C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40012C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40012C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x40012C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Host;

	[global::Cpp2ILInjected.Token(Token = "0x40012CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public MaxPlayersSlider_Layout MaxPlayers;

	[global::Cpp2ILInjected.Token(Token = "0x40012CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Password;

	[global::Cpp2ILInjected.Token(Token = "0x40012CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40012CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Button_Layout ItemPlay;

	[global::Cpp2ILInjected.Token(Token = "0x40012CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Button_Layout ItemDelete;

	[global::Cpp2ILInjected.Token(Token = "0x40012CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Button_Layout ItemFavourite;

	[global::Cpp2ILInjected.Token(Token = "0x40012D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40012D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x40012D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40012D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout ItemTimeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40012D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout ItemTime;

	[global::Cpp2ILInjected.Token(Token = "0x40012D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Panel_Layout ItemModeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40012D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ItemMode;

	[global::Cpp2ILInjected.Token(Token = "0x40012D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ItemSizeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40012D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout ItemSize;

	[global::Cpp2ILInjected.Token(Token = "0x40012D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x40012DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public String_Layout PlayerCountTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40012DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout PlayerCountLabel;

	[global::Cpp2ILInjected.Token(Token = "0x40012DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Slider_Layout PlayerCount;

	[global::Cpp2ILInjected.Token(Token = "0x40012DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public String_Layout ServerPasswordTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40012DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public String_Layout ServerPasswordEdit;

	[global::Cpp2ILInjected.Token(Token = "0x40012DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public SettingsOverlayToggle_Layout InviteOpenToggle;
}
