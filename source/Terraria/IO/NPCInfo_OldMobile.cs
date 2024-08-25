using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x200056E")]
	public class NPCInfo_OldMobile
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4003E11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool downedAnyBoss;

		[global::Cpp2ILInjected.Token(Token = "0x4003E12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool downedRabbit;

		[global::Cpp2ILInjected.Token(Token = "0x4003E13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private bool downedTurkor;

		[global::Cpp2ILInjected.Token(Token = "0x4003E14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<NPCInfo_OldMobile.NPCEntry> npcEntries;

		[global::Cpp2ILInjected.Token(Token = "0x200056F")]
		public class NPCEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x60033D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1342D60", Offset = "0x1342D60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NPCEntry()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4003E15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int npcId;

			[global::Cpp2ILInjected.Token(Token = "0x4003E16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int homeTileX;

			[global::Cpp2ILInjected.Token(Token = "0x4003E17")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int homeTileY;

			[global::Cpp2ILInjected.Token(Token = "0x4003E18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public bool homeless;

			[global::Cpp2ILInjected.Token(Token = "0x4003E19")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Vector2 position;
		}
	}
}
