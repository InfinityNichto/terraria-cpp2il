using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Items;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000314 RID: 788
	[global::Cpp2ILInjected.Token(Token = "0x20003EE")]
	public class Item : Entity
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00026696 File Offset: 0x00024896
		[global::Cpp2ILInjected.Token(Token = "0x1700037F")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AF9")]
			[global::Cpp2ILInjected.Address(RVA = "0xB3028C", Offset = "0xB3028C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 47)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetItemNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00026699 File Offset: 0x00024899
		[global::Cpp2ILInjected.Token(Token = "0x17000380")]
		public string HoverName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AFA")]
			[global::Cpp2ILInjected.Address(RVA = "0xB302FC", Offset = "0xB302FC", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "SetupBackingSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "DrawItem", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip_GetLinesInfo", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(float),
				typeof(ref int),
				typeof(string[]),
				typeof(bool[]),
				typeof(bool[]),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "AffixName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0002669C File Offset: 0x0002489C
		[global::Cpp2ILInjected.Token(Token = "0x6001AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0xB304E0", Offset = "0xB304E0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationInner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(Point),
			typeof(Vector2),
			typeof(bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void StartCachingType(int t)
		{
			throw null;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0002669F File Offset: 0x0002489F
		[global::Cpp2ILInjected.Token(Token = "0x6001AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0xB30570", Offset = "0xB30570", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationInner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(Point),
			typeof(Vector2),
			typeof(bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DropCache(IEntitySource reason, Vector2 pos, Vector2 spread, int t, bool stopCaching = true)
		{
			throw null;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000266A2 File Offset: 0x000248A2
		[global::Cpp2ILInjected.Token(Token = "0x6001AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0xB30FE4", Offset = "0xB30FE4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Parent), Member = ".ctor", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEntitySource GetNPCSource_FromThis()
		{
			throw null;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000266A5 File Offset: 0x000248A5
		[global::Cpp2ILInjected.Token(Token = "0x6001AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0xB31040", Offset = "0xB31040", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_ByItemSourceId), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			throw null;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x000266A8 File Offset: 0x000248A8
		[global::Cpp2ILInjected.Token(Token = "0x17000381")]
		public bool PaintOrCoating
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AFF")]
			[global::Cpp2ILInjected.Address(RVA = "0xB310AC", Offset = "0xB310AC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FindPaintOrCoating", ReturnType = typeof(Item))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_CheckCanUse", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.CreativeHelper), Member = "GetItemGroup", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ref int)
			}, ReturnType = typeof(ContentSamples.CreativeHelper.ItemGroup))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000266AB File Offset: 0x000248AB
		[global::Cpp2ILInjected.Token(Token = "0x17000382")]
		public bool FitsAccessoryVanitySlot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B00")]
			[global::Cpp2ILInjected.Address(RVA = "0xB310CC", Offset = "0xB310CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickItemMovementAction", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int),
				typeof(Item),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapVanityEquip", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int),
				typeof(Player)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x000266AE File Offset: 0x000248AE
		[global::Cpp2ILInjected.Token(Token = "0x17000383")]
		public int OriginalRarity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B01")]
			[global::Cpp2ILInjected.Address(RVA = "0xB310D4", Offset = "0xB310D4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000266B1 File Offset: 0x000248B1
		[global::Cpp2ILInjected.Token(Token = "0x17000384")]
		public int OriginalDamage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B02")]
			[global::Cpp2ILInjected.Address(RVA = "0xB31154", Offset = "0xB31154", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_0", Member = "<.cctor>b__39", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_1", Member = "<.cctor>b__41", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_2", Member = "<.cctor>b__43", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_3", Member = "<.cctor>b__45", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_4", Member = "<.cctor>b__47", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_5", Member = "<.cctor>b__49", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_12", Member = "<.cctor>b__63", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x000266B4 File Offset: 0x000248B4
		[global::Cpp2ILInjected.Token(Token = "0x17000385")]
		public int OriginalDefense
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B03")]
			[global::Cpp2ILInjected.Address(RVA = "0xB311D4", Offset = "0xB311D4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_13", Member = "<.cctor>b__65", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_15", Member = "<.cctor>b__69", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000266B7 File Offset: 0x000248B7
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x000266BA File Offset: 0x000248BA
		[global::Cpp2ILInjected.Token(Token = "0x17000386")]
		public ItemVariant Variant
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B04")]
			[global::Cpp2ILInjected.Address(RVA = "0xB31254", Offset = "0xB31254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B05")]
			[global::Cpp2ILInjected.Address(RVA = "0xB3125C", Offset = "0xB3125C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000266BD File Offset: 0x000248BD
		[global::Cpp2ILInjected.Token(Token = "0x6001B06")]
		[global::Cpp2ILInjected.Address(RVA = "0xB31264", Offset = "0xB31264", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000266C0 File Offset: 0x000248C0
		[global::Cpp2ILInjected.Token(Token = "0x6001B07")]
		[global::Cpp2ILInjected.Address(RVA = "0xB31394", Offset = "0xB31394", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000266C3 File Offset: 0x000248C3
		[global::Cpp2ILInjected.Token(Token = "0x6001B08")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3144C", Offset = "0xB3144C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool CanHavePrefixes()
		{
			throw null;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000266C6 File Offset: 0x000248C6
		[global::Cpp2ILInjected.Token(Token = "0x6001B09")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3148C", Offset = "0xB3148C", Length = "0x814")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 191)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "RollAPrefix", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TryGetPrefixStatMultipliersForItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public bool Prefix(int prefixWeWant)
		{
			throw null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000266C9 File Offset: 0x000248C9
		[global::Cpp2ILInjected.Token(Token = "0x6001B0A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3256C", Offset = "0xB3256C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CanApplyPrefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "FixAgainstExploit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetRollablePrefixes", ReturnType = typeof(int[]))]
		public bool CanRollPrefix(int prefix)
		{
			throw null;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000266CC File Offset: 0x000248CC
		[global::Cpp2ILInjected.Token(Token = "0x6001B0B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3281C", Offset = "0xB3281C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CanRollPrefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TryGetPrefixStatMultipliersForItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		public bool CanApplyPrefix(int prefix)
		{
			throw null;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000266CF File Offset: 0x000248CF
		[global::Cpp2ILInjected.Token(Token = "0x6001B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB31CE8", Offset = "0xB31CE8", Length = "0x884")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CanApplyPrefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool TryGetPrefixStatMultipliersForItem(int rolledPrefix, out float dmg, out float kb, out float spd, out float size, out float shtspd, out float mcst, out int crt)
		{
			throw null;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000266D2 File Offset: 0x000248D2
		[global::Cpp2ILInjected.Token(Token = "0x6001B0D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB325E4", Offset = "0xB325E4", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CanRollPrefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "RollAPrefix", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsAPrefixableAccessory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public int[] GetRollablePrefixes()
		{
			throw null;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000266D5 File Offset: 0x000248D5
		[global::Cpp2ILInjected.Token(Token = "0x6001B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB31CA0", Offset = "0xB31CA0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetRollablePrefixes", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		private bool RollAPrefix(UnifiedRandom random, ref int rolledPrefix)
		{
			throw null;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000266D8 File Offset: 0x000248D8
		[global::Cpp2ILInjected.Token(Token = "0x6001B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3289C", Offset = "0xB3289C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetRollablePrefixes", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsAPrefixableAccessory()
		{
			throw null;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000266DB File Offset: 0x000248DB
		[global::Cpp2ILInjected.Token(Token = "0x6001B10")]
		[global::Cpp2ILInjected.Address(RVA = "0xB303A4", Offset = "0xB303A4", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "get_HoverName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GUIHotbarDrawInner", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(PopupTextContext),
			typeof(Item),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string AffixName()
		{
			throw null;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000266DE File Offset: 0x000248DE
		[global::Cpp2ILInjected.Token(Token = "0x6001B11")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32924", Offset = "0xB32924", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftButtonOver", MemberParameters = new object[] { typeof(GUITransactionButton.InputState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetTooltip", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ItemTooltip))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RebuildTooltip()
		{
			throw null;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000266E1 File Offset: 0x000248E1
		[global::Cpp2ILInjected.Token(Token = "0x6001B12")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32990", Offset = "0xB32990", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Rectangle getRect()
		{
			throw null;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000266E4 File Offset: 0x000248E4
		[global::Cpp2ILInjected.Token(Token = "0x6001B13")]
		[global::Cpp2ILInjected.Address(RVA = "0xB329E4", Offset = "0xB329E4", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool checkMat()
		{
			throw null;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000266E7 File Offset: 0x000248E7
		[global::Cpp2ILInjected.Token(Token = "0x6001B14")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32C4C", Offset = "0xB32C4C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 138)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		public void netDefaults(int type)
		{
			throw null;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000266EA File Offset: 0x000248EA
		[global::Cpp2ILInjected.Token(Token = "0x6001B15")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32C74", Offset = "0xB32C74", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForBannersAndDropThem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyDamageToNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update_NPCCollision", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneMetrics), Member = "ScanAndExportToMain", MemberParameters = new object[] { typeof(SceneMetricsScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = "GetKillCountNeeded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public static int BannerToItem(int banner)
		{
			throw null;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000266ED File Offset: 0x000248ED
		[global::Cpp2ILInjected.Token(Token = "0x6001B16")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32D30", Offset = "0xB32D30", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForBannersAndDropThem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyDamageToNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update_NPCCollision", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "FindBannerToAssociateTo", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(Projectile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = "GetKillCountNeeded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static int NPCtoBanner(int i)
		{
			throw null;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000266F0 File Offset: 0x000248F0
		[global::Cpp2ILInjected.Token(Token = "0x6001B17")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32D54", Offset = "0xB32D54", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawBuffTooltip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForBannersAndDropThem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static int BannerToNPC(int i)
		{
			throw null;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000266F3 File Offset: 0x000248F3
		[global::Cpp2ILInjected.Token(Token = "0x6001B18")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32D78", Offset = "0xB32D78", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickItemMovementAction", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "FillAmmoFromInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public bool FitsAmmoSlot()
		{
			throw null;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000266F6 File Offset: 0x000248F6
		[global::Cpp2ILInjected.Token(Token = "0x6001B19")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32DD8", Offset = "0xB32DD8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CanGoIntoAmmoOnPickup", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FillAmmo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "FillAmmoFromInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool CanFillEmptyAmmoSlot()
		{
			throw null;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000266F9 File Offset: 0x000248F9
		[global::Cpp2ILInjected.Token(Token = "0x6001B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE2AD4", Offset = "0xAE2AD4", Length = "0x1156C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "sellPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetShopValues", MemberParameters = new object[]
		{
			typeof(ItemRarityColor),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "MakeUsableWithChlorophyteExtractinator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 879)]
		public void SetDefaults1(int type)
		{
			throw null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000266FC File Offset: 0x000248FC
		[global::Cpp2ILInjected.Token(Token = "0x6001B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAF4040", Offset = "0xAF4040", Length = "0xE02C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "sellPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "MakeUsableWithChlorophyteExtractinator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 600)]
		public void SetDefaults2(int type)
		{
			throw null;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x000266FF File Offset: 0x000248FF
		[global::Cpp2ILInjected.Token(Token = "0x6001B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB0206C", Offset = "0xB0206C", Length = "0x9BD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "sellPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "MakeUsableWithChlorophyteExtractinator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToQuestFish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToSeaShell", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 537)]
		public void SetDefaults3(int type)
		{
			throw null;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00026702 File Offset: 0x00024902
		[global::Cpp2ILInjected.Token(Token = "0x6001B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32E78", Offset = "0xB32E78", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void DefaultToQuestFish()
		{
			throw null;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00026705 File Offset: 0x00024905
		[global::Cpp2ILInjected.Token(Token = "0x6001B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB0BC40", Offset = "0xB0BC40", Length = "0xC4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "sellPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetShopValues", MemberParameters = new object[]
		{
			typeof(ItemRarityColor),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToGolfBall", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 577)]
		public void SetDefaults4(int type)
		{
			throw null;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00026708 File Offset: 0x00024908
		[global::Cpp2ILInjected.Token(Token = "0x6001B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32E9C", Offset = "0xB32E9C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DefaultToGolfBall(int projid)
		{
			throw null;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0002670B File Offset: 0x0002490B
		[global::Cpp2ILInjected.Token(Token = "0x6001B20")]
		[global::Cpp2ILInjected.Address(RVA = "0xB25088", Offset = "0xB25088", Length = "0xB204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToPlaceableTile", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetShopValues", MemberParameters = new object[]
		{
			typeof(ItemRarityColor),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToPlaceableWall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToVanitypet", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "sellPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToPlaceableTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToAccessory", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToCapturedCritter", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToGolfClub", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultTokite", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToSeaShell", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToGuitar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToQuestFish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToHeadgear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToLawnMower", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToBow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetWeaponValues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToRangedWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToSpear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToStaff", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToGolfBall", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToThrownWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToMagicWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToMount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToWhip", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToMusicBox", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToTorch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToFood", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToSolution", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 493)]
		public void SetDefaults5(int type)
		{
			throw null;
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0002670E File Offset: 0x0002490E
		[global::Cpp2ILInjected.Token(Token = "0x6001B21")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32FB0", Offset = "0xB32FB0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DefaultToSolution(int projectileId)
		{
			throw null;
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00026711 File Offset: 0x00024911
		[global::Cpp2ILInjected.Token(Token = "0x6001B22")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3307C", Offset = "0xB3307C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToWhip(int projectileId, int dmg, float kb, float shootspeed, int animationTotalTime = 30)
		{
			throw null;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00026714 File Offset: 0x00024914
		[global::Cpp2ILInjected.Token(Token = "0x6001B23")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3313C", Offset = "0xB3313C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToThrownWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultTokite(int projId)
		{
			throw null;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00026717 File Offset: 0x00024917
		[global::Cpp2ILInjected.Token(Token = "0x6001B24")]
		[global::Cpp2ILInjected.Address(RVA = "0xB33288", Offset = "0xB33288", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawOverlay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ManageRightClickFeatures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "UseGasTrapInChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Chest),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "TryItemSwap", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		public void ChangeItemType(int to)
		{
			throw null;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0002671A File Offset: 0x0002491A
		[global::Cpp2ILInjected.Token(Token = "0x6001B25")]
		[global::Cpp2ILInjected.Address(RVA = "0xB332B4", Offset = "0xB332B4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DefaultToVanitypet(int projId, int buffID)
		{
			throw null;
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0002671D File Offset: 0x0002491D
		[global::Cpp2ILInjected.Token(Token = "0x17000387")]
		public bool IsACoin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B26")]
			[global::Cpp2ILInjected.Address(RVA = "0xB333B8", Offset = "0xB333B8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DepositHeldItem", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawItem", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickStackAllChests", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrabItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemGrabRange", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BuyItem", MemberParameters = new object[]
			{
				typeof(long),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemSpace", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(Player.ItemSpaceStatus))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemSpace", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ref Player.ItemSpaceStatus)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(GetItemSettings),
				typeof(bool)
			}, ReturnType = typeof(Item))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_VoidVault", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item[]),
				typeof(Item),
				typeof(GetItemSettings),
				typeof(Item)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot_VoidBag", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item[]),
				typeof(Item),
				typeof(GetItemSettings),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(GetItemSettings),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot_VoidBag", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item[]),
				typeof(Item),
				typeof(GetItemSettings),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(GetItemSettings),
				typeof(Item),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DropCoins", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.CreativeHelper), Member = "GetItemGroup", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ref int)
			}, ReturnType = typeof(ContentSamples.CreativeHelper.ItemGroup))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00026720 File Offset: 0x00024920
		[global::Cpp2ILInjected.Token(Token = "0x6001B27")]
		[global::Cpp2ILInjected.Address(RVA = "0xB333CC", Offset = "0xB333CC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_GolfBallIndicator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsAGolfingItem(Item item)
		{
			throw null;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00026723 File Offset: 0x00024923
		[global::Cpp2ILInjected.Token(Token = "0x6001B28")]
		[global::Cpp2ILInjected.Address(RVA = "0xB33468", Offset = "0xB33468", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void DefaultToSeaShell()
		{
			throw null;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00026726 File Offset: 0x00024926
		[global::Cpp2ILInjected.Token(Token = "0x6001B29")]
		[global::Cpp2ILInjected.Address(RVA = "0xB33590", Offset = "0xB33590", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToCapturedCritter(short npcIdToSpawnOnUse)
		{
			throw null;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00026729 File Offset: 0x00024929
		[global::Cpp2ILInjected.Token(Token = "0x6001B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3362C", Offset = "0xB3362C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToStaff(int projType, float pushForwardSpeed, int singleShotTime, int manaPerShot)
		{
			throw null;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0002672C File Offset: 0x0002492C
		[global::Cpp2ILInjected.Token(Token = "0x6001B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB33710", Offset = "0xB33710", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToSpear(int projType, float pushForwardSpeed, int animationTime)
		{
			throw null;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0002672F File Offset: 0x0002492F
		[global::Cpp2ILInjected.Token(Token = "0x6001B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB337C0", Offset = "0xB337C0", Length = "0xA84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToFood", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DefaultToHealingPotion", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void SetFoodDefaults(int type)
		{
			throw null;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00026732 File Offset: 0x00024932
		[global::Cpp2ILInjected.Token(Token = "0x6001B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34434", Offset = "0xB34434", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public void DefaultToMount(int mount)
		{
			throw null;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00026735 File Offset: 0x00024935
		[global::Cpp2ILInjected.Token(Token = "0x6001B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34448", Offset = "0xB34448", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToPlaceableWall(ushort wallToPlace)
		{
			throw null;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00026738 File Offset: 0x00024938
		[global::Cpp2ILInjected.Token(Token = "0x6001B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB344E4", Offset = "0xB344E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public void SetWeaponValues(int dmg, float knockback, int bonusCritChance = 0)
		{
			throw null;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0002673B File Offset: 0x0002493B
		[global::Cpp2ILInjected.Token(Token = "0x6001B30")]
		[global::Cpp2ILInjected.Address(RVA = "0xB344F4", Offset = "0xB344F4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DefaultToBow(int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			throw null;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0002673E File Offset: 0x0002493E
		[global::Cpp2ILInjected.Token(Token = "0x6001B31")]
		[global::Cpp2ILInjected.Address(RVA = "0xB336E4", Offset = "0xB336E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void DefaultToMagicWeapon(int projType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			throw null;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00026741 File Offset: 0x00024941
		[global::Cpp2ILInjected.Token(Token = "0x6001B32")]
		[global::Cpp2ILInjected.Address(RVA = "0xB345D8", Offset = "0xB345D8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void DefaultToRangedWeapon(int baseProjType, int ammoID, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			throw null;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00026744 File Offset: 0x00024944
		[global::Cpp2ILInjected.Token(Token = "0x6001B33")]
		[global::Cpp2ILInjected.Address(RVA = "0xB331DC", Offset = "0xB331DC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "DefaultTokite", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToThrownWeapon(int baseProjType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			throw null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00026747 File Offset: 0x00024947
		[global::Cpp2ILInjected.Token(Token = "0x6001B34")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34608", Offset = "0xB34608", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DefaultToTorch(int tileStyleToPlace, bool allowWaterPlacement = false)
		{
			throw null;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0002674A File Offset: 0x0002494A
		[global::Cpp2ILInjected.Token(Token = "0x6001B35")]
		[global::Cpp2ILInjected.Address(RVA = "0xB346CC", Offset = "0xB346CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void DefaultToPlaceableTile(int tileIDToPlace, int tileStyleToPlace = 0)
		{
			throw null;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0002674D File Offset: 0x0002494D
		[global::Cpp2ILInjected.Token(Token = "0x6001B36")]
		[global::Cpp2ILInjected.Address(RVA = "0xB346D0", Offset = "0xB346D0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 88)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToPlaceableTile(ushort tileIDToPlace, int tileStyleToPlace = 0)
		{
			throw null;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00026750 File Offset: 0x00024950
		[global::Cpp2ILInjected.Token(Token = "0x6001B37")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34774", Offset = "0xB34774", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void MakeUsableWithChlorophyteExtractinator()
		{
			throw null;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00026753 File Offset: 0x00024953
		[global::Cpp2ILInjected.Token(Token = "0x6001B38")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34798", Offset = "0xB34798", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void DefaultToGolfClub(int newwidth, int newheight)
		{
			throw null;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00026756 File Offset: 0x00024956
		[global::Cpp2ILInjected.Token(Token = "0x6001B39")]
		[global::Cpp2ILInjected.Address(RVA = "0xB347CC", Offset = "0xB347CC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultToLawnMower(int newwidth, int newheight)
		{
			throw null;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00026759 File Offset: 0x00024959
		[global::Cpp2ILInjected.Token(Token = "0x6001B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34244", Offset = "0xB34244", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetFoodDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DefaultToFood(int newwidth, int newheight, int foodbuff, int foodbuffduration, bool useGulpSound = false, int animationTime = 17)
		{
			throw null;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0002675C File Offset: 0x0002495C
		[global::Cpp2ILInjected.Token(Token = "0x6001B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34350", Offset = "0xB34350", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetFoodDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DefaultToHealingPotion(int newwidth, int newheight, int healingAmount, int animationTime = 17)
		{
			throw null;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0002675F File Offset: 0x0002495F
		[global::Cpp2ILInjected.Token(Token = "0x6001B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32FA4", Offset = "0xB32FA4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 89)]
		public void SetShopValues(ItemRarityColor rarity, int coinValue)
		{
			throw null;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00026762 File Offset: 0x00024962
		[global::Cpp2ILInjected.Token(Token = "0x6001B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3485C", Offset = "0xB3485C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void DefaultToHeadgear(int newwidth, int newheight, int helmetArtID)
		{
			throw null;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00026765 File Offset: 0x00024965
		[global::Cpp2ILInjected.Token(Token = "0x6001B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34868", Offset = "0xB34868", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		public void DefaultToAccessory(int newwidth = 24, int newheight = 24)
		{
			throw null;
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00026768 File Offset: 0x00024968
		[global::Cpp2ILInjected.Token(Token = "0x6001B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34878", Offset = "0xB34878", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void DefaultToGuitar(int newwidth = 24, int newheight = 24)
		{
			throw null;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0002676B File Offset: 0x0002496B
		[global::Cpp2ILInjected.Token(Token = "0x6001B40")]
		[global::Cpp2ILInjected.Address(RVA = "0xB34898", Offset = "0xB34898", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void DefaultToMusicBox(int style)
		{
			throw null;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0002676E File Offset: 0x0002496E
		[global::Cpp2ILInjected.Token(Token = "0x6001B41")]
		[global::Cpp2ILInjected.Address(RVA = "0xB307C4", Offset = "0xB307C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7176)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		public void SetDefaults(int Type = 0)
		{
			throw null;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00026771 File Offset: 0x00024971
		[global::Cpp2ILInjected.Token(Token = "0x6001B42")]
		[global::Cpp2ILInjected.Address(RVA = "0xB348EC", Offset = "0xB348EC", Length = "0xBC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "DropCache", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "ChangeItemType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "OnCreated", MemberParameters = new object[] { typeof(ItemCreationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "FixAgainstExploit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetPickedUpByMonsters_Special", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetPickedUpByMonsters_Money", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CombineWithNearbyItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemConversion_OldMobile), Member = "ModifyBodySlot", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemConversion_OldMobile), Member = "ModifyHeadSlot", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemConversion_OldMobile), Member = "ModifyLegSlot", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "ResetStats", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "HasVariant", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "SelectVariant", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ItemVariant))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetFoodDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "RebuildTooltip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
		public void SetDefaults(int Type, bool noMatCheck = false, ItemVariant variant = null)
		{
			throw null;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00026774 File Offset: 0x00024974
		[global::Cpp2ILInjected.Token(Token = "0x6001B43")]
		[global::Cpp2ILInjected.Address(RVA = "0xB35648", Offset = "0xB35648", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftButtonOver", MemberParameters = new object[] { typeof(GUITransactionButton.InputState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		public void OnCreated(ItemCreationContext context)
		{
			throw null;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00026777 File Offset: 0x00024977
		[global::Cpp2ILInjected.Token(Token = "0x6001B44")]
		[global::Cpp2ILInjected.Address(RVA = "0xB354B0", Offset = "0xB354B0", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ResetStats(int Type)
		{
			throw null;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0002677A File Offset: 0x0002497A
		[global::Cpp2ILInjected.Token(Token = "0x6001B45")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3566C", Offset = "0xB3566C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(Item),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Color GetAlphaFaded(Color newColor)
		{
			throw null;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0002677D File Offset: 0x0002497D
		[global::Cpp2ILInjected.Token(Token = "0x6001B46")]
		[global::Cpp2ILInjected.Address(RVA = "0xB35710", Offset = "0xB35710", Length = "0x7AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(Item),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemTooltipDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "DrawHotbarItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_40_InteractItemIcon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_30_BladedGlove", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gFade", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Color GetAlpha(Color newColor)
		{
			throw null;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00026780 File Offset: 0x00024980
		[global::Cpp2ILInjected.Token(Token = "0x6001B47")]
		[global::Cpp2ILInjected.Address(RVA = "0xB35EBC", Offset = "0xB35EBC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(Item),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemTooltipDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "DrawHotbarItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_40_InteractItemIcon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSpecialTilesLegacy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Color GetColor(Color newColor)
		{
			throw null;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00026783 File Offset: 0x00024983
		[global::Cpp2ILInjected.Token(Token = "0x6001B48")]
		[global::Cpp2ILInjected.Address(RVA = "0xB35F40", Offset = "0xB35F40", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool MechSpawn(float x, float y, int type)
		{
			throw null;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00026786 File Offset: 0x00024986
		[global::Cpp2ILInjected.Token(Token = "0x6001B49")]
		[global::Cpp2ILInjected.Address(RVA = "0xB32F80", Offset = "0xB32F80", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CollectTaxes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.DyeInitializer.<>c", Member = "<LoadLegacyHairdyes>b__5_3", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Color),
			typeof(ref bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 213)]
		public static int buyPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			throw null;
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00026789 File Offset: 0x00024989
		[global::Cpp2ILInjected.Token(Token = "0x6001B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB33390", Offset = "0xB33390", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults4", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults5", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 476)]
		public static int sellPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			throw null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0002678C File Offset: 0x0002498C
		[global::Cpp2ILInjected.Token(Token = "0x6001B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB360DC", Offset = "0xB360DC", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "Shimmering", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetShimmerEquivalentType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShimmerTransforms), Member = "IsItemTransformLocked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FindDecraftAmount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool CanShimmer()
		{
			throw null;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0002678F File Offset: 0x0002498F
		[global::Cpp2ILInjected.Token(Token = "0x6001B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB363C4", Offset = "0xB363C4", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CanShimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "shimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Shimmering()
		{
			throw null;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00026792 File Offset: 0x00024992
		[global::Cpp2ILInjected.Token(Token = "0x6001B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB36330", Offset = "0xB36330", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CanShimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetShimmerEquivalentType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShimmerTransforms), Member = "GetDecraftingRecipeIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int FindDecraftAmount()
		{
			throw null;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00026795 File Offset: 0x00024995
		[global::Cpp2ILInjected.Token(Token = "0x6001B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB36290", Offset = "0xB36290", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CanShimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "FindDecraftAmount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int GetShimmerEquivalentType()
		{
			throw null;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00026798 File Offset: 0x00024998
		[global::Cpp2ILInjected.Token(Token = "0x6001B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB36614", Offset = "0xB36614", Length = "0xFF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "Shimmering", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetShimmerEquivalentType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShimmerTransforms), Member = "GetDecraftingRecipeIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "AddCoinLuck", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "ShimmerEffect", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetNPCSource_FromThis", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CheckAchievement_RealEstateAndTownSlimes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetAvailableAmountOfNPCsToSpawnUpToSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "ReleaseNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FindDecraftAmount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
		private void GetShimmered()
		{
			throw null;
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0002679B File Offset: 0x0002499B
		[global::Cpp2ILInjected.Token(Token = "0x6001B50")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3760C", Offset = "0xB3760C", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void ShimmerEffect(Vector2 shimmerPositon)
		{
			throw null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0002679E File Offset: 0x0002499E
		[global::Cpp2ILInjected.Token(Token = "0x6001B51")]
		[global::Cpp2ILInjected.Address(RVA = "0xB37878", Offset = "0xB37878", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FixLoadedData_Items", MemberParameters = new object[] { typeof(Item[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EquipmentLoadout), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEFoodPlatter), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEWeaponsRack), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CanRollPrefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Refresh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void FixAgainstExploit()
		{
			throw null;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000267A1 File Offset: 0x000249A1
		[global::Cpp2ILInjected.Token(Token = "0x6001B52")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3795C", Offset = "0xB3795C", Length = "0xC88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "shimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Shimmering", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetPickedUpByMonsters_Special", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetPickedUpByMonsters_Money", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TryCombiningIntoNearbyItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "MoveInWorld", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ref Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CheckLavaDeath", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DespawnIfMeetingConditions", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "UpdateItem_VisualEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "LengthSquared", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public void UpdateItem(int i)
		{
			throw null;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000267A4 File Offset: 0x000249A4
		[global::Cpp2ILInjected.Token(Token = "0x6001B53")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3A64C", Offset = "0xB3A64C", Length = "0x670")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private void DespawnIfMeetingConditions(int i)
		{
			throw null;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000267A7 File Offset: 0x000249A7
		[global::Cpp2ILInjected.Token(Token = "0x6001B54")]
		[global::Cpp2ILInjected.Address(RVA = "0xB38CAC", Offset = "0xB38CAC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile_DropItems", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CombineWithNearbyItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void TryCombiningIntoNearbyItems(int i)
		{
			throw null;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000267AA File Offset: 0x000249AA
		[global::Cpp2ILInjected.Token(Token = "0x6001B55")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E218", Offset = "0xB3E218", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "RefreshOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryGetAmmo", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref Item),
			typeof(ref Color),
			typeof(ref float),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ModifyFlexibleWandPlacementInfo", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_PlaceIt_ConsumeFlexibleWandMaterial", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_CheckFlexibleWand", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public FlexibleTileWand GetFlexibleTileWand()
		{
			throw null;
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x000267AD File Offset: 0x000249AD
		[global::Cpp2ILInjected.Token(Token = "0x6001B56")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3A060", Offset = "0xB3A060", Length = "0x5EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "IsNPCValidForBestiaryKillCredit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "RegisterKill", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "StrikeNPCNoInteraction", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SpawnWOF", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_isLikeATownNPC", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void CheckLavaDeath(int i)
		{
			throw null;
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000267B0 File Offset: 0x000249B0
		[global::Cpp2ILInjected.Token(Token = "0x6001B57")]
		[global::Cpp2ILInjected.Address(RVA = "0xB38DD8", Offset = "0xB38DD8", Length = "0x1288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "LavaCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "WetCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "dustWater", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "TileCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "SlopeCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "StepConveyorBelt", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		private void MoveInWorld(float gravity, float maxFallSpeed, ref Vector2 wetVelocity, int i)
		{
			throw null;
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000267B3 File Offset: 0x000249B3
		[global::Cpp2ILInjected.Token(Token = "0x6001B58")]
		[global::Cpp2ILInjected.Address(RVA = "0xB385E4", Offset = "0xB385E4", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TransformCopperSlime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void GetPickedUpByMonsters_Special(int i)
		{
			throw null;
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000267B6 File Offset: 0x000249B6
		[global::Cpp2ILInjected.Token(Token = "0x6001B59")]
		[global::Cpp2ILInjected.Address(RVA = "0xB387E8", Offset = "0xB387E8", Length = "0x4C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "moneyPing", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void GetPickedUpByMonsters_Money(int i)
		{
			throw null;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000267B9 File Offset: 0x000249B9
		[global::Cpp2ILInjected.Token(Token = "0x6001B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3DD80", Offset = "0xB3DD80", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "TryCombiningIntoNearbyItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CanCombineStackInWorld", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void CombineWithNearbyItems(int myItemIndex)
		{
			throw null;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000267BC File Offset: 0x000249BC
		[global::Cpp2ILInjected.Token(Token = "0x6001B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E2E4", Offset = "0xB3E2E4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CombineWithNearbyItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool CanCombineStackInWorld()
		{
			throw null;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x000267BF File Offset: 0x000249BF
		[global::Cpp2ILInjected.Token(Token = "0x6001B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3ACBC", Offset = "0xB3ACBC", Length = "0x30C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2CircularEdge", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 127)]
		private void UpdateItem_VisualEffects()
		{
			throw null;
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x000267C2 File Offset: 0x000249C2
		[global::Cpp2ILInjected.Token(Token = "0x6001B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E384", Offset = "0xB3E384", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_40_InteractItemIcon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static Rectangle GetDrawHitbox(int type, Player user)
		{
			throw null;
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x000267C5 File Offset: 0x000249C5
		[global::Cpp2ILInjected.Token(Token = "0x6001B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E66C", Offset = "0xB3E66C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int NewItem(Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			throw null;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000267C8 File Offset: 0x000249C8
		[global::Cpp2ILInjected.Token(Token = "0x6001B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E770", Offset = "0xB3E770", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "ThrowItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DepositHeldItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OpenGoodieBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonCode), Member = "DropItemLocalPerClientAndSetNPCMoneyTo0", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			throw null;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000267CB File Offset: 0x000249CB
		[global::Cpp2ILInjected.Token(Token = "0x6001B60")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E840", Offset = "0xB3E840", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "DoDeathEvents", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryToPoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "UseGasTrapInChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Chest),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_192_JuminoAnimation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "DropGeodeGems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonCode), Member = "DropItemForEachInteractingPlayerOnThePlayer", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(UnifiedRandom),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int NewItem(IEntitySource source, Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			throw null;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x000267CE File Offset: 0x000249CE
		[global::Cpp2ILInjected.Token(Token = "0x6001B61")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3E944", Offset = "0xB3E944", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "DropStarterCrystals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int NewItem(IEntitySource source, Vector2 pos, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			throw null;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x000267D1 File Offset: 0x000249D1
		[global::Cpp2ILInjected.Token(Token = "0x6001B62")]
		[global::Cpp2ILInjected.Address(RVA = "0xB307D0", Offset = "0xB307D0", Length = "0x814")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 302)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFromList", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			"T[]"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "PickAnItemSlotToSpawnItemOn", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "WetCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_HighlightNewItems", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
		public static int NewItem(IEntitySource source, int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			throw null;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x000267D4 File Offset: 0x000249D4
		[global::Cpp2ILInjected.Token(Token = "0x6001B63")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3EA30", Offset = "0xB3EA30", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static int PickAnItemSlotToSpawnItemOn(bool reverseLookup, int nextItem)
		{
			throw null;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x000267D7 File Offset: 0x000249D7
		[global::Cpp2ILInjected.Token(Token = "0x6001B64")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3EC50", Offset = "0xB3EC50", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CheckPlayerItemOwnership", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CheckAssignItemOwnership", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ItemSpace", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(Player.ItemSpaceStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanPullItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Player.ItemSpaceStatus)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void FindOwner(int whoAmI, bool ignoreDistance = true)
		{
			throw null;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000267DA File Offset: 0x000249DA
		[global::Cpp2ILInjected.Token(Token = "0x6001B65")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F298", Offset = "0xB3F298", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 101)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Item Clone()
		{
			throw null;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000267DD File Offset: 0x000249DD
		[global::Cpp2ILInjected.Token(Token = "0x6001B66")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F318", Offset = "0xB3F318", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheckWrapped", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CanAffordItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "clientClone", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		public Item clientClone(Item cloneDestination)
		{
			throw null;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000267E0 File Offset: 0x000249E0
		[global::Cpp2ILInjected.Token(Token = "0x6001B67")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F3B8", Offset = "0xB3F3B8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "TurnGoldChestIntoDeadMansChest", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySystem), Member = "ItemCacheCreate", MemberParameters = new object[] { typeof(List<Item[]>) }, ReturnType = typeof(List<Tuple<Point, Item>>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Item DeepClone()
		{
			throw null;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x000267E3 File Offset: 0x000249E3
		[global::Cpp2ILInjected.Token(Token = "0x6001B68")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F438", Offset = "0xB3F438", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
		public bool IsTheSameAs(Item compareItem)
		{
			throw null;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000267E6 File Offset: 0x000249E6
		[global::Cpp2ILInjected.Token(Token = "0x6001B69")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F464", Offset = "0xB3F464", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TrySyncingMyPlayer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TrySyncingItemArray", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(Item[]),
			typeof(Item[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public bool IsNotTheSameAs(Item compareItem)
		{
			throw null;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000267E9 File Offset: 0x000249E9
		[global::Cpp2ILInjected.Token(Token = "0x6001B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F4A0", Offset = "0xB3F4A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetNameOverride(string name)
		{
			throw null;
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000267EC File Offset: 0x000249EC
		[global::Cpp2ILInjected.Token(Token = "0x6001B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F4A8", Offset = "0xB3F4A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearNameOverride()
		{
			throw null;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x000267EF File Offset: 0x000249EF
		[global::Cpp2ILInjected.Token(Token = "0x17000388")]
		public bool IsAir
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B6C")]
			[global::Cpp2ILInjected.Address(RVA = "0xB3F4B0", Offset = "0xB3F4B0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 116)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000267F2 File Offset: 0x000249F2
		[global::Cpp2ILInjected.Token(Token = "0x6001B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F4D4", Offset = "0xB3F4D4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		public void TurnToAir(bool fullReset = false)
		{
			throw null;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000267F5 File Offset: 0x000249F5
		[global::Cpp2ILInjected.Token(Token = "0x6001B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F50C", Offset = "0xB3F50C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void OnPurchase(Item item)
		{
			throw null;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000267F8 File Offset: 0x000249F8
		[global::Cpp2ILInjected.Token(Token = "0x6001B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F55C", Offset = "0xB3F55C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemExpectedPrice", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySystem), Member = "GetItemExpectedPrice", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetStoreValue()
		{
			throw null;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000267FB File Offset: 0x000249FB
		[global::Cpp2ILInjected.Token(Token = "0x6001B70")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F5C8", Offset = "0xB3F5C8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SaveTemporaryItemSlotContents", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EquipmentLoadout), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Serialize(BinaryWriter writer, ItemSerializationContext context)
		{
			throw null;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000267FE File Offset: 0x000249FE
		[global::Cpp2ILInjected.Token(Token = "0x6001B71")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F62C", Offset = "0xB3F62C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTemporaryItemSlotContents", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EquipmentLoadout), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public void DeserializeFrom(BinaryReader reader, ItemSerializationContext context)
		{
			throw null;
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00026801 File Offset: 0x00024A01
		[global::Cpp2ILInjected.Token(Token = "0x17000389")]
		public bool IsCurrency
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B72")]
			[global::Cpp2ILInjected.Address(RVA = "0xB3F6D0", Offset = "0xB3F6D0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomCurrencyManager), Member = "IsCustomCurrency", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00026804 File Offset: 0x00024A04
		[global::Cpp2ILInjected.Token(Token = "0x6001B73")]
		[global::Cpp2ILInjected.Address(RVA = "0xB37944", Offset = "0xB37944", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Refresh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void ResetPrefix()
		{
			throw null;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00026807 File Offset: 0x00024A07
		[global::Cpp2ILInjected.Token(Token = "0x6001B74")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F748", Offset = "0xB3F748", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "FixAgainstExploit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "ResetPrefix", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "RefreshItems", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "UpdateItemVariants", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "SelectVariant", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ItemVariant))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Refresh(bool onlyIfVariantChanged = true)
		{
			throw null;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0002680A File Offset: 0x00024A0A
		[global::Cpp2ILInjected.Token(Token = "0x1700038A")]
		public bool CanBeQuickUsed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B75")]
			[global::Cpp2ILInjected.Address(RVA = "0xB3F804", Offset = "0xB3F804", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0002680D File Offset: 0x00024A0D
		[global::Cpp2ILInjected.Token(Token = "0x6001B76")]
		[global::Cpp2ILInjected.Address(RVA = "0xB30708", Offset = "0xB30708", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 206)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Item()
		{
			throw null;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00026810 File Offset: 0x00024A10
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001B77")]
		[global::Cpp2ILInjected.Address(RVA = "0xB3F904", Offset = "0xB3F904", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static Item()
		{
			throw null;
		}

		// Token: 0x040021BF RID: 8639
		[global::Cpp2ILInjected.Token(Token = "0x4002831")]
		public static int numberOfNewItems;

		// Token: 0x040021C0 RID: 8640
		[global::Cpp2ILInjected.Token(Token = "0x4002832")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _nameOverride;

		// Token: 0x040021C1 RID: 8641
		[global::Cpp2ILInjected.Token(Token = "0x4002833")]
		public const int luckPotionDuration1 = 18000;

		// Token: 0x040021C2 RID: 8642
		[global::Cpp2ILInjected.Token(Token = "0x4002834")]
		public const int luckPotionDuration2 = 36000;

		// Token: 0x040021C3 RID: 8643
		[global::Cpp2ILInjected.Token(Token = "0x4002835")]
		public const int luckPotionDuration3 = 54000;

		// Token: 0x040021C4 RID: 8644
		[global::Cpp2ILInjected.Token(Token = "0x4002836")]
		public const int flaskTime = 72000;

		// Token: 0x040021C5 RID: 8645
		[global::Cpp2ILInjected.Token(Token = "0x4002837")]
		public const int copper = 1;

		// Token: 0x040021C6 RID: 8646
		[global::Cpp2ILInjected.Token(Token = "0x4002838")]
		public const int silver = 100;

		// Token: 0x040021C7 RID: 8647
		[global::Cpp2ILInjected.Token(Token = "0x4002839")]
		public const int gold = 10000;

		// Token: 0x040021C8 RID: 8648
		[global::Cpp2ILInjected.Token(Token = "0x400283A")]
		public const int platinum = 1000000;

		// Token: 0x040021C9 RID: 8649
		[global::Cpp2ILInjected.Token(Token = "0x400283B")]
		public const int goldCritterRarityColor = 3;

		// Token: 0x040021CA RID: 8650
		[global::Cpp2ILInjected.Token(Token = "0x400283C")]
		private static readonly int shadowOrbPrice;

		// Token: 0x040021CB RID: 8651
		[global::Cpp2ILInjected.Token(Token = "0x400283D")]
		private static readonly int dungeonPrice;

		// Token: 0x040021CC RID: 8652
		[global::Cpp2ILInjected.Token(Token = "0x400283E")]
		private static readonly int queenBeePrice;

		// Token: 0x040021CD RID: 8653
		[global::Cpp2ILInjected.Token(Token = "0x400283F")]
		private static readonly int hellPrice;

		// Token: 0x040021CE RID: 8654
		[global::Cpp2ILInjected.Token(Token = "0x4002840")]
		private static readonly int eclipsePrice;

		// Token: 0x040021CF RID: 8655
		[global::Cpp2ILInjected.Token(Token = "0x4002841")]
		private static readonly int eclipsePostPlanteraPrice;

		// Token: 0x040021D0 RID: 8656
		[global::Cpp2ILInjected.Token(Token = "0x4002842")]
		private static readonly int eclipseMothronPrice;

		// Token: 0x040021D1 RID: 8657
		[global::Cpp2ILInjected.Token(Token = "0x4002843")]
		public static int CommonMaxStack;

		// Token: 0x040021D2 RID: 8658
		[global::Cpp2ILInjected.Token(Token = "0x4002844")]
		public static int[] cachedItemSpawnsByType;

		// Token: 0x040021D3 RID: 8659
		[global::Cpp2ILInjected.Token(Token = "0x4002845")]
		public static int potionDelay;

		// Token: 0x040021D4 RID: 8660
		[global::Cpp2ILInjected.Token(Token = "0x4002846")]
		public static int restorationDelay;

		// Token: 0x040021D5 RID: 8661
		[global::Cpp2ILInjected.Token(Token = "0x4002847")]
		public static int mushroomDelay;

		// Token: 0x040021D6 RID: 8662
		[global::Cpp2ILInjected.Token(Token = "0x4002848")]
		public static int[] headType;

		// Token: 0x040021D7 RID: 8663
		[global::Cpp2ILInjected.Token(Token = "0x4002849")]
		public static int[] bodyType;

		// Token: 0x040021D8 RID: 8664
		[global::Cpp2ILInjected.Token(Token = "0x400284A")]
		public static int[] legType;

		// Token: 0x040021D9 RID: 8665
		[global::Cpp2ILInjected.Token(Token = "0x400284B")]
		public static bool[] staff;

		// Token: 0x040021DA RID: 8666
		[global::Cpp2ILInjected.Token(Token = "0x400284C")]
		public static bool[] claw;

		// Token: 0x040021DB RID: 8667
		[global::Cpp2ILInjected.Token(Token = "0x400284D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public bool questItem;

		// Token: 0x040021DC RID: 8668
		[global::Cpp2ILInjected.Token(Token = "0x400284E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		public bool flame;

		// Token: 0x040021DD RID: 8669
		[global::Cpp2ILInjected.Token(Token = "0x400284F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x62")]
		public bool mech;

		// Token: 0x040021DE RID: 8670
		[global::Cpp2ILInjected.Token(Token = "0x4002850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x63")]
		public bool beingGrabbed;

		// Token: 0x040021DF RID: 8671
		[global::Cpp2ILInjected.Token(Token = "0x4002851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public bool wornArmor;

		// Token: 0x040021E0 RID: 8672
		[global::Cpp2ILInjected.Token(Token = "0x4002852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x65")]
		public bool expertOnly;

		// Token: 0x040021E1 RID: 8673
		[global::Cpp2ILInjected.Token(Token = "0x4002853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x66")]
		public bool expert;

		// Token: 0x040021E2 RID: 8674
		[global::Cpp2ILInjected.Token(Token = "0x4002854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x67")]
		public bool isAShopItem;

		// Token: 0x040021E3 RID: 8675
		[global::Cpp2ILInjected.Token(Token = "0x4002855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public bool instanced;

		// Token: 0x040021E4 RID: 8676
		[global::Cpp2ILInjected.Token(Token = "0x4002856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		public bool favorited;

		// Token: 0x040021E5 RID: 8677
		[global::Cpp2ILInjected.Token(Token = "0x4002857")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6A")]
		public bool channel;

		// Token: 0x040021E6 RID: 8678
		[global::Cpp2ILInjected.Token(Token = "0x4002858")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6B")]
		public bool accessory;

		// Token: 0x040021E7 RID: 8679
		[global::Cpp2ILInjected.Token(Token = "0x4002859")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public bool potion;

		// Token: 0x040021E8 RID: 8680
		[global::Cpp2ILInjected.Token(Token = "0x400285A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6D")]
		public bool consumable;

		// Token: 0x040021E9 RID: 8681
		[global::Cpp2ILInjected.Token(Token = "0x400285B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6E")]
		public bool autoReuse;

		// Token: 0x040021EA RID: 8682
		[global::Cpp2ILInjected.Token(Token = "0x400285C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6F")]
		public bool useTurn;

		// Token: 0x040021EB RID: 8683
		[global::Cpp2ILInjected.Token(Token = "0x400285D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public bool notAmmo;

		// Token: 0x040021EC RID: 8684
		[global::Cpp2ILInjected.Token(Token = "0x400285E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		public bool buyOnce;

		// Token: 0x040021ED RID: 8685
		[global::Cpp2ILInjected.Token(Token = "0x400285F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		public bool noUseGraphic;

		// Token: 0x040021EE RID: 8686
		[global::Cpp2ILInjected.Token(Token = "0x4002860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x73")]
		public bool noMelee;

		// Token: 0x040021EF RID: 8687
		[global::Cpp2ILInjected.Token(Token = "0x4002861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public bool buy;

		// Token: 0x040021F0 RID: 8688
		[global::Cpp2ILInjected.Token(Token = "0x4002862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x75")]
		public bool reforge;

		// Token: 0x040021F1 RID: 8689
		[global::Cpp2ILInjected.Token(Token = "0x4002863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x76")]
		public bool social;

		// Token: 0x040021F2 RID: 8690
		[global::Cpp2ILInjected.Token(Token = "0x4002864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x77")]
		public bool vanity;

		// Token: 0x040021F3 RID: 8691
		[global::Cpp2ILInjected.Token(Token = "0x4002865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public bool material;

		// Token: 0x040021F4 RID: 8692
		[global::Cpp2ILInjected.Token(Token = "0x4002866")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x79")]
		public bool noWet;

		// Token: 0x040021F5 RID: 8693
		[global::Cpp2ILInjected.Token(Token = "0x4002867")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7A")]
		public bool cartTrack;

		// Token: 0x040021F6 RID: 8694
		[global::Cpp2ILInjected.Token(Token = "0x4002868")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7B")]
		public bool uniqueStack;

		// Token: 0x040021F7 RID: 8695
		[global::Cpp2ILInjected.Token(Token = "0x4002869")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public bool DD2Summon;

		// Token: 0x040021F8 RID: 8696
		[global::Cpp2ILInjected.Token(Token = "0x400286A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7D")]
		public bool melee;

		// Token: 0x040021F9 RID: 8697
		[global::Cpp2ILInjected.Token(Token = "0x400286B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7E")]
		public bool magic;

		// Token: 0x040021FA RID: 8698
		[global::Cpp2ILInjected.Token(Token = "0x400286C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7F")]
		public bool ranged;

		// Token: 0x040021FB RID: 8699
		[global::Cpp2ILInjected.Token(Token = "0x400286D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public bool summon;

		// Token: 0x040021FC RID: 8700
		[global::Cpp2ILInjected.Token(Token = "0x400286E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x81")]
		public bool sentry;

		// Token: 0x040021FD RID: 8701
		[global::Cpp2ILInjected.Token(Token = "0x400286F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x82")]
		public bool newAndShiny;

		// Token: 0x040021FE RID: 8702
		[global::Cpp2ILInjected.Token(Token = "0x4002870")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x83")]
		public bool canBePlacedInVanityRegardlessOfConditions;

		// Token: 0x040021FF RID: 8703
		[global::Cpp2ILInjected.Token(Token = "0x4002871")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private bool frozen;

		// Token: 0x04002200 RID: 8704
		[global::Cpp2ILInjected.Token(Token = "0x4002872")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x85")]
		private byte frozenCount;

		// Token: 0x04002201 RID: 8705
		[global::Cpp2ILInjected.Token(Token = "0x4002873")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public int noGrabDelay;

		// Token: 0x04002202 RID: 8706
		[global::Cpp2ILInjected.Token(Token = "0x4002874")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public int timeSinceItemSpawned;

		// Token: 0x04002203 RID: 8707
		[global::Cpp2ILInjected.Token(Token = "0x4002875")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public int tileWand;

		// Token: 0x04002204 RID: 8708
		[global::Cpp2ILInjected.Token(Token = "0x4002876")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public int tooltipContext;

		// Token: 0x04002205 RID: 8709
		[global::Cpp2ILInjected.Token(Token = "0x4002877")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public byte dye;

		// Token: 0x04002206 RID: 8710
		[global::Cpp2ILInjected.Token(Token = "0x4002878")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int fishingPole;

		// Token: 0x04002207 RID: 8711
		[global::Cpp2ILInjected.Token(Token = "0x4002879")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int bait;

		// Token: 0x04002208 RID: 8712
		[global::Cpp2ILInjected.Token(Token = "0x400287A")]
		public const int coinGrabRange = 350;

		// Token: 0x04002209 RID: 8713
		[global::Cpp2ILInjected.Token(Token = "0x400287B")]
		public const int manaGrabRange = 300;

		// Token: 0x0400220A RID: 8714
		[global::Cpp2ILInjected.Token(Token = "0x400287C")]
		public const int lifeGrabRange = 250;

		// Token: 0x0400220B RID: 8715
		[global::Cpp2ILInjected.Token(Token = "0x400287D")]
		public const int treasureGrabRange = 150;

		// Token: 0x0400220C RID: 8716
		[global::Cpp2ILInjected.Token(Token = "0x400287E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		public short makeNPC;

		// Token: 0x0400220D RID: 8717
		[global::Cpp2ILInjected.Token(Token = "0x400287F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA6")]
		public short hairDye;

		// Token: 0x0400220E RID: 8718
		[global::Cpp2ILInjected.Token(Token = "0x4002880")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public byte paint;

		// Token: 0x0400220F RID: 8719
		[global::Cpp2ILInjected.Token(Token = "0x4002881")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		public byte paintCoating;

		// Token: 0x04002210 RID: 8720
		[global::Cpp2ILInjected.Token(Token = "0x4002882")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		public int ownIgnore;

		// Token: 0x04002211 RID: 8721
		[global::Cpp2ILInjected.Token(Token = "0x4002883")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public int ownTime;

		// Token: 0x04002212 RID: 8722
		[global::Cpp2ILInjected.Token(Token = "0x4002884")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		public int keepTime;

		// Token: 0x04002213 RID: 8723
		[global::Cpp2ILInjected.Token(Token = "0x4002885")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public int timeLeftInWhichTheItemCannotBeTakenByEnemies;

		// Token: 0x04002214 RID: 8724
		[global::Cpp2ILInjected.Token(Token = "0x4002886")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		public int type;

		// Token: 0x04002215 RID: 8725
		[global::Cpp2ILInjected.Token(Token = "0x4002887")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public byte holdStyle;

		// Token: 0x04002216 RID: 8726
		[global::Cpp2ILInjected.Token(Token = "0x4002888")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC1")]
		public byte useStyle;

		// Token: 0x04002217 RID: 8727
		[global::Cpp2ILInjected.Token(Token = "0x4002889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		public int useAnimation;

		// Token: 0x04002218 RID: 8728
		[global::Cpp2ILInjected.Token(Token = "0x400288A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public int useTime;

		// Token: 0x04002219 RID: 8729
		[global::Cpp2ILInjected.Token(Token = "0x400288B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		public int stack;

		// Token: 0x0400221A RID: 8730
		[global::Cpp2ILInjected.Token(Token = "0x400288C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public int maxStack;

		// Token: 0x0400221B RID: 8731
		[global::Cpp2ILInjected.Token(Token = "0x400288D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
		public int pick;

		// Token: 0x0400221C RID: 8732
		[global::Cpp2ILInjected.Token(Token = "0x400288E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public int axe;

		// Token: 0x0400221D RID: 8733
		[global::Cpp2ILInjected.Token(Token = "0x400288F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		public int hammer;

		// Token: 0x0400221E RID: 8734
		[global::Cpp2ILInjected.Token(Token = "0x4002890")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public int tileBoost;

		// Token: 0x0400221F RID: 8735
		[global::Cpp2ILInjected.Token(Token = "0x4002891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		public int createTile;

		// Token: 0x04002220 RID: 8736
		[global::Cpp2ILInjected.Token(Token = "0x4002892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public int createWall;

		// Token: 0x04002221 RID: 8737
		[global::Cpp2ILInjected.Token(Token = "0x4002893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		public int placeStyle;

		// Token: 0x04002222 RID: 8738
		[global::Cpp2ILInjected.Token(Token = "0x4002894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public int damage;

		// Token: 0x04002223 RID: 8739
		[global::Cpp2ILInjected.Token(Token = "0x4002895")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		public float knockBack;

		// Token: 0x04002224 RID: 8740
		[global::Cpp2ILInjected.Token(Token = "0x4002896")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public int healLife;

		// Token: 0x04002225 RID: 8741
		[global::Cpp2ILInjected.Token(Token = "0x4002897")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		public int healMana;

		// Token: 0x04002226 RID: 8742
		[global::Cpp2ILInjected.Token(Token = "0x4002898")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public Color color;

		// Token: 0x04002227 RID: 8743
		[global::Cpp2ILInjected.Token(Token = "0x4002899")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		public int alpha;

		// Token: 0x04002228 RID: 8744
		[global::Cpp2ILInjected.Token(Token = "0x400289A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public short glowMask;

		// Token: 0x04002229 RID: 8745
		[global::Cpp2ILInjected.Token(Token = "0x400289B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		public float scale;

		// Token: 0x0400222A RID: 8746
		[global::Cpp2ILInjected.Token(Token = "0x400289C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public LegacySoundStyle UseSound;

		// Token: 0x0400222B RID: 8747
		[global::Cpp2ILInjected.Token(Token = "0x400289D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public int defense;

		// Token: 0x0400222C RID: 8748
		[global::Cpp2ILInjected.Token(Token = "0x400289E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		public int headSlot;

		// Token: 0x0400222D RID: 8749
		[global::Cpp2ILInjected.Token(Token = "0x400289F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public int bodySlot;

		// Token: 0x0400222E RID: 8750
		[global::Cpp2ILInjected.Token(Token = "0x40028A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		public int legSlot;

		// Token: 0x0400222F RID: 8751
		[global::Cpp2ILInjected.Token(Token = "0x40028A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public sbyte handOnSlot;

		// Token: 0x04002230 RID: 8752
		[global::Cpp2ILInjected.Token(Token = "0x40028A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x129")]
		public sbyte handOffSlot;

		// Token: 0x04002231 RID: 8753
		[global::Cpp2ILInjected.Token(Token = "0x40028A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12A")]
		public sbyte backSlot;

		// Token: 0x04002232 RID: 8754
		[global::Cpp2ILInjected.Token(Token = "0x40028A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12B")]
		public sbyte frontSlot;

		// Token: 0x04002233 RID: 8755
		[global::Cpp2ILInjected.Token(Token = "0x40028A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		public sbyte shoeSlot;

		// Token: 0x04002234 RID: 8756
		[global::Cpp2ILInjected.Token(Token = "0x40028A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12D")]
		public sbyte waistSlot;

		// Token: 0x04002235 RID: 8757
		[global::Cpp2ILInjected.Token(Token = "0x40028A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12E")]
		public sbyte wingSlot;

		// Token: 0x04002236 RID: 8758
		[global::Cpp2ILInjected.Token(Token = "0x40028A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12F")]
		public sbyte shieldSlot;

		// Token: 0x04002237 RID: 8759
		[global::Cpp2ILInjected.Token(Token = "0x40028A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public sbyte neckSlot;

		// Token: 0x04002238 RID: 8760
		[global::Cpp2ILInjected.Token(Token = "0x40028AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x131")]
		public sbyte faceSlot;

		// Token: 0x04002239 RID: 8761
		[global::Cpp2ILInjected.Token(Token = "0x40028AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x132")]
		public sbyte balloonSlot;

		// Token: 0x0400223A RID: 8762
		[global::Cpp2ILInjected.Token(Token = "0x40028AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x133")]
		public sbyte beardSlot;

		// Token: 0x0400223B RID: 8763
		[global::Cpp2ILInjected.Token(Token = "0x40028AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		public int stringColor;

		// Token: 0x0400223C RID: 8764
		[global::Cpp2ILInjected.Token(Token = "0x40028AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public ItemTooltip ToolTip;

		// Token: 0x0400223D RID: 8765
		[global::Cpp2ILInjected.Token(Token = "0x40028AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public string BestiaryNotes;

		// Token: 0x0400223E RID: 8766
		[global::Cpp2ILInjected.Token(Token = "0x40028B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public int playerIndexTheItemIsReservedFor;

		// Token: 0x0400223F RID: 8767
		[global::Cpp2ILInjected.Token(Token = "0x40028B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
		public int rare;

		// Token: 0x04002240 RID: 8768
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40028B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private ItemVariant <Variant>k__BackingField;

		// Token: 0x04002241 RID: 8769
		[global::Cpp2ILInjected.Token(Token = "0x40028B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public int shoot;

		// Token: 0x04002242 RID: 8770
		[global::Cpp2ILInjected.Token(Token = "0x40028B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		public float shootSpeed;

		// Token: 0x04002243 RID: 8771
		[global::Cpp2ILInjected.Token(Token = "0x40028B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public int ammo;

		// Token: 0x04002244 RID: 8772
		[global::Cpp2ILInjected.Token(Token = "0x40028B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
		public int useAmmo;

		// Token: 0x04002245 RID: 8773
		[global::Cpp2ILInjected.Token(Token = "0x40028B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public int lifeRegen;

		// Token: 0x04002246 RID: 8774
		[global::Cpp2ILInjected.Token(Token = "0x40028B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
		public int manaIncrease;

		// Token: 0x04002247 RID: 8775
		[global::Cpp2ILInjected.Token(Token = "0x40028B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		public int mana;

		// Token: 0x04002248 RID: 8776
		[global::Cpp2ILInjected.Token(Token = "0x40028BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
		public int timeSinceTheItemHasBeenReservedForSomeone;

		// Token: 0x04002249 RID: 8777
		[global::Cpp2ILInjected.Token(Token = "0x40028BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public int value;

		// Token: 0x0400224A RID: 8778
		[global::Cpp2ILInjected.Token(Token = "0x40028BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x17C")]
		public int buffType;

		// Token: 0x0400224B RID: 8779
		[global::Cpp2ILInjected.Token(Token = "0x40028BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		public int buffTime;

		// Token: 0x0400224C RID: 8780
		[global::Cpp2ILInjected.Token(Token = "0x40028BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x184")]
		public int mountType;

		// Token: 0x0400224D RID: 8781
		[global::Cpp2ILInjected.Token(Token = "0x40028BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public int shopSpecialCurrency;

		// Token: 0x0400224E RID: 8782
		[global::Cpp2ILInjected.Token(Token = "0x40028C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18C")]
		public int? shopCustomPrice;

		// Token: 0x0400224F RID: 8783
		[global::Cpp2ILInjected.Token(Token = "0x40028C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		public bool shootsEveryUse;

		// Token: 0x04002250 RID: 8784
		[global::Cpp2ILInjected.Token(Token = "0x40028C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x195")]
		public bool chlorophyteExtractinatorConsumable;

		// Token: 0x04002251 RID: 8785
		[global::Cpp2ILInjected.Token(Token = "0x40028C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		public int netID;

		// Token: 0x04002252 RID: 8786
		[global::Cpp2ILInjected.Token(Token = "0x40028C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
		public int crit;

		// Token: 0x04002253 RID: 8787
		[global::Cpp2ILInjected.Token(Token = "0x40028C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		public byte prefix;

		// Token: 0x04002254 RID: 8788
		[global::Cpp2ILInjected.Token(Token = "0x40028C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
		public int reuseDelay;

		// Token: 0x04002255 RID: 8789
		[Old("This is used to allow items to be discerned as vanity even if they didn't have visual slots to poll against")]
		[global::Cpp2ILInjected.Token(Token = "0x40028C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		public bool hasVanityEffects;

		// Token: 0x04002256 RID: 8790
		[global::Cpp2ILInjected.Token(Token = "0x40028C8")]
		private const int foodWidth = 22;

		// Token: 0x04002257 RID: 8791
		[global::Cpp2ILInjected.Token(Token = "0x40028C9")]
		private const int foodHeight = 22;

		// Token: 0x04002258 RID: 8792
		[global::Cpp2ILInjected.Token(Token = "0x40028CA")]
		public const int WALL_PLACEMENT_USETIME = 7;

		// Token: 0x04002259 RID: 8793
		[global::Cpp2ILInjected.Token(Token = "0x40028CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A9")]
		public bool shimmered;

		// Token: 0x0400225A RID: 8794
		[global::Cpp2ILInjected.Token(Token = "0x40028CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
		public float shimmerTime;
	}
}
