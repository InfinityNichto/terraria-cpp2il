using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E5 RID: 1765
	[global::Cpp2ILInjected.Token(Token = "0x2000ACE")]
	public class UIText : UIElement
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x0002E586 File Offset: 0x0002C786
		[global::Cpp2ILInjected.Token(Token = "0x170008CF")]
		public string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x600515C")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFC4", Offset = "0x92EFC4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "TrimDisplayIfOverElementDimensions", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x0002E589 File Offset: 0x0002C789
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x0002E58C File Offset: 0x0002C78C
		[global::Cpp2ILInjected.Token(Token = "0x170008D0")]
		public float TextOriginX
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600515D")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFD4", Offset = "0x92EFD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600515E")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFDC", Offset = "0x92EFDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x0002E58F File Offset: 0x0002C78F
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x0002E592 File Offset: 0x0002C792
		[global::Cpp2ILInjected.Token(Token = "0x170008D1")]
		public float TextOriginY
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600515F")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFE4", Offset = "0x92EFE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005160")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFEC", Offset = "0x92EFEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x0002E595 File Offset: 0x0002C795
		// (set) Token: 0x060044FF RID: 17663 RVA: 0x0002E598 File Offset: 0x0002C798
		[global::Cpp2ILInjected.Token(Token = "0x170008D2")]
		public float WrappedTextBottomPadding
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005161")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFF4", Offset = "0x92EFF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005162")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EFFC", Offset = "0x92EFFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x0002E59B File Offset: 0x0002C79B
		// (set) Token: 0x06004501 RID: 17665 RVA: 0x0002E59E File Offset: 0x0002C79E
		[global::Cpp2ILInjected.Token(Token = "0x170008D3")]
		public bool IsWrapped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005163")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F004", Offset = "0x92F004", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005164")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F00C", Offset = "0x92F00C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlavorTextBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06004502 RID: 17666 RVA: 0x0002E5A1 File Offset: 0x0002C7A1
		// (remove) Token: 0x06004503 RID: 17667 RVA: 0x0002E5A4 File Offset: 0x0002C7A4
		[global::Cpp2ILInjected.Token(Token = "0x14000065")]
		public event Action OnInternalTextChange
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005165")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F208", Offset = "0x92F208", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlavorTextBestiaryInfoElement), Member = "AddDynamicResize", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIText)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "AddDynamicResize", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIText)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005166")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F2A8", Offset = "0x92F2A8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x0002E5A7 File Offset: 0x0002C7A7
		// (set) Token: 0x06004505 RID: 17669 RVA: 0x0002E5AA File Offset: 0x0002C7AA
		[global::Cpp2ILInjected.Token(Token = "0x170008D4")]
		public Color TextColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005167")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F348", Offset = "0x92F348", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005168")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F354", Offset = "0x92F354", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x0002E5AD File Offset: 0x0002C7AD
		// (set) Token: 0x06004507 RID: 17671 RVA: 0x0002E5B0 File Offset: 0x0002C7B0
		[global::Cpp2ILInjected.Token(Token = "0x170008D5")]
		public Color ShadowColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005169")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F360", Offset = "0x92F360", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600516A")]
			[global::Cpp2ILInjected.Address(RVA = "0x92F36C", Offset = "0x92F36C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x0002E5B3 File Offset: 0x0002C7B3
		[global::Cpp2ILInjected.Token(Token = "0x600516B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F378", Offset = "0x92F378", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamePlateInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillCounterInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "FillProgressBottomBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddBackAndForwardButtons", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSortAndFilterButtons", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public UIText(string text, float textScale = 1f, bool large = false)
		{
			throw null;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x0002E5B6 File Offset: 0x0002C7B6
		[global::Cpp2ILInjected.Token(Token = "0x600516C")]
		[global::Cpp2ILInjected.Address(RVA = "0x926ADC", Offset = "0x926ADC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterProviderInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlavorTextBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamePlateInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(LocalizedText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(byte),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public UIText(LocalizedText text, float textScale = 1f, bool large = false)
		{
			throw null;
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x0002E5B9 File Offset: 0x0002C7B9
		[global::Cpp2ILInjected.Token(Token = "0x600516D")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F500", Offset = "0x92F500", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		[global::Cpp2ILInjected.Token(Token = "0x600516E")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F528", Offset = "0x92F528", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryGridRange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "SetContents", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "TrimDisplayIfOverElementDimensions", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "descriptionText_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetText(string text)
		{
			throw null;
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x0002E5BF File Offset: 0x0002C7BF
		[global::Cpp2ILInjected.Token(Token = "0x600516F")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F534", Offset = "0x92F534", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "SetContents", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetText(LocalizedText text)
		{
			throw null;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x0002E5C2 File Offset: 0x0002C7C2
		[global::Cpp2ILInjected.Token(Token = "0x6005170")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F540", Offset = "0x92F540", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetText(string text, float textScale, bool large)
		{
			throw null;
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x0002E5C5 File Offset: 0x0002C7C5
		[global::Cpp2ILInjected.Token(Token = "0x6005171")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F548", Offset = "0x92F548", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetText(LocalizedText text, float textScale, bool large)
		{
			throw null;
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x0002E5C8 File Offset: 0x0002C7C8
		[global::Cpp2ILInjected.Token(Token = "0x6005172")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F550", Offset = "0x92F550", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "VerifyTextState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ConvertNormalSnippets", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x0002E5CB File Offset: 0x0002C7CB
		[global::Cpp2ILInjected.Token(Token = "0x6005173")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F874", Offset = "0x92F874", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void VerifyTextState()
		{
			throw null;
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x0002E5CE File Offset: 0x0002C7CE
		[global::Cpp2ILInjected.Token(Token = "0x6005174")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F028", Offset = "0x92F028", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(LocalizedText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "VerifyTextState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "CreateWrappedText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void InternalSetText(object text, float textScale, bool large)
		{
			throw null;
		}

		// Token: 0x040070A1 RID: 28833
		[global::Cpp2ILInjected.Token(Token = "0x40089ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private object _text;

		// Token: 0x040070A2 RID: 28834
		[global::Cpp2ILInjected.Token(Token = "0x40089EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private float _textScale;

		// Token: 0x040070A3 RID: 28835
		[global::Cpp2ILInjected.Token(Token = "0x40089EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private Vector2 _textSize;

		// Token: 0x040070A4 RID: 28836
		[global::Cpp2ILInjected.Token(Token = "0x40089F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		private bool _isLarge;

		// Token: 0x040070A5 RID: 28837
		[global::Cpp2ILInjected.Token(Token = "0x40089F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15D")]
		private Color _color;

		// Token: 0x040070A6 RID: 28838
		[global::Cpp2ILInjected.Token(Token = "0x40089F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x161")]
		private Color _shadowColor;

		// Token: 0x040070A7 RID: 28839
		[global::Cpp2ILInjected.Token(Token = "0x40089F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x165")]
		private bool _isWrapped;

		// Token: 0x040070A8 RID: 28840
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private float <TextOriginX>k__BackingField;

		// Token: 0x040070A9 RID: 28841
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
		private float <TextOriginY>k__BackingField;

		// Token: 0x040070AA RID: 28842
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private float <WrappedTextBottomPadding>k__BackingField;

		// Token: 0x040070AB RID: 28843
		[global::Cpp2ILInjected.Token(Token = "0x40089F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
		public bool DynamicallyScaleDownToWidth;

		// Token: 0x040070AC RID: 28844
		[global::Cpp2ILInjected.Token(Token = "0x40089F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private string _visibleText;

		// Token: 0x040070AD RID: 28845
		[global::Cpp2ILInjected.Token(Token = "0x40089F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private string _lastTextReference;

		// Token: 0x040070AE RID: 28846
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private Action OnInternalTextChange;
	}
}
