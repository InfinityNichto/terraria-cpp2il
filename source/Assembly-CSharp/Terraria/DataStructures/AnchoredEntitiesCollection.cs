using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent;

namespace Terraria.DataStructures
{
	// Token: 0x02000474 RID: 1140
	[global::Cpp2ILInjected.Token(Token = "0x2000674")]
	public class AnchoredEntitiesCollection
	{
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x0002AF35 File Offset: 0x00029135
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

		// Token: 0x0600320B RID: 12811 RVA: 0x0002AF38 File Offset: 0x00029138
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

		// Token: 0x0600320C RID: 12812 RVA: 0x0002AF3B File Offset: 0x0002913B
		[global::Cpp2ILInjected.Token(Token = "0x6003732")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E018", Offset = "0x141E018", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearNPCAnchors()
		{
			throw null;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0002AF3E File Offset: 0x0002913E
		[global::Cpp2ILInjected.Token(Token = "0x6003733")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E060", Offset = "0x141E060", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearPlayerAnchors()
		{
			throw null;
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0002AF41 File Offset: 0x00029141
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

		// Token: 0x0600320F RID: 12815 RVA: 0x0002AF44 File Offset: 0x00029144
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

		// Token: 0x06003210 RID: 12816 RVA: 0x0002AF47 File Offset: 0x00029147
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

		// Token: 0x06003211 RID: 12817 RVA: 0x0002AF4A File Offset: 0x0002914A
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

		// Token: 0x0400642E RID: 25646
		[global::Cpp2ILInjected.Token(Token = "0x4007825")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredNPCs;

		// Token: 0x0400642F RID: 25647
		[global::Cpp2ILInjected.Token(Token = "0x4007826")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredPlayers;

		// Token: 0x02000935 RID: 2357
		[global::Cpp2ILInjected.Token(Token = "0x2000675")]
		private struct IndexPointPair
		{
			// Token: 0x04008AD6 RID: 35542
			[global::Cpp2ILInjected.Token(Token = "0x4007827")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04008AD7 RID: 35543
			[global::Cpp2ILInjected.Token(Token = "0x4007828")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public Point coords;
		}
	}
}
