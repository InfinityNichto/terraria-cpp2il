using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;
using Terraria.IO;
using Terraria.Localization;

namespace Terraria.ID
{
	// Token: 0x020003EF RID: 1007
	[global::Cpp2ILInjected.Token(Token = "0x20005D1")]
	public class ItemID
	{
		// Token: 0x06003058 RID: 12376 RVA: 0x0002AA52 File Offset: 0x00028C52
		[global::Cpp2ILInjected.Token(Token = "0x600354F")]
		[global::Cpp2ILInjected.Address(RVA = "0x138E74C", Offset = "0x138E74C", Length = "0x6654")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID), Member = "FromLegacyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, short>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, short>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 655)]
		private static Dictionary<string, short> GenerateLegacyItemDictionary()
		{
			throw null;
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x0002AA55 File Offset: 0x00028C55
		[global::Cpp2ILInjected.Token(Token = "0x6003550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1394DA0", Offset = "0x1394DA0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetItemName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static short FromNetId(short id)
		{
			throw null;
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x0002AA58 File Offset: 0x00028C58
		[global::Cpp2ILInjected.Token(Token = "0x6003551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1394F44", Offset = "0x1394F44", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldSwitch), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemID), Member = "GenerateLegacyItemDictionary", ReturnType = typeof(Dictionary<string, short>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, short>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public static short FromLegacyName(string name, int release)
		{
			throw null;
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0002AA5B File Offset: 0x00028C5B
		[global::Cpp2ILInjected.Token(Token = "0x6003552")]
		[global::Cpp2ILInjected.Address(RVA = "0x139533C", Offset = "0x139533C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemID()
		{
			throw null;
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0002AA5E File Offset: 0x00028C5E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003553")]
		[global::Cpp2ILInjected.Address(RVA = "0x1395344", Offset = "0x1395344", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "Create", MemberTypeParameters = new object[] { "IdClass", "IdType" }, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ItemID()
		{
			throw null;
		}

		// Token: 0x04003BB9 RID: 15289
		[global::Cpp2ILInjected.Token(Token = "0x4004E05")]
		private static Dictionary<string, short> _legacyItemLookup;

		// Token: 0x04003BBA RID: 15290
		[global::Cpp2ILInjected.Token(Token = "0x4004E06")]
		public const short YellowPhasesaberOld = -24;

		// Token: 0x04003BBB RID: 15291
		[global::Cpp2ILInjected.Token(Token = "0x4004E07")]
		public const short WhitePhasesaberOld = -23;

		// Token: 0x04003BBC RID: 15292
		[global::Cpp2ILInjected.Token(Token = "0x4004E08")]
		public const short PurplePhasesaberOld = -22;

		// Token: 0x04003BBD RID: 15293
		[global::Cpp2ILInjected.Token(Token = "0x4004E09")]
		public const short GreenPhasesaberOld = -21;

		// Token: 0x04003BBE RID: 15294
		[global::Cpp2ILInjected.Token(Token = "0x4004E0A")]
		public const short RedPhasesaberOld = -20;

		// Token: 0x04003BBF RID: 15295
		[global::Cpp2ILInjected.Token(Token = "0x4004E0B")]
		public const short BluePhasesaberOld = -19;

		// Token: 0x04003BC0 RID: 15296
		[global::Cpp2ILInjected.Token(Token = "0x4004E0C")]
		public const short PlatinumBowOld = -48;

		// Token: 0x04003BC1 RID: 15297
		[global::Cpp2ILInjected.Token(Token = "0x4004E0D")]
		public const short PlatinumHammerOld = -47;

		// Token: 0x04003BC2 RID: 15298
		[global::Cpp2ILInjected.Token(Token = "0x4004E0E")]
		public const short PlatinumAxeOld = -46;

		// Token: 0x04003BC3 RID: 15299
		[global::Cpp2ILInjected.Token(Token = "0x4004E0F")]
		public const short PlatinumShortswordOld = -45;

		// Token: 0x04003BC4 RID: 15300
		[global::Cpp2ILInjected.Token(Token = "0x4004E10")]
		public const short PlatinumBroadswordOld = -44;

		// Token: 0x04003BC5 RID: 15301
		[global::Cpp2ILInjected.Token(Token = "0x4004E11")]
		public const short PlatinumPickaxeOld = -43;

		// Token: 0x04003BC6 RID: 15302
		[global::Cpp2ILInjected.Token(Token = "0x4004E12")]
		public const short TungstenBowOld = -42;

		// Token: 0x04003BC7 RID: 15303
		[global::Cpp2ILInjected.Token(Token = "0x4004E13")]
		public const short TungstenHammerOld = -41;

		// Token: 0x04003BC8 RID: 15304
		[global::Cpp2ILInjected.Token(Token = "0x4004E14")]
		public const short TungstenAxeOld = -40;

		// Token: 0x04003BC9 RID: 15305
		[global::Cpp2ILInjected.Token(Token = "0x4004E15")]
		public const short TungstenShortswordOld = -39;

		// Token: 0x04003BCA RID: 15306
		[global::Cpp2ILInjected.Token(Token = "0x4004E16")]
		public const short TungstenBroadswordOld = -38;

		// Token: 0x04003BCB RID: 15307
		[global::Cpp2ILInjected.Token(Token = "0x4004E17")]
		public const short TungstenPickaxeOld = -37;

		// Token: 0x04003BCC RID: 15308
		[global::Cpp2ILInjected.Token(Token = "0x4004E18")]
		public const short LeadBowOld = -36;

		// Token: 0x04003BCD RID: 15309
		[global::Cpp2ILInjected.Token(Token = "0x4004E19")]
		public const short LeadHammerOld = -35;

		// Token: 0x04003BCE RID: 15310
		[global::Cpp2ILInjected.Token(Token = "0x4004E1A")]
		public const short LeadAxeOld = -34;

		// Token: 0x04003BCF RID: 15311
		[global::Cpp2ILInjected.Token(Token = "0x4004E1B")]
		public const short LeadShortswordOld = -33;

		// Token: 0x04003BD0 RID: 15312
		[global::Cpp2ILInjected.Token(Token = "0x4004E1C")]
		public const short LeadBroadswordOld = -32;

		// Token: 0x04003BD1 RID: 15313
		[global::Cpp2ILInjected.Token(Token = "0x4004E1D")]
		public const short LeadPickaxeOld = -31;

		// Token: 0x04003BD2 RID: 15314
		[global::Cpp2ILInjected.Token(Token = "0x4004E1E")]
		public const short TinBowOld = -30;

		// Token: 0x04003BD3 RID: 15315
		[global::Cpp2ILInjected.Token(Token = "0x4004E1F")]
		public const short TinHammerOld = -29;

		// Token: 0x04003BD4 RID: 15316
		[global::Cpp2ILInjected.Token(Token = "0x4004E20")]
		public const short TinAxeOld = -28;

		// Token: 0x04003BD5 RID: 15317
		[global::Cpp2ILInjected.Token(Token = "0x4004E21")]
		public const short TinShortswordOld = -27;

		// Token: 0x04003BD6 RID: 15318
		[global::Cpp2ILInjected.Token(Token = "0x4004E22")]
		public const short TinBroadswordOld = -26;

		// Token: 0x04003BD7 RID: 15319
		[global::Cpp2ILInjected.Token(Token = "0x4004E23")]
		public const short TinPickaxeOld = -25;

		// Token: 0x04003BD8 RID: 15320
		[global::Cpp2ILInjected.Token(Token = "0x4004E24")]
		public const short CopperBowOld = -18;

		// Token: 0x04003BD9 RID: 15321
		[global::Cpp2ILInjected.Token(Token = "0x4004E25")]
		public const short CopperHammerOld = -17;

		// Token: 0x04003BDA RID: 15322
		[global::Cpp2ILInjected.Token(Token = "0x4004E26")]
		public const short CopperAxeOld = -16;

		// Token: 0x04003BDB RID: 15323
		[global::Cpp2ILInjected.Token(Token = "0x4004E27")]
		public const short CopperShortswordOld = -15;

		// Token: 0x04003BDC RID: 15324
		[global::Cpp2ILInjected.Token(Token = "0x4004E28")]
		public const short CopperBroadswordOld = -14;

		// Token: 0x04003BDD RID: 15325
		[global::Cpp2ILInjected.Token(Token = "0x4004E29")]
		public const short CopperPickaxeOld = -13;

		// Token: 0x04003BDE RID: 15326
		[global::Cpp2ILInjected.Token(Token = "0x4004E2A")]
		public const short SilverBowOld = -12;

		// Token: 0x04003BDF RID: 15327
		[global::Cpp2ILInjected.Token(Token = "0x4004E2B")]
		public const short SilverHammerOld = -11;

		// Token: 0x04003BE0 RID: 15328
		[global::Cpp2ILInjected.Token(Token = "0x4004E2C")]
		public const short SilverAxeOld = -10;

		// Token: 0x04003BE1 RID: 15329
		[global::Cpp2ILInjected.Token(Token = "0x4004E2D")]
		public const short SilverShortswordOld = -9;

		// Token: 0x04003BE2 RID: 15330
		[global::Cpp2ILInjected.Token(Token = "0x4004E2E")]
		public const short SilverBroadswordOld = -8;

		// Token: 0x04003BE3 RID: 15331
		[global::Cpp2ILInjected.Token(Token = "0x4004E2F")]
		public const short SilverPickaxeOld = -7;

		// Token: 0x04003BE4 RID: 15332
		[global::Cpp2ILInjected.Token(Token = "0x4004E30")]
		public const short GoldBowOld = -6;

		// Token: 0x04003BE5 RID: 15333
		[global::Cpp2ILInjected.Token(Token = "0x4004E31")]
		public const short GoldHammerOld = -5;

		// Token: 0x04003BE6 RID: 15334
		[global::Cpp2ILInjected.Token(Token = "0x4004E32")]
		public const short GoldAxeOld = -4;

		// Token: 0x04003BE7 RID: 15335
		[global::Cpp2ILInjected.Token(Token = "0x4004E33")]
		public const short GoldShortswordOld = -3;

		// Token: 0x04003BE8 RID: 15336
		[global::Cpp2ILInjected.Token(Token = "0x4004E34")]
		public const short GoldBroadswordOld = -2;

		// Token: 0x04003BE9 RID: 15337
		[global::Cpp2ILInjected.Token(Token = "0x4004E35")]
		public const short GoldPickaxeOld = -1;

		// Token: 0x04003BEA RID: 15338
		[global::Cpp2ILInjected.Token(Token = "0x4004E36")]
		public const short None = 0;

		// Token: 0x04003BEB RID: 15339
		[global::Cpp2ILInjected.Token(Token = "0x4004E37")]
		public const short IronPickaxe = 1;

		// Token: 0x04003BEC RID: 15340
		[global::Cpp2ILInjected.Token(Token = "0x4004E38")]
		public const short DirtBlock = 2;

		// Token: 0x04003BED RID: 15341
		[global::Cpp2ILInjected.Token(Token = "0x4004E39")]
		public const short StoneBlock = 3;

		// Token: 0x04003BEE RID: 15342
		[global::Cpp2ILInjected.Token(Token = "0x4004E3A")]
		public const short IronBroadsword = 4;

		// Token: 0x04003BEF RID: 15343
		[global::Cpp2ILInjected.Token(Token = "0x4004E3B")]
		public const short Mushroom = 5;

		// Token: 0x04003BF0 RID: 15344
		[global::Cpp2ILInjected.Token(Token = "0x4004E3C")]
		public const short IronShortsword = 6;

		// Token: 0x04003BF1 RID: 15345
		[global::Cpp2ILInjected.Token(Token = "0x4004E3D")]
		public const short IronHammer = 7;

		// Token: 0x04003BF2 RID: 15346
		[global::Cpp2ILInjected.Token(Token = "0x4004E3E")]
		public const short Torch = 8;

		// Token: 0x04003BF3 RID: 15347
		[global::Cpp2ILInjected.Token(Token = "0x4004E3F")]
		public const short Wood = 9;

		// Token: 0x04003BF4 RID: 15348
		[global::Cpp2ILInjected.Token(Token = "0x4004E40")]
		public const short IronAxe = 10;

		// Token: 0x04003BF5 RID: 15349
		[global::Cpp2ILInjected.Token(Token = "0x4004E41")]
		public const short IronOre = 11;

		// Token: 0x04003BF6 RID: 15350
		[global::Cpp2ILInjected.Token(Token = "0x4004E42")]
		public const short CopperOre = 12;

		// Token: 0x04003BF7 RID: 15351
		[global::Cpp2ILInjected.Token(Token = "0x4004E43")]
		public const short GoldOre = 13;

		// Token: 0x04003BF8 RID: 15352
		[global::Cpp2ILInjected.Token(Token = "0x4004E44")]
		public const short SilverOre = 14;

		// Token: 0x04003BF9 RID: 15353
		[global::Cpp2ILInjected.Token(Token = "0x4004E45")]
		public const short CopperWatch = 15;

		// Token: 0x04003BFA RID: 15354
		[global::Cpp2ILInjected.Token(Token = "0x4004E46")]
		public const short SilverWatch = 16;

		// Token: 0x04003BFB RID: 15355
		[global::Cpp2ILInjected.Token(Token = "0x4004E47")]
		public const short GoldWatch = 17;

		// Token: 0x04003BFC RID: 15356
		[global::Cpp2ILInjected.Token(Token = "0x4004E48")]
		public const short DepthMeter = 18;

		// Token: 0x04003BFD RID: 15357
		[global::Cpp2ILInjected.Token(Token = "0x4004E49")]
		public const short GoldBar = 19;

		// Token: 0x04003BFE RID: 15358
		[global::Cpp2ILInjected.Token(Token = "0x4004E4A")]
		public const short CopperBar = 20;

		// Token: 0x04003BFF RID: 15359
		[global::Cpp2ILInjected.Token(Token = "0x4004E4B")]
		public const short SilverBar = 21;

		// Token: 0x04003C00 RID: 15360
		[global::Cpp2ILInjected.Token(Token = "0x4004E4C")]
		public const short IronBar = 22;

		// Token: 0x04003C01 RID: 15361
		[global::Cpp2ILInjected.Token(Token = "0x4004E4D")]
		public const short Gel = 23;

		// Token: 0x04003C02 RID: 15362
		[global::Cpp2ILInjected.Token(Token = "0x4004E4E")]
		public const short WoodenSword = 24;

		// Token: 0x04003C03 RID: 15363
		[global::Cpp2ILInjected.Token(Token = "0x4004E4F")]
		public const short WoodenDoor = 25;

		// Token: 0x04003C04 RID: 15364
		[global::Cpp2ILInjected.Token(Token = "0x4004E50")]
		public const short StoneWall = 26;

		// Token: 0x04003C05 RID: 15365
		[global::Cpp2ILInjected.Token(Token = "0x4004E51")]
		public const short Acorn = 27;

		// Token: 0x04003C06 RID: 15366
		[global::Cpp2ILInjected.Token(Token = "0x4004E52")]
		public const short LesserHealingPotion = 28;

		// Token: 0x04003C07 RID: 15367
		[global::Cpp2ILInjected.Token(Token = "0x4004E53")]
		public const short LifeCrystal = 29;

		// Token: 0x04003C08 RID: 15368
		[global::Cpp2ILInjected.Token(Token = "0x4004E54")]
		public const short DirtWall = 30;

		// Token: 0x04003C09 RID: 15369
		[global::Cpp2ILInjected.Token(Token = "0x4004E55")]
		public const short Bottle = 31;

		// Token: 0x04003C0A RID: 15370
		[global::Cpp2ILInjected.Token(Token = "0x4004E56")]
		public const short WoodenTable = 32;

		// Token: 0x04003C0B RID: 15371
		[global::Cpp2ILInjected.Token(Token = "0x4004E57")]
		public const short Furnace = 33;

		// Token: 0x04003C0C RID: 15372
		[global::Cpp2ILInjected.Token(Token = "0x4004E58")]
		public const short WoodenChair = 34;

		// Token: 0x04003C0D RID: 15373
		[global::Cpp2ILInjected.Token(Token = "0x4004E59")]
		public const short IronAnvil = 35;

		// Token: 0x04003C0E RID: 15374
		[global::Cpp2ILInjected.Token(Token = "0x4004E5A")]
		public const short WorkBench = 36;

		// Token: 0x04003C0F RID: 15375
		[global::Cpp2ILInjected.Token(Token = "0x4004E5B")]
		public const short Goggles = 37;

		// Token: 0x04003C10 RID: 15376
		[global::Cpp2ILInjected.Token(Token = "0x4004E5C")]
		public const short Lens = 38;

		// Token: 0x04003C11 RID: 15377
		[global::Cpp2ILInjected.Token(Token = "0x4004E5D")]
		public const short WoodenBow = 39;

		// Token: 0x04003C12 RID: 15378
		[global::Cpp2ILInjected.Token(Token = "0x4004E5E")]
		public const short WoodenArrow = 40;

		// Token: 0x04003C13 RID: 15379
		[global::Cpp2ILInjected.Token(Token = "0x4004E5F")]
		public const short FlamingArrow = 41;

		// Token: 0x04003C14 RID: 15380
		[global::Cpp2ILInjected.Token(Token = "0x4004E60")]
		public const short Shuriken = 42;

		// Token: 0x04003C15 RID: 15381
		[global::Cpp2ILInjected.Token(Token = "0x4004E61")]
		public const short SuspiciousLookingEye = 43;

		// Token: 0x04003C16 RID: 15382
		[global::Cpp2ILInjected.Token(Token = "0x4004E62")]
		public const short DemonBow = 44;

		// Token: 0x04003C17 RID: 15383
		[global::Cpp2ILInjected.Token(Token = "0x4004E63")]
		public const short WarAxeoftheNight = 45;

		// Token: 0x04003C18 RID: 15384
		[global::Cpp2ILInjected.Token(Token = "0x4004E64")]
		public const short LightsBane = 46;

		// Token: 0x04003C19 RID: 15385
		[global::Cpp2ILInjected.Token(Token = "0x4004E65")]
		public const short UnholyArrow = 47;

		// Token: 0x04003C1A RID: 15386
		[global::Cpp2ILInjected.Token(Token = "0x4004E66")]
		public const short Chest = 48;

		// Token: 0x04003C1B RID: 15387
		[global::Cpp2ILInjected.Token(Token = "0x4004E67")]
		public const short BandofRegeneration = 49;

		// Token: 0x04003C1C RID: 15388
		[global::Cpp2ILInjected.Token(Token = "0x4004E68")]
		public const short MagicMirror = 50;

		// Token: 0x04003C1D RID: 15389
		[global::Cpp2ILInjected.Token(Token = "0x4004E69")]
		public const short JestersArrow = 51;

		// Token: 0x04003C1E RID: 15390
		[global::Cpp2ILInjected.Token(Token = "0x4004E6A")]
		public const short AngelStatue = 52;

		// Token: 0x04003C1F RID: 15391
		[global::Cpp2ILInjected.Token(Token = "0x4004E6B")]
		public const short CloudinaBottle = 53;

		// Token: 0x04003C20 RID: 15392
		[global::Cpp2ILInjected.Token(Token = "0x4004E6C")]
		public const short HermesBoots = 54;

		// Token: 0x04003C21 RID: 15393
		[global::Cpp2ILInjected.Token(Token = "0x4004E6D")]
		public const short EnchantedBoomerang = 55;

		// Token: 0x04003C22 RID: 15394
		[global::Cpp2ILInjected.Token(Token = "0x4004E6E")]
		public const short DemoniteOre = 56;

		// Token: 0x04003C23 RID: 15395
		[global::Cpp2ILInjected.Token(Token = "0x4004E6F")]
		public const short DemoniteBar = 57;

		// Token: 0x04003C24 RID: 15396
		[global::Cpp2ILInjected.Token(Token = "0x4004E70")]
		public const short Heart = 58;

		// Token: 0x04003C25 RID: 15397
		[global::Cpp2ILInjected.Token(Token = "0x4004E71")]
		public const short CorruptSeeds = 59;

		// Token: 0x04003C26 RID: 15398
		[global::Cpp2ILInjected.Token(Token = "0x4004E72")]
		public const short VileMushroom = 60;

		// Token: 0x04003C27 RID: 15399
		[global::Cpp2ILInjected.Token(Token = "0x4004E73")]
		public const short EbonstoneBlock = 61;

		// Token: 0x04003C28 RID: 15400
		[global::Cpp2ILInjected.Token(Token = "0x4004E74")]
		public const short GrassSeeds = 62;

		// Token: 0x04003C29 RID: 15401
		[global::Cpp2ILInjected.Token(Token = "0x4004E75")]
		public const short Sunflower = 63;

		// Token: 0x04003C2A RID: 15402
		[global::Cpp2ILInjected.Token(Token = "0x4004E76")]
		public const short Vilethorn = 64;

		// Token: 0x04003C2B RID: 15403
		[global::Cpp2ILInjected.Token(Token = "0x4004E77")]
		public const short Starfury = 65;

		// Token: 0x04003C2C RID: 15404
		[global::Cpp2ILInjected.Token(Token = "0x4004E78")]
		public const short PurificationPowder = 66;

		// Token: 0x04003C2D RID: 15405
		[global::Cpp2ILInjected.Token(Token = "0x4004E79")]
		public const short VilePowder = 67;

		// Token: 0x04003C2E RID: 15406
		[global::Cpp2ILInjected.Token(Token = "0x4004E7A")]
		public const short RottenChunk = 68;

		// Token: 0x04003C2F RID: 15407
		[global::Cpp2ILInjected.Token(Token = "0x4004E7B")]
		public const short WormTooth = 69;

		// Token: 0x04003C30 RID: 15408
		[global::Cpp2ILInjected.Token(Token = "0x4004E7C")]
		public const short WormFood = 70;

		// Token: 0x04003C31 RID: 15409
		[global::Cpp2ILInjected.Token(Token = "0x4004E7D")]
		public const short CopperCoin = 71;

		// Token: 0x04003C32 RID: 15410
		[global::Cpp2ILInjected.Token(Token = "0x4004E7E")]
		public const short SilverCoin = 72;

		// Token: 0x04003C33 RID: 15411
		[global::Cpp2ILInjected.Token(Token = "0x4004E7F")]
		public const short GoldCoin = 73;

		// Token: 0x04003C34 RID: 15412
		[global::Cpp2ILInjected.Token(Token = "0x4004E80")]
		public const short PlatinumCoin = 74;

		// Token: 0x04003C35 RID: 15413
		[global::Cpp2ILInjected.Token(Token = "0x4004E81")]
		public const short FallenStar = 75;

		// Token: 0x04003C36 RID: 15414
		[global::Cpp2ILInjected.Token(Token = "0x4004E82")]
		public const short CopperGreaves = 76;

		// Token: 0x04003C37 RID: 15415
		[global::Cpp2ILInjected.Token(Token = "0x4004E83")]
		public const short IronGreaves = 77;

		// Token: 0x04003C38 RID: 15416
		[global::Cpp2ILInjected.Token(Token = "0x4004E84")]
		public const short SilverGreaves = 78;

		// Token: 0x04003C39 RID: 15417
		[global::Cpp2ILInjected.Token(Token = "0x4004E85")]
		public const short GoldGreaves = 79;

		// Token: 0x04003C3A RID: 15418
		[global::Cpp2ILInjected.Token(Token = "0x4004E86")]
		public const short CopperChainmail = 80;

		// Token: 0x04003C3B RID: 15419
		[global::Cpp2ILInjected.Token(Token = "0x4004E87")]
		public const short IronChainmail = 81;

		// Token: 0x04003C3C RID: 15420
		[global::Cpp2ILInjected.Token(Token = "0x4004E88")]
		public const short SilverChainmail = 82;

		// Token: 0x04003C3D RID: 15421
		[global::Cpp2ILInjected.Token(Token = "0x4004E89")]
		public const short GoldChainmail = 83;

		// Token: 0x04003C3E RID: 15422
		[global::Cpp2ILInjected.Token(Token = "0x4004E8A")]
		public const short GrapplingHook = 84;

		// Token: 0x04003C3F RID: 15423
		[global::Cpp2ILInjected.Token(Token = "0x4004E8B")]
		public const short Chain = 85;

		// Token: 0x04003C40 RID: 15424
		[global::Cpp2ILInjected.Token(Token = "0x4004E8C")]
		public const short ShadowScale = 86;

		// Token: 0x04003C41 RID: 15425
		[global::Cpp2ILInjected.Token(Token = "0x4004E8D")]
		public const short PiggyBank = 87;

		// Token: 0x04003C42 RID: 15426
		[global::Cpp2ILInjected.Token(Token = "0x4004E8E")]
		public const short MiningHelmet = 88;

		// Token: 0x04003C43 RID: 15427
		[global::Cpp2ILInjected.Token(Token = "0x4004E8F")]
		public const short CopperHelmet = 89;

		// Token: 0x04003C44 RID: 15428
		[global::Cpp2ILInjected.Token(Token = "0x4004E90")]
		public const short IronHelmet = 90;

		// Token: 0x04003C45 RID: 15429
		[global::Cpp2ILInjected.Token(Token = "0x4004E91")]
		public const short SilverHelmet = 91;

		// Token: 0x04003C46 RID: 15430
		[global::Cpp2ILInjected.Token(Token = "0x4004E92")]
		public const short GoldHelmet = 92;

		// Token: 0x04003C47 RID: 15431
		[global::Cpp2ILInjected.Token(Token = "0x4004E93")]
		public const short WoodWall = 93;

		// Token: 0x04003C48 RID: 15432
		[global::Cpp2ILInjected.Token(Token = "0x4004E94")]
		public const short WoodPlatform = 94;

		// Token: 0x04003C49 RID: 15433
		[global::Cpp2ILInjected.Token(Token = "0x4004E95")]
		public const short FlintlockPistol = 95;

		// Token: 0x04003C4A RID: 15434
		[global::Cpp2ILInjected.Token(Token = "0x4004E96")]
		public const short Musket = 96;

		// Token: 0x04003C4B RID: 15435
		[global::Cpp2ILInjected.Token(Token = "0x4004E97")]
		public const short MusketBall = 97;

		// Token: 0x04003C4C RID: 15436
		[global::Cpp2ILInjected.Token(Token = "0x4004E98")]
		public const short Minishark = 98;

		// Token: 0x04003C4D RID: 15437
		[global::Cpp2ILInjected.Token(Token = "0x4004E99")]
		public const short IronBow = 99;

		// Token: 0x04003C4E RID: 15438
		[global::Cpp2ILInjected.Token(Token = "0x4004E9A")]
		public const short ShadowGreaves = 100;

		// Token: 0x04003C4F RID: 15439
		[global::Cpp2ILInjected.Token(Token = "0x4004E9B")]
		public const short ShadowScalemail = 101;

		// Token: 0x04003C50 RID: 15440
		[global::Cpp2ILInjected.Token(Token = "0x4004E9C")]
		public const short ShadowHelmet = 102;

		// Token: 0x04003C51 RID: 15441
		[global::Cpp2ILInjected.Token(Token = "0x4004E9D")]
		public const short NightmarePickaxe = 103;

		// Token: 0x04003C52 RID: 15442
		[global::Cpp2ILInjected.Token(Token = "0x4004E9E")]
		public const short TheBreaker = 104;

		// Token: 0x04003C53 RID: 15443
		[global::Cpp2ILInjected.Token(Token = "0x4004E9F")]
		public const short Candle = 105;

		// Token: 0x04003C54 RID: 15444
		[global::Cpp2ILInjected.Token(Token = "0x4004EA0")]
		public const short CopperChandelier = 106;

		// Token: 0x04003C55 RID: 15445
		[global::Cpp2ILInjected.Token(Token = "0x4004EA1")]
		public const short SilverChandelier = 107;

		// Token: 0x04003C56 RID: 15446
		[global::Cpp2ILInjected.Token(Token = "0x4004EA2")]
		public const short GoldChandelier = 108;

		// Token: 0x04003C57 RID: 15447
		[global::Cpp2ILInjected.Token(Token = "0x4004EA3")]
		public const short ManaCrystal = 109;

		// Token: 0x04003C58 RID: 15448
		[global::Cpp2ILInjected.Token(Token = "0x4004EA4")]
		public const short LesserManaPotion = 110;

		// Token: 0x04003C59 RID: 15449
		[global::Cpp2ILInjected.Token(Token = "0x4004EA5")]
		public const short BandofStarpower = 111;

		// Token: 0x04003C5A RID: 15450
		[global::Cpp2ILInjected.Token(Token = "0x4004EA6")]
		public const short FlowerofFire = 112;

		// Token: 0x04003C5B RID: 15451
		[global::Cpp2ILInjected.Token(Token = "0x4004EA7")]
		public const short MagicMissile = 113;

		// Token: 0x04003C5C RID: 15452
		[global::Cpp2ILInjected.Token(Token = "0x4004EA8")]
		public const short DirtRod = 114;

		// Token: 0x04003C5D RID: 15453
		[global::Cpp2ILInjected.Token(Token = "0x4004EA9")]
		public const short ShadowOrb = 115;

		// Token: 0x04003C5E RID: 15454
		[global::Cpp2ILInjected.Token(Token = "0x4004EAA")]
		public const short Meteorite = 116;

		// Token: 0x04003C5F RID: 15455
		[global::Cpp2ILInjected.Token(Token = "0x4004EAB")]
		public const short MeteoriteBar = 117;

		// Token: 0x04003C60 RID: 15456
		[global::Cpp2ILInjected.Token(Token = "0x4004EAC")]
		public const short Hook = 118;

		// Token: 0x04003C61 RID: 15457
		[global::Cpp2ILInjected.Token(Token = "0x4004EAD")]
		public const short Flamarang = 119;

		// Token: 0x04003C62 RID: 15458
		[global::Cpp2ILInjected.Token(Token = "0x4004EAE")]
		public const short MoltenFury = 120;

		// Token: 0x04003C63 RID: 15459
		[global::Cpp2ILInjected.Token(Token = "0x4004EAF")]
		public const short FieryGreatsword = 121;

		// Token: 0x04003C64 RID: 15460
		[global::Cpp2ILInjected.Token(Token = "0x4004EB0")]
		public const short MoltenPickaxe = 122;

		// Token: 0x04003C65 RID: 15461
		[global::Cpp2ILInjected.Token(Token = "0x4004EB1")]
		public const short MeteorHelmet = 123;

		// Token: 0x04003C66 RID: 15462
		[global::Cpp2ILInjected.Token(Token = "0x4004EB2")]
		public const short MeteorSuit = 124;

		// Token: 0x04003C67 RID: 15463
		[global::Cpp2ILInjected.Token(Token = "0x4004EB3")]
		public const short MeteorLeggings = 125;

		// Token: 0x04003C68 RID: 15464
		[global::Cpp2ILInjected.Token(Token = "0x4004EB4")]
		public const short BottledWater = 126;

		// Token: 0x04003C69 RID: 15465
		[global::Cpp2ILInjected.Token(Token = "0x4004EB5")]
		public const short SpaceGun = 127;

		// Token: 0x04003C6A RID: 15466
		[global::Cpp2ILInjected.Token(Token = "0x4004EB6")]
		public const short RocketBoots = 128;

		// Token: 0x04003C6B RID: 15467
		[global::Cpp2ILInjected.Token(Token = "0x4004EB7")]
		public const short GrayBrick = 129;

		// Token: 0x04003C6C RID: 15468
		[global::Cpp2ILInjected.Token(Token = "0x4004EB8")]
		public const short GrayBrickWall = 130;

		// Token: 0x04003C6D RID: 15469
		[global::Cpp2ILInjected.Token(Token = "0x4004EB9")]
		public const short RedBrick = 131;

		// Token: 0x04003C6E RID: 15470
		[global::Cpp2ILInjected.Token(Token = "0x4004EBA")]
		public const short RedBrickWall = 132;

		// Token: 0x04003C6F RID: 15471
		[global::Cpp2ILInjected.Token(Token = "0x4004EBB")]
		public const short ClayBlock = 133;

		// Token: 0x04003C70 RID: 15472
		[global::Cpp2ILInjected.Token(Token = "0x4004EBC")]
		public const short BlueBrick = 134;

		// Token: 0x04003C71 RID: 15473
		[global::Cpp2ILInjected.Token(Token = "0x4004EBD")]
		public const short BlueBrickWall = 135;

		// Token: 0x04003C72 RID: 15474
		[global::Cpp2ILInjected.Token(Token = "0x4004EBE")]
		public const short ChainLantern = 136;

		// Token: 0x04003C73 RID: 15475
		[global::Cpp2ILInjected.Token(Token = "0x4004EBF")]
		public const short GreenBrick = 137;

		// Token: 0x04003C74 RID: 15476
		[global::Cpp2ILInjected.Token(Token = "0x4004EC0")]
		public const short GreenBrickWall = 138;

		// Token: 0x04003C75 RID: 15477
		[global::Cpp2ILInjected.Token(Token = "0x4004EC1")]
		public const short PinkBrick = 139;

		// Token: 0x04003C76 RID: 15478
		[global::Cpp2ILInjected.Token(Token = "0x4004EC2")]
		public const short PinkBrickWall = 140;

		// Token: 0x04003C77 RID: 15479
		[global::Cpp2ILInjected.Token(Token = "0x4004EC3")]
		public const short GoldBrick = 141;

		// Token: 0x04003C78 RID: 15480
		[global::Cpp2ILInjected.Token(Token = "0x4004EC4")]
		public const short GoldBrickWall = 142;

		// Token: 0x04003C79 RID: 15481
		[global::Cpp2ILInjected.Token(Token = "0x4004EC5")]
		public const short SilverBrick = 143;

		// Token: 0x04003C7A RID: 15482
		[global::Cpp2ILInjected.Token(Token = "0x4004EC6")]
		public const short SilverBrickWall = 144;

		// Token: 0x04003C7B RID: 15483
		[global::Cpp2ILInjected.Token(Token = "0x4004EC7")]
		public const short CopperBrick = 145;

		// Token: 0x04003C7C RID: 15484
		[global::Cpp2ILInjected.Token(Token = "0x4004EC8")]
		public const short CopperBrickWall = 146;

		// Token: 0x04003C7D RID: 15485
		[global::Cpp2ILInjected.Token(Token = "0x4004EC9")]
		public const short Spike = 147;

		// Token: 0x04003C7E RID: 15486
		[global::Cpp2ILInjected.Token(Token = "0x4004ECA")]
		public const short WaterCandle = 148;

		// Token: 0x04003C7F RID: 15487
		[global::Cpp2ILInjected.Token(Token = "0x4004ECB")]
		public const short Book = 149;

		// Token: 0x04003C80 RID: 15488
		[global::Cpp2ILInjected.Token(Token = "0x4004ECC")]
		public const short Cobweb = 150;

		// Token: 0x04003C81 RID: 15489
		[global::Cpp2ILInjected.Token(Token = "0x4004ECD")]
		public const short NecroHelmet = 151;

		// Token: 0x04003C82 RID: 15490
		[global::Cpp2ILInjected.Token(Token = "0x4004ECE")]
		public const short NecroBreastplate = 152;

		// Token: 0x04003C83 RID: 15491
		[global::Cpp2ILInjected.Token(Token = "0x4004ECF")]
		public const short NecroGreaves = 153;

		// Token: 0x04003C84 RID: 15492
		[global::Cpp2ILInjected.Token(Token = "0x4004ED0")]
		public const short Bone = 154;

		// Token: 0x04003C85 RID: 15493
		[global::Cpp2ILInjected.Token(Token = "0x4004ED1")]
		public const short Muramasa = 155;

		// Token: 0x04003C86 RID: 15494
		[global::Cpp2ILInjected.Token(Token = "0x4004ED2")]
		public const short CobaltShield = 156;

		// Token: 0x04003C87 RID: 15495
		[global::Cpp2ILInjected.Token(Token = "0x4004ED3")]
		public const short AquaScepter = 157;

		// Token: 0x04003C88 RID: 15496
		[global::Cpp2ILInjected.Token(Token = "0x4004ED4")]
		public const short LuckyHorseshoe = 158;

		// Token: 0x04003C89 RID: 15497
		[global::Cpp2ILInjected.Token(Token = "0x4004ED5")]
		public const short ShinyRedBalloon = 159;

		// Token: 0x04003C8A RID: 15498
		[global::Cpp2ILInjected.Token(Token = "0x4004ED6")]
		public const short Harpoon = 160;

		// Token: 0x04003C8B RID: 15499
		[global::Cpp2ILInjected.Token(Token = "0x4004ED7")]
		public const short SpikyBall = 161;

		// Token: 0x04003C8C RID: 15500
		[global::Cpp2ILInjected.Token(Token = "0x4004ED8")]
		public const short BallOHurt = 162;

		// Token: 0x04003C8D RID: 15501
		[global::Cpp2ILInjected.Token(Token = "0x4004ED9")]
		public const short BlueMoon = 163;

		// Token: 0x04003C8E RID: 15502
		[global::Cpp2ILInjected.Token(Token = "0x4004EDA")]
		public const short Handgun = 164;

		// Token: 0x04003C8F RID: 15503
		[global::Cpp2ILInjected.Token(Token = "0x4004EDB")]
		public const short WaterBolt = 165;

		// Token: 0x04003C90 RID: 15504
		[global::Cpp2ILInjected.Token(Token = "0x4004EDC")]
		public const short Bomb = 166;

		// Token: 0x04003C91 RID: 15505
		[global::Cpp2ILInjected.Token(Token = "0x4004EDD")]
		public const short Dynamite = 167;

		// Token: 0x04003C92 RID: 15506
		[global::Cpp2ILInjected.Token(Token = "0x4004EDE")]
		public const short Grenade = 168;

		// Token: 0x04003C93 RID: 15507
		[global::Cpp2ILInjected.Token(Token = "0x4004EDF")]
		public const short SandBlock = 169;

		// Token: 0x04003C94 RID: 15508
		[global::Cpp2ILInjected.Token(Token = "0x4004EE0")]
		public const short Glass = 170;

		// Token: 0x04003C95 RID: 15509
		[global::Cpp2ILInjected.Token(Token = "0x4004EE1")]
		public const short Sign = 171;

		// Token: 0x04003C96 RID: 15510
		[global::Cpp2ILInjected.Token(Token = "0x4004EE2")]
		public const short AshBlock = 172;

		// Token: 0x04003C97 RID: 15511
		[global::Cpp2ILInjected.Token(Token = "0x4004EE3")]
		public const short Obsidian = 173;

		// Token: 0x04003C98 RID: 15512
		[global::Cpp2ILInjected.Token(Token = "0x4004EE4")]
		public const short Hellstone = 174;

		// Token: 0x04003C99 RID: 15513
		[global::Cpp2ILInjected.Token(Token = "0x4004EE5")]
		public const short HellstoneBar = 175;

		// Token: 0x04003C9A RID: 15514
		[global::Cpp2ILInjected.Token(Token = "0x4004EE6")]
		public const short MudBlock = 176;

		// Token: 0x04003C9B RID: 15515
		[global::Cpp2ILInjected.Token(Token = "0x4004EE7")]
		public const short Sapphire = 177;

		// Token: 0x04003C9C RID: 15516
		[global::Cpp2ILInjected.Token(Token = "0x4004EE8")]
		public const short Ruby = 178;

		// Token: 0x04003C9D RID: 15517
		[global::Cpp2ILInjected.Token(Token = "0x4004EE9")]
		public const short Emerald = 179;

		// Token: 0x04003C9E RID: 15518
		[global::Cpp2ILInjected.Token(Token = "0x4004EEA")]
		public const short Topaz = 180;

		// Token: 0x04003C9F RID: 15519
		[global::Cpp2ILInjected.Token(Token = "0x4004EEB")]
		public const short Amethyst = 181;

		// Token: 0x04003CA0 RID: 15520
		[global::Cpp2ILInjected.Token(Token = "0x4004EEC")]
		public const short Diamond = 182;

		// Token: 0x04003CA1 RID: 15521
		[global::Cpp2ILInjected.Token(Token = "0x4004EED")]
		public const short GlowingMushroom = 183;

		// Token: 0x04003CA2 RID: 15522
		[global::Cpp2ILInjected.Token(Token = "0x4004EEE")]
		public const short Star = 184;

		// Token: 0x04003CA3 RID: 15523
		[global::Cpp2ILInjected.Token(Token = "0x4004EEF")]
		public const short IvyWhip = 185;

		// Token: 0x04003CA4 RID: 15524
		[global::Cpp2ILInjected.Token(Token = "0x4004EF0")]
		public const short BreathingReed = 186;

		// Token: 0x04003CA5 RID: 15525
		[global::Cpp2ILInjected.Token(Token = "0x4004EF1")]
		public const short Flipper = 187;

		// Token: 0x04003CA6 RID: 15526
		[global::Cpp2ILInjected.Token(Token = "0x4004EF2")]
		public const short HealingPotion = 188;

		// Token: 0x04003CA7 RID: 15527
		[global::Cpp2ILInjected.Token(Token = "0x4004EF3")]
		public const short ManaPotion = 189;

		// Token: 0x04003CA8 RID: 15528
		[global::Cpp2ILInjected.Token(Token = "0x4004EF4")]
		public const short BladeofGrass = 190;

		// Token: 0x04003CA9 RID: 15529
		[global::Cpp2ILInjected.Token(Token = "0x4004EF5")]
		public const short ThornChakram = 191;

		// Token: 0x04003CAA RID: 15530
		[global::Cpp2ILInjected.Token(Token = "0x4004EF6")]
		public const short ObsidianBrick = 192;

		// Token: 0x04003CAB RID: 15531
		[global::Cpp2ILInjected.Token(Token = "0x4004EF7")]
		public const short ObsidianSkull = 193;

		// Token: 0x04003CAC RID: 15532
		[global::Cpp2ILInjected.Token(Token = "0x4004EF8")]
		public const short MushroomGrassSeeds = 194;

		// Token: 0x04003CAD RID: 15533
		[global::Cpp2ILInjected.Token(Token = "0x4004EF9")]
		public const short JungleGrassSeeds = 195;

		// Token: 0x04003CAE RID: 15534
		[global::Cpp2ILInjected.Token(Token = "0x4004EFA")]
		public const short WoodenHammer = 196;

		// Token: 0x04003CAF RID: 15535
		[global::Cpp2ILInjected.Token(Token = "0x4004EFB")]
		public const short StarCannon = 197;

		// Token: 0x04003CB0 RID: 15536
		[global::Cpp2ILInjected.Token(Token = "0x4004EFC")]
		public const short BluePhaseblade = 198;

		// Token: 0x04003CB1 RID: 15537
		[global::Cpp2ILInjected.Token(Token = "0x4004EFD")]
		public const short RedPhaseblade = 199;

		// Token: 0x04003CB2 RID: 15538
		[global::Cpp2ILInjected.Token(Token = "0x4004EFE")]
		public const short GreenPhaseblade = 200;

		// Token: 0x04003CB3 RID: 15539
		[global::Cpp2ILInjected.Token(Token = "0x4004EFF")]
		public const short PurplePhaseblade = 201;

		// Token: 0x04003CB4 RID: 15540
		[global::Cpp2ILInjected.Token(Token = "0x4004F00")]
		public const short WhitePhaseblade = 202;

		// Token: 0x04003CB5 RID: 15541
		[global::Cpp2ILInjected.Token(Token = "0x4004F01")]
		public const short YellowPhaseblade = 203;

		// Token: 0x04003CB6 RID: 15542
		[global::Cpp2ILInjected.Token(Token = "0x4004F02")]
		public const short MeteorHamaxe = 204;

		// Token: 0x04003CB7 RID: 15543
		[global::Cpp2ILInjected.Token(Token = "0x4004F03")]
		public const short EmptyBucket = 205;

		// Token: 0x04003CB8 RID: 15544
		[global::Cpp2ILInjected.Token(Token = "0x4004F04")]
		public const short WaterBucket = 206;

		// Token: 0x04003CB9 RID: 15545
		[global::Cpp2ILInjected.Token(Token = "0x4004F05")]
		public const short LavaBucket = 207;

		// Token: 0x04003CBA RID: 15546
		[global::Cpp2ILInjected.Token(Token = "0x4004F06")]
		public const short JungleRose = 208;

		// Token: 0x04003CBB RID: 15547
		[global::Cpp2ILInjected.Token(Token = "0x4004F07")]
		public const short Stinger = 209;

		// Token: 0x04003CBC RID: 15548
		[global::Cpp2ILInjected.Token(Token = "0x4004F08")]
		public const short Vine = 210;

		// Token: 0x04003CBD RID: 15549
		[global::Cpp2ILInjected.Token(Token = "0x4004F09")]
		public const short FeralClaws = 211;

		// Token: 0x04003CBE RID: 15550
		[global::Cpp2ILInjected.Token(Token = "0x4004F0A")]
		public const short AnkletoftheWind = 212;

		// Token: 0x04003CBF RID: 15551
		[global::Cpp2ILInjected.Token(Token = "0x4004F0B")]
		public const short StaffofRegrowth = 213;

		// Token: 0x04003CC0 RID: 15552
		[global::Cpp2ILInjected.Token(Token = "0x4004F0C")]
		public const short HellstoneBrick = 214;

		// Token: 0x04003CC1 RID: 15553
		[global::Cpp2ILInjected.Token(Token = "0x4004F0D")]
		public const short WhoopieCushion = 215;

		// Token: 0x04003CC2 RID: 15554
		[global::Cpp2ILInjected.Token(Token = "0x4004F0E")]
		public const short Shackle = 216;

		// Token: 0x04003CC3 RID: 15555
		[global::Cpp2ILInjected.Token(Token = "0x4004F0F")]
		public const short MoltenHamaxe = 217;

		// Token: 0x04003CC4 RID: 15556
		[global::Cpp2ILInjected.Token(Token = "0x4004F10")]
		public const short Flamelash = 218;

		// Token: 0x04003CC5 RID: 15557
		[global::Cpp2ILInjected.Token(Token = "0x4004F11")]
		public const short PhoenixBlaster = 219;

		// Token: 0x04003CC6 RID: 15558
		[global::Cpp2ILInjected.Token(Token = "0x4004F12")]
		public const short Sunfury = 220;

		// Token: 0x04003CC7 RID: 15559
		[global::Cpp2ILInjected.Token(Token = "0x4004F13")]
		public const short Hellforge = 221;

		// Token: 0x04003CC8 RID: 15560
		[global::Cpp2ILInjected.Token(Token = "0x4004F14")]
		public const short ClayPot = 222;

		// Token: 0x04003CC9 RID: 15561
		[global::Cpp2ILInjected.Token(Token = "0x4004F15")]
		public const short NaturesGift = 223;

		// Token: 0x04003CCA RID: 15562
		[global::Cpp2ILInjected.Token(Token = "0x4004F16")]
		public const short Bed = 224;

		// Token: 0x04003CCB RID: 15563
		[global::Cpp2ILInjected.Token(Token = "0x4004F17")]
		public const short Silk = 225;

		// Token: 0x04003CCC RID: 15564
		[global::Cpp2ILInjected.Token(Token = "0x4004F18")]
		public const short LesserRestorationPotion = 226;

		// Token: 0x04003CCD RID: 15565
		[global::Cpp2ILInjected.Token(Token = "0x4004F19")]
		public const short RestorationPotion = 227;

		// Token: 0x04003CCE RID: 15566
		[global::Cpp2ILInjected.Token(Token = "0x4004F1A")]
		public const short JungleHat = 228;

		// Token: 0x04003CCF RID: 15567
		[global::Cpp2ILInjected.Token(Token = "0x4004F1B")]
		public const short JungleShirt = 229;

		// Token: 0x04003CD0 RID: 15568
		[global::Cpp2ILInjected.Token(Token = "0x4004F1C")]
		public const short JunglePants = 230;

		// Token: 0x04003CD1 RID: 15569
		[global::Cpp2ILInjected.Token(Token = "0x4004F1D")]
		public const short MoltenHelmet = 231;

		// Token: 0x04003CD2 RID: 15570
		[global::Cpp2ILInjected.Token(Token = "0x4004F1E")]
		public const short MoltenBreastplate = 232;

		// Token: 0x04003CD3 RID: 15571
		[global::Cpp2ILInjected.Token(Token = "0x4004F1F")]
		public const short MoltenGreaves = 233;

		// Token: 0x04003CD4 RID: 15572
		[global::Cpp2ILInjected.Token(Token = "0x4004F20")]
		public const short MeteorShot = 234;

		// Token: 0x04003CD5 RID: 15573
		[global::Cpp2ILInjected.Token(Token = "0x4004F21")]
		public const short StickyBomb = 235;

		// Token: 0x04003CD6 RID: 15574
		[global::Cpp2ILInjected.Token(Token = "0x4004F22")]
		public const short BlackLens = 236;

		// Token: 0x04003CD7 RID: 15575
		[global::Cpp2ILInjected.Token(Token = "0x4004F23")]
		public const short Sunglasses = 237;

		// Token: 0x04003CD8 RID: 15576
		[global::Cpp2ILInjected.Token(Token = "0x4004F24")]
		public const short WizardHat = 238;

		// Token: 0x04003CD9 RID: 15577
		[global::Cpp2ILInjected.Token(Token = "0x4004F25")]
		public const short TopHat = 239;

		// Token: 0x04003CDA RID: 15578
		[global::Cpp2ILInjected.Token(Token = "0x4004F26")]
		public const short TuxedoShirt = 240;

		// Token: 0x04003CDB RID: 15579
		[global::Cpp2ILInjected.Token(Token = "0x4004F27")]
		public const short TuxedoPants = 241;

		// Token: 0x04003CDC RID: 15580
		[global::Cpp2ILInjected.Token(Token = "0x4004F28")]
		public const short SummerHat = 242;

		// Token: 0x04003CDD RID: 15581
		[global::Cpp2ILInjected.Token(Token = "0x4004F29")]
		public const short BunnyHood = 243;

		// Token: 0x04003CDE RID: 15582
		[global::Cpp2ILInjected.Token(Token = "0x4004F2A")]
		public const short PlumbersHat = 244;

		// Token: 0x04003CDF RID: 15583
		[global::Cpp2ILInjected.Token(Token = "0x4004F2B")]
		public const short PlumbersShirt = 245;

		// Token: 0x04003CE0 RID: 15584
		[global::Cpp2ILInjected.Token(Token = "0x4004F2C")]
		public const short PlumbersPants = 246;

		// Token: 0x04003CE1 RID: 15585
		[global::Cpp2ILInjected.Token(Token = "0x4004F2D")]
		public const short HerosHat = 247;

		// Token: 0x04003CE2 RID: 15586
		[global::Cpp2ILInjected.Token(Token = "0x4004F2E")]
		public const short HerosShirt = 248;

		// Token: 0x04003CE3 RID: 15587
		[global::Cpp2ILInjected.Token(Token = "0x4004F2F")]
		public const short HerosPants = 249;

		// Token: 0x04003CE4 RID: 15588
		[global::Cpp2ILInjected.Token(Token = "0x4004F30")]
		public const short FishBowl = 250;

		// Token: 0x04003CE5 RID: 15589
		[global::Cpp2ILInjected.Token(Token = "0x4004F31")]
		public const short ArchaeologistsHat = 251;

		// Token: 0x04003CE6 RID: 15590
		[global::Cpp2ILInjected.Token(Token = "0x4004F32")]
		public const short ArchaeologistsJacket = 252;

		// Token: 0x04003CE7 RID: 15591
		[global::Cpp2ILInjected.Token(Token = "0x4004F33")]
		public const short ArchaeologistsPants = 253;

		// Token: 0x04003CE8 RID: 15592
		[global::Cpp2ILInjected.Token(Token = "0x4004F34")]
		public const short BlackThread = 254;

		// Token: 0x04003CE9 RID: 15593
		[global::Cpp2ILInjected.Token(Token = "0x4004F35")]
		public const short GreenThread = 255;

		// Token: 0x04003CEA RID: 15594
		[global::Cpp2ILInjected.Token(Token = "0x4004F36")]
		public const short NinjaHood = 256;

		// Token: 0x04003CEB RID: 15595
		[global::Cpp2ILInjected.Token(Token = "0x4004F37")]
		public const short NinjaShirt = 257;

		// Token: 0x04003CEC RID: 15596
		[global::Cpp2ILInjected.Token(Token = "0x4004F38")]
		public const short NinjaPants = 258;

		// Token: 0x04003CED RID: 15597
		[global::Cpp2ILInjected.Token(Token = "0x4004F39")]
		public const short Leather = 259;

		// Token: 0x04003CEE RID: 15598
		[global::Cpp2ILInjected.Token(Token = "0x4004F3A")]
		public const short RedHat = 260;

		// Token: 0x04003CEF RID: 15599
		[global::Cpp2ILInjected.Token(Token = "0x4004F3B")]
		public const short Goldfish = 261;

		// Token: 0x04003CF0 RID: 15600
		[global::Cpp2ILInjected.Token(Token = "0x4004F3C")]
		public const short Robe = 262;

		// Token: 0x04003CF1 RID: 15601
		[global::Cpp2ILInjected.Token(Token = "0x4004F3D")]
		public const short RobotHat = 263;

		// Token: 0x04003CF2 RID: 15602
		[global::Cpp2ILInjected.Token(Token = "0x4004F3E")]
		public const short GoldCrown = 264;

		// Token: 0x04003CF3 RID: 15603
		[global::Cpp2ILInjected.Token(Token = "0x4004F3F")]
		public const short HellfireArrow = 265;

		// Token: 0x04003CF4 RID: 15604
		[global::Cpp2ILInjected.Token(Token = "0x4004F40")]
		public const short Sandgun = 266;

		// Token: 0x04003CF5 RID: 15605
		[global::Cpp2ILInjected.Token(Token = "0x4004F41")]
		public const short GuideVoodooDoll = 267;

		// Token: 0x04003CF6 RID: 15606
		[global::Cpp2ILInjected.Token(Token = "0x4004F42")]
		public const short DivingHelmet = 268;

		// Token: 0x04003CF7 RID: 15607
		[global::Cpp2ILInjected.Token(Token = "0x4004F43")]
		public const short FamiliarShirt = 269;

		// Token: 0x04003CF8 RID: 15608
		[global::Cpp2ILInjected.Token(Token = "0x4004F44")]
		public const short FamiliarPants = 270;

		// Token: 0x04003CF9 RID: 15609
		[global::Cpp2ILInjected.Token(Token = "0x4004F45")]
		public const short FamiliarWig = 271;

		// Token: 0x04003CFA RID: 15610
		[global::Cpp2ILInjected.Token(Token = "0x4004F46")]
		public const short DemonScythe = 272;

		// Token: 0x04003CFB RID: 15611
		[global::Cpp2ILInjected.Token(Token = "0x4004F47")]
		public const short NightsEdge = 273;

		// Token: 0x04003CFC RID: 15612
		[global::Cpp2ILInjected.Token(Token = "0x4004F48")]
		public const short DarkLance = 274;

		// Token: 0x04003CFD RID: 15613
		[global::Cpp2ILInjected.Token(Token = "0x4004F49")]
		public const short Coral = 275;

		// Token: 0x04003CFE RID: 15614
		[global::Cpp2ILInjected.Token(Token = "0x4004F4A")]
		public const short Cactus = 276;

		// Token: 0x04003CFF RID: 15615
		[global::Cpp2ILInjected.Token(Token = "0x4004F4B")]
		public const short Trident = 277;

		// Token: 0x04003D00 RID: 15616
		[global::Cpp2ILInjected.Token(Token = "0x4004F4C")]
		public const short SilverBullet = 278;

		// Token: 0x04003D01 RID: 15617
		[global::Cpp2ILInjected.Token(Token = "0x4004F4D")]
		public const short ThrowingKnife = 279;

		// Token: 0x04003D02 RID: 15618
		[global::Cpp2ILInjected.Token(Token = "0x4004F4E")]
		public const short Spear = 280;

		// Token: 0x04003D03 RID: 15619
		[global::Cpp2ILInjected.Token(Token = "0x4004F4F")]
		public const short Blowpipe = 281;

		// Token: 0x04003D04 RID: 15620
		[global::Cpp2ILInjected.Token(Token = "0x4004F50")]
		public const short Glowstick = 282;

		// Token: 0x04003D05 RID: 15621
		[global::Cpp2ILInjected.Token(Token = "0x4004F51")]
		public const short Seed = 283;

		// Token: 0x04003D06 RID: 15622
		[global::Cpp2ILInjected.Token(Token = "0x4004F52")]
		public const short WoodenBoomerang = 284;

		// Token: 0x04003D07 RID: 15623
		[global::Cpp2ILInjected.Token(Token = "0x4004F53")]
		public const short Aglet = 285;

		// Token: 0x04003D08 RID: 15624
		[global::Cpp2ILInjected.Token(Token = "0x4004F54")]
		public const short StickyGlowstick = 286;

		// Token: 0x04003D09 RID: 15625
		[global::Cpp2ILInjected.Token(Token = "0x4004F55")]
		public const short PoisonedKnife = 287;

		// Token: 0x04003D0A RID: 15626
		[global::Cpp2ILInjected.Token(Token = "0x4004F56")]
		public const short ObsidianSkinPotion = 288;

		// Token: 0x04003D0B RID: 15627
		[global::Cpp2ILInjected.Token(Token = "0x4004F57")]
		public const short RegenerationPotion = 289;

		// Token: 0x04003D0C RID: 15628
		[global::Cpp2ILInjected.Token(Token = "0x4004F58")]
		public const short SwiftnessPotion = 290;

		// Token: 0x04003D0D RID: 15629
		[global::Cpp2ILInjected.Token(Token = "0x4004F59")]
		public const short GillsPotion = 291;

		// Token: 0x04003D0E RID: 15630
		[global::Cpp2ILInjected.Token(Token = "0x4004F5A")]
		public const short IronskinPotion = 292;

		// Token: 0x04003D0F RID: 15631
		[global::Cpp2ILInjected.Token(Token = "0x4004F5B")]
		public const short ManaRegenerationPotion = 293;

		// Token: 0x04003D10 RID: 15632
		[global::Cpp2ILInjected.Token(Token = "0x4004F5C")]
		public const short MagicPowerPotion = 294;

		// Token: 0x04003D11 RID: 15633
		[global::Cpp2ILInjected.Token(Token = "0x4004F5D")]
		public const short FeatherfallPotion = 295;

		// Token: 0x04003D12 RID: 15634
		[global::Cpp2ILInjected.Token(Token = "0x4004F5E")]
		public const short SpelunkerPotion = 296;

		// Token: 0x04003D13 RID: 15635
		[global::Cpp2ILInjected.Token(Token = "0x4004F5F")]
		public const short InvisibilityPotion = 297;

		// Token: 0x04003D14 RID: 15636
		[global::Cpp2ILInjected.Token(Token = "0x4004F60")]
		public const short ShinePotion = 298;

		// Token: 0x04003D15 RID: 15637
		[global::Cpp2ILInjected.Token(Token = "0x4004F61")]
		public const short NightOwlPotion = 299;

		// Token: 0x04003D16 RID: 15638
		[global::Cpp2ILInjected.Token(Token = "0x4004F62")]
		public const short BattlePotion = 300;

		// Token: 0x04003D17 RID: 15639
		[global::Cpp2ILInjected.Token(Token = "0x4004F63")]
		public const short ThornsPotion = 301;

		// Token: 0x04003D18 RID: 15640
		[global::Cpp2ILInjected.Token(Token = "0x4004F64")]
		public const short WaterWalkingPotion = 302;

		// Token: 0x04003D19 RID: 15641
		[global::Cpp2ILInjected.Token(Token = "0x4004F65")]
		public const short ArcheryPotion = 303;

		// Token: 0x04003D1A RID: 15642
		[global::Cpp2ILInjected.Token(Token = "0x4004F66")]
		public const short HunterPotion = 304;

		// Token: 0x04003D1B RID: 15643
		[global::Cpp2ILInjected.Token(Token = "0x4004F67")]
		public const short GravitationPotion = 305;

		// Token: 0x04003D1C RID: 15644
		[global::Cpp2ILInjected.Token(Token = "0x4004F68")]
		public const short GoldChest = 306;

		// Token: 0x04003D1D RID: 15645
		[global::Cpp2ILInjected.Token(Token = "0x4004F69")]
		public const short DaybloomSeeds = 307;

		// Token: 0x04003D1E RID: 15646
		[global::Cpp2ILInjected.Token(Token = "0x4004F6A")]
		public const short MoonglowSeeds = 308;

		// Token: 0x04003D1F RID: 15647
		[global::Cpp2ILInjected.Token(Token = "0x4004F6B")]
		public const short BlinkrootSeeds = 309;

		// Token: 0x04003D20 RID: 15648
		[global::Cpp2ILInjected.Token(Token = "0x4004F6C")]
		public const short DeathweedSeeds = 310;

		// Token: 0x04003D21 RID: 15649
		[global::Cpp2ILInjected.Token(Token = "0x4004F6D")]
		public const short WaterleafSeeds = 311;

		// Token: 0x04003D22 RID: 15650
		[global::Cpp2ILInjected.Token(Token = "0x4004F6E")]
		public const short FireblossomSeeds = 312;

		// Token: 0x04003D23 RID: 15651
		[global::Cpp2ILInjected.Token(Token = "0x4004F6F")]
		public const short Daybloom = 313;

		// Token: 0x04003D24 RID: 15652
		[global::Cpp2ILInjected.Token(Token = "0x4004F70")]
		public const short Moonglow = 314;

		// Token: 0x04003D25 RID: 15653
		[global::Cpp2ILInjected.Token(Token = "0x4004F71")]
		public const short Blinkroot = 315;

		// Token: 0x04003D26 RID: 15654
		[global::Cpp2ILInjected.Token(Token = "0x4004F72")]
		public const short Deathweed = 316;

		// Token: 0x04003D27 RID: 15655
		[global::Cpp2ILInjected.Token(Token = "0x4004F73")]
		public const short Waterleaf = 317;

		// Token: 0x04003D28 RID: 15656
		[global::Cpp2ILInjected.Token(Token = "0x4004F74")]
		public const short Fireblossom = 318;

		// Token: 0x04003D29 RID: 15657
		[global::Cpp2ILInjected.Token(Token = "0x4004F75")]
		public const short SharkFin = 319;

		// Token: 0x04003D2A RID: 15658
		[global::Cpp2ILInjected.Token(Token = "0x4004F76")]
		public const short Feather = 320;

		// Token: 0x04003D2B RID: 15659
		[global::Cpp2ILInjected.Token(Token = "0x4004F77")]
		public const short Tombstone = 321;

		// Token: 0x04003D2C RID: 15660
		[global::Cpp2ILInjected.Token(Token = "0x4004F78")]
		public const short MimeMask = 322;

		// Token: 0x04003D2D RID: 15661
		[global::Cpp2ILInjected.Token(Token = "0x4004F79")]
		public const short AntlionMandible = 323;

		// Token: 0x04003D2E RID: 15662
		[global::Cpp2ILInjected.Token(Token = "0x4004F7A")]
		public const short IllegalGunParts = 324;

		// Token: 0x04003D2F RID: 15663
		[global::Cpp2ILInjected.Token(Token = "0x4004F7B")]
		public const short TheDoctorsShirt = 325;

		// Token: 0x04003D30 RID: 15664
		[global::Cpp2ILInjected.Token(Token = "0x4004F7C")]
		public const short TheDoctorsPants = 326;

		// Token: 0x04003D31 RID: 15665
		[global::Cpp2ILInjected.Token(Token = "0x4004F7D")]
		public const short GoldenKey = 327;

		// Token: 0x04003D32 RID: 15666
		[global::Cpp2ILInjected.Token(Token = "0x4004F7E")]
		public const short ShadowChest = 328;

		// Token: 0x04003D33 RID: 15667
		[global::Cpp2ILInjected.Token(Token = "0x4004F7F")]
		public const short ShadowKey = 329;

		// Token: 0x04003D34 RID: 15668
		[global::Cpp2ILInjected.Token(Token = "0x4004F80")]
		public const short ObsidianBrickWall = 330;

		// Token: 0x04003D35 RID: 15669
		[global::Cpp2ILInjected.Token(Token = "0x4004F81")]
		public const short JungleSpores = 331;

		// Token: 0x04003D36 RID: 15670
		[global::Cpp2ILInjected.Token(Token = "0x4004F82")]
		public const short Loom = 332;

		// Token: 0x04003D37 RID: 15671
		[global::Cpp2ILInjected.Token(Token = "0x4004F83")]
		public const short Piano = 333;

		// Token: 0x04003D38 RID: 15672
		[global::Cpp2ILInjected.Token(Token = "0x4004F84")]
		public const short Dresser = 334;

		// Token: 0x04003D39 RID: 15673
		[global::Cpp2ILInjected.Token(Token = "0x4004F85")]
		public const short Bench = 335;

		// Token: 0x04003D3A RID: 15674
		[global::Cpp2ILInjected.Token(Token = "0x4004F86")]
		public const short Bathtub = 336;

		// Token: 0x04003D3B RID: 15675
		[global::Cpp2ILInjected.Token(Token = "0x4004F87")]
		public const short RedBanner = 337;

		// Token: 0x04003D3C RID: 15676
		[global::Cpp2ILInjected.Token(Token = "0x4004F88")]
		public const short GreenBanner = 338;

		// Token: 0x04003D3D RID: 15677
		[global::Cpp2ILInjected.Token(Token = "0x4004F89")]
		public const short BlueBanner = 339;

		// Token: 0x04003D3E RID: 15678
		[global::Cpp2ILInjected.Token(Token = "0x4004F8A")]
		public const short YellowBanner = 340;

		// Token: 0x04003D3F RID: 15679
		[global::Cpp2ILInjected.Token(Token = "0x4004F8B")]
		public const short LampPost = 341;

		// Token: 0x04003D40 RID: 15680
		[global::Cpp2ILInjected.Token(Token = "0x4004F8C")]
		public const short TikiTorch = 342;

		// Token: 0x04003D41 RID: 15681
		[global::Cpp2ILInjected.Token(Token = "0x4004F8D")]
		public const short Barrel = 343;

		// Token: 0x04003D42 RID: 15682
		[global::Cpp2ILInjected.Token(Token = "0x4004F8E")]
		public const short ChineseLantern = 344;

		// Token: 0x04003D43 RID: 15683
		[global::Cpp2ILInjected.Token(Token = "0x4004F8F")]
		public const short CookingPot = 345;

		// Token: 0x04003D44 RID: 15684
		[global::Cpp2ILInjected.Token(Token = "0x4004F90")]
		public const short Safe = 346;

		// Token: 0x04003D45 RID: 15685
		[global::Cpp2ILInjected.Token(Token = "0x4004F91")]
		public const short SkullLantern = 347;

		// Token: 0x04003D46 RID: 15686
		[global::Cpp2ILInjected.Token(Token = "0x4004F92")]
		public const short TrashCan = 348;

		// Token: 0x04003D47 RID: 15687
		[global::Cpp2ILInjected.Token(Token = "0x4004F93")]
		public const short Candelabra = 349;

		// Token: 0x04003D48 RID: 15688
		[global::Cpp2ILInjected.Token(Token = "0x4004F94")]
		public const short PinkVase = 350;

		// Token: 0x04003D49 RID: 15689
		[global::Cpp2ILInjected.Token(Token = "0x4004F95")]
		public const short Mug = 351;

		// Token: 0x04003D4A RID: 15690
		[global::Cpp2ILInjected.Token(Token = "0x4004F96")]
		public const short Keg = 352;

		// Token: 0x04003D4B RID: 15691
		[global::Cpp2ILInjected.Token(Token = "0x4004F97")]
		public const short Ale = 353;

		// Token: 0x04003D4C RID: 15692
		[global::Cpp2ILInjected.Token(Token = "0x4004F98")]
		public const short Bookcase = 354;

		// Token: 0x04003D4D RID: 15693
		[global::Cpp2ILInjected.Token(Token = "0x4004F99")]
		public const short Throne = 355;

		// Token: 0x04003D4E RID: 15694
		[global::Cpp2ILInjected.Token(Token = "0x4004F9A")]
		public const short Bowl = 356;

		// Token: 0x04003D4F RID: 15695
		[global::Cpp2ILInjected.Token(Token = "0x4004F9B")]
		public const short BowlofSoup = 357;

		// Token: 0x04003D50 RID: 15696
		[global::Cpp2ILInjected.Token(Token = "0x4004F9C")]
		public const short Toilet = 358;

		// Token: 0x04003D51 RID: 15697
		[global::Cpp2ILInjected.Token(Token = "0x4004F9D")]
		public const short GrandfatherClock = 359;

		// Token: 0x04003D52 RID: 15698
		[global::Cpp2ILInjected.Token(Token = "0x4004F9E")]
		public const short ArmorStatue = 360;

		// Token: 0x04003D53 RID: 15699
		[global::Cpp2ILInjected.Token(Token = "0x4004F9F")]
		public const short GoblinBattleStandard = 361;

		// Token: 0x04003D54 RID: 15700
		[global::Cpp2ILInjected.Token(Token = "0x4004FA0")]
		public const short TatteredCloth = 362;

		// Token: 0x04003D55 RID: 15701
		[global::Cpp2ILInjected.Token(Token = "0x4004FA1")]
		public const short Sawmill = 363;

		// Token: 0x04003D56 RID: 15702
		[global::Cpp2ILInjected.Token(Token = "0x4004FA2")]
		public const short CobaltOre = 364;

		// Token: 0x04003D57 RID: 15703
		[global::Cpp2ILInjected.Token(Token = "0x4004FA3")]
		public const short MythrilOre = 365;

		// Token: 0x04003D58 RID: 15704
		[global::Cpp2ILInjected.Token(Token = "0x4004FA4")]
		public const short AdamantiteOre = 366;

		// Token: 0x04003D59 RID: 15705
		[global::Cpp2ILInjected.Token(Token = "0x4004FA5")]
		public const short Pwnhammer = 367;

		// Token: 0x04003D5A RID: 15706
		[global::Cpp2ILInjected.Token(Token = "0x4004FA6")]
		public const short Excalibur = 368;

		// Token: 0x04003D5B RID: 15707
		[global::Cpp2ILInjected.Token(Token = "0x4004FA7")]
		public const short HallowedSeeds = 369;

		// Token: 0x04003D5C RID: 15708
		[global::Cpp2ILInjected.Token(Token = "0x4004FA8")]
		public const short EbonsandBlock = 370;

		// Token: 0x04003D5D RID: 15709
		[global::Cpp2ILInjected.Token(Token = "0x4004FA9")]
		public const short CobaltHat = 371;

		// Token: 0x04003D5E RID: 15710
		[global::Cpp2ILInjected.Token(Token = "0x4004FAA")]
		public const short CobaltHelmet = 372;

		// Token: 0x04003D5F RID: 15711
		[global::Cpp2ILInjected.Token(Token = "0x4004FAB")]
		public const short CobaltMask = 373;

		// Token: 0x04003D60 RID: 15712
		[global::Cpp2ILInjected.Token(Token = "0x4004FAC")]
		public const short CobaltBreastplate = 374;

		// Token: 0x04003D61 RID: 15713
		[global::Cpp2ILInjected.Token(Token = "0x4004FAD")]
		public const short CobaltLeggings = 375;

		// Token: 0x04003D62 RID: 15714
		[global::Cpp2ILInjected.Token(Token = "0x4004FAE")]
		public const short MythrilHood = 376;

		// Token: 0x04003D63 RID: 15715
		[global::Cpp2ILInjected.Token(Token = "0x4004FAF")]
		public const short MythrilHelmet = 377;

		// Token: 0x04003D64 RID: 15716
		[global::Cpp2ILInjected.Token(Token = "0x4004FB0")]
		public const short MythrilHat = 378;

		// Token: 0x04003D65 RID: 15717
		[global::Cpp2ILInjected.Token(Token = "0x4004FB1")]
		public const short MythrilChainmail = 379;

		// Token: 0x04003D66 RID: 15718
		[global::Cpp2ILInjected.Token(Token = "0x4004FB2")]
		public const short MythrilGreaves = 380;

		// Token: 0x04003D67 RID: 15719
		[global::Cpp2ILInjected.Token(Token = "0x4004FB3")]
		public const short CobaltBar = 381;

		// Token: 0x04003D68 RID: 15720
		[global::Cpp2ILInjected.Token(Token = "0x4004FB4")]
		public const short MythrilBar = 382;

		// Token: 0x04003D69 RID: 15721
		[global::Cpp2ILInjected.Token(Token = "0x4004FB5")]
		public const short CobaltChainsaw = 383;

		// Token: 0x04003D6A RID: 15722
		[global::Cpp2ILInjected.Token(Token = "0x4004FB6")]
		public const short MythrilChainsaw = 384;

		// Token: 0x04003D6B RID: 15723
		[global::Cpp2ILInjected.Token(Token = "0x4004FB7")]
		public const short CobaltDrill = 385;

		// Token: 0x04003D6C RID: 15724
		[global::Cpp2ILInjected.Token(Token = "0x4004FB8")]
		public const short MythrilDrill = 386;

		// Token: 0x04003D6D RID: 15725
		[global::Cpp2ILInjected.Token(Token = "0x4004FB9")]
		public const short AdamantiteChainsaw = 387;

		// Token: 0x04003D6E RID: 15726
		[global::Cpp2ILInjected.Token(Token = "0x4004FBA")]
		public const short AdamantiteDrill = 388;

		// Token: 0x04003D6F RID: 15727
		[global::Cpp2ILInjected.Token(Token = "0x4004FBB")]
		public const short DaoofPow = 389;

		// Token: 0x04003D70 RID: 15728
		[global::Cpp2ILInjected.Token(Token = "0x4004FBC")]
		public const short MythrilHalberd = 390;

		// Token: 0x04003D71 RID: 15729
		[global::Cpp2ILInjected.Token(Token = "0x4004FBD")]
		public const short AdamantiteBar = 391;

		// Token: 0x04003D72 RID: 15730
		[global::Cpp2ILInjected.Token(Token = "0x4004FBE")]
		public const short GlassWall = 392;

		// Token: 0x04003D73 RID: 15731
		[global::Cpp2ILInjected.Token(Token = "0x4004FBF")]
		public const short Compass = 393;

		// Token: 0x04003D74 RID: 15732
		[global::Cpp2ILInjected.Token(Token = "0x4004FC0")]
		public const short DivingGear = 394;

		// Token: 0x04003D75 RID: 15733
		[global::Cpp2ILInjected.Token(Token = "0x4004FC1")]
		public const short GPS = 395;

		// Token: 0x04003D76 RID: 15734
		[global::Cpp2ILInjected.Token(Token = "0x4004FC2")]
		public const short ObsidianHorseshoe = 396;

		// Token: 0x04003D77 RID: 15735
		[global::Cpp2ILInjected.Token(Token = "0x4004FC3")]
		public const short ObsidianShield = 397;

		// Token: 0x04003D78 RID: 15736
		[global::Cpp2ILInjected.Token(Token = "0x4004FC4")]
		public const short TinkerersWorkshop = 398;

		// Token: 0x04003D79 RID: 15737
		[global::Cpp2ILInjected.Token(Token = "0x4004FC5")]
		public const short CloudinaBalloon = 399;

		// Token: 0x04003D7A RID: 15738
		[global::Cpp2ILInjected.Token(Token = "0x4004FC6")]
		public const short AdamantiteHeadgear = 400;

		// Token: 0x04003D7B RID: 15739
		[global::Cpp2ILInjected.Token(Token = "0x4004FC7")]
		public const short AdamantiteHelmet = 401;

		// Token: 0x04003D7C RID: 15740
		[global::Cpp2ILInjected.Token(Token = "0x4004FC8")]
		public const short AdamantiteMask = 402;

		// Token: 0x04003D7D RID: 15741
		[global::Cpp2ILInjected.Token(Token = "0x4004FC9")]
		public const short AdamantiteBreastplate = 403;

		// Token: 0x04003D7E RID: 15742
		[global::Cpp2ILInjected.Token(Token = "0x4004FCA")]
		public const short AdamantiteLeggings = 404;

		// Token: 0x04003D7F RID: 15743
		[global::Cpp2ILInjected.Token(Token = "0x4004FCB")]
		public const short SpectreBoots = 405;

		// Token: 0x04003D80 RID: 15744
		[global::Cpp2ILInjected.Token(Token = "0x4004FCC")]
		public const short AdamantiteGlaive = 406;

		// Token: 0x04003D81 RID: 15745
		[global::Cpp2ILInjected.Token(Token = "0x4004FCD")]
		public const short Toolbelt = 407;

		// Token: 0x04003D82 RID: 15746
		[global::Cpp2ILInjected.Token(Token = "0x4004FCE")]
		public const short PearlsandBlock = 408;

		// Token: 0x04003D83 RID: 15747
		[global::Cpp2ILInjected.Token(Token = "0x4004FCF")]
		public const short PearlstoneBlock = 409;

		// Token: 0x04003D84 RID: 15748
		[global::Cpp2ILInjected.Token(Token = "0x4004FD0")]
		public const short MiningShirt = 410;

		// Token: 0x04003D85 RID: 15749
		[global::Cpp2ILInjected.Token(Token = "0x4004FD1")]
		public const short MiningPants = 411;

		// Token: 0x04003D86 RID: 15750
		[global::Cpp2ILInjected.Token(Token = "0x4004FD2")]
		public const short PearlstoneBrick = 412;

		// Token: 0x04003D87 RID: 15751
		[global::Cpp2ILInjected.Token(Token = "0x4004FD3")]
		public const short IridescentBrick = 413;

		// Token: 0x04003D88 RID: 15752
		[global::Cpp2ILInjected.Token(Token = "0x4004FD4")]
		public const short MudstoneBlock = 414;

		// Token: 0x04003D89 RID: 15753
		[global::Cpp2ILInjected.Token(Token = "0x4004FD5")]
		public const short CobaltBrick = 415;

		// Token: 0x04003D8A RID: 15754
		[global::Cpp2ILInjected.Token(Token = "0x4004FD6")]
		public const short MythrilBrick = 416;

		// Token: 0x04003D8B RID: 15755
		[global::Cpp2ILInjected.Token(Token = "0x4004FD7")]
		public const short PearlstoneBrickWall = 417;

		// Token: 0x04003D8C RID: 15756
		[global::Cpp2ILInjected.Token(Token = "0x4004FD8")]
		public const short IridescentBrickWall = 418;

		// Token: 0x04003D8D RID: 15757
		[global::Cpp2ILInjected.Token(Token = "0x4004FD9")]
		public const short MudstoneBrickWall = 419;

		// Token: 0x04003D8E RID: 15758
		[global::Cpp2ILInjected.Token(Token = "0x4004FDA")]
		public const short CobaltBrickWall = 420;

		// Token: 0x04003D8F RID: 15759
		[global::Cpp2ILInjected.Token(Token = "0x4004FDB")]
		public const short MythrilBrickWall = 421;

		// Token: 0x04003D90 RID: 15760
		[global::Cpp2ILInjected.Token(Token = "0x4004FDC")]
		public const short HolyWater = 422;

		// Token: 0x04003D91 RID: 15761
		[global::Cpp2ILInjected.Token(Token = "0x4004FDD")]
		public const short UnholyWater = 423;

		// Token: 0x04003D92 RID: 15762
		[global::Cpp2ILInjected.Token(Token = "0x4004FDE")]
		public const short SiltBlock = 424;

		// Token: 0x04003D93 RID: 15763
		[global::Cpp2ILInjected.Token(Token = "0x4004FDF")]
		public const short FairyBell = 425;

		// Token: 0x04003D94 RID: 15764
		[global::Cpp2ILInjected.Token(Token = "0x4004FE0")]
		public const short BreakerBlade = 426;

		// Token: 0x04003D95 RID: 15765
		[global::Cpp2ILInjected.Token(Token = "0x4004FE1")]
		public const short BlueTorch = 427;

		// Token: 0x04003D96 RID: 15766
		[global::Cpp2ILInjected.Token(Token = "0x4004FE2")]
		public const short RedTorch = 428;

		// Token: 0x04003D97 RID: 15767
		[global::Cpp2ILInjected.Token(Token = "0x4004FE3")]
		public const short GreenTorch = 429;

		// Token: 0x04003D98 RID: 15768
		[global::Cpp2ILInjected.Token(Token = "0x4004FE4")]
		public const short PurpleTorch = 430;

		// Token: 0x04003D99 RID: 15769
		[global::Cpp2ILInjected.Token(Token = "0x4004FE5")]
		public const short WhiteTorch = 431;

		// Token: 0x04003D9A RID: 15770
		[global::Cpp2ILInjected.Token(Token = "0x4004FE6")]
		public const short YellowTorch = 432;

		// Token: 0x04003D9B RID: 15771
		[global::Cpp2ILInjected.Token(Token = "0x4004FE7")]
		public const short DemonTorch = 433;

		// Token: 0x04003D9C RID: 15772
		[global::Cpp2ILInjected.Token(Token = "0x4004FE8")]
		public const short ClockworkAssaultRifle = 434;

		// Token: 0x04003D9D RID: 15773
		[global::Cpp2ILInjected.Token(Token = "0x4004FE9")]
		public const short CobaltRepeater = 435;

		// Token: 0x04003D9E RID: 15774
		[global::Cpp2ILInjected.Token(Token = "0x4004FEA")]
		public const short MythrilRepeater = 436;

		// Token: 0x04003D9F RID: 15775
		[global::Cpp2ILInjected.Token(Token = "0x4004FEB")]
		public const short DualHook = 437;

		// Token: 0x04003DA0 RID: 15776
		[global::Cpp2ILInjected.Token(Token = "0x4004FEC")]
		public const short StarStatue = 438;

		// Token: 0x04003DA1 RID: 15777
		[global::Cpp2ILInjected.Token(Token = "0x4004FED")]
		public const short SwordStatue = 439;

		// Token: 0x04003DA2 RID: 15778
		[global::Cpp2ILInjected.Token(Token = "0x4004FEE")]
		public const short SlimeStatue = 440;

		// Token: 0x04003DA3 RID: 15779
		[global::Cpp2ILInjected.Token(Token = "0x4004FEF")]
		public const short GoblinStatue = 441;

		// Token: 0x04003DA4 RID: 15780
		[global::Cpp2ILInjected.Token(Token = "0x4004FF0")]
		public const short ShieldStatue = 442;

		// Token: 0x04003DA5 RID: 15781
		[global::Cpp2ILInjected.Token(Token = "0x4004FF1")]
		public const short BatStatue = 443;

		// Token: 0x04003DA6 RID: 15782
		[global::Cpp2ILInjected.Token(Token = "0x4004FF2")]
		public const short FishStatue = 444;

		// Token: 0x04003DA7 RID: 15783
		[global::Cpp2ILInjected.Token(Token = "0x4004FF3")]
		public const short BunnyStatue = 445;

		// Token: 0x04003DA8 RID: 15784
		[global::Cpp2ILInjected.Token(Token = "0x4004FF4")]
		public const short SkeletonStatue = 446;

		// Token: 0x04003DA9 RID: 15785
		[global::Cpp2ILInjected.Token(Token = "0x4004FF5")]
		public const short ReaperStatue = 447;

		// Token: 0x04003DAA RID: 15786
		[global::Cpp2ILInjected.Token(Token = "0x4004FF6")]
		public const short WomanStatue = 448;

		// Token: 0x04003DAB RID: 15787
		[global::Cpp2ILInjected.Token(Token = "0x4004FF7")]
		public const short ImpStatue = 449;

		// Token: 0x04003DAC RID: 15788
		[global::Cpp2ILInjected.Token(Token = "0x4004FF8")]
		public const short GargoyleStatue = 450;

		// Token: 0x04003DAD RID: 15789
		[global::Cpp2ILInjected.Token(Token = "0x4004FF9")]
		public const short GloomStatue = 451;

		// Token: 0x04003DAE RID: 15790
		[global::Cpp2ILInjected.Token(Token = "0x4004FFA")]
		public const short HornetStatue = 452;

		// Token: 0x04003DAF RID: 15791
		[global::Cpp2ILInjected.Token(Token = "0x4004FFB")]
		public const short BombStatue = 453;

		// Token: 0x04003DB0 RID: 15792
		[global::Cpp2ILInjected.Token(Token = "0x4004FFC")]
		public const short CrabStatue = 454;

		// Token: 0x04003DB1 RID: 15793
		[global::Cpp2ILInjected.Token(Token = "0x4004FFD")]
		public const short HammerStatue = 455;

		// Token: 0x04003DB2 RID: 15794
		[global::Cpp2ILInjected.Token(Token = "0x4004FFE")]
		public const short PotionStatue = 456;

		// Token: 0x04003DB3 RID: 15795
		[global::Cpp2ILInjected.Token(Token = "0x4004FFF")]
		public const short SpearStatue = 457;

		// Token: 0x04003DB4 RID: 15796
		[global::Cpp2ILInjected.Token(Token = "0x4005000")]
		public const short CrossStatue = 458;

		// Token: 0x04003DB5 RID: 15797
		[global::Cpp2ILInjected.Token(Token = "0x4005001")]
		public const short JellyfishStatue = 459;

		// Token: 0x04003DB6 RID: 15798
		[global::Cpp2ILInjected.Token(Token = "0x4005002")]
		public const short BowStatue = 460;

		// Token: 0x04003DB7 RID: 15799
		[global::Cpp2ILInjected.Token(Token = "0x4005003")]
		public const short BoomerangStatue = 461;

		// Token: 0x04003DB8 RID: 15800
		[global::Cpp2ILInjected.Token(Token = "0x4005004")]
		public const short BootStatue = 462;

		// Token: 0x04003DB9 RID: 15801
		[global::Cpp2ILInjected.Token(Token = "0x4005005")]
		public const short ChestStatue = 463;

		// Token: 0x04003DBA RID: 15802
		[global::Cpp2ILInjected.Token(Token = "0x4005006")]
		public const short BirdStatue = 464;

		// Token: 0x04003DBB RID: 15803
		[global::Cpp2ILInjected.Token(Token = "0x4005007")]
		public const short AxeStatue = 465;

		// Token: 0x04003DBC RID: 15804
		[global::Cpp2ILInjected.Token(Token = "0x4005008")]
		public const short CorruptStatue = 466;

		// Token: 0x04003DBD RID: 15805
		[global::Cpp2ILInjected.Token(Token = "0x4005009")]
		public const short TreeStatue = 467;

		// Token: 0x04003DBE RID: 15806
		[global::Cpp2ILInjected.Token(Token = "0x400500A")]
		public const short AnvilStatue = 468;

		// Token: 0x04003DBF RID: 15807
		[global::Cpp2ILInjected.Token(Token = "0x400500B")]
		public const short PickaxeStatue = 469;

		// Token: 0x04003DC0 RID: 15808
		[global::Cpp2ILInjected.Token(Token = "0x400500C")]
		public const short MushroomStatue = 470;

		// Token: 0x04003DC1 RID: 15809
		[global::Cpp2ILInjected.Token(Token = "0x400500D")]
		public const short EyeballStatue = 471;

		// Token: 0x04003DC2 RID: 15810
		[global::Cpp2ILInjected.Token(Token = "0x400500E")]
		public const short PillarStatue = 472;

		// Token: 0x04003DC3 RID: 15811
		[global::Cpp2ILInjected.Token(Token = "0x400500F")]
		public const short HeartStatue = 473;

		// Token: 0x04003DC4 RID: 15812
		[global::Cpp2ILInjected.Token(Token = "0x4005010")]
		public const short PotStatue = 474;

		// Token: 0x04003DC5 RID: 15813
		[global::Cpp2ILInjected.Token(Token = "0x4005011")]
		public const short SunflowerStatue = 475;

		// Token: 0x04003DC6 RID: 15814
		[global::Cpp2ILInjected.Token(Token = "0x4005012")]
		public const short KingStatue = 476;

		// Token: 0x04003DC7 RID: 15815
		[global::Cpp2ILInjected.Token(Token = "0x4005013")]
		public const short QueenStatue = 477;

		// Token: 0x04003DC8 RID: 15816
		[global::Cpp2ILInjected.Token(Token = "0x4005014")]
		public const short PiranhaStatue = 478;

		// Token: 0x04003DC9 RID: 15817
		[global::Cpp2ILInjected.Token(Token = "0x4005015")]
		public const short PlankedWall = 479;

		// Token: 0x04003DCA RID: 15818
		[global::Cpp2ILInjected.Token(Token = "0x4005016")]
		public const short WoodenBeam = 480;

		// Token: 0x04003DCB RID: 15819
		[global::Cpp2ILInjected.Token(Token = "0x4005017")]
		public const short AdamantiteRepeater = 481;

		// Token: 0x04003DCC RID: 15820
		[global::Cpp2ILInjected.Token(Token = "0x4005018")]
		public const short AdamantiteSword = 482;

		// Token: 0x04003DCD RID: 15821
		[global::Cpp2ILInjected.Token(Token = "0x4005019")]
		public const short CobaltSword = 483;

		// Token: 0x04003DCE RID: 15822
		[global::Cpp2ILInjected.Token(Token = "0x400501A")]
		public const short MythrilSword = 484;

		// Token: 0x04003DCF RID: 15823
		[global::Cpp2ILInjected.Token(Token = "0x400501B")]
		public const short MoonCharm = 485;

		// Token: 0x04003DD0 RID: 15824
		[global::Cpp2ILInjected.Token(Token = "0x400501C")]
		public const short Ruler = 486;

		// Token: 0x04003DD1 RID: 15825
		[global::Cpp2ILInjected.Token(Token = "0x400501D")]
		public const short CrystalBall = 487;

		// Token: 0x04003DD2 RID: 15826
		[global::Cpp2ILInjected.Token(Token = "0x400501E")]
		public const short DiscoBall = 488;

		// Token: 0x04003DD3 RID: 15827
		[global::Cpp2ILInjected.Token(Token = "0x400501F")]
		public const short SorcererEmblem = 489;

		// Token: 0x04003DD4 RID: 15828
		[global::Cpp2ILInjected.Token(Token = "0x4005020")]
		public const short WarriorEmblem = 490;

		// Token: 0x04003DD5 RID: 15829
		[global::Cpp2ILInjected.Token(Token = "0x4005021")]
		public const short RangerEmblem = 491;

		// Token: 0x04003DD6 RID: 15830
		[global::Cpp2ILInjected.Token(Token = "0x4005022")]
		public const short DemonWings = 492;

		// Token: 0x04003DD7 RID: 15831
		[global::Cpp2ILInjected.Token(Token = "0x4005023")]
		public const short AngelWings = 493;

		// Token: 0x04003DD8 RID: 15832
		[global::Cpp2ILInjected.Token(Token = "0x4005024")]
		public const short MagicalHarp = 494;

		// Token: 0x04003DD9 RID: 15833
		[global::Cpp2ILInjected.Token(Token = "0x4005025")]
		public const short RainbowRod = 495;

		// Token: 0x04003DDA RID: 15834
		[global::Cpp2ILInjected.Token(Token = "0x4005026")]
		public const short IceRod = 496;

		// Token: 0x04003DDB RID: 15835
		[global::Cpp2ILInjected.Token(Token = "0x4005027")]
		public const short NeptunesShell = 497;

		// Token: 0x04003DDC RID: 15836
		[global::Cpp2ILInjected.Token(Token = "0x4005028")]
		public const short Mannequin = 498;

		// Token: 0x04003DDD RID: 15837
		[global::Cpp2ILInjected.Token(Token = "0x4005029")]
		public const short GreaterHealingPotion = 499;

		// Token: 0x04003DDE RID: 15838
		[global::Cpp2ILInjected.Token(Token = "0x400502A")]
		public const short GreaterManaPotion = 500;

		// Token: 0x04003DDF RID: 15839
		[global::Cpp2ILInjected.Token(Token = "0x400502B")]
		public const short PixieDust = 501;

		// Token: 0x04003DE0 RID: 15840
		[global::Cpp2ILInjected.Token(Token = "0x400502C")]
		public const short CrystalShard = 502;

		// Token: 0x04003DE1 RID: 15841
		[global::Cpp2ILInjected.Token(Token = "0x400502D")]
		public const short ClownHat = 503;

		// Token: 0x04003DE2 RID: 15842
		[global::Cpp2ILInjected.Token(Token = "0x400502E")]
		public const short ClownShirt = 504;

		// Token: 0x04003DE3 RID: 15843
		[global::Cpp2ILInjected.Token(Token = "0x400502F")]
		public const short ClownPants = 505;

		// Token: 0x04003DE4 RID: 15844
		[global::Cpp2ILInjected.Token(Token = "0x4005030")]
		public const short Flamethrower = 506;

		// Token: 0x04003DE5 RID: 15845
		[global::Cpp2ILInjected.Token(Token = "0x4005031")]
		public const short Bell = 507;

		// Token: 0x04003DE6 RID: 15846
		[global::Cpp2ILInjected.Token(Token = "0x4005032")]
		public const short Harp = 508;

		// Token: 0x04003DE7 RID: 15847
		[global::Cpp2ILInjected.Token(Token = "0x4005033")]
		public const short Wrench = 509;

		// Token: 0x04003DE8 RID: 15848
		[global::Cpp2ILInjected.Token(Token = "0x4005034")]
		public const short WireCutter = 510;

		// Token: 0x04003DE9 RID: 15849
		[global::Cpp2ILInjected.Token(Token = "0x4005035")]
		public const short ActiveStoneBlock = 511;

		// Token: 0x04003DEA RID: 15850
		[global::Cpp2ILInjected.Token(Token = "0x4005036")]
		public const short InactiveStoneBlock = 512;

		// Token: 0x04003DEB RID: 15851
		[global::Cpp2ILInjected.Token(Token = "0x4005037")]
		public const short Lever = 513;

		// Token: 0x04003DEC RID: 15852
		[global::Cpp2ILInjected.Token(Token = "0x4005038")]
		public const short LaserRifle = 514;

		// Token: 0x04003DED RID: 15853
		[global::Cpp2ILInjected.Token(Token = "0x4005039")]
		public const short CrystalBullet = 515;

		// Token: 0x04003DEE RID: 15854
		[global::Cpp2ILInjected.Token(Token = "0x400503A")]
		public const short HolyArrow = 516;

		// Token: 0x04003DEF RID: 15855
		[global::Cpp2ILInjected.Token(Token = "0x400503B")]
		public const short MagicDagger = 517;

		// Token: 0x04003DF0 RID: 15856
		[global::Cpp2ILInjected.Token(Token = "0x400503C")]
		public const short CrystalStorm = 518;

		// Token: 0x04003DF1 RID: 15857
		[global::Cpp2ILInjected.Token(Token = "0x400503D")]
		public const short CursedFlames = 519;

		// Token: 0x04003DF2 RID: 15858
		[global::Cpp2ILInjected.Token(Token = "0x400503E")]
		public const short SoulofLight = 520;

		// Token: 0x04003DF3 RID: 15859
		[global::Cpp2ILInjected.Token(Token = "0x400503F")]
		public const short SoulofNight = 521;

		// Token: 0x04003DF4 RID: 15860
		[global::Cpp2ILInjected.Token(Token = "0x4005040")]
		public const short CursedFlame = 522;

		// Token: 0x04003DF5 RID: 15861
		[global::Cpp2ILInjected.Token(Token = "0x4005041")]
		public const short CursedTorch = 523;

		// Token: 0x04003DF6 RID: 15862
		[global::Cpp2ILInjected.Token(Token = "0x4005042")]
		public const short AdamantiteForge = 524;

		// Token: 0x04003DF7 RID: 15863
		[global::Cpp2ILInjected.Token(Token = "0x4005043")]
		public const short MythrilAnvil = 525;

		// Token: 0x04003DF8 RID: 15864
		[global::Cpp2ILInjected.Token(Token = "0x4005044")]
		public const short UnicornHorn = 526;

		// Token: 0x04003DF9 RID: 15865
		[global::Cpp2ILInjected.Token(Token = "0x4005045")]
		public const short DarkShard = 527;

		// Token: 0x04003DFA RID: 15866
		[global::Cpp2ILInjected.Token(Token = "0x4005046")]
		public const short LightShard = 528;

		// Token: 0x04003DFB RID: 15867
		[global::Cpp2ILInjected.Token(Token = "0x4005047")]
		public const short RedPressurePlate = 529;

		// Token: 0x04003DFC RID: 15868
		[global::Cpp2ILInjected.Token(Token = "0x4005048")]
		public const short Wire = 530;

		// Token: 0x04003DFD RID: 15869
		[global::Cpp2ILInjected.Token(Token = "0x4005049")]
		public const short SpellTome = 531;

		// Token: 0x04003DFE RID: 15870
		[global::Cpp2ILInjected.Token(Token = "0x400504A")]
		public const short StarCloak = 532;

		// Token: 0x04003DFF RID: 15871
		[global::Cpp2ILInjected.Token(Token = "0x400504B")]
		public const short Megashark = 533;

		// Token: 0x04003E00 RID: 15872
		[global::Cpp2ILInjected.Token(Token = "0x400504C")]
		public const short Shotgun = 534;

		// Token: 0x04003E01 RID: 15873
		[global::Cpp2ILInjected.Token(Token = "0x400504D")]
		public const short PhilosophersStone = 535;

		// Token: 0x04003E02 RID: 15874
		[global::Cpp2ILInjected.Token(Token = "0x400504E")]
		public const short TitanGlove = 536;

		// Token: 0x04003E03 RID: 15875
		[global::Cpp2ILInjected.Token(Token = "0x400504F")]
		public const short CobaltNaginata = 537;

		// Token: 0x04003E04 RID: 15876
		[global::Cpp2ILInjected.Token(Token = "0x4005050")]
		public const short Switch = 538;

		// Token: 0x04003E05 RID: 15877
		[global::Cpp2ILInjected.Token(Token = "0x4005051")]
		public const short DartTrap = 539;

		// Token: 0x04003E06 RID: 15878
		[global::Cpp2ILInjected.Token(Token = "0x4005052")]
		public const short Boulder = 540;

		// Token: 0x04003E07 RID: 15879
		[global::Cpp2ILInjected.Token(Token = "0x4005053")]
		public const short GreenPressurePlate = 541;

		// Token: 0x04003E08 RID: 15880
		[global::Cpp2ILInjected.Token(Token = "0x4005054")]
		public const short GrayPressurePlate = 542;

		// Token: 0x04003E09 RID: 15881
		[global::Cpp2ILInjected.Token(Token = "0x4005055")]
		public const short BrownPressurePlate = 543;

		// Token: 0x04003E0A RID: 15882
		[global::Cpp2ILInjected.Token(Token = "0x4005056")]
		public const short MechanicalEye = 544;

		// Token: 0x04003E0B RID: 15883
		[global::Cpp2ILInjected.Token(Token = "0x4005057")]
		public const short CursedArrow = 545;

		// Token: 0x04003E0C RID: 15884
		[global::Cpp2ILInjected.Token(Token = "0x4005058")]
		public const short CursedBullet = 546;

		// Token: 0x04003E0D RID: 15885
		[global::Cpp2ILInjected.Token(Token = "0x4005059")]
		public const short SoulofFright = 547;

		// Token: 0x04003E0E RID: 15886
		[global::Cpp2ILInjected.Token(Token = "0x400505A")]
		public const short SoulofMight = 548;

		// Token: 0x04003E0F RID: 15887
		[global::Cpp2ILInjected.Token(Token = "0x400505B")]
		public const short SoulofSight = 549;

		// Token: 0x04003E10 RID: 15888
		[global::Cpp2ILInjected.Token(Token = "0x400505C")]
		public const short Gungnir = 550;

		// Token: 0x04003E11 RID: 15889
		[global::Cpp2ILInjected.Token(Token = "0x400505D")]
		public const short HallowedPlateMail = 551;

		// Token: 0x04003E12 RID: 15890
		[global::Cpp2ILInjected.Token(Token = "0x400505E")]
		public const short HallowedGreaves = 552;

		// Token: 0x04003E13 RID: 15891
		[global::Cpp2ILInjected.Token(Token = "0x400505F")]
		public const short HallowedHelmet = 553;

		// Token: 0x04003E14 RID: 15892
		[global::Cpp2ILInjected.Token(Token = "0x4005060")]
		public const short CrossNecklace = 554;

		// Token: 0x04003E15 RID: 15893
		[global::Cpp2ILInjected.Token(Token = "0x4005061")]
		public const short ManaFlower = 555;

		// Token: 0x04003E16 RID: 15894
		[global::Cpp2ILInjected.Token(Token = "0x4005062")]
		public const short MechanicalWorm = 556;

		// Token: 0x04003E17 RID: 15895
		[global::Cpp2ILInjected.Token(Token = "0x4005063")]
		public const short MechanicalSkull = 557;

		// Token: 0x04003E18 RID: 15896
		[global::Cpp2ILInjected.Token(Token = "0x4005064")]
		public const short HallowedHeadgear = 558;

		// Token: 0x04003E19 RID: 15897
		[global::Cpp2ILInjected.Token(Token = "0x4005065")]
		public const short HallowedMask = 559;

		// Token: 0x04003E1A RID: 15898
		[global::Cpp2ILInjected.Token(Token = "0x4005066")]
		public const short SlimeCrown = 560;

		// Token: 0x04003E1B RID: 15899
		[global::Cpp2ILInjected.Token(Token = "0x4005067")]
		public const short LightDisc = 561;

		// Token: 0x04003E1C RID: 15900
		[global::Cpp2ILInjected.Token(Token = "0x4005068")]
		public const short MusicBoxOverworldDay = 562;

		// Token: 0x04003E1D RID: 15901
		[global::Cpp2ILInjected.Token(Token = "0x4005069")]
		public const short MusicBoxEerie = 563;

		// Token: 0x04003E1E RID: 15902
		[global::Cpp2ILInjected.Token(Token = "0x400506A")]
		public const short MusicBoxNight = 564;

		// Token: 0x04003E1F RID: 15903
		[global::Cpp2ILInjected.Token(Token = "0x400506B")]
		public const short MusicBoxTitle = 565;

		// Token: 0x04003E20 RID: 15904
		[global::Cpp2ILInjected.Token(Token = "0x400506C")]
		public const short MusicBoxUnderground = 566;

		// Token: 0x04003E21 RID: 15905
		[global::Cpp2ILInjected.Token(Token = "0x400506D")]
		public const short MusicBoxBoss1 = 567;

		// Token: 0x04003E22 RID: 15906
		[global::Cpp2ILInjected.Token(Token = "0x400506E")]
		public const short MusicBoxJungle = 568;

		// Token: 0x04003E23 RID: 15907
		[global::Cpp2ILInjected.Token(Token = "0x400506F")]
		public const short MusicBoxCorruption = 569;

		// Token: 0x04003E24 RID: 15908
		[global::Cpp2ILInjected.Token(Token = "0x4005070")]
		public const short MusicBoxUndergroundCorruption = 570;

		// Token: 0x04003E25 RID: 15909
		[global::Cpp2ILInjected.Token(Token = "0x4005071")]
		public const short MusicBoxTheHallow = 571;

		// Token: 0x04003E26 RID: 15910
		[global::Cpp2ILInjected.Token(Token = "0x4005072")]
		public const short MusicBoxBoss2 = 572;

		// Token: 0x04003E27 RID: 15911
		[global::Cpp2ILInjected.Token(Token = "0x4005073")]
		public const short MusicBoxUndergroundHallow = 573;

		// Token: 0x04003E28 RID: 15912
		[global::Cpp2ILInjected.Token(Token = "0x4005074")]
		public const short MusicBoxBoss3 = 574;

		// Token: 0x04003E29 RID: 15913
		[global::Cpp2ILInjected.Token(Token = "0x4005075")]
		public const short SoulofFlight = 575;

		// Token: 0x04003E2A RID: 15914
		[global::Cpp2ILInjected.Token(Token = "0x4005076")]
		public const short MusicBox = 576;

		// Token: 0x04003E2B RID: 15915
		[global::Cpp2ILInjected.Token(Token = "0x4005077")]
		public const short DemoniteBrick = 577;

		// Token: 0x04003E2C RID: 15916
		[global::Cpp2ILInjected.Token(Token = "0x4005078")]
		public const short HallowedRepeater = 578;

		// Token: 0x04003E2D RID: 15917
		[global::Cpp2ILInjected.Token(Token = "0x4005079")]
		public const short Drax = 579;

		// Token: 0x04003E2E RID: 15918
		[global::Cpp2ILInjected.Token(Token = "0x400507A")]
		public const short Explosives = 580;

		// Token: 0x04003E2F RID: 15919
		[global::Cpp2ILInjected.Token(Token = "0x400507B")]
		public const short InletPump = 581;

		// Token: 0x04003E30 RID: 15920
		[global::Cpp2ILInjected.Token(Token = "0x400507C")]
		public const short OutletPump = 582;

		// Token: 0x04003E31 RID: 15921
		[global::Cpp2ILInjected.Token(Token = "0x400507D")]
		public const short Timer1Second = 583;

		// Token: 0x04003E32 RID: 15922
		[global::Cpp2ILInjected.Token(Token = "0x400507E")]
		public const short Timer3Second = 584;

		// Token: 0x04003E33 RID: 15923
		[global::Cpp2ILInjected.Token(Token = "0x400507F")]
		public const short Timer5Second = 585;

		// Token: 0x04003E34 RID: 15924
		[global::Cpp2ILInjected.Token(Token = "0x4005080")]
		public const short CandyCaneBlock = 586;

		// Token: 0x04003E35 RID: 15925
		[global::Cpp2ILInjected.Token(Token = "0x4005081")]
		public const short CandyCaneWall = 587;

		// Token: 0x04003E36 RID: 15926
		[global::Cpp2ILInjected.Token(Token = "0x4005082")]
		public const short SantaHat = 588;

		// Token: 0x04003E37 RID: 15927
		[global::Cpp2ILInjected.Token(Token = "0x4005083")]
		public const short SantaShirt = 589;

		// Token: 0x04003E38 RID: 15928
		[global::Cpp2ILInjected.Token(Token = "0x4005084")]
		public const short SantaPants = 590;

		// Token: 0x04003E39 RID: 15929
		[global::Cpp2ILInjected.Token(Token = "0x4005085")]
		public const short GreenCandyCaneBlock = 591;

		// Token: 0x04003E3A RID: 15930
		[global::Cpp2ILInjected.Token(Token = "0x4005086")]
		public const short GreenCandyCaneWall = 592;

		// Token: 0x04003E3B RID: 15931
		[global::Cpp2ILInjected.Token(Token = "0x4005087")]
		public const short SnowBlock = 593;

		// Token: 0x04003E3C RID: 15932
		[global::Cpp2ILInjected.Token(Token = "0x4005088")]
		public const short SnowBrick = 594;

		// Token: 0x04003E3D RID: 15933
		[global::Cpp2ILInjected.Token(Token = "0x4005089")]
		public const short SnowBrickWall = 595;

		// Token: 0x04003E3E RID: 15934
		[global::Cpp2ILInjected.Token(Token = "0x400508A")]
		public const short BlueLight = 596;

		// Token: 0x04003E3F RID: 15935
		[global::Cpp2ILInjected.Token(Token = "0x400508B")]
		public const short RedLight = 597;

		// Token: 0x04003E40 RID: 15936
		[global::Cpp2ILInjected.Token(Token = "0x400508C")]
		public const short GreenLight = 598;

		// Token: 0x04003E41 RID: 15937
		[global::Cpp2ILInjected.Token(Token = "0x400508D")]
		public const short BluePresent = 599;

		// Token: 0x04003E42 RID: 15938
		[global::Cpp2ILInjected.Token(Token = "0x400508E")]
		public const short GreenPresent = 600;

		// Token: 0x04003E43 RID: 15939
		[global::Cpp2ILInjected.Token(Token = "0x400508F")]
		public const short YellowPresent = 601;

		// Token: 0x04003E44 RID: 15940
		[global::Cpp2ILInjected.Token(Token = "0x4005090")]
		public const short SnowGlobe = 602;

		// Token: 0x04003E45 RID: 15941
		[global::Cpp2ILInjected.Token(Token = "0x4005091")]
		public const short Carrot = 603;

		// Token: 0x04003E46 RID: 15942
		[global::Cpp2ILInjected.Token(Token = "0x4005092")]
		public const short AdamantiteBeam = 604;

		// Token: 0x04003E47 RID: 15943
		[global::Cpp2ILInjected.Token(Token = "0x4005093")]
		public const short AdamantiteBeamWall = 605;

		// Token: 0x04003E48 RID: 15944
		[global::Cpp2ILInjected.Token(Token = "0x4005094")]
		public const short DemoniteBrickWall = 606;

		// Token: 0x04003E49 RID: 15945
		[global::Cpp2ILInjected.Token(Token = "0x4005095")]
		public const short SandstoneBrick = 607;

		// Token: 0x04003E4A RID: 15946
		[global::Cpp2ILInjected.Token(Token = "0x4005096")]
		public const short SandstoneBrickWall = 608;

		// Token: 0x04003E4B RID: 15947
		[global::Cpp2ILInjected.Token(Token = "0x4005097")]
		public const short EbonstoneBrick = 609;

		// Token: 0x04003E4C RID: 15948
		[global::Cpp2ILInjected.Token(Token = "0x4005098")]
		public const short EbonstoneBrickWall = 610;

		// Token: 0x04003E4D RID: 15949
		[global::Cpp2ILInjected.Token(Token = "0x4005099")]
		public const short RedStucco = 611;

		// Token: 0x04003E4E RID: 15950
		[global::Cpp2ILInjected.Token(Token = "0x400509A")]
		public const short YellowStucco = 612;

		// Token: 0x04003E4F RID: 15951
		[global::Cpp2ILInjected.Token(Token = "0x400509B")]
		public const short GreenStucco = 613;

		// Token: 0x04003E50 RID: 15952
		[global::Cpp2ILInjected.Token(Token = "0x400509C")]
		public const short GrayStucco = 614;

		// Token: 0x04003E51 RID: 15953
		[global::Cpp2ILInjected.Token(Token = "0x400509D")]
		public const short RedStuccoWall = 615;

		// Token: 0x04003E52 RID: 15954
		[global::Cpp2ILInjected.Token(Token = "0x400509E")]
		public const short YellowStuccoWall = 616;

		// Token: 0x04003E53 RID: 15955
		[global::Cpp2ILInjected.Token(Token = "0x400509F")]
		public const short GreenStuccoWall = 617;

		// Token: 0x04003E54 RID: 15956
		[global::Cpp2ILInjected.Token(Token = "0x40050A0")]
		public const short GrayStuccoWall = 618;

		// Token: 0x04003E55 RID: 15957
		[global::Cpp2ILInjected.Token(Token = "0x40050A1")]
		public const short Ebonwood = 619;

		// Token: 0x04003E56 RID: 15958
		[global::Cpp2ILInjected.Token(Token = "0x40050A2")]
		public const short RichMahogany = 620;

		// Token: 0x04003E57 RID: 15959
		[global::Cpp2ILInjected.Token(Token = "0x40050A3")]
		public const short Pearlwood = 621;

		// Token: 0x04003E58 RID: 15960
		[global::Cpp2ILInjected.Token(Token = "0x40050A4")]
		public const short EbonwoodWall = 622;

		// Token: 0x04003E59 RID: 15961
		[global::Cpp2ILInjected.Token(Token = "0x40050A5")]
		public const short RichMahoganyWall = 623;

		// Token: 0x04003E5A RID: 15962
		[global::Cpp2ILInjected.Token(Token = "0x40050A6")]
		public const short PearlwoodWall = 624;

		// Token: 0x04003E5B RID: 15963
		[global::Cpp2ILInjected.Token(Token = "0x40050A7")]
		public const short EbonwoodChest = 625;

		// Token: 0x04003E5C RID: 15964
		[global::Cpp2ILInjected.Token(Token = "0x40050A8")]
		public const short RichMahoganyChest = 626;

		// Token: 0x04003E5D RID: 15965
		[global::Cpp2ILInjected.Token(Token = "0x40050A9")]
		public const short PearlwoodChest = 627;

		// Token: 0x04003E5E RID: 15966
		[global::Cpp2ILInjected.Token(Token = "0x40050AA")]
		public const short EbonwoodChair = 628;

		// Token: 0x04003E5F RID: 15967
		[global::Cpp2ILInjected.Token(Token = "0x40050AB")]
		public const short RichMahoganyChair = 629;

		// Token: 0x04003E60 RID: 15968
		[global::Cpp2ILInjected.Token(Token = "0x40050AC")]
		public const short PearlwoodChair = 630;

		// Token: 0x04003E61 RID: 15969
		[global::Cpp2ILInjected.Token(Token = "0x40050AD")]
		public const short EbonwoodPlatform = 631;

		// Token: 0x04003E62 RID: 15970
		[global::Cpp2ILInjected.Token(Token = "0x40050AE")]
		public const short RichMahoganyPlatform = 632;

		// Token: 0x04003E63 RID: 15971
		[global::Cpp2ILInjected.Token(Token = "0x40050AF")]
		public const short PearlwoodPlatform = 633;

		// Token: 0x04003E64 RID: 15972
		[global::Cpp2ILInjected.Token(Token = "0x40050B0")]
		public const short BonePlatform = 634;

		// Token: 0x04003E65 RID: 15973
		[global::Cpp2ILInjected.Token(Token = "0x40050B1")]
		public const short EbonwoodWorkBench = 635;

		// Token: 0x04003E66 RID: 15974
		[global::Cpp2ILInjected.Token(Token = "0x40050B2")]
		public const short RichMahoganyWorkBench = 636;

		// Token: 0x04003E67 RID: 15975
		[global::Cpp2ILInjected.Token(Token = "0x40050B3")]
		public const short PearlwoodWorkBench = 637;

		// Token: 0x04003E68 RID: 15976
		[global::Cpp2ILInjected.Token(Token = "0x40050B4")]
		public const short EbonwoodTable = 638;

		// Token: 0x04003E69 RID: 15977
		[global::Cpp2ILInjected.Token(Token = "0x40050B5")]
		public const short RichMahoganyTable = 639;

		// Token: 0x04003E6A RID: 15978
		[global::Cpp2ILInjected.Token(Token = "0x40050B6")]
		public const short PearlwoodTable = 640;

		// Token: 0x04003E6B RID: 15979
		[global::Cpp2ILInjected.Token(Token = "0x40050B7")]
		public const short EbonwoodPiano = 641;

		// Token: 0x04003E6C RID: 15980
		[global::Cpp2ILInjected.Token(Token = "0x40050B8")]
		public const short RichMahoganyPiano = 642;

		// Token: 0x04003E6D RID: 15981
		[global::Cpp2ILInjected.Token(Token = "0x40050B9")]
		public const short PearlwoodPiano = 643;

		// Token: 0x04003E6E RID: 15982
		[global::Cpp2ILInjected.Token(Token = "0x40050BA")]
		public const short EbonwoodBed = 644;

		// Token: 0x04003E6F RID: 15983
		[global::Cpp2ILInjected.Token(Token = "0x40050BB")]
		public const short RichMahoganyBed = 645;

		// Token: 0x04003E70 RID: 15984
		[global::Cpp2ILInjected.Token(Token = "0x40050BC")]
		public const short PearlwoodBed = 646;

		// Token: 0x04003E71 RID: 15985
		[global::Cpp2ILInjected.Token(Token = "0x40050BD")]
		public const short EbonwoodDresser = 647;

		// Token: 0x04003E72 RID: 15986
		[global::Cpp2ILInjected.Token(Token = "0x40050BE")]
		public const short RichMahoganyDresser = 648;

		// Token: 0x04003E73 RID: 15987
		[global::Cpp2ILInjected.Token(Token = "0x40050BF")]
		public const short PearlwoodDresser = 649;

		// Token: 0x04003E74 RID: 15988
		[global::Cpp2ILInjected.Token(Token = "0x40050C0")]
		public const short EbonwoodDoor = 650;

		// Token: 0x04003E75 RID: 15989
		[global::Cpp2ILInjected.Token(Token = "0x40050C1")]
		public const short RichMahoganyDoor = 651;

		// Token: 0x04003E76 RID: 15990
		[global::Cpp2ILInjected.Token(Token = "0x40050C2")]
		public const short PearlwoodDoor = 652;

		// Token: 0x04003E77 RID: 15991
		[global::Cpp2ILInjected.Token(Token = "0x40050C3")]
		public const short EbonwoodSword = 653;

		// Token: 0x04003E78 RID: 15992
		[global::Cpp2ILInjected.Token(Token = "0x40050C4")]
		public const short EbonwoodHammer = 654;

		// Token: 0x04003E79 RID: 15993
		[global::Cpp2ILInjected.Token(Token = "0x40050C5")]
		public const short EbonwoodBow = 655;

		// Token: 0x04003E7A RID: 15994
		[global::Cpp2ILInjected.Token(Token = "0x40050C6")]
		public const short RichMahoganySword = 656;

		// Token: 0x04003E7B RID: 15995
		[global::Cpp2ILInjected.Token(Token = "0x40050C7")]
		public const short RichMahoganyHammer = 657;

		// Token: 0x04003E7C RID: 15996
		[global::Cpp2ILInjected.Token(Token = "0x40050C8")]
		public const short RichMahoganyBow = 658;

		// Token: 0x04003E7D RID: 15997
		[global::Cpp2ILInjected.Token(Token = "0x40050C9")]
		public const short PearlwoodSword = 659;

		// Token: 0x04003E7E RID: 15998
		[global::Cpp2ILInjected.Token(Token = "0x40050CA")]
		public const short PearlwoodHammer = 660;

		// Token: 0x04003E7F RID: 15999
		[global::Cpp2ILInjected.Token(Token = "0x40050CB")]
		public const short PearlwoodBow = 661;

		// Token: 0x04003E80 RID: 16000
		[global::Cpp2ILInjected.Token(Token = "0x40050CC")]
		public const short RainbowBrick = 662;

		// Token: 0x04003E81 RID: 16001
		[global::Cpp2ILInjected.Token(Token = "0x40050CD")]
		public const short RainbowBrickWall = 663;

		// Token: 0x04003E82 RID: 16002
		[global::Cpp2ILInjected.Token(Token = "0x40050CE")]
		public const short IceBlock = 664;

		// Token: 0x04003E83 RID: 16003
		[global::Cpp2ILInjected.Token(Token = "0x40050CF")]
		public const short RedsWings = 665;

		// Token: 0x04003E84 RID: 16004
		[global::Cpp2ILInjected.Token(Token = "0x40050D0")]
		public const short RedsHelmet = 666;

		// Token: 0x04003E85 RID: 16005
		[global::Cpp2ILInjected.Token(Token = "0x40050D1")]
		public const short RedsBreastplate = 667;

		// Token: 0x04003E86 RID: 16006
		[global::Cpp2ILInjected.Token(Token = "0x40050D2")]
		public const short RedsLeggings = 668;

		// Token: 0x04003E87 RID: 16007
		[global::Cpp2ILInjected.Token(Token = "0x40050D3")]
		public const short Fish = 669;

		// Token: 0x04003E88 RID: 16008
		[global::Cpp2ILInjected.Token(Token = "0x40050D4")]
		public const short IceBoomerang = 670;

		// Token: 0x04003E89 RID: 16009
		[global::Cpp2ILInjected.Token(Token = "0x40050D5")]
		public const short Keybrand = 671;

		// Token: 0x04003E8A RID: 16010
		[global::Cpp2ILInjected.Token(Token = "0x40050D6")]
		public const short Cutlass = 672;

		// Token: 0x04003E8B RID: 16011
		[global::Cpp2ILInjected.Token(Token = "0x40050D7")]
		public const short BorealWoodWorkBench = 673;

		// Token: 0x04003E8C RID: 16012
		[global::Cpp2ILInjected.Token(Token = "0x40050D8")]
		public const short TrueExcalibur = 674;

		// Token: 0x04003E8D RID: 16013
		[global::Cpp2ILInjected.Token(Token = "0x40050D9")]
		public const short TrueNightsEdge = 675;

		// Token: 0x04003E8E RID: 16014
		[global::Cpp2ILInjected.Token(Token = "0x40050DA")]
		public const short Frostbrand = 676;

		// Token: 0x04003E8F RID: 16015
		[global::Cpp2ILInjected.Token(Token = "0x40050DB")]
		public const short BorealWoodTable = 677;

		// Token: 0x04003E90 RID: 16016
		[global::Cpp2ILInjected.Token(Token = "0x40050DC")]
		public const short RedPotion = 678;

		// Token: 0x04003E91 RID: 16017
		[global::Cpp2ILInjected.Token(Token = "0x40050DD")]
		public const short TacticalShotgun = 679;

		// Token: 0x04003E92 RID: 16018
		[global::Cpp2ILInjected.Token(Token = "0x40050DE")]
		public const short IvyChest = 680;

		// Token: 0x04003E93 RID: 16019
		[global::Cpp2ILInjected.Token(Token = "0x40050DF")]
		public const short IceChest = 681;

		// Token: 0x04003E94 RID: 16020
		[global::Cpp2ILInjected.Token(Token = "0x40050E0")]
		public const short Marrow = 682;

		// Token: 0x04003E95 RID: 16021
		[global::Cpp2ILInjected.Token(Token = "0x40050E1")]
		public const short UnholyTrident = 683;

		// Token: 0x04003E96 RID: 16022
		[global::Cpp2ILInjected.Token(Token = "0x40050E2")]
		public const short FrostHelmet = 684;

		// Token: 0x04003E97 RID: 16023
		[global::Cpp2ILInjected.Token(Token = "0x40050E3")]
		public const short FrostBreastplate = 685;

		// Token: 0x04003E98 RID: 16024
		[global::Cpp2ILInjected.Token(Token = "0x40050E4")]
		public const short FrostLeggings = 686;

		// Token: 0x04003E99 RID: 16025
		[global::Cpp2ILInjected.Token(Token = "0x40050E5")]
		public const short TinHelmet = 687;

		// Token: 0x04003E9A RID: 16026
		[global::Cpp2ILInjected.Token(Token = "0x40050E6")]
		public const short TinChainmail = 688;

		// Token: 0x04003E9B RID: 16027
		[global::Cpp2ILInjected.Token(Token = "0x40050E7")]
		public const short TinGreaves = 689;

		// Token: 0x04003E9C RID: 16028
		[global::Cpp2ILInjected.Token(Token = "0x40050E8")]
		public const short LeadHelmet = 690;

		// Token: 0x04003E9D RID: 16029
		[global::Cpp2ILInjected.Token(Token = "0x40050E9")]
		public const short LeadChainmail = 691;

		// Token: 0x04003E9E RID: 16030
		[global::Cpp2ILInjected.Token(Token = "0x40050EA")]
		public const short LeadGreaves = 692;

		// Token: 0x04003E9F RID: 16031
		[global::Cpp2ILInjected.Token(Token = "0x40050EB")]
		public const short TungstenHelmet = 693;

		// Token: 0x04003EA0 RID: 16032
		[global::Cpp2ILInjected.Token(Token = "0x40050EC")]
		public const short TungstenChainmail = 694;

		// Token: 0x04003EA1 RID: 16033
		[global::Cpp2ILInjected.Token(Token = "0x40050ED")]
		public const short TungstenGreaves = 695;

		// Token: 0x04003EA2 RID: 16034
		[global::Cpp2ILInjected.Token(Token = "0x40050EE")]
		public const short PlatinumHelmet = 696;

		// Token: 0x04003EA3 RID: 16035
		[global::Cpp2ILInjected.Token(Token = "0x40050EF")]
		public const short PlatinumChainmail = 697;

		// Token: 0x04003EA4 RID: 16036
		[global::Cpp2ILInjected.Token(Token = "0x40050F0")]
		public const short PlatinumGreaves = 698;

		// Token: 0x04003EA5 RID: 16037
		[global::Cpp2ILInjected.Token(Token = "0x40050F1")]
		public const short TinOre = 699;

		// Token: 0x04003EA6 RID: 16038
		[global::Cpp2ILInjected.Token(Token = "0x40050F2")]
		public const short LeadOre = 700;

		// Token: 0x04003EA7 RID: 16039
		[global::Cpp2ILInjected.Token(Token = "0x40050F3")]
		public const short TungstenOre = 701;

		// Token: 0x04003EA8 RID: 16040
		[global::Cpp2ILInjected.Token(Token = "0x40050F4")]
		public const short PlatinumOre = 702;

		// Token: 0x04003EA9 RID: 16041
		[global::Cpp2ILInjected.Token(Token = "0x40050F5")]
		public const short TinBar = 703;

		// Token: 0x04003EAA RID: 16042
		[global::Cpp2ILInjected.Token(Token = "0x40050F6")]
		public const short LeadBar = 704;

		// Token: 0x04003EAB RID: 16043
		[global::Cpp2ILInjected.Token(Token = "0x40050F7")]
		public const short TungstenBar = 705;

		// Token: 0x04003EAC RID: 16044
		[global::Cpp2ILInjected.Token(Token = "0x40050F8")]
		public const short PlatinumBar = 706;

		// Token: 0x04003EAD RID: 16045
		[global::Cpp2ILInjected.Token(Token = "0x40050F9")]
		public const short TinWatch = 707;

		// Token: 0x04003EAE RID: 16046
		[global::Cpp2ILInjected.Token(Token = "0x40050FA")]
		public const short TungstenWatch = 708;

		// Token: 0x04003EAF RID: 16047
		[global::Cpp2ILInjected.Token(Token = "0x40050FB")]
		public const short PlatinumWatch = 709;

		// Token: 0x04003EB0 RID: 16048
		[global::Cpp2ILInjected.Token(Token = "0x40050FC")]
		public const short TinChandelier = 710;

		// Token: 0x04003EB1 RID: 16049
		[global::Cpp2ILInjected.Token(Token = "0x40050FD")]
		public const short TungstenChandelier = 711;

		// Token: 0x04003EB2 RID: 16050
		[global::Cpp2ILInjected.Token(Token = "0x40050FE")]
		public const short PlatinumChandelier = 712;

		// Token: 0x04003EB3 RID: 16051
		[global::Cpp2ILInjected.Token(Token = "0x40050FF")]
		public const short PlatinumCandle = 713;

		// Token: 0x04003EB4 RID: 16052
		[global::Cpp2ILInjected.Token(Token = "0x4005100")]
		public const short PlatinumCandelabra = 714;

		// Token: 0x04003EB5 RID: 16053
		[global::Cpp2ILInjected.Token(Token = "0x4005101")]
		public const short PlatinumCrown = 715;

		// Token: 0x04003EB6 RID: 16054
		[global::Cpp2ILInjected.Token(Token = "0x4005102")]
		public const short LeadAnvil = 716;

		// Token: 0x04003EB7 RID: 16055
		[global::Cpp2ILInjected.Token(Token = "0x4005103")]
		public const short TinBrick = 717;

		// Token: 0x04003EB8 RID: 16056
		[global::Cpp2ILInjected.Token(Token = "0x4005104")]
		public const short TungstenBrick = 718;

		// Token: 0x04003EB9 RID: 16057
		[global::Cpp2ILInjected.Token(Token = "0x4005105")]
		public const short PlatinumBrick = 719;

		// Token: 0x04003EBA RID: 16058
		[global::Cpp2ILInjected.Token(Token = "0x4005106")]
		public const short TinBrickWall = 720;

		// Token: 0x04003EBB RID: 16059
		[global::Cpp2ILInjected.Token(Token = "0x4005107")]
		public const short TungstenBrickWall = 721;

		// Token: 0x04003EBC RID: 16060
		[global::Cpp2ILInjected.Token(Token = "0x4005108")]
		public const short PlatinumBrickWall = 722;

		// Token: 0x04003EBD RID: 16061
		[global::Cpp2ILInjected.Token(Token = "0x4005109")]
		public const short BeamSword = 723;

		// Token: 0x04003EBE RID: 16062
		[global::Cpp2ILInjected.Token(Token = "0x400510A")]
		public const short IceBlade = 724;

		// Token: 0x04003EBF RID: 16063
		[global::Cpp2ILInjected.Token(Token = "0x400510B")]
		public const short IceBow = 725;

		// Token: 0x04003EC0 RID: 16064
		[global::Cpp2ILInjected.Token(Token = "0x400510C")]
		public const short FrostStaff = 726;

		// Token: 0x04003EC1 RID: 16065
		[global::Cpp2ILInjected.Token(Token = "0x400510D")]
		public const short WoodHelmet = 727;

		// Token: 0x04003EC2 RID: 16066
		[global::Cpp2ILInjected.Token(Token = "0x400510E")]
		public const short WoodBreastplate = 728;

		// Token: 0x04003EC3 RID: 16067
		[global::Cpp2ILInjected.Token(Token = "0x400510F")]
		public const short WoodGreaves = 729;

		// Token: 0x04003EC4 RID: 16068
		[global::Cpp2ILInjected.Token(Token = "0x4005110")]
		public const short EbonwoodHelmet = 730;

		// Token: 0x04003EC5 RID: 16069
		[global::Cpp2ILInjected.Token(Token = "0x4005111")]
		public const short EbonwoodBreastplate = 731;

		// Token: 0x04003EC6 RID: 16070
		[global::Cpp2ILInjected.Token(Token = "0x4005112")]
		public const short EbonwoodGreaves = 732;

		// Token: 0x04003EC7 RID: 16071
		[global::Cpp2ILInjected.Token(Token = "0x4005113")]
		public const short RichMahoganyHelmet = 733;

		// Token: 0x04003EC8 RID: 16072
		[global::Cpp2ILInjected.Token(Token = "0x4005114")]
		public const short RichMahoganyBreastplate = 734;

		// Token: 0x04003EC9 RID: 16073
		[global::Cpp2ILInjected.Token(Token = "0x4005115")]
		public const short RichMahoganyGreaves = 735;

		// Token: 0x04003ECA RID: 16074
		[global::Cpp2ILInjected.Token(Token = "0x4005116")]
		public const short PearlwoodHelmet = 736;

		// Token: 0x04003ECB RID: 16075
		[global::Cpp2ILInjected.Token(Token = "0x4005117")]
		public const short PearlwoodBreastplate = 737;

		// Token: 0x04003ECC RID: 16076
		[global::Cpp2ILInjected.Token(Token = "0x4005118")]
		public const short PearlwoodGreaves = 738;

		// Token: 0x04003ECD RID: 16077
		[global::Cpp2ILInjected.Token(Token = "0x4005119")]
		public const short AmethystStaff = 739;

		// Token: 0x04003ECE RID: 16078
		[global::Cpp2ILInjected.Token(Token = "0x400511A")]
		public const short TopazStaff = 740;

		// Token: 0x04003ECF RID: 16079
		[global::Cpp2ILInjected.Token(Token = "0x400511B")]
		public const short SapphireStaff = 741;

		// Token: 0x04003ED0 RID: 16080
		[global::Cpp2ILInjected.Token(Token = "0x400511C")]
		public const short EmeraldStaff = 742;

		// Token: 0x04003ED1 RID: 16081
		[global::Cpp2ILInjected.Token(Token = "0x400511D")]
		public const short RubyStaff = 743;

		// Token: 0x04003ED2 RID: 16082
		[global::Cpp2ILInjected.Token(Token = "0x400511E")]
		public const short DiamondStaff = 744;

		// Token: 0x04003ED3 RID: 16083
		[global::Cpp2ILInjected.Token(Token = "0x400511F")]
		public const short GrassWall = 745;

		// Token: 0x04003ED4 RID: 16084
		[global::Cpp2ILInjected.Token(Token = "0x4005120")]
		public const short JungleWall = 746;

		// Token: 0x04003ED5 RID: 16085
		[global::Cpp2ILInjected.Token(Token = "0x4005121")]
		public const short FlowerWall = 747;

		// Token: 0x04003ED6 RID: 16086
		[global::Cpp2ILInjected.Token(Token = "0x4005122")]
		public const short Jetpack = 748;

		// Token: 0x04003ED7 RID: 16087
		[global::Cpp2ILInjected.Token(Token = "0x4005123")]
		public const short ButterflyWings = 749;

		// Token: 0x04003ED8 RID: 16088
		[global::Cpp2ILInjected.Token(Token = "0x4005124")]
		public const short CactusWall = 750;

		// Token: 0x04003ED9 RID: 16089
		[global::Cpp2ILInjected.Token(Token = "0x4005125")]
		public const short Cloud = 751;

		// Token: 0x04003EDA RID: 16090
		[global::Cpp2ILInjected.Token(Token = "0x4005126")]
		public const short CloudWall = 752;

		// Token: 0x04003EDB RID: 16091
		[global::Cpp2ILInjected.Token(Token = "0x4005127")]
		public const short Seaweed = 753;

		// Token: 0x04003EDC RID: 16092
		[global::Cpp2ILInjected.Token(Token = "0x4005128")]
		public const short RuneHat = 754;

		// Token: 0x04003EDD RID: 16093
		[global::Cpp2ILInjected.Token(Token = "0x4005129")]
		public const short RuneRobe = 755;

		// Token: 0x04003EDE RID: 16094
		[global::Cpp2ILInjected.Token(Token = "0x400512A")]
		public const short MushroomSpear = 756;

		// Token: 0x04003EDF RID: 16095
		[global::Cpp2ILInjected.Token(Token = "0x400512B")]
		public const short TerraBlade = 757;

		// Token: 0x04003EE0 RID: 16096
		[global::Cpp2ILInjected.Token(Token = "0x400512C")]
		public const short GrenadeLauncher = 758;

		// Token: 0x04003EE1 RID: 16097
		[global::Cpp2ILInjected.Token(Token = "0x400512D")]
		public const short RocketLauncher = 759;

		// Token: 0x04003EE2 RID: 16098
		[global::Cpp2ILInjected.Token(Token = "0x400512E")]
		public const short ProximityMineLauncher = 760;

		// Token: 0x04003EE3 RID: 16099
		[global::Cpp2ILInjected.Token(Token = "0x400512F")]
		public const short FairyWings = 761;

		// Token: 0x04003EE4 RID: 16100
		[global::Cpp2ILInjected.Token(Token = "0x4005130")]
		public const short SlimeBlock = 762;

		// Token: 0x04003EE5 RID: 16101
		[global::Cpp2ILInjected.Token(Token = "0x4005131")]
		public const short FleshBlock = 763;

		// Token: 0x04003EE6 RID: 16102
		[global::Cpp2ILInjected.Token(Token = "0x4005132")]
		public const short MushroomWall = 764;

		// Token: 0x04003EE7 RID: 16103
		[global::Cpp2ILInjected.Token(Token = "0x4005133")]
		public const short RainCloud = 765;

		// Token: 0x04003EE8 RID: 16104
		[global::Cpp2ILInjected.Token(Token = "0x4005134")]
		public const short BoneBlock = 766;

		// Token: 0x04003EE9 RID: 16105
		[global::Cpp2ILInjected.Token(Token = "0x4005135")]
		public const short FrozenSlimeBlock = 767;

		// Token: 0x04003EEA RID: 16106
		[global::Cpp2ILInjected.Token(Token = "0x4005136")]
		public const short BoneBlockWall = 768;

		// Token: 0x04003EEB RID: 16107
		[global::Cpp2ILInjected.Token(Token = "0x4005137")]
		public const short SlimeBlockWall = 769;

		// Token: 0x04003EEC RID: 16108
		[global::Cpp2ILInjected.Token(Token = "0x4005138")]
		public const short FleshBlockWall = 770;

		// Token: 0x04003EED RID: 16109
		[global::Cpp2ILInjected.Token(Token = "0x4005139")]
		public const short RocketI = 771;

		// Token: 0x04003EEE RID: 16110
		[global::Cpp2ILInjected.Token(Token = "0x400513A")]
		public const short RocketII = 772;

		// Token: 0x04003EEF RID: 16111
		[global::Cpp2ILInjected.Token(Token = "0x400513B")]
		public const short RocketIII = 773;

		// Token: 0x04003EF0 RID: 16112
		[global::Cpp2ILInjected.Token(Token = "0x400513C")]
		public const short RocketIV = 774;

		// Token: 0x04003EF1 RID: 16113
		[global::Cpp2ILInjected.Token(Token = "0x400513D")]
		public const short AsphaltBlock = 775;

		// Token: 0x04003EF2 RID: 16114
		[global::Cpp2ILInjected.Token(Token = "0x400513E")]
		public const short CobaltPickaxe = 776;

		// Token: 0x04003EF3 RID: 16115
		[global::Cpp2ILInjected.Token(Token = "0x400513F")]
		public const short MythrilPickaxe = 777;

		// Token: 0x04003EF4 RID: 16116
		[global::Cpp2ILInjected.Token(Token = "0x4005140")]
		public const short AdamantitePickaxe = 778;

		// Token: 0x04003EF5 RID: 16117
		[global::Cpp2ILInjected.Token(Token = "0x4005141")]
		public const short Clentaminator = 779;

		// Token: 0x04003EF6 RID: 16118
		[global::Cpp2ILInjected.Token(Token = "0x4005142")]
		public const short GreenSolution = 780;

		// Token: 0x04003EF7 RID: 16119
		[global::Cpp2ILInjected.Token(Token = "0x4005143")]
		public const short BlueSolution = 781;

		// Token: 0x04003EF8 RID: 16120
		[global::Cpp2ILInjected.Token(Token = "0x4005144")]
		public const short PurpleSolution = 782;

		// Token: 0x04003EF9 RID: 16121
		[global::Cpp2ILInjected.Token(Token = "0x4005145")]
		public const short DarkBlueSolution = 783;

		// Token: 0x04003EFA RID: 16122
		[global::Cpp2ILInjected.Token(Token = "0x4005146")]
		public const short RedSolution = 784;

		// Token: 0x04003EFB RID: 16123
		[global::Cpp2ILInjected.Token(Token = "0x4005147")]
		public const short HarpyWings = 785;

		// Token: 0x04003EFC RID: 16124
		[global::Cpp2ILInjected.Token(Token = "0x4005148")]
		public const short BoneWings = 786;

		// Token: 0x04003EFD RID: 16125
		[global::Cpp2ILInjected.Token(Token = "0x4005149")]
		public const short Hammush = 787;

		// Token: 0x04003EFE RID: 16126
		[global::Cpp2ILInjected.Token(Token = "0x400514A")]
		public const short NettleBurst = 788;

		// Token: 0x04003EFF RID: 16127
		[global::Cpp2ILInjected.Token(Token = "0x400514B")]
		public const short AnkhBanner = 789;

		// Token: 0x04003F00 RID: 16128
		[global::Cpp2ILInjected.Token(Token = "0x400514C")]
		public const short SnakeBanner = 790;

		// Token: 0x04003F01 RID: 16129
		[global::Cpp2ILInjected.Token(Token = "0x400514D")]
		public const short OmegaBanner = 791;

		// Token: 0x04003F02 RID: 16130
		[global::Cpp2ILInjected.Token(Token = "0x400514E")]
		public const short CrimsonHelmet = 792;

		// Token: 0x04003F03 RID: 16131
		[global::Cpp2ILInjected.Token(Token = "0x400514F")]
		public const short CrimsonScalemail = 793;

		// Token: 0x04003F04 RID: 16132
		[global::Cpp2ILInjected.Token(Token = "0x4005150")]
		public const short CrimsonGreaves = 794;

		// Token: 0x04003F05 RID: 16133
		[global::Cpp2ILInjected.Token(Token = "0x4005151")]
		public const short BloodButcherer = 795;

		// Token: 0x04003F06 RID: 16134
		[global::Cpp2ILInjected.Token(Token = "0x4005152")]
		public const short TendonBow = 796;

		// Token: 0x04003F07 RID: 16135
		[global::Cpp2ILInjected.Token(Token = "0x4005153")]
		public const short FleshGrinder = 797;

		// Token: 0x04003F08 RID: 16136
		[global::Cpp2ILInjected.Token(Token = "0x4005154")]
		public const short DeathbringerPickaxe = 798;

		// Token: 0x04003F09 RID: 16137
		[global::Cpp2ILInjected.Token(Token = "0x4005155")]
		public const short BloodLustCluster = 799;

		// Token: 0x04003F0A RID: 16138
		[global::Cpp2ILInjected.Token(Token = "0x4005156")]
		public const short TheUndertaker = 800;

		// Token: 0x04003F0B RID: 16139
		[global::Cpp2ILInjected.Token(Token = "0x4005157")]
		public const short TheMeatball = 801;

		// Token: 0x04003F0C RID: 16140
		[global::Cpp2ILInjected.Token(Token = "0x4005158")]
		public const short TheRottedFork = 802;

		// Token: 0x04003F0D RID: 16141
		[global::Cpp2ILInjected.Token(Token = "0x4005159")]
		public const short EskimoHood = 803;

		// Token: 0x04003F0E RID: 16142
		[global::Cpp2ILInjected.Token(Token = "0x400515A")]
		public const short EskimoCoat = 804;

		// Token: 0x04003F0F RID: 16143
		[global::Cpp2ILInjected.Token(Token = "0x400515B")]
		public const short EskimoPants = 805;

		// Token: 0x04003F10 RID: 16144
		[global::Cpp2ILInjected.Token(Token = "0x400515C")]
		public const short LivingWoodChair = 806;

		// Token: 0x04003F11 RID: 16145
		[global::Cpp2ILInjected.Token(Token = "0x400515D")]
		public const short CactusChair = 807;

		// Token: 0x04003F12 RID: 16146
		[global::Cpp2ILInjected.Token(Token = "0x400515E")]
		public const short BoneChair = 808;

		// Token: 0x04003F13 RID: 16147
		[global::Cpp2ILInjected.Token(Token = "0x400515F")]
		public const short FleshChair = 809;

		// Token: 0x04003F14 RID: 16148
		[global::Cpp2ILInjected.Token(Token = "0x4005160")]
		public const short MushroomChair = 810;

		// Token: 0x04003F15 RID: 16149
		[global::Cpp2ILInjected.Token(Token = "0x4005161")]
		public const short BoneWorkBench = 811;

		// Token: 0x04003F16 RID: 16150
		[global::Cpp2ILInjected.Token(Token = "0x4005162")]
		public const short CactusWorkBench = 812;

		// Token: 0x04003F17 RID: 16151
		[global::Cpp2ILInjected.Token(Token = "0x4005163")]
		public const short FleshWorkBench = 813;

		// Token: 0x04003F18 RID: 16152
		[global::Cpp2ILInjected.Token(Token = "0x4005164")]
		public const short MushroomWorkBench = 814;

		// Token: 0x04003F19 RID: 16153
		[global::Cpp2ILInjected.Token(Token = "0x4005165")]
		public const short SlimeWorkBench = 815;

		// Token: 0x04003F1A RID: 16154
		[global::Cpp2ILInjected.Token(Token = "0x4005166")]
		public const short CactusDoor = 816;

		// Token: 0x04003F1B RID: 16155
		[global::Cpp2ILInjected.Token(Token = "0x4005167")]
		public const short FleshDoor = 817;

		// Token: 0x04003F1C RID: 16156
		[global::Cpp2ILInjected.Token(Token = "0x4005168")]
		public const short MushroomDoor = 818;

		// Token: 0x04003F1D RID: 16157
		[global::Cpp2ILInjected.Token(Token = "0x4005169")]
		public const short LivingWoodDoor = 819;

		// Token: 0x04003F1E RID: 16158
		[global::Cpp2ILInjected.Token(Token = "0x400516A")]
		public const short BoneDoor = 820;

		// Token: 0x04003F1F RID: 16159
		[global::Cpp2ILInjected.Token(Token = "0x400516B")]
		public const short FlameWings = 821;

		// Token: 0x04003F20 RID: 16160
		[global::Cpp2ILInjected.Token(Token = "0x400516C")]
		public const short FrozenWings = 822;

		// Token: 0x04003F21 RID: 16161
		[global::Cpp2ILInjected.Token(Token = "0x400516D")]
		public const short GhostWings = 823;

		// Token: 0x04003F22 RID: 16162
		[global::Cpp2ILInjected.Token(Token = "0x400516E")]
		public const short SunplateBlock = 824;

		// Token: 0x04003F23 RID: 16163
		[global::Cpp2ILInjected.Token(Token = "0x400516F")]
		public const short DiscWall = 825;

		// Token: 0x04003F24 RID: 16164
		[global::Cpp2ILInjected.Token(Token = "0x4005170")]
		public const short SkywareChair = 826;

		// Token: 0x04003F25 RID: 16165
		[global::Cpp2ILInjected.Token(Token = "0x4005171")]
		public const short BoneTable = 827;

		// Token: 0x04003F26 RID: 16166
		[global::Cpp2ILInjected.Token(Token = "0x4005172")]
		public const short FleshTable = 828;

		// Token: 0x04003F27 RID: 16167
		[global::Cpp2ILInjected.Token(Token = "0x4005173")]
		public const short LivingWoodTable = 829;

		// Token: 0x04003F28 RID: 16168
		[global::Cpp2ILInjected.Token(Token = "0x4005174")]
		public const short SkywareTable = 830;

		// Token: 0x04003F29 RID: 16169
		[global::Cpp2ILInjected.Token(Token = "0x4005175")]
		public const short LivingWoodChest = 831;

		// Token: 0x04003F2A RID: 16170
		[global::Cpp2ILInjected.Token(Token = "0x4005176")]
		public const short LivingWoodWand = 832;

		// Token: 0x04003F2B RID: 16171
		[global::Cpp2ILInjected.Token(Token = "0x4005177")]
		public const short PurpleIceBlock = 833;

		// Token: 0x04003F2C RID: 16172
		[global::Cpp2ILInjected.Token(Token = "0x4005178")]
		public const short PinkIceBlock = 834;

		// Token: 0x04003F2D RID: 16173
		[global::Cpp2ILInjected.Token(Token = "0x4005179")]
		public const short RedIceBlock = 835;

		// Token: 0x04003F2E RID: 16174
		[global::Cpp2ILInjected.Token(Token = "0x400517A")]
		public const short CrimstoneBlock = 836;

		// Token: 0x04003F2F RID: 16175
		[global::Cpp2ILInjected.Token(Token = "0x400517B")]
		public const short SkywareDoor = 837;

		// Token: 0x04003F30 RID: 16176
		[global::Cpp2ILInjected.Token(Token = "0x400517C")]
		public const short SkywareChest = 838;

		// Token: 0x04003F31 RID: 16177
		[global::Cpp2ILInjected.Token(Token = "0x400517D")]
		public const short SteampunkHat = 839;

		// Token: 0x04003F32 RID: 16178
		[global::Cpp2ILInjected.Token(Token = "0x400517E")]
		public const short SteampunkShirt = 840;

		// Token: 0x04003F33 RID: 16179
		[global::Cpp2ILInjected.Token(Token = "0x400517F")]
		public const short SteampunkPants = 841;

		// Token: 0x04003F34 RID: 16180
		[global::Cpp2ILInjected.Token(Token = "0x4005180")]
		public const short BeeHat = 842;

		// Token: 0x04003F35 RID: 16181
		[global::Cpp2ILInjected.Token(Token = "0x4005181")]
		public const short BeeShirt = 843;

		// Token: 0x04003F36 RID: 16182
		[global::Cpp2ILInjected.Token(Token = "0x4005182")]
		public const short BeePants = 844;

		// Token: 0x04003F37 RID: 16183
		[global::Cpp2ILInjected.Token(Token = "0x4005183")]
		public const short WorldBanner = 845;

		// Token: 0x04003F38 RID: 16184
		[global::Cpp2ILInjected.Token(Token = "0x4005184")]
		public const short SunBanner = 846;

		// Token: 0x04003F39 RID: 16185
		[global::Cpp2ILInjected.Token(Token = "0x4005185")]
		public const short GravityBanner = 847;

		// Token: 0x04003F3A RID: 16186
		[global::Cpp2ILInjected.Token(Token = "0x4005186")]
		public const short PharaohsMask = 848;

		// Token: 0x04003F3B RID: 16187
		[global::Cpp2ILInjected.Token(Token = "0x4005187")]
		public const short Actuator = 849;

		// Token: 0x04003F3C RID: 16188
		[global::Cpp2ILInjected.Token(Token = "0x4005188")]
		public const short BlueWrench = 850;

		// Token: 0x04003F3D RID: 16189
		[global::Cpp2ILInjected.Token(Token = "0x4005189")]
		public const short GreenWrench = 851;

		// Token: 0x04003F3E RID: 16190
		[global::Cpp2ILInjected.Token(Token = "0x400518A")]
		public const short BluePressurePlate = 852;

		// Token: 0x04003F3F RID: 16191
		[global::Cpp2ILInjected.Token(Token = "0x400518B")]
		public const short YellowPressurePlate = 853;

		// Token: 0x04003F40 RID: 16192
		[global::Cpp2ILInjected.Token(Token = "0x400518C")]
		public const short DiscountCard = 854;

		// Token: 0x04003F41 RID: 16193
		[global::Cpp2ILInjected.Token(Token = "0x400518D")]
		public const short LuckyCoin = 855;

		// Token: 0x04003F42 RID: 16194
		[global::Cpp2ILInjected.Token(Token = "0x400518E")]
		public const short UnicornonaStick = 856;

		// Token: 0x04003F43 RID: 16195
		[global::Cpp2ILInjected.Token(Token = "0x400518F")]
		public const short SandstorminaBottle = 857;

		// Token: 0x04003F44 RID: 16196
		[global::Cpp2ILInjected.Token(Token = "0x4005190")]
		public const short BorealWoodSofa = 858;

		// Token: 0x04003F45 RID: 16197
		[global::Cpp2ILInjected.Token(Token = "0x4005191")]
		public const short BeachBall = 859;

		// Token: 0x04003F46 RID: 16198
		[global::Cpp2ILInjected.Token(Token = "0x4005192")]
		public const short CharmofMyths = 860;

		// Token: 0x04003F47 RID: 16199
		[global::Cpp2ILInjected.Token(Token = "0x4005193")]
		public const short MoonShell = 861;

		// Token: 0x04003F48 RID: 16200
		[global::Cpp2ILInjected.Token(Token = "0x4005194")]
		public const short StarVeil = 862;

		// Token: 0x04003F49 RID: 16201
		[global::Cpp2ILInjected.Token(Token = "0x4005195")]
		public const short WaterWalkingBoots = 863;

		// Token: 0x04003F4A RID: 16202
		[global::Cpp2ILInjected.Token(Token = "0x4005196")]
		public const short Tiara = 864;

		// Token: 0x04003F4B RID: 16203
		[global::Cpp2ILInjected.Token(Token = "0x4005197")]
		public const short PrincessDress = 865;

		// Token: 0x04003F4C RID: 16204
		[global::Cpp2ILInjected.Token(Token = "0x4005198")]
		public const short PharaohsRobe = 866;

		// Token: 0x04003F4D RID: 16205
		[global::Cpp2ILInjected.Token(Token = "0x4005199")]
		public const short GreenCap = 867;

		// Token: 0x04003F4E RID: 16206
		[global::Cpp2ILInjected.Token(Token = "0x400519A")]
		public const short MushroomCap = 868;

		// Token: 0x04003F4F RID: 16207
		[global::Cpp2ILInjected.Token(Token = "0x400519B")]
		public const short TamOShanter = 869;

		// Token: 0x04003F50 RID: 16208
		[global::Cpp2ILInjected.Token(Token = "0x400519C")]
		public const short MummyMask = 870;

		// Token: 0x04003F51 RID: 16209
		[global::Cpp2ILInjected.Token(Token = "0x400519D")]
		public const short MummyShirt = 871;

		// Token: 0x04003F52 RID: 16210
		[global::Cpp2ILInjected.Token(Token = "0x400519E")]
		public const short MummyPants = 872;

		// Token: 0x04003F53 RID: 16211
		[global::Cpp2ILInjected.Token(Token = "0x400519F")]
		public const short CowboyHat = 873;

		// Token: 0x04003F54 RID: 16212
		[global::Cpp2ILInjected.Token(Token = "0x40051A0")]
		public const short CowboyJacket = 874;

		// Token: 0x04003F55 RID: 16213
		[global::Cpp2ILInjected.Token(Token = "0x40051A1")]
		public const short CowboyPants = 875;

		// Token: 0x04003F56 RID: 16214
		[global::Cpp2ILInjected.Token(Token = "0x40051A2")]
		public const short PirateHat = 876;

		// Token: 0x04003F57 RID: 16215
		[global::Cpp2ILInjected.Token(Token = "0x40051A3")]
		public const short PirateShirt = 877;

		// Token: 0x04003F58 RID: 16216
		[global::Cpp2ILInjected.Token(Token = "0x40051A4")]
		public const short PiratePants = 878;

		// Token: 0x04003F59 RID: 16217
		[global::Cpp2ILInjected.Token(Token = "0x40051A5")]
		public const short VikingHelmet = 879;

		// Token: 0x04003F5A RID: 16218
		[global::Cpp2ILInjected.Token(Token = "0x40051A6")]
		public const short CrimtaneOre = 880;

		// Token: 0x04003F5B RID: 16219
		[global::Cpp2ILInjected.Token(Token = "0x40051A7")]
		public const short CactusSword = 881;

		// Token: 0x04003F5C RID: 16220
		[global::Cpp2ILInjected.Token(Token = "0x40051A8")]
		public const short CactusPickaxe = 882;

		// Token: 0x04003F5D RID: 16221
		[global::Cpp2ILInjected.Token(Token = "0x40051A9")]
		public const short IceBrick = 883;

		// Token: 0x04003F5E RID: 16222
		[global::Cpp2ILInjected.Token(Token = "0x40051AA")]
		public const short IceBrickWall = 884;

		// Token: 0x04003F5F RID: 16223
		[global::Cpp2ILInjected.Token(Token = "0x40051AB")]
		public const short AdhesiveBandage = 885;

		// Token: 0x04003F60 RID: 16224
		[global::Cpp2ILInjected.Token(Token = "0x40051AC")]
		public const short ArmorPolish = 886;

		// Token: 0x04003F61 RID: 16225
		[global::Cpp2ILInjected.Token(Token = "0x40051AD")]
		public const short Bezoar = 887;

		// Token: 0x04003F62 RID: 16226
		[global::Cpp2ILInjected.Token(Token = "0x40051AE")]
		public const short Blindfold = 888;

		// Token: 0x04003F63 RID: 16227
		[global::Cpp2ILInjected.Token(Token = "0x40051AF")]
		public const short FastClock = 889;

		// Token: 0x04003F64 RID: 16228
		[global::Cpp2ILInjected.Token(Token = "0x40051B0")]
		public const short Megaphone = 890;

		// Token: 0x04003F65 RID: 16229
		[global::Cpp2ILInjected.Token(Token = "0x40051B1")]
		public const short Nazar = 891;

		// Token: 0x04003F66 RID: 16230
		[global::Cpp2ILInjected.Token(Token = "0x40051B2")]
		public const short Vitamins = 892;

		// Token: 0x04003F67 RID: 16231
		[global::Cpp2ILInjected.Token(Token = "0x40051B3")]
		public const short TrifoldMap = 893;

		// Token: 0x04003F68 RID: 16232
		[global::Cpp2ILInjected.Token(Token = "0x40051B4")]
		public const short CactusHelmet = 894;

		// Token: 0x04003F69 RID: 16233
		[global::Cpp2ILInjected.Token(Token = "0x40051B5")]
		public const short CactusBreastplate = 895;

		// Token: 0x04003F6A RID: 16234
		[global::Cpp2ILInjected.Token(Token = "0x40051B6")]
		public const short CactusLeggings = 896;

		// Token: 0x04003F6B RID: 16235
		[global::Cpp2ILInjected.Token(Token = "0x40051B7")]
		public const short PowerGlove = 897;

		// Token: 0x04003F6C RID: 16236
		[global::Cpp2ILInjected.Token(Token = "0x40051B8")]
		public const short LightningBoots = 898;

		// Token: 0x04003F6D RID: 16237
		[global::Cpp2ILInjected.Token(Token = "0x40051B9")]
		public const short SunStone = 899;

		// Token: 0x04003F6E RID: 16238
		[global::Cpp2ILInjected.Token(Token = "0x40051BA")]
		public const short MoonStone = 900;

		// Token: 0x04003F6F RID: 16239
		[global::Cpp2ILInjected.Token(Token = "0x40051BB")]
		public const short ArmorBracing = 901;

		// Token: 0x04003F70 RID: 16240
		[global::Cpp2ILInjected.Token(Token = "0x40051BC")]
		public const short MedicatedBandage = 902;

		// Token: 0x04003F71 RID: 16241
		[global::Cpp2ILInjected.Token(Token = "0x40051BD")]
		public const short ThePlan = 903;

		// Token: 0x04003F72 RID: 16242
		[global::Cpp2ILInjected.Token(Token = "0x40051BE")]
		public const short CountercurseMantra = 904;

		// Token: 0x04003F73 RID: 16243
		[global::Cpp2ILInjected.Token(Token = "0x40051BF")]
		public const short CoinGun = 905;

		// Token: 0x04003F74 RID: 16244
		[global::Cpp2ILInjected.Token(Token = "0x40051C0")]
		public const short LavaCharm = 906;

		// Token: 0x04003F75 RID: 16245
		[global::Cpp2ILInjected.Token(Token = "0x40051C1")]
		public const short ObsidianWaterWalkingBoots = 907;

		// Token: 0x04003F76 RID: 16246
		[global::Cpp2ILInjected.Token(Token = "0x40051C2")]
		public const short LavaWaders = 908;

		// Token: 0x04003F77 RID: 16247
		[global::Cpp2ILInjected.Token(Token = "0x40051C3")]
		public const short PureWaterFountain = 909;

		// Token: 0x04003F78 RID: 16248
		[global::Cpp2ILInjected.Token(Token = "0x40051C4")]
		public const short DesertWaterFountain = 910;

		// Token: 0x04003F79 RID: 16249
		[global::Cpp2ILInjected.Token(Token = "0x40051C5")]
		public const short Shadewood = 911;

		// Token: 0x04003F7A RID: 16250
		[global::Cpp2ILInjected.Token(Token = "0x40051C6")]
		public const short ShadewoodDoor = 912;

		// Token: 0x04003F7B RID: 16251
		[global::Cpp2ILInjected.Token(Token = "0x40051C7")]
		public const short ShadewoodPlatform = 913;

		// Token: 0x04003F7C RID: 16252
		[global::Cpp2ILInjected.Token(Token = "0x40051C8")]
		public const short ShadewoodChest = 914;

		// Token: 0x04003F7D RID: 16253
		[global::Cpp2ILInjected.Token(Token = "0x40051C9")]
		public const short ShadewoodChair = 915;

		// Token: 0x04003F7E RID: 16254
		[global::Cpp2ILInjected.Token(Token = "0x40051CA")]
		public const short ShadewoodWorkBench = 916;

		// Token: 0x04003F7F RID: 16255
		[global::Cpp2ILInjected.Token(Token = "0x40051CB")]
		public const short ShadewoodTable = 917;

		// Token: 0x04003F80 RID: 16256
		[global::Cpp2ILInjected.Token(Token = "0x40051CC")]
		public const short ShadewoodDresser = 918;

		// Token: 0x04003F81 RID: 16257
		[global::Cpp2ILInjected.Token(Token = "0x40051CD")]
		public const short ShadewoodPiano = 919;

		// Token: 0x04003F82 RID: 16258
		[global::Cpp2ILInjected.Token(Token = "0x40051CE")]
		public const short ShadewoodBed = 920;

		// Token: 0x04003F83 RID: 16259
		[global::Cpp2ILInjected.Token(Token = "0x40051CF")]
		public const short ShadewoodSword = 921;

		// Token: 0x04003F84 RID: 16260
		[global::Cpp2ILInjected.Token(Token = "0x40051D0")]
		public const short ShadewoodHammer = 922;

		// Token: 0x04003F85 RID: 16261
		[global::Cpp2ILInjected.Token(Token = "0x40051D1")]
		public const short ShadewoodBow = 923;

		// Token: 0x04003F86 RID: 16262
		[global::Cpp2ILInjected.Token(Token = "0x40051D2")]
		public const short ShadewoodHelmet = 924;

		// Token: 0x04003F87 RID: 16263
		[global::Cpp2ILInjected.Token(Token = "0x40051D3")]
		public const short ShadewoodBreastplate = 925;

		// Token: 0x04003F88 RID: 16264
		[global::Cpp2ILInjected.Token(Token = "0x40051D4")]
		public const short ShadewoodGreaves = 926;

		// Token: 0x04003F89 RID: 16265
		[global::Cpp2ILInjected.Token(Token = "0x40051D5")]
		public const short ShadewoodWall = 927;

		// Token: 0x04003F8A RID: 16266
		[global::Cpp2ILInjected.Token(Token = "0x40051D6")]
		public const short Cannon = 928;

		// Token: 0x04003F8B RID: 16267
		[global::Cpp2ILInjected.Token(Token = "0x40051D7")]
		public const short Cannonball = 929;

		// Token: 0x04003F8C RID: 16268
		[global::Cpp2ILInjected.Token(Token = "0x40051D8")]
		public const short FlareGun = 930;

		// Token: 0x04003F8D RID: 16269
		[global::Cpp2ILInjected.Token(Token = "0x40051D9")]
		public const short Flare = 931;

		// Token: 0x04003F8E RID: 16270
		[global::Cpp2ILInjected.Token(Token = "0x40051DA")]
		public const short BoneWand = 932;

		// Token: 0x04003F8F RID: 16271
		[global::Cpp2ILInjected.Token(Token = "0x40051DB")]
		public const short LeafWand = 933;

		// Token: 0x04003F90 RID: 16272
		[global::Cpp2ILInjected.Token(Token = "0x40051DC")]
		public const short FlyingCarpet = 934;

		// Token: 0x04003F91 RID: 16273
		[global::Cpp2ILInjected.Token(Token = "0x40051DD")]
		public const short AvengerEmblem = 935;

		// Token: 0x04003F92 RID: 16274
		[global::Cpp2ILInjected.Token(Token = "0x40051DE")]
		public const short MechanicalGlove = 936;

		// Token: 0x04003F93 RID: 16275
		[global::Cpp2ILInjected.Token(Token = "0x40051DF")]
		public const short LandMine = 937;

		// Token: 0x04003F94 RID: 16276
		[global::Cpp2ILInjected.Token(Token = "0x40051E0")]
		public const short PaladinsShield = 938;

		// Token: 0x04003F95 RID: 16277
		[global::Cpp2ILInjected.Token(Token = "0x40051E1")]
		public const short WebSlinger = 939;

		// Token: 0x04003F96 RID: 16278
		[global::Cpp2ILInjected.Token(Token = "0x40051E2")]
		public const short JungleWaterFountain = 940;

		// Token: 0x04003F97 RID: 16279
		[global::Cpp2ILInjected.Token(Token = "0x40051E3")]
		public const short IcyWaterFountain = 941;

		// Token: 0x04003F98 RID: 16280
		[global::Cpp2ILInjected.Token(Token = "0x40051E4")]
		public const short CorruptWaterFountain = 942;

		// Token: 0x04003F99 RID: 16281
		[global::Cpp2ILInjected.Token(Token = "0x40051E5")]
		public const short CrimsonWaterFountain = 943;

		// Token: 0x04003F9A RID: 16282
		[global::Cpp2ILInjected.Token(Token = "0x40051E6")]
		public const short HallowedWaterFountain = 944;

		// Token: 0x04003F9B RID: 16283
		[global::Cpp2ILInjected.Token(Token = "0x40051E7")]
		public const short BloodWaterFountain = 945;

		// Token: 0x04003F9C RID: 16284
		[global::Cpp2ILInjected.Token(Token = "0x40051E8")]
		public const short Umbrella = 946;

		// Token: 0x04003F9D RID: 16285
		[global::Cpp2ILInjected.Token(Token = "0x40051E9")]
		public const short ChlorophyteOre = 947;

		// Token: 0x04003F9E RID: 16286
		[global::Cpp2ILInjected.Token(Token = "0x40051EA")]
		public const short SteampunkWings = 948;

		// Token: 0x04003F9F RID: 16287
		[global::Cpp2ILInjected.Token(Token = "0x40051EB")]
		public const short Snowball = 949;

		// Token: 0x04003FA0 RID: 16288
		[global::Cpp2ILInjected.Token(Token = "0x40051EC")]
		public const short IceSkates = 950;

		// Token: 0x04003FA1 RID: 16289
		[global::Cpp2ILInjected.Token(Token = "0x40051ED")]
		public const short SnowballLauncher = 951;

		// Token: 0x04003FA2 RID: 16290
		[global::Cpp2ILInjected.Token(Token = "0x40051EE")]
		public const short WebCoveredChest = 952;

		// Token: 0x04003FA3 RID: 16291
		[global::Cpp2ILInjected.Token(Token = "0x40051EF")]
		public const short ClimbingClaws = 953;

		// Token: 0x04003FA4 RID: 16292
		[global::Cpp2ILInjected.Token(Token = "0x40051F0")]
		public const short AncientIronHelmet = 954;

		// Token: 0x04003FA5 RID: 16293
		[global::Cpp2ILInjected.Token(Token = "0x40051F1")]
		public const short AncientGoldHelmet = 955;

		// Token: 0x04003FA6 RID: 16294
		[global::Cpp2ILInjected.Token(Token = "0x40051F2")]
		public const short AncientShadowHelmet = 956;

		// Token: 0x04003FA7 RID: 16295
		[global::Cpp2ILInjected.Token(Token = "0x40051F3")]
		public const short AncientShadowScalemail = 957;

		// Token: 0x04003FA8 RID: 16296
		[global::Cpp2ILInjected.Token(Token = "0x40051F4")]
		public const short AncientShadowGreaves = 958;

		// Token: 0x04003FA9 RID: 16297
		[global::Cpp2ILInjected.Token(Token = "0x40051F5")]
		public const short AncientNecroHelmet = 959;

		// Token: 0x04003FAA RID: 16298
		[global::Cpp2ILInjected.Token(Token = "0x40051F6")]
		public const short AncientCobaltHelmet = 960;

		// Token: 0x04003FAB RID: 16299
		[global::Cpp2ILInjected.Token(Token = "0x40051F7")]
		public const short AncientCobaltBreastplate = 961;

		// Token: 0x04003FAC RID: 16300
		[global::Cpp2ILInjected.Token(Token = "0x40051F8")]
		public const short AncientCobaltLeggings = 962;

		// Token: 0x04003FAD RID: 16301
		[global::Cpp2ILInjected.Token(Token = "0x40051F9")]
		public const short BlackBelt = 963;

		// Token: 0x04003FAE RID: 16302
		[global::Cpp2ILInjected.Token(Token = "0x40051FA")]
		public const short Boomstick = 964;

		// Token: 0x04003FAF RID: 16303
		[global::Cpp2ILInjected.Token(Token = "0x40051FB")]
		public const short Rope = 965;

		// Token: 0x04003FB0 RID: 16304
		[global::Cpp2ILInjected.Token(Token = "0x40051FC")]
		public const short Campfire = 966;

		// Token: 0x04003FB1 RID: 16305
		[global::Cpp2ILInjected.Token(Token = "0x40051FD")]
		public const short Marshmallow = 967;

		// Token: 0x04003FB2 RID: 16306
		[global::Cpp2ILInjected.Token(Token = "0x40051FE")]
		public const short MarshmallowonaStick = 968;

		// Token: 0x04003FB3 RID: 16307
		[global::Cpp2ILInjected.Token(Token = "0x40051FF")]
		public const short CookedMarshmallow = 969;

		// Token: 0x04003FB4 RID: 16308
		[global::Cpp2ILInjected.Token(Token = "0x4005200")]
		public const short RedRocket = 970;

		// Token: 0x04003FB5 RID: 16309
		[global::Cpp2ILInjected.Token(Token = "0x4005201")]
		public const short GreenRocket = 971;

		// Token: 0x04003FB6 RID: 16310
		[global::Cpp2ILInjected.Token(Token = "0x4005202")]
		public const short BlueRocket = 972;

		// Token: 0x04003FB7 RID: 16311
		[global::Cpp2ILInjected.Token(Token = "0x4005203")]
		public const short YellowRocket = 973;

		// Token: 0x04003FB8 RID: 16312
		[global::Cpp2ILInjected.Token(Token = "0x4005204")]
		public const short IceTorch = 974;

		// Token: 0x04003FB9 RID: 16313
		[global::Cpp2ILInjected.Token(Token = "0x4005205")]
		public const short ShoeSpikes = 975;

		// Token: 0x04003FBA RID: 16314
		[global::Cpp2ILInjected.Token(Token = "0x4005206")]
		public const short TigerClimbingGear = 976;

		// Token: 0x04003FBB RID: 16315
		[global::Cpp2ILInjected.Token(Token = "0x4005207")]
		public const short Tabi = 977;

		// Token: 0x04003FBC RID: 16316
		[global::Cpp2ILInjected.Token(Token = "0x4005208")]
		public const short PinkEskimoHood = 978;

		// Token: 0x04003FBD RID: 16317
		[global::Cpp2ILInjected.Token(Token = "0x4005209")]
		public const short PinkEskimoCoat = 979;

		// Token: 0x04003FBE RID: 16318
		[global::Cpp2ILInjected.Token(Token = "0x400520A")]
		public const short PinkEskimoPants = 980;

		// Token: 0x04003FBF RID: 16319
		[global::Cpp2ILInjected.Token(Token = "0x400520B")]
		public const short PinkThread = 981;

		// Token: 0x04003FC0 RID: 16320
		[global::Cpp2ILInjected.Token(Token = "0x400520C")]
		public const short ManaRegenerationBand = 982;

		// Token: 0x04003FC1 RID: 16321
		[global::Cpp2ILInjected.Token(Token = "0x400520D")]
		public const short SandstorminaBalloon = 983;

		// Token: 0x04003FC2 RID: 16322
		[global::Cpp2ILInjected.Token(Token = "0x400520E")]
		public const short MasterNinjaGear = 984;

		// Token: 0x04003FC3 RID: 16323
		[global::Cpp2ILInjected.Token(Token = "0x400520F")]
		public const short RopeCoil = 985;

		// Token: 0x04003FC4 RID: 16324
		[global::Cpp2ILInjected.Token(Token = "0x4005210")]
		public const short Blowgun = 986;

		// Token: 0x04003FC5 RID: 16325
		[global::Cpp2ILInjected.Token(Token = "0x4005211")]
		public const short BlizzardinaBottle = 987;

		// Token: 0x04003FC6 RID: 16326
		[global::Cpp2ILInjected.Token(Token = "0x4005212")]
		public const short FrostburnArrow = 988;

		// Token: 0x04003FC7 RID: 16327
		[global::Cpp2ILInjected.Token(Token = "0x4005213")]
		public const short EnchantedSword = 989;

		// Token: 0x04003FC8 RID: 16328
		[global::Cpp2ILInjected.Token(Token = "0x4005214")]
		public const short PickaxeAxe = 990;

		// Token: 0x04003FC9 RID: 16329
		[global::Cpp2ILInjected.Token(Token = "0x4005215")]
		public const short CobaltWaraxe = 991;

		// Token: 0x04003FCA RID: 16330
		[global::Cpp2ILInjected.Token(Token = "0x4005216")]
		public const short MythrilWaraxe = 992;

		// Token: 0x04003FCB RID: 16331
		[global::Cpp2ILInjected.Token(Token = "0x4005217")]
		public const short AdamantiteWaraxe = 993;

		// Token: 0x04003FCC RID: 16332
		[global::Cpp2ILInjected.Token(Token = "0x4005218")]
		public const short EatersBone = 994;

		// Token: 0x04003FCD RID: 16333
		[global::Cpp2ILInjected.Token(Token = "0x4005219")]
		public const short BlendOMatic = 995;

		// Token: 0x04003FCE RID: 16334
		[global::Cpp2ILInjected.Token(Token = "0x400521A")]
		public const short MeatGrinder = 996;

		// Token: 0x04003FCF RID: 16335
		[global::Cpp2ILInjected.Token(Token = "0x400521B")]
		public const short Extractinator = 997;

		// Token: 0x04003FD0 RID: 16336
		[global::Cpp2ILInjected.Token(Token = "0x400521C")]
		public const short Solidifier = 998;

		// Token: 0x04003FD1 RID: 16337
		[global::Cpp2ILInjected.Token(Token = "0x400521D")]
		public const short Amber = 999;

		// Token: 0x04003FD2 RID: 16338
		[global::Cpp2ILInjected.Token(Token = "0x400521E")]
		public const short ConfettiGun = 1000;

		// Token: 0x04003FD3 RID: 16339
		[global::Cpp2ILInjected.Token(Token = "0x400521F")]
		public const short ChlorophyteMask = 1001;

		// Token: 0x04003FD4 RID: 16340
		[global::Cpp2ILInjected.Token(Token = "0x4005220")]
		public const short ChlorophyteHelmet = 1002;

		// Token: 0x04003FD5 RID: 16341
		[global::Cpp2ILInjected.Token(Token = "0x4005221")]
		public const short ChlorophyteHeadgear = 1003;

		// Token: 0x04003FD6 RID: 16342
		[global::Cpp2ILInjected.Token(Token = "0x4005222")]
		public const short ChlorophytePlateMail = 1004;

		// Token: 0x04003FD7 RID: 16343
		[global::Cpp2ILInjected.Token(Token = "0x4005223")]
		public const short ChlorophyteGreaves = 1005;

		// Token: 0x04003FD8 RID: 16344
		[global::Cpp2ILInjected.Token(Token = "0x4005224")]
		public const short ChlorophyteBar = 1006;

		// Token: 0x04003FD9 RID: 16345
		[global::Cpp2ILInjected.Token(Token = "0x4005225")]
		public const short RedDye = 1007;

		// Token: 0x04003FDA RID: 16346
		[global::Cpp2ILInjected.Token(Token = "0x4005226")]
		public const short OrangeDye = 1008;

		// Token: 0x04003FDB RID: 16347
		[global::Cpp2ILInjected.Token(Token = "0x4005227")]
		public const short YellowDye = 1009;

		// Token: 0x04003FDC RID: 16348
		[global::Cpp2ILInjected.Token(Token = "0x4005228")]
		public const short LimeDye = 1010;

		// Token: 0x04003FDD RID: 16349
		[global::Cpp2ILInjected.Token(Token = "0x4005229")]
		public const short GreenDye = 1011;

		// Token: 0x04003FDE RID: 16350
		[global::Cpp2ILInjected.Token(Token = "0x400522A")]
		public const short TealDye = 1012;

		// Token: 0x04003FDF RID: 16351
		[global::Cpp2ILInjected.Token(Token = "0x400522B")]
		public const short CyanDye = 1013;

		// Token: 0x04003FE0 RID: 16352
		[global::Cpp2ILInjected.Token(Token = "0x400522C")]
		public const short SkyBlueDye = 1014;

		// Token: 0x04003FE1 RID: 16353
		[global::Cpp2ILInjected.Token(Token = "0x400522D")]
		public const short BlueDye = 1015;

		// Token: 0x04003FE2 RID: 16354
		[global::Cpp2ILInjected.Token(Token = "0x400522E")]
		public const short PurpleDye = 1016;

		// Token: 0x04003FE3 RID: 16355
		[global::Cpp2ILInjected.Token(Token = "0x400522F")]
		public const short VioletDye = 1017;

		// Token: 0x04003FE4 RID: 16356
		[global::Cpp2ILInjected.Token(Token = "0x4005230")]
		public const short PinkDye = 1018;

		// Token: 0x04003FE5 RID: 16357
		[global::Cpp2ILInjected.Token(Token = "0x4005231")]
		public const short RedandBlackDye = 1019;

		// Token: 0x04003FE6 RID: 16358
		[global::Cpp2ILInjected.Token(Token = "0x4005232")]
		public const short OrangeandBlackDye = 1020;

		// Token: 0x04003FE7 RID: 16359
		[global::Cpp2ILInjected.Token(Token = "0x4005233")]
		public const short YellowandBlackDye = 1021;

		// Token: 0x04003FE8 RID: 16360
		[global::Cpp2ILInjected.Token(Token = "0x4005234")]
		public const short LimeandBlackDye = 1022;

		// Token: 0x04003FE9 RID: 16361
		[global::Cpp2ILInjected.Token(Token = "0x4005235")]
		public const short GreenandBlackDye = 1023;

		// Token: 0x04003FEA RID: 16362
		[global::Cpp2ILInjected.Token(Token = "0x4005236")]
		public const short TealandBlackDye = 1024;

		// Token: 0x04003FEB RID: 16363
		[global::Cpp2ILInjected.Token(Token = "0x4005237")]
		public const short CyanandBlackDye = 1025;

		// Token: 0x04003FEC RID: 16364
		[global::Cpp2ILInjected.Token(Token = "0x4005238")]
		public const short SkyBlueandBlackDye = 1026;

		// Token: 0x04003FED RID: 16365
		[global::Cpp2ILInjected.Token(Token = "0x4005239")]
		public const short BlueandBlackDye = 1027;

		// Token: 0x04003FEE RID: 16366
		[global::Cpp2ILInjected.Token(Token = "0x400523A")]
		public const short PurpleandBlackDye = 1028;

		// Token: 0x04003FEF RID: 16367
		[global::Cpp2ILInjected.Token(Token = "0x400523B")]
		public const short VioletandBlackDye = 1029;

		// Token: 0x04003FF0 RID: 16368
		[global::Cpp2ILInjected.Token(Token = "0x400523C")]
		public const short PinkandBlackDye = 1030;

		// Token: 0x04003FF1 RID: 16369
		[global::Cpp2ILInjected.Token(Token = "0x400523D")]
		public const short FlameDye = 1031;

		// Token: 0x04003FF2 RID: 16370
		[global::Cpp2ILInjected.Token(Token = "0x400523E")]
		public const short FlameAndBlackDye = 1032;

		// Token: 0x04003FF3 RID: 16371
		[global::Cpp2ILInjected.Token(Token = "0x400523F")]
		public const short GreenFlameDye = 1033;

		// Token: 0x04003FF4 RID: 16372
		[global::Cpp2ILInjected.Token(Token = "0x4005240")]
		public const short GreenFlameAndBlackDye = 1034;

		// Token: 0x04003FF5 RID: 16373
		[global::Cpp2ILInjected.Token(Token = "0x4005241")]
		public const short BlueFlameDye = 1035;

		// Token: 0x04003FF6 RID: 16374
		[global::Cpp2ILInjected.Token(Token = "0x4005242")]
		public const short BlueFlameAndBlackDye = 1036;

		// Token: 0x04003FF7 RID: 16375
		[global::Cpp2ILInjected.Token(Token = "0x4005243")]
		public const short SilverDye = 1037;

		// Token: 0x04003FF8 RID: 16376
		[global::Cpp2ILInjected.Token(Token = "0x4005244")]
		public const short BrightRedDye = 1038;

		// Token: 0x04003FF9 RID: 16377
		[global::Cpp2ILInjected.Token(Token = "0x4005245")]
		public const short BrightOrangeDye = 1039;

		// Token: 0x04003FFA RID: 16378
		[global::Cpp2ILInjected.Token(Token = "0x4005246")]
		public const short BrightYellowDye = 1040;

		// Token: 0x04003FFB RID: 16379
		[global::Cpp2ILInjected.Token(Token = "0x4005247")]
		public const short BrightLimeDye = 1041;

		// Token: 0x04003FFC RID: 16380
		[global::Cpp2ILInjected.Token(Token = "0x4005248")]
		public const short BrightGreenDye = 1042;

		// Token: 0x04003FFD RID: 16381
		[global::Cpp2ILInjected.Token(Token = "0x4005249")]
		public const short BrightTealDye = 1043;

		// Token: 0x04003FFE RID: 16382
		[global::Cpp2ILInjected.Token(Token = "0x400524A")]
		public const short BrightCyanDye = 1044;

		// Token: 0x04003FFF RID: 16383
		[global::Cpp2ILInjected.Token(Token = "0x400524B")]
		public const short BrightSkyBlueDye = 1045;

		// Token: 0x04004000 RID: 16384
		[global::Cpp2ILInjected.Token(Token = "0x400524C")]
		public const short BrightBlueDye = 1046;

		// Token: 0x04004001 RID: 16385
		[global::Cpp2ILInjected.Token(Token = "0x400524D")]
		public const short BrightPurpleDye = 1047;

		// Token: 0x04004002 RID: 16386
		[global::Cpp2ILInjected.Token(Token = "0x400524E")]
		public const short BrightVioletDye = 1048;

		// Token: 0x04004003 RID: 16387
		[global::Cpp2ILInjected.Token(Token = "0x400524F")]
		public const short BrightPinkDye = 1049;

		// Token: 0x04004004 RID: 16388
		[global::Cpp2ILInjected.Token(Token = "0x4005250")]
		public const short BlackDye = 1050;

		// Token: 0x04004005 RID: 16389
		[global::Cpp2ILInjected.Token(Token = "0x4005251")]
		public const short RedandSilverDye = 1051;

		// Token: 0x04004006 RID: 16390
		[global::Cpp2ILInjected.Token(Token = "0x4005252")]
		public const short OrangeandSilverDye = 1052;

		// Token: 0x04004007 RID: 16391
		[global::Cpp2ILInjected.Token(Token = "0x4005253")]
		public const short YellowandSilverDye = 1053;

		// Token: 0x04004008 RID: 16392
		[global::Cpp2ILInjected.Token(Token = "0x4005254")]
		public const short LimeandSilverDye = 1054;

		// Token: 0x04004009 RID: 16393
		[global::Cpp2ILInjected.Token(Token = "0x4005255")]
		public const short GreenandSilverDye = 1055;

		// Token: 0x0400400A RID: 16394
		[global::Cpp2ILInjected.Token(Token = "0x4005256")]
		public const short TealandSilverDye = 1056;

		// Token: 0x0400400B RID: 16395
		[global::Cpp2ILInjected.Token(Token = "0x4005257")]
		public const short CyanandSilverDye = 1057;

		// Token: 0x0400400C RID: 16396
		[global::Cpp2ILInjected.Token(Token = "0x4005258")]
		public const short SkyBlueandSilverDye = 1058;

		// Token: 0x0400400D RID: 16397
		[global::Cpp2ILInjected.Token(Token = "0x4005259")]
		public const short BlueandSilverDye = 1059;

		// Token: 0x0400400E RID: 16398
		[global::Cpp2ILInjected.Token(Token = "0x400525A")]
		public const short PurpleandSilverDye = 1060;

		// Token: 0x0400400F RID: 16399
		[global::Cpp2ILInjected.Token(Token = "0x400525B")]
		public const short VioletandSilverDye = 1061;

		// Token: 0x04004010 RID: 16400
		[global::Cpp2ILInjected.Token(Token = "0x400525C")]
		public const short PinkandSilverDye = 1062;

		// Token: 0x04004011 RID: 16401
		[global::Cpp2ILInjected.Token(Token = "0x400525D")]
		public const short IntenseFlameDye = 1063;

		// Token: 0x04004012 RID: 16402
		[global::Cpp2ILInjected.Token(Token = "0x400525E")]
		public const short IntenseGreenFlameDye = 1064;

		// Token: 0x04004013 RID: 16403
		[global::Cpp2ILInjected.Token(Token = "0x400525F")]
		public const short IntenseBlueFlameDye = 1065;

		// Token: 0x04004014 RID: 16404
		[global::Cpp2ILInjected.Token(Token = "0x4005260")]
		public const short RainbowDye = 1066;

		// Token: 0x04004015 RID: 16405
		[global::Cpp2ILInjected.Token(Token = "0x4005261")]
		public const short IntenseRainbowDye = 1067;

		// Token: 0x04004016 RID: 16406
		[global::Cpp2ILInjected.Token(Token = "0x4005262")]
		public const short YellowGradientDye = 1068;

		// Token: 0x04004017 RID: 16407
		[global::Cpp2ILInjected.Token(Token = "0x4005263")]
		public const short CyanGradientDye = 1069;

		// Token: 0x04004018 RID: 16408
		[global::Cpp2ILInjected.Token(Token = "0x4005264")]
		public const short VioletGradientDye = 1070;

		// Token: 0x04004019 RID: 16409
		[global::Cpp2ILInjected.Token(Token = "0x4005265")]
		public const short Paintbrush = 1071;

		// Token: 0x0400401A RID: 16410
		[global::Cpp2ILInjected.Token(Token = "0x4005266")]
		public const short PaintRoller = 1072;

		// Token: 0x0400401B RID: 16411
		[global::Cpp2ILInjected.Token(Token = "0x4005267")]
		public const short RedPaint = 1073;

		// Token: 0x0400401C RID: 16412
		[global::Cpp2ILInjected.Token(Token = "0x4005268")]
		public const short OrangePaint = 1074;

		// Token: 0x0400401D RID: 16413
		[global::Cpp2ILInjected.Token(Token = "0x4005269")]
		public const short YellowPaint = 1075;

		// Token: 0x0400401E RID: 16414
		[global::Cpp2ILInjected.Token(Token = "0x400526A")]
		public const short LimePaint = 1076;

		// Token: 0x0400401F RID: 16415
		[global::Cpp2ILInjected.Token(Token = "0x400526B")]
		public const short GreenPaint = 1077;

		// Token: 0x04004020 RID: 16416
		[global::Cpp2ILInjected.Token(Token = "0x400526C")]
		public const short TealPaint = 1078;

		// Token: 0x04004021 RID: 16417
		[global::Cpp2ILInjected.Token(Token = "0x400526D")]
		public const short CyanPaint = 1079;

		// Token: 0x04004022 RID: 16418
		[global::Cpp2ILInjected.Token(Token = "0x400526E")]
		public const short SkyBluePaint = 1080;

		// Token: 0x04004023 RID: 16419
		[global::Cpp2ILInjected.Token(Token = "0x400526F")]
		public const short BluePaint = 1081;

		// Token: 0x04004024 RID: 16420
		[global::Cpp2ILInjected.Token(Token = "0x4005270")]
		public const short PurplePaint = 1082;

		// Token: 0x04004025 RID: 16421
		[global::Cpp2ILInjected.Token(Token = "0x4005271")]
		public const short VioletPaint = 1083;

		// Token: 0x04004026 RID: 16422
		[global::Cpp2ILInjected.Token(Token = "0x4005272")]
		public const short PinkPaint = 1084;

		// Token: 0x04004027 RID: 16423
		[global::Cpp2ILInjected.Token(Token = "0x4005273")]
		public const short DeepRedPaint = 1085;

		// Token: 0x04004028 RID: 16424
		[global::Cpp2ILInjected.Token(Token = "0x4005274")]
		public const short DeepOrangePaint = 1086;

		// Token: 0x04004029 RID: 16425
		[global::Cpp2ILInjected.Token(Token = "0x4005275")]
		public const short DeepYellowPaint = 1087;

		// Token: 0x0400402A RID: 16426
		[global::Cpp2ILInjected.Token(Token = "0x4005276")]
		public const short DeepLimePaint = 1088;

		// Token: 0x0400402B RID: 16427
		[global::Cpp2ILInjected.Token(Token = "0x4005277")]
		public const short DeepGreenPaint = 1089;

		// Token: 0x0400402C RID: 16428
		[global::Cpp2ILInjected.Token(Token = "0x4005278")]
		public const short DeepTealPaint = 1090;

		// Token: 0x0400402D RID: 16429
		[global::Cpp2ILInjected.Token(Token = "0x4005279")]
		public const short DeepCyanPaint = 1091;

		// Token: 0x0400402E RID: 16430
		[global::Cpp2ILInjected.Token(Token = "0x400527A")]
		public const short DeepSkyBluePaint = 1092;

		// Token: 0x0400402F RID: 16431
		[global::Cpp2ILInjected.Token(Token = "0x400527B")]
		public const short DeepBluePaint = 1093;

		// Token: 0x04004030 RID: 16432
		[global::Cpp2ILInjected.Token(Token = "0x400527C")]
		public const short DeepPurplePaint = 1094;

		// Token: 0x04004031 RID: 16433
		[global::Cpp2ILInjected.Token(Token = "0x400527D")]
		public const short DeepVioletPaint = 1095;

		// Token: 0x04004032 RID: 16434
		[global::Cpp2ILInjected.Token(Token = "0x400527E")]
		public const short DeepPinkPaint = 1096;

		// Token: 0x04004033 RID: 16435
		[global::Cpp2ILInjected.Token(Token = "0x400527F")]
		public const short BlackPaint = 1097;

		// Token: 0x04004034 RID: 16436
		[global::Cpp2ILInjected.Token(Token = "0x4005280")]
		public const short WhitePaint = 1098;

		// Token: 0x04004035 RID: 16437
		[global::Cpp2ILInjected.Token(Token = "0x4005281")]
		public const short GrayPaint = 1099;

		// Token: 0x04004036 RID: 16438
		[global::Cpp2ILInjected.Token(Token = "0x4005282")]
		public const short PaintScraper = 1100;

		// Token: 0x04004037 RID: 16439
		[global::Cpp2ILInjected.Token(Token = "0x4005283")]
		public const short LihzahrdBrick = 1101;

		// Token: 0x04004038 RID: 16440
		[global::Cpp2ILInjected.Token(Token = "0x4005284")]
		public const short LihzahrdBrickWall = 1102;

		// Token: 0x04004039 RID: 16441
		[global::Cpp2ILInjected.Token(Token = "0x4005285")]
		public const short SlushBlock = 1103;

		// Token: 0x0400403A RID: 16442
		[global::Cpp2ILInjected.Token(Token = "0x4005286")]
		public const short PalladiumOre = 1104;

		// Token: 0x0400403B RID: 16443
		[global::Cpp2ILInjected.Token(Token = "0x4005287")]
		public const short OrichalcumOre = 1105;

		// Token: 0x0400403C RID: 16444
		[global::Cpp2ILInjected.Token(Token = "0x4005288")]
		public const short TitaniumOre = 1106;

		// Token: 0x0400403D RID: 16445
		[global::Cpp2ILInjected.Token(Token = "0x4005289")]
		public const short TealMushroom = 1107;

		// Token: 0x0400403E RID: 16446
		[global::Cpp2ILInjected.Token(Token = "0x400528A")]
		public const short GreenMushroom = 1108;

		// Token: 0x0400403F RID: 16447
		[global::Cpp2ILInjected.Token(Token = "0x400528B")]
		public const short SkyBlueFlower = 1109;

		// Token: 0x04004040 RID: 16448
		[global::Cpp2ILInjected.Token(Token = "0x400528C")]
		public const short YellowMarigold = 1110;

		// Token: 0x04004041 RID: 16449
		[global::Cpp2ILInjected.Token(Token = "0x400528D")]
		public const short BlueBerries = 1111;

		// Token: 0x04004042 RID: 16450
		[global::Cpp2ILInjected.Token(Token = "0x400528E")]
		public const short LimeKelp = 1112;

		// Token: 0x04004043 RID: 16451
		[global::Cpp2ILInjected.Token(Token = "0x400528F")]
		public const short PinkPricklyPear = 1113;

		// Token: 0x04004044 RID: 16452
		[global::Cpp2ILInjected.Token(Token = "0x4005290")]
		public const short OrangeBloodroot = 1114;

		// Token: 0x04004045 RID: 16453
		[global::Cpp2ILInjected.Token(Token = "0x4005291")]
		public const short RedHusk = 1115;

		// Token: 0x04004046 RID: 16454
		[global::Cpp2ILInjected.Token(Token = "0x4005292")]
		public const short CyanHusk = 1116;

		// Token: 0x04004047 RID: 16455
		[global::Cpp2ILInjected.Token(Token = "0x4005293")]
		public const short VioletHusk = 1117;

		// Token: 0x04004048 RID: 16456
		[global::Cpp2ILInjected.Token(Token = "0x4005294")]
		public const short PurpleMucos = 1118;

		// Token: 0x04004049 RID: 16457
		[global::Cpp2ILInjected.Token(Token = "0x4005295")]
		public const short BlackInk = 1119;

		// Token: 0x0400404A RID: 16458
		[global::Cpp2ILInjected.Token(Token = "0x4005296")]
		public const short DyeVat = 1120;

		// Token: 0x0400404B RID: 16459
		[global::Cpp2ILInjected.Token(Token = "0x4005297")]
		public const short BeeGun = 1121;

		// Token: 0x0400404C RID: 16460
		[global::Cpp2ILInjected.Token(Token = "0x4005298")]
		public const short PossessedHatchet = 1122;

		// Token: 0x0400404D RID: 16461
		[global::Cpp2ILInjected.Token(Token = "0x4005299")]
		public const short BeeKeeper = 1123;

		// Token: 0x0400404E RID: 16462
		[global::Cpp2ILInjected.Token(Token = "0x400529A")]
		public const short Hive = 1124;

		// Token: 0x0400404F RID: 16463
		[global::Cpp2ILInjected.Token(Token = "0x400529B")]
		public const short HoneyBlock = 1125;

		// Token: 0x04004050 RID: 16464
		[global::Cpp2ILInjected.Token(Token = "0x400529C")]
		public const short HiveWall = 1126;

		// Token: 0x04004051 RID: 16465
		[global::Cpp2ILInjected.Token(Token = "0x400529D")]
		public const short CrispyHoneyBlock = 1127;

		// Token: 0x04004052 RID: 16466
		[global::Cpp2ILInjected.Token(Token = "0x400529E")]
		public const short HoneyBucket = 1128;

		// Token: 0x04004053 RID: 16467
		[global::Cpp2ILInjected.Token(Token = "0x400529F")]
		public const short HiveWand = 1129;

		// Token: 0x04004054 RID: 16468
		[global::Cpp2ILInjected.Token(Token = "0x40052A0")]
		public const short Beenade = 1130;

		// Token: 0x04004055 RID: 16469
		[global::Cpp2ILInjected.Token(Token = "0x40052A1")]
		public const short GravityGlobe = 1131;

		// Token: 0x04004056 RID: 16470
		[global::Cpp2ILInjected.Token(Token = "0x40052A2")]
		public const short HoneyComb = 1132;

		// Token: 0x04004057 RID: 16471
		[global::Cpp2ILInjected.Token(Token = "0x40052A3")]
		public const short Abeemination = 1133;

		// Token: 0x04004058 RID: 16472
		[global::Cpp2ILInjected.Token(Token = "0x40052A4")]
		public const short BottledHoney = 1134;

		// Token: 0x04004059 RID: 16473
		[global::Cpp2ILInjected.Token(Token = "0x40052A5")]
		public const short RainHat = 1135;

		// Token: 0x0400405A RID: 16474
		[global::Cpp2ILInjected.Token(Token = "0x40052A6")]
		public const short RainCoat = 1136;

		// Token: 0x0400405B RID: 16475
		[global::Cpp2ILInjected.Token(Token = "0x40052A7")]
		public const short LihzahrdDoor = 1137;

		// Token: 0x0400405C RID: 16476
		[global::Cpp2ILInjected.Token(Token = "0x40052A8")]
		public const short DungeonDoor = 1138;

		// Token: 0x0400405D RID: 16477
		[global::Cpp2ILInjected.Token(Token = "0x40052A9")]
		public const short LeadDoor = 1139;

		// Token: 0x0400405E RID: 16478
		[global::Cpp2ILInjected.Token(Token = "0x40052AA")]
		public const short IronDoor = 1140;

		// Token: 0x0400405F RID: 16479
		[global::Cpp2ILInjected.Token(Token = "0x40052AB")]
		public const short TempleKey = 1141;

		// Token: 0x04004060 RID: 16480
		[global::Cpp2ILInjected.Token(Token = "0x40052AC")]
		public const short LihzahrdChest = 1142;

		// Token: 0x04004061 RID: 16481
		[global::Cpp2ILInjected.Token(Token = "0x40052AD")]
		public const short LihzahrdChair = 1143;

		// Token: 0x04004062 RID: 16482
		[global::Cpp2ILInjected.Token(Token = "0x40052AE")]
		public const short LihzahrdTable = 1144;

		// Token: 0x04004063 RID: 16483
		[global::Cpp2ILInjected.Token(Token = "0x40052AF")]
		public const short LihzahrdWorkBench = 1145;

		// Token: 0x04004064 RID: 16484
		[global::Cpp2ILInjected.Token(Token = "0x40052B0")]
		public const short SuperDartTrap = 1146;

		// Token: 0x04004065 RID: 16485
		[global::Cpp2ILInjected.Token(Token = "0x40052B1")]
		public const short FlameTrap = 1147;

		// Token: 0x04004066 RID: 16486
		[global::Cpp2ILInjected.Token(Token = "0x40052B2")]
		public const short SpikyBallTrap = 1148;

		// Token: 0x04004067 RID: 16487
		[global::Cpp2ILInjected.Token(Token = "0x40052B3")]
		public const short SpearTrap = 1149;

		// Token: 0x04004068 RID: 16488
		[global::Cpp2ILInjected.Token(Token = "0x40052B4")]
		public const short WoodenSpike = 1150;

		// Token: 0x04004069 RID: 16489
		[global::Cpp2ILInjected.Token(Token = "0x40052B5")]
		public const short LihzahrdPressurePlate = 1151;

		// Token: 0x0400406A RID: 16490
		[global::Cpp2ILInjected.Token(Token = "0x40052B6")]
		public const short LihzahrdStatue = 1152;

		// Token: 0x0400406B RID: 16491
		[global::Cpp2ILInjected.Token(Token = "0x40052B7")]
		public const short LihzahrdWatcherStatue = 1153;

		// Token: 0x0400406C RID: 16492
		[global::Cpp2ILInjected.Token(Token = "0x40052B8")]
		public const short LihzahrdGuardianStatue = 1154;

		// Token: 0x0400406D RID: 16493
		[global::Cpp2ILInjected.Token(Token = "0x40052B9")]
		public const short WaspGun = 1155;

		// Token: 0x0400406E RID: 16494
		[global::Cpp2ILInjected.Token(Token = "0x40052BA")]
		public const short PiranhaGun = 1156;

		// Token: 0x0400406F RID: 16495
		[global::Cpp2ILInjected.Token(Token = "0x40052BB")]
		public const short PygmyStaff = 1157;

		// Token: 0x04004070 RID: 16496
		[global::Cpp2ILInjected.Token(Token = "0x40052BC")]
		public const short PygmyNecklace = 1158;

		// Token: 0x04004071 RID: 16497
		[global::Cpp2ILInjected.Token(Token = "0x40052BD")]
		public const short TikiMask = 1159;

		// Token: 0x04004072 RID: 16498
		[global::Cpp2ILInjected.Token(Token = "0x40052BE")]
		public const short TikiShirt = 1160;

		// Token: 0x04004073 RID: 16499
		[global::Cpp2ILInjected.Token(Token = "0x40052BF")]
		public const short TikiPants = 1161;

		// Token: 0x04004074 RID: 16500
		[global::Cpp2ILInjected.Token(Token = "0x40052C0")]
		public const short LeafWings = 1162;

		// Token: 0x04004075 RID: 16501
		[global::Cpp2ILInjected.Token(Token = "0x40052C1")]
		public const short BlizzardinaBalloon = 1163;

		// Token: 0x04004076 RID: 16502
		[global::Cpp2ILInjected.Token(Token = "0x40052C2")]
		public const short BundleofBalloons = 1164;

		// Token: 0x04004077 RID: 16503
		[global::Cpp2ILInjected.Token(Token = "0x40052C3")]
		public const short BatWings = 1165;

		// Token: 0x04004078 RID: 16504
		[global::Cpp2ILInjected.Token(Token = "0x40052C4")]
		public const short BoneSword = 1166;

		// Token: 0x04004079 RID: 16505
		[global::Cpp2ILInjected.Token(Token = "0x40052C5")]
		public const short HerculesBeetle = 1167;

		// Token: 0x0400407A RID: 16506
		[global::Cpp2ILInjected.Token(Token = "0x40052C6")]
		public const short SmokeBomb = 1168;

		// Token: 0x0400407B RID: 16507
		[global::Cpp2ILInjected.Token(Token = "0x40052C7")]
		public const short BoneKey = 1169;

		// Token: 0x0400407C RID: 16508
		[global::Cpp2ILInjected.Token(Token = "0x40052C8")]
		public const short Nectar = 1170;

		// Token: 0x0400407D RID: 16509
		[global::Cpp2ILInjected.Token(Token = "0x40052C9")]
		public const short TikiTotem = 1171;

		// Token: 0x0400407E RID: 16510
		[global::Cpp2ILInjected.Token(Token = "0x40052CA")]
		public const short LizardEgg = 1172;

		// Token: 0x0400407F RID: 16511
		[global::Cpp2ILInjected.Token(Token = "0x40052CB")]
		public const short GraveMarker = 1173;

		// Token: 0x04004080 RID: 16512
		[global::Cpp2ILInjected.Token(Token = "0x40052CC")]
		public const short CrossGraveMarker = 1174;

		// Token: 0x04004081 RID: 16513
		[global::Cpp2ILInjected.Token(Token = "0x40052CD")]
		public const short Headstone = 1175;

		// Token: 0x04004082 RID: 16514
		[global::Cpp2ILInjected.Token(Token = "0x40052CE")]
		public const short Gravestone = 1176;

		// Token: 0x04004083 RID: 16515
		[global::Cpp2ILInjected.Token(Token = "0x40052CF")]
		public const short Obelisk = 1177;

		// Token: 0x04004084 RID: 16516
		[global::Cpp2ILInjected.Token(Token = "0x40052D0")]
		public const short LeafBlower = 1178;

		// Token: 0x04004085 RID: 16517
		[global::Cpp2ILInjected.Token(Token = "0x40052D1")]
		public const short ChlorophyteBullet = 1179;

		// Token: 0x04004086 RID: 16518
		[global::Cpp2ILInjected.Token(Token = "0x40052D2")]
		public const short ParrotCracker = 1180;

		// Token: 0x04004087 RID: 16519
		[global::Cpp2ILInjected.Token(Token = "0x40052D3")]
		public const short StrangeGlowingMushroom = 1181;

		// Token: 0x04004088 RID: 16520
		[global::Cpp2ILInjected.Token(Token = "0x40052D4")]
		public const short Seedling = 1182;

		// Token: 0x04004089 RID: 16521
		[global::Cpp2ILInjected.Token(Token = "0x40052D5")]
		public const short WispinaBottle = 1183;

		// Token: 0x0400408A RID: 16522
		[global::Cpp2ILInjected.Token(Token = "0x40052D6")]
		public const short PalladiumBar = 1184;

		// Token: 0x0400408B RID: 16523
		[global::Cpp2ILInjected.Token(Token = "0x40052D7")]
		public const short PalladiumSword = 1185;

		// Token: 0x0400408C RID: 16524
		[global::Cpp2ILInjected.Token(Token = "0x40052D8")]
		public const short PalladiumPike = 1186;

		// Token: 0x0400408D RID: 16525
		[global::Cpp2ILInjected.Token(Token = "0x40052D9")]
		public const short PalladiumRepeater = 1187;

		// Token: 0x0400408E RID: 16526
		[global::Cpp2ILInjected.Token(Token = "0x40052DA")]
		public const short PalladiumPickaxe = 1188;

		// Token: 0x0400408F RID: 16527
		[global::Cpp2ILInjected.Token(Token = "0x40052DB")]
		public const short PalladiumDrill = 1189;

		// Token: 0x04004090 RID: 16528
		[global::Cpp2ILInjected.Token(Token = "0x40052DC")]
		public const short PalladiumChainsaw = 1190;

		// Token: 0x04004091 RID: 16529
		[global::Cpp2ILInjected.Token(Token = "0x40052DD")]
		public const short OrichalcumBar = 1191;

		// Token: 0x04004092 RID: 16530
		[global::Cpp2ILInjected.Token(Token = "0x40052DE")]
		public const short OrichalcumSword = 1192;

		// Token: 0x04004093 RID: 16531
		[global::Cpp2ILInjected.Token(Token = "0x40052DF")]
		public const short OrichalcumHalberd = 1193;

		// Token: 0x04004094 RID: 16532
		[global::Cpp2ILInjected.Token(Token = "0x40052E0")]
		public const short OrichalcumRepeater = 1194;

		// Token: 0x04004095 RID: 16533
		[global::Cpp2ILInjected.Token(Token = "0x40052E1")]
		public const short OrichalcumPickaxe = 1195;

		// Token: 0x04004096 RID: 16534
		[global::Cpp2ILInjected.Token(Token = "0x40052E2")]
		public const short OrichalcumDrill = 1196;

		// Token: 0x04004097 RID: 16535
		[global::Cpp2ILInjected.Token(Token = "0x40052E3")]
		public const short OrichalcumChainsaw = 1197;

		// Token: 0x04004098 RID: 16536
		[global::Cpp2ILInjected.Token(Token = "0x40052E4")]
		public const short TitaniumBar = 1198;

		// Token: 0x04004099 RID: 16537
		[global::Cpp2ILInjected.Token(Token = "0x40052E5")]
		public const short TitaniumSword = 1199;

		// Token: 0x0400409A RID: 16538
		[global::Cpp2ILInjected.Token(Token = "0x40052E6")]
		public const short TitaniumTrident = 1200;

		// Token: 0x0400409B RID: 16539
		[global::Cpp2ILInjected.Token(Token = "0x40052E7")]
		public const short TitaniumRepeater = 1201;

		// Token: 0x0400409C RID: 16540
		[global::Cpp2ILInjected.Token(Token = "0x40052E8")]
		public const short TitaniumPickaxe = 1202;

		// Token: 0x0400409D RID: 16541
		[global::Cpp2ILInjected.Token(Token = "0x40052E9")]
		public const short TitaniumDrill = 1203;

		// Token: 0x0400409E RID: 16542
		[global::Cpp2ILInjected.Token(Token = "0x40052EA")]
		public const short TitaniumChainsaw = 1204;

		// Token: 0x0400409F RID: 16543
		[global::Cpp2ILInjected.Token(Token = "0x40052EB")]
		public const short PalladiumMask = 1205;

		// Token: 0x040040A0 RID: 16544
		[global::Cpp2ILInjected.Token(Token = "0x40052EC")]
		public const short PalladiumHelmet = 1206;

		// Token: 0x040040A1 RID: 16545
		[global::Cpp2ILInjected.Token(Token = "0x40052ED")]
		public const short PalladiumHeadgear = 1207;

		// Token: 0x040040A2 RID: 16546
		[global::Cpp2ILInjected.Token(Token = "0x40052EE")]
		public const short PalladiumBreastplate = 1208;

		// Token: 0x040040A3 RID: 16547
		[global::Cpp2ILInjected.Token(Token = "0x40052EF")]
		public const short PalladiumLeggings = 1209;

		// Token: 0x040040A4 RID: 16548
		[global::Cpp2ILInjected.Token(Token = "0x40052F0")]
		public const short OrichalcumMask = 1210;

		// Token: 0x040040A5 RID: 16549
		[global::Cpp2ILInjected.Token(Token = "0x40052F1")]
		public const short OrichalcumHelmet = 1211;

		// Token: 0x040040A6 RID: 16550
		[global::Cpp2ILInjected.Token(Token = "0x40052F2")]
		public const short OrichalcumHeadgear = 1212;

		// Token: 0x040040A7 RID: 16551
		[global::Cpp2ILInjected.Token(Token = "0x40052F3")]
		public const short OrichalcumBreastplate = 1213;

		// Token: 0x040040A8 RID: 16552
		[global::Cpp2ILInjected.Token(Token = "0x40052F4")]
		public const short OrichalcumLeggings = 1214;

		// Token: 0x040040A9 RID: 16553
		[global::Cpp2ILInjected.Token(Token = "0x40052F5")]
		public const short TitaniumMask = 1215;

		// Token: 0x040040AA RID: 16554
		[global::Cpp2ILInjected.Token(Token = "0x40052F6")]
		public const short TitaniumHelmet = 1216;

		// Token: 0x040040AB RID: 16555
		[global::Cpp2ILInjected.Token(Token = "0x40052F7")]
		public const short TitaniumHeadgear = 1217;

		// Token: 0x040040AC RID: 16556
		[global::Cpp2ILInjected.Token(Token = "0x40052F8")]
		public const short TitaniumBreastplate = 1218;

		// Token: 0x040040AD RID: 16557
		[global::Cpp2ILInjected.Token(Token = "0x40052F9")]
		public const short TitaniumLeggings = 1219;

		// Token: 0x040040AE RID: 16558
		[global::Cpp2ILInjected.Token(Token = "0x40052FA")]
		public const short OrichalcumAnvil = 1220;

		// Token: 0x040040AF RID: 16559
		[global::Cpp2ILInjected.Token(Token = "0x40052FB")]
		public const short TitaniumForge = 1221;

		// Token: 0x040040B0 RID: 16560
		[global::Cpp2ILInjected.Token(Token = "0x40052FC")]
		public const short PalladiumWaraxe = 1222;

		// Token: 0x040040B1 RID: 16561
		[global::Cpp2ILInjected.Token(Token = "0x40052FD")]
		public const short OrichalcumWaraxe = 1223;

		// Token: 0x040040B2 RID: 16562
		[global::Cpp2ILInjected.Token(Token = "0x40052FE")]
		public const short TitaniumWaraxe = 1224;

		// Token: 0x040040B3 RID: 16563
		[global::Cpp2ILInjected.Token(Token = "0x40052FF")]
		public const short HallowedBar = 1225;

		// Token: 0x040040B4 RID: 16564
		[global::Cpp2ILInjected.Token(Token = "0x4005300")]
		public const short ChlorophyteClaymore = 1226;

		// Token: 0x040040B5 RID: 16565
		[global::Cpp2ILInjected.Token(Token = "0x4005301")]
		public const short ChlorophyteSaber = 1227;

		// Token: 0x040040B6 RID: 16566
		[global::Cpp2ILInjected.Token(Token = "0x4005302")]
		public const short ChlorophytePartisan = 1228;

		// Token: 0x040040B7 RID: 16567
		[global::Cpp2ILInjected.Token(Token = "0x4005303")]
		public const short ChlorophyteShotbow = 1229;

		// Token: 0x040040B8 RID: 16568
		[global::Cpp2ILInjected.Token(Token = "0x4005304")]
		public const short ChlorophytePickaxe = 1230;

		// Token: 0x040040B9 RID: 16569
		[global::Cpp2ILInjected.Token(Token = "0x4005305")]
		public const short ChlorophyteDrill = 1231;

		// Token: 0x040040BA RID: 16570
		[global::Cpp2ILInjected.Token(Token = "0x4005306")]
		public const short ChlorophyteChainsaw = 1232;

		// Token: 0x040040BB RID: 16571
		[global::Cpp2ILInjected.Token(Token = "0x4005307")]
		public const short ChlorophyteGreataxe = 1233;

		// Token: 0x040040BC RID: 16572
		[global::Cpp2ILInjected.Token(Token = "0x4005308")]
		public const short ChlorophyteWarhammer = 1234;

		// Token: 0x040040BD RID: 16573
		[global::Cpp2ILInjected.Token(Token = "0x4005309")]
		public const short ChlorophyteArrow = 1235;

		// Token: 0x040040BE RID: 16574
		[global::Cpp2ILInjected.Token(Token = "0x400530A")]
		public const short AmethystHook = 1236;

		// Token: 0x040040BF RID: 16575
		[global::Cpp2ILInjected.Token(Token = "0x400530B")]
		public const short TopazHook = 1237;

		// Token: 0x040040C0 RID: 16576
		[global::Cpp2ILInjected.Token(Token = "0x400530C")]
		public const short SapphireHook = 1238;

		// Token: 0x040040C1 RID: 16577
		[global::Cpp2ILInjected.Token(Token = "0x400530D")]
		public const short EmeraldHook = 1239;

		// Token: 0x040040C2 RID: 16578
		[global::Cpp2ILInjected.Token(Token = "0x400530E")]
		public const short RubyHook = 1240;

		// Token: 0x040040C3 RID: 16579
		[global::Cpp2ILInjected.Token(Token = "0x400530F")]
		public const short DiamondHook = 1241;

		// Token: 0x040040C4 RID: 16580
		[global::Cpp2ILInjected.Token(Token = "0x4005310")]
		public const short AmberMosquito = 1242;

		// Token: 0x040040C5 RID: 16581
		[global::Cpp2ILInjected.Token(Token = "0x4005311")]
		public const short UmbrellaHat = 1243;

		// Token: 0x040040C6 RID: 16582
		[global::Cpp2ILInjected.Token(Token = "0x4005312")]
		public const short NimbusRod = 1244;

		// Token: 0x040040C7 RID: 16583
		[global::Cpp2ILInjected.Token(Token = "0x4005313")]
		public const short OrangeTorch = 1245;

		// Token: 0x040040C8 RID: 16584
		[global::Cpp2ILInjected.Token(Token = "0x4005314")]
		public const short CrimsandBlock = 1246;

		// Token: 0x040040C9 RID: 16585
		[global::Cpp2ILInjected.Token(Token = "0x4005315")]
		public const short BeeCloak = 1247;

		// Token: 0x040040CA RID: 16586
		[global::Cpp2ILInjected.Token(Token = "0x4005316")]
		public const short EyeoftheGolem = 1248;

		// Token: 0x040040CB RID: 16587
		[global::Cpp2ILInjected.Token(Token = "0x4005317")]
		public const short HoneyBalloon = 1249;

		// Token: 0x040040CC RID: 16588
		[global::Cpp2ILInjected.Token(Token = "0x4005318")]
		public const short BlueHorseshoeBalloon = 1250;

		// Token: 0x040040CD RID: 16589
		[global::Cpp2ILInjected.Token(Token = "0x4005319")]
		public const short WhiteHorseshoeBalloon = 1251;

		// Token: 0x040040CE RID: 16590
		[global::Cpp2ILInjected.Token(Token = "0x400531A")]
		public const short YellowHorseshoeBalloon = 1252;

		// Token: 0x040040CF RID: 16591
		[global::Cpp2ILInjected.Token(Token = "0x400531B")]
		public const short FrozenTurtleShell = 1253;

		// Token: 0x040040D0 RID: 16592
		[global::Cpp2ILInjected.Token(Token = "0x400531C")]
		public const short SniperRifle = 1254;

		// Token: 0x040040D1 RID: 16593
		[global::Cpp2ILInjected.Token(Token = "0x400531D")]
		public const short VenusMagnum = 1255;

		// Token: 0x040040D2 RID: 16594
		[global::Cpp2ILInjected.Token(Token = "0x400531E")]
		public const short CrimsonRod = 1256;

		// Token: 0x040040D3 RID: 16595
		[global::Cpp2ILInjected.Token(Token = "0x400531F")]
		public const short CrimtaneBar = 1257;

		// Token: 0x040040D4 RID: 16596
		[global::Cpp2ILInjected.Token(Token = "0x4005320")]
		public const short Stynger = 1258;

		// Token: 0x040040D5 RID: 16597
		[global::Cpp2ILInjected.Token(Token = "0x4005321")]
		public const short FlowerPow = 1259;

		// Token: 0x040040D6 RID: 16598
		[global::Cpp2ILInjected.Token(Token = "0x4005322")]
		public const short RainbowGun = 1260;

		// Token: 0x040040D7 RID: 16599
		[global::Cpp2ILInjected.Token(Token = "0x4005323")]
		public const short StyngerBolt = 1261;

		// Token: 0x040040D8 RID: 16600
		[global::Cpp2ILInjected.Token(Token = "0x4005324")]
		public const short ChlorophyteJackhammer = 1262;

		// Token: 0x040040D9 RID: 16601
		[global::Cpp2ILInjected.Token(Token = "0x4005325")]
		public const short Teleporter = 1263;

		// Token: 0x040040DA RID: 16602
		[global::Cpp2ILInjected.Token(Token = "0x4005326")]
		public const short FlowerofFrost = 1264;

		// Token: 0x040040DB RID: 16603
		[global::Cpp2ILInjected.Token(Token = "0x4005327")]
		public const short Uzi = 1265;

		// Token: 0x040040DC RID: 16604
		[global::Cpp2ILInjected.Token(Token = "0x4005328")]
		public const short MagnetSphere = 1266;

		// Token: 0x040040DD RID: 16605
		[global::Cpp2ILInjected.Token(Token = "0x4005329")]
		public const short PurpleStainedGlass = 1267;

		// Token: 0x040040DE RID: 16606
		[global::Cpp2ILInjected.Token(Token = "0x400532A")]
		public const short YellowStainedGlass = 1268;

		// Token: 0x040040DF RID: 16607
		[global::Cpp2ILInjected.Token(Token = "0x400532B")]
		public const short BlueStainedGlass = 1269;

		// Token: 0x040040E0 RID: 16608
		[global::Cpp2ILInjected.Token(Token = "0x400532C")]
		public const short GreenStainedGlass = 1270;

		// Token: 0x040040E1 RID: 16609
		[global::Cpp2ILInjected.Token(Token = "0x400532D")]
		public const short RedStainedGlass = 1271;

		// Token: 0x040040E2 RID: 16610
		[global::Cpp2ILInjected.Token(Token = "0x400532E")]
		public const short MulticoloredStainedGlass = 1272;

		// Token: 0x040040E3 RID: 16611
		[global::Cpp2ILInjected.Token(Token = "0x400532F")]
		public const short SkeletronHand = 1273;

		// Token: 0x040040E4 RID: 16612
		[global::Cpp2ILInjected.Token(Token = "0x4005330")]
		public const short Skull = 1274;

		// Token: 0x040040E5 RID: 16613
		[global::Cpp2ILInjected.Token(Token = "0x4005331")]
		public const short BallaHat = 1275;

		// Token: 0x040040E6 RID: 16614
		[global::Cpp2ILInjected.Token(Token = "0x4005332")]
		public const short GangstaHat = 1276;

		// Token: 0x040040E7 RID: 16615
		[global::Cpp2ILInjected.Token(Token = "0x4005333")]
		public const short SailorHat = 1277;

		// Token: 0x040040E8 RID: 16616
		[global::Cpp2ILInjected.Token(Token = "0x4005334")]
		public const short EyePatch = 1278;

		// Token: 0x040040E9 RID: 16617
		[global::Cpp2ILInjected.Token(Token = "0x4005335")]
		public const short SailorShirt = 1279;

		// Token: 0x040040EA RID: 16618
		[global::Cpp2ILInjected.Token(Token = "0x4005336")]
		public const short SailorPants = 1280;

		// Token: 0x040040EB RID: 16619
		[global::Cpp2ILInjected.Token(Token = "0x4005337")]
		public const short SkeletronMask = 1281;

		// Token: 0x040040EC RID: 16620
		[global::Cpp2ILInjected.Token(Token = "0x4005338")]
		public const short AmethystRobe = 1282;

		// Token: 0x040040ED RID: 16621
		[global::Cpp2ILInjected.Token(Token = "0x4005339")]
		public const short TopazRobe = 1283;

		// Token: 0x040040EE RID: 16622
		[global::Cpp2ILInjected.Token(Token = "0x400533A")]
		public const short SapphireRobe = 1284;

		// Token: 0x040040EF RID: 16623
		[global::Cpp2ILInjected.Token(Token = "0x400533B")]
		public const short EmeraldRobe = 1285;

		// Token: 0x040040F0 RID: 16624
		[global::Cpp2ILInjected.Token(Token = "0x400533C")]
		public const short RubyRobe = 1286;

		// Token: 0x040040F1 RID: 16625
		[global::Cpp2ILInjected.Token(Token = "0x400533D")]
		public const short DiamondRobe = 1287;

		// Token: 0x040040F2 RID: 16626
		[global::Cpp2ILInjected.Token(Token = "0x400533E")]
		public const short WhiteTuxedoShirt = 1288;

		// Token: 0x040040F3 RID: 16627
		[global::Cpp2ILInjected.Token(Token = "0x400533F")]
		public const short WhiteTuxedoPants = 1289;

		// Token: 0x040040F4 RID: 16628
		[global::Cpp2ILInjected.Token(Token = "0x4005340")]
		public const short PanicNecklace = 1290;

		// Token: 0x040040F5 RID: 16629
		[global::Cpp2ILInjected.Token(Token = "0x4005341")]
		public const short LifeFruit = 1291;

		// Token: 0x040040F6 RID: 16630
		[global::Cpp2ILInjected.Token(Token = "0x4005342")]
		public const short LihzahrdAltar = 1292;

		// Token: 0x040040F7 RID: 16631
		[global::Cpp2ILInjected.Token(Token = "0x4005343")]
		public const short LihzahrdPowerCell = 1293;

		// Token: 0x040040F8 RID: 16632
		[global::Cpp2ILInjected.Token(Token = "0x4005344")]
		public const short Picksaw = 1294;

		// Token: 0x040040F9 RID: 16633
		[global::Cpp2ILInjected.Token(Token = "0x4005345")]
		public const short HeatRay = 1295;

		// Token: 0x040040FA RID: 16634
		[global::Cpp2ILInjected.Token(Token = "0x4005346")]
		public const short StaffofEarth = 1296;

		// Token: 0x040040FB RID: 16635
		[global::Cpp2ILInjected.Token(Token = "0x4005347")]
		public const short GolemFist = 1297;

		// Token: 0x040040FC RID: 16636
		[global::Cpp2ILInjected.Token(Token = "0x4005348")]
		public const short WaterChest = 1298;

		// Token: 0x040040FD RID: 16637
		[global::Cpp2ILInjected.Token(Token = "0x4005349")]
		public const short Binoculars = 1299;

		// Token: 0x040040FE RID: 16638
		[global::Cpp2ILInjected.Token(Token = "0x400534A")]
		public const short RifleScope = 1300;

		// Token: 0x040040FF RID: 16639
		[global::Cpp2ILInjected.Token(Token = "0x400534B")]
		public const short DestroyerEmblem = 1301;

		// Token: 0x04004100 RID: 16640
		[global::Cpp2ILInjected.Token(Token = "0x400534C")]
		public const short HighVelocityBullet = 1302;

		// Token: 0x04004101 RID: 16641
		[global::Cpp2ILInjected.Token(Token = "0x400534D")]
		public const short JellyfishNecklace = 1303;

		// Token: 0x04004102 RID: 16642
		[global::Cpp2ILInjected.Token(Token = "0x400534E")]
		public const short ZombieArm = 1304;

		// Token: 0x04004103 RID: 16643
		[global::Cpp2ILInjected.Token(Token = "0x400534F")]
		public const short TheAxe = 1305;

		// Token: 0x04004104 RID: 16644
		[global::Cpp2ILInjected.Token(Token = "0x4005350")]
		public const short IceSickle = 1306;

		// Token: 0x04004105 RID: 16645
		[global::Cpp2ILInjected.Token(Token = "0x4005351")]
		public const short ClothierVoodooDoll = 1307;

		// Token: 0x04004106 RID: 16646
		[global::Cpp2ILInjected.Token(Token = "0x4005352")]
		public const short PoisonStaff = 1308;

		// Token: 0x04004107 RID: 16647
		[global::Cpp2ILInjected.Token(Token = "0x4005353")]
		public const short SlimeStaff = 1309;

		// Token: 0x04004108 RID: 16648
		[global::Cpp2ILInjected.Token(Token = "0x4005354")]
		public const short PoisonDart = 1310;

		// Token: 0x04004109 RID: 16649
		[global::Cpp2ILInjected.Token(Token = "0x4005355")]
		public const short EyeSpring = 1311;

		// Token: 0x0400410A RID: 16650
		[global::Cpp2ILInjected.Token(Token = "0x4005356")]
		public const short ToySled = 1312;

		// Token: 0x0400410B RID: 16651
		[global::Cpp2ILInjected.Token(Token = "0x4005357")]
		public const short BookofSkulls = 1313;

		// Token: 0x0400410C RID: 16652
		[global::Cpp2ILInjected.Token(Token = "0x4005358")]
		public const short KOCannon = 1314;

		// Token: 0x0400410D RID: 16653
		[global::Cpp2ILInjected.Token(Token = "0x4005359")]
		public const short PirateMap = 1315;

		// Token: 0x0400410E RID: 16654
		[global::Cpp2ILInjected.Token(Token = "0x400535A")]
		public const short TurtleHelmet = 1316;

		// Token: 0x0400410F RID: 16655
		[global::Cpp2ILInjected.Token(Token = "0x400535B")]
		public const short TurtleScaleMail = 1317;

		// Token: 0x04004110 RID: 16656
		[global::Cpp2ILInjected.Token(Token = "0x400535C")]
		public const short TurtleLeggings = 1318;

		// Token: 0x04004111 RID: 16657
		[global::Cpp2ILInjected.Token(Token = "0x400535D")]
		public const short SnowballCannon = 1319;

		// Token: 0x04004112 RID: 16658
		[global::Cpp2ILInjected.Token(Token = "0x400535E")]
		public const short BonePickaxe = 1320;

		// Token: 0x04004113 RID: 16659
		[global::Cpp2ILInjected.Token(Token = "0x400535F")]
		public const short MagicQuiver = 1321;

		// Token: 0x04004114 RID: 16660
		[global::Cpp2ILInjected.Token(Token = "0x4005360")]
		public const short MagmaStone = 1322;

		// Token: 0x04004115 RID: 16661
		[global::Cpp2ILInjected.Token(Token = "0x4005361")]
		public const short ObsidianRose = 1323;

		// Token: 0x04004116 RID: 16662
		[global::Cpp2ILInjected.Token(Token = "0x4005362")]
		public const short Bananarang = 1324;

		// Token: 0x04004117 RID: 16663
		[global::Cpp2ILInjected.Token(Token = "0x4005363")]
		public const short ChainKnife = 1325;

		// Token: 0x04004118 RID: 16664
		[global::Cpp2ILInjected.Token(Token = "0x4005364")]
		public const short RodofDiscord = 1326;

		// Token: 0x04004119 RID: 16665
		[global::Cpp2ILInjected.Token(Token = "0x4005365")]
		public const short DeathSickle = 1327;

		// Token: 0x0400411A RID: 16666
		[global::Cpp2ILInjected.Token(Token = "0x4005366")]
		public const short TurtleShell = 1328;

		// Token: 0x0400411B RID: 16667
		[global::Cpp2ILInjected.Token(Token = "0x4005367")]
		public const short TissueSample = 1329;

		// Token: 0x0400411C RID: 16668
		[global::Cpp2ILInjected.Token(Token = "0x4005368")]
		public const short Vertebrae = 1330;

		// Token: 0x0400411D RID: 16669
		[global::Cpp2ILInjected.Token(Token = "0x4005369")]
		public const short BloodySpine = 1331;

		// Token: 0x0400411E RID: 16670
		[global::Cpp2ILInjected.Token(Token = "0x400536A")]
		public const short Ichor = 1332;

		// Token: 0x0400411F RID: 16671
		[global::Cpp2ILInjected.Token(Token = "0x400536B")]
		public const short IchorTorch = 1333;

		// Token: 0x04004120 RID: 16672
		[global::Cpp2ILInjected.Token(Token = "0x400536C")]
		public const short IchorArrow = 1334;

		// Token: 0x04004121 RID: 16673
		[global::Cpp2ILInjected.Token(Token = "0x400536D")]
		public const short IchorBullet = 1335;

		// Token: 0x04004122 RID: 16674
		[global::Cpp2ILInjected.Token(Token = "0x400536E")]
		public const short GoldenShower = 1336;

		// Token: 0x04004123 RID: 16675
		[global::Cpp2ILInjected.Token(Token = "0x400536F")]
		public const short BunnyCannon = 1337;

		// Token: 0x04004124 RID: 16676
		[global::Cpp2ILInjected.Token(Token = "0x4005370")]
		public const short ExplosiveBunny = 1338;

		// Token: 0x04004125 RID: 16677
		[global::Cpp2ILInjected.Token(Token = "0x4005371")]
		public const short VialofVenom = 1339;

		// Token: 0x04004126 RID: 16678
		[global::Cpp2ILInjected.Token(Token = "0x4005372")]
		public const short FlaskofVenom = 1340;

		// Token: 0x04004127 RID: 16679
		[global::Cpp2ILInjected.Token(Token = "0x4005373")]
		public const short VenomArrow = 1341;

		// Token: 0x04004128 RID: 16680
		[global::Cpp2ILInjected.Token(Token = "0x4005374")]
		public const short VenomBullet = 1342;

		// Token: 0x04004129 RID: 16681
		[global::Cpp2ILInjected.Token(Token = "0x4005375")]
		public const short FireGauntlet = 1343;

		// Token: 0x0400412A RID: 16682
		[global::Cpp2ILInjected.Token(Token = "0x4005376")]
		public const short Cog = 1344;

		// Token: 0x0400412B RID: 16683
		[global::Cpp2ILInjected.Token(Token = "0x4005377")]
		public const short Confetti = 1345;

		// Token: 0x0400412C RID: 16684
		[global::Cpp2ILInjected.Token(Token = "0x4005378")]
		public const short Nanites = 1346;

		// Token: 0x0400412D RID: 16685
		[global::Cpp2ILInjected.Token(Token = "0x4005379")]
		public const short ExplosivePowder = 1347;

		// Token: 0x0400412E RID: 16686
		[global::Cpp2ILInjected.Token(Token = "0x400537A")]
		public const short GoldDust = 1348;

		// Token: 0x0400412F RID: 16687
		[global::Cpp2ILInjected.Token(Token = "0x400537B")]
		public const short PartyBullet = 1349;

		// Token: 0x04004130 RID: 16688
		[global::Cpp2ILInjected.Token(Token = "0x400537C")]
		public const short NanoBullet = 1350;

		// Token: 0x04004131 RID: 16689
		[global::Cpp2ILInjected.Token(Token = "0x400537D")]
		public const short ExplodingBullet = 1351;

		// Token: 0x04004132 RID: 16690
		[global::Cpp2ILInjected.Token(Token = "0x400537E")]
		public const short GoldenBullet = 1352;

		// Token: 0x04004133 RID: 16691
		[global::Cpp2ILInjected.Token(Token = "0x400537F")]
		public const short FlaskofCursedFlames = 1353;

		// Token: 0x04004134 RID: 16692
		[global::Cpp2ILInjected.Token(Token = "0x4005380")]
		public const short FlaskofFire = 1354;

		// Token: 0x04004135 RID: 16693
		[global::Cpp2ILInjected.Token(Token = "0x4005381")]
		public const short FlaskofGold = 1355;

		// Token: 0x04004136 RID: 16694
		[global::Cpp2ILInjected.Token(Token = "0x4005382")]
		public const short FlaskofIchor = 1356;

		// Token: 0x04004137 RID: 16695
		[global::Cpp2ILInjected.Token(Token = "0x4005383")]
		public const short FlaskofNanites = 1357;

		// Token: 0x04004138 RID: 16696
		[global::Cpp2ILInjected.Token(Token = "0x4005384")]
		public const short FlaskofParty = 1358;

		// Token: 0x04004139 RID: 16697
		[global::Cpp2ILInjected.Token(Token = "0x4005385")]
		public const short FlaskofPoison = 1359;

		// Token: 0x0400413A RID: 16698
		[global::Cpp2ILInjected.Token(Token = "0x4005386")]
		public const short EyeofCthulhuTrophy = 1360;

		// Token: 0x0400413B RID: 16699
		[global::Cpp2ILInjected.Token(Token = "0x4005387")]
		public const short EaterofWorldsTrophy = 1361;

		// Token: 0x0400413C RID: 16700
		[global::Cpp2ILInjected.Token(Token = "0x4005388")]
		public const short BrainofCthulhuTrophy = 1362;

		// Token: 0x0400413D RID: 16701
		[global::Cpp2ILInjected.Token(Token = "0x4005389")]
		public const short SkeletronTrophy = 1363;

		// Token: 0x0400413E RID: 16702
		[global::Cpp2ILInjected.Token(Token = "0x400538A")]
		public const short QueenBeeTrophy = 1364;

		// Token: 0x0400413F RID: 16703
		[global::Cpp2ILInjected.Token(Token = "0x400538B")]
		public const short WallofFleshTrophy = 1365;

		// Token: 0x04004140 RID: 16704
		[global::Cpp2ILInjected.Token(Token = "0x400538C")]
		public const short DestroyerTrophy = 1366;

		// Token: 0x04004141 RID: 16705
		[global::Cpp2ILInjected.Token(Token = "0x400538D")]
		public const short SkeletronPrimeTrophy = 1367;

		// Token: 0x04004142 RID: 16706
		[global::Cpp2ILInjected.Token(Token = "0x400538E")]
		public const short RetinazerTrophy = 1368;

		// Token: 0x04004143 RID: 16707
		[global::Cpp2ILInjected.Token(Token = "0x400538F")]
		public const short SpazmatismTrophy = 1369;

		// Token: 0x04004144 RID: 16708
		[global::Cpp2ILInjected.Token(Token = "0x4005390")]
		public const short PlanteraTrophy = 1370;

		// Token: 0x04004145 RID: 16709
		[global::Cpp2ILInjected.Token(Token = "0x4005391")]
		public const short GolemTrophy = 1371;

		// Token: 0x04004146 RID: 16710
		[global::Cpp2ILInjected.Token(Token = "0x4005392")]
		public const short BloodMoonRising = 1372;

		// Token: 0x04004147 RID: 16711
		[global::Cpp2ILInjected.Token(Token = "0x4005393")]
		public const short TheHangedMan = 1373;

		// Token: 0x04004148 RID: 16712
		[global::Cpp2ILInjected.Token(Token = "0x4005394")]
		public const short GloryoftheFire = 1374;

		// Token: 0x04004149 RID: 16713
		[global::Cpp2ILInjected.Token(Token = "0x4005395")]
		public const short BoneWarp = 1375;

		// Token: 0x0400414A RID: 16714
		[global::Cpp2ILInjected.Token(Token = "0x4005396")]
		public const short WallSkeleton = 1376;

		// Token: 0x0400414B RID: 16715
		[global::Cpp2ILInjected.Token(Token = "0x4005397")]
		public const short HangingSkeleton = 1377;

		// Token: 0x0400414C RID: 16716
		[global::Cpp2ILInjected.Token(Token = "0x4005398")]
		public const short BlueSlabWall = 1378;

		// Token: 0x0400414D RID: 16717
		[global::Cpp2ILInjected.Token(Token = "0x4005399")]
		public const short BlueTiledWall = 1379;

		// Token: 0x0400414E RID: 16718
		[global::Cpp2ILInjected.Token(Token = "0x400539A")]
		public const short PinkSlabWall = 1380;

		// Token: 0x0400414F RID: 16719
		[global::Cpp2ILInjected.Token(Token = "0x400539B")]
		public const short PinkTiledWall = 1381;

		// Token: 0x04004150 RID: 16720
		[global::Cpp2ILInjected.Token(Token = "0x400539C")]
		public const short GreenSlabWall = 1382;

		// Token: 0x04004151 RID: 16721
		[global::Cpp2ILInjected.Token(Token = "0x400539D")]
		public const short GreenTiledWall = 1383;

		// Token: 0x04004152 RID: 16722
		[global::Cpp2ILInjected.Token(Token = "0x400539E")]
		public const short BlueBrickPlatform = 1384;

		// Token: 0x04004153 RID: 16723
		[global::Cpp2ILInjected.Token(Token = "0x400539F")]
		public const short PinkBrickPlatform = 1385;

		// Token: 0x04004154 RID: 16724
		[global::Cpp2ILInjected.Token(Token = "0x40053A0")]
		public const short GreenBrickPlatform = 1386;

		// Token: 0x04004155 RID: 16725
		[global::Cpp2ILInjected.Token(Token = "0x40053A1")]
		public const short MetalShelf = 1387;

		// Token: 0x04004156 RID: 16726
		[global::Cpp2ILInjected.Token(Token = "0x40053A2")]
		public const short BrassShelf = 1388;

		// Token: 0x04004157 RID: 16727
		[global::Cpp2ILInjected.Token(Token = "0x40053A3")]
		public const short WoodShelf = 1389;

		// Token: 0x04004158 RID: 16728
		[global::Cpp2ILInjected.Token(Token = "0x40053A4")]
		public const short BrassLantern = 1390;

		// Token: 0x04004159 RID: 16729
		[global::Cpp2ILInjected.Token(Token = "0x40053A5")]
		public const short CagedLantern = 1391;

		// Token: 0x0400415A RID: 16730
		[global::Cpp2ILInjected.Token(Token = "0x40053A6")]
		public const short CarriageLantern = 1392;

		// Token: 0x0400415B RID: 16731
		[global::Cpp2ILInjected.Token(Token = "0x40053A7")]
		public const short AlchemyLantern = 1393;

		// Token: 0x0400415C RID: 16732
		[global::Cpp2ILInjected.Token(Token = "0x40053A8")]
		public const short DiablostLamp = 1394;

		// Token: 0x0400415D RID: 16733
		[global::Cpp2ILInjected.Token(Token = "0x40053A9")]
		public const short OilRagSconse = 1395;

		// Token: 0x0400415E RID: 16734
		[global::Cpp2ILInjected.Token(Token = "0x40053AA")]
		public const short BlueDungeonChair = 1396;

		// Token: 0x0400415F RID: 16735
		[global::Cpp2ILInjected.Token(Token = "0x40053AB")]
		public const short BlueDungeonTable = 1397;

		// Token: 0x04004160 RID: 16736
		[global::Cpp2ILInjected.Token(Token = "0x40053AC")]
		public const short BlueDungeonWorkBench = 1398;

		// Token: 0x04004161 RID: 16737
		[global::Cpp2ILInjected.Token(Token = "0x40053AD")]
		public const short GreenDungeonChair = 1399;

		// Token: 0x04004162 RID: 16738
		[global::Cpp2ILInjected.Token(Token = "0x40053AE")]
		public const short GreenDungeonTable = 1400;

		// Token: 0x04004163 RID: 16739
		[global::Cpp2ILInjected.Token(Token = "0x40053AF")]
		public const short GreenDungeonWorkBench = 1401;

		// Token: 0x04004164 RID: 16740
		[global::Cpp2ILInjected.Token(Token = "0x40053B0")]
		public const short PinkDungeonChair = 1402;

		// Token: 0x04004165 RID: 16741
		[global::Cpp2ILInjected.Token(Token = "0x40053B1")]
		public const short PinkDungeonTable = 1403;

		// Token: 0x04004166 RID: 16742
		[global::Cpp2ILInjected.Token(Token = "0x40053B2")]
		public const short PinkDungeonWorkBench = 1404;

		// Token: 0x04004167 RID: 16743
		[global::Cpp2ILInjected.Token(Token = "0x40053B3")]
		public const short BlueDungeonCandle = 1405;

		// Token: 0x04004168 RID: 16744
		[global::Cpp2ILInjected.Token(Token = "0x40053B4")]
		public const short GreenDungeonCandle = 1406;

		// Token: 0x04004169 RID: 16745
		[global::Cpp2ILInjected.Token(Token = "0x40053B5")]
		public const short PinkDungeonCandle = 1407;

		// Token: 0x0400416A RID: 16746
		[global::Cpp2ILInjected.Token(Token = "0x40053B6")]
		public const short BlueDungeonVase = 1408;

		// Token: 0x0400416B RID: 16747
		[global::Cpp2ILInjected.Token(Token = "0x40053B7")]
		public const short GreenDungeonVase = 1409;

		// Token: 0x0400416C RID: 16748
		[global::Cpp2ILInjected.Token(Token = "0x40053B8")]
		public const short PinkDungeonVase = 1410;

		// Token: 0x0400416D RID: 16749
		[global::Cpp2ILInjected.Token(Token = "0x40053B9")]
		public const short BlueDungeonDoor = 1411;

		// Token: 0x0400416E RID: 16750
		[global::Cpp2ILInjected.Token(Token = "0x40053BA")]
		public const short GreenDungeonDoor = 1412;

		// Token: 0x0400416F RID: 16751
		[global::Cpp2ILInjected.Token(Token = "0x40053BB")]
		public const short PinkDungeonDoor = 1413;

		// Token: 0x04004170 RID: 16752
		[global::Cpp2ILInjected.Token(Token = "0x40053BC")]
		public const short BlueDungeonBookcase = 1414;

		// Token: 0x04004171 RID: 16753
		[global::Cpp2ILInjected.Token(Token = "0x40053BD")]
		public const short GreenDungeonBookcase = 1415;

		// Token: 0x04004172 RID: 16754
		[global::Cpp2ILInjected.Token(Token = "0x40053BE")]
		public const short PinkDungeonBookcase = 1416;

		// Token: 0x04004173 RID: 16755
		[global::Cpp2ILInjected.Token(Token = "0x40053BF")]
		public const short Catacomb = 1417;

		// Token: 0x04004174 RID: 16756
		[global::Cpp2ILInjected.Token(Token = "0x40053C0")]
		public const short DungeonShelf = 1418;

		// Token: 0x04004175 RID: 16757
		[global::Cpp2ILInjected.Token(Token = "0x40053C1")]
		public const short SkellingtonJSkellingsworth = 1419;

		// Token: 0x04004176 RID: 16758
		[global::Cpp2ILInjected.Token(Token = "0x40053C2")]
		public const short TheCursedMan = 1420;

		// Token: 0x04004177 RID: 16759
		[global::Cpp2ILInjected.Token(Token = "0x40053C3")]
		public const short TheEyeSeestheEnd = 1421;

		// Token: 0x04004178 RID: 16760
		[global::Cpp2ILInjected.Token(Token = "0x40053C4")]
		public const short SomethingEvilisWatchingYou = 1422;

		// Token: 0x04004179 RID: 16761
		[global::Cpp2ILInjected.Token(Token = "0x40053C5")]
		public const short TheTwinsHaveAwoken = 1423;

		// Token: 0x0400417A RID: 16762
		[global::Cpp2ILInjected.Token(Token = "0x40053C6")]
		public const short TheScreamer = 1424;

		// Token: 0x0400417B RID: 16763
		[global::Cpp2ILInjected.Token(Token = "0x40053C7")]
		public const short GoblinsPlayingPoker = 1425;

		// Token: 0x0400417C RID: 16764
		[global::Cpp2ILInjected.Token(Token = "0x40053C8")]
		public const short Dryadisque = 1426;

		// Token: 0x0400417D RID: 16765
		[global::Cpp2ILInjected.Token(Token = "0x40053C9")]
		public const short Sunflowers = 1427;

		// Token: 0x0400417E RID: 16766
		[global::Cpp2ILInjected.Token(Token = "0x40053CA")]
		public const short TerrarianGothic = 1428;

		// Token: 0x0400417F RID: 16767
		[global::Cpp2ILInjected.Token(Token = "0x40053CB")]
		public const short Beanie = 1429;

		// Token: 0x04004180 RID: 16768
		[global::Cpp2ILInjected.Token(Token = "0x40053CC")]
		public const short ImbuingStation = 1430;

		// Token: 0x04004181 RID: 16769
		[global::Cpp2ILInjected.Token(Token = "0x40053CD")]
		public const short StarinaBottle = 1431;

		// Token: 0x04004182 RID: 16770
		[global::Cpp2ILInjected.Token(Token = "0x40053CE")]
		public const short EmptyBullet = 1432;

		// Token: 0x04004183 RID: 16771
		[global::Cpp2ILInjected.Token(Token = "0x40053CF")]
		public const short Impact = 1433;

		// Token: 0x04004184 RID: 16772
		[global::Cpp2ILInjected.Token(Token = "0x40053D0")]
		public const short PoweredbyBirds = 1434;

		// Token: 0x04004185 RID: 16773
		[global::Cpp2ILInjected.Token(Token = "0x40053D1")]
		public const short TheDestroyer = 1435;

		// Token: 0x04004186 RID: 16774
		[global::Cpp2ILInjected.Token(Token = "0x40053D2")]
		public const short ThePersistencyofEyes = 1436;

		// Token: 0x04004187 RID: 16775
		[global::Cpp2ILInjected.Token(Token = "0x40053D3")]
		public const short UnicornCrossingtheHallows = 1437;

		// Token: 0x04004188 RID: 16776
		[global::Cpp2ILInjected.Token(Token = "0x40053D4")]
		public const short GreatWave = 1438;

		// Token: 0x04004189 RID: 16777
		[global::Cpp2ILInjected.Token(Token = "0x40053D5")]
		public const short StarryNight = 1439;

		// Token: 0x0400418A RID: 16778
		[global::Cpp2ILInjected.Token(Token = "0x40053D6")]
		public const short GuidePicasso = 1440;

		// Token: 0x0400418B RID: 16779
		[global::Cpp2ILInjected.Token(Token = "0x40053D7")]
		public const short TheGuardiansGaze = 1441;

		// Token: 0x0400418C RID: 16780
		[global::Cpp2ILInjected.Token(Token = "0x40053D8")]
		public const short FatherofSomeone = 1442;

		// Token: 0x0400418D RID: 16781
		[global::Cpp2ILInjected.Token(Token = "0x40053D9")]
		public const short NurseLisa = 1443;

		// Token: 0x0400418E RID: 16782
		[global::Cpp2ILInjected.Token(Token = "0x40053DA")]
		public const short ShadowbeamStaff = 1444;

		// Token: 0x0400418F RID: 16783
		[global::Cpp2ILInjected.Token(Token = "0x40053DB")]
		public const short InfernoFork = 1445;

		// Token: 0x04004190 RID: 16784
		[global::Cpp2ILInjected.Token(Token = "0x40053DC")]
		public const short SpectreStaff = 1446;

		// Token: 0x04004191 RID: 16785
		[global::Cpp2ILInjected.Token(Token = "0x40053DD")]
		public const short WoodenFence = 1447;

		// Token: 0x04004192 RID: 16786
		[global::Cpp2ILInjected.Token(Token = "0x40053DE")]
		public const short LeadFence = 1448;

		// Token: 0x04004193 RID: 16787
		[global::Cpp2ILInjected.Token(Token = "0x40053DF")]
		public const short BubbleMachine = 1449;

		// Token: 0x04004194 RID: 16788
		[global::Cpp2ILInjected.Token(Token = "0x40053E0")]
		public const short BubbleWand = 1450;

		// Token: 0x04004195 RID: 16789
		[global::Cpp2ILInjected.Token(Token = "0x40053E1")]
		public const short MarchingBonesBanner = 1451;

		// Token: 0x04004196 RID: 16790
		[global::Cpp2ILInjected.Token(Token = "0x40053E2")]
		public const short NecromanticSign = 1452;

		// Token: 0x04004197 RID: 16791
		[global::Cpp2ILInjected.Token(Token = "0x40053E3")]
		public const short RustedCompanyStandard = 1453;

		// Token: 0x04004198 RID: 16792
		[global::Cpp2ILInjected.Token(Token = "0x40053E4")]
		public const short RaggedBrotherhoodSigil = 1454;

		// Token: 0x04004199 RID: 16793
		[global::Cpp2ILInjected.Token(Token = "0x40053E5")]
		public const short MoltenLegionFlag = 1455;

		// Token: 0x0400419A RID: 16794
		[global::Cpp2ILInjected.Token(Token = "0x40053E6")]
		public const short DiabolicSigil = 1456;

		// Token: 0x0400419B RID: 16795
		[global::Cpp2ILInjected.Token(Token = "0x40053E7")]
		public const short ObsidianPlatform = 1457;

		// Token: 0x0400419C RID: 16796
		[global::Cpp2ILInjected.Token(Token = "0x40053E8")]
		public const short ObsidianDoor = 1458;

		// Token: 0x0400419D RID: 16797
		[global::Cpp2ILInjected.Token(Token = "0x40053E9")]
		public const short ObsidianChair = 1459;

		// Token: 0x0400419E RID: 16798
		[global::Cpp2ILInjected.Token(Token = "0x40053EA")]
		public const short ObsidianTable = 1460;

		// Token: 0x0400419F RID: 16799
		[global::Cpp2ILInjected.Token(Token = "0x40053EB")]
		public const short ObsidianWorkBench = 1461;

		// Token: 0x040041A0 RID: 16800
		[global::Cpp2ILInjected.Token(Token = "0x40053EC")]
		public const short ObsidianVase = 1462;

		// Token: 0x040041A1 RID: 16801
		[global::Cpp2ILInjected.Token(Token = "0x40053ED")]
		public const short ObsidianBookcase = 1463;

		// Token: 0x040041A2 RID: 16802
		[global::Cpp2ILInjected.Token(Token = "0x40053EE")]
		public const short HellboundBanner = 1464;

		// Token: 0x040041A3 RID: 16803
		[global::Cpp2ILInjected.Token(Token = "0x40053EF")]
		public const short HellHammerBanner = 1465;

		// Token: 0x040041A4 RID: 16804
		[global::Cpp2ILInjected.Token(Token = "0x40053F0")]
		public const short HelltowerBanner = 1466;

		// Token: 0x040041A5 RID: 16805
		[global::Cpp2ILInjected.Token(Token = "0x40053F1")]
		public const short LostHopesofManBanner = 1467;

		// Token: 0x040041A6 RID: 16806
		[global::Cpp2ILInjected.Token(Token = "0x40053F2")]
		public const short ObsidianWatcherBanner = 1468;

		// Token: 0x040041A7 RID: 16807
		[global::Cpp2ILInjected.Token(Token = "0x40053F3")]
		public const short LavaEruptsBanner = 1469;

		// Token: 0x040041A8 RID: 16808
		[global::Cpp2ILInjected.Token(Token = "0x40053F4")]
		public const short BlueDungeonBed = 1470;

		// Token: 0x040041A9 RID: 16809
		[global::Cpp2ILInjected.Token(Token = "0x40053F5")]
		public const short GreenDungeonBed = 1471;

		// Token: 0x040041AA RID: 16810
		[global::Cpp2ILInjected.Token(Token = "0x40053F6")]
		public const short PinkDungeonBed = 1472;

		// Token: 0x040041AB RID: 16811
		[global::Cpp2ILInjected.Token(Token = "0x40053F7")]
		public const short ObsidianBed = 1473;

		// Token: 0x040041AC RID: 16812
		[global::Cpp2ILInjected.Token(Token = "0x40053F8")]
		public const short Waldo = 1474;

		// Token: 0x040041AD RID: 16813
		[global::Cpp2ILInjected.Token(Token = "0x40053F9")]
		public const short Darkness = 1475;

		// Token: 0x040041AE RID: 16814
		[global::Cpp2ILInjected.Token(Token = "0x40053FA")]
		public const short DarkSoulReaper = 1476;

		// Token: 0x040041AF RID: 16815
		[global::Cpp2ILInjected.Token(Token = "0x40053FB")]
		public const short Land = 1477;

		// Token: 0x040041B0 RID: 16816
		[global::Cpp2ILInjected.Token(Token = "0x40053FC")]
		public const short TrappedGhost = 1478;

		// Token: 0x040041B1 RID: 16817
		[global::Cpp2ILInjected.Token(Token = "0x40053FD")]
		public const short DemonsEye = 1479;

		// Token: 0x040041B2 RID: 16818
		[global::Cpp2ILInjected.Token(Token = "0x40053FE")]
		public const short FindingGold = 1480;

		// Token: 0x040041B3 RID: 16819
		[global::Cpp2ILInjected.Token(Token = "0x40053FF")]
		public const short FirstEncounter = 1481;

		// Token: 0x040041B4 RID: 16820
		[global::Cpp2ILInjected.Token(Token = "0x4005400")]
		public const short GoodMorning = 1482;

		// Token: 0x040041B5 RID: 16821
		[global::Cpp2ILInjected.Token(Token = "0x4005401")]
		public const short UndergroundReward = 1483;

		// Token: 0x040041B6 RID: 16822
		[global::Cpp2ILInjected.Token(Token = "0x4005402")]
		public const short ThroughtheWindow = 1484;

		// Token: 0x040041B7 RID: 16823
		[global::Cpp2ILInjected.Token(Token = "0x4005403")]
		public const short PlaceAbovetheClouds = 1485;

		// Token: 0x040041B8 RID: 16824
		[global::Cpp2ILInjected.Token(Token = "0x4005404")]
		public const short DoNotStepontheGrass = 1486;

		// Token: 0x040041B9 RID: 16825
		[global::Cpp2ILInjected.Token(Token = "0x4005405")]
		public const short ColdWatersintheWhiteLand = 1487;

		// Token: 0x040041BA RID: 16826
		[global::Cpp2ILInjected.Token(Token = "0x4005406")]
		public const short LightlessChasms = 1488;

		// Token: 0x040041BB RID: 16827
		[global::Cpp2ILInjected.Token(Token = "0x4005407")]
		public const short TheLandofDeceivingLooks = 1489;

		// Token: 0x040041BC RID: 16828
		[global::Cpp2ILInjected.Token(Token = "0x4005408")]
		public const short Daylight = 1490;

		// Token: 0x040041BD RID: 16829
		[global::Cpp2ILInjected.Token(Token = "0x4005409")]
		public const short SecretoftheSands = 1491;

		// Token: 0x040041BE RID: 16830
		[global::Cpp2ILInjected.Token(Token = "0x400540A")]
		public const short DeadlandComesAlive = 1492;

		// Token: 0x040041BF RID: 16831
		[global::Cpp2ILInjected.Token(Token = "0x400540B")]
		public const short EvilPresence = 1493;

		// Token: 0x040041C0 RID: 16832
		[global::Cpp2ILInjected.Token(Token = "0x400540C")]
		public const short SkyGuardian = 1494;

		// Token: 0x040041C1 RID: 16833
		[global::Cpp2ILInjected.Token(Token = "0x400540D")]
		public const short AmericanExplosive = 1495;

		// Token: 0x040041C2 RID: 16834
		[global::Cpp2ILInjected.Token(Token = "0x400540E")]
		public const short Discover = 1496;

		// Token: 0x040041C3 RID: 16835
		[global::Cpp2ILInjected.Token(Token = "0x400540F")]
		public const short HandEarth = 1497;

		// Token: 0x040041C4 RID: 16836
		[global::Cpp2ILInjected.Token(Token = "0x4005410")]
		public const short OldMiner = 1498;

		// Token: 0x040041C5 RID: 16837
		[global::Cpp2ILInjected.Token(Token = "0x4005411")]
		public const short Skelehead = 1499;

		// Token: 0x040041C6 RID: 16838
		[global::Cpp2ILInjected.Token(Token = "0x4005412")]
		public const short FacingtheCerebralMastermind = 1500;

		// Token: 0x040041C7 RID: 16839
		[global::Cpp2ILInjected.Token(Token = "0x4005413")]
		public const short LakeofFire = 1501;

		// Token: 0x040041C8 RID: 16840
		[global::Cpp2ILInjected.Token(Token = "0x4005414")]
		public const short TrioSuperHeroes = 1502;

		// Token: 0x040041C9 RID: 16841
		[global::Cpp2ILInjected.Token(Token = "0x4005415")]
		public const short SpectreHood = 1503;

		// Token: 0x040041CA RID: 16842
		[global::Cpp2ILInjected.Token(Token = "0x4005416")]
		public const short SpectreRobe = 1504;

		// Token: 0x040041CB RID: 16843
		[global::Cpp2ILInjected.Token(Token = "0x4005417")]
		public const short SpectrePants = 1505;

		// Token: 0x040041CC RID: 16844
		[global::Cpp2ILInjected.Token(Token = "0x4005418")]
		public const short SpectrePickaxe = 1506;

		// Token: 0x040041CD RID: 16845
		[global::Cpp2ILInjected.Token(Token = "0x4005419")]
		public const short SpectreHamaxe = 1507;

		// Token: 0x040041CE RID: 16846
		[global::Cpp2ILInjected.Token(Token = "0x400541A")]
		public const short Ectoplasm = 1508;

		// Token: 0x040041CF RID: 16847
		[global::Cpp2ILInjected.Token(Token = "0x400541B")]
		public const short GothicChair = 1509;

		// Token: 0x040041D0 RID: 16848
		[global::Cpp2ILInjected.Token(Token = "0x400541C")]
		public const short GothicTable = 1510;

		// Token: 0x040041D1 RID: 16849
		[global::Cpp2ILInjected.Token(Token = "0x400541D")]
		public const short GothicWorkBench = 1511;

		// Token: 0x040041D2 RID: 16850
		[global::Cpp2ILInjected.Token(Token = "0x400541E")]
		public const short GothicBookcase = 1512;

		// Token: 0x040041D3 RID: 16851
		[global::Cpp2ILInjected.Token(Token = "0x400541F")]
		public const short PaladinsHammer = 1513;

		// Token: 0x040041D4 RID: 16852
		[global::Cpp2ILInjected.Token(Token = "0x4005420")]
		public const short SWATHelmet = 1514;

		// Token: 0x040041D5 RID: 16853
		[global::Cpp2ILInjected.Token(Token = "0x4005421")]
		public const short BeeWings = 1515;

		// Token: 0x040041D6 RID: 16854
		[global::Cpp2ILInjected.Token(Token = "0x4005422")]
		public const short GiantHarpyFeather = 1516;

		// Token: 0x040041D7 RID: 16855
		[global::Cpp2ILInjected.Token(Token = "0x4005423")]
		public const short BoneFeather = 1517;

		// Token: 0x040041D8 RID: 16856
		[global::Cpp2ILInjected.Token(Token = "0x4005424")]
		public const short FireFeather = 1518;

		// Token: 0x040041D9 RID: 16857
		[global::Cpp2ILInjected.Token(Token = "0x4005425")]
		public const short IceFeather = 1519;

		// Token: 0x040041DA RID: 16858
		[global::Cpp2ILInjected.Token(Token = "0x4005426")]
		public const short BrokenBatWing = 1520;

		// Token: 0x040041DB RID: 16859
		[global::Cpp2ILInjected.Token(Token = "0x4005427")]
		public const short TatteredBeeWing = 1521;

		// Token: 0x040041DC RID: 16860
		[global::Cpp2ILInjected.Token(Token = "0x4005428")]
		public const short LargeAmethyst = 1522;

		// Token: 0x040041DD RID: 16861
		[global::Cpp2ILInjected.Token(Token = "0x4005429")]
		public const short LargeTopaz = 1523;

		// Token: 0x040041DE RID: 16862
		[global::Cpp2ILInjected.Token(Token = "0x400542A")]
		public const short LargeSapphire = 1524;

		// Token: 0x040041DF RID: 16863
		[global::Cpp2ILInjected.Token(Token = "0x400542B")]
		public const short LargeEmerald = 1525;

		// Token: 0x040041E0 RID: 16864
		[global::Cpp2ILInjected.Token(Token = "0x400542C")]
		public const short LargeRuby = 1526;

		// Token: 0x040041E1 RID: 16865
		[global::Cpp2ILInjected.Token(Token = "0x400542D")]
		public const short LargeDiamond = 1527;

		// Token: 0x040041E2 RID: 16866
		[global::Cpp2ILInjected.Token(Token = "0x400542E")]
		public const short JungleChest = 1528;

		// Token: 0x040041E3 RID: 16867
		[global::Cpp2ILInjected.Token(Token = "0x400542F")]
		public const short CorruptionChest = 1529;

		// Token: 0x040041E4 RID: 16868
		[global::Cpp2ILInjected.Token(Token = "0x4005430")]
		public const short CrimsonChest = 1530;

		// Token: 0x040041E5 RID: 16869
		[global::Cpp2ILInjected.Token(Token = "0x4005431")]
		public const short HallowedChest = 1531;

		// Token: 0x040041E6 RID: 16870
		[global::Cpp2ILInjected.Token(Token = "0x4005432")]
		public const short FrozenChest = 1532;

		// Token: 0x040041E7 RID: 16871
		[global::Cpp2ILInjected.Token(Token = "0x4005433")]
		public const short JungleKey = 1533;

		// Token: 0x040041E8 RID: 16872
		[global::Cpp2ILInjected.Token(Token = "0x4005434")]
		public const short CorruptionKey = 1534;

		// Token: 0x040041E9 RID: 16873
		[global::Cpp2ILInjected.Token(Token = "0x4005435")]
		public const short CrimsonKey = 1535;

		// Token: 0x040041EA RID: 16874
		[global::Cpp2ILInjected.Token(Token = "0x4005436")]
		public const short HallowedKey = 1536;

		// Token: 0x040041EB RID: 16875
		[global::Cpp2ILInjected.Token(Token = "0x4005437")]
		public const short FrozenKey = 1537;

		// Token: 0x040041EC RID: 16876
		[global::Cpp2ILInjected.Token(Token = "0x4005438")]
		public const short ImpFace = 1538;

		// Token: 0x040041ED RID: 16877
		[global::Cpp2ILInjected.Token(Token = "0x4005439")]
		public const short OminousPresence = 1539;

		// Token: 0x040041EE RID: 16878
		[global::Cpp2ILInjected.Token(Token = "0x400543A")]
		public const short ShiningMoon = 1540;

		// Token: 0x040041EF RID: 16879
		[global::Cpp2ILInjected.Token(Token = "0x400543B")]
		public const short LivingGore = 1541;

		// Token: 0x040041F0 RID: 16880
		[global::Cpp2ILInjected.Token(Token = "0x400543C")]
		public const short FlowingMagma = 1542;

		// Token: 0x040041F1 RID: 16881
		[global::Cpp2ILInjected.Token(Token = "0x400543D")]
		public const short SpectrePaintbrush = 1543;

		// Token: 0x040041F2 RID: 16882
		[global::Cpp2ILInjected.Token(Token = "0x400543E")]
		public const short SpectrePaintRoller = 1544;

		// Token: 0x040041F3 RID: 16883
		[global::Cpp2ILInjected.Token(Token = "0x400543F")]
		public const short SpectrePaintScraper = 1545;

		// Token: 0x040041F4 RID: 16884
		[global::Cpp2ILInjected.Token(Token = "0x4005440")]
		public const short ShroomiteHeadgear = 1546;

		// Token: 0x040041F5 RID: 16885
		[global::Cpp2ILInjected.Token(Token = "0x4005441")]
		public const short ShroomiteMask = 1547;

		// Token: 0x040041F6 RID: 16886
		[global::Cpp2ILInjected.Token(Token = "0x4005442")]
		public const short ShroomiteHelmet = 1548;

		// Token: 0x040041F7 RID: 16887
		[global::Cpp2ILInjected.Token(Token = "0x4005443")]
		public const short ShroomiteBreastplate = 1549;

		// Token: 0x040041F8 RID: 16888
		[global::Cpp2ILInjected.Token(Token = "0x4005444")]
		public const short ShroomiteLeggings = 1550;

		// Token: 0x040041F9 RID: 16889
		[global::Cpp2ILInjected.Token(Token = "0x4005445")]
		public const short Autohammer = 1551;

		// Token: 0x040041FA RID: 16890
		[global::Cpp2ILInjected.Token(Token = "0x4005446")]
		public const short ShroomiteBar = 1552;

		// Token: 0x040041FB RID: 16891
		[global::Cpp2ILInjected.Token(Token = "0x4005447")]
		public const short SDMG = 1553;

		// Token: 0x040041FC RID: 16892
		[global::Cpp2ILInjected.Token(Token = "0x4005448")]
		public const short CenxsTiara = 1554;

		// Token: 0x040041FD RID: 16893
		[global::Cpp2ILInjected.Token(Token = "0x4005449")]
		public const short CenxsBreastplate = 1555;

		// Token: 0x040041FE RID: 16894
		[global::Cpp2ILInjected.Token(Token = "0x400544A")]
		public const short CenxsLeggings = 1556;

		// Token: 0x040041FF RID: 16895
		[global::Cpp2ILInjected.Token(Token = "0x400544B")]
		public const short CrownosMask = 1557;

		// Token: 0x04004200 RID: 16896
		[global::Cpp2ILInjected.Token(Token = "0x400544C")]
		public const short CrownosBreastplate = 1558;

		// Token: 0x04004201 RID: 16897
		[global::Cpp2ILInjected.Token(Token = "0x400544D")]
		public const short CrownosLeggings = 1559;

		// Token: 0x04004202 RID: 16898
		[global::Cpp2ILInjected.Token(Token = "0x400544E")]
		public const short WillsHelmet = 1560;

		// Token: 0x04004203 RID: 16899
		[global::Cpp2ILInjected.Token(Token = "0x400544F")]
		public const short WillsBreastplate = 1561;

		// Token: 0x04004204 RID: 16900
		[global::Cpp2ILInjected.Token(Token = "0x4005450")]
		public const short WillsLeggings = 1562;

		// Token: 0x04004205 RID: 16901
		[global::Cpp2ILInjected.Token(Token = "0x4005451")]
		public const short JimsHelmet = 1563;

		// Token: 0x04004206 RID: 16902
		[global::Cpp2ILInjected.Token(Token = "0x4005452")]
		public const short JimsBreastplate = 1564;

		// Token: 0x04004207 RID: 16903
		[global::Cpp2ILInjected.Token(Token = "0x4005453")]
		public const short JimsLeggings = 1565;

		// Token: 0x04004208 RID: 16904
		[global::Cpp2ILInjected.Token(Token = "0x4005454")]
		public const short AaronsHelmet = 1566;

		// Token: 0x04004209 RID: 16905
		[global::Cpp2ILInjected.Token(Token = "0x4005455")]
		public const short AaronsBreastplate = 1567;

		// Token: 0x0400420A RID: 16906
		[global::Cpp2ILInjected.Token(Token = "0x4005456")]
		public const short AaronsLeggings = 1568;

		// Token: 0x0400420B RID: 16907
		[global::Cpp2ILInjected.Token(Token = "0x4005457")]
		public const short VampireKnives = 1569;

		// Token: 0x0400420C RID: 16908
		[global::Cpp2ILInjected.Token(Token = "0x4005458")]
		public const short BrokenHeroSword = 1570;

		// Token: 0x0400420D RID: 16909
		[global::Cpp2ILInjected.Token(Token = "0x4005459")]
		public const short ScourgeoftheCorruptor = 1571;

		// Token: 0x0400420E RID: 16910
		[global::Cpp2ILInjected.Token(Token = "0x400545A")]
		public const short StaffoftheFrostHydra = 1572;

		// Token: 0x0400420F RID: 16911
		[global::Cpp2ILInjected.Token(Token = "0x400545B")]
		public const short TheCreationoftheGuide = 1573;

		// Token: 0x04004210 RID: 16912
		[global::Cpp2ILInjected.Token(Token = "0x400545C")]
		public const short TheMerchant = 1574;

		// Token: 0x04004211 RID: 16913
		[global::Cpp2ILInjected.Token(Token = "0x400545D")]
		public const short CrownoDevoursHisLunch = 1575;

		// Token: 0x04004212 RID: 16914
		[global::Cpp2ILInjected.Token(Token = "0x400545E")]
		public const short RareEnchantment = 1576;

		// Token: 0x04004213 RID: 16915
		[global::Cpp2ILInjected.Token(Token = "0x400545F")]
		public const short GloriousNight = 1577;

		// Token: 0x04004214 RID: 16916
		[global::Cpp2ILInjected.Token(Token = "0x4005460")]
		public const short SweetheartNecklace = 1578;

		// Token: 0x04004215 RID: 16917
		[global::Cpp2ILInjected.Token(Token = "0x4005461")]
		public const short FlurryBoots = 1579;

		// Token: 0x04004216 RID: 16918
		[global::Cpp2ILInjected.Token(Token = "0x4005462")]
		public const short DTownsHelmet = 1580;

		// Token: 0x04004217 RID: 16919
		[global::Cpp2ILInjected.Token(Token = "0x4005463")]
		public const short DTownsBreastplate = 1581;

		// Token: 0x04004218 RID: 16920
		[global::Cpp2ILInjected.Token(Token = "0x4005464")]
		public const short DTownsLeggings = 1582;

		// Token: 0x04004219 RID: 16921
		[global::Cpp2ILInjected.Token(Token = "0x4005465")]
		public const short DTownsWings = 1583;

		// Token: 0x0400421A RID: 16922
		[global::Cpp2ILInjected.Token(Token = "0x4005466")]
		public const short WillsWings = 1584;

		// Token: 0x0400421B RID: 16923
		[global::Cpp2ILInjected.Token(Token = "0x4005467")]
		public const short CrownosWings = 1585;

		// Token: 0x0400421C RID: 16924
		[global::Cpp2ILInjected.Token(Token = "0x4005468")]
		public const short CenxsWings = 1586;

		// Token: 0x0400421D RID: 16925
		[global::Cpp2ILInjected.Token(Token = "0x4005469")]
		public const short CenxsDress = 1587;

		// Token: 0x0400421E RID: 16926
		[global::Cpp2ILInjected.Token(Token = "0x400546A")]
		public const short CenxsDressPants = 1588;

		// Token: 0x0400421F RID: 16927
		[global::Cpp2ILInjected.Token(Token = "0x400546B")]
		public const short PalladiumColumn = 1589;

		// Token: 0x04004220 RID: 16928
		[global::Cpp2ILInjected.Token(Token = "0x400546C")]
		public const short PalladiumColumnWall = 1590;

		// Token: 0x04004221 RID: 16929
		[global::Cpp2ILInjected.Token(Token = "0x400546D")]
		public const short BubblegumBlock = 1591;

		// Token: 0x04004222 RID: 16930
		[global::Cpp2ILInjected.Token(Token = "0x400546E")]
		public const short BubblegumBlockWall = 1592;

		// Token: 0x04004223 RID: 16931
		[global::Cpp2ILInjected.Token(Token = "0x400546F")]
		public const short TitanstoneBlock = 1593;

		// Token: 0x04004224 RID: 16932
		[global::Cpp2ILInjected.Token(Token = "0x4005470")]
		public const short TitanstoneBlockWall = 1594;

		// Token: 0x04004225 RID: 16933
		[global::Cpp2ILInjected.Token(Token = "0x4005471")]
		public const short MagicCuffs = 1595;

		// Token: 0x04004226 RID: 16934
		[global::Cpp2ILInjected.Token(Token = "0x4005472")]
		public const short MusicBoxSnow = 1596;

		// Token: 0x04004227 RID: 16935
		[global::Cpp2ILInjected.Token(Token = "0x4005473")]
		public const short MusicBoxSpace = 1597;

		// Token: 0x04004228 RID: 16936
		[global::Cpp2ILInjected.Token(Token = "0x4005474")]
		public const short MusicBoxCrimson = 1598;

		// Token: 0x04004229 RID: 16937
		[global::Cpp2ILInjected.Token(Token = "0x4005475")]
		public const short MusicBoxBoss4 = 1599;

		// Token: 0x0400422A RID: 16938
		[global::Cpp2ILInjected.Token(Token = "0x4005476")]
		public const short MusicBoxAltOverworldDay = 1600;

		// Token: 0x0400422B RID: 16939
		[global::Cpp2ILInjected.Token(Token = "0x4005477")]
		public const short MusicBoxRain = 1601;

		// Token: 0x0400422C RID: 16940
		[global::Cpp2ILInjected.Token(Token = "0x4005478")]
		public const short MusicBoxIce = 1602;

		// Token: 0x0400422D RID: 16941
		[global::Cpp2ILInjected.Token(Token = "0x4005479")]
		public const short MusicBoxDesert = 1603;

		// Token: 0x0400422E RID: 16942
		[global::Cpp2ILInjected.Token(Token = "0x400547A")]
		public const short MusicBoxOcean = 1604;

		// Token: 0x0400422F RID: 16943
		[global::Cpp2ILInjected.Token(Token = "0x400547B")]
		public const short MusicBoxDungeon = 1605;

		// Token: 0x04004230 RID: 16944
		[global::Cpp2ILInjected.Token(Token = "0x400547C")]
		public const short MusicBoxPlantera = 1606;

		// Token: 0x04004231 RID: 16945
		[global::Cpp2ILInjected.Token(Token = "0x400547D")]
		public const short MusicBoxBoss5 = 1607;

		// Token: 0x04004232 RID: 16946
		[global::Cpp2ILInjected.Token(Token = "0x400547E")]
		public const short MusicBoxTemple = 1608;

		// Token: 0x04004233 RID: 16947
		[global::Cpp2ILInjected.Token(Token = "0x400547F")]
		public const short MusicBoxEclipse = 1609;

		// Token: 0x04004234 RID: 16948
		[global::Cpp2ILInjected.Token(Token = "0x4005480")]
		public const short MusicBoxMushrooms = 1610;

		// Token: 0x04004235 RID: 16949
		[global::Cpp2ILInjected.Token(Token = "0x4005481")]
		public const short ButterflyDust = 1611;

		// Token: 0x04004236 RID: 16950
		[global::Cpp2ILInjected.Token(Token = "0x4005482")]
		public const short AnkhCharm = 1612;

		// Token: 0x04004237 RID: 16951
		[global::Cpp2ILInjected.Token(Token = "0x4005483")]
		public const short AnkhShield = 1613;

		// Token: 0x04004238 RID: 16952
		[global::Cpp2ILInjected.Token(Token = "0x4005484")]
		public const short BlueFlare = 1614;

		// Token: 0x04004239 RID: 16953
		[global::Cpp2ILInjected.Token(Token = "0x4005485")]
		public const short AnglerFishBanner = 1615;

		// Token: 0x0400423A RID: 16954
		[global::Cpp2ILInjected.Token(Token = "0x4005486")]
		public const short AngryNimbusBanner = 1616;

		// Token: 0x0400423B RID: 16955
		[global::Cpp2ILInjected.Token(Token = "0x4005487")]
		public const short AnomuraFungusBanner = 1617;

		// Token: 0x0400423C RID: 16956
		[global::Cpp2ILInjected.Token(Token = "0x4005488")]
		public const short AntlionBanner = 1618;

		// Token: 0x0400423D RID: 16957
		[global::Cpp2ILInjected.Token(Token = "0x4005489")]
		public const short ArapaimaBanner = 1619;

		// Token: 0x0400423E RID: 16958
		[global::Cpp2ILInjected.Token(Token = "0x400548A")]
		public const short ArmoredSkeletonBanner = 1620;

		// Token: 0x0400423F RID: 16959
		[global::Cpp2ILInjected.Token(Token = "0x400548B")]
		public const short BatBanner = 1621;

		// Token: 0x04004240 RID: 16960
		[global::Cpp2ILInjected.Token(Token = "0x400548C")]
		public const short BirdBanner = 1622;

		// Token: 0x04004241 RID: 16961
		[global::Cpp2ILInjected.Token(Token = "0x400548D")]
		public const short BlackRecluseBanner = 1623;

		// Token: 0x04004242 RID: 16962
		[global::Cpp2ILInjected.Token(Token = "0x400548E")]
		public const short BloodFeederBanner = 1624;

		// Token: 0x04004243 RID: 16963
		[global::Cpp2ILInjected.Token(Token = "0x400548F")]
		public const short BloodJellyBanner = 1625;

		// Token: 0x04004244 RID: 16964
		[global::Cpp2ILInjected.Token(Token = "0x4005490")]
		public const short BloodCrawlerBanner = 1626;

		// Token: 0x04004245 RID: 16965
		[global::Cpp2ILInjected.Token(Token = "0x4005491")]
		public const short BoneSerpentBanner = 1627;

		// Token: 0x04004246 RID: 16966
		[global::Cpp2ILInjected.Token(Token = "0x4005492")]
		public const short BunnyBanner = 1628;

		// Token: 0x04004247 RID: 16967
		[global::Cpp2ILInjected.Token(Token = "0x4005493")]
		public const short ChaosElementalBanner = 1629;

		// Token: 0x04004248 RID: 16968
		[global::Cpp2ILInjected.Token(Token = "0x4005494")]
		public const short MimicBanner = 1630;

		// Token: 0x04004249 RID: 16969
		[global::Cpp2ILInjected.Token(Token = "0x4005495")]
		public const short ClownBanner = 1631;

		// Token: 0x0400424A RID: 16970
		[global::Cpp2ILInjected.Token(Token = "0x4005496")]
		public const short CorruptBunnyBanner = 1632;

		// Token: 0x0400424B RID: 16971
		[global::Cpp2ILInjected.Token(Token = "0x4005497")]
		public const short CorruptGoldfishBanner = 1633;

		// Token: 0x0400424C RID: 16972
		[global::Cpp2ILInjected.Token(Token = "0x4005498")]
		public const short CrabBanner = 1634;

		// Token: 0x0400424D RID: 16973
		[global::Cpp2ILInjected.Token(Token = "0x4005499")]
		public const short CrimeraBanner = 1635;

		// Token: 0x0400424E RID: 16974
		[global::Cpp2ILInjected.Token(Token = "0x400549A")]
		public const short CrimsonAxeBanner = 1636;

		// Token: 0x0400424F RID: 16975
		[global::Cpp2ILInjected.Token(Token = "0x400549B")]
		public const short CursedHammerBanner = 1637;

		// Token: 0x04004250 RID: 16976
		[global::Cpp2ILInjected.Token(Token = "0x400549C")]
		public const short DemonBanner = 1638;

		// Token: 0x04004251 RID: 16977
		[global::Cpp2ILInjected.Token(Token = "0x400549D")]
		public const short DemonEyeBanner = 1639;

		// Token: 0x04004252 RID: 16978
		[global::Cpp2ILInjected.Token(Token = "0x400549E")]
		public const short DerplingBanner = 1640;

		// Token: 0x04004253 RID: 16979
		[global::Cpp2ILInjected.Token(Token = "0x400549F")]
		public const short EaterofSoulsBanner = 1641;

		// Token: 0x04004254 RID: 16980
		[global::Cpp2ILInjected.Token(Token = "0x40054A0")]
		public const short EnchantedSwordBanner = 1642;

		// Token: 0x04004255 RID: 16981
		[global::Cpp2ILInjected.Token(Token = "0x40054A1")]
		public const short ZombieEskimoBanner = 1643;

		// Token: 0x04004256 RID: 16982
		[global::Cpp2ILInjected.Token(Token = "0x40054A2")]
		public const short FaceMonsterBanner = 1644;

		// Token: 0x04004257 RID: 16983
		[global::Cpp2ILInjected.Token(Token = "0x40054A3")]
		public const short FloatyGrossBanner = 1645;

		// Token: 0x04004258 RID: 16984
		[global::Cpp2ILInjected.Token(Token = "0x40054A4")]
		public const short FlyingFishBanner = 1646;

		// Token: 0x04004259 RID: 16985
		[global::Cpp2ILInjected.Token(Token = "0x40054A5")]
		public const short FlyingSnakeBanner = 1647;

		// Token: 0x0400425A RID: 16986
		[global::Cpp2ILInjected.Token(Token = "0x40054A6")]
		public const short FrankensteinBanner = 1648;

		// Token: 0x0400425B RID: 16987
		[global::Cpp2ILInjected.Token(Token = "0x40054A7")]
		public const short FungiBulbBanner = 1649;

		// Token: 0x0400425C RID: 16988
		[global::Cpp2ILInjected.Token(Token = "0x40054A8")]
		public const short FungoFishBanner = 1650;

		// Token: 0x0400425D RID: 16989
		[global::Cpp2ILInjected.Token(Token = "0x40054A9")]
		public const short GastropodBanner = 1651;

		// Token: 0x0400425E RID: 16990
		[global::Cpp2ILInjected.Token(Token = "0x40054AA")]
		public const short GoblinThiefBanner = 1652;

		// Token: 0x0400425F RID: 16991
		[global::Cpp2ILInjected.Token(Token = "0x40054AB")]
		public const short GoblinSorcererBanner = 1653;

		// Token: 0x04004260 RID: 16992
		[global::Cpp2ILInjected.Token(Token = "0x40054AC")]
		public const short GoblinPeonBanner = 1654;

		// Token: 0x04004261 RID: 16993
		[global::Cpp2ILInjected.Token(Token = "0x40054AD")]
		public const short GoblinScoutBanner = 1655;

		// Token: 0x04004262 RID: 16994
		[global::Cpp2ILInjected.Token(Token = "0x40054AE")]
		public const short GoblinWarriorBanner = 1656;

		// Token: 0x04004263 RID: 16995
		[global::Cpp2ILInjected.Token(Token = "0x40054AF")]
		public const short GoldfishBanner = 1657;

		// Token: 0x04004264 RID: 16996
		[global::Cpp2ILInjected.Token(Token = "0x40054B0")]
		public const short HarpyBanner = 1658;

		// Token: 0x04004265 RID: 16997
		[global::Cpp2ILInjected.Token(Token = "0x40054B1")]
		public const short HellbatBanner = 1659;

		// Token: 0x04004266 RID: 16998
		[global::Cpp2ILInjected.Token(Token = "0x40054B2")]
		public const short HerplingBanner = 1660;

		// Token: 0x04004267 RID: 16999
		[global::Cpp2ILInjected.Token(Token = "0x40054B3")]
		public const short HornetBanner = 1661;

		// Token: 0x04004268 RID: 17000
		[global::Cpp2ILInjected.Token(Token = "0x40054B4")]
		public const short IceElementalBanner = 1662;

		// Token: 0x04004269 RID: 17001
		[global::Cpp2ILInjected.Token(Token = "0x40054B5")]
		public const short IcyMermanBanner = 1663;

		// Token: 0x0400426A RID: 17002
		[global::Cpp2ILInjected.Token(Token = "0x40054B6")]
		public const short FireImpBanner = 1664;

		// Token: 0x0400426B RID: 17003
		[global::Cpp2ILInjected.Token(Token = "0x40054B7")]
		public const short JellyfishBanner = 1665;

		// Token: 0x0400426C RID: 17004
		[global::Cpp2ILInjected.Token(Token = "0x40054B8")]
		public const short JungleCreeperBanner = 1666;

		// Token: 0x0400426D RID: 17005
		[global::Cpp2ILInjected.Token(Token = "0x40054B9")]
		public const short LihzahrdBanner = 1667;

		// Token: 0x0400426E RID: 17006
		[global::Cpp2ILInjected.Token(Token = "0x40054BA")]
		public const short ManEaterBanner = 1668;

		// Token: 0x0400426F RID: 17007
		[global::Cpp2ILInjected.Token(Token = "0x40054BB")]
		public const short MeteorHeadBanner = 1669;

		// Token: 0x04004270 RID: 17008
		[global::Cpp2ILInjected.Token(Token = "0x40054BC")]
		public const short MothBanner = 1670;

		// Token: 0x04004271 RID: 17009
		[global::Cpp2ILInjected.Token(Token = "0x40054BD")]
		public const short MummyBanner = 1671;

		// Token: 0x04004272 RID: 17010
		[global::Cpp2ILInjected.Token(Token = "0x40054BE")]
		public const short MushiLadybugBanner = 1672;

		// Token: 0x04004273 RID: 17011
		[global::Cpp2ILInjected.Token(Token = "0x40054BF")]
		public const short ParrotBanner = 1673;

		// Token: 0x04004274 RID: 17012
		[global::Cpp2ILInjected.Token(Token = "0x40054C0")]
		public const short PigronBanner = 1674;

		// Token: 0x04004275 RID: 17013
		[global::Cpp2ILInjected.Token(Token = "0x40054C1")]
		public const short PiranhaBanner = 1675;

		// Token: 0x04004276 RID: 17014
		[global::Cpp2ILInjected.Token(Token = "0x40054C2")]
		public const short PirateBanner = 1676;

		// Token: 0x04004277 RID: 17015
		[global::Cpp2ILInjected.Token(Token = "0x40054C3")]
		public const short PixieBanner = 1677;

		// Token: 0x04004278 RID: 17016
		[global::Cpp2ILInjected.Token(Token = "0x40054C4")]
		public const short RaincoatZombieBanner = 1678;

		// Token: 0x04004279 RID: 17017
		[global::Cpp2ILInjected.Token(Token = "0x40054C5")]
		public const short ReaperBanner = 1679;

		// Token: 0x0400427A RID: 17018
		[global::Cpp2ILInjected.Token(Token = "0x40054C6")]
		public const short SharkBanner = 1680;

		// Token: 0x0400427B RID: 17019
		[global::Cpp2ILInjected.Token(Token = "0x40054C7")]
		public const short SkeletonBanner = 1681;

		// Token: 0x0400427C RID: 17020
		[global::Cpp2ILInjected.Token(Token = "0x40054C8")]
		public const short SkeletonMageBanner = 1682;

		// Token: 0x0400427D RID: 17021
		[global::Cpp2ILInjected.Token(Token = "0x40054C9")]
		public const short SlimeBanner = 1683;

		// Token: 0x0400427E RID: 17022
		[global::Cpp2ILInjected.Token(Token = "0x40054CA")]
		public const short SnowFlinxBanner = 1684;

		// Token: 0x0400427F RID: 17023
		[global::Cpp2ILInjected.Token(Token = "0x40054CB")]
		public const short SpiderBanner = 1685;

		// Token: 0x04004280 RID: 17024
		[global::Cpp2ILInjected.Token(Token = "0x40054CC")]
		public const short SporeZombieBanner = 1686;

		// Token: 0x04004281 RID: 17025
		[global::Cpp2ILInjected.Token(Token = "0x40054CD")]
		public const short SwampThingBanner = 1687;

		// Token: 0x04004282 RID: 17026
		[global::Cpp2ILInjected.Token(Token = "0x40054CE")]
		public const short TortoiseBanner = 1688;

		// Token: 0x04004283 RID: 17027
		[global::Cpp2ILInjected.Token(Token = "0x40054CF")]
		public const short ToxicSludgeBanner = 1689;

		// Token: 0x04004284 RID: 17028
		[global::Cpp2ILInjected.Token(Token = "0x40054D0")]
		public const short UmbrellaSlimeBanner = 1690;

		// Token: 0x04004285 RID: 17029
		[global::Cpp2ILInjected.Token(Token = "0x40054D1")]
		public const short UnicornBanner = 1691;

		// Token: 0x04004286 RID: 17030
		[global::Cpp2ILInjected.Token(Token = "0x40054D2")]
		public const short VampireBanner = 1692;

		// Token: 0x04004287 RID: 17031
		[global::Cpp2ILInjected.Token(Token = "0x40054D3")]
		public const short VultureBanner = 1693;

		// Token: 0x04004288 RID: 17032
		[global::Cpp2ILInjected.Token(Token = "0x40054D4")]
		public const short NypmhBanner = 1694;

		// Token: 0x04004289 RID: 17033
		[global::Cpp2ILInjected.Token(Token = "0x40054D5")]
		public const short WerewolfBanner = 1695;

		// Token: 0x0400428A RID: 17034
		[global::Cpp2ILInjected.Token(Token = "0x40054D6")]
		public const short WolfBanner = 1696;

		// Token: 0x0400428B RID: 17035
		[global::Cpp2ILInjected.Token(Token = "0x40054D7")]
		public const short WorldFeederBanner = 1697;

		// Token: 0x0400428C RID: 17036
		[global::Cpp2ILInjected.Token(Token = "0x40054D8")]
		public const short WormBanner = 1698;

		// Token: 0x0400428D RID: 17037
		[global::Cpp2ILInjected.Token(Token = "0x40054D9")]
		public const short WraithBanner = 1699;

		// Token: 0x0400428E RID: 17038
		[global::Cpp2ILInjected.Token(Token = "0x40054DA")]
		public const short WyvernBanner = 1700;

		// Token: 0x0400428F RID: 17039
		[global::Cpp2ILInjected.Token(Token = "0x40054DB")]
		public const short ZombieBanner = 1701;

		// Token: 0x04004290 RID: 17040
		[global::Cpp2ILInjected.Token(Token = "0x40054DC")]
		public const short GlassPlatform = 1702;

		// Token: 0x04004291 RID: 17041
		[global::Cpp2ILInjected.Token(Token = "0x40054DD")]
		public const short GlassChair = 1703;

		// Token: 0x04004292 RID: 17042
		[global::Cpp2ILInjected.Token(Token = "0x40054DE")]
		public const short GoldenChair = 1704;

		// Token: 0x04004293 RID: 17043
		[global::Cpp2ILInjected.Token(Token = "0x40054DF")]
		public const short GoldenToilet = 1705;

		// Token: 0x04004294 RID: 17044
		[global::Cpp2ILInjected.Token(Token = "0x40054E0")]
		public const short BarStool = 1706;

		// Token: 0x04004295 RID: 17045
		[global::Cpp2ILInjected.Token(Token = "0x40054E1")]
		public const short HoneyChair = 1707;

		// Token: 0x04004296 RID: 17046
		[global::Cpp2ILInjected.Token(Token = "0x40054E2")]
		public const short SteampunkChair = 1708;

		// Token: 0x04004297 RID: 17047
		[global::Cpp2ILInjected.Token(Token = "0x40054E3")]
		public const short GlassDoor = 1709;

		// Token: 0x04004298 RID: 17048
		[global::Cpp2ILInjected.Token(Token = "0x40054E4")]
		public const short GoldenDoor = 1710;

		// Token: 0x04004299 RID: 17049
		[global::Cpp2ILInjected.Token(Token = "0x40054E5")]
		public const short HoneyDoor = 1711;

		// Token: 0x0400429A RID: 17050
		[global::Cpp2ILInjected.Token(Token = "0x40054E6")]
		public const short SteampunkDoor = 1712;

		// Token: 0x0400429B RID: 17051
		[global::Cpp2ILInjected.Token(Token = "0x40054E7")]
		public const short GlassTable = 1713;

		// Token: 0x0400429C RID: 17052
		[global::Cpp2ILInjected.Token(Token = "0x40054E8")]
		public const short BanquetTable = 1714;

		// Token: 0x0400429D RID: 17053
		[global::Cpp2ILInjected.Token(Token = "0x40054E9")]
		public const short Bar = 1715;

		// Token: 0x0400429E RID: 17054
		[global::Cpp2ILInjected.Token(Token = "0x40054EA")]
		public const short GoldenTable = 1716;

		// Token: 0x0400429F RID: 17055
		[global::Cpp2ILInjected.Token(Token = "0x40054EB")]
		public const short HoneyTable = 1717;

		// Token: 0x040042A0 RID: 17056
		[global::Cpp2ILInjected.Token(Token = "0x40054EC")]
		public const short SteampunkTable = 1718;

		// Token: 0x040042A1 RID: 17057
		[global::Cpp2ILInjected.Token(Token = "0x40054ED")]
		public const short GlassBed = 1719;

		// Token: 0x040042A2 RID: 17058
		[global::Cpp2ILInjected.Token(Token = "0x40054EE")]
		public const short GoldenBed = 1720;

		// Token: 0x040042A3 RID: 17059
		[global::Cpp2ILInjected.Token(Token = "0x40054EF")]
		public const short HoneyBed = 1721;

		// Token: 0x040042A4 RID: 17060
		[global::Cpp2ILInjected.Token(Token = "0x40054F0")]
		public const short SteampunkBed = 1722;

		// Token: 0x040042A5 RID: 17061
		[global::Cpp2ILInjected.Token(Token = "0x40054F1")]
		public const short LivingWoodWall = 1723;

		// Token: 0x040042A6 RID: 17062
		[global::Cpp2ILInjected.Token(Token = "0x40054F2")]
		public const short FartinaJar = 1724;

		// Token: 0x040042A7 RID: 17063
		[global::Cpp2ILInjected.Token(Token = "0x40054F3")]
		public const short Pumpkin = 1725;

		// Token: 0x040042A8 RID: 17064
		[global::Cpp2ILInjected.Token(Token = "0x40054F4")]
		public const short PumpkinWall = 1726;

		// Token: 0x040042A9 RID: 17065
		[global::Cpp2ILInjected.Token(Token = "0x40054F5")]
		public const short Hay = 1727;

		// Token: 0x040042AA RID: 17066
		[global::Cpp2ILInjected.Token(Token = "0x40054F6")]
		public const short HayWall = 1728;

		// Token: 0x040042AB RID: 17067
		[global::Cpp2ILInjected.Token(Token = "0x40054F7")]
		public const short SpookyWood = 1729;

		// Token: 0x040042AC RID: 17068
		[global::Cpp2ILInjected.Token(Token = "0x40054F8")]
		public const short SpookyWoodWall = 1730;

		// Token: 0x040042AD RID: 17069
		[global::Cpp2ILInjected.Token(Token = "0x40054F9")]
		public const short PumpkinHelmet = 1731;

		// Token: 0x040042AE RID: 17070
		[global::Cpp2ILInjected.Token(Token = "0x40054FA")]
		public const short PumpkinBreastplate = 1732;

		// Token: 0x040042AF RID: 17071
		[global::Cpp2ILInjected.Token(Token = "0x40054FB")]
		public const short PumpkinLeggings = 1733;

		// Token: 0x040042B0 RID: 17072
		[global::Cpp2ILInjected.Token(Token = "0x40054FC")]
		public const short CandyApple = 1734;

		// Token: 0x040042B1 RID: 17073
		[global::Cpp2ILInjected.Token(Token = "0x40054FD")]
		public const short SoulCake = 1735;

		// Token: 0x040042B2 RID: 17074
		[global::Cpp2ILInjected.Token(Token = "0x40054FE")]
		public const short NurseHat = 1736;

		// Token: 0x040042B3 RID: 17075
		[global::Cpp2ILInjected.Token(Token = "0x40054FF")]
		public const short NurseShirt = 1737;

		// Token: 0x040042B4 RID: 17076
		[global::Cpp2ILInjected.Token(Token = "0x4005500")]
		public const short NursePants = 1738;

		// Token: 0x040042B5 RID: 17077
		[global::Cpp2ILInjected.Token(Token = "0x4005501")]
		public const short WizardsHat = 1739;

		// Token: 0x040042B6 RID: 17078
		[global::Cpp2ILInjected.Token(Token = "0x4005502")]
		public const short GuyFawkesMask = 1740;

		// Token: 0x040042B7 RID: 17079
		[global::Cpp2ILInjected.Token(Token = "0x4005503")]
		public const short DyeTraderRobe = 1741;

		// Token: 0x040042B8 RID: 17080
		[global::Cpp2ILInjected.Token(Token = "0x4005504")]
		public const short SteampunkGoggles = 1742;

		// Token: 0x040042B9 RID: 17081
		[global::Cpp2ILInjected.Token(Token = "0x4005505")]
		public const short CyborgHelmet = 1743;

		// Token: 0x040042BA RID: 17082
		[global::Cpp2ILInjected.Token(Token = "0x4005506")]
		public const short CyborgShirt = 1744;

		// Token: 0x040042BB RID: 17083
		[global::Cpp2ILInjected.Token(Token = "0x4005507")]
		public const short CyborgPants = 1745;

		// Token: 0x040042BC RID: 17084
		[global::Cpp2ILInjected.Token(Token = "0x4005508")]
		public const short CreeperMask = 1746;

		// Token: 0x040042BD RID: 17085
		[global::Cpp2ILInjected.Token(Token = "0x4005509")]
		public const short CreeperShirt = 1747;

		// Token: 0x040042BE RID: 17086
		[global::Cpp2ILInjected.Token(Token = "0x400550A")]
		public const short CreeperPants = 1748;

		// Token: 0x040042BF RID: 17087
		[global::Cpp2ILInjected.Token(Token = "0x400550B")]
		public const short CatMask = 1749;

		// Token: 0x040042C0 RID: 17088
		[global::Cpp2ILInjected.Token(Token = "0x400550C")]
		public const short CatShirt = 1750;

		// Token: 0x040042C1 RID: 17089
		[global::Cpp2ILInjected.Token(Token = "0x400550D")]
		public const short CatPants = 1751;

		// Token: 0x040042C2 RID: 17090
		[global::Cpp2ILInjected.Token(Token = "0x400550E")]
		public const short GhostMask = 1752;

		// Token: 0x040042C3 RID: 17091
		[global::Cpp2ILInjected.Token(Token = "0x400550F")]
		public const short GhostShirt = 1753;

		// Token: 0x040042C4 RID: 17092
		[global::Cpp2ILInjected.Token(Token = "0x4005510")]
		public const short PumpkinMask = 1754;

		// Token: 0x040042C5 RID: 17093
		[global::Cpp2ILInjected.Token(Token = "0x4005511")]
		public const short PumpkinShirt = 1755;

		// Token: 0x040042C6 RID: 17094
		[global::Cpp2ILInjected.Token(Token = "0x4005512")]
		public const short PumpkinPants = 1756;

		// Token: 0x040042C7 RID: 17095
		[global::Cpp2ILInjected.Token(Token = "0x4005513")]
		public const short RobotMask = 1757;

		// Token: 0x040042C8 RID: 17096
		[global::Cpp2ILInjected.Token(Token = "0x4005514")]
		public const short RobotShirt = 1758;

		// Token: 0x040042C9 RID: 17097
		[global::Cpp2ILInjected.Token(Token = "0x4005515")]
		public const short RobotPants = 1759;

		// Token: 0x040042CA RID: 17098
		[global::Cpp2ILInjected.Token(Token = "0x4005516")]
		public const short UnicornMask = 1760;

		// Token: 0x040042CB RID: 17099
		[global::Cpp2ILInjected.Token(Token = "0x4005517")]
		public const short UnicornShirt = 1761;

		// Token: 0x040042CC RID: 17100
		[global::Cpp2ILInjected.Token(Token = "0x4005518")]
		public const short UnicornPants = 1762;

		// Token: 0x040042CD RID: 17101
		[global::Cpp2ILInjected.Token(Token = "0x4005519")]
		public const short VampireMask = 1763;

		// Token: 0x040042CE RID: 17102
		[global::Cpp2ILInjected.Token(Token = "0x400551A")]
		public const short VampireShirt = 1764;

		// Token: 0x040042CF RID: 17103
		[global::Cpp2ILInjected.Token(Token = "0x400551B")]
		public const short VampirePants = 1765;

		// Token: 0x040042D0 RID: 17104
		[global::Cpp2ILInjected.Token(Token = "0x400551C")]
		public const short WitchHat = 1766;

		// Token: 0x040042D1 RID: 17105
		[global::Cpp2ILInjected.Token(Token = "0x400551D")]
		public const short LeprechaunHat = 1767;

		// Token: 0x040042D2 RID: 17106
		[global::Cpp2ILInjected.Token(Token = "0x400551E")]
		public const short LeprechaunShirt = 1768;

		// Token: 0x040042D3 RID: 17107
		[global::Cpp2ILInjected.Token(Token = "0x400551F")]
		public const short LeprechaunPants = 1769;

		// Token: 0x040042D4 RID: 17108
		[global::Cpp2ILInjected.Token(Token = "0x4005520")]
		public const short PixieShirt = 1770;

		// Token: 0x040042D5 RID: 17109
		[global::Cpp2ILInjected.Token(Token = "0x4005521")]
		public const short PixiePants = 1771;

		// Token: 0x040042D6 RID: 17110
		[global::Cpp2ILInjected.Token(Token = "0x4005522")]
		public const short PrincessHat = 1772;

		// Token: 0x040042D7 RID: 17111
		[global::Cpp2ILInjected.Token(Token = "0x4005523")]
		public const short PrincessDressNew = 1773;

		// Token: 0x040042D8 RID: 17112
		[global::Cpp2ILInjected.Token(Token = "0x4005524")]
		public const short GoodieBag = 1774;

		// Token: 0x040042D9 RID: 17113
		[global::Cpp2ILInjected.Token(Token = "0x4005525")]
		public const short WitchDress = 1775;

		// Token: 0x040042DA RID: 17114
		[global::Cpp2ILInjected.Token(Token = "0x4005526")]
		public const short WitchBoots = 1776;

		// Token: 0x040042DB RID: 17115
		[global::Cpp2ILInjected.Token(Token = "0x4005527")]
		public const short BrideofFrankensteinMask = 1777;

		// Token: 0x040042DC RID: 17116
		[global::Cpp2ILInjected.Token(Token = "0x4005528")]
		public const short BrideofFrankensteinDress = 1778;

		// Token: 0x040042DD RID: 17117
		[global::Cpp2ILInjected.Token(Token = "0x4005529")]
		public const short KarateTortoiseMask = 1779;

		// Token: 0x040042DE RID: 17118
		[global::Cpp2ILInjected.Token(Token = "0x400552A")]
		public const short KarateTortoiseShirt = 1780;

		// Token: 0x040042DF RID: 17119
		[global::Cpp2ILInjected.Token(Token = "0x400552B")]
		public const short KarateTortoisePants = 1781;

		// Token: 0x040042E0 RID: 17120
		[global::Cpp2ILInjected.Token(Token = "0x400552C")]
		public const short CandyCornRifle = 1782;

		// Token: 0x040042E1 RID: 17121
		[global::Cpp2ILInjected.Token(Token = "0x400552D")]
		public const short CandyCorn = 1783;

		// Token: 0x040042E2 RID: 17122
		[global::Cpp2ILInjected.Token(Token = "0x400552E")]
		public const short JackOLanternLauncher = 1784;

		// Token: 0x040042E3 RID: 17123
		[global::Cpp2ILInjected.Token(Token = "0x400552F")]
		public const short ExplosiveJackOLantern = 1785;

		// Token: 0x040042E4 RID: 17124
		[global::Cpp2ILInjected.Token(Token = "0x4005530")]
		public const short Sickle = 1786;

		// Token: 0x040042E5 RID: 17125
		[global::Cpp2ILInjected.Token(Token = "0x4005531")]
		public const short PumpkinPie = 1787;

		// Token: 0x040042E6 RID: 17126
		[global::Cpp2ILInjected.Token(Token = "0x4005532")]
		public const short ScarecrowHat = 1788;

		// Token: 0x040042E7 RID: 17127
		[global::Cpp2ILInjected.Token(Token = "0x4005533")]
		public const short ScarecrowShirt = 1789;

		// Token: 0x040042E8 RID: 17128
		[global::Cpp2ILInjected.Token(Token = "0x4005534")]
		public const short ScarecrowPants = 1790;

		// Token: 0x040042E9 RID: 17129
		[global::Cpp2ILInjected.Token(Token = "0x4005535")]
		public const short Cauldron = 1791;

		// Token: 0x040042EA RID: 17130
		[global::Cpp2ILInjected.Token(Token = "0x4005536")]
		public const short PumpkinChair = 1792;

		// Token: 0x040042EB RID: 17131
		[global::Cpp2ILInjected.Token(Token = "0x4005537")]
		public const short PumpkinDoor = 1793;

		// Token: 0x040042EC RID: 17132
		[global::Cpp2ILInjected.Token(Token = "0x4005538")]
		public const short PumpkinTable = 1794;

		// Token: 0x040042ED RID: 17133
		[global::Cpp2ILInjected.Token(Token = "0x4005539")]
		public const short PumpkinWorkBench = 1795;

		// Token: 0x040042EE RID: 17134
		[global::Cpp2ILInjected.Token(Token = "0x400553A")]
		public const short PumpkinPlatform = 1796;

		// Token: 0x040042EF RID: 17135
		[global::Cpp2ILInjected.Token(Token = "0x400553B")]
		public const short TatteredFairyWings = 1797;

		// Token: 0x040042F0 RID: 17136
		[global::Cpp2ILInjected.Token(Token = "0x400553C")]
		public const short SpiderEgg = 1798;

		// Token: 0x040042F1 RID: 17137
		[global::Cpp2ILInjected.Token(Token = "0x400553D")]
		public const short MagicalPumpkinSeed = 1799;

		// Token: 0x040042F2 RID: 17138
		[global::Cpp2ILInjected.Token(Token = "0x400553E")]
		public const short BatHook = 1800;

		// Token: 0x040042F3 RID: 17139
		[global::Cpp2ILInjected.Token(Token = "0x400553F")]
		public const short BatScepter = 1801;

		// Token: 0x040042F4 RID: 17140
		[global::Cpp2ILInjected.Token(Token = "0x4005540")]
		public const short RavenStaff = 1802;

		// Token: 0x040042F5 RID: 17141
		[global::Cpp2ILInjected.Token(Token = "0x4005541")]
		public const short JungleKeyMold = 1803;

		// Token: 0x040042F6 RID: 17142
		[global::Cpp2ILInjected.Token(Token = "0x4005542")]
		public const short CorruptionKeyMold = 1804;

		// Token: 0x040042F7 RID: 17143
		[global::Cpp2ILInjected.Token(Token = "0x4005543")]
		public const short CrimsonKeyMold = 1805;

		// Token: 0x040042F8 RID: 17144
		[global::Cpp2ILInjected.Token(Token = "0x4005544")]
		public const short HallowedKeyMold = 1806;

		// Token: 0x040042F9 RID: 17145
		[global::Cpp2ILInjected.Token(Token = "0x4005545")]
		public const short FrozenKeyMold = 1807;

		// Token: 0x040042FA RID: 17146
		[global::Cpp2ILInjected.Token(Token = "0x4005546")]
		public const short HangingJackOLantern = 1808;

		// Token: 0x040042FB RID: 17147
		[global::Cpp2ILInjected.Token(Token = "0x4005547")]
		public const short RottenEgg = 1809;

		// Token: 0x040042FC RID: 17148
		[global::Cpp2ILInjected.Token(Token = "0x4005548")]
		public const short UnluckyYarn = 1810;

		// Token: 0x040042FD RID: 17149
		[global::Cpp2ILInjected.Token(Token = "0x4005549")]
		public const short BlackFairyDust = 1811;

		// Token: 0x040042FE RID: 17150
		[global::Cpp2ILInjected.Token(Token = "0x400554A")]
		public const short Jackelier = 1812;

		// Token: 0x040042FF RID: 17151
		[global::Cpp2ILInjected.Token(Token = "0x400554B")]
		public const short JackOLantern = 1813;

		// Token: 0x04004300 RID: 17152
		[global::Cpp2ILInjected.Token(Token = "0x400554C")]
		public const short SpookyChair = 1814;

		// Token: 0x04004301 RID: 17153
		[global::Cpp2ILInjected.Token(Token = "0x400554D")]
		public const short SpookyDoor = 1815;

		// Token: 0x04004302 RID: 17154
		[global::Cpp2ILInjected.Token(Token = "0x400554E")]
		public const short SpookyTable = 1816;

		// Token: 0x04004303 RID: 17155
		[global::Cpp2ILInjected.Token(Token = "0x400554F")]
		public const short SpookyWorkBench = 1817;

		// Token: 0x04004304 RID: 17156
		[global::Cpp2ILInjected.Token(Token = "0x4005550")]
		public const short SpookyPlatform = 1818;

		// Token: 0x04004305 RID: 17157
		[global::Cpp2ILInjected.Token(Token = "0x4005551")]
		public const short ReaperHood = 1819;

		// Token: 0x04004306 RID: 17158
		[global::Cpp2ILInjected.Token(Token = "0x4005552")]
		public const short ReaperRobe = 1820;

		// Token: 0x04004307 RID: 17159
		[global::Cpp2ILInjected.Token(Token = "0x4005553")]
		public const short FoxMask = 1821;

		// Token: 0x04004308 RID: 17160
		[global::Cpp2ILInjected.Token(Token = "0x4005554")]
		public const short FoxShirt = 1822;

		// Token: 0x04004309 RID: 17161
		[global::Cpp2ILInjected.Token(Token = "0x4005555")]
		public const short FoxPants = 1823;

		// Token: 0x0400430A RID: 17162
		[global::Cpp2ILInjected.Token(Token = "0x4005556")]
		public const short CatEars = 1824;

		// Token: 0x0400430B RID: 17163
		[global::Cpp2ILInjected.Token(Token = "0x4005557")]
		public const short BloodyMachete = 1825;

		// Token: 0x0400430C RID: 17164
		[global::Cpp2ILInjected.Token(Token = "0x4005558")]
		public const short TheHorsemansBlade = 1826;

		// Token: 0x0400430D RID: 17165
		[global::Cpp2ILInjected.Token(Token = "0x4005559")]
		public const short BladedGlove = 1827;

		// Token: 0x0400430E RID: 17166
		[global::Cpp2ILInjected.Token(Token = "0x400555A")]
		public const short PumpkinSeed = 1828;

		// Token: 0x0400430F RID: 17167
		[global::Cpp2ILInjected.Token(Token = "0x400555B")]
		public const short SpookyHook = 1829;

		// Token: 0x04004310 RID: 17168
		[global::Cpp2ILInjected.Token(Token = "0x400555C")]
		public const short SpookyWings = 1830;

		// Token: 0x04004311 RID: 17169
		[global::Cpp2ILInjected.Token(Token = "0x400555D")]
		public const short SpookyTwig = 1831;

		// Token: 0x04004312 RID: 17170
		[global::Cpp2ILInjected.Token(Token = "0x400555E")]
		public const short SpookyHelmet = 1832;

		// Token: 0x04004313 RID: 17171
		[global::Cpp2ILInjected.Token(Token = "0x400555F")]
		public const short SpookyBreastplate = 1833;

		// Token: 0x04004314 RID: 17172
		[global::Cpp2ILInjected.Token(Token = "0x4005560")]
		public const short SpookyLeggings = 1834;

		// Token: 0x04004315 RID: 17173
		[global::Cpp2ILInjected.Token(Token = "0x4005561")]
		public const short StakeLauncher = 1835;

		// Token: 0x04004316 RID: 17174
		[global::Cpp2ILInjected.Token(Token = "0x4005562")]
		public const short Stake = 1836;

		// Token: 0x04004317 RID: 17175
		[global::Cpp2ILInjected.Token(Token = "0x4005563")]
		public const short CursedSapling = 1837;

		// Token: 0x04004318 RID: 17176
		[global::Cpp2ILInjected.Token(Token = "0x4005564")]
		public const short SpaceCreatureMask = 1838;

		// Token: 0x04004319 RID: 17177
		[global::Cpp2ILInjected.Token(Token = "0x4005565")]
		public const short SpaceCreatureShirt = 1839;

		// Token: 0x0400431A RID: 17178
		[global::Cpp2ILInjected.Token(Token = "0x4005566")]
		public const short SpaceCreaturePants = 1840;

		// Token: 0x0400431B RID: 17179
		[global::Cpp2ILInjected.Token(Token = "0x4005567")]
		public const short WolfMask = 1841;

		// Token: 0x0400431C RID: 17180
		[global::Cpp2ILInjected.Token(Token = "0x4005568")]
		public const short WolfShirt = 1842;

		// Token: 0x0400431D RID: 17181
		[global::Cpp2ILInjected.Token(Token = "0x4005569")]
		public const short WolfPants = 1843;

		// Token: 0x0400431E RID: 17182
		[global::Cpp2ILInjected.Token(Token = "0x400556A")]
		public const short PumpkinMoonMedallion = 1844;

		// Token: 0x0400431F RID: 17183
		[global::Cpp2ILInjected.Token(Token = "0x400556B")]
		public const short NecromanticScroll = 1845;

		// Token: 0x04004320 RID: 17184
		[global::Cpp2ILInjected.Token(Token = "0x400556C")]
		public const short JackingSkeletron = 1846;

		// Token: 0x04004321 RID: 17185
		[global::Cpp2ILInjected.Token(Token = "0x400556D")]
		public const short BitterHarvest = 1847;

		// Token: 0x04004322 RID: 17186
		[global::Cpp2ILInjected.Token(Token = "0x400556E")]
		public const short BloodMoonCountess = 1848;

		// Token: 0x04004323 RID: 17187
		[global::Cpp2ILInjected.Token(Token = "0x400556F")]
		public const short HallowsEve = 1849;

		// Token: 0x04004324 RID: 17188
		[global::Cpp2ILInjected.Token(Token = "0x4005570")]
		public const short MorbidCuriosity = 1850;

		// Token: 0x04004325 RID: 17189
		[global::Cpp2ILInjected.Token(Token = "0x4005571")]
		public const short TreasureHunterShirt = 1851;

		// Token: 0x04004326 RID: 17190
		[global::Cpp2ILInjected.Token(Token = "0x4005572")]
		public const short TreasureHunterPants = 1852;

		// Token: 0x04004327 RID: 17191
		[global::Cpp2ILInjected.Token(Token = "0x4005573")]
		public const short DryadCoverings = 1853;

		// Token: 0x04004328 RID: 17192
		[global::Cpp2ILInjected.Token(Token = "0x4005574")]
		public const short DryadLoincloth = 1854;

		// Token: 0x04004329 RID: 17193
		[global::Cpp2ILInjected.Token(Token = "0x4005575")]
		public const short MourningWoodTrophy = 1855;

		// Token: 0x0400432A RID: 17194
		[global::Cpp2ILInjected.Token(Token = "0x4005576")]
		public const short PumpkingTrophy = 1856;

		// Token: 0x0400432B RID: 17195
		[global::Cpp2ILInjected.Token(Token = "0x4005577")]
		public const short JackOLanternMask = 1857;

		// Token: 0x0400432C RID: 17196
		[global::Cpp2ILInjected.Token(Token = "0x4005578")]
		public const short SniperScope = 1858;

		// Token: 0x0400432D RID: 17197
		[global::Cpp2ILInjected.Token(Token = "0x4005579")]
		public const short HeartLantern = 1859;

		// Token: 0x0400432E RID: 17198
		[global::Cpp2ILInjected.Token(Token = "0x400557A")]
		public const short JellyfishDivingGear = 1860;

		// Token: 0x0400432F RID: 17199
		[global::Cpp2ILInjected.Token(Token = "0x400557B")]
		public const short ArcticDivingGear = 1861;

		// Token: 0x04004330 RID: 17200
		[global::Cpp2ILInjected.Token(Token = "0x400557C")]
		public const short FrostsparkBoots = 1862;

		// Token: 0x04004331 RID: 17201
		[global::Cpp2ILInjected.Token(Token = "0x400557D")]
		public const short FartInABalloon = 1863;

		// Token: 0x04004332 RID: 17202
		[global::Cpp2ILInjected.Token(Token = "0x400557E")]
		public const short PapyrusScarab = 1864;

		// Token: 0x04004333 RID: 17203
		[global::Cpp2ILInjected.Token(Token = "0x400557F")]
		public const short CelestialStone = 1865;

		// Token: 0x04004334 RID: 17204
		[global::Cpp2ILInjected.Token(Token = "0x4005580")]
		public const short Hoverboard = 1866;

		// Token: 0x04004335 RID: 17205
		[global::Cpp2ILInjected.Token(Token = "0x4005581")]
		public const short CandyCane = 1867;

		// Token: 0x04004336 RID: 17206
		[global::Cpp2ILInjected.Token(Token = "0x4005582")]
		public const short SugarPlum = 1868;

		// Token: 0x04004337 RID: 17207
		[global::Cpp2ILInjected.Token(Token = "0x4005583")]
		public const short Present = 1869;

		// Token: 0x04004338 RID: 17208
		[global::Cpp2ILInjected.Token(Token = "0x4005584")]
		public const short RedRyder = 1870;

		// Token: 0x04004339 RID: 17209
		[global::Cpp2ILInjected.Token(Token = "0x4005585")]
		public const short FestiveWings = 1871;

		// Token: 0x0400433A RID: 17210
		[global::Cpp2ILInjected.Token(Token = "0x4005586")]
		public const short PineTreeBlock = 1872;

		// Token: 0x0400433B RID: 17211
		[global::Cpp2ILInjected.Token(Token = "0x4005587")]
		public const short ChristmasTree = 1873;

		// Token: 0x0400433C RID: 17212
		[global::Cpp2ILInjected.Token(Token = "0x4005588")]
		public const short StarTopper1 = 1874;

		// Token: 0x0400433D RID: 17213
		[global::Cpp2ILInjected.Token(Token = "0x4005589")]
		public const short StarTopper2 = 1875;

		// Token: 0x0400433E RID: 17214
		[global::Cpp2ILInjected.Token(Token = "0x400558A")]
		public const short StarTopper3 = 1876;

		// Token: 0x0400433F RID: 17215
		[global::Cpp2ILInjected.Token(Token = "0x400558B")]
		public const short BowTopper = 1877;

		// Token: 0x04004340 RID: 17216
		[global::Cpp2ILInjected.Token(Token = "0x400558C")]
		public const short WhiteGarland = 1878;

		// Token: 0x04004341 RID: 17217
		[global::Cpp2ILInjected.Token(Token = "0x400558D")]
		public const short WhiteAndRedGarland = 1879;

		// Token: 0x04004342 RID: 17218
		[global::Cpp2ILInjected.Token(Token = "0x400558E")]
		public const short RedGardland = 1880;

		// Token: 0x04004343 RID: 17219
		[global::Cpp2ILInjected.Token(Token = "0x400558F")]
		public const short RedAndGreenGardland = 1881;

		// Token: 0x04004344 RID: 17220
		[global::Cpp2ILInjected.Token(Token = "0x4005590")]
		public const short GreenGardland = 1882;

		// Token: 0x04004345 RID: 17221
		[global::Cpp2ILInjected.Token(Token = "0x4005591")]
		public const short GreenAndWhiteGarland = 1883;

		// Token: 0x04004346 RID: 17222
		[global::Cpp2ILInjected.Token(Token = "0x4005592")]
		public const short MulticoloredBulb = 1884;

		// Token: 0x04004347 RID: 17223
		[global::Cpp2ILInjected.Token(Token = "0x4005593")]
		public const short RedBulb = 1885;

		// Token: 0x04004348 RID: 17224
		[global::Cpp2ILInjected.Token(Token = "0x4005594")]
		public const short YellowBulb = 1886;

		// Token: 0x04004349 RID: 17225
		[global::Cpp2ILInjected.Token(Token = "0x4005595")]
		public const short GreenBulb = 1887;

		// Token: 0x0400434A RID: 17226
		[global::Cpp2ILInjected.Token(Token = "0x4005596")]
		public const short RedAndGreenBulb = 1888;

		// Token: 0x0400434B RID: 17227
		[global::Cpp2ILInjected.Token(Token = "0x4005597")]
		public const short YellowAndGreenBulb = 1889;

		// Token: 0x0400434C RID: 17228
		[global::Cpp2ILInjected.Token(Token = "0x4005598")]
		public const short RedAndYellowBulb = 1890;

		// Token: 0x0400434D RID: 17229
		[global::Cpp2ILInjected.Token(Token = "0x4005599")]
		public const short WhiteBulb = 1891;

		// Token: 0x0400434E RID: 17230
		[global::Cpp2ILInjected.Token(Token = "0x400559A")]
		public const short WhiteAndRedBulb = 1892;

		// Token: 0x0400434F RID: 17231
		[global::Cpp2ILInjected.Token(Token = "0x400559B")]
		public const short WhiteAndYellowBulb = 1893;

		// Token: 0x04004350 RID: 17232
		[global::Cpp2ILInjected.Token(Token = "0x400559C")]
		public const short WhiteAndGreenBulb = 1894;

		// Token: 0x04004351 RID: 17233
		[global::Cpp2ILInjected.Token(Token = "0x400559D")]
		public const short MulticoloredLights = 1895;

		// Token: 0x04004352 RID: 17234
		[global::Cpp2ILInjected.Token(Token = "0x400559E")]
		public const short RedLights = 1896;

		// Token: 0x04004353 RID: 17235
		[global::Cpp2ILInjected.Token(Token = "0x400559F")]
		public const short GreenLights = 1897;

		// Token: 0x04004354 RID: 17236
		[global::Cpp2ILInjected.Token(Token = "0x40055A0")]
		public const short BlueLights = 1898;

		// Token: 0x04004355 RID: 17237
		[global::Cpp2ILInjected.Token(Token = "0x40055A1")]
		public const short YellowLights = 1899;

		// Token: 0x04004356 RID: 17238
		[global::Cpp2ILInjected.Token(Token = "0x40055A2")]
		public const short RedAndYellowLights = 1900;

		// Token: 0x04004357 RID: 17239
		[global::Cpp2ILInjected.Token(Token = "0x40055A3")]
		public const short RedAndGreenLights = 1901;

		// Token: 0x04004358 RID: 17240
		[global::Cpp2ILInjected.Token(Token = "0x40055A4")]
		public const short YellowAndGreenLights = 1902;

		// Token: 0x04004359 RID: 17241
		[global::Cpp2ILInjected.Token(Token = "0x40055A5")]
		public const short BlueAndGreenLights = 1903;

		// Token: 0x0400435A RID: 17242
		[global::Cpp2ILInjected.Token(Token = "0x40055A6")]
		public const short RedAndBlueLights = 1904;

		// Token: 0x0400435B RID: 17243
		[global::Cpp2ILInjected.Token(Token = "0x40055A7")]
		public const short BlueAndYellowLights = 1905;

		// Token: 0x0400435C RID: 17244
		[global::Cpp2ILInjected.Token(Token = "0x40055A8")]
		public const short GiantBow = 1906;

		// Token: 0x0400435D RID: 17245
		[global::Cpp2ILInjected.Token(Token = "0x40055A9")]
		public const short ReindeerAntlers = 1907;

		// Token: 0x0400435E RID: 17246
		[global::Cpp2ILInjected.Token(Token = "0x40055AA")]
		public const short Holly = 1908;

		// Token: 0x0400435F RID: 17247
		[global::Cpp2ILInjected.Token(Token = "0x40055AB")]
		public const short CandyCaneSword = 1909;

		// Token: 0x04004360 RID: 17248
		[global::Cpp2ILInjected.Token(Token = "0x40055AC")]
		public const short ElfMelter = 1910;

		// Token: 0x04004361 RID: 17249
		[global::Cpp2ILInjected.Token(Token = "0x40055AD")]
		public const short ChristmasPudding = 1911;

		// Token: 0x04004362 RID: 17250
		[global::Cpp2ILInjected.Token(Token = "0x40055AE")]
		public const short Eggnog = 1912;

		// Token: 0x04004363 RID: 17251
		[global::Cpp2ILInjected.Token(Token = "0x40055AF")]
		public const short StarAnise = 1913;

		// Token: 0x04004364 RID: 17252
		[global::Cpp2ILInjected.Token(Token = "0x40055B0")]
		public const short ReindeerBells = 1914;

		// Token: 0x04004365 RID: 17253
		[global::Cpp2ILInjected.Token(Token = "0x40055B1")]
		public const short CandyCaneHook = 1915;

		// Token: 0x04004366 RID: 17254
		[global::Cpp2ILInjected.Token(Token = "0x40055B2")]
		public const short ChristmasHook = 1916;

		// Token: 0x04004367 RID: 17255
		[global::Cpp2ILInjected.Token(Token = "0x40055B3")]
		public const short CnadyCanePickaxe = 1917;

		// Token: 0x04004368 RID: 17256
		[global::Cpp2ILInjected.Token(Token = "0x40055B4")]
		public const short FruitcakeChakram = 1918;

		// Token: 0x04004369 RID: 17257
		[global::Cpp2ILInjected.Token(Token = "0x40055B5")]
		public const short SugarCookie = 1919;

		// Token: 0x0400436A RID: 17258
		[global::Cpp2ILInjected.Token(Token = "0x40055B6")]
		public const short GingerbreadCookie = 1920;

		// Token: 0x0400436B RID: 17259
		[global::Cpp2ILInjected.Token(Token = "0x40055B7")]
		public const short HandWarmer = 1921;

		// Token: 0x0400436C RID: 17260
		[global::Cpp2ILInjected.Token(Token = "0x40055B8")]
		public const short Coal = 1922;

		// Token: 0x0400436D RID: 17261
		[global::Cpp2ILInjected.Token(Token = "0x40055B9")]
		public const short Toolbox = 1923;

		// Token: 0x0400436E RID: 17262
		[global::Cpp2ILInjected.Token(Token = "0x40055BA")]
		public const short PineDoor = 1924;

		// Token: 0x0400436F RID: 17263
		[global::Cpp2ILInjected.Token(Token = "0x40055BB")]
		public const short PineChair = 1925;

		// Token: 0x04004370 RID: 17264
		[global::Cpp2ILInjected.Token(Token = "0x40055BC")]
		public const short PineTable = 1926;

		// Token: 0x04004371 RID: 17265
		[global::Cpp2ILInjected.Token(Token = "0x40055BD")]
		public const short DogWhistle = 1927;

		// Token: 0x04004372 RID: 17266
		[global::Cpp2ILInjected.Token(Token = "0x40055BE")]
		public const short ChristmasTreeSword = 1928;

		// Token: 0x04004373 RID: 17267
		[global::Cpp2ILInjected.Token(Token = "0x40055BF")]
		public const short ChainGun = 1929;

		// Token: 0x04004374 RID: 17268
		[global::Cpp2ILInjected.Token(Token = "0x40055C0")]
		public const short Razorpine = 1930;

		// Token: 0x04004375 RID: 17269
		[global::Cpp2ILInjected.Token(Token = "0x40055C1")]
		public const short BlizzardStaff = 1931;

		// Token: 0x04004376 RID: 17270
		[global::Cpp2ILInjected.Token(Token = "0x40055C2")]
		public const short MrsClauseHat = 1932;

		// Token: 0x04004377 RID: 17271
		[global::Cpp2ILInjected.Token(Token = "0x40055C3")]
		public const short MrsClauseShirt = 1933;

		// Token: 0x04004378 RID: 17272
		[global::Cpp2ILInjected.Token(Token = "0x40055C4")]
		public const short MrsClauseHeels = 1934;

		// Token: 0x04004379 RID: 17273
		[global::Cpp2ILInjected.Token(Token = "0x40055C5")]
		public const short ParkaHood = 1935;

		// Token: 0x0400437A RID: 17274
		[global::Cpp2ILInjected.Token(Token = "0x40055C6")]
		public const short ParkaCoat = 1936;

		// Token: 0x0400437B RID: 17275
		[global::Cpp2ILInjected.Token(Token = "0x40055C7")]
		public const short ParkaPants = 1937;

		// Token: 0x0400437C RID: 17276
		[global::Cpp2ILInjected.Token(Token = "0x40055C8")]
		public const short SnowHat = 1938;

		// Token: 0x0400437D RID: 17277
		[global::Cpp2ILInjected.Token(Token = "0x40055C9")]
		public const short UglySweater = 1939;

		// Token: 0x0400437E RID: 17278
		[global::Cpp2ILInjected.Token(Token = "0x40055CA")]
		public const short TreeMask = 1940;

		// Token: 0x0400437F RID: 17279
		[global::Cpp2ILInjected.Token(Token = "0x40055CB")]
		public const short TreeShirt = 1941;

		// Token: 0x04004380 RID: 17280
		[global::Cpp2ILInjected.Token(Token = "0x40055CC")]
		public const short TreeTrunks = 1942;

		// Token: 0x04004381 RID: 17281
		[global::Cpp2ILInjected.Token(Token = "0x40055CD")]
		public const short ElfHat = 1943;

		// Token: 0x04004382 RID: 17282
		[global::Cpp2ILInjected.Token(Token = "0x40055CE")]
		public const short ElfShirt = 1944;

		// Token: 0x04004383 RID: 17283
		[global::Cpp2ILInjected.Token(Token = "0x40055CF")]
		public const short ElfPants = 1945;

		// Token: 0x04004384 RID: 17284
		[global::Cpp2ILInjected.Token(Token = "0x40055D0")]
		public const short SnowmanCannon = 1946;

		// Token: 0x04004385 RID: 17285
		[global::Cpp2ILInjected.Token(Token = "0x40055D1")]
		public const short NorthPole = 1947;

		// Token: 0x04004386 RID: 17286
		[global::Cpp2ILInjected.Token(Token = "0x40055D2")]
		public const short ChristmasTreeWallpaper = 1948;

		// Token: 0x04004387 RID: 17287
		[global::Cpp2ILInjected.Token(Token = "0x40055D3")]
		public const short OrnamentWallpaper = 1949;

		// Token: 0x04004388 RID: 17288
		[global::Cpp2ILInjected.Token(Token = "0x40055D4")]
		public const short CandyCaneWallpaper = 1950;

		// Token: 0x04004389 RID: 17289
		[global::Cpp2ILInjected.Token(Token = "0x40055D5")]
		public const short FestiveWallpaper = 1951;

		// Token: 0x0400438A RID: 17290
		[global::Cpp2ILInjected.Token(Token = "0x40055D6")]
		public const short StarsWallpaper = 1952;

		// Token: 0x0400438B RID: 17291
		[global::Cpp2ILInjected.Token(Token = "0x40055D7")]
		public const short SquigglesWallpaper = 1953;

		// Token: 0x0400438C RID: 17292
		[global::Cpp2ILInjected.Token(Token = "0x40055D8")]
		public const short SnowflakeWallpaper = 1954;

		// Token: 0x0400438D RID: 17293
		[global::Cpp2ILInjected.Token(Token = "0x40055D9")]
		public const short KrampusHornWallpaper = 1955;

		// Token: 0x0400438E RID: 17294
		[global::Cpp2ILInjected.Token(Token = "0x40055DA")]
		public const short BluegreenWallpaper = 1956;

		// Token: 0x0400438F RID: 17295
		[global::Cpp2ILInjected.Token(Token = "0x40055DB")]
		public const short GrinchFingerWallpaper = 1957;

		// Token: 0x04004390 RID: 17296
		[global::Cpp2ILInjected.Token(Token = "0x40055DC")]
		public const short NaughtyPresent = 1958;

		// Token: 0x04004391 RID: 17297
		[global::Cpp2ILInjected.Token(Token = "0x40055DD")]
		public const short BabyGrinchMischiefWhistle = 1959;

		// Token: 0x04004392 RID: 17298
		[global::Cpp2ILInjected.Token(Token = "0x40055DE")]
		public const short IceQueenTrophy = 1960;

		// Token: 0x04004393 RID: 17299
		[global::Cpp2ILInjected.Token(Token = "0x40055DF")]
		public const short SantaNK1Trophy = 1961;

		// Token: 0x04004394 RID: 17300
		[global::Cpp2ILInjected.Token(Token = "0x40055E0")]
		public const short EverscreamTrophy = 1962;

		// Token: 0x04004395 RID: 17301
		[global::Cpp2ILInjected.Token(Token = "0x40055E1")]
		public const short MusicBoxPumpkinMoon = 1963;

		// Token: 0x04004396 RID: 17302
		[global::Cpp2ILInjected.Token(Token = "0x40055E2")]
		public const short MusicBoxAltUnderground = 1964;

		// Token: 0x04004397 RID: 17303
		[global::Cpp2ILInjected.Token(Token = "0x40055E3")]
		public const short MusicBoxFrostMoon = 1965;

		// Token: 0x04004398 RID: 17304
		[global::Cpp2ILInjected.Token(Token = "0x40055E4")]
		public const short BrownPaint = 1966;

		// Token: 0x04004399 RID: 17305
		[global::Cpp2ILInjected.Token(Token = "0x40055E5")]
		public const short ShadowPaint = 1967;

		// Token: 0x0400439A RID: 17306
		[global::Cpp2ILInjected.Token(Token = "0x40055E6")]
		public const short NegativePaint = 1968;

		// Token: 0x0400439B RID: 17307
		[global::Cpp2ILInjected.Token(Token = "0x40055E7")]
		public const short TeamDye = 1969;

		// Token: 0x0400439C RID: 17308
		[global::Cpp2ILInjected.Token(Token = "0x40055E8")]
		public const short AmethystGemsparkBlock = 1970;

		// Token: 0x0400439D RID: 17309
		[global::Cpp2ILInjected.Token(Token = "0x40055E9")]
		public const short TopazGemsparkBlock = 1971;

		// Token: 0x0400439E RID: 17310
		[global::Cpp2ILInjected.Token(Token = "0x40055EA")]
		public const short SapphireGemsparkBlock = 1972;

		// Token: 0x0400439F RID: 17311
		[global::Cpp2ILInjected.Token(Token = "0x40055EB")]
		public const short EmeraldGemsparkBlock = 1973;

		// Token: 0x040043A0 RID: 17312
		[global::Cpp2ILInjected.Token(Token = "0x40055EC")]
		public const short RubyGemsparkBlock = 1974;

		// Token: 0x040043A1 RID: 17313
		[global::Cpp2ILInjected.Token(Token = "0x40055ED")]
		public const short DiamondGemsparkBlock = 1975;

		// Token: 0x040043A2 RID: 17314
		[global::Cpp2ILInjected.Token(Token = "0x40055EE")]
		public const short AmberGemsparkBlock = 1976;

		// Token: 0x040043A3 RID: 17315
		[global::Cpp2ILInjected.Token(Token = "0x40055EF")]
		public const short LifeHairDye = 1977;

		// Token: 0x040043A4 RID: 17316
		[global::Cpp2ILInjected.Token(Token = "0x40055F0")]
		public const short ManaHairDye = 1978;

		// Token: 0x040043A5 RID: 17317
		[global::Cpp2ILInjected.Token(Token = "0x40055F1")]
		public const short DepthHairDye = 1979;

		// Token: 0x040043A6 RID: 17318
		[global::Cpp2ILInjected.Token(Token = "0x40055F2")]
		public const short MoneyHairDye = 1980;

		// Token: 0x040043A7 RID: 17319
		[global::Cpp2ILInjected.Token(Token = "0x40055F3")]
		public const short TimeHairDye = 1981;

		// Token: 0x040043A8 RID: 17320
		[global::Cpp2ILInjected.Token(Token = "0x40055F4")]
		public const short TeamHairDye = 1982;

		// Token: 0x040043A9 RID: 17321
		[global::Cpp2ILInjected.Token(Token = "0x40055F5")]
		public const short BiomeHairDye = 1983;

		// Token: 0x040043AA RID: 17322
		[global::Cpp2ILInjected.Token(Token = "0x40055F6")]
		public const short PartyHairDye = 1984;

		// Token: 0x040043AB RID: 17323
		[global::Cpp2ILInjected.Token(Token = "0x40055F7")]
		public const short RainbowHairDye = 1985;

		// Token: 0x040043AC RID: 17324
		[global::Cpp2ILInjected.Token(Token = "0x40055F8")]
		public const short SpeedHairDye = 1986;

		// Token: 0x040043AD RID: 17325
		[global::Cpp2ILInjected.Token(Token = "0x40055F9")]
		public const short AngelHalo = 1987;

		// Token: 0x040043AE RID: 17326
		[global::Cpp2ILInjected.Token(Token = "0x40055FA")]
		public const short Fez = 1988;

		// Token: 0x040043AF RID: 17327
		[global::Cpp2ILInjected.Token(Token = "0x40055FB")]
		public const short Womannquin = 1989;

		// Token: 0x040043B0 RID: 17328
		[global::Cpp2ILInjected.Token(Token = "0x40055FC")]
		public const short HairDyeRemover = 1990;

		// Token: 0x040043B1 RID: 17329
		[global::Cpp2ILInjected.Token(Token = "0x40055FD")]
		public const short BugNet = 1991;

		// Token: 0x040043B2 RID: 17330
		[global::Cpp2ILInjected.Token(Token = "0x40055FE")]
		public const short Firefly = 1992;

		// Token: 0x040043B3 RID: 17331
		[global::Cpp2ILInjected.Token(Token = "0x40055FF")]
		public const short FireflyinaBottle = 1993;

		// Token: 0x040043B4 RID: 17332
		[global::Cpp2ILInjected.Token(Token = "0x4005600")]
		public const short MonarchButterfly = 1994;

		// Token: 0x040043B5 RID: 17333
		[global::Cpp2ILInjected.Token(Token = "0x4005601")]
		public const short PurpleEmperorButterfly = 1995;

		// Token: 0x040043B6 RID: 17334
		[global::Cpp2ILInjected.Token(Token = "0x4005602")]
		public const short RedAdmiralButterfly = 1996;

		// Token: 0x040043B7 RID: 17335
		[global::Cpp2ILInjected.Token(Token = "0x4005603")]
		public const short UlyssesButterfly = 1997;

		// Token: 0x040043B8 RID: 17336
		[global::Cpp2ILInjected.Token(Token = "0x4005604")]
		public const short SulphurButterfly = 1998;

		// Token: 0x040043B9 RID: 17337
		[global::Cpp2ILInjected.Token(Token = "0x4005605")]
		public const short TreeNymphButterfly = 1999;

		// Token: 0x040043BA RID: 17338
		[global::Cpp2ILInjected.Token(Token = "0x4005606")]
		public const short ZebraSwallowtailButterfly = 2000;

		// Token: 0x040043BB RID: 17339
		[global::Cpp2ILInjected.Token(Token = "0x4005607")]
		public const short JuliaButterfly = 2001;

		// Token: 0x040043BC RID: 17340
		[global::Cpp2ILInjected.Token(Token = "0x4005608")]
		public const short Worm = 2002;

		// Token: 0x040043BD RID: 17341
		[global::Cpp2ILInjected.Token(Token = "0x4005609")]
		public const short Mouse = 2003;

		// Token: 0x040043BE RID: 17342
		[global::Cpp2ILInjected.Token(Token = "0x400560A")]
		public const short LightningBug = 2004;

		// Token: 0x040043BF RID: 17343
		[global::Cpp2ILInjected.Token(Token = "0x400560B")]
		public const short LightningBuginaBottle = 2005;

		// Token: 0x040043C0 RID: 17344
		[global::Cpp2ILInjected.Token(Token = "0x400560C")]
		public const short Snail = 2006;

		// Token: 0x040043C1 RID: 17345
		[global::Cpp2ILInjected.Token(Token = "0x400560D")]
		public const short GlowingSnail = 2007;

		// Token: 0x040043C2 RID: 17346
		[global::Cpp2ILInjected.Token(Token = "0x400560E")]
		public const short FancyGreyWallpaper = 2008;

		// Token: 0x040043C3 RID: 17347
		[global::Cpp2ILInjected.Token(Token = "0x400560F")]
		public const short IceFloeWallpaper = 2009;

		// Token: 0x040043C4 RID: 17348
		[global::Cpp2ILInjected.Token(Token = "0x4005610")]
		public const short MusicWallpaper = 2010;

		// Token: 0x040043C5 RID: 17349
		[global::Cpp2ILInjected.Token(Token = "0x4005611")]
		public const short PurpleRainWallpaper = 2011;

		// Token: 0x040043C6 RID: 17350
		[global::Cpp2ILInjected.Token(Token = "0x4005612")]
		public const short RainbowWallpaper = 2012;

		// Token: 0x040043C7 RID: 17351
		[global::Cpp2ILInjected.Token(Token = "0x4005613")]
		public const short SparkleStoneWallpaper = 2013;

		// Token: 0x040043C8 RID: 17352
		[global::Cpp2ILInjected.Token(Token = "0x4005614")]
		public const short StarlitHeavenWallpaper = 2014;

		// Token: 0x040043C9 RID: 17353
		[global::Cpp2ILInjected.Token(Token = "0x4005615")]
		public const short Bird = 2015;

		// Token: 0x040043CA RID: 17354
		[global::Cpp2ILInjected.Token(Token = "0x4005616")]
		public const short BlueJay = 2016;

		// Token: 0x040043CB RID: 17355
		[global::Cpp2ILInjected.Token(Token = "0x4005617")]
		public const short Cardinal = 2017;

		// Token: 0x040043CC RID: 17356
		[global::Cpp2ILInjected.Token(Token = "0x4005618")]
		public const short Squirrel = 2018;

		// Token: 0x040043CD RID: 17357
		[global::Cpp2ILInjected.Token(Token = "0x4005619")]
		public const short Bunny = 2019;

		// Token: 0x040043CE RID: 17358
		[global::Cpp2ILInjected.Token(Token = "0x400561A")]
		public const short CactusBookcase = 2020;

		// Token: 0x040043CF RID: 17359
		[global::Cpp2ILInjected.Token(Token = "0x400561B")]
		public const short EbonwoodBookcase = 2021;

		// Token: 0x040043D0 RID: 17360
		[global::Cpp2ILInjected.Token(Token = "0x400561C")]
		public const short FleshBookcase = 2022;

		// Token: 0x040043D1 RID: 17361
		[global::Cpp2ILInjected.Token(Token = "0x400561D")]
		public const short HoneyBookcase = 2023;

		// Token: 0x040043D2 RID: 17362
		[global::Cpp2ILInjected.Token(Token = "0x400561E")]
		public const short SteampunkBookcase = 2024;

		// Token: 0x040043D3 RID: 17363
		[global::Cpp2ILInjected.Token(Token = "0x400561F")]
		public const short GlassBookcase = 2025;

		// Token: 0x040043D4 RID: 17364
		[global::Cpp2ILInjected.Token(Token = "0x4005620")]
		public const short RichMahoganyBookcase = 2026;

		// Token: 0x040043D5 RID: 17365
		[global::Cpp2ILInjected.Token(Token = "0x4005621")]
		public const short PearlwoodBookcase = 2027;

		// Token: 0x040043D6 RID: 17366
		[global::Cpp2ILInjected.Token(Token = "0x4005622")]
		public const short SpookyBookcase = 2028;

		// Token: 0x040043D7 RID: 17367
		[global::Cpp2ILInjected.Token(Token = "0x4005623")]
		public const short SkywareBookcase = 2029;

		// Token: 0x040043D8 RID: 17368
		[global::Cpp2ILInjected.Token(Token = "0x4005624")]
		public const short LihzahrdBookcase = 2030;

		// Token: 0x040043D9 RID: 17369
		[global::Cpp2ILInjected.Token(Token = "0x4005625")]
		public const short FrozenBookcase = 2031;

		// Token: 0x040043DA RID: 17370
		[global::Cpp2ILInjected.Token(Token = "0x4005626")]
		public const short CactusLantern = 2032;

		// Token: 0x040043DB RID: 17371
		[global::Cpp2ILInjected.Token(Token = "0x4005627")]
		public const short EbonwoodLantern = 2033;

		// Token: 0x040043DC RID: 17372
		[global::Cpp2ILInjected.Token(Token = "0x4005628")]
		public const short FleshLantern = 2034;

		// Token: 0x040043DD RID: 17373
		[global::Cpp2ILInjected.Token(Token = "0x4005629")]
		public const short HoneyLantern = 2035;

		// Token: 0x040043DE RID: 17374
		[global::Cpp2ILInjected.Token(Token = "0x400562A")]
		public const short SteampunkLantern = 2036;

		// Token: 0x040043DF RID: 17375
		[global::Cpp2ILInjected.Token(Token = "0x400562B")]
		public const short GlassLantern = 2037;

		// Token: 0x040043E0 RID: 17376
		[global::Cpp2ILInjected.Token(Token = "0x400562C")]
		public const short RichMahoganyLantern = 2038;

		// Token: 0x040043E1 RID: 17377
		[global::Cpp2ILInjected.Token(Token = "0x400562D")]
		public const short PearlwoodLantern = 2039;

		// Token: 0x040043E2 RID: 17378
		[global::Cpp2ILInjected.Token(Token = "0x400562E")]
		public const short FrozenLantern = 2040;

		// Token: 0x040043E3 RID: 17379
		[global::Cpp2ILInjected.Token(Token = "0x400562F")]
		public const short LihzahrdLantern = 2041;

		// Token: 0x040043E4 RID: 17380
		[global::Cpp2ILInjected.Token(Token = "0x4005630")]
		public const short SkywareLantern = 2042;

		// Token: 0x040043E5 RID: 17381
		[global::Cpp2ILInjected.Token(Token = "0x4005631")]
		public const short SpookyLantern = 2043;

		// Token: 0x040043E6 RID: 17382
		[global::Cpp2ILInjected.Token(Token = "0x4005632")]
		public const short FrozenDoor = 2044;

		// Token: 0x040043E7 RID: 17383
		[global::Cpp2ILInjected.Token(Token = "0x4005633")]
		public const short CactusCandle = 2045;

		// Token: 0x040043E8 RID: 17384
		[global::Cpp2ILInjected.Token(Token = "0x4005634")]
		public const short EbonwoodCandle = 2046;

		// Token: 0x040043E9 RID: 17385
		[global::Cpp2ILInjected.Token(Token = "0x4005635")]
		public const short FleshCandle = 2047;

		// Token: 0x040043EA RID: 17386
		[global::Cpp2ILInjected.Token(Token = "0x4005636")]
		public const short GlassCandle = 2048;

		// Token: 0x040043EB RID: 17387
		[global::Cpp2ILInjected.Token(Token = "0x4005637")]
		public const short FrozenCandle = 2049;

		// Token: 0x040043EC RID: 17388
		[global::Cpp2ILInjected.Token(Token = "0x4005638")]
		public const short RichMahoganyCandle = 2050;

		// Token: 0x040043ED RID: 17389
		[global::Cpp2ILInjected.Token(Token = "0x4005639")]
		public const short PearlwoodCandle = 2051;

		// Token: 0x040043EE RID: 17390
		[global::Cpp2ILInjected.Token(Token = "0x400563A")]
		public const short LihzahrdCandle = 2052;

		// Token: 0x040043EF RID: 17391
		[global::Cpp2ILInjected.Token(Token = "0x400563B")]
		public const short SkywareCandle = 2053;

		// Token: 0x040043F0 RID: 17392
		[global::Cpp2ILInjected.Token(Token = "0x400563C")]
		public const short PumpkinCandle = 2054;

		// Token: 0x040043F1 RID: 17393
		[global::Cpp2ILInjected.Token(Token = "0x400563D")]
		public const short CactusChandelier = 2055;

		// Token: 0x040043F2 RID: 17394
		[global::Cpp2ILInjected.Token(Token = "0x400563E")]
		public const short EbonwoodChandelier = 2056;

		// Token: 0x040043F3 RID: 17395
		[global::Cpp2ILInjected.Token(Token = "0x400563F")]
		public const short FleshChandelier = 2057;

		// Token: 0x040043F4 RID: 17396
		[global::Cpp2ILInjected.Token(Token = "0x4005640")]
		public const short HoneyChandelier = 2058;

		// Token: 0x040043F5 RID: 17397
		[global::Cpp2ILInjected.Token(Token = "0x4005641")]
		public const short FrozenChandelier = 2059;

		// Token: 0x040043F6 RID: 17398
		[global::Cpp2ILInjected.Token(Token = "0x4005642")]
		public const short RichMahoganyChandelier = 2060;

		// Token: 0x040043F7 RID: 17399
		[global::Cpp2ILInjected.Token(Token = "0x4005643")]
		public const short PearlwoodChandelier = 2061;

		// Token: 0x040043F8 RID: 17400
		[global::Cpp2ILInjected.Token(Token = "0x4005644")]
		public const short LihzahrdChandelier = 2062;

		// Token: 0x040043F9 RID: 17401
		[global::Cpp2ILInjected.Token(Token = "0x4005645")]
		public const short SkywareChandelier = 2063;

		// Token: 0x040043FA RID: 17402
		[global::Cpp2ILInjected.Token(Token = "0x4005646")]
		public const short SpookyChandelier = 2064;

		// Token: 0x040043FB RID: 17403
		[global::Cpp2ILInjected.Token(Token = "0x4005647")]
		public const short GlassChandelier = 2065;

		// Token: 0x040043FC RID: 17404
		[global::Cpp2ILInjected.Token(Token = "0x4005648")]
		public const short CactusBed = 2066;

		// Token: 0x040043FD RID: 17405
		[global::Cpp2ILInjected.Token(Token = "0x4005649")]
		public const short FleshBed = 2067;

		// Token: 0x040043FE RID: 17406
		[global::Cpp2ILInjected.Token(Token = "0x400564A")]
		public const short FrozenBed = 2068;

		// Token: 0x040043FF RID: 17407
		[global::Cpp2ILInjected.Token(Token = "0x400564B")]
		public const short LihzahrdBed = 2069;

		// Token: 0x04004400 RID: 17408
		[global::Cpp2ILInjected.Token(Token = "0x400564C")]
		public const short SkywareBed = 2070;

		// Token: 0x04004401 RID: 17409
		[global::Cpp2ILInjected.Token(Token = "0x400564D")]
		public const short SpookyBed = 2071;

		// Token: 0x04004402 RID: 17410
		[global::Cpp2ILInjected.Token(Token = "0x400564E")]
		public const short CactusBathtub = 2072;

		// Token: 0x04004403 RID: 17411
		[global::Cpp2ILInjected.Token(Token = "0x400564F")]
		public const short EbonwoodBathtub = 2073;

		// Token: 0x04004404 RID: 17412
		[global::Cpp2ILInjected.Token(Token = "0x4005650")]
		public const short FleshBathtub = 2074;

		// Token: 0x04004405 RID: 17413
		[global::Cpp2ILInjected.Token(Token = "0x4005651")]
		public const short GlassBathtub = 2075;

		// Token: 0x04004406 RID: 17414
		[global::Cpp2ILInjected.Token(Token = "0x4005652")]
		public const short FrozenBathtub = 2076;

		// Token: 0x04004407 RID: 17415
		[global::Cpp2ILInjected.Token(Token = "0x4005653")]
		public const short RichMahoganyBathtub = 2077;

		// Token: 0x04004408 RID: 17416
		[global::Cpp2ILInjected.Token(Token = "0x4005654")]
		public const short PearlwoodBathtub = 2078;

		// Token: 0x04004409 RID: 17417
		[global::Cpp2ILInjected.Token(Token = "0x4005655")]
		public const short LihzahrdBathtub = 2079;

		// Token: 0x0400440A RID: 17418
		[global::Cpp2ILInjected.Token(Token = "0x4005656")]
		public const short SkywareBathtub = 2080;

		// Token: 0x0400440B RID: 17419
		[global::Cpp2ILInjected.Token(Token = "0x4005657")]
		public const short SpookyBathtub = 2081;

		// Token: 0x0400440C RID: 17420
		[global::Cpp2ILInjected.Token(Token = "0x4005658")]
		public const short CactusLamp = 2082;

		// Token: 0x0400440D RID: 17421
		[global::Cpp2ILInjected.Token(Token = "0x4005659")]
		public const short EbonwoodLamp = 2083;

		// Token: 0x0400440E RID: 17422
		[global::Cpp2ILInjected.Token(Token = "0x400565A")]
		public const short FleshLamp = 2084;

		// Token: 0x0400440F RID: 17423
		[global::Cpp2ILInjected.Token(Token = "0x400565B")]
		public const short GlassLamp = 2085;

		// Token: 0x04004410 RID: 17424
		[global::Cpp2ILInjected.Token(Token = "0x400565C")]
		public const short FrozenLamp = 2086;

		// Token: 0x04004411 RID: 17425
		[global::Cpp2ILInjected.Token(Token = "0x400565D")]
		public const short RichMahoganyLamp = 2087;

		// Token: 0x04004412 RID: 17426
		[global::Cpp2ILInjected.Token(Token = "0x400565E")]
		public const short PearlwoodLamp = 2088;

		// Token: 0x04004413 RID: 17427
		[global::Cpp2ILInjected.Token(Token = "0x400565F")]
		public const short LihzahrdLamp = 2089;

		// Token: 0x04004414 RID: 17428
		[global::Cpp2ILInjected.Token(Token = "0x4005660")]
		public const short SkywareLamp = 2090;

		// Token: 0x04004415 RID: 17429
		[global::Cpp2ILInjected.Token(Token = "0x4005661")]
		public const short SpookyLamp = 2091;

		// Token: 0x04004416 RID: 17430
		[global::Cpp2ILInjected.Token(Token = "0x4005662")]
		public const short CactusCandelabra = 2092;

		// Token: 0x04004417 RID: 17431
		[global::Cpp2ILInjected.Token(Token = "0x4005663")]
		public const short EbonwoodCandelabra = 2093;

		// Token: 0x04004418 RID: 17432
		[global::Cpp2ILInjected.Token(Token = "0x4005664")]
		public const short FleshCandelabra = 2094;

		// Token: 0x04004419 RID: 17433
		[global::Cpp2ILInjected.Token(Token = "0x4005665")]
		public const short HoneyCandelabra = 2095;

		// Token: 0x0400441A RID: 17434
		[global::Cpp2ILInjected.Token(Token = "0x4005666")]
		public const short SteampunkCandelabra = 2096;

		// Token: 0x0400441B RID: 17435
		[global::Cpp2ILInjected.Token(Token = "0x4005667")]
		public const short GlassCandelabra = 2097;

		// Token: 0x0400441C RID: 17436
		[global::Cpp2ILInjected.Token(Token = "0x4005668")]
		public const short RichMahoganyCandelabra = 2098;

		// Token: 0x0400441D RID: 17437
		[global::Cpp2ILInjected.Token(Token = "0x4005669")]
		public const short PearlwoodCandelabra = 2099;

		// Token: 0x0400441E RID: 17438
		[global::Cpp2ILInjected.Token(Token = "0x400566A")]
		public const short FrozenCandelabra = 2100;

		// Token: 0x0400441F RID: 17439
		[global::Cpp2ILInjected.Token(Token = "0x400566B")]
		public const short LihzahrdCandelabra = 2101;

		// Token: 0x04004420 RID: 17440
		[global::Cpp2ILInjected.Token(Token = "0x400566C")]
		public const short SkywareCandelabra = 2102;

		// Token: 0x04004421 RID: 17441
		[global::Cpp2ILInjected.Token(Token = "0x400566D")]
		public const short SpookyCandelabra = 2103;

		// Token: 0x04004422 RID: 17442
		[global::Cpp2ILInjected.Token(Token = "0x400566E")]
		public const short BrainMask = 2104;

		// Token: 0x04004423 RID: 17443
		[global::Cpp2ILInjected.Token(Token = "0x400566F")]
		public const short FleshMask = 2105;

		// Token: 0x04004424 RID: 17444
		[global::Cpp2ILInjected.Token(Token = "0x4005670")]
		public const short TwinMask = 2106;

		// Token: 0x04004425 RID: 17445
		[global::Cpp2ILInjected.Token(Token = "0x4005671")]
		public const short SkeletronPrimeMask = 2107;

		// Token: 0x04004426 RID: 17446
		[global::Cpp2ILInjected.Token(Token = "0x4005672")]
		public const short BeeMask = 2108;

		// Token: 0x04004427 RID: 17447
		[global::Cpp2ILInjected.Token(Token = "0x4005673")]
		public const short PlanteraMask = 2109;

		// Token: 0x04004428 RID: 17448
		[global::Cpp2ILInjected.Token(Token = "0x4005674")]
		public const short GolemMask = 2110;

		// Token: 0x04004429 RID: 17449
		[global::Cpp2ILInjected.Token(Token = "0x4005675")]
		public const short EaterMask = 2111;

		// Token: 0x0400442A RID: 17450
		[global::Cpp2ILInjected.Token(Token = "0x4005676")]
		public const short EyeMask = 2112;

		// Token: 0x0400442B RID: 17451
		[global::Cpp2ILInjected.Token(Token = "0x4005677")]
		public const short DestroyerMask = 2113;

		// Token: 0x0400442C RID: 17452
		[global::Cpp2ILInjected.Token(Token = "0x4005678")]
		public const short BlacksmithRack = 2114;

		// Token: 0x0400442D RID: 17453
		[global::Cpp2ILInjected.Token(Token = "0x4005679")]
		public const short CarpentryRack = 2115;

		// Token: 0x0400442E RID: 17454
		[global::Cpp2ILInjected.Token(Token = "0x400567A")]
		public const short HelmetRack = 2116;

		// Token: 0x0400442F RID: 17455
		[global::Cpp2ILInjected.Token(Token = "0x400567B")]
		public const short SpearRack = 2117;

		// Token: 0x04004430 RID: 17456
		[global::Cpp2ILInjected.Token(Token = "0x400567C")]
		public const short SwordRack = 2118;

		// Token: 0x04004431 RID: 17457
		[global::Cpp2ILInjected.Token(Token = "0x400567D")]
		public const short StoneSlab = 2119;

		// Token: 0x04004432 RID: 17458
		[global::Cpp2ILInjected.Token(Token = "0x400567E")]
		public const short SandstoneSlab = 2120;

		// Token: 0x04004433 RID: 17459
		[global::Cpp2ILInjected.Token(Token = "0x400567F")]
		public const short Frog = 2121;

		// Token: 0x04004434 RID: 17460
		[global::Cpp2ILInjected.Token(Token = "0x4005680")]
		public const short MallardDuck = 2122;

		// Token: 0x04004435 RID: 17461
		[global::Cpp2ILInjected.Token(Token = "0x4005681")]
		public const short Duck = 2123;

		// Token: 0x04004436 RID: 17462
		[global::Cpp2ILInjected.Token(Token = "0x4005682")]
		public const short HoneyBathtub = 2124;

		// Token: 0x04004437 RID: 17463
		[global::Cpp2ILInjected.Token(Token = "0x4005683")]
		public const short SteampunkBathtub = 2125;

		// Token: 0x04004438 RID: 17464
		[global::Cpp2ILInjected.Token(Token = "0x4005684")]
		public const short LivingWoodBathtub = 2126;

		// Token: 0x04004439 RID: 17465
		[global::Cpp2ILInjected.Token(Token = "0x4005685")]
		public const short ShadewoodBathtub = 2127;

		// Token: 0x0400443A RID: 17466
		[global::Cpp2ILInjected.Token(Token = "0x4005686")]
		public const short BoneBathtub = 2128;

		// Token: 0x0400443B RID: 17467
		[global::Cpp2ILInjected.Token(Token = "0x4005687")]
		public const short HoneyLamp = 2129;

		// Token: 0x0400443C RID: 17468
		[global::Cpp2ILInjected.Token(Token = "0x4005688")]
		public const short SteampunkLamp = 2130;

		// Token: 0x0400443D RID: 17469
		[global::Cpp2ILInjected.Token(Token = "0x4005689")]
		public const short LivingWoodLamp = 2131;

		// Token: 0x0400443E RID: 17470
		[global::Cpp2ILInjected.Token(Token = "0x400568A")]
		public const short ShadewoodLamp = 2132;

		// Token: 0x0400443F RID: 17471
		[global::Cpp2ILInjected.Token(Token = "0x400568B")]
		public const short GoldenLamp = 2133;

		// Token: 0x04004440 RID: 17472
		[global::Cpp2ILInjected.Token(Token = "0x400568C")]
		public const short BoneLamp = 2134;

		// Token: 0x04004441 RID: 17473
		[global::Cpp2ILInjected.Token(Token = "0x400568D")]
		public const short LivingWoodBookcase = 2135;

		// Token: 0x04004442 RID: 17474
		[global::Cpp2ILInjected.Token(Token = "0x400568E")]
		public const short ShadewoodBookcase = 2136;

		// Token: 0x04004443 RID: 17475
		[global::Cpp2ILInjected.Token(Token = "0x400568F")]
		public const short GoldenBookcase = 2137;

		// Token: 0x04004444 RID: 17476
		[global::Cpp2ILInjected.Token(Token = "0x4005690")]
		public const short BoneBookcase = 2138;

		// Token: 0x04004445 RID: 17477
		[global::Cpp2ILInjected.Token(Token = "0x4005691")]
		public const short LivingWoodBed = 2139;

		// Token: 0x04004446 RID: 17478
		[global::Cpp2ILInjected.Token(Token = "0x4005692")]
		public const short BoneBed = 2140;

		// Token: 0x04004447 RID: 17479
		[global::Cpp2ILInjected.Token(Token = "0x4005693")]
		public const short LivingWoodChandelier = 2141;

		// Token: 0x04004448 RID: 17480
		[global::Cpp2ILInjected.Token(Token = "0x4005694")]
		public const short ShadewoodChandelier = 2142;

		// Token: 0x04004449 RID: 17481
		[global::Cpp2ILInjected.Token(Token = "0x4005695")]
		public const short GoldenChandelier = 2143;

		// Token: 0x0400444A RID: 17482
		[global::Cpp2ILInjected.Token(Token = "0x4005696")]
		public const short BoneChandelier = 2144;

		// Token: 0x0400444B RID: 17483
		[global::Cpp2ILInjected.Token(Token = "0x4005697")]
		public const short LivingWoodLantern = 2145;

		// Token: 0x0400444C RID: 17484
		[global::Cpp2ILInjected.Token(Token = "0x4005698")]
		public const short ShadewoodLantern = 2146;

		// Token: 0x0400444D RID: 17485
		[global::Cpp2ILInjected.Token(Token = "0x4005699")]
		public const short GoldenLantern = 2147;

		// Token: 0x0400444E RID: 17486
		[global::Cpp2ILInjected.Token(Token = "0x400569A")]
		public const short BoneLantern = 2148;

		// Token: 0x0400444F RID: 17487
		[global::Cpp2ILInjected.Token(Token = "0x400569B")]
		public const short LivingWoodCandelabra = 2149;

		// Token: 0x04004450 RID: 17488
		[global::Cpp2ILInjected.Token(Token = "0x400569C")]
		public const short ShadewoodCandelabra = 2150;

		// Token: 0x04004451 RID: 17489
		[global::Cpp2ILInjected.Token(Token = "0x400569D")]
		public const short GoldenCandelabra = 2151;

		// Token: 0x04004452 RID: 17490
		[global::Cpp2ILInjected.Token(Token = "0x400569E")]
		public const short BoneCandelabra = 2152;

		// Token: 0x04004453 RID: 17491
		[global::Cpp2ILInjected.Token(Token = "0x400569F")]
		public const short LivingWoodCandle = 2153;

		// Token: 0x04004454 RID: 17492
		[global::Cpp2ILInjected.Token(Token = "0x40056A0")]
		public const short ShadewoodCandle = 2154;

		// Token: 0x04004455 RID: 17493
		[global::Cpp2ILInjected.Token(Token = "0x40056A1")]
		public const short GoldenCandle = 2155;

		// Token: 0x04004456 RID: 17494
		[global::Cpp2ILInjected.Token(Token = "0x40056A2")]
		public const short BlackScorpion = 2156;

		// Token: 0x04004457 RID: 17495
		[global::Cpp2ILInjected.Token(Token = "0x40056A3")]
		public const short Scorpion = 2157;

		// Token: 0x04004458 RID: 17496
		[global::Cpp2ILInjected.Token(Token = "0x40056A4")]
		public const short BubbleWallpaper = 2158;

		// Token: 0x04004459 RID: 17497
		[global::Cpp2ILInjected.Token(Token = "0x40056A5")]
		public const short CopperPipeWallpaper = 2159;

		// Token: 0x0400445A RID: 17498
		[global::Cpp2ILInjected.Token(Token = "0x40056A6")]
		public const short DuckyWallpaper = 2160;

		// Token: 0x0400445B RID: 17499
		[global::Cpp2ILInjected.Token(Token = "0x40056A7")]
		public const short FrostCore = 2161;

		// Token: 0x0400445C RID: 17500
		[global::Cpp2ILInjected.Token(Token = "0x40056A8")]
		public const short BunnyCage = 2162;

		// Token: 0x0400445D RID: 17501
		[global::Cpp2ILInjected.Token(Token = "0x40056A9")]
		public const short SquirrelCage = 2163;

		// Token: 0x0400445E RID: 17502
		[global::Cpp2ILInjected.Token(Token = "0x40056AA")]
		public const short MallardDuckCage = 2164;

		// Token: 0x0400445F RID: 17503
		[global::Cpp2ILInjected.Token(Token = "0x40056AB")]
		public const short DuckCage = 2165;

		// Token: 0x04004460 RID: 17504
		[global::Cpp2ILInjected.Token(Token = "0x40056AC")]
		public const short BirdCage = 2166;

		// Token: 0x04004461 RID: 17505
		[global::Cpp2ILInjected.Token(Token = "0x40056AD")]
		public const short BlueJayCage = 2167;

		// Token: 0x04004462 RID: 17506
		[global::Cpp2ILInjected.Token(Token = "0x40056AE")]
		public const short CardinalCage = 2168;

		// Token: 0x04004463 RID: 17507
		[global::Cpp2ILInjected.Token(Token = "0x40056AF")]
		public const short WaterfallWall = 2169;

		// Token: 0x04004464 RID: 17508
		[global::Cpp2ILInjected.Token(Token = "0x40056B0")]
		public const short LavafallWall = 2170;

		// Token: 0x04004465 RID: 17509
		[global::Cpp2ILInjected.Token(Token = "0x40056B1")]
		public const short CrimsonSeeds = 2171;

		// Token: 0x04004466 RID: 17510
		[global::Cpp2ILInjected.Token(Token = "0x40056B2")]
		public const short HeavyWorkBench = 2172;

		// Token: 0x04004467 RID: 17511
		[global::Cpp2ILInjected.Token(Token = "0x40056B3")]
		public const short CopperPlating = 2173;

		// Token: 0x04004468 RID: 17512
		[global::Cpp2ILInjected.Token(Token = "0x40056B4")]
		public const short SnailCage = 2174;

		// Token: 0x04004469 RID: 17513
		[global::Cpp2ILInjected.Token(Token = "0x40056B5")]
		public const short GlowingSnailCage = 2175;

		// Token: 0x0400446A RID: 17514
		[global::Cpp2ILInjected.Token(Token = "0x40056B6")]
		public const short ShroomiteDiggingClaw = 2176;

		// Token: 0x0400446B RID: 17515
		[global::Cpp2ILInjected.Token(Token = "0x40056B7")]
		public const short AmmoBox = 2177;

		// Token: 0x0400446C RID: 17516
		[global::Cpp2ILInjected.Token(Token = "0x40056B8")]
		public const short MonarchButterflyJar = 2178;

		// Token: 0x0400446D RID: 17517
		[global::Cpp2ILInjected.Token(Token = "0x40056B9")]
		public const short PurpleEmperorButterflyJar = 2179;

		// Token: 0x0400446E RID: 17518
		[global::Cpp2ILInjected.Token(Token = "0x40056BA")]
		public const short RedAdmiralButterflyJar = 2180;

		// Token: 0x0400446F RID: 17519
		[global::Cpp2ILInjected.Token(Token = "0x40056BB")]
		public const short UlyssesButterflyJar = 2181;

		// Token: 0x04004470 RID: 17520
		[global::Cpp2ILInjected.Token(Token = "0x40056BC")]
		public const short SulphurButterflyJar = 2182;

		// Token: 0x04004471 RID: 17521
		[global::Cpp2ILInjected.Token(Token = "0x40056BD")]
		public const short TreeNymphButterflyJar = 2183;

		// Token: 0x04004472 RID: 17522
		[global::Cpp2ILInjected.Token(Token = "0x40056BE")]
		public const short ZebraSwallowtailButterflyJar = 2184;

		// Token: 0x04004473 RID: 17523
		[global::Cpp2ILInjected.Token(Token = "0x40056BF")]
		public const short JuliaButterflyJar = 2185;

		// Token: 0x04004474 RID: 17524
		[global::Cpp2ILInjected.Token(Token = "0x40056C0")]
		public const short ScorpionCage = 2186;

		// Token: 0x04004475 RID: 17525
		[global::Cpp2ILInjected.Token(Token = "0x40056C1")]
		public const short BlackScorpionCage = 2187;

		// Token: 0x04004476 RID: 17526
		[global::Cpp2ILInjected.Token(Token = "0x40056C2")]
		public const short VenomStaff = 2188;

		// Token: 0x04004477 RID: 17527
		[global::Cpp2ILInjected.Token(Token = "0x40056C3")]
		public const short SpectreMask = 2189;

		// Token: 0x04004478 RID: 17528
		[global::Cpp2ILInjected.Token(Token = "0x40056C4")]
		public const short FrogCage = 2190;

		// Token: 0x04004479 RID: 17529
		[global::Cpp2ILInjected.Token(Token = "0x40056C5")]
		public const short MouseCage = 2191;

		// Token: 0x0400447A RID: 17530
		[global::Cpp2ILInjected.Token(Token = "0x40056C6")]
		public const short BoneWelder = 2192;

		// Token: 0x0400447B RID: 17531
		[global::Cpp2ILInjected.Token(Token = "0x40056C7")]
		public const short FleshCloningVaat = 2193;

		// Token: 0x0400447C RID: 17532
		[global::Cpp2ILInjected.Token(Token = "0x40056C8")]
		public const short GlassKiln = 2194;

		// Token: 0x0400447D RID: 17533
		[global::Cpp2ILInjected.Token(Token = "0x40056C9")]
		public const short LihzahrdFurnace = 2195;

		// Token: 0x0400447E RID: 17534
		[global::Cpp2ILInjected.Token(Token = "0x40056CA")]
		public const short LivingLoom = 2196;

		// Token: 0x0400447F RID: 17535
		[global::Cpp2ILInjected.Token(Token = "0x40056CB")]
		public const short SkyMill = 2197;

		// Token: 0x04004480 RID: 17536
		[global::Cpp2ILInjected.Token(Token = "0x40056CC")]
		public const short IceMachine = 2198;

		// Token: 0x04004481 RID: 17537
		[global::Cpp2ILInjected.Token(Token = "0x40056CD")]
		public const short BeetleHelmet = 2199;

		// Token: 0x04004482 RID: 17538
		[global::Cpp2ILInjected.Token(Token = "0x40056CE")]
		public const short BeetleScaleMail = 2200;

		// Token: 0x04004483 RID: 17539
		[global::Cpp2ILInjected.Token(Token = "0x40056CF")]
		public const short BeetleShell = 2201;

		// Token: 0x04004484 RID: 17540
		[global::Cpp2ILInjected.Token(Token = "0x40056D0")]
		public const short BeetleLeggings = 2202;

		// Token: 0x04004485 RID: 17541
		[global::Cpp2ILInjected.Token(Token = "0x40056D1")]
		public const short SteampunkBoiler = 2203;

		// Token: 0x04004486 RID: 17542
		[global::Cpp2ILInjected.Token(Token = "0x40056D2")]
		public const short HoneyDispenser = 2204;

		// Token: 0x04004487 RID: 17543
		[global::Cpp2ILInjected.Token(Token = "0x40056D3")]
		public const short Penguin = 2205;

		// Token: 0x04004488 RID: 17544
		[global::Cpp2ILInjected.Token(Token = "0x40056D4")]
		public const short PenguinCage = 2206;

		// Token: 0x04004489 RID: 17545
		[global::Cpp2ILInjected.Token(Token = "0x40056D5")]
		public const short WormCage = 2207;

		// Token: 0x0400448A RID: 17546
		[global::Cpp2ILInjected.Token(Token = "0x40056D6")]
		public const short Terrarium = 2208;

		// Token: 0x0400448B RID: 17547
		[global::Cpp2ILInjected.Token(Token = "0x40056D7")]
		public const short SuperManaPotion = 2209;

		// Token: 0x0400448C RID: 17548
		[global::Cpp2ILInjected.Token(Token = "0x40056D8")]
		public const short EbonwoodFence = 2210;

		// Token: 0x0400448D RID: 17549
		[global::Cpp2ILInjected.Token(Token = "0x40056D9")]
		public const short RichMahoganyFence = 2211;

		// Token: 0x0400448E RID: 17550
		[global::Cpp2ILInjected.Token(Token = "0x40056DA")]
		public const short PearlwoodFence = 2212;

		// Token: 0x0400448F RID: 17551
		[global::Cpp2ILInjected.Token(Token = "0x40056DB")]
		public const short ShadewoodFence = 2213;

		// Token: 0x04004490 RID: 17552
		[global::Cpp2ILInjected.Token(Token = "0x40056DC")]
		public const short BrickLayer = 2214;

		// Token: 0x04004491 RID: 17553
		[global::Cpp2ILInjected.Token(Token = "0x40056DD")]
		public const short ExtendoGrip = 2215;

		// Token: 0x04004492 RID: 17554
		[global::Cpp2ILInjected.Token(Token = "0x40056DE")]
		public const short PaintSprayer = 2216;

		// Token: 0x04004493 RID: 17555
		[global::Cpp2ILInjected.Token(Token = "0x40056DF")]
		public const short PortableCementMixer = 2217;

		// Token: 0x04004494 RID: 17556
		[global::Cpp2ILInjected.Token(Token = "0x40056E0")]
		public const short BeetleHusk = 2218;

		// Token: 0x04004495 RID: 17557
		[global::Cpp2ILInjected.Token(Token = "0x40056E1")]
		public const short CelestialMagnet = 2219;

		// Token: 0x04004496 RID: 17558
		[global::Cpp2ILInjected.Token(Token = "0x40056E2")]
		public const short CelestialEmblem = 2220;

		// Token: 0x04004497 RID: 17559
		[global::Cpp2ILInjected.Token(Token = "0x40056E3")]
		public const short CelestialCuffs = 2221;

		// Token: 0x04004498 RID: 17560
		[global::Cpp2ILInjected.Token(Token = "0x40056E4")]
		public const short PeddlersHat = 2222;

		// Token: 0x04004499 RID: 17561
		[global::Cpp2ILInjected.Token(Token = "0x40056E5")]
		public const short PulseBow = 2223;

		// Token: 0x0400449A RID: 17562
		[global::Cpp2ILInjected.Token(Token = "0x40056E6")]
		public const short DynastyChandelier = 2224;

		// Token: 0x0400449B RID: 17563
		[global::Cpp2ILInjected.Token(Token = "0x40056E7")]
		public const short DynastyLamp = 2225;

		// Token: 0x0400449C RID: 17564
		[global::Cpp2ILInjected.Token(Token = "0x40056E8")]
		public const short DynastyLantern = 2226;

		// Token: 0x0400449D RID: 17565
		[global::Cpp2ILInjected.Token(Token = "0x40056E9")]
		public const short DynastyCandelabra = 2227;

		// Token: 0x0400449E RID: 17566
		[global::Cpp2ILInjected.Token(Token = "0x40056EA")]
		public const short DynastyChair = 2228;

		// Token: 0x0400449F RID: 17567
		[global::Cpp2ILInjected.Token(Token = "0x40056EB")]
		public const short DynastyWorkBench = 2229;

		// Token: 0x040044A0 RID: 17568
		[global::Cpp2ILInjected.Token(Token = "0x40056EC")]
		public const short DynastyChest = 2230;

		// Token: 0x040044A1 RID: 17569
		[global::Cpp2ILInjected.Token(Token = "0x40056ED")]
		public const short DynastyBed = 2231;

		// Token: 0x040044A2 RID: 17570
		[global::Cpp2ILInjected.Token(Token = "0x40056EE")]
		public const short DynastyBathtub = 2232;

		// Token: 0x040044A3 RID: 17571
		[global::Cpp2ILInjected.Token(Token = "0x40056EF")]
		public const short DynastyBookcase = 2233;

		// Token: 0x040044A4 RID: 17572
		[global::Cpp2ILInjected.Token(Token = "0x40056F0")]
		public const short DynastyCup = 2234;

		// Token: 0x040044A5 RID: 17573
		[global::Cpp2ILInjected.Token(Token = "0x40056F1")]
		public const short DynastyBowl = 2235;

		// Token: 0x040044A6 RID: 17574
		[global::Cpp2ILInjected.Token(Token = "0x40056F2")]
		public const short DynastyCandle = 2236;

		// Token: 0x040044A7 RID: 17575
		[global::Cpp2ILInjected.Token(Token = "0x40056F3")]
		public const short DynastyClock = 2237;

		// Token: 0x040044A8 RID: 17576
		[global::Cpp2ILInjected.Token(Token = "0x40056F4")]
		public const short GoldenClock = 2238;

		// Token: 0x040044A9 RID: 17577
		[global::Cpp2ILInjected.Token(Token = "0x40056F5")]
		public const short GlassClock = 2239;

		// Token: 0x040044AA RID: 17578
		[global::Cpp2ILInjected.Token(Token = "0x40056F6")]
		public const short HoneyClock = 2240;

		// Token: 0x040044AB RID: 17579
		[global::Cpp2ILInjected.Token(Token = "0x40056F7")]
		public const short SteampunkClock = 2241;

		// Token: 0x040044AC RID: 17580
		[global::Cpp2ILInjected.Token(Token = "0x40056F8")]
		public const short FancyDishes = 2242;

		// Token: 0x040044AD RID: 17581
		[global::Cpp2ILInjected.Token(Token = "0x40056F9")]
		public const short GlassBowl = 2243;

		// Token: 0x040044AE RID: 17582
		[global::Cpp2ILInjected.Token(Token = "0x40056FA")]
		public const short WineGlass = 2244;

		// Token: 0x040044AF RID: 17583
		[global::Cpp2ILInjected.Token(Token = "0x40056FB")]
		public const short LivingWoodPiano = 2245;

		// Token: 0x040044B0 RID: 17584
		[global::Cpp2ILInjected.Token(Token = "0x40056FC")]
		public const short FleshPiano = 2246;

		// Token: 0x040044B1 RID: 17585
		[global::Cpp2ILInjected.Token(Token = "0x40056FD")]
		public const short FrozenPiano = 2247;

		// Token: 0x040044B2 RID: 17586
		[global::Cpp2ILInjected.Token(Token = "0x40056FE")]
		public const short FrozenTable = 2248;

		// Token: 0x040044B3 RID: 17587
		[global::Cpp2ILInjected.Token(Token = "0x40056FF")]
		public const short HoneyChest = 2249;

		// Token: 0x040044B4 RID: 17588
		[global::Cpp2ILInjected.Token(Token = "0x4005700")]
		public const short SteampunkChest = 2250;

		// Token: 0x040044B5 RID: 17589
		[global::Cpp2ILInjected.Token(Token = "0x4005701")]
		public const short HoneyWorkBench = 2251;

		// Token: 0x040044B6 RID: 17590
		[global::Cpp2ILInjected.Token(Token = "0x4005702")]
		public const short FrozenWorkBench = 2252;

		// Token: 0x040044B7 RID: 17591
		[global::Cpp2ILInjected.Token(Token = "0x4005703")]
		public const short SteampunkWorkBench = 2253;

		// Token: 0x040044B8 RID: 17592
		[global::Cpp2ILInjected.Token(Token = "0x4005704")]
		public const short GlassPiano = 2254;

		// Token: 0x040044B9 RID: 17593
		[global::Cpp2ILInjected.Token(Token = "0x4005705")]
		public const short HoneyPiano = 2255;

		// Token: 0x040044BA RID: 17594
		[global::Cpp2ILInjected.Token(Token = "0x4005706")]
		public const short SteampunkPiano = 2256;

		// Token: 0x040044BB RID: 17595
		[global::Cpp2ILInjected.Token(Token = "0x4005707")]
		public const short HoneyCup = 2257;

		// Token: 0x040044BC RID: 17596
		[global::Cpp2ILInjected.Token(Token = "0x4005708")]
		public const short SteampunkCup = 2258;

		// Token: 0x040044BD RID: 17597
		[global::Cpp2ILInjected.Token(Token = "0x4005709")]
		public const short DynastyTable = 2259;

		// Token: 0x040044BE RID: 17598
		[global::Cpp2ILInjected.Token(Token = "0x400570A")]
		public const short DynastyWood = 2260;

		// Token: 0x040044BF RID: 17599
		[global::Cpp2ILInjected.Token(Token = "0x400570B")]
		public const short RedDynastyShingles = 2261;

		// Token: 0x040044C0 RID: 17600
		[global::Cpp2ILInjected.Token(Token = "0x400570C")]
		public const short BlueDynastyShingles = 2262;

		// Token: 0x040044C1 RID: 17601
		[global::Cpp2ILInjected.Token(Token = "0x400570D")]
		public const short WhiteDynastyWall = 2263;

		// Token: 0x040044C2 RID: 17602
		[global::Cpp2ILInjected.Token(Token = "0x400570E")]
		public const short BlueDynastyWall = 2264;

		// Token: 0x040044C3 RID: 17603
		[global::Cpp2ILInjected.Token(Token = "0x400570F")]
		public const short DynastyDoor = 2265;

		// Token: 0x040044C4 RID: 17604
		[global::Cpp2ILInjected.Token(Token = "0x4005710")]
		public const short Sake = 2266;

		// Token: 0x040044C5 RID: 17605
		[global::Cpp2ILInjected.Token(Token = "0x4005711")]
		public const short PadThai = 2267;

		// Token: 0x040044C6 RID: 17606
		[global::Cpp2ILInjected.Token(Token = "0x4005712")]
		public const short Pho = 2268;

		// Token: 0x040044C7 RID: 17607
		[global::Cpp2ILInjected.Token(Token = "0x4005713")]
		public const short Revolver = 2269;

		// Token: 0x040044C8 RID: 17608
		[global::Cpp2ILInjected.Token(Token = "0x4005714")]
		public const short Gatligator = 2270;

		// Token: 0x040044C9 RID: 17609
		[global::Cpp2ILInjected.Token(Token = "0x4005715")]
		public const short ArcaneRuneWall = 2271;

		// Token: 0x040044CA RID: 17610
		[global::Cpp2ILInjected.Token(Token = "0x4005716")]
		public const short WaterGun = 2272;

		// Token: 0x040044CB RID: 17611
		[global::Cpp2ILInjected.Token(Token = "0x4005717")]
		public const short Katana = 2273;

		// Token: 0x040044CC RID: 17612
		[global::Cpp2ILInjected.Token(Token = "0x4005718")]
		public const short UltrabrightTorch = 2274;

		// Token: 0x040044CD RID: 17613
		[global::Cpp2ILInjected.Token(Token = "0x4005719")]
		public const short MagicHat = 2275;

		// Token: 0x040044CE RID: 17614
		[global::Cpp2ILInjected.Token(Token = "0x400571A")]
		public const short DiamondRing = 2276;

		// Token: 0x040044CF RID: 17615
		[global::Cpp2ILInjected.Token(Token = "0x400571B")]
		public const short Gi = 2277;

		// Token: 0x040044D0 RID: 17616
		[global::Cpp2ILInjected.Token(Token = "0x400571C")]
		public const short Kimono = 2278;

		// Token: 0x040044D1 RID: 17617
		[global::Cpp2ILInjected.Token(Token = "0x400571D")]
		public const short GypsyRobe = 2279;

		// Token: 0x040044D2 RID: 17618
		[global::Cpp2ILInjected.Token(Token = "0x400571E")]
		public const short BeetleWings = 2280;

		// Token: 0x040044D3 RID: 17619
		[global::Cpp2ILInjected.Token(Token = "0x400571F")]
		public const short TigerSkin = 2281;

		// Token: 0x040044D4 RID: 17620
		[global::Cpp2ILInjected.Token(Token = "0x4005720")]
		public const short LeopardSkin = 2282;

		// Token: 0x040044D5 RID: 17621
		[global::Cpp2ILInjected.Token(Token = "0x4005721")]
		public const short ZebraSkin = 2283;

		// Token: 0x040044D6 RID: 17622
		[global::Cpp2ILInjected.Token(Token = "0x4005722")]
		public const short CrimsonCloak = 2284;

		// Token: 0x040044D7 RID: 17623
		[global::Cpp2ILInjected.Token(Token = "0x4005723")]
		public const short MysteriousCape = 2285;

		// Token: 0x040044D8 RID: 17624
		[global::Cpp2ILInjected.Token(Token = "0x4005724")]
		public const short RedCape = 2286;

		// Token: 0x040044D9 RID: 17625
		[global::Cpp2ILInjected.Token(Token = "0x4005725")]
		public const short WinterCape = 2287;

		// Token: 0x040044DA RID: 17626
		[global::Cpp2ILInjected.Token(Token = "0x4005726")]
		public const short FrozenChair = 2288;

		// Token: 0x040044DB RID: 17627
		[global::Cpp2ILInjected.Token(Token = "0x4005727")]
		public const short WoodFishingPole = 2289;

		// Token: 0x040044DC RID: 17628
		[global::Cpp2ILInjected.Token(Token = "0x4005728")]
		public const short Bass = 2290;

		// Token: 0x040044DD RID: 17629
		[global::Cpp2ILInjected.Token(Token = "0x4005729")]
		public const short ReinforcedFishingPole = 2291;

		// Token: 0x040044DE RID: 17630
		[global::Cpp2ILInjected.Token(Token = "0x400572A")]
		public const short FiberglassFishingPole = 2292;

		// Token: 0x040044DF RID: 17631
		[global::Cpp2ILInjected.Token(Token = "0x400572B")]
		public const short FisherofSouls = 2293;

		// Token: 0x040044E0 RID: 17632
		[global::Cpp2ILInjected.Token(Token = "0x400572C")]
		public const short GoldenFishingRod = 2294;

		// Token: 0x040044E1 RID: 17633
		[global::Cpp2ILInjected.Token(Token = "0x400572D")]
		public const short MechanicsRod = 2295;

		// Token: 0x040044E2 RID: 17634
		[global::Cpp2ILInjected.Token(Token = "0x400572E")]
		public const short SittingDucksFishingRod = 2296;

		// Token: 0x040044E3 RID: 17635
		[global::Cpp2ILInjected.Token(Token = "0x400572F")]
		public const short Trout = 2297;

		// Token: 0x040044E4 RID: 17636
		[global::Cpp2ILInjected.Token(Token = "0x4005730")]
		public const short Salmon = 2298;

		// Token: 0x040044E5 RID: 17637
		[global::Cpp2ILInjected.Token(Token = "0x4005731")]
		public const short AtlanticCod = 2299;

		// Token: 0x040044E6 RID: 17638
		[global::Cpp2ILInjected.Token(Token = "0x4005732")]
		public const short Tuna = 2300;

		// Token: 0x040044E7 RID: 17639
		[global::Cpp2ILInjected.Token(Token = "0x4005733")]
		public const short RedSnapper = 2301;

		// Token: 0x040044E8 RID: 17640
		[global::Cpp2ILInjected.Token(Token = "0x4005734")]
		public const short NeonTetra = 2302;

		// Token: 0x040044E9 RID: 17641
		[global::Cpp2ILInjected.Token(Token = "0x4005735")]
		public const short ArmoredCavefish = 2303;

		// Token: 0x040044EA RID: 17642
		[global::Cpp2ILInjected.Token(Token = "0x4005736")]
		public const short Damselfish = 2304;

		// Token: 0x040044EB RID: 17643
		[global::Cpp2ILInjected.Token(Token = "0x4005737")]
		public const short CrimsonTigerfish = 2305;

		// Token: 0x040044EC RID: 17644
		[global::Cpp2ILInjected.Token(Token = "0x4005738")]
		public const short FrostMinnow = 2306;

		// Token: 0x040044ED RID: 17645
		[global::Cpp2ILInjected.Token(Token = "0x4005739")]
		public const short PrincessFish = 2307;

		// Token: 0x040044EE RID: 17646
		[global::Cpp2ILInjected.Token(Token = "0x400573A")]
		public const short GoldenCarp = 2308;

		// Token: 0x040044EF RID: 17647
		[global::Cpp2ILInjected.Token(Token = "0x400573B")]
		public const short SpecularFish = 2309;

		// Token: 0x040044F0 RID: 17648
		[global::Cpp2ILInjected.Token(Token = "0x400573C")]
		public const short Prismite = 2310;

		// Token: 0x040044F1 RID: 17649
		[global::Cpp2ILInjected.Token(Token = "0x400573D")]
		public const short VariegatedLardfish = 2311;

		// Token: 0x040044F2 RID: 17650
		[global::Cpp2ILInjected.Token(Token = "0x400573E")]
		public const short FlarefinKoi = 2312;

		// Token: 0x040044F3 RID: 17651
		[global::Cpp2ILInjected.Token(Token = "0x400573F")]
		public const short DoubleCod = 2313;

		// Token: 0x040044F4 RID: 17652
		[global::Cpp2ILInjected.Token(Token = "0x4005740")]
		public const short Honeyfin = 2314;

		// Token: 0x040044F5 RID: 17653
		[global::Cpp2ILInjected.Token(Token = "0x4005741")]
		public const short Obsidifish = 2315;

		// Token: 0x040044F6 RID: 17654
		[global::Cpp2ILInjected.Token(Token = "0x4005742")]
		public const short Shrimp = 2316;

		// Token: 0x040044F7 RID: 17655
		[global::Cpp2ILInjected.Token(Token = "0x4005743")]
		public const short ChaosFish = 2317;

		// Token: 0x040044F8 RID: 17656
		[global::Cpp2ILInjected.Token(Token = "0x4005744")]
		public const short Ebonkoi = 2318;

		// Token: 0x040044F9 RID: 17657
		[global::Cpp2ILInjected.Token(Token = "0x4005745")]
		public const short Hemopiranha = 2319;

		// Token: 0x040044FA RID: 17658
		[global::Cpp2ILInjected.Token(Token = "0x4005746")]
		public const short Rockfish = 2320;

		// Token: 0x040044FB RID: 17659
		[global::Cpp2ILInjected.Token(Token = "0x4005747")]
		public const short Stinkfish = 2321;

		// Token: 0x040044FC RID: 17660
		[global::Cpp2ILInjected.Token(Token = "0x4005748")]
		public const short MiningPotion = 2322;

		// Token: 0x040044FD RID: 17661
		[global::Cpp2ILInjected.Token(Token = "0x4005749")]
		public const short HeartreachPotion = 2323;

		// Token: 0x040044FE RID: 17662
		[global::Cpp2ILInjected.Token(Token = "0x400574A")]
		public const short CalmingPotion = 2324;

		// Token: 0x040044FF RID: 17663
		[global::Cpp2ILInjected.Token(Token = "0x400574B")]
		public const short BuilderPotion = 2325;

		// Token: 0x04004500 RID: 17664
		[global::Cpp2ILInjected.Token(Token = "0x400574C")]
		public const short TitanPotion = 2326;

		// Token: 0x04004501 RID: 17665
		[global::Cpp2ILInjected.Token(Token = "0x400574D")]
		public const short FlipperPotion = 2327;

		// Token: 0x04004502 RID: 17666
		[global::Cpp2ILInjected.Token(Token = "0x400574E")]
		public const short SummoningPotion = 2328;

		// Token: 0x04004503 RID: 17667
		[global::Cpp2ILInjected.Token(Token = "0x400574F")]
		public const short TrapsightPotion = 2329;

		// Token: 0x04004504 RID: 17668
		[global::Cpp2ILInjected.Token(Token = "0x4005750")]
		public const short PurpleClubberfish = 2330;

		// Token: 0x04004505 RID: 17669
		[global::Cpp2ILInjected.Token(Token = "0x4005751")]
		public const short ObsidianSwordfish = 2331;

		// Token: 0x04004506 RID: 17670
		[global::Cpp2ILInjected.Token(Token = "0x4005752")]
		public const short Swordfish = 2332;

		// Token: 0x04004507 RID: 17671
		[global::Cpp2ILInjected.Token(Token = "0x4005753")]
		public const short IronFence = 2333;

		// Token: 0x04004508 RID: 17672
		[global::Cpp2ILInjected.Token(Token = "0x4005754")]
		public const short WoodenCrate = 2334;

		// Token: 0x04004509 RID: 17673
		[global::Cpp2ILInjected.Token(Token = "0x4005755")]
		public const short IronCrate = 2335;

		// Token: 0x0400450A RID: 17674
		[global::Cpp2ILInjected.Token(Token = "0x4005756")]
		public const short GoldenCrate = 2336;

		// Token: 0x0400450B RID: 17675
		[global::Cpp2ILInjected.Token(Token = "0x4005757")]
		public const short OldShoe = 2337;

		// Token: 0x0400450C RID: 17676
		[global::Cpp2ILInjected.Token(Token = "0x4005758")]
		public const short FishingSeaweed = 2338;

		// Token: 0x0400450D RID: 17677
		[global::Cpp2ILInjected.Token(Token = "0x4005759")]
		public const short TinCan = 2339;

		// Token: 0x0400450E RID: 17678
		[global::Cpp2ILInjected.Token(Token = "0x400575A")]
		public const short MinecartTrack = 2340;

		// Token: 0x0400450F RID: 17679
		[global::Cpp2ILInjected.Token(Token = "0x400575B")]
		public const short ReaverShark = 2341;

		// Token: 0x04004510 RID: 17680
		[global::Cpp2ILInjected.Token(Token = "0x400575C")]
		public const short SawtoothShark = 2342;

		// Token: 0x04004511 RID: 17681
		[global::Cpp2ILInjected.Token(Token = "0x400575D")]
		public const short Minecart = 2343;

		// Token: 0x04004512 RID: 17682
		[global::Cpp2ILInjected.Token(Token = "0x400575E")]
		public const short AmmoReservationPotion = 2344;

		// Token: 0x04004513 RID: 17683
		[global::Cpp2ILInjected.Token(Token = "0x400575F")]
		public const short LifeforcePotion = 2345;

		// Token: 0x04004514 RID: 17684
		[global::Cpp2ILInjected.Token(Token = "0x4005760")]
		public const short EndurancePotion = 2346;

		// Token: 0x04004515 RID: 17685
		[global::Cpp2ILInjected.Token(Token = "0x4005761")]
		public const short RagePotion = 2347;

		// Token: 0x04004516 RID: 17686
		[global::Cpp2ILInjected.Token(Token = "0x4005762")]
		public const short InfernoPotion = 2348;

		// Token: 0x04004517 RID: 17687
		[global::Cpp2ILInjected.Token(Token = "0x4005763")]
		public const short WrathPotion = 2349;

		// Token: 0x04004518 RID: 17688
		[global::Cpp2ILInjected.Token(Token = "0x4005764")]
		public const short RecallPotion = 2350;

		// Token: 0x04004519 RID: 17689
		[global::Cpp2ILInjected.Token(Token = "0x4005765")]
		public const short TeleportationPotion = 2351;

		// Token: 0x0400451A RID: 17690
		[global::Cpp2ILInjected.Token(Token = "0x4005766")]
		public const short LovePotion = 2352;

		// Token: 0x0400451B RID: 17691
		[global::Cpp2ILInjected.Token(Token = "0x4005767")]
		public const short StinkPotion = 2353;

		// Token: 0x0400451C RID: 17692
		[global::Cpp2ILInjected.Token(Token = "0x4005768")]
		public const short FishingPotion = 2354;

		// Token: 0x0400451D RID: 17693
		[global::Cpp2ILInjected.Token(Token = "0x4005769")]
		public const short SonarPotion = 2355;

		// Token: 0x0400451E RID: 17694
		[global::Cpp2ILInjected.Token(Token = "0x400576A")]
		public const short CratePotion = 2356;

		// Token: 0x0400451F RID: 17695
		[global::Cpp2ILInjected.Token(Token = "0x400576B")]
		public const short ShiverthornSeeds = 2357;

		// Token: 0x04004520 RID: 17696
		[global::Cpp2ILInjected.Token(Token = "0x400576C")]
		public const short Shiverthorn = 2358;

		// Token: 0x04004521 RID: 17697
		[global::Cpp2ILInjected.Token(Token = "0x400576D")]
		public const short WarmthPotion = 2359;

		// Token: 0x04004522 RID: 17698
		[global::Cpp2ILInjected.Token(Token = "0x400576E")]
		public const short FishHook = 2360;

		// Token: 0x04004523 RID: 17699
		[global::Cpp2ILInjected.Token(Token = "0x400576F")]
		public const short BeeHeadgear = 2361;

		// Token: 0x04004524 RID: 17700
		[global::Cpp2ILInjected.Token(Token = "0x4005770")]
		public const short BeeBreastplate = 2362;

		// Token: 0x04004525 RID: 17701
		[global::Cpp2ILInjected.Token(Token = "0x4005771")]
		public const short BeeGreaves = 2363;

		// Token: 0x04004526 RID: 17702
		[global::Cpp2ILInjected.Token(Token = "0x4005772")]
		public const short HornetStaff = 2364;

		// Token: 0x04004527 RID: 17703
		[global::Cpp2ILInjected.Token(Token = "0x4005773")]
		public const short ImpStaff = 2365;

		// Token: 0x04004528 RID: 17704
		[global::Cpp2ILInjected.Token(Token = "0x4005774")]
		public const short QueenSpiderStaff = 2366;

		// Token: 0x04004529 RID: 17705
		[global::Cpp2ILInjected.Token(Token = "0x4005775")]
		public const short AnglerHat = 2367;

		// Token: 0x0400452A RID: 17706
		[global::Cpp2ILInjected.Token(Token = "0x4005776")]
		public const short AnglerVest = 2368;

		// Token: 0x0400452B RID: 17707
		[global::Cpp2ILInjected.Token(Token = "0x4005777")]
		public const short AnglerPants = 2369;

		// Token: 0x0400452C RID: 17708
		[global::Cpp2ILInjected.Token(Token = "0x4005778")]
		public const short SpiderMask = 2370;

		// Token: 0x0400452D RID: 17709
		[global::Cpp2ILInjected.Token(Token = "0x4005779")]
		public const short SpiderBreastplate = 2371;

		// Token: 0x0400452E RID: 17710
		[global::Cpp2ILInjected.Token(Token = "0x400577A")]
		public const short SpiderGreaves = 2372;

		// Token: 0x0400452F RID: 17711
		[global::Cpp2ILInjected.Token(Token = "0x400577B")]
		public const short HighTestFishingLine = 2373;

		// Token: 0x04004530 RID: 17712
		[global::Cpp2ILInjected.Token(Token = "0x400577C")]
		public const short AnglerEarring = 2374;

		// Token: 0x04004531 RID: 17713
		[global::Cpp2ILInjected.Token(Token = "0x400577D")]
		public const short TackleBox = 2375;

		// Token: 0x04004532 RID: 17714
		[global::Cpp2ILInjected.Token(Token = "0x400577E")]
		public const short BlueDungeonPiano = 2376;

		// Token: 0x04004533 RID: 17715
		[global::Cpp2ILInjected.Token(Token = "0x400577F")]
		public const short GreenDungeonPiano = 2377;

		// Token: 0x04004534 RID: 17716
		[global::Cpp2ILInjected.Token(Token = "0x4005780")]
		public const short PinkDungeonPiano = 2378;

		// Token: 0x04004535 RID: 17717
		[global::Cpp2ILInjected.Token(Token = "0x4005781")]
		public const short GoldenPiano = 2379;

		// Token: 0x04004536 RID: 17718
		[global::Cpp2ILInjected.Token(Token = "0x4005782")]
		public const short ObsidianPiano = 2380;

		// Token: 0x04004537 RID: 17719
		[global::Cpp2ILInjected.Token(Token = "0x4005783")]
		public const short BonePiano = 2381;

		// Token: 0x04004538 RID: 17720
		[global::Cpp2ILInjected.Token(Token = "0x4005784")]
		public const short CactusPiano = 2382;

		// Token: 0x04004539 RID: 17721
		[global::Cpp2ILInjected.Token(Token = "0x4005785")]
		public const short SpookyPiano = 2383;

		// Token: 0x0400453A RID: 17722
		[global::Cpp2ILInjected.Token(Token = "0x4005786")]
		public const short SkywarePiano = 2384;

		// Token: 0x0400453B RID: 17723
		[global::Cpp2ILInjected.Token(Token = "0x4005787")]
		public const short LihzahrdPiano = 2385;

		// Token: 0x0400453C RID: 17724
		[global::Cpp2ILInjected.Token(Token = "0x4005788")]
		public const short BlueDungeonDresser = 2386;

		// Token: 0x0400453D RID: 17725
		[global::Cpp2ILInjected.Token(Token = "0x4005789")]
		public const short GreenDungeonDresser = 2387;

		// Token: 0x0400453E RID: 17726
		[global::Cpp2ILInjected.Token(Token = "0x400578A")]
		public const short PinkDungeonDresser = 2388;

		// Token: 0x0400453F RID: 17727
		[global::Cpp2ILInjected.Token(Token = "0x400578B")]
		public const short GoldenDresser = 2389;

		// Token: 0x04004540 RID: 17728
		[global::Cpp2ILInjected.Token(Token = "0x400578C")]
		public const short ObsidianDresser = 2390;

		// Token: 0x04004541 RID: 17729
		[global::Cpp2ILInjected.Token(Token = "0x400578D")]
		public const short BoneDresser = 2391;

		// Token: 0x04004542 RID: 17730
		[global::Cpp2ILInjected.Token(Token = "0x400578E")]
		public const short CactusDresser = 2392;

		// Token: 0x04004543 RID: 17731
		[global::Cpp2ILInjected.Token(Token = "0x400578F")]
		public const short SpookyDresser = 2393;

		// Token: 0x04004544 RID: 17732
		[global::Cpp2ILInjected.Token(Token = "0x4005790")]
		public const short SkywareDresser = 2394;

		// Token: 0x04004545 RID: 17733
		[global::Cpp2ILInjected.Token(Token = "0x4005791")]
		public const short HoneyDresser = 2395;

		// Token: 0x04004546 RID: 17734
		[global::Cpp2ILInjected.Token(Token = "0x4005792")]
		public const short LihzahrdDresser = 2396;

		// Token: 0x04004547 RID: 17735
		[global::Cpp2ILInjected.Token(Token = "0x4005793")]
		public const short Sofa = 2397;

		// Token: 0x04004548 RID: 17736
		[global::Cpp2ILInjected.Token(Token = "0x4005794")]
		public const short EbonwoodSofa = 2398;

		// Token: 0x04004549 RID: 17737
		[global::Cpp2ILInjected.Token(Token = "0x4005795")]
		public const short RichMahoganySofa = 2399;

		// Token: 0x0400454A RID: 17738
		[global::Cpp2ILInjected.Token(Token = "0x4005796")]
		public const short PearlwoodSofa = 2400;

		// Token: 0x0400454B RID: 17739
		[global::Cpp2ILInjected.Token(Token = "0x4005797")]
		public const short ShadewoodSofa = 2401;

		// Token: 0x0400454C RID: 17740
		[global::Cpp2ILInjected.Token(Token = "0x4005798")]
		public const short BlueDungeonSofa = 2402;

		// Token: 0x0400454D RID: 17741
		[global::Cpp2ILInjected.Token(Token = "0x4005799")]
		public const short GreenDungeonSofa = 2403;

		// Token: 0x0400454E RID: 17742
		[global::Cpp2ILInjected.Token(Token = "0x400579A")]
		public const short PinkDungeonSofa = 2404;

		// Token: 0x0400454F RID: 17743
		[global::Cpp2ILInjected.Token(Token = "0x400579B")]
		public const short GoldenSofa = 2405;

		// Token: 0x04004550 RID: 17744
		[global::Cpp2ILInjected.Token(Token = "0x400579C")]
		public const short ObsidianSofa = 2406;

		// Token: 0x04004551 RID: 17745
		[global::Cpp2ILInjected.Token(Token = "0x400579D")]
		public const short BoneSofa = 2407;

		// Token: 0x04004552 RID: 17746
		[global::Cpp2ILInjected.Token(Token = "0x400579E")]
		public const short CactusSofa = 2408;

		// Token: 0x04004553 RID: 17747
		[global::Cpp2ILInjected.Token(Token = "0x400579F")]
		public const short SpookySofa = 2409;

		// Token: 0x04004554 RID: 17748
		[global::Cpp2ILInjected.Token(Token = "0x40057A0")]
		public const short SkywareSofa = 2410;

		// Token: 0x04004555 RID: 17749
		[global::Cpp2ILInjected.Token(Token = "0x40057A1")]
		public const short HoneySofa = 2411;

		// Token: 0x04004556 RID: 17750
		[global::Cpp2ILInjected.Token(Token = "0x40057A2")]
		public const short SteampunkSofa = 2412;

		// Token: 0x04004557 RID: 17751
		[global::Cpp2ILInjected.Token(Token = "0x40057A3")]
		public const short MushroomSofa = 2413;

		// Token: 0x04004558 RID: 17752
		[global::Cpp2ILInjected.Token(Token = "0x40057A4")]
		public const short GlassSofa = 2414;

		// Token: 0x04004559 RID: 17753
		[global::Cpp2ILInjected.Token(Token = "0x40057A5")]
		public const short PumpkinSofa = 2415;

		// Token: 0x0400455A RID: 17754
		[global::Cpp2ILInjected.Token(Token = "0x40057A6")]
		public const short LihzahrdSofa = 2416;

		// Token: 0x0400455B RID: 17755
		[global::Cpp2ILInjected.Token(Token = "0x40057A7")]
		public const short SeashellHairpin = 2417;

		// Token: 0x0400455C RID: 17756
		[global::Cpp2ILInjected.Token(Token = "0x40057A8")]
		public const short MermaidAdornment = 2418;

		// Token: 0x0400455D RID: 17757
		[global::Cpp2ILInjected.Token(Token = "0x40057A9")]
		public const short MermaidTail = 2419;

		// Token: 0x0400455E RID: 17758
		[global::Cpp2ILInjected.Token(Token = "0x40057AA")]
		public const short ZephyrFish = 2420;

		// Token: 0x0400455F RID: 17759
		[global::Cpp2ILInjected.Token(Token = "0x40057AB")]
		public const short Fleshcatcher = 2421;

		// Token: 0x04004560 RID: 17760
		[global::Cpp2ILInjected.Token(Token = "0x40057AC")]
		public const short HotlineFishingHook = 2422;

		// Token: 0x04004561 RID: 17761
		[global::Cpp2ILInjected.Token(Token = "0x40057AD")]
		public const short FrogLeg = 2423;

		// Token: 0x04004562 RID: 17762
		[global::Cpp2ILInjected.Token(Token = "0x40057AE")]
		public const short Anchor = 2424;

		// Token: 0x04004563 RID: 17763
		[global::Cpp2ILInjected.Token(Token = "0x40057AF")]
		public const short CookedFish = 2425;

		// Token: 0x04004564 RID: 17764
		[global::Cpp2ILInjected.Token(Token = "0x40057B0")]
		public const short CookedShrimp = 2426;

		// Token: 0x04004565 RID: 17765
		[global::Cpp2ILInjected.Token(Token = "0x40057B1")]
		public const short Sashimi = 2427;

		// Token: 0x04004566 RID: 17766
		[global::Cpp2ILInjected.Token(Token = "0x40057B2")]
		public const short FuzzyCarrot = 2428;

		// Token: 0x04004567 RID: 17767
		[global::Cpp2ILInjected.Token(Token = "0x40057B3")]
		public const short ScalyTruffle = 2429;

		// Token: 0x04004568 RID: 17768
		[global::Cpp2ILInjected.Token(Token = "0x40057B4")]
		public const short SlimySaddle = 2430;

		// Token: 0x04004569 RID: 17769
		[global::Cpp2ILInjected.Token(Token = "0x40057B5")]
		public const short BeeWax = 2431;

		// Token: 0x0400456A RID: 17770
		[global::Cpp2ILInjected.Token(Token = "0x40057B6")]
		public const short CopperPlatingWall = 2432;

		// Token: 0x0400456B RID: 17771
		[global::Cpp2ILInjected.Token(Token = "0x40057B7")]
		public const short StoneSlabWall = 2433;

		// Token: 0x0400456C RID: 17772
		[global::Cpp2ILInjected.Token(Token = "0x40057B8")]
		public const short Sail = 2434;

		// Token: 0x0400456D RID: 17773
		[global::Cpp2ILInjected.Token(Token = "0x40057B9")]
		public const short CoralstoneBlock = 2435;

		// Token: 0x0400456E RID: 17774
		[global::Cpp2ILInjected.Token(Token = "0x40057BA")]
		public const short BlueJellyfish = 2436;

		// Token: 0x0400456F RID: 17775
		[global::Cpp2ILInjected.Token(Token = "0x40057BB")]
		public const short GreenJellyfish = 2437;

		// Token: 0x04004570 RID: 17776
		[global::Cpp2ILInjected.Token(Token = "0x40057BC")]
		public const short PinkJellyfish = 2438;

		// Token: 0x04004571 RID: 17777
		[global::Cpp2ILInjected.Token(Token = "0x40057BD")]
		public const short BlueJellyfishJar = 2439;

		// Token: 0x04004572 RID: 17778
		[global::Cpp2ILInjected.Token(Token = "0x40057BE")]
		public const short GreenJellyfishJar = 2440;

		// Token: 0x04004573 RID: 17779
		[global::Cpp2ILInjected.Token(Token = "0x40057BF")]
		public const short PinkJellyfishJar = 2441;

		// Token: 0x04004574 RID: 17780
		[global::Cpp2ILInjected.Token(Token = "0x40057C0")]
		public const short LifePreserver = 2442;

		// Token: 0x04004575 RID: 17781
		[global::Cpp2ILInjected.Token(Token = "0x40057C1")]
		public const short ShipsWheel = 2443;

		// Token: 0x04004576 RID: 17782
		[global::Cpp2ILInjected.Token(Token = "0x40057C2")]
		public const short CompassRose = 2444;

		// Token: 0x04004577 RID: 17783
		[global::Cpp2ILInjected.Token(Token = "0x40057C3")]
		public const short WallAnchor = 2445;

		// Token: 0x04004578 RID: 17784
		[global::Cpp2ILInjected.Token(Token = "0x40057C4")]
		public const short GoldfishTrophy = 2446;

		// Token: 0x04004579 RID: 17785
		[global::Cpp2ILInjected.Token(Token = "0x40057C5")]
		public const short BunnyfishTrophy = 2447;

		// Token: 0x0400457A RID: 17786
		[global::Cpp2ILInjected.Token(Token = "0x40057C6")]
		public const short SwordfishTrophy = 2448;

		// Token: 0x0400457B RID: 17787
		[global::Cpp2ILInjected.Token(Token = "0x40057C7")]
		public const short SharkteethTrophy = 2449;

		// Token: 0x0400457C RID: 17788
		[global::Cpp2ILInjected.Token(Token = "0x40057C8")]
		public const short Batfish = 2450;

		// Token: 0x0400457D RID: 17789
		[global::Cpp2ILInjected.Token(Token = "0x40057C9")]
		public const short BumblebeeTuna = 2451;

		// Token: 0x0400457E RID: 17790
		[global::Cpp2ILInjected.Token(Token = "0x40057CA")]
		public const short Catfish = 2452;

		// Token: 0x0400457F RID: 17791
		[global::Cpp2ILInjected.Token(Token = "0x40057CB")]
		public const short Cloudfish = 2453;

		// Token: 0x04004580 RID: 17792
		[global::Cpp2ILInjected.Token(Token = "0x40057CC")]
		public const short Cursedfish = 2454;

		// Token: 0x04004581 RID: 17793
		[global::Cpp2ILInjected.Token(Token = "0x40057CD")]
		public const short Dirtfish = 2455;

		// Token: 0x04004582 RID: 17794
		[global::Cpp2ILInjected.Token(Token = "0x40057CE")]
		public const short DynamiteFish = 2456;

		// Token: 0x04004583 RID: 17795
		[global::Cpp2ILInjected.Token(Token = "0x40057CF")]
		public const short EaterofPlankton = 2457;

		// Token: 0x04004584 RID: 17796
		[global::Cpp2ILInjected.Token(Token = "0x40057D0")]
		public const short FallenStarfish = 2458;

		// Token: 0x04004585 RID: 17797
		[global::Cpp2ILInjected.Token(Token = "0x40057D1")]
		public const short TheFishofCthulu = 2459;

		// Token: 0x04004586 RID: 17798
		[global::Cpp2ILInjected.Token(Token = "0x40057D2")]
		public const short Fishotron = 2460;

		// Token: 0x04004587 RID: 17799
		[global::Cpp2ILInjected.Token(Token = "0x40057D3")]
		public const short Harpyfish = 2461;

		// Token: 0x04004588 RID: 17800
		[global::Cpp2ILInjected.Token(Token = "0x40057D4")]
		public const short Hungerfish = 2462;

		// Token: 0x04004589 RID: 17801
		[global::Cpp2ILInjected.Token(Token = "0x40057D5")]
		public const short Ichorfish = 2463;

		// Token: 0x0400458A RID: 17802
		[global::Cpp2ILInjected.Token(Token = "0x40057D6")]
		public const short Jewelfish = 2464;

		// Token: 0x0400458B RID: 17803
		[global::Cpp2ILInjected.Token(Token = "0x40057D7")]
		public const short MirageFish = 2465;

		// Token: 0x0400458C RID: 17804
		[global::Cpp2ILInjected.Token(Token = "0x40057D8")]
		public const short MutantFlinxfin = 2466;

		// Token: 0x0400458D RID: 17805
		[global::Cpp2ILInjected.Token(Token = "0x40057D9")]
		public const short Pengfish = 2467;

		// Token: 0x0400458E RID: 17806
		[global::Cpp2ILInjected.Token(Token = "0x40057DA")]
		public const short Pixiefish = 2468;

		// Token: 0x0400458F RID: 17807
		[global::Cpp2ILInjected.Token(Token = "0x40057DB")]
		public const short Spiderfish = 2469;

		// Token: 0x04004590 RID: 17808
		[global::Cpp2ILInjected.Token(Token = "0x40057DC")]
		public const short TundraTrout = 2470;

		// Token: 0x04004591 RID: 17809
		[global::Cpp2ILInjected.Token(Token = "0x40057DD")]
		public const short UnicornFish = 2471;

		// Token: 0x04004592 RID: 17810
		[global::Cpp2ILInjected.Token(Token = "0x40057DE")]
		public const short GuideVoodooFish = 2472;

		// Token: 0x04004593 RID: 17811
		[global::Cpp2ILInjected.Token(Token = "0x40057DF")]
		public const short Wyverntail = 2473;

		// Token: 0x04004594 RID: 17812
		[global::Cpp2ILInjected.Token(Token = "0x40057E0")]
		public const short ZombieFish = 2474;

		// Token: 0x04004595 RID: 17813
		[global::Cpp2ILInjected.Token(Token = "0x40057E1")]
		public const short AmanitaFungifin = 2475;

		// Token: 0x04004596 RID: 17814
		[global::Cpp2ILInjected.Token(Token = "0x40057E2")]
		public const short Angelfish = 2476;

		// Token: 0x04004597 RID: 17815
		[global::Cpp2ILInjected.Token(Token = "0x40057E3")]
		public const short BloodyManowar = 2477;

		// Token: 0x04004598 RID: 17816
		[global::Cpp2ILInjected.Token(Token = "0x40057E4")]
		public const short Bonefish = 2478;

		// Token: 0x04004599 RID: 17817
		[global::Cpp2ILInjected.Token(Token = "0x40057E5")]
		public const short Bunnyfish = 2479;

		// Token: 0x0400459A RID: 17818
		[global::Cpp2ILInjected.Token(Token = "0x40057E6")]
		public const short CapnTunabeard = 2480;

		// Token: 0x0400459B RID: 17819
		[global::Cpp2ILInjected.Token(Token = "0x40057E7")]
		public const short Clownfish = 2481;

		// Token: 0x0400459C RID: 17820
		[global::Cpp2ILInjected.Token(Token = "0x40057E8")]
		public const short DemonicHellfish = 2482;

		// Token: 0x0400459D RID: 17821
		[global::Cpp2ILInjected.Token(Token = "0x40057E9")]
		public const short Derpfish = 2483;

		// Token: 0x0400459E RID: 17822
		[global::Cpp2ILInjected.Token(Token = "0x40057EA")]
		public const short Fishron = 2484;

		// Token: 0x0400459F RID: 17823
		[global::Cpp2ILInjected.Token(Token = "0x40057EB")]
		public const short InfectedScabbardfish = 2485;

		// Token: 0x040045A0 RID: 17824
		[global::Cpp2ILInjected.Token(Token = "0x40057EC")]
		public const short Mudfish = 2486;

		// Token: 0x040045A1 RID: 17825
		[global::Cpp2ILInjected.Token(Token = "0x40057ED")]
		public const short Slimefish = 2487;

		// Token: 0x040045A2 RID: 17826
		[global::Cpp2ILInjected.Token(Token = "0x40057EE")]
		public const short TropicalBarracuda = 2488;

		// Token: 0x040045A3 RID: 17827
		[global::Cpp2ILInjected.Token(Token = "0x40057EF")]
		public const short KingSlimeTrophy = 2489;

		// Token: 0x040045A4 RID: 17828
		[global::Cpp2ILInjected.Token(Token = "0x40057F0")]
		public const short ShipInABottle = 2490;

		// Token: 0x040045A5 RID: 17829
		[global::Cpp2ILInjected.Token(Token = "0x40057F1")]
		public const short HardySaddle = 2491;

		// Token: 0x040045A6 RID: 17830
		[global::Cpp2ILInjected.Token(Token = "0x40057F2")]
		public const short PressureTrack = 2492;

		// Token: 0x040045A7 RID: 17831
		[global::Cpp2ILInjected.Token(Token = "0x40057F3")]
		public const short KingSlimeMask = 2493;

		// Token: 0x040045A8 RID: 17832
		[global::Cpp2ILInjected.Token(Token = "0x40057F4")]
		public const short FinWings = 2494;

		// Token: 0x040045A9 RID: 17833
		[global::Cpp2ILInjected.Token(Token = "0x40057F5")]
		public const short TreasureMap = 2495;

		// Token: 0x040045AA RID: 17834
		[global::Cpp2ILInjected.Token(Token = "0x40057F6")]
		public const short SeaweedPlanter = 2496;

		// Token: 0x040045AB RID: 17835
		[global::Cpp2ILInjected.Token(Token = "0x40057F7")]
		public const short PillaginMePixels = 2497;

		// Token: 0x040045AC RID: 17836
		[global::Cpp2ILInjected.Token(Token = "0x40057F8")]
		public const short FishCostumeMask = 2498;

		// Token: 0x040045AD RID: 17837
		[global::Cpp2ILInjected.Token(Token = "0x40057F9")]
		public const short FishCostumeShirt = 2499;

		// Token: 0x040045AE RID: 17838
		[global::Cpp2ILInjected.Token(Token = "0x40057FA")]
		public const short FishCostumeFinskirt = 2500;

		// Token: 0x040045AF RID: 17839
		[global::Cpp2ILInjected.Token(Token = "0x40057FB")]
		public const short GingerBeard = 2501;

		// Token: 0x040045B0 RID: 17840
		[global::Cpp2ILInjected.Token(Token = "0x40057FC")]
		public const short HoneyedGoggles = 2502;

		// Token: 0x040045B1 RID: 17841
		[global::Cpp2ILInjected.Token(Token = "0x40057FD")]
		public const short BorealWood = 2503;

		// Token: 0x040045B2 RID: 17842
		[global::Cpp2ILInjected.Token(Token = "0x40057FE")]
		public const short PalmWood = 2504;

		// Token: 0x040045B3 RID: 17843
		[global::Cpp2ILInjected.Token(Token = "0x40057FF")]
		public const short BorealWoodWall = 2505;

		// Token: 0x040045B4 RID: 17844
		[global::Cpp2ILInjected.Token(Token = "0x4005800")]
		public const short PalmWoodWall = 2506;

		// Token: 0x040045B5 RID: 17845
		[global::Cpp2ILInjected.Token(Token = "0x4005801")]
		public const short BorealWoodFence = 2507;

		// Token: 0x040045B6 RID: 17846
		[global::Cpp2ILInjected.Token(Token = "0x4005802")]
		public const short PalmWoodFence = 2508;

		// Token: 0x040045B7 RID: 17847
		[global::Cpp2ILInjected.Token(Token = "0x4005803")]
		public const short BorealWoodHelmet = 2509;

		// Token: 0x040045B8 RID: 17848
		[global::Cpp2ILInjected.Token(Token = "0x4005804")]
		public const short BorealWoodBreastplate = 2510;

		// Token: 0x040045B9 RID: 17849
		[global::Cpp2ILInjected.Token(Token = "0x4005805")]
		public const short BorealWoodGreaves = 2511;

		// Token: 0x040045BA RID: 17850
		[global::Cpp2ILInjected.Token(Token = "0x4005806")]
		public const short PalmWoodHelmet = 2512;

		// Token: 0x040045BB RID: 17851
		[global::Cpp2ILInjected.Token(Token = "0x4005807")]
		public const short PalmWoodBreastplate = 2513;

		// Token: 0x040045BC RID: 17852
		[global::Cpp2ILInjected.Token(Token = "0x4005808")]
		public const short PalmWoodGreaves = 2514;

		// Token: 0x040045BD RID: 17853
		[global::Cpp2ILInjected.Token(Token = "0x4005809")]
		public const short PalmWoodBow = 2515;

		// Token: 0x040045BE RID: 17854
		[global::Cpp2ILInjected.Token(Token = "0x400580A")]
		public const short PalmWoodHammer = 2516;

		// Token: 0x040045BF RID: 17855
		[global::Cpp2ILInjected.Token(Token = "0x400580B")]
		public const short PalmWoodSword = 2517;

		// Token: 0x040045C0 RID: 17856
		[global::Cpp2ILInjected.Token(Token = "0x400580C")]
		public const short PalmWoodPlatform = 2518;

		// Token: 0x040045C1 RID: 17857
		[global::Cpp2ILInjected.Token(Token = "0x400580D")]
		public const short PalmWoodBathtub = 2519;

		// Token: 0x040045C2 RID: 17858
		[global::Cpp2ILInjected.Token(Token = "0x400580E")]
		public const short PalmWoodBed = 2520;

		// Token: 0x040045C3 RID: 17859
		[global::Cpp2ILInjected.Token(Token = "0x400580F")]
		public const short PalmWoodBench = 2521;

		// Token: 0x040045C4 RID: 17860
		[global::Cpp2ILInjected.Token(Token = "0x4005810")]
		public const short PalmWoodCandelabra = 2522;

		// Token: 0x040045C5 RID: 17861
		[global::Cpp2ILInjected.Token(Token = "0x4005811")]
		public const short PalmWoodCandle = 2523;

		// Token: 0x040045C6 RID: 17862
		[global::Cpp2ILInjected.Token(Token = "0x4005812")]
		public const short PalmWoodChair = 2524;

		// Token: 0x040045C7 RID: 17863
		[global::Cpp2ILInjected.Token(Token = "0x4005813")]
		public const short PalmWoodChandelier = 2525;

		// Token: 0x040045C8 RID: 17864
		[global::Cpp2ILInjected.Token(Token = "0x4005814")]
		public const short PalmWoodChest = 2526;

		// Token: 0x040045C9 RID: 17865
		[global::Cpp2ILInjected.Token(Token = "0x4005815")]
		public const short PalmWoodSofa = 2527;

		// Token: 0x040045CA RID: 17866
		[global::Cpp2ILInjected.Token(Token = "0x4005816")]
		public const short PalmWoodDoor = 2528;

		// Token: 0x040045CB RID: 17867
		[global::Cpp2ILInjected.Token(Token = "0x4005817")]
		public const short PalmWoodDresser = 2529;

		// Token: 0x040045CC RID: 17868
		[global::Cpp2ILInjected.Token(Token = "0x4005818")]
		public const short PalmWoodLantern = 2530;

		// Token: 0x040045CD RID: 17869
		[global::Cpp2ILInjected.Token(Token = "0x4005819")]
		public const short PalmWoodPiano = 2531;

		// Token: 0x040045CE RID: 17870
		[global::Cpp2ILInjected.Token(Token = "0x400581A")]
		public const short PalmWoodTable = 2532;

		// Token: 0x040045CF RID: 17871
		[global::Cpp2ILInjected.Token(Token = "0x400581B")]
		public const short PalmWoodLamp = 2533;

		// Token: 0x040045D0 RID: 17872
		[global::Cpp2ILInjected.Token(Token = "0x400581C")]
		public const short PalmWoodWorkBench = 2534;

		// Token: 0x040045D1 RID: 17873
		[global::Cpp2ILInjected.Token(Token = "0x400581D")]
		public const short OpticStaff = 2535;

		// Token: 0x040045D2 RID: 17874
		[global::Cpp2ILInjected.Token(Token = "0x400581E")]
		public const short PalmWoodBookcase = 2536;

		// Token: 0x040045D3 RID: 17875
		[global::Cpp2ILInjected.Token(Token = "0x400581F")]
		public const short MushroomBathtub = 2537;

		// Token: 0x040045D4 RID: 17876
		[global::Cpp2ILInjected.Token(Token = "0x4005820")]
		public const short MushroomBed = 2538;

		// Token: 0x040045D5 RID: 17877
		[global::Cpp2ILInjected.Token(Token = "0x4005821")]
		public const short MushroomBench = 2539;

		// Token: 0x040045D6 RID: 17878
		[global::Cpp2ILInjected.Token(Token = "0x4005822")]
		public const short MushroomBookcase = 2540;

		// Token: 0x040045D7 RID: 17879
		[global::Cpp2ILInjected.Token(Token = "0x4005823")]
		public const short MushroomCandelabra = 2541;

		// Token: 0x040045D8 RID: 17880
		[global::Cpp2ILInjected.Token(Token = "0x4005824")]
		public const short MushroomCandle = 2542;

		// Token: 0x040045D9 RID: 17881
		[global::Cpp2ILInjected.Token(Token = "0x4005825")]
		public const short MushroomChandelier = 2543;

		// Token: 0x040045DA RID: 17882
		[global::Cpp2ILInjected.Token(Token = "0x4005826")]
		public const short MushroomChest = 2544;

		// Token: 0x040045DB RID: 17883
		[global::Cpp2ILInjected.Token(Token = "0x4005827")]
		public const short MushroomDresser = 2545;

		// Token: 0x040045DC RID: 17884
		[global::Cpp2ILInjected.Token(Token = "0x4005828")]
		public const short MushroomLantern = 2546;

		// Token: 0x040045DD RID: 17885
		[global::Cpp2ILInjected.Token(Token = "0x4005829")]
		public const short MushroomLamp = 2547;

		// Token: 0x040045DE RID: 17886
		[global::Cpp2ILInjected.Token(Token = "0x400582A")]
		public const short MushroomPiano = 2548;

		// Token: 0x040045DF RID: 17887
		[global::Cpp2ILInjected.Token(Token = "0x400582B")]
		public const short MushroomPlatform = 2549;

		// Token: 0x040045E0 RID: 17888
		[global::Cpp2ILInjected.Token(Token = "0x400582C")]
		public const short MushroomTable = 2550;

		// Token: 0x040045E1 RID: 17889
		[global::Cpp2ILInjected.Token(Token = "0x400582D")]
		public const short SpiderStaff = 2551;

		// Token: 0x040045E2 RID: 17890
		[global::Cpp2ILInjected.Token(Token = "0x400582E")]
		public const short BorealWoodBathtub = 2552;

		// Token: 0x040045E3 RID: 17891
		[global::Cpp2ILInjected.Token(Token = "0x400582F")]
		public const short BorealWoodBed = 2553;

		// Token: 0x040045E4 RID: 17892
		[global::Cpp2ILInjected.Token(Token = "0x4005830")]
		public const short BorealWoodBookcase = 2554;

		// Token: 0x040045E5 RID: 17893
		[global::Cpp2ILInjected.Token(Token = "0x4005831")]
		public const short BorealWoodCandelabra = 2555;

		// Token: 0x040045E6 RID: 17894
		[global::Cpp2ILInjected.Token(Token = "0x4005832")]
		public const short BorealWoodCandle = 2556;

		// Token: 0x040045E7 RID: 17895
		[global::Cpp2ILInjected.Token(Token = "0x4005833")]
		public const short BorealWoodChair = 2557;

		// Token: 0x040045E8 RID: 17896
		[global::Cpp2ILInjected.Token(Token = "0x4005834")]
		public const short BorealWoodChandelier = 2558;

		// Token: 0x040045E9 RID: 17897
		[global::Cpp2ILInjected.Token(Token = "0x4005835")]
		public const short BorealWoodChest = 2559;

		// Token: 0x040045EA RID: 17898
		[global::Cpp2ILInjected.Token(Token = "0x4005836")]
		public const short BorealWoodClock = 2560;

		// Token: 0x040045EB RID: 17899
		[global::Cpp2ILInjected.Token(Token = "0x4005837")]
		public const short BorealWoodDoor = 2561;

		// Token: 0x040045EC RID: 17900
		[global::Cpp2ILInjected.Token(Token = "0x4005838")]
		public const short BorealWoodDresser = 2562;

		// Token: 0x040045ED RID: 17901
		[global::Cpp2ILInjected.Token(Token = "0x4005839")]
		public const short BorealWoodLamp = 2563;

		// Token: 0x040045EE RID: 17902
		[global::Cpp2ILInjected.Token(Token = "0x400583A")]
		public const short BorealWoodLantern = 2564;

		// Token: 0x040045EF RID: 17903
		[global::Cpp2ILInjected.Token(Token = "0x400583B")]
		public const short BorealWoodPiano = 2565;

		// Token: 0x040045F0 RID: 17904
		[global::Cpp2ILInjected.Token(Token = "0x400583C")]
		public const short BorealWoodPlatform = 2566;

		// Token: 0x040045F1 RID: 17905
		[global::Cpp2ILInjected.Token(Token = "0x400583D")]
		public const short SlimeBathtub = 2567;

		// Token: 0x040045F2 RID: 17906
		[global::Cpp2ILInjected.Token(Token = "0x400583E")]
		public const short SlimeBed = 2568;

		// Token: 0x040045F3 RID: 17907
		[global::Cpp2ILInjected.Token(Token = "0x400583F")]
		public const short SlimeBookcase = 2569;

		// Token: 0x040045F4 RID: 17908
		[global::Cpp2ILInjected.Token(Token = "0x4005840")]
		public const short SlimeCandelabra = 2570;

		// Token: 0x040045F5 RID: 17909
		[global::Cpp2ILInjected.Token(Token = "0x4005841")]
		public const short SlimeCandle = 2571;

		// Token: 0x040045F6 RID: 17910
		[global::Cpp2ILInjected.Token(Token = "0x4005842")]
		public const short SlimeChair = 2572;

		// Token: 0x040045F7 RID: 17911
		[global::Cpp2ILInjected.Token(Token = "0x4005843")]
		public const short SlimeChandelier = 2573;

		// Token: 0x040045F8 RID: 17912
		[global::Cpp2ILInjected.Token(Token = "0x4005844")]
		public const short SlimeChest = 2574;

		// Token: 0x040045F9 RID: 17913
		[global::Cpp2ILInjected.Token(Token = "0x4005845")]
		public const short SlimeClock = 2575;

		// Token: 0x040045FA RID: 17914
		[global::Cpp2ILInjected.Token(Token = "0x4005846")]
		public const short SlimeDoor = 2576;

		// Token: 0x040045FB RID: 17915
		[global::Cpp2ILInjected.Token(Token = "0x4005847")]
		public const short SlimeDresser = 2577;

		// Token: 0x040045FC RID: 17916
		[global::Cpp2ILInjected.Token(Token = "0x4005848")]
		public const short SlimeLamp = 2578;

		// Token: 0x040045FD RID: 17917
		[global::Cpp2ILInjected.Token(Token = "0x4005849")]
		public const short SlimeLantern = 2579;

		// Token: 0x040045FE RID: 17918
		[global::Cpp2ILInjected.Token(Token = "0x400584A")]
		public const short SlimePiano = 2580;

		// Token: 0x040045FF RID: 17919
		[global::Cpp2ILInjected.Token(Token = "0x400584B")]
		public const short SlimePlatform = 2581;

		// Token: 0x04004600 RID: 17920
		[global::Cpp2ILInjected.Token(Token = "0x400584C")]
		public const short SlimeSofa = 2582;

		// Token: 0x04004601 RID: 17921
		[global::Cpp2ILInjected.Token(Token = "0x400584D")]
		public const short SlimeTable = 2583;

		// Token: 0x04004602 RID: 17922
		[global::Cpp2ILInjected.Token(Token = "0x400584E")]
		public const short PirateStaff = 2584;

		// Token: 0x04004603 RID: 17923
		[global::Cpp2ILInjected.Token(Token = "0x400584F")]
		public const short SlimeHook = 2585;

		// Token: 0x04004604 RID: 17924
		[global::Cpp2ILInjected.Token(Token = "0x4005850")]
		public const short StickyGrenade = 2586;

		// Token: 0x04004605 RID: 17925
		[global::Cpp2ILInjected.Token(Token = "0x4005851")]
		public const short TartarSauce = 2587;

		// Token: 0x04004606 RID: 17926
		[global::Cpp2ILInjected.Token(Token = "0x4005852")]
		public const short DukeFishronMask = 2588;

		// Token: 0x04004607 RID: 17927
		[global::Cpp2ILInjected.Token(Token = "0x4005853")]
		public const short DukeFishronTrophy = 2589;

		// Token: 0x04004608 RID: 17928
		[global::Cpp2ILInjected.Token(Token = "0x4005854")]
		public const short MolotovCocktail = 2590;

		// Token: 0x04004609 RID: 17929
		[global::Cpp2ILInjected.Token(Token = "0x4005855")]
		public const short BoneClock = 2591;

		// Token: 0x0400460A RID: 17930
		[global::Cpp2ILInjected.Token(Token = "0x4005856")]
		public const short CactusClock = 2592;

		// Token: 0x0400460B RID: 17931
		[global::Cpp2ILInjected.Token(Token = "0x4005857")]
		public const short EbonwoodClock = 2593;

		// Token: 0x0400460C RID: 17932
		[global::Cpp2ILInjected.Token(Token = "0x4005858")]
		public const short FrozenClock = 2594;

		// Token: 0x0400460D RID: 17933
		[global::Cpp2ILInjected.Token(Token = "0x4005859")]
		public const short LihzahrdClock = 2595;

		// Token: 0x0400460E RID: 17934
		[global::Cpp2ILInjected.Token(Token = "0x400585A")]
		public const short LivingWoodClock = 2596;

		// Token: 0x0400460F RID: 17935
		[global::Cpp2ILInjected.Token(Token = "0x400585B")]
		public const short RichMahoganyClock = 2597;

		// Token: 0x04004610 RID: 17936
		[global::Cpp2ILInjected.Token(Token = "0x400585C")]
		public const short FleshClock = 2598;

		// Token: 0x04004611 RID: 17937
		[global::Cpp2ILInjected.Token(Token = "0x400585D")]
		public const short MushroomClock = 2599;

		// Token: 0x04004612 RID: 17938
		[global::Cpp2ILInjected.Token(Token = "0x400585E")]
		public const short ObsidianClock = 2600;

		// Token: 0x04004613 RID: 17939
		[global::Cpp2ILInjected.Token(Token = "0x400585F")]
		public const short PalmWoodClock = 2601;

		// Token: 0x04004614 RID: 17940
		[global::Cpp2ILInjected.Token(Token = "0x4005860")]
		public const short PearlwoodClock = 2602;

		// Token: 0x04004615 RID: 17941
		[global::Cpp2ILInjected.Token(Token = "0x4005861")]
		public const short PumpkinClock = 2603;

		// Token: 0x04004616 RID: 17942
		[global::Cpp2ILInjected.Token(Token = "0x4005862")]
		public const short ShadewoodClock = 2604;

		// Token: 0x04004617 RID: 17943
		[global::Cpp2ILInjected.Token(Token = "0x4005863")]
		public const short SpookyClock = 2605;

		// Token: 0x04004618 RID: 17944
		[global::Cpp2ILInjected.Token(Token = "0x4005864")]
		public const short SkywareClock = 2606;

		// Token: 0x04004619 RID: 17945
		[global::Cpp2ILInjected.Token(Token = "0x4005865")]
		public const short SpiderFang = 2607;

		// Token: 0x0400461A RID: 17946
		[global::Cpp2ILInjected.Token(Token = "0x4005866")]
		public const short FalconBlade = 2608;

		// Token: 0x0400461B RID: 17947
		[global::Cpp2ILInjected.Token(Token = "0x4005867")]
		public const short FishronWings = 2609;

		// Token: 0x0400461C RID: 17948
		[global::Cpp2ILInjected.Token(Token = "0x4005868")]
		public const short SlimeGun = 2610;

		// Token: 0x0400461D RID: 17949
		[global::Cpp2ILInjected.Token(Token = "0x4005869")]
		public const short Flairon = 2611;

		// Token: 0x0400461E RID: 17950
		[global::Cpp2ILInjected.Token(Token = "0x400586A")]
		public const short GreenDungeonChest = 2612;

		// Token: 0x0400461F RID: 17951
		[global::Cpp2ILInjected.Token(Token = "0x400586B")]
		public const short PinkDungeonChest = 2613;

		// Token: 0x04004620 RID: 17952
		[global::Cpp2ILInjected.Token(Token = "0x400586C")]
		public const short BlueDungeonChest = 2614;

		// Token: 0x04004621 RID: 17953
		[global::Cpp2ILInjected.Token(Token = "0x400586D")]
		public const short BoneChest = 2615;

		// Token: 0x04004622 RID: 17954
		[global::Cpp2ILInjected.Token(Token = "0x400586E")]
		public const short CactusChest = 2616;

		// Token: 0x04004623 RID: 17955
		[global::Cpp2ILInjected.Token(Token = "0x400586F")]
		public const short FleshChest = 2617;

		// Token: 0x04004624 RID: 17956
		[global::Cpp2ILInjected.Token(Token = "0x4005870")]
		public const short ObsidianChest = 2618;

		// Token: 0x04004625 RID: 17957
		[global::Cpp2ILInjected.Token(Token = "0x4005871")]
		public const short PumpkinChest = 2619;

		// Token: 0x04004626 RID: 17958
		[global::Cpp2ILInjected.Token(Token = "0x4005872")]
		public const short SpookyChest = 2620;

		// Token: 0x04004627 RID: 17959
		[global::Cpp2ILInjected.Token(Token = "0x4005873")]
		public const short TempestStaff = 2621;

		// Token: 0x04004628 RID: 17960
		[global::Cpp2ILInjected.Token(Token = "0x4005874")]
		public const short RazorbladeTyphoon = 2622;

		// Token: 0x04004629 RID: 17961
		[global::Cpp2ILInjected.Token(Token = "0x4005875")]
		public const short BubbleGun = 2623;

		// Token: 0x0400462A RID: 17962
		[global::Cpp2ILInjected.Token(Token = "0x4005876")]
		public const short Tsunami = 2624;

		// Token: 0x0400462B RID: 17963
		[global::Cpp2ILInjected.Token(Token = "0x4005877")]
		public const short Seashell = 2625;

		// Token: 0x0400462C RID: 17964
		[global::Cpp2ILInjected.Token(Token = "0x4005878")]
		public const short Starfish = 2626;

		// Token: 0x0400462D RID: 17965
		[global::Cpp2ILInjected.Token(Token = "0x4005879")]
		public const short SteampunkPlatform = 2627;

		// Token: 0x0400462E RID: 17966
		[global::Cpp2ILInjected.Token(Token = "0x400587A")]
		public const short SkywarePlatform = 2628;

		// Token: 0x0400462F RID: 17967
		[global::Cpp2ILInjected.Token(Token = "0x400587B")]
		public const short LivingWoodPlatform = 2629;

		// Token: 0x04004630 RID: 17968
		[global::Cpp2ILInjected.Token(Token = "0x400587C")]
		public const short HoneyPlatform = 2630;

		// Token: 0x04004631 RID: 17969
		[global::Cpp2ILInjected.Token(Token = "0x400587D")]
		public const short SkywareWorkbench = 2631;

		// Token: 0x04004632 RID: 17970
		[global::Cpp2ILInjected.Token(Token = "0x400587E")]
		public const short GlassWorkBench = 2632;

		// Token: 0x04004633 RID: 17971
		[global::Cpp2ILInjected.Token(Token = "0x400587F")]
		public const short LivingWoodWorkBench = 2633;

		// Token: 0x04004634 RID: 17972
		[global::Cpp2ILInjected.Token(Token = "0x4005880")]
		public const short FleshSofa = 2634;

		// Token: 0x04004635 RID: 17973
		[global::Cpp2ILInjected.Token(Token = "0x4005881")]
		public const short FrozenSofa = 2635;

		// Token: 0x04004636 RID: 17974
		[global::Cpp2ILInjected.Token(Token = "0x4005882")]
		public const short LivingWoodSofa = 2636;

		// Token: 0x04004637 RID: 17975
		[global::Cpp2ILInjected.Token(Token = "0x4005883")]
		public const short PumpkinDresser = 2637;

		// Token: 0x04004638 RID: 17976
		[global::Cpp2ILInjected.Token(Token = "0x4005884")]
		public const short SteampunkDresser = 2638;

		// Token: 0x04004639 RID: 17977
		[global::Cpp2ILInjected.Token(Token = "0x4005885")]
		public const short GlassDresser = 2639;

		// Token: 0x0400463A RID: 17978
		[global::Cpp2ILInjected.Token(Token = "0x4005886")]
		public const short FleshDresser = 2640;

		// Token: 0x0400463B RID: 17979
		[global::Cpp2ILInjected.Token(Token = "0x4005887")]
		public const short PumpkinLantern = 2641;

		// Token: 0x0400463C RID: 17980
		[global::Cpp2ILInjected.Token(Token = "0x4005888")]
		public const short ObsidianLantern = 2642;

		// Token: 0x0400463D RID: 17981
		[global::Cpp2ILInjected.Token(Token = "0x4005889")]
		public const short PumpkinLamp = 2643;

		// Token: 0x0400463E RID: 17982
		[global::Cpp2ILInjected.Token(Token = "0x400588A")]
		public const short ObsidianLamp = 2644;

		// Token: 0x0400463F RID: 17983
		[global::Cpp2ILInjected.Token(Token = "0x400588B")]
		public const short BlueDungeonLamp = 2645;

		// Token: 0x04004640 RID: 17984
		[global::Cpp2ILInjected.Token(Token = "0x400588C")]
		public const short GreenDungeonLamp = 2646;

		// Token: 0x04004641 RID: 17985
		[global::Cpp2ILInjected.Token(Token = "0x400588D")]
		public const short PinkDungeonLamp = 2647;

		// Token: 0x04004642 RID: 17986
		[global::Cpp2ILInjected.Token(Token = "0x400588E")]
		public const short HoneyCandle = 2648;

		// Token: 0x04004643 RID: 17987
		[global::Cpp2ILInjected.Token(Token = "0x400588F")]
		public const short SteampunkCandle = 2649;

		// Token: 0x04004644 RID: 17988
		[global::Cpp2ILInjected.Token(Token = "0x4005890")]
		public const short SpookyCandle = 2650;

		// Token: 0x04004645 RID: 17989
		[global::Cpp2ILInjected.Token(Token = "0x4005891")]
		public const short ObsidianCandle = 2651;

		// Token: 0x04004646 RID: 17990
		[global::Cpp2ILInjected.Token(Token = "0x4005892")]
		public const short BlueDungeonChandelier = 2652;

		// Token: 0x04004647 RID: 17991
		[global::Cpp2ILInjected.Token(Token = "0x4005893")]
		public const short GreenDungeonChandelier = 2653;

		// Token: 0x04004648 RID: 17992
		[global::Cpp2ILInjected.Token(Token = "0x4005894")]
		public const short PinkDungeonChandelier = 2654;

		// Token: 0x04004649 RID: 17993
		[global::Cpp2ILInjected.Token(Token = "0x4005895")]
		public const short SteampunkChandelier = 2655;

		// Token: 0x0400464A RID: 17994
		[global::Cpp2ILInjected.Token(Token = "0x4005896")]
		public const short PumpkinChandelier = 2656;

		// Token: 0x0400464B RID: 17995
		[global::Cpp2ILInjected.Token(Token = "0x4005897")]
		public const short ObsidianChandelier = 2657;

		// Token: 0x0400464C RID: 17996
		[global::Cpp2ILInjected.Token(Token = "0x4005898")]
		public const short BlueDungeonBathtub = 2658;

		// Token: 0x0400464D RID: 17997
		[global::Cpp2ILInjected.Token(Token = "0x4005899")]
		public const short GreenDungeonBathtub = 2659;

		// Token: 0x0400464E RID: 17998
		[global::Cpp2ILInjected.Token(Token = "0x400589A")]
		public const short PinkDungeonBathtub = 2660;

		// Token: 0x0400464F RID: 17999
		[global::Cpp2ILInjected.Token(Token = "0x400589B")]
		public const short PumpkinBathtub = 2661;

		// Token: 0x04004650 RID: 18000
		[global::Cpp2ILInjected.Token(Token = "0x400589C")]
		public const short ObsidianBathtub = 2662;

		// Token: 0x04004651 RID: 18001
		[global::Cpp2ILInjected.Token(Token = "0x400589D")]
		public const short GoldenBathtub = 2663;

		// Token: 0x04004652 RID: 18002
		[global::Cpp2ILInjected.Token(Token = "0x400589E")]
		public const short BlueDungeonCandelabra = 2664;

		// Token: 0x04004653 RID: 18003
		[global::Cpp2ILInjected.Token(Token = "0x400589F")]
		public const short GreenDungeonCandelabra = 2665;

		// Token: 0x04004654 RID: 18004
		[global::Cpp2ILInjected.Token(Token = "0x40058A0")]
		public const short PinkDungeonCandelabra = 2666;

		// Token: 0x04004655 RID: 18005
		[global::Cpp2ILInjected.Token(Token = "0x40058A1")]
		public const short ObsidianCandelabra = 2667;

		// Token: 0x04004656 RID: 18006
		[global::Cpp2ILInjected.Token(Token = "0x40058A2")]
		public const short PumpkinCandelabra = 2668;

		// Token: 0x04004657 RID: 18007
		[global::Cpp2ILInjected.Token(Token = "0x40058A3")]
		public const short PumpkinBed = 2669;

		// Token: 0x04004658 RID: 18008
		[global::Cpp2ILInjected.Token(Token = "0x40058A4")]
		public const short PumpkinBookcase = 2670;

		// Token: 0x04004659 RID: 18009
		[global::Cpp2ILInjected.Token(Token = "0x40058A5")]
		public const short PumpkinPiano = 2671;

		// Token: 0x0400465A RID: 18010
		[global::Cpp2ILInjected.Token(Token = "0x40058A6")]
		public const short SharkStatue = 2672;

		// Token: 0x0400465B RID: 18011
		[global::Cpp2ILInjected.Token(Token = "0x40058A7")]
		public const short TruffleWorm = 2673;

		// Token: 0x0400465C RID: 18012
		[global::Cpp2ILInjected.Token(Token = "0x40058A8")]
		public const short ApprenticeBait = 2674;

		// Token: 0x0400465D RID: 18013
		[global::Cpp2ILInjected.Token(Token = "0x40058A9")]
		public const short JourneymanBait = 2675;

		// Token: 0x0400465E RID: 18014
		[global::Cpp2ILInjected.Token(Token = "0x40058AA")]
		public const short MasterBait = 2676;

		// Token: 0x0400465F RID: 18015
		[global::Cpp2ILInjected.Token(Token = "0x40058AB")]
		public const short AmberGemsparkWall = 2677;

		// Token: 0x04004660 RID: 18016
		[global::Cpp2ILInjected.Token(Token = "0x40058AC")]
		public const short AmberGemsparkWallOff = 2678;

		// Token: 0x04004661 RID: 18017
		[global::Cpp2ILInjected.Token(Token = "0x40058AD")]
		public const short AmethystGemsparkWall = 2679;

		// Token: 0x04004662 RID: 18018
		[global::Cpp2ILInjected.Token(Token = "0x40058AE")]
		public const short AmethystGemsparkWallOff = 2680;

		// Token: 0x04004663 RID: 18019
		[global::Cpp2ILInjected.Token(Token = "0x40058AF")]
		public const short DiamondGemsparkWall = 2681;

		// Token: 0x04004664 RID: 18020
		[global::Cpp2ILInjected.Token(Token = "0x40058B0")]
		public const short DiamondGemsparkWallOff = 2682;

		// Token: 0x04004665 RID: 18021
		[global::Cpp2ILInjected.Token(Token = "0x40058B1")]
		public const short EmeraldGemsparkWall = 2683;

		// Token: 0x04004666 RID: 18022
		[global::Cpp2ILInjected.Token(Token = "0x40058B2")]
		public const short EmeraldGemsparkWallOff = 2684;

		// Token: 0x04004667 RID: 18023
		[global::Cpp2ILInjected.Token(Token = "0x40058B3")]
		public const short RubyGemsparkWall = 2685;

		// Token: 0x04004668 RID: 18024
		[global::Cpp2ILInjected.Token(Token = "0x40058B4")]
		public const short RubyGemsparkWallOff = 2686;

		// Token: 0x04004669 RID: 18025
		[global::Cpp2ILInjected.Token(Token = "0x40058B5")]
		public const short SapphireGemsparkWall = 2687;

		// Token: 0x0400466A RID: 18026
		[global::Cpp2ILInjected.Token(Token = "0x40058B6")]
		public const short SapphireGemsparkWallOff = 2688;

		// Token: 0x0400466B RID: 18027
		[global::Cpp2ILInjected.Token(Token = "0x40058B7")]
		public const short TopazGemsparkWall = 2689;

		// Token: 0x0400466C RID: 18028
		[global::Cpp2ILInjected.Token(Token = "0x40058B8")]
		public const short TopazGemsparkWallOff = 2690;

		// Token: 0x0400466D RID: 18029
		[global::Cpp2ILInjected.Token(Token = "0x40058B9")]
		public const short TinPlatingWall = 2691;

		// Token: 0x0400466E RID: 18030
		[global::Cpp2ILInjected.Token(Token = "0x40058BA")]
		public const short TinPlating = 2692;

		// Token: 0x0400466F RID: 18031
		[global::Cpp2ILInjected.Token(Token = "0x40058BB")]
		public const short WaterfallBlock = 2693;

		// Token: 0x04004670 RID: 18032
		[global::Cpp2ILInjected.Token(Token = "0x40058BC")]
		public const short LavafallBlock = 2694;

		// Token: 0x04004671 RID: 18033
		[global::Cpp2ILInjected.Token(Token = "0x40058BD")]
		public const short ConfettiBlock = 2695;

		// Token: 0x04004672 RID: 18034
		[global::Cpp2ILInjected.Token(Token = "0x40058BE")]
		public const short ConfettiWall = 2696;

		// Token: 0x04004673 RID: 18035
		[global::Cpp2ILInjected.Token(Token = "0x40058BF")]
		public const short ConfettiBlockBlack = 2697;

		// Token: 0x04004674 RID: 18036
		[global::Cpp2ILInjected.Token(Token = "0x40058C0")]
		public const short ConfettiWallBlack = 2698;

		// Token: 0x04004675 RID: 18037
		[global::Cpp2ILInjected.Token(Token = "0x40058C1")]
		public const short WeaponRack = 2699;

		// Token: 0x04004676 RID: 18038
		[global::Cpp2ILInjected.Token(Token = "0x40058C2")]
		public const short FireworksBox = 2700;

		// Token: 0x04004677 RID: 18039
		[global::Cpp2ILInjected.Token(Token = "0x40058C3")]
		public const short LivingFireBlock = 2701;

		// Token: 0x04004678 RID: 18040
		[global::Cpp2ILInjected.Token(Token = "0x40058C4")]
		public const short AlphabetStatue0 = 2702;

		// Token: 0x04004679 RID: 18041
		[global::Cpp2ILInjected.Token(Token = "0x40058C5")]
		public const short AlphabetStatue1 = 2703;

		// Token: 0x0400467A RID: 18042
		[global::Cpp2ILInjected.Token(Token = "0x40058C6")]
		public const short AlphabetStatue2 = 2704;

		// Token: 0x0400467B RID: 18043
		[global::Cpp2ILInjected.Token(Token = "0x40058C7")]
		public const short AlphabetStatue3 = 2705;

		// Token: 0x0400467C RID: 18044
		[global::Cpp2ILInjected.Token(Token = "0x40058C8")]
		public const short AlphabetStatue4 = 2706;

		// Token: 0x0400467D RID: 18045
		[global::Cpp2ILInjected.Token(Token = "0x40058C9")]
		public const short AlphabetStatue5 = 2707;

		// Token: 0x0400467E RID: 18046
		[global::Cpp2ILInjected.Token(Token = "0x40058CA")]
		public const short AlphabetStatue6 = 2708;

		// Token: 0x0400467F RID: 18047
		[global::Cpp2ILInjected.Token(Token = "0x40058CB")]
		public const short AlphabetStatue7 = 2709;

		// Token: 0x04004680 RID: 18048
		[global::Cpp2ILInjected.Token(Token = "0x40058CC")]
		public const short AlphabetStatue8 = 2710;

		// Token: 0x04004681 RID: 18049
		[global::Cpp2ILInjected.Token(Token = "0x40058CD")]
		public const short AlphabetStatue9 = 2711;

		// Token: 0x04004682 RID: 18050
		[global::Cpp2ILInjected.Token(Token = "0x40058CE")]
		public const short AlphabetStatueA = 2712;

		// Token: 0x04004683 RID: 18051
		[global::Cpp2ILInjected.Token(Token = "0x40058CF")]
		public const short AlphabetStatueB = 2713;

		// Token: 0x04004684 RID: 18052
		[global::Cpp2ILInjected.Token(Token = "0x40058D0")]
		public const short AlphabetStatueC = 2714;

		// Token: 0x04004685 RID: 18053
		[global::Cpp2ILInjected.Token(Token = "0x40058D1")]
		public const short AlphabetStatueD = 2715;

		// Token: 0x04004686 RID: 18054
		[global::Cpp2ILInjected.Token(Token = "0x40058D2")]
		public const short AlphabetStatueE = 2716;

		// Token: 0x04004687 RID: 18055
		[global::Cpp2ILInjected.Token(Token = "0x40058D3")]
		public const short AlphabetStatueF = 2717;

		// Token: 0x04004688 RID: 18056
		[global::Cpp2ILInjected.Token(Token = "0x40058D4")]
		public const short AlphabetStatueG = 2718;

		// Token: 0x04004689 RID: 18057
		[global::Cpp2ILInjected.Token(Token = "0x40058D5")]
		public const short AlphabetStatueH = 2719;

		// Token: 0x0400468A RID: 18058
		[global::Cpp2ILInjected.Token(Token = "0x40058D6")]
		public const short AlphabetStatueI = 2720;

		// Token: 0x0400468B RID: 18059
		[global::Cpp2ILInjected.Token(Token = "0x40058D7")]
		public const short AlphabetStatueJ = 2721;

		// Token: 0x0400468C RID: 18060
		[global::Cpp2ILInjected.Token(Token = "0x40058D8")]
		public const short AlphabetStatueK = 2722;

		// Token: 0x0400468D RID: 18061
		[global::Cpp2ILInjected.Token(Token = "0x40058D9")]
		public const short AlphabetStatueL = 2723;

		// Token: 0x0400468E RID: 18062
		[global::Cpp2ILInjected.Token(Token = "0x40058DA")]
		public const short AlphabetStatueM = 2724;

		// Token: 0x0400468F RID: 18063
		[global::Cpp2ILInjected.Token(Token = "0x40058DB")]
		public const short AlphabetStatueN = 2725;

		// Token: 0x04004690 RID: 18064
		[global::Cpp2ILInjected.Token(Token = "0x40058DC")]
		public const short AlphabetStatueO = 2726;

		// Token: 0x04004691 RID: 18065
		[global::Cpp2ILInjected.Token(Token = "0x40058DD")]
		public const short AlphabetStatueP = 2727;

		// Token: 0x04004692 RID: 18066
		[global::Cpp2ILInjected.Token(Token = "0x40058DE")]
		public const short AlphabetStatueQ = 2728;

		// Token: 0x04004693 RID: 18067
		[global::Cpp2ILInjected.Token(Token = "0x40058DF")]
		public const short AlphabetStatueR = 2729;

		// Token: 0x04004694 RID: 18068
		[global::Cpp2ILInjected.Token(Token = "0x40058E0")]
		public const short AlphabetStatueS = 2730;

		// Token: 0x04004695 RID: 18069
		[global::Cpp2ILInjected.Token(Token = "0x40058E1")]
		public const short AlphabetStatueT = 2731;

		// Token: 0x04004696 RID: 18070
		[global::Cpp2ILInjected.Token(Token = "0x40058E2")]
		public const short AlphabetStatueU = 2732;

		// Token: 0x04004697 RID: 18071
		[global::Cpp2ILInjected.Token(Token = "0x40058E3")]
		public const short AlphabetStatueV = 2733;

		// Token: 0x04004698 RID: 18072
		[global::Cpp2ILInjected.Token(Token = "0x40058E4")]
		public const short AlphabetStatueW = 2734;

		// Token: 0x04004699 RID: 18073
		[global::Cpp2ILInjected.Token(Token = "0x40058E5")]
		public const short AlphabetStatueX = 2735;

		// Token: 0x0400469A RID: 18074
		[global::Cpp2ILInjected.Token(Token = "0x40058E6")]
		public const short AlphabetStatueY = 2736;

		// Token: 0x0400469B RID: 18075
		[global::Cpp2ILInjected.Token(Token = "0x40058E7")]
		public const short AlphabetStatueZ = 2737;

		// Token: 0x0400469C RID: 18076
		[global::Cpp2ILInjected.Token(Token = "0x40058E8")]
		public const short FireworkFountain = 2738;

		// Token: 0x0400469D RID: 18077
		[global::Cpp2ILInjected.Token(Token = "0x40058E9")]
		public const short BoosterTrack = 2739;

		// Token: 0x0400469E RID: 18078
		[global::Cpp2ILInjected.Token(Token = "0x40058EA")]
		public const short Grasshopper = 2740;

		// Token: 0x0400469F RID: 18079
		[global::Cpp2ILInjected.Token(Token = "0x40058EB")]
		public const short GrasshopperCage = 2741;

		// Token: 0x040046A0 RID: 18080
		[global::Cpp2ILInjected.Token(Token = "0x40058EC")]
		public const short MusicBoxUndergroundCrimson = 2742;

		// Token: 0x040046A1 RID: 18081
		[global::Cpp2ILInjected.Token(Token = "0x40058ED")]
		public const short CactusTable = 2743;

		// Token: 0x040046A2 RID: 18082
		[global::Cpp2ILInjected.Token(Token = "0x40058EE")]
		public const short CactusPlatform = 2744;

		// Token: 0x040046A3 RID: 18083
		[global::Cpp2ILInjected.Token(Token = "0x40058EF")]
		public const short BorealWoodSword = 2745;

		// Token: 0x040046A4 RID: 18084
		[global::Cpp2ILInjected.Token(Token = "0x40058F0")]
		public const short BorealWoodHammer = 2746;

		// Token: 0x040046A5 RID: 18085
		[global::Cpp2ILInjected.Token(Token = "0x40058F1")]
		public const short BorealWoodBow = 2747;

		// Token: 0x040046A6 RID: 18086
		[global::Cpp2ILInjected.Token(Token = "0x40058F2")]
		public const short GlassChest = 2748;

		// Token: 0x040046A7 RID: 18087
		[global::Cpp2ILInjected.Token(Token = "0x40058F3")]
		public const short XenoStaff = 2749;

		// Token: 0x040046A8 RID: 18088
		[global::Cpp2ILInjected.Token(Token = "0x40058F4")]
		public const short MeteorStaff = 2750;

		// Token: 0x040046A9 RID: 18089
		[global::Cpp2ILInjected.Token(Token = "0x40058F5")]
		public const short LivingCursedFireBlock = 2751;

		// Token: 0x040046AA RID: 18090
		[global::Cpp2ILInjected.Token(Token = "0x40058F6")]
		public const short LivingDemonFireBlock = 2752;

		// Token: 0x040046AB RID: 18091
		[global::Cpp2ILInjected.Token(Token = "0x40058F7")]
		public const short LivingFrostFireBlock = 2753;

		// Token: 0x040046AC RID: 18092
		[global::Cpp2ILInjected.Token(Token = "0x40058F8")]
		public const short LivingIchorBlock = 2754;

		// Token: 0x040046AD RID: 18093
		[global::Cpp2ILInjected.Token(Token = "0x40058F9")]
		public const short LivingUltrabrightFireBlock = 2755;

		// Token: 0x040046AE RID: 18094
		[global::Cpp2ILInjected.Token(Token = "0x40058FA")]
		public const short GenderChangePotion = 2756;

		// Token: 0x040046AF RID: 18095
		[global::Cpp2ILInjected.Token(Token = "0x40058FB")]
		public const short VortexHelmet = 2757;

		// Token: 0x040046B0 RID: 18096
		[global::Cpp2ILInjected.Token(Token = "0x40058FC")]
		public const short VortexBreastplate = 2758;

		// Token: 0x040046B1 RID: 18097
		[global::Cpp2ILInjected.Token(Token = "0x40058FD")]
		public const short VortexLeggings = 2759;

		// Token: 0x040046B2 RID: 18098
		[global::Cpp2ILInjected.Token(Token = "0x40058FE")]
		public const short NebulaHelmet = 2760;

		// Token: 0x040046B3 RID: 18099
		[global::Cpp2ILInjected.Token(Token = "0x40058FF")]
		public const short NebulaBreastplate = 2761;

		// Token: 0x040046B4 RID: 18100
		[global::Cpp2ILInjected.Token(Token = "0x4005900")]
		public const short NebulaLeggings = 2762;

		// Token: 0x040046B5 RID: 18101
		[global::Cpp2ILInjected.Token(Token = "0x4005901")]
		public const short SolarFlareHelmet = 2763;

		// Token: 0x040046B6 RID: 18102
		[global::Cpp2ILInjected.Token(Token = "0x4005902")]
		public const short SolarFlareBreastplate = 2764;

		// Token: 0x040046B7 RID: 18103
		[global::Cpp2ILInjected.Token(Token = "0x4005903")]
		public const short SolarFlareLeggings = 2765;

		// Token: 0x040046B8 RID: 18104
		[global::Cpp2ILInjected.Token(Token = "0x4005904")]
		public const short LunarTabletFragment = 2766;

		// Token: 0x040046B9 RID: 18105
		[global::Cpp2ILInjected.Token(Token = "0x4005905")]
		public const short SolarTablet = 2767;

		// Token: 0x040046BA RID: 18106
		[global::Cpp2ILInjected.Token(Token = "0x4005906")]
		public const short DrillContainmentUnit = 2768;

		// Token: 0x040046BB RID: 18107
		[global::Cpp2ILInjected.Token(Token = "0x4005907")]
		public const short CosmicCarKey = 2769;

		// Token: 0x040046BC RID: 18108
		[global::Cpp2ILInjected.Token(Token = "0x4005908")]
		public const short MothronWings = 2770;

		// Token: 0x040046BD RID: 18109
		[global::Cpp2ILInjected.Token(Token = "0x4005909")]
		public const short BrainScrambler = 2771;

		// Token: 0x040046BE RID: 18110
		[global::Cpp2ILInjected.Token(Token = "0x400590A")]
		public const short VortexAxe = 2772;

		// Token: 0x040046BF RID: 18111
		[global::Cpp2ILInjected.Token(Token = "0x400590B")]
		public const short VortexChainsaw = 2773;

		// Token: 0x040046C0 RID: 18112
		[global::Cpp2ILInjected.Token(Token = "0x400590C")]
		public const short VortexDrill = 2774;

		// Token: 0x040046C1 RID: 18113
		[global::Cpp2ILInjected.Token(Token = "0x400590D")]
		public const short VortexHammer = 2775;

		// Token: 0x040046C2 RID: 18114
		[global::Cpp2ILInjected.Token(Token = "0x400590E")]
		public const short VortexPickaxe = 2776;

		// Token: 0x040046C3 RID: 18115
		[global::Cpp2ILInjected.Token(Token = "0x400590F")]
		public const short NebulaAxe = 2777;

		// Token: 0x040046C4 RID: 18116
		[global::Cpp2ILInjected.Token(Token = "0x4005910")]
		public const short NebulaChainsaw = 2778;

		// Token: 0x040046C5 RID: 18117
		[global::Cpp2ILInjected.Token(Token = "0x4005911")]
		public const short NebulaDrill = 2779;

		// Token: 0x040046C6 RID: 18118
		[global::Cpp2ILInjected.Token(Token = "0x4005912")]
		public const short NebulaHammer = 2780;

		// Token: 0x040046C7 RID: 18119
		[global::Cpp2ILInjected.Token(Token = "0x4005913")]
		public const short NebulaPickaxe = 2781;

		// Token: 0x040046C8 RID: 18120
		[global::Cpp2ILInjected.Token(Token = "0x4005914")]
		public const short SolarFlareAxe = 2782;

		// Token: 0x040046C9 RID: 18121
		[global::Cpp2ILInjected.Token(Token = "0x4005915")]
		public const short SolarFlareChainsaw = 2783;

		// Token: 0x040046CA RID: 18122
		[global::Cpp2ILInjected.Token(Token = "0x4005916")]
		public const short SolarFlareDrill = 2784;

		// Token: 0x040046CB RID: 18123
		[global::Cpp2ILInjected.Token(Token = "0x4005917")]
		public const short SolarFlareHammer = 2785;

		// Token: 0x040046CC RID: 18124
		[global::Cpp2ILInjected.Token(Token = "0x4005918")]
		public const short SolarFlarePickaxe = 2786;

		// Token: 0x040046CD RID: 18125
		[global::Cpp2ILInjected.Token(Token = "0x4005919")]
		public const short HoneyfallBlock = 2787;

		// Token: 0x040046CE RID: 18126
		[global::Cpp2ILInjected.Token(Token = "0x400591A")]
		public const short HoneyfallWall = 2788;

		// Token: 0x040046CF RID: 18127
		[global::Cpp2ILInjected.Token(Token = "0x400591B")]
		public const short ChlorophyteBrickWall = 2789;

		// Token: 0x040046D0 RID: 18128
		[global::Cpp2ILInjected.Token(Token = "0x400591C")]
		public const short CrimtaneBrickWall = 2790;

		// Token: 0x040046D1 RID: 18129
		[global::Cpp2ILInjected.Token(Token = "0x400591D")]
		public const short ShroomitePlatingWall = 2791;

		// Token: 0x040046D2 RID: 18130
		[global::Cpp2ILInjected.Token(Token = "0x400591E")]
		public const short ChlorophyteBrick = 2792;

		// Token: 0x040046D3 RID: 18131
		[global::Cpp2ILInjected.Token(Token = "0x400591F")]
		public const short CrimtaneBrick = 2793;

		// Token: 0x040046D4 RID: 18132
		[global::Cpp2ILInjected.Token(Token = "0x4005920")]
		public const short ShroomitePlating = 2794;

		// Token: 0x040046D5 RID: 18133
		[global::Cpp2ILInjected.Token(Token = "0x4005921")]
		public const short LaserMachinegun = 2795;

		// Token: 0x040046D6 RID: 18134
		[global::Cpp2ILInjected.Token(Token = "0x4005922")]
		public const short ElectrosphereLauncher = 2796;

		// Token: 0x040046D7 RID: 18135
		[global::Cpp2ILInjected.Token(Token = "0x4005923")]
		public const short Xenopopper = 2797;

		// Token: 0x040046D8 RID: 18136
		[global::Cpp2ILInjected.Token(Token = "0x4005924")]
		public const short LaserDrill = 2798;

		// Token: 0x040046D9 RID: 18137
		[global::Cpp2ILInjected.Token(Token = "0x4005925")]
		public const short LaserRuler = 2799;

		// Token: 0x040046DA RID: 18138
		[global::Cpp2ILInjected.Token(Token = "0x4005926")]
		public const short AntiGravityHook = 2800;

		// Token: 0x040046DB RID: 18139
		[global::Cpp2ILInjected.Token(Token = "0x4005927")]
		public const short MoonMask = 2801;

		// Token: 0x040046DC RID: 18140
		[global::Cpp2ILInjected.Token(Token = "0x4005928")]
		public const short SunMask = 2802;

		// Token: 0x040046DD RID: 18141
		[global::Cpp2ILInjected.Token(Token = "0x4005929")]
		public const short MartianCostumeMask = 2803;

		// Token: 0x040046DE RID: 18142
		[global::Cpp2ILInjected.Token(Token = "0x400592A")]
		public const short MartianCostumeShirt = 2804;

		// Token: 0x040046DF RID: 18143
		[global::Cpp2ILInjected.Token(Token = "0x400592B")]
		public const short MartianCostumePants = 2805;

		// Token: 0x040046E0 RID: 18144
		[global::Cpp2ILInjected.Token(Token = "0x400592C")]
		public const short MartianUniformHelmet = 2806;

		// Token: 0x040046E1 RID: 18145
		[global::Cpp2ILInjected.Token(Token = "0x400592D")]
		public const short MartianUniformTorso = 2807;

		// Token: 0x040046E2 RID: 18146
		[global::Cpp2ILInjected.Token(Token = "0x400592E")]
		public const short MartianUniformPants = 2808;

		// Token: 0x040046E3 RID: 18147
		[global::Cpp2ILInjected.Token(Token = "0x400592F")]
		public const short MartianAstroClock = 2809;

		// Token: 0x040046E4 RID: 18148
		[global::Cpp2ILInjected.Token(Token = "0x4005930")]
		public const short MartianBathtub = 2810;

		// Token: 0x040046E5 RID: 18149
		[global::Cpp2ILInjected.Token(Token = "0x4005931")]
		public const short MartianBed = 2811;

		// Token: 0x040046E6 RID: 18150
		[global::Cpp2ILInjected.Token(Token = "0x4005932")]
		public const short MartianHoverChair = 2812;

		// Token: 0x040046E7 RID: 18151
		[global::Cpp2ILInjected.Token(Token = "0x4005933")]
		public const short MartianChandelier = 2813;

		// Token: 0x040046E8 RID: 18152
		[global::Cpp2ILInjected.Token(Token = "0x4005934")]
		public const short MartianChest = 2814;

		// Token: 0x040046E9 RID: 18153
		[global::Cpp2ILInjected.Token(Token = "0x4005935")]
		public const short MartianDoor = 2815;

		// Token: 0x040046EA RID: 18154
		[global::Cpp2ILInjected.Token(Token = "0x4005936")]
		public const short MartianDresser = 2816;

		// Token: 0x040046EB RID: 18155
		[global::Cpp2ILInjected.Token(Token = "0x4005937")]
		public const short MartianHolobookcase = 2817;

		// Token: 0x040046EC RID: 18156
		[global::Cpp2ILInjected.Token(Token = "0x4005938")]
		public const short MartianHoverCandle = 2818;

		// Token: 0x040046ED RID: 18157
		[global::Cpp2ILInjected.Token(Token = "0x4005939")]
		public const short MartianLamppost = 2819;

		// Token: 0x040046EE RID: 18158
		[global::Cpp2ILInjected.Token(Token = "0x400593A")]
		public const short MartianLantern = 2820;

		// Token: 0x040046EF RID: 18159
		[global::Cpp2ILInjected.Token(Token = "0x400593B")]
		public const short MartianPiano = 2821;

		// Token: 0x040046F0 RID: 18160
		[global::Cpp2ILInjected.Token(Token = "0x400593C")]
		public const short MartianPlatform = 2822;

		// Token: 0x040046F1 RID: 18161
		[global::Cpp2ILInjected.Token(Token = "0x400593D")]
		public const short MartianSofa = 2823;

		// Token: 0x040046F2 RID: 18162
		[global::Cpp2ILInjected.Token(Token = "0x400593E")]
		public const short MartianTable = 2824;

		// Token: 0x040046F3 RID: 18163
		[global::Cpp2ILInjected.Token(Token = "0x400593F")]
		public const short MartianTableLamp = 2825;

		// Token: 0x040046F4 RID: 18164
		[global::Cpp2ILInjected.Token(Token = "0x4005940")]
		public const short MartianWorkBench = 2826;

		// Token: 0x040046F5 RID: 18165
		[global::Cpp2ILInjected.Token(Token = "0x4005941")]
		public const short WoodenSink = 2827;

		// Token: 0x040046F6 RID: 18166
		[global::Cpp2ILInjected.Token(Token = "0x4005942")]
		public const short EbonwoodSink = 2828;

		// Token: 0x040046F7 RID: 18167
		[global::Cpp2ILInjected.Token(Token = "0x4005943")]
		public const short RichMahoganySink = 2829;

		// Token: 0x040046F8 RID: 18168
		[global::Cpp2ILInjected.Token(Token = "0x4005944")]
		public const short PearlwoodSink = 2830;

		// Token: 0x040046F9 RID: 18169
		[global::Cpp2ILInjected.Token(Token = "0x4005945")]
		public const short BoneSink = 2831;

		// Token: 0x040046FA RID: 18170
		[global::Cpp2ILInjected.Token(Token = "0x4005946")]
		public const short FleshSink = 2832;

		// Token: 0x040046FB RID: 18171
		[global::Cpp2ILInjected.Token(Token = "0x4005947")]
		public const short LivingWoodSink = 2833;

		// Token: 0x040046FC RID: 18172
		[global::Cpp2ILInjected.Token(Token = "0x4005948")]
		public const short SkywareSink = 2834;

		// Token: 0x040046FD RID: 18173
		[global::Cpp2ILInjected.Token(Token = "0x4005949")]
		public const short ShadewoodSink = 2835;

		// Token: 0x040046FE RID: 18174
		[global::Cpp2ILInjected.Token(Token = "0x400594A")]
		public const short LihzahrdSink = 2836;

		// Token: 0x040046FF RID: 18175
		[global::Cpp2ILInjected.Token(Token = "0x400594B")]
		public const short BlueDungeonSink = 2837;

		// Token: 0x04004700 RID: 18176
		[global::Cpp2ILInjected.Token(Token = "0x400594C")]
		public const short GreenDungeonSink = 2838;

		// Token: 0x04004701 RID: 18177
		[global::Cpp2ILInjected.Token(Token = "0x400594D")]
		public const short PinkDungeonSink = 2839;

		// Token: 0x04004702 RID: 18178
		[global::Cpp2ILInjected.Token(Token = "0x400594E")]
		public const short ObsidianSink = 2840;

		// Token: 0x04004703 RID: 18179
		[global::Cpp2ILInjected.Token(Token = "0x400594F")]
		public const short MetalSink = 2841;

		// Token: 0x04004704 RID: 18180
		[global::Cpp2ILInjected.Token(Token = "0x4005950")]
		public const short GlassSink = 2842;

		// Token: 0x04004705 RID: 18181
		[global::Cpp2ILInjected.Token(Token = "0x4005951")]
		public const short GoldenSink = 2843;

		// Token: 0x04004706 RID: 18182
		[global::Cpp2ILInjected.Token(Token = "0x4005952")]
		public const short HoneySink = 2844;

		// Token: 0x04004707 RID: 18183
		[global::Cpp2ILInjected.Token(Token = "0x4005953")]
		public const short SteampunkSink = 2845;

		// Token: 0x04004708 RID: 18184
		[global::Cpp2ILInjected.Token(Token = "0x4005954")]
		public const short PumpkinSink = 2846;

		// Token: 0x04004709 RID: 18185
		[global::Cpp2ILInjected.Token(Token = "0x4005955")]
		public const short SpookySink = 2847;

		// Token: 0x0400470A RID: 18186
		[global::Cpp2ILInjected.Token(Token = "0x4005956")]
		public const short FrozenSink = 2848;

		// Token: 0x0400470B RID: 18187
		[global::Cpp2ILInjected.Token(Token = "0x4005957")]
		public const short DynastySink = 2849;

		// Token: 0x0400470C RID: 18188
		[global::Cpp2ILInjected.Token(Token = "0x4005958")]
		public const short PalmWoodSink = 2850;

		// Token: 0x0400470D RID: 18189
		[global::Cpp2ILInjected.Token(Token = "0x4005959")]
		public const short MushroomSink = 2851;

		// Token: 0x0400470E RID: 18190
		[global::Cpp2ILInjected.Token(Token = "0x400595A")]
		public const short BorealWoodSink = 2852;

		// Token: 0x0400470F RID: 18191
		[global::Cpp2ILInjected.Token(Token = "0x400595B")]
		public const short SlimeSink = 2853;

		// Token: 0x04004710 RID: 18192
		[global::Cpp2ILInjected.Token(Token = "0x400595C")]
		public const short CactusSink = 2854;

		// Token: 0x04004711 RID: 18193
		[global::Cpp2ILInjected.Token(Token = "0x400595D")]
		public const short MartianSink = 2855;

		// Token: 0x04004712 RID: 18194
		[global::Cpp2ILInjected.Token(Token = "0x400595E")]
		public const short WhiteLunaticHood = 2856;

		// Token: 0x04004713 RID: 18195
		[global::Cpp2ILInjected.Token(Token = "0x400595F")]
		public const short BlueLunaticHood = 2857;

		// Token: 0x04004714 RID: 18196
		[global::Cpp2ILInjected.Token(Token = "0x4005960")]
		public const short WhiteLunaticRobe = 2858;

		// Token: 0x04004715 RID: 18197
		[global::Cpp2ILInjected.Token(Token = "0x4005961")]
		public const short BlueLunaticRobe = 2859;

		// Token: 0x04004716 RID: 18198
		[global::Cpp2ILInjected.Token(Token = "0x4005962")]
		public const short MartianConduitPlating = 2860;

		// Token: 0x04004717 RID: 18199
		[global::Cpp2ILInjected.Token(Token = "0x4005963")]
		public const short MartianConduitWall = 2861;

		// Token: 0x04004718 RID: 18200
		[global::Cpp2ILInjected.Token(Token = "0x4005964")]
		public const short HiTekSunglasses = 2862;

		// Token: 0x04004719 RID: 18201
		[global::Cpp2ILInjected.Token(Token = "0x4005965")]
		public const short MartianHairDye = 2863;

		// Token: 0x0400471A RID: 18202
		[global::Cpp2ILInjected.Token(Token = "0x4005966")]
		public const short MartianArmorDye = 2864;

		// Token: 0x0400471B RID: 18203
		[global::Cpp2ILInjected.Token(Token = "0x4005967")]
		public const short PaintingCastleMarsberg = 2865;

		// Token: 0x0400471C RID: 18204
		[global::Cpp2ILInjected.Token(Token = "0x4005968")]
		public const short PaintingMartiaLisa = 2866;

		// Token: 0x0400471D RID: 18205
		[global::Cpp2ILInjected.Token(Token = "0x4005969")]
		public const short PaintingTheTruthIsUpThere = 2867;

		// Token: 0x0400471E RID: 18206
		[global::Cpp2ILInjected.Token(Token = "0x400596A")]
		public const short SmokeBlock = 2868;

		// Token: 0x0400471F RID: 18207
		[global::Cpp2ILInjected.Token(Token = "0x400596B")]
		public const short LivingFlameDye = 2869;

		// Token: 0x04004720 RID: 18208
		[global::Cpp2ILInjected.Token(Token = "0x400596C")]
		public const short LivingRainbowDye = 2870;

		// Token: 0x04004721 RID: 18209
		[global::Cpp2ILInjected.Token(Token = "0x400596D")]
		public const short ShadowDye = 2871;

		// Token: 0x04004722 RID: 18210
		[global::Cpp2ILInjected.Token(Token = "0x400596E")]
		public const short NegativeDye = 2872;

		// Token: 0x04004723 RID: 18211
		[global::Cpp2ILInjected.Token(Token = "0x400596F")]
		public const short LivingOceanDye = 2873;

		// Token: 0x04004724 RID: 18212
		[global::Cpp2ILInjected.Token(Token = "0x4005970")]
		public const short BrownDye = 2874;

		// Token: 0x04004725 RID: 18213
		[global::Cpp2ILInjected.Token(Token = "0x4005971")]
		public const short BrownAndBlackDye = 2875;

		// Token: 0x04004726 RID: 18214
		[global::Cpp2ILInjected.Token(Token = "0x4005972")]
		public const short BrightBrownDye = 2876;

		// Token: 0x04004727 RID: 18215
		[global::Cpp2ILInjected.Token(Token = "0x4005973")]
		public const short BrownAndSilverDye = 2877;

		// Token: 0x04004728 RID: 18216
		[global::Cpp2ILInjected.Token(Token = "0x4005974")]
		public const short WispDye = 2878;

		// Token: 0x04004729 RID: 18217
		[global::Cpp2ILInjected.Token(Token = "0x4005975")]
		public const short PixieDye = 2879;

		// Token: 0x0400472A RID: 18218
		[global::Cpp2ILInjected.Token(Token = "0x4005976")]
		public const short InfluxWaver = 2880;

		// Token: 0x0400472B RID: 18219
		[global::Cpp2ILInjected.Token(Token = "0x4005977")]
		public const short PhasicWarpEjector = 2881;

		// Token: 0x0400472C RID: 18220
		[global::Cpp2ILInjected.Token(Token = "0x4005978")]
		public const short ChargedBlasterCannon = 2882;

		// Token: 0x0400472D RID: 18221
		[global::Cpp2ILInjected.Token(Token = "0x4005979")]
		public const short ChlorophyteDye = 2883;

		// Token: 0x0400472E RID: 18222
		[global::Cpp2ILInjected.Token(Token = "0x400597A")]
		public const short UnicornWispDye = 2884;

		// Token: 0x0400472F RID: 18223
		[global::Cpp2ILInjected.Token(Token = "0x400597B")]
		public const short InfernalWispDye = 2885;

		// Token: 0x04004730 RID: 18224
		[global::Cpp2ILInjected.Token(Token = "0x400597C")]
		public const short ViciousPowder = 2886;

		// Token: 0x04004731 RID: 18225
		[global::Cpp2ILInjected.Token(Token = "0x400597D")]
		public const short ViciousMushroom = 2887;

		// Token: 0x04004732 RID: 18226
		[global::Cpp2ILInjected.Token(Token = "0x400597E")]
		public const short BeesKnees = 2888;

		// Token: 0x04004733 RID: 18227
		[global::Cpp2ILInjected.Token(Token = "0x400597F")]
		public const short GoldBird = 2889;

		// Token: 0x04004734 RID: 18228
		[global::Cpp2ILInjected.Token(Token = "0x4005980")]
		public const short GoldBunny = 2890;

		// Token: 0x04004735 RID: 18229
		[global::Cpp2ILInjected.Token(Token = "0x4005981")]
		public const short GoldButterfly = 2891;

		// Token: 0x04004736 RID: 18230
		[global::Cpp2ILInjected.Token(Token = "0x4005982")]
		public const short GoldFrog = 2892;

		// Token: 0x04004737 RID: 18231
		[global::Cpp2ILInjected.Token(Token = "0x4005983")]
		public const short GoldGrasshopper = 2893;

		// Token: 0x04004738 RID: 18232
		[global::Cpp2ILInjected.Token(Token = "0x4005984")]
		public const short GoldMouse = 2894;

		// Token: 0x04004739 RID: 18233
		[global::Cpp2ILInjected.Token(Token = "0x4005985")]
		public const short GoldWorm = 2895;

		// Token: 0x0400473A RID: 18234
		[global::Cpp2ILInjected.Token(Token = "0x4005986")]
		public const short StickyDynamite = 2896;

		// Token: 0x0400473B RID: 18235
		[global::Cpp2ILInjected.Token(Token = "0x4005987")]
		public const short AngryTrapperBanner = 2897;

		// Token: 0x0400473C RID: 18236
		[global::Cpp2ILInjected.Token(Token = "0x4005988")]
		public const short ArmoredVikingBanner = 2898;

		// Token: 0x0400473D RID: 18237
		[global::Cpp2ILInjected.Token(Token = "0x4005989")]
		public const short BlackSlimeBanner = 2899;

		// Token: 0x0400473E RID: 18238
		[global::Cpp2ILInjected.Token(Token = "0x400598A")]
		public const short BlueArmoredBonesBanner = 2900;

		// Token: 0x0400473F RID: 18239
		[global::Cpp2ILInjected.Token(Token = "0x400598B")]
		public const short BlueCultistArcherBanner = 2901;

		// Token: 0x04004740 RID: 18240
		[global::Cpp2ILInjected.Token(Token = "0x400598C")]
		public const short BlueCultistCasterBanner = 2902;

		// Token: 0x04004741 RID: 18241
		[global::Cpp2ILInjected.Token(Token = "0x400598D")]
		public const short BlueCultistFighterBanner = 2903;

		// Token: 0x04004742 RID: 18242
		[global::Cpp2ILInjected.Token(Token = "0x400598E")]
		public const short BoneLeeBanner = 2904;

		// Token: 0x04004743 RID: 18243
		[global::Cpp2ILInjected.Token(Token = "0x400598F")]
		public const short ClingerBanner = 2905;

		// Token: 0x04004744 RID: 18244
		[global::Cpp2ILInjected.Token(Token = "0x4005990")]
		public const short CochinealBeetleBanner = 2906;

		// Token: 0x04004745 RID: 18245
		[global::Cpp2ILInjected.Token(Token = "0x4005991")]
		public const short CorruptPenguinBanner = 2907;

		// Token: 0x04004746 RID: 18246
		[global::Cpp2ILInjected.Token(Token = "0x4005992")]
		public const short CorruptSlimeBanner = 2908;

		// Token: 0x04004747 RID: 18247
		[global::Cpp2ILInjected.Token(Token = "0x4005993")]
		public const short CorruptorBanner = 2909;

		// Token: 0x04004748 RID: 18248
		[global::Cpp2ILInjected.Token(Token = "0x4005994")]
		public const short CrimslimeBanner = 2910;

		// Token: 0x04004749 RID: 18249
		[global::Cpp2ILInjected.Token(Token = "0x4005995")]
		public const short CursedSkullBanner = 2911;

		// Token: 0x0400474A RID: 18250
		[global::Cpp2ILInjected.Token(Token = "0x4005996")]
		public const short CyanBeetleBanner = 2912;

		// Token: 0x0400474B RID: 18251
		[global::Cpp2ILInjected.Token(Token = "0x4005997")]
		public const short DevourerBanner = 2913;

		// Token: 0x0400474C RID: 18252
		[global::Cpp2ILInjected.Token(Token = "0x4005998")]
		public const short DiablolistBanner = 2914;

		// Token: 0x0400474D RID: 18253
		[global::Cpp2ILInjected.Token(Token = "0x4005999")]
		public const short DoctorBonesBanner = 2915;

		// Token: 0x0400474E RID: 18254
		[global::Cpp2ILInjected.Token(Token = "0x400599A")]
		public const short DungeonSlimeBanner = 2916;

		// Token: 0x0400474F RID: 18255
		[global::Cpp2ILInjected.Token(Token = "0x400599B")]
		public const short DungeonSpiritBanner = 2917;

		// Token: 0x04004750 RID: 18256
		[global::Cpp2ILInjected.Token(Token = "0x400599C")]
		public const short ElfArcherBanner = 2918;

		// Token: 0x04004751 RID: 18257
		[global::Cpp2ILInjected.Token(Token = "0x400599D")]
		public const short ElfCopterBanner = 2919;

		// Token: 0x04004752 RID: 18258
		[global::Cpp2ILInjected.Token(Token = "0x400599E")]
		public const short EyezorBanner = 2920;

		// Token: 0x04004753 RID: 18259
		[global::Cpp2ILInjected.Token(Token = "0x400599F")]
		public const short FlockoBanner = 2921;

		// Token: 0x04004754 RID: 18260
		[global::Cpp2ILInjected.Token(Token = "0x40059A0")]
		public const short GhostBanner = 2922;

		// Token: 0x04004755 RID: 18261
		[global::Cpp2ILInjected.Token(Token = "0x40059A1")]
		public const short GiantBatBanner = 2923;

		// Token: 0x04004756 RID: 18262
		[global::Cpp2ILInjected.Token(Token = "0x40059A2")]
		public const short GiantCursedSkullBanner = 2924;

		// Token: 0x04004757 RID: 18263
		[global::Cpp2ILInjected.Token(Token = "0x40059A3")]
		public const short GiantFlyingFoxBanner = 2925;

		// Token: 0x04004758 RID: 18264
		[global::Cpp2ILInjected.Token(Token = "0x40059A4")]
		public const short GingerbreadManBanner = 2926;

		// Token: 0x04004759 RID: 18265
		[global::Cpp2ILInjected.Token(Token = "0x40059A5")]
		public const short GoblinArcherBanner = 2927;

		// Token: 0x0400475A RID: 18266
		[global::Cpp2ILInjected.Token(Token = "0x40059A6")]
		public const short GreenSlimeBanner = 2928;

		// Token: 0x0400475B RID: 18267
		[global::Cpp2ILInjected.Token(Token = "0x40059A7")]
		public const short HeadlessHorsemanBanner = 2929;

		// Token: 0x0400475C RID: 18268
		[global::Cpp2ILInjected.Token(Token = "0x40059A8")]
		public const short HellArmoredBonesBanner = 2930;

		// Token: 0x0400475D RID: 18269
		[global::Cpp2ILInjected.Token(Token = "0x40059A9")]
		public const short HellhoundBanner = 2931;

		// Token: 0x0400475E RID: 18270
		[global::Cpp2ILInjected.Token(Token = "0x40059AA")]
		public const short HoppinJackBanner = 2932;

		// Token: 0x0400475F RID: 18271
		[global::Cpp2ILInjected.Token(Token = "0x40059AB")]
		public const short IceBatBanner = 2933;

		// Token: 0x04004760 RID: 18272
		[global::Cpp2ILInjected.Token(Token = "0x40059AC")]
		public const short IceGolemBanner = 2934;

		// Token: 0x04004761 RID: 18273
		[global::Cpp2ILInjected.Token(Token = "0x40059AD")]
		public const short IceSlimeBanner = 2935;

		// Token: 0x04004762 RID: 18274
		[global::Cpp2ILInjected.Token(Token = "0x40059AE")]
		public const short IchorStickerBanner = 2936;

		// Token: 0x04004763 RID: 18275
		[global::Cpp2ILInjected.Token(Token = "0x40059AF")]
		public const short IlluminantBatBanner = 2937;

		// Token: 0x04004764 RID: 18276
		[global::Cpp2ILInjected.Token(Token = "0x40059B0")]
		public const short IlluminantSlimeBanner = 2938;

		// Token: 0x04004765 RID: 18277
		[global::Cpp2ILInjected.Token(Token = "0x40059B1")]
		public const short JungleBatBanner = 2939;

		// Token: 0x04004766 RID: 18278
		[global::Cpp2ILInjected.Token(Token = "0x40059B2")]
		public const short JungleSlimeBanner = 2940;

		// Token: 0x04004767 RID: 18279
		[global::Cpp2ILInjected.Token(Token = "0x40059B3")]
		public const short KrampusBanner = 2941;

		// Token: 0x04004768 RID: 18280
		[global::Cpp2ILInjected.Token(Token = "0x40059B4")]
		public const short LacBeetleBanner = 2942;

		// Token: 0x04004769 RID: 18281
		[global::Cpp2ILInjected.Token(Token = "0x40059B5")]
		public const short LavaBatBanner = 2943;

		// Token: 0x0400476A RID: 18282
		[global::Cpp2ILInjected.Token(Token = "0x40059B6")]
		public const short LavaSlimeBanner = 2944;

		// Token: 0x0400476B RID: 18283
		[global::Cpp2ILInjected.Token(Token = "0x40059B7")]
		public const short MartianBrainscramblerBanner = 2945;

		// Token: 0x0400476C RID: 18284
		[global::Cpp2ILInjected.Token(Token = "0x40059B8")]
		public const short MartianDroneBanner = 2946;

		// Token: 0x0400476D RID: 18285
		[global::Cpp2ILInjected.Token(Token = "0x40059B9")]
		public const short MartianEngineerBanner = 2947;

		// Token: 0x0400476E RID: 18286
		[global::Cpp2ILInjected.Token(Token = "0x40059BA")]
		public const short MartianGigazapperBanner = 2948;

		// Token: 0x0400476F RID: 18287
		[global::Cpp2ILInjected.Token(Token = "0x40059BB")]
		public const short MartianGreyGruntBanner = 2949;

		// Token: 0x04004770 RID: 18288
		[global::Cpp2ILInjected.Token(Token = "0x40059BC")]
		public const short MartianOfficerBanner = 2950;

		// Token: 0x04004771 RID: 18289
		[global::Cpp2ILInjected.Token(Token = "0x40059BD")]
		public const short MartianRaygunnerBanner = 2951;

		// Token: 0x04004772 RID: 18290
		[global::Cpp2ILInjected.Token(Token = "0x40059BE")]
		public const short MartianScutlixGunnerBanner = 2952;

		// Token: 0x04004773 RID: 18291
		[global::Cpp2ILInjected.Token(Token = "0x40059BF")]
		public const short MartianTeslaTurretBanner = 2953;

		// Token: 0x04004774 RID: 18292
		[global::Cpp2ILInjected.Token(Token = "0x40059C0")]
		public const short MisterStabbyBanner = 2954;

		// Token: 0x04004775 RID: 18293
		[global::Cpp2ILInjected.Token(Token = "0x40059C1")]
		public const short MotherSlimeBanner = 2955;

		// Token: 0x04004776 RID: 18294
		[global::Cpp2ILInjected.Token(Token = "0x40059C2")]
		public const short NecromancerBanner = 2956;

		// Token: 0x04004777 RID: 18295
		[global::Cpp2ILInjected.Token(Token = "0x40059C3")]
		public const short NutcrackerBanner = 2957;

		// Token: 0x04004778 RID: 18296
		[global::Cpp2ILInjected.Token(Token = "0x40059C4")]
		public const short PaladinBanner = 2958;

		// Token: 0x04004779 RID: 18297
		[global::Cpp2ILInjected.Token(Token = "0x40059C5")]
		public const short PenguinBanner = 2959;

		// Token: 0x0400477A RID: 18298
		[global::Cpp2ILInjected.Token(Token = "0x40059C6")]
		public const short PinkyBanner = 2960;

		// Token: 0x0400477B RID: 18299
		[global::Cpp2ILInjected.Token(Token = "0x40059C7")]
		public const short PoltergeistBanner = 2961;

		// Token: 0x0400477C RID: 18300
		[global::Cpp2ILInjected.Token(Token = "0x40059C8")]
		public const short PossessedArmorBanner = 2962;

		// Token: 0x0400477D RID: 18301
		[global::Cpp2ILInjected.Token(Token = "0x40059C9")]
		public const short PresentMimicBanner = 2963;

		// Token: 0x0400477E RID: 18302
		[global::Cpp2ILInjected.Token(Token = "0x40059CA")]
		public const short PurpleSlimeBanner = 2964;

		// Token: 0x0400477F RID: 18303
		[global::Cpp2ILInjected.Token(Token = "0x40059CB")]
		public const short RaggedCasterBanner = 2965;

		// Token: 0x04004780 RID: 18304
		[global::Cpp2ILInjected.Token(Token = "0x40059CC")]
		public const short RainbowSlimeBanner = 2966;

		// Token: 0x04004781 RID: 18305
		[global::Cpp2ILInjected.Token(Token = "0x40059CD")]
		public const short RavenBanner = 2967;

		// Token: 0x04004782 RID: 18306
		[global::Cpp2ILInjected.Token(Token = "0x40059CE")]
		public const short RedSlimeBanner = 2968;

		// Token: 0x04004783 RID: 18307
		[global::Cpp2ILInjected.Token(Token = "0x40059CF")]
		public const short RuneWizardBanner = 2969;

		// Token: 0x04004784 RID: 18308
		[global::Cpp2ILInjected.Token(Token = "0x40059D0")]
		public const short RustyArmoredBonesBanner = 2970;

		// Token: 0x04004785 RID: 18309
		[global::Cpp2ILInjected.Token(Token = "0x40059D1")]
		public const short ScarecrowBanner = 2971;

		// Token: 0x04004786 RID: 18310
		[global::Cpp2ILInjected.Token(Token = "0x40059D2")]
		public const short ScutlixBanner = 2972;

		// Token: 0x04004787 RID: 18311
		[global::Cpp2ILInjected.Token(Token = "0x40059D3")]
		public const short SkeletonArcherBanner = 2973;

		// Token: 0x04004788 RID: 18312
		[global::Cpp2ILInjected.Token(Token = "0x40059D4")]
		public const short SkeletonCommandoBanner = 2974;

		// Token: 0x04004789 RID: 18313
		[global::Cpp2ILInjected.Token(Token = "0x40059D5")]
		public const short SkeletonSniperBanner = 2975;

		// Token: 0x0400478A RID: 18314
		[global::Cpp2ILInjected.Token(Token = "0x40059D6")]
		public const short SlimerBanner = 2976;

		// Token: 0x0400478B RID: 18315
		[global::Cpp2ILInjected.Token(Token = "0x40059D7")]
		public const short SnatcherBanner = 2977;

		// Token: 0x0400478C RID: 18316
		[global::Cpp2ILInjected.Token(Token = "0x40059D8")]
		public const short SnowBallaBanner = 2978;

		// Token: 0x0400478D RID: 18317
		[global::Cpp2ILInjected.Token(Token = "0x40059D9")]
		public const short SnowmanGangstaBanner = 2979;

		// Token: 0x0400478E RID: 18318
		[global::Cpp2ILInjected.Token(Token = "0x40059DA")]
		public const short SpikedIceSlimeBanner = 2980;

		// Token: 0x0400478F RID: 18319
		[global::Cpp2ILInjected.Token(Token = "0x40059DB")]
		public const short SpikedJungleSlimeBanner = 2981;

		// Token: 0x04004790 RID: 18320
		[global::Cpp2ILInjected.Token(Token = "0x40059DC")]
		public const short SplinterlingBanner = 2982;

		// Token: 0x04004791 RID: 18321
		[global::Cpp2ILInjected.Token(Token = "0x40059DD")]
		public const short SquidBanner = 2983;

		// Token: 0x04004792 RID: 18322
		[global::Cpp2ILInjected.Token(Token = "0x40059DE")]
		public const short TacticalSkeletonBanner = 2984;

		// Token: 0x04004793 RID: 18323
		[global::Cpp2ILInjected.Token(Token = "0x40059DF")]
		public const short TheGroomBanner = 2985;

		// Token: 0x04004794 RID: 18324
		[global::Cpp2ILInjected.Token(Token = "0x40059E0")]
		public const short TimBanner = 2986;

		// Token: 0x04004795 RID: 18325
		[global::Cpp2ILInjected.Token(Token = "0x40059E1")]
		public const short UndeadMinerBanner = 2987;

		// Token: 0x04004796 RID: 18326
		[global::Cpp2ILInjected.Token(Token = "0x40059E2")]
		public const short UndeadVikingBanner = 2988;

		// Token: 0x04004797 RID: 18327
		[global::Cpp2ILInjected.Token(Token = "0x40059E3")]
		public const short WhiteCultistArcherBanner = 2989;

		// Token: 0x04004798 RID: 18328
		[global::Cpp2ILInjected.Token(Token = "0x40059E4")]
		public const short WhiteCultistCasterBanner = 2990;

		// Token: 0x04004799 RID: 18329
		[global::Cpp2ILInjected.Token(Token = "0x40059E5")]
		public const short WhiteCultistFighterBanner = 2991;

		// Token: 0x0400479A RID: 18330
		[global::Cpp2ILInjected.Token(Token = "0x40059E6")]
		public const short YellowSlimeBanner = 2992;

		// Token: 0x0400479B RID: 18331
		[global::Cpp2ILInjected.Token(Token = "0x40059E7")]
		public const short YetiBanner = 2993;

		// Token: 0x0400479C RID: 18332
		[global::Cpp2ILInjected.Token(Token = "0x40059E8")]
		public const short ZombieElfBanner = 2994;

		// Token: 0x0400479D RID: 18333
		[global::Cpp2ILInjected.Token(Token = "0x40059E9")]
		public const short SparkyPainting = 2995;

		// Token: 0x0400479E RID: 18334
		[global::Cpp2ILInjected.Token(Token = "0x40059EA")]
		public const short VineRope = 2996;

		// Token: 0x0400479F RID: 18335
		[global::Cpp2ILInjected.Token(Token = "0x40059EB")]
		public const short WormholePotion = 2997;

		// Token: 0x040047A0 RID: 18336
		[global::Cpp2ILInjected.Token(Token = "0x40059EC")]
		public const short SummonerEmblem = 2998;

		// Token: 0x040047A1 RID: 18337
		[global::Cpp2ILInjected.Token(Token = "0x40059ED")]
		public const short BewitchingTable = 2999;

		// Token: 0x040047A2 RID: 18338
		[global::Cpp2ILInjected.Token(Token = "0x40059EE")]
		public const short AlchemyTable = 3000;

		// Token: 0x040047A3 RID: 18339
		[global::Cpp2ILInjected.Token(Token = "0x40059EF")]
		public const short StrangeBrew = 3001;

		// Token: 0x040047A4 RID: 18340
		[global::Cpp2ILInjected.Token(Token = "0x40059F0")]
		public const short SpelunkerGlowstick = 3002;

		// Token: 0x040047A5 RID: 18341
		[global::Cpp2ILInjected.Token(Token = "0x40059F1")]
		public const short BoneArrow = 3003;

		// Token: 0x040047A6 RID: 18342
		[global::Cpp2ILInjected.Token(Token = "0x40059F2")]
		public const short BoneTorch = 3004;

		// Token: 0x040047A7 RID: 18343
		[global::Cpp2ILInjected.Token(Token = "0x40059F3")]
		public const short VineRopeCoil = 3005;

		// Token: 0x040047A8 RID: 18344
		[global::Cpp2ILInjected.Token(Token = "0x40059F4")]
		public const short SoulDrain = 3006;

		// Token: 0x040047A9 RID: 18345
		[global::Cpp2ILInjected.Token(Token = "0x40059F5")]
		public const short DartPistol = 3007;

		// Token: 0x040047AA RID: 18346
		[global::Cpp2ILInjected.Token(Token = "0x40059F6")]
		public const short DartRifle = 3008;

		// Token: 0x040047AB RID: 18347
		[global::Cpp2ILInjected.Token(Token = "0x40059F7")]
		public const short CrystalDart = 3009;

		// Token: 0x040047AC RID: 18348
		[global::Cpp2ILInjected.Token(Token = "0x40059F8")]
		public const short CursedDart = 3010;

		// Token: 0x040047AD RID: 18349
		[global::Cpp2ILInjected.Token(Token = "0x40059F9")]
		public const short IchorDart = 3011;

		// Token: 0x040047AE RID: 18350
		[global::Cpp2ILInjected.Token(Token = "0x40059FA")]
		public const short ChainGuillotines = 3012;

		// Token: 0x040047AF RID: 18351
		[global::Cpp2ILInjected.Token(Token = "0x40059FB")]
		public const short FetidBaghnakhs = 3013;

		// Token: 0x040047B0 RID: 18352
		[global::Cpp2ILInjected.Token(Token = "0x40059FC")]
		public const short ClingerStaff = 3014;

		// Token: 0x040047B1 RID: 18353
		[global::Cpp2ILInjected.Token(Token = "0x40059FD")]
		public const short PutridScent = 3015;

		// Token: 0x040047B2 RID: 18354
		[global::Cpp2ILInjected.Token(Token = "0x40059FE")]
		public const short FleshKnuckles = 3016;

		// Token: 0x040047B3 RID: 18355
		[global::Cpp2ILInjected.Token(Token = "0x40059FF")]
		public const short FlowerBoots = 3017;

		// Token: 0x040047B4 RID: 18356
		[global::Cpp2ILInjected.Token(Token = "0x4005A00")]
		public const short Seedler = 3018;

		// Token: 0x040047B5 RID: 18357
		[global::Cpp2ILInjected.Token(Token = "0x4005A01")]
		public const short HellwingBow = 3019;

		// Token: 0x040047B6 RID: 18358
		[global::Cpp2ILInjected.Token(Token = "0x4005A02")]
		public const short TendonHook = 3020;

		// Token: 0x040047B7 RID: 18359
		[global::Cpp2ILInjected.Token(Token = "0x4005A03")]
		public const short ThornHook = 3021;

		// Token: 0x040047B8 RID: 18360
		[global::Cpp2ILInjected.Token(Token = "0x4005A04")]
		public const short IlluminantHook = 3022;

		// Token: 0x040047B9 RID: 18361
		[global::Cpp2ILInjected.Token(Token = "0x4005A05")]
		public const short WormHook = 3023;

		// Token: 0x040047BA RID: 18362
		[global::Cpp2ILInjected.Token(Token = "0x4005A06")]
		public const short DevDye = 3024;

		// Token: 0x040047BB RID: 18363
		[global::Cpp2ILInjected.Token(Token = "0x4005A07")]
		public const short PurpleOozeDye = 3025;

		// Token: 0x040047BC RID: 18364
		[global::Cpp2ILInjected.Token(Token = "0x4005A08")]
		public const short ReflectiveSilverDye = 3026;

		// Token: 0x040047BD RID: 18365
		[global::Cpp2ILInjected.Token(Token = "0x4005A09")]
		public const short ReflectiveGoldDye = 3027;

		// Token: 0x040047BE RID: 18366
		[global::Cpp2ILInjected.Token(Token = "0x4005A0A")]
		public const short BlueAcidDye = 3028;

		// Token: 0x040047BF RID: 18367
		[global::Cpp2ILInjected.Token(Token = "0x4005A0B")]
		public const short DaedalusStormbow = 3029;

		// Token: 0x040047C0 RID: 18368
		[global::Cpp2ILInjected.Token(Token = "0x4005A0C")]
		public const short FlyingKnife = 3030;

		// Token: 0x040047C1 RID: 18369
		[global::Cpp2ILInjected.Token(Token = "0x4005A0D")]
		public const short BottomlessBucket = 3031;

		// Token: 0x040047C2 RID: 18370
		[global::Cpp2ILInjected.Token(Token = "0x4005A0E")]
		public const short SuperAbsorbantSponge = 3032;

		// Token: 0x040047C3 RID: 18371
		[global::Cpp2ILInjected.Token(Token = "0x4005A0F")]
		public const short GoldRing = 3033;

		// Token: 0x040047C4 RID: 18372
		[global::Cpp2ILInjected.Token(Token = "0x4005A10")]
		public const short CoinRing = 3034;

		// Token: 0x040047C5 RID: 18373
		[global::Cpp2ILInjected.Token(Token = "0x4005A11")]
		public const short GreedyRing = 3035;

		// Token: 0x040047C6 RID: 18374
		[global::Cpp2ILInjected.Token(Token = "0x4005A12")]
		public const short FishFinder = 3036;

		// Token: 0x040047C7 RID: 18375
		[global::Cpp2ILInjected.Token(Token = "0x4005A13")]
		public const short WeatherRadio = 3037;

		// Token: 0x040047C8 RID: 18376
		[global::Cpp2ILInjected.Token(Token = "0x4005A14")]
		public const short HadesDye = 3038;

		// Token: 0x040047C9 RID: 18377
		[global::Cpp2ILInjected.Token(Token = "0x4005A15")]
		public const short TwilightDye = 3039;

		// Token: 0x040047CA RID: 18378
		[global::Cpp2ILInjected.Token(Token = "0x4005A16")]
		public const short AcidDye = 3040;

		// Token: 0x040047CB RID: 18379
		[global::Cpp2ILInjected.Token(Token = "0x4005A17")]
		public const short MushroomDye = 3041;

		// Token: 0x040047CC RID: 18380
		[global::Cpp2ILInjected.Token(Token = "0x4005A18")]
		public const short PhaseDye = 3042;

		// Token: 0x040047CD RID: 18381
		[global::Cpp2ILInjected.Token(Token = "0x4005A19")]
		public const short MagicLantern = 3043;

		// Token: 0x040047CE RID: 18382
		[global::Cpp2ILInjected.Token(Token = "0x4005A1A")]
		public const short MusicBoxLunarBoss = 3044;

		// Token: 0x040047CF RID: 18383
		[global::Cpp2ILInjected.Token(Token = "0x4005A1B")]
		public const short RainbowTorch = 3045;

		// Token: 0x040047D0 RID: 18384
		[global::Cpp2ILInjected.Token(Token = "0x4005A1C")]
		public const short CursedCampfire = 3046;

		// Token: 0x040047D1 RID: 18385
		[global::Cpp2ILInjected.Token(Token = "0x4005A1D")]
		public const short DemonCampfire = 3047;

		// Token: 0x040047D2 RID: 18386
		[global::Cpp2ILInjected.Token(Token = "0x4005A1E")]
		public const short FrozenCampfire = 3048;

		// Token: 0x040047D3 RID: 18387
		[global::Cpp2ILInjected.Token(Token = "0x4005A1F")]
		public const short IchorCampfire = 3049;

		// Token: 0x040047D4 RID: 18388
		[global::Cpp2ILInjected.Token(Token = "0x4005A20")]
		public const short RainbowCampfire = 3050;

		// Token: 0x040047D5 RID: 18389
		[global::Cpp2ILInjected.Token(Token = "0x4005A21")]
		public const short CrystalVileShard = 3051;

		// Token: 0x040047D6 RID: 18390
		[global::Cpp2ILInjected.Token(Token = "0x4005A22")]
		public const short ShadowFlameBow = 3052;

		// Token: 0x040047D7 RID: 18391
		[global::Cpp2ILInjected.Token(Token = "0x4005A23")]
		public const short ShadowFlameHexDoll = 3053;

		// Token: 0x040047D8 RID: 18392
		[global::Cpp2ILInjected.Token(Token = "0x4005A24")]
		public const short ShadowFlameKnife = 3054;

		// Token: 0x040047D9 RID: 18393
		[global::Cpp2ILInjected.Token(Token = "0x4005A25")]
		public const short PaintingAcorns = 3055;

		// Token: 0x040047DA RID: 18394
		[global::Cpp2ILInjected.Token(Token = "0x4005A26")]
		public const short PaintingColdSnap = 3056;

		// Token: 0x040047DB RID: 18395
		[global::Cpp2ILInjected.Token(Token = "0x4005A27")]
		public const short PaintingCursedSaint = 3057;

		// Token: 0x040047DC RID: 18396
		[global::Cpp2ILInjected.Token(Token = "0x4005A28")]
		public const short PaintingSnowfellas = 3058;

		// Token: 0x040047DD RID: 18397
		[global::Cpp2ILInjected.Token(Token = "0x4005A29")]
		public const short PaintingTheSeason = 3059;

		// Token: 0x040047DE RID: 18398
		[global::Cpp2ILInjected.Token(Token = "0x4005A2A")]
		public const short BoneRattle = 3060;

		// Token: 0x040047DF RID: 18399
		[global::Cpp2ILInjected.Token(Token = "0x4005A2B")]
		public const short ArchitectGizmoPack = 3061;

		// Token: 0x040047E0 RID: 18400
		[global::Cpp2ILInjected.Token(Token = "0x4005A2C")]
		public const short CrimsonHeart = 3062;

		// Token: 0x040047E1 RID: 18401
		[global::Cpp2ILInjected.Token(Token = "0x4005A2D")]
		public const short Meowmere = 3063;

		// Token: 0x040047E2 RID: 18402
		[global::Cpp2ILInjected.Token(Token = "0x4005A2E")]
		public const short Sundial = 3064;

		// Token: 0x040047E3 RID: 18403
		[global::Cpp2ILInjected.Token(Token = "0x4005A2F")]
		public const short StarWrath = 3065;

		// Token: 0x040047E4 RID: 18404
		[global::Cpp2ILInjected.Token(Token = "0x4005A30")]
		public const short MarbleBlock = 3066;

		// Token: 0x040047E5 RID: 18405
		[global::Cpp2ILInjected.Token(Token = "0x4005A31")]
		public const short HellstoneBrickWall = 3067;

		// Token: 0x040047E6 RID: 18406
		[global::Cpp2ILInjected.Token(Token = "0x4005A32")]
		public const short CordageGuide = 3068;

		// Token: 0x040047E7 RID: 18407
		[global::Cpp2ILInjected.Token(Token = "0x4005A33")]
		public const short WandofSparking = 3069;

		// Token: 0x040047E8 RID: 18408
		[global::Cpp2ILInjected.Token(Token = "0x4005A34")]
		public const short GoldBirdCage = 3070;

		// Token: 0x040047E9 RID: 18409
		[global::Cpp2ILInjected.Token(Token = "0x4005A35")]
		public const short GoldBunnyCage = 3071;

		// Token: 0x040047EA RID: 18410
		[global::Cpp2ILInjected.Token(Token = "0x4005A36")]
		public const short GoldButterflyCage = 3072;

		// Token: 0x040047EB RID: 18411
		[global::Cpp2ILInjected.Token(Token = "0x4005A37")]
		public const short GoldFrogCage = 3073;

		// Token: 0x040047EC RID: 18412
		[global::Cpp2ILInjected.Token(Token = "0x4005A38")]
		public const short GoldGrasshopperCage = 3074;

		// Token: 0x040047ED RID: 18413
		[global::Cpp2ILInjected.Token(Token = "0x4005A39")]
		public const short GoldMouseCage = 3075;

		// Token: 0x040047EE RID: 18414
		[global::Cpp2ILInjected.Token(Token = "0x4005A3A")]
		public const short GoldWormCage = 3076;

		// Token: 0x040047EF RID: 18415
		[global::Cpp2ILInjected.Token(Token = "0x4005A3B")]
		public const short SilkRope = 3077;

		// Token: 0x040047F0 RID: 18416
		[global::Cpp2ILInjected.Token(Token = "0x4005A3C")]
		public const short WebRope = 3078;

		// Token: 0x040047F1 RID: 18417
		[global::Cpp2ILInjected.Token(Token = "0x4005A3D")]
		public const short SilkRopeCoil = 3079;

		// Token: 0x040047F2 RID: 18418
		[global::Cpp2ILInjected.Token(Token = "0x4005A3E")]
		public const short WebRopeCoil = 3080;

		// Token: 0x040047F3 RID: 18419
		[global::Cpp2ILInjected.Token(Token = "0x4005A3F")]
		public const short Marble = 3081;

		// Token: 0x040047F4 RID: 18420
		[global::Cpp2ILInjected.Token(Token = "0x4005A40")]
		public const short MarbleWall = 3082;

		// Token: 0x040047F5 RID: 18421
		[global::Cpp2ILInjected.Token(Token = "0x4005A41")]
		public const short MarbleBlockWall = 3083;

		// Token: 0x040047F6 RID: 18422
		[global::Cpp2ILInjected.Token(Token = "0x4005A42")]
		public const short Radar = 3084;

		// Token: 0x040047F7 RID: 18423
		[global::Cpp2ILInjected.Token(Token = "0x4005A43")]
		public const short LockBox = 3085;

		// Token: 0x040047F8 RID: 18424
		[global::Cpp2ILInjected.Token(Token = "0x4005A44")]
		public const short Granite = 3086;

		// Token: 0x040047F9 RID: 18425
		[global::Cpp2ILInjected.Token(Token = "0x4005A45")]
		public const short GraniteBlock = 3087;

		// Token: 0x040047FA RID: 18426
		[global::Cpp2ILInjected.Token(Token = "0x4005A46")]
		public const short GraniteWall = 3088;

		// Token: 0x040047FB RID: 18427
		[global::Cpp2ILInjected.Token(Token = "0x4005A47")]
		public const short GraniteBlockWall = 3089;

		// Token: 0x040047FC RID: 18428
		[global::Cpp2ILInjected.Token(Token = "0x4005A48")]
		public const short RoyalGel = 3090;

		// Token: 0x040047FD RID: 18429
		[global::Cpp2ILInjected.Token(Token = "0x4005A49")]
		public const short NightKey = 3091;

		// Token: 0x040047FE RID: 18430
		[global::Cpp2ILInjected.Token(Token = "0x4005A4A")]
		public const short LightKey = 3092;

		// Token: 0x040047FF RID: 18431
		[global::Cpp2ILInjected.Token(Token = "0x4005A4B")]
		public const short HerbBag = 3093;

		// Token: 0x04004800 RID: 18432
		[global::Cpp2ILInjected.Token(Token = "0x4005A4C")]
		public const short Javelin = 3094;

		// Token: 0x04004801 RID: 18433
		[global::Cpp2ILInjected.Token(Token = "0x4005A4D")]
		public const short TallyCounter = 3095;

		// Token: 0x04004802 RID: 18434
		[global::Cpp2ILInjected.Token(Token = "0x4005A4E")]
		public const short Sextant = 3096;

		// Token: 0x04004803 RID: 18435
		[global::Cpp2ILInjected.Token(Token = "0x4005A4F")]
		public const short EoCShield = 3097;

		// Token: 0x04004804 RID: 18436
		[global::Cpp2ILInjected.Token(Token = "0x4005A50")]
		public const short ButchersChainsaw = 3098;

		// Token: 0x04004805 RID: 18437
		[global::Cpp2ILInjected.Token(Token = "0x4005A51")]
		public const short Stopwatch = 3099;

		// Token: 0x04004806 RID: 18438
		[global::Cpp2ILInjected.Token(Token = "0x4005A52")]
		public const short MeteoriteBrick = 3100;

		// Token: 0x04004807 RID: 18439
		[global::Cpp2ILInjected.Token(Token = "0x4005A53")]
		public const short MeteoriteBrickWall = 3101;

		// Token: 0x04004808 RID: 18440
		[global::Cpp2ILInjected.Token(Token = "0x4005A54")]
		public const short MetalDetector = 3102;

		// Token: 0x04004809 RID: 18441
		[global::Cpp2ILInjected.Token(Token = "0x4005A55")]
		public const short EndlessQuiver = 3103;

		// Token: 0x0400480A RID: 18442
		[global::Cpp2ILInjected.Token(Token = "0x4005A56")]
		public const short EndlessMusketPouch = 3104;

		// Token: 0x0400480B RID: 18443
		[global::Cpp2ILInjected.Token(Token = "0x4005A57")]
		public const short ToxicFlask = 3105;

		// Token: 0x0400480C RID: 18444
		[global::Cpp2ILInjected.Token(Token = "0x4005A58")]
		public const short PsychoKnife = 3106;

		// Token: 0x0400480D RID: 18445
		[global::Cpp2ILInjected.Token(Token = "0x4005A59")]
		public const short NailGun = 3107;

		// Token: 0x0400480E RID: 18446
		[global::Cpp2ILInjected.Token(Token = "0x4005A5A")]
		public const short Nail = 3108;

		// Token: 0x0400480F RID: 18447
		[global::Cpp2ILInjected.Token(Token = "0x4005A5B")]
		public const short NightVisionHelmet = 3109;

		// Token: 0x04004810 RID: 18448
		[global::Cpp2ILInjected.Token(Token = "0x4005A5C")]
		public const short CelestialShell = 3110;

		// Token: 0x04004811 RID: 18449
		[global::Cpp2ILInjected.Token(Token = "0x4005A5D")]
		public const short PinkGel = 3111;

		// Token: 0x04004812 RID: 18450
		[global::Cpp2ILInjected.Token(Token = "0x4005A5E")]
		public const short BouncyGlowstick = 3112;

		// Token: 0x04004813 RID: 18451
		[global::Cpp2ILInjected.Token(Token = "0x4005A5F")]
		public const short PinkSlimeBlock = 3113;

		// Token: 0x04004814 RID: 18452
		[global::Cpp2ILInjected.Token(Token = "0x4005A60")]
		public const short PinkTorch = 3114;

		// Token: 0x04004815 RID: 18453
		[global::Cpp2ILInjected.Token(Token = "0x4005A61")]
		public const short BouncyBomb = 3115;

		// Token: 0x04004816 RID: 18454
		[global::Cpp2ILInjected.Token(Token = "0x4005A62")]
		public const short BouncyGrenade = 3116;

		// Token: 0x04004817 RID: 18455
		[global::Cpp2ILInjected.Token(Token = "0x4005A63")]
		public const short PeaceCandle = 3117;

		// Token: 0x04004818 RID: 18456
		[global::Cpp2ILInjected.Token(Token = "0x4005A64")]
		public const short LifeformAnalyzer = 3118;

		// Token: 0x04004819 RID: 18457
		[global::Cpp2ILInjected.Token(Token = "0x4005A65")]
		public const short DPSMeter = 3119;

		// Token: 0x0400481A RID: 18458
		[global::Cpp2ILInjected.Token(Token = "0x4005A66")]
		public const short FishermansGuide = 3120;

		// Token: 0x0400481B RID: 18459
		[global::Cpp2ILInjected.Token(Token = "0x4005A67")]
		public const short GoblinTech = 3121;

		// Token: 0x0400481C RID: 18460
		[global::Cpp2ILInjected.Token(Token = "0x4005A68")]
		public const short REK = 3122;

		// Token: 0x0400481D RID: 18461
		[global::Cpp2ILInjected.Token(Token = "0x4005A69")]
		public const short PDA = 3123;

		// Token: 0x0400481E RID: 18462
		[global::Cpp2ILInjected.Token(Token = "0x4005A6A")]
		public const short CellPhone = 3124;

		// Token: 0x0400481F RID: 18463
		[global::Cpp2ILInjected.Token(Token = "0x4005A6B")]
		public const short GraniteChest = 3125;

		// Token: 0x04004820 RID: 18464
		[global::Cpp2ILInjected.Token(Token = "0x4005A6C")]
		public const short MeteoriteClock = 3126;

		// Token: 0x04004821 RID: 18465
		[global::Cpp2ILInjected.Token(Token = "0x4005A6D")]
		public const short MarbleClock = 3127;

		// Token: 0x04004822 RID: 18466
		[global::Cpp2ILInjected.Token(Token = "0x4005A6E")]
		public const short GraniteClock = 3128;

		// Token: 0x04004823 RID: 18467
		[global::Cpp2ILInjected.Token(Token = "0x4005A6F")]
		public const short MeteoriteDoor = 3129;

		// Token: 0x04004824 RID: 18468
		[global::Cpp2ILInjected.Token(Token = "0x4005A70")]
		public const short MarbleDoor = 3130;

		// Token: 0x04004825 RID: 18469
		[global::Cpp2ILInjected.Token(Token = "0x4005A71")]
		public const short GraniteDoor = 3131;

		// Token: 0x04004826 RID: 18470
		[global::Cpp2ILInjected.Token(Token = "0x4005A72")]
		public const short MeteoriteDresser = 3132;

		// Token: 0x04004827 RID: 18471
		[global::Cpp2ILInjected.Token(Token = "0x4005A73")]
		public const short MarbleDresser = 3133;

		// Token: 0x04004828 RID: 18472
		[global::Cpp2ILInjected.Token(Token = "0x4005A74")]
		public const short GraniteDresser = 3134;

		// Token: 0x04004829 RID: 18473
		[global::Cpp2ILInjected.Token(Token = "0x4005A75")]
		public const short MeteoriteLamp = 3135;

		// Token: 0x0400482A RID: 18474
		[global::Cpp2ILInjected.Token(Token = "0x4005A76")]
		public const short MarbleLamp = 3136;

		// Token: 0x0400482B RID: 18475
		[global::Cpp2ILInjected.Token(Token = "0x4005A77")]
		public const short GraniteLamp = 3137;

		// Token: 0x0400482C RID: 18476
		[global::Cpp2ILInjected.Token(Token = "0x4005A78")]
		public const short MeteoriteLantern = 3138;

		// Token: 0x0400482D RID: 18477
		[global::Cpp2ILInjected.Token(Token = "0x4005A79")]
		public const short MarbleLantern = 3139;

		// Token: 0x0400482E RID: 18478
		[global::Cpp2ILInjected.Token(Token = "0x4005A7A")]
		public const short GraniteLantern = 3140;

		// Token: 0x0400482F RID: 18479
		[global::Cpp2ILInjected.Token(Token = "0x4005A7B")]
		public const short MeteoritePiano = 3141;

		// Token: 0x04004830 RID: 18480
		[global::Cpp2ILInjected.Token(Token = "0x4005A7C")]
		public const short MarblePiano = 3142;

		// Token: 0x04004831 RID: 18481
		[global::Cpp2ILInjected.Token(Token = "0x4005A7D")]
		public const short GranitePiano = 3143;

		// Token: 0x04004832 RID: 18482
		[global::Cpp2ILInjected.Token(Token = "0x4005A7E")]
		public const short MeteoritePlatform = 3144;

		// Token: 0x04004833 RID: 18483
		[global::Cpp2ILInjected.Token(Token = "0x4005A7F")]
		public const short MarblePlatform = 3145;

		// Token: 0x04004834 RID: 18484
		[global::Cpp2ILInjected.Token(Token = "0x4005A80")]
		public const short GranitePlatform = 3146;

		// Token: 0x04004835 RID: 18485
		[global::Cpp2ILInjected.Token(Token = "0x4005A81")]
		public const short MeteoriteSink = 3147;

		// Token: 0x04004836 RID: 18486
		[global::Cpp2ILInjected.Token(Token = "0x4005A82")]
		public const short MarbleSink = 3148;

		// Token: 0x04004837 RID: 18487
		[global::Cpp2ILInjected.Token(Token = "0x4005A83")]
		public const short GraniteSink = 3149;

		// Token: 0x04004838 RID: 18488
		[global::Cpp2ILInjected.Token(Token = "0x4005A84")]
		public const short MeteoriteSofa = 3150;

		// Token: 0x04004839 RID: 18489
		[global::Cpp2ILInjected.Token(Token = "0x4005A85")]
		public const short MarbleSofa = 3151;

		// Token: 0x0400483A RID: 18490
		[global::Cpp2ILInjected.Token(Token = "0x4005A86")]
		public const short GraniteSofa = 3152;

		// Token: 0x0400483B RID: 18491
		[global::Cpp2ILInjected.Token(Token = "0x4005A87")]
		public const short MeteoriteTable = 3153;

		// Token: 0x0400483C RID: 18492
		[global::Cpp2ILInjected.Token(Token = "0x4005A88")]
		public const short MarbleTable = 3154;

		// Token: 0x0400483D RID: 18493
		[global::Cpp2ILInjected.Token(Token = "0x4005A89")]
		public const short GraniteTable = 3155;

		// Token: 0x0400483E RID: 18494
		[global::Cpp2ILInjected.Token(Token = "0x4005A8A")]
		public const short MeteoriteWorkBench = 3156;

		// Token: 0x0400483F RID: 18495
		[global::Cpp2ILInjected.Token(Token = "0x4005A8B")]
		public const short MarbleWorkBench = 3157;

		// Token: 0x04004840 RID: 18496
		[global::Cpp2ILInjected.Token(Token = "0x4005A8C")]
		public const short GraniteWorkBench = 3158;

		// Token: 0x04004841 RID: 18497
		[global::Cpp2ILInjected.Token(Token = "0x4005A8D")]
		public const short MeteoriteBathtub = 3159;

		// Token: 0x04004842 RID: 18498
		[global::Cpp2ILInjected.Token(Token = "0x4005A8E")]
		public const short MarbleBathtub = 3160;

		// Token: 0x04004843 RID: 18499
		[global::Cpp2ILInjected.Token(Token = "0x4005A8F")]
		public const short GraniteBathtub = 3161;

		// Token: 0x04004844 RID: 18500
		[global::Cpp2ILInjected.Token(Token = "0x4005A90")]
		public const short MeteoriteBed = 3162;

		// Token: 0x04004845 RID: 18501
		[global::Cpp2ILInjected.Token(Token = "0x4005A91")]
		public const short MarbleBed = 3163;

		// Token: 0x04004846 RID: 18502
		[global::Cpp2ILInjected.Token(Token = "0x4005A92")]
		public const short GraniteBed = 3164;

		// Token: 0x04004847 RID: 18503
		[global::Cpp2ILInjected.Token(Token = "0x4005A93")]
		public const short MeteoriteBookcase = 3165;

		// Token: 0x04004848 RID: 18504
		[global::Cpp2ILInjected.Token(Token = "0x4005A94")]
		public const short MarbleBookcase = 3166;

		// Token: 0x04004849 RID: 18505
		[global::Cpp2ILInjected.Token(Token = "0x4005A95")]
		public const short GraniteBookcase = 3167;

		// Token: 0x0400484A RID: 18506
		[global::Cpp2ILInjected.Token(Token = "0x4005A96")]
		public const short MeteoriteCandelabra = 3168;

		// Token: 0x0400484B RID: 18507
		[global::Cpp2ILInjected.Token(Token = "0x4005A97")]
		public const short MarbleCandelabra = 3169;

		// Token: 0x0400484C RID: 18508
		[global::Cpp2ILInjected.Token(Token = "0x4005A98")]
		public const short GraniteCandelabra = 3170;

		// Token: 0x0400484D RID: 18509
		[global::Cpp2ILInjected.Token(Token = "0x4005A99")]
		public const short MeteoriteCandle = 3171;

		// Token: 0x0400484E RID: 18510
		[global::Cpp2ILInjected.Token(Token = "0x4005A9A")]
		public const short MarbleCandle = 3172;

		// Token: 0x0400484F RID: 18511
		[global::Cpp2ILInjected.Token(Token = "0x4005A9B")]
		public const short GraniteCandle = 3173;

		// Token: 0x04004850 RID: 18512
		[global::Cpp2ILInjected.Token(Token = "0x4005A9C")]
		public const short MeteoriteChair = 3174;

		// Token: 0x04004851 RID: 18513
		[global::Cpp2ILInjected.Token(Token = "0x4005A9D")]
		public const short MarbleChair = 3175;

		// Token: 0x04004852 RID: 18514
		[global::Cpp2ILInjected.Token(Token = "0x4005A9E")]
		public const short GraniteChair = 3176;

		// Token: 0x04004853 RID: 18515
		[global::Cpp2ILInjected.Token(Token = "0x4005A9F")]
		public const short MeteoriteChandelier = 3177;

		// Token: 0x04004854 RID: 18516
		[global::Cpp2ILInjected.Token(Token = "0x4005AA0")]
		public const short MarbleChandelier = 3178;

		// Token: 0x04004855 RID: 18517
		[global::Cpp2ILInjected.Token(Token = "0x4005AA1")]
		public const short GraniteChandelier = 3179;

		// Token: 0x04004856 RID: 18518
		[global::Cpp2ILInjected.Token(Token = "0x4005AA2")]
		public const short MeteoriteChest = 3180;

		// Token: 0x04004857 RID: 18519
		[global::Cpp2ILInjected.Token(Token = "0x4005AA3")]
		public const short MarbleChest = 3181;

		// Token: 0x04004858 RID: 18520
		[global::Cpp2ILInjected.Token(Token = "0x4005AA4")]
		public const short MagicWaterDropper = 3182;

		// Token: 0x04004859 RID: 18521
		[global::Cpp2ILInjected.Token(Token = "0x4005AA5")]
		public const short GoldenBugNet = 3183;

		// Token: 0x0400485A RID: 18522
		[global::Cpp2ILInjected.Token(Token = "0x4005AA6")]
		public const short MagicLavaDropper = 3184;

		// Token: 0x0400485B RID: 18523
		[global::Cpp2ILInjected.Token(Token = "0x4005AA7")]
		public const short MagicHoneyDropper = 3185;

		// Token: 0x0400485C RID: 18524
		[global::Cpp2ILInjected.Token(Token = "0x4005AA8")]
		public const short EmptyDropper = 3186;

		// Token: 0x0400485D RID: 18525
		[global::Cpp2ILInjected.Token(Token = "0x4005AA9")]
		public const short GladiatorHelmet = 3187;

		// Token: 0x0400485E RID: 18526
		[global::Cpp2ILInjected.Token(Token = "0x4005AAA")]
		public const short GladiatorBreastplate = 3188;

		// Token: 0x0400485F RID: 18527
		[global::Cpp2ILInjected.Token(Token = "0x4005AAB")]
		public const short GladiatorLeggings = 3189;

		// Token: 0x04004860 RID: 18528
		[global::Cpp2ILInjected.Token(Token = "0x4005AAC")]
		public const short ReflectiveDye = 3190;

		// Token: 0x04004861 RID: 18529
		[global::Cpp2ILInjected.Token(Token = "0x4005AAD")]
		public const short EnchantedNightcrawler = 3191;

		// Token: 0x04004862 RID: 18530
		[global::Cpp2ILInjected.Token(Token = "0x4005AAE")]
		public const short Grubby = 3192;

		// Token: 0x04004863 RID: 18531
		[global::Cpp2ILInjected.Token(Token = "0x4005AAF")]
		public const short Sluggy = 3193;

		// Token: 0x04004864 RID: 18532
		[global::Cpp2ILInjected.Token(Token = "0x4005AB0")]
		public const short Buggy = 3194;

		// Token: 0x04004865 RID: 18533
		[global::Cpp2ILInjected.Token(Token = "0x4005AB1")]
		public const short GrubSoup = 3195;

		// Token: 0x04004866 RID: 18534
		[global::Cpp2ILInjected.Token(Token = "0x4005AB2")]
		public const short BombFish = 3196;

		// Token: 0x04004867 RID: 18535
		[global::Cpp2ILInjected.Token(Token = "0x4005AB3")]
		public const short FrostDaggerfish = 3197;

		// Token: 0x04004868 RID: 18536
		[global::Cpp2ILInjected.Token(Token = "0x4005AB4")]
		public const short SharpeningStation = 3198;

		// Token: 0x04004869 RID: 18537
		[global::Cpp2ILInjected.Token(Token = "0x4005AB5")]
		public const short IceMirror = 3199;

		// Token: 0x0400486A RID: 18538
		[global::Cpp2ILInjected.Token(Token = "0x4005AB6")]
		public const short SailfishBoots = 3200;

		// Token: 0x0400486B RID: 18539
		[global::Cpp2ILInjected.Token(Token = "0x4005AB7")]
		public const short TsunamiInABottle = 3201;

		// Token: 0x0400486C RID: 18540
		[global::Cpp2ILInjected.Token(Token = "0x4005AB8")]
		public const short TargetDummy = 3202;

		// Token: 0x0400486D RID: 18541
		[global::Cpp2ILInjected.Token(Token = "0x4005AB9")]
		public const short CorruptFishingCrate = 3203;

		// Token: 0x0400486E RID: 18542
		[global::Cpp2ILInjected.Token(Token = "0x4005ABA")]
		public const short CrimsonFishingCrate = 3204;

		// Token: 0x0400486F RID: 18543
		[global::Cpp2ILInjected.Token(Token = "0x4005ABB")]
		public const short DungeonFishingCrate = 3205;

		// Token: 0x04004870 RID: 18544
		[global::Cpp2ILInjected.Token(Token = "0x4005ABC")]
		public const short FloatingIslandFishingCrate = 3206;

		// Token: 0x04004871 RID: 18545
		[global::Cpp2ILInjected.Token(Token = "0x4005ABD")]
		public const short HallowedFishingCrate = 3207;

		// Token: 0x04004872 RID: 18546
		[global::Cpp2ILInjected.Token(Token = "0x4005ABE")]
		public const short JungleFishingCrate = 3208;

		// Token: 0x04004873 RID: 18547
		[global::Cpp2ILInjected.Token(Token = "0x4005ABF")]
		public const short CrystalSerpent = 3209;

		// Token: 0x04004874 RID: 18548
		[global::Cpp2ILInjected.Token(Token = "0x4005AC0")]
		public const short Toxikarp = 3210;

		// Token: 0x04004875 RID: 18549
		[global::Cpp2ILInjected.Token(Token = "0x4005AC1")]
		public const short Bladetongue = 3211;

		// Token: 0x04004876 RID: 18550
		[global::Cpp2ILInjected.Token(Token = "0x4005AC2")]
		public const short SharkToothNecklace = 3212;

		// Token: 0x04004877 RID: 18551
		[global::Cpp2ILInjected.Token(Token = "0x4005AC3")]
		public const short MoneyTrough = 3213;

		// Token: 0x04004878 RID: 18552
		[global::Cpp2ILInjected.Token(Token = "0x4005AC4")]
		public const short Bubble = 3214;

		// Token: 0x04004879 RID: 18553
		[global::Cpp2ILInjected.Token(Token = "0x4005AC5")]
		public const short DayBloomPlanterBox = 3215;

		// Token: 0x0400487A RID: 18554
		[global::Cpp2ILInjected.Token(Token = "0x4005AC6")]
		public const short MoonglowPlanterBox = 3216;

		// Token: 0x0400487B RID: 18555
		[global::Cpp2ILInjected.Token(Token = "0x4005AC7")]
		public const short CorruptPlanterBox = 3217;

		// Token: 0x0400487C RID: 18556
		[global::Cpp2ILInjected.Token(Token = "0x4005AC8")]
		public const short CrimsonPlanterBox = 3218;

		// Token: 0x0400487D RID: 18557
		[global::Cpp2ILInjected.Token(Token = "0x4005AC9")]
		public const short BlinkrootPlanterBox = 3219;

		// Token: 0x0400487E RID: 18558
		[global::Cpp2ILInjected.Token(Token = "0x4005ACA")]
		public const short WaterleafPlanterBox = 3220;

		// Token: 0x0400487F RID: 18559
		[global::Cpp2ILInjected.Token(Token = "0x4005ACB")]
		public const short ShiverthornPlanterBox = 3221;

		// Token: 0x04004880 RID: 18560
		[global::Cpp2ILInjected.Token(Token = "0x4005ACC")]
		public const short FireBlossomPlanterBox = 3222;

		// Token: 0x04004881 RID: 18561
		[global::Cpp2ILInjected.Token(Token = "0x4005ACD")]
		public const short BrainOfConfusion = 3223;

		// Token: 0x04004882 RID: 18562
		[global::Cpp2ILInjected.Token(Token = "0x4005ACE")]
		public const short WormScarf = 3224;

		// Token: 0x04004883 RID: 18563
		[global::Cpp2ILInjected.Token(Token = "0x4005ACF")]
		public const short BalloonPufferfish = 3225;

		// Token: 0x04004884 RID: 18564
		[global::Cpp2ILInjected.Token(Token = "0x4005AD0")]
		public const short BejeweledValkyrieHead = 3226;

		// Token: 0x04004885 RID: 18565
		[global::Cpp2ILInjected.Token(Token = "0x4005AD1")]
		public const short BejeweledValkyrieBody = 3227;

		// Token: 0x04004886 RID: 18566
		[global::Cpp2ILInjected.Token(Token = "0x4005AD2")]
		public const short BejeweledValkyrieWing = 3228;

		// Token: 0x04004887 RID: 18567
		[global::Cpp2ILInjected.Token(Token = "0x4005AD3")]
		public const short RichGravestone1 = 3229;

		// Token: 0x04004888 RID: 18568
		[global::Cpp2ILInjected.Token(Token = "0x4005AD4")]
		public const short RichGravestone2 = 3230;

		// Token: 0x04004889 RID: 18569
		[global::Cpp2ILInjected.Token(Token = "0x4005AD5")]
		public const short RichGravestone3 = 3231;

		// Token: 0x0400488A RID: 18570
		[global::Cpp2ILInjected.Token(Token = "0x4005AD6")]
		public const short RichGravestone4 = 3232;

		// Token: 0x0400488B RID: 18571
		[global::Cpp2ILInjected.Token(Token = "0x4005AD7")]
		public const short RichGravestone5 = 3233;

		// Token: 0x0400488C RID: 18572
		[global::Cpp2ILInjected.Token(Token = "0x4005AD8")]
		public const short CrystalBlock = 3234;

		// Token: 0x0400488D RID: 18573
		[global::Cpp2ILInjected.Token(Token = "0x4005AD9")]
		public const short MusicBoxMartians = 3235;

		// Token: 0x0400488E RID: 18574
		[global::Cpp2ILInjected.Token(Token = "0x4005ADA")]
		public const short MusicBoxPirates = 3236;

		// Token: 0x0400488F RID: 18575
		[global::Cpp2ILInjected.Token(Token = "0x4005ADB")]
		public const short MusicBoxHell = 3237;

		// Token: 0x04004890 RID: 18576
		[global::Cpp2ILInjected.Token(Token = "0x4005ADC")]
		public const short CrystalBlockWall = 3238;

		// Token: 0x04004891 RID: 18577
		[global::Cpp2ILInjected.Token(Token = "0x4005ADD")]
		public const short Trapdoor = 3239;

		// Token: 0x04004892 RID: 18578
		[global::Cpp2ILInjected.Token(Token = "0x4005ADE")]
		public const short TallGate = 3240;

		// Token: 0x04004893 RID: 18579
		[global::Cpp2ILInjected.Token(Token = "0x4005ADF")]
		public const short SharkronBalloon = 3241;

		// Token: 0x04004894 RID: 18580
		[global::Cpp2ILInjected.Token(Token = "0x4005AE0")]
		public const short TaxCollectorHat = 3242;

		// Token: 0x04004895 RID: 18581
		[global::Cpp2ILInjected.Token(Token = "0x4005AE1")]
		public const short TaxCollectorSuit = 3243;

		// Token: 0x04004896 RID: 18582
		[global::Cpp2ILInjected.Token(Token = "0x4005AE2")]
		public const short TaxCollectorPants = 3244;

		// Token: 0x04004897 RID: 18583
		[global::Cpp2ILInjected.Token(Token = "0x4005AE3")]
		public const short BoneGlove = 3245;

		// Token: 0x04004898 RID: 18584
		[global::Cpp2ILInjected.Token(Token = "0x4005AE4")]
		public const short ClothierJacket = 3246;

		// Token: 0x04004899 RID: 18585
		[global::Cpp2ILInjected.Token(Token = "0x4005AE5")]
		public const short ClothierPants = 3247;

		// Token: 0x0400489A RID: 18586
		[global::Cpp2ILInjected.Token(Token = "0x4005AE6")]
		public const short DyeTraderTurban = 3248;

		// Token: 0x0400489B RID: 18587
		[global::Cpp2ILInjected.Token(Token = "0x4005AE7")]
		public const short DeadlySphereStaff = 3249;

		// Token: 0x0400489C RID: 18588
		[global::Cpp2ILInjected.Token(Token = "0x4005AE8")]
		public const short BalloonHorseshoeFart = 3250;

		// Token: 0x0400489D RID: 18589
		[global::Cpp2ILInjected.Token(Token = "0x4005AE9")]
		public const short BalloonHorseshoeHoney = 3251;

		// Token: 0x0400489E RID: 18590
		[global::Cpp2ILInjected.Token(Token = "0x4005AEA")]
		public const short BalloonHorseshoeSharkron = 3252;

		// Token: 0x0400489F RID: 18591
		[global::Cpp2ILInjected.Token(Token = "0x4005AEB")]
		public const short LavaLamp = 3253;

		// Token: 0x040048A0 RID: 18592
		[global::Cpp2ILInjected.Token(Token = "0x4005AEC")]
		public const short CageEnchantedNightcrawler = 3254;

		// Token: 0x040048A1 RID: 18593
		[global::Cpp2ILInjected.Token(Token = "0x4005AED")]
		public const short CageBuggy = 3255;

		// Token: 0x040048A2 RID: 18594
		[global::Cpp2ILInjected.Token(Token = "0x4005AEE")]
		public const short CageGrubby = 3256;

		// Token: 0x040048A3 RID: 18595
		[global::Cpp2ILInjected.Token(Token = "0x4005AEF")]
		public const short CageSluggy = 3257;

		// Token: 0x040048A4 RID: 18596
		[global::Cpp2ILInjected.Token(Token = "0x4005AF0")]
		public const short SlapHand = 3258;

		// Token: 0x040048A5 RID: 18597
		[global::Cpp2ILInjected.Token(Token = "0x4005AF1")]
		public const short TwilightHairDye = 3259;

		// Token: 0x040048A6 RID: 18598
		[global::Cpp2ILInjected.Token(Token = "0x4005AF2")]
		public const short BlessedApple = 3260;

		// Token: 0x040048A7 RID: 18599
		[global::Cpp2ILInjected.Token(Token = "0x4005AF3")]
		public const short SpectreBar = 3261;

		// Token: 0x040048A8 RID: 18600
		[global::Cpp2ILInjected.Token(Token = "0x4005AF4")]
		public const short Code1 = 3262;

		// Token: 0x040048A9 RID: 18601
		[global::Cpp2ILInjected.Token(Token = "0x4005AF5")]
		public const short BuccaneerBandana = 3263;

		// Token: 0x040048AA RID: 18602
		[global::Cpp2ILInjected.Token(Token = "0x4005AF6")]
		public const short BuccaneerShirt = 3264;

		// Token: 0x040048AB RID: 18603
		[global::Cpp2ILInjected.Token(Token = "0x4005AF7")]
		public const short BuccaneerPants = 3265;

		// Token: 0x040048AC RID: 18604
		[global::Cpp2ILInjected.Token(Token = "0x4005AF8")]
		public const short ObsidianHelm = 3266;

		// Token: 0x040048AD RID: 18605
		[global::Cpp2ILInjected.Token(Token = "0x4005AF9")]
		public const short ObsidianShirt = 3267;

		// Token: 0x040048AE RID: 18606
		[global::Cpp2ILInjected.Token(Token = "0x4005AFA")]
		public const short ObsidianPants = 3268;

		// Token: 0x040048AF RID: 18607
		[global::Cpp2ILInjected.Token(Token = "0x4005AFB")]
		public const short MedusaHead = 3269;

		// Token: 0x040048B0 RID: 18608
		[global::Cpp2ILInjected.Token(Token = "0x4005AFC")]
		public const short ItemFrame = 3270;

		// Token: 0x040048B1 RID: 18609
		[global::Cpp2ILInjected.Token(Token = "0x4005AFD")]
		public const short Sandstone = 3271;

		// Token: 0x040048B2 RID: 18610
		[global::Cpp2ILInjected.Token(Token = "0x4005AFE")]
		public const short HardenedSand = 3272;

		// Token: 0x040048B3 RID: 18611
		[global::Cpp2ILInjected.Token(Token = "0x4005AFF")]
		public const short SandstoneWall = 3273;

		// Token: 0x040048B4 RID: 18612
		[global::Cpp2ILInjected.Token(Token = "0x4005B00")]
		public const short CorruptHardenedSand = 3274;

		// Token: 0x040048B5 RID: 18613
		[global::Cpp2ILInjected.Token(Token = "0x4005B01")]
		public const short CrimsonHardenedSand = 3275;

		// Token: 0x040048B6 RID: 18614
		[global::Cpp2ILInjected.Token(Token = "0x4005B02")]
		public const short CorruptSandstone = 3276;

		// Token: 0x040048B7 RID: 18615
		[global::Cpp2ILInjected.Token(Token = "0x4005B03")]
		public const short CrimsonSandstone = 3277;

		// Token: 0x040048B8 RID: 18616
		[global::Cpp2ILInjected.Token(Token = "0x4005B04")]
		public const short WoodYoyo = 3278;

		// Token: 0x040048B9 RID: 18617
		[global::Cpp2ILInjected.Token(Token = "0x4005B05")]
		public const short CorruptYoyo = 3279;

		// Token: 0x040048BA RID: 18618
		[global::Cpp2ILInjected.Token(Token = "0x4005B06")]
		public const short CrimsonYoyo = 3280;

		// Token: 0x040048BB RID: 18619
		[global::Cpp2ILInjected.Token(Token = "0x4005B07")]
		public const short JungleYoyo = 3281;

		// Token: 0x040048BC RID: 18620
		[global::Cpp2ILInjected.Token(Token = "0x4005B08")]
		public const short Cascade = 3282;

		// Token: 0x040048BD RID: 18621
		[global::Cpp2ILInjected.Token(Token = "0x4005B09")]
		public const short Chik = 3283;

		// Token: 0x040048BE RID: 18622
		[global::Cpp2ILInjected.Token(Token = "0x4005B0A")]
		public const short Code2 = 3284;

		// Token: 0x040048BF RID: 18623
		[global::Cpp2ILInjected.Token(Token = "0x4005B0B")]
		public const short Rally = 3285;

		// Token: 0x040048C0 RID: 18624
		[global::Cpp2ILInjected.Token(Token = "0x4005B0C")]
		public const short Yelets = 3286;

		// Token: 0x040048C1 RID: 18625
		[global::Cpp2ILInjected.Token(Token = "0x4005B0D")]
		public const short RedsYoyo = 3287;

		// Token: 0x040048C2 RID: 18626
		[global::Cpp2ILInjected.Token(Token = "0x4005B0E")]
		public const short ValkyrieYoyo = 3288;

		// Token: 0x040048C3 RID: 18627
		[global::Cpp2ILInjected.Token(Token = "0x4005B0F")]
		public const short Amarok = 3289;

		// Token: 0x040048C4 RID: 18628
		[global::Cpp2ILInjected.Token(Token = "0x4005B10")]
		public const short HelFire = 3290;

		// Token: 0x040048C5 RID: 18629
		[global::Cpp2ILInjected.Token(Token = "0x4005B11")]
		public const short Kraken = 3291;

		// Token: 0x040048C6 RID: 18630
		[global::Cpp2ILInjected.Token(Token = "0x4005B12")]
		public const short TheEyeOfCthulhu = 3292;

		// Token: 0x040048C7 RID: 18631
		[global::Cpp2ILInjected.Token(Token = "0x4005B13")]
		public const short RedString = 3293;

		// Token: 0x040048C8 RID: 18632
		[global::Cpp2ILInjected.Token(Token = "0x4005B14")]
		public const short OrangeString = 3294;

		// Token: 0x040048C9 RID: 18633
		[global::Cpp2ILInjected.Token(Token = "0x4005B15")]
		public const short YellowString = 3295;

		// Token: 0x040048CA RID: 18634
		[global::Cpp2ILInjected.Token(Token = "0x4005B16")]
		public const short LimeString = 3296;

		// Token: 0x040048CB RID: 18635
		[global::Cpp2ILInjected.Token(Token = "0x4005B17")]
		public const short GreenString = 3297;

		// Token: 0x040048CC RID: 18636
		[global::Cpp2ILInjected.Token(Token = "0x4005B18")]
		public const short TealString = 3298;

		// Token: 0x040048CD RID: 18637
		[global::Cpp2ILInjected.Token(Token = "0x4005B19")]
		public const short CyanString = 3299;

		// Token: 0x040048CE RID: 18638
		[global::Cpp2ILInjected.Token(Token = "0x4005B1A")]
		public const short SkyBlueString = 3300;

		// Token: 0x040048CF RID: 18639
		[global::Cpp2ILInjected.Token(Token = "0x4005B1B")]
		public const short BlueString = 3301;

		// Token: 0x040048D0 RID: 18640
		[global::Cpp2ILInjected.Token(Token = "0x4005B1C")]
		public const short PurpleString = 3302;

		// Token: 0x040048D1 RID: 18641
		[global::Cpp2ILInjected.Token(Token = "0x4005B1D")]
		public const short VioletString = 3303;

		// Token: 0x040048D2 RID: 18642
		[global::Cpp2ILInjected.Token(Token = "0x4005B1E")]
		public const short PinkString = 3304;

		// Token: 0x040048D3 RID: 18643
		[global::Cpp2ILInjected.Token(Token = "0x4005B1F")]
		public const short BrownString = 3305;

		// Token: 0x040048D4 RID: 18644
		[global::Cpp2ILInjected.Token(Token = "0x4005B20")]
		public const short WhiteString = 3306;

		// Token: 0x040048D5 RID: 18645
		[global::Cpp2ILInjected.Token(Token = "0x4005B21")]
		public const short RainbowString = 3307;

		// Token: 0x040048D6 RID: 18646
		[global::Cpp2ILInjected.Token(Token = "0x4005B22")]
		public const short BlackString = 3308;

		// Token: 0x040048D7 RID: 18647
		[global::Cpp2ILInjected.Token(Token = "0x4005B23")]
		public const short BlackCounterweight = 3309;

		// Token: 0x040048D8 RID: 18648
		[global::Cpp2ILInjected.Token(Token = "0x4005B24")]
		public const short BlueCounterweight = 3310;

		// Token: 0x040048D9 RID: 18649
		[global::Cpp2ILInjected.Token(Token = "0x4005B25")]
		public const short GreenCounterweight = 3311;

		// Token: 0x040048DA RID: 18650
		[global::Cpp2ILInjected.Token(Token = "0x4005B26")]
		public const short PurpleCounterweight = 3312;

		// Token: 0x040048DB RID: 18651
		[global::Cpp2ILInjected.Token(Token = "0x4005B27")]
		public const short RedCounterweight = 3313;

		// Token: 0x040048DC RID: 18652
		[global::Cpp2ILInjected.Token(Token = "0x4005B28")]
		public const short YellowCounterweight = 3314;

		// Token: 0x040048DD RID: 18653
		[global::Cpp2ILInjected.Token(Token = "0x4005B29")]
		public const short FormatC = 3315;

		// Token: 0x040048DE RID: 18654
		[global::Cpp2ILInjected.Token(Token = "0x4005B2A")]
		public const short Gradient = 3316;

		// Token: 0x040048DF RID: 18655
		[global::Cpp2ILInjected.Token(Token = "0x4005B2B")]
		public const short Valor = 3317;

		// Token: 0x040048E0 RID: 18656
		[global::Cpp2ILInjected.Token(Token = "0x4005B2C")]
		public const short KingSlimeBossBag = 3318;

		// Token: 0x040048E1 RID: 18657
		[global::Cpp2ILInjected.Token(Token = "0x4005B2D")]
		public const short EyeOfCthulhuBossBag = 3319;

		// Token: 0x040048E2 RID: 18658
		[global::Cpp2ILInjected.Token(Token = "0x4005B2E")]
		public const short EaterOfWorldsBossBag = 3320;

		// Token: 0x040048E3 RID: 18659
		[global::Cpp2ILInjected.Token(Token = "0x4005B2F")]
		public const short BrainOfCthulhuBossBag = 3321;

		// Token: 0x040048E4 RID: 18660
		[global::Cpp2ILInjected.Token(Token = "0x4005B30")]
		public const short QueenBeeBossBag = 3322;

		// Token: 0x040048E5 RID: 18661
		[global::Cpp2ILInjected.Token(Token = "0x4005B31")]
		public const short SkeletronBossBag = 3323;

		// Token: 0x040048E6 RID: 18662
		[global::Cpp2ILInjected.Token(Token = "0x4005B32")]
		public const short WallOfFleshBossBag = 3324;

		// Token: 0x040048E7 RID: 18663
		[global::Cpp2ILInjected.Token(Token = "0x4005B33")]
		public const short DestroyerBossBag = 3325;

		// Token: 0x040048E8 RID: 18664
		[global::Cpp2ILInjected.Token(Token = "0x4005B34")]
		public const short TwinsBossBag = 3326;

		// Token: 0x040048E9 RID: 18665
		[global::Cpp2ILInjected.Token(Token = "0x4005B35")]
		public const short SkeletronPrimeBossBag = 3327;

		// Token: 0x040048EA RID: 18666
		[global::Cpp2ILInjected.Token(Token = "0x4005B36")]
		public const short PlanteraBossBag = 3328;

		// Token: 0x040048EB RID: 18667
		[global::Cpp2ILInjected.Token(Token = "0x4005B37")]
		public const short GolemBossBag = 3329;

		// Token: 0x040048EC RID: 18668
		[global::Cpp2ILInjected.Token(Token = "0x4005B38")]
		public const short FishronBossBag = 3330;

		// Token: 0x040048ED RID: 18669
		[global::Cpp2ILInjected.Token(Token = "0x4005B39")]
		public const short CultistBossBag = 3331;

		// Token: 0x040048EE RID: 18670
		[global::Cpp2ILInjected.Token(Token = "0x4005B3A")]
		public const short MoonLordBossBag = 3332;

		// Token: 0x040048EF RID: 18671
		[global::Cpp2ILInjected.Token(Token = "0x4005B3B")]
		public const short HiveBackpack = 3333;

		// Token: 0x040048F0 RID: 18672
		[global::Cpp2ILInjected.Token(Token = "0x4005B3C")]
		public const short YoYoGlove = 3334;

		// Token: 0x040048F1 RID: 18673
		[global::Cpp2ILInjected.Token(Token = "0x4005B3D")]
		public const short DemonHeart = 3335;

		// Token: 0x040048F2 RID: 18674
		[global::Cpp2ILInjected.Token(Token = "0x4005B3E")]
		public const short SporeSac = 3336;

		// Token: 0x040048F3 RID: 18675
		[global::Cpp2ILInjected.Token(Token = "0x4005B3F")]
		public const short ShinyStone = 3337;

		// Token: 0x040048F4 RID: 18676
		[global::Cpp2ILInjected.Token(Token = "0x4005B40")]
		public const short HallowHardenedSand = 3338;

		// Token: 0x040048F5 RID: 18677
		[global::Cpp2ILInjected.Token(Token = "0x4005B41")]
		public const short HallowSandstone = 3339;

		// Token: 0x040048F6 RID: 18678
		[global::Cpp2ILInjected.Token(Token = "0x4005B42")]
		public const short HardenedSandWall = 3340;

		// Token: 0x040048F7 RID: 18679
		[global::Cpp2ILInjected.Token(Token = "0x4005B43")]
		public const short CorruptHardenedSandWall = 3341;

		// Token: 0x040048F8 RID: 18680
		[global::Cpp2ILInjected.Token(Token = "0x4005B44")]
		public const short CrimsonHardenedSandWall = 3342;

		// Token: 0x040048F9 RID: 18681
		[global::Cpp2ILInjected.Token(Token = "0x4005B45")]
		public const short HallowHardenedSandWall = 3343;

		// Token: 0x040048FA RID: 18682
		[global::Cpp2ILInjected.Token(Token = "0x4005B46")]
		public const short CorruptSandstoneWall = 3344;

		// Token: 0x040048FB RID: 18683
		[global::Cpp2ILInjected.Token(Token = "0x4005B47")]
		public const short CrimsonSandstoneWall = 3345;

		// Token: 0x040048FC RID: 18684
		[global::Cpp2ILInjected.Token(Token = "0x4005B48")]
		public const short HallowSandstoneWall = 3346;

		// Token: 0x040048FD RID: 18685
		[global::Cpp2ILInjected.Token(Token = "0x4005B49")]
		public const short DesertFossil = 3347;

		// Token: 0x040048FE RID: 18686
		[global::Cpp2ILInjected.Token(Token = "0x4005B4A")]
		public const short DesertFossilWall = 3348;

		// Token: 0x040048FF RID: 18687
		[global::Cpp2ILInjected.Token(Token = "0x4005B4B")]
		public const short DyeTradersScimitar = 3349;

		// Token: 0x04004900 RID: 18688
		[global::Cpp2ILInjected.Token(Token = "0x4005B4C")]
		public const short PainterPaintballGun = 3350;

		// Token: 0x04004901 RID: 18689
		[global::Cpp2ILInjected.Token(Token = "0x4005B4D")]
		public const short TaxCollectorsStickOfDoom = 3351;

		// Token: 0x04004902 RID: 18690
		[global::Cpp2ILInjected.Token(Token = "0x4005B4E")]
		public const short StylistKilLaKillScissorsIWish = 3352;

		// Token: 0x04004903 RID: 18691
		[global::Cpp2ILInjected.Token(Token = "0x4005B4F")]
		public const short MinecartMech = 3353;

		// Token: 0x04004904 RID: 18692
		[global::Cpp2ILInjected.Token(Token = "0x4005B50")]
		public const short MechanicalWheelPiece = 3354;

		// Token: 0x04004905 RID: 18693
		[global::Cpp2ILInjected.Token(Token = "0x4005B51")]
		public const short MechanicalWagonPiece = 3355;

		// Token: 0x04004906 RID: 18694
		[global::Cpp2ILInjected.Token(Token = "0x4005B52")]
		public const short MechanicalBatteryPiece = 3356;

		// Token: 0x04004907 RID: 18695
		[global::Cpp2ILInjected.Token(Token = "0x4005B53")]
		public const short AncientCultistTrophy = 3357;

		// Token: 0x04004908 RID: 18696
		[global::Cpp2ILInjected.Token(Token = "0x4005B54")]
		public const short MartianSaucerTrophy = 3358;

		// Token: 0x04004909 RID: 18697
		[global::Cpp2ILInjected.Token(Token = "0x4005B55")]
		public const short FlyingDutchmanTrophy = 3359;

		// Token: 0x0400490A RID: 18698
		[global::Cpp2ILInjected.Token(Token = "0x4005B56")]
		public const short LivingMahoganyWand = 3360;

		// Token: 0x0400490B RID: 18699
		[global::Cpp2ILInjected.Token(Token = "0x4005B57")]
		public const short LivingMahoganyLeafWand = 3361;

		// Token: 0x0400490C RID: 18700
		[global::Cpp2ILInjected.Token(Token = "0x4005B58")]
		public const short FallenTuxedoShirt = 3362;

		// Token: 0x0400490D RID: 18701
		[global::Cpp2ILInjected.Token(Token = "0x4005B59")]
		public const short FallenTuxedoPants = 3363;

		// Token: 0x0400490E RID: 18702
		[global::Cpp2ILInjected.Token(Token = "0x4005B5A")]
		public const short Fireplace = 3364;

		// Token: 0x0400490F RID: 18703
		[global::Cpp2ILInjected.Token(Token = "0x4005B5B")]
		public const short Chimney = 3365;

		// Token: 0x04004910 RID: 18704
		[global::Cpp2ILInjected.Token(Token = "0x4005B5C")]
		public const short YoyoBag = 3366;

		// Token: 0x04004911 RID: 18705
		[global::Cpp2ILInjected.Token(Token = "0x4005B5D")]
		public const short ShrimpyTruffle = 3367;

		// Token: 0x04004912 RID: 18706
		[global::Cpp2ILInjected.Token(Token = "0x4005B5E")]
		public const short Arkhalis = 3368;

		// Token: 0x04004913 RID: 18707
		[global::Cpp2ILInjected.Token(Token = "0x4005B5F")]
		public const short ConfettiCannon = 3369;

		// Token: 0x04004914 RID: 18708
		[global::Cpp2ILInjected.Token(Token = "0x4005B60")]
		public const short MusicBoxTowers = 3370;

		// Token: 0x04004915 RID: 18709
		[global::Cpp2ILInjected.Token(Token = "0x4005B61")]
		public const short MusicBoxGoblins = 3371;

		// Token: 0x04004916 RID: 18710
		[global::Cpp2ILInjected.Token(Token = "0x4005B62")]
		public const short BossMaskCultist = 3372;

		// Token: 0x04004917 RID: 18711
		[global::Cpp2ILInjected.Token(Token = "0x4005B63")]
		public const short BossMaskMoonlord = 3373;

		// Token: 0x04004918 RID: 18712
		[global::Cpp2ILInjected.Token(Token = "0x4005B64")]
		public const short FossilHelm = 3374;

		// Token: 0x04004919 RID: 18713
		[global::Cpp2ILInjected.Token(Token = "0x4005B65")]
		public const short FossilShirt = 3375;

		// Token: 0x0400491A RID: 18714
		[global::Cpp2ILInjected.Token(Token = "0x4005B66")]
		public const short FossilPants = 3376;

		// Token: 0x0400491B RID: 18715
		[global::Cpp2ILInjected.Token(Token = "0x4005B67")]
		public const short AmberStaff = 3377;

		// Token: 0x0400491C RID: 18716
		[global::Cpp2ILInjected.Token(Token = "0x4005B68")]
		public const short BoneJavelin = 3378;

		// Token: 0x0400491D RID: 18717
		[global::Cpp2ILInjected.Token(Token = "0x4005B69")]
		public const short BoneDagger = 3379;

		// Token: 0x0400491E RID: 18718
		[global::Cpp2ILInjected.Token(Token = "0x4005B6A")]
		public const short FossilOre = 3380;

		// Token: 0x0400491F RID: 18719
		[global::Cpp2ILInjected.Token(Token = "0x4005B6B")]
		public const short StardustHelmet = 3381;

		// Token: 0x04004920 RID: 18720
		[global::Cpp2ILInjected.Token(Token = "0x4005B6C")]
		public const short StardustBreastplate = 3382;

		// Token: 0x04004921 RID: 18721
		[global::Cpp2ILInjected.Token(Token = "0x4005B6D")]
		public const short StardustLeggings = 3383;

		// Token: 0x04004922 RID: 18722
		[global::Cpp2ILInjected.Token(Token = "0x4005B6E")]
		public const short PortalGun = 3384;

		// Token: 0x04004923 RID: 18723
		[global::Cpp2ILInjected.Token(Token = "0x4005B6F")]
		public const short StrangePlant1 = 3385;

		// Token: 0x04004924 RID: 18724
		[global::Cpp2ILInjected.Token(Token = "0x4005B70")]
		public const short StrangePlant2 = 3386;

		// Token: 0x04004925 RID: 18725
		[global::Cpp2ILInjected.Token(Token = "0x4005B71")]
		public const short StrangePlant3 = 3387;

		// Token: 0x04004926 RID: 18726
		[global::Cpp2ILInjected.Token(Token = "0x4005B72")]
		public const short StrangePlant4 = 3388;

		// Token: 0x04004927 RID: 18727
		[global::Cpp2ILInjected.Token(Token = "0x4005B73")]
		public const short Terrarian = 3389;

		// Token: 0x04004928 RID: 18728
		[global::Cpp2ILInjected.Token(Token = "0x4005B74")]
		public const short GoblinSummonerBanner = 3390;

		// Token: 0x04004929 RID: 18729
		[global::Cpp2ILInjected.Token(Token = "0x4005B75")]
		public const short SalamanderBanner = 3391;

		// Token: 0x0400492A RID: 18730
		[global::Cpp2ILInjected.Token(Token = "0x4005B76")]
		public const short GiantShellyBanner = 3392;

		// Token: 0x0400492B RID: 18731
		[global::Cpp2ILInjected.Token(Token = "0x4005B77")]
		public const short CrawdadBanner = 3393;

		// Token: 0x0400492C RID: 18732
		[global::Cpp2ILInjected.Token(Token = "0x4005B78")]
		public const short FritzBanner = 3394;

		// Token: 0x0400492D RID: 18733
		[global::Cpp2ILInjected.Token(Token = "0x4005B79")]
		public const short CreatureFromTheDeepBanner = 3395;

		// Token: 0x0400492E RID: 18734
		[global::Cpp2ILInjected.Token(Token = "0x4005B7A")]
		public const short DrManFlyBanner = 3396;

		// Token: 0x0400492F RID: 18735
		[global::Cpp2ILInjected.Token(Token = "0x4005B7B")]
		public const short MothronBanner = 3397;

		// Token: 0x04004930 RID: 18736
		[global::Cpp2ILInjected.Token(Token = "0x4005B7C")]
		public const short SeveredHandBanner = 3398;

		// Token: 0x04004931 RID: 18737
		[global::Cpp2ILInjected.Token(Token = "0x4005B7D")]
		public const short ThePossessedBanner = 3399;

		// Token: 0x04004932 RID: 18738
		[global::Cpp2ILInjected.Token(Token = "0x4005B7E")]
		public const short ButcherBanner = 3400;

		// Token: 0x04004933 RID: 18739
		[global::Cpp2ILInjected.Token(Token = "0x4005B7F")]
		public const short PsychoBanner = 3401;

		// Token: 0x04004934 RID: 18740
		[global::Cpp2ILInjected.Token(Token = "0x4005B80")]
		public const short DeadlySphereBanner = 3402;

		// Token: 0x04004935 RID: 18741
		[global::Cpp2ILInjected.Token(Token = "0x4005B81")]
		public const short NailheadBanner = 3403;

		// Token: 0x04004936 RID: 18742
		[global::Cpp2ILInjected.Token(Token = "0x4005B82")]
		public const short PoisonousSporeBanner = 3404;

		// Token: 0x04004937 RID: 18743
		[global::Cpp2ILInjected.Token(Token = "0x4005B83")]
		public const short MedusaBanner = 3405;

		// Token: 0x04004938 RID: 18744
		[global::Cpp2ILInjected.Token(Token = "0x4005B84")]
		public const short GreekSkeletonBanner = 3406;

		// Token: 0x04004939 RID: 18745
		[global::Cpp2ILInjected.Token(Token = "0x4005B85")]
		public const short GraniteFlyerBanner = 3407;

		// Token: 0x0400493A RID: 18746
		[global::Cpp2ILInjected.Token(Token = "0x4005B86")]
		public const short GraniteGolemBanner = 3408;

		// Token: 0x0400493B RID: 18747
		[global::Cpp2ILInjected.Token(Token = "0x4005B87")]
		public const short BloodZombieBanner = 3409;

		// Token: 0x0400493C RID: 18748
		[global::Cpp2ILInjected.Token(Token = "0x4005B88")]
		public const short DripplerBanner = 3410;

		// Token: 0x0400493D RID: 18749
		[global::Cpp2ILInjected.Token(Token = "0x4005B89")]
		public const short TombCrawlerBanner = 3411;

		// Token: 0x0400493E RID: 18750
		[global::Cpp2ILInjected.Token(Token = "0x4005B8A")]
		public const short DuneSplicerBanner = 3412;

		// Token: 0x0400493F RID: 18751
		[global::Cpp2ILInjected.Token(Token = "0x4005B8B")]
		public const short FlyingAntlionBanner = 3413;

		// Token: 0x04004940 RID: 18752
		[global::Cpp2ILInjected.Token(Token = "0x4005B8C")]
		public const short WalkingAntlionBanner = 3414;

		// Token: 0x04004941 RID: 18753
		[global::Cpp2ILInjected.Token(Token = "0x4005B8D")]
		public const short DesertGhoulBanner = 3415;

		// Token: 0x04004942 RID: 18754
		[global::Cpp2ILInjected.Token(Token = "0x4005B8E")]
		public const short DesertLamiaBanner = 3416;

		// Token: 0x04004943 RID: 18755
		[global::Cpp2ILInjected.Token(Token = "0x4005B8F")]
		public const short DesertDjinnBanner = 3417;

		// Token: 0x04004944 RID: 18756
		[global::Cpp2ILInjected.Token(Token = "0x4005B90")]
		public const short DesertBasiliskBanner = 3418;

		// Token: 0x04004945 RID: 18757
		[global::Cpp2ILInjected.Token(Token = "0x4005B91")]
		public const short RavagerScorpionBanner = 3419;

		// Token: 0x04004946 RID: 18758
		[global::Cpp2ILInjected.Token(Token = "0x4005B92")]
		public const short StardustSoldierBanner = 3420;

		// Token: 0x04004947 RID: 18759
		[global::Cpp2ILInjected.Token(Token = "0x4005B93")]
		public const short StardustWormBanner = 3421;

		// Token: 0x04004948 RID: 18760
		[global::Cpp2ILInjected.Token(Token = "0x4005B94")]
		public const short StardustJellyfishBanner = 3422;

		// Token: 0x04004949 RID: 18761
		[global::Cpp2ILInjected.Token(Token = "0x4005B95")]
		public const short StardustSpiderBanner = 3423;

		// Token: 0x0400494A RID: 18762
		[global::Cpp2ILInjected.Token(Token = "0x4005B96")]
		public const short StardustSmallCellBanner = 3424;

		// Token: 0x0400494B RID: 18763
		[global::Cpp2ILInjected.Token(Token = "0x4005B97")]
		public const short StardustLargeCellBanner = 3425;

		// Token: 0x0400494C RID: 18764
		[global::Cpp2ILInjected.Token(Token = "0x4005B98")]
		public const short SolarCoriteBanner = 3426;

		// Token: 0x0400494D RID: 18765
		[global::Cpp2ILInjected.Token(Token = "0x4005B99")]
		public const short SolarSrollerBanner = 3427;

		// Token: 0x0400494E RID: 18766
		[global::Cpp2ILInjected.Token(Token = "0x4005B9A")]
		public const short SolarCrawltipedeBanner = 3428;

		// Token: 0x0400494F RID: 18767
		[global::Cpp2ILInjected.Token(Token = "0x4005B9B")]
		public const short SolarDrakomireRiderBanner = 3429;

		// Token: 0x04004950 RID: 18768
		[global::Cpp2ILInjected.Token(Token = "0x4005B9C")]
		public const short SolarDrakomireBanner = 3430;

		// Token: 0x04004951 RID: 18769
		[global::Cpp2ILInjected.Token(Token = "0x4005B9D")]
		public const short SolarSolenianBanner = 3431;

		// Token: 0x04004952 RID: 18770
		[global::Cpp2ILInjected.Token(Token = "0x4005B9E")]
		public const short NebulaSoldierBanner = 3432;

		// Token: 0x04004953 RID: 18771
		[global::Cpp2ILInjected.Token(Token = "0x4005B9F")]
		public const short NebulaHeadcrabBanner = 3433;

		// Token: 0x04004954 RID: 18772
		[global::Cpp2ILInjected.Token(Token = "0x4005BA0")]
		public const short NebulaBrainBanner = 3434;

		// Token: 0x04004955 RID: 18773
		[global::Cpp2ILInjected.Token(Token = "0x4005BA1")]
		public const short NebulaBeastBanner = 3435;

		// Token: 0x04004956 RID: 18774
		[global::Cpp2ILInjected.Token(Token = "0x4005BA2")]
		public const short VortexLarvaBanner = 3436;

		// Token: 0x04004957 RID: 18775
		[global::Cpp2ILInjected.Token(Token = "0x4005BA3")]
		public const short VortexHornetQueenBanner = 3437;

		// Token: 0x04004958 RID: 18776
		[global::Cpp2ILInjected.Token(Token = "0x4005BA4")]
		public const short VortexHornetBanner = 3438;

		// Token: 0x04004959 RID: 18777
		[global::Cpp2ILInjected.Token(Token = "0x4005BA5")]
		public const short VortexSoldierBanner = 3439;

		// Token: 0x0400495A RID: 18778
		[global::Cpp2ILInjected.Token(Token = "0x4005BA6")]
		public const short VortexRiflemanBanner = 3440;

		// Token: 0x0400495B RID: 18779
		[global::Cpp2ILInjected.Token(Token = "0x4005BA7")]
		public const short PirateCaptainBanner = 3441;

		// Token: 0x0400495C RID: 18780
		[global::Cpp2ILInjected.Token(Token = "0x4005BA8")]
		public const short PirateDeadeyeBanner = 3442;

		// Token: 0x0400495D RID: 18781
		[global::Cpp2ILInjected.Token(Token = "0x4005BA9")]
		public const short PirateCorsairBanner = 3443;

		// Token: 0x0400495E RID: 18782
		[global::Cpp2ILInjected.Token(Token = "0x4005BAA")]
		public const short PirateCrossbowerBanner = 3444;

		// Token: 0x0400495F RID: 18783
		[global::Cpp2ILInjected.Token(Token = "0x4005BAB")]
		public const short MartianWalkerBanner = 3445;

		// Token: 0x04004960 RID: 18784
		[global::Cpp2ILInjected.Token(Token = "0x4005BAC")]
		public const short RedDevilBanner = 3446;

		// Token: 0x04004961 RID: 18785
		[global::Cpp2ILInjected.Token(Token = "0x4005BAD")]
		public const short PinkJellyfishBanner = 3447;

		// Token: 0x04004962 RID: 18786
		[global::Cpp2ILInjected.Token(Token = "0x4005BAE")]
		public const short GreenJellyfishBanner = 3448;

		// Token: 0x04004963 RID: 18787
		[global::Cpp2ILInjected.Token(Token = "0x4005BAF")]
		public const short DarkMummyBanner = 3449;

		// Token: 0x04004964 RID: 18788
		[global::Cpp2ILInjected.Token(Token = "0x4005BB0")]
		public const short LightMummyBanner = 3450;

		// Token: 0x04004965 RID: 18789
		[global::Cpp2ILInjected.Token(Token = "0x4005BB1")]
		public const short AngryBonesBanner = 3451;

		// Token: 0x04004966 RID: 18790
		[global::Cpp2ILInjected.Token(Token = "0x4005BB2")]
		public const short IceTortoiseBanner = 3452;

		// Token: 0x04004967 RID: 18791
		[global::Cpp2ILInjected.Token(Token = "0x4005BB3")]
		public const short NebulaPickup1 = 3453;

		// Token: 0x04004968 RID: 18792
		[global::Cpp2ILInjected.Token(Token = "0x4005BB4")]
		public const short NebulaPickup2 = 3454;

		// Token: 0x04004969 RID: 18793
		[global::Cpp2ILInjected.Token(Token = "0x4005BB5")]
		public const short NebulaPickup3 = 3455;

		// Token: 0x0400496A RID: 18794
		[global::Cpp2ILInjected.Token(Token = "0x4005BB6")]
		public const short FragmentVortex = 3456;

		// Token: 0x0400496B RID: 18795
		[global::Cpp2ILInjected.Token(Token = "0x4005BB7")]
		public const short FragmentNebula = 3457;

		// Token: 0x0400496C RID: 18796
		[global::Cpp2ILInjected.Token(Token = "0x4005BB8")]
		public const short FragmentSolar = 3458;

		// Token: 0x0400496D RID: 18797
		[global::Cpp2ILInjected.Token(Token = "0x4005BB9")]
		public const short FragmentStardust = 3459;

		// Token: 0x0400496E RID: 18798
		[global::Cpp2ILInjected.Token(Token = "0x4005BBA")]
		public const short LunarOre = 3460;

		// Token: 0x0400496F RID: 18799
		[global::Cpp2ILInjected.Token(Token = "0x4005BBB")]
		public const short LunarBrick = 3461;

		// Token: 0x04004970 RID: 18800
		[global::Cpp2ILInjected.Token(Token = "0x4005BBC")]
		public const short StardustAxe = 3462;

		// Token: 0x04004971 RID: 18801
		[global::Cpp2ILInjected.Token(Token = "0x4005BBD")]
		public const short StardustChainsaw = 3463;

		// Token: 0x04004972 RID: 18802
		[global::Cpp2ILInjected.Token(Token = "0x4005BBE")]
		public const short StardustDrill = 3464;

		// Token: 0x04004973 RID: 18803
		[global::Cpp2ILInjected.Token(Token = "0x4005BBF")]
		public const short StardustHammer = 3465;

		// Token: 0x04004974 RID: 18804
		[global::Cpp2ILInjected.Token(Token = "0x4005BC0")]
		public const short StardustPickaxe = 3466;

		// Token: 0x04004975 RID: 18805
		[global::Cpp2ILInjected.Token(Token = "0x4005BC1")]
		public const short LunarBar = 3467;

		// Token: 0x04004976 RID: 18806
		[global::Cpp2ILInjected.Token(Token = "0x4005BC2")]
		public const short WingsSolar = 3468;

		// Token: 0x04004977 RID: 18807
		[global::Cpp2ILInjected.Token(Token = "0x4005BC3")]
		public const short WingsVortex = 3469;

		// Token: 0x04004978 RID: 18808
		[global::Cpp2ILInjected.Token(Token = "0x4005BC4")]
		public const short WingsNebula = 3470;

		// Token: 0x04004979 RID: 18809
		[global::Cpp2ILInjected.Token(Token = "0x4005BC5")]
		public const short WingsStardust = 3471;

		// Token: 0x0400497A RID: 18810
		[global::Cpp2ILInjected.Token(Token = "0x4005BC6")]
		public const short LunarBrickWall = 3472;

		// Token: 0x0400497B RID: 18811
		[global::Cpp2ILInjected.Token(Token = "0x4005BC7")]
		public const short SolarEruption = 3473;

		// Token: 0x0400497C RID: 18812
		[global::Cpp2ILInjected.Token(Token = "0x4005BC8")]
		public const short StardustCellStaff = 3474;

		// Token: 0x0400497D RID: 18813
		[global::Cpp2ILInjected.Token(Token = "0x4005BC9")]
		public const short VortexBeater = 3475;

		// Token: 0x0400497E RID: 18814
		[global::Cpp2ILInjected.Token(Token = "0x4005BCA")]
		public const short NebulaArcanum = 3476;

		// Token: 0x0400497F RID: 18815
		[global::Cpp2ILInjected.Token(Token = "0x4005BCB")]
		public const short BloodWater = 3477;

		// Token: 0x04004980 RID: 18816
		[global::Cpp2ILInjected.Token(Token = "0x4005BCC")]
		public const short TheBrideHat = 3478;

		// Token: 0x04004981 RID: 18817
		[global::Cpp2ILInjected.Token(Token = "0x4005BCD")]
		public const short TheBrideDress = 3479;

		// Token: 0x04004982 RID: 18818
		[global::Cpp2ILInjected.Token(Token = "0x4005BCE")]
		public const short PlatinumBow = 3480;

		// Token: 0x04004983 RID: 18819
		[global::Cpp2ILInjected.Token(Token = "0x4005BCF")]
		public const short PlatinumHammer = 3481;

		// Token: 0x04004984 RID: 18820
		[global::Cpp2ILInjected.Token(Token = "0x4005BD0")]
		public const short PlatinumAxe = 3482;

		// Token: 0x04004985 RID: 18821
		[global::Cpp2ILInjected.Token(Token = "0x4005BD1")]
		public const short PlatinumShortsword = 3483;

		// Token: 0x04004986 RID: 18822
		[global::Cpp2ILInjected.Token(Token = "0x4005BD2")]
		public const short PlatinumBroadsword = 3484;

		// Token: 0x04004987 RID: 18823
		[global::Cpp2ILInjected.Token(Token = "0x4005BD3")]
		public const short PlatinumPickaxe = 3485;

		// Token: 0x04004988 RID: 18824
		[global::Cpp2ILInjected.Token(Token = "0x4005BD4")]
		public const short TungstenBow = 3486;

		// Token: 0x04004989 RID: 18825
		[global::Cpp2ILInjected.Token(Token = "0x4005BD5")]
		public const short TungstenHammer = 3487;

		// Token: 0x0400498A RID: 18826
		[global::Cpp2ILInjected.Token(Token = "0x4005BD6")]
		public const short TungstenAxe = 3488;

		// Token: 0x0400498B RID: 18827
		[global::Cpp2ILInjected.Token(Token = "0x4005BD7")]
		public const short TungstenShortsword = 3489;

		// Token: 0x0400498C RID: 18828
		[global::Cpp2ILInjected.Token(Token = "0x4005BD8")]
		public const short TungstenBroadsword = 3490;

		// Token: 0x0400498D RID: 18829
		[global::Cpp2ILInjected.Token(Token = "0x4005BD9")]
		public const short TungstenPickaxe = 3491;

		// Token: 0x0400498E RID: 18830
		[global::Cpp2ILInjected.Token(Token = "0x4005BDA")]
		public const short LeadBow = 3492;

		// Token: 0x0400498F RID: 18831
		[global::Cpp2ILInjected.Token(Token = "0x4005BDB")]
		public const short LeadHammer = 3493;

		// Token: 0x04004990 RID: 18832
		[global::Cpp2ILInjected.Token(Token = "0x4005BDC")]
		public const short LeadAxe = 3494;

		// Token: 0x04004991 RID: 18833
		[global::Cpp2ILInjected.Token(Token = "0x4005BDD")]
		public const short LeadShortsword = 3495;

		// Token: 0x04004992 RID: 18834
		[global::Cpp2ILInjected.Token(Token = "0x4005BDE")]
		public const short LeadBroadsword = 3496;

		// Token: 0x04004993 RID: 18835
		[global::Cpp2ILInjected.Token(Token = "0x4005BDF")]
		public const short LeadPickaxe = 3497;

		// Token: 0x04004994 RID: 18836
		[global::Cpp2ILInjected.Token(Token = "0x4005BE0")]
		public const short TinBow = 3498;

		// Token: 0x04004995 RID: 18837
		[global::Cpp2ILInjected.Token(Token = "0x4005BE1")]
		public const short TinHammer = 3499;

		// Token: 0x04004996 RID: 18838
		[global::Cpp2ILInjected.Token(Token = "0x4005BE2")]
		public const short TinAxe = 3500;

		// Token: 0x04004997 RID: 18839
		[global::Cpp2ILInjected.Token(Token = "0x4005BE3")]
		public const short TinShortsword = 3501;

		// Token: 0x04004998 RID: 18840
		[global::Cpp2ILInjected.Token(Token = "0x4005BE4")]
		public const short TinBroadsword = 3502;

		// Token: 0x04004999 RID: 18841
		[global::Cpp2ILInjected.Token(Token = "0x4005BE5")]
		public const short TinPickaxe = 3503;

		// Token: 0x0400499A RID: 18842
		[global::Cpp2ILInjected.Token(Token = "0x4005BE6")]
		public const short CopperBow = 3504;

		// Token: 0x0400499B RID: 18843
		[global::Cpp2ILInjected.Token(Token = "0x4005BE7")]
		public const short CopperHammer = 3505;

		// Token: 0x0400499C RID: 18844
		[global::Cpp2ILInjected.Token(Token = "0x4005BE8")]
		public const short CopperAxe = 3506;

		// Token: 0x0400499D RID: 18845
		[global::Cpp2ILInjected.Token(Token = "0x4005BE9")]
		public const short CopperShortsword = 3507;

		// Token: 0x0400499E RID: 18846
		[global::Cpp2ILInjected.Token(Token = "0x4005BEA")]
		public const short CopperBroadsword = 3508;

		// Token: 0x0400499F RID: 18847
		[global::Cpp2ILInjected.Token(Token = "0x4005BEB")]
		public const short CopperPickaxe = 3509;

		// Token: 0x040049A0 RID: 18848
		[global::Cpp2ILInjected.Token(Token = "0x4005BEC")]
		public const short SilverBow = 3510;

		// Token: 0x040049A1 RID: 18849
		[global::Cpp2ILInjected.Token(Token = "0x4005BED")]
		public const short SilverHammer = 3511;

		// Token: 0x040049A2 RID: 18850
		[global::Cpp2ILInjected.Token(Token = "0x4005BEE")]
		public const short SilverAxe = 3512;

		// Token: 0x040049A3 RID: 18851
		[global::Cpp2ILInjected.Token(Token = "0x4005BEF")]
		public const short SilverShortsword = 3513;

		// Token: 0x040049A4 RID: 18852
		[global::Cpp2ILInjected.Token(Token = "0x4005BF0")]
		public const short SilverBroadsword = 3514;

		// Token: 0x040049A5 RID: 18853
		[global::Cpp2ILInjected.Token(Token = "0x4005BF1")]
		public const short SilverPickaxe = 3515;

		// Token: 0x040049A6 RID: 18854
		[global::Cpp2ILInjected.Token(Token = "0x4005BF2")]
		public const short GoldBow = 3516;

		// Token: 0x040049A7 RID: 18855
		[global::Cpp2ILInjected.Token(Token = "0x4005BF3")]
		public const short GoldHammer = 3517;

		// Token: 0x040049A8 RID: 18856
		[global::Cpp2ILInjected.Token(Token = "0x4005BF4")]
		public const short GoldAxe = 3518;

		// Token: 0x040049A9 RID: 18857
		[global::Cpp2ILInjected.Token(Token = "0x4005BF5")]
		public const short GoldShortsword = 3519;

		// Token: 0x040049AA RID: 18858
		[global::Cpp2ILInjected.Token(Token = "0x4005BF6")]
		public const short GoldBroadsword = 3520;

		// Token: 0x040049AB RID: 18859
		[global::Cpp2ILInjected.Token(Token = "0x4005BF7")]
		public const short GoldPickaxe = 3521;

		// Token: 0x040049AC RID: 18860
		[global::Cpp2ILInjected.Token(Token = "0x4005BF8")]
		public const short LunarHamaxeSolar = 3522;

		// Token: 0x040049AD RID: 18861
		[global::Cpp2ILInjected.Token(Token = "0x4005BF9")]
		public const short LunarHamaxeVortex = 3523;

		// Token: 0x040049AE RID: 18862
		[global::Cpp2ILInjected.Token(Token = "0x4005BFA")]
		public const short LunarHamaxeNebula = 3524;

		// Token: 0x040049AF RID: 18863
		[global::Cpp2ILInjected.Token(Token = "0x4005BFB")]
		public const short LunarHamaxeStardust = 3525;

		// Token: 0x040049B0 RID: 18864
		[global::Cpp2ILInjected.Token(Token = "0x4005BFC")]
		public const short SolarDye = 3526;

		// Token: 0x040049B1 RID: 18865
		[global::Cpp2ILInjected.Token(Token = "0x4005BFD")]
		public const short NebulaDye = 3527;

		// Token: 0x040049B2 RID: 18866
		[global::Cpp2ILInjected.Token(Token = "0x4005BFE")]
		public const short VortexDye = 3528;

		// Token: 0x040049B3 RID: 18867
		[global::Cpp2ILInjected.Token(Token = "0x4005BFF")]
		public const short StardustDye = 3529;

		// Token: 0x040049B4 RID: 18868
		[global::Cpp2ILInjected.Token(Token = "0x4005C00")]
		public const short VoidDye = 3530;

		// Token: 0x040049B5 RID: 18869
		[global::Cpp2ILInjected.Token(Token = "0x4005C01")]
		public const short StardustDragonStaff = 3531;

		// Token: 0x040049B6 RID: 18870
		[global::Cpp2ILInjected.Token(Token = "0x4005C02")]
		public const short Bacon = 3532;

		// Token: 0x040049B7 RID: 18871
		[global::Cpp2ILInjected.Token(Token = "0x4005C03")]
		public const short ShiftingSandsDye = 3533;

		// Token: 0x040049B8 RID: 18872
		[global::Cpp2ILInjected.Token(Token = "0x4005C04")]
		public const short MirageDye = 3534;

		// Token: 0x040049B9 RID: 18873
		[global::Cpp2ILInjected.Token(Token = "0x4005C05")]
		public const short ShiftingPearlSandsDye = 3535;

		// Token: 0x040049BA RID: 18874
		[global::Cpp2ILInjected.Token(Token = "0x4005C06")]
		public const short VortexMonolith = 3536;

		// Token: 0x040049BB RID: 18875
		[global::Cpp2ILInjected.Token(Token = "0x4005C07")]
		public const short NebulaMonolith = 3537;

		// Token: 0x040049BC RID: 18876
		[global::Cpp2ILInjected.Token(Token = "0x4005C08")]
		public const short StardustMonolith = 3538;

		// Token: 0x040049BD RID: 18877
		[global::Cpp2ILInjected.Token(Token = "0x4005C09")]
		public const short SolarMonolith = 3539;

		// Token: 0x040049BE RID: 18878
		[global::Cpp2ILInjected.Token(Token = "0x4005C0A")]
		public const short Phantasm = 3540;

		// Token: 0x040049BF RID: 18879
		[global::Cpp2ILInjected.Token(Token = "0x4005C0B")]
		public const short LastPrism = 3541;

		// Token: 0x040049C0 RID: 18880
		[global::Cpp2ILInjected.Token(Token = "0x4005C0C")]
		public const short NebulaBlaze = 3542;

		// Token: 0x040049C1 RID: 18881
		[global::Cpp2ILInjected.Token(Token = "0x4005C0D")]
		public const short DayBreak = 3543;

		// Token: 0x040049C2 RID: 18882
		[global::Cpp2ILInjected.Token(Token = "0x4005C0E")]
		public const short SuperHealingPotion = 3544;

		// Token: 0x040049C3 RID: 18883
		[global::Cpp2ILInjected.Token(Token = "0x4005C0F")]
		public const short Detonator = 3545;

		// Token: 0x040049C4 RID: 18884
		[global::Cpp2ILInjected.Token(Token = "0x4005C10")]
		public const short FireworksLauncher = 3546;

		// Token: 0x040049C5 RID: 18885
		[global::Cpp2ILInjected.Token(Token = "0x4005C11")]
		public const short BouncyDynamite = 3547;

		// Token: 0x040049C6 RID: 18886
		[global::Cpp2ILInjected.Token(Token = "0x4005C12")]
		public const short PartyGirlGrenade = 3548;

		// Token: 0x040049C7 RID: 18887
		[global::Cpp2ILInjected.Token(Token = "0x4005C13")]
		public const short LunarCraftingStation = 3549;

		// Token: 0x040049C8 RID: 18888
		[global::Cpp2ILInjected.Token(Token = "0x4005C14")]
		public const short FlameAndSilverDye = 3550;

		// Token: 0x040049C9 RID: 18889
		[global::Cpp2ILInjected.Token(Token = "0x4005C15")]
		public const short GreenFlameAndSilverDye = 3551;

		// Token: 0x040049CA RID: 18890
		[global::Cpp2ILInjected.Token(Token = "0x4005C16")]
		public const short BlueFlameAndSilverDye = 3552;

		// Token: 0x040049CB RID: 18891
		[global::Cpp2ILInjected.Token(Token = "0x4005C17")]
		public const short ReflectiveCopperDye = 3553;

		// Token: 0x040049CC RID: 18892
		[global::Cpp2ILInjected.Token(Token = "0x4005C18")]
		public const short ReflectiveObsidianDye = 3554;

		// Token: 0x040049CD RID: 18893
		[global::Cpp2ILInjected.Token(Token = "0x4005C19")]
		public const short ReflectiveMetalDye = 3555;

		// Token: 0x040049CE RID: 18894
		[global::Cpp2ILInjected.Token(Token = "0x4005C1A")]
		public const short MidnightRainbowDye = 3556;

		// Token: 0x040049CF RID: 18895
		[global::Cpp2ILInjected.Token(Token = "0x4005C1B")]
		public const short BlackAndWhiteDye = 3557;

		// Token: 0x040049D0 RID: 18896
		[global::Cpp2ILInjected.Token(Token = "0x4005C1C")]
		public const short BrightSilverDye = 3558;

		// Token: 0x040049D1 RID: 18897
		[global::Cpp2ILInjected.Token(Token = "0x4005C1D")]
		public const short SilverAndBlackDye = 3559;

		// Token: 0x040049D2 RID: 18898
		[global::Cpp2ILInjected.Token(Token = "0x4005C1E")]
		public const short RedAcidDye = 3560;

		// Token: 0x040049D3 RID: 18899
		[global::Cpp2ILInjected.Token(Token = "0x4005C1F")]
		public const short GelDye = 3561;

		// Token: 0x040049D4 RID: 18900
		[global::Cpp2ILInjected.Token(Token = "0x4005C20")]
		public const short PinkGelDye = 3562;

		// Token: 0x040049D5 RID: 18901
		[global::Cpp2ILInjected.Token(Token = "0x4005C21")]
		public const short SquirrelRed = 3563;

		// Token: 0x040049D6 RID: 18902
		[global::Cpp2ILInjected.Token(Token = "0x4005C22")]
		public const short SquirrelGold = 3564;

		// Token: 0x040049D7 RID: 18903
		[global::Cpp2ILInjected.Token(Token = "0x4005C23")]
		public const short SquirrelOrangeCage = 3565;

		// Token: 0x040049D8 RID: 18904
		[global::Cpp2ILInjected.Token(Token = "0x4005C24")]
		public const short SquirrelGoldCage = 3566;

		// Token: 0x040049D9 RID: 18905
		[global::Cpp2ILInjected.Token(Token = "0x4005C25")]
		public const short MoonlordBullet = 3567;

		// Token: 0x040049DA RID: 18906
		[global::Cpp2ILInjected.Token(Token = "0x4005C26")]
		public const short MoonlordArrow = 3568;

		// Token: 0x040049DB RID: 18907
		[global::Cpp2ILInjected.Token(Token = "0x4005C27")]
		public const short MoonlordTurretStaff = 3569;

		// Token: 0x040049DC RID: 18908
		[global::Cpp2ILInjected.Token(Token = "0x4005C28")]
		public const short LunarFlareBook = 3570;

		// Token: 0x040049DD RID: 18909
		[global::Cpp2ILInjected.Token(Token = "0x4005C29")]
		public const short RainbowCrystalStaff = 3571;

		// Token: 0x040049DE RID: 18910
		[global::Cpp2ILInjected.Token(Token = "0x4005C2A")]
		public const short LunarHook = 3572;

		// Token: 0x040049DF RID: 18911
		[global::Cpp2ILInjected.Token(Token = "0x4005C2B")]
		public const short LunarBlockSolar = 3573;

		// Token: 0x040049E0 RID: 18912
		[global::Cpp2ILInjected.Token(Token = "0x4005C2C")]
		public const short LunarBlockVortex = 3574;

		// Token: 0x040049E1 RID: 18913
		[global::Cpp2ILInjected.Token(Token = "0x4005C2D")]
		public const short LunarBlockNebula = 3575;

		// Token: 0x040049E2 RID: 18914
		[global::Cpp2ILInjected.Token(Token = "0x4005C2E")]
		public const short LunarBlockStardust = 3576;

		// Token: 0x040049E3 RID: 18915
		[global::Cpp2ILInjected.Token(Token = "0x4005C2F")]
		public const short SuspiciousLookingTentacle = 3577;

		// Token: 0x040049E4 RID: 18916
		[global::Cpp2ILInjected.Token(Token = "0x4005C30")]
		public const short Yoraiz0rShirt = 3578;

		// Token: 0x040049E5 RID: 18917
		[global::Cpp2ILInjected.Token(Token = "0x4005C31")]
		public const short Yoraiz0rPants = 3579;

		// Token: 0x040049E6 RID: 18918
		[global::Cpp2ILInjected.Token(Token = "0x4005C32")]
		public const short Yoraiz0rWings = 3580;

		// Token: 0x040049E7 RID: 18919
		[global::Cpp2ILInjected.Token(Token = "0x4005C33")]
		public const short Yoraiz0rDarkness = 3581;

		// Token: 0x040049E8 RID: 18920
		[global::Cpp2ILInjected.Token(Token = "0x4005C34")]
		public const short JimsWings = 3582;

		// Token: 0x040049E9 RID: 18921
		[global::Cpp2ILInjected.Token(Token = "0x4005C35")]
		public const short Yoraiz0rHead = 3583;

		// Token: 0x040049EA RID: 18922
		[global::Cpp2ILInjected.Token(Token = "0x4005C36")]
		public const short LivingLeafWall = 3584;

		// Token: 0x040049EB RID: 18923
		[global::Cpp2ILInjected.Token(Token = "0x4005C37")]
		public const short SkiphsHelm = 3585;

		// Token: 0x040049EC RID: 18924
		[global::Cpp2ILInjected.Token(Token = "0x4005C38")]
		public const short SkiphsShirt = 3586;

		// Token: 0x040049ED RID: 18925
		[global::Cpp2ILInjected.Token(Token = "0x4005C39")]
		public const short SkiphsPants = 3587;

		// Token: 0x040049EE RID: 18926
		[global::Cpp2ILInjected.Token(Token = "0x4005C3A")]
		public const short SkiphsWings = 3588;

		// Token: 0x040049EF RID: 18927
		[global::Cpp2ILInjected.Token(Token = "0x4005C3B")]
		public const short LokisHelm = 3589;

		// Token: 0x040049F0 RID: 18928
		[global::Cpp2ILInjected.Token(Token = "0x4005C3C")]
		public const short LokisShirt = 3590;

		// Token: 0x040049F1 RID: 18929
		[global::Cpp2ILInjected.Token(Token = "0x4005C3D")]
		public const short LokisPants = 3591;

		// Token: 0x040049F2 RID: 18930
		[global::Cpp2ILInjected.Token(Token = "0x4005C3E")]
		public const short LokisWings = 3592;

		// Token: 0x040049F3 RID: 18931
		[global::Cpp2ILInjected.Token(Token = "0x4005C3F")]
		public const short SandSlimeBanner = 3593;

		// Token: 0x040049F4 RID: 18932
		[global::Cpp2ILInjected.Token(Token = "0x4005C40")]
		public const short SeaSnailBanner = 3594;

		// Token: 0x040049F5 RID: 18933
		[global::Cpp2ILInjected.Token(Token = "0x4005C41")]
		public const short MoonLordTrophy = 3595;

		// Token: 0x040049F6 RID: 18934
		[global::Cpp2ILInjected.Token(Token = "0x4005C42")]
		public const short MoonLordPainting = 3596;

		// Token: 0x040049F7 RID: 18935
		[global::Cpp2ILInjected.Token(Token = "0x4005C43")]
		public const short BurningHadesDye = 3597;

		// Token: 0x040049F8 RID: 18936
		[global::Cpp2ILInjected.Token(Token = "0x4005C44")]
		public const short GrimDye = 3598;

		// Token: 0x040049F9 RID: 18937
		[global::Cpp2ILInjected.Token(Token = "0x4005C45")]
		public const short LokisDye = 3599;

		// Token: 0x040049FA RID: 18938
		[global::Cpp2ILInjected.Token(Token = "0x4005C46")]
		public const short ShadowflameHadesDye = 3600;

		// Token: 0x040049FB RID: 18939
		[global::Cpp2ILInjected.Token(Token = "0x4005C47")]
		public const short CelestialSigil = 3601;

		// Token: 0x040049FC RID: 18940
		[global::Cpp2ILInjected.Token(Token = "0x4005C48")]
		public const short LogicGateLamp_Off = 3602;

		// Token: 0x040049FD RID: 18941
		[global::Cpp2ILInjected.Token(Token = "0x4005C49")]
		public const short LogicGate_AND = 3603;

		// Token: 0x040049FE RID: 18942
		[global::Cpp2ILInjected.Token(Token = "0x4005C4A")]
		public const short LogicGate_OR = 3604;

		// Token: 0x040049FF RID: 18943
		[global::Cpp2ILInjected.Token(Token = "0x4005C4B")]
		public const short LogicGate_NAND = 3605;

		// Token: 0x04004A00 RID: 18944
		[global::Cpp2ILInjected.Token(Token = "0x4005C4C")]
		public const short LogicGate_NOR = 3606;

		// Token: 0x04004A01 RID: 18945
		[global::Cpp2ILInjected.Token(Token = "0x4005C4D")]
		public const short LogicGate_XOR = 3607;

		// Token: 0x04004A02 RID: 18946
		[global::Cpp2ILInjected.Token(Token = "0x4005C4E")]
		public const short LogicGate_NXOR = 3608;

		// Token: 0x04004A03 RID: 18947
		[global::Cpp2ILInjected.Token(Token = "0x4005C4F")]
		public const short ConveyorBeltLeft = 3609;

		// Token: 0x04004A04 RID: 18948
		[global::Cpp2ILInjected.Token(Token = "0x4005C50")]
		public const short ConveyorBeltRight = 3610;

		// Token: 0x04004A05 RID: 18949
		[global::Cpp2ILInjected.Token(Token = "0x4005C51")]
		public const short WireKite = 3611;

		// Token: 0x04004A06 RID: 18950
		[global::Cpp2ILInjected.Token(Token = "0x4005C52")]
		public const short YellowWrench = 3612;

		// Token: 0x04004A07 RID: 18951
		[global::Cpp2ILInjected.Token(Token = "0x4005C53")]
		public const short LogicSensor_Sun = 3613;

		// Token: 0x04004A08 RID: 18952
		[global::Cpp2ILInjected.Token(Token = "0x4005C54")]
		public const short LogicSensor_Moon = 3614;

		// Token: 0x04004A09 RID: 18953
		[global::Cpp2ILInjected.Token(Token = "0x4005C55")]
		public const short LogicSensor_Above = 3615;

		// Token: 0x04004A0A RID: 18954
		[global::Cpp2ILInjected.Token(Token = "0x4005C56")]
		public const short WirePipe = 3616;

		// Token: 0x04004A0B RID: 18955
		[global::Cpp2ILInjected.Token(Token = "0x4005C57")]
		public const short AnnouncementBox = 3617;

		// Token: 0x04004A0C RID: 18956
		[global::Cpp2ILInjected.Token(Token = "0x4005C58")]
		public const short LogicGateLamp_On = 3618;

		// Token: 0x04004A0D RID: 18957
		[global::Cpp2ILInjected.Token(Token = "0x4005C59")]
		public const short MechanicalLens = 3619;

		// Token: 0x04004A0E RID: 18958
		[global::Cpp2ILInjected.Token(Token = "0x4005C5A")]
		public const short ActuationRod = 3620;

		// Token: 0x04004A0F RID: 18959
		[global::Cpp2ILInjected.Token(Token = "0x4005C5B")]
		public const short TeamBlockRed = 3621;

		// Token: 0x04004A10 RID: 18960
		[global::Cpp2ILInjected.Token(Token = "0x4005C5C")]
		public const short TeamBlockRedPlatform = 3622;

		// Token: 0x04004A11 RID: 18961
		[global::Cpp2ILInjected.Token(Token = "0x4005C5D")]
		public const short StaticHook = 3623;

		// Token: 0x04004A12 RID: 18962
		[global::Cpp2ILInjected.Token(Token = "0x4005C5E")]
		public const short ActuationAccessory = 3624;

		// Token: 0x04004A13 RID: 18963
		[global::Cpp2ILInjected.Token(Token = "0x4005C5F")]
		public const short MulticolorWrench = 3625;

		// Token: 0x04004A14 RID: 18964
		[global::Cpp2ILInjected.Token(Token = "0x4005C60")]
		public const short WeightedPressurePlatePink = 3626;

		// Token: 0x04004A15 RID: 18965
		[global::Cpp2ILInjected.Token(Token = "0x4005C61")]
		public const short EngineeringHelmet = 3627;

		// Token: 0x04004A16 RID: 18966
		[global::Cpp2ILInjected.Token(Token = "0x4005C62")]
		public const short CompanionCube = 3628;

		// Token: 0x04004A17 RID: 18967
		[global::Cpp2ILInjected.Token(Token = "0x4005C63")]
		public const short WireBulb = 3629;

		// Token: 0x04004A18 RID: 18968
		[global::Cpp2ILInjected.Token(Token = "0x4005C64")]
		public const short WeightedPressurePlateOrange = 3630;

		// Token: 0x04004A19 RID: 18969
		[global::Cpp2ILInjected.Token(Token = "0x4005C65")]
		public const short WeightedPressurePlatePurple = 3631;

		// Token: 0x04004A1A RID: 18970
		[global::Cpp2ILInjected.Token(Token = "0x4005C66")]
		public const short WeightedPressurePlateCyan = 3632;

		// Token: 0x04004A1B RID: 18971
		[global::Cpp2ILInjected.Token(Token = "0x4005C67")]
		public const short TeamBlockGreen = 3633;

		// Token: 0x04004A1C RID: 18972
		[global::Cpp2ILInjected.Token(Token = "0x4005C68")]
		public const short TeamBlockBlue = 3634;

		// Token: 0x04004A1D RID: 18973
		[global::Cpp2ILInjected.Token(Token = "0x4005C69")]
		public const short TeamBlockYellow = 3635;

		// Token: 0x04004A1E RID: 18974
		[global::Cpp2ILInjected.Token(Token = "0x4005C6A")]
		public const short TeamBlockPink = 3636;

		// Token: 0x04004A1F RID: 18975
		[global::Cpp2ILInjected.Token(Token = "0x4005C6B")]
		public const short TeamBlockWhite = 3637;

		// Token: 0x04004A20 RID: 18976
		[global::Cpp2ILInjected.Token(Token = "0x4005C6C")]
		public const short TeamBlockGreenPlatform = 3638;

		// Token: 0x04004A21 RID: 18977
		[global::Cpp2ILInjected.Token(Token = "0x4005C6D")]
		public const short TeamBlockBluePlatform = 3639;

		// Token: 0x04004A22 RID: 18978
		[global::Cpp2ILInjected.Token(Token = "0x4005C6E")]
		public const short TeamBlockYellowPlatform = 3640;

		// Token: 0x04004A23 RID: 18979
		[global::Cpp2ILInjected.Token(Token = "0x4005C6F")]
		public const short TeamBlockPinkPlatform = 3641;

		// Token: 0x04004A24 RID: 18980
		[global::Cpp2ILInjected.Token(Token = "0x4005C70")]
		public const short TeamBlockWhitePlatform = 3642;

		// Token: 0x04004A25 RID: 18981
		[global::Cpp2ILInjected.Token(Token = "0x4005C71")]
		public const short LargeAmber = 3643;

		// Token: 0x04004A26 RID: 18982
		[global::Cpp2ILInjected.Token(Token = "0x4005C72")]
		public const short GemLockRuby = 3644;

		// Token: 0x04004A27 RID: 18983
		[global::Cpp2ILInjected.Token(Token = "0x4005C73")]
		public const short GemLockSapphire = 3645;

		// Token: 0x04004A28 RID: 18984
		[global::Cpp2ILInjected.Token(Token = "0x4005C74")]
		public const short GemLockEmerald = 3646;

		// Token: 0x04004A29 RID: 18985
		[global::Cpp2ILInjected.Token(Token = "0x4005C75")]
		public const short GemLockTopaz = 3647;

		// Token: 0x04004A2A RID: 18986
		[global::Cpp2ILInjected.Token(Token = "0x4005C76")]
		public const short GemLockAmethyst = 3648;

		// Token: 0x04004A2B RID: 18987
		[global::Cpp2ILInjected.Token(Token = "0x4005C77")]
		public const short GemLockDiamond = 3649;

		// Token: 0x04004A2C RID: 18988
		[global::Cpp2ILInjected.Token(Token = "0x4005C78")]
		public const short GemLockAmber = 3650;

		// Token: 0x04004A2D RID: 18989
		[global::Cpp2ILInjected.Token(Token = "0x4005C79")]
		public const short SquirrelStatue = 3651;

		// Token: 0x04004A2E RID: 18990
		[global::Cpp2ILInjected.Token(Token = "0x4005C7A")]
		public const short ButterflyStatue = 3652;

		// Token: 0x04004A2F RID: 18991
		[global::Cpp2ILInjected.Token(Token = "0x4005C7B")]
		public const short WormStatue = 3653;

		// Token: 0x04004A30 RID: 18992
		[global::Cpp2ILInjected.Token(Token = "0x4005C7C")]
		public const short FireflyStatue = 3654;

		// Token: 0x04004A31 RID: 18993
		[global::Cpp2ILInjected.Token(Token = "0x4005C7D")]
		public const short ScorpionStatue = 3655;

		// Token: 0x04004A32 RID: 18994
		[global::Cpp2ILInjected.Token(Token = "0x4005C7E")]
		public const short SnailStatue = 3656;

		// Token: 0x04004A33 RID: 18995
		[global::Cpp2ILInjected.Token(Token = "0x4005C7F")]
		public const short GrasshopperStatue = 3657;

		// Token: 0x04004A34 RID: 18996
		[global::Cpp2ILInjected.Token(Token = "0x4005C80")]
		public const short MouseStatue = 3658;

		// Token: 0x04004A35 RID: 18997
		[global::Cpp2ILInjected.Token(Token = "0x4005C81")]
		public const short DuckStatue = 3659;

		// Token: 0x04004A36 RID: 18998
		[global::Cpp2ILInjected.Token(Token = "0x4005C82")]
		public const short PenguinStatue = 3660;

		// Token: 0x04004A37 RID: 18999
		[global::Cpp2ILInjected.Token(Token = "0x4005C83")]
		public const short FrogStatue = 3661;

		// Token: 0x04004A38 RID: 19000
		[global::Cpp2ILInjected.Token(Token = "0x4005C84")]
		public const short BuggyStatue = 3662;

		// Token: 0x04004A39 RID: 19001
		[global::Cpp2ILInjected.Token(Token = "0x4005C85")]
		public const short LogicGateLamp_Faulty = 3663;

		// Token: 0x04004A3A RID: 19002
		[global::Cpp2ILInjected.Token(Token = "0x4005C86")]
		public const short PortalGunStation = 3664;

		// Token: 0x04004A3B RID: 19003
		[global::Cpp2ILInjected.Token(Token = "0x4005C87")]
		public const short Fake_Chest = 3665;

		// Token: 0x04004A3C RID: 19004
		[global::Cpp2ILInjected.Token(Token = "0x4005C88")]
		public const short Fake_GoldChest = 3666;

		// Token: 0x04004A3D RID: 19005
		[global::Cpp2ILInjected.Token(Token = "0x4005C89")]
		public const short Fake_ShadowChest = 3667;

		// Token: 0x04004A3E RID: 19006
		[global::Cpp2ILInjected.Token(Token = "0x4005C8A")]
		public const short Fake_EbonwoodChest = 3668;

		// Token: 0x04004A3F RID: 19007
		[global::Cpp2ILInjected.Token(Token = "0x4005C8B")]
		public const short Fake_RichMahoganyChest = 3669;

		// Token: 0x04004A40 RID: 19008
		[global::Cpp2ILInjected.Token(Token = "0x4005C8C")]
		public const short Fake_PearlwoodChest = 3670;

		// Token: 0x04004A41 RID: 19009
		[global::Cpp2ILInjected.Token(Token = "0x4005C8D")]
		public const short Fake_IvyChest = 3671;

		// Token: 0x04004A42 RID: 19010
		[global::Cpp2ILInjected.Token(Token = "0x4005C8E")]
		public const short Fake_IceChest = 3672;

		// Token: 0x04004A43 RID: 19011
		[global::Cpp2ILInjected.Token(Token = "0x4005C8F")]
		public const short Fake_LivingWoodChest = 3673;

		// Token: 0x04004A44 RID: 19012
		[global::Cpp2ILInjected.Token(Token = "0x4005C90")]
		public const short Fake_SkywareChest = 3674;

		// Token: 0x04004A45 RID: 19013
		[global::Cpp2ILInjected.Token(Token = "0x4005C91")]
		public const short Fake_ShadewoodChest = 3675;

		// Token: 0x04004A46 RID: 19014
		[global::Cpp2ILInjected.Token(Token = "0x4005C92")]
		public const short Fake_WebCoveredChest = 3676;

		// Token: 0x04004A47 RID: 19015
		[global::Cpp2ILInjected.Token(Token = "0x4005C93")]
		public const short Fake_LihzahrdChest = 3677;

		// Token: 0x04004A48 RID: 19016
		[global::Cpp2ILInjected.Token(Token = "0x4005C94")]
		public const short Fake_WaterChest = 3678;

		// Token: 0x04004A49 RID: 19017
		[global::Cpp2ILInjected.Token(Token = "0x4005C95")]
		public const short Fake_JungleChest = 3679;

		// Token: 0x04004A4A RID: 19018
		[global::Cpp2ILInjected.Token(Token = "0x4005C96")]
		public const short Fake_CorruptionChest = 3680;

		// Token: 0x04004A4B RID: 19019
		[global::Cpp2ILInjected.Token(Token = "0x4005C97")]
		public const short Fake_CrimsonChest = 3681;

		// Token: 0x04004A4C RID: 19020
		[global::Cpp2ILInjected.Token(Token = "0x4005C98")]
		public const short Fake_HallowedChest = 3682;

		// Token: 0x04004A4D RID: 19021
		[global::Cpp2ILInjected.Token(Token = "0x4005C99")]
		public const short Fake_FrozenChest = 3683;

		// Token: 0x04004A4E RID: 19022
		[global::Cpp2ILInjected.Token(Token = "0x4005C9A")]
		public const short Fake_DynastyChest = 3684;

		// Token: 0x04004A4F RID: 19023
		[global::Cpp2ILInjected.Token(Token = "0x4005C9B")]
		public const short Fake_HoneyChest = 3685;

		// Token: 0x04004A50 RID: 19024
		[global::Cpp2ILInjected.Token(Token = "0x4005C9C")]
		public const short Fake_SteampunkChest = 3686;

		// Token: 0x04004A51 RID: 19025
		[global::Cpp2ILInjected.Token(Token = "0x4005C9D")]
		public const short Fake_PalmWoodChest = 3687;

		// Token: 0x04004A52 RID: 19026
		[global::Cpp2ILInjected.Token(Token = "0x4005C9E")]
		public const short Fake_MushroomChest = 3688;

		// Token: 0x04004A53 RID: 19027
		[global::Cpp2ILInjected.Token(Token = "0x4005C9F")]
		public const short Fake_BorealWoodChest = 3689;

		// Token: 0x04004A54 RID: 19028
		[global::Cpp2ILInjected.Token(Token = "0x4005CA0")]
		public const short Fake_SlimeChest = 3690;

		// Token: 0x04004A55 RID: 19029
		[global::Cpp2ILInjected.Token(Token = "0x4005CA1")]
		public const short Fake_GreenDungeonChest = 3691;

		// Token: 0x04004A56 RID: 19030
		[global::Cpp2ILInjected.Token(Token = "0x4005CA2")]
		public const short Fake_PinkDungeonChest = 3692;

		// Token: 0x04004A57 RID: 19031
		[global::Cpp2ILInjected.Token(Token = "0x4005CA3")]
		public const short Fake_BlueDungeonChest = 3693;

		// Token: 0x04004A58 RID: 19032
		[global::Cpp2ILInjected.Token(Token = "0x4005CA4")]
		public const short Fake_BoneChest = 3694;

		// Token: 0x04004A59 RID: 19033
		[global::Cpp2ILInjected.Token(Token = "0x4005CA5")]
		public const short Fake_CactusChest = 3695;

		// Token: 0x04004A5A RID: 19034
		[global::Cpp2ILInjected.Token(Token = "0x4005CA6")]
		public const short Fake_FleshChest = 3696;

		// Token: 0x04004A5B RID: 19035
		[global::Cpp2ILInjected.Token(Token = "0x4005CA7")]
		public const short Fake_ObsidianChest = 3697;

		// Token: 0x04004A5C RID: 19036
		[global::Cpp2ILInjected.Token(Token = "0x4005CA8")]
		public const short Fake_PumpkinChest = 3698;

		// Token: 0x04004A5D RID: 19037
		[global::Cpp2ILInjected.Token(Token = "0x4005CA9")]
		public const short Fake_SpookyChest = 3699;

		// Token: 0x04004A5E RID: 19038
		[global::Cpp2ILInjected.Token(Token = "0x4005CAA")]
		public const short Fake_GlassChest = 3700;

		// Token: 0x04004A5F RID: 19039
		[global::Cpp2ILInjected.Token(Token = "0x4005CAB")]
		public const short Fake_MartianChest = 3701;

		// Token: 0x04004A60 RID: 19040
		[global::Cpp2ILInjected.Token(Token = "0x4005CAC")]
		public const short Fake_MeteoriteChest = 3702;

		// Token: 0x04004A61 RID: 19041
		[global::Cpp2ILInjected.Token(Token = "0x4005CAD")]
		public const short Fake_GraniteChest = 3703;

		// Token: 0x04004A62 RID: 19042
		[global::Cpp2ILInjected.Token(Token = "0x4005CAE")]
		public const short Fake_MarbleChest = 3704;

		// Token: 0x04004A63 RID: 19043
		[global::Cpp2ILInjected.Token(Token = "0x4005CAF")]
		public const short Fake_newchest1 = 3705;

		// Token: 0x04004A64 RID: 19044
		[global::Cpp2ILInjected.Token(Token = "0x4005CB0")]
		public const short Fake_newchest2 = 3706;

		// Token: 0x04004A65 RID: 19045
		[global::Cpp2ILInjected.Token(Token = "0x4005CB1")]
		public const short ProjectilePressurePad = 3707;

		// Token: 0x04004A66 RID: 19046
		[global::Cpp2ILInjected.Token(Token = "0x4005CB2")]
		public const short WallCreeperStatue = 3708;

		// Token: 0x04004A67 RID: 19047
		[global::Cpp2ILInjected.Token(Token = "0x4005CB3")]
		public const short UnicornStatue = 3709;

		// Token: 0x04004A68 RID: 19048
		[global::Cpp2ILInjected.Token(Token = "0x4005CB4")]
		public const short DripplerStatue = 3710;

		// Token: 0x04004A69 RID: 19049
		[global::Cpp2ILInjected.Token(Token = "0x4005CB5")]
		public const short WraithStatue = 3711;

		// Token: 0x04004A6A RID: 19050
		[global::Cpp2ILInjected.Token(Token = "0x4005CB6")]
		public const short BoneSkeletonStatue = 3712;

		// Token: 0x04004A6B RID: 19051
		[global::Cpp2ILInjected.Token(Token = "0x4005CB7")]
		public const short UndeadVikingStatue = 3713;

		// Token: 0x04004A6C RID: 19052
		[global::Cpp2ILInjected.Token(Token = "0x4005CB8")]
		public const short MedusaStatue = 3714;

		// Token: 0x04004A6D RID: 19053
		[global::Cpp2ILInjected.Token(Token = "0x4005CB9")]
		public const short HarpyStatue = 3715;

		// Token: 0x04004A6E RID: 19054
		[global::Cpp2ILInjected.Token(Token = "0x4005CBA")]
		public const short PigronStatue = 3716;

		// Token: 0x04004A6F RID: 19055
		[global::Cpp2ILInjected.Token(Token = "0x4005CBB")]
		public const short HopliteStatue = 3717;

		// Token: 0x04004A70 RID: 19056
		[global::Cpp2ILInjected.Token(Token = "0x4005CBC")]
		public const short GraniteGolemStatue = 3718;

		// Token: 0x04004A71 RID: 19057
		[global::Cpp2ILInjected.Token(Token = "0x4005CBD")]
		public const short ZombieArmStatue = 3719;

		// Token: 0x04004A72 RID: 19058
		[global::Cpp2ILInjected.Token(Token = "0x4005CBE")]
		public const short BloodZombieStatue = 3720;

		// Token: 0x04004A73 RID: 19059
		[global::Cpp2ILInjected.Token(Token = "0x4005CBF")]
		public const short AnglerTackleBag = 3721;

		// Token: 0x04004A74 RID: 19060
		[global::Cpp2ILInjected.Token(Token = "0x4005CC0")]
		public const short GeyserTrap = 3722;

		// Token: 0x04004A75 RID: 19061
		[global::Cpp2ILInjected.Token(Token = "0x4005CC1")]
		public const short UltraBrightCampfire = 3723;

		// Token: 0x04004A76 RID: 19062
		[global::Cpp2ILInjected.Token(Token = "0x4005CC2")]
		public const short BoneCampfire = 3724;

		// Token: 0x04004A77 RID: 19063
		[global::Cpp2ILInjected.Token(Token = "0x4005CC3")]
		public const short PixelBox = 3725;

		// Token: 0x04004A78 RID: 19064
		[global::Cpp2ILInjected.Token(Token = "0x4005CC4")]
		public const short LogicSensor_Water = 3726;

		// Token: 0x04004A79 RID: 19065
		[global::Cpp2ILInjected.Token(Token = "0x4005CC5")]
		public const short LogicSensor_Lava = 3727;

		// Token: 0x04004A7A RID: 19066
		[global::Cpp2ILInjected.Token(Token = "0x4005CC6")]
		public const short LogicSensor_Honey = 3728;

		// Token: 0x04004A7B RID: 19067
		[global::Cpp2ILInjected.Token(Token = "0x4005CC7")]
		public const short LogicSensor_Liquid = 3729;

		// Token: 0x04004A7C RID: 19068
		[global::Cpp2ILInjected.Token(Token = "0x4005CC8")]
		public const short PartyBundleOfBalloonsAccessory = 3730;

		// Token: 0x04004A7D RID: 19069
		[global::Cpp2ILInjected.Token(Token = "0x4005CC9")]
		public const short PartyBalloonAnimal = 3731;

		// Token: 0x04004A7E RID: 19070
		[global::Cpp2ILInjected.Token(Token = "0x4005CCA")]
		public const short PartyHat = 3732;

		// Token: 0x04004A7F RID: 19071
		[global::Cpp2ILInjected.Token(Token = "0x4005CCB")]
		public const short FlowerBoyHat = 3733;

		// Token: 0x04004A80 RID: 19072
		[global::Cpp2ILInjected.Token(Token = "0x4005CCC")]
		public const short FlowerBoyShirt = 3734;

		// Token: 0x04004A81 RID: 19073
		[global::Cpp2ILInjected.Token(Token = "0x4005CCD")]
		public const short FlowerBoyPants = 3735;

		// Token: 0x04004A82 RID: 19074
		[global::Cpp2ILInjected.Token(Token = "0x4005CCE")]
		public const short SillyBalloonPink = 3736;

		// Token: 0x04004A83 RID: 19075
		[global::Cpp2ILInjected.Token(Token = "0x4005CCF")]
		public const short SillyBalloonPurple = 3737;

		// Token: 0x04004A84 RID: 19076
		[global::Cpp2ILInjected.Token(Token = "0x4005CD0")]
		public const short SillyBalloonGreen = 3738;

		// Token: 0x04004A85 RID: 19077
		[global::Cpp2ILInjected.Token(Token = "0x4005CD1")]
		public const short SillyStreamerBlue = 3739;

		// Token: 0x04004A86 RID: 19078
		[global::Cpp2ILInjected.Token(Token = "0x4005CD2")]
		public const short SillyStreamerGreen = 3740;

		// Token: 0x04004A87 RID: 19079
		[global::Cpp2ILInjected.Token(Token = "0x4005CD3")]
		public const short SillyStreamerPink = 3741;

		// Token: 0x04004A88 RID: 19080
		[global::Cpp2ILInjected.Token(Token = "0x4005CD4")]
		public const short SillyBalloonMachine = 3742;

		// Token: 0x04004A89 RID: 19081
		[global::Cpp2ILInjected.Token(Token = "0x4005CD5")]
		public const short SillyBalloonTiedPink = 3743;

		// Token: 0x04004A8A RID: 19082
		[global::Cpp2ILInjected.Token(Token = "0x4005CD6")]
		public const short SillyBalloonTiedPurple = 3744;

		// Token: 0x04004A8B RID: 19083
		[global::Cpp2ILInjected.Token(Token = "0x4005CD7")]
		public const short SillyBalloonTiedGreen = 3745;

		// Token: 0x04004A8C RID: 19084
		[global::Cpp2ILInjected.Token(Token = "0x4005CD8")]
		public const short Pigronata = 3746;

		// Token: 0x04004A8D RID: 19085
		[global::Cpp2ILInjected.Token(Token = "0x4005CD9")]
		public const short PartyMonolith = 3747;

		// Token: 0x04004A8E RID: 19086
		[global::Cpp2ILInjected.Token(Token = "0x4005CDA")]
		public const short PartyBundleOfBalloonTile = 3748;

		// Token: 0x04004A8F RID: 19087
		[global::Cpp2ILInjected.Token(Token = "0x4005CDB")]
		public const short PartyPresent = 3749;

		// Token: 0x04004A90 RID: 19088
		[global::Cpp2ILInjected.Token(Token = "0x4005CDC")]
		public const short SliceOfCake = 3750;

		// Token: 0x04004A91 RID: 19089
		[global::Cpp2ILInjected.Token(Token = "0x4005CDD")]
		public const short CogWall = 3751;

		// Token: 0x04004A92 RID: 19090
		[global::Cpp2ILInjected.Token(Token = "0x4005CDE")]
		public const short SandFallWall = 3752;

		// Token: 0x04004A93 RID: 19091
		[global::Cpp2ILInjected.Token(Token = "0x4005CDF")]
		public const short SnowFallWall = 3753;

		// Token: 0x04004A94 RID: 19092
		[global::Cpp2ILInjected.Token(Token = "0x4005CE0")]
		public const short SandFallBlock = 3754;

		// Token: 0x04004A95 RID: 19093
		[global::Cpp2ILInjected.Token(Token = "0x4005CE1")]
		public const short SnowFallBlock = 3755;

		// Token: 0x04004A96 RID: 19094
		[global::Cpp2ILInjected.Token(Token = "0x4005CE2")]
		public const short SnowCloudBlock = 3756;

		// Token: 0x04004A97 RID: 19095
		[global::Cpp2ILInjected.Token(Token = "0x4005CE3")]
		public const short PedguinHat = 3757;

		// Token: 0x04004A98 RID: 19096
		[global::Cpp2ILInjected.Token(Token = "0x4005CE4")]
		public const short PedguinShirt = 3758;

		// Token: 0x04004A99 RID: 19097
		[global::Cpp2ILInjected.Token(Token = "0x4005CE5")]
		public const short PedguinPants = 3759;

		// Token: 0x04004A9A RID: 19098
		[global::Cpp2ILInjected.Token(Token = "0x4005CE6")]
		public const short SillyBalloonPinkWall = 3760;

		// Token: 0x04004A9B RID: 19099
		[global::Cpp2ILInjected.Token(Token = "0x4005CE7")]
		public const short SillyBalloonPurpleWall = 3761;

		// Token: 0x04004A9C RID: 19100
		[global::Cpp2ILInjected.Token(Token = "0x4005CE8")]
		public const short SillyBalloonGreenWall = 3762;

		// Token: 0x04004A9D RID: 19101
		[global::Cpp2ILInjected.Token(Token = "0x4005CE9")]
		public const short AviatorSunglasses = 3763;

		// Token: 0x04004A9E RID: 19102
		[global::Cpp2ILInjected.Token(Token = "0x4005CEA")]
		public const short BluePhasesaber = 3764;

		// Token: 0x04004A9F RID: 19103
		[global::Cpp2ILInjected.Token(Token = "0x4005CEB")]
		public const short RedPhasesaber = 3765;

		// Token: 0x04004AA0 RID: 19104
		[global::Cpp2ILInjected.Token(Token = "0x4005CEC")]
		public const short GreenPhasesaber = 3766;

		// Token: 0x04004AA1 RID: 19105
		[global::Cpp2ILInjected.Token(Token = "0x4005CED")]
		public const short PurplePhasesaber = 3767;

		// Token: 0x04004AA2 RID: 19106
		[global::Cpp2ILInjected.Token(Token = "0x4005CEE")]
		public const short WhitePhasesaber = 3768;

		// Token: 0x04004AA3 RID: 19107
		[global::Cpp2ILInjected.Token(Token = "0x4005CEF")]
		public const short YellowPhasesaber = 3769;

		// Token: 0x04004AA4 RID: 19108
		[global::Cpp2ILInjected.Token(Token = "0x4005CF0")]
		public const short DjinnsCurse = 3770;

		// Token: 0x04004AA5 RID: 19109
		[global::Cpp2ILInjected.Token(Token = "0x4005CF1")]
		public const short AncientHorn = 3771;

		// Token: 0x04004AA6 RID: 19110
		[global::Cpp2ILInjected.Token(Token = "0x4005CF2")]
		public const short AntlionClaw = 3772;

		// Token: 0x04004AA7 RID: 19111
		[global::Cpp2ILInjected.Token(Token = "0x4005CF3")]
		public const short AncientArmorHat = 3773;

		// Token: 0x04004AA8 RID: 19112
		[global::Cpp2ILInjected.Token(Token = "0x4005CF4")]
		public const short AncientArmorShirt = 3774;

		// Token: 0x04004AA9 RID: 19113
		[global::Cpp2ILInjected.Token(Token = "0x4005CF5")]
		public const short AncientArmorPants = 3775;

		// Token: 0x04004AAA RID: 19114
		[global::Cpp2ILInjected.Token(Token = "0x4005CF6")]
		public const short AncientBattleArmorHat = 3776;

		// Token: 0x04004AAB RID: 19115
		[global::Cpp2ILInjected.Token(Token = "0x4005CF7")]
		public const short AncientBattleArmorShirt = 3777;

		// Token: 0x04004AAC RID: 19116
		[global::Cpp2ILInjected.Token(Token = "0x4005CF8")]
		public const short AncientBattleArmorPants = 3778;

		// Token: 0x04004AAD RID: 19117
		[global::Cpp2ILInjected.Token(Token = "0x4005CF9")]
		public const short SpiritFlame = 3779;

		// Token: 0x04004AAE RID: 19118
		[global::Cpp2ILInjected.Token(Token = "0x4005CFA")]
		public const short SandElementalBanner = 3780;

		// Token: 0x04004AAF RID: 19119
		[global::Cpp2ILInjected.Token(Token = "0x4005CFB")]
		public const short PocketMirror = 3781;

		// Token: 0x04004AB0 RID: 19120
		[global::Cpp2ILInjected.Token(Token = "0x4005CFC")]
		public const short MagicSandDropper = 3782;

		// Token: 0x04004AB1 RID: 19121
		[global::Cpp2ILInjected.Token(Token = "0x4005CFD")]
		public const short AncientBattleArmorMaterial = 3783;

		// Token: 0x04004AB2 RID: 19122
		[global::Cpp2ILInjected.Token(Token = "0x4005CFE")]
		public const short LamiaPants = 3784;

		// Token: 0x04004AB3 RID: 19123
		[global::Cpp2ILInjected.Token(Token = "0x4005CFF")]
		public const short LamiaShirt = 3785;

		// Token: 0x04004AB4 RID: 19124
		[global::Cpp2ILInjected.Token(Token = "0x4005D00")]
		public const short LamiaHat = 3786;

		// Token: 0x04004AB5 RID: 19125
		[global::Cpp2ILInjected.Token(Token = "0x4005D01")]
		public const short SkyFracture = 3787;

		// Token: 0x04004AB6 RID: 19126
		[global::Cpp2ILInjected.Token(Token = "0x4005D02")]
		public const short OnyxBlaster = 3788;

		// Token: 0x04004AB7 RID: 19127
		[global::Cpp2ILInjected.Token(Token = "0x4005D03")]
		public const short SandsharkBanner = 3789;

		// Token: 0x04004AB8 RID: 19128
		[global::Cpp2ILInjected.Token(Token = "0x4005D04")]
		public const short SandsharkCorruptBanner = 3790;

		// Token: 0x04004AB9 RID: 19129
		[global::Cpp2ILInjected.Token(Token = "0x4005D05")]
		public const short SandsharkCrimsonBanner = 3791;

		// Token: 0x04004ABA RID: 19130
		[global::Cpp2ILInjected.Token(Token = "0x4005D06")]
		public const short SandsharkHallowedBanner = 3792;

		// Token: 0x04004ABB RID: 19131
		[global::Cpp2ILInjected.Token(Token = "0x4005D07")]
		public const short TumbleweedBanner = 3793;

		// Token: 0x04004ABC RID: 19132
		[global::Cpp2ILInjected.Token(Token = "0x4005D08")]
		public const short AncientCloth = 3794;

		// Token: 0x04004ABD RID: 19133
		[global::Cpp2ILInjected.Token(Token = "0x4005D09")]
		public const short DjinnLamp = 3795;

		// Token: 0x04004ABE RID: 19134
		[global::Cpp2ILInjected.Token(Token = "0x4005D0A")]
		public const short MusicBoxSandstorm = 3796;

		// Token: 0x04004ABF RID: 19135
		[global::Cpp2ILInjected.Token(Token = "0x4005D0B")]
		public const short ApprenticeHat = 3797;

		// Token: 0x04004AC0 RID: 19136
		[global::Cpp2ILInjected.Token(Token = "0x4005D0C")]
		public const short ApprenticeRobe = 3798;

		// Token: 0x04004AC1 RID: 19137
		[global::Cpp2ILInjected.Token(Token = "0x4005D0D")]
		public const short ApprenticeTrousers = 3799;

		// Token: 0x04004AC2 RID: 19138
		[global::Cpp2ILInjected.Token(Token = "0x4005D0E")]
		public const short SquireGreatHelm = 3800;

		// Token: 0x04004AC3 RID: 19139
		[global::Cpp2ILInjected.Token(Token = "0x4005D0F")]
		public const short SquirePlating = 3801;

		// Token: 0x04004AC4 RID: 19140
		[global::Cpp2ILInjected.Token(Token = "0x4005D10")]
		public const short SquireGreaves = 3802;

		// Token: 0x04004AC5 RID: 19141
		[global::Cpp2ILInjected.Token(Token = "0x4005D11")]
		public const short HuntressWig = 3803;

		// Token: 0x04004AC6 RID: 19142
		[global::Cpp2ILInjected.Token(Token = "0x4005D12")]
		public const short HuntressJerkin = 3804;

		// Token: 0x04004AC7 RID: 19143
		[global::Cpp2ILInjected.Token(Token = "0x4005D13")]
		public const short HuntressPants = 3805;

		// Token: 0x04004AC8 RID: 19144
		[global::Cpp2ILInjected.Token(Token = "0x4005D14")]
		public const short MonkBrows = 3806;

		// Token: 0x04004AC9 RID: 19145
		[global::Cpp2ILInjected.Token(Token = "0x4005D15")]
		public const short MonkShirt = 3807;

		// Token: 0x04004ACA RID: 19146
		[global::Cpp2ILInjected.Token(Token = "0x4005D16")]
		public const short MonkPants = 3808;

		// Token: 0x04004ACB RID: 19147
		[global::Cpp2ILInjected.Token(Token = "0x4005D17")]
		public const short ApprenticeScarf = 3809;

		// Token: 0x04004ACC RID: 19148
		[global::Cpp2ILInjected.Token(Token = "0x4005D18")]
		public const short SquireShield = 3810;

		// Token: 0x04004ACD RID: 19149
		[global::Cpp2ILInjected.Token(Token = "0x4005D19")]
		public const short HuntressBuckler = 3811;

		// Token: 0x04004ACE RID: 19150
		[global::Cpp2ILInjected.Token(Token = "0x4005D1A")]
		public const short MonkBelt = 3812;

		// Token: 0x04004ACF RID: 19151
		[global::Cpp2ILInjected.Token(Token = "0x4005D1B")]
		public const short DefendersForge = 3813;

		// Token: 0x04004AD0 RID: 19152
		[global::Cpp2ILInjected.Token(Token = "0x4005D1C")]
		public const short WarTable = 3814;

		// Token: 0x04004AD1 RID: 19153
		[global::Cpp2ILInjected.Token(Token = "0x4005D1D")]
		public const short WarTableBanner = 3815;

		// Token: 0x04004AD2 RID: 19154
		[global::Cpp2ILInjected.Token(Token = "0x4005D1E")]
		public const short DD2ElderCrystalStand = 3816;

		// Token: 0x04004AD3 RID: 19155
		[global::Cpp2ILInjected.Token(Token = "0x4005D1F")]
		public const short DefenderMedal = 3817;

		// Token: 0x04004AD4 RID: 19156
		[global::Cpp2ILInjected.Token(Token = "0x4005D20")]
		public const short DD2FlameburstTowerT1Popper = 3818;

		// Token: 0x04004AD5 RID: 19157
		[global::Cpp2ILInjected.Token(Token = "0x4005D21")]
		public const short DD2FlameburstTowerT2Popper = 3819;

		// Token: 0x04004AD6 RID: 19158
		[global::Cpp2ILInjected.Token(Token = "0x4005D22")]
		public const short DD2FlameburstTowerT3Popper = 3820;

		// Token: 0x04004AD7 RID: 19159
		[global::Cpp2ILInjected.Token(Token = "0x4005D23")]
		public const short AleThrowingGlove = 3821;

		// Token: 0x04004AD8 RID: 19160
		[global::Cpp2ILInjected.Token(Token = "0x4005D24")]
		public const short DD2EnergyCrystal = 3822;

		// Token: 0x04004AD9 RID: 19161
		[global::Cpp2ILInjected.Token(Token = "0x4005D25")]
		public const short DD2SquireDemonSword = 3823;

		// Token: 0x04004ADA RID: 19162
		[global::Cpp2ILInjected.Token(Token = "0x4005D26")]
		public const short DD2BallistraTowerT1Popper = 3824;

		// Token: 0x04004ADB RID: 19163
		[global::Cpp2ILInjected.Token(Token = "0x4005D27")]
		public const short DD2BallistraTowerT2Popper = 3825;

		// Token: 0x04004ADC RID: 19164
		[global::Cpp2ILInjected.Token(Token = "0x4005D28")]
		public const short DD2BallistraTowerT3Popper = 3826;

		// Token: 0x04004ADD RID: 19165
		[global::Cpp2ILInjected.Token(Token = "0x4005D29")]
		public const short DD2SquireBetsySword = 3827;

		// Token: 0x04004ADE RID: 19166
		[global::Cpp2ILInjected.Token(Token = "0x4005D2A")]
		public const short DD2ElderCrystal = 3828;

		// Token: 0x04004ADF RID: 19167
		[global::Cpp2ILInjected.Token(Token = "0x4005D2B")]
		public const short DD2LightningAuraT1Popper = 3829;

		// Token: 0x04004AE0 RID: 19168
		[global::Cpp2ILInjected.Token(Token = "0x4005D2C")]
		public const short DD2LightningAuraT2Popper = 3830;

		// Token: 0x04004AE1 RID: 19169
		[global::Cpp2ILInjected.Token(Token = "0x4005D2D")]
		public const short DD2LightningAuraT3Popper = 3831;

		// Token: 0x04004AE2 RID: 19170
		[global::Cpp2ILInjected.Token(Token = "0x4005D2E")]
		public const short DD2ExplosiveTrapT1Popper = 3832;

		// Token: 0x04004AE3 RID: 19171
		[global::Cpp2ILInjected.Token(Token = "0x4005D2F")]
		public const short DD2ExplosiveTrapT2Popper = 3833;

		// Token: 0x04004AE4 RID: 19172
		[global::Cpp2ILInjected.Token(Token = "0x4005D30")]
		public const short DD2ExplosiveTrapT3Popper = 3834;

		// Token: 0x04004AE5 RID: 19173
		[global::Cpp2ILInjected.Token(Token = "0x4005D31")]
		public const short MonkStaffT1 = 3835;

		// Token: 0x04004AE6 RID: 19174
		[global::Cpp2ILInjected.Token(Token = "0x4005D32")]
		public const short MonkStaffT2 = 3836;

		// Token: 0x04004AE7 RID: 19175
		[global::Cpp2ILInjected.Token(Token = "0x4005D33")]
		public const short DD2GoblinBomberBanner = 3837;

		// Token: 0x04004AE8 RID: 19176
		[global::Cpp2ILInjected.Token(Token = "0x4005D34")]
		public const short DD2GoblinBanner = 3838;

		// Token: 0x04004AE9 RID: 19177
		[global::Cpp2ILInjected.Token(Token = "0x4005D35")]
		public const short DD2SkeletonBanner = 3839;

		// Token: 0x04004AEA RID: 19178
		[global::Cpp2ILInjected.Token(Token = "0x4005D36")]
		public const short DD2DrakinBanner = 3840;

		// Token: 0x04004AEB RID: 19179
		[global::Cpp2ILInjected.Token(Token = "0x4005D37")]
		public const short DD2KoboldFlyerBanner = 3841;

		// Token: 0x04004AEC RID: 19180
		[global::Cpp2ILInjected.Token(Token = "0x4005D38")]
		public const short DD2KoboldBanner = 3842;

		// Token: 0x04004AED RID: 19181
		[global::Cpp2ILInjected.Token(Token = "0x4005D39")]
		public const short DD2WitherBeastBanner = 3843;

		// Token: 0x04004AEE RID: 19182
		[global::Cpp2ILInjected.Token(Token = "0x4005D3A")]
		public const short DD2WyvernBanner = 3844;

		// Token: 0x04004AEF RID: 19183
		[global::Cpp2ILInjected.Token(Token = "0x4005D3B")]
		public const short DD2JavelinThrowerBanner = 3845;

		// Token: 0x04004AF0 RID: 19184
		[global::Cpp2ILInjected.Token(Token = "0x4005D3C")]
		public const short DD2LightningBugBanner = 3846;

		// Token: 0x04004AF1 RID: 19185
		[global::Cpp2ILInjected.Token(Token = "0x4005D3D")]
		public const short OgreMask = 3847;

		// Token: 0x04004AF2 RID: 19186
		[global::Cpp2ILInjected.Token(Token = "0x4005D3E")]
		public const short GoblinMask = 3848;

		// Token: 0x04004AF3 RID: 19187
		[global::Cpp2ILInjected.Token(Token = "0x4005D3F")]
		public const short GoblinBomberCap = 3849;

		// Token: 0x04004AF4 RID: 19188
		[global::Cpp2ILInjected.Token(Token = "0x4005D40")]
		public const short EtherianJavelin = 3850;

		// Token: 0x04004AF5 RID: 19189
		[global::Cpp2ILInjected.Token(Token = "0x4005D41")]
		public const short KoboldDynamiteBackpack = 3851;

		// Token: 0x04004AF6 RID: 19190
		[global::Cpp2ILInjected.Token(Token = "0x4005D42")]
		public const short BookStaff = 3852;

		// Token: 0x04004AF7 RID: 19191
		[global::Cpp2ILInjected.Token(Token = "0x4005D43")]
		public const short BoringBow = 3853;

		// Token: 0x04004AF8 RID: 19192
		[global::Cpp2ILInjected.Token(Token = "0x4005D44")]
		public const short DD2PhoenixBow = 3854;

		// Token: 0x04004AF9 RID: 19193
		[global::Cpp2ILInjected.Token(Token = "0x4005D45")]
		public const short DD2PetGato = 3855;

		// Token: 0x04004AFA RID: 19194
		[global::Cpp2ILInjected.Token(Token = "0x4005D46")]
		public const short DD2PetGhost = 3856;

		// Token: 0x04004AFB RID: 19195
		[global::Cpp2ILInjected.Token(Token = "0x4005D47")]
		public const short DD2PetDragon = 3857;

		// Token: 0x04004AFC RID: 19196
		[global::Cpp2ILInjected.Token(Token = "0x4005D48")]
		public const short MonkStaffT3 = 3858;

		// Token: 0x04004AFD RID: 19197
		[global::Cpp2ILInjected.Token(Token = "0x4005D49")]
		public const short DD2BetsyBow = 3859;

		// Token: 0x04004AFE RID: 19198
		[global::Cpp2ILInjected.Token(Token = "0x4005D4A")]
		public const short BossBagBetsy = 3860;

		// Token: 0x04004AFF RID: 19199
		[global::Cpp2ILInjected.Token(Token = "0x4005D4B")]
		public const short BossBagOgre = 3861;

		// Token: 0x04004B00 RID: 19200
		[global::Cpp2ILInjected.Token(Token = "0x4005D4C")]
		public const short BossBagDarkMage = 3862;

		// Token: 0x04004B01 RID: 19201
		[global::Cpp2ILInjected.Token(Token = "0x4005D4D")]
		public const short BossMaskBetsy = 3863;

		// Token: 0x04004B02 RID: 19202
		[global::Cpp2ILInjected.Token(Token = "0x4005D4E")]
		public const short BossMaskDarkMage = 3864;

		// Token: 0x04004B03 RID: 19203
		[global::Cpp2ILInjected.Token(Token = "0x4005D4F")]
		public const short BossMaskOgre = 3865;

		// Token: 0x04004B04 RID: 19204
		[global::Cpp2ILInjected.Token(Token = "0x4005D50")]
		public const short BossTrophyBetsy = 3866;

		// Token: 0x04004B05 RID: 19205
		[global::Cpp2ILInjected.Token(Token = "0x4005D51")]
		public const short BossTrophyDarkmage = 3867;

		// Token: 0x04004B06 RID: 19206
		[global::Cpp2ILInjected.Token(Token = "0x4005D52")]
		public const short BossTrophyOgre = 3868;

		// Token: 0x04004B07 RID: 19207
		[global::Cpp2ILInjected.Token(Token = "0x4005D53")]
		public const short MusicBoxDD2 = 3869;

		// Token: 0x04004B08 RID: 19208
		[global::Cpp2ILInjected.Token(Token = "0x4005D54")]
		public const short ApprenticeStaffT3 = 3870;

		// Token: 0x04004B09 RID: 19209
		[global::Cpp2ILInjected.Token(Token = "0x4005D55")]
		public const short SquireAltHead = 3871;

		// Token: 0x04004B0A RID: 19210
		[global::Cpp2ILInjected.Token(Token = "0x4005D56")]
		public const short SquireAltShirt = 3872;

		// Token: 0x04004B0B RID: 19211
		[global::Cpp2ILInjected.Token(Token = "0x4005D57")]
		public const short SquireAltPants = 3873;

		// Token: 0x04004B0C RID: 19212
		[global::Cpp2ILInjected.Token(Token = "0x4005D58")]
		public const short ApprenticeAltHead = 3874;

		// Token: 0x04004B0D RID: 19213
		[global::Cpp2ILInjected.Token(Token = "0x4005D59")]
		public const short ApprenticeAltShirt = 3875;

		// Token: 0x04004B0E RID: 19214
		[global::Cpp2ILInjected.Token(Token = "0x4005D5A")]
		public const short ApprenticeAltPants = 3876;

		// Token: 0x04004B0F RID: 19215
		[global::Cpp2ILInjected.Token(Token = "0x4005D5B")]
		public const short HuntressAltHead = 3877;

		// Token: 0x04004B10 RID: 19216
		[global::Cpp2ILInjected.Token(Token = "0x4005D5C")]
		public const short HuntressAltShirt = 3878;

		// Token: 0x04004B11 RID: 19217
		[global::Cpp2ILInjected.Token(Token = "0x4005D5D")]
		public const short HuntressAltPants = 3879;

		// Token: 0x04004B12 RID: 19218
		[global::Cpp2ILInjected.Token(Token = "0x4005D5E")]
		public const short MonkAltHead = 3880;

		// Token: 0x04004B13 RID: 19219
		[global::Cpp2ILInjected.Token(Token = "0x4005D5F")]
		public const short MonkAltShirt = 3881;

		// Token: 0x04004B14 RID: 19220
		[global::Cpp2ILInjected.Token(Token = "0x4005D60")]
		public const short MonkAltPants = 3882;

		// Token: 0x04004B15 RID: 19221
		[global::Cpp2ILInjected.Token(Token = "0x4005D61")]
		public const short BetsyWings = 3883;

		// Token: 0x04004B16 RID: 19222
		[global::Cpp2ILInjected.Token(Token = "0x4005D62")]
		public const short CrystalChest = 3884;

		// Token: 0x04004B17 RID: 19223
		[global::Cpp2ILInjected.Token(Token = "0x4005D63")]
		public const short GoldenChest = 3885;

		// Token: 0x04004B18 RID: 19224
		[global::Cpp2ILInjected.Token(Token = "0x4005D64")]
		public const short Fake_CrystalChest = 3886;

		// Token: 0x04004B19 RID: 19225
		[global::Cpp2ILInjected.Token(Token = "0x4005D65")]
		public const short Fake_GoldenChest = 3887;

		// Token: 0x04004B1A RID: 19226
		[global::Cpp2ILInjected.Token(Token = "0x4005D66")]
		public const short CrystalDoor = 3888;

		// Token: 0x04004B1B RID: 19227
		[global::Cpp2ILInjected.Token(Token = "0x4005D67")]
		public const short CrystalChair = 3889;

		// Token: 0x04004B1C RID: 19228
		[global::Cpp2ILInjected.Token(Token = "0x4005D68")]
		public const short CrystalCandle = 3890;

		// Token: 0x04004B1D RID: 19229
		[global::Cpp2ILInjected.Token(Token = "0x4005D69")]
		public const short CrystalLantern = 3891;

		// Token: 0x04004B1E RID: 19230
		[global::Cpp2ILInjected.Token(Token = "0x4005D6A")]
		public const short CrystalLamp = 3892;

		// Token: 0x04004B1F RID: 19231
		[global::Cpp2ILInjected.Token(Token = "0x4005D6B")]
		public const short CrystalCandelabra = 3893;

		// Token: 0x04004B20 RID: 19232
		[global::Cpp2ILInjected.Token(Token = "0x4005D6C")]
		public const short CrystalChandelier = 3894;

		// Token: 0x04004B21 RID: 19233
		[global::Cpp2ILInjected.Token(Token = "0x4005D6D")]
		public const short CrystalBathtub = 3895;

		// Token: 0x04004B22 RID: 19234
		[global::Cpp2ILInjected.Token(Token = "0x4005D6E")]
		public const short CrystalSink = 3896;

		// Token: 0x04004B23 RID: 19235
		[global::Cpp2ILInjected.Token(Token = "0x4005D6F")]
		public const short CrystalBed = 3897;

		// Token: 0x04004B24 RID: 19236
		[global::Cpp2ILInjected.Token(Token = "0x4005D70")]
		public const short CrystalClock = 3898;

		// Token: 0x04004B25 RID: 19237
		[global::Cpp2ILInjected.Token(Token = "0x4005D71")]
		public const short SkywareClock2 = 3899;

		// Token: 0x04004B26 RID: 19238
		[global::Cpp2ILInjected.Token(Token = "0x4005D72")]
		public const short DungeonClockBlue = 3900;

		// Token: 0x04004B27 RID: 19239
		[global::Cpp2ILInjected.Token(Token = "0x4005D73")]
		public const short DungeonClockGreen = 3901;

		// Token: 0x04004B28 RID: 19240
		[global::Cpp2ILInjected.Token(Token = "0x4005D74")]
		public const short DungeonClockPink = 3902;

		// Token: 0x04004B29 RID: 19241
		[global::Cpp2ILInjected.Token(Token = "0x4005D75")]
		public const short CrystalPlatform = 3903;

		// Token: 0x04004B2A RID: 19242
		[global::Cpp2ILInjected.Token(Token = "0x4005D76")]
		public const short GoldenPlatform = 3904;

		// Token: 0x04004B2B RID: 19243
		[global::Cpp2ILInjected.Token(Token = "0x4005D77")]
		public const short DynastyPlatform = 3905;

		// Token: 0x04004B2C RID: 19244
		[global::Cpp2ILInjected.Token(Token = "0x4005D78")]
		public const short LihzahrdPlatform = 3906;

		// Token: 0x04004B2D RID: 19245
		[global::Cpp2ILInjected.Token(Token = "0x4005D79")]
		public const short FleshPlatform = 3907;

		// Token: 0x04004B2E RID: 19246
		[global::Cpp2ILInjected.Token(Token = "0x4005D7A")]
		public const short FrozenPlatform = 3908;

		// Token: 0x04004B2F RID: 19247
		[global::Cpp2ILInjected.Token(Token = "0x4005D7B")]
		public const short CrystalWorkbench = 3909;

		// Token: 0x04004B30 RID: 19248
		[global::Cpp2ILInjected.Token(Token = "0x4005D7C")]
		public const short GoldenWorkbench = 3910;

		// Token: 0x04004B31 RID: 19249
		[global::Cpp2ILInjected.Token(Token = "0x4005D7D")]
		public const short CrystalDresser = 3911;

		// Token: 0x04004B32 RID: 19250
		[global::Cpp2ILInjected.Token(Token = "0x4005D7E")]
		public const short DynastyDresser = 3912;

		// Token: 0x04004B33 RID: 19251
		[global::Cpp2ILInjected.Token(Token = "0x4005D7F")]
		public const short FrozenDresser = 3913;

		// Token: 0x04004B34 RID: 19252
		[global::Cpp2ILInjected.Token(Token = "0x4005D80")]
		public const short LivingWoodDresser = 3914;

		// Token: 0x04004B35 RID: 19253
		[global::Cpp2ILInjected.Token(Token = "0x4005D81")]
		public const short CrystalPiano = 3915;

		// Token: 0x04004B36 RID: 19254
		[global::Cpp2ILInjected.Token(Token = "0x4005D82")]
		public const short DynastyPiano = 3916;

		// Token: 0x04004B37 RID: 19255
		[global::Cpp2ILInjected.Token(Token = "0x4005D83")]
		public const short CrystalBookCase = 3917;

		// Token: 0x04004B38 RID: 19256
		[global::Cpp2ILInjected.Token(Token = "0x4005D84")]
		public const short CrystalSofaHowDoesThatEvenWork = 3918;

		// Token: 0x04004B39 RID: 19257
		[global::Cpp2ILInjected.Token(Token = "0x4005D85")]
		public const short DynastySofa = 3919;

		// Token: 0x04004B3A RID: 19258
		[global::Cpp2ILInjected.Token(Token = "0x4005D86")]
		public const short CrystalTable = 3920;

		// Token: 0x04004B3B RID: 19259
		[global::Cpp2ILInjected.Token(Token = "0x4005D87")]
		public const short ArkhalisHat = 3921;

		// Token: 0x04004B3C RID: 19260
		[global::Cpp2ILInjected.Token(Token = "0x4005D88")]
		public const short ArkhalisShirt = 3922;

		// Token: 0x04004B3D RID: 19261
		[global::Cpp2ILInjected.Token(Token = "0x4005D89")]
		public const short ArkhalisPants = 3923;

		// Token: 0x04004B3E RID: 19262
		[global::Cpp2ILInjected.Token(Token = "0x4005D8A")]
		public const short ArkhalisWings = 3924;

		// Token: 0x04004B3F RID: 19263
		[global::Cpp2ILInjected.Token(Token = "0x4005D8B")]
		public const short LeinforsHat = 3925;

		// Token: 0x04004B40 RID: 19264
		[global::Cpp2ILInjected.Token(Token = "0x4005D8C")]
		public const short LeinforsShirt = 3926;

		// Token: 0x04004B41 RID: 19265
		[global::Cpp2ILInjected.Token(Token = "0x4005D8D")]
		public const short LeinforsPants = 3927;

		// Token: 0x04004B42 RID: 19266
		[global::Cpp2ILInjected.Token(Token = "0x4005D8E")]
		public const short LeinforsWings = 3928;

		// Token: 0x04004B43 RID: 19267
		[global::Cpp2ILInjected.Token(Token = "0x4005D8F")]
		public const short LeinforsAccessory = 3929;

		// Token: 0x04004B44 RID: 19268
		[global::Cpp2ILInjected.Token(Token = "0x4005D90")]
		public const short Celeb2 = 3930;

		// Token: 0x04004B45 RID: 19269
		[global::Cpp2ILInjected.Token(Token = "0x4005D91")]
		public const short SpiderBathtub = 3931;

		// Token: 0x04004B46 RID: 19270
		[global::Cpp2ILInjected.Token(Token = "0x4005D92")]
		public const short SpiderBed = 3932;

		// Token: 0x04004B47 RID: 19271
		[global::Cpp2ILInjected.Token(Token = "0x4005D93")]
		public const short SpiderBookcase = 3933;

		// Token: 0x04004B48 RID: 19272
		[global::Cpp2ILInjected.Token(Token = "0x4005D94")]
		public const short SpiderDresser = 3934;

		// Token: 0x04004B49 RID: 19273
		[global::Cpp2ILInjected.Token(Token = "0x4005D95")]
		public const short SpiderCandelabra = 3935;

		// Token: 0x04004B4A RID: 19274
		[global::Cpp2ILInjected.Token(Token = "0x4005D96")]
		public const short SpiderCandle = 3936;

		// Token: 0x04004B4B RID: 19275
		[global::Cpp2ILInjected.Token(Token = "0x4005D97")]
		public const short SpiderChair = 3937;

		// Token: 0x04004B4C RID: 19276
		[global::Cpp2ILInjected.Token(Token = "0x4005D98")]
		public const short SpiderChandelier = 3938;

		// Token: 0x04004B4D RID: 19277
		[global::Cpp2ILInjected.Token(Token = "0x4005D99")]
		public const short SpiderChest = 3939;

		// Token: 0x04004B4E RID: 19278
		[global::Cpp2ILInjected.Token(Token = "0x4005D9A")]
		public const short SpiderClock = 3940;

		// Token: 0x04004B4F RID: 19279
		[global::Cpp2ILInjected.Token(Token = "0x4005D9B")]
		public const short SpiderDoor = 3941;

		// Token: 0x04004B50 RID: 19280
		[global::Cpp2ILInjected.Token(Token = "0x4005D9C")]
		public const short SpiderLamp = 3942;

		// Token: 0x04004B51 RID: 19281
		[global::Cpp2ILInjected.Token(Token = "0x4005D9D")]
		public const short SpiderLantern = 3943;

		// Token: 0x04004B52 RID: 19282
		[global::Cpp2ILInjected.Token(Token = "0x4005D9E")]
		public const short SpiderPiano = 3944;

		// Token: 0x04004B53 RID: 19283
		[global::Cpp2ILInjected.Token(Token = "0x4005D9F")]
		public const short SpiderPlatform = 3945;

		// Token: 0x04004B54 RID: 19284
		[global::Cpp2ILInjected.Token(Token = "0x4005DA0")]
		public const short SpiderSinkSpiderSinkDoesWhateverASpiderSinkDoes = 3946;

		// Token: 0x04004B55 RID: 19285
		[global::Cpp2ILInjected.Token(Token = "0x4005DA1")]
		public const short SpiderSofa = 3947;

		// Token: 0x04004B56 RID: 19286
		[global::Cpp2ILInjected.Token(Token = "0x4005DA2")]
		public const short SpiderTable = 3948;

		// Token: 0x04004B57 RID: 19287
		[global::Cpp2ILInjected.Token(Token = "0x4005DA3")]
		public const short SpiderWorkbench = 3949;

		// Token: 0x04004B58 RID: 19288
		[global::Cpp2ILInjected.Token(Token = "0x4005DA4")]
		public const short Fake_SpiderChest = 3950;

		// Token: 0x04004B59 RID: 19289
		[global::Cpp2ILInjected.Token(Token = "0x4005DA5")]
		public const short IronBrick = 3951;

		// Token: 0x04004B5A RID: 19290
		[global::Cpp2ILInjected.Token(Token = "0x4005DA6")]
		public const short IronBrickWall = 3952;

		// Token: 0x04004B5B RID: 19291
		[global::Cpp2ILInjected.Token(Token = "0x4005DA7")]
		public const short LeadBrick = 3953;

		// Token: 0x04004B5C RID: 19292
		[global::Cpp2ILInjected.Token(Token = "0x4005DA8")]
		public const short LeadBrickWall = 3954;

		// Token: 0x04004B5D RID: 19293
		[global::Cpp2ILInjected.Token(Token = "0x4005DA9")]
		public const short LesionBlock = 3955;

		// Token: 0x04004B5E RID: 19294
		[global::Cpp2ILInjected.Token(Token = "0x4005DAA")]
		public const short LesionBlockWall = 3956;

		// Token: 0x04004B5F RID: 19295
		[global::Cpp2ILInjected.Token(Token = "0x4005DAB")]
		public const short LesionPlatform = 3957;

		// Token: 0x04004B60 RID: 19296
		[global::Cpp2ILInjected.Token(Token = "0x4005DAC")]
		public const short LesionBathtub = 3958;

		// Token: 0x04004B61 RID: 19297
		[global::Cpp2ILInjected.Token(Token = "0x4005DAD")]
		public const short LesionBed = 3959;

		// Token: 0x04004B62 RID: 19298
		[global::Cpp2ILInjected.Token(Token = "0x4005DAE")]
		public const short LesionBookcase = 3960;

		// Token: 0x04004B63 RID: 19299
		[global::Cpp2ILInjected.Token(Token = "0x4005DAF")]
		public const short LesionCandelabra = 3961;

		// Token: 0x04004B64 RID: 19300
		[global::Cpp2ILInjected.Token(Token = "0x4005DB0")]
		public const short LesionCandle = 3962;

		// Token: 0x04004B65 RID: 19301
		[global::Cpp2ILInjected.Token(Token = "0x4005DB1")]
		public const short LesionChair = 3963;

		// Token: 0x04004B66 RID: 19302
		[global::Cpp2ILInjected.Token(Token = "0x4005DB2")]
		public const short LesionChandelier = 3964;

		// Token: 0x04004B67 RID: 19303
		[global::Cpp2ILInjected.Token(Token = "0x4005DB3")]
		public const short LesionChest = 3965;

		// Token: 0x04004B68 RID: 19304
		[global::Cpp2ILInjected.Token(Token = "0x4005DB4")]
		public const short LesionClock = 3966;

		// Token: 0x04004B69 RID: 19305
		[global::Cpp2ILInjected.Token(Token = "0x4005DB5")]
		public const short LesionDoor = 3967;

		// Token: 0x04004B6A RID: 19306
		[global::Cpp2ILInjected.Token(Token = "0x4005DB6")]
		public const short LesionDresser = 3968;

		// Token: 0x04004B6B RID: 19307
		[global::Cpp2ILInjected.Token(Token = "0x4005DB7")]
		public const short LesionLamp = 3969;

		// Token: 0x04004B6C RID: 19308
		[global::Cpp2ILInjected.Token(Token = "0x4005DB8")]
		public const short LesionLantern = 3970;

		// Token: 0x04004B6D RID: 19309
		[global::Cpp2ILInjected.Token(Token = "0x4005DB9")]
		public const short LesionPiano = 3971;

		// Token: 0x04004B6E RID: 19310
		[global::Cpp2ILInjected.Token(Token = "0x4005DBA")]
		public const short LesionSink = 3972;

		// Token: 0x04004B6F RID: 19311
		[global::Cpp2ILInjected.Token(Token = "0x4005DBB")]
		public const short LesionSofa = 3973;

		// Token: 0x04004B70 RID: 19312
		[global::Cpp2ILInjected.Token(Token = "0x4005DBC")]
		public const short LesionTable = 3974;

		// Token: 0x04004B71 RID: 19313
		[global::Cpp2ILInjected.Token(Token = "0x4005DBD")]
		public const short LesionWorkbench = 3975;

		// Token: 0x04004B72 RID: 19314
		[global::Cpp2ILInjected.Token(Token = "0x4005DBE")]
		public const short Fake_LesionChest = 3976;

		// Token: 0x04004B73 RID: 19315
		[global::Cpp2ILInjected.Token(Token = "0x4005DBF")]
		public const short HatRack = 3977;

		// Token: 0x04004B74 RID: 19316
		[global::Cpp2ILInjected.Token(Token = "0x4005DC0")]
		public const short ColorOnlyDye = 3978;

		// Token: 0x04004B75 RID: 19317
		[global::Cpp2ILInjected.Token(Token = "0x4005DC1")]
		public const short WoodenCrateHard = 3979;

		// Token: 0x04004B76 RID: 19318
		[global::Cpp2ILInjected.Token(Token = "0x4005DC2")]
		public const short IronCrateHard = 3980;

		// Token: 0x04004B77 RID: 19319
		[global::Cpp2ILInjected.Token(Token = "0x4005DC3")]
		public const short GoldenCrateHard = 3981;

		// Token: 0x04004B78 RID: 19320
		[global::Cpp2ILInjected.Token(Token = "0x4005DC4")]
		public const short CorruptFishingCrateHard = 3982;

		// Token: 0x04004B79 RID: 19321
		[global::Cpp2ILInjected.Token(Token = "0x4005DC5")]
		public const short CrimsonFishingCrateHard = 3983;

		// Token: 0x04004B7A RID: 19322
		[global::Cpp2ILInjected.Token(Token = "0x4005DC6")]
		public const short DungeonFishingCrateHard = 3984;

		// Token: 0x04004B7B RID: 19323
		[global::Cpp2ILInjected.Token(Token = "0x4005DC7")]
		public const short FloatingIslandFishingCrateHard = 3985;

		// Token: 0x04004B7C RID: 19324
		[global::Cpp2ILInjected.Token(Token = "0x4005DC8")]
		public const short HallowedFishingCrateHard = 3986;

		// Token: 0x04004B7D RID: 19325
		[global::Cpp2ILInjected.Token(Token = "0x4005DC9")]
		public const short JungleFishingCrateHard = 3987;

		// Token: 0x04004B7E RID: 19326
		[global::Cpp2ILInjected.Token(Token = "0x4005DCA")]
		public const short DeadMansChest = 3988;

		// Token: 0x04004B7F RID: 19327
		[global::Cpp2ILInjected.Token(Token = "0x4005DCB")]
		public const short GolfBall = 3989;

		// Token: 0x04004B80 RID: 19328
		[global::Cpp2ILInjected.Token(Token = "0x4005DCC")]
		public const short AmphibianBoots = 3990;

		// Token: 0x04004B81 RID: 19329
		[global::Cpp2ILInjected.Token(Token = "0x4005DCD")]
		public const short ArcaneFlower = 3991;

		// Token: 0x04004B82 RID: 19330
		[global::Cpp2ILInjected.Token(Token = "0x4005DCE")]
		public const short BerserkerGlove = 3992;

		// Token: 0x04004B83 RID: 19331
		[global::Cpp2ILInjected.Token(Token = "0x4005DCF")]
		public const short FairyBoots = 3993;

		// Token: 0x04004B84 RID: 19332
		[global::Cpp2ILInjected.Token(Token = "0x4005DD0")]
		public const short FrogFlipper = 3994;

		// Token: 0x04004B85 RID: 19333
		[global::Cpp2ILInjected.Token(Token = "0x4005DD1")]
		public const short FrogGear = 3995;

		// Token: 0x04004B86 RID: 19334
		[global::Cpp2ILInjected.Token(Token = "0x4005DD2")]
		public const short FrogWebbing = 3996;

		// Token: 0x04004B87 RID: 19335
		[global::Cpp2ILInjected.Token(Token = "0x4005DD3")]
		public const short FrozenShield = 3997;

		// Token: 0x04004B88 RID: 19336
		[global::Cpp2ILInjected.Token(Token = "0x4005DD4")]
		public const short HeroShield = 3998;

		// Token: 0x04004B89 RID: 19337
		[global::Cpp2ILInjected.Token(Token = "0x4005DD5")]
		public const short LavaSkull = 3999;

		// Token: 0x04004B8A RID: 19338
		[global::Cpp2ILInjected.Token(Token = "0x4005DD6")]
		public const short MagnetFlower = 4000;

		// Token: 0x04004B8B RID: 19339
		[global::Cpp2ILInjected.Token(Token = "0x4005DD7")]
		public const short ManaCloak = 4001;

		// Token: 0x04004B8C RID: 19340
		[global::Cpp2ILInjected.Token(Token = "0x4005DD8")]
		public const short MoltenQuiver = 4002;

		// Token: 0x04004B8D RID: 19341
		[global::Cpp2ILInjected.Token(Token = "0x4005DD9")]
		public const short MoltenSkullRose = 4003;

		// Token: 0x04004B8E RID: 19342
		[global::Cpp2ILInjected.Token(Token = "0x4005DDA")]
		public const short ObsidianSkullRose = 4004;

		// Token: 0x04004B8F RID: 19343
		[global::Cpp2ILInjected.Token(Token = "0x4005DDB")]
		public const short ReconScope = 4005;

		// Token: 0x04004B90 RID: 19344
		[global::Cpp2ILInjected.Token(Token = "0x4005DDC")]
		public const short StalkersQuiver = 4006;

		// Token: 0x04004B91 RID: 19345
		[global::Cpp2ILInjected.Token(Token = "0x4005DDD")]
		public const short StingerNecklace = 4007;

		// Token: 0x04004B92 RID: 19346
		[global::Cpp2ILInjected.Token(Token = "0x4005DDE")]
		public const short UltrabrightHelmet = 4008;

		// Token: 0x04004B93 RID: 19347
		[global::Cpp2ILInjected.Token(Token = "0x4005DDF")]
		public const short Apple = 4009;

		// Token: 0x04004B94 RID: 19348
		[global::Cpp2ILInjected.Token(Token = "0x4005DE0")]
		public const short ApplePieSlice = 4010;

		// Token: 0x04004B95 RID: 19349
		[global::Cpp2ILInjected.Token(Token = "0x4005DE1")]
		public const short ApplePie = 4011;

		// Token: 0x04004B96 RID: 19350
		[global::Cpp2ILInjected.Token(Token = "0x4005DE2")]
		public const short BananaSplit = 4012;

		// Token: 0x04004B97 RID: 19351
		[global::Cpp2ILInjected.Token(Token = "0x4005DE3")]
		public const short BBQRibs = 4013;

		// Token: 0x04004B98 RID: 19352
		[global::Cpp2ILInjected.Token(Token = "0x4005DE4")]
		public const short BunnyStew = 4014;

		// Token: 0x04004B99 RID: 19353
		[global::Cpp2ILInjected.Token(Token = "0x4005DE5")]
		public const short Burger = 4015;

		// Token: 0x04004B9A RID: 19354
		[global::Cpp2ILInjected.Token(Token = "0x4005DE6")]
		public const short ChickenNugget = 4016;

		// Token: 0x04004B9B RID: 19355
		[global::Cpp2ILInjected.Token(Token = "0x4005DE7")]
		public const short ChocolateChipCookie = 4017;

		// Token: 0x04004B9C RID: 19356
		[global::Cpp2ILInjected.Token(Token = "0x4005DE8")]
		public const short CreamSoda = 4018;

		// Token: 0x04004B9D RID: 19357
		[global::Cpp2ILInjected.Token(Token = "0x4005DE9")]
		public const short Escargot = 4019;

		// Token: 0x04004B9E RID: 19358
		[global::Cpp2ILInjected.Token(Token = "0x4005DEA")]
		public const short FriedEgg = 4020;

		// Token: 0x04004B9F RID: 19359
		[global::Cpp2ILInjected.Token(Token = "0x4005DEB")]
		public const short Fries = 4021;

		// Token: 0x04004BA0 RID: 19360
		[global::Cpp2ILInjected.Token(Token = "0x4005DEC")]
		public const short GoldenDelight = 4022;

		// Token: 0x04004BA1 RID: 19361
		[global::Cpp2ILInjected.Token(Token = "0x4005DED")]
		public const short Grapes = 4023;

		// Token: 0x04004BA2 RID: 19362
		[global::Cpp2ILInjected.Token(Token = "0x4005DEE")]
		public const short GrilledSquirrel = 4024;

		// Token: 0x04004BA3 RID: 19363
		[global::Cpp2ILInjected.Token(Token = "0x4005DEF")]
		public const short Hotdog = 4025;

		// Token: 0x04004BA4 RID: 19364
		[global::Cpp2ILInjected.Token(Token = "0x4005DF0")]
		public const short IceCream = 4026;

		// Token: 0x04004BA5 RID: 19365
		[global::Cpp2ILInjected.Token(Token = "0x4005DF1")]
		public const short Milkshake = 4027;

		// Token: 0x04004BA6 RID: 19366
		[global::Cpp2ILInjected.Token(Token = "0x4005DF2")]
		public const short Nachos = 4028;

		// Token: 0x04004BA7 RID: 19367
		[global::Cpp2ILInjected.Token(Token = "0x4005DF3")]
		public const short Pizza = 4029;

		// Token: 0x04004BA8 RID: 19368
		[global::Cpp2ILInjected.Token(Token = "0x4005DF4")]
		public const short PotatoChips = 4030;

		// Token: 0x04004BA9 RID: 19369
		[global::Cpp2ILInjected.Token(Token = "0x4005DF5")]
		public const short RoastedBird = 4031;

		// Token: 0x04004BAA RID: 19370
		[global::Cpp2ILInjected.Token(Token = "0x4005DF6")]
		public const short RoastedDuck = 4032;

		// Token: 0x04004BAB RID: 19371
		[global::Cpp2ILInjected.Token(Token = "0x4005DF7")]
		public const short SauteedFrogLegs = 4033;

		// Token: 0x04004BAC RID: 19372
		[global::Cpp2ILInjected.Token(Token = "0x4005DF8")]
		public const short SeafoodDinner = 4034;

		// Token: 0x04004BAD RID: 19373
		[global::Cpp2ILInjected.Token(Token = "0x4005DF9")]
		public const short ShrimpPoBoy = 4035;

		// Token: 0x04004BAE RID: 19374
		[global::Cpp2ILInjected.Token(Token = "0x4005DFA")]
		public const short Spaghetti = 4036;

		// Token: 0x04004BAF RID: 19375
		[global::Cpp2ILInjected.Token(Token = "0x4005DFB")]
		public const short Steak = 4037;

		// Token: 0x04004BB0 RID: 19376
		[global::Cpp2ILInjected.Token(Token = "0x4005DFC")]
		public const short MoltenCharm = 4038;

		// Token: 0x04004BB1 RID: 19377
		[global::Cpp2ILInjected.Token(Token = "0x4005DFD")]
		public const short GolfClubIron = 4039;

		// Token: 0x04004BB2 RID: 19378
		[global::Cpp2ILInjected.Token(Token = "0x4005DFE")]
		public const short GolfCup = 4040;

		// Token: 0x04004BB3 RID: 19379
		[global::Cpp2ILInjected.Token(Token = "0x4005DFF")]
		public const short FlowerPacketBlue = 4041;

		// Token: 0x04004BB4 RID: 19380
		[global::Cpp2ILInjected.Token(Token = "0x4005E00")]
		public const short FlowerPacketMagenta = 4042;

		// Token: 0x04004BB5 RID: 19381
		[global::Cpp2ILInjected.Token(Token = "0x4005E01")]
		public const short FlowerPacketPink = 4043;

		// Token: 0x04004BB6 RID: 19382
		[global::Cpp2ILInjected.Token(Token = "0x4005E02")]
		public const short FlowerPacketRed = 4044;

		// Token: 0x04004BB7 RID: 19383
		[global::Cpp2ILInjected.Token(Token = "0x4005E03")]
		public const short FlowerPacketYellow = 4045;

		// Token: 0x04004BB8 RID: 19384
		[global::Cpp2ILInjected.Token(Token = "0x4005E04")]
		public const short FlowerPacketViolet = 4046;

		// Token: 0x04004BB9 RID: 19385
		[global::Cpp2ILInjected.Token(Token = "0x4005E05")]
		public const short FlowerPacketWhite = 4047;

		// Token: 0x04004BBA RID: 19386
		[global::Cpp2ILInjected.Token(Token = "0x4005E06")]
		public const short FlowerPacketTallGrass = 4048;

		// Token: 0x04004BBB RID: 19387
		[global::Cpp2ILInjected.Token(Token = "0x4005E07")]
		public const short LawnMower = 4049;

		// Token: 0x04004BBC RID: 19388
		[global::Cpp2ILInjected.Token(Token = "0x4005E08")]
		public const short CrimstoneBrick = 4050;

		// Token: 0x04004BBD RID: 19389
		[global::Cpp2ILInjected.Token(Token = "0x4005E09")]
		public const short SmoothSandstone = 4051;

		// Token: 0x04004BBE RID: 19390
		[global::Cpp2ILInjected.Token(Token = "0x4005E0A")]
		public const short CrimstoneBrickWall = 4052;

		// Token: 0x04004BBF RID: 19391
		[global::Cpp2ILInjected.Token(Token = "0x4005E0B")]
		public const short SmoothSandstoneWall = 4053;

		// Token: 0x04004BC0 RID: 19392
		[global::Cpp2ILInjected.Token(Token = "0x4005E0C")]
		public const short BloodMoonMonolith = 4054;

		// Token: 0x04004BC1 RID: 19393
		[global::Cpp2ILInjected.Token(Token = "0x4005E0D")]
		public const short SandBoots = 4055;

		// Token: 0x04004BC2 RID: 19394
		[global::Cpp2ILInjected.Token(Token = "0x4005E0E")]
		public const short AncientChisel = 4056;

		// Token: 0x04004BC3 RID: 19395
		[global::Cpp2ILInjected.Token(Token = "0x4005E0F")]
		public const short CarbonGuitar = 4057;

		// Token: 0x04004BC4 RID: 19396
		[global::Cpp2ILInjected.Token(Token = "0x4005E10")]
		public const short SkeletonBow = 4058;

		// Token: 0x04004BC5 RID: 19397
		[global::Cpp2ILInjected.Token(Token = "0x4005E11")]
		public const short FossilPickaxe = 4059;

		// Token: 0x04004BC6 RID: 19398
		[global::Cpp2ILInjected.Token(Token = "0x4005E12")]
		public const short SuperStarCannon = 4060;

		// Token: 0x04004BC7 RID: 19399
		[global::Cpp2ILInjected.Token(Token = "0x4005E13")]
		public const short ThunderSpear = 4061;

		// Token: 0x04004BC8 RID: 19400
		[global::Cpp2ILInjected.Token(Token = "0x4005E14")]
		public const short ThunderStaff = 4062;

		// Token: 0x04004BC9 RID: 19401
		[global::Cpp2ILInjected.Token(Token = "0x4005E15")]
		public const short DrumSet = 4063;

		// Token: 0x04004BCA RID: 19402
		[global::Cpp2ILInjected.Token(Token = "0x4005E16")]
		public const short PicnicTable = 4064;

		// Token: 0x04004BCB RID: 19403
		[global::Cpp2ILInjected.Token(Token = "0x4005E17")]
		public const short PicnicTableWithCloth = 4065;

		// Token: 0x04004BCC RID: 19404
		[global::Cpp2ILInjected.Token(Token = "0x4005E18")]
		public const short DesertMinecart = 4066;

		// Token: 0x04004BCD RID: 19405
		[global::Cpp2ILInjected.Token(Token = "0x4005E19")]
		public const short FishMinecart = 4067;

		// Token: 0x04004BCE RID: 19406
		[global::Cpp2ILInjected.Token(Token = "0x4005E1A")]
		public const short FairyCritterPink = 4068;

		// Token: 0x04004BCF RID: 19407
		[global::Cpp2ILInjected.Token(Token = "0x4005E1B")]
		public const short FairyCritterGreen = 4069;

		// Token: 0x04004BD0 RID: 19408
		[global::Cpp2ILInjected.Token(Token = "0x4005E1C")]
		public const short FairyCritterBlue = 4070;

		// Token: 0x04004BD1 RID: 19409
		[global::Cpp2ILInjected.Token(Token = "0x4005E1D")]
		public const short JunoniaShell = 4071;

		// Token: 0x04004BD2 RID: 19410
		[global::Cpp2ILInjected.Token(Token = "0x4005E1E")]
		public const short LightningWhelkShell = 4072;

		// Token: 0x04004BD3 RID: 19411
		[global::Cpp2ILInjected.Token(Token = "0x4005E1F")]
		public const short TulipShell = 4073;

		// Token: 0x04004BD4 RID: 19412
		[global::Cpp2ILInjected.Token(Token = "0x4005E20")]
		public const short PinWheel = 4074;

		// Token: 0x04004BD5 RID: 19413
		[global::Cpp2ILInjected.Token(Token = "0x4005E21")]
		public const short WeatherVane = 4075;

		// Token: 0x04004BD6 RID: 19414
		[global::Cpp2ILInjected.Token(Token = "0x4005E22")]
		public const short VoidVault = 4076;

		// Token: 0x04004BD7 RID: 19415
		[global::Cpp2ILInjected.Token(Token = "0x4005E23")]
		public const short MusicBoxOceanAlt = 4077;

		// Token: 0x04004BD8 RID: 19416
		[global::Cpp2ILInjected.Token(Token = "0x4005E24")]
		public const short MusicBoxSlimeRain = 4078;

		// Token: 0x04004BD9 RID: 19417
		[global::Cpp2ILInjected.Token(Token = "0x4005E25")]
		public const short MusicBoxSpaceAlt = 4079;

		// Token: 0x04004BDA RID: 19418
		[global::Cpp2ILInjected.Token(Token = "0x4005E26")]
		public const short MusicBoxTownDay = 4080;

		// Token: 0x04004BDB RID: 19419
		[global::Cpp2ILInjected.Token(Token = "0x4005E27")]
		public const short MusicBoxTownNight = 4081;

		// Token: 0x04004BDC RID: 19420
		[global::Cpp2ILInjected.Token(Token = "0x4005E28")]
		public const short MusicBoxWindyDay = 4082;

		// Token: 0x04004BDD RID: 19421
		[global::Cpp2ILInjected.Token(Token = "0x4005E29")]
		public const short GolfCupFlagWhite = 4083;

		// Token: 0x04004BDE RID: 19422
		[global::Cpp2ILInjected.Token(Token = "0x4005E2A")]
		public const short GolfCupFlagRed = 4084;

		// Token: 0x04004BDF RID: 19423
		[global::Cpp2ILInjected.Token(Token = "0x4005E2B")]
		public const short GolfCupFlagGreen = 4085;

		// Token: 0x04004BE0 RID: 19424
		[global::Cpp2ILInjected.Token(Token = "0x4005E2C")]
		public const short GolfCupFlagBlue = 4086;

		// Token: 0x04004BE1 RID: 19425
		[global::Cpp2ILInjected.Token(Token = "0x4005E2D")]
		public const short GolfCupFlagYellow = 4087;

		// Token: 0x04004BE2 RID: 19426
		[global::Cpp2ILInjected.Token(Token = "0x4005E2E")]
		public const short GolfCupFlagPurple = 4088;

		// Token: 0x04004BE3 RID: 19427
		[global::Cpp2ILInjected.Token(Token = "0x4005E2F")]
		public const short GolfTee = 4089;

		// Token: 0x04004BE4 RID: 19428
		[global::Cpp2ILInjected.Token(Token = "0x4005E30")]
		public const short ShellPileBlock = 4090;

		// Token: 0x04004BE5 RID: 19429
		[global::Cpp2ILInjected.Token(Token = "0x4005E31")]
		public const short AntiPortalBlock = 4091;

		// Token: 0x04004BE6 RID: 19430
		[global::Cpp2ILInjected.Token(Token = "0x4005E32")]
		public const short GolfClubPutter = 4092;

		// Token: 0x04004BE7 RID: 19431
		[global::Cpp2ILInjected.Token(Token = "0x4005E33")]
		public const short GolfClubWedge = 4093;

		// Token: 0x04004BE8 RID: 19432
		[global::Cpp2ILInjected.Token(Token = "0x4005E34")]
		public const short GolfClubDriver = 4094;

		// Token: 0x04004BE9 RID: 19433
		[global::Cpp2ILInjected.Token(Token = "0x4005E35")]
		public const short GolfWhistle = 4095;

		// Token: 0x04004BEA RID: 19434
		[global::Cpp2ILInjected.Token(Token = "0x4005E36")]
		public const short ToiletEbonyWood = 4096;

		// Token: 0x04004BEB RID: 19435
		[global::Cpp2ILInjected.Token(Token = "0x4005E37")]
		public const short ToiletRichMahogany = 4097;

		// Token: 0x04004BEC RID: 19436
		[global::Cpp2ILInjected.Token(Token = "0x4005E38")]
		public const short ToiletPearlwood = 4098;

		// Token: 0x04004BED RID: 19437
		[global::Cpp2ILInjected.Token(Token = "0x4005E39")]
		public const short ToiletLivingWood = 4099;

		// Token: 0x04004BEE RID: 19438
		[global::Cpp2ILInjected.Token(Token = "0x4005E3A")]
		public const short ToiletCactus = 4100;

		// Token: 0x04004BEF RID: 19439
		[global::Cpp2ILInjected.Token(Token = "0x4005E3B")]
		public const short ToiletBone = 4101;

		// Token: 0x04004BF0 RID: 19440
		[global::Cpp2ILInjected.Token(Token = "0x4005E3C")]
		public const short ToiletFlesh = 4102;

		// Token: 0x04004BF1 RID: 19441
		[global::Cpp2ILInjected.Token(Token = "0x4005E3D")]
		public const short ToiletMushroom = 4103;

		// Token: 0x04004BF2 RID: 19442
		[global::Cpp2ILInjected.Token(Token = "0x4005E3E")]
		public const short ToiletSunplate = 4104;

		// Token: 0x04004BF3 RID: 19443
		[global::Cpp2ILInjected.Token(Token = "0x4005E3F")]
		public const short ToiletShadewood = 4105;

		// Token: 0x04004BF4 RID: 19444
		[global::Cpp2ILInjected.Token(Token = "0x4005E40")]
		public const short ToiletLihzhard = 4106;

		// Token: 0x04004BF5 RID: 19445
		[global::Cpp2ILInjected.Token(Token = "0x4005E41")]
		public const short ToiletDungeonBlue = 4107;

		// Token: 0x04004BF6 RID: 19446
		[global::Cpp2ILInjected.Token(Token = "0x4005E42")]
		public const short ToiletDungeonGreen = 4108;

		// Token: 0x04004BF7 RID: 19447
		[global::Cpp2ILInjected.Token(Token = "0x4005E43")]
		public const short ToiletDungeonPink = 4109;

		// Token: 0x04004BF8 RID: 19448
		[global::Cpp2ILInjected.Token(Token = "0x4005E44")]
		public const short ToiletObsidian = 4110;

		// Token: 0x04004BF9 RID: 19449
		[global::Cpp2ILInjected.Token(Token = "0x4005E45")]
		public const short ToiletFrozen = 4111;

		// Token: 0x04004BFA RID: 19450
		[global::Cpp2ILInjected.Token(Token = "0x4005E46")]
		public const short ToiletGlass = 4112;

		// Token: 0x04004BFB RID: 19451
		[global::Cpp2ILInjected.Token(Token = "0x4005E47")]
		public const short ToiletHoney = 4113;

		// Token: 0x04004BFC RID: 19452
		[global::Cpp2ILInjected.Token(Token = "0x4005E48")]
		public const short ToiletSteampunk = 4114;

		// Token: 0x04004BFD RID: 19453
		[global::Cpp2ILInjected.Token(Token = "0x4005E49")]
		public const short ToiletPumpkin = 4115;

		// Token: 0x04004BFE RID: 19454
		[global::Cpp2ILInjected.Token(Token = "0x4005E4A")]
		public const short ToiletSpooky = 4116;

		// Token: 0x04004BFF RID: 19455
		[global::Cpp2ILInjected.Token(Token = "0x4005E4B")]
		public const short ToiletDynasty = 4117;

		// Token: 0x04004C00 RID: 19456
		[global::Cpp2ILInjected.Token(Token = "0x4005E4C")]
		public const short ToiletPalm = 4118;

		// Token: 0x04004C01 RID: 19457
		[global::Cpp2ILInjected.Token(Token = "0x4005E4D")]
		public const short ToiletBoreal = 4119;

		// Token: 0x04004C02 RID: 19458
		[global::Cpp2ILInjected.Token(Token = "0x4005E4E")]
		public const short ToiletSlime = 4120;

		// Token: 0x04004C03 RID: 19459
		[global::Cpp2ILInjected.Token(Token = "0x4005E4F")]
		public const short ToiletMartian = 4121;

		// Token: 0x04004C04 RID: 19460
		[global::Cpp2ILInjected.Token(Token = "0x4005E50")]
		public const short ToiletGranite = 4122;

		// Token: 0x04004C05 RID: 19461
		[global::Cpp2ILInjected.Token(Token = "0x4005E51")]
		public const short ToiletMarble = 4123;

		// Token: 0x04004C06 RID: 19462
		[global::Cpp2ILInjected.Token(Token = "0x4005E52")]
		public const short ToiletCrystal = 4124;

		// Token: 0x04004C07 RID: 19463
		[global::Cpp2ILInjected.Token(Token = "0x4005E53")]
		public const short ToiletSpider = 4125;

		// Token: 0x04004C08 RID: 19464
		[global::Cpp2ILInjected.Token(Token = "0x4005E54")]
		public const short ToiletLesion = 4126;

		// Token: 0x04004C09 RID: 19465
		[global::Cpp2ILInjected.Token(Token = "0x4005E55")]
		public const short ToiletDiamond = 4127;

		// Token: 0x04004C0A RID: 19466
		[global::Cpp2ILInjected.Token(Token = "0x4005E56")]
		public const short MaidHead = 4128;

		// Token: 0x04004C0B RID: 19467
		[global::Cpp2ILInjected.Token(Token = "0x4005E57")]
		public const short MaidShirt = 4129;

		// Token: 0x04004C0C RID: 19468
		[global::Cpp2ILInjected.Token(Token = "0x4005E58")]
		public const short MaidPants = 4130;

		// Token: 0x04004C0D RID: 19469
		[global::Cpp2ILInjected.Token(Token = "0x4005E59")]
		public const short VoidLens = 4131;

		// Token: 0x04004C0E RID: 19470
		[global::Cpp2ILInjected.Token(Token = "0x4005E5A")]
		public const short MaidHead2 = 4132;

		// Token: 0x04004C0F RID: 19471
		[global::Cpp2ILInjected.Token(Token = "0x4005E5B")]
		public const short MaidShirt2 = 4133;

		// Token: 0x04004C10 RID: 19472
		[global::Cpp2ILInjected.Token(Token = "0x4005E5C")]
		public const short MaidPants2 = 4134;

		// Token: 0x04004C11 RID: 19473
		[global::Cpp2ILInjected.Token(Token = "0x4005E5D")]
		public const short GolfHat = 4135;

		// Token: 0x04004C12 RID: 19474
		[global::Cpp2ILInjected.Token(Token = "0x4005E5E")]
		public const short GolfShirt = 4136;

		// Token: 0x04004C13 RID: 19475
		[global::Cpp2ILInjected.Token(Token = "0x4005E5F")]
		public const short GolfPants = 4137;

		// Token: 0x04004C14 RID: 19476
		[global::Cpp2ILInjected.Token(Token = "0x4005E60")]
		public const short GolfVisor = 4138;

		// Token: 0x04004C15 RID: 19477
		[global::Cpp2ILInjected.Token(Token = "0x4005E61")]
		public const short SpiderBlock = 4139;

		// Token: 0x04004C16 RID: 19478
		[global::Cpp2ILInjected.Token(Token = "0x4005E62")]
		public const short SpiderWall = 4140;

		// Token: 0x04004C17 RID: 19479
		[global::Cpp2ILInjected.Token(Token = "0x4005E63")]
		public const short ToiletMeteor = 4141;

		// Token: 0x04004C18 RID: 19480
		[global::Cpp2ILInjected.Token(Token = "0x4005E64")]
		public const short LesionStation = 4142;

		// Token: 0x04004C19 RID: 19481
		[global::Cpp2ILInjected.Token(Token = "0x4005E65")]
		public const short ManaCloakStar = 4143;

		// Token: 0x04004C1A RID: 19482
		[global::Cpp2ILInjected.Token(Token = "0x4005E66")]
		public const short Terragrim = 4144;

		// Token: 0x04004C1B RID: 19483
		[global::Cpp2ILInjected.Token(Token = "0x4005E67")]
		public const short SolarBathtub = 4145;

		// Token: 0x04004C1C RID: 19484
		[global::Cpp2ILInjected.Token(Token = "0x4005E68")]
		public const short SolarBed = 4146;

		// Token: 0x04004C1D RID: 19485
		[global::Cpp2ILInjected.Token(Token = "0x4005E69")]
		public const short SolarBookcase = 4147;

		// Token: 0x04004C1E RID: 19486
		[global::Cpp2ILInjected.Token(Token = "0x4005E6A")]
		public const short SolarDresser = 4148;

		// Token: 0x04004C1F RID: 19487
		[global::Cpp2ILInjected.Token(Token = "0x4005E6B")]
		public const short SolarCandelabra = 4149;

		// Token: 0x04004C20 RID: 19488
		[global::Cpp2ILInjected.Token(Token = "0x4005E6C")]
		public const short SolarCandle = 4150;

		// Token: 0x04004C21 RID: 19489
		[global::Cpp2ILInjected.Token(Token = "0x4005E6D")]
		public const short SolarChair = 4151;

		// Token: 0x04004C22 RID: 19490
		[global::Cpp2ILInjected.Token(Token = "0x4005E6E")]
		public const short SolarChandelier = 4152;

		// Token: 0x04004C23 RID: 19491
		[global::Cpp2ILInjected.Token(Token = "0x4005E6F")]
		public const short SolarChest = 4153;

		// Token: 0x04004C24 RID: 19492
		[global::Cpp2ILInjected.Token(Token = "0x4005E70")]
		public const short SolarClock = 4154;

		// Token: 0x04004C25 RID: 19493
		[global::Cpp2ILInjected.Token(Token = "0x4005E71")]
		public const short SolarDoor = 4155;

		// Token: 0x04004C26 RID: 19494
		[global::Cpp2ILInjected.Token(Token = "0x4005E72")]
		public const short SolarLamp = 4156;

		// Token: 0x04004C27 RID: 19495
		[global::Cpp2ILInjected.Token(Token = "0x4005E73")]
		public const short SolarLantern = 4157;

		// Token: 0x04004C28 RID: 19496
		[global::Cpp2ILInjected.Token(Token = "0x4005E74")]
		public const short SolarPiano = 4158;

		// Token: 0x04004C29 RID: 19497
		[global::Cpp2ILInjected.Token(Token = "0x4005E75")]
		public const short SolarPlatform = 4159;

		// Token: 0x04004C2A RID: 19498
		[global::Cpp2ILInjected.Token(Token = "0x4005E76")]
		public const short SolarSink = 4160;

		// Token: 0x04004C2B RID: 19499
		[global::Cpp2ILInjected.Token(Token = "0x4005E77")]
		public const short SolarSofa = 4161;

		// Token: 0x04004C2C RID: 19500
		[global::Cpp2ILInjected.Token(Token = "0x4005E78")]
		public const short SolarTable = 4162;

		// Token: 0x04004C2D RID: 19501
		[global::Cpp2ILInjected.Token(Token = "0x4005E79")]
		public const short SolarWorkbench = 4163;

		// Token: 0x04004C2E RID: 19502
		[global::Cpp2ILInjected.Token(Token = "0x4005E7A")]
		public const short Fake_SolarChest = 4164;

		// Token: 0x04004C2F RID: 19503
		[global::Cpp2ILInjected.Token(Token = "0x4005E7B")]
		public const short SolarToilet = 4165;

		// Token: 0x04004C30 RID: 19504
		[global::Cpp2ILInjected.Token(Token = "0x4005E7C")]
		public const short VortexBathtub = 4166;

		// Token: 0x04004C31 RID: 19505
		[global::Cpp2ILInjected.Token(Token = "0x4005E7D")]
		public const short VortexBed = 4167;

		// Token: 0x04004C32 RID: 19506
		[global::Cpp2ILInjected.Token(Token = "0x4005E7E")]
		public const short VortexBookcase = 4168;

		// Token: 0x04004C33 RID: 19507
		[global::Cpp2ILInjected.Token(Token = "0x4005E7F")]
		public const short VortexDresser = 4169;

		// Token: 0x04004C34 RID: 19508
		[global::Cpp2ILInjected.Token(Token = "0x4005E80")]
		public const short VortexCandelabra = 4170;

		// Token: 0x04004C35 RID: 19509
		[global::Cpp2ILInjected.Token(Token = "0x4005E81")]
		public const short VortexCandle = 4171;

		// Token: 0x04004C36 RID: 19510
		[global::Cpp2ILInjected.Token(Token = "0x4005E82")]
		public const short VortexChair = 4172;

		// Token: 0x04004C37 RID: 19511
		[global::Cpp2ILInjected.Token(Token = "0x4005E83")]
		public const short VortexChandelier = 4173;

		// Token: 0x04004C38 RID: 19512
		[global::Cpp2ILInjected.Token(Token = "0x4005E84")]
		public const short VortexChest = 4174;

		// Token: 0x04004C39 RID: 19513
		[global::Cpp2ILInjected.Token(Token = "0x4005E85")]
		public const short VortexClock = 4175;

		// Token: 0x04004C3A RID: 19514
		[global::Cpp2ILInjected.Token(Token = "0x4005E86")]
		public const short VortexDoor = 4176;

		// Token: 0x04004C3B RID: 19515
		[global::Cpp2ILInjected.Token(Token = "0x4005E87")]
		public const short VortexLamp = 4177;

		// Token: 0x04004C3C RID: 19516
		[global::Cpp2ILInjected.Token(Token = "0x4005E88")]
		public const short VortexLantern = 4178;

		// Token: 0x04004C3D RID: 19517
		[global::Cpp2ILInjected.Token(Token = "0x4005E89")]
		public const short VortexPiano = 4179;

		// Token: 0x04004C3E RID: 19518
		[global::Cpp2ILInjected.Token(Token = "0x4005E8A")]
		public const short VortexPlatform = 4180;

		// Token: 0x04004C3F RID: 19519
		[global::Cpp2ILInjected.Token(Token = "0x4005E8B")]
		public const short VortexSink = 4181;

		// Token: 0x04004C40 RID: 19520
		[global::Cpp2ILInjected.Token(Token = "0x4005E8C")]
		public const short VortexSofa = 4182;

		// Token: 0x04004C41 RID: 19521
		[global::Cpp2ILInjected.Token(Token = "0x4005E8D")]
		public const short VortexTable = 4183;

		// Token: 0x04004C42 RID: 19522
		[global::Cpp2ILInjected.Token(Token = "0x4005E8E")]
		public const short VortexWorkbench = 4184;

		// Token: 0x04004C43 RID: 19523
		[global::Cpp2ILInjected.Token(Token = "0x4005E8F")]
		public const short Fake_VortexChest = 4185;

		// Token: 0x04004C44 RID: 19524
		[global::Cpp2ILInjected.Token(Token = "0x4005E90")]
		public const short VortexToilet = 4186;

		// Token: 0x04004C45 RID: 19525
		[global::Cpp2ILInjected.Token(Token = "0x4005E91")]
		public const short NebulaBathtub = 4187;

		// Token: 0x04004C46 RID: 19526
		[global::Cpp2ILInjected.Token(Token = "0x4005E92")]
		public const short NebulaBed = 4188;

		// Token: 0x04004C47 RID: 19527
		[global::Cpp2ILInjected.Token(Token = "0x4005E93")]
		public const short NebulaBookcase = 4189;

		// Token: 0x04004C48 RID: 19528
		[global::Cpp2ILInjected.Token(Token = "0x4005E94")]
		public const short NebulaDresser = 4190;

		// Token: 0x04004C49 RID: 19529
		[global::Cpp2ILInjected.Token(Token = "0x4005E95")]
		public const short NebulaCandelabra = 4191;

		// Token: 0x04004C4A RID: 19530
		[global::Cpp2ILInjected.Token(Token = "0x4005E96")]
		public const short NebulaCandle = 4192;

		// Token: 0x04004C4B RID: 19531
		[global::Cpp2ILInjected.Token(Token = "0x4005E97")]
		public const short NebulaChair = 4193;

		// Token: 0x04004C4C RID: 19532
		[global::Cpp2ILInjected.Token(Token = "0x4005E98")]
		public const short NebulaChandelier = 4194;

		// Token: 0x04004C4D RID: 19533
		[global::Cpp2ILInjected.Token(Token = "0x4005E99")]
		public const short NebulaChest = 4195;

		// Token: 0x04004C4E RID: 19534
		[global::Cpp2ILInjected.Token(Token = "0x4005E9A")]
		public const short NebulaClock = 4196;

		// Token: 0x04004C4F RID: 19535
		[global::Cpp2ILInjected.Token(Token = "0x4005E9B")]
		public const short NebulaDoor = 4197;

		// Token: 0x04004C50 RID: 19536
		[global::Cpp2ILInjected.Token(Token = "0x4005E9C")]
		public const short NebulaLamp = 4198;

		// Token: 0x04004C51 RID: 19537
		[global::Cpp2ILInjected.Token(Token = "0x4005E9D")]
		public const short NebulaLantern = 4199;

		// Token: 0x04004C52 RID: 19538
		[global::Cpp2ILInjected.Token(Token = "0x4005E9E")]
		public const short NebulaPiano = 4200;

		// Token: 0x04004C53 RID: 19539
		[global::Cpp2ILInjected.Token(Token = "0x4005E9F")]
		public const short NebulaPlatform = 4201;

		// Token: 0x04004C54 RID: 19540
		[global::Cpp2ILInjected.Token(Token = "0x4005EA0")]
		public const short NebulaSink = 4202;

		// Token: 0x04004C55 RID: 19541
		[global::Cpp2ILInjected.Token(Token = "0x4005EA1")]
		public const short NebulaSofa = 4203;

		// Token: 0x04004C56 RID: 19542
		[global::Cpp2ILInjected.Token(Token = "0x4005EA2")]
		public const short NebulaTable = 4204;

		// Token: 0x04004C57 RID: 19543
		[global::Cpp2ILInjected.Token(Token = "0x4005EA3")]
		public const short NebulaWorkbench = 4205;

		// Token: 0x04004C58 RID: 19544
		[global::Cpp2ILInjected.Token(Token = "0x4005EA4")]
		public const short Fake_NebulaChest = 4206;

		// Token: 0x04004C59 RID: 19545
		[global::Cpp2ILInjected.Token(Token = "0x4005EA5")]
		public const short NebulaToilet = 4207;

		// Token: 0x04004C5A RID: 19546
		[global::Cpp2ILInjected.Token(Token = "0x4005EA6")]
		public const short StardustBathtub = 4208;

		// Token: 0x04004C5B RID: 19547
		[global::Cpp2ILInjected.Token(Token = "0x4005EA7")]
		public const short StardustBed = 4209;

		// Token: 0x04004C5C RID: 19548
		[global::Cpp2ILInjected.Token(Token = "0x4005EA8")]
		public const short StardustBookcase = 4210;

		// Token: 0x04004C5D RID: 19549
		[global::Cpp2ILInjected.Token(Token = "0x4005EA9")]
		public const short StardustDresser = 4211;

		// Token: 0x04004C5E RID: 19550
		[global::Cpp2ILInjected.Token(Token = "0x4005EAA")]
		public const short StardustCandelabra = 4212;

		// Token: 0x04004C5F RID: 19551
		[global::Cpp2ILInjected.Token(Token = "0x4005EAB")]
		public const short StardustCandle = 4213;

		// Token: 0x04004C60 RID: 19552
		[global::Cpp2ILInjected.Token(Token = "0x4005EAC")]
		public const short StardustChair = 4214;

		// Token: 0x04004C61 RID: 19553
		[global::Cpp2ILInjected.Token(Token = "0x4005EAD")]
		public const short StardustChandelier = 4215;

		// Token: 0x04004C62 RID: 19554
		[global::Cpp2ILInjected.Token(Token = "0x4005EAE")]
		public const short StardustChest = 4216;

		// Token: 0x04004C63 RID: 19555
		[global::Cpp2ILInjected.Token(Token = "0x4005EAF")]
		public const short StardustClock = 4217;

		// Token: 0x04004C64 RID: 19556
		[global::Cpp2ILInjected.Token(Token = "0x4005EB0")]
		public const short StardustDoor = 4218;

		// Token: 0x04004C65 RID: 19557
		[global::Cpp2ILInjected.Token(Token = "0x4005EB1")]
		public const short StardustLamp = 4219;

		// Token: 0x04004C66 RID: 19558
		[global::Cpp2ILInjected.Token(Token = "0x4005EB2")]
		public const short StardustLantern = 4220;

		// Token: 0x04004C67 RID: 19559
		[global::Cpp2ILInjected.Token(Token = "0x4005EB3")]
		public const short StardustPiano = 4221;

		// Token: 0x04004C68 RID: 19560
		[global::Cpp2ILInjected.Token(Token = "0x4005EB4")]
		public const short StardustPlatform = 4222;

		// Token: 0x04004C69 RID: 19561
		[global::Cpp2ILInjected.Token(Token = "0x4005EB5")]
		public const short StardustSink = 4223;

		// Token: 0x04004C6A RID: 19562
		[global::Cpp2ILInjected.Token(Token = "0x4005EB6")]
		public const short StardustSofa = 4224;

		// Token: 0x04004C6B RID: 19563
		[global::Cpp2ILInjected.Token(Token = "0x4005EB7")]
		public const short StardustTable = 4225;

		// Token: 0x04004C6C RID: 19564
		[global::Cpp2ILInjected.Token(Token = "0x4005EB8")]
		public const short StardustWorkbench = 4226;

		// Token: 0x04004C6D RID: 19565
		[global::Cpp2ILInjected.Token(Token = "0x4005EB9")]
		public const short Fake_StardustChest = 4227;

		// Token: 0x04004C6E RID: 19566
		[global::Cpp2ILInjected.Token(Token = "0x4005EBA")]
		public const short StardustToilet = 4228;

		// Token: 0x04004C6F RID: 19567
		[global::Cpp2ILInjected.Token(Token = "0x4005EBB")]
		public const short SolarBrick = 4229;

		// Token: 0x04004C70 RID: 19568
		[global::Cpp2ILInjected.Token(Token = "0x4005EBC")]
		public const short VortexBrick = 4230;

		// Token: 0x04004C71 RID: 19569
		[global::Cpp2ILInjected.Token(Token = "0x4005EBD")]
		public const short NebulaBrick = 4231;

		// Token: 0x04004C72 RID: 19570
		[global::Cpp2ILInjected.Token(Token = "0x4005EBE")]
		public const short StardustBrick = 4232;

		// Token: 0x04004C73 RID: 19571
		[global::Cpp2ILInjected.Token(Token = "0x4005EBF")]
		public const short SolarBrickWall = 4233;

		// Token: 0x04004C74 RID: 19572
		[global::Cpp2ILInjected.Token(Token = "0x4005EC0")]
		public const short VortexBrickWall = 4234;

		// Token: 0x04004C75 RID: 19573
		[global::Cpp2ILInjected.Token(Token = "0x4005EC1")]
		public const short NebulaBrickWall = 4235;

		// Token: 0x04004C76 RID: 19574
		[global::Cpp2ILInjected.Token(Token = "0x4005EC2")]
		public const short StardustBrickWall = 4236;

		// Token: 0x04004C77 RID: 19575
		[global::Cpp2ILInjected.Token(Token = "0x4005EC3")]
		public const short MusicBoxDayRemix = 4237;

		// Token: 0x04004C78 RID: 19576
		[global::Cpp2ILInjected.Token(Token = "0x4005EC4")]
		public const short CrackedBlueBrick = 4238;

		// Token: 0x04004C79 RID: 19577
		[global::Cpp2ILInjected.Token(Token = "0x4005EC5")]
		public const short CrackedGreenBrick = 4239;

		// Token: 0x04004C7A RID: 19578
		[global::Cpp2ILInjected.Token(Token = "0x4005EC6")]
		public const short CrackedPinkBrick = 4240;

		// Token: 0x04004C7B RID: 19579
		[global::Cpp2ILInjected.Token(Token = "0x4005EC7")]
		public const short FlowerPacketWild = 4241;

		// Token: 0x04004C7C RID: 19580
		[global::Cpp2ILInjected.Token(Token = "0x4005EC8")]
		public const short GolfBallDyedBlack = 4242;

		// Token: 0x04004C7D RID: 19581
		[global::Cpp2ILInjected.Token(Token = "0x4005EC9")]
		public const short GolfBallDyedBlue = 4243;

		// Token: 0x04004C7E RID: 19582
		[global::Cpp2ILInjected.Token(Token = "0x4005ECA")]
		public const short GolfBallDyedBrown = 4244;

		// Token: 0x04004C7F RID: 19583
		[global::Cpp2ILInjected.Token(Token = "0x4005ECB")]
		public const short GolfBallDyedCyan = 4245;

		// Token: 0x04004C80 RID: 19584
		[global::Cpp2ILInjected.Token(Token = "0x4005ECC")]
		public const short GolfBallDyedGreen = 4246;

		// Token: 0x04004C81 RID: 19585
		[global::Cpp2ILInjected.Token(Token = "0x4005ECD")]
		public const short GolfBallDyedLimeGreen = 4247;

		// Token: 0x04004C82 RID: 19586
		[global::Cpp2ILInjected.Token(Token = "0x4005ECE")]
		public const short GolfBallDyedOrange = 4248;

		// Token: 0x04004C83 RID: 19587
		[global::Cpp2ILInjected.Token(Token = "0x4005ECF")]
		public const short GolfBallDyedPink = 4249;

		// Token: 0x04004C84 RID: 19588
		[global::Cpp2ILInjected.Token(Token = "0x4005ED0")]
		public const short GolfBallDyedPurple = 4250;

		// Token: 0x04004C85 RID: 19589
		[global::Cpp2ILInjected.Token(Token = "0x4005ED1")]
		public const short GolfBallDyedRed = 4251;

		// Token: 0x04004C86 RID: 19590
		[global::Cpp2ILInjected.Token(Token = "0x4005ED2")]
		public const short GolfBallDyedSkyBlue = 4252;

		// Token: 0x04004C87 RID: 19591
		[global::Cpp2ILInjected.Token(Token = "0x4005ED3")]
		public const short GolfBallDyedTeal = 4253;

		// Token: 0x04004C88 RID: 19592
		[global::Cpp2ILInjected.Token(Token = "0x4005ED4")]
		public const short GolfBallDyedViolet = 4254;

		// Token: 0x04004C89 RID: 19593
		[global::Cpp2ILInjected.Token(Token = "0x4005ED5")]
		public const short GolfBallDyedYellow = 4255;

		// Token: 0x04004C8A RID: 19594
		[global::Cpp2ILInjected.Token(Token = "0x4005ED6")]
		public const short AmberRobe = 4256;

		// Token: 0x04004C8B RID: 19595
		[global::Cpp2ILInjected.Token(Token = "0x4005ED7")]
		public const short AmberHook = 4257;

		// Token: 0x04004C8C RID: 19596
		[global::Cpp2ILInjected.Token(Token = "0x4005ED8")]
		public const short OrangePhaseblade = 4258;

		// Token: 0x04004C8D RID: 19597
		[global::Cpp2ILInjected.Token(Token = "0x4005ED9")]
		public const short OrangePhasesaber = 4259;

		// Token: 0x04004C8E RID: 19598
		[global::Cpp2ILInjected.Token(Token = "0x4005EDA")]
		public const short OrangeStainedGlass = 4260;

		// Token: 0x04004C8F RID: 19599
		[global::Cpp2ILInjected.Token(Token = "0x4005EDB")]
		public const short OrangePressurePlate = 4261;

		// Token: 0x04004C90 RID: 19600
		[global::Cpp2ILInjected.Token(Token = "0x4005EDC")]
		public const short MysticCoilSnake = 4262;

		// Token: 0x04004C91 RID: 19601
		[global::Cpp2ILInjected.Token(Token = "0x4005EDD")]
		public const short MagicConch = 4263;

		// Token: 0x04004C92 RID: 19602
		[global::Cpp2ILInjected.Token(Token = "0x4005EDE")]
		public const short GolfCart = 4264;

		// Token: 0x04004C93 RID: 19603
		[global::Cpp2ILInjected.Token(Token = "0x4005EDF")]
		public const short GolfChest = 4265;

		// Token: 0x04004C94 RID: 19604
		[global::Cpp2ILInjected.Token(Token = "0x4005EE0")]
		public const short Fake_GolfChest = 4266;

		// Token: 0x04004C95 RID: 19605
		[global::Cpp2ILInjected.Token(Token = "0x4005EE1")]
		public const short DesertChest = 4267;

		// Token: 0x04004C96 RID: 19606
		[global::Cpp2ILInjected.Token(Token = "0x4005EE2")]
		public const short Fake_DesertChest = 4268;

		// Token: 0x04004C97 RID: 19607
		[global::Cpp2ILInjected.Token(Token = "0x4005EE3")]
		public const short SanguineStaff = 4269;

		// Token: 0x04004C98 RID: 19608
		[global::Cpp2ILInjected.Token(Token = "0x4005EE4")]
		public const short SharpTears = 4270;

		// Token: 0x04004C99 RID: 19609
		[global::Cpp2ILInjected.Token(Token = "0x4005EE5")]
		public const short BloodMoonStarter = 4271;

		// Token: 0x04004C9A RID: 19610
		[global::Cpp2ILInjected.Token(Token = "0x4005EE6")]
		public const short DripplerFlail = 4272;

		// Token: 0x04004C9B RID: 19611
		[global::Cpp2ILInjected.Token(Token = "0x4005EE7")]
		public const short VampireFrogStaff = 4273;

		// Token: 0x04004C9C RID: 19612
		[global::Cpp2ILInjected.Token(Token = "0x4005EE8")]
		public const short GoldGoldfish = 4274;

		// Token: 0x04004C9D RID: 19613
		[global::Cpp2ILInjected.Token(Token = "0x4005EE9")]
		public const short GoldGoldfishBowl = 4275;

		// Token: 0x04004C9E RID: 19614
		[global::Cpp2ILInjected.Token(Token = "0x4005EEA")]
		public const short CatBast = 4276;

		// Token: 0x04004C9F RID: 19615
		[global::Cpp2ILInjected.Token(Token = "0x4005EEB")]
		public const short GoldStarryGlassBlock = 4277;

		// Token: 0x04004CA0 RID: 19616
		[global::Cpp2ILInjected.Token(Token = "0x4005EEC")]
		public const short BlueStarryGlassBlock = 4278;

		// Token: 0x04004CA1 RID: 19617
		[global::Cpp2ILInjected.Token(Token = "0x4005EED")]
		public const short GoldStarryGlassWall = 4279;

		// Token: 0x04004CA2 RID: 19618
		[global::Cpp2ILInjected.Token(Token = "0x4005EEE")]
		public const short BlueStarryGlassWall = 4280;

		// Token: 0x04004CA3 RID: 19619
		[global::Cpp2ILInjected.Token(Token = "0x4005EEF")]
		public const short BabyBirdStaff = 4281;

		// Token: 0x04004CA4 RID: 19620
		[global::Cpp2ILInjected.Token(Token = "0x4005EF0")]
		public const short Apricot = 4282;

		// Token: 0x04004CA5 RID: 19621
		[global::Cpp2ILInjected.Token(Token = "0x4005EF1")]
		public const short Banana = 4283;

		// Token: 0x04004CA6 RID: 19622
		[global::Cpp2ILInjected.Token(Token = "0x4005EF2")]
		public const short BlackCurrant = 4284;

		// Token: 0x04004CA7 RID: 19623
		[global::Cpp2ILInjected.Token(Token = "0x4005EF3")]
		public const short BloodOrange = 4285;

		// Token: 0x04004CA8 RID: 19624
		[global::Cpp2ILInjected.Token(Token = "0x4005EF4")]
		public const short Cherry = 4286;

		// Token: 0x04004CA9 RID: 19625
		[global::Cpp2ILInjected.Token(Token = "0x4005EF5")]
		public const short Coconut = 4287;

		// Token: 0x04004CAA RID: 19626
		[global::Cpp2ILInjected.Token(Token = "0x4005EF6")]
		public const short Dragonfruit = 4288;

		// Token: 0x04004CAB RID: 19627
		[global::Cpp2ILInjected.Token(Token = "0x4005EF7")]
		public const short Elderberry = 4289;

		// Token: 0x04004CAC RID: 19628
		[global::Cpp2ILInjected.Token(Token = "0x4005EF8")]
		public const short Grapefruit = 4290;

		// Token: 0x04004CAD RID: 19629
		[global::Cpp2ILInjected.Token(Token = "0x4005EF9")]
		public const short Lemon = 4291;

		// Token: 0x04004CAE RID: 19630
		[global::Cpp2ILInjected.Token(Token = "0x4005EFA")]
		public const short Mango = 4292;

		// Token: 0x04004CAF RID: 19631
		[global::Cpp2ILInjected.Token(Token = "0x4005EFB")]
		public const short Peach = 4293;

		// Token: 0x04004CB0 RID: 19632
		[global::Cpp2ILInjected.Token(Token = "0x4005EFC")]
		public const short Pineapple = 4294;

		// Token: 0x04004CB1 RID: 19633
		[global::Cpp2ILInjected.Token(Token = "0x4005EFD")]
		public const short Plum = 4295;

		// Token: 0x04004CB2 RID: 19634
		[global::Cpp2ILInjected.Token(Token = "0x4005EFE")]
		public const short Rambutan = 4296;

		// Token: 0x04004CB3 RID: 19635
		[global::Cpp2ILInjected.Token(Token = "0x4005EFF")]
		public const short Starfruit = 4297;

		// Token: 0x04004CB4 RID: 19636
		[global::Cpp2ILInjected.Token(Token = "0x4005F00")]
		public const short SandstoneBathtub = 4298;

		// Token: 0x04004CB5 RID: 19637
		[global::Cpp2ILInjected.Token(Token = "0x4005F01")]
		public const short SandstoneBed = 4299;

		// Token: 0x04004CB6 RID: 19638
		[global::Cpp2ILInjected.Token(Token = "0x4005F02")]
		public const short SandstoneBookcase = 4300;

		// Token: 0x04004CB7 RID: 19639
		[global::Cpp2ILInjected.Token(Token = "0x4005F03")]
		public const short SandstoneDresser = 4301;

		// Token: 0x04004CB8 RID: 19640
		[global::Cpp2ILInjected.Token(Token = "0x4005F04")]
		public const short SandstoneCandelabra = 4302;

		// Token: 0x04004CB9 RID: 19641
		[global::Cpp2ILInjected.Token(Token = "0x4005F05")]
		public const short SandstoneCandle = 4303;

		// Token: 0x04004CBA RID: 19642
		[global::Cpp2ILInjected.Token(Token = "0x4005F06")]
		public const short SandstoneChair = 4304;

		// Token: 0x04004CBB RID: 19643
		[global::Cpp2ILInjected.Token(Token = "0x4005F07")]
		public const short SandstoneChandelier = 4305;

		// Token: 0x04004CBC RID: 19644
		[global::Cpp2ILInjected.Token(Token = "0x4005F08")]
		public const short SandstoneClock = 4306;

		// Token: 0x04004CBD RID: 19645
		[global::Cpp2ILInjected.Token(Token = "0x4005F09")]
		public const short SandstoneDoor = 4307;

		// Token: 0x04004CBE RID: 19646
		[global::Cpp2ILInjected.Token(Token = "0x4005F0A")]
		public const short SandstoneLamp = 4308;

		// Token: 0x04004CBF RID: 19647
		[global::Cpp2ILInjected.Token(Token = "0x4005F0B")]
		public const short SandstoneLantern = 4309;

		// Token: 0x04004CC0 RID: 19648
		[global::Cpp2ILInjected.Token(Token = "0x4005F0C")]
		public const short SandstonePiano = 4310;

		// Token: 0x04004CC1 RID: 19649
		[global::Cpp2ILInjected.Token(Token = "0x4005F0D")]
		public const short SandstonePlatform = 4311;

		// Token: 0x04004CC2 RID: 19650
		[global::Cpp2ILInjected.Token(Token = "0x4005F0E")]
		public const short SandstoneSink = 4312;

		// Token: 0x04004CC3 RID: 19651
		[global::Cpp2ILInjected.Token(Token = "0x4005F0F")]
		public const short SandstoneSofa = 4313;

		// Token: 0x04004CC4 RID: 19652
		[global::Cpp2ILInjected.Token(Token = "0x4005F10")]
		public const short SandstoneTable = 4314;

		// Token: 0x04004CC5 RID: 19653
		[global::Cpp2ILInjected.Token(Token = "0x4005F11")]
		public const short SandstoneWorkbench = 4315;

		// Token: 0x04004CC6 RID: 19654
		[global::Cpp2ILInjected.Token(Token = "0x4005F12")]
		public const short SandstoneToilet = 4316;

		// Token: 0x04004CC7 RID: 19655
		[global::Cpp2ILInjected.Token(Token = "0x4005F13")]
		public const short BloodHamaxe = 4317;

		// Token: 0x04004CC8 RID: 19656
		[global::Cpp2ILInjected.Token(Token = "0x4005F14")]
		public const short VoidMonolith = 4318;

		// Token: 0x04004CC9 RID: 19657
		[global::Cpp2ILInjected.Token(Token = "0x4005F15")]
		public const short ArrowSign = 4319;

		// Token: 0x04004CCA RID: 19658
		[global::Cpp2ILInjected.Token(Token = "0x4005F16")]
		public const short PaintedArrowSign = 4320;

		// Token: 0x04004CCB RID: 19659
		[global::Cpp2ILInjected.Token(Token = "0x4005F17")]
		public const short GameMasterShirt = 4321;

		// Token: 0x04004CCC RID: 19660
		[global::Cpp2ILInjected.Token(Token = "0x4005F18")]
		public const short GameMasterPants = 4322;

		// Token: 0x04004CCD RID: 19661
		[global::Cpp2ILInjected.Token(Token = "0x4005F19")]
		public const short StarPrincessCrown = 4323;

		// Token: 0x04004CCE RID: 19662
		[global::Cpp2ILInjected.Token(Token = "0x4005F1A")]
		public const short StarPrincessDress = 4324;

		// Token: 0x04004CCF RID: 19663
		[global::Cpp2ILInjected.Token(Token = "0x4005F1B")]
		public const short BloodFishingRod = 4325;

		// Token: 0x04004CD0 RID: 19664
		[global::Cpp2ILInjected.Token(Token = "0x4005F1C")]
		public const short FoodPlatter = 4326;

		// Token: 0x04004CD1 RID: 19665
		[global::Cpp2ILInjected.Token(Token = "0x4005F1D")]
		public const short BlackDragonflyJar = 4327;

		// Token: 0x04004CD2 RID: 19666
		[global::Cpp2ILInjected.Token(Token = "0x4005F1E")]
		public const short BlueDragonflyJar = 4328;

		// Token: 0x04004CD3 RID: 19667
		[global::Cpp2ILInjected.Token(Token = "0x4005F1F")]
		public const short GreenDragonflyJar = 4329;

		// Token: 0x04004CD4 RID: 19668
		[global::Cpp2ILInjected.Token(Token = "0x4005F20")]
		public const short OrangeDragonflyJar = 4330;

		// Token: 0x04004CD5 RID: 19669
		[global::Cpp2ILInjected.Token(Token = "0x4005F21")]
		public const short RedDragonflyJar = 4331;

		// Token: 0x04004CD6 RID: 19670
		[global::Cpp2ILInjected.Token(Token = "0x4005F22")]
		public const short YellowDragonflyJar = 4332;

		// Token: 0x04004CD7 RID: 19671
		[global::Cpp2ILInjected.Token(Token = "0x4005F23")]
		public const short GoldDragonflyJar = 4333;

		// Token: 0x04004CD8 RID: 19672
		[global::Cpp2ILInjected.Token(Token = "0x4005F24")]
		public const short BlackDragonfly = 4334;

		// Token: 0x04004CD9 RID: 19673
		[global::Cpp2ILInjected.Token(Token = "0x4005F25")]
		public const short BlueDragonfly = 4335;

		// Token: 0x04004CDA RID: 19674
		[global::Cpp2ILInjected.Token(Token = "0x4005F26")]
		public const short GreenDragonfly = 4336;

		// Token: 0x04004CDB RID: 19675
		[global::Cpp2ILInjected.Token(Token = "0x4005F27")]
		public const short OrangeDragonfly = 4337;

		// Token: 0x04004CDC RID: 19676
		[global::Cpp2ILInjected.Token(Token = "0x4005F28")]
		public const short RedDragonfly = 4338;

		// Token: 0x04004CDD RID: 19677
		[global::Cpp2ILInjected.Token(Token = "0x4005F29")]
		public const short YellowDragonfly = 4339;

		// Token: 0x04004CDE RID: 19678
		[global::Cpp2ILInjected.Token(Token = "0x4005F2A")]
		public const short GoldDragonfly = 4340;

		// Token: 0x04004CDF RID: 19679
		[global::Cpp2ILInjected.Token(Token = "0x4005F2B")]
		public const short PortableStool = 4341;

		// Token: 0x04004CE0 RID: 19680
		[global::Cpp2ILInjected.Token(Token = "0x4005F2C")]
		public const short DragonflyStatue = 4342;

		// Token: 0x04004CE1 RID: 19681
		[global::Cpp2ILInjected.Token(Token = "0x4005F2D")]
		public const short PaperAirplaneA = 4343;

		// Token: 0x04004CE2 RID: 19682
		[global::Cpp2ILInjected.Token(Token = "0x4005F2E")]
		public const short PaperAirplaneB = 4344;

		// Token: 0x04004CE3 RID: 19683
		[global::Cpp2ILInjected.Token(Token = "0x4005F2F")]
		public const short CanOfWorms = 4345;

		// Token: 0x04004CE4 RID: 19684
		[global::Cpp2ILInjected.Token(Token = "0x4005F30")]
		public const short EncumberingStone = 4346;

		// Token: 0x04004CE5 RID: 19685
		[global::Cpp2ILInjected.Token(Token = "0x4005F31")]
		public const short ZapinatorGray = 4347;

		// Token: 0x04004CE6 RID: 19686
		[global::Cpp2ILInjected.Token(Token = "0x4005F32")]
		public const short ZapinatorOrange = 4348;

		// Token: 0x04004CE7 RID: 19687
		[global::Cpp2ILInjected.Token(Token = "0x4005F33")]
		public const short GreenMoss = 4349;

		// Token: 0x04004CE8 RID: 19688
		[global::Cpp2ILInjected.Token(Token = "0x4005F34")]
		public const short BrownMoss = 4350;

		// Token: 0x04004CE9 RID: 19689
		[global::Cpp2ILInjected.Token(Token = "0x4005F35")]
		public const short RedMoss = 4351;

		// Token: 0x04004CEA RID: 19690
		[global::Cpp2ILInjected.Token(Token = "0x4005F36")]
		public const short BlueMoss = 4352;

		// Token: 0x04004CEB RID: 19691
		[global::Cpp2ILInjected.Token(Token = "0x4005F37")]
		public const short PurpleMoss = 4353;

		// Token: 0x04004CEC RID: 19692
		[global::Cpp2ILInjected.Token(Token = "0x4005F38")]
		public const short LavaMoss = 4354;

		// Token: 0x04004CED RID: 19693
		[global::Cpp2ILInjected.Token(Token = "0x4005F39")]
		public const short BoulderStatue = 4355;

		// Token: 0x04004CEE RID: 19694
		[global::Cpp2ILInjected.Token(Token = "0x4005F3A")]
		public const short MusicBoxTitleAlt = 4356;

		// Token: 0x04004CEF RID: 19695
		[global::Cpp2ILInjected.Token(Token = "0x4005F3B")]
		public const short MusicBoxStorm = 4357;

		// Token: 0x04004CF0 RID: 19696
		[global::Cpp2ILInjected.Token(Token = "0x4005F3C")]
		public const short MusicBoxGraveyard = 4358;

		// Token: 0x04004CF1 RID: 19697
		[global::Cpp2ILInjected.Token(Token = "0x4005F3D")]
		public const short Seagull = 4359;

		// Token: 0x04004CF2 RID: 19698
		[global::Cpp2ILInjected.Token(Token = "0x4005F3E")]
		public const short SeagullStatue = 4360;

		// Token: 0x04004CF3 RID: 19699
		[global::Cpp2ILInjected.Token(Token = "0x4005F3F")]
		public const short LadyBug = 4361;

		// Token: 0x04004CF4 RID: 19700
		[global::Cpp2ILInjected.Token(Token = "0x4005F40")]
		public const short GoldLadyBug = 4362;

		// Token: 0x04004CF5 RID: 19701
		[global::Cpp2ILInjected.Token(Token = "0x4005F41")]
		public const short Maggot = 4363;

		// Token: 0x04004CF6 RID: 19702
		[global::Cpp2ILInjected.Token(Token = "0x4005F42")]
		public const short MaggotCage = 4364;

		// Token: 0x04004CF7 RID: 19703
		[global::Cpp2ILInjected.Token(Token = "0x4005F43")]
		public const short CelestialWand = 4365;

		// Token: 0x04004CF8 RID: 19704
		[global::Cpp2ILInjected.Token(Token = "0x4005F44")]
		public const short EucaluptusSap = 4366;

		// Token: 0x04004CF9 RID: 19705
		[global::Cpp2ILInjected.Token(Token = "0x4005F45")]
		public const short KiteBlue = 4367;

		// Token: 0x04004CFA RID: 19706
		[global::Cpp2ILInjected.Token(Token = "0x4005F46")]
		public const short KiteBlueAndYellow = 4368;

		// Token: 0x04004CFB RID: 19707
		[global::Cpp2ILInjected.Token(Token = "0x4005F47")]
		public const short KiteRed = 4369;

		// Token: 0x04004CFC RID: 19708
		[global::Cpp2ILInjected.Token(Token = "0x4005F48")]
		public const short KiteRedAndYellow = 4370;

		// Token: 0x04004CFD RID: 19709
		[global::Cpp2ILInjected.Token(Token = "0x4005F49")]
		public const short KiteYellow = 4371;

		// Token: 0x04004CFE RID: 19710
		[global::Cpp2ILInjected.Token(Token = "0x4005F4A")]
		public const short IvyGuitar = 4372;

		// Token: 0x04004CFF RID: 19711
		[global::Cpp2ILInjected.Token(Token = "0x4005F4B")]
		public const short Pupfish = 4373;

		// Token: 0x04004D00 RID: 19712
		[global::Cpp2ILInjected.Token(Token = "0x4005F4C")]
		public const short Grebe = 4374;

		// Token: 0x04004D01 RID: 19713
		[global::Cpp2ILInjected.Token(Token = "0x4005F4D")]
		public const short Rat = 4375;

		// Token: 0x04004D02 RID: 19714
		[global::Cpp2ILInjected.Token(Token = "0x4005F4E")]
		public const short RatCage = 4376;

		// Token: 0x04004D03 RID: 19715
		[global::Cpp2ILInjected.Token(Token = "0x4005F4F")]
		public const short KryptonMoss = 4377;

		// Token: 0x04004D04 RID: 19716
		[global::Cpp2ILInjected.Token(Token = "0x4005F50")]
		public const short XenonMoss = 4378;

		// Token: 0x04004D05 RID: 19717
		[global::Cpp2ILInjected.Token(Token = "0x4005F51")]
		public const short KiteWyvern = 4379;

		// Token: 0x04004D06 RID: 19718
		[global::Cpp2ILInjected.Token(Token = "0x4005F52")]
		public const short LadybugCage = 4380;

		// Token: 0x04004D07 RID: 19719
		[global::Cpp2ILInjected.Token(Token = "0x4005F53")]
		public const short BloodRainBow = 4381;

		// Token: 0x04004D08 RID: 19720
		[global::Cpp2ILInjected.Token(Token = "0x4005F54")]
		public const short CombatBook = 4382;

		// Token: 0x04004D09 RID: 19721
		[global::Cpp2ILInjected.Token(Token = "0x4005F55")]
		public const short DesertTorch = 4383;

		// Token: 0x04004D0A RID: 19722
		[global::Cpp2ILInjected.Token(Token = "0x4005F56")]
		public const short CoralTorch = 4384;

		// Token: 0x04004D0B RID: 19723
		[global::Cpp2ILInjected.Token(Token = "0x4005F57")]
		public const short CorruptTorch = 4385;

		// Token: 0x04004D0C RID: 19724
		[global::Cpp2ILInjected.Token(Token = "0x4005F58")]
		public const short CrimsonTorch = 4386;

		// Token: 0x04004D0D RID: 19725
		[global::Cpp2ILInjected.Token(Token = "0x4005F59")]
		public const short HallowedTorch = 4387;

		// Token: 0x04004D0E RID: 19726
		[global::Cpp2ILInjected.Token(Token = "0x4005F5A")]
		public const short JungleTorch = 4388;

		// Token: 0x04004D0F RID: 19727
		[global::Cpp2ILInjected.Token(Token = "0x4005F5B")]
		public const short ArgonMoss = 4389;

		// Token: 0x04004D10 RID: 19728
		[global::Cpp2ILInjected.Token(Token = "0x4005F5C")]
		public const short RollingCactus = 4390;

		// Token: 0x04004D11 RID: 19729
		[global::Cpp2ILInjected.Token(Token = "0x4005F5D")]
		public const short ThinIce = 4391;

		// Token: 0x04004D12 RID: 19730
		[global::Cpp2ILInjected.Token(Token = "0x4005F5E")]
		public const short EchoBlock = 4392;

		// Token: 0x04004D13 RID: 19731
		[global::Cpp2ILInjected.Token(Token = "0x4005F5F")]
		public const short ScarabFish = 4393;

		// Token: 0x04004D14 RID: 19732
		[global::Cpp2ILInjected.Token(Token = "0x4005F60")]
		public const short ScorpioFish = 4394;

		// Token: 0x04004D15 RID: 19733
		[global::Cpp2ILInjected.Token(Token = "0x4005F61")]
		public const short Owl = 4395;

		// Token: 0x04004D16 RID: 19734
		[global::Cpp2ILInjected.Token(Token = "0x4005F62")]
		public const short OwlCage = 4396;

		// Token: 0x04004D17 RID: 19735
		[global::Cpp2ILInjected.Token(Token = "0x4005F63")]
		public const short OwlStatue = 4397;

		// Token: 0x04004D18 RID: 19736
		[global::Cpp2ILInjected.Token(Token = "0x4005F64")]
		public const short PupfishBowl = 4398;

		// Token: 0x04004D19 RID: 19737
		[global::Cpp2ILInjected.Token(Token = "0x4005F65")]
		public const short GoldLadybugCage = 4399;

		// Token: 0x04004D1A RID: 19738
		[global::Cpp2ILInjected.Token(Token = "0x4005F66")]
		public const short Geode = 4400;

		// Token: 0x04004D1B RID: 19739
		[global::Cpp2ILInjected.Token(Token = "0x4005F67")]
		public const short Flounder = 4401;

		// Token: 0x04004D1C RID: 19740
		[global::Cpp2ILInjected.Token(Token = "0x4005F68")]
		public const short RockLobster = 4402;

		// Token: 0x04004D1D RID: 19741
		[global::Cpp2ILInjected.Token(Token = "0x4005F69")]
		public const short LobsterTail = 4403;

		// Token: 0x04004D1E RID: 19742
		[global::Cpp2ILInjected.Token(Token = "0x4005F6A")]
		public const short FloatingTube = 4404;

		// Token: 0x04004D1F RID: 19743
		[global::Cpp2ILInjected.Token(Token = "0x4005F6B")]
		public const short FrozenCrate = 4405;

		// Token: 0x04004D20 RID: 19744
		[global::Cpp2ILInjected.Token(Token = "0x4005F6C")]
		public const short FrozenCrateHard = 4406;

		// Token: 0x04004D21 RID: 19745
		[global::Cpp2ILInjected.Token(Token = "0x4005F6D")]
		public const short OasisCrate = 4407;

		// Token: 0x04004D22 RID: 19746
		[global::Cpp2ILInjected.Token(Token = "0x4005F6E")]
		public const short OasisCrateHard = 4408;

		// Token: 0x04004D23 RID: 19747
		[global::Cpp2ILInjected.Token(Token = "0x4005F6F")]
		public const short SpectreGoggles = 4409;

		// Token: 0x04004D24 RID: 19748
		[global::Cpp2ILInjected.Token(Token = "0x4005F70")]
		public const short Oyster = 4410;

		// Token: 0x04004D25 RID: 19749
		[global::Cpp2ILInjected.Token(Token = "0x4005F71")]
		public const short ShuckedOyster = 4411;

		// Token: 0x04004D26 RID: 19750
		[global::Cpp2ILInjected.Token(Token = "0x4005F72")]
		public const short WhitePearl = 4412;

		// Token: 0x04004D27 RID: 19751
		[global::Cpp2ILInjected.Token(Token = "0x4005F73")]
		public const short BlackPearl = 4413;

		// Token: 0x04004D28 RID: 19752
		[global::Cpp2ILInjected.Token(Token = "0x4005F74")]
		public const short PinkPearl = 4414;

		// Token: 0x04004D29 RID: 19753
		[global::Cpp2ILInjected.Token(Token = "0x4005F75")]
		public const short StoneDoor = 4415;

		// Token: 0x04004D2A RID: 19754
		[global::Cpp2ILInjected.Token(Token = "0x4005F76")]
		public const short StonePlatform = 4416;

		// Token: 0x04004D2B RID: 19755
		[global::Cpp2ILInjected.Token(Token = "0x4005F77")]
		public const short OasisFountain = 4417;

		// Token: 0x04004D2C RID: 19756
		[global::Cpp2ILInjected.Token(Token = "0x4005F78")]
		public const short WaterStrider = 4418;

		// Token: 0x04004D2D RID: 19757
		[global::Cpp2ILInjected.Token(Token = "0x4005F79")]
		public const short GoldWaterStrider = 4419;

		// Token: 0x04004D2E RID: 19758
		[global::Cpp2ILInjected.Token(Token = "0x4005F7A")]
		public const short LawnFlamingo = 4420;

		// Token: 0x04004D2F RID: 19759
		[global::Cpp2ILInjected.Token(Token = "0x4005F7B")]
		public const short MusicBoxUndergroundJungle = 4421;

		// Token: 0x04004D30 RID: 19760
		[global::Cpp2ILInjected.Token(Token = "0x4005F7C")]
		public const short Grate = 4422;

		// Token: 0x04004D31 RID: 19761
		[global::Cpp2ILInjected.Token(Token = "0x4005F7D")]
		public const short ScarabBomb = 4423;

		// Token: 0x04004D32 RID: 19762
		[global::Cpp2ILInjected.Token(Token = "0x4005F7E")]
		public const short WroughtIronFence = 4424;

		// Token: 0x04004D33 RID: 19763
		[global::Cpp2ILInjected.Token(Token = "0x4005F7F")]
		public const short SharkBait = 4425;

		// Token: 0x04004D34 RID: 19764
		[global::Cpp2ILInjected.Token(Token = "0x4005F80")]
		public const short BeeMinecart = 4426;

		// Token: 0x04004D35 RID: 19765
		[global::Cpp2ILInjected.Token(Token = "0x4005F81")]
		public const short LadybugMinecart = 4427;

		// Token: 0x04004D36 RID: 19766
		[global::Cpp2ILInjected.Token(Token = "0x4005F82")]
		public const short PigronMinecart = 4428;

		// Token: 0x04004D37 RID: 19767
		[global::Cpp2ILInjected.Token(Token = "0x4005F83")]
		public const short SunflowerMinecart = 4429;

		// Token: 0x04004D38 RID: 19768
		[global::Cpp2ILInjected.Token(Token = "0x4005F84")]
		public const short PottedForestCedar = 4430;

		// Token: 0x04004D39 RID: 19769
		[global::Cpp2ILInjected.Token(Token = "0x4005F85")]
		public const short PottedJungleCedar = 4431;

		// Token: 0x04004D3A RID: 19770
		[global::Cpp2ILInjected.Token(Token = "0x4005F86")]
		public const short PottedHallowCedar = 4432;

		// Token: 0x04004D3B RID: 19771
		[global::Cpp2ILInjected.Token(Token = "0x4005F87")]
		public const short PottedForestTree = 4433;

		// Token: 0x04004D3C RID: 19772
		[global::Cpp2ILInjected.Token(Token = "0x4005F88")]
		public const short PottedJungleTree = 4434;

		// Token: 0x04004D3D RID: 19773
		[global::Cpp2ILInjected.Token(Token = "0x4005F89")]
		public const short PottedHallowTree = 4435;

		// Token: 0x04004D3E RID: 19774
		[global::Cpp2ILInjected.Token(Token = "0x4005F8A")]
		public const short PottedForestPalm = 4436;

		// Token: 0x04004D3F RID: 19775
		[global::Cpp2ILInjected.Token(Token = "0x4005F8B")]
		public const short PottedJunglePalm = 4437;

		// Token: 0x04004D40 RID: 19776
		[global::Cpp2ILInjected.Token(Token = "0x4005F8C")]
		public const short PottedHallowPalm = 4438;

		// Token: 0x04004D41 RID: 19777
		[global::Cpp2ILInjected.Token(Token = "0x4005F8D")]
		public const short PottedForestBamboo = 4439;

		// Token: 0x04004D42 RID: 19778
		[global::Cpp2ILInjected.Token(Token = "0x4005F8E")]
		public const short PottedJungleBamboo = 4440;

		// Token: 0x04004D43 RID: 19779
		[global::Cpp2ILInjected.Token(Token = "0x4005F8F")]
		public const short PottedHallowBamboo = 4441;

		// Token: 0x04004D44 RID: 19780
		[global::Cpp2ILInjected.Token(Token = "0x4005F90")]
		public const short ScarabFishingRod = 4442;

		// Token: 0x04004D45 RID: 19781
		[global::Cpp2ILInjected.Token(Token = "0x4005F91")]
		public const short HellMinecart = 4443;

		// Token: 0x04004D46 RID: 19782
		[global::Cpp2ILInjected.Token(Token = "0x4005F92")]
		public const short WitchBroom = 4444;

		// Token: 0x04004D47 RID: 19783
		[global::Cpp2ILInjected.Token(Token = "0x4005F93")]
		public const short ClusterRocketI = 4445;

		// Token: 0x04004D48 RID: 19784
		[global::Cpp2ILInjected.Token(Token = "0x4005F94")]
		public const short ClusterRocketII = 4446;

		// Token: 0x04004D49 RID: 19785
		[global::Cpp2ILInjected.Token(Token = "0x4005F95")]
		public const short WetRocket = 4447;

		// Token: 0x04004D4A RID: 19786
		[global::Cpp2ILInjected.Token(Token = "0x4005F96")]
		public const short LavaRocket = 4448;

		// Token: 0x04004D4B RID: 19787
		[global::Cpp2ILInjected.Token(Token = "0x4005F97")]
		public const short HoneyRocket = 4449;

		// Token: 0x04004D4C RID: 19788
		[global::Cpp2ILInjected.Token(Token = "0x4005F98")]
		public const short ShroomMinecart = 4450;

		// Token: 0x04004D4D RID: 19789
		[global::Cpp2ILInjected.Token(Token = "0x4005F99")]
		public const short AmethystMinecart = 4451;

		// Token: 0x04004D4E RID: 19790
		[global::Cpp2ILInjected.Token(Token = "0x4005F9A")]
		public const short TopazMinecart = 4452;

		// Token: 0x04004D4F RID: 19791
		[global::Cpp2ILInjected.Token(Token = "0x4005F9B")]
		public const short SapphireMinecart = 4453;

		// Token: 0x04004D50 RID: 19792
		[global::Cpp2ILInjected.Token(Token = "0x4005F9C")]
		public const short EmeraldMinecart = 4454;

		// Token: 0x04004D51 RID: 19793
		[global::Cpp2ILInjected.Token(Token = "0x4005F9D")]
		public const short RubyMinecart = 4455;

		// Token: 0x04004D52 RID: 19794
		[global::Cpp2ILInjected.Token(Token = "0x4005F9E")]
		public const short DiamondMinecart = 4456;

		// Token: 0x04004D53 RID: 19795
		[global::Cpp2ILInjected.Token(Token = "0x4005F9F")]
		public const short MiniNukeI = 4457;

		// Token: 0x04004D54 RID: 19796
		[global::Cpp2ILInjected.Token(Token = "0x4005FA0")]
		public const short MiniNukeII = 4458;

		// Token: 0x04004D55 RID: 19797
		[global::Cpp2ILInjected.Token(Token = "0x4005FA1")]
		public const short DryRocket = 4459;

		// Token: 0x04004D56 RID: 19798
		[global::Cpp2ILInjected.Token(Token = "0x4005FA2")]
		public const short SandcastleBucket = 4460;

		// Token: 0x04004D57 RID: 19799
		[global::Cpp2ILInjected.Token(Token = "0x4005FA3")]
		public const short TurtleCage = 4461;

		// Token: 0x04004D58 RID: 19800
		[global::Cpp2ILInjected.Token(Token = "0x4005FA4")]
		public const short TurtleJungleCage = 4462;

		// Token: 0x04004D59 RID: 19801
		[global::Cpp2ILInjected.Token(Token = "0x4005FA5")]
		public const short Gladius = 4463;

		// Token: 0x04004D5A RID: 19802
		[global::Cpp2ILInjected.Token(Token = "0x4005FA6")]
		public const short Turtle = 4464;

		// Token: 0x04004D5B RID: 19803
		[global::Cpp2ILInjected.Token(Token = "0x4005FA7")]
		public const short TurtleJungle = 4465;

		// Token: 0x04004D5C RID: 19804
		[global::Cpp2ILInjected.Token(Token = "0x4005FA8")]
		public const short TurtleStatue = 4466;

		// Token: 0x04004D5D RID: 19805
		[global::Cpp2ILInjected.Token(Token = "0x4005FA9")]
		public const short AmberMinecart = 4467;

		// Token: 0x04004D5E RID: 19806
		[global::Cpp2ILInjected.Token(Token = "0x4005FAA")]
		public const short BeetleMinecart = 4468;

		// Token: 0x04004D5F RID: 19807
		[global::Cpp2ILInjected.Token(Token = "0x4005FAB")]
		public const short MeowmereMinecart = 4469;

		// Token: 0x04004D60 RID: 19808
		[global::Cpp2ILInjected.Token(Token = "0x4005FAC")]
		public const short PartyMinecart = 4470;

		// Token: 0x04004D61 RID: 19809
		[global::Cpp2ILInjected.Token(Token = "0x4005FAD")]
		public const short PirateMinecart = 4471;

		// Token: 0x04004D62 RID: 19810
		[global::Cpp2ILInjected.Token(Token = "0x4005FAE")]
		public const short SteampunkMinecart = 4472;

		// Token: 0x04004D63 RID: 19811
		[global::Cpp2ILInjected.Token(Token = "0x4005FAF")]
		public const short GrebeCage = 4473;

		// Token: 0x04004D64 RID: 19812
		[global::Cpp2ILInjected.Token(Token = "0x4005FB0")]
		public const short SeagullCage = 4474;

		// Token: 0x04004D65 RID: 19813
		[global::Cpp2ILInjected.Token(Token = "0x4005FB1")]
		public const short WaterStriderCage = 4475;

		// Token: 0x04004D66 RID: 19814
		[global::Cpp2ILInjected.Token(Token = "0x4005FB2")]
		public const short GoldWaterStriderCage = 4476;

		// Token: 0x04004D67 RID: 19815
		[global::Cpp2ILInjected.Token(Token = "0x4005FB3")]
		public const short LuckPotionLesser = 4477;

		// Token: 0x04004D68 RID: 19816
		[global::Cpp2ILInjected.Token(Token = "0x4005FB4")]
		public const short LuckPotion = 4478;

		// Token: 0x04004D69 RID: 19817
		[global::Cpp2ILInjected.Token(Token = "0x4005FB5")]
		public const short LuckPotionGreater = 4479;

		// Token: 0x04004D6A RID: 19818
		[global::Cpp2ILInjected.Token(Token = "0x4005FB6")]
		public const short Seahorse = 4480;

		// Token: 0x04004D6B RID: 19819
		[global::Cpp2ILInjected.Token(Token = "0x4005FB7")]
		public const short SeahorseCage = 4481;

		// Token: 0x04004D6C RID: 19820
		[global::Cpp2ILInjected.Token(Token = "0x4005FB8")]
		public const short GoldSeahorse = 4482;

		// Token: 0x04004D6D RID: 19821
		[global::Cpp2ILInjected.Token(Token = "0x4005FB9")]
		public const short GoldSeahorseCage = 4483;

		// Token: 0x04004D6E RID: 19822
		[global::Cpp2ILInjected.Token(Token = "0x4005FBA")]
		public const short TimerOneHalfSecond = 4484;

		// Token: 0x04004D6F RID: 19823
		[global::Cpp2ILInjected.Token(Token = "0x4005FBB")]
		public const short TimerOneFourthSecond = 4485;

		// Token: 0x04004D70 RID: 19824
		[global::Cpp2ILInjected.Token(Token = "0x4005FBC")]
		public const short EbonstoneEcho = 4486;

		// Token: 0x04004D71 RID: 19825
		[global::Cpp2ILInjected.Token(Token = "0x4005FBD")]
		public const short MudWallEcho = 4487;

		// Token: 0x04004D72 RID: 19826
		[global::Cpp2ILInjected.Token(Token = "0x4005FBE")]
		public const short PearlstoneEcho = 4488;

		// Token: 0x04004D73 RID: 19827
		[global::Cpp2ILInjected.Token(Token = "0x4005FBF")]
		public const short SnowWallEcho = 4489;

		// Token: 0x04004D74 RID: 19828
		[global::Cpp2ILInjected.Token(Token = "0x4005FC0")]
		public const short AmethystEcho = 4490;

		// Token: 0x04004D75 RID: 19829
		[global::Cpp2ILInjected.Token(Token = "0x4005FC1")]
		public const short TopazEcho = 4491;

		// Token: 0x04004D76 RID: 19830
		[global::Cpp2ILInjected.Token(Token = "0x4005FC2")]
		public const short SapphireEcho = 4492;

		// Token: 0x04004D77 RID: 19831
		[global::Cpp2ILInjected.Token(Token = "0x4005FC3")]
		public const short EmeraldEcho = 4493;

		// Token: 0x04004D78 RID: 19832
		[global::Cpp2ILInjected.Token(Token = "0x4005FC4")]
		public const short RubyEcho = 4494;

		// Token: 0x04004D79 RID: 19833
		[global::Cpp2ILInjected.Token(Token = "0x4005FC5")]
		public const short DiamondEcho = 4495;

		// Token: 0x04004D7A RID: 19834
		[global::Cpp2ILInjected.Token(Token = "0x4005FC6")]
		public const short Cave1Echo = 4496;

		// Token: 0x04004D7B RID: 19835
		[global::Cpp2ILInjected.Token(Token = "0x4005FC7")]
		public const short Cave2Echo = 4497;

		// Token: 0x04004D7C RID: 19836
		[global::Cpp2ILInjected.Token(Token = "0x4005FC8")]
		public const short Cave3Echo = 4498;

		// Token: 0x04004D7D RID: 19837
		[global::Cpp2ILInjected.Token(Token = "0x4005FC9")]
		public const short Cave4Echo = 4499;

		// Token: 0x04004D7E RID: 19838
		[global::Cpp2ILInjected.Token(Token = "0x4005FCA")]
		public const short Cave5Echo = 4500;

		// Token: 0x04004D7F RID: 19839
		[global::Cpp2ILInjected.Token(Token = "0x4005FCB")]
		public const short Cave6Echo = 4501;

		// Token: 0x04004D80 RID: 19840
		[global::Cpp2ILInjected.Token(Token = "0x4005FCC")]
		public const short Cave7Echo = 4502;

		// Token: 0x04004D81 RID: 19841
		[global::Cpp2ILInjected.Token(Token = "0x4005FCD")]
		public const short SpiderEcho = 4503;

		// Token: 0x04004D82 RID: 19842
		[global::Cpp2ILInjected.Token(Token = "0x4005FCE")]
		public const short CorruptGrassEcho = 4504;

		// Token: 0x04004D83 RID: 19843
		[global::Cpp2ILInjected.Token(Token = "0x4005FCF")]
		public const short HallowedGrassEcho = 4505;

		// Token: 0x04004D84 RID: 19844
		[global::Cpp2ILInjected.Token(Token = "0x4005FD0")]
		public const short IceEcho = 4506;

		// Token: 0x04004D85 RID: 19845
		[global::Cpp2ILInjected.Token(Token = "0x4005FD1")]
		public const short ObsidianBackEcho = 4507;

		// Token: 0x04004D86 RID: 19846
		[global::Cpp2ILInjected.Token(Token = "0x4005FD2")]
		public const short CrimsonGrassEcho = 4508;

		// Token: 0x04004D87 RID: 19847
		[global::Cpp2ILInjected.Token(Token = "0x4005FD3")]
		public const short CrimstoneEcho = 4509;

		// Token: 0x04004D88 RID: 19848
		[global::Cpp2ILInjected.Token(Token = "0x4005FD4")]
		public const short CaveWall1Echo = 4510;

		// Token: 0x04004D89 RID: 19849
		[global::Cpp2ILInjected.Token(Token = "0x4005FD5")]
		public const short CaveWall2Echo = 4511;

		// Token: 0x04004D8A RID: 19850
		[global::Cpp2ILInjected.Token(Token = "0x4005FD6")]
		public const short Cave8Echo = 4512;

		// Token: 0x04004D8B RID: 19851
		[global::Cpp2ILInjected.Token(Token = "0x4005FD7")]
		public const short Corruption1Echo = 4513;

		// Token: 0x04004D8C RID: 19852
		[global::Cpp2ILInjected.Token(Token = "0x4005FD8")]
		public const short Corruption2Echo = 4514;

		// Token: 0x04004D8D RID: 19853
		[global::Cpp2ILInjected.Token(Token = "0x4005FD9")]
		public const short Corruption3Echo = 4515;

		// Token: 0x04004D8E RID: 19854
		[global::Cpp2ILInjected.Token(Token = "0x4005FDA")]
		public const short Corruption4Echo = 4516;

		// Token: 0x04004D8F RID: 19855
		[global::Cpp2ILInjected.Token(Token = "0x4005FDB")]
		public const short Crimson1Echo = 4517;

		// Token: 0x04004D90 RID: 19856
		[global::Cpp2ILInjected.Token(Token = "0x4005FDC")]
		public const short Crimson2Echo = 4518;

		// Token: 0x04004D91 RID: 19857
		[global::Cpp2ILInjected.Token(Token = "0x4005FDD")]
		public const short Crimson3Echo = 4519;

		// Token: 0x04004D92 RID: 19858
		[global::Cpp2ILInjected.Token(Token = "0x4005FDE")]
		public const short Crimson4Echo = 4520;

		// Token: 0x04004D93 RID: 19859
		[global::Cpp2ILInjected.Token(Token = "0x4005FDF")]
		public const short Dirt1Echo = 4521;

		// Token: 0x04004D94 RID: 19860
		[global::Cpp2ILInjected.Token(Token = "0x4005FE0")]
		public const short Dirt2Echo = 4522;

		// Token: 0x04004D95 RID: 19861
		[global::Cpp2ILInjected.Token(Token = "0x4005FE1")]
		public const short Dirt3Echo = 4523;

		// Token: 0x04004D96 RID: 19862
		[global::Cpp2ILInjected.Token(Token = "0x4005FE2")]
		public const short Dirt4Echo = 4524;

		// Token: 0x04004D97 RID: 19863
		[global::Cpp2ILInjected.Token(Token = "0x4005FE3")]
		public const short Hallow1Echo = 4525;

		// Token: 0x04004D98 RID: 19864
		[global::Cpp2ILInjected.Token(Token = "0x4005FE4")]
		public const short Hallow2Echo = 4526;

		// Token: 0x04004D99 RID: 19865
		[global::Cpp2ILInjected.Token(Token = "0x4005FE5")]
		public const short Hallow3Echo = 4527;

		// Token: 0x04004D9A RID: 19866
		[global::Cpp2ILInjected.Token(Token = "0x4005FE6")]
		public const short Hallow4Echo = 4528;

		// Token: 0x04004D9B RID: 19867
		[global::Cpp2ILInjected.Token(Token = "0x4005FE7")]
		public const short Jungle1Echo = 4529;

		// Token: 0x04004D9C RID: 19868
		[global::Cpp2ILInjected.Token(Token = "0x4005FE8")]
		public const short Jungle2Echo = 4530;

		// Token: 0x04004D9D RID: 19869
		[global::Cpp2ILInjected.Token(Token = "0x4005FE9")]
		public const short Jungle3Echo = 4531;

		// Token: 0x04004D9E RID: 19870
		[global::Cpp2ILInjected.Token(Token = "0x4005FEA")]
		public const short Jungle4Echo = 4532;

		// Token: 0x04004D9F RID: 19871
		[global::Cpp2ILInjected.Token(Token = "0x4005FEB")]
		public const short Lava1Echo = 4533;

		// Token: 0x04004DA0 RID: 19872
		[global::Cpp2ILInjected.Token(Token = "0x4005FEC")]
		public const short Lava2Echo = 4534;

		// Token: 0x04004DA1 RID: 19873
		[global::Cpp2ILInjected.Token(Token = "0x4005FED")]
		public const short Lava3Echo = 4535;

		// Token: 0x04004DA2 RID: 19874
		[global::Cpp2ILInjected.Token(Token = "0x4005FEE")]
		public const short Lava4Echo = 4536;

		// Token: 0x04004DA3 RID: 19875
		[global::Cpp2ILInjected.Token(Token = "0x4005FEF")]
		public const short Rocks1Echo = 4537;

		// Token: 0x04004DA4 RID: 19876
		[global::Cpp2ILInjected.Token(Token = "0x4005FF0")]
		public const short Rocks2Echo = 4538;

		// Token: 0x04004DA5 RID: 19877
		[global::Cpp2ILInjected.Token(Token = "0x4005FF1")]
		public const short Rocks3Echo = 4539;

		// Token: 0x04004DA6 RID: 19878
		[global::Cpp2ILInjected.Token(Token = "0x4005FF2")]
		public const short Rocks4Echo = 4540;

		// Token: 0x04004DA7 RID: 19879
		[global::Cpp2ILInjected.Token(Token = "0x4005FF3")]
		public const short TheBrideBanner = 4541;

		// Token: 0x04004DA8 RID: 19880
		[global::Cpp2ILInjected.Token(Token = "0x4005FF4")]
		public const short ZombieMermanBanner = 4542;

		// Token: 0x04004DA9 RID: 19881
		[global::Cpp2ILInjected.Token(Token = "0x4005FF5")]
		public const short EyeballFlyingFishBanner = 4543;

		// Token: 0x04004DAA RID: 19882
		[global::Cpp2ILInjected.Token(Token = "0x4005FF6")]
		public const short BloodSquidBanner = 4544;

		// Token: 0x04004DAB RID: 19883
		[global::Cpp2ILInjected.Token(Token = "0x4005FF7")]
		public const short BloodEelBanner = 4545;

		// Token: 0x04004DAC RID: 19884
		[global::Cpp2ILInjected.Token(Token = "0x4005FF8")]
		public const short GoblinSharkBanner = 4546;

		// Token: 0x04004DAD RID: 19885
		[global::Cpp2ILInjected.Token(Token = "0x4005FF9")]
		public const short LargeBambooBlock = 4547;

		// Token: 0x04004DAE RID: 19886
		[global::Cpp2ILInjected.Token(Token = "0x4005FFA")]
		public const short LargeBambooBlockWall = 4548;

		// Token: 0x04004DAF RID: 19887
		[global::Cpp2ILInjected.Token(Token = "0x4005FFB")]
		public const short DemonHorns = 4549;

		// Token: 0x04004DB0 RID: 19888
		[global::Cpp2ILInjected.Token(Token = "0x4005FFC")]
		public const short BambooLeaf = 4550;

		// Token: 0x04004DB1 RID: 19889
		[global::Cpp2ILInjected.Token(Token = "0x4005FFD")]
		public const short HellCake = 4551;

		// Token: 0x04004DB2 RID: 19890
		[global::Cpp2ILInjected.Token(Token = "0x4005FFE")]
		public const short FogMachine = 4552;

		// Token: 0x04004DB3 RID: 19891
		[global::Cpp2ILInjected.Token(Token = "0x4005FFF")]
		public const short PlasmaLamp = 4553;

		// Token: 0x04004DB4 RID: 19892
		[global::Cpp2ILInjected.Token(Token = "0x4006000")]
		public const short MarbleColumn = 4554;

		// Token: 0x04004DB5 RID: 19893
		[global::Cpp2ILInjected.Token(Token = "0x4006001")]
		public const short ChefHat = 4555;

		// Token: 0x04004DB6 RID: 19894
		[global::Cpp2ILInjected.Token(Token = "0x4006002")]
		public const short ChefShirt = 4556;

		// Token: 0x04004DB7 RID: 19895
		[global::Cpp2ILInjected.Token(Token = "0x4006003")]
		public const short ChefPants = 4557;

		// Token: 0x04004DB8 RID: 19896
		[global::Cpp2ILInjected.Token(Token = "0x4006004")]
		public const short StarHairpin = 4558;

		// Token: 0x04004DB9 RID: 19897
		[global::Cpp2ILInjected.Token(Token = "0x4006005")]
		public const short HeartHairpin = 4559;

		// Token: 0x04004DBA RID: 19898
		[global::Cpp2ILInjected.Token(Token = "0x4006006")]
		public const short BunnyEars = 4560;

		// Token: 0x04004DBB RID: 19899
		[global::Cpp2ILInjected.Token(Token = "0x4006007")]
		public const short DevilHorns = 4561;

		// Token: 0x04004DBC RID: 19900
		[global::Cpp2ILInjected.Token(Token = "0x4006008")]
		public const short Fedora = 4562;

		// Token: 0x04004DBD RID: 19901
		[global::Cpp2ILInjected.Token(Token = "0x4006009")]
		public const short UnicornHornHat = 4563;

		// Token: 0x04004DBE RID: 19902
		[global::Cpp2ILInjected.Token(Token = "0x400600A")]
		public const short BambooBlock = 4564;

		// Token: 0x04004DBF RID: 19903
		[global::Cpp2ILInjected.Token(Token = "0x400600B")]
		public const short BambooBlockWall = 4565;

		// Token: 0x04004DC0 RID: 19904
		[global::Cpp2ILInjected.Token(Token = "0x400600C")]
		public const short BambooBathtub = 4566;

		// Token: 0x04004DC1 RID: 19905
		[global::Cpp2ILInjected.Token(Token = "0x400600D")]
		public const short BambooBed = 4567;

		// Token: 0x04004DC2 RID: 19906
		[global::Cpp2ILInjected.Token(Token = "0x400600E")]
		public const short BambooBookcase = 4568;

		// Token: 0x04004DC3 RID: 19907
		[global::Cpp2ILInjected.Token(Token = "0x400600F")]
		public const short BambooDresser = 4569;

		// Token: 0x04004DC4 RID: 19908
		[global::Cpp2ILInjected.Token(Token = "0x4006010")]
		public const short BambooCandelabra = 4570;

		// Token: 0x04004DC5 RID: 19909
		[global::Cpp2ILInjected.Token(Token = "0x4006011")]
		public const short BambooCandle = 4571;

		// Token: 0x04004DC6 RID: 19910
		[global::Cpp2ILInjected.Token(Token = "0x4006012")]
		public const short BambooChair = 4572;

		// Token: 0x04004DC7 RID: 19911
		[global::Cpp2ILInjected.Token(Token = "0x4006013")]
		public const short BambooChandelier = 4573;

		// Token: 0x04004DC8 RID: 19912
		[global::Cpp2ILInjected.Token(Token = "0x4006014")]
		public const short BambooChest = 4574;

		// Token: 0x04004DC9 RID: 19913
		[global::Cpp2ILInjected.Token(Token = "0x4006015")]
		public const short BambooClock = 4575;

		// Token: 0x04004DCA RID: 19914
		[global::Cpp2ILInjected.Token(Token = "0x4006016")]
		public const short BambooDoor = 4576;

		// Token: 0x04004DCB RID: 19915
		[global::Cpp2ILInjected.Token(Token = "0x4006017")]
		public const short BambooLamp = 4577;

		// Token: 0x04004DCC RID: 19916
		[global::Cpp2ILInjected.Token(Token = "0x4006018")]
		public const short BambooLantern = 4578;

		// Token: 0x04004DCD RID: 19917
		[global::Cpp2ILInjected.Token(Token = "0x4006019")]
		public const short BambooPiano = 4579;

		// Token: 0x04004DCE RID: 19918
		[global::Cpp2ILInjected.Token(Token = "0x400601A")]
		public const short BambooPlatform = 4580;

		// Token: 0x04004DCF RID: 19919
		[global::Cpp2ILInjected.Token(Token = "0x400601B")]
		public const short BambooSink = 4581;

		// Token: 0x04004DD0 RID: 19920
		[global::Cpp2ILInjected.Token(Token = "0x400601C")]
		public const short BambooSofa = 4582;

		// Token: 0x04004DD1 RID: 19921
		[global::Cpp2ILInjected.Token(Token = "0x400601D")]
		public const short BambooTable = 4583;

		// Token: 0x04004DD2 RID: 19922
		[global::Cpp2ILInjected.Token(Token = "0x400601E")]
		public const short BambooWorkbench = 4584;

		// Token: 0x04004DD3 RID: 19923
		[global::Cpp2ILInjected.Token(Token = "0x400601F")]
		public const short Fake_BambooChest = 4585;

		// Token: 0x04004DD4 RID: 19924
		[global::Cpp2ILInjected.Token(Token = "0x4006020")]
		public const short BambooToilet = 4586;

		// Token: 0x04004DD5 RID: 19925
		[global::Cpp2ILInjected.Token(Token = "0x4006021")]
		public const short GolfClubStoneIron = 4587;

		// Token: 0x04004DD6 RID: 19926
		[global::Cpp2ILInjected.Token(Token = "0x4006022")]
		public const short GolfClubRustyPutter = 4588;

		// Token: 0x04004DD7 RID: 19927
		[global::Cpp2ILInjected.Token(Token = "0x4006023")]
		public const short GolfClubBronzeWedge = 4589;

		// Token: 0x04004DD8 RID: 19928
		[global::Cpp2ILInjected.Token(Token = "0x4006024")]
		public const short GolfClubWoodDriver = 4590;

		// Token: 0x04004DD9 RID: 19929
		[global::Cpp2ILInjected.Token(Token = "0x4006025")]
		public const short GolfClubMythrilIron = 4591;

		// Token: 0x04004DDA RID: 19930
		[global::Cpp2ILInjected.Token(Token = "0x4006026")]
		public const short GolfClubLeadPutter = 4592;

		// Token: 0x04004DDB RID: 19931
		[global::Cpp2ILInjected.Token(Token = "0x4006027")]
		public const short GolfClubGoldWedge = 4593;

		// Token: 0x04004DDC RID: 19932
		[global::Cpp2ILInjected.Token(Token = "0x4006028")]
		public const short GolfClubPearlwoodDriver = 4594;

		// Token: 0x04004DDD RID: 19933
		[global::Cpp2ILInjected.Token(Token = "0x4006029")]
		public const short GolfClubTitaniumIron = 4595;

		// Token: 0x04004DDE RID: 19934
		[global::Cpp2ILInjected.Token(Token = "0x400602A")]
		public const short GolfClubShroomitePutter = 4596;

		// Token: 0x04004DDF RID: 19935
		[global::Cpp2ILInjected.Token(Token = "0x400602B")]
		public const short GolfClubDiamondWedge = 4597;

		// Token: 0x04004DE0 RID: 19936
		[global::Cpp2ILInjected.Token(Token = "0x400602C")]
		public const short GolfClubChlorophyteDriver = 4598;

		// Token: 0x04004DE1 RID: 19937
		[global::Cpp2ILInjected.Token(Token = "0x400602D")]
		public const short GolfTrophyBronze = 4599;

		// Token: 0x04004DE2 RID: 19938
		[global::Cpp2ILInjected.Token(Token = "0x400602E")]
		public const short GolfTrophySilver = 4600;

		// Token: 0x04004DE3 RID: 19939
		[global::Cpp2ILInjected.Token(Token = "0x400602F")]
		public const short GolfTrophyGold = 4601;

		// Token: 0x04004DE4 RID: 19940
		[global::Cpp2ILInjected.Token(Token = "0x4006030")]
		public const short BloodNautilusBanner = 4602;

		// Token: 0x04004DE5 RID: 19941
		[global::Cpp2ILInjected.Token(Token = "0x4006031")]
		public const short BirdieRattle = 4603;

		// Token: 0x04004DE6 RID: 19942
		[global::Cpp2ILInjected.Token(Token = "0x4006032")]
		public const short ExoticEasternChewToy = 4604;

		// Token: 0x04004DE7 RID: 19943
		[global::Cpp2ILInjected.Token(Token = "0x4006033")]
		public const short BedazzledNectar = 4605;

		// Token: 0x04004DE8 RID: 19944
		[global::Cpp2ILInjected.Token(Token = "0x4006034")]
		public const short MusicBoxJungleNight = 4606;

		// Token: 0x04004DE9 RID: 19945
		[global::Cpp2ILInjected.Token(Token = "0x4006035")]
		public const short StormTigerStaff = 4607;

		// Token: 0x04004DEA RID: 19946
		[global::Cpp2ILInjected.Token(Token = "0x4006036")]
		public const short ChumBucket = 4608;

		// Token: 0x04004DEB RID: 19947
		[global::Cpp2ILInjected.Token(Token = "0x4006037")]
		public const short GardenGnome = 4609;

		// Token: 0x04004DEC RID: 19948
		[global::Cpp2ILInjected.Token(Token = "0x4006038")]
		public const short KiteBoneSerpent = 4610;

		// Token: 0x04004DED RID: 19949
		[global::Cpp2ILInjected.Token(Token = "0x4006039")]
		public const short KiteWorldFeeder = 4611;

		// Token: 0x04004DEE RID: 19950
		[global::Cpp2ILInjected.Token(Token = "0x400603A")]
		public const short KiteBunny = 4612;

		// Token: 0x04004DEF RID: 19951
		[global::Cpp2ILInjected.Token(Token = "0x400603B")]
		public const short KitePigron = 4613;

		// Token: 0x04004DF0 RID: 19952
		[global::Cpp2ILInjected.Token(Token = "0x400603C")]
		public const short AppleJuice = 4614;

		// Token: 0x04004DF1 RID: 19953
		[global::Cpp2ILInjected.Token(Token = "0x400603D")]
		public const short GrapeJuice = 4615;

		// Token: 0x04004DF2 RID: 19954
		[global::Cpp2ILInjected.Token(Token = "0x400603E")]
		public const short Lemonade = 4616;

		// Token: 0x04004DF3 RID: 19955
		[global::Cpp2ILInjected.Token(Token = "0x400603F")]
		public const short BananaDaiquiri = 4617;

		// Token: 0x04004DF4 RID: 19956
		[global::Cpp2ILInjected.Token(Token = "0x4006040")]
		public const short PeachSangria = 4618;

		// Token: 0x04004DF5 RID: 19957
		[global::Cpp2ILInjected.Token(Token = "0x4006041")]
		public const short PinaColada = 4619;

		// Token: 0x04004DF6 RID: 19958
		[global::Cpp2ILInjected.Token(Token = "0x4006042")]
		public const short TropicalSmoothie = 4620;

		// Token: 0x04004DF7 RID: 19959
		[global::Cpp2ILInjected.Token(Token = "0x4006043")]
		public const short BloodyMoscato = 4621;

		// Token: 0x04004DF8 RID: 19960
		[global::Cpp2ILInjected.Token(Token = "0x4006044")]
		public const short SmoothieofDarkness = 4622;

		// Token: 0x04004DF9 RID: 19961
		[global::Cpp2ILInjected.Token(Token = "0x4006045")]
		public const short PrismaticPunch = 4623;

		// Token: 0x04004DFA RID: 19962
		[global::Cpp2ILInjected.Token(Token = "0x4006046")]
		public const short FruitJuice = 4624;

		// Token: 0x04004DFB RID: 19963
		[global::Cpp2ILInjected.Token(Token = "0x4006047")]
		public const short FruitSalad = 4625;

		// Token: 0x04004DFC RID: 19964
		[global::Cpp2ILInjected.Token(Token = "0x4006048")]
		public const short AndrewSphinx = 4626;

		// Token: 0x04004DFD RID: 19965
		[global::Cpp2ILInjected.Token(Token = "0x4006049")]
		public const short WatchfulAntlion = 4627;

		// Token: 0x04004DFE RID: 19966
		[global::Cpp2ILInjected.Token(Token = "0x400604A")]
		public const short BurningSpirit = 4628;

		// Token: 0x04004DFF RID: 19967
		[global::Cpp2ILInjected.Token(Token = "0x400604B")]
		public const short JawsOfDeath = 4629;

		// Token: 0x04004E00 RID: 19968
		[global::Cpp2ILInjected.Token(Token = "0x400604C")]
		public const short TheSandsOfSlime = 4630;

		// Token: 0x04004E01 RID: 19969
		[global::Cpp2ILInjected.Token(Token = "0x400604D")]
		public const short SnakesIHateSnakes = 4631;

		// Token: 0x04004E02 RID: 19970
		[global::Cpp2ILInjected.Token(Token = "0x400604E")]
		public const short LifeAboveTheSand = 4632;

		// Token: 0x04004E03 RID: 19971
		[global::Cpp2ILInjected.Token(Token = "0x400604F")]
		public const short Oasis = 4633;

		// Token: 0x04004E04 RID: 19972
		[global::Cpp2ILInjected.Token(Token = "0x4006050")]
		public const short PrehistoryPreserved = 4634;

		// Token: 0x04004E05 RID: 19973
		[global::Cpp2ILInjected.Token(Token = "0x4006051")]
		public const short AncientTablet = 4635;

		// Token: 0x04004E06 RID: 19974
		[global::Cpp2ILInjected.Token(Token = "0x4006052")]
		public const short Uluru = 4636;

		// Token: 0x04004E07 RID: 19975
		[global::Cpp2ILInjected.Token(Token = "0x4006053")]
		public const short VisitingThePyramids = 4637;

		// Token: 0x04004E08 RID: 19976
		[global::Cpp2ILInjected.Token(Token = "0x4006054")]
		public const short BandageBoy = 4638;

		// Token: 0x04004E09 RID: 19977
		[global::Cpp2ILInjected.Token(Token = "0x4006055")]
		public const short DivineEye = 4639;

		// Token: 0x04004E0A RID: 19978
		[global::Cpp2ILInjected.Token(Token = "0x4006056")]
		public const short AmethystStoneBlock = 4640;

		// Token: 0x04004E0B RID: 19979
		[global::Cpp2ILInjected.Token(Token = "0x4006057")]
		public const short TopazStoneBlock = 4641;

		// Token: 0x04004E0C RID: 19980
		[global::Cpp2ILInjected.Token(Token = "0x4006058")]
		public const short SapphireStoneBlock = 4642;

		// Token: 0x04004E0D RID: 19981
		[global::Cpp2ILInjected.Token(Token = "0x4006059")]
		public const short EmeraldStoneBlock = 4643;

		// Token: 0x04004E0E RID: 19982
		[global::Cpp2ILInjected.Token(Token = "0x400605A")]
		public const short RubyStoneBlock = 4644;

		// Token: 0x04004E0F RID: 19983
		[global::Cpp2ILInjected.Token(Token = "0x400605B")]
		public const short DiamondStoneBlock = 4645;

		// Token: 0x04004E10 RID: 19984
		[global::Cpp2ILInjected.Token(Token = "0x400605C")]
		public const short AmberStoneBlock = 4646;

		// Token: 0x04004E11 RID: 19985
		[global::Cpp2ILInjected.Token(Token = "0x400605D")]
		public const short AmberStoneWallEcho = 4647;

		// Token: 0x04004E12 RID: 19986
		[global::Cpp2ILInjected.Token(Token = "0x400605E")]
		public const short KiteManEater = 4648;

		// Token: 0x04004E13 RID: 19987
		[global::Cpp2ILInjected.Token(Token = "0x400605F")]
		public const short KiteJellyfishBlue = 4649;

		// Token: 0x04004E14 RID: 19988
		[global::Cpp2ILInjected.Token(Token = "0x4006060")]
		public const short KiteJellyfishPink = 4650;

		// Token: 0x04004E15 RID: 19989
		[global::Cpp2ILInjected.Token(Token = "0x4006061")]
		public const short KiteShark = 4651;

		// Token: 0x04004E16 RID: 19990
		[global::Cpp2ILInjected.Token(Token = "0x4006062")]
		public const short SuperHeroMask = 4652;

		// Token: 0x04004E17 RID: 19991
		[global::Cpp2ILInjected.Token(Token = "0x4006063")]
		public const short SuperHeroCostume = 4653;

		// Token: 0x04004E18 RID: 19992
		[global::Cpp2ILInjected.Token(Token = "0x4006064")]
		public const short SuperHeroTights = 4654;

		// Token: 0x04004E19 RID: 19993
		[global::Cpp2ILInjected.Token(Token = "0x4006065")]
		public const short PinkFairyJar = 4655;

		// Token: 0x04004E1A RID: 19994
		[global::Cpp2ILInjected.Token(Token = "0x4006066")]
		public const short GreenFairyJar = 4656;

		// Token: 0x04004E1B RID: 19995
		[global::Cpp2ILInjected.Token(Token = "0x4006067")]
		public const short BlueFairyJar = 4657;

		// Token: 0x04004E1C RID: 19996
		[global::Cpp2ILInjected.Token(Token = "0x4006068")]
		public const short GolfPainting1 = 4658;

		// Token: 0x04004E1D RID: 19997
		[global::Cpp2ILInjected.Token(Token = "0x4006069")]
		public const short GolfPainting2 = 4659;

		// Token: 0x04004E1E RID: 19998
		[global::Cpp2ILInjected.Token(Token = "0x400606A")]
		public const short GolfPainting3 = 4660;

		// Token: 0x04004E1F RID: 19999
		[global::Cpp2ILInjected.Token(Token = "0x400606B")]
		public const short GolfPainting4 = 4661;

		// Token: 0x04004E20 RID: 20000
		[global::Cpp2ILInjected.Token(Token = "0x400606C")]
		public const short FogboundDye = 4662;

		// Token: 0x04004E21 RID: 20001
		[global::Cpp2ILInjected.Token(Token = "0x400606D")]
		public const short BloodbathDye = 4663;

		// Token: 0x04004E22 RID: 20002
		[global::Cpp2ILInjected.Token(Token = "0x400606E")]
		public const short PrettyPinkDressSkirt = 4664;

		// Token: 0x04004E23 RID: 20003
		[global::Cpp2ILInjected.Token(Token = "0x400606F")]
		public const short PrettyPinkDressPants = 4665;

		// Token: 0x04004E24 RID: 20004
		[global::Cpp2ILInjected.Token(Token = "0x4006070")]
		public const short PrettyPinkRibbon = 4666;

		// Token: 0x04004E25 RID: 20005
		[global::Cpp2ILInjected.Token(Token = "0x4006071")]
		public const short BambooFence = 4667;

		// Token: 0x04004E26 RID: 20006
		[global::Cpp2ILInjected.Token(Token = "0x4006072")]
		public const short GlowPaint = 4668;

		// Token: 0x04004E27 RID: 20007
		[global::Cpp2ILInjected.Token(Token = "0x4006073")]
		public const short KiteSandShark = 4669;

		// Token: 0x04004E28 RID: 20008
		[global::Cpp2ILInjected.Token(Token = "0x4006074")]
		public const short KiteBunnyCorrupt = 4670;

		// Token: 0x04004E29 RID: 20009
		[global::Cpp2ILInjected.Token(Token = "0x4006075")]
		public const short KiteBunnyCrimson = 4671;

		// Token: 0x04004E2A RID: 20010
		[global::Cpp2ILInjected.Token(Token = "0x4006076")]
		public const short BlandWhip = 4672;

		// Token: 0x04004E2B RID: 20011
		[global::Cpp2ILInjected.Token(Token = "0x4006077")]
		public const short DrumStick = 4673;

		// Token: 0x04004E2C RID: 20012
		[global::Cpp2ILInjected.Token(Token = "0x4006078")]
		public const short KiteGoldfish = 4674;

		// Token: 0x04004E2D RID: 20013
		[global::Cpp2ILInjected.Token(Token = "0x4006079")]
		public const short KiteAngryTrapper = 4675;

		// Token: 0x04004E2E RID: 20014
		[global::Cpp2ILInjected.Token(Token = "0x400607A")]
		public const short KiteKoi = 4676;

		// Token: 0x04004E2F RID: 20015
		[global::Cpp2ILInjected.Token(Token = "0x400607B")]
		public const short KiteCrawltipede = 4677;

		// Token: 0x04004E30 RID: 20016
		[global::Cpp2ILInjected.Token(Token = "0x400607C")]
		public const short SwordWhip = 4678;

		// Token: 0x04004E31 RID: 20017
		[global::Cpp2ILInjected.Token(Token = "0x400607D")]
		public const short MaceWhip = 4679;

		// Token: 0x04004E32 RID: 20018
		[global::Cpp2ILInjected.Token(Token = "0x400607E")]
		public const short ScytheWhip = 4680;

		// Token: 0x04004E33 RID: 20019
		[global::Cpp2ILInjected.Token(Token = "0x400607F")]
		public const short KiteSpectrum = 4681;

		// Token: 0x04004E34 RID: 20020
		[global::Cpp2ILInjected.Token(Token = "0x4006080")]
		public const short ReleaseDoves = 4682;

		// Token: 0x04004E35 RID: 20021
		[global::Cpp2ILInjected.Token(Token = "0x4006081")]
		public const short KiteWanderingEye = 4683;

		// Token: 0x04004E36 RID: 20022
		[global::Cpp2ILInjected.Token(Token = "0x4006082")]
		public const short KiteUnicorn = 4684;

		// Token: 0x04004E37 RID: 20023
		[global::Cpp2ILInjected.Token(Token = "0x4006083")]
		public const short UndertakerHat = 4685;

		// Token: 0x04004E38 RID: 20024
		[global::Cpp2ILInjected.Token(Token = "0x4006084")]
		public const short UndertakerCoat = 4686;

		// Token: 0x04004E39 RID: 20025
		[global::Cpp2ILInjected.Token(Token = "0x4006085")]
		public const short DandelionBanner = 4687;

		// Token: 0x04004E3A RID: 20026
		[global::Cpp2ILInjected.Token(Token = "0x4006086")]
		public const short GnomeBanner = 4688;

		// Token: 0x04004E3B RID: 20027
		[global::Cpp2ILInjected.Token(Token = "0x4006087")]
		public const short DesertCampfire = 4689;

		// Token: 0x04004E3C RID: 20028
		[global::Cpp2ILInjected.Token(Token = "0x4006088")]
		public const short CoralCampfire = 4690;

		// Token: 0x04004E3D RID: 20029
		[global::Cpp2ILInjected.Token(Token = "0x4006089")]
		public const short CorruptCampfire = 4691;

		// Token: 0x04004E3E RID: 20030
		[global::Cpp2ILInjected.Token(Token = "0x400608A")]
		public const short CrimsonCampfire = 4692;

		// Token: 0x04004E3F RID: 20031
		[global::Cpp2ILInjected.Token(Token = "0x400608B")]
		public const short HallowedCampfire = 4693;

		// Token: 0x04004E40 RID: 20032
		[global::Cpp2ILInjected.Token(Token = "0x400608C")]
		public const short JungleCampfire = 4694;

		// Token: 0x04004E41 RID: 20033
		[global::Cpp2ILInjected.Token(Token = "0x400608D")]
		public const short SoulBottleLight = 4695;

		// Token: 0x04004E42 RID: 20034
		[global::Cpp2ILInjected.Token(Token = "0x400608E")]
		public const short SoulBottleNight = 4696;

		// Token: 0x04004E43 RID: 20035
		[global::Cpp2ILInjected.Token(Token = "0x400608F")]
		public const short SoulBottleFlight = 4697;

		// Token: 0x04004E44 RID: 20036
		[global::Cpp2ILInjected.Token(Token = "0x4006090")]
		public const short SoulBottleSight = 4698;

		// Token: 0x04004E45 RID: 20037
		[global::Cpp2ILInjected.Token(Token = "0x4006091")]
		public const short SoulBottleMight = 4699;

		// Token: 0x04004E46 RID: 20038
		[global::Cpp2ILInjected.Token(Token = "0x4006092")]
		public const short SoulBottleFright = 4700;

		// Token: 0x04004E47 RID: 20039
		[global::Cpp2ILInjected.Token(Token = "0x4006093")]
		public const short MudBud = 4701;

		// Token: 0x04004E48 RID: 20040
		[global::Cpp2ILInjected.Token(Token = "0x4006094")]
		public const short ReleaseLantern = 4702;

		// Token: 0x04004E49 RID: 20041
		[global::Cpp2ILInjected.Token(Token = "0x4006095")]
		public const short QuadBarrelShotgun = 4703;

		// Token: 0x04004E4A RID: 20042
		[global::Cpp2ILInjected.Token(Token = "0x4006096")]
		public const short FuneralHat = 4704;

		// Token: 0x04004E4B RID: 20043
		[global::Cpp2ILInjected.Token(Token = "0x4006097")]
		public const short FuneralCoat = 4705;

		// Token: 0x04004E4C RID: 20044
		[global::Cpp2ILInjected.Token(Token = "0x4006098")]
		public const short FuneralPants = 4706;

		// Token: 0x04004E4D RID: 20045
		[global::Cpp2ILInjected.Token(Token = "0x4006099")]
		public const short TragicUmbrella = 4707;

		// Token: 0x04004E4E RID: 20046
		[global::Cpp2ILInjected.Token(Token = "0x400609A")]
		public const short VictorianGothHat = 4708;

		// Token: 0x04004E4F RID: 20047
		[global::Cpp2ILInjected.Token(Token = "0x400609B")]
		public const short VictorianGothDress = 4709;

		// Token: 0x04004E50 RID: 20048
		[global::Cpp2ILInjected.Token(Token = "0x400609C")]
		public const short TatteredWoodSign = 4710;

		// Token: 0x04004E51 RID: 20049
		[global::Cpp2ILInjected.Token(Token = "0x400609D")]
		public const short GravediggerShovel = 4711;

		// Token: 0x04004E52 RID: 20050
		[global::Cpp2ILInjected.Token(Token = "0x400609E")]
		public const short DungeonDesertChest = 4712;

		// Token: 0x04004E53 RID: 20051
		[global::Cpp2ILInjected.Token(Token = "0x400609F")]
		public const short Fake_DungeonDesertChest = 4713;

		// Token: 0x04004E54 RID: 20052
		[global::Cpp2ILInjected.Token(Token = "0x40060A0")]
		public const short DungeonDesertKey = 4714;

		// Token: 0x04004E55 RID: 20053
		[global::Cpp2ILInjected.Token(Token = "0x40060A1")]
		public const short SparkleGuitar = 4715;

		// Token: 0x04004E56 RID: 20054
		[global::Cpp2ILInjected.Token(Token = "0x40060A2")]
		public const short MolluskWhistle = 4716;

		// Token: 0x04004E57 RID: 20055
		[global::Cpp2ILInjected.Token(Token = "0x40060A3")]
		public const short BorealBeam = 4717;

		// Token: 0x04004E58 RID: 20056
		[global::Cpp2ILInjected.Token(Token = "0x40060A4")]
		public const short RichMahoganyBeam = 4718;

		// Token: 0x04004E59 RID: 20057
		[global::Cpp2ILInjected.Token(Token = "0x40060A5")]
		public const short GraniteColumn = 4719;

		// Token: 0x04004E5A RID: 20058
		[global::Cpp2ILInjected.Token(Token = "0x40060A6")]
		public const short SandstoneColumn = 4720;

		// Token: 0x04004E5B RID: 20059
		[global::Cpp2ILInjected.Token(Token = "0x40060A7")]
		public const short MushroomBeam = 4721;

		// Token: 0x04004E5C RID: 20060
		[global::Cpp2ILInjected.Token(Token = "0x40060A8")]
		public const short FirstFractal = 4722;

		// Token: 0x04004E5D RID: 20061
		[global::Cpp2ILInjected.Token(Token = "0x40060A9")]
		public const short Nevermore = 4723;

		// Token: 0x04004E5E RID: 20062
		[global::Cpp2ILInjected.Token(Token = "0x40060AA")]
		public const short Reborn = 4724;

		// Token: 0x04004E5F RID: 20063
		[global::Cpp2ILInjected.Token(Token = "0x40060AB")]
		public const short Graveyard = 4725;

		// Token: 0x04004E60 RID: 20064
		[global::Cpp2ILInjected.Token(Token = "0x40060AC")]
		public const short GhostManifestation = 4726;

		// Token: 0x04004E61 RID: 20065
		[global::Cpp2ILInjected.Token(Token = "0x40060AD")]
		public const short WickedUndead = 4727;

		// Token: 0x04004E62 RID: 20066
		[global::Cpp2ILInjected.Token(Token = "0x40060AE")]
		public const short BloodyGoblet = 4728;

		// Token: 0x04004E63 RID: 20067
		[global::Cpp2ILInjected.Token(Token = "0x40060AF")]
		public const short StillLife = 4729;

		// Token: 0x04004E64 RID: 20068
		[global::Cpp2ILInjected.Token(Token = "0x40060B0")]
		public const short GhostarsWings = 4730;

		// Token: 0x04004E65 RID: 20069
		[global::Cpp2ILInjected.Token(Token = "0x40060B1")]
		public const short TerraToilet = 4731;

		// Token: 0x04004E66 RID: 20070
		[global::Cpp2ILInjected.Token(Token = "0x40060B2")]
		public const short GhostarSkullPin = 4732;

		// Token: 0x04004E67 RID: 20071
		[global::Cpp2ILInjected.Token(Token = "0x40060B3")]
		public const short GhostarShirt = 4733;

		// Token: 0x04004E68 RID: 20072
		[global::Cpp2ILInjected.Token(Token = "0x40060B4")]
		public const short GhostarPants = 4734;

		// Token: 0x04004E69 RID: 20073
		[global::Cpp2ILInjected.Token(Token = "0x40060B5")]
		public const short BallOfFuseWire = 4735;

		// Token: 0x04004E6A RID: 20074
		[global::Cpp2ILInjected.Token(Token = "0x40060B6")]
		public const short FullMoonSqueakyToy = 4736;

		// Token: 0x04004E6B RID: 20075
		[global::Cpp2ILInjected.Token(Token = "0x40060B7")]
		public const short OrnateShadowKey = 4737;

		// Token: 0x04004E6C RID: 20076
		[global::Cpp2ILInjected.Token(Token = "0x40060B8")]
		public const short DrManFlyMask = 4738;

		// Token: 0x04004E6D RID: 20077
		[global::Cpp2ILInjected.Token(Token = "0x40060B9")]
		public const short DrManFlyLabCoat = 4739;

		// Token: 0x04004E6E RID: 20078
		[global::Cpp2ILInjected.Token(Token = "0x40060BA")]
		public const short ButcherMask = 4740;

		// Token: 0x04004E6F RID: 20079
		[global::Cpp2ILInjected.Token(Token = "0x40060BB")]
		public const short ButcherApron = 4741;

		// Token: 0x04004E70 RID: 20080
		[global::Cpp2ILInjected.Token(Token = "0x40060BC")]
		public const short ButcherPants = 4742;

		// Token: 0x04004E71 RID: 20081
		[global::Cpp2ILInjected.Token(Token = "0x40060BD")]
		public const short Football = 4743;

		// Token: 0x04004E72 RID: 20082
		[global::Cpp2ILInjected.Token(Token = "0x40060BE")]
		public const short HunterCloak = 4744;

		// Token: 0x04004E73 RID: 20083
		[global::Cpp2ILInjected.Token(Token = "0x40060BF")]
		public const short CoffinMinecart = 4745;

		// Token: 0x04004E74 RID: 20084
		[global::Cpp2ILInjected.Token(Token = "0x40060C0")]
		public const short SafemanWings = 4746;

		// Token: 0x04004E75 RID: 20085
		[global::Cpp2ILInjected.Token(Token = "0x40060C1")]
		public const short SafemanSunHair = 4747;

		// Token: 0x04004E76 RID: 20086
		[global::Cpp2ILInjected.Token(Token = "0x40060C2")]
		public const short SafemanSunDress = 4748;

		// Token: 0x04004E77 RID: 20087
		[global::Cpp2ILInjected.Token(Token = "0x40060C3")]
		public const short SafemanDressLeggings = 4749;

		// Token: 0x04004E78 RID: 20088
		[global::Cpp2ILInjected.Token(Token = "0x40060C4")]
		public const short FoodBarbarianWings = 4750;

		// Token: 0x04004E79 RID: 20089
		[global::Cpp2ILInjected.Token(Token = "0x40060C5")]
		public const short FoodBarbarianHelm = 4751;

		// Token: 0x04004E7A RID: 20090
		[global::Cpp2ILInjected.Token(Token = "0x40060C6")]
		public const short FoodBarbarianArmor = 4752;

		// Token: 0x04004E7B RID: 20091
		[global::Cpp2ILInjected.Token(Token = "0x40060C7")]
		public const short FoodBarbarianGreaves = 4753;

		// Token: 0x04004E7C RID: 20092
		[global::Cpp2ILInjected.Token(Token = "0x40060C8")]
		public const short GroxTheGreatWings = 4754;

		// Token: 0x04004E7D RID: 20093
		[global::Cpp2ILInjected.Token(Token = "0x40060C9")]
		public const short GroxTheGreatHelm = 4755;

		// Token: 0x04004E7E RID: 20094
		[global::Cpp2ILInjected.Token(Token = "0x40060CA")]
		public const short GroxTheGreatArmor = 4756;

		// Token: 0x04004E7F RID: 20095
		[global::Cpp2ILInjected.Token(Token = "0x40060CB")]
		public const short GroxTheGreatGreaves = 4757;

		// Token: 0x04004E80 RID: 20096
		[global::Cpp2ILInjected.Token(Token = "0x40060CC")]
		public const short Smolstar = 4758;

		// Token: 0x04004E81 RID: 20097
		[global::Cpp2ILInjected.Token(Token = "0x40060CD")]
		public const short SquirrelHook = 4759;

		// Token: 0x04004E82 RID: 20098
		[global::Cpp2ILInjected.Token(Token = "0x40060CE")]
		public const short BouncingShield = 4760;

		// Token: 0x04004E83 RID: 20099
		[global::Cpp2ILInjected.Token(Token = "0x40060CF")]
		public const short RockGolemHead = 4761;

		// Token: 0x04004E84 RID: 20100
		[global::Cpp2ILInjected.Token(Token = "0x40060D0")]
		public const short CritterShampoo = 4762;

		// Token: 0x04004E85 RID: 20101
		[global::Cpp2ILInjected.Token(Token = "0x40060D1")]
		public const short DiggingMoleMinecart = 4763;

		// Token: 0x04004E86 RID: 20102
		[global::Cpp2ILInjected.Token(Token = "0x40060D2")]
		public const short Shroomerang = 4764;

		// Token: 0x04004E87 RID: 20103
		[global::Cpp2ILInjected.Token(Token = "0x40060D3")]
		public const short TreeGlobe = 4765;

		// Token: 0x04004E88 RID: 20104
		[global::Cpp2ILInjected.Token(Token = "0x40060D4")]
		public const short WorldGlobe = 4766;

		// Token: 0x04004E89 RID: 20105
		[global::Cpp2ILInjected.Token(Token = "0x40060D5")]
		public const short DontHurtCrittersBook = 4767;

		// Token: 0x04004E8A RID: 20106
		[global::Cpp2ILInjected.Token(Token = "0x40060D6")]
		public const short DogEars = 4768;

		// Token: 0x04004E8B RID: 20107
		[global::Cpp2ILInjected.Token(Token = "0x40060D7")]
		public const short DogTail = 4769;

		// Token: 0x04004E8C RID: 20108
		[global::Cpp2ILInjected.Token(Token = "0x40060D8")]
		public const short FoxEars = 4770;

		// Token: 0x04004E8D RID: 20109
		[global::Cpp2ILInjected.Token(Token = "0x40060D9")]
		public const short FoxTail = 4771;

		// Token: 0x04004E8E RID: 20110
		[global::Cpp2ILInjected.Token(Token = "0x40060DA")]
		public const short LizardEars = 4772;

		// Token: 0x04004E8F RID: 20111
		[global::Cpp2ILInjected.Token(Token = "0x40060DB")]
		public const short LizardTail = 4773;

		// Token: 0x04004E90 RID: 20112
		[global::Cpp2ILInjected.Token(Token = "0x40060DC")]
		public const short PandaEars = 4774;

		// Token: 0x04004E91 RID: 20113
		[global::Cpp2ILInjected.Token(Token = "0x40060DD")]
		public const short BunnyTail = 4775;

		// Token: 0x04004E92 RID: 20114
		[global::Cpp2ILInjected.Token(Token = "0x40060DE")]
		public const short FairyGlowstick = 4776;

		// Token: 0x04004E93 RID: 20115
		[global::Cpp2ILInjected.Token(Token = "0x40060DF")]
		public const short LightningCarrot = 4777;

		// Token: 0x04004E94 RID: 20116
		[global::Cpp2ILInjected.Token(Token = "0x40060E0")]
		public const short HallowBossDye = 4778;

		// Token: 0x04004E95 RID: 20117
		[global::Cpp2ILInjected.Token(Token = "0x40060E1")]
		public const short MushroomHat = 4779;

		// Token: 0x04004E96 RID: 20118
		[global::Cpp2ILInjected.Token(Token = "0x40060E2")]
		public const short MushroomVest = 4780;

		// Token: 0x04004E97 RID: 20119
		[global::Cpp2ILInjected.Token(Token = "0x40060E3")]
		public const short MushroomPants = 4781;

		// Token: 0x04004E98 RID: 20120
		[global::Cpp2ILInjected.Token(Token = "0x40060E4")]
		public const short FairyQueenBossBag = 4782;

		// Token: 0x04004E99 RID: 20121
		[global::Cpp2ILInjected.Token(Token = "0x40060E5")]
		public const short FairyQueenTrophy = 4783;

		// Token: 0x04004E9A RID: 20122
		[global::Cpp2ILInjected.Token(Token = "0x40060E6")]
		public const short FairyQueenMask = 4784;

		// Token: 0x04004E9B RID: 20123
		[global::Cpp2ILInjected.Token(Token = "0x40060E7")]
		public const short PaintedHorseSaddle = 4785;

		// Token: 0x04004E9C RID: 20124
		[global::Cpp2ILInjected.Token(Token = "0x40060E8")]
		public const short MajesticHorseSaddle = 4786;

		// Token: 0x04004E9D RID: 20125
		[global::Cpp2ILInjected.Token(Token = "0x40060E9")]
		public const short DarkHorseSaddle = 4787;

		// Token: 0x04004E9E RID: 20126
		[global::Cpp2ILInjected.Token(Token = "0x40060EA")]
		public const short JoustingLance = 4788;

		// Token: 0x04004E9F RID: 20127
		[global::Cpp2ILInjected.Token(Token = "0x40060EB")]
		public const short ShadowJoustingLance = 4789;

		// Token: 0x04004EA0 RID: 20128
		[global::Cpp2ILInjected.Token(Token = "0x40060EC")]
		public const short HallowJoustingLance = 4790;

		// Token: 0x04004EA1 RID: 20129
		[global::Cpp2ILInjected.Token(Token = "0x40060ED")]
		public const short PogoStick = 4791;

		// Token: 0x04004EA2 RID: 20130
		[global::Cpp2ILInjected.Token(Token = "0x40060EE")]
		public const short PirateShipMountItem = 4792;

		// Token: 0x04004EA3 RID: 20131
		[global::Cpp2ILInjected.Token(Token = "0x40060EF")]
		public const short SpookyWoodMountItem = 4793;

		// Token: 0x04004EA4 RID: 20132
		[global::Cpp2ILInjected.Token(Token = "0x40060F0")]
		public const short SantankMountItem = 4794;

		// Token: 0x04004EA5 RID: 20133
		[global::Cpp2ILInjected.Token(Token = "0x40060F1")]
		public const short WallOfFleshGoatMountItem = 4795;

		// Token: 0x04004EA6 RID: 20134
		[global::Cpp2ILInjected.Token(Token = "0x40060F2")]
		public const short DarkMageBookMountItem = 4796;

		// Token: 0x04004EA7 RID: 20135
		[global::Cpp2ILInjected.Token(Token = "0x40060F3")]
		public const short KingSlimePetItem = 4797;

		// Token: 0x04004EA8 RID: 20136
		[global::Cpp2ILInjected.Token(Token = "0x40060F4")]
		public const short EyeOfCthulhuPetItem = 4798;

		// Token: 0x04004EA9 RID: 20137
		[global::Cpp2ILInjected.Token(Token = "0x40060F5")]
		public const short EaterOfWorldsPetItem = 4799;

		// Token: 0x04004EAA RID: 20138
		[global::Cpp2ILInjected.Token(Token = "0x40060F6")]
		public const short BrainOfCthulhuPetItem = 4800;

		// Token: 0x04004EAB RID: 20139
		[global::Cpp2ILInjected.Token(Token = "0x40060F7")]
		public const short SkeletronPetItem = 4801;

		// Token: 0x04004EAC RID: 20140
		[global::Cpp2ILInjected.Token(Token = "0x40060F8")]
		public const short QueenBeePetItem = 4802;

		// Token: 0x04004EAD RID: 20141
		[global::Cpp2ILInjected.Token(Token = "0x40060F9")]
		public const short DestroyerPetItem = 4803;

		// Token: 0x04004EAE RID: 20142
		[global::Cpp2ILInjected.Token(Token = "0x40060FA")]
		public const short TwinsPetItem = 4804;

		// Token: 0x04004EAF RID: 20143
		[global::Cpp2ILInjected.Token(Token = "0x40060FB")]
		public const short SkeletronPrimePetItem = 4805;

		// Token: 0x04004EB0 RID: 20144
		[global::Cpp2ILInjected.Token(Token = "0x40060FC")]
		public const short PlanteraPetItem = 4806;

		// Token: 0x04004EB1 RID: 20145
		[global::Cpp2ILInjected.Token(Token = "0x40060FD")]
		public const short GolemPetItem = 4807;

		// Token: 0x04004EB2 RID: 20146
		[global::Cpp2ILInjected.Token(Token = "0x40060FE")]
		public const short DukeFishronPetItem = 4808;

		// Token: 0x04004EB3 RID: 20147
		[global::Cpp2ILInjected.Token(Token = "0x40060FF")]
		public const short LunaticCultistPetItem = 4809;

		// Token: 0x04004EB4 RID: 20148
		[global::Cpp2ILInjected.Token(Token = "0x4006100")]
		public const short MoonLordPetItem = 4810;

		// Token: 0x04004EB5 RID: 20149
		[global::Cpp2ILInjected.Token(Token = "0x4006101")]
		public const short FairyQueenPetItem = 4811;

		// Token: 0x04004EB6 RID: 20150
		[global::Cpp2ILInjected.Token(Token = "0x4006102")]
		public const short PumpkingPetItem = 4812;

		// Token: 0x04004EB7 RID: 20151
		[global::Cpp2ILInjected.Token(Token = "0x4006103")]
		public const short EverscreamPetItem = 4813;

		// Token: 0x04004EB8 RID: 20152
		[global::Cpp2ILInjected.Token(Token = "0x4006104")]
		public const short IceQueenPetItem = 4814;

		// Token: 0x04004EB9 RID: 20153
		[global::Cpp2ILInjected.Token(Token = "0x4006105")]
		public const short MartianPetItem = 4815;

		// Token: 0x04004EBA RID: 20154
		[global::Cpp2ILInjected.Token(Token = "0x4006106")]
		public const short DD2OgrePetItem = 4816;

		// Token: 0x04004EBB RID: 20155
		[global::Cpp2ILInjected.Token(Token = "0x4006107")]
		public const short DD2BetsyPetItem = 4817;

		// Token: 0x04004EBC RID: 20156
		[global::Cpp2ILInjected.Token(Token = "0x4006108")]
		public const short CombatWrench = 4818;

		// Token: 0x04004EBD RID: 20157
		[global::Cpp2ILInjected.Token(Token = "0x4006109")]
		public const short DemonConch = 4819;

		// Token: 0x04004EBE RID: 20158
		[global::Cpp2ILInjected.Token(Token = "0x400610A")]
		public const short BottomlessLavaBucket = 4820;

		// Token: 0x04004EBF RID: 20159
		[global::Cpp2ILInjected.Token(Token = "0x400610B")]
		public const short FireproofBugNet = 4821;

		// Token: 0x04004EC0 RID: 20160
		[global::Cpp2ILInjected.Token(Token = "0x400610C")]
		public const short FlameWakerBoots = 4822;

		// Token: 0x04004EC1 RID: 20161
		[global::Cpp2ILInjected.Token(Token = "0x400610D")]
		public const short RainbowWings = 4823;

		// Token: 0x04004EC2 RID: 20162
		[global::Cpp2ILInjected.Token(Token = "0x400610E")]
		public const short WetBomb = 4824;

		// Token: 0x04004EC3 RID: 20163
		[global::Cpp2ILInjected.Token(Token = "0x400610F")]
		public const short LavaBomb = 4825;

		// Token: 0x04004EC4 RID: 20164
		[global::Cpp2ILInjected.Token(Token = "0x4006110")]
		public const short HoneyBomb = 4826;

		// Token: 0x04004EC5 RID: 20165
		[global::Cpp2ILInjected.Token(Token = "0x4006111")]
		public const short DryBomb = 4827;

		// Token: 0x04004EC6 RID: 20166
		[global::Cpp2ILInjected.Token(Token = "0x4006112")]
		public const short SuperheatedBlood = 4828;

		// Token: 0x04004EC7 RID: 20167
		[global::Cpp2ILInjected.Token(Token = "0x4006113")]
		public const short LicenseCat = 4829;

		// Token: 0x04004EC8 RID: 20168
		[global::Cpp2ILInjected.Token(Token = "0x4006114")]
		public const short LicenseDog = 4830;

		// Token: 0x04004EC9 RID: 20169
		[global::Cpp2ILInjected.Token(Token = "0x4006115")]
		public const short GemSquirrelAmethyst = 4831;

		// Token: 0x04004ECA RID: 20170
		[global::Cpp2ILInjected.Token(Token = "0x4006116")]
		public const short GemSquirrelTopaz = 4832;

		// Token: 0x04004ECB RID: 20171
		[global::Cpp2ILInjected.Token(Token = "0x4006117")]
		public const short GemSquirrelSapphire = 4833;

		// Token: 0x04004ECC RID: 20172
		[global::Cpp2ILInjected.Token(Token = "0x4006118")]
		public const short GemSquirrelEmerald = 4834;

		// Token: 0x04004ECD RID: 20173
		[global::Cpp2ILInjected.Token(Token = "0x4006119")]
		public const short GemSquirrelRuby = 4835;

		// Token: 0x04004ECE RID: 20174
		[global::Cpp2ILInjected.Token(Token = "0x400611A")]
		public const short GemSquirrelDiamond = 4836;

		// Token: 0x04004ECF RID: 20175
		[global::Cpp2ILInjected.Token(Token = "0x400611B")]
		public const short GemSquirrelAmber = 4837;

		// Token: 0x04004ED0 RID: 20176
		[global::Cpp2ILInjected.Token(Token = "0x400611C")]
		public const short GemBunnyAmethyst = 4838;

		// Token: 0x04004ED1 RID: 20177
		[global::Cpp2ILInjected.Token(Token = "0x400611D")]
		public const short GemBunnyTopaz = 4839;

		// Token: 0x04004ED2 RID: 20178
		[global::Cpp2ILInjected.Token(Token = "0x400611E")]
		public const short GemBunnySapphire = 4840;

		// Token: 0x04004ED3 RID: 20179
		[global::Cpp2ILInjected.Token(Token = "0x400611F")]
		public const short GemBunnyEmerald = 4841;

		// Token: 0x04004ED4 RID: 20180
		[global::Cpp2ILInjected.Token(Token = "0x4006120")]
		public const short GemBunnyRuby = 4842;

		// Token: 0x04004ED5 RID: 20181
		[global::Cpp2ILInjected.Token(Token = "0x4006121")]
		public const short GemBunnyDiamond = 4843;

		// Token: 0x04004ED6 RID: 20182
		[global::Cpp2ILInjected.Token(Token = "0x4006122")]
		public const short GemBunnyAmber = 4844;

		// Token: 0x04004ED7 RID: 20183
		[global::Cpp2ILInjected.Token(Token = "0x4006123")]
		public const short HellButterfly = 4845;

		// Token: 0x04004ED8 RID: 20184
		[global::Cpp2ILInjected.Token(Token = "0x4006124")]
		public const short HellButterflyJar = 4846;

		// Token: 0x04004ED9 RID: 20185
		[global::Cpp2ILInjected.Token(Token = "0x4006125")]
		public const short Lavafly = 4847;

		// Token: 0x04004EDA RID: 20186
		[global::Cpp2ILInjected.Token(Token = "0x4006126")]
		public const short LavaflyinaBottle = 4848;

		// Token: 0x04004EDB RID: 20187
		[global::Cpp2ILInjected.Token(Token = "0x4006127")]
		public const short MagmaSnail = 4849;

		// Token: 0x04004EDC RID: 20188
		[global::Cpp2ILInjected.Token(Token = "0x4006128")]
		public const short MagmaSnailCage = 4850;

		// Token: 0x04004EDD RID: 20189
		[global::Cpp2ILInjected.Token(Token = "0x4006129")]
		public const short GemTreeTopazSeed = 4851;

		// Token: 0x04004EDE RID: 20190
		[global::Cpp2ILInjected.Token(Token = "0x400612A")]
		public const short GemTreeAmethystSeed = 4852;

		// Token: 0x04004EDF RID: 20191
		[global::Cpp2ILInjected.Token(Token = "0x400612B")]
		public const short GemTreeSapphireSeed = 4853;

		// Token: 0x04004EE0 RID: 20192
		[global::Cpp2ILInjected.Token(Token = "0x400612C")]
		public const short GemTreeEmeraldSeed = 4854;

		// Token: 0x04004EE1 RID: 20193
		[global::Cpp2ILInjected.Token(Token = "0x400612D")]
		public const short GemTreeRubySeed = 4855;

		// Token: 0x04004EE2 RID: 20194
		[global::Cpp2ILInjected.Token(Token = "0x400612E")]
		public const short GemTreeDiamondSeed = 4856;

		// Token: 0x04004EE3 RID: 20195
		[global::Cpp2ILInjected.Token(Token = "0x400612F")]
		public const short GemTreeAmberSeed = 4857;

		// Token: 0x04004EE4 RID: 20196
		[global::Cpp2ILInjected.Token(Token = "0x4006130")]
		public const short PotSuspended = 4858;

		// Token: 0x04004EE5 RID: 20197
		[global::Cpp2ILInjected.Token(Token = "0x4006131")]
		public const short PotSuspendedDaybloom = 4859;

		// Token: 0x04004EE6 RID: 20198
		[global::Cpp2ILInjected.Token(Token = "0x4006132")]
		public const short PotSuspendedMoonglow = 4860;

		// Token: 0x04004EE7 RID: 20199
		[global::Cpp2ILInjected.Token(Token = "0x4006133")]
		public const short PotSuspendedWaterleaf = 4861;

		// Token: 0x04004EE8 RID: 20200
		[global::Cpp2ILInjected.Token(Token = "0x4006134")]
		public const short PotSuspendedShiverthorn = 4862;

		// Token: 0x04004EE9 RID: 20201
		[global::Cpp2ILInjected.Token(Token = "0x4006135")]
		public const short PotSuspendedBlinkroot = 4863;

		// Token: 0x04004EEA RID: 20202
		[global::Cpp2ILInjected.Token(Token = "0x4006136")]
		public const short PotSuspendedDeathweedCorrupt = 4864;

		// Token: 0x04004EEB RID: 20203
		[global::Cpp2ILInjected.Token(Token = "0x4006137")]
		public const short PotSuspendedDeathweedCrimson = 4865;

		// Token: 0x04004EEC RID: 20204
		[global::Cpp2ILInjected.Token(Token = "0x4006138")]
		public const short PotSuspendedFireblossom = 4866;

		// Token: 0x04004EED RID: 20205
		[global::Cpp2ILInjected.Token(Token = "0x4006139")]
		public const short BrazierSuspended = 4867;

		// Token: 0x04004EEE RID: 20206
		[global::Cpp2ILInjected.Token(Token = "0x400613A")]
		public const short VolcanoSmall = 4868;

		// Token: 0x04004EEF RID: 20207
		[global::Cpp2ILInjected.Token(Token = "0x400613B")]
		public const short VolcanoLarge = 4869;

		// Token: 0x04004EF0 RID: 20208
		[global::Cpp2ILInjected.Token(Token = "0x400613C")]
		public const short PotionOfReturn = 4870;

		// Token: 0x04004EF1 RID: 20209
		[global::Cpp2ILInjected.Token(Token = "0x400613D")]
		public const short VanityTreeSakuraSeed = 4871;

		// Token: 0x04004EF2 RID: 20210
		[global::Cpp2ILInjected.Token(Token = "0x400613E")]
		public const short LavaAbsorbantSponge = 4872;

		// Token: 0x04004EF3 RID: 20211
		[global::Cpp2ILInjected.Token(Token = "0x400613F")]
		public const short HallowedHood = 4873;

		// Token: 0x04004EF4 RID: 20212
		[global::Cpp2ILInjected.Token(Token = "0x4006140")]
		public const short HellfireTreads = 4874;

		// Token: 0x04004EF5 RID: 20213
		[global::Cpp2ILInjected.Token(Token = "0x4006141")]
		public const short TeleportationPylonJungle = 4875;

		// Token: 0x04004EF6 RID: 20214
		[global::Cpp2ILInjected.Token(Token = "0x4006142")]
		public const short TeleportationPylonPurity = 4876;

		// Token: 0x04004EF7 RID: 20215
		[global::Cpp2ILInjected.Token(Token = "0x4006143")]
		public const short LavaCrate = 4877;

		// Token: 0x04004EF8 RID: 20216
		[global::Cpp2ILInjected.Token(Token = "0x4006144")]
		public const short LavaCrateHard = 4878;

		// Token: 0x04004EF9 RID: 20217
		[global::Cpp2ILInjected.Token(Token = "0x4006145")]
		public const short ObsidianLockbox = 4879;

		// Token: 0x04004EFA RID: 20218
		[global::Cpp2ILInjected.Token(Token = "0x4006146")]
		public const short LavaFishbowl = 4880;

		// Token: 0x04004EFB RID: 20219
		[global::Cpp2ILInjected.Token(Token = "0x4006147")]
		public const short LavaFishingHook = 4881;

		// Token: 0x04004EFC RID: 20220
		[global::Cpp2ILInjected.Token(Token = "0x4006148")]
		public const short AmethystBunnyCage = 4882;

		// Token: 0x04004EFD RID: 20221
		[global::Cpp2ILInjected.Token(Token = "0x4006149")]
		public const short TopazBunnyCage = 4883;

		// Token: 0x04004EFE RID: 20222
		[global::Cpp2ILInjected.Token(Token = "0x400614A")]
		public const short SapphireBunnyCage = 4884;

		// Token: 0x04004EFF RID: 20223
		[global::Cpp2ILInjected.Token(Token = "0x400614B")]
		public const short EmeraldBunnyCage = 4885;

		// Token: 0x04004F00 RID: 20224
		[global::Cpp2ILInjected.Token(Token = "0x400614C")]
		public const short RubyBunnyCage = 4886;

		// Token: 0x04004F01 RID: 20225
		[global::Cpp2ILInjected.Token(Token = "0x400614D")]
		public const short DiamondBunnyCage = 4887;

		// Token: 0x04004F02 RID: 20226
		[global::Cpp2ILInjected.Token(Token = "0x400614E")]
		public const short AmberBunnyCage = 4888;

		// Token: 0x04004F03 RID: 20227
		[global::Cpp2ILInjected.Token(Token = "0x400614F")]
		public const short AmethystSquirrelCage = 4889;

		// Token: 0x04004F04 RID: 20228
		[global::Cpp2ILInjected.Token(Token = "0x4006150")]
		public const short TopazSquirrelCage = 4890;

		// Token: 0x04004F05 RID: 20229
		[global::Cpp2ILInjected.Token(Token = "0x4006151")]
		public const short SapphireSquirrelCage = 4891;

		// Token: 0x04004F06 RID: 20230
		[global::Cpp2ILInjected.Token(Token = "0x4006152")]
		public const short EmeraldSquirrelCage = 4892;

		// Token: 0x04004F07 RID: 20231
		[global::Cpp2ILInjected.Token(Token = "0x4006153")]
		public const short RubySquirrelCage = 4893;

		// Token: 0x04004F08 RID: 20232
		[global::Cpp2ILInjected.Token(Token = "0x4006154")]
		public const short DiamondSquirrelCage = 4894;

		// Token: 0x04004F09 RID: 20233
		[global::Cpp2ILInjected.Token(Token = "0x4006155")]
		public const short AmberSquirrelCage = 4895;

		// Token: 0x04004F0A RID: 20234
		[global::Cpp2ILInjected.Token(Token = "0x4006156")]
		public const short AncientHallowedMask = 4896;

		// Token: 0x04004F0B RID: 20235
		[global::Cpp2ILInjected.Token(Token = "0x4006157")]
		public const short AncientHallowedHelmet = 4897;

		// Token: 0x04004F0C RID: 20236
		[global::Cpp2ILInjected.Token(Token = "0x4006158")]
		public const short AncientHallowedHeadgear = 4898;

		// Token: 0x04004F0D RID: 20237
		[global::Cpp2ILInjected.Token(Token = "0x4006159")]
		public const short AncientHallowedHood = 4899;

		// Token: 0x04004F0E RID: 20238
		[global::Cpp2ILInjected.Token(Token = "0x400615A")]
		public const short AncientHallowedPlateMail = 4900;

		// Token: 0x04004F0F RID: 20239
		[global::Cpp2ILInjected.Token(Token = "0x400615B")]
		public const short AncientHallowedGreaves = 4901;

		// Token: 0x04004F10 RID: 20240
		[global::Cpp2ILInjected.Token(Token = "0x400615C")]
		public const short PottedLavaPlantPalm = 4902;

		// Token: 0x04004F11 RID: 20241
		[global::Cpp2ILInjected.Token(Token = "0x400615D")]
		public const short PottedLavaPlantBush = 4903;

		// Token: 0x04004F12 RID: 20242
		[global::Cpp2ILInjected.Token(Token = "0x400615E")]
		public const short PottedLavaPlantBramble = 4904;

		// Token: 0x04004F13 RID: 20243
		[global::Cpp2ILInjected.Token(Token = "0x400615F")]
		public const short PottedLavaPlantBulb = 4905;

		// Token: 0x04004F14 RID: 20244
		[global::Cpp2ILInjected.Token(Token = "0x4006160")]
		public const short PottedLavaPlantTendrils = 4906;

		// Token: 0x04004F15 RID: 20245
		[global::Cpp2ILInjected.Token(Token = "0x4006161")]
		public const short VanityTreeYellowWillowSeed = 4907;

		// Token: 0x04004F16 RID: 20246
		[global::Cpp2ILInjected.Token(Token = "0x4006162")]
		public const short DirtBomb = 4908;

		// Token: 0x04004F17 RID: 20247
		[global::Cpp2ILInjected.Token(Token = "0x4006163")]
		public const short DirtStickyBomb = 4909;

		// Token: 0x04004F18 RID: 20248
		[global::Cpp2ILInjected.Token(Token = "0x4006164")]
		public const short LicenseBunny = 4910;

		// Token: 0x04004F19 RID: 20249
		[global::Cpp2ILInjected.Token(Token = "0x4006165")]
		public const short CoolWhip = 4911;

		// Token: 0x04004F1A RID: 20250
		[global::Cpp2ILInjected.Token(Token = "0x4006166")]
		public const short FireWhip = 4912;

		// Token: 0x04004F1B RID: 20251
		[global::Cpp2ILInjected.Token(Token = "0x4006167")]
		public const short ThornWhip = 4913;

		// Token: 0x04004F1C RID: 20252
		[global::Cpp2ILInjected.Token(Token = "0x4006168")]
		public const short RainbowWhip = 4914;

		// Token: 0x04004F1D RID: 20253
		[global::Cpp2ILInjected.Token(Token = "0x4006169")]
		public const short TungstenBullet = 4915;

		// Token: 0x04004F1E RID: 20254
		[global::Cpp2ILInjected.Token(Token = "0x400616A")]
		public const short TeleportationPylonHallow = 4916;

		// Token: 0x04004F1F RID: 20255
		[global::Cpp2ILInjected.Token(Token = "0x400616B")]
		public const short TeleportationPylonUnderground = 4917;

		// Token: 0x04004F20 RID: 20256
		[global::Cpp2ILInjected.Token(Token = "0x400616C")]
		public const short TeleportationPylonOcean = 4918;

		// Token: 0x04004F21 RID: 20257
		[global::Cpp2ILInjected.Token(Token = "0x400616D")]
		public const short TeleportationPylonDesert = 4919;

		// Token: 0x04004F22 RID: 20258
		[global::Cpp2ILInjected.Token(Token = "0x400616E")]
		public const short TeleportationPylonSnow = 4920;

		// Token: 0x04004F23 RID: 20259
		[global::Cpp2ILInjected.Token(Token = "0x400616F")]
		public const short TeleportationPylonMushroom = 4921;

		// Token: 0x04004F24 RID: 20260
		[global::Cpp2ILInjected.Token(Token = "0x4006170")]
		public const short CavernFountain = 4922;

		// Token: 0x04004F25 RID: 20261
		[global::Cpp2ILInjected.Token(Token = "0x4006171")]
		public const short PiercingStarlight = 4923;

		// Token: 0x04004F26 RID: 20262
		[global::Cpp2ILInjected.Token(Token = "0x4006172")]
		public const short EyeofCthulhuMasterTrophy = 4924;

		// Token: 0x04004F27 RID: 20263
		[global::Cpp2ILInjected.Token(Token = "0x4006173")]
		public const short EaterofWorldsMasterTrophy = 4925;

		// Token: 0x04004F28 RID: 20264
		[global::Cpp2ILInjected.Token(Token = "0x4006174")]
		public const short BrainofCthulhuMasterTrophy = 4926;

		// Token: 0x04004F29 RID: 20265
		[global::Cpp2ILInjected.Token(Token = "0x4006175")]
		public const short SkeletronMasterTrophy = 4927;

		// Token: 0x04004F2A RID: 20266
		[global::Cpp2ILInjected.Token(Token = "0x4006176")]
		public const short QueenBeeMasterTrophy = 4928;

		// Token: 0x04004F2B RID: 20267
		[global::Cpp2ILInjected.Token(Token = "0x4006177")]
		public const short KingSlimeMasterTrophy = 4929;

		// Token: 0x04004F2C RID: 20268
		[global::Cpp2ILInjected.Token(Token = "0x4006178")]
		public const short WallofFleshMasterTrophy = 4930;

		// Token: 0x04004F2D RID: 20269
		[global::Cpp2ILInjected.Token(Token = "0x4006179")]
		public const short TwinsMasterTrophy = 4931;

		// Token: 0x04004F2E RID: 20270
		[global::Cpp2ILInjected.Token(Token = "0x400617A")]
		public const short DestroyerMasterTrophy = 4932;

		// Token: 0x04004F2F RID: 20271
		[global::Cpp2ILInjected.Token(Token = "0x400617B")]
		public const short SkeletronPrimeMasterTrophy = 4933;

		// Token: 0x04004F30 RID: 20272
		[global::Cpp2ILInjected.Token(Token = "0x400617C")]
		public const short PlanteraMasterTrophy = 4934;

		// Token: 0x04004F31 RID: 20273
		[global::Cpp2ILInjected.Token(Token = "0x400617D")]
		public const short GolemMasterTrophy = 4935;

		// Token: 0x04004F32 RID: 20274
		[global::Cpp2ILInjected.Token(Token = "0x400617E")]
		public const short DukeFishronMasterTrophy = 4936;

		// Token: 0x04004F33 RID: 20275
		[global::Cpp2ILInjected.Token(Token = "0x400617F")]
		public const short LunaticCultistMasterTrophy = 4937;

		// Token: 0x04004F34 RID: 20276
		[global::Cpp2ILInjected.Token(Token = "0x4006180")]
		public const short MoonLordMasterTrophy = 4938;

		// Token: 0x04004F35 RID: 20277
		[global::Cpp2ILInjected.Token(Token = "0x4006181")]
		public const short UFOMasterTrophy = 4939;

		// Token: 0x04004F36 RID: 20278
		[global::Cpp2ILInjected.Token(Token = "0x4006182")]
		public const short FlyingDutchmanMasterTrophy = 4940;

		// Token: 0x04004F37 RID: 20279
		[global::Cpp2ILInjected.Token(Token = "0x4006183")]
		public const short MourningWoodMasterTrophy = 4941;

		// Token: 0x04004F38 RID: 20280
		[global::Cpp2ILInjected.Token(Token = "0x4006184")]
		public const short PumpkingMasterTrophy = 4942;

		// Token: 0x04004F39 RID: 20281
		[global::Cpp2ILInjected.Token(Token = "0x4006185")]
		public const short IceQueenMasterTrophy = 4943;

		// Token: 0x04004F3A RID: 20282
		[global::Cpp2ILInjected.Token(Token = "0x4006186")]
		public const short EverscreamMasterTrophy = 4944;

		// Token: 0x04004F3B RID: 20283
		[global::Cpp2ILInjected.Token(Token = "0x4006187")]
		public const short SantankMasterTrophy = 4945;

		// Token: 0x04004F3C RID: 20284
		[global::Cpp2ILInjected.Token(Token = "0x4006188")]
		public const short DarkMageMasterTrophy = 4946;

		// Token: 0x04004F3D RID: 20285
		[global::Cpp2ILInjected.Token(Token = "0x4006189")]
		public const short OgreMasterTrophy = 4947;

		// Token: 0x04004F3E RID: 20286
		[global::Cpp2ILInjected.Token(Token = "0x400618A")]
		public const short BetsyMasterTrophy = 4948;

		// Token: 0x04004F3F RID: 20287
		[global::Cpp2ILInjected.Token(Token = "0x400618B")]
		public const short FairyQueenMasterTrophy = 4949;

		// Token: 0x04004F40 RID: 20288
		[global::Cpp2ILInjected.Token(Token = "0x400618C")]
		public const short QueenSlimeMasterTrophy = 4950;

		// Token: 0x04004F41 RID: 20289
		[global::Cpp2ILInjected.Token(Token = "0x400618D")]
		public const short TeleportationPylonVictory = 4951;

		// Token: 0x04004F42 RID: 20290
		[global::Cpp2ILInjected.Token(Token = "0x400618E")]
		public const short FairyQueenMagicItem = 4952;

		// Token: 0x04004F43 RID: 20291
		[global::Cpp2ILInjected.Token(Token = "0x400618F")]
		public const short FairyQueenRangedItem = 4953;

		// Token: 0x04004F44 RID: 20292
		[global::Cpp2ILInjected.Token(Token = "0x4006190")]
		public const short LongRainbowTrailWings = 4954;

		// Token: 0x04004F45 RID: 20293
		[global::Cpp2ILInjected.Token(Token = "0x4006191")]
		public const short RabbitOrder = 4955;

		// Token: 0x04004F46 RID: 20294
		[global::Cpp2ILInjected.Token(Token = "0x4006192")]
		public const short Zenith = 4956;

		// Token: 0x04004F47 RID: 20295
		[global::Cpp2ILInjected.Token(Token = "0x4006193")]
		public const short QueenSlimeBossBag = 4957;

		// Token: 0x04004F48 RID: 20296
		[global::Cpp2ILInjected.Token(Token = "0x4006194")]
		public const short QueenSlimeTrophy = 4958;

		// Token: 0x04004F49 RID: 20297
		[global::Cpp2ILInjected.Token(Token = "0x4006195")]
		public const short QueenSlimeMask = 4959;

		// Token: 0x04004F4A RID: 20298
		[global::Cpp2ILInjected.Token(Token = "0x4006196")]
		public const short QueenSlimePetItem = 4960;

		// Token: 0x04004F4B RID: 20299
		[global::Cpp2ILInjected.Token(Token = "0x4006197")]
		public const short EmpressButterfly = 4961;

		// Token: 0x04004F4C RID: 20300
		[global::Cpp2ILInjected.Token(Token = "0x4006198")]
		public const short AccentSlab = 4962;

		// Token: 0x04004F4D RID: 20301
		[global::Cpp2ILInjected.Token(Token = "0x4006199")]
		public const short TruffleWormCage = 4963;

		// Token: 0x04004F4E RID: 20302
		[global::Cpp2ILInjected.Token(Token = "0x400619A")]
		public const short EmpressButterflyJar = 4964;

		// Token: 0x04004F4F RID: 20303
		[global::Cpp2ILInjected.Token(Token = "0x400619B")]
		public const short RockGolemBanner = 4965;

		// Token: 0x04004F50 RID: 20304
		[global::Cpp2ILInjected.Token(Token = "0x400619C")]
		public const short BloodMummyBanner = 4966;

		// Token: 0x04004F51 RID: 20305
		[global::Cpp2ILInjected.Token(Token = "0x400619D")]
		public const short SporeSkeletonBanner = 4967;

		// Token: 0x04004F52 RID: 20306
		[global::Cpp2ILInjected.Token(Token = "0x400619E")]
		public const short SporeBatBanner = 4968;

		// Token: 0x04004F53 RID: 20307
		[global::Cpp2ILInjected.Token(Token = "0x400619F")]
		public const short LarvaeAntlionBanner = 4969;

		// Token: 0x04004F54 RID: 20308
		[global::Cpp2ILInjected.Token(Token = "0x40061A0")]
		public const short CrimsonBunnyBanner = 4970;

		// Token: 0x04004F55 RID: 20309
		[global::Cpp2ILInjected.Token(Token = "0x40061A1")]
		public const short CrimsonGoldfishBanner = 4971;

		// Token: 0x04004F56 RID: 20310
		[global::Cpp2ILInjected.Token(Token = "0x40061A2")]
		public const short CrimsonPenguinBanner = 4972;

		// Token: 0x04004F57 RID: 20311
		[global::Cpp2ILInjected.Token(Token = "0x40061A3")]
		public const short BigMimicCorruptionBanner = 4973;

		// Token: 0x04004F58 RID: 20312
		[global::Cpp2ILInjected.Token(Token = "0x40061A4")]
		public const short BigMimicCrimsonBanner = 4974;

		// Token: 0x04004F59 RID: 20313
		[global::Cpp2ILInjected.Token(Token = "0x40061A5")]
		public const short BigMimicHallowBanner = 4975;

		// Token: 0x04004F5A RID: 20314
		[global::Cpp2ILInjected.Token(Token = "0x40061A6")]
		public const short MossHornetBanner = 4976;

		// Token: 0x04004F5B RID: 20315
		[global::Cpp2ILInjected.Token(Token = "0x40061A7")]
		public const short WanderingEyeBanner = 4977;

		// Token: 0x04004F5C RID: 20316
		[global::Cpp2ILInjected.Token(Token = "0x40061A8")]
		public const short CreativeWings = 4978;

		// Token: 0x04004F5D RID: 20317
		[global::Cpp2ILInjected.Token(Token = "0x40061A9")]
		public const short MusicBoxQueenSlime = 4979;

		// Token: 0x04004F5E RID: 20318
		[global::Cpp2ILInjected.Token(Token = "0x40061AA")]
		public const short QueenSlimeHook = 4980;

		// Token: 0x04004F5F RID: 20319
		[global::Cpp2ILInjected.Token(Token = "0x40061AB")]
		public const short QueenSlimeMountSaddle = 4981;

		// Token: 0x04004F60 RID: 20320
		[global::Cpp2ILInjected.Token(Token = "0x40061AC")]
		public const short CrystalNinjaHelmet = 4982;

		// Token: 0x04004F61 RID: 20321
		[global::Cpp2ILInjected.Token(Token = "0x40061AD")]
		public const short CrystalNinjaChestplate = 4983;

		// Token: 0x04004F62 RID: 20322
		[global::Cpp2ILInjected.Token(Token = "0x40061AE")]
		public const short CrystalNinjaLeggings = 4984;

		// Token: 0x04004F63 RID: 20323
		[global::Cpp2ILInjected.Token(Token = "0x40061AF")]
		public const short MusicBoxEmpressOfLight = 4985;

		// Token: 0x04004F64 RID: 20324
		[global::Cpp2ILInjected.Token(Token = "0x40061B0")]
		public const short GelBalloon = 4986;

		// Token: 0x04004F65 RID: 20325
		[global::Cpp2ILInjected.Token(Token = "0x40061B1")]
		public const short VolatileGelatin = 4987;

		// Token: 0x04004F66 RID: 20326
		[global::Cpp2ILInjected.Token(Token = "0x40061B2")]
		public const short QueenSlimeCrystal = 4988;

		// Token: 0x04004F67 RID: 20327
		[global::Cpp2ILInjected.Token(Token = "0x40061B3")]
		public const short EmpressFlightBooster = 4989;

		// Token: 0x04004F68 RID: 20328
		[global::Cpp2ILInjected.Token(Token = "0x40061B4")]
		public const short MusicBoxDukeFishron = 4990;

		// Token: 0x04004F69 RID: 20329
		[global::Cpp2ILInjected.Token(Token = "0x40061B5")]
		public const short MusicBoxMorningRain = 4991;

		// Token: 0x04004F6A RID: 20330
		[global::Cpp2ILInjected.Token(Token = "0x40061B6")]
		public const short MusicBoxConsoleTitle = 4992;

		// Token: 0x04004F6B RID: 20331
		[global::Cpp2ILInjected.Token(Token = "0x40061B7")]
		public const short ChippysCouch = 4993;

		// Token: 0x04004F6C RID: 20332
		[global::Cpp2ILInjected.Token(Token = "0x40061B8")]
		public const short GraduationCapBlue = 4994;

		// Token: 0x04004F6D RID: 20333
		[global::Cpp2ILInjected.Token(Token = "0x40061B9")]
		public const short GraduationCapMaroon = 4995;

		// Token: 0x04004F6E RID: 20334
		[global::Cpp2ILInjected.Token(Token = "0x40061BA")]
		public const short GraduationCapBlack = 4996;

		// Token: 0x04004F6F RID: 20335
		[global::Cpp2ILInjected.Token(Token = "0x40061BB")]
		public const short GraduationGownBlue = 4997;

		// Token: 0x04004F70 RID: 20336
		[global::Cpp2ILInjected.Token(Token = "0x40061BC")]
		public const short GraduationGownMaroon = 4998;

		// Token: 0x04004F71 RID: 20337
		[global::Cpp2ILInjected.Token(Token = "0x40061BD")]
		public const short GraduationGownBlack = 4999;

		// Token: 0x04004F72 RID: 20338
		[global::Cpp2ILInjected.Token(Token = "0x40061BE")]
		public const short TerrasparkBoots = 5000;

		// Token: 0x04004F73 RID: 20339
		[global::Cpp2ILInjected.Token(Token = "0x40061BF")]
		public const short MoonLordLegs = 5001;

		// Token: 0x04004F74 RID: 20340
		[global::Cpp2ILInjected.Token(Token = "0x40061C0")]
		public const short OceanCrate = 5002;

		// Token: 0x04004F75 RID: 20341
		[global::Cpp2ILInjected.Token(Token = "0x40061C1")]
		public const short OceanCrateHard = 5003;

		// Token: 0x04004F76 RID: 20342
		[global::Cpp2ILInjected.Token(Token = "0x40061C2")]
		public const short BadgersHat = 5004;

		// Token: 0x04004F77 RID: 20343
		[global::Cpp2ILInjected.Token(Token = "0x40061C3")]
		public const short EmpressBlade = 5005;

		// Token: 0x04004F78 RID: 20344
		[global::Cpp2ILInjected.Token(Token = "0x40061C4")]
		public const short MusicBoxUndergroundDesert = 5006;

		// Token: 0x04004F79 RID: 20345
		[global::Cpp2ILInjected.Token(Token = "0x40061C5")]
		public const short DeadMansSweater = 5007;

		// Token: 0x04004F7A RID: 20346
		[global::Cpp2ILInjected.Token(Token = "0x40061C6")]
		public const short TeaKettle = 5008;

		// Token: 0x04004F7B RID: 20347
		[global::Cpp2ILInjected.Token(Token = "0x40061C7")]
		public const short Teacup = 5009;

		// Token: 0x04004F7C RID: 20348
		[global::Cpp2ILInjected.Token(Token = "0x40061C8")]
		public const short TreasureMagnet = 5010;

		// Token: 0x04004F7D RID: 20349
		[global::Cpp2ILInjected.Token(Token = "0x40061C9")]
		public const short Mace = 5011;

		// Token: 0x04004F7E RID: 20350
		[global::Cpp2ILInjected.Token(Token = "0x40061CA")]
		public const short FlamingMace = 5012;

		// Token: 0x04004F7F RID: 20351
		[global::Cpp2ILInjected.Token(Token = "0x40061CB")]
		public const short SleepingIcon = 5013;

		// Token: 0x04004F80 RID: 20352
		[global::Cpp2ILInjected.Token(Token = "0x40061CC")]
		public const short MusicBoxOWRain = 5014;

		// Token: 0x04004F81 RID: 20353
		[global::Cpp2ILInjected.Token(Token = "0x40061CD")]
		public const short MusicBoxOWDay = 5015;

		// Token: 0x04004F82 RID: 20354
		[global::Cpp2ILInjected.Token(Token = "0x40061CE")]
		public const short MusicBoxOWNight = 5016;

		// Token: 0x04004F83 RID: 20355
		[global::Cpp2ILInjected.Token(Token = "0x40061CF")]
		public const short MusicBoxOWUnderground = 5017;

		// Token: 0x04004F84 RID: 20356
		[global::Cpp2ILInjected.Token(Token = "0x40061D0")]
		public const short MusicBoxOWDesert = 5018;

		// Token: 0x04004F85 RID: 20357
		[global::Cpp2ILInjected.Token(Token = "0x40061D1")]
		public const short MusicBoxOWOcean = 5019;

		// Token: 0x04004F86 RID: 20358
		[global::Cpp2ILInjected.Token(Token = "0x40061D2")]
		public const short MusicBoxOWMushroom = 5020;

		// Token: 0x04004F87 RID: 20359
		[global::Cpp2ILInjected.Token(Token = "0x40061D3")]
		public const short MusicBoxOWDungeon = 5021;

		// Token: 0x04004F88 RID: 20360
		[global::Cpp2ILInjected.Token(Token = "0x40061D4")]
		public const short MusicBoxOWSpace = 5022;

		// Token: 0x04004F89 RID: 20361
		[global::Cpp2ILInjected.Token(Token = "0x40061D5")]
		public const short MusicBoxOWUnderworld = 5023;

		// Token: 0x04004F8A RID: 20362
		[global::Cpp2ILInjected.Token(Token = "0x40061D6")]
		public const short MusicBoxOWSnow = 5024;

		// Token: 0x04004F8B RID: 20363
		[global::Cpp2ILInjected.Token(Token = "0x40061D7")]
		public const short MusicBoxOWCorruption = 5025;

		// Token: 0x04004F8C RID: 20364
		[global::Cpp2ILInjected.Token(Token = "0x40061D8")]
		public const short MusicBoxOWUndergroundCorruption = 5026;

		// Token: 0x04004F8D RID: 20365
		[global::Cpp2ILInjected.Token(Token = "0x40061D9")]
		public const short MusicBoxOWCrimson = 5027;

		// Token: 0x04004F8E RID: 20366
		[global::Cpp2ILInjected.Token(Token = "0x40061DA")]
		public const short MusicBoxOWUndergroundCrimson = 5028;

		// Token: 0x04004F8F RID: 20367
		[global::Cpp2ILInjected.Token(Token = "0x40061DB")]
		public const short MusicBoxOWUndergroundSnow = 5029;

		// Token: 0x04004F90 RID: 20368
		[global::Cpp2ILInjected.Token(Token = "0x40061DC")]
		public const short MusicBoxOWUndergroundHallow = 5030;

		// Token: 0x04004F91 RID: 20369
		[global::Cpp2ILInjected.Token(Token = "0x40061DD")]
		public const short MusicBoxOWBloodMoon = 5031;

		// Token: 0x04004F92 RID: 20370
		[global::Cpp2ILInjected.Token(Token = "0x40061DE")]
		public const short MusicBoxOWBoss2 = 5032;

		// Token: 0x04004F93 RID: 20371
		[global::Cpp2ILInjected.Token(Token = "0x40061DF")]
		public const short MusicBoxOWBoss1 = 5033;

		// Token: 0x04004F94 RID: 20372
		[global::Cpp2ILInjected.Token(Token = "0x40061E0")]
		public const short MusicBoxOWInvasion = 5034;

		// Token: 0x04004F95 RID: 20373
		[global::Cpp2ILInjected.Token(Token = "0x40061E1")]
		public const short MusicBoxOWTowers = 5035;

		// Token: 0x04004F96 RID: 20374
		[global::Cpp2ILInjected.Token(Token = "0x40061E2")]
		public const short MusicBoxOWMoonLord = 5036;

		// Token: 0x04004F97 RID: 20375
		[global::Cpp2ILInjected.Token(Token = "0x40061E3")]
		public const short MusicBoxOWPlantera = 5037;

		// Token: 0x04004F98 RID: 20376
		[global::Cpp2ILInjected.Token(Token = "0x40061E4")]
		public const short MusicBoxOWJungle = 5038;

		// Token: 0x04004F99 RID: 20377
		[global::Cpp2ILInjected.Token(Token = "0x40061E5")]
		public const short MusicBoxOWWallOfFlesh = 5039;

		// Token: 0x04004F9A RID: 20378
		[global::Cpp2ILInjected.Token(Token = "0x40061E6")]
		public const short MusicBoxOWHallow = 5040;

		// Token: 0x04004F9B RID: 20379
		[global::Cpp2ILInjected.Token(Token = "0x40061E7")]
		public const short MilkCarton = 5041;

		// Token: 0x04004F9C RID: 20380
		[global::Cpp2ILInjected.Token(Token = "0x40061E8")]
		public const short CoffeeCup = 5042;

		// Token: 0x04004F9D RID: 20381
		[global::Cpp2ILInjected.Token(Token = "0x40061E9")]
		public const short TorchGodsFavor = 5043;

		// Token: 0x04004F9E RID: 20382
		[global::Cpp2ILInjected.Token(Token = "0x40061EA")]
		public const short MusicBoxCredits = 5044;

		// Token: 0x04004F9F RID: 20383
		[global::Cpp2ILInjected.Token(Token = "0x40061EB")]
		public const short PlaguebringerHelmet = 5045;

		// Token: 0x04004FA0 RID: 20384
		[global::Cpp2ILInjected.Token(Token = "0x40061EC")]
		public const short PlaguebringerChestplate = 5046;

		// Token: 0x04004FA1 RID: 20385
		[global::Cpp2ILInjected.Token(Token = "0x40061ED")]
		public const short PlaguebringerGreaves = 5047;

		// Token: 0x04004FA2 RID: 20386
		[global::Cpp2ILInjected.Token(Token = "0x40061EE")]
		public const short RoninHat = 5048;

		// Token: 0x04004FA3 RID: 20387
		[global::Cpp2ILInjected.Token(Token = "0x40061EF")]
		public const short RoninShirt = 5049;

		// Token: 0x04004FA4 RID: 20388
		[global::Cpp2ILInjected.Token(Token = "0x40061F0")]
		public const short RoninPants = 5050;

		// Token: 0x04004FA5 RID: 20389
		[global::Cpp2ILInjected.Token(Token = "0x40061F1")]
		public const short TimelessTravelerHood = 5051;

		// Token: 0x04004FA6 RID: 20390
		[global::Cpp2ILInjected.Token(Token = "0x40061F2")]
		public const short TimelessTravelerRobe = 5052;

		// Token: 0x04004FA7 RID: 20391
		[global::Cpp2ILInjected.Token(Token = "0x40061F3")]
		public const short TimelessTravelerBottom = 5053;

		// Token: 0x04004FA8 RID: 20392
		[global::Cpp2ILInjected.Token(Token = "0x40061F4")]
		public const short FloretProtectorHelmet = 5054;

		// Token: 0x04004FA9 RID: 20393
		[global::Cpp2ILInjected.Token(Token = "0x40061F5")]
		public const short FloretProtectorChestplate = 5055;

		// Token: 0x04004FAA RID: 20394
		[global::Cpp2ILInjected.Token(Token = "0x40061F6")]
		public const short FloretProtectorLegs = 5056;

		// Token: 0x04004FAB RID: 20395
		[global::Cpp2ILInjected.Token(Token = "0x40061F7")]
		public const short CapricornMask = 5057;

		// Token: 0x04004FAC RID: 20396
		[global::Cpp2ILInjected.Token(Token = "0x40061F8")]
		public const short CapricornChestplate = 5058;

		// Token: 0x04004FAD RID: 20397
		[global::Cpp2ILInjected.Token(Token = "0x40061F9")]
		public const short CapricornLegs = 5059;

		// Token: 0x04004FAE RID: 20398
		[global::Cpp2ILInjected.Token(Token = "0x40061FA")]
		public const short CapricornTail = 5060;

		// Token: 0x04004FAF RID: 20399
		[global::Cpp2ILInjected.Token(Token = "0x40061FB")]
		public const short TVHeadMask = 5061;

		// Token: 0x04004FB0 RID: 20400
		[global::Cpp2ILInjected.Token(Token = "0x40061FC")]
		public const short TVHeadSuit = 5062;

		// Token: 0x04004FB1 RID: 20401
		[global::Cpp2ILInjected.Token(Token = "0x40061FD")]
		public const short TVHeadPants = 5063;

		// Token: 0x04004FB2 RID: 20402
		[global::Cpp2ILInjected.Token(Token = "0x40061FE")]
		public const short LavaproofTackleBag = 5064;

		// Token: 0x04004FB3 RID: 20403
		[global::Cpp2ILInjected.Token(Token = "0x40061FF")]
		public const short PrincessWeapon = 5065;

		// Token: 0x04004FB4 RID: 20404
		[global::Cpp2ILInjected.Token(Token = "0x4006200")]
		public const short BeeHive = 5066;

		// Token: 0x04004FB5 RID: 20405
		[global::Cpp2ILInjected.Token(Token = "0x4006201")]
		public const short AntlionEggs = 5067;

		// Token: 0x04004FB6 RID: 20406
		[global::Cpp2ILInjected.Token(Token = "0x4006202")]
		public const short FlinxFurCoat = 5068;

		// Token: 0x04004FB7 RID: 20407
		[global::Cpp2ILInjected.Token(Token = "0x4006203")]
		public const short FlinxStaff = 5069;

		// Token: 0x04004FB8 RID: 20408
		[global::Cpp2ILInjected.Token(Token = "0x4006204")]
		public const short FlinxFur = 5070;

		// Token: 0x04004FB9 RID: 20409
		[global::Cpp2ILInjected.Token(Token = "0x4006205")]
		public const short RoyalTiara = 5071;

		// Token: 0x04004FBA RID: 20410
		[global::Cpp2ILInjected.Token(Token = "0x4006206")]
		public const short RoyalDressTop = 5072;

		// Token: 0x04004FBB RID: 20411
		[global::Cpp2ILInjected.Token(Token = "0x4006207")]
		public const short RoyalDressBottom = 5073;

		// Token: 0x04004FBC RID: 20412
		[global::Cpp2ILInjected.Token(Token = "0x4006208")]
		public const short BoneWhip = 5074;

		// Token: 0x04004FBD RID: 20413
		[global::Cpp2ILInjected.Token(Token = "0x4006209")]
		public const short RainbowCursor = 5075;

		// Token: 0x04004FBE RID: 20414
		[global::Cpp2ILInjected.Token(Token = "0x400620A")]
		public const short RoyalScepter = 5076;

		// Token: 0x04004FBF RID: 20415
		[global::Cpp2ILInjected.Token(Token = "0x400620B")]
		public const short GlassSlipper = 5077;

		// Token: 0x04004FC0 RID: 20416
		[global::Cpp2ILInjected.Token(Token = "0x400620C")]
		public const short PrinceUniform = 5078;

		// Token: 0x04004FC1 RID: 20417
		[global::Cpp2ILInjected.Token(Token = "0x400620D")]
		public const short PrincePants = 5079;

		// Token: 0x04004FC2 RID: 20418
		[global::Cpp2ILInjected.Token(Token = "0x400620E")]
		public const short PrinceCape = 5080;

		// Token: 0x04004FC3 RID: 20419
		[global::Cpp2ILInjected.Token(Token = "0x400620F")]
		public const short PottedCrystalPlantFern = 5081;

		// Token: 0x04004FC4 RID: 20420
		[global::Cpp2ILInjected.Token(Token = "0x4006210")]
		public const short PottedCrystalPlantSpiral = 5082;

		// Token: 0x04004FC5 RID: 20421
		[global::Cpp2ILInjected.Token(Token = "0x4006211")]
		public const short PottedCrystalPlantTeardrop = 5083;

		// Token: 0x04004FC6 RID: 20422
		[global::Cpp2ILInjected.Token(Token = "0x4006212")]
		public const short PottedCrystalPlantTree = 5084;

		// Token: 0x04004FC7 RID: 20423
		[global::Cpp2ILInjected.Token(Token = "0x4006213")]
		public const short Princess64 = 5085;

		// Token: 0x04004FC8 RID: 20424
		[global::Cpp2ILInjected.Token(Token = "0x4006214")]
		public const short PaintingOfALass = 5086;

		// Token: 0x04004FC9 RID: 20425
		[global::Cpp2ILInjected.Token(Token = "0x4006215")]
		public const short DarkSideHallow = 5087;

		// Token: 0x04004FCA RID: 20426
		[global::Cpp2ILInjected.Token(Token = "0x4006216")]
		public const short BerniePetItem = 5088;

		// Token: 0x04004FCB RID: 20427
		[global::Cpp2ILInjected.Token(Token = "0x4006217")]
		public const short GlommerPetItem = 5089;

		// Token: 0x04004FCC RID: 20428
		[global::Cpp2ILInjected.Token(Token = "0x4006218")]
		public const short DeerclopsPetItem = 5090;

		// Token: 0x04004FCD RID: 20429
		[global::Cpp2ILInjected.Token(Token = "0x4006219")]
		public const short PigPetItem = 5091;

		// Token: 0x04004FCE RID: 20430
		[global::Cpp2ILInjected.Token(Token = "0x400621A")]
		public const short MonsterLasagna = 5092;

		// Token: 0x04004FCF RID: 20431
		[global::Cpp2ILInjected.Token(Token = "0x400621B")]
		public const short FroggleBunwich = 5093;

		// Token: 0x04004FD0 RID: 20432
		[global::Cpp2ILInjected.Token(Token = "0x400621C")]
		public const short TentacleSpike = 5094;

		// Token: 0x04004FD1 RID: 20433
		[global::Cpp2ILInjected.Token(Token = "0x400621D")]
		public const short LucyTheAxe = 5095;

		// Token: 0x04004FD2 RID: 20434
		[global::Cpp2ILInjected.Token(Token = "0x400621E")]
		public const short HamBat = 5096;

		// Token: 0x04004FD3 RID: 20435
		[global::Cpp2ILInjected.Token(Token = "0x400621F")]
		public const short BatBat = 5097;

		// Token: 0x04004FD4 RID: 20436
		[global::Cpp2ILInjected.Token(Token = "0x4006220")]
		public const short ChesterPetItem = 5098;

		// Token: 0x04004FD5 RID: 20437
		[global::Cpp2ILInjected.Token(Token = "0x4006221")]
		public const short GarlandHat = 5099;

		// Token: 0x04004FD6 RID: 20438
		[global::Cpp2ILInjected.Token(Token = "0x4006222")]
		public const short BoneHelm = 5100;

		// Token: 0x04004FD7 RID: 20439
		[global::Cpp2ILInjected.Token(Token = "0x4006223")]
		public const short Eyebrella = 5101;

		// Token: 0x04004FD8 RID: 20440
		[global::Cpp2ILInjected.Token(Token = "0x4006224")]
		public const short WilsonShirt = 5102;

		// Token: 0x04004FD9 RID: 20441
		[global::Cpp2ILInjected.Token(Token = "0x4006225")]
		public const short WilsonPants = 5103;

		// Token: 0x04004FDA RID: 20442
		[global::Cpp2ILInjected.Token(Token = "0x4006226")]
		public const short WilsonBeardShort = 5104;

		// Token: 0x04004FDB RID: 20443
		[global::Cpp2ILInjected.Token(Token = "0x4006227")]
		public const short WilsonBeardLong = 5105;

		// Token: 0x04004FDC RID: 20444
		[global::Cpp2ILInjected.Token(Token = "0x4006228")]
		public const short WilsonBeardMagnificent = 5106;

		// Token: 0x04004FDD RID: 20445
		[global::Cpp2ILInjected.Token(Token = "0x4006229")]
		public const short Magiluminescence = 5107;

		// Token: 0x04004FDE RID: 20446
		[global::Cpp2ILInjected.Token(Token = "0x400622A")]
		public const short DeerclopsTrophy = 5108;

		// Token: 0x04004FDF RID: 20447
		[global::Cpp2ILInjected.Token(Token = "0x400622B")]
		public const short DeerclopsMask = 5109;

		// Token: 0x04004FE0 RID: 20448
		[global::Cpp2ILInjected.Token(Token = "0x400622C")]
		public const short DeerclopsMasterTrophy = 5110;

		// Token: 0x04004FE1 RID: 20449
		[global::Cpp2ILInjected.Token(Token = "0x400622D")]
		public const short DeerclopsBossBag = 5111;

		// Token: 0x04004FE2 RID: 20450
		[global::Cpp2ILInjected.Token(Token = "0x400622E")]
		public const short MusicBoxDeerclops = 5112;

		// Token: 0x04004FE3 RID: 20451
		[global::Cpp2ILInjected.Token(Token = "0x400622F")]
		public const short DontStarveShaderItem = 5113;

		// Token: 0x04004FE4 RID: 20452
		[global::Cpp2ILInjected.Token(Token = "0x4006230")]
		public const short AbigailsFlower = 5114;

		// Token: 0x04004FE5 RID: 20453
		[global::Cpp2ILInjected.Token(Token = "0x4006231")]
		public const short WillowShirt = 5115;

		// Token: 0x04004FE6 RID: 20454
		[global::Cpp2ILInjected.Token(Token = "0x4006232")]
		public const short WillowSkirt = 5116;

		// Token: 0x04004FE7 RID: 20455
		[global::Cpp2ILInjected.Token(Token = "0x4006233")]
		public const short PewMaticHorn = 5117;

		// Token: 0x04004FE8 RID: 20456
		[global::Cpp2ILInjected.Token(Token = "0x4006234")]
		public const short WeatherPain = 5118;

		// Token: 0x04004FE9 RID: 20457
		[global::Cpp2ILInjected.Token(Token = "0x4006235")]
		public const short HoundiusShootius = 5119;

		// Token: 0x04004FEA RID: 20458
		[global::Cpp2ILInjected.Token(Token = "0x4006236")]
		public const short DeerThing = 5120;

		// Token: 0x04004FEB RID: 20459
		[global::Cpp2ILInjected.Token(Token = "0x4006237")]
		public const short PaintingWilson = 5121;

		// Token: 0x04004FEC RID: 20460
		[global::Cpp2ILInjected.Token(Token = "0x4006238")]
		public const short PaintingWillow = 5122;

		// Token: 0x04004FED RID: 20461
		[global::Cpp2ILInjected.Token(Token = "0x4006239")]
		public const short PaintingWendy = 5123;

		// Token: 0x04004FEE RID: 20462
		[global::Cpp2ILInjected.Token(Token = "0x400623A")]
		public const short PaintingWolfgang = 5124;

		// Token: 0x04004FEF RID: 20463
		[global::Cpp2ILInjected.Token(Token = "0x400623B")]
		public const short FartMinecart = 5125;

		// Token: 0x04004FF0 RID: 20464
		[global::Cpp2ILInjected.Token(Token = "0x400623C")]
		public const short HandOfCreation = 5126;

		// Token: 0x04004FF1 RID: 20465
		[global::Cpp2ILInjected.Token(Token = "0x400623D")]
		public const short VioletMoss = 5127;

		// Token: 0x04004FF2 RID: 20466
		[global::Cpp2ILInjected.Token(Token = "0x400623E")]
		public const short RainbowMoss = 5128;

		// Token: 0x04004FF3 RID: 20467
		[global::Cpp2ILInjected.Token(Token = "0x400623F")]
		public const short Flymeal = 5129;

		// Token: 0x04004FF4 RID: 20468
		[global::Cpp2ILInjected.Token(Token = "0x4006240")]
		public const short WolfMountItem = 5130;

		// Token: 0x04004FF5 RID: 20469
		[global::Cpp2ILInjected.Token(Token = "0x4006241")]
		public const short ResplendentDessert = 5131;

		// Token: 0x04004FF6 RID: 20470
		[global::Cpp2ILInjected.Token(Token = "0x4006242")]
		public const short Stinkbug = 5132;

		// Token: 0x04004FF7 RID: 20471
		[global::Cpp2ILInjected.Token(Token = "0x4006243")]
		public const short StinkbugCage = 5133;

		// Token: 0x04004FF8 RID: 20472
		[global::Cpp2ILInjected.Token(Token = "0x4006244")]
		public const short Clentaminator2 = 5134;

		// Token: 0x04004FF9 RID: 20473
		[global::Cpp2ILInjected.Token(Token = "0x4006245")]
		public const short VenomDartTrap = 5135;

		// Token: 0x04004FFA RID: 20474
		[global::Cpp2ILInjected.Token(Token = "0x4006246")]
		public const short VulkelfEar = 5136;

		// Token: 0x04004FFB RID: 20475
		[global::Cpp2ILInjected.Token(Token = "0x4006247")]
		public const short StinkbugHousingBlocker = 5137;

		// Token: 0x04004FFC RID: 20476
		[global::Cpp2ILInjected.Token(Token = "0x4006248")]
		public const short StinkbugHousingBlockerEcho = 5138;

		// Token: 0x04004FFD RID: 20477
		[global::Cpp2ILInjected.Token(Token = "0x4006249")]
		public const short FishingBobber = 5139;

		// Token: 0x04004FFE RID: 20478
		[global::Cpp2ILInjected.Token(Token = "0x400624A")]
		public const short FishingBobberGlowingStar = 5140;

		// Token: 0x04004FFF RID: 20479
		[global::Cpp2ILInjected.Token(Token = "0x400624B")]
		public const short FishingBobberGlowingLava = 5141;

		// Token: 0x04005000 RID: 20480
		[global::Cpp2ILInjected.Token(Token = "0x400624C")]
		public const short FishingBobberGlowingKrypton = 5142;

		// Token: 0x04005001 RID: 20481
		[global::Cpp2ILInjected.Token(Token = "0x400624D")]
		public const short FishingBobberGlowingXenon = 5143;

		// Token: 0x04005002 RID: 20482
		[global::Cpp2ILInjected.Token(Token = "0x400624E")]
		public const short FishingBobberGlowingArgon = 5144;

		// Token: 0x04005003 RID: 20483
		[global::Cpp2ILInjected.Token(Token = "0x400624F")]
		public const short FishingBobberGlowingViolet = 5145;

		// Token: 0x04005004 RID: 20484
		[global::Cpp2ILInjected.Token(Token = "0x4006250")]
		public const short FishingBobberGlowingRainbow = 5146;

		// Token: 0x04005005 RID: 20485
		[global::Cpp2ILInjected.Token(Token = "0x4006251")]
		public const short WandofFrosting = 5147;

		// Token: 0x04005006 RID: 20486
		[global::Cpp2ILInjected.Token(Token = "0x4006252")]
		public const short CoralBathtub = 5148;

		// Token: 0x04005007 RID: 20487
		[global::Cpp2ILInjected.Token(Token = "0x4006253")]
		public const short CoralBed = 5149;

		// Token: 0x04005008 RID: 20488
		[global::Cpp2ILInjected.Token(Token = "0x4006254")]
		public const short CoralBookcase = 5150;

		// Token: 0x04005009 RID: 20489
		[global::Cpp2ILInjected.Token(Token = "0x4006255")]
		public const short CoralDresser = 5151;

		// Token: 0x0400500A RID: 20490
		[global::Cpp2ILInjected.Token(Token = "0x4006256")]
		public const short CoralCandelabra = 5152;

		// Token: 0x0400500B RID: 20491
		[global::Cpp2ILInjected.Token(Token = "0x4006257")]
		public const short CoralCandle = 5153;

		// Token: 0x0400500C RID: 20492
		[global::Cpp2ILInjected.Token(Token = "0x4006258")]
		public const short CoralChair = 5154;

		// Token: 0x0400500D RID: 20493
		[global::Cpp2ILInjected.Token(Token = "0x4006259")]
		public const short CoralChandelier = 5155;

		// Token: 0x0400500E RID: 20494
		[global::Cpp2ILInjected.Token(Token = "0x400625A")]
		public const short CoralChest = 5156;

		// Token: 0x0400500F RID: 20495
		[global::Cpp2ILInjected.Token(Token = "0x400625B")]
		public const short CoralClock = 5157;

		// Token: 0x04005010 RID: 20496
		[global::Cpp2ILInjected.Token(Token = "0x400625C")]
		public const short CoralDoor = 5158;

		// Token: 0x04005011 RID: 20497
		[global::Cpp2ILInjected.Token(Token = "0x400625D")]
		public const short CoralLamp = 5159;

		// Token: 0x04005012 RID: 20498
		[global::Cpp2ILInjected.Token(Token = "0x400625E")]
		public const short CoralLantern = 5160;

		// Token: 0x04005013 RID: 20499
		[global::Cpp2ILInjected.Token(Token = "0x400625F")]
		public const short CoralPiano = 5161;

		// Token: 0x04005014 RID: 20500
		[global::Cpp2ILInjected.Token(Token = "0x4006260")]
		public const short CoralPlatform = 5162;

		// Token: 0x04005015 RID: 20501
		[global::Cpp2ILInjected.Token(Token = "0x4006261")]
		public const short CoralSink = 5163;

		// Token: 0x04005016 RID: 20502
		[global::Cpp2ILInjected.Token(Token = "0x4006262")]
		public const short CoralSofa = 5164;

		// Token: 0x04005017 RID: 20503
		[global::Cpp2ILInjected.Token(Token = "0x4006263")]
		public const short CoralTable = 5165;

		// Token: 0x04005018 RID: 20504
		[global::Cpp2ILInjected.Token(Token = "0x4006264")]
		public const short CoralWorkbench = 5166;

		// Token: 0x04005019 RID: 20505
		[global::Cpp2ILInjected.Token(Token = "0x4006265")]
		public const short Fake_CoralChest = 5167;

		// Token: 0x0400501A RID: 20506
		[global::Cpp2ILInjected.Token(Token = "0x4006266")]
		public const short CoralToilet = 5168;

		// Token: 0x0400501B RID: 20507
		[global::Cpp2ILInjected.Token(Token = "0x4006267")]
		public const short BalloonBathtub = 5169;

		// Token: 0x0400501C RID: 20508
		[global::Cpp2ILInjected.Token(Token = "0x4006268")]
		public const short BalloonBed = 5170;

		// Token: 0x0400501D RID: 20509
		[global::Cpp2ILInjected.Token(Token = "0x4006269")]
		public const short BalloonBookcase = 5171;

		// Token: 0x0400501E RID: 20510
		[global::Cpp2ILInjected.Token(Token = "0x400626A")]
		public const short BalloonDresser = 5172;

		// Token: 0x0400501F RID: 20511
		[global::Cpp2ILInjected.Token(Token = "0x400626B")]
		public const short BalloonCandelabra = 5173;

		// Token: 0x04005020 RID: 20512
		[global::Cpp2ILInjected.Token(Token = "0x400626C")]
		public const short BalloonCandle = 5174;

		// Token: 0x04005021 RID: 20513
		[global::Cpp2ILInjected.Token(Token = "0x400626D")]
		public const short BalloonChair = 5175;

		// Token: 0x04005022 RID: 20514
		[global::Cpp2ILInjected.Token(Token = "0x400626E")]
		public const short BalloonChandelier = 5176;

		// Token: 0x04005023 RID: 20515
		[global::Cpp2ILInjected.Token(Token = "0x400626F")]
		public const short BalloonChest = 5177;

		// Token: 0x04005024 RID: 20516
		[global::Cpp2ILInjected.Token(Token = "0x4006270")]
		public const short BalloonClock = 5178;

		// Token: 0x04005025 RID: 20517
		[global::Cpp2ILInjected.Token(Token = "0x4006271")]
		public const short BalloonDoor = 5179;

		// Token: 0x04005026 RID: 20518
		[global::Cpp2ILInjected.Token(Token = "0x4006272")]
		public const short BalloonLamp = 5180;

		// Token: 0x04005027 RID: 20519
		[global::Cpp2ILInjected.Token(Token = "0x4006273")]
		public const short BalloonLantern = 5181;

		// Token: 0x04005028 RID: 20520
		[global::Cpp2ILInjected.Token(Token = "0x4006274")]
		public const short BalloonPiano = 5182;

		// Token: 0x04005029 RID: 20521
		[global::Cpp2ILInjected.Token(Token = "0x4006275")]
		public const short BalloonPlatform = 5183;

		// Token: 0x0400502A RID: 20522
		[global::Cpp2ILInjected.Token(Token = "0x4006276")]
		public const short BalloonSink = 5184;

		// Token: 0x0400502B RID: 20523
		[global::Cpp2ILInjected.Token(Token = "0x4006277")]
		public const short BalloonSofa = 5185;

		// Token: 0x0400502C RID: 20524
		[global::Cpp2ILInjected.Token(Token = "0x4006278")]
		public const short BalloonTable = 5186;

		// Token: 0x0400502D RID: 20525
		[global::Cpp2ILInjected.Token(Token = "0x4006279")]
		public const short BalloonWorkbench = 5187;

		// Token: 0x0400502E RID: 20526
		[global::Cpp2ILInjected.Token(Token = "0x400627A")]
		public const short Fake_BalloonChest = 5188;

		// Token: 0x0400502F RID: 20527
		[global::Cpp2ILInjected.Token(Token = "0x400627B")]
		public const short BalloonToilet = 5189;

		// Token: 0x04005030 RID: 20528
		[global::Cpp2ILInjected.Token(Token = "0x400627C")]
		public const short AshWoodBathtub = 5190;

		// Token: 0x04005031 RID: 20529
		[global::Cpp2ILInjected.Token(Token = "0x400627D")]
		public const short AshWoodBed = 5191;

		// Token: 0x04005032 RID: 20530
		[global::Cpp2ILInjected.Token(Token = "0x400627E")]
		public const short AshWoodBookcase = 5192;

		// Token: 0x04005033 RID: 20531
		[global::Cpp2ILInjected.Token(Token = "0x400627F")]
		public const short AshWoodDresser = 5193;

		// Token: 0x04005034 RID: 20532
		[global::Cpp2ILInjected.Token(Token = "0x4006280")]
		public const short AshWoodCandelabra = 5194;

		// Token: 0x04005035 RID: 20533
		[global::Cpp2ILInjected.Token(Token = "0x4006281")]
		public const short AshWoodCandle = 5195;

		// Token: 0x04005036 RID: 20534
		[global::Cpp2ILInjected.Token(Token = "0x4006282")]
		public const short AshWoodChair = 5196;

		// Token: 0x04005037 RID: 20535
		[global::Cpp2ILInjected.Token(Token = "0x4006283")]
		public const short AshWoodChandelier = 5197;

		// Token: 0x04005038 RID: 20536
		[global::Cpp2ILInjected.Token(Token = "0x4006284")]
		public const short AshWoodChest = 5198;

		// Token: 0x04005039 RID: 20537
		[global::Cpp2ILInjected.Token(Token = "0x4006285")]
		public const short AshWoodClock = 5199;

		// Token: 0x0400503A RID: 20538
		[global::Cpp2ILInjected.Token(Token = "0x4006286")]
		public const short AshWoodDoor = 5200;

		// Token: 0x0400503B RID: 20539
		[global::Cpp2ILInjected.Token(Token = "0x4006287")]
		public const short AshWoodLamp = 5201;

		// Token: 0x0400503C RID: 20540
		[global::Cpp2ILInjected.Token(Token = "0x4006288")]
		public const short AshWoodLantern = 5202;

		// Token: 0x0400503D RID: 20541
		[global::Cpp2ILInjected.Token(Token = "0x4006289")]
		public const short AshWoodPiano = 5203;

		// Token: 0x0400503E RID: 20542
		[global::Cpp2ILInjected.Token(Token = "0x400628A")]
		public const short AshWoodPlatform = 5204;

		// Token: 0x0400503F RID: 20543
		[global::Cpp2ILInjected.Token(Token = "0x400628B")]
		public const short AshWoodSink = 5205;

		// Token: 0x04005040 RID: 20544
		[global::Cpp2ILInjected.Token(Token = "0x400628C")]
		public const short AshWoodSofa = 5206;

		// Token: 0x04005041 RID: 20545
		[global::Cpp2ILInjected.Token(Token = "0x400628D")]
		public const short AshWoodTable = 5207;

		// Token: 0x04005042 RID: 20546
		[global::Cpp2ILInjected.Token(Token = "0x400628E")]
		public const short AshWoodWorkbench = 5208;

		// Token: 0x04005043 RID: 20547
		[global::Cpp2ILInjected.Token(Token = "0x400628F")]
		public const short Fake_AshWoodChest = 5209;

		// Token: 0x04005044 RID: 20548
		[global::Cpp2ILInjected.Token(Token = "0x4006290")]
		public const short AshWoodToilet = 5210;

		// Token: 0x04005045 RID: 20549
		[global::Cpp2ILInjected.Token(Token = "0x4006291")]
		public const short BiomeSightPotion = 5211;

		// Token: 0x04005046 RID: 20550
		[global::Cpp2ILInjected.Token(Token = "0x4006292")]
		public const short ScarletMacaw = 5212;

		// Token: 0x04005047 RID: 20551
		[global::Cpp2ILInjected.Token(Token = "0x4006293")]
		public const short ScarletMacawCage = 5213;

		// Token: 0x04005048 RID: 20552
		[global::Cpp2ILInjected.Token(Token = "0x4006294")]
		public const short AshGrassSeeds = 5214;

		// Token: 0x04005049 RID: 20553
		[global::Cpp2ILInjected.Token(Token = "0x4006295")]
		public const short AshWood = 5215;

		// Token: 0x0400504A RID: 20554
		[global::Cpp2ILInjected.Token(Token = "0x4006296")]
		public const short AshWoodWall = 5216;

		// Token: 0x0400504B RID: 20555
		[global::Cpp2ILInjected.Token(Token = "0x4006297")]
		public const short AshWoodFence = 5217;

		// Token: 0x0400504C RID: 20556
		[global::Cpp2ILInjected.Token(Token = "0x4006298")]
		public const short Outcast = 5218;

		// Token: 0x0400504D RID: 20557
		[global::Cpp2ILInjected.Token(Token = "0x4006299")]
		public const short FairyGuides = 5219;

		// Token: 0x0400504E RID: 20558
		[global::Cpp2ILInjected.Token(Token = "0x400629A")]
		public const short AHorribleNightforAlchemy = 5220;

		// Token: 0x0400504F RID: 20559
		[global::Cpp2ILInjected.Token(Token = "0x400629B")]
		public const short MorningHunt = 5221;

		// Token: 0x04005050 RID: 20560
		[global::Cpp2ILInjected.Token(Token = "0x400629C")]
		public const short SuspiciouslySparkly = 5222;

		// Token: 0x04005051 RID: 20561
		[global::Cpp2ILInjected.Token(Token = "0x400629D")]
		public const short Requiem = 5223;

		// Token: 0x04005052 RID: 20562
		[global::Cpp2ILInjected.Token(Token = "0x400629E")]
		public const short CatSword = 5224;

		// Token: 0x04005053 RID: 20563
		[global::Cpp2ILInjected.Token(Token = "0x400629F")]
		public const short KargohsSummon = 5225;

		// Token: 0x04005054 RID: 20564
		[global::Cpp2ILInjected.Token(Token = "0x40062A0")]
		public const short HighPitch = 5226;

		// Token: 0x04005055 RID: 20565
		[global::Cpp2ILInjected.Token(Token = "0x40062A1")]
		public const short AMachineforTerrarians = 5227;

		// Token: 0x04005056 RID: 20566
		[global::Cpp2ILInjected.Token(Token = "0x40062A2")]
		public const short TerraBladeChronicles = 5228;

		// Token: 0x04005057 RID: 20567
		[global::Cpp2ILInjected.Token(Token = "0x40062A3")]
		public const short BennyWarhol = 5229;

		// Token: 0x04005058 RID: 20568
		[global::Cpp2ILInjected.Token(Token = "0x40062A4")]
		public const short LizardKing = 5230;

		// Token: 0x04005059 RID: 20569
		[global::Cpp2ILInjected.Token(Token = "0x40062A5")]
		public const short MySon = 5231;

		// Token: 0x0400505A RID: 20570
		[global::Cpp2ILInjected.Token(Token = "0x40062A6")]
		public const short Duality = 5232;

		// Token: 0x0400505B RID: 20571
		[global::Cpp2ILInjected.Token(Token = "0x40062A7")]
		public const short ParsecPals = 5233;

		// Token: 0x0400505C RID: 20572
		[global::Cpp2ILInjected.Token(Token = "0x40062A8")]
		public const short RemnantsofDevotion = 5234;

		// Token: 0x0400505D RID: 20573
		[global::Cpp2ILInjected.Token(Token = "0x40062A9")]
		public const short NotSoLostInParadise = 5235;

		// Token: 0x0400505E RID: 20574
		[global::Cpp2ILInjected.Token(Token = "0x40062AA")]
		public const short OcularResonance = 5236;

		// Token: 0x0400505F RID: 20575
		[global::Cpp2ILInjected.Token(Token = "0x40062AB")]
		public const short WingsofEvil = 5237;

		// Token: 0x04005060 RID: 20576
		[global::Cpp2ILInjected.Token(Token = "0x40062AC")]
		public const short Constellation = 5238;

		// Token: 0x04005061 RID: 20577
		[global::Cpp2ILInjected.Token(Token = "0x40062AD")]
		public const short Eyezorhead = 5239;

		// Token: 0x04005062 RID: 20578
		[global::Cpp2ILInjected.Token(Token = "0x40062AE")]
		public const short DreadoftheRedSea = 5240;

		// Token: 0x04005063 RID: 20579
		[global::Cpp2ILInjected.Token(Token = "0x40062AF")]
		public const short DoNotEattheVileMushroom = 5241;

		// Token: 0x04005064 RID: 20580
		[global::Cpp2ILInjected.Token(Token = "0x40062B0")]
		public const short YuumaTheBlueTiger = 5242;

		// Token: 0x04005065 RID: 20581
		[global::Cpp2ILInjected.Token(Token = "0x40062B1")]
		public const short MoonmanandCompany = 5243;

		// Token: 0x04005066 RID: 20582
		[global::Cpp2ILInjected.Token(Token = "0x40062B2")]
		public const short SunshineofIsrapony = 5244;

		// Token: 0x04005067 RID: 20583
		[global::Cpp2ILInjected.Token(Token = "0x40062B3")]
		public const short Purity = 5245;

		// Token: 0x04005068 RID: 20584
		[global::Cpp2ILInjected.Token(Token = "0x40062B4")]
		public const short SufficientlyAdvanced = 5246;

		// Token: 0x04005069 RID: 20585
		[global::Cpp2ILInjected.Token(Token = "0x40062B5")]
		public const short StrangeGrowth = 5247;

		// Token: 0x0400506A RID: 20586
		[global::Cpp2ILInjected.Token(Token = "0x40062B6")]
		public const short HappyLittleTree = 5248;

		// Token: 0x0400506B RID: 20587
		[global::Cpp2ILInjected.Token(Token = "0x40062B7")]
		public const short StrangeDeadFellows = 5249;

		// Token: 0x0400506C RID: 20588
		[global::Cpp2ILInjected.Token(Token = "0x40062B8")]
		public const short Secrets = 5250;

		// Token: 0x0400506D RID: 20589
		[global::Cpp2ILInjected.Token(Token = "0x40062B9")]
		public const short Thunderbolt = 5251;

		// Token: 0x0400506E RID: 20590
		[global::Cpp2ILInjected.Token(Token = "0x40062BA")]
		public const short Crustography = 5252;

		// Token: 0x0400506F RID: 20591
		[global::Cpp2ILInjected.Token(Token = "0x40062BB")]
		public const short TheWerewolf = 5253;

		// Token: 0x04005070 RID: 20592
		[global::Cpp2ILInjected.Token(Token = "0x40062BC")]
		public const short BlessingfromTheHeavens = 5254;

		// Token: 0x04005071 RID: 20593
		[global::Cpp2ILInjected.Token(Token = "0x40062BD")]
		public const short LoveisintheTrashSlot = 5255;

		// Token: 0x04005072 RID: 20594
		[global::Cpp2ILInjected.Token(Token = "0x40062BE")]
		public const short Fangs = 5256;

		// Token: 0x04005073 RID: 20595
		[global::Cpp2ILInjected.Token(Token = "0x40062BF")]
		public const short HailtotheKing = 5257;

		// Token: 0x04005074 RID: 20596
		[global::Cpp2ILInjected.Token(Token = "0x40062C0")]
		public const short SeeTheWorldForWhatItIs = 5258;

		// Token: 0x04005075 RID: 20597
		[global::Cpp2ILInjected.Token(Token = "0x40062C1")]
		public const short WhatLurksBelow = 5259;

		// Token: 0x04005076 RID: 20598
		[global::Cpp2ILInjected.Token(Token = "0x40062C2")]
		public const short ThisIsGettingOutOfHand = 5260;

		// Token: 0x04005077 RID: 20599
		[global::Cpp2ILInjected.Token(Token = "0x40062C3")]
		public const short Buddies = 5261;

		// Token: 0x04005078 RID: 20600
		[global::Cpp2ILInjected.Token(Token = "0x40062C4")]
		public const short MidnightSun = 5262;

		// Token: 0x04005079 RID: 20601
		[global::Cpp2ILInjected.Token(Token = "0x40062C5")]
		public const short CouchGag = 5263;

		// Token: 0x0400507A RID: 20602
		[global::Cpp2ILInjected.Token(Token = "0x40062C6")]
		public const short SilentFish = 5264;

		// Token: 0x0400507B RID: 20603
		[global::Cpp2ILInjected.Token(Token = "0x40062C7")]
		public const short TheDuke = 5265;

		// Token: 0x0400507C RID: 20604
		[global::Cpp2ILInjected.Token(Token = "0x40062C8")]
		public const short RoyalRomance = 5266;

		// Token: 0x0400507D RID: 20605
		[global::Cpp2ILInjected.Token(Token = "0x40062C9")]
		public const short Bioluminescence = 5267;

		// Token: 0x0400507E RID: 20606
		[global::Cpp2ILInjected.Token(Token = "0x40062CA")]
		public const short Wildflowers = 5268;

		// Token: 0x0400507F RID: 20607
		[global::Cpp2ILInjected.Token(Token = "0x40062CB")]
		public const short VikingVoyage = 5269;

		// Token: 0x04005080 RID: 20608
		[global::Cpp2ILInjected.Token(Token = "0x40062CC")]
		public const short Bifrost = 5270;

		// Token: 0x04005081 RID: 20609
		[global::Cpp2ILInjected.Token(Token = "0x40062CD")]
		public const short Heartlands = 5271;

		// Token: 0x04005082 RID: 20610
		[global::Cpp2ILInjected.Token(Token = "0x40062CE")]
		public const short ForestTroll = 5272;

		// Token: 0x04005083 RID: 20611
		[global::Cpp2ILInjected.Token(Token = "0x40062CF")]
		public const short AuroraBorealis = 5273;

		// Token: 0x04005084 RID: 20612
		[global::Cpp2ILInjected.Token(Token = "0x40062D0")]
		public const short LadyOfTheLake = 5274;

		// Token: 0x04005085 RID: 20613
		[global::Cpp2ILInjected.Token(Token = "0x40062D1")]
		public const short JojaCola = 5275;

		// Token: 0x04005086 RID: 20614
		[global::Cpp2ILInjected.Token(Token = "0x40062D2")]
		public const short JunimoPetItem = 5276;

		// Token: 0x04005087 RID: 20615
		[global::Cpp2ILInjected.Token(Token = "0x40062D3")]
		public const short SpicyPepper = 5277;

		// Token: 0x04005088 RID: 20616
		[global::Cpp2ILInjected.Token(Token = "0x40062D4")]
		public const short Pomegranate = 5278;

		// Token: 0x04005089 RID: 20617
		[global::Cpp2ILInjected.Token(Token = "0x40062D5")]
		public const short AshWoodHelmet = 5279;

		// Token: 0x0400508A RID: 20618
		[global::Cpp2ILInjected.Token(Token = "0x40062D6")]
		public const short AshWoodBreastplate = 5280;

		// Token: 0x0400508B RID: 20619
		[global::Cpp2ILInjected.Token(Token = "0x40062D7")]
		public const short AshWoodGreaves = 5281;

		// Token: 0x0400508C RID: 20620
		[global::Cpp2ILInjected.Token(Token = "0x40062D8")]
		public const short AshWoodBow = 5282;

		// Token: 0x0400508D RID: 20621
		[global::Cpp2ILInjected.Token(Token = "0x40062D9")]
		public const short AshWoodHammer = 5283;

		// Token: 0x0400508E RID: 20622
		[global::Cpp2ILInjected.Token(Token = "0x40062DA")]
		public const short AshWoodSword = 5284;

		// Token: 0x0400508F RID: 20623
		[global::Cpp2ILInjected.Token(Token = "0x40062DB")]
		public const short MoonGlobe = 5285;

		// Token: 0x04005090 RID: 20624
		[global::Cpp2ILInjected.Token(Token = "0x40062DC")]
		public const short RepairedLifeCrystal = 5286;

		// Token: 0x04005091 RID: 20625
		[global::Cpp2ILInjected.Token(Token = "0x40062DD")]
		public const short RepairedManaCrystal = 5287;

		// Token: 0x04005092 RID: 20626
		[global::Cpp2ILInjected.Token(Token = "0x40062DE")]
		public const short TerraFartMinecart = 5288;

		// Token: 0x04005093 RID: 20627
		[global::Cpp2ILInjected.Token(Token = "0x40062DF")]
		public const short MinecartPowerup = 5289;

		// Token: 0x04005094 RID: 20628
		[global::Cpp2ILInjected.Token(Token = "0x40062E0")]
		public const short JimsCap = 5290;

		// Token: 0x04005095 RID: 20629
		[global::Cpp2ILInjected.Token(Token = "0x40062E1")]
		public const short EchoWall = 5291;

		// Token: 0x04005096 RID: 20630
		[global::Cpp2ILInjected.Token(Token = "0x40062E2")]
		public const short EchoPlatform = 5292;

		// Token: 0x04005097 RID: 20631
		[global::Cpp2ILInjected.Token(Token = "0x40062E3")]
		public const short MushroomTorch = 5293;

		// Token: 0x04005098 RID: 20632
		[global::Cpp2ILInjected.Token(Token = "0x40062E4")]
		public const short HiveFive = 5294;

		// Token: 0x04005099 RID: 20633
		[global::Cpp2ILInjected.Token(Token = "0x40062E5")]
		public const short AcornAxe = 5295;

		// Token: 0x0400509A RID: 20634
		[global::Cpp2ILInjected.Token(Token = "0x40062E6")]
		public const short ChlorophyteExtractinator = 5296;

		// Token: 0x0400509B RID: 20635
		[global::Cpp2ILInjected.Token(Token = "0x40062E7")]
		public const short BlueEgg = 5297;

		// Token: 0x0400509C RID: 20636
		[global::Cpp2ILInjected.Token(Token = "0x40062E8")]
		public const short Trimarang = 5298;

		// Token: 0x0400509D RID: 20637
		[global::Cpp2ILInjected.Token(Token = "0x40062E9")]
		public const short MushroomCampfire = 5299;

		// Token: 0x0400509E RID: 20638
		[global::Cpp2ILInjected.Token(Token = "0x40062EA")]
		public const short BlueMacaw = 5300;

		// Token: 0x0400509F RID: 20639
		[global::Cpp2ILInjected.Token(Token = "0x40062EB")]
		public const short BlueMacawCage = 5301;

		// Token: 0x040050A0 RID: 20640
		[global::Cpp2ILInjected.Token(Token = "0x40062EC")]
		public const short BottomlessHoneyBucket = 5302;

		// Token: 0x040050A1 RID: 20641
		[global::Cpp2ILInjected.Token(Token = "0x40062ED")]
		public const short HoneyAbsorbantSponge = 5303;

		// Token: 0x040050A2 RID: 20642
		[global::Cpp2ILInjected.Token(Token = "0x40062EE")]
		public const short UltraAbsorbantSponge = 5304;

		// Token: 0x040050A3 RID: 20643
		[global::Cpp2ILInjected.Token(Token = "0x40062EF")]
		public const short GoblorcEar = 5305;

		// Token: 0x040050A4 RID: 20644
		[global::Cpp2ILInjected.Token(Token = "0x40062F0")]
		public const short ReefBlock = 5306;

		// Token: 0x040050A5 RID: 20645
		[global::Cpp2ILInjected.Token(Token = "0x40062F1")]
		public const short ReefWall = 5307;

		// Token: 0x040050A6 RID: 20646
		[global::Cpp2ILInjected.Token(Token = "0x40062F2")]
		public const short PlacePainting = 5308;

		// Token: 0x040050A7 RID: 20647
		[global::Cpp2ILInjected.Token(Token = "0x40062F3")]
		public const short DontHurtNatureBook = 5309;

		// Token: 0x040050A8 RID: 20648
		[global::Cpp2ILInjected.Token(Token = "0x40062F4")]
		public const short PrincessStyle = 5310;

		// Token: 0x040050A9 RID: 20649
		[global::Cpp2ILInjected.Token(Token = "0x40062F5")]
		public const short Toucan = 5311;

		// Token: 0x040050AA RID: 20650
		[global::Cpp2ILInjected.Token(Token = "0x40062F6")]
		public const short YellowCockatiel = 5312;

		// Token: 0x040050AB RID: 20651
		[global::Cpp2ILInjected.Token(Token = "0x40062F7")]
		public const short GrayCockatiel = 5313;

		// Token: 0x040050AC RID: 20652
		[global::Cpp2ILInjected.Token(Token = "0x40062F8")]
		public const short ToucanCage = 5314;

		// Token: 0x040050AD RID: 20653
		[global::Cpp2ILInjected.Token(Token = "0x40062F9")]
		public const short YellowCockatielCage = 5315;

		// Token: 0x040050AE RID: 20654
		[global::Cpp2ILInjected.Token(Token = "0x40062FA")]
		public const short GrayCockatielCage = 5316;

		// Token: 0x040050AF RID: 20655
		[global::Cpp2ILInjected.Token(Token = "0x40062FB")]
		public const short MacawStatue = 5317;

		// Token: 0x040050B0 RID: 20656
		[global::Cpp2ILInjected.Token(Token = "0x40062FC")]
		public const short ToucanStatue = 5318;

		// Token: 0x040050B1 RID: 20657
		[global::Cpp2ILInjected.Token(Token = "0x40062FD")]
		public const short CockatielStatue = 5319;

		// Token: 0x040050B2 RID: 20658
		[global::Cpp2ILInjected.Token(Token = "0x40062FE")]
		public const short PlaceableHealingPotion = 5320;

		// Token: 0x040050B3 RID: 20659
		[global::Cpp2ILInjected.Token(Token = "0x40062FF")]
		public const short PlaceableManaPotion = 5321;

		// Token: 0x040050B4 RID: 20660
		[global::Cpp2ILInjected.Token(Token = "0x4006300")]
		public const short ShadowCandle = 5322;

		// Token: 0x040050B5 RID: 20661
		[global::Cpp2ILInjected.Token(Token = "0x4006301")]
		public const short DontHurtComboBook = 5323;

		// Token: 0x040050B6 RID: 20662
		[global::Cpp2ILInjected.Token(Token = "0x4006302")]
		public const short RubblemakerSmall = 5324;

		// Token: 0x040050B7 RID: 20663
		[global::Cpp2ILInjected.Token(Token = "0x4006303")]
		public const short ClosedVoidBag = 5325;

		// Token: 0x040050B8 RID: 20664
		[global::Cpp2ILInjected.Token(Token = "0x4006304")]
		public const short ArtisanLoaf = 5326;

		// Token: 0x040050B9 RID: 20665
		[global::Cpp2ILInjected.Token(Token = "0x4006305")]
		public const short TNTBarrel = 5327;

		// Token: 0x040050BA RID: 20666
		[global::Cpp2ILInjected.Token(Token = "0x4006306")]
		public const short ChestLock = 5328;

		// Token: 0x040050BB RID: 20667
		[global::Cpp2ILInjected.Token(Token = "0x4006307")]
		public const short RubblemakerMedium = 5329;

		// Token: 0x040050BC RID: 20668
		[global::Cpp2ILInjected.Token(Token = "0x4006308")]
		public const short RubblemakerLarge = 5330;

		// Token: 0x040050BD RID: 20669
		[global::Cpp2ILInjected.Token(Token = "0x4006309")]
		public const short HorseshoeBundle = 5331;

		// Token: 0x040050BE RID: 20670
		[global::Cpp2ILInjected.Token(Token = "0x400630A")]
		public const short SpiffoPlush = 5332;

		// Token: 0x040050BF RID: 20671
		[global::Cpp2ILInjected.Token(Token = "0x400630B")]
		public const short GlowTulip = 5333;

		// Token: 0x040050C0 RID: 20672
		[global::Cpp2ILInjected.Token(Token = "0x400630C")]
		public const short MechdusaSummon = 5334;

		// Token: 0x040050C1 RID: 20673
		[global::Cpp2ILInjected.Token(Token = "0x400630D")]
		public const short RodOfHarmony = 5335;

		// Token: 0x040050C2 RID: 20674
		[global::Cpp2ILInjected.Token(Token = "0x400630E")]
		public const short CombatBookVolumeTwo = 5336;

		// Token: 0x040050C3 RID: 20675
		[global::Cpp2ILInjected.Token(Token = "0x400630F")]
		public const short AegisCrystal = 5337;

		// Token: 0x040050C4 RID: 20676
		[global::Cpp2ILInjected.Token(Token = "0x4006310")]
		public const short AegisFruit = 5338;

		// Token: 0x040050C5 RID: 20677
		[global::Cpp2ILInjected.Token(Token = "0x4006311")]
		public const short ArcaneCrystal = 5339;

		// Token: 0x040050C6 RID: 20678
		[global::Cpp2ILInjected.Token(Token = "0x4006312")]
		public const short GalaxyPearl = 5340;

		// Token: 0x040050C7 RID: 20679
		[global::Cpp2ILInjected.Token(Token = "0x4006313")]
		public const short GummyWorm = 5341;

		// Token: 0x040050C8 RID: 20680
		[global::Cpp2ILInjected.Token(Token = "0x4006314")]
		public const short Ambrosia = 5342;

		// Token: 0x040050C9 RID: 20681
		[global::Cpp2ILInjected.Token(Token = "0x4006315")]
		public const short PeddlersSatchel = 5343;

		// Token: 0x040050CA RID: 20682
		[global::Cpp2ILInjected.Token(Token = "0x4006316")]
		public const short EchoCoating = 5344;

		// Token: 0x040050CB RID: 20683
		[global::Cpp2ILInjected.Token(Token = "0x4006317")]
		public const short EchoMonolith = 5345;

		// Token: 0x040050CC RID: 20684
		[global::Cpp2ILInjected.Token(Token = "0x4006318")]
		public const short GasTrap = 5346;

		// Token: 0x040050CD RID: 20685
		[global::Cpp2ILInjected.Token(Token = "0x4006319")]
		public const short ShimmerMonolith = 5347;

		// Token: 0x040050CE RID: 20686
		[global::Cpp2ILInjected.Token(Token = "0x400631A")]
		public const short ShimmerArrow = 5348;

		// Token: 0x040050CF RID: 20687
		[global::Cpp2ILInjected.Token(Token = "0x400631B")]
		public const short ShimmerBlock = 5349;

		// Token: 0x040050D0 RID: 20688
		[global::Cpp2ILInjected.Token(Token = "0x400631C")]
		public const short Shimmerfly = 5350;

		// Token: 0x040050D1 RID: 20689
		[global::Cpp2ILInjected.Token(Token = "0x400631D")]
		public const short ShimmerflyinaBottle = 5351;

		// Token: 0x040050D2 RID: 20690
		[global::Cpp2ILInjected.Token(Token = "0x400631E")]
		public const short ShimmerSlimeBanner = 5352;

		// Token: 0x040050D3 RID: 20691
		[global::Cpp2ILInjected.Token(Token = "0x400631F")]
		public const short ShimmerTorch = 5353;

		// Token: 0x040050D4 RID: 20692
		[global::Cpp2ILInjected.Token(Token = "0x4006320")]
		public const short ReflectiveShades = 5354;

		// Token: 0x040050D5 RID: 20693
		[global::Cpp2ILInjected.Token(Token = "0x4006321")]
		public const short ShimmerCloak = 5355;

		// Token: 0x040050D6 RID: 20694
		[global::Cpp2ILInjected.Token(Token = "0x4006322")]
		public const short UsedGasTrap = 5356;

		// Token: 0x040050D7 RID: 20695
		[global::Cpp2ILInjected.Token(Token = "0x4006323")]
		public const short ShimmerCampfire = 5357;

		// Token: 0x040050D8 RID: 20696
		[global::Cpp2ILInjected.Token(Token = "0x4006324")]
		public const short Shellphone = 5358;

		// Token: 0x040050D9 RID: 20697
		[global::Cpp2ILInjected.Token(Token = "0x4006325")]
		public const short ShellphoneSpawn = 5359;

		// Token: 0x040050DA RID: 20698
		[global::Cpp2ILInjected.Token(Token = "0x4006326")]
		public const short ShellphoneOcean = 5360;

		// Token: 0x040050DB RID: 20699
		[global::Cpp2ILInjected.Token(Token = "0x4006327")]
		public const short ShellphoneHell = 5361;

		// Token: 0x040050DC RID: 20700
		[global::Cpp2ILInjected.Token(Token = "0x4006328")]
		public const short MusicBoxShimmer = 5362;

		// Token: 0x040050DD RID: 20701
		[global::Cpp2ILInjected.Token(Token = "0x4006329")]
		public const short SpiderWallUnsafe = 5363;

		// Token: 0x040050DE RID: 20702
		[global::Cpp2ILInjected.Token(Token = "0x400632A")]
		public const short BottomlessShimmerBucket = 5364;

		// Token: 0x040050DF RID: 20703
		[global::Cpp2ILInjected.Token(Token = "0x400632B")]
		public const short BlueBrickWallUnsafe = 5365;

		// Token: 0x040050E0 RID: 20704
		[global::Cpp2ILInjected.Token(Token = "0x400632C")]
		public const short BlueSlabWallUnsafe = 5366;

		// Token: 0x040050E1 RID: 20705
		[global::Cpp2ILInjected.Token(Token = "0x400632D")]
		public const short BlueTiledWallUnsafe = 5367;

		// Token: 0x040050E2 RID: 20706
		[global::Cpp2ILInjected.Token(Token = "0x400632E")]
		public const short PinkBrickWallUnsafe = 5368;

		// Token: 0x040050E3 RID: 20707
		[global::Cpp2ILInjected.Token(Token = "0x400632F")]
		public const short PinkSlabWallUnsafe = 5369;

		// Token: 0x040050E4 RID: 20708
		[global::Cpp2ILInjected.Token(Token = "0x4006330")]
		public const short PinkTiledWallUnsafe = 5370;

		// Token: 0x040050E5 RID: 20709
		[global::Cpp2ILInjected.Token(Token = "0x4006331")]
		public const short GreenBrickWallUnsafe = 5371;

		// Token: 0x040050E6 RID: 20710
		[global::Cpp2ILInjected.Token(Token = "0x4006332")]
		public const short GreenSlabWallUnsafe = 5372;

		// Token: 0x040050E7 RID: 20711
		[global::Cpp2ILInjected.Token(Token = "0x4006333")]
		public const short GreenTiledWallUnsafe = 5373;

		// Token: 0x040050E8 RID: 20712
		[global::Cpp2ILInjected.Token(Token = "0x4006334")]
		public const short SandstoneWallUnsafe = 5374;

		// Token: 0x040050E9 RID: 20713
		[global::Cpp2ILInjected.Token(Token = "0x4006335")]
		public const short HardenedSandWallUnsafe = 5375;

		// Token: 0x040050EA RID: 20714
		[global::Cpp2ILInjected.Token(Token = "0x4006336")]
		public const short LihzahrdWallUnsafe = 5376;

		// Token: 0x040050EB RID: 20715
		[global::Cpp2ILInjected.Token(Token = "0x4006337")]
		public const short SpelunkerFlare = 5377;

		// Token: 0x040050EC RID: 20716
		[global::Cpp2ILInjected.Token(Token = "0x4006338")]
		public const short CursedFlare = 5378;

		// Token: 0x040050ED RID: 20717
		[global::Cpp2ILInjected.Token(Token = "0x4006339")]
		public const short RainbowFlare = 5379;

		// Token: 0x040050EE RID: 20718
		[global::Cpp2ILInjected.Token(Token = "0x400633A")]
		public const short ShimmerFlare = 5380;

		// Token: 0x040050EF RID: 20719
		[global::Cpp2ILInjected.Token(Token = "0x400633B")]
		public const short Moondial = 5381;

		// Token: 0x040050F0 RID: 20720
		[global::Cpp2ILInjected.Token(Token = "0x400633C")]
		public const short WaffleIron = 5382;

		// Token: 0x040050F1 RID: 20721
		[global::Cpp2ILInjected.Token(Token = "0x400633D")]
		public const short BouncyBoulder = 5383;

		// Token: 0x040050F2 RID: 20722
		[global::Cpp2ILInjected.Token(Token = "0x400633E")]
		public const short LifeCrystalBoulder = 5384;

		// Token: 0x040050F3 RID: 20723
		[global::Cpp2ILInjected.Token(Token = "0x400633F")]
		public const short DizzyHat = 5385;

		// Token: 0x040050F4 RID: 20724
		[global::Cpp2ILInjected.Token(Token = "0x4006340")]
		public const short LincolnsHoodie = 5386;

		// Token: 0x040050F5 RID: 20725
		[global::Cpp2ILInjected.Token(Token = "0x4006341")]
		public const short LincolnsPants = 5387;

		// Token: 0x040050F6 RID: 20726
		[global::Cpp2ILInjected.Token(Token = "0x4006342")]
		public const short SunOrnament = 5388;

		// Token: 0x040050F7 RID: 20727
		[global::Cpp2ILInjected.Token(Token = "0x4006343")]
		public const short HoplitePizza = 5389;

		// Token: 0x040050F8 RID: 20728
		[global::Cpp2ILInjected.Token(Token = "0x4006344")]
		public const short LincolnsHood = 5390;

		// Token: 0x040050F9 RID: 20729
		[global::Cpp2ILInjected.Token(Token = "0x4006345")]
		public const short UncumberingStone = 5391;

		// Token: 0x040050FA RID: 20730
		[global::Cpp2ILInjected.Token(Token = "0x4006346")]
		public const short SandSolution = 5392;

		// Token: 0x040050FB RID: 20731
		[global::Cpp2ILInjected.Token(Token = "0x4006347")]
		public const short SnowSolution = 5393;

		// Token: 0x040050FC RID: 20732
		[global::Cpp2ILInjected.Token(Token = "0x4006348")]
		public const short DirtSolution = 5394;

		// Token: 0x040050FD RID: 20733
		[global::Cpp2ILInjected.Token(Token = "0x4006349")]
		public const short PoopBlock = 5395;

		// Token: 0x040050FE RID: 20734
		[global::Cpp2ILInjected.Token(Token = "0x400634A")]
		public const short PoopWall = 5396;

		// Token: 0x040050FF RID: 20735
		[global::Cpp2ILInjected.Token(Token = "0x400634B")]
		public const short ShimmerWall = 5397;

		// Token: 0x04005100 RID: 20736
		[global::Cpp2ILInjected.Token(Token = "0x400634C")]
		public const short ShimmerBrick = 5398;

		// Token: 0x04005101 RID: 20737
		[global::Cpp2ILInjected.Token(Token = "0x400634D")]
		public const short ShimmerBrickWall = 5399;

		// Token: 0x04005102 RID: 20738
		[global::Cpp2ILInjected.Token(Token = "0x400634E")]
		public const short DirtiestBlock = 5400;

		// Token: 0x04005103 RID: 20739
		[global::Cpp2ILInjected.Token(Token = "0x400634F")]
		public const short LunarRustBrick = 5401;

		// Token: 0x04005104 RID: 20740
		[global::Cpp2ILInjected.Token(Token = "0x4006350")]
		public const short DarkCelestialBrick = 5402;

		// Token: 0x04005105 RID: 20741
		[global::Cpp2ILInjected.Token(Token = "0x4006351")]
		public const short AstraBrick = 5403;

		// Token: 0x04005106 RID: 20742
		[global::Cpp2ILInjected.Token(Token = "0x4006352")]
		public const short CosmicEmberBrick = 5404;

		// Token: 0x04005107 RID: 20743
		[global::Cpp2ILInjected.Token(Token = "0x4006353")]
		public const short CryocoreBrick = 5405;

		// Token: 0x04005108 RID: 20744
		[global::Cpp2ILInjected.Token(Token = "0x4006354")]
		public const short MercuryBrick = 5406;

		// Token: 0x04005109 RID: 20745
		[global::Cpp2ILInjected.Token(Token = "0x4006355")]
		public const short StarRoyaleBrick = 5407;

		// Token: 0x0400510A RID: 20746
		[global::Cpp2ILInjected.Token(Token = "0x4006356")]
		public const short HeavenforgeBrick = 5408;

		// Token: 0x0400510B RID: 20747
		[global::Cpp2ILInjected.Token(Token = "0x4006357")]
		public const short LunarRustBrickWall = 5409;

		// Token: 0x0400510C RID: 20748
		[global::Cpp2ILInjected.Token(Token = "0x4006358")]
		public const short DarkCelestialBrickWall = 5410;

		// Token: 0x0400510D RID: 20749
		[global::Cpp2ILInjected.Token(Token = "0x4006359")]
		public const short AstraBrickWall = 5411;

		// Token: 0x0400510E RID: 20750
		[global::Cpp2ILInjected.Token(Token = "0x400635A")]
		public const short CosmicEmberBrickWall = 5412;

		// Token: 0x0400510F RID: 20751
		[global::Cpp2ILInjected.Token(Token = "0x400635B")]
		public const short CryocoreBrickWall = 5413;

		// Token: 0x04005110 RID: 20752
		[global::Cpp2ILInjected.Token(Token = "0x400635C")]
		public const short MercuryBrickWall = 5414;

		// Token: 0x04005111 RID: 20753
		[global::Cpp2ILInjected.Token(Token = "0x400635D")]
		public const short StarRoyaleBrickWall = 5415;

		// Token: 0x04005112 RID: 20754
		[global::Cpp2ILInjected.Token(Token = "0x400635E")]
		public const short HeavenforgeBrickWall = 5416;

		// Token: 0x04005113 RID: 20755
		[global::Cpp2ILInjected.Token(Token = "0x400635F")]
		public const short AncientBlueDungeonBrick = 5417;

		// Token: 0x04005114 RID: 20756
		[global::Cpp2ILInjected.Token(Token = "0x4006360")]
		public const short AncientBlueDungeonBrickWall = 5418;

		// Token: 0x04005115 RID: 20757
		[global::Cpp2ILInjected.Token(Token = "0x4006361")]
		public const short AncientGreenDungeonBrick = 5419;

		// Token: 0x04005116 RID: 20758
		[global::Cpp2ILInjected.Token(Token = "0x4006362")]
		public const short AncientGreenDungeonBrickWall = 5420;

		// Token: 0x04005117 RID: 20759
		[global::Cpp2ILInjected.Token(Token = "0x4006363")]
		public const short AncientPinkDungeonBrick = 5421;

		// Token: 0x04005118 RID: 20760
		[global::Cpp2ILInjected.Token(Token = "0x4006364")]
		public const short AncientPinkDungeonBrickWall = 5422;

		// Token: 0x04005119 RID: 20761
		[global::Cpp2ILInjected.Token(Token = "0x4006365")]
		public const short AncientGoldBrick = 5423;

		// Token: 0x0400511A RID: 20762
		[global::Cpp2ILInjected.Token(Token = "0x4006366")]
		public const short AncientGoldBrickWall = 5424;

		// Token: 0x0400511B RID: 20763
		[global::Cpp2ILInjected.Token(Token = "0x4006367")]
		public const short AncientSilverBrick = 5425;

		// Token: 0x0400511C RID: 20764
		[global::Cpp2ILInjected.Token(Token = "0x4006368")]
		public const short AncientSilverBrickWall = 5426;

		// Token: 0x0400511D RID: 20765
		[global::Cpp2ILInjected.Token(Token = "0x4006369")]
		public const short AncientCopperBrick = 5427;

		// Token: 0x0400511E RID: 20766
		[global::Cpp2ILInjected.Token(Token = "0x400636A")]
		public const short AncientCopperBrickWall = 5428;

		// Token: 0x0400511F RID: 20767
		[global::Cpp2ILInjected.Token(Token = "0x400636B")]
		public const short AncientCobaltBrick = 5429;

		// Token: 0x04005120 RID: 20768
		[global::Cpp2ILInjected.Token(Token = "0x400636C")]
		public const short AncientCobaltBrickWall = 5430;

		// Token: 0x04005121 RID: 20769
		[global::Cpp2ILInjected.Token(Token = "0x400636D")]
		public const short AncientMythrilBrick = 5431;

		// Token: 0x04005122 RID: 20770
		[global::Cpp2ILInjected.Token(Token = "0x400636E")]
		public const short AncientMythrilBrickWall = 5432;

		// Token: 0x04005123 RID: 20771
		[global::Cpp2ILInjected.Token(Token = "0x400636F")]
		public const short AncientObsidianBrick = 5433;

		// Token: 0x04005124 RID: 20772
		[global::Cpp2ILInjected.Token(Token = "0x4006370")]
		public const short AncientObsidianBrickWall = 5434;

		// Token: 0x04005125 RID: 20773
		[global::Cpp2ILInjected.Token(Token = "0x4006371")]
		public const short AncientHellstoneBrick = 5435;

		// Token: 0x04005126 RID: 20774
		[global::Cpp2ILInjected.Token(Token = "0x4006372")]
		public const short AncientHellstoneBrickWall = 5436;

		// Token: 0x04005127 RID: 20775
		[global::Cpp2ILInjected.Token(Token = "0x4006373")]
		public const short ShellphoneDummy = 5437;

		// Token: 0x04005128 RID: 20776
		[global::Cpp2ILInjected.Token(Token = "0x4006374")]
		public const short Fertilizer = 5438;

		// Token: 0x04005129 RID: 20777
		[global::Cpp2ILInjected.Token(Token = "0x4006375")]
		public const short LavaMossBlock = 5439;

		// Token: 0x0400512A RID: 20778
		[global::Cpp2ILInjected.Token(Token = "0x4006376")]
		public const short ArgonMossBlock = 5440;

		// Token: 0x0400512B RID: 20779
		[global::Cpp2ILInjected.Token(Token = "0x4006377")]
		public const short KryptonMossBlock = 5441;

		// Token: 0x0400512C RID: 20780
		[global::Cpp2ILInjected.Token(Token = "0x4006378")]
		public const short XenonMossBlock = 5442;

		// Token: 0x0400512D RID: 20781
		[global::Cpp2ILInjected.Token(Token = "0x4006379")]
		public const short VioletMossBlock = 5443;

		// Token: 0x0400512E RID: 20782
		[global::Cpp2ILInjected.Token(Token = "0x400637A")]
		public const short RainbowMossBlock = 5444;

		// Token: 0x0400512F RID: 20783
		[global::Cpp2ILInjected.Token(Token = "0x400637B")]
		public const short LavaMossBlockWall = 5445;

		// Token: 0x04005130 RID: 20784
		[global::Cpp2ILInjected.Token(Token = "0x400637C")]
		public const short ArgonMossBlockWall = 5446;

		// Token: 0x04005131 RID: 20785
		[global::Cpp2ILInjected.Token(Token = "0x400637D")]
		public const short KryptonMossBlockWall = 5447;

		// Token: 0x04005132 RID: 20786
		[global::Cpp2ILInjected.Token(Token = "0x400637E")]
		public const short XenonMossBlockWall = 5448;

		// Token: 0x04005133 RID: 20787
		[global::Cpp2ILInjected.Token(Token = "0x400637F")]
		public const short VioletMossBlockWall = 5449;

		// Token: 0x04005134 RID: 20788
		[global::Cpp2ILInjected.Token(Token = "0x4006380")]
		public const short RainbowMossBlockWall = 5450;

		// Token: 0x04005135 RID: 20789
		[global::Cpp2ILInjected.Token(Token = "0x4006381")]
		public const short JimsDrone = 5451;

		// Token: 0x04005136 RID: 20790
		[global::Cpp2ILInjected.Token(Token = "0x4006382")]
		public const short JimsDroneVisor = 5452;

		// Token: 0x04005137 RID: 20791
		[global::Cpp2ILInjected.Token(Token = "0x4006383")]
		public const short DontHurtCrittersBookInactive = 5453;

		// Token: 0x04005138 RID: 20792
		[global::Cpp2ILInjected.Token(Token = "0x4006384")]
		public const short DontHurtNatureBookInactive = 5454;

		// Token: 0x04005139 RID: 20793
		[global::Cpp2ILInjected.Token(Token = "0x4006385")]
		public const short DontHurtComboBookInactive = 5455;

		// Token: 0x0400513A RID: 20794
		[global::Cpp2ILInjected.Token(Token = "0x4006386")]
		public const short Count = 5456;

		// Token: 0x0400513B RID: 20795
		[global::Cpp2ILInjected.Token(Token = "0x4006387")]
		public static readonly IdDictionary Search;

		// Token: 0x0200091E RID: 2334
		[global::Cpp2ILInjected.Token(Token = "0x20005D2")]
		public struct BannerEffect
		{
			// Token: 0x06004C72 RID: 19570 RVA: 0x0002F87F File Offset: 0x0002DA7F
			[global::Cpp2ILInjected.Token(Token = "0x6003554")]
			[global::Cpp2ILInjected.Address(RVA = "0x13953A8", Offset = "0x13953A8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public BannerEffect(float strength = 1f)
			{
				throw null;
			}

			// Token: 0x06004C73 RID: 19571 RVA: 0x0002F882 File Offset: 0x0002DA82
			[global::Cpp2ILInjected.Token(Token = "0x6003555")]
			[global::Cpp2ILInjected.Address(RVA = "0x13953E4", Offset = "0x13953E4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public BannerEffect(float normalDamageDealt, float expertDamageDealt, float normalDamageReceived, float expertDamageReceived)
			{
				throw null;
			}

			// Token: 0x06004C74 RID: 19572 RVA: 0x0002F885 File Offset: 0x0002DA85
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003556")]
			[global::Cpp2ILInjected.Address(RVA = "0x13953F8", Offset = "0x13953F8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static BannerEffect()
			{
				throw null;
			}

			// Token: 0x0400896B RID: 35179
			[global::Cpp2ILInjected.Token(Token = "0x4006388")]
			public static readonly ItemID.BannerEffect None;

			// Token: 0x0400896C RID: 35180
			[global::Cpp2ILInjected.Token(Token = "0x4006389")]
			public static readonly ItemID.BannerEffect Reduced;

			// Token: 0x0400896D RID: 35181
			[global::Cpp2ILInjected.Token(Token = "0x400638A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly float NormalDamageDealt;

			// Token: 0x0400896E RID: 35182
			[global::Cpp2ILInjected.Token(Token = "0x400638B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly float ExpertDamageDealt;

			// Token: 0x0400896F RID: 35183
			[global::Cpp2ILInjected.Token(Token = "0x400638C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly float NormalDamageReceived;

			// Token: 0x04008970 RID: 35184
			[global::Cpp2ILInjected.Token(Token = "0x400638D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly float ExpertDamageReceived;

			// Token: 0x04008971 RID: 35185
			[global::Cpp2ILInjected.Token(Token = "0x400638E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly bool Enabled;
		}

		// Token: 0x0200091F RID: 2335
		[global::Cpp2ILInjected.Token(Token = "0x20005D3")]
		public class Sets
		{
			// Token: 0x06004C75 RID: 19573 RVA: 0x0002F888 File Offset: 0x0002DA88
			[global::Cpp2ILInjected.Token(Token = "0x6003557")]
			[global::Cpp2ILInjected.Address(RVA = "0x139546C", Offset = "0x139546C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			// Token: 0x06004C76 RID: 19574 RVA: 0x0002F88B File Offset: 0x0002DA8B
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003558")]
			[global::Cpp2ILInjected.Address(RVA = "0x1395474", Offset = "0x1395474", Length = "0xCB5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int[])
			}, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int[])
			}, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateCustomSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T",
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlowerPacketInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(object),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateFloatSet", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float[])
			}, ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(ItemID.BannerEffect) }, MemberParameters = new object[]
			{
				typeof(ItemID.BannerEffect),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(float?) }, MemberParameters = new object[]
			{
				typeof(float?),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1005)]
			static Sets()
			{
				throw null;
			}

			// Token: 0x04008972 RID: 35186
			[global::Cpp2ILInjected.Token(Token = "0x400638F")]
			public static SetFactory Factory;

			// Token: 0x04008973 RID: 35187
			[global::Cpp2ILInjected.Token(Token = "0x4006390")]
			public static List<int> ItemsThatAreProcessedAfterNormalContentSample;

			// Token: 0x04008974 RID: 35188
			[global::Cpp2ILInjected.Token(Token = "0x4006391")]
			public static bool[] IsLavaImmuneRegardlessOfRarity;

			// Token: 0x04008975 RID: 35189
			[global::Cpp2ILInjected.Token(Token = "0x4006392")]
			public static bool[] ItemsThatAllowRepeatedRightClick;

			// Token: 0x04008976 RID: 35190
			[global::Cpp2ILInjected.Token(Token = "0x4006393")]
			public static bool[] ItemsThatCountAsBombsForDemolitionistToSpawn;

			// Token: 0x04008977 RID: 35191
			[global::Cpp2ILInjected.Token(Token = "0x4006394")]
			public static bool[] ItemsThatShouldNotBeInInventory;

			// Token: 0x04008978 RID: 35192
			[global::Cpp2ILInjected.Token(Token = "0x4006395")]
			public static bool[] DrawUnsafeIndicator;

			// Token: 0x04008979 RID: 35193
			[global::Cpp2ILInjected.Token(Token = "0x4006396")]
			public static bool[] UsesBetterMeleeItemLocation;

			// Token: 0x0400897A RID: 35194
			[global::Cpp2ILInjected.Token(Token = "0x4006397")]
			public static bool[] WorksInVoidBag;

			// Token: 0x0400897B RID: 35195
			[global::Cpp2ILInjected.Token(Token = "0x4006398")]
			public static bool[] GrassSeeds;

			// Token: 0x0400897C RID: 35196
			[global::Cpp2ILInjected.Token(Token = "0x4006399")]
			public static int[] ShimmerTransformToItem;

			// Token: 0x0400897D RID: 35197
			[global::Cpp2ILInjected.Token(Token = "0x400639A")]
			public static int[] ShimmerCountsAsItem;

			// Token: 0x0400897E RID: 35198
			[global::Cpp2ILInjected.Token(Token = "0x400639B")]
			public static int[] OverflowProtectionTimeOffset;

			// Token: 0x0400897F RID: 35199
			[global::Cpp2ILInjected.Token(Token = "0x400639C")]
			public static int[] ItemsForStuffCannon;

			// Token: 0x04008980 RID: 35200
			[global::Cpp2ILInjected.Token(Token = "0x400639D")]
			public static bool?[] CanBeQuickusedOnGamepad;

			// Token: 0x04008981 RID: 35201
			[global::Cpp2ILInjected.Token(Token = "0x400639E")]
			public static bool?[] ForcesBreaksSleeping;

			// Token: 0x04008982 RID: 35202
			[global::Cpp2ILInjected.Token(Token = "0x400639F")]
			public static bool[] SkipsInitialUseSound;

			// Token: 0x04008983 RID: 35203
			[global::Cpp2ILInjected.Token(Token = "0x40063A0")]
			public static bool[] UsesCursedByPlanteraTooltip;

			// Token: 0x04008984 RID: 35204
			[global::Cpp2ILInjected.Token(Token = "0x40063A1")]
			public static bool[] IsAKite;

			// Token: 0x04008985 RID: 35205
			[global::Cpp2ILInjected.Token(Token = "0x40063A2")]
			public static bool?[] ForceConsumption;

			// Token: 0x04008986 RID: 35206
			[global::Cpp2ILInjected.Token(Token = "0x40063A3")]
			public static bool[] HasAProjectileThatHasAUsabilityCheck;

			// Token: 0x04008987 RID: 35207
			[global::Cpp2ILInjected.Token(Token = "0x40063A4")]
			public static bool[] CanGetPrefixes;

			// Token: 0x04008988 RID: 35208
			[global::Cpp2ILInjected.Token(Token = "0x40063A5")]
			public static List<int> NonColorfulDyeItems;

			// Token: 0x04008989 RID: 35209
			[global::Cpp2ILInjected.Token(Token = "0x40063A6")]
			public static bool[] ColorfulDyeValues;

			// Token: 0x0400898A RID: 35210
			[global::Cpp2ILInjected.Token(Token = "0x40063A7")]
			public static FlowerPacketInfo[] flowerPacketInfo;

			// Token: 0x0400898B RID: 35211
			[global::Cpp2ILInjected.Token(Token = "0x40063A8")]
			public static bool[] IsAMaterial;

			// Token: 0x0400898C RID: 35212
			[global::Cpp2ILInjected.Token(Token = "0x40063A9")]
			public static int[] IsCrafted;

			// Token: 0x0400898D RID: 35213
			[global::Cpp2ILInjected.Token(Token = "0x40063AA")]
			public static int[] IsCraftedCrimson;

			// Token: 0x0400898E RID: 35214
			[global::Cpp2ILInjected.Token(Token = "0x40063AB")]
			public static int[] IsCraftedCorruption;

			// Token: 0x0400898F RID: 35215
			[global::Cpp2ILInjected.Token(Token = "0x40063AC")]
			public static bool[] IgnoresEncumberingStone;

			// Token: 0x04008990 RID: 35216
			[global::Cpp2ILInjected.Token(Token = "0x40063AD")]
			public static float[] ToolTipDamageMultiplier;

			// Token: 0x04008991 RID: 35217
			[global::Cpp2ILInjected.Token(Token = "0x40063AE")]
			public static bool[] IsAPickup;

			// Token: 0x04008992 RID: 35218
			[global::Cpp2ILInjected.Token(Token = "0x40063AF")]
			public static bool[] IsDrill;

			// Token: 0x04008993 RID: 35219
			[global::Cpp2ILInjected.Token(Token = "0x40063B0")]
			public static bool[] IsChainsaw;

			// Token: 0x04008994 RID: 35220
			[global::Cpp2ILInjected.Token(Token = "0x40063B1")]
			public static bool[] IsPaintScraper;

			// Token: 0x04008995 RID: 35221
			[global::Cpp2ILInjected.Token(Token = "0x40063B2")]
			public static bool[] SummonerWeaponThatScalesWithAttackSpeed;

			// Token: 0x04008996 RID: 35222
			[global::Cpp2ILInjected.Token(Token = "0x40063B3")]
			public static bool[] IsFood;

			// Token: 0x04008997 RID: 35223
			[global::Cpp2ILInjected.Token(Token = "0x40063B4")]
			public static Color[][] FoodParticleColors;

			// Token: 0x04008998 RID: 35224
			[global::Cpp2ILInjected.Token(Token = "0x40063B5")]
			public static Color[][] DrinkParticleColors;

			// Token: 0x04008999 RID: 35225
			[global::Cpp2ILInjected.Token(Token = "0x40063B6")]
			private static ItemID.BannerEffect DD2BannerEffect;

			// Token: 0x0400899A RID: 35226
			[global::Cpp2ILInjected.Token(Token = "0x40063B7")]
			public static ItemID.BannerEffect[] BannerStrength;

			// Token: 0x0400899B RID: 35227
			[global::Cpp2ILInjected.Token(Token = "0x40063B8")]
			public static int DefaultKillsForBannerNeeded;

			// Token: 0x0400899C RID: 35228
			[global::Cpp2ILInjected.Token(Token = "0x40063B9")]
			public static int[] KillsToBanner;

			// Token: 0x0400899D RID: 35229
			[global::Cpp2ILInjected.Token(Token = "0x40063BA")]
			public static bool[] CanFishInLava;

			// Token: 0x0400899E RID: 35230
			[global::Cpp2ILInjected.Token(Token = "0x40063BB")]
			public static bool[] IsLavaBait;

			// Token: 0x0400899F RID: 35231
			[global::Cpp2ILInjected.Token(Token = "0x40063BC")]
			private const int healingItemsDecayRate = 4;

			// Token: 0x040089A0 RID: 35232
			[global::Cpp2ILInjected.Token(Token = "0x40063BD")]
			public static int[] ItemSpawnDecaySpeed;

			// Token: 0x040089A1 RID: 35233
			[global::Cpp2ILInjected.Token(Token = "0x40063BE")]
			public static bool[] IsFishingCrate;

			// Token: 0x040089A2 RID: 35234
			[global::Cpp2ILInjected.Token(Token = "0x40063BF")]
			public static bool[] IsFishingCrateHardmode;

			// Token: 0x040089A3 RID: 35235
			[global::Cpp2ILInjected.Token(Token = "0x40063C0")]
			public static bool[] CanBePlacedOnWeaponRacks;

			// Token: 0x040089A4 RID: 35236
			[global::Cpp2ILInjected.Token(Token = "0x40063C1")]
			public static int[] TextureCopyLoad;

			// Token: 0x040089A5 RID: 35237
			[global::Cpp2ILInjected.Token(Token = "0x40063C2")]
			public static bool[] TrapSigned;

			// Token: 0x040089A6 RID: 35238
			[global::Cpp2ILInjected.Token(Token = "0x40063C3")]
			public static bool[] Deprecated;

			// Token: 0x040089A7 RID: 35239
			[global::Cpp2ILInjected.Token(Token = "0x40063C4")]
			public static bool[] NeverAppearsAsNewInInventory;

			// Token: 0x040089A8 RID: 35240
			[global::Cpp2ILInjected.Token(Token = "0x40063C5")]
			public static bool[] CommonCoin;

			// Token: 0x040089A9 RID: 35241
			[global::Cpp2ILInjected.Token(Token = "0x40063C6")]
			public static bool[] ItemIconPulse;

			// Token: 0x040089AA RID: 35242
			[global::Cpp2ILInjected.Token(Token = "0x40063C7")]
			public static bool[] ItemNoGravity;

			// Token: 0x040089AB RID: 35243
			[global::Cpp2ILInjected.Token(Token = "0x40063C8")]
			public static int[] ExtractinatorMode;

			// Token: 0x040089AC RID: 35244
			[global::Cpp2ILInjected.Token(Token = "0x40063C9")]
			public static int[] StaffMinionSlotsRequired;

			// Token: 0x040089AD RID: 35245
			[global::Cpp2ILInjected.Token(Token = "0x40063CA")]
			public static bool[] ExoticPlantsForDyeTrade;

			// Token: 0x040089AE RID: 35246
			[global::Cpp2ILInjected.Token(Token = "0x40063CB")]
			public static bool[] NebulaPickup;

			// Token: 0x040089AF RID: 35247
			[global::Cpp2ILInjected.Token(Token = "0x40063CC")]
			public static bool[] AnimatesAsSoul;

			// Token: 0x040089B0 RID: 35248
			[global::Cpp2ILInjected.Token(Token = "0x40063CD")]
			public static bool[] gunProj;

			// Token: 0x040089B1 RID: 35249
			[global::Cpp2ILInjected.Token(Token = "0x40063CE")]
			public static int[] SortingPriorityBossSpawns;

			// Token: 0x040089B2 RID: 35250
			[global::Cpp2ILInjected.Token(Token = "0x40063CF")]
			public static int[] SortingPriorityWiring;

			// Token: 0x040089B3 RID: 35251
			[global::Cpp2ILInjected.Token(Token = "0x40063D0")]
			public static int[] SortingPriorityMaterials;

			// Token: 0x040089B4 RID: 35252
			[global::Cpp2ILInjected.Token(Token = "0x40063D1")]
			public static int[] SortingPriorityExtractibles;

			// Token: 0x040089B5 RID: 35253
			[global::Cpp2ILInjected.Token(Token = "0x40063D2")]
			public static int[] SortingPriorityRopes;

			// Token: 0x040089B6 RID: 35254
			[global::Cpp2ILInjected.Token(Token = "0x40063D3")]
			public static int[] SortingPriorityPainting;

			// Token: 0x040089B7 RID: 35255
			[global::Cpp2ILInjected.Token(Token = "0x40063D4")]
			public static int[] SortingPriorityTerraforming;

			// Token: 0x040089B8 RID: 35256
			[global::Cpp2ILInjected.Token(Token = "0x40063D5")]
			public static int[] GamepadExtraRange;

			// Token: 0x040089B9 RID: 35257
			[global::Cpp2ILInjected.Token(Token = "0x40063D6")]
			public static bool[] GamepadWholeScreenUseRange;

			// Token: 0x040089BA RID: 35258
			[global::Cpp2ILInjected.Token(Token = "0x40063D7")]
			public static float[] BonusMeleeSpeedMultiplier;

			// Token: 0x040089BB RID: 35259
			[global::Cpp2ILInjected.Token(Token = "0x40063D8")]
			public static bool[] GamepadSmartQuickReach;

			// Token: 0x040089BC RID: 35260
			[global::Cpp2ILInjected.Token(Token = "0x40063D9")]
			public static bool[] Yoyo;

			// Token: 0x040089BD RID: 35261
			[global::Cpp2ILInjected.Token(Token = "0x40063DA")]
			public static bool[] AlsoABuildingItem;

			// Token: 0x040089BE RID: 35262
			[global::Cpp2ILInjected.Token(Token = "0x40063DB")]
			public static bool[] LockOnIgnoresCollision;

			// Token: 0x040089BF RID: 35263
			[global::Cpp2ILInjected.Token(Token = "0x40063DC")]
			public static int[] LockOnAimAbove;

			// Token: 0x040089C0 RID: 35264
			[global::Cpp2ILInjected.Token(Token = "0x40063DD")]
			public static float?[] LockOnAimCompensation;

			// Token: 0x040089C1 RID: 35265
			[global::Cpp2ILInjected.Token(Token = "0x40063DE")]
			public static bool[] SingleUseInGamepad;

			// Token: 0x040089C2 RID: 35266
			[global::Cpp2ILInjected.Token(Token = "0x40063DF")]
			public static bool[] Torches;

			// Token: 0x040089C3 RID: 35267
			[global::Cpp2ILInjected.Token(Token = "0x40063E0")]
			public static bool[] WaterTorches;

			// Token: 0x040089C4 RID: 35268
			[global::Cpp2ILInjected.Token(Token = "0x40063E1")]
			public static short[] Workbenches;

			// Token: 0x040089C5 RID: 35269
			[global::Cpp2ILInjected.Token(Token = "0x40063E2")]
			public static bool[] BossBag;

			// Token: 0x040089C6 RID: 35270
			[global::Cpp2ILInjected.Token(Token = "0x40063E3")]
			public static bool[] OpenableBag;
		}
	}
}
