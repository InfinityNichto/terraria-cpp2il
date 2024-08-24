using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x02000548 RID: 1352
	[global::Cpp2ILInjected.Token(Token = "0x20007C2")]
	public class FlexibleTileWand
	{
		// Token: 0x060039AF RID: 14767 RVA: 0x0002C4DD File Offset: 0x0002A6DD
		[global::Cpp2ILInjected.Token(Token = "0x6004081")]
		[global::Cpp2ILInjected.Address(RVA = "0x76FA3C", Offset = "0x76FA3C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "AddVariations", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "AddVariations_ByRow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "EnsureAllMaterialOptions", MemberParameters = new object[] { typeof(FlexibleTileWand) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand.OptionBucket), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void AddVariation(int itemType, int tileIdToPlace, int tileStyleToPlace)
		{
			throw null;
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
		[global::Cpp2ILInjected.Token(Token = "0x6004082")]
		[global::Cpp2ILInjected.Address(RVA = "0x76FCB4", Offset = "0x76FCB4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerLarge", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerMedium", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerSmall", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 64)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void AddVariations(int itemType, int tileIdToPlace, params int[] stylesToPlace)
		{
			throw null;
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0002C4E3 File Offset: 0x0002A6E3
		[global::Cpp2ILInjected.Token(Token = "0x6004083")]
		[global::Cpp2ILInjected.Address(RVA = "0x76FD20", Offset = "0x76FD20", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "ForModders_AddPotsToWand", MemberParameters = new object[]
		{
			typeof(FlexibleTileWand),
			typeof(ref int),
			typeof(ref ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void AddVariations_ByRow(int itemType, int tileIdToPlace, int variationsPerRow, params int[] rows)
		{
			throw null;
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0002C4E6 File Offset: 0x0002A6E6
		[global::Cpp2ILInjected.Token(Token = "0x6004084")]
		[global::Cpp2ILInjected.Address(RVA = "0x76FDB8", Offset = "0x76FDB8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "RefreshOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryGetPlacementOption(Player player, int randomSeed, int selectCycleOffset, out FlexibleTileWand.PlacementOption option, out Item itemToConsume)
		{
			throw null;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0002C4E9 File Offset: 0x0002A6E9
		[global::Cpp2ILInjected.Token(Token = "0x6004085")]
		[global::Cpp2ILInjected.Address(RVA = "0x76FEB4", Offset = "0x76FEB4", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerLarge", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerMedium", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerSmall", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private static void EnsureAllMaterialOptions(FlexibleTileWand wand)
		{
			throw null;
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x0002C4EC File Offset: 0x0002A6EC
		[global::Cpp2ILInjected.Token(Token = "0x6004086")]
		[global::Cpp2ILInjected.Address(RVA = "0x7700EC", Offset = "0x7700EC", Length = "0x698")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "EnsureAllMaterialOptions", MemberParameters = new object[] { typeof(FlexibleTileWand) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariations", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public static FlexibleTileWand CreateRubblePlacerLarge()
		{
			throw null;
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0002C4EF File Offset: 0x0002A6EF
		[global::Cpp2ILInjected.Token(Token = "0x6004087")]
		[global::Cpp2ILInjected.Address(RVA = "0x77082C", Offset = "0x77082C", Length = "0x5E8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "EnsureAllMaterialOptions", MemberParameters = new object[] { typeof(FlexibleTileWand) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariations", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public static FlexibleTileWand CreateRubblePlacerMedium()
		{
			throw null;
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0002C4F2 File Offset: 0x0002A6F2
		[global::Cpp2ILInjected.Token(Token = "0x6004088")]
		[global::Cpp2ILInjected.Address(RVA = "0x770E14", Offset = "0x770E14", Length = "0x438")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "EnsureAllMaterialOptions", MemberParameters = new object[] { typeof(FlexibleTileWand) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariations", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static FlexibleTileWand CreateRubblePlacerSmall()
		{
			throw null;
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0002C4F5 File Offset: 0x0002A6F5
		[global::Cpp2ILInjected.Token(Token = "0x6004089")]
		[global::Cpp2ILInjected.Address(RVA = "0x77124C", Offset = "0x77124C", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "AddVariations_ByRow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static void ForModders_AddPotsToWand(FlexibleTileWand wand, ref int echoPileStyle, ref ushort tileType)
		{
			throw null;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		[global::Cpp2ILInjected.Token(Token = "0x600408A")]
		[global::Cpp2ILInjected.Address(RVA = "0x770784", Offset = "0x770784", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerLarge", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerMedium", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerSmall", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public FlexibleTileWand()
		{
			throw null;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0002C4FB File Offset: 0x0002A6FB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600408B")]
		[global::Cpp2ILInjected.Address(RVA = "0x771648", Offset = "0x771648", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerSmall", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerMedium", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlexibleTileWand), Member = "CreateRubblePlacerLarge", ReturnType = typeof(FlexibleTileWand))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static FlexibleTileWand()
		{
			throw null;
		}

		// Token: 0x040068D6 RID: 26838
		[global::Cpp2ILInjected.Token(Token = "0x4007E37")]
		public static FlexibleTileWand RubblePlacementSmall;

		// Token: 0x040068D7 RID: 26839
		[global::Cpp2ILInjected.Token(Token = "0x4007E38")]
		public static FlexibleTileWand RubblePlacementMedium;

		// Token: 0x040068D8 RID: 26840
		[global::Cpp2ILInjected.Token(Token = "0x4007E39")]
		public static FlexibleTileWand RubblePlacementLarge;

		// Token: 0x040068D9 RID: 26841
		[global::Cpp2ILInjected.Token(Token = "0x4007E3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private UnifiedRandom _random;

		// Token: 0x040068DA RID: 26842
		[global::Cpp2ILInjected.Token(Token = "0x4007E3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Dictionary<int, FlexibleTileWand.OptionBucket> _options;

		// Token: 0x040068DB RID: 26843
		[global::Cpp2ILInjected.Token(Token = "0x4007E3C")]
		private static int maxVariations;

		// Token: 0x02000985 RID: 2437
		[global::Cpp2ILInjected.Token(Token = "0x20007C3")]
		public class OptionBucket
		{
			// Token: 0x06004DA7 RID: 19879 RVA: 0x0002FB3D File Offset: 0x0002DD3D
			[global::Cpp2ILInjected.Token(Token = "0x600408C")]
			[global::Cpp2ILInjected.Address(RVA = "0x76FC24", Offset = "0x76FC24", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlexibleTileWand), Member = "AddVariation", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public OptionBucket(int itemTypeToConsume)
			{
				throw null;
			}

			// Token: 0x06004DA8 RID: 19880 RVA: 0x0002FB40 File Offset: 0x0002DD40
			[global::Cpp2ILInjected.Token(Token = "0x600408D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7716B8", Offset = "0x7716B8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public FlexibleTileWand.PlacementOption GetRandomOption(UnifiedRandom random)
			{
				throw null;
			}

			// Token: 0x06004DA9 RID: 19881 RVA: 0x0002FB43 File Offset: 0x0002DD43
			[global::Cpp2ILInjected.Token(Token = "0x600408E")]
			[global::Cpp2ILInjected.Address(RVA = "0x771730", Offset = "0x771730", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public FlexibleTileWand.PlacementOption GetOptionWithCycling(int cycleOffset)
			{
				throw null;
			}

			// Token: 0x04008C16 RID: 35862
			[global::Cpp2ILInjected.Token(Token = "0x4007E3D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int ItemTypeToConsume;

			// Token: 0x04008C17 RID: 35863
			[global::Cpp2ILInjected.Token(Token = "0x4007E3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public List<FlexibleTileWand.PlacementOption> Options;
		}

		// Token: 0x02000986 RID: 2438
		[global::Cpp2ILInjected.Token(Token = "0x20007C4")]
		public class PlacementOption
		{
			// Token: 0x06004DAA RID: 19882 RVA: 0x0002FB46 File Offset: 0x0002DD46
			[global::Cpp2ILInjected.Token(Token = "0x600408F")]
			[global::Cpp2ILInjected.Address(RVA = "0x76FCAC", Offset = "0x76FCAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlacementOption()
			{
				throw null;
			}

			// Token: 0x04008C18 RID: 35864
			[global::Cpp2ILInjected.Token(Token = "0x4007E3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int TileIdToPlace;

			// Token: 0x04008C19 RID: 35865
			[global::Cpp2ILInjected.Token(Token = "0x4007E40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int TileStyleToPlace;
		}
	}
}
