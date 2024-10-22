﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x20009B1")]
	public class TileDestroyedCondition : AchievementCondition
	{
		[global::Cpp2ILInjected.Token(Token = "0x600496D")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E54C", Offset = "0x82E54C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDestroyedCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(ushort[])
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private TileDestroyedCondition(LocalUser user, ushort[] tileIds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600496E")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E888", Offset = "0x82E888", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600496F")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E600", Offset = "0x82E600", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper.TileDestroyedEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "add_OnTileDestroyed", MemberParameters = new object[] { typeof(AchievementsHelper.TileDestroyedEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void ListenForDestruction(TileDestroyedCondition condition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004970")]
		[global::Cpp2ILInjected.Address(RVA = "0x82E95C", Offset = "0x82E95C", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void TileDestroyedListener(Player player, ushort tileId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004971")]
		[global::Cpp2ILInjected.Address(RVA = "0x82EB08", Offset = "0x82EB08", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDestroyedCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(ushort[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, params ushort[] tileIds)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004972")]
		[global::Cpp2ILInjected.Address(RVA = "0x82EB70", Offset = "0x82EB70", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static TileDestroyedCondition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400844F")]
		public const string Identifier = "TILE_DESTROYED";

		[global::Cpp2ILInjected.Token(Token = "0x4008450")]
		private static Dictionary<ushort, List<TileDestroyedCondition>> _listeners;

		[global::Cpp2ILInjected.Token(Token = "0x4008451")]
		private static bool _isListenerHooked;

		[global::Cpp2ILInjected.Token(Token = "0x4008452")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly LocalUser _user;

		[global::Cpp2ILInjected.Token(Token = "0x4008453")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ushort[] _tileIds;
	}
}
