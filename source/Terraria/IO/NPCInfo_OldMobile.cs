using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.IO
{
	// Token: 0x020003C5 RID: 965
	[global::Cpp2ILInjected.Token(Token = "0x200056E")]
	public class NPCInfo_OldMobile
	{
		// Token: 0x06002F64 RID: 12132 RVA: 0x0002A776 File Offset: 0x00028976
		[global::Cpp2ILInjected.Token(Token = "0x60033CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1342130", Offset = "0x1342130", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void LoadNPCEntries(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x0002A779 File Offset: 0x00028979
		[global::Cpp2ILInjected.Token(Token = "0x60033D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13422E8", Offset = "0x13422E8", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "setNPCName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "getNewNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ReadNPCNames(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x0002A77C File Offset: 0x0002897C
		[global::Cpp2ILInjected.Token(Token = "0x60033D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x13425B0", Offset = "0x13425B0", Length = "0x518")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x0002A77F File Offset: 0x0002897F
		[global::Cpp2ILInjected.Token(Token = "0x60033D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1342AC8", Offset = "0x1342AC8", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldDataMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x0002A782 File Offset: 0x00028982
		[global::Cpp2ILInjected.Token(Token = "0x60033D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1342CE4", Offset = "0x1342CE4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public NPCInfo_OldMobile()
		{
			throw null;
		}

		// Token: 0x040032B6 RID: 12982
		[global::Cpp2ILInjected.Token(Token = "0x4003E11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool downedAnyBoss;

		// Token: 0x040032B7 RID: 12983
		[global::Cpp2ILInjected.Token(Token = "0x4003E12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool downedRabbit;

		// Token: 0x040032B8 RID: 12984
		[global::Cpp2ILInjected.Token(Token = "0x4003E13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private bool downedTurkor;

		// Token: 0x040032B9 RID: 12985
		[global::Cpp2ILInjected.Token(Token = "0x4003E14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<NPCInfo_OldMobile.NPCEntry> npcEntries;

		// Token: 0x020008F9 RID: 2297
		[global::Cpp2ILInjected.Token(Token = "0x200056F")]
		public class NPCEntry
		{
			// Token: 0x06004C16 RID: 19478 RVA: 0x0002F76B File Offset: 0x0002D96B
			[global::Cpp2ILInjected.Token(Token = "0x60033D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1342D60", Offset = "0x1342D60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NPCEntry()
			{
				throw null;
			}

			// Token: 0x040082FE RID: 33534
			[global::Cpp2ILInjected.Token(Token = "0x4003E15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int npcId;

			// Token: 0x040082FF RID: 33535
			[global::Cpp2ILInjected.Token(Token = "0x4003E16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int homeTileX;

			// Token: 0x04008300 RID: 33536
			[global::Cpp2ILInjected.Token(Token = "0x4003E17")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int homeTileY;

			// Token: 0x04008301 RID: 33537
			[global::Cpp2ILInjected.Token(Token = "0x4003E18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public bool homeless;

			// Token: 0x04008302 RID: 33538
			[global::Cpp2ILInjected.Token(Token = "0x4003E19")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Vector2 position;
		}
	}
}
