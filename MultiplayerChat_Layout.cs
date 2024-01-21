using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class MultiplayerChat_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40010FF")]
	public static bool FromPage;

	[Cpp2IlInjected.Token(Token = "0x4001100")]
	public static MultiplayerChat_Layout _instance;

	[Cpp2IlInjected.Token(Token = "0x4001101")]
	public static MultiplayerChat_Layout _miniChatInstance;

	[Cpp2IlInjected.Token(Token = "0x4001102")]
	public static MultiplayerChat_Layout _instanceMobile;

	[Cpp2IlInjected.Token(Token = "0x4001103")]
	public static MultiplayerChat_Layout _miniChatInstanceMobile;

	[Cpp2IlInjected.Token(Token = "0x4001104")]
	public static MultiplayerChat_Layout _instanceLeft;

	[Cpp2IlInjected.Token(Token = "0x4001105")]
	public static MultiplayerChat_Layout _instanceRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001106")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001107")]
	public Vector2 BackingNotificationTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001108")]
	public Vector2 BackingNotificationBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001109")]
	public Panel_Layout BackingNotification;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400110A")]
	public TransactionButton_Layout Toggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400110B")]
	public TransactionButton_Layout ToggleOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400110C")]
	public ItemGrid_Layout NotificationGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400110D")]
	public DraggableItemGrid_Layout TextGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400110E")]
	public Panel_Layout ItemIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400110F")]
	public String_Layout ItemWho;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001110")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001111")]
	public Panel_Layout ItemSelectedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001112")]
	public String_Layout ItemText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001113")]
	public Vector2 ItemTextInset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001114")]
	public Panel_Layout BeginChatBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001115")]
	public Panel_Layout BeginChatDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001116")]
	public TransactionButton_Layout BeginChat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001117")]
	public TransactionButton_Layout BeginChatBarsUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001118")]
	public String_Layout ChatText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001119")]
	public Color ChattingTextColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400111A")]
	public float TextWrapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400111B")]
	public float TextWrapSizeBarsUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400111C")]
	public String_Layout PlayerNameText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400111D")]
	public float PlayerNameMaxLen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400111E")]
	public Panel_Layout EmotesGridBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400111F")]
	public StringButton_Layout EmotesTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4001120")]
	public Panel_Layout EmotesMenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001121")]
	public Panel_Layout EmotesMenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001122")]
	public TransactionButton_Layout EmotesGeneral;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001123")]
	public TransactionButton_Layout EmotesRPS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001124")]
	public TransactionButton_Layout EmotesItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001125")]
	public TransactionButton_Layout EmotesBiomesAndEvents;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001126")]
	public TransactionButton_Layout EmotesTownNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4001127")]
	public TransactionButton_Layout EmotesCritters;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4001128")]
	public TransactionButton_Layout EmotesBosses;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4001129")]
	public DraggableItemGrid_Layout EmotesGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400112A")]
	public TransactionButton_Layout PrimaryChat;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400112B")]
	public TransactionButton_Layout Emote;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400112C")]
	public TransactionButton_Layout EmotesClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400112D")]
	public float EmoteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400112E")]
	public Vector2 EmoteIconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400112F")]
	public float EmoteIconScale;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public static MultiplayerChat_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x10B1FBC", Offset = "0x10B1FBC", VA = "0x10B1FBC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public static MultiplayerChat_Layout EmotesWindowInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x10B2130", Offset = "0x10B2130", VA = "0x10B2130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public static MultiplayerChat_Layout MiniChatInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x10B21A8", Offset = "0x10B21A8", VA = "0x10B21A8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDD")]
	[Cpp2IlInjected.Address(RVA = "0x10B2280", Offset = "0x10B2280", VA = "0x10B2280")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDE")]
	[Cpp2IlInjected.Address(RVA = "0x10B24B8", Offset = "0x10B24B8", VA = "0x10B24B8")]
	public MultiplayerChat_Layout()
	{
	}
}
