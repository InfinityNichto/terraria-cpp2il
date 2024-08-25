using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200023D")]
public class SaveSynchronisationLobby_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D17")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2558", Offset = "0x9D2558", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D18")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D25A4", Offset = "0x9D25A4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSynchronisationLobby_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40017BD")]
	public static SaveSynchronisationLobby_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40017BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40017BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40017C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x40017C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Connect;

	[global::Cpp2ILInjected.Token(Token = "0x40017C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ConnectViaIP;

	[global::Cpp2ILInjected.Token(Token = "0x40017C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout SearchingText;

	[global::Cpp2ILInjected.Token(Token = "0x40017C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Button_Layout SearchingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40017C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public DraggableItemGrid_Layout HostDevicesGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40017C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40017C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x40017CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public int ItemNameMaxWidth;

	[global::Cpp2ILInjected.Token(Token = "0x40017CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40017CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ItemPlayers;

	[global::Cpp2ILInjected.Token(Token = "0x40017CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout ItemWorlds;

	[global::Cpp2ILInjected.Token(Token = "0x40017CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout ItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x40017CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout PC_Icon;

	[global::Cpp2ILInjected.Token(Token = "0x40017D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Texture_Layout Amazon_Icon;

	[global::Cpp2ILInjected.Token(Token = "0x40017D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Texture_Layout Google_Icon;

	[global::Cpp2ILInjected.Token(Token = "0x40017D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Texture_Layout iOS_Icon;

	[global::Cpp2ILInjected.Token(Token = "0x40017D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Texture_Layout XBOX_Icon;

	[global::Cpp2ILInjected.Token(Token = "0x40017D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Texture_Layout PS4_Icon;

	[global::Cpp2ILInjected.Token(Token = "0x40017D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout Switch_Icon;
}
