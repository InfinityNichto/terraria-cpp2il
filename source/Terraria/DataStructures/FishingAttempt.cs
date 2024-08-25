using System;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000646")]
	public struct FishingAttempt
	{
		[global::Cpp2ILInjected.Token(Token = "0x40077C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public PlayerFishingConditions playerFishingConditions;

		[global::Cpp2ILInjected.Token(Token = "0x40077C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int X;

		[global::Cpp2ILInjected.Token(Token = "0x40077C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int Y;

		[global::Cpp2ILInjected.Token(Token = "0x40077CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int bobberType;

		[global::Cpp2ILInjected.Token(Token = "0x40077CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool common;

		[global::Cpp2ILInjected.Token(Token = "0x40077CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		public bool uncommon;

		[global::Cpp2ILInjected.Token(Token = "0x40077CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		public bool rare;

		[global::Cpp2ILInjected.Token(Token = "0x40077CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x27")]
		public bool veryrare;

		[global::Cpp2ILInjected.Token(Token = "0x40077CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool legendary;

		[global::Cpp2ILInjected.Token(Token = "0x40077D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		public bool crate;

		[global::Cpp2ILInjected.Token(Token = "0x40077D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		public bool inLava;

		[global::Cpp2ILInjected.Token(Token = "0x40077D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		public bool inHoney;

		[global::Cpp2ILInjected.Token(Token = "0x40077D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int waterTilesCount;

		[global::Cpp2ILInjected.Token(Token = "0x40077D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int waterNeededToFish;

		[global::Cpp2ILInjected.Token(Token = "0x40077D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float waterQuality;

		[global::Cpp2ILInjected.Token(Token = "0x40077D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int chumsInWater;

		[global::Cpp2ILInjected.Token(Token = "0x40077D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int fishingLevel;

		[global::Cpp2ILInjected.Token(Token = "0x40077D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool CanFishInLava;

		[global::Cpp2ILInjected.Token(Token = "0x40077D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float atmo;

		[global::Cpp2ILInjected.Token(Token = "0x40077DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int questFish;

		[global::Cpp2ILInjected.Token(Token = "0x40077DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public int heightLevel;

		[global::Cpp2ILInjected.Token(Token = "0x40077DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public int rolledItemDrop;

		[global::Cpp2ILInjected.Token(Token = "0x40077DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public int rolledEnemySpawn;
	}
}
