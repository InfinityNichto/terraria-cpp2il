using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A3 RID: 419
[global::Cpp2ILInjected.Token(Token = "0x2000232")]
public class PVPIcons_Layout : PageControllerLayoutDefinition<PVPIcons_Layout>
{
	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00023EEB File Offset: 0x000220EB
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

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00023EEE File Offset: 0x000220EE
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

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00023EF1 File Offset: 0x000220F1
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

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00023EF4 File Offset: 0x000220F4
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

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00023EF7 File Offset: 0x000220F7
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

	// Token: 0x040011E7 RID: 4583
	[global::Cpp2ILInjected.Token(Token = "0x400169C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x040011E8 RID: 4584
	[global::Cpp2ILInjected.Token(Token = "0x400169D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout PlatformInvite;

	// Token: 0x040011E9 RID: 4585
	[global::Cpp2ILInjected.Token(Token = "0x400169E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout PVP;

	// Token: 0x040011EA RID: 4586
	[global::Cpp2ILInjected.Token(Token = "0x400169F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout PVP_Horizontal;

	// Token: 0x040011EB RID: 4587
	[global::Cpp2ILInjected.Token(Token = "0x40016A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout TeamGrid;

	// Token: 0x040011EC RID: 4588
	[global::Cpp2ILInjected.Token(Token = "0x40016A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout TeamGrid_Horizontal;

	// Token: 0x040011ED RID: 4589
	[global::Cpp2ILInjected.Token(Token = "0x40016A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 TeamGridLocationTouch;

	// Token: 0x040011EE RID: 4590
	[global::Cpp2ILInjected.Token(Token = "0x40016A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 TeamGridOffset;

	// Token: 0x040011EF RID: 4591
	[global::Cpp2ILInjected.Token(Token = "0x40016A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 TeamGridControllerOffset;

	// Token: 0x040011F0 RID: 4592
	[global::Cpp2ILInjected.Token(Token = "0x40016A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout TeamGridBacking;

	// Token: 0x040011F1 RID: 4593
	[global::Cpp2ILInjected.Token(Token = "0x40016A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Vector2 TeamBackingTLOffset;

	// Token: 0x040011F2 RID: 4594
	[global::Cpp2ILInjected.Token(Token = "0x40016A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Vector2 TeamBackingBROffset;

	// Token: 0x040011F3 RID: 4595
	[global::Cpp2ILInjected.Token(Token = "0x40016A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 CharacterDrawOffset;

	// Token: 0x040011F4 RID: 4596
	[global::Cpp2ILInjected.Token(Token = "0x40016A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x040011F5 RID: 4597
	[global::Cpp2ILInjected.Token(Token = "0x40016AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public DraggableItemGrid_Layout PlayerGridCollapsed;

	// Token: 0x040011F6 RID: 4598
	[global::Cpp2ILInjected.Token(Token = "0x40016AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout PlayerTeam;

	// Token: 0x040011F7 RID: 4599
	[global::Cpp2ILInjected.Token(Token = "0x40016AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout PlayerTeam_Horizontal;

	// Token: 0x040011F8 RID: 4600
	[global::Cpp2ILInjected.Token(Token = "0x40016AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout SelectedPlayerName;

	// Token: 0x040011F9 RID: 4601
	[global::Cpp2ILInjected.Token(Token = "0x40016AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout SelectedPlayerNameDivider;

	// Token: 0x040011FA RID: 4602
	[global::Cpp2ILInjected.Token(Token = "0x40016AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout SelectedPlayerTeam;

	// Token: 0x040011FB RID: 4603
	[global::Cpp2ILInjected.Token(Token = "0x40016B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout SelectedPlayerTeamName;

	// Token: 0x040011FC RID: 4604
	[global::Cpp2ILInjected.Token(Token = "0x40016B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout SelectedPlayerTeleport;

	// Token: 0x040011FD RID: 4605
	[global::Cpp2ILInjected.Token(Token = "0x40016B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout SelectedPlayerVoiceMute;

	// Token: 0x040011FE RID: 4606
	[global::Cpp2ILInjected.Token(Token = "0x40016B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout SelectedPlayerVoiceUnMute;

	// Token: 0x040011FF RID: 4607
	[global::Cpp2ILInjected.Token(Token = "0x40016B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout SelectedPlayerMap;

	// Token: 0x04001200 RID: 4608
	[global::Cpp2ILInjected.Token(Token = "0x40016B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout SelectedPlayerViewPlatformProfile;

	// Token: 0x04001201 RID: 4609
	[global::Cpp2ILInjected.Token(Token = "0x40016B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout SelectedPlayerClose;

	// Token: 0x04001202 RID: 4610
	[global::Cpp2ILInjected.Token(Token = "0x40016B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout SelectedPlayerDivider;

	// Token: 0x04001203 RID: 4611
	[global::Cpp2ILInjected.Token(Token = "0x40016B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Panel_Layout SelectedPlayerDivider2;

	// Token: 0x04001204 RID: 4612
	[global::Cpp2ILInjected.Token(Token = "0x40016B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout SelectedPlayerHealthBacking;

	// Token: 0x04001205 RID: 4613
	[global::Cpp2ILInjected.Token(Token = "0x40016BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Button_Layout SelectedPlayerHealthIcon;

	// Token: 0x04001206 RID: 4614
	[global::Cpp2ILInjected.Token(Token = "0x40016BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public String_Layout SelectedPlayerHealth;

	// Token: 0x04001207 RID: 4615
	[global::Cpp2ILInjected.Token(Token = "0x40016BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout SelectedPlayerManaBacking;

	// Token: 0x04001208 RID: 4616
	[global::Cpp2ILInjected.Token(Token = "0x40016BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Button_Layout SelectedPlayerManaIcon;

	// Token: 0x04001209 RID: 4617
	[global::Cpp2ILInjected.Token(Token = "0x40016BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public String_Layout SelectedPlayerMana;

	// Token: 0x0400120A RID: 4618
	[global::Cpp2ILInjected.Token(Token = "0x40016BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Panel_Layout SelectedPlayerBacking;

	// Token: 0x0400120B RID: 4619
	[global::Cpp2ILInjected.Token(Token = "0x40016C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public String_Layout SelectedPlayerPlatformProfileName;

	// Token: 0x0400120C RID: 4620
	[global::Cpp2ILInjected.Token(Token = "0x40016C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout SelectedPlayerPlatformProfileBacking;

	// Token: 0x0400120D RID: 4621
	[global::Cpp2ILInjected.Token(Token = "0x40016C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout SelectedPlayerImagePosition;

	// Token: 0x0400120E RID: 4622
	[global::Cpp2ILInjected.Token(Token = "0x40016C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Panel_Layout SelectedPlayerImageClipRegion;

	// Token: 0x0400120F RID: 4623
	[global::Cpp2ILInjected.Token(Token = "0x40016C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public Vector2 SelectedPlayerImageDrawOffset;

	// Token: 0x04001210 RID: 4624
	[global::Cpp2ILInjected.Token(Token = "0x40016C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout PlayerClipRegion;

	// Token: 0x04001211 RID: 4625
	[global::Cpp2ILInjected.Token(Token = "0x40016C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public float TeamScale;

	// Token: 0x04001212 RID: 4626
	[global::Cpp2ILInjected.Token(Token = "0x40016C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
	public float TeamIconScale;

	// Token: 0x04001213 RID: 4627
	[global::Cpp2ILInjected.Token(Token = "0x40016C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Vector2 TeamIconOffset;

	// Token: 0x04001214 RID: 4628
	[global::Cpp2ILInjected.Token(Token = "0x40016C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public float PlayerScale;

	// Token: 0x04001215 RID: 4629
	[global::Cpp2ILInjected.Token(Token = "0x40016CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x184")]
	public float PlayerIconScale;

	// Token: 0x04001216 RID: 4630
	[global::Cpp2ILInjected.Token(Token = "0x40016CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Vector2 PlayerIconOffset;

	// Token: 0x04001217 RID: 4631
	[global::Cpp2ILInjected.Token(Token = "0x40016CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public Vector2 PlayerHeadOffset;

	// Token: 0x04001218 RID: 4632
	[global::Cpp2ILInjected.Token(Token = "0x40016CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public float PlayerHeadScale;

	// Token: 0x04001219 RID: 4633
	[global::Cpp2ILInjected.Token(Token = "0x40016CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
	public float TalkingIconScale;

	// Token: 0x0400121A RID: 4634
	[global::Cpp2ILInjected.Token(Token = "0x40016CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Vector2 TalkIconOffset;

	// Token: 0x0400121B RID: 4635
	[global::Cpp2ILInjected.Token(Token = "0x40016D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Texture_Layout TalkingIcon;

	// Token: 0x0400121C RID: 4636
	[global::Cpp2ILInjected.Token(Token = "0x40016D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public float MutedIconScale;

	// Token: 0x0400121D RID: 4637
	[global::Cpp2ILInjected.Token(Token = "0x40016D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	public Vector2 MutedIconOffset;

	// Token: 0x0400121E RID: 4638
	[global::Cpp2ILInjected.Token(Token = "0x40016D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Texture_Layout MutedIcon;

	// Token: 0x0400121F RID: 4639
	[global::Cpp2ILInjected.Token(Token = "0x40016D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public Color Team1BackingColour;

	// Token: 0x04001220 RID: 4640
	[global::Cpp2ILInjected.Token(Token = "0x40016D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
	public Color Team2BackingColour;

	// Token: 0x04001221 RID: 4641
	[global::Cpp2ILInjected.Token(Token = "0x40016D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public Color Team3BackingColour;

	// Token: 0x04001222 RID: 4642
	[global::Cpp2ILInjected.Token(Token = "0x40016D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
	public Color Team4BackingColour;

	// Token: 0x04001223 RID: 4643
	[global::Cpp2ILInjected.Token(Token = "0x40016D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public Color Team5BackingColour;

	// Token: 0x04001224 RID: 4644
	[global::Cpp2ILInjected.Token(Token = "0x40016D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1DC")]
	public Color Team6BackingColour;

	// Token: 0x04001225 RID: 4645
	[global::Cpp2ILInjected.Token(Token = "0x40016DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public Color TeamBackingColourDisabled;

	// Token: 0x04001226 RID: 4646
	[global::Cpp2ILInjected.Token(Token = "0x40016DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E4")]
	public Color TeamIconColourDisabled;

	// Token: 0x04001227 RID: 4647
	[global::Cpp2ILInjected.Token(Token = "0x40016DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Color Team1PlayerBackingColour;

	// Token: 0x04001228 RID: 4648
	[global::Cpp2ILInjected.Token(Token = "0x40016DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
	public Color Team2PlayerBackingColour;

	// Token: 0x04001229 RID: 4649
	[global::Cpp2ILInjected.Token(Token = "0x40016DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public Color Team3PlayerBackingColour;

	// Token: 0x0400122A RID: 4650
	[global::Cpp2ILInjected.Token(Token = "0x40016DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F4")]
	public Color Team4PlayerBackingColour;

	// Token: 0x0400122B RID: 4651
	[global::Cpp2ILInjected.Token(Token = "0x40016E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Color Team5PlayerBackingColour;

	// Token: 0x0400122C RID: 4652
	[global::Cpp2ILInjected.Token(Token = "0x40016E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1FC")]
	public Color Team6PlayerBackingColour;

	// Token: 0x0400122D RID: 4653
	[global::Cpp2ILInjected.Token(Token = "0x40016E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public Color EmptySlotColour;

	// Token: 0x0400122E RID: 4654
	[global::Cpp2ILInjected.Token(Token = "0x40016E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
	public Color EmptySlotIconColour;

	// Token: 0x0400122F RID: 4655
	[global::Cpp2ILInjected.Token(Token = "0x40016E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public float EmptySlotIconScale;

	// Token: 0x04001230 RID: 4656
	[global::Cpp2ILInjected.Token(Token = "0x40016E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public Texture_Layout EmptySlotIcon;

	// Token: 0x04001231 RID: 4657
	[global::Cpp2ILInjected.Token(Token = "0x40016E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public float CharacterScale;

	// Token: 0x04001232 RID: 4658
	[global::Cpp2ILInjected.Token(Token = "0x40016E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public String_Layout TeamCooldownCounter;
}
