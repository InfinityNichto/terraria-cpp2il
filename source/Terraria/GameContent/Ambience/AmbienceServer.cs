﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.NetModules;
using Terraria.Net;
using Terraria.Utilities;

namespace Terraria.GameContent.Ambience
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AFB")]
	public class AmbienceServer
	{
		[global::Cpp2ILInjected.Token(Token = "0x600523E")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B8B4", Offset = "0x93B8B4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_0", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_1", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_2", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_4", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_6", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_7", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_8", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_9", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_10", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_12", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_13", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_14", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool IsSunnyDay()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600523F")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B954", Offset = "0x93B954", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_7", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsSunset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005240")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B9E0", Offset = "0x93B9E0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_7", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_8", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_11", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_13", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<.ctor>b__10_14", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool IsCalmNight()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005241")]
		[global::Cpp2ILInjected.Address(RVA = "0x93BAB8", Offset = "0x93BAB8", Length = "0xEEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<Initialize>b__1845_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ByteEnum, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<AmbienceServer.AmbienceSpawnInfo>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "ResetSpawnTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ByteEnum, object>), Member = "set_Item", MemberParameters = new object[]
		{
			"System.ByteEnum",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 112)]
		public AmbienceServer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005242")]
		[global::Cpp2ILInjected.Address(RVA = "0x93CA34", Offset = "0x93CA34", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		private bool IsPlayerAtRightHeightForType(SkyEntityType type, Player plr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005243")]
		[global::Cpp2ILInjected.Address(RVA = "0x93CB4C", Offset = "0x93CB4C", Length = "0x57C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "SpawnForcedEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "ResetSpawnTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<, >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<ByteEnum, object>, ByteEnum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new object[] { "TSource", "TResult" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<ByteEnum, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "FindPlayerThatCanSeeBackgroundAmbience", MemberParameters = new object[] { typeof(ref Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { "System.ByteEnum" }, MemberParameters = new object[]
		{
			typeof(IEnumerable<ByteEnum>),
			typeof(Func<ByteEnum, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<TSource>",
			typeof(int)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "SpawnForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005244")]
		[global::Cpp2ILInjected.Address(RVA = "0x93C9A4", Offset = "0x93C9A4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ResetSpawnTime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005245")]
		[global::Cpp2ILInjected.Address(RVA = "0x93D51C", Offset = "0x93D51C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HandleMeteorFall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ForceEntitySpawn(AmbienceServer.AmbienceSpawnInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005246")]
		[global::Cpp2ILInjected.Address(RVA = "0x93D0D0", Offset = "0x93D0D0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<AmbienceServer.AmbienceSpawnInfo>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "FindPlayerThatCanSeeBackgroundAmbience", MemberParameters = new object[] { typeof(ref Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "SpawnForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<AmbienceServer.AmbienceSpawnInfo>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void SpawnForcedEntities()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005247")]
		[global::Cpp2ILInjected.Address(RVA = "0x93D234", Offset = "0x93D234", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "SpawnForcedEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Count", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ElementAt", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(int)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void FindPlayerThatCanSeeBackgroundAmbience(out Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005248")]
		[global::Cpp2ILInjected.Address(RVA = "0x93D5C4", Offset = "0x93D5C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbience(Player plr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005249")]
		[global::Cpp2ILInjected.Address(RVA = "0x93CAC4", Offset = "0x93CAC4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<FindPlayerThatCanSeeBackgroundAmbience>b__16_0", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<FindPlayerThatCanSeeBackgroundAmbience>b__16_1", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c__DisplayClass12_0), Member = "<Update>b__3", MemberParameters = new object[] { typeof(SkyEntityType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c__DisplayClass12_0), Member = "<Update>b__5", MemberParameters = new object[] { typeof(SkyEntityType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "IsPlayerAtRightHeightForType", MemberParameters = new object[]
		{
			typeof(SkyEntityType),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "SpawnForcedEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbience", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(Player plr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600524A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93CA4C", Offset = "0x93CA4C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<FindPlayerThatCanSeeBackgroundAmbience>b__16_0", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c), Member = "<FindPlayerThatCanSeeBackgroundAmbience>b__16_1", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c__DisplayClass12_0), Member = "<Update>b__3", MemberParameters = new object[] { typeof(SkyEntityType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer.<>c__DisplayClass12_0), Member = "<Update>b__5", MemberParameters = new object[] { typeof(SkyEntityType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "SpawnForcedEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbience", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(Player plr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600524B")]
		[global::Cpp2ILInjected.Address(RVA = "0x93D48C", Offset = "0x93D48C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "SpawnForcedEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetAmbienceModule), Member = "SerializeSkyEntitySpawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "BroadcastOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SpawnForPlayer(Player player, SkyEntityType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A83")]
		private const int MINIMUM_SECONDS_BETWEEN_SPAWNS = 10;

		[global::Cpp2ILInjected.Token(Token = "0x4008A84")]
		private const int MAXIMUM_SECONDS_BETWEEN_SPAWNS = 120;

		[global::Cpp2ILInjected.Token(Token = "0x4008A85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<SkyEntityType, Func<bool>> _spawnConditions;

		[global::Cpp2ILInjected.Token(Token = "0x4008A86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<SkyEntityType, Func<Player, bool>> _secondarySpawnConditionsPerPlayer;

		[global::Cpp2ILInjected.Token(Token = "0x4008A87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _updatesUntilNextAttempt;

		[global::Cpp2ILInjected.Token(Token = "0x4008A88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<AmbienceServer.AmbienceSpawnInfo> _forcedSpawns;

		[global::Cpp2ILInjected.Token(Token = "0x2000AFC")]
		public struct AmbienceSpawnInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008A89")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public SkyEntityType skyEntityType;

			[global::Cpp2ILInjected.Token(Token = "0x4008A8A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int targetPlayer;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000AFD")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600524C")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D5EC", Offset = "0x93D5EC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600524D")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D648", Offset = "0x93D648", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600524E")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D650", Offset = "0x93D650", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <.ctor>b__10_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600524F")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D6B8", Offset = "0x93D6B8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal bool <.ctor>b__10_1()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005250")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D758", Offset = "0x93D758", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal bool <.ctor>b__10_2()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005251")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D7F8", Offset = "0x93D7F8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <.ctor>b__10_3()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005252")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D858", Offset = "0x93D858", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_TooWindyForButterflies", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			internal bool <.ctor>b__10_4()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005253")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D948", Offset = "0x93D948", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal bool <.ctor>b__10_5()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005254")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DA18", Offset = "0x93DA18", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_6()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005255")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DA1C", Offset = "0x93DA1C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunset", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsCalmNight", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_7()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005256")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DA44", Offset = "0x93DA44", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsCalmNight", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_8()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005257")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DA64", Offset = "0x93DA64", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_9()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005258")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DA68", Offset = "0x93DA68", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal bool <.ctor>b__10_10()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005259")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB08", Offset = "0x93DB08", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsCalmNight", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_11()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600525A")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB0C", Offset = "0x93DB0C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_12()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600525B")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB10", Offset = "0x93DB10", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsCalmNight", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_13()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600525C")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB30", Offset = "0x93DB30", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsSunnyDay", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsCalmNight", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_14()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600525D")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB50", Offset = "0x93DB50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <.ctor>b__10_15()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600525E")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB58", Offset = "0x93DB58", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDesert", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_16(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600525F")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB64", Offset = "0x93DB64", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_17(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005260")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB70", Offset = "0x93DB70", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneBeach", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_18(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005261")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB7C", Offset = "0x93DB7C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_19(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005262")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB88", Offset = "0x93DB88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_20(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005263")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DB94", Offset = "0x93DB94", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_21(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005264")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DBA0", Offset = "0x93DBA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_22(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005265")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DBAC", Offset = "0x93DBAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneJungle", ReturnType = typeof(bool))]
			internal bool <.ctor>b__10_23(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005266")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DBB8", Offset = "0x93DBB8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <Update>b__12_0(KeyValuePair<SkyEntityType, Func<bool>> pair)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005267")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DBFC", Offset = "0x93DBFC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal SkyEntityType <Update>b__12_1(KeyValuePair<SkyEntityType, Func<bool>> pair)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005268")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DC38", Offset = "0x93DC38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Update>b__12_2(SkyEntityType type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005269")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DC40", Offset = "0x93DC40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Update>b__12_4(SkyEntityType type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600526A")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DC48", Offset = "0x93DC48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Update>b__12_6(SkyEntityType type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600526B")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DC50", Offset = "0x93DC50", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			internal bool <FindPlayerThatCanSeeBackgroundAmbience>b__16_0(Player plr)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600526C")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DC90", Offset = "0x93DC90", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			internal bool <FindPlayerThatCanSeeBackgroundAmbience>b__16_1(Player plr)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008A8B")]
			public static readonly AmbienceServer.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4008A8C")]
			public static Func<bool> <>9__10_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008A8D")]
			public static Func<bool> <>9__10_1;

			[global::Cpp2ILInjected.Token(Token = "0x4008A8E")]
			public static Func<bool> <>9__10_2;

			[global::Cpp2ILInjected.Token(Token = "0x4008A8F")]
			public static Func<bool> <>9__10_3;

			[global::Cpp2ILInjected.Token(Token = "0x4008A90")]
			public static Func<bool> <>9__10_4;

			[global::Cpp2ILInjected.Token(Token = "0x4008A91")]
			public static Func<bool> <>9__10_5;

			[global::Cpp2ILInjected.Token(Token = "0x4008A92")]
			public static Func<bool> <>9__10_6;

			[global::Cpp2ILInjected.Token(Token = "0x4008A93")]
			public static Func<bool> <>9__10_7;

			[global::Cpp2ILInjected.Token(Token = "0x4008A94")]
			public static Func<bool> <>9__10_8;

			[global::Cpp2ILInjected.Token(Token = "0x4008A95")]
			public static Func<bool> <>9__10_9;

			[global::Cpp2ILInjected.Token(Token = "0x4008A96")]
			public static Func<bool> <>9__10_10;

			[global::Cpp2ILInjected.Token(Token = "0x4008A97")]
			public static Func<bool> <>9__10_11;

			[global::Cpp2ILInjected.Token(Token = "0x4008A98")]
			public static Func<bool> <>9__10_12;

			[global::Cpp2ILInjected.Token(Token = "0x4008A99")]
			public static Func<bool> <>9__10_13;

			[global::Cpp2ILInjected.Token(Token = "0x4008A9A")]
			public static Func<bool> <>9__10_14;

			[global::Cpp2ILInjected.Token(Token = "0x4008A9B")]
			public static Func<bool> <>9__10_15;

			[global::Cpp2ILInjected.Token(Token = "0x4008A9C")]
			public static Func<Player, bool> <>9__10_16;

			[global::Cpp2ILInjected.Token(Token = "0x4008A9D")]
			public static Func<Player, bool> <>9__10_17;

			[global::Cpp2ILInjected.Token(Token = "0x4008A9E")]
			public static Func<Player, bool> <>9__10_18;

			[global::Cpp2ILInjected.Token(Token = "0x4008A9F")]
			public static Func<Player, bool> <>9__10_19;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA0")]
			public static Func<Player, bool> <>9__10_20;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA1")]
			public static Func<Player, bool> <>9__10_21;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA2")]
			public static Func<Player, bool> <>9__10_22;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA3")]
			public static Func<Player, bool> <>9__10_23;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA4")]
			public static Func<KeyValuePair<SkyEntityType, Func<bool>>, bool> <>9__12_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA5")]
			public static Func<KeyValuePair<SkyEntityType, Func<bool>>, SkyEntityType> <>9__12_1;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA6")]
			public static Func<SkyEntityType, bool> <>9__12_2;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA7")]
			public static Func<SkyEntityType, bool> <>9__12_4;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA8")]
			public static Func<SkyEntityType, bool> <>9__12_6;

			[global::Cpp2ILInjected.Token(Token = "0x4008AA9")]
			public static Func<Player, bool> <>9__16_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008AAA")]
			public static Func<Player, bool> <>9__16_1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000AFE")]
		private sealed class <>c__DisplayClass12_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600526D")]
			[global::Cpp2ILInjected.Address(RVA = "0x93D0C8", Offset = "0x93D0C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass12_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600526E")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DCD0", Offset = "0x93DCD0", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ByteEnum, object>), Member = "ContainsKey", MemberParameters = new object[] { "System.ByteEnum" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ByteEnum, object>), Member = "get_Item", MemberParameters = new object[] { "System.ByteEnum" }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <Update>b__3(SkyEntityType type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600526F")]
			[global::Cpp2ILInjected.Address(RVA = "0x93DD9C", Offset = "0x93DD9C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbienceServer), Member = "IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ByteEnum, object>), Member = "ContainsKey", MemberParameters = new object[] { "System.ByteEnum" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ByteEnum, object>), Member = "get_Item", MemberParameters = new object[] { "System.ByteEnum" }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <Update>b__5(SkyEntityType type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008AAB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public AmbienceServer <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4008AAC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Player player;
		}
	}
}
