﻿using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.NetModules;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.WorldBuilding;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x02000316 RID: 790
	[global::Cpp2ILInjected.Token(Token = "0x20003F0")]
	public class Liquid
	{
		// Token: 0x06001A10 RID: 6672 RVA: 0x0002688E File Offset: 0x00024A8E
		[global::Cpp2ILInjected.Token(Token = "0x6001BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE85DC", Offset = "0xCE85DC", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void NetSendLiquid(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00026891 File Offset: 0x00024A91
		[global::Cpp2ILInjected.Token(Token = "0x6001BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE8754", Offset = "0xCE8754", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShimmerCleanUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WaterCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void tilesIgnoreWater(bool ignoreSolids)
		{
			throw null;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00026894 File Offset: 0x00024A94
		[global::Cpp2ILInjected.Token(Token = "0x6001BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE87C4", Offset = "0xCE87C4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_48", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_96", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void worldGenTilesIgnoreWater(bool ignoreSolids)
		{
			throw null;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00026897 File Offset: 0x00024A97
		[global::Cpp2ILInjected.Token(Token = "0x6001BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE8838", Offset = "0xCE8838", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "SelectMultiplayer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_0", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void ReInit()
		{
			throw null;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0002689A File Offset: 0x00024A9A
		[global::Cpp2ILInjected.Token(Token = "0x6001BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE8904", Offset = "0xCE8904", Length = "0x9C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_27", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_48", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_72", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_96", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinishRemixWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "ShimmerRemoveWater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "tilesIgnoreWater", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "UpdateProgressDisplay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "oceanDepths", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "AttemptToMoveLava", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "AttemptToMoveHoney", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "AttemptToMoveShimmer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public unsafe static void QuickWater(int verbose = 0, int minY = -1, int maxY = -1)
		{
			throw null;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0002689D File Offset: 0x00024A9D
		[global::Cpp2ILInjected.Token(Token = "0x6001BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE9684", Offset = "0xCE9684", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "HoneyCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void AttemptToMoveHoney(int X, int Y, bool tileAtXYHasHoney, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000268A0 File Offset: 0x00024AA0
		[global::Cpp2ILInjected.Token(Token = "0x6001BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE949C", Offset = "0xCE949C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "LavaCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void AttemptToMoveLava(int X, int Y, bool tileAtXYHasLava, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000268A3 File Offset: 0x00024AA3
		[global::Cpp2ILInjected.Token(Token = "0x6001BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE986C", Offset = "0xCE986C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "ShimmerCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void AttemptToMoveShimmer(int X, int Y, bool tileAtXYHasShimmer, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000268A6 File Offset: 0x00024AA6
		[global::Cpp2ILInjected.Token(Token = "0x6001BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE92C8", Offset = "0xCE92C8", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void UpdateProgressDisplay(int verbose, int minY, int maxY, int y)
		{
			throw null;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000268A9 File Offset: 0x00024AA9
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE9D40", Offset = "0xCE9D40", Length = "0x21FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "LavaCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "HoneyCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "ShimmerCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 107)]
		public unsafe void Update(int worldWidth, uint* tileLookup, ushort* tileTypeData, short* tileTypeSHeader, byte* tileTypeBHeader, byte* tileLiquidValues, ushort* tileSearchUID)
		{
			throw null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000268AC File Offset: 0x00024AAC
		[global::Cpp2ILInjected.Token(Token = "0x6001BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0xCEC35C", Offset = "0xCEC35C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void StartPanic()
		{
			throw null;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000268AF File Offset: 0x00024AAF
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0xCEC4EC", Offset = "0xCEC4EC", Length = "0xB0C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_48", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_96", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "tilesIgnoreWater", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "StartPanic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint*),
			typeof(ushort*),
			typeof(short*),
			typeof(byte*),
			typeof(byte*),
			typeof(ushort*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidBuffer), Member = "DelBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetLiquidModule), Member = "CreateAndBroadcastByChunk", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "WaterCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		public unsafe static void UpdateLiquid()
		{
			throw null;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x000268B2 File Offset: 0x00024AB2
		[global::Cpp2ILInjected.Token(Token = "0x6001BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0xCEBF3C", Offset = "0xCEBF3C", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint*),
			typeof(ushort*),
			typeof(short*),
			typeof(byte*),
			typeof(byte*),
			typeof(ushort*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseBuckets", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "EmptyLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WaterCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "checkingLiquid", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "skipLiquid", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidBuffer), Member = "AddBuffer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "NetSendLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "CheckLavaDeath", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "CheckWaterDeath", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public unsafe static void AddWater(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000268B5 File Offset: 0x00024AB5
		[global::Cpp2ILInjected.Token(Token = "0x6001BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0xCF976C", Offset = "0xCF976C", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool UnderGroundDesertCheck(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000268B8 File Offset: 0x00024AB8
		[global::Cpp2ILInjected.Token(Token = "0x6001BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0xCF9988", Offset = "0xCF9988", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "LavaCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static bool UndergroundDesertCheck(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000268BB File Offset: 0x00024ABB
		[global::Cpp2ILInjected.Token(Token = "0x6001BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0xCF9B00", Offset = "0xCF9B00", Length = "0x9FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "LavaCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "HoneyCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "ShimmerCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "GetLiquidMergeTypes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_liquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "shimmer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "honey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetLiquidChangeType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileChangeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlayLiquidChangeSound", MemberParameters = new object[]
		{
			typeof(TileChangeType),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareTileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTileSquare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TileChangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public unsafe static void LiquidCheck(int x, int y, int thisLiquidType, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000268BE File Offset: 0x00024ABE
		[global::Cpp2ILInjected.Token(Token = "0x6001BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0xCFA4FC", Offset = "0xCFA4FC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public unsafe static void GetLiquidMergeTypes(int thisLiquidType, out int liquidMergeTileType, out int liquidMergeType, bool waterNearby, bool lavaNearby, bool honeyNearby, bool shimmerNearby)
		{
			throw null;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000268C1 File Offset: 0x00024AC1
		[global::Cpp2ILInjected.Token(Token = "0x6001BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE9AEC", Offset = "0xCE9AEC", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AttemptToMoveLava", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint*),
			typeof(ushort*),
			typeof(short*),
			typeof(byte*),
			typeof(byte*),
			typeof(ushort*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "UndergroundDesertCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe static void LavaCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000268C4 File Offset: 0x00024AC4
		[global::Cpp2ILInjected.Token(Token = "0x6001BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE9A54", Offset = "0xCE9A54", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AttemptToMoveHoney", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint*),
			typeof(ushort*),
			typeof(short*),
			typeof(byte*),
			typeof(byte*),
			typeof(ushort*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static void HoneyCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000268C7 File Offset: 0x00024AC7
		[global::Cpp2ILInjected.Token(Token = "0x6001BB4")]
		[global::Cpp2ILInjected.Address(RVA = "0xCE9CA8", Offset = "0xCE9CA8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AttemptToMoveShimmer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint*),
			typeof(ushort*),
			typeof(short*),
			typeof(byte*),
			typeof(byte*),
			typeof(ushort*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static void ShimmerCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000268CA File Offset: 0x00024ACA
		[global::Cpp2ILInjected.Token(Token = "0x6001BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0xCECFF8", Offset = "0xCECFF8", Length = "0xBE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "LavaCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareTileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTileSquare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TileChangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "ShimmerCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "HoneyCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "NetSendLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetCheckingLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CheckAlch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CheckLilyPad", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public unsafe static void DelWater(int l)
		{
			throw null;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000268CD File Offset: 0x00024ACD
		[global::Cpp2ILInjected.Token(Token = "0x6001BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0xCFA670", Offset = "0xCFA670", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Liquid()
		{
			throw null;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000268D0 File Offset: 0x00024AD0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BB7")]
		[global::Cpp2ILInjected.Address(RVA = "0xCFA678", Offset = "0xCFA678", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Liquid()
		{
			throw null;
		}

		// Token: 0x0400225F RID: 8799
		[global::Cpp2ILInjected.Token(Token = "0x40028D1")]
		public static int skipCount;

		// Token: 0x04002260 RID: 8800
		[global::Cpp2ILInjected.Token(Token = "0x40028D2")]
		public static int stuckCount;

		// Token: 0x04002261 RID: 8801
		[global::Cpp2ILInjected.Token(Token = "0x40028D3")]
		public static int stuckAmount;

		// Token: 0x04002262 RID: 8802
		[global::Cpp2ILInjected.Token(Token = "0x40028D4")]
		public static int cycles;

		// Token: 0x04002263 RID: 8803
		[global::Cpp2ILInjected.Token(Token = "0x40028D5")]
		public static int curMaxLiquid;

		// Token: 0x04002264 RID: 8804
		[global::Cpp2ILInjected.Token(Token = "0x40028D6")]
		public static int numLiquid;

		// Token: 0x04002265 RID: 8805
		[global::Cpp2ILInjected.Token(Token = "0x40028D7")]
		public static bool stuck;

		// Token: 0x04002266 RID: 8806
		[global::Cpp2ILInjected.Token(Token = "0x40028D8")]
		public static bool quickFall;

		// Token: 0x04002267 RID: 8807
		[global::Cpp2ILInjected.Token(Token = "0x40028D9")]
		public static bool quickSettle;

		// Token: 0x04002268 RID: 8808
		[global::Cpp2ILInjected.Token(Token = "0x40028DA")]
		private static int wetCounter;

		// Token: 0x04002269 RID: 8809
		[global::Cpp2ILInjected.Token(Token = "0x40028DB")]
		public static int panicCounter;

		// Token: 0x0400226A RID: 8810
		[global::Cpp2ILInjected.Token(Token = "0x40028DC")]
		public static bool panicMode;

		// Token: 0x0400226B RID: 8811
		[global::Cpp2ILInjected.Token(Token = "0x40028DD")]
		public static int panicY;

		// Token: 0x0400226C RID: 8812
		[global::Cpp2ILInjected.Token(Token = "0x40028DE")]
		public const int maxLiquidBuffer = 50000;

		// Token: 0x0400226D RID: 8813
		[global::Cpp2ILInjected.Token(Token = "0x40028DF")]
		public static int maxLiquid;

		// Token: 0x0400226E RID: 8814
		[global::Cpp2ILInjected.Token(Token = "0x40028E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int x;

		// Token: 0x0400226F RID: 8815
		[global::Cpp2ILInjected.Token(Token = "0x40028E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int y;

		// Token: 0x04002270 RID: 8816
		[global::Cpp2ILInjected.Token(Token = "0x40028E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int kill;

		// Token: 0x04002271 RID: 8817
		[global::Cpp2ILInjected.Token(Token = "0x40028E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int delay;

		// Token: 0x04002272 RID: 8818
		[global::Cpp2ILInjected.Token(Token = "0x40028E4")]
		private static HashSet<int> _netChangeSet;

		// Token: 0x04002273 RID: 8819
		[global::Cpp2ILInjected.Token(Token = "0x40028E5")]
		private static HashSet<int> _swapNetChangeSet;
	}
}