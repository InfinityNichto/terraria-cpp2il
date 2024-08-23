using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.Modules;

namespace Terraria.ObjectData
{
	// Token: 0x020003A6 RID: 934
	[global::Cpp2ILInjected.Token(Token = "0x2000545")]
	public class TileObjectData
	{
		// Token: 0x06002E0D RID: 11789 RVA: 0x0002A392 File Offset: 0x00028592
		[global::Cpp2ILInjected.Token(Token = "0x600326C")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E370", Offset = "0x132E370", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addBaseTile", MemberParameters = new object[] { typeof(ref TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addAlternate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectAlternatesModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectAlternatesModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectSubTilesModule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TileObjectSubTilesModule),
			typeof(List<TileObjectData>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileObjectData(TileObjectData copyFrom = null)
		{
			throw null;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x0002A395 File Offset: 0x00028595
		[global::Cpp2ILInjected.Token(Token = "0x600326D")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E3CC", Offset = "0x132E3CC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 462)]
		public void CopyFrom(TileObjectData copy)
		{
			throw null;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0002A398 File Offset: 0x00028598
		[global::Cpp2ILInjected.Token(Token = "0x600326E")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E40C", Offset = "0x132E40C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "FullCopyFrom", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		public void FullCopyFrom(ushort tileType)
		{
			throw null;
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x0002A39B File Offset: 0x0002859B
		[global::Cpp2ILInjected.Token(Token = "0x600326F")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E62C", Offset = "0x132E62C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "FullCopyFrom", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectSubTilesModule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TileObjectSubTilesModule),
			typeof(List<TileObjectData>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void FullCopyFrom(TileObjectData copy)
		{
			throw null;
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0002A39E File Offset: 0x0002859E
		[global::Cpp2ILInjected.Token(Token = "0x6003270")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E87C", Offset = "0x132E87C", Length = "0x538")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectAlternatesModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectAlternatesModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Alternates", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorTop", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorBottom", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorLeft", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorRight", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorTypesModule), Member = ".ctor", MemberParameters = new object[] { typeof(AnchorTypesModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorValidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorInvalidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorAlternateTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorValidWalls", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookCheckIfCanPlace", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookPostPlaceEveryone", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookPostPlaceMyPlayer", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookPlaceOverride", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_SubTiles", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Origin", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Direction", MemberParameters = new object[] { typeof(TileObjectDirection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_RandomStyleRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_FlattenAnchors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TileObjectCoordinatesModule),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinateHeights", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinateWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinatePadding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinatePaddingFix", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawYOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawFlipHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawFlipVertical", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawStepDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Style", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleWrapLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleMultiplier", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void SetupBaseObject()
		{
			throw null;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x0002A3A1 File Offset: 0x000285A1
		[global::Cpp2ILInjected.Token(Token = "0x6003271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1332040", Offset = "0x1332040", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_CoordinateFullWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_CoordinateFullHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addBaseTile", MemberParameters = new object[] { typeof(ref TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addAlternate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Calculate()
		{
			throw null;
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0002A3A4 File Offset: 0x000285A4
		[global::Cpp2ILInjected.Token(Token = "0x6003272")]
		[global::Cpp2ILInjected.Address(RVA = "0x13321F0", Offset = "0x13321F0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void WriteCheck()
		{
			throw null;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x0002A3A7 File Offset: 0x000285A7
		[global::Cpp2ILInjected.Token(Token = "0x6003273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1332284", Offset = "0x1332284", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void LockWrites()
		{
			throw null;
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x0002A3AA File Offset: 0x000285AA
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x0002A3AD File Offset: 0x000285AD
		[global::Cpp2ILInjected.Token(Token = "0x17000636")]
		private bool LinkedAlternates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003274")]
			[global::Cpp2ILInjected.Address(RVA = "0x13322D0", Offset = "0x13322D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003275")]
			[global::Cpp2ILInjected.Address(RVA = "0x13322D8", Offset = "0x13322D8", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectAlternatesModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectAlternatesModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x0002A3B0 File Offset: 0x000285B0
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x0002A3B3 File Offset: 0x000285B3
		[global::Cpp2ILInjected.Token(Token = "0x17000637")]
		public bool UsesCustomCanPlace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332360", Offset = "0x1332360", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003277")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332368", Offset = "0x1332368", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x0002A3B6 File Offset: 0x000285B6
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x0002A3B9 File Offset: 0x000285B9
		[global::Cpp2ILInjected.Token(Token = "0x17000638")]
		private List<TileObjectData> Alternates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003278")]
			[global::Cpp2ILInjected.Address(RVA = "0x133238C", Offset = "0x133238C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003279")]
			[global::Cpp2ILInjected.Address(RVA = "0x132EF54", Offset = "0x132EF54", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addAlternate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectAlternatesModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectAlternatesModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x0002A3BC File Offset: 0x000285BC
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x0002A3BF File Offset: 0x000285BF
		[global::Cpp2ILInjected.Token(Token = "0x17000639")]
		public AnchorData AnchorTop
		{
			[global::Cpp2ILInjected.Token(Token = "0x600327A")]
			[global::Cpp2ILInjected.Address(RVA = "0x13323F4", Offset = "0x13323F4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_AnchorTop", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_AnchorTop", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600327B")]
			[global::Cpp2ILInjected.Address(RVA = "0x132F05C", Offset = "0x132F05C", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorTop", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 44)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorData), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(AnchorData),
				typeof(AnchorData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorTop", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0002A3C2 File Offset: 0x000285C2
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x0002A3C5 File Offset: 0x000285C5
		[global::Cpp2ILInjected.Token(Token = "0x1700063A")]
		public AnchorData AnchorBottom
		{
			[global::Cpp2ILInjected.Token(Token = "0x600327C")]
			[global::Cpp2ILInjected.Address(RVA = "0x133245C", Offset = "0x133245C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_AnchorBottom", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_AnchorBottom", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600327D")]
			[global::Cpp2ILInjected.Address(RVA = "0x132F214", Offset = "0x132F214", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorBottom", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 115)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorData), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(AnchorData),
				typeof(AnchorData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorBottom", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x0002A3C8 File Offset: 0x000285C8
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0002A3CB File Offset: 0x000285CB
		[global::Cpp2ILInjected.Token(Token = "0x1700063B")]
		public AnchorData AnchorLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x600327E")]
			[global::Cpp2ILInjected.Address(RVA = "0x13324C4", Offset = "0x13324C4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_AnchorLeft", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_AnchorLeft", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600327F")]
			[global::Cpp2ILInjected.Address(RVA = "0x132F3CC", Offset = "0x132F3CC", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorLeft", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorData), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(AnchorData),
				typeof(AnchorData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorLeft", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x0002A3CE File Offset: 0x000285CE
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0002A3D1 File Offset: 0x000285D1
		[global::Cpp2ILInjected.Token(Token = "0x1700063C")]
		public AnchorData AnchorRight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003280")]
			[global::Cpp2ILInjected.Address(RVA = "0x133252C", Offset = "0x133252C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_AnchorRight", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_AnchorRight", ReturnType = typeof(AnchorData))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003281")]
			[global::Cpp2ILInjected.Address(RVA = "0x132F584", Offset = "0x132F584", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorRight", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorData), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(AnchorData),
				typeof(AnchorData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorRight", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x0002A3D4 File Offset: 0x000285D4
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x0002A3D7 File Offset: 0x000285D7
		[global::Cpp2ILInjected.Token(Token = "0x1700063D")]
		public bool AnchorWall
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003282")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332594", Offset = "0x1332594", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003283")]
			[global::Cpp2ILInjected.Address(RVA = "0x132F73C", Offset = "0x132F73C", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x0002A3DA File Offset: 0x000285DA
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0002A3DD File Offset: 0x000285DD
		[global::Cpp2ILInjected.Token(Token = "0x1700063E")]
		public int[] AnchorValidTiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003284")]
			[global::Cpp2ILInjected.Address(RVA = "0x13325FC", Offset = "0x13325FC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003285")]
			[global::Cpp2ILInjected.Address(RVA = "0x132F9D4", Offset = "0x132F9D4", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorValidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "deepCompare", MemberParameters = new object[]
			{
				typeof(int[]),
				typeof(int[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorTypesModule), Member = ".ctor", MemberParameters = new object[] { typeof(AnchorTypesModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorValidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x0002A3E0 File Offset: 0x000285E0
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x0002A3E3 File Offset: 0x000285E3
		[global::Cpp2ILInjected.Token(Token = "0x1700063F")]
		public int[] AnchorInvalidTiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003286")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332664", Offset = "0x1332664", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003287")]
			[global::Cpp2ILInjected.Address(RVA = "0x132FB74", Offset = "0x132FB74", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorInvalidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "deepCompare", MemberParameters = new object[]
			{
				typeof(int[]),
				typeof(int[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorTypesModule), Member = ".ctor", MemberParameters = new object[] { typeof(AnchorTypesModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorInvalidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x0002A3E6 File Offset: 0x000285E6
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0002A3E9 File Offset: 0x000285E9
		[global::Cpp2ILInjected.Token(Token = "0x17000640")]
		public int[] AnchorAlternateTiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003288")]
			[global::Cpp2ILInjected.Address(RVA = "0x13326CC", Offset = "0x13326CC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003289")]
			[global::Cpp2ILInjected.Address(RVA = "0x132FD14", Offset = "0x132FD14", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorAlternateTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "deepCompare", MemberParameters = new object[]
			{
				typeof(int[]),
				typeof(int[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorTypesModule), Member = ".ctor", MemberParameters = new object[] { typeof(AnchorTypesModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorAlternateTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x0002A3EC File Offset: 0x000285EC
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x0002A3EF File Offset: 0x000285EF
		[global::Cpp2ILInjected.Token(Token = "0x17000641")]
		public int[] AnchorValidWalls
		{
			[global::Cpp2ILInjected.Token(Token = "0x600328A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332734", Offset = "0x1332734", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600328B")]
			[global::Cpp2ILInjected.Address(RVA = "0x132FEB4", Offset = "0x132FEB4", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorValidWalls", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorTypesModule), Member = ".ctor", MemberParameters = new object[] { typeof(AnchorTypesModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorValidWalls", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x0002A3F2 File Offset: 0x000285F2
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x0002A3F5 File Offset: 0x000285F5
		[global::Cpp2ILInjected.Token(Token = "0x17000642")]
		public bool WaterDeath
		{
			[global::Cpp2ILInjected.Token(Token = "0x600328C")]
			[global::Cpp2ILInjected.Address(RVA = "0x133279C", Offset = "0x133279C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckWaterDeath", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckWaterDeath", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600328D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330060", Offset = "0x1330060", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_WaterDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x0002A3F8 File Offset: 0x000285F8
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x0002A3FB File Offset: 0x000285FB
		[global::Cpp2ILInjected.Token(Token = "0x17000643")]
		public bool LavaDeath
		{
			[global::Cpp2ILInjected.Token(Token = "0x600328E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332804", Offset = "0x1332804", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckLavaDeath", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckLavaDeath", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600328F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330184", Offset = "0x1330184", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_LavaDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 125)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x0002A3FE File Offset: 0x000285FE
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x0002A401 File Offset: 0x00028601
		[global::Cpp2ILInjected.Token(Token = "0x17000644")]
		public LiquidPlacement WaterPlacement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003290")]
			[global::Cpp2ILInjected.Address(RVA = "0x133286C", Offset = "0x133286C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003291")]
			[global::Cpp2ILInjected.Address(RVA = "0x13302E0", Offset = "0x13302E0", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_WaterPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x0002A404 File Offset: 0x00028604
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x0002A407 File Offset: 0x00028607
		[global::Cpp2ILInjected.Token(Token = "0x17000645")]
		public LiquidPlacement LavaPlacement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003292")]
			[global::Cpp2ILInjected.Address(RVA = "0x13328D4", Offset = "0x13328D4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003293")]
			[global::Cpp2ILInjected.Address(RVA = "0x13303F0", Offset = "0x13303F0", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_LavaPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x0002A40A File Offset: 0x0002860A
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x0002A40D File Offset: 0x0002860D
		[global::Cpp2ILInjected.Token(Token = "0x17000646")]
		public PlacementHook HookCheckIfCanPlace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003294")]
			[global::Cpp2ILInjected.Address(RVA = "0x133293C", Offset = "0x133293C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_HookCheckIfCanPlace", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_HookCheckIfCanPlace", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003295")]
			[global::Cpp2ILInjected.Address(RVA = "0x133057C", Offset = "0x133057C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x0002A410 File Offset: 0x00028610
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x0002A413 File Offset: 0x00028613
		[global::Cpp2ILInjected.Token(Token = "0x17000647")]
		public PlacementHook HookPostPlaceEveryone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003296")]
			[global::Cpp2ILInjected.Address(RVA = "0x13329C4", Offset = "0x13329C4", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_HookPostPlaceEveryone", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_HookPostPlaceEveryone", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003297")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330668", Offset = "0x1330668", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x0002A416 File Offset: 0x00028616
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x0002A419 File Offset: 0x00028619
		[global::Cpp2ILInjected.Token(Token = "0x17000648")]
		public PlacementHook HookPostPlaceMyPlayer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003298")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332A4C", Offset = "0x1332A4C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_HookPostPlaceMyPlayer", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_HookPostPlaceMyPlayer", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003299")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330754", Offset = "0x1330754", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x0002A41C File Offset: 0x0002861C
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x0002A41F File Offset: 0x0002861F
		[global::Cpp2ILInjected.Token(Token = "0x17000649")]
		public PlacementHook HookPlaceOverride
		{
			[global::Cpp2ILInjected.Token(Token = "0x600329A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332AD4", Offset = "0x1332AD4", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_HookPlaceOverride", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_HookPlaceOverride", ReturnType = typeof(PlacementHook))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600329B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330840", Offset = "0x1330840", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x0002A422 File Offset: 0x00028622
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x0002A425 File Offset: 0x00028625
		[global::Cpp2ILInjected.Token(Token = "0x1700064A")]
		private List<TileObjectData> SubTiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x600329C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332B5C", Offset = "0x1332B5C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600329D")]
			[global::Cpp2ILInjected.Address(RVA = "0x133092C", Offset = "0x133092C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectSubTilesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectSubTilesModule),
				typeof(List<TileObjectData>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x0002A428 File Offset: 0x00028628
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x0002A42B File Offset: 0x0002862B
		[global::Cpp2ILInjected.Token(Token = "0x1700064B")]
		public int DrawYOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600329E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332BC4", Offset = "0x1332BC4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600329F")]
			[global::Cpp2ILInjected.Address(RVA = "0x13317D0", Offset = "0x13317D0", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawYOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 150)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectDrawModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectDrawModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawYOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0002A42E File Offset: 0x0002862E
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x0002A431 File Offset: 0x00028631
		[global::Cpp2ILInjected.Token(Token = "0x1700064C")]
		public int DrawXOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332BD4", Offset = "0x1332BD4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332BE4", Offset = "0x1332BE4", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawXOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectDrawModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectDrawModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawXOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x0002A434 File Offset: 0x00028634
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x0002A437 File Offset: 0x00028637
		[global::Cpp2ILInjected.Token(Token = "0x1700064D")]
		public bool DrawFlipHorizontal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332CE0", Offset = "0x1332CE0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x13318CC", Offset = "0x13318CC", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawFlipHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectDrawModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectDrawModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawFlipHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x0002A43A File Offset: 0x0002863A
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x0002A43D File Offset: 0x0002863D
		[global::Cpp2ILInjected.Token(Token = "0x1700064E")]
		public bool DrawFlipVertical
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332CF0", Offset = "0x1332CF0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x13319D0", Offset = "0x13319D0", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawFlipVertical", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectDrawModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectDrawModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawFlipVertical", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x0002A440 File Offset: 0x00028640
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x0002A443 File Offset: 0x00028643
		[global::Cpp2ILInjected.Token(Token = "0x1700064F")]
		public int DrawStepDown
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332D00", Offset = "0x1332D00", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331AD4", Offset = "0x1331AD4", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawStepDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectDrawModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectDrawModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawStepDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x0002A446 File Offset: 0x00028646
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x0002A449 File Offset: 0x00028649
		[global::Cpp2ILInjected.Token(Token = "0x17000650")]
		public bool StyleHorizontal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332D10", Offset = "0x1332D10", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331D44", Offset = "0x1331D44", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 79)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x0002A44C File Offset: 0x0002864C
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x0002A44F File Offset: 0x0002864F
		[global::Cpp2ILInjected.Token(Token = "0x17000651")]
		public int Style
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332D20", Offset = "0x1332D20", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331C48", Offset = "0x1331C48", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Style", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "addAlternate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Style", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x0002A452 File Offset: 0x00028652
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x0002A455 File Offset: 0x00028655
		[global::Cpp2ILInjected.Token(Token = "0x17000652")]
		public int StyleWrapLimit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332D88", Offset = "0x1332D88", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331E48", Offset = "0x1331E48", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleWrapLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleWrapLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x0002A458 File Offset: 0x00028658
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x0002A45B File Offset: 0x0002865B
		[global::Cpp2ILInjected.Token(Token = "0x17000653")]
		public int? StyleWrapLimitVisualOverride
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332DF0", Offset = "0x1332DF0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332E58", Offset = "0x1332E58", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleWrapLimitVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleWrapLimitVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x0002A45E File Offset: 0x0002865E
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x0002A461 File Offset: 0x00028661
		[global::Cpp2ILInjected.Token(Token = "0x17000654")]
		public int? styleLineSkipVisualOverride
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332F88", Offset = "0x1332F88", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332FF0", Offset = "0x1332FF0", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_styleLineSkipVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_styleLineSkipVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x0002A464 File Offset: 0x00028664
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x0002A467 File Offset: 0x00028667
		[global::Cpp2ILInjected.Token(Token = "0x17000655")]
		public int StyleLineSkip
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333120", Offset = "0x1333120", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333188", Offset = "0x1333188", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleLineSkip", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleLineSkip", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x0002A46A File Offset: 0x0002866A
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x0002A46D File Offset: 0x0002866D
		[global::Cpp2ILInjected.Token(Token = "0x17000656")]
		public int StyleMultiplier
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333284", Offset = "0x1333284", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331F44", Offset = "0x1331F44", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleMultiplier", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectStyleModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectStyleModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleMultiplier", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x0002A470 File Offset: 0x00028670
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x0002A473 File Offset: 0x00028673
		[global::Cpp2ILInjected.Token(Token = "0x17000657")]
		public int Width
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1332188", Offset = "0x1332188", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GasTrapCheck", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Player)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 105)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330A98", Offset = "0x1330A98", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x0002A476 File Offset: 0x00028676
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x0002A479 File Offset: 0x00028679
		[global::Cpp2ILInjected.Token(Token = "0x17000658")]
		public int Height
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x13332EC", Offset = "0x13332EC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330BE0", Offset = "0x1330BE0", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 60)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x0002A47C File Offset: 0x0002867C
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x0002A47F File Offset: 0x0002867F
		[global::Cpp2ILInjected.Token(Token = "0x17000659")]
		public Point16 Origin
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333354", Offset = "0x1333354", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_Origin", ReturnType = typeof(Point16))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CallPostPlacementPlayerHook", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(TileObject)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "OriginToTopLeft", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref Point16)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_Origin", ReturnType = typeof(Point16))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330D28", Offset = "0x1330D28", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Origin", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 119)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Point16),
				typeof(Point16)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Origin", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x0002A482 File Offset: 0x00028682
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x0002A485 File Offset: 0x00028685
		[global::Cpp2ILInjected.Token(Token = "0x1700065A")]
		public TileObjectDirection Direction
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x13333B8", Offset = "0x13333B8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330E60", Offset = "0x1330E60", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Direction", MemberParameters = new object[] { typeof(TileObjectDirection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Direction", MemberParameters = new object[] { typeof(TileObjectDirection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x0002A488 File Offset: 0x00028688
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x0002A48B File Offset: 0x0002868B
		[global::Cpp2ILInjected.Token(Token = "0x1700065B")]
		public int RandomStyleRange
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333420", Offset = "0x1333420", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1330F5C", Offset = "0x1330F5C", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_RandomStyleRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_RandomStyleRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x0002A48E File Offset: 0x0002868E
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x0002A491 File Offset: 0x00028691
		[global::Cpp2ILInjected.Token(Token = "0x1700065C")]
		public int[] SpecificRandomStyles
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333488", Offset = "0x1333488", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x13334F0", Offset = "0x13334F0", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_SpecificRandomStyles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_SpecificRandomStyles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x0002A494 File Offset: 0x00028694
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x0002A497 File Offset: 0x00028697
		[global::Cpp2ILInjected.Token(Token = "0x1700065D")]
		public bool FlattenAnchors
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x13335EC", Offset = "0x13335EC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331058", Offset = "0x1331058", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_FlattenAnchors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectBaseModule), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectBaseModule) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_FlattenAnchors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x0002A49A File Offset: 0x0002869A
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x0002A49D File Offset: 0x0002869D
		[global::Cpp2ILInjected.Token(Token = "0x1700065E")]
		public int[] CoordinateHeights
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333654", Offset = "0x1333654", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorldTiles", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(bool[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorldTiles", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(bool[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x133127C", Offset = "0x133127C", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinateHeights", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 95)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "deepCompare", MemberParameters = new object[]
			{
				typeof(int[]),
				typeof(int[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinateHeights", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x0002A4A0 File Offset: 0x000286A0
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x0002A4A3 File Offset: 0x000286A3
		[global::Cpp2ILInjected.Token(Token = "0x1700065F")]
		public int CoordinateWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x13336BC", Offset = "0x13336BC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331428", Offset = "0x1331428", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinateWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinateWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x0002A4A6 File Offset: 0x000286A6
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x0002A4A9 File Offset: 0x000286A9
		[global::Cpp2ILInjected.Token(Token = "0x17000660")]
		public int CoordinatePadding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333724", Offset = "0x1333724", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorldTiles", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(bool[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorldTiles", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(bool[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x133152C", Offset = "0x133152C", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinatePadding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 44)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinatePadding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x0002A4AC File Offset: 0x000286AC
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x0002A4AF File Offset: 0x000286AF
		[global::Cpp2ILInjected.Token(Token = "0x17000661")]
		public Point16 CoordinatePaddingFix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x133378C", Offset = "0x133378C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "get_CoordinatePaddingFix", ReturnType = typeof(Point16))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinatePaddingFix", ReturnType = typeof(Point16))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1331630", Offset = "0x1331630", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinatePaddingFix", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Point16),
				typeof(Point16)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinatePaddingFix", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x0002A4B2 File Offset: 0x000286B2
		[global::Cpp2ILInjected.Token(Token = "0x17000662")]
		public int CoordinateFullWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x13337F0", Offset = "0x13337F0", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "PlatformFrameWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(TileObjectData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x0002A4B5 File Offset: 0x000286B5
		[global::Cpp2ILInjected.Token(Token = "0x17000663")]
		public int CoordinateFullHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x133386C", Offset = "0x133386C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorldTiles", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(bool[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorldTiles", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(bool[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSuper", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(TileObjectData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x0002A4B8 File Offset: 0x000286B8
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x0002A4BB File Offset: 0x000286BB
		[global::Cpp2ILInjected.Token(Token = "0x17000664")]
		public int DrawStyleOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x13338E8", Offset = "0x13338E8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60032CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333950", Offset = "0x1333950", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawStyleOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "WriteCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectCoordinatesModule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TileObjectCoordinatesModule),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawStyleOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x0002A4BE File Offset: 0x000286BE
		[global::Cpp2ILInjected.Token(Token = "0x60032D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1333A54", Offset = "0x1333A54", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckLiquidPlacement", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool LiquidPlace(Tile checkTile)
		{
			throw null;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x0002A4C1 File Offset: 0x000286C1
		[global::Cpp2ILInjected.Token(Token = "0x17000665")]
		public int AlternatesCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1333D40", Offset = "0x1333D40", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x0002A4C4 File Offset: 0x000286C4
		[global::Cpp2ILInjected.Token(Token = "0x60032D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1333DCC", Offset = "0x1333DCC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public bool isValidTileAnchor(int type)
		{
			throw null;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0002A4C7 File Offset: 0x000286C7
		[global::Cpp2ILInjected.Token(Token = "0x60032D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1333E48", Offset = "0x1333E48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool isValidWallAnchor(int type)
		{
			throw null;
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0002A4CA File Offset: 0x000286CA
		[global::Cpp2ILInjected.Token(Token = "0x60032D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1333EA0", Offset = "0x1333EA0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool isValidAlternateAnchor(int type)
		{
			throw null;
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0002A4CD File Offset: 0x000286CD
		[global::Cpp2ILInjected.Token(Token = "0x60032D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1333EEC", Offset = "0x1333EEC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawPreview", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(TileObjectPreviewData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(TileObjectPreviewData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int CalculatePlacementStyle(int style, int alternate, int random)
		{
			throw null;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0002A4D0 File Offset: 0x000286D0
		[global::Cpp2ILInjected.Token(Token = "0x60032D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1333FB4", Offset = "0x1333FB4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void addBaseTile(out TileObjectData baseTile)
		{
			throw null;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x0002A4D3 File Offset: 0x000286D3
		[global::Cpp2ILInjected.Token(Token = "0x60032D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334040", Offset = "0x1334040", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 331)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void addTile(int tileType)
		{
			throw null;
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x0002A4D6 File Offset: 0x000286D6
		[global::Cpp2ILInjected.Token(Token = "0x60032D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13340F0", Offset = "0x13340F0", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_SubTiles", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void addSubTile(params int[] styles)
		{
			throw null;
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x0002A4D9 File Offset: 0x000286D9
		[global::Cpp2ILInjected.Token(Token = "0x60032D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334324", Offset = "0x1334324", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_SubTiles", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void addSubTile(int style)
		{
			throw null;
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x0002A4DC File Offset: 0x000286DC
		[global::Cpp2ILInjected.Token(Token = "0x60032DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334520", Offset = "0x1334520", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 94)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "Calculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Alternates", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Style", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void addAlternate(int baseStyle)
		{
			throw null;
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x0002A4DF File Offset: 0x000286DF
		[global::Cpp2ILInjected.Token(Token = "0x60032DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1306518", Offset = "0x1306518", Length = "0x10280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinateHeights", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinateWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinatePadding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleMultiplier", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleWrapLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_UsesCustomCanPlace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "CopyFrom", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LavaPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "addSubTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "addTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Origin", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_Width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchorData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AnchorType),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorBottom", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<, , , , , , >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlacementHook), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Func<int, int, int, int, int, int, int>),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookPlaceOverride", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorTop", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterPlacement", MemberParameters = new object[] { typeof(LiquidPlacement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawYOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawFlipHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "addBaseTile", MemberParameters = new object[] { typeof(ref TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorValidWalls", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorValidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorLeft", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorRight", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_Direction", MemberParameters = new object[] { typeof(TileObjectDirection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "addAlternate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleLineSkip", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_LinkedAlternates", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "FullCopyFrom", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_WaterDeath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookPostPlaceMyPlayer", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_RandomStyleRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_StyleWrapLimitVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_CoordinatePaddingFix", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_Height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawStyleOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorInvalidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_HookCheckIfCanPlace", MemberParameters = new object[] { typeof(PlacementHook) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_StyleWrapLimit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_styleLineSkipVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_AnchorAlternateTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_FlattenAnchors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawXOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "set_DrawStepDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 246)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x0002A4E2 File Offset: 0x000286E2
		[global::Cpp2ILInjected.Token(Token = "0x60032DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13346D0", Offset = "0x13346D0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdatePlacementPreview", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GasTrapCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool CustomPlace(int type, int style)
		{
			throw null;
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x0002A4E5 File Offset: 0x000286E5
		[global::Cpp2ILInjected.Token(Token = "0x60032DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x13347F8", Offset = "0x13347F8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_CheckLavaBlocking", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "LiquidPlace", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		public static bool CheckLiquidPlacement(int type, int style, Tile checkTile)
		{
			throw null;
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x0002A4E8 File Offset: 0x000286E8
		[global::Cpp2ILInjected.Token(Token = "0x60032DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334834", Offset = "0x1334834", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool LiquidPlace(int type, Tile checkTile)
		{
			throw null;
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x0002A4EB File Offset: 0x000286EB
		[global::Cpp2ILInjected.Token(Token = "0x60032DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334908", Offset = "0x1334908", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_WaterDeath", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CheckWaterDeath(int type, int style)
		{
			throw null;
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x0002A4EE File Offset: 0x000286EE
		[global::Cpp2ILInjected.Token(Token = "0x60032E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334990", Offset = "0x1334990", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DontStarveTryWateringTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WaterCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_WaterDeath", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CheckWaterDeath(Tile checkTile)
		{
			throw null;
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x0002A4F1 File Offset: 0x000286F1
		[global::Cpp2ILInjected.Token(Token = "0x60032E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334FB8", Offset = "0x1334FB8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_LavaDeath", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CheckLavaDeath(int type, int style)
		{
			throw null;
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x0002A4F4 File Offset: 0x000286F4
		[global::Cpp2ILInjected.Token(Token = "0x60032E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335040", Offset = "0x1335040", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WaterCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_LavaDeath", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CheckLavaDeath(Tile checkTile)
		{
			throw null;
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x0002A4F7 File Offset: 0x000286F7
		[global::Cpp2ILInjected.Token(Token = "0x60032E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13350E8", Offset = "0x13350E8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AnchorValid", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(AnchorType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlatformProperTopFrame", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinateFullWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int PlatformFrameWidth()
		{
			throw null;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x0002A4FA File Offset: 0x000286FA
		[global::Cpp2ILInjected.Token(Token = "0x60032E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E434", Offset = "0x132E434", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static TileObjectData GetTileData(int type, int style, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x0002A4FD File Offset: 0x000286FD
		[global::Cpp2ILInjected.Token(Token = "0x60032E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1334A38", Offset = "0x1334A38", Length = "0x580")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckWaterDeath", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "CheckLavaDeath", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinateFullWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinateFullHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static TileObjectData GetTileData(Tile getTile)
		{
			throw null;
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0002A500 File Offset: 0x00028700
		[global::Cpp2ILInjected.Token(Token = "0x60032E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335150", Offset = "0x1335150", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SyncObjectPlacement(int tileX, int tileY, int type, int style, int dir)
		{
			throw null;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x0002A503 File Offset: 0x00028703
		[global::Cpp2ILInjected.Token(Token = "0x60032E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335204", Offset = "0x1335204", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_PlaceIt", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TileObject),
			typeof(int)
		}, ReturnType = typeof(TileObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryReplantingTree", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_Origin", ReturnType = typeof(Point16))]
		public static bool CallPostPlacementPlayerHook(int tileX, int tileY, int type, int style, int dir, int alternate, TileObject data)
		{
			throw null;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x0002A506 File Offset: 0x00028706
		[global::Cpp2ILInjected.Token(Token = "0x60032E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13352CC", Offset = "0x13352CC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "AfterPlacement_Hook", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_Origin", ReturnType = typeof(Point16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static void OriginToTopLeft(int type, int style, ref Point16 baseCoords)
		{
			throw null;
		}

		// Token: 0x04003205 RID: 12805
		[global::Cpp2ILInjected.Token(Token = "0x4003BA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TileObjectData _parent;

		// Token: 0x04003206 RID: 12806
		[global::Cpp2ILInjected.Token(Token = "0x4003BA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _linkedAlternates;

		// Token: 0x04003207 RID: 12807
		[global::Cpp2ILInjected.Token(Token = "0x4003BA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool _usesCustomCanPlace;

		// Token: 0x04003208 RID: 12808
		[global::Cpp2ILInjected.Token(Token = "0x4003BA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TileObjectAlternatesModule _alternates;

		// Token: 0x04003209 RID: 12809
		[global::Cpp2ILInjected.Token(Token = "0x4003BA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AnchorDataModule _anchor;

		// Token: 0x0400320A RID: 12810
		[global::Cpp2ILInjected.Token(Token = "0x4003BA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private AnchorTypesModule _anchorTiles;

		// Token: 0x0400320B RID: 12811
		[global::Cpp2ILInjected.Token(Token = "0x4003BAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private LiquidDeathModule _liquidDeath;

		// Token: 0x0400320C RID: 12812
		[global::Cpp2ILInjected.Token(Token = "0x4003BAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private LiquidPlacementModule _liquidPlacement;

		// Token: 0x0400320D RID: 12813
		[global::Cpp2ILInjected.Token(Token = "0x4003BAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private TilePlacementHooksModule _placementHooks;

		// Token: 0x0400320E RID: 12814
		[global::Cpp2ILInjected.Token(Token = "0x4003BAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private TileObjectSubTilesModule _subTiles;

		// Token: 0x0400320F RID: 12815
		[global::Cpp2ILInjected.Token(Token = "0x4003BAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private TileObjectDrawModule _tileObjectDraw;

		// Token: 0x04003210 RID: 12816
		[global::Cpp2ILInjected.Token(Token = "0x4003BAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private TileObjectStyleModule _tileObjectStyle;

		// Token: 0x04003211 RID: 12817
		[global::Cpp2ILInjected.Token(Token = "0x4003BB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private TileObjectBaseModule _tileObjectBase;

		// Token: 0x04003212 RID: 12818
		[global::Cpp2ILInjected.Token(Token = "0x4003BB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private TileObjectCoordinatesModule _tileObjectCoords;

		// Token: 0x04003213 RID: 12819
		[global::Cpp2ILInjected.Token(Token = "0x4003BB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _hasOwnAlternates;

		// Token: 0x04003214 RID: 12820
		[global::Cpp2ILInjected.Token(Token = "0x4003BB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x79")]
		private bool _hasOwnAnchor;

		// Token: 0x04003215 RID: 12821
		[global::Cpp2ILInjected.Token(Token = "0x4003BB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7A")]
		private bool _hasOwnAnchorTiles;

		// Token: 0x04003216 RID: 12822
		[global::Cpp2ILInjected.Token(Token = "0x4003BB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7B")]
		private bool _hasOwnLiquidDeath;

		// Token: 0x04003217 RID: 12823
		[global::Cpp2ILInjected.Token(Token = "0x4003BB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private bool _hasOwnLiquidPlacement;

		// Token: 0x04003218 RID: 12824
		[global::Cpp2ILInjected.Token(Token = "0x4003BB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7D")]
		private bool _hasOwnPlacementHooks;

		// Token: 0x04003219 RID: 12825
		[global::Cpp2ILInjected.Token(Token = "0x4003BB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7E")]
		private bool _hasOwnSubTiles;

		// Token: 0x0400321A RID: 12826
		[global::Cpp2ILInjected.Token(Token = "0x4003BB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7F")]
		private bool _hasOwnTileObjectBase;

		// Token: 0x0400321B RID: 12827
		[global::Cpp2ILInjected.Token(Token = "0x4003BBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool _hasOwnTileObjectDraw;

		// Token: 0x0400321C RID: 12828
		[global::Cpp2ILInjected.Token(Token = "0x4003BBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x81")]
		private bool _hasOwnTileObjectStyle;

		// Token: 0x0400321D RID: 12829
		[global::Cpp2ILInjected.Token(Token = "0x4003BBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x82")]
		private bool _hasOwnTileObjectCoords;

		// Token: 0x0400321E RID: 12830
		[global::Cpp2ILInjected.Token(Token = "0x4003BBD")]
		private static List<TileObjectData> _data;

		// Token: 0x0400321F RID: 12831
		[global::Cpp2ILInjected.Token(Token = "0x4003BBE")]
		private static TileObjectData _baseObject;

		// Token: 0x04003220 RID: 12832
		[global::Cpp2ILInjected.Token(Token = "0x4003BBF")]
		private static bool readOnlyData;

		// Token: 0x04003221 RID: 12833
		[global::Cpp2ILInjected.Token(Token = "0x4003BC0")]
		private static TileObjectData newTile;

		// Token: 0x04003222 RID: 12834
		[global::Cpp2ILInjected.Token(Token = "0x4003BC1")]
		private static TileObjectData newSubTile;

		// Token: 0x04003223 RID: 12835
		[global::Cpp2ILInjected.Token(Token = "0x4003BC2")]
		private static TileObjectData newAlternate;

		// Token: 0x04003224 RID: 12836
		[global::Cpp2ILInjected.Token(Token = "0x4003BC3")]
		private static TileObjectData StyleSwitch;

		// Token: 0x04003225 RID: 12837
		[global::Cpp2ILInjected.Token(Token = "0x4003BC4")]
		private static TileObjectData StyleTorch;

		// Token: 0x04003226 RID: 12838
		[global::Cpp2ILInjected.Token(Token = "0x4003BC5")]
		private static TileObjectData Style4x2;

		// Token: 0x04003227 RID: 12839
		[global::Cpp2ILInjected.Token(Token = "0x4003BC6")]
		private static TileObjectData Style2x2;

		// Token: 0x04003228 RID: 12840
		[global::Cpp2ILInjected.Token(Token = "0x4003BC7")]
		private static TileObjectData Style1x2;

		// Token: 0x04003229 RID: 12841
		[global::Cpp2ILInjected.Token(Token = "0x4003BC8")]
		private static TileObjectData Style1x1;

		// Token: 0x0400322A RID: 12842
		[global::Cpp2ILInjected.Token(Token = "0x4003BC9")]
		private static TileObjectData StyleAlch;

		// Token: 0x0400322B RID: 12843
		[global::Cpp2ILInjected.Token(Token = "0x4003BCA")]
		private static TileObjectData StyleDye;

		// Token: 0x0400322C RID: 12844
		[global::Cpp2ILInjected.Token(Token = "0x4003BCB")]
		private static TileObjectData Style2x1;

		// Token: 0x0400322D RID: 12845
		[global::Cpp2ILInjected.Token(Token = "0x4003BCC")]
		private static TileObjectData Style6x3;

		// Token: 0x0400322E RID: 12846
		[global::Cpp2ILInjected.Token(Token = "0x4003BCD")]
		private static TileObjectData StyleSmallCage;

		// Token: 0x0400322F RID: 12847
		[global::Cpp2ILInjected.Token(Token = "0x4003BCE")]
		private static TileObjectData StyleOnTable1x1;

		// Token: 0x04003230 RID: 12848
		[global::Cpp2ILInjected.Token(Token = "0x4003BCF")]
		private static TileObjectData Style1x2Top;

		// Token: 0x04003231 RID: 12849
		[global::Cpp2ILInjected.Token(Token = "0x4003BD0")]
		private static TileObjectData Style1xX;

		// Token: 0x04003232 RID: 12850
		[global::Cpp2ILInjected.Token(Token = "0x4003BD1")]
		private static TileObjectData Style2xX;

		// Token: 0x04003233 RID: 12851
		[global::Cpp2ILInjected.Token(Token = "0x4003BD2")]
		private static TileObjectData Style3x2;

		// Token: 0x04003234 RID: 12852
		[global::Cpp2ILInjected.Token(Token = "0x4003BD3")]
		private static TileObjectData Style3x3;

		// Token: 0x04003235 RID: 12853
		[global::Cpp2ILInjected.Token(Token = "0x4003BD4")]
		private static TileObjectData Style3x4;

		// Token: 0x04003236 RID: 12854
		[global::Cpp2ILInjected.Token(Token = "0x4003BD5")]
		private static TileObjectData Style5x4;

		// Token: 0x04003237 RID: 12855
		[global::Cpp2ILInjected.Token(Token = "0x4003BD6")]
		private static TileObjectData Style3x3Wall;
	}
}
