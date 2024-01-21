using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D1")]
public class NPCInfo_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x20008F7")]
	public class NPCEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008308")]
		public int npcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008309")]
		public int homeTileX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400830A")]
		public int homeTileY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400830B")]
		public bool homeless;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400830C")]
		public Vector2 position;

		[Cpp2IlInjected.Token(Token = "0x6004C74")]
		[Cpp2IlInjected.Address(RVA = "0xE41178", Offset = "0xE41178", VA = "0xE41178")]
		public NPCEntry()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032B8")]
	private bool downedAnyBoss;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40032B9")]
	private bool downedRabbit;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40032BA")]
	private bool downedTurkor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40032BB")]
	private List<NPCEntry> npcEntries;

	[Cpp2IlInjected.Token(Token = "0x6002FD9")]
	[Cpp2IlInjected.Address(RVA = "0xE403E8", Offset = "0xE403E8", VA = "0xE403E8")]
	public void LoadNPCEntries(BinaryReader reader, int release)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FDA")]
	[Cpp2IlInjected.Address(RVA = "0xE405A4", Offset = "0xE405A4", VA = "0xE405A4")]
	public void ReadNPCNames(BinaryReader reader, int release)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FDB")]
	[Cpp2IlInjected.Address(RVA = "0xE408A0", Offset = "0xE408A0", VA = "0xE408A0")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FDC")]
	[Cpp2IlInjected.Address(RVA = "0xE40EA4", Offset = "0xE40EA4", VA = "0xE40EA4")]
	public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FDD")]
	[Cpp2IlInjected.Address(RVA = "0xE410F4", Offset = "0xE410F4", VA = "0xE410F4")]
	public NPCInfo_OldMobile()
	{
	}
}
