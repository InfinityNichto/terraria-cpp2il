using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[global::Cpp2ILInjected.Token(Token = "0x2000227")]
internal class MultiplayerChat_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x17000161")]
	public static MultiplayerChat_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0C70", Offset = "0x9D0C70", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "get_maxRowIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "get_maxRowColumn", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "UpdateEmoteScroll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "UpdateScrollRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "ChatDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000162")]
	public static MultiplayerChat_Layout EmotesWindowInstance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0D1C", Offset = "0x9D0D1C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000163")]
	public static MultiplayerChat_Layout MiniChatInstance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0D64", Offset = "0x9D0D64", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "ChatDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CE4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0DE8", Offset = "0x9D0DE8", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CE5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0F2C", Offset = "0x9D0F2C", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public MultiplayerChat_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001590")]
	public static bool FromPage;

	[global::Cpp2ILInjected.Token(Token = "0x4001591")]
	public static MultiplayerChat_Layout _instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001592")]
	public static MultiplayerChat_Layout _miniChatInstance;

	[global::Cpp2ILInjected.Token(Token = "0x4001593")]
	public static MultiplayerChat_Layout _instanceMobile;

	[global::Cpp2ILInjected.Token(Token = "0x4001594")]
	public static MultiplayerChat_Layout _miniChatInstanceMobile;

	[global::Cpp2ILInjected.Token(Token = "0x4001595")]
	public static MultiplayerChat_Layout _instanceLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001596")]
	public static MultiplayerChat_Layout _instanceRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001597")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001598")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 BackingNotificationTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001599")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 BackingNotificationBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x400159A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout BackingNotification;

	[global::Cpp2ILInjected.Token(Token = "0x400159B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Toggle;

	[global::Cpp2ILInjected.Token(Token = "0x400159C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ToggleOpen;

	[global::Cpp2ILInjected.Token(Token = "0x400159D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout NotificationGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400159E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public DraggableItemGrid_Layout TextGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400159F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40015A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ItemWho;

	[global::Cpp2ILInjected.Token(Token = "0x40015A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40015A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40015A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout ItemText;

	[global::Cpp2ILInjected.Token(Token = "0x40015A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 ItemTextInset;

	[global::Cpp2ILInjected.Token(Token = "0x40015A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout BeginChatBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40015A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout BeginChatDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40015A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout BeginChat;

	[global::Cpp2ILInjected.Token(Token = "0x40015A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout BeginChatBarsUI;

	[global::Cpp2ILInjected.Token(Token = "0x40015A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ChatText;

	[global::Cpp2ILInjected.Token(Token = "0x40015AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color ChattingTextColor;

	[global::Cpp2ILInjected.Token(Token = "0x40015AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public float TextWrapSize;

	[global::Cpp2ILInjected.Token(Token = "0x40015AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float TextWrapSizeBarsUI;

	[global::Cpp2ILInjected.Token(Token = "0x40015AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout PlayerNameText;

	[global::Cpp2ILInjected.Token(Token = "0x40015AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float PlayerNameMaxLen;

	[global::Cpp2ILInjected.Token(Token = "0x40015AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout EmotesGridBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40015B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public StringButton_Layout EmotesTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40015B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout EmotesMenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40015B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout EmotesMenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x40015B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout EmotesGeneral;

	[global::Cpp2ILInjected.Token(Token = "0x40015B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout EmotesRPS;

	[global::Cpp2ILInjected.Token(Token = "0x40015B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout EmotesItems;

	[global::Cpp2ILInjected.Token(Token = "0x40015B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout EmotesBiomesAndEvents;

	[global::Cpp2ILInjected.Token(Token = "0x40015B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout EmotesTownNPCs;

	[global::Cpp2ILInjected.Token(Token = "0x40015B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout EmotesCritters;

	[global::Cpp2ILInjected.Token(Token = "0x40015B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout EmotesBosses;

	[global::Cpp2ILInjected.Token(Token = "0x40015BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public DraggableItemGrid_Layout EmotesGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40015BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public TransactionButton_Layout PrimaryChat;

	[global::Cpp2ILInjected.Token(Token = "0x40015BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout Emote;

	[global::Cpp2ILInjected.Token(Token = "0x40015BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout EmotesClose;

	[global::Cpp2ILInjected.Token(Token = "0x40015BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public float EmoteScale;

	[global::Cpp2ILInjected.Token(Token = "0x40015BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
	public Vector2 EmoteIconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40015C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	public float EmoteIconScale;
}
