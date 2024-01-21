using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200019D")]
public class PVPIcons_Layout : PageControllerLayoutDefinition<PVPIcons_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400114C")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400114D")]
	public TransactionButton_Layout PlatformInvite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400114E")]
	public TransactionButton_Layout PVP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400114F")]
	public TransactionButton_Layout PVP_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001150")]
	public ItemGrid_Layout TeamGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001151")]
	public ItemGrid_Layout TeamGrid_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001152")]
	public Vector2 TeamGridLocationTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001153")]
	public Vector2 TeamGridOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001154")]
	public Vector2 TeamGridControllerOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001155")]
	public Panel_Layout TeamGridBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001156")]
	public Vector2 TeamBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001157")]
	public Vector2 TeamBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001158")]
	public Vector2 CharacterDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001159")]
	public DraggableItemGrid_Layout PlayerGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400115A")]
	public DraggableItemGrid_Layout PlayerGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400115B")]
	public TransactionButton_Layout PlayerTeam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400115C")]
	public TransactionButton_Layout PlayerTeam_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400115D")]
	public String_Layout SelectedPlayerName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400115E")]
	public Panel_Layout SelectedPlayerNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400115F")]
	public TransactionButton_Layout SelectedPlayerTeam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001160")]
	public String_Layout SelectedPlayerTeamName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4001161")]
	public TransactionButton_Layout SelectedPlayerTeleport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4001162")]
	public TransactionButton_Layout SelectedPlayerVoiceMute;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001163")]
	public TransactionButton_Layout SelectedPlayerVoiceUnMute;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001164")]
	public TransactionButton_Layout SelectedPlayerMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001165")]
	public TransactionButton_Layout SelectedPlayerViewPlatformProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001166")]
	public TransactionButton_Layout SelectedPlayerClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001167")]
	public Panel_Layout SelectedPlayerDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001168")]
	public Panel_Layout SelectedPlayerDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4001169")]
	public Panel_Layout SelectedPlayerHealthBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400116A")]
	public Button_Layout SelectedPlayerHealthIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400116B")]
	public String_Layout SelectedPlayerHealth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400116C")]
	public Panel_Layout SelectedPlayerManaBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400116D")]
	public Button_Layout SelectedPlayerManaIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400116E")]
	public String_Layout SelectedPlayerMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400116F")]
	public Panel_Layout SelectedPlayerBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4001170")]
	public String_Layout SelectedPlayerPlatformProfileName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4001171")]
	public Panel_Layout SelectedPlayerPlatformProfileBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4001172")]
	public Panel_Layout SelectedPlayerImagePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4001173")]
	public Panel_Layout SelectedPlayerImageClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4001174")]
	public Vector2 SelectedPlayerImageDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4001175")]
	public Panel_Layout PlayerClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4001176")]
	public float TeamScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4001177")]
	public float TeamIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4001178")]
	public Vector2 TeamIconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4001179")]
	public float PlayerScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400117A")]
	public float PlayerIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400117B")]
	public Vector2 PlayerIconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400117C")]
	public Vector2 PlayerHeadOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400117D")]
	public float PlayerHeadScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400117E")]
	public float TalkingIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400117F")]
	public Vector2 TalkIconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4001180")]
	public Texture_Layout TalkingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4001181")]
	public float MutedIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4001182")]
	public Vector2 MutedIconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4001183")]
	public Texture_Layout MutedIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4001184")]
	public Color Team1BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4001185")]
	public Color Team2BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4001186")]
	public Color Team3BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4001187")]
	public Color Team4BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4001188")]
	public Color Team5BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4001189")]
	public Color Team6BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400118A")]
	public Color TeamBackingColourDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x400118B")]
	public Color TeamIconColourDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400118C")]
	public Color Team1PlayerBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400118D")]
	public Color Team2PlayerBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400118E")]
	public Color Team3PlayerBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x400118F")]
	public Color Team4PlayerBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4001190")]
	public Color Team5PlayerBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4001191")]
	public Color Team6PlayerBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4001192")]
	public Color EmptySlotColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x4001193")]
	public Color EmptySlotIconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4001194")]
	public float EmptySlotIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4001195")]
	public Texture_Layout EmptySlotIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4001196")]
	public float CharacterScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4001197")]
	public String_Layout TeamCooldownCounter;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public ItemGrid_Layout TeamGridLayout
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x10B2E54", Offset = "0x10B2E54", VA = "0x10B2E54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public DraggableItemGrid_Layout Grid
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x10B2ECC", Offset = "0x10B2ECC", VA = "0x10B2ECC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public TransactionButton_Layout PVPIcon
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x10B3028", Offset = "0x10B3028", VA = "0x10B3028")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public TransactionButton_Layout PlayerTeamIcon
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x10B30A0", Offset = "0x10B30A0", VA = "0x10B30A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x10B3118", Offset = "0x10B3118", VA = "0x10B3118")]
	public PVPIcons_Layout()
	{
	}
}
