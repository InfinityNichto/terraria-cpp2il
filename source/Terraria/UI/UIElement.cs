using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;

namespace Terraria.UI
{
	// Token: 0x020004D0 RID: 1232
	[global::Cpp2ILInjected.Token(Token = "0x200071D")]
	public class UIElement : IComparable
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x0002BA27 File Offset: 0x00029C27
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x0002BA2A File Offset: 0x00029C2A
		[global::Cpp2ILInjected.Token(Token = "0x17000764")]
		public UIElement Parent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C34")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E214", Offset = "0x148E214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C35")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E21C", Offset = "0x148E21C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x0002BA2D File Offset: 0x00029C2D
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x0002BA30 File Offset: 0x00029C30
		[global::Cpp2ILInjected.Token(Token = "0x17000765")]
		public int UniqueId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C36")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E224", Offset = "0x148E224", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C37")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E22C", Offset = "0x148E22C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x0002BA33 File Offset: 0x00029C33
		[global::Cpp2ILInjected.Token(Token = "0x17000766")]
		public IEnumerable<UIElement> Children
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003C38")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E234", Offset = "0x148E234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060035F9 RID: 13817 RVA: 0x0002BA36 File Offset: 0x00029C36
		// (remove) Token: 0x060035FA RID: 13818 RVA: 0x0002BA39 File Offset: 0x00029C39
		[global::Cpp2ILInjected.Token(Token = "0x14000047")]
		public event UIElement.MouseEvent OnLeftMouseDown
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C39")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E23C", Offset = "0x148E23C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E2D8", Offset = "0x148E2D8", Length = "0x9C")]
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

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060035FB RID: 13819 RVA: 0x0002BA3C File Offset: 0x00029C3C
		// (remove) Token: 0x060035FC RID: 13820 RVA: 0x0002BA3F File Offset: 0x00029C3F
		[global::Cpp2ILInjected.Token(Token = "0x14000048")]
		public event UIElement.MouseEvent OnLeftMouseUp
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E374", Offset = "0x148E374", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E410", Offset = "0x148E410", Length = "0x9C")]
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

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060035FD RID: 13821 RVA: 0x0002BA42 File Offset: 0x00029C42
		// (remove) Token: 0x060035FE RID: 13822 RVA: 0x0002BA45 File Offset: 0x00029C45
		[global::Cpp2ILInjected.Token(Token = "0x14000049")]
		public event UIElement.MouseEvent OnLeftClick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E4AC", Offset = "0x148E4AC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E548", Offset = "0x148E548", Length = "0x9C")]
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

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060035FF RID: 13823 RVA: 0x0002BA48 File Offset: 0x00029C48
		// (remove) Token: 0x06003600 RID: 13824 RVA: 0x0002BA4B File Offset: 0x00029C4B
		[global::Cpp2ILInjected.Token(Token = "0x1400004A")]
		public event UIElement.MouseEvent OnLeftDoubleClick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E5E4", Offset = "0x148E5E4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C40")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E680", Offset = "0x148E680", Length = "0x9C")]
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

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06003601 RID: 13825 RVA: 0x0002BA4E File Offset: 0x00029C4E
		// (remove) Token: 0x06003602 RID: 13826 RVA: 0x0002BA51 File Offset: 0x00029C51
		[global::Cpp2ILInjected.Token(Token = "0x1400004B")]
		public event UIElement.MouseEvent OnRightMouseDown
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C41")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E71C", Offset = "0x148E71C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C42")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E7B8", Offset = "0x148E7B8", Length = "0x9C")]
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

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06003603 RID: 13827 RVA: 0x0002BA54 File Offset: 0x00029C54
		// (remove) Token: 0x06003604 RID: 13828 RVA: 0x0002BA57 File Offset: 0x00029C57
		[global::Cpp2ILInjected.Token(Token = "0x1400004C")]
		public event UIElement.MouseEvent OnRightMouseUp
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C43")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E854", Offset = "0x148E854", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C44")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E8F0", Offset = "0x148E8F0", Length = "0x9C")]
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

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06003605 RID: 13829 RVA: 0x0002BA5A File Offset: 0x00029C5A
		// (remove) Token: 0x06003606 RID: 13830 RVA: 0x0002BA5D File Offset: 0x00029C5D
		[global::Cpp2ILInjected.Token(Token = "0x1400004D")]
		public event UIElement.MouseEvent OnRightClick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C45")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E98C", Offset = "0x148E98C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C46")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EA28", Offset = "0x148EA28", Length = "0x9C")]
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

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06003607 RID: 13831 RVA: 0x0002BA60 File Offset: 0x00029C60
		// (remove) Token: 0x06003608 RID: 13832 RVA: 0x0002BA63 File Offset: 0x00029C63
		[global::Cpp2ILInjected.Token(Token = "0x1400004E")]
		public event UIElement.MouseEvent OnRightDoubleClick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C47")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EAC4", Offset = "0x148EAC4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C48")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EB60", Offset = "0x148EB60", Length = "0x9C")]
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

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06003609 RID: 13833 RVA: 0x0002BA66 File Offset: 0x00029C66
		// (remove) Token: 0x0600360A RID: 13834 RVA: 0x0002BA69 File Offset: 0x00029C69
		[global::Cpp2ILInjected.Token(Token = "0x1400004F")]
		public event UIElement.MouseEvent OnMouseOver
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C49")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EBFC", Offset = "0x148EBFC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "AddIndication", MemberParameters = new object[]
			{
				typeof(UIPanel),
				typeof(float),
				typeof(string),
				typeof(string),
				typeof(UIElement.ElementEvent),
				typeof(UIElement.MouseEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(UIBestiaryEntryInfoPage)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
				typeof(Action),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "StyleKey", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"Terraria.GameContent.UI.Elements.UITextPanel`1<T>",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BestiaryEntry),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(EntryFilterer<Item, IItemEntryFilter>),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(DropRateInfo),
				typeof(BestiaryUICollectionInfo),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EC98", Offset = "0x148EC98", Length = "0x9C")]
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

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x0600360B RID: 13835 RVA: 0x0002BA6C File Offset: 0x00029C6C
		// (remove) Token: 0x0600360C RID: 13836 RVA: 0x0002BA6F File Offset: 0x00029C6F
		[global::Cpp2ILInjected.Token(Token = "0x14000050")]
		public event UIElement.MouseEvent OnMouseOut
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x148ED34", Offset = "0x148ED34", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "AddIndication", MemberParameters = new object[]
			{
				typeof(UIPanel),
				typeof(float),
				typeof(string),
				typeof(string),
				typeof(UIElement.ElementEvent),
				typeof(UIElement.MouseEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
				typeof(Action),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "StyleKey", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"Terraria.GameContent.UI.Elements.UITextPanel`1<T>",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BestiaryEntry),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(DropRateInfo),
				typeof(BestiaryUICollectionInfo),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EDD0", Offset = "0x148EDD0", Length = "0x9C")]
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

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x0600360D RID: 13837 RVA: 0x0002BA72 File Offset: 0x00029C72
		// (remove) Token: 0x0600360E RID: 13838 RVA: 0x0002BA75 File Offset: 0x00029C75
		[global::Cpp2ILInjected.Token(Token = "0x14000051")]
		public event UIElement.ScrollWheelEvent OnScrollWheel
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EE6C", Offset = "0x148EE6C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EF08", Offset = "0x148EF08", Length = "0x9C")]
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

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x0600360F RID: 13839 RVA: 0x0002BA78 File Offset: 0x00029C78
		// (remove) Token: 0x06003610 RID: 13840 RVA: 0x0002BA7B File Offset: 0x00029C7B
		[global::Cpp2ILInjected.Token(Token = "0x14000052")]
		public event UIElement.ElementEvent OnUpdate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x148EFA4", Offset = "0x148EFA4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003C50")]
			[global::Cpp2ILInjected.Address(RVA = "0x148F040", Offset = "0x148F040", Length = "0x9C")]
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

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x0002BA7E File Offset: 0x00029C7E
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x0002BA81 File Offset: 0x00029C81
		[global::Cpp2ILInjected.Token(Token = "0x17000767")]
		public bool IsMouseHovering
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C51")]
			[global::Cpp2ILInjected.Address(RVA = "0x148F0DC", Offset = "0x148F0DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C52")]
			[global::Cpp2ILInjected.Address(RVA = "0x148F0E4", Offset = "0x148F0E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0002BA84 File Offset: 0x00029C84
		[global::Cpp2ILInjected.Token(Token = "0x6003C53")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F0F0", Offset = "0x148F0F0", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 69)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UIElement()
		{
			throw null;
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0002BA87 File Offset: 0x00029C87
		[global::Cpp2ILInjected.Token(Token = "0x6003C54")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F204", Offset = "0x148F204", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddBackAndForwardButtons", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSortAndFilterButtons", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateSubcategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(ref CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Dictionary<int, GroupOptionButton<int>>),
			typeof(Dictionary<int, UIElement>)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PowerStripUIElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiarySortingOptionsGrid), Member = "BuildGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EntryFilterer<Item, IItemEntryFilter>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void SetSnapPoint(string name, int id, Vector2? anchor = null, Vector2? offset = null)
		{
			throw null;
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0002BA8A File Offset: 0x00029C8A
		[global::Cpp2ILInjected.Token(Token = "0x6003C55")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F3BC", Offset = "0x148F3BC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SnapPoint), Member = "Calculate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		public bool GetSnapPoint(out SnapPoint point)
		{
			throw null;
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x0002BA8D File Offset: 0x00029C8D
		[global::Cpp2ILInjected.Token(Token = "0x6003C56")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F3F0", Offset = "0x148F3F0", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual void ExecuteRecursively(UIElement.UIElementAction action)
		{
			throw null;
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0002BA90 File Offset: 0x00029C90
		[global::Cpp2ILInjected.Token(Token = "0x6003C57")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F540", Offset = "0x148F540", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingSimpleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingToggleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		protected virtual void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0002BA93 File Offset: 0x00029C93
		[global::Cpp2ILInjected.Token(Token = "0x6003C58")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F544", Offset = "0x148F544", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected virtual void DrawChildren(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x0002BA96 File Offset: 0x00029C96
		[global::Cpp2ILInjected.Token(Token = "0x6003C59")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F680", Offset = "0x148F680", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 198)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Append(UIElement element)
		{
			throw null;
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0002BA99 File Offset: 0x00029C99
		[global::Cpp2ILInjected.Token(Token = "0x6003C5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F738", Offset = "0x148F738", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.States.UIVirtualKeyboard.<>c__DisplayClass52_1", Member = "<BuildSpaceBarArea>b__3", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public void Remove()
		{
			throw null;
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0002BA9C File Offset: 0x00029C9C
		[global::Cpp2ILInjected.Token(Token = "0x6003C5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F74C", Offset = "0x148F74C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OpenOrCloseSortingOptions", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OpenOrCloseFilteringGrid", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Click_CloseFilteringGrid", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "CloseFilteringGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Click_CloseSortingGrid", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "CloseSortingGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = "MouseOver", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = "MouseOut", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "Remove", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveChild(UIElement child)
		{
			throw null;
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0002BA9F File Offset: 0x00029C9F
		[global::Cpp2ILInjected.Token(Token = "0x6003C5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F7AC", Offset = "0x148F7AC", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UICreativeInfiniteItemsDisplay_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void RemoveAllChildren()
		{
			throw null;
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0002BAA2 File Offset: 0x00029CA2
		[global::Cpp2ILInjected.Token(Token = "0x6003C5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x148F910", Offset = "0x148F910", Length = "0x698")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "GetClippingRectangle", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_ScissorRectangle", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_RasterizerState", MemberParameters = new object[] { typeof(RasterizerState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public virtual void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0002BAA5 File Offset: 0x00029CA5
		[global::Cpp2ILInjected.Token(Token = "0x6003C5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490430", Offset = "0x1490430", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryIcon), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0002BAA8 File Offset: 0x00029CA8
		[global::Cpp2ILInjected.Token(Token = "0x6003C5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x148FFA8", Offset = "0x148FFA8", Length = "0x488")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public Rectangle GetClippingRectangle(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0002BAAB File Offset: 0x00029CAB
		[global::Cpp2ILInjected.Token(Token = "0x6003C60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490580", Offset = "0x1490580", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SnapPoint), Member = "Calculate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual List<SnapPoint> GetSnapPoints()
		{
			throw null;
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x0002BAAE File Offset: 0x00029CAE
		[global::Cpp2ILInjected.Token(Token = "0x6003C61")]
		[global::Cpp2ILInjected.Address(RVA = "0x14907A8", Offset = "0x14907A8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoLine<>), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIGenProgressBar), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIParticleLayer), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextPanel<>), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "GetDimensions", ReturnType = typeof(CalculatedStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "GetDimensionsBasedOnParentDimensions", MemberParameters = new object[] { typeof(CalculatedStyle) }, ReturnType = typeof(CalculatedStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void Recalculate()
		{
			throw null;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0002BAB1 File Offset: 0x00029CB1
		[global::Cpp2ILInjected.Token(Token = "0x6003C62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490904", Offset = "0x1490904", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		private CalculatedStyle GetDimensionsBasedOnParentDimensions(CalculatedStyle parentDimensions)
		{
			throw null;
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		[global::Cpp2ILInjected.Token(Token = "0x6003C63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490A00", Offset = "0x1490A00", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UIElement GetElementAt(Vector2 point)
		{
			throw null;
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0002BAB7 File Offset: 0x00029CB7
		[global::Cpp2ILInjected.Token(Token = "0x6003C64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490AF8", Offset = "0x1490AF8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool ContainsPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x0002BABA File Offset: 0x00029CBA
		[global::Cpp2ILInjected.Token(Token = "0x6003C65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490B3C", Offset = "0x1490B3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		public virtual Rectangle GetViewCullingArea()
		{
			throw null;
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0002BABD File Offset: 0x00029CBD
		[global::Cpp2ILInjected.Token(Token = "0x6003C66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490B48", Offset = "0x1490B48", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		public void SetPadding(float pixels)
		{
			throw null;
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0002BAC0 File Offset: 0x00029CC0
		[global::Cpp2ILInjected.Token(Token = "0x6003C67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490B54", Offset = "0x1490B54", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "RecalculateChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual void RecalculateChildren()
		{
			throw null;
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0002BAC3 File Offset: 0x00029CC3
		[global::Cpp2ILInjected.Token(Token = "0x6003C68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490C90", Offset = "0x1490C90", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public CalculatedStyle GetInnerDimensions()
		{
			throw null;
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x0002BAC6 File Offset: 0x00029CC6
		[global::Cpp2ILInjected.Token(Token = "0x6003C69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490CA4", Offset = "0x1490CA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public CalculatedStyle GetDimensions()
		{
			throw null;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x0002BAC9 File Offset: 0x00029CC9
		[global::Cpp2ILInjected.Token(Token = "0x6003C6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490CB8", Offset = "0x1490CB8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public CalculatedStyle GetOuterDimensions()
		{
			throw null;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0002BACC File Offset: 0x00029CCC
		[global::Cpp2ILInjected.Token(Token = "0x6003C6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490CCC", Offset = "0x1490CCC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyStyle(UIElement element)
		{
			throw null;
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0002BACF File Offset: 0x00029CCF
		[global::Cpp2ILInjected.Token(Token = "0x6003C6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490D28", Offset = "0x1490D28", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIScrollbar), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void LeftMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0002BAD2 File Offset: 0x00029CD2
		[global::Cpp2ILInjected.Token(Token = "0x6003C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490D88", Offset = "0x1490D88", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIScrollbar), Member = "LeftMouseUp", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void LeftMouseUp(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0002BAD5 File Offset: 0x00029CD5
		[global::Cpp2ILInjected.Token(Token = "0x6003C6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490DE8", Offset = "0x1490DE8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIToggleImage), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void LeftClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x0002BAD8 File Offset: 0x00029CD8
		[global::Cpp2ILInjected.Token(Token = "0x6003C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490E48", Offset = "0x1490E48", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void LeftDoubleClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x0002BADB File Offset: 0x00029CDB
		[global::Cpp2ILInjected.Token(Token = "0x6003C70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490EA8", Offset = "0x1490EA8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void RightMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0002BADE File Offset: 0x00029CDE
		[global::Cpp2ILInjected.Token(Token = "0x6003C71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490F08", Offset = "0x1490F08", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void RightMouseUp(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0002BAE1 File Offset: 0x00029CE1
		[global::Cpp2ILInjected.Token(Token = "0x6003C72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490F68", Offset = "0x1490F68", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "RightClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "RightClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void RightClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0002BAE4 File Offset: 0x00029CE4
		[global::Cpp2ILInjected.Token(Token = "0x6003C73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1490FC8", Offset = "0x1490FC8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void RightDoubleClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0002BAE7 File Offset: 0x00029CE7
		[global::Cpp2ILInjected.Token(Token = "0x6003C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491028", Offset = "0x1491028", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredImageButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageButton), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0002BAEA File Offset: 0x00029CEA
		[global::Cpp2ILInjected.Token(Token = "0x6003C75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491090", Offset = "0x1491090", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredImageButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageButton), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0002BAED File Offset: 0x00029CED
		[global::Cpp2ILInjected.Token(Token = "0x6003C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x14910F4", Offset = "0x14910F4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "ScrollWheel", MemberParameters = new object[] { typeof(UIScrollWheelEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void ScrollWheel(UIScrollWheelEvent evt)
		{
			throw null;
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0002BAF0 File Offset: 0x00029CF0
		[global::Cpp2ILInjected.Token(Token = "0x6003C77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491154", Offset = "0x1491154", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "RefreshState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Activate()
		{
			throw null;
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0002BAF3 File Offset: 0x00029CF3
		[global::Cpp2ILInjected.Token(Token = "0x6003C78")]
		[global::Cpp2ILInjected.Address(RVA = "0x14912E0", Offset = "0x14912E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnActivate()
		{
			throw null;
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0002BAF6 File Offset: 0x00029CF6
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		[global::Cpp2ILInjected.Token(Token = "0x6003C79")]
		[global::Cpp2ILInjected.Address(RVA = "0x14912E4", Offset = "0x14912E4", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicDebugDrawer), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void DrawDebugHitbox(BasicDebugDrawer drawer, float colorIntensity = 0f)
		{
			throw null;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0002BAF9 File Offset: 0x00029CF9
		[global::Cpp2ILInjected.Token(Token = "0x6003C7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14916F8", Offset = "0x14916F8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Deactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "RefreshState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Deactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Deactivate()
		{
			throw null;
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0002BAFC File Offset: 0x00029CFC
		[global::Cpp2ILInjected.Token(Token = "0x6003C7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491838", Offset = "0x1491838", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "OnDeactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual void OnDeactivate()
		{
			throw null;
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x0002BAFF File Offset: 0x00029CFF
		[global::Cpp2ILInjected.Token(Token = "0x6003C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14912B8", Offset = "0x14912B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0002BB02 File Offset: 0x00029D02
		[global::Cpp2ILInjected.Token(Token = "0x6003C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x149183C", Offset = "0x149183C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnInitialize()
		{
			throw null;
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0002BB05 File Offset: 0x00029D05
		[global::Cpp2ILInjected.Token(Token = "0x6003C7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491840", Offset = "0x1491840", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoLine<>), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public virtual int CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0002BB08 File Offset: 0x00029D08
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003C7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491848", Offset = "0x1491848", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RasterizerState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RasterizerState), Member = "set_CullMode", MemberParameters = new object[] { typeof(CullMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RasterizerState), Member = "set_ScissorTestEnable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static UIElement()
		{
			throw null;
		}

		// Token: 0x040066BA RID: 26298
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private UIElement <Parent>k__BackingField;

		// Token: 0x040066BB RID: 26299
		[global::Cpp2ILInjected.Token(Token = "0x4007B87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected readonly List<UIElement> Elements;

		// Token: 0x040066BC RID: 26300
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int <UniqueId>k__BackingField;

		// Token: 0x040066BD RID: 26301
		[global::Cpp2ILInjected.Token(Token = "0x4007B89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public StyleDimension Top;

		// Token: 0x040066BE RID: 26302
		[global::Cpp2ILInjected.Token(Token = "0x4007B8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public StyleDimension Left;

		// Token: 0x040066BF RID: 26303
		[global::Cpp2ILInjected.Token(Token = "0x4007B8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public StyleDimension Width;

		// Token: 0x040066C0 RID: 26304
		[global::Cpp2ILInjected.Token(Token = "0x4007B8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public StyleDimension Height;

		// Token: 0x040066C1 RID: 26305
		[global::Cpp2ILInjected.Token(Token = "0x4007B8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public StyleDimension MaxWidth;

		// Token: 0x040066C2 RID: 26306
		[global::Cpp2ILInjected.Token(Token = "0x4007B8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public StyleDimension MaxHeight;

		// Token: 0x040066C3 RID: 26307
		[global::Cpp2ILInjected.Token(Token = "0x4007B8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public StyleDimension MinWidth;

		// Token: 0x040066C4 RID: 26308
		[global::Cpp2ILInjected.Token(Token = "0x4007B90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public StyleDimension MinHeight;

		// Token: 0x040066C5 RID: 26309
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private UIElement.MouseEvent OnLeftMouseDown;

		// Token: 0x040066C6 RID: 26310
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private UIElement.MouseEvent OnLeftMouseUp;

		// Token: 0x040066C7 RID: 26311
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private UIElement.MouseEvent OnLeftClick;

		// Token: 0x040066C8 RID: 26312
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private UIElement.MouseEvent OnLeftDoubleClick;

		// Token: 0x040066C9 RID: 26313
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private UIElement.MouseEvent OnRightMouseDown;

		// Token: 0x040066CA RID: 26314
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private UIElement.MouseEvent OnRightMouseUp;

		// Token: 0x040066CB RID: 26315
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private UIElement.MouseEvent OnRightClick;

		// Token: 0x040066CC RID: 26316
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private UIElement.MouseEvent OnRightDoubleClick;

		// Token: 0x040066CD RID: 26317
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private UIElement.MouseEvent OnMouseOver;

		// Token: 0x040066CE RID: 26318
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private UIElement.MouseEvent OnMouseOut;

		// Token: 0x040066CF RID: 26319
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private UIElement.ScrollWheelEvent OnScrollWheel;

		// Token: 0x040066D0 RID: 26320
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private UIElement.ElementEvent OnUpdate;

		// Token: 0x040066D1 RID: 26321
		[global::Cpp2ILInjected.Token(Token = "0x4007B9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool _isInitialized;

		// Token: 0x040066D2 RID: 26322
		[global::Cpp2ILInjected.Token(Token = "0x4007B9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC9")]
		public bool IgnoresMouseInteraction;

		// Token: 0x040066D3 RID: 26323
		[global::Cpp2ILInjected.Token(Token = "0x4007B9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCA")]
		public bool OverflowHidden;

		// Token: 0x040066D4 RID: 26324
		[global::Cpp2ILInjected.Token(Token = "0x4007BA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public SamplerState OverrideSamplerState;

		// Token: 0x040066D5 RID: 26325
		[global::Cpp2ILInjected.Token(Token = "0x4007BA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public float PaddingTop;

		// Token: 0x040066D6 RID: 26326
		[global::Cpp2ILInjected.Token(Token = "0x4007BA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		public float PaddingLeft;

		// Token: 0x040066D7 RID: 26327
		[global::Cpp2ILInjected.Token(Token = "0x4007BA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public float PaddingRight;

		// Token: 0x040066D8 RID: 26328
		[global::Cpp2ILInjected.Token(Token = "0x4007BA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		public float PaddingBottom;

		// Token: 0x040066D9 RID: 26329
		[global::Cpp2ILInjected.Token(Token = "0x4007BA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public float MarginTop;

		// Token: 0x040066DA RID: 26330
		[global::Cpp2ILInjected.Token(Token = "0x4007BA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		public float MarginLeft;

		// Token: 0x040066DB RID: 26331
		[global::Cpp2ILInjected.Token(Token = "0x4007BA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public float MarginRight;

		// Token: 0x040066DC RID: 26332
		[global::Cpp2ILInjected.Token(Token = "0x4007BA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		public float MarginBottom;

		// Token: 0x040066DD RID: 26333
		[global::Cpp2ILInjected.Token(Token = "0x4007BA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public float HAlign;

		// Token: 0x040066DE RID: 26334
		[global::Cpp2ILInjected.Token(Token = "0x4007BAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		public float VAlign;

		// Token: 0x040066DF RID: 26335
		[global::Cpp2ILInjected.Token(Token = "0x4007BAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private CalculatedStyle _innerDimensions;

		// Token: 0x040066E0 RID: 26336
		[global::Cpp2ILInjected.Token(Token = "0x4007BAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private CalculatedStyle _dimensions;

		// Token: 0x040066E1 RID: 26337
		[global::Cpp2ILInjected.Token(Token = "0x4007BAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private CalculatedStyle _outerDimensions;

		// Token: 0x040066E2 RID: 26338
		[global::Cpp2ILInjected.Token(Token = "0x4007BAE")]
		private static readonly RasterizerState OverflowHiddenRasterizerState;

		// Token: 0x040066E3 RID: 26339
		[global::Cpp2ILInjected.Token(Token = "0x4007BAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public bool UseImmediateMode;

		// Token: 0x040066E4 RID: 26340
		[global::Cpp2ILInjected.Token(Token = "0x4007BB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private SnapPoint _snapPoint;

		// Token: 0x040066E5 RID: 26341
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007BB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private bool <IsMouseHovering>k__BackingField;

		// Token: 0x040066E6 RID: 26342
		[global::Cpp2ILInjected.Token(Token = "0x4007BB2")]
		private static int _idCounter;

		// Token: 0x0200095A RID: 2394
		// (Invoke) Token: 0x06004D1B RID: 19739
		[global::Cpp2ILInjected.Token(Token = "0x200071E")]
		public delegate void MouseEvent(UIMouseEvent evt, UIElement listeningElement);

		// Token: 0x0200095B RID: 2395
		// (Invoke) Token: 0x06004D1F RID: 19743
		[global::Cpp2ILInjected.Token(Token = "0x200071F")]
		public delegate void ScrollWheelEvent(UIScrollWheelEvent evt, UIElement listeningElement);

		// Token: 0x0200095C RID: 2396
		// (Invoke) Token: 0x06004D23 RID: 19747
		[global::Cpp2ILInjected.Token(Token = "0x2000720")]
		public delegate void ElementEvent(UIElement affectedElement);

		// Token: 0x0200095D RID: 2397
		// (Invoke) Token: 0x06004D27 RID: 19751
		[global::Cpp2ILInjected.Token(Token = "0x2000721")]
		public delegate void UIElementAction(UIElement element);
	}
}
