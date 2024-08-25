using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000674")]
	public class AnchoredEntitiesCollection
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006A9")]
		public int AnchoredPlayersAmount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003730")]
			[global::Cpp2ILInjected.Address(RVA = "0x141DF40", Offset = "0x141DF40", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003731")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DF80", Offset = "0x141DF80", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<AnchoredEntitiesCollection.IndexPointPair>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public AnchoredEntitiesCollection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003732")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E018", Offset = "0x141E018", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearNPCAnchors()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003733")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E060", Offset = "0x141E060", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearPlayerAnchors()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003734")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E0A8", Offset = "0x141E0A8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddNPC(int npcIndex, Point coords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003735")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E168", Offset = "0x141E168", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "UpdateSitting", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "SitDown", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSleepingHelper), Member = "UpdateState", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSleepingHelper), Member = "StartSleeping", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public int GetNextPlayerStackIndexInCoords(Point coords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003736")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E2D0", Offset = "0x141E2D0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "UpdateSitting", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "SitDown", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSleepingHelper), Member = "UpdateState", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSleepingHelper), Member = "StartSleeping", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnchoredEntitiesCollection), Member = "GetEntitiesInCoords", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddPlayerAndGetItsStackedIndexInCoords(int playerIndex, Point coords, out int stackedIndexInCoords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003737")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E16C", Offset = "0x141E16C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnchoredEntitiesCollection), Member = "AddPlayerAndGetItsStackedIndexInCoords", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<AnchoredEntitiesCollection.IndexPointPair>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int GetEntitiesInCoords(Point coords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007825")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredNPCs;

		[global::Cpp2ILInjected.Token(Token = "0x4007826")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredPlayers;

		[global::Cpp2ILInjected.Token(Token = "0x2000675")]
		private struct IndexPointPair
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007827")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int index;

			[global::Cpp2ILInjected.Token(Token = "0x4007828")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public Point coords;
		}
	}
}
