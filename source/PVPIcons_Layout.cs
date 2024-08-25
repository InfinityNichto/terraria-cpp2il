using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000232")]
public class PVPIcons_Layout : PageControllerLayoutDefinition<PVPIcons_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x17000166")]
	public ItemGrid_Layout TeamGridLayout
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D165C", Offset = "0x9D165C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetTeamGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawTeamGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "IsOver", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000167")]
	public DraggableItemGrid_Layout Grid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D16C8", Offset = "0x9D16C8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPVPIcons), Member = "get_Collapsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageIconsExtended_Layout), Member = "GetDisplayGrid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000168")]
	public TransactionButton_Layout PVPIcon
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1764", Offset = "0x9D1764", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000169")]
	public TransactionButton_Layout PlayerTeamIcon
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D17D0", Offset = "0x9D17D0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawTeamGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D00")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D183C", Offset = "0x9D183C", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public PVPIcons_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400169C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400169D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout PlatformInvite;

	[global::Cpp2ILInjected.Token(Token = "0x400169E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout PVP;

	[global::Cpp2ILInjected.Token(Token = "0x400169F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout PVP_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x40016A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout TeamGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40016A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout TeamGrid_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x40016A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 TeamGridLocationTouch;

	[global::Cpp2ILInjected.Token(Token = "0x40016A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 TeamGridOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 TeamGridControllerOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout TeamGridBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Vector2 TeamBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Vector2 TeamBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 CharacterDrawOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public DraggableItemGrid_Layout PlayerGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40016AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public DraggableItemGrid_Layout PlayerGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x40016AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout PlayerTeam;

	[global::Cpp2ILInjected.Token(Token = "0x40016AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout PlayerTeam_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x40016AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout SelectedPlayerName;

	[global::Cpp2ILInjected.Token(Token = "0x40016AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout SelectedPlayerNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40016AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout SelectedPlayerTeam;

	[global::Cpp2ILInjected.Token(Token = "0x40016B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout SelectedPlayerTeamName;

	[global::Cpp2ILInjected.Token(Token = "0x40016B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout SelectedPlayerTeleport;

	[global::Cpp2ILInjected.Token(Token = "0x40016B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout SelectedPlayerVoiceMute;

	[global::Cpp2ILInjected.Token(Token = "0x40016B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout SelectedPlayerVoiceUnMute;

	[global::Cpp2ILInjected.Token(Token = "0x40016B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout SelectedPlayerMap;

	[global::Cpp2ILInjected.Token(Token = "0x40016B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout SelectedPlayerViewPlatformProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40016B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout SelectedPlayerClose;

	[global::Cpp2ILInjected.Token(Token = "0x40016B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout SelectedPlayerDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40016B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Panel_Layout SelectedPlayerDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x40016B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout SelectedPlayerHealthBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Button_Layout SelectedPlayerHealthIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40016BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public String_Layout SelectedPlayerHealth;

	[global::Cpp2ILInjected.Token(Token = "0x40016BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout SelectedPlayerManaBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Button_Layout SelectedPlayerManaIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40016BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public String_Layout SelectedPlayerMana;

	[global::Cpp2ILInjected.Token(Token = "0x40016BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Panel_Layout SelectedPlayerBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public String_Layout SelectedPlayerPlatformProfileName;

	[global::Cpp2ILInjected.Token(Token = "0x40016C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout SelectedPlayerPlatformProfileBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout SelectedPlayerImagePosition;

	[global::Cpp2ILInjected.Token(Token = "0x40016C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Panel_Layout SelectedPlayerImageClipRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40016C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public Vector2 SelectedPlayerImageDrawOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout PlayerClipRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40016C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public float TeamScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
	public float TeamIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Vector2 TeamIconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public float PlayerScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x184")]
	public float PlayerIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Vector2 PlayerIconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public Vector2 PlayerHeadOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public float PlayerHeadScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
	public float TalkingIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Vector2 TalkIconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Texture_Layout TalkingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40016D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public float MutedIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	public Vector2 MutedIconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Texture_Layout MutedIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40016D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public Color Team1BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
	public Color Team2BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public Color Team3BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
	public Color Team4BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public Color Team5BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1DC")]
	public Color Team6BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public Color TeamBackingColourDisabled;

	[global::Cpp2ILInjected.Token(Token = "0x40016DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E4")]
	public Color TeamIconColourDisabled;

	[global::Cpp2ILInjected.Token(Token = "0x40016DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Color Team1PlayerBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
	public Color Team2PlayerBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public Color Team3PlayerBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F4")]
	public Color Team4PlayerBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Color Team5PlayerBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1FC")]
	public Color Team6PlayerBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public Color EmptySlotColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
	public Color EmptySlotIconColour;

	[global::Cpp2ILInjected.Token(Token = "0x40016E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public float EmptySlotIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public Texture_Layout EmptySlotIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40016E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public float CharacterScale;

	[global::Cpp2ILInjected.Token(Token = "0x40016E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public String_Layout TeamCooldownCounter;
}
