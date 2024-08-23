using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000693 RID: 1683
	[global::Cpp2ILInjected.Token(Token = "0x2000A55")]
	public class MysticLogFairiesEvent
	{
		// Token: 0x06004225 RID: 16933 RVA: 0x0002DD25 File Offset: 0x0002BF25
		[global::Cpp2ILInjected.Token(Token = "0x6004E1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D15F8", Offset = "0x8D15F8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void WorldClear()
		{
			throw null;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x0002DD28 File Offset: 0x0002BF28
		[global::Cpp2ILInjected.Token(Token = "0x6004E1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1648", Offset = "0x8D1648", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void StartWorld()
		{
			throw null;
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0002DD2B File Offset: 0x0002BF2B
		[global::Cpp2ILInjected.Token(Token = "0x6004E1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1ACC", Offset = "0x8D1ACC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartNight", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MysticLogFairiesEvent), Member = "ScanWholeOverworldForLogs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void StartNight()
		{
			throw null;
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x0002DD2E File Offset: 0x0002BF2E
		[global::Cpp2ILInjected.Token(Token = "0x6004E20")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1B44", Offset = "0x8D1B44", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MysticLogFairiesEvent), Member = "IsAGoodTime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MysticLogFairiesEvent), Member = "TrySpawningFairies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void UpdateTime()
		{
			throw null;
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0002DD31 File Offset: 0x0002BF31
		[global::Cpp2ILInjected.Token(Token = "0x6004E21")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1C34", Offset = "0x8D1C34", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool IsAGoodTime()
		{
			throw null;
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0002DD34 File Offset: 0x0002BF34
		[global::Cpp2ILInjected.Token(Token = "0x6004E22")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1D0C", Offset = "0x8D1D0C", Length = "0x568")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MysticLogFairiesEvent), Member = "GetOneOverSpawnChance", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlayerLOS", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(short[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_WorldEvent), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private void TrySpawningFairies()
		{
			throw null;
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x0002DD37 File Offset: 0x0002BF37
		[global::Cpp2ILInjected.Token(Token = "0x6004E23")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D2318", Offset = "0x8D2318", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Check3x2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MysticLogFairiesEvent), Member = "ScanWholeOverworldForLogs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void FallenLogDestroyed()
		{
			throw null;
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x0002DD3A File Offset: 0x0002BF3A
		[global::Cpp2ILInjected.Token(Token = "0x6004E24")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D16B4", Offset = "0x8D16B4", Length = "0x418")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "StartNight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "FallenLogDestroyed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MysticLogFairiesEvent), Member = "GetStumpTopLeft", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void ScanWholeOverworldForLogs()
		{
			throw null;
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0002DD3D File Offset: 0x0002BF3D
		[global::Cpp2ILInjected.Token(Token = "0x6004E25")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D2384", Offset = "0x8D2384", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "ScanWholeOverworldForLogs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Point GetStumpTopLeft(Point stumpRandomPoint)
		{
			throw null;
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x0002DD40 File Offset: 0x0002BF40
		[global::Cpp2ILInjected.Token(Token = "0x6004E26")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D2274", Offset = "0x8D2274", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "TrySpawningFairies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int GetOneOverSpawnChance()
		{
			throw null;
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x0002DD43 File Offset: 0x0002BF43
		[global::Cpp2ILInjected.Token(Token = "0x6004E27")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D245C", Offset = "0x8D245C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public MysticLogFairiesEvent()
		{
			throw null;
		}

		// Token: 0x04006E04 RID: 28164
		[global::Cpp2ILInjected.Token(Token = "0x40086D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _canSpawnFairies;

		// Token: 0x04006E05 RID: 28165
		[global::Cpp2ILInjected.Token(Token = "0x40086D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _delayUntilNextAttempt;

		// Token: 0x04006E06 RID: 28166
		[global::Cpp2ILInjected.Token(Token = "0x40086D8")]
		private const int DELAY_BETWEEN_ATTEMPTS = 60;

		// Token: 0x04006E07 RID: 28167
		[global::Cpp2ILInjected.Token(Token = "0x40086D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<Point> _stumpCoords;
	}
}
