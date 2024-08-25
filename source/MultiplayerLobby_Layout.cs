using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000205")]
public class MultiplayerLobby_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CA9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF584", Offset = "0x9CF584", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CAA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF5D0", Offset = "0x9CF5D0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerLobby_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012EF")]
	public static MultiplayerLobby_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40012F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40012F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Options;

	[global::Cpp2ILInjected.Token(Token = "0x40012F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout OptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40012F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x40012F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout LB;

	[global::Cpp2ILInjected.Token(Token = "0x40012F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout RB;

	[global::Cpp2ILInjected.Token(Token = "0x40012F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Local;

	[global::Cpp2ILInjected.Token(Token = "0x40012F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Dedicated;

	[global::Cpp2ILInjected.Token(Token = "0x40012F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Friends;

	[global::Cpp2ILInjected.Token(Token = "0x40012FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40012FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x40012FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x40012FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Join;

	[global::Cpp2ILInjected.Token(Token = "0x40012FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Delete;

	[global::Cpp2ILInjected.Token(Token = "0x40012FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x4001300")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout PlatformInvite;

	[global::Cpp2ILInjected.Token(Token = "0x4001301")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public bool ShowPlatformInvite;

	[global::Cpp2ILInjected.Token(Token = "0x4001302")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
	public bool AlwaysShowPlatformInvite;

	[global::Cpp2ILInjected.Token(Token = "0x4001303")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public DraggableItemGrid_Layout FriendsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001304")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public DraggableItemGrid_Layout LocalGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001305")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout LocalNew;

	[global::Cpp2ILInjected.Token(Token = "0x4001306")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout SearchingText;

	[global::Cpp2ILInjected.Token(Token = "0x4001307")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout SearchingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001308")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout NoFriendsText;

	[global::Cpp2ILInjected.Token(Token = "0x4001309")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public DraggableItemGrid_Layout DedicatedGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400130A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout DedicatedNew;

	[global::Cpp2ILInjected.Token(Token = "0x400130B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400130C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400130D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Button_Layout ItemPlay;

	[global::Cpp2ILInjected.Token(Token = "0x400130E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400130F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x4001310")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public int ItemNameMaxWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001311")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001312")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout ItemPlayerBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001313")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public String_Layout ItemPlayer;

	[global::Cpp2ILInjected.Token(Token = "0x4001314")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout ItemModeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001315")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public String_Layout ItemMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001316")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Panel_Layout ItemSizeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001317")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public String_Layout ItemSize;

	[global::Cpp2ILInjected.Token(Token = "0x4001318")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout ItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x4001319")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Button_Layout ItemFavourite;

	[global::Cpp2ILInjected.Token(Token = "0x400131A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public SelectPlayerFavoriteIcons FavoriteIcons;
}
