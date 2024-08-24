using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000199 RID: 409
[global::Cpp2ILInjected.Token(Token = "0x2000227")]
internal class MultiplayerChat_Layout : LayoutDefinition
{
	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00023E9D File Offset: 0x0002209D
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

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00023EA0 File Offset: 0x000220A0
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

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00023EA3 File Offset: 0x000220A3
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

	// Token: 0x06000BCB RID: 3019 RVA: 0x00023EA6 File Offset: 0x000220A6
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

	// Token: 0x06000BCC RID: 3020 RVA: 0x00023EA9 File Offset: 0x000220A9
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

	// Token: 0x040010F6 RID: 4342
	[global::Cpp2ILInjected.Token(Token = "0x4001590")]
	public static bool FromPage;

	// Token: 0x040010F7 RID: 4343
	[global::Cpp2ILInjected.Token(Token = "0x4001591")]
	public static MultiplayerChat_Layout _instance;

	// Token: 0x040010F8 RID: 4344
	[global::Cpp2ILInjected.Token(Token = "0x4001592")]
	public static MultiplayerChat_Layout _miniChatInstance;

	// Token: 0x040010F9 RID: 4345
	[global::Cpp2ILInjected.Token(Token = "0x4001593")]
	public static MultiplayerChat_Layout _instanceMobile;

	// Token: 0x040010FA RID: 4346
	[global::Cpp2ILInjected.Token(Token = "0x4001594")]
	public static MultiplayerChat_Layout _miniChatInstanceMobile;

	// Token: 0x040010FB RID: 4347
	[global::Cpp2ILInjected.Token(Token = "0x4001595")]
	public static MultiplayerChat_Layout _instanceLeft;

	// Token: 0x040010FC RID: 4348
	[global::Cpp2ILInjected.Token(Token = "0x4001596")]
	public static MultiplayerChat_Layout _instanceRight;

	// Token: 0x040010FD RID: 4349
	[global::Cpp2ILInjected.Token(Token = "0x4001597")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x040010FE RID: 4350
	[global::Cpp2ILInjected.Token(Token = "0x4001598")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 BackingNotificationTLOffset;

	// Token: 0x040010FF RID: 4351
	[global::Cpp2ILInjected.Token(Token = "0x4001599")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 BackingNotificationBROffset;

	// Token: 0x04001100 RID: 4352
	[global::Cpp2ILInjected.Token(Token = "0x400159A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout BackingNotification;

	// Token: 0x04001101 RID: 4353
	[global::Cpp2ILInjected.Token(Token = "0x400159B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Toggle;

	// Token: 0x04001102 RID: 4354
	[global::Cpp2ILInjected.Token(Token = "0x400159C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ToggleOpen;

	// Token: 0x04001103 RID: 4355
	[global::Cpp2ILInjected.Token(Token = "0x400159D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout NotificationGrid;

	// Token: 0x04001104 RID: 4356
	[global::Cpp2ILInjected.Token(Token = "0x400159E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public DraggableItemGrid_Layout TextGrid;

	// Token: 0x04001105 RID: 4357
	[global::Cpp2ILInjected.Token(Token = "0x400159F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemIcon;

	// Token: 0x04001106 RID: 4358
	[global::Cpp2ILInjected.Token(Token = "0x40015A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ItemWho;

	// Token: 0x04001107 RID: 4359
	[global::Cpp2ILInjected.Token(Token = "0x40015A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout ItemBacking;

	// Token: 0x04001108 RID: 4360
	[global::Cpp2ILInjected.Token(Token = "0x40015A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001109 RID: 4361
	[global::Cpp2ILInjected.Token(Token = "0x40015A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout ItemText;

	// Token: 0x0400110A RID: 4362
	[global::Cpp2ILInjected.Token(Token = "0x40015A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 ItemTextInset;

	// Token: 0x0400110B RID: 4363
	[global::Cpp2ILInjected.Token(Token = "0x40015A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout BeginChatBacking;

	// Token: 0x0400110C RID: 4364
	[global::Cpp2ILInjected.Token(Token = "0x40015A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout BeginChatDivider;

	// Token: 0x0400110D RID: 4365
	[global::Cpp2ILInjected.Token(Token = "0x40015A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout BeginChat;

	// Token: 0x0400110E RID: 4366
	[global::Cpp2ILInjected.Token(Token = "0x40015A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout BeginChatBarsUI;

	// Token: 0x0400110F RID: 4367
	[global::Cpp2ILInjected.Token(Token = "0x40015A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ChatText;

	// Token: 0x04001110 RID: 4368
	[global::Cpp2ILInjected.Token(Token = "0x40015AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color ChattingTextColor;

	// Token: 0x04001111 RID: 4369
	[global::Cpp2ILInjected.Token(Token = "0x40015AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public float TextWrapSize;

	// Token: 0x04001112 RID: 4370
	[global::Cpp2ILInjected.Token(Token = "0x40015AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float TextWrapSizeBarsUI;

	// Token: 0x04001113 RID: 4371
	[global::Cpp2ILInjected.Token(Token = "0x40015AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout PlayerNameText;

	// Token: 0x04001114 RID: 4372
	[global::Cpp2ILInjected.Token(Token = "0x40015AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float PlayerNameMaxLen;

	// Token: 0x04001115 RID: 4373
	[global::Cpp2ILInjected.Token(Token = "0x40015AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout EmotesGridBacking;

	// Token: 0x04001116 RID: 4374
	[global::Cpp2ILInjected.Token(Token = "0x40015B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public StringButton_Layout EmotesTitle;

	// Token: 0x04001117 RID: 4375
	[global::Cpp2ILInjected.Token(Token = "0x40015B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout EmotesMenuDivider;

	// Token: 0x04001118 RID: 4376
	[global::Cpp2ILInjected.Token(Token = "0x40015B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout EmotesMenuDivider2;

	// Token: 0x04001119 RID: 4377
	[global::Cpp2ILInjected.Token(Token = "0x40015B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout EmotesGeneral;

	// Token: 0x0400111A RID: 4378
	[global::Cpp2ILInjected.Token(Token = "0x40015B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout EmotesRPS;

	// Token: 0x0400111B RID: 4379
	[global::Cpp2ILInjected.Token(Token = "0x40015B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout EmotesItems;

	// Token: 0x0400111C RID: 4380
	[global::Cpp2ILInjected.Token(Token = "0x40015B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout EmotesBiomesAndEvents;

	// Token: 0x0400111D RID: 4381
	[global::Cpp2ILInjected.Token(Token = "0x40015B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout EmotesTownNPCs;

	// Token: 0x0400111E RID: 4382
	[global::Cpp2ILInjected.Token(Token = "0x40015B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout EmotesCritters;

	// Token: 0x0400111F RID: 4383
	[global::Cpp2ILInjected.Token(Token = "0x40015B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout EmotesBosses;

	// Token: 0x04001120 RID: 4384
	[global::Cpp2ILInjected.Token(Token = "0x40015BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public DraggableItemGrid_Layout EmotesGrid;

	// Token: 0x04001121 RID: 4385
	[global::Cpp2ILInjected.Token(Token = "0x40015BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public TransactionButton_Layout PrimaryChat;

	// Token: 0x04001122 RID: 4386
	[global::Cpp2ILInjected.Token(Token = "0x40015BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout Emote;

	// Token: 0x04001123 RID: 4387
	[global::Cpp2ILInjected.Token(Token = "0x40015BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout EmotesClose;

	// Token: 0x04001124 RID: 4388
	[global::Cpp2ILInjected.Token(Token = "0x40015BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public float EmoteScale;

	// Token: 0x04001125 RID: 4389
	[global::Cpp2ILInjected.Token(Token = "0x40015BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
	public Vector2 EmoteIconOffset;

	// Token: 0x04001126 RID: 4390
	[global::Cpp2ILInjected.Token(Token = "0x40015C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	public float EmoteIconScale;
}
