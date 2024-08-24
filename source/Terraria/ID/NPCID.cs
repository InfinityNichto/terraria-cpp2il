using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.ID
{
	// Token: 0x020003F9 RID: 1017
	[global::Cpp2ILInjected.Token(Token = "0x20005DF")]
	public class NPCID
	{
		// Token: 0x06003065 RID: 12389 RVA: 0x0002AA79 File Offset: 0x00028C79
		[global::Cpp2ILInjected.Token(Token = "0x6003563")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2B34", Offset = "0x13C2B34", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int FromLegacyName(string name)
		{
			throw null;
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x0002AA7C File Offset: 0x00028C7C
		[global::Cpp2ILInjected.Token(Token = "0x6003564")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2BCC", Offset = "0x13C2BCC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SetDefaultsFromNetId", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "InitializeLegacyLocalization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int FromNetId(int id)
		{
			throw null;
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0002AA7F File Offset: 0x00028C7F
		[global::Cpp2ILInjected.Token(Token = "0x6003565")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2C3C", Offset = "0x13C2C3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCID()
		{
			throw null;
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0002AA82 File Offset: 0x00028C82
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003566")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2C44", Offset = "0x13C2C44", Length = "0x4B18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "Create", MemberTypeParameters = new object[] { "IdClass", "IdType" }, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 482)]
		static NPCID()
		{
			throw null;
		}

		// Token: 0x040052C6 RID: 21190
		[global::Cpp2ILInjected.Token(Token = "0x4006573")]
		private static readonly int[] NetIdMap;

		// Token: 0x040052C7 RID: 21191
		[global::Cpp2ILInjected.Token(Token = "0x4006574")]
		private static readonly Dictionary<string, int> LegacyNameToIdMap;

		// Token: 0x040052C8 RID: 21192
		[global::Cpp2ILInjected.Token(Token = "0x4006575")]
		public const short NegativeIDCount = -66;

		// Token: 0x040052C9 RID: 21193
		[global::Cpp2ILInjected.Token(Token = "0x4006576")]
		public const short BigHornetStingy = -65;

		// Token: 0x040052CA RID: 21194
		[global::Cpp2ILInjected.Token(Token = "0x4006577")]
		public const short LittleHornetStingy = -64;

		// Token: 0x040052CB RID: 21195
		[global::Cpp2ILInjected.Token(Token = "0x4006578")]
		public const short BigHornetSpikey = -63;

		// Token: 0x040052CC RID: 21196
		[global::Cpp2ILInjected.Token(Token = "0x4006579")]
		public const short LittleHornetSpikey = -62;

		// Token: 0x040052CD RID: 21197
		[global::Cpp2ILInjected.Token(Token = "0x400657A")]
		public const short BigHornetLeafy = -61;

		// Token: 0x040052CE RID: 21198
		[global::Cpp2ILInjected.Token(Token = "0x400657B")]
		public const short LittleHornetLeafy = -60;

		// Token: 0x040052CF RID: 21199
		[global::Cpp2ILInjected.Token(Token = "0x400657C")]
		public const short BigHornetHoney = -59;

		// Token: 0x040052D0 RID: 21200
		[global::Cpp2ILInjected.Token(Token = "0x400657D")]
		public const short LittleHornetHoney = -58;

		// Token: 0x040052D1 RID: 21201
		[global::Cpp2ILInjected.Token(Token = "0x400657E")]
		public const short BigHornetFatty = -57;

		// Token: 0x040052D2 RID: 21202
		[global::Cpp2ILInjected.Token(Token = "0x400657F")]
		public const short LittleHornetFatty = -56;

		// Token: 0x040052D3 RID: 21203
		[global::Cpp2ILInjected.Token(Token = "0x4006580")]
		public const short BigRainZombie = -55;

		// Token: 0x040052D4 RID: 21204
		[global::Cpp2ILInjected.Token(Token = "0x4006581")]
		public const short SmallRainZombie = -54;

		// Token: 0x040052D5 RID: 21205
		[global::Cpp2ILInjected.Token(Token = "0x4006582")]
		public const short BigPantlessSkeleton = -53;

		// Token: 0x040052D6 RID: 21206
		[global::Cpp2ILInjected.Token(Token = "0x4006583")]
		public const short SmallPantlessSkeleton = -52;

		// Token: 0x040052D7 RID: 21207
		[global::Cpp2ILInjected.Token(Token = "0x4006584")]
		public const short BigMisassembledSkeleton = -51;

		// Token: 0x040052D8 RID: 21208
		[global::Cpp2ILInjected.Token(Token = "0x4006585")]
		public const short SmallMisassembledSkeleton = -50;

		// Token: 0x040052D9 RID: 21209
		[global::Cpp2ILInjected.Token(Token = "0x4006586")]
		public const short BigHeadacheSkeleton = -49;

		// Token: 0x040052DA RID: 21210
		[global::Cpp2ILInjected.Token(Token = "0x4006587")]
		public const short SmallHeadacheSkeleton = -48;

		// Token: 0x040052DB RID: 21211
		[global::Cpp2ILInjected.Token(Token = "0x4006588")]
		public const short BigSkeleton = -47;

		// Token: 0x040052DC RID: 21212
		[global::Cpp2ILInjected.Token(Token = "0x4006589")]
		public const short SmallSkeleton = -46;

		// Token: 0x040052DD RID: 21213
		[global::Cpp2ILInjected.Token(Token = "0x400658A")]
		public const short BigFemaleZombie = -45;

		// Token: 0x040052DE RID: 21214
		[global::Cpp2ILInjected.Token(Token = "0x400658B")]
		public const short SmallFemaleZombie = -44;

		// Token: 0x040052DF RID: 21215
		[global::Cpp2ILInjected.Token(Token = "0x400658C")]
		public const short DemonEye2 = -43;

		// Token: 0x040052E0 RID: 21216
		[global::Cpp2ILInjected.Token(Token = "0x400658D")]
		public const short PurpleEye2 = -42;

		// Token: 0x040052E1 RID: 21217
		[global::Cpp2ILInjected.Token(Token = "0x400658E")]
		public const short GreenEye2 = -41;

		// Token: 0x040052E2 RID: 21218
		[global::Cpp2ILInjected.Token(Token = "0x400658F")]
		public const short DialatedEye2 = -40;

		// Token: 0x040052E3 RID: 21219
		[global::Cpp2ILInjected.Token(Token = "0x4006590")]
		public const short SleepyEye2 = -39;

		// Token: 0x040052E4 RID: 21220
		[global::Cpp2ILInjected.Token(Token = "0x4006591")]
		public const short CataractEye2 = -38;

		// Token: 0x040052E5 RID: 21221
		[global::Cpp2ILInjected.Token(Token = "0x4006592")]
		public const short BigTwiggyZombie = -37;

		// Token: 0x040052E6 RID: 21222
		[global::Cpp2ILInjected.Token(Token = "0x4006593")]
		public const short SmallTwiggyZombie = -36;

		// Token: 0x040052E7 RID: 21223
		[global::Cpp2ILInjected.Token(Token = "0x4006594")]
		public const short BigSwampZombie = -35;

		// Token: 0x040052E8 RID: 21224
		[global::Cpp2ILInjected.Token(Token = "0x4006595")]
		public const short SmallSwampZombie = -34;

		// Token: 0x040052E9 RID: 21225
		[global::Cpp2ILInjected.Token(Token = "0x4006596")]
		public const short BigSlimedZombie = -33;

		// Token: 0x040052EA RID: 21226
		[global::Cpp2ILInjected.Token(Token = "0x4006597")]
		public const short SmallSlimedZombie = -32;

		// Token: 0x040052EB RID: 21227
		[global::Cpp2ILInjected.Token(Token = "0x4006598")]
		public const short BigPincushionZombie = -31;

		// Token: 0x040052EC RID: 21228
		[global::Cpp2ILInjected.Token(Token = "0x4006599")]
		public const short SmallPincushionZombie = -30;

		// Token: 0x040052ED RID: 21229
		[global::Cpp2ILInjected.Token(Token = "0x400659A")]
		public const short BigBaldZombie = -29;

		// Token: 0x040052EE RID: 21230
		[global::Cpp2ILInjected.Token(Token = "0x400659B")]
		public const short SmallBaldZombie = -28;

		// Token: 0x040052EF RID: 21231
		[global::Cpp2ILInjected.Token(Token = "0x400659C")]
		public const short BigZombie = -27;

		// Token: 0x040052F0 RID: 21232
		[global::Cpp2ILInjected.Token(Token = "0x400659D")]
		public const short SmallZombie = -26;

		// Token: 0x040052F1 RID: 21233
		[global::Cpp2ILInjected.Token(Token = "0x400659E")]
		public const short BigCrimslime = -25;

		// Token: 0x040052F2 RID: 21234
		[global::Cpp2ILInjected.Token(Token = "0x400659F")]
		public const short LittleCrimslime = -24;

		// Token: 0x040052F3 RID: 21235
		[global::Cpp2ILInjected.Token(Token = "0x40065A0")]
		public const short BigCrimera = -23;

		// Token: 0x040052F4 RID: 21236
		[global::Cpp2ILInjected.Token(Token = "0x40065A1")]
		public const short LittleCrimera = -22;

		// Token: 0x040052F5 RID: 21237
		[global::Cpp2ILInjected.Token(Token = "0x40065A2")]
		public const short GiantMossHornet = -21;

		// Token: 0x040052F6 RID: 21238
		[global::Cpp2ILInjected.Token(Token = "0x40065A3")]
		public const short BigMossHornet = -20;

		// Token: 0x040052F7 RID: 21239
		[global::Cpp2ILInjected.Token(Token = "0x40065A4")]
		public const short LittleMossHornet = -19;

		// Token: 0x040052F8 RID: 21240
		[global::Cpp2ILInjected.Token(Token = "0x40065A5")]
		public const short TinyMossHornet = -18;

		// Token: 0x040052F9 RID: 21241
		[global::Cpp2ILInjected.Token(Token = "0x40065A6")]
		public const short BigStinger = -17;

		// Token: 0x040052FA RID: 21242
		[global::Cpp2ILInjected.Token(Token = "0x40065A7")]
		public const short LittleStinger = -16;

		// Token: 0x040052FB RID: 21243
		[global::Cpp2ILInjected.Token(Token = "0x40065A8")]
		public const short HeavySkeleton = -15;

		// Token: 0x040052FC RID: 21244
		[global::Cpp2ILInjected.Token(Token = "0x40065A9")]
		public const short BigBoned = -14;

		// Token: 0x040052FD RID: 21245
		[global::Cpp2ILInjected.Token(Token = "0x40065AA")]
		public const short ShortBones = -13;

		// Token: 0x040052FE RID: 21246
		[global::Cpp2ILInjected.Token(Token = "0x40065AB")]
		public const short BigEater = -12;

		// Token: 0x040052FF RID: 21247
		[global::Cpp2ILInjected.Token(Token = "0x40065AC")]
		public const short LittleEater = -11;

		// Token: 0x04005300 RID: 21248
		[global::Cpp2ILInjected.Token(Token = "0x40065AD")]
		public const short JungleSlime = -10;

		// Token: 0x04005301 RID: 21249
		[global::Cpp2ILInjected.Token(Token = "0x40065AE")]
		public const short YellowSlime = -9;

		// Token: 0x04005302 RID: 21250
		[global::Cpp2ILInjected.Token(Token = "0x40065AF")]
		public const short RedSlime = -8;

		// Token: 0x04005303 RID: 21251
		[global::Cpp2ILInjected.Token(Token = "0x40065B0")]
		public const short PurpleSlime = -7;

		// Token: 0x04005304 RID: 21252
		[global::Cpp2ILInjected.Token(Token = "0x40065B1")]
		public const short BlackSlime = -6;

		// Token: 0x04005305 RID: 21253
		[global::Cpp2ILInjected.Token(Token = "0x40065B2")]
		public const short BabySlime = -5;

		// Token: 0x04005306 RID: 21254
		[global::Cpp2ILInjected.Token(Token = "0x40065B3")]
		public const short Pinky = -4;

		// Token: 0x04005307 RID: 21255
		[global::Cpp2ILInjected.Token(Token = "0x40065B4")]
		public const short GreenSlime = -3;

		// Token: 0x04005308 RID: 21256
		[global::Cpp2ILInjected.Token(Token = "0x40065B5")]
		public const short Slimer2 = -2;

		// Token: 0x04005309 RID: 21257
		[global::Cpp2ILInjected.Token(Token = "0x40065B6")]
		public const short Slimeling = -1;

		// Token: 0x0400530A RID: 21258
		[global::Cpp2ILInjected.Token(Token = "0x40065B7")]
		public const short None = 0;

		// Token: 0x0400530B RID: 21259
		[global::Cpp2ILInjected.Token(Token = "0x40065B8")]
		public const short BlueSlime = 1;

		// Token: 0x0400530C RID: 21260
		[global::Cpp2ILInjected.Token(Token = "0x40065B9")]
		public const short DemonEye = 2;

		// Token: 0x0400530D RID: 21261
		[global::Cpp2ILInjected.Token(Token = "0x40065BA")]
		public const short Zombie = 3;

		// Token: 0x0400530E RID: 21262
		[global::Cpp2ILInjected.Token(Token = "0x40065BB")]
		public const short EyeofCthulhu = 4;

		// Token: 0x0400530F RID: 21263
		[global::Cpp2ILInjected.Token(Token = "0x40065BC")]
		public const short ServantofCthulhu = 5;

		// Token: 0x04005310 RID: 21264
		[global::Cpp2ILInjected.Token(Token = "0x40065BD")]
		public const short EaterofSouls = 6;

		// Token: 0x04005311 RID: 21265
		[global::Cpp2ILInjected.Token(Token = "0x40065BE")]
		public const short DevourerHead = 7;

		// Token: 0x04005312 RID: 21266
		[global::Cpp2ILInjected.Token(Token = "0x40065BF")]
		public const short DevourerBody = 8;

		// Token: 0x04005313 RID: 21267
		[global::Cpp2ILInjected.Token(Token = "0x40065C0")]
		public const short DevourerTail = 9;

		// Token: 0x04005314 RID: 21268
		[global::Cpp2ILInjected.Token(Token = "0x40065C1")]
		public const short GiantWormHead = 10;

		// Token: 0x04005315 RID: 21269
		[global::Cpp2ILInjected.Token(Token = "0x40065C2")]
		public const short GiantWormBody = 11;

		// Token: 0x04005316 RID: 21270
		[global::Cpp2ILInjected.Token(Token = "0x40065C3")]
		public const short GiantWormTail = 12;

		// Token: 0x04005317 RID: 21271
		[global::Cpp2ILInjected.Token(Token = "0x40065C4")]
		public const short EaterofWorldsHead = 13;

		// Token: 0x04005318 RID: 21272
		[global::Cpp2ILInjected.Token(Token = "0x40065C5")]
		public const short EaterofWorldsBody = 14;

		// Token: 0x04005319 RID: 21273
		[global::Cpp2ILInjected.Token(Token = "0x40065C6")]
		public const short EaterofWorldsTail = 15;

		// Token: 0x0400531A RID: 21274
		[global::Cpp2ILInjected.Token(Token = "0x40065C7")]
		public const short MotherSlime = 16;

		// Token: 0x0400531B RID: 21275
		[global::Cpp2ILInjected.Token(Token = "0x40065C8")]
		public const short Merchant = 17;

		// Token: 0x0400531C RID: 21276
		[global::Cpp2ILInjected.Token(Token = "0x40065C9")]
		public const short Nurse = 18;

		// Token: 0x0400531D RID: 21277
		[global::Cpp2ILInjected.Token(Token = "0x40065CA")]
		public const short ArmsDealer = 19;

		// Token: 0x0400531E RID: 21278
		[global::Cpp2ILInjected.Token(Token = "0x40065CB")]
		public const short Dryad = 20;

		// Token: 0x0400531F RID: 21279
		[global::Cpp2ILInjected.Token(Token = "0x40065CC")]
		public const short Skeleton = 21;

		// Token: 0x04005320 RID: 21280
		[global::Cpp2ILInjected.Token(Token = "0x40065CD")]
		public const short Guide = 22;

		// Token: 0x04005321 RID: 21281
		[global::Cpp2ILInjected.Token(Token = "0x40065CE")]
		public const short MeteorHead = 23;

		// Token: 0x04005322 RID: 21282
		[global::Cpp2ILInjected.Token(Token = "0x40065CF")]
		public const short FireImp = 24;

		// Token: 0x04005323 RID: 21283
		[global::Cpp2ILInjected.Token(Token = "0x40065D0")]
		public const short BurningSphere = 25;

		// Token: 0x04005324 RID: 21284
		[global::Cpp2ILInjected.Token(Token = "0x40065D1")]
		public const short GoblinPeon = 26;

		// Token: 0x04005325 RID: 21285
		[global::Cpp2ILInjected.Token(Token = "0x40065D2")]
		public const short GoblinThief = 27;

		// Token: 0x04005326 RID: 21286
		[global::Cpp2ILInjected.Token(Token = "0x40065D3")]
		public const short GoblinWarrior = 28;

		// Token: 0x04005327 RID: 21287
		[global::Cpp2ILInjected.Token(Token = "0x40065D4")]
		public const short GoblinSorcerer = 29;

		// Token: 0x04005328 RID: 21288
		[global::Cpp2ILInjected.Token(Token = "0x40065D5")]
		public const short ChaosBall = 30;

		// Token: 0x04005329 RID: 21289
		[global::Cpp2ILInjected.Token(Token = "0x40065D6")]
		public const short AngryBones = 31;

		// Token: 0x0400532A RID: 21290
		[global::Cpp2ILInjected.Token(Token = "0x40065D7")]
		public const short DarkCaster = 32;

		// Token: 0x0400532B RID: 21291
		[global::Cpp2ILInjected.Token(Token = "0x40065D8")]
		public const short WaterSphere = 33;

		// Token: 0x0400532C RID: 21292
		[global::Cpp2ILInjected.Token(Token = "0x40065D9")]
		public const short CursedSkull = 34;

		// Token: 0x0400532D RID: 21293
		[global::Cpp2ILInjected.Token(Token = "0x40065DA")]
		public const short SkeletronHead = 35;

		// Token: 0x0400532E RID: 21294
		[global::Cpp2ILInjected.Token(Token = "0x40065DB")]
		public const short SkeletronHand = 36;

		// Token: 0x0400532F RID: 21295
		[global::Cpp2ILInjected.Token(Token = "0x40065DC")]
		public const short OldMan = 37;

		// Token: 0x04005330 RID: 21296
		[global::Cpp2ILInjected.Token(Token = "0x40065DD")]
		public const short Demolitionist = 38;

		// Token: 0x04005331 RID: 21297
		[global::Cpp2ILInjected.Token(Token = "0x40065DE")]
		public const short BoneSerpentHead = 39;

		// Token: 0x04005332 RID: 21298
		[global::Cpp2ILInjected.Token(Token = "0x40065DF")]
		public const short BoneSerpentBody = 40;

		// Token: 0x04005333 RID: 21299
		[global::Cpp2ILInjected.Token(Token = "0x40065E0")]
		public const short BoneSerpentTail = 41;

		// Token: 0x04005334 RID: 21300
		[global::Cpp2ILInjected.Token(Token = "0x40065E1")]
		public const short Hornet = 42;

		// Token: 0x04005335 RID: 21301
		[global::Cpp2ILInjected.Token(Token = "0x40065E2")]
		public const short ManEater = 43;

		// Token: 0x04005336 RID: 21302
		[global::Cpp2ILInjected.Token(Token = "0x40065E3")]
		public const short UndeadMiner = 44;

		// Token: 0x04005337 RID: 21303
		[global::Cpp2ILInjected.Token(Token = "0x40065E4")]
		public const short Tim = 45;

		// Token: 0x04005338 RID: 21304
		[global::Cpp2ILInjected.Token(Token = "0x40065E5")]
		public const short Bunny = 46;

		// Token: 0x04005339 RID: 21305
		[global::Cpp2ILInjected.Token(Token = "0x40065E6")]
		public const short CorruptBunny = 47;

		// Token: 0x0400533A RID: 21306
		[global::Cpp2ILInjected.Token(Token = "0x40065E7")]
		public const short Harpy = 48;

		// Token: 0x0400533B RID: 21307
		[global::Cpp2ILInjected.Token(Token = "0x40065E8")]
		public const short CaveBat = 49;

		// Token: 0x0400533C RID: 21308
		[global::Cpp2ILInjected.Token(Token = "0x40065E9")]
		public const short KingSlime = 50;

		// Token: 0x0400533D RID: 21309
		[global::Cpp2ILInjected.Token(Token = "0x40065EA")]
		public const short JungleBat = 51;

		// Token: 0x0400533E RID: 21310
		[global::Cpp2ILInjected.Token(Token = "0x40065EB")]
		public const short DoctorBones = 52;

		// Token: 0x0400533F RID: 21311
		[global::Cpp2ILInjected.Token(Token = "0x40065EC")]
		public const short TheGroom = 53;

		// Token: 0x04005340 RID: 21312
		[global::Cpp2ILInjected.Token(Token = "0x40065ED")]
		public const short Clothier = 54;

		// Token: 0x04005341 RID: 21313
		[global::Cpp2ILInjected.Token(Token = "0x40065EE")]
		public const short Goldfish = 55;

		// Token: 0x04005342 RID: 21314
		[global::Cpp2ILInjected.Token(Token = "0x40065EF")]
		public const short Snatcher = 56;

		// Token: 0x04005343 RID: 21315
		[global::Cpp2ILInjected.Token(Token = "0x40065F0")]
		public const short CorruptGoldfish = 57;

		// Token: 0x04005344 RID: 21316
		[global::Cpp2ILInjected.Token(Token = "0x40065F1")]
		public const short Piranha = 58;

		// Token: 0x04005345 RID: 21317
		[global::Cpp2ILInjected.Token(Token = "0x40065F2")]
		public const short LavaSlime = 59;

		// Token: 0x04005346 RID: 21318
		[global::Cpp2ILInjected.Token(Token = "0x40065F3")]
		public const short Hellbat = 60;

		// Token: 0x04005347 RID: 21319
		[global::Cpp2ILInjected.Token(Token = "0x40065F4")]
		public const short Vulture = 61;

		// Token: 0x04005348 RID: 21320
		[global::Cpp2ILInjected.Token(Token = "0x40065F5")]
		public const short Demon = 62;

		// Token: 0x04005349 RID: 21321
		[global::Cpp2ILInjected.Token(Token = "0x40065F6")]
		public const short BlueJellyfish = 63;

		// Token: 0x0400534A RID: 21322
		[global::Cpp2ILInjected.Token(Token = "0x40065F7")]
		public const short PinkJellyfish = 64;

		// Token: 0x0400534B RID: 21323
		[global::Cpp2ILInjected.Token(Token = "0x40065F8")]
		public const short Shark = 65;

		// Token: 0x0400534C RID: 21324
		[global::Cpp2ILInjected.Token(Token = "0x40065F9")]
		public const short VoodooDemon = 66;

		// Token: 0x0400534D RID: 21325
		[global::Cpp2ILInjected.Token(Token = "0x40065FA")]
		public const short Crab = 67;

		// Token: 0x0400534E RID: 21326
		[global::Cpp2ILInjected.Token(Token = "0x40065FB")]
		public const short DungeonGuardian = 68;

		// Token: 0x0400534F RID: 21327
		[global::Cpp2ILInjected.Token(Token = "0x40065FC")]
		public const short Antlion = 69;

		// Token: 0x04005350 RID: 21328
		[global::Cpp2ILInjected.Token(Token = "0x40065FD")]
		public const short SpikeBall = 70;

		// Token: 0x04005351 RID: 21329
		[global::Cpp2ILInjected.Token(Token = "0x40065FE")]
		public const short DungeonSlime = 71;

		// Token: 0x04005352 RID: 21330
		[global::Cpp2ILInjected.Token(Token = "0x40065FF")]
		public const short BlazingWheel = 72;

		// Token: 0x04005353 RID: 21331
		[global::Cpp2ILInjected.Token(Token = "0x4006600")]
		public const short GoblinScout = 73;

		// Token: 0x04005354 RID: 21332
		[global::Cpp2ILInjected.Token(Token = "0x4006601")]
		public const short Bird = 74;

		// Token: 0x04005355 RID: 21333
		[global::Cpp2ILInjected.Token(Token = "0x4006602")]
		public const short Pixie = 75;

		// Token: 0x04005356 RID: 21334
		[global::Cpp2ILInjected.Token(Token = "0x4006603")]
		public const short None2 = 76;

		// Token: 0x04005357 RID: 21335
		[global::Cpp2ILInjected.Token(Token = "0x4006604")]
		public const short ArmoredSkeleton = 77;

		// Token: 0x04005358 RID: 21336
		[global::Cpp2ILInjected.Token(Token = "0x4006605")]
		public const short Mummy = 78;

		// Token: 0x04005359 RID: 21337
		[global::Cpp2ILInjected.Token(Token = "0x4006606")]
		public const short DarkMummy = 79;

		// Token: 0x0400535A RID: 21338
		[global::Cpp2ILInjected.Token(Token = "0x4006607")]
		public const short LightMummy = 80;

		// Token: 0x0400535B RID: 21339
		[global::Cpp2ILInjected.Token(Token = "0x4006608")]
		public const short CorruptSlime = 81;

		// Token: 0x0400535C RID: 21340
		[global::Cpp2ILInjected.Token(Token = "0x4006609")]
		public const short Wraith = 82;

		// Token: 0x0400535D RID: 21341
		[global::Cpp2ILInjected.Token(Token = "0x400660A")]
		public const short CursedHammer = 83;

		// Token: 0x0400535E RID: 21342
		[global::Cpp2ILInjected.Token(Token = "0x400660B")]
		public const short EnchantedSword = 84;

		// Token: 0x0400535F RID: 21343
		[global::Cpp2ILInjected.Token(Token = "0x400660C")]
		public const short Mimic = 85;

		// Token: 0x04005360 RID: 21344
		[global::Cpp2ILInjected.Token(Token = "0x400660D")]
		public const short Unicorn = 86;

		// Token: 0x04005361 RID: 21345
		[global::Cpp2ILInjected.Token(Token = "0x400660E")]
		public const short WyvernHead = 87;

		// Token: 0x04005362 RID: 21346
		[global::Cpp2ILInjected.Token(Token = "0x400660F")]
		public const short WyvernLegs = 88;

		// Token: 0x04005363 RID: 21347
		[global::Cpp2ILInjected.Token(Token = "0x4006610")]
		public const short WyvernBody = 89;

		// Token: 0x04005364 RID: 21348
		[global::Cpp2ILInjected.Token(Token = "0x4006611")]
		public const short WyvernBody2 = 90;

		// Token: 0x04005365 RID: 21349
		[global::Cpp2ILInjected.Token(Token = "0x4006612")]
		public const short WyvernBody3 = 91;

		// Token: 0x04005366 RID: 21350
		[global::Cpp2ILInjected.Token(Token = "0x4006613")]
		public const short WyvernTail = 92;

		// Token: 0x04005367 RID: 21351
		[global::Cpp2ILInjected.Token(Token = "0x4006614")]
		public const short GiantBat = 93;

		// Token: 0x04005368 RID: 21352
		[global::Cpp2ILInjected.Token(Token = "0x4006615")]
		public const short Corruptor = 94;

		// Token: 0x04005369 RID: 21353
		[global::Cpp2ILInjected.Token(Token = "0x4006616")]
		public const short DiggerHead = 95;

		// Token: 0x0400536A RID: 21354
		[global::Cpp2ILInjected.Token(Token = "0x4006617")]
		public const short DiggerBody = 96;

		// Token: 0x0400536B RID: 21355
		[global::Cpp2ILInjected.Token(Token = "0x4006618")]
		public const short DiggerTail = 97;

		// Token: 0x0400536C RID: 21356
		[global::Cpp2ILInjected.Token(Token = "0x4006619")]
		public const short SeekerHead = 98;

		// Token: 0x0400536D RID: 21357
		[global::Cpp2ILInjected.Token(Token = "0x400661A")]
		public const short SeekerBody = 99;

		// Token: 0x0400536E RID: 21358
		[global::Cpp2ILInjected.Token(Token = "0x400661B")]
		public const short SeekerTail = 100;

		// Token: 0x0400536F RID: 21359
		[global::Cpp2ILInjected.Token(Token = "0x400661C")]
		public const short Clinger = 101;

		// Token: 0x04005370 RID: 21360
		[global::Cpp2ILInjected.Token(Token = "0x400661D")]
		public const short AnglerFish = 102;

		// Token: 0x04005371 RID: 21361
		[global::Cpp2ILInjected.Token(Token = "0x400661E")]
		public const short GreenJellyfish = 103;

		// Token: 0x04005372 RID: 21362
		[global::Cpp2ILInjected.Token(Token = "0x400661F")]
		public const short Werewolf = 104;

		// Token: 0x04005373 RID: 21363
		[global::Cpp2ILInjected.Token(Token = "0x4006620")]
		public const short BoundGoblin = 105;

		// Token: 0x04005374 RID: 21364
		[global::Cpp2ILInjected.Token(Token = "0x4006621")]
		public const short BoundWizard = 106;

		// Token: 0x04005375 RID: 21365
		[global::Cpp2ILInjected.Token(Token = "0x4006622")]
		public const short GoblinTinkerer = 107;

		// Token: 0x04005376 RID: 21366
		[global::Cpp2ILInjected.Token(Token = "0x4006623")]
		public const short Wizard = 108;

		// Token: 0x04005377 RID: 21367
		[global::Cpp2ILInjected.Token(Token = "0x4006624")]
		public const short Clown = 109;

		// Token: 0x04005378 RID: 21368
		[global::Cpp2ILInjected.Token(Token = "0x4006625")]
		public const short SkeletonArcher = 110;

		// Token: 0x04005379 RID: 21369
		[global::Cpp2ILInjected.Token(Token = "0x4006626")]
		public const short GoblinArcher = 111;

		// Token: 0x0400537A RID: 21370
		[global::Cpp2ILInjected.Token(Token = "0x4006627")]
		public const short VileSpit = 112;

		// Token: 0x0400537B RID: 21371
		[global::Cpp2ILInjected.Token(Token = "0x4006628")]
		public const short WallofFlesh = 113;

		// Token: 0x0400537C RID: 21372
		[global::Cpp2ILInjected.Token(Token = "0x4006629")]
		public const short WallofFleshEye = 114;

		// Token: 0x0400537D RID: 21373
		[global::Cpp2ILInjected.Token(Token = "0x400662A")]
		public const short TheHungry = 115;

		// Token: 0x0400537E RID: 21374
		[global::Cpp2ILInjected.Token(Token = "0x400662B")]
		public const short TheHungryII = 116;

		// Token: 0x0400537F RID: 21375
		[global::Cpp2ILInjected.Token(Token = "0x400662C")]
		public const short LeechHead = 117;

		// Token: 0x04005380 RID: 21376
		[global::Cpp2ILInjected.Token(Token = "0x400662D")]
		public const short LeechBody = 118;

		// Token: 0x04005381 RID: 21377
		[global::Cpp2ILInjected.Token(Token = "0x400662E")]
		public const short LeechTail = 119;

		// Token: 0x04005382 RID: 21378
		[global::Cpp2ILInjected.Token(Token = "0x400662F")]
		public const short ChaosElemental = 120;

		// Token: 0x04005383 RID: 21379
		[global::Cpp2ILInjected.Token(Token = "0x4006630")]
		public const short Slimer = 121;

		// Token: 0x04005384 RID: 21380
		[global::Cpp2ILInjected.Token(Token = "0x4006631")]
		public const short Gastropod = 122;

		// Token: 0x04005385 RID: 21381
		[global::Cpp2ILInjected.Token(Token = "0x4006632")]
		public const short BoundMechanic = 123;

		// Token: 0x04005386 RID: 21382
		[global::Cpp2ILInjected.Token(Token = "0x4006633")]
		public const short Mechanic = 124;

		// Token: 0x04005387 RID: 21383
		[global::Cpp2ILInjected.Token(Token = "0x4006634")]
		public const short Retinazer = 125;

		// Token: 0x04005388 RID: 21384
		[global::Cpp2ILInjected.Token(Token = "0x4006635")]
		public const short Spazmatism = 126;

		// Token: 0x04005389 RID: 21385
		[global::Cpp2ILInjected.Token(Token = "0x4006636")]
		public const short SkeletronPrime = 127;

		// Token: 0x0400538A RID: 21386
		[global::Cpp2ILInjected.Token(Token = "0x4006637")]
		public const short PrimeCannon = 128;

		// Token: 0x0400538B RID: 21387
		[global::Cpp2ILInjected.Token(Token = "0x4006638")]
		public const short PrimeSaw = 129;

		// Token: 0x0400538C RID: 21388
		[global::Cpp2ILInjected.Token(Token = "0x4006639")]
		public const short PrimeVice = 130;

		// Token: 0x0400538D RID: 21389
		[global::Cpp2ILInjected.Token(Token = "0x400663A")]
		public const short PrimeLaser = 131;

		// Token: 0x0400538E RID: 21390
		[global::Cpp2ILInjected.Token(Token = "0x400663B")]
		public const short BaldZombie = 132;

		// Token: 0x0400538F RID: 21391
		[global::Cpp2ILInjected.Token(Token = "0x400663C")]
		public const short WanderingEye = 133;

		// Token: 0x04005390 RID: 21392
		[global::Cpp2ILInjected.Token(Token = "0x400663D")]
		public const short TheDestroyer = 134;

		// Token: 0x04005391 RID: 21393
		[global::Cpp2ILInjected.Token(Token = "0x400663E")]
		public const short TheDestroyerBody = 135;

		// Token: 0x04005392 RID: 21394
		[global::Cpp2ILInjected.Token(Token = "0x400663F")]
		public const short TheDestroyerTail = 136;

		// Token: 0x04005393 RID: 21395
		[global::Cpp2ILInjected.Token(Token = "0x4006640")]
		public const short IlluminantBat = 137;

		// Token: 0x04005394 RID: 21396
		[global::Cpp2ILInjected.Token(Token = "0x4006641")]
		public const short IlluminantSlime = 138;

		// Token: 0x04005395 RID: 21397
		[global::Cpp2ILInjected.Token(Token = "0x4006642")]
		public const short Probe = 139;

		// Token: 0x04005396 RID: 21398
		[global::Cpp2ILInjected.Token(Token = "0x4006643")]
		public const short PossessedArmor = 140;

		// Token: 0x04005397 RID: 21399
		[global::Cpp2ILInjected.Token(Token = "0x4006644")]
		public const short ToxicSludge = 141;

		// Token: 0x04005398 RID: 21400
		[global::Cpp2ILInjected.Token(Token = "0x4006645")]
		public const short SantaClaus = 142;

		// Token: 0x04005399 RID: 21401
		[global::Cpp2ILInjected.Token(Token = "0x4006646")]
		public const short SnowmanGangsta = 143;

		// Token: 0x0400539A RID: 21402
		[global::Cpp2ILInjected.Token(Token = "0x4006647")]
		public const short MisterStabby = 144;

		// Token: 0x0400539B RID: 21403
		[global::Cpp2ILInjected.Token(Token = "0x4006648")]
		public const short SnowBalla = 145;

		// Token: 0x0400539C RID: 21404
		[global::Cpp2ILInjected.Token(Token = "0x4006649")]
		public const short None3 = 146;

		// Token: 0x0400539D RID: 21405
		[global::Cpp2ILInjected.Token(Token = "0x400664A")]
		public const short IceSlime = 147;

		// Token: 0x0400539E RID: 21406
		[global::Cpp2ILInjected.Token(Token = "0x400664B")]
		public const short Penguin = 148;

		// Token: 0x0400539F RID: 21407
		[global::Cpp2ILInjected.Token(Token = "0x400664C")]
		public const short PenguinBlack = 149;

		// Token: 0x040053A0 RID: 21408
		[global::Cpp2ILInjected.Token(Token = "0x400664D")]
		public const short IceBat = 150;

		// Token: 0x040053A1 RID: 21409
		[global::Cpp2ILInjected.Token(Token = "0x400664E")]
		public const short Lavabat = 151;

		// Token: 0x040053A2 RID: 21410
		[global::Cpp2ILInjected.Token(Token = "0x400664F")]
		public const short GiantFlyingFox = 152;

		// Token: 0x040053A3 RID: 21411
		[global::Cpp2ILInjected.Token(Token = "0x4006650")]
		public const short GiantTortoise = 153;

		// Token: 0x040053A4 RID: 21412
		[global::Cpp2ILInjected.Token(Token = "0x4006651")]
		public const short IceTortoise = 154;

		// Token: 0x040053A5 RID: 21413
		[global::Cpp2ILInjected.Token(Token = "0x4006652")]
		public const short Wolf = 155;

		// Token: 0x040053A6 RID: 21414
		[global::Cpp2ILInjected.Token(Token = "0x4006653")]
		public const short RedDevil = 156;

		// Token: 0x040053A7 RID: 21415
		[global::Cpp2ILInjected.Token(Token = "0x4006654")]
		public const short Arapaima = 157;

		// Token: 0x040053A8 RID: 21416
		[global::Cpp2ILInjected.Token(Token = "0x4006655")]
		public const short VampireBat = 158;

		// Token: 0x040053A9 RID: 21417
		[global::Cpp2ILInjected.Token(Token = "0x4006656")]
		public const short Vampire = 159;

		// Token: 0x040053AA RID: 21418
		[global::Cpp2ILInjected.Token(Token = "0x4006657")]
		public const short Truffle = 160;

		// Token: 0x040053AB RID: 21419
		[global::Cpp2ILInjected.Token(Token = "0x4006658")]
		public const short ZombieEskimo = 161;

		// Token: 0x040053AC RID: 21420
		[global::Cpp2ILInjected.Token(Token = "0x4006659")]
		public const short Frankenstein = 162;

		// Token: 0x040053AD RID: 21421
		[global::Cpp2ILInjected.Token(Token = "0x400665A")]
		public const short BlackRecluse = 163;

		// Token: 0x040053AE RID: 21422
		[global::Cpp2ILInjected.Token(Token = "0x400665B")]
		public const short WallCreeper = 164;

		// Token: 0x040053AF RID: 21423
		[global::Cpp2ILInjected.Token(Token = "0x400665C")]
		public const short WallCreeperWall = 165;

		// Token: 0x040053B0 RID: 21424
		[global::Cpp2ILInjected.Token(Token = "0x400665D")]
		public const short SwampThing = 166;

		// Token: 0x040053B1 RID: 21425
		[global::Cpp2ILInjected.Token(Token = "0x400665E")]
		public const short UndeadViking = 167;

		// Token: 0x040053B2 RID: 21426
		[global::Cpp2ILInjected.Token(Token = "0x400665F")]
		public const short CorruptPenguin = 168;

		// Token: 0x040053B3 RID: 21427
		[global::Cpp2ILInjected.Token(Token = "0x4006660")]
		public const short IceElemental = 169;

		// Token: 0x040053B4 RID: 21428
		[global::Cpp2ILInjected.Token(Token = "0x4006661")]
		public const short PigronCorruption = 170;

		// Token: 0x040053B5 RID: 21429
		[global::Cpp2ILInjected.Token(Token = "0x4006662")]
		public const short PigronHallow = 171;

		// Token: 0x040053B6 RID: 21430
		[global::Cpp2ILInjected.Token(Token = "0x4006663")]
		public const short RuneWizard = 172;

		// Token: 0x040053B7 RID: 21431
		[global::Cpp2ILInjected.Token(Token = "0x4006664")]
		public const short Crimera = 173;

		// Token: 0x040053B8 RID: 21432
		[global::Cpp2ILInjected.Token(Token = "0x4006665")]
		public const short Herpling = 174;

		// Token: 0x040053B9 RID: 21433
		[global::Cpp2ILInjected.Token(Token = "0x4006666")]
		public const short AngryTrapper = 175;

		// Token: 0x040053BA RID: 21434
		[global::Cpp2ILInjected.Token(Token = "0x4006667")]
		public const short MossHornet = 176;

		// Token: 0x040053BB RID: 21435
		[global::Cpp2ILInjected.Token(Token = "0x4006668")]
		public const short Derpling = 177;

		// Token: 0x040053BC RID: 21436
		[global::Cpp2ILInjected.Token(Token = "0x4006669")]
		public const short Steampunker = 178;

		// Token: 0x040053BD RID: 21437
		[global::Cpp2ILInjected.Token(Token = "0x400666A")]
		public const short CrimsonAxe = 179;

		// Token: 0x040053BE RID: 21438
		[global::Cpp2ILInjected.Token(Token = "0x400666B")]
		public const short PigronCrimson = 180;

		// Token: 0x040053BF RID: 21439
		[global::Cpp2ILInjected.Token(Token = "0x400666C")]
		public const short FaceMonster = 181;

		// Token: 0x040053C0 RID: 21440
		[global::Cpp2ILInjected.Token(Token = "0x400666D")]
		public const short FloatyGross = 182;

		// Token: 0x040053C1 RID: 21441
		[global::Cpp2ILInjected.Token(Token = "0x400666E")]
		public const short Crimslime = 183;

		// Token: 0x040053C2 RID: 21442
		[global::Cpp2ILInjected.Token(Token = "0x400666F")]
		public const short SpikedIceSlime = 184;

		// Token: 0x040053C3 RID: 21443
		[global::Cpp2ILInjected.Token(Token = "0x4006670")]
		public const short SnowFlinx = 185;

		// Token: 0x040053C4 RID: 21444
		[global::Cpp2ILInjected.Token(Token = "0x4006671")]
		public const short PincushionZombie = 186;

		// Token: 0x040053C5 RID: 21445
		[global::Cpp2ILInjected.Token(Token = "0x4006672")]
		public const short SlimedZombie = 187;

		// Token: 0x040053C6 RID: 21446
		[global::Cpp2ILInjected.Token(Token = "0x4006673")]
		public const short SwampZombie = 188;

		// Token: 0x040053C7 RID: 21447
		[global::Cpp2ILInjected.Token(Token = "0x4006674")]
		public const short TwiggyZombie = 189;

		// Token: 0x040053C8 RID: 21448
		[global::Cpp2ILInjected.Token(Token = "0x4006675")]
		public const short CataractEye = 190;

		// Token: 0x040053C9 RID: 21449
		[global::Cpp2ILInjected.Token(Token = "0x4006676")]
		public const short SleepyEye = 191;

		// Token: 0x040053CA RID: 21450
		[global::Cpp2ILInjected.Token(Token = "0x4006677")]
		public const short DialatedEye = 192;

		// Token: 0x040053CB RID: 21451
		[global::Cpp2ILInjected.Token(Token = "0x4006678")]
		public const short GreenEye = 193;

		// Token: 0x040053CC RID: 21452
		[global::Cpp2ILInjected.Token(Token = "0x4006679")]
		public const short PurpleEye = 194;

		// Token: 0x040053CD RID: 21453
		[global::Cpp2ILInjected.Token(Token = "0x400667A")]
		public const short LostGirl = 195;

		// Token: 0x040053CE RID: 21454
		[global::Cpp2ILInjected.Token(Token = "0x400667B")]
		public const short Nymph = 196;

		// Token: 0x040053CF RID: 21455
		[global::Cpp2ILInjected.Token(Token = "0x400667C")]
		public const short ArmoredViking = 197;

		// Token: 0x040053D0 RID: 21456
		[global::Cpp2ILInjected.Token(Token = "0x400667D")]
		public const short Lihzahrd = 198;

		// Token: 0x040053D1 RID: 21457
		[global::Cpp2ILInjected.Token(Token = "0x400667E")]
		public const short LihzahrdCrawler = 199;

		// Token: 0x040053D2 RID: 21458
		[global::Cpp2ILInjected.Token(Token = "0x400667F")]
		public const short FemaleZombie = 200;

		// Token: 0x040053D3 RID: 21459
		[global::Cpp2ILInjected.Token(Token = "0x4006680")]
		public const short HeadacheSkeleton = 201;

		// Token: 0x040053D4 RID: 21460
		[global::Cpp2ILInjected.Token(Token = "0x4006681")]
		public const short MisassembledSkeleton = 202;

		// Token: 0x040053D5 RID: 21461
		[global::Cpp2ILInjected.Token(Token = "0x4006682")]
		public const short PantlessSkeleton = 203;

		// Token: 0x040053D6 RID: 21462
		[global::Cpp2ILInjected.Token(Token = "0x4006683")]
		public const short SpikedJungleSlime = 204;

		// Token: 0x040053D7 RID: 21463
		[global::Cpp2ILInjected.Token(Token = "0x4006684")]
		public const short Moth = 205;

		// Token: 0x040053D8 RID: 21464
		[global::Cpp2ILInjected.Token(Token = "0x4006685")]
		public const short IcyMerman = 206;

		// Token: 0x040053D9 RID: 21465
		[global::Cpp2ILInjected.Token(Token = "0x4006686")]
		public const short DyeTrader = 207;

		// Token: 0x040053DA RID: 21466
		[global::Cpp2ILInjected.Token(Token = "0x4006687")]
		public const short PartyGirl = 208;

		// Token: 0x040053DB RID: 21467
		[global::Cpp2ILInjected.Token(Token = "0x4006688")]
		public const short Cyborg = 209;

		// Token: 0x040053DC RID: 21468
		[global::Cpp2ILInjected.Token(Token = "0x4006689")]
		public const short Bee = 210;

		// Token: 0x040053DD RID: 21469
		[global::Cpp2ILInjected.Token(Token = "0x400668A")]
		public const short BeeSmall = 211;

		// Token: 0x040053DE RID: 21470
		[global::Cpp2ILInjected.Token(Token = "0x400668B")]
		public const short PirateDeckhand = 212;

		// Token: 0x040053DF RID: 21471
		[global::Cpp2ILInjected.Token(Token = "0x400668C")]
		public const short PirateCorsair = 213;

		// Token: 0x040053E0 RID: 21472
		[global::Cpp2ILInjected.Token(Token = "0x400668D")]
		public const short PirateDeadeye = 214;

		// Token: 0x040053E1 RID: 21473
		[global::Cpp2ILInjected.Token(Token = "0x400668E")]
		public const short PirateCrossbower = 215;

		// Token: 0x040053E2 RID: 21474
		[global::Cpp2ILInjected.Token(Token = "0x400668F")]
		public const short PirateCaptain = 216;

		// Token: 0x040053E3 RID: 21475
		[global::Cpp2ILInjected.Token(Token = "0x4006690")]
		public const short CochinealBeetle = 217;

		// Token: 0x040053E4 RID: 21476
		[global::Cpp2ILInjected.Token(Token = "0x4006691")]
		public const short CyanBeetle = 218;

		// Token: 0x040053E5 RID: 21477
		[global::Cpp2ILInjected.Token(Token = "0x4006692")]
		public const short LacBeetle = 219;

		// Token: 0x040053E6 RID: 21478
		[global::Cpp2ILInjected.Token(Token = "0x4006693")]
		public const short SeaSnail = 220;

		// Token: 0x040053E7 RID: 21479
		[global::Cpp2ILInjected.Token(Token = "0x4006694")]
		public const short Squid = 221;

		// Token: 0x040053E8 RID: 21480
		[global::Cpp2ILInjected.Token(Token = "0x4006695")]
		public const short QueenBee = 222;

		// Token: 0x040053E9 RID: 21481
		[global::Cpp2ILInjected.Token(Token = "0x4006696")]
		public const short ZombieRaincoat = 223;

		// Token: 0x040053EA RID: 21482
		[global::Cpp2ILInjected.Token(Token = "0x4006697")]
		public const short FlyingFish = 224;

		// Token: 0x040053EB RID: 21483
		[global::Cpp2ILInjected.Token(Token = "0x4006698")]
		public const short UmbrellaSlime = 225;

		// Token: 0x040053EC RID: 21484
		[global::Cpp2ILInjected.Token(Token = "0x4006699")]
		public const short FlyingSnake = 226;

		// Token: 0x040053ED RID: 21485
		[global::Cpp2ILInjected.Token(Token = "0x400669A")]
		public const short Painter = 227;

		// Token: 0x040053EE RID: 21486
		[global::Cpp2ILInjected.Token(Token = "0x400669B")]
		public const short WitchDoctor = 228;

		// Token: 0x040053EF RID: 21487
		[global::Cpp2ILInjected.Token(Token = "0x400669C")]
		public const short Pirate = 229;

		// Token: 0x040053F0 RID: 21488
		[global::Cpp2ILInjected.Token(Token = "0x400669D")]
		public const short GoldfishWalker = 230;

		// Token: 0x040053F1 RID: 21489
		[global::Cpp2ILInjected.Token(Token = "0x400669E")]
		public const short HornetFatty = 231;

		// Token: 0x040053F2 RID: 21490
		[global::Cpp2ILInjected.Token(Token = "0x400669F")]
		public const short HornetHoney = 232;

		// Token: 0x040053F3 RID: 21491
		[global::Cpp2ILInjected.Token(Token = "0x40066A0")]
		public const short HornetLeafy = 233;

		// Token: 0x040053F4 RID: 21492
		[global::Cpp2ILInjected.Token(Token = "0x40066A1")]
		public const short HornetSpikey = 234;

		// Token: 0x040053F5 RID: 21493
		[global::Cpp2ILInjected.Token(Token = "0x40066A2")]
		public const short HornetStingy = 235;

		// Token: 0x040053F6 RID: 21494
		[global::Cpp2ILInjected.Token(Token = "0x40066A3")]
		public const short JungleCreeper = 236;

		// Token: 0x040053F7 RID: 21495
		[global::Cpp2ILInjected.Token(Token = "0x40066A4")]
		public const short JungleCreeperWall = 237;

		// Token: 0x040053F8 RID: 21496
		[global::Cpp2ILInjected.Token(Token = "0x40066A5")]
		public const short BlackRecluseWall = 238;

		// Token: 0x040053F9 RID: 21497
		[global::Cpp2ILInjected.Token(Token = "0x40066A6")]
		public const short BloodCrawler = 239;

		// Token: 0x040053FA RID: 21498
		[global::Cpp2ILInjected.Token(Token = "0x40066A7")]
		public const short BloodCrawlerWall = 240;

		// Token: 0x040053FB RID: 21499
		[global::Cpp2ILInjected.Token(Token = "0x40066A8")]
		public const short BloodFeeder = 241;

		// Token: 0x040053FC RID: 21500
		[global::Cpp2ILInjected.Token(Token = "0x40066A9")]
		public const short BloodJelly = 242;

		// Token: 0x040053FD RID: 21501
		[global::Cpp2ILInjected.Token(Token = "0x40066AA")]
		public const short IceGolem = 243;

		// Token: 0x040053FE RID: 21502
		[global::Cpp2ILInjected.Token(Token = "0x40066AB")]
		public const short RainbowSlime = 244;

		// Token: 0x040053FF RID: 21503
		[global::Cpp2ILInjected.Token(Token = "0x40066AC")]
		public const short Golem = 245;

		// Token: 0x04005400 RID: 21504
		[global::Cpp2ILInjected.Token(Token = "0x40066AD")]
		public const short GolemHead = 246;

		// Token: 0x04005401 RID: 21505
		[global::Cpp2ILInjected.Token(Token = "0x40066AE")]
		public const short GolemFistLeft = 247;

		// Token: 0x04005402 RID: 21506
		[global::Cpp2ILInjected.Token(Token = "0x40066AF")]
		public const short GolemFistRight = 248;

		// Token: 0x04005403 RID: 21507
		[global::Cpp2ILInjected.Token(Token = "0x40066B0")]
		public const short GolemHeadFree = 249;

		// Token: 0x04005404 RID: 21508
		[global::Cpp2ILInjected.Token(Token = "0x40066B1")]
		public const short AngryNimbus = 250;

		// Token: 0x04005405 RID: 21509
		[global::Cpp2ILInjected.Token(Token = "0x40066B2")]
		public const short Eyezor = 251;

		// Token: 0x04005406 RID: 21510
		[global::Cpp2ILInjected.Token(Token = "0x40066B3")]
		public const short Parrot = 252;

		// Token: 0x04005407 RID: 21511
		[global::Cpp2ILInjected.Token(Token = "0x40066B4")]
		public const short Reaper = 253;

		// Token: 0x04005408 RID: 21512
		[global::Cpp2ILInjected.Token(Token = "0x40066B5")]
		public const short ZombieMushroom = 254;

		// Token: 0x04005409 RID: 21513
		[global::Cpp2ILInjected.Token(Token = "0x40066B6")]
		public const short ZombieMushroomHat = 255;

		// Token: 0x0400540A RID: 21514
		[global::Cpp2ILInjected.Token(Token = "0x40066B7")]
		public const short FungoFish = 256;

		// Token: 0x0400540B RID: 21515
		[global::Cpp2ILInjected.Token(Token = "0x40066B8")]
		public const short AnomuraFungus = 257;

		// Token: 0x0400540C RID: 21516
		[global::Cpp2ILInjected.Token(Token = "0x40066B9")]
		public const short MushiLadybug = 258;

		// Token: 0x0400540D RID: 21517
		[global::Cpp2ILInjected.Token(Token = "0x40066BA")]
		public const short FungiBulb = 259;

		// Token: 0x0400540E RID: 21518
		[global::Cpp2ILInjected.Token(Token = "0x40066BB")]
		public const short GiantFungiBulb = 260;

		// Token: 0x0400540F RID: 21519
		[global::Cpp2ILInjected.Token(Token = "0x40066BC")]
		public const short FungiSpore = 261;

		// Token: 0x04005410 RID: 21520
		[global::Cpp2ILInjected.Token(Token = "0x40066BD")]
		public const short Plantera = 262;

		// Token: 0x04005411 RID: 21521
		[global::Cpp2ILInjected.Token(Token = "0x40066BE")]
		public const short PlanterasHook = 263;

		// Token: 0x04005412 RID: 21522
		[global::Cpp2ILInjected.Token(Token = "0x40066BF")]
		public const short PlanterasTentacle = 264;

		// Token: 0x04005413 RID: 21523
		[global::Cpp2ILInjected.Token(Token = "0x40066C0")]
		public const short Spore = 265;

		// Token: 0x04005414 RID: 21524
		[global::Cpp2ILInjected.Token(Token = "0x40066C1")]
		public const short BrainofCthulhu = 266;

		// Token: 0x04005415 RID: 21525
		[global::Cpp2ILInjected.Token(Token = "0x40066C2")]
		public const short Creeper = 267;

		// Token: 0x04005416 RID: 21526
		[global::Cpp2ILInjected.Token(Token = "0x40066C3")]
		public const short IchorSticker = 268;

		// Token: 0x04005417 RID: 21527
		[global::Cpp2ILInjected.Token(Token = "0x40066C4")]
		public const short RustyArmoredBonesAxe = 269;

		// Token: 0x04005418 RID: 21528
		[global::Cpp2ILInjected.Token(Token = "0x40066C5")]
		public const short RustyArmoredBonesFlail = 270;

		// Token: 0x04005419 RID: 21529
		[global::Cpp2ILInjected.Token(Token = "0x40066C6")]
		public const short RustyArmoredBonesSword = 271;

		// Token: 0x0400541A RID: 21530
		[global::Cpp2ILInjected.Token(Token = "0x40066C7")]
		public const short RustyArmoredBonesSwordNoArmor = 272;

		// Token: 0x0400541B RID: 21531
		[global::Cpp2ILInjected.Token(Token = "0x40066C8")]
		public const short BlueArmoredBones = 273;

		// Token: 0x0400541C RID: 21532
		[global::Cpp2ILInjected.Token(Token = "0x40066C9")]
		public const short BlueArmoredBonesMace = 274;

		// Token: 0x0400541D RID: 21533
		[global::Cpp2ILInjected.Token(Token = "0x40066CA")]
		public const short BlueArmoredBonesNoPants = 275;

		// Token: 0x0400541E RID: 21534
		[global::Cpp2ILInjected.Token(Token = "0x40066CB")]
		public const short BlueArmoredBonesSword = 276;

		// Token: 0x0400541F RID: 21535
		[global::Cpp2ILInjected.Token(Token = "0x40066CC")]
		public const short HellArmoredBones = 277;

		// Token: 0x04005420 RID: 21536
		[global::Cpp2ILInjected.Token(Token = "0x40066CD")]
		public const short HellArmoredBonesSpikeShield = 278;

		// Token: 0x04005421 RID: 21537
		[global::Cpp2ILInjected.Token(Token = "0x40066CE")]
		public const short HellArmoredBonesMace = 279;

		// Token: 0x04005422 RID: 21538
		[global::Cpp2ILInjected.Token(Token = "0x40066CF")]
		public const short HellArmoredBonesSword = 280;

		// Token: 0x04005423 RID: 21539
		[global::Cpp2ILInjected.Token(Token = "0x40066D0")]
		public const short RaggedCaster = 281;

		// Token: 0x04005424 RID: 21540
		[global::Cpp2ILInjected.Token(Token = "0x40066D1")]
		public const short RaggedCasterOpenCoat = 282;

		// Token: 0x04005425 RID: 21541
		[global::Cpp2ILInjected.Token(Token = "0x40066D2")]
		public const short Necromancer = 283;

		// Token: 0x04005426 RID: 21542
		[global::Cpp2ILInjected.Token(Token = "0x40066D3")]
		public const short NecromancerArmored = 284;

		// Token: 0x04005427 RID: 21543
		[global::Cpp2ILInjected.Token(Token = "0x40066D4")]
		public const short DiabolistRed = 285;

		// Token: 0x04005428 RID: 21544
		[global::Cpp2ILInjected.Token(Token = "0x40066D5")]
		public const short DiabolistWhite = 286;

		// Token: 0x04005429 RID: 21545
		[global::Cpp2ILInjected.Token(Token = "0x40066D6")]
		public const short BoneLee = 287;

		// Token: 0x0400542A RID: 21546
		[global::Cpp2ILInjected.Token(Token = "0x40066D7")]
		public const short DungeonSpirit = 288;

		// Token: 0x0400542B RID: 21547
		[global::Cpp2ILInjected.Token(Token = "0x40066D8")]
		public const short GiantCursedSkull = 289;

		// Token: 0x0400542C RID: 21548
		[global::Cpp2ILInjected.Token(Token = "0x40066D9")]
		public const short Paladin = 290;

		// Token: 0x0400542D RID: 21549
		[global::Cpp2ILInjected.Token(Token = "0x40066DA")]
		public const short SkeletonSniper = 291;

		// Token: 0x0400542E RID: 21550
		[global::Cpp2ILInjected.Token(Token = "0x40066DB")]
		public const short TacticalSkeleton = 292;

		// Token: 0x0400542F RID: 21551
		[global::Cpp2ILInjected.Token(Token = "0x40066DC")]
		public const short SkeletonCommando = 293;

		// Token: 0x04005430 RID: 21552
		[global::Cpp2ILInjected.Token(Token = "0x40066DD")]
		public const short AngryBonesBig = 294;

		// Token: 0x04005431 RID: 21553
		[global::Cpp2ILInjected.Token(Token = "0x40066DE")]
		public const short AngryBonesBigMuscle = 295;

		// Token: 0x04005432 RID: 21554
		[global::Cpp2ILInjected.Token(Token = "0x40066DF")]
		public const short AngryBonesBigHelmet = 296;

		// Token: 0x04005433 RID: 21555
		[global::Cpp2ILInjected.Token(Token = "0x40066E0")]
		public const short BirdBlue = 297;

		// Token: 0x04005434 RID: 21556
		[global::Cpp2ILInjected.Token(Token = "0x40066E1")]
		public const short BirdRed = 298;

		// Token: 0x04005435 RID: 21557
		[global::Cpp2ILInjected.Token(Token = "0x40066E2")]
		public const short Squirrel = 299;

		// Token: 0x04005436 RID: 21558
		[global::Cpp2ILInjected.Token(Token = "0x40066E3")]
		public const short Mouse = 300;

		// Token: 0x04005437 RID: 21559
		[global::Cpp2ILInjected.Token(Token = "0x40066E4")]
		public const short Raven = 301;

		// Token: 0x04005438 RID: 21560
		[global::Cpp2ILInjected.Token(Token = "0x40066E5")]
		public const short SlimeMasked = 302;

		// Token: 0x04005439 RID: 21561
		[global::Cpp2ILInjected.Token(Token = "0x40066E6")]
		public const short BunnySlimed = 303;

		// Token: 0x0400543A RID: 21562
		[global::Cpp2ILInjected.Token(Token = "0x40066E7")]
		public const short HoppinJack = 304;

		// Token: 0x0400543B RID: 21563
		[global::Cpp2ILInjected.Token(Token = "0x40066E8")]
		public const short Scarecrow1 = 305;

		// Token: 0x0400543C RID: 21564
		[global::Cpp2ILInjected.Token(Token = "0x40066E9")]
		public const short Scarecrow2 = 306;

		// Token: 0x0400543D RID: 21565
		[global::Cpp2ILInjected.Token(Token = "0x40066EA")]
		public const short Scarecrow3 = 307;

		// Token: 0x0400543E RID: 21566
		[global::Cpp2ILInjected.Token(Token = "0x40066EB")]
		public const short Scarecrow4 = 308;

		// Token: 0x0400543F RID: 21567
		[global::Cpp2ILInjected.Token(Token = "0x40066EC")]
		public const short Scarecrow5 = 309;

		// Token: 0x04005440 RID: 21568
		[global::Cpp2ILInjected.Token(Token = "0x40066ED")]
		public const short Scarecrow6 = 310;

		// Token: 0x04005441 RID: 21569
		[global::Cpp2ILInjected.Token(Token = "0x40066EE")]
		public const short Scarecrow7 = 311;

		// Token: 0x04005442 RID: 21570
		[global::Cpp2ILInjected.Token(Token = "0x40066EF")]
		public const short Scarecrow8 = 312;

		// Token: 0x04005443 RID: 21571
		[global::Cpp2ILInjected.Token(Token = "0x40066F0")]
		public const short Scarecrow9 = 313;

		// Token: 0x04005444 RID: 21572
		[global::Cpp2ILInjected.Token(Token = "0x40066F1")]
		public const short Scarecrow10 = 314;

		// Token: 0x04005445 RID: 21573
		[global::Cpp2ILInjected.Token(Token = "0x40066F2")]
		public const short HeadlessHorseman = 315;

		// Token: 0x04005446 RID: 21574
		[global::Cpp2ILInjected.Token(Token = "0x40066F3")]
		public const short Ghost = 316;

		// Token: 0x04005447 RID: 21575
		[global::Cpp2ILInjected.Token(Token = "0x40066F4")]
		public const short DemonEyeOwl = 317;

		// Token: 0x04005448 RID: 21576
		[global::Cpp2ILInjected.Token(Token = "0x40066F5")]
		public const short DemonEyeSpaceship = 318;

		// Token: 0x04005449 RID: 21577
		[global::Cpp2ILInjected.Token(Token = "0x40066F6")]
		public const short ZombieDoctor = 319;

		// Token: 0x0400544A RID: 21578
		[global::Cpp2ILInjected.Token(Token = "0x40066F7")]
		public const short ZombieSuperman = 320;

		// Token: 0x0400544B RID: 21579
		[global::Cpp2ILInjected.Token(Token = "0x40066F8")]
		public const short ZombiePixie = 321;

		// Token: 0x0400544C RID: 21580
		[global::Cpp2ILInjected.Token(Token = "0x40066F9")]
		public const short SkeletonTopHat = 322;

		// Token: 0x0400544D RID: 21581
		[global::Cpp2ILInjected.Token(Token = "0x40066FA")]
		public const short SkeletonAstonaut = 323;

		// Token: 0x0400544E RID: 21582
		[global::Cpp2ILInjected.Token(Token = "0x40066FB")]
		public const short SkeletonAlien = 324;

		// Token: 0x0400544F RID: 21583
		[global::Cpp2ILInjected.Token(Token = "0x40066FC")]
		public const short MourningWood = 325;

		// Token: 0x04005450 RID: 21584
		[global::Cpp2ILInjected.Token(Token = "0x40066FD")]
		public const short Splinterling = 326;

		// Token: 0x04005451 RID: 21585
		[global::Cpp2ILInjected.Token(Token = "0x40066FE")]
		public const short Pumpking = 327;

		// Token: 0x04005452 RID: 21586
		[global::Cpp2ILInjected.Token(Token = "0x40066FF")]
		public const short PumpkingBlade = 328;

		// Token: 0x04005453 RID: 21587
		[global::Cpp2ILInjected.Token(Token = "0x4006700")]
		public const short Hellhound = 329;

		// Token: 0x04005454 RID: 21588
		[global::Cpp2ILInjected.Token(Token = "0x4006701")]
		public const short Poltergeist = 330;

		// Token: 0x04005455 RID: 21589
		[global::Cpp2ILInjected.Token(Token = "0x4006702")]
		public const short ZombieXmas = 331;

		// Token: 0x04005456 RID: 21590
		[global::Cpp2ILInjected.Token(Token = "0x4006703")]
		public const short ZombieSweater = 332;

		// Token: 0x04005457 RID: 21591
		[global::Cpp2ILInjected.Token(Token = "0x4006704")]
		public const short SlimeRibbonWhite = 333;

		// Token: 0x04005458 RID: 21592
		[global::Cpp2ILInjected.Token(Token = "0x4006705")]
		public const short SlimeRibbonYellow = 334;

		// Token: 0x04005459 RID: 21593
		[global::Cpp2ILInjected.Token(Token = "0x4006706")]
		public const short SlimeRibbonGreen = 335;

		// Token: 0x0400545A RID: 21594
		[global::Cpp2ILInjected.Token(Token = "0x4006707")]
		public const short SlimeRibbonRed = 336;

		// Token: 0x0400545B RID: 21595
		[global::Cpp2ILInjected.Token(Token = "0x4006708")]
		public const short BunnyXmas = 337;

		// Token: 0x0400545C RID: 21596
		[global::Cpp2ILInjected.Token(Token = "0x4006709")]
		public const short ZombieElf = 338;

		// Token: 0x0400545D RID: 21597
		[global::Cpp2ILInjected.Token(Token = "0x400670A")]
		public const short ZombieElfBeard = 339;

		// Token: 0x0400545E RID: 21598
		[global::Cpp2ILInjected.Token(Token = "0x400670B")]
		public const short ZombieElfGirl = 340;

		// Token: 0x0400545F RID: 21599
		[global::Cpp2ILInjected.Token(Token = "0x400670C")]
		public const short PresentMimic = 341;

		// Token: 0x04005460 RID: 21600
		[global::Cpp2ILInjected.Token(Token = "0x400670D")]
		public const short GingerbreadMan = 342;

		// Token: 0x04005461 RID: 21601
		[global::Cpp2ILInjected.Token(Token = "0x400670E")]
		public const short Yeti = 343;

		// Token: 0x04005462 RID: 21602
		[global::Cpp2ILInjected.Token(Token = "0x400670F")]
		public const short Everscream = 344;

		// Token: 0x04005463 RID: 21603
		[global::Cpp2ILInjected.Token(Token = "0x4006710")]
		public const short IceQueen = 345;

		// Token: 0x04005464 RID: 21604
		[global::Cpp2ILInjected.Token(Token = "0x4006711")]
		public const short SantaNK1 = 346;

		// Token: 0x04005465 RID: 21605
		[global::Cpp2ILInjected.Token(Token = "0x4006712")]
		public const short ElfCopter = 347;

		// Token: 0x04005466 RID: 21606
		[global::Cpp2ILInjected.Token(Token = "0x4006713")]
		public const short Nutcracker = 348;

		// Token: 0x04005467 RID: 21607
		[global::Cpp2ILInjected.Token(Token = "0x4006714")]
		public const short NutcrackerSpinning = 349;

		// Token: 0x04005468 RID: 21608
		[global::Cpp2ILInjected.Token(Token = "0x4006715")]
		public const short ElfArcher = 350;

		// Token: 0x04005469 RID: 21609
		[global::Cpp2ILInjected.Token(Token = "0x4006716")]
		public const short Krampus = 351;

		// Token: 0x0400546A RID: 21610
		[global::Cpp2ILInjected.Token(Token = "0x4006717")]
		public const short Flocko = 352;

		// Token: 0x0400546B RID: 21611
		[global::Cpp2ILInjected.Token(Token = "0x4006718")]
		public const short Stylist = 353;

		// Token: 0x0400546C RID: 21612
		[global::Cpp2ILInjected.Token(Token = "0x4006719")]
		public const short WebbedStylist = 354;

		// Token: 0x0400546D RID: 21613
		[global::Cpp2ILInjected.Token(Token = "0x400671A")]
		public const short Firefly = 355;

		// Token: 0x0400546E RID: 21614
		[global::Cpp2ILInjected.Token(Token = "0x400671B")]
		public const short Butterfly = 356;

		// Token: 0x0400546F RID: 21615
		[global::Cpp2ILInjected.Token(Token = "0x400671C")]
		public const short Worm = 357;

		// Token: 0x04005470 RID: 21616
		[global::Cpp2ILInjected.Token(Token = "0x400671D")]
		public const short LightningBug = 358;

		// Token: 0x04005471 RID: 21617
		[global::Cpp2ILInjected.Token(Token = "0x400671E")]
		public const short Snail = 359;

		// Token: 0x04005472 RID: 21618
		[global::Cpp2ILInjected.Token(Token = "0x400671F")]
		public const short GlowingSnail = 360;

		// Token: 0x04005473 RID: 21619
		[global::Cpp2ILInjected.Token(Token = "0x4006720")]
		public const short Frog = 361;

		// Token: 0x04005474 RID: 21620
		[global::Cpp2ILInjected.Token(Token = "0x4006721")]
		public const short Duck = 362;

		// Token: 0x04005475 RID: 21621
		[global::Cpp2ILInjected.Token(Token = "0x4006722")]
		public const short Duck2 = 363;

		// Token: 0x04005476 RID: 21622
		[global::Cpp2ILInjected.Token(Token = "0x4006723")]
		public const short DuckWhite = 364;

		// Token: 0x04005477 RID: 21623
		[global::Cpp2ILInjected.Token(Token = "0x4006724")]
		public const short DuckWhite2 = 365;

		// Token: 0x04005478 RID: 21624
		[global::Cpp2ILInjected.Token(Token = "0x4006725")]
		public const short ScorpionBlack = 366;

		// Token: 0x04005479 RID: 21625
		[global::Cpp2ILInjected.Token(Token = "0x4006726")]
		public const short Scorpion = 367;

		// Token: 0x0400547A RID: 21626
		[global::Cpp2ILInjected.Token(Token = "0x4006727")]
		public const short TravellingMerchant = 368;

		// Token: 0x0400547B RID: 21627
		[global::Cpp2ILInjected.Token(Token = "0x4006728")]
		public const short Angler = 369;

		// Token: 0x0400547C RID: 21628
		[global::Cpp2ILInjected.Token(Token = "0x4006729")]
		public const short DukeFishron = 370;

		// Token: 0x0400547D RID: 21629
		[global::Cpp2ILInjected.Token(Token = "0x400672A")]
		public const short DetonatingBubble = 371;

		// Token: 0x0400547E RID: 21630
		[global::Cpp2ILInjected.Token(Token = "0x400672B")]
		public const short Sharkron = 372;

		// Token: 0x0400547F RID: 21631
		[global::Cpp2ILInjected.Token(Token = "0x400672C")]
		public const short Sharkron2 = 373;

		// Token: 0x04005480 RID: 21632
		[global::Cpp2ILInjected.Token(Token = "0x400672D")]
		public const short TruffleWorm = 374;

		// Token: 0x04005481 RID: 21633
		[global::Cpp2ILInjected.Token(Token = "0x400672E")]
		public const short TruffleWormDigger = 375;

		// Token: 0x04005482 RID: 21634
		[global::Cpp2ILInjected.Token(Token = "0x400672F")]
		public const short SleepingAngler = 376;

		// Token: 0x04005483 RID: 21635
		[global::Cpp2ILInjected.Token(Token = "0x4006730")]
		public const short Grasshopper = 377;

		// Token: 0x04005484 RID: 21636
		[global::Cpp2ILInjected.Token(Token = "0x4006731")]
		public const short ChatteringTeethBomb = 378;

		// Token: 0x04005485 RID: 21637
		[global::Cpp2ILInjected.Token(Token = "0x4006732")]
		public const short CultistArcherBlue = 379;

		// Token: 0x04005486 RID: 21638
		[global::Cpp2ILInjected.Token(Token = "0x4006733")]
		public const short CultistArcherWhite = 380;

		// Token: 0x04005487 RID: 21639
		[global::Cpp2ILInjected.Token(Token = "0x4006734")]
		public const short BrainScrambler = 381;

		// Token: 0x04005488 RID: 21640
		[global::Cpp2ILInjected.Token(Token = "0x4006735")]
		public const short RayGunner = 382;

		// Token: 0x04005489 RID: 21641
		[global::Cpp2ILInjected.Token(Token = "0x4006736")]
		public const short MartianOfficer = 383;

		// Token: 0x0400548A RID: 21642
		[global::Cpp2ILInjected.Token(Token = "0x4006737")]
		public const short ForceBubble = 384;

		// Token: 0x0400548B RID: 21643
		[global::Cpp2ILInjected.Token(Token = "0x4006738")]
		public const short GrayGrunt = 385;

		// Token: 0x0400548C RID: 21644
		[global::Cpp2ILInjected.Token(Token = "0x4006739")]
		public const short MartianEngineer = 386;

		// Token: 0x0400548D RID: 21645
		[global::Cpp2ILInjected.Token(Token = "0x400673A")]
		public const short MartianTurret = 387;

		// Token: 0x0400548E RID: 21646
		[global::Cpp2ILInjected.Token(Token = "0x400673B")]
		public const short MartianDrone = 388;

		// Token: 0x0400548F RID: 21647
		[global::Cpp2ILInjected.Token(Token = "0x400673C")]
		public const short GigaZapper = 389;

		// Token: 0x04005490 RID: 21648
		[global::Cpp2ILInjected.Token(Token = "0x400673D")]
		public const short ScutlixRider = 390;

		// Token: 0x04005491 RID: 21649
		[global::Cpp2ILInjected.Token(Token = "0x400673E")]
		public const short Scutlix = 391;

		// Token: 0x04005492 RID: 21650
		[global::Cpp2ILInjected.Token(Token = "0x400673F")]
		public const short MartianSaucer = 392;

		// Token: 0x04005493 RID: 21651
		[global::Cpp2ILInjected.Token(Token = "0x4006740")]
		public const short MartianSaucerTurret = 393;

		// Token: 0x04005494 RID: 21652
		[global::Cpp2ILInjected.Token(Token = "0x4006741")]
		public const short MartianSaucerCannon = 394;

		// Token: 0x04005495 RID: 21653
		[global::Cpp2ILInjected.Token(Token = "0x4006742")]
		public const short MartianSaucerCore = 395;

		// Token: 0x04005496 RID: 21654
		[global::Cpp2ILInjected.Token(Token = "0x4006743")]
		public const short MoonLordHead = 396;

		// Token: 0x04005497 RID: 21655
		[global::Cpp2ILInjected.Token(Token = "0x4006744")]
		public const short MoonLordHand = 397;

		// Token: 0x04005498 RID: 21656
		[global::Cpp2ILInjected.Token(Token = "0x4006745")]
		public const short MoonLordCore = 398;

		// Token: 0x04005499 RID: 21657
		[global::Cpp2ILInjected.Token(Token = "0x4006746")]
		public const short MartianProbe = 399;

		// Token: 0x0400549A RID: 21658
		[global::Cpp2ILInjected.Token(Token = "0x4006747")]
		public const short MoonLordFreeEye = 400;

		// Token: 0x0400549B RID: 21659
		[global::Cpp2ILInjected.Token(Token = "0x4006748")]
		public const short MoonLordLeechBlob = 401;

		// Token: 0x0400549C RID: 21660
		[global::Cpp2ILInjected.Token(Token = "0x4006749")]
		public const short StardustWormHead = 402;

		// Token: 0x0400549D RID: 21661
		[global::Cpp2ILInjected.Token(Token = "0x400674A")]
		public const short StardustWormBody = 403;

		// Token: 0x0400549E RID: 21662
		[global::Cpp2ILInjected.Token(Token = "0x400674B")]
		public const short StardustWormTail = 404;

		// Token: 0x0400549F RID: 21663
		[global::Cpp2ILInjected.Token(Token = "0x400674C")]
		public const short StardustCellBig = 405;

		// Token: 0x040054A0 RID: 21664
		[global::Cpp2ILInjected.Token(Token = "0x400674D")]
		public const short StardustCellSmall = 406;

		// Token: 0x040054A1 RID: 21665
		[global::Cpp2ILInjected.Token(Token = "0x400674E")]
		public const short StardustJellyfishBig = 407;

		// Token: 0x040054A2 RID: 21666
		[global::Cpp2ILInjected.Token(Token = "0x400674F")]
		public const short StardustJellyfishSmall = 408;

		// Token: 0x040054A3 RID: 21667
		[global::Cpp2ILInjected.Token(Token = "0x4006750")]
		public const short StardustSpiderBig = 409;

		// Token: 0x040054A4 RID: 21668
		[global::Cpp2ILInjected.Token(Token = "0x4006751")]
		public const short StardustSpiderSmall = 410;

		// Token: 0x040054A5 RID: 21669
		[global::Cpp2ILInjected.Token(Token = "0x4006752")]
		public const short StardustSoldier = 411;

		// Token: 0x040054A6 RID: 21670
		[global::Cpp2ILInjected.Token(Token = "0x4006753")]
		public const short SolarCrawltipedeHead = 412;

		// Token: 0x040054A7 RID: 21671
		[global::Cpp2ILInjected.Token(Token = "0x4006754")]
		public const short SolarCrawltipedeBody = 413;

		// Token: 0x040054A8 RID: 21672
		[global::Cpp2ILInjected.Token(Token = "0x4006755")]
		public const short SolarCrawltipedeTail = 414;

		// Token: 0x040054A9 RID: 21673
		[global::Cpp2ILInjected.Token(Token = "0x4006756")]
		public const short SolarDrakomire = 415;

		// Token: 0x040054AA RID: 21674
		[global::Cpp2ILInjected.Token(Token = "0x4006757")]
		public const short SolarDrakomireRider = 416;

		// Token: 0x040054AB RID: 21675
		[global::Cpp2ILInjected.Token(Token = "0x4006758")]
		public const short SolarSroller = 417;

		// Token: 0x040054AC RID: 21676
		[global::Cpp2ILInjected.Token(Token = "0x4006759")]
		public const short SolarCorite = 418;

		// Token: 0x040054AD RID: 21677
		[global::Cpp2ILInjected.Token(Token = "0x400675A")]
		public const short SolarSolenian = 419;

		// Token: 0x040054AE RID: 21678
		[global::Cpp2ILInjected.Token(Token = "0x400675B")]
		public const short NebulaBrain = 420;

		// Token: 0x040054AF RID: 21679
		[global::Cpp2ILInjected.Token(Token = "0x400675C")]
		public const short NebulaHeadcrab = 421;

		// Token: 0x040054B0 RID: 21680
		[global::Cpp2ILInjected.Token(Token = "0x400675D")]
		public const short NebulaBeast = 423;

		// Token: 0x040054B1 RID: 21681
		[global::Cpp2ILInjected.Token(Token = "0x400675E")]
		public const short NebulaSoldier = 424;

		// Token: 0x040054B2 RID: 21682
		[global::Cpp2ILInjected.Token(Token = "0x400675F")]
		public const short VortexRifleman = 425;

		// Token: 0x040054B3 RID: 21683
		[global::Cpp2ILInjected.Token(Token = "0x4006760")]
		public const short VortexHornetQueen = 426;

		// Token: 0x040054B4 RID: 21684
		[global::Cpp2ILInjected.Token(Token = "0x4006761")]
		public const short VortexHornet = 427;

		// Token: 0x040054B5 RID: 21685
		[global::Cpp2ILInjected.Token(Token = "0x4006762")]
		public const short VortexLarva = 428;

		// Token: 0x040054B6 RID: 21686
		[global::Cpp2ILInjected.Token(Token = "0x4006763")]
		public const short VortexSoldier = 429;

		// Token: 0x040054B7 RID: 21687
		[global::Cpp2ILInjected.Token(Token = "0x4006764")]
		public const short ArmedZombie = 430;

		// Token: 0x040054B8 RID: 21688
		[global::Cpp2ILInjected.Token(Token = "0x4006765")]
		public const short ArmedZombieEskimo = 431;

		// Token: 0x040054B9 RID: 21689
		[global::Cpp2ILInjected.Token(Token = "0x4006766")]
		public const short ArmedZombiePincussion = 432;

		// Token: 0x040054BA RID: 21690
		[global::Cpp2ILInjected.Token(Token = "0x4006767")]
		public const short ArmedZombieSlimed = 433;

		// Token: 0x040054BB RID: 21691
		[global::Cpp2ILInjected.Token(Token = "0x4006768")]
		public const short ArmedZombieSwamp = 434;

		// Token: 0x040054BC RID: 21692
		[global::Cpp2ILInjected.Token(Token = "0x4006769")]
		public const short ArmedZombieTwiggy = 435;

		// Token: 0x040054BD RID: 21693
		[global::Cpp2ILInjected.Token(Token = "0x400676A")]
		public const short ArmedZombieCenx = 436;

		// Token: 0x040054BE RID: 21694
		[global::Cpp2ILInjected.Token(Token = "0x400676B")]
		public const short CultistTablet = 437;

		// Token: 0x040054BF RID: 21695
		[global::Cpp2ILInjected.Token(Token = "0x400676C")]
		public const short CultistDevote = 438;

		// Token: 0x040054C0 RID: 21696
		[global::Cpp2ILInjected.Token(Token = "0x400676D")]
		public const short CultistBoss = 439;

		// Token: 0x040054C1 RID: 21697
		[global::Cpp2ILInjected.Token(Token = "0x400676E")]
		public const short CultistBossClone = 440;

		// Token: 0x040054C2 RID: 21698
		[global::Cpp2ILInjected.Token(Token = "0x400676F")]
		public const short GoldBird = 442;

		// Token: 0x040054C3 RID: 21699
		[global::Cpp2ILInjected.Token(Token = "0x4006770")]
		public const short GoldBunny = 443;

		// Token: 0x040054C4 RID: 21700
		[global::Cpp2ILInjected.Token(Token = "0x4006771")]
		public const short GoldButterfly = 444;

		// Token: 0x040054C5 RID: 21701
		[global::Cpp2ILInjected.Token(Token = "0x4006772")]
		public const short GoldFrog = 445;

		// Token: 0x040054C6 RID: 21702
		[global::Cpp2ILInjected.Token(Token = "0x4006773")]
		public const short GoldGrasshopper = 446;

		// Token: 0x040054C7 RID: 21703
		[global::Cpp2ILInjected.Token(Token = "0x4006774")]
		public const short GoldMouse = 447;

		// Token: 0x040054C8 RID: 21704
		[global::Cpp2ILInjected.Token(Token = "0x4006775")]
		public const short GoldWorm = 448;

		// Token: 0x040054C9 RID: 21705
		[global::Cpp2ILInjected.Token(Token = "0x4006776")]
		public const short BoneThrowingSkeleton = 449;

		// Token: 0x040054CA RID: 21706
		[global::Cpp2ILInjected.Token(Token = "0x4006777")]
		public const short BoneThrowingSkeleton2 = 450;

		// Token: 0x040054CB RID: 21707
		[global::Cpp2ILInjected.Token(Token = "0x4006778")]
		public const short BoneThrowingSkeleton3 = 451;

		// Token: 0x040054CC RID: 21708
		[global::Cpp2ILInjected.Token(Token = "0x4006779")]
		public const short BoneThrowingSkeleton4 = 452;

		// Token: 0x040054CD RID: 21709
		[global::Cpp2ILInjected.Token(Token = "0x400677A")]
		public const short SkeletonMerchant = 453;

		// Token: 0x040054CE RID: 21710
		[global::Cpp2ILInjected.Token(Token = "0x400677B")]
		public const short CultistDragonHead = 454;

		// Token: 0x040054CF RID: 21711
		[global::Cpp2ILInjected.Token(Token = "0x400677C")]
		public const short CultistDragonBody1 = 455;

		// Token: 0x040054D0 RID: 21712
		[global::Cpp2ILInjected.Token(Token = "0x400677D")]
		public const short CultistDragonBody2 = 456;

		// Token: 0x040054D1 RID: 21713
		[global::Cpp2ILInjected.Token(Token = "0x400677E")]
		public const short CultistDragonBody3 = 457;

		// Token: 0x040054D2 RID: 21714
		[global::Cpp2ILInjected.Token(Token = "0x400677F")]
		public const short CultistDragonBody4 = 458;

		// Token: 0x040054D3 RID: 21715
		[global::Cpp2ILInjected.Token(Token = "0x4006780")]
		public const short CultistDragonTail = 459;

		// Token: 0x040054D4 RID: 21716
		[global::Cpp2ILInjected.Token(Token = "0x4006781")]
		public const short Butcher = 460;

		// Token: 0x040054D5 RID: 21717
		[global::Cpp2ILInjected.Token(Token = "0x4006782")]
		public const short CreatureFromTheDeep = 461;

		// Token: 0x040054D6 RID: 21718
		[global::Cpp2ILInjected.Token(Token = "0x4006783")]
		public const short Fritz = 462;

		// Token: 0x040054D7 RID: 21719
		[global::Cpp2ILInjected.Token(Token = "0x4006784")]
		public const short Nailhead = 463;

		// Token: 0x040054D8 RID: 21720
		[global::Cpp2ILInjected.Token(Token = "0x4006785")]
		public const short CrimsonBunny = 464;

		// Token: 0x040054D9 RID: 21721
		[global::Cpp2ILInjected.Token(Token = "0x4006786")]
		public const short CrimsonGoldfish = 465;

		// Token: 0x040054DA RID: 21722
		[global::Cpp2ILInjected.Token(Token = "0x4006787")]
		public const short Psycho = 466;

		// Token: 0x040054DB RID: 21723
		[global::Cpp2ILInjected.Token(Token = "0x4006788")]
		public const short DeadlySphere = 467;

		// Token: 0x040054DC RID: 21724
		[global::Cpp2ILInjected.Token(Token = "0x4006789")]
		public const short DrManFly = 468;

		// Token: 0x040054DD RID: 21725
		[global::Cpp2ILInjected.Token(Token = "0x400678A")]
		public const short ThePossessed = 469;

		// Token: 0x040054DE RID: 21726
		[global::Cpp2ILInjected.Token(Token = "0x400678B")]
		public const short CrimsonPenguin = 470;

		// Token: 0x040054DF RID: 21727
		[global::Cpp2ILInjected.Token(Token = "0x400678C")]
		public const short GoblinSummoner = 471;

		// Token: 0x040054E0 RID: 21728
		[global::Cpp2ILInjected.Token(Token = "0x400678D")]
		public const short ShadowFlameApparition = 472;

		// Token: 0x040054E1 RID: 21729
		[global::Cpp2ILInjected.Token(Token = "0x400678E")]
		public const short BigMimicCorruption = 473;

		// Token: 0x040054E2 RID: 21730
		[global::Cpp2ILInjected.Token(Token = "0x400678F")]
		public const short BigMimicCrimson = 474;

		// Token: 0x040054E3 RID: 21731
		[global::Cpp2ILInjected.Token(Token = "0x4006790")]
		public const short BigMimicHallow = 475;

		// Token: 0x040054E4 RID: 21732
		[global::Cpp2ILInjected.Token(Token = "0x4006791")]
		public const short BigMimicJungle = 476;

		// Token: 0x040054E5 RID: 21733
		[global::Cpp2ILInjected.Token(Token = "0x4006792")]
		public const short Mothron = 477;

		// Token: 0x040054E6 RID: 21734
		[global::Cpp2ILInjected.Token(Token = "0x4006793")]
		public const short MothronEgg = 478;

		// Token: 0x040054E7 RID: 21735
		[global::Cpp2ILInjected.Token(Token = "0x4006794")]
		public const short MothronSpawn = 479;

		// Token: 0x040054E8 RID: 21736
		[global::Cpp2ILInjected.Token(Token = "0x4006795")]
		public const short Medusa = 480;

		// Token: 0x040054E9 RID: 21737
		[global::Cpp2ILInjected.Token(Token = "0x4006796")]
		public const short GreekSkeleton = 481;

		// Token: 0x040054EA RID: 21738
		[global::Cpp2ILInjected.Token(Token = "0x4006797")]
		public const short GraniteGolem = 482;

		// Token: 0x040054EB RID: 21739
		[global::Cpp2ILInjected.Token(Token = "0x4006798")]
		public const short GraniteFlyer = 483;

		// Token: 0x040054EC RID: 21740
		[global::Cpp2ILInjected.Token(Token = "0x4006799")]
		public const short EnchantedNightcrawler = 484;

		// Token: 0x040054ED RID: 21741
		[global::Cpp2ILInjected.Token(Token = "0x400679A")]
		public const short Grubby = 485;

		// Token: 0x040054EE RID: 21742
		[global::Cpp2ILInjected.Token(Token = "0x400679B")]
		public const short Sluggy = 486;

		// Token: 0x040054EF RID: 21743
		[global::Cpp2ILInjected.Token(Token = "0x400679C")]
		public const short Buggy = 487;

		// Token: 0x040054F0 RID: 21744
		[global::Cpp2ILInjected.Token(Token = "0x400679D")]
		public const short TargetDummy = 488;

		// Token: 0x040054F1 RID: 21745
		[global::Cpp2ILInjected.Token(Token = "0x400679E")]
		public const short BloodZombie = 489;

		// Token: 0x040054F2 RID: 21746
		[global::Cpp2ILInjected.Token(Token = "0x400679F")]
		public const short Drippler = 490;

		// Token: 0x040054F3 RID: 21747
		[global::Cpp2ILInjected.Token(Token = "0x40067A0")]
		public const short PirateShip = 491;

		// Token: 0x040054F4 RID: 21748
		[global::Cpp2ILInjected.Token(Token = "0x40067A1")]
		public const short PirateShipCannon = 492;

		// Token: 0x040054F5 RID: 21749
		[global::Cpp2ILInjected.Token(Token = "0x40067A2")]
		public const short LunarTowerStardust = 493;

		// Token: 0x040054F6 RID: 21750
		[global::Cpp2ILInjected.Token(Token = "0x40067A3")]
		public const short Crawdad = 494;

		// Token: 0x040054F7 RID: 21751
		[global::Cpp2ILInjected.Token(Token = "0x40067A4")]
		public const short Crawdad2 = 495;

		// Token: 0x040054F8 RID: 21752
		[global::Cpp2ILInjected.Token(Token = "0x40067A5")]
		public const short GiantShelly = 496;

		// Token: 0x040054F9 RID: 21753
		[global::Cpp2ILInjected.Token(Token = "0x40067A6")]
		public const short GiantShelly2 = 497;

		// Token: 0x040054FA RID: 21754
		[global::Cpp2ILInjected.Token(Token = "0x40067A7")]
		public const short Salamander = 498;

		// Token: 0x040054FB RID: 21755
		[global::Cpp2ILInjected.Token(Token = "0x40067A8")]
		public const short Salamander2 = 499;

		// Token: 0x040054FC RID: 21756
		[global::Cpp2ILInjected.Token(Token = "0x40067A9")]
		public const short Salamander3 = 500;

		// Token: 0x040054FD RID: 21757
		[global::Cpp2ILInjected.Token(Token = "0x40067AA")]
		public const short Salamander4 = 501;

		// Token: 0x040054FE RID: 21758
		[global::Cpp2ILInjected.Token(Token = "0x40067AB")]
		public const short Salamander5 = 502;

		// Token: 0x040054FF RID: 21759
		[global::Cpp2ILInjected.Token(Token = "0x40067AC")]
		public const short Salamander6 = 503;

		// Token: 0x04005500 RID: 21760
		[global::Cpp2ILInjected.Token(Token = "0x40067AD")]
		public const short Salamander7 = 504;

		// Token: 0x04005501 RID: 21761
		[global::Cpp2ILInjected.Token(Token = "0x40067AE")]
		public const short Salamander8 = 505;

		// Token: 0x04005502 RID: 21762
		[global::Cpp2ILInjected.Token(Token = "0x40067AF")]
		public const short Salamander9 = 506;

		// Token: 0x04005503 RID: 21763
		[global::Cpp2ILInjected.Token(Token = "0x40067B0")]
		public const short LunarTowerNebula = 507;

		// Token: 0x04005504 RID: 21764
		[global::Cpp2ILInjected.Token(Token = "0x40067B1")]
		public const short LunarTowerVortex = 422;

		// Token: 0x04005505 RID: 21765
		[global::Cpp2ILInjected.Token(Token = "0x40067B2")]
		public const short TaxCollector = 441;

		// Token: 0x04005506 RID: 21766
		[global::Cpp2ILInjected.Token(Token = "0x40067B3")]
		public const short GiantWalkingAntlion = 508;

		// Token: 0x04005507 RID: 21767
		[global::Cpp2ILInjected.Token(Token = "0x40067B4")]
		public const short GiantFlyingAntlion = 509;

		// Token: 0x04005508 RID: 21768
		[global::Cpp2ILInjected.Token(Token = "0x40067B5")]
		public const short DuneSplicerHead = 510;

		// Token: 0x04005509 RID: 21769
		[global::Cpp2ILInjected.Token(Token = "0x40067B6")]
		public const short DuneSplicerBody = 511;

		// Token: 0x0400550A RID: 21770
		[global::Cpp2ILInjected.Token(Token = "0x40067B7")]
		public const short DuneSplicerTail = 512;

		// Token: 0x0400550B RID: 21771
		[global::Cpp2ILInjected.Token(Token = "0x40067B8")]
		public const short TombCrawlerHead = 513;

		// Token: 0x0400550C RID: 21772
		[global::Cpp2ILInjected.Token(Token = "0x40067B9")]
		public const short TombCrawlerBody = 514;

		// Token: 0x0400550D RID: 21773
		[global::Cpp2ILInjected.Token(Token = "0x40067BA")]
		public const short TombCrawlerTail = 515;

		// Token: 0x0400550E RID: 21774
		[global::Cpp2ILInjected.Token(Token = "0x40067BB")]
		public const short SolarFlare = 516;

		// Token: 0x0400550F RID: 21775
		[global::Cpp2ILInjected.Token(Token = "0x40067BC")]
		public const short LunarTowerSolar = 517;

		// Token: 0x04005510 RID: 21776
		[global::Cpp2ILInjected.Token(Token = "0x40067BD")]
		public const short SolarSpearman = 518;

		// Token: 0x04005511 RID: 21777
		[global::Cpp2ILInjected.Token(Token = "0x40067BE")]
		public const short SolarGoop = 519;

		// Token: 0x04005512 RID: 21778
		[global::Cpp2ILInjected.Token(Token = "0x40067BF")]
		public const short MartianWalker = 520;

		// Token: 0x04005513 RID: 21779
		[global::Cpp2ILInjected.Token(Token = "0x40067C0")]
		public const short AncientCultistSquidhead = 521;

		// Token: 0x04005514 RID: 21780
		[global::Cpp2ILInjected.Token(Token = "0x40067C1")]
		public const short AncientLight = 522;

		// Token: 0x04005515 RID: 21781
		[global::Cpp2ILInjected.Token(Token = "0x40067C2")]
		public const short AncientDoom = 523;

		// Token: 0x04005516 RID: 21782
		[global::Cpp2ILInjected.Token(Token = "0x40067C3")]
		public const short DesertGhoul = 524;

		// Token: 0x04005517 RID: 21783
		[global::Cpp2ILInjected.Token(Token = "0x40067C4")]
		public const short DesertGhoulCorruption = 525;

		// Token: 0x04005518 RID: 21784
		[global::Cpp2ILInjected.Token(Token = "0x40067C5")]
		public const short DesertGhoulCrimson = 526;

		// Token: 0x04005519 RID: 21785
		[global::Cpp2ILInjected.Token(Token = "0x40067C6")]
		public const short DesertGhoulHallow = 527;

		// Token: 0x0400551A RID: 21786
		[global::Cpp2ILInjected.Token(Token = "0x40067C7")]
		public const short DesertLamiaLight = 528;

		// Token: 0x0400551B RID: 21787
		[global::Cpp2ILInjected.Token(Token = "0x40067C8")]
		public const short DesertLamiaDark = 529;

		// Token: 0x0400551C RID: 21788
		[global::Cpp2ILInjected.Token(Token = "0x40067C9")]
		public const short DesertScorpionWalk = 530;

		// Token: 0x0400551D RID: 21789
		[global::Cpp2ILInjected.Token(Token = "0x40067CA")]
		public const short DesertScorpionWall = 531;

		// Token: 0x0400551E RID: 21790
		[global::Cpp2ILInjected.Token(Token = "0x40067CB")]
		public const short DesertBeast = 532;

		// Token: 0x0400551F RID: 21791
		[global::Cpp2ILInjected.Token(Token = "0x40067CC")]
		public const short DesertDjinn = 533;

		// Token: 0x04005520 RID: 21792
		[global::Cpp2ILInjected.Token(Token = "0x40067CD")]
		public const short DemonTaxCollector = 534;

		// Token: 0x04005521 RID: 21793
		[global::Cpp2ILInjected.Token(Token = "0x40067CE")]
		public const short SlimeSpiked = 535;

		// Token: 0x04005522 RID: 21794
		[global::Cpp2ILInjected.Token(Token = "0x40067CF")]
		public const short TheBride = 536;

		// Token: 0x04005523 RID: 21795
		[global::Cpp2ILInjected.Token(Token = "0x40067D0")]
		public const short SandSlime = 537;

		// Token: 0x04005524 RID: 21796
		[global::Cpp2ILInjected.Token(Token = "0x40067D1")]
		public const short SquirrelRed = 538;

		// Token: 0x04005525 RID: 21797
		[global::Cpp2ILInjected.Token(Token = "0x40067D2")]
		public const short SquirrelGold = 539;

		// Token: 0x04005526 RID: 21798
		[global::Cpp2ILInjected.Token(Token = "0x40067D3")]
		public const short PartyBunny = 540;

		// Token: 0x04005527 RID: 21799
		[global::Cpp2ILInjected.Token(Token = "0x40067D4")]
		public const short SandElemental = 541;

		// Token: 0x04005528 RID: 21800
		[global::Cpp2ILInjected.Token(Token = "0x40067D5")]
		public const short SandShark = 542;

		// Token: 0x04005529 RID: 21801
		[global::Cpp2ILInjected.Token(Token = "0x40067D6")]
		public const short SandsharkCorrupt = 543;

		// Token: 0x0400552A RID: 21802
		[global::Cpp2ILInjected.Token(Token = "0x40067D7")]
		public const short SandsharkCrimson = 544;

		// Token: 0x0400552B RID: 21803
		[global::Cpp2ILInjected.Token(Token = "0x40067D8")]
		public const short SandsharkHallow = 545;

		// Token: 0x0400552C RID: 21804
		[global::Cpp2ILInjected.Token(Token = "0x40067D9")]
		public const short Tumbleweed = 546;

		// Token: 0x0400552D RID: 21805
		[global::Cpp2ILInjected.Token(Token = "0x40067DA")]
		public const short DD2AttackerTest = 547;

		// Token: 0x0400552E RID: 21806
		[global::Cpp2ILInjected.Token(Token = "0x40067DB")]
		public const short DD2EterniaCrystal = 548;

		// Token: 0x0400552F RID: 21807
		[global::Cpp2ILInjected.Token(Token = "0x40067DC")]
		public const short DD2LanePortal = 549;

		// Token: 0x04005530 RID: 21808
		[global::Cpp2ILInjected.Token(Token = "0x40067DD")]
		public const short DD2Bartender = 550;

		// Token: 0x04005531 RID: 21809
		[global::Cpp2ILInjected.Token(Token = "0x40067DE")]
		public const short DD2Betsy = 551;

		// Token: 0x04005532 RID: 21810
		[global::Cpp2ILInjected.Token(Token = "0x40067DF")]
		public const short DD2GoblinT1 = 552;

		// Token: 0x04005533 RID: 21811
		[global::Cpp2ILInjected.Token(Token = "0x40067E0")]
		public const short DD2GoblinT2 = 553;

		// Token: 0x04005534 RID: 21812
		[global::Cpp2ILInjected.Token(Token = "0x40067E1")]
		public const short DD2GoblinT3 = 554;

		// Token: 0x04005535 RID: 21813
		[global::Cpp2ILInjected.Token(Token = "0x40067E2")]
		public const short DD2GoblinBomberT1 = 555;

		// Token: 0x04005536 RID: 21814
		[global::Cpp2ILInjected.Token(Token = "0x40067E3")]
		public const short DD2GoblinBomberT2 = 556;

		// Token: 0x04005537 RID: 21815
		[global::Cpp2ILInjected.Token(Token = "0x40067E4")]
		public const short DD2GoblinBomberT3 = 557;

		// Token: 0x04005538 RID: 21816
		[global::Cpp2ILInjected.Token(Token = "0x40067E5")]
		public const short DD2WyvernT1 = 558;

		// Token: 0x04005539 RID: 21817
		[global::Cpp2ILInjected.Token(Token = "0x40067E6")]
		public const short DD2WyvernT2 = 559;

		// Token: 0x0400553A RID: 21818
		[global::Cpp2ILInjected.Token(Token = "0x40067E7")]
		public const short DD2WyvernT3 = 560;

		// Token: 0x0400553B RID: 21819
		[global::Cpp2ILInjected.Token(Token = "0x40067E8")]
		public const short DD2JavelinstT1 = 561;

		// Token: 0x0400553C RID: 21820
		[global::Cpp2ILInjected.Token(Token = "0x40067E9")]
		public const short DD2JavelinstT2 = 562;

		// Token: 0x0400553D RID: 21821
		[global::Cpp2ILInjected.Token(Token = "0x40067EA")]
		public const short DD2JavelinstT3 = 563;

		// Token: 0x0400553E RID: 21822
		[global::Cpp2ILInjected.Token(Token = "0x40067EB")]
		public const short DD2DarkMageT1 = 564;

		// Token: 0x0400553F RID: 21823
		[global::Cpp2ILInjected.Token(Token = "0x40067EC")]
		public const short DD2DarkMageT3 = 565;

		// Token: 0x04005540 RID: 21824
		[global::Cpp2ILInjected.Token(Token = "0x40067ED")]
		public const short DD2SkeletonT1 = 566;

		// Token: 0x04005541 RID: 21825
		[global::Cpp2ILInjected.Token(Token = "0x40067EE")]
		public const short DD2SkeletonT3 = 567;

		// Token: 0x04005542 RID: 21826
		[global::Cpp2ILInjected.Token(Token = "0x40067EF")]
		public const short DD2WitherBeastT2 = 568;

		// Token: 0x04005543 RID: 21827
		[global::Cpp2ILInjected.Token(Token = "0x40067F0")]
		public const short DD2WitherBeastT3 = 569;

		// Token: 0x04005544 RID: 21828
		[global::Cpp2ILInjected.Token(Token = "0x40067F1")]
		public const short DD2DrakinT2 = 570;

		// Token: 0x04005545 RID: 21829
		[global::Cpp2ILInjected.Token(Token = "0x40067F2")]
		public const short DD2DrakinT3 = 571;

		// Token: 0x04005546 RID: 21830
		[global::Cpp2ILInjected.Token(Token = "0x40067F3")]
		public const short DD2KoboldWalkerT2 = 572;

		// Token: 0x04005547 RID: 21831
		[global::Cpp2ILInjected.Token(Token = "0x40067F4")]
		public const short DD2KoboldWalkerT3 = 573;

		// Token: 0x04005548 RID: 21832
		[global::Cpp2ILInjected.Token(Token = "0x40067F5")]
		public const short DD2KoboldFlyerT2 = 574;

		// Token: 0x04005549 RID: 21833
		[global::Cpp2ILInjected.Token(Token = "0x40067F6")]
		public const short DD2KoboldFlyerT3 = 575;

		// Token: 0x0400554A RID: 21834
		[global::Cpp2ILInjected.Token(Token = "0x40067F7")]
		public const short DD2OgreT2 = 576;

		// Token: 0x0400554B RID: 21835
		[global::Cpp2ILInjected.Token(Token = "0x40067F8")]
		public const short DD2OgreT3 = 577;

		// Token: 0x0400554C RID: 21836
		[global::Cpp2ILInjected.Token(Token = "0x40067F9")]
		public const short DD2LightningBugT3 = 578;

		// Token: 0x0400554D RID: 21837
		[global::Cpp2ILInjected.Token(Token = "0x40067FA")]
		public const short BartenderUnconscious = 579;

		// Token: 0x0400554E RID: 21838
		[global::Cpp2ILInjected.Token(Token = "0x40067FB")]
		public const short WalkingAntlion = 580;

		// Token: 0x0400554F RID: 21839
		[global::Cpp2ILInjected.Token(Token = "0x40067FC")]
		public const short FlyingAntlion = 581;

		// Token: 0x04005550 RID: 21840
		[global::Cpp2ILInjected.Token(Token = "0x40067FD")]
		public const short LarvaeAntlion = 582;

		// Token: 0x04005551 RID: 21841
		[global::Cpp2ILInjected.Token(Token = "0x40067FE")]
		public const short FairyCritterPink = 583;

		// Token: 0x04005552 RID: 21842
		[global::Cpp2ILInjected.Token(Token = "0x40067FF")]
		public const short FairyCritterGreen = 584;

		// Token: 0x04005553 RID: 21843
		[global::Cpp2ILInjected.Token(Token = "0x4006800")]
		public const short FairyCritterBlue = 585;

		// Token: 0x04005554 RID: 21844
		[global::Cpp2ILInjected.Token(Token = "0x4006801")]
		public const short ZombieMerman = 586;

		// Token: 0x04005555 RID: 21845
		[global::Cpp2ILInjected.Token(Token = "0x4006802")]
		public const short EyeballFlyingFish = 587;

		// Token: 0x04005556 RID: 21846
		[global::Cpp2ILInjected.Token(Token = "0x4006803")]
		public const short Golfer = 588;

		// Token: 0x04005557 RID: 21847
		[global::Cpp2ILInjected.Token(Token = "0x4006804")]
		public const short GolferRescue = 589;

		// Token: 0x04005558 RID: 21848
		[global::Cpp2ILInjected.Token(Token = "0x4006805")]
		public const short TorchZombie = 590;

		// Token: 0x04005559 RID: 21849
		[global::Cpp2ILInjected.Token(Token = "0x4006806")]
		public const short ArmedTorchZombie = 591;

		// Token: 0x0400555A RID: 21850
		[global::Cpp2ILInjected.Token(Token = "0x4006807")]
		public const short GoldGoldfish = 592;

		// Token: 0x0400555B RID: 21851
		[global::Cpp2ILInjected.Token(Token = "0x4006808")]
		public const short GoldGoldfishWalker = 593;

		// Token: 0x0400555C RID: 21852
		[global::Cpp2ILInjected.Token(Token = "0x4006809")]
		public const short WindyBalloon = 594;

		// Token: 0x0400555D RID: 21853
		[global::Cpp2ILInjected.Token(Token = "0x400680A")]
		public const short BlackDragonfly = 595;

		// Token: 0x0400555E RID: 21854
		[global::Cpp2ILInjected.Token(Token = "0x400680B")]
		public const short BlueDragonfly = 596;

		// Token: 0x0400555F RID: 21855
		[global::Cpp2ILInjected.Token(Token = "0x400680C")]
		public const short GreenDragonfly = 597;

		// Token: 0x04005560 RID: 21856
		[global::Cpp2ILInjected.Token(Token = "0x400680D")]
		public const short OrangeDragonfly = 598;

		// Token: 0x04005561 RID: 21857
		[global::Cpp2ILInjected.Token(Token = "0x400680E")]
		public const short RedDragonfly = 599;

		// Token: 0x04005562 RID: 21858
		[global::Cpp2ILInjected.Token(Token = "0x400680F")]
		public const short YellowDragonfly = 600;

		// Token: 0x04005563 RID: 21859
		[global::Cpp2ILInjected.Token(Token = "0x4006810")]
		public const short GoldDragonfly = 601;

		// Token: 0x04005564 RID: 21860
		[global::Cpp2ILInjected.Token(Token = "0x4006811")]
		public const short Seagull = 602;

		// Token: 0x04005565 RID: 21861
		[global::Cpp2ILInjected.Token(Token = "0x4006812")]
		public const short Seagull2 = 603;

		// Token: 0x04005566 RID: 21862
		[global::Cpp2ILInjected.Token(Token = "0x4006813")]
		public const short LadyBug = 604;

		// Token: 0x04005567 RID: 21863
		[global::Cpp2ILInjected.Token(Token = "0x4006814")]
		public const short GoldLadyBug = 605;

		// Token: 0x04005568 RID: 21864
		[global::Cpp2ILInjected.Token(Token = "0x4006815")]
		public const short Maggot = 606;

		// Token: 0x04005569 RID: 21865
		[global::Cpp2ILInjected.Token(Token = "0x4006816")]
		public const short Pupfish = 607;

		// Token: 0x0400556A RID: 21866
		[global::Cpp2ILInjected.Token(Token = "0x4006817")]
		public const short Grebe = 608;

		// Token: 0x0400556B RID: 21867
		[global::Cpp2ILInjected.Token(Token = "0x4006818")]
		public const short Grebe2 = 609;

		// Token: 0x0400556C RID: 21868
		[global::Cpp2ILInjected.Token(Token = "0x4006819")]
		public const short Rat = 610;

		// Token: 0x0400556D RID: 21869
		[global::Cpp2ILInjected.Token(Token = "0x400681A")]
		public const short Owl = 611;

		// Token: 0x0400556E RID: 21870
		[global::Cpp2ILInjected.Token(Token = "0x400681B")]
		public const short WaterStrider = 612;

		// Token: 0x0400556F RID: 21871
		[global::Cpp2ILInjected.Token(Token = "0x400681C")]
		public const short GoldWaterStrider = 613;

		// Token: 0x04005570 RID: 21872
		[global::Cpp2ILInjected.Token(Token = "0x400681D")]
		public const short ExplosiveBunny = 614;

		// Token: 0x04005571 RID: 21873
		[global::Cpp2ILInjected.Token(Token = "0x400681E")]
		public const short Dolphin = 615;

		// Token: 0x04005572 RID: 21874
		[global::Cpp2ILInjected.Token(Token = "0x400681F")]
		public const short Turtle = 616;

		// Token: 0x04005573 RID: 21875
		[global::Cpp2ILInjected.Token(Token = "0x4006820")]
		public const short TurtleJungle = 617;

		// Token: 0x04005574 RID: 21876
		[global::Cpp2ILInjected.Token(Token = "0x4006821")]
		public const short BloodNautilus = 618;

		// Token: 0x04005575 RID: 21877
		[global::Cpp2ILInjected.Token(Token = "0x4006822")]
		public const short BloodSquid = 619;

		// Token: 0x04005576 RID: 21878
		[global::Cpp2ILInjected.Token(Token = "0x4006823")]
		public const short GoblinShark = 620;

		// Token: 0x04005577 RID: 21879
		[global::Cpp2ILInjected.Token(Token = "0x4006824")]
		public const short BloodEelHead = 621;

		// Token: 0x04005578 RID: 21880
		[global::Cpp2ILInjected.Token(Token = "0x4006825")]
		public const short BloodEelBody = 622;

		// Token: 0x04005579 RID: 21881
		[global::Cpp2ILInjected.Token(Token = "0x4006826")]
		public const short BloodEelTail = 623;

		// Token: 0x0400557A RID: 21882
		[global::Cpp2ILInjected.Token(Token = "0x4006827")]
		public const short Gnome = 624;

		// Token: 0x0400557B RID: 21883
		[global::Cpp2ILInjected.Token(Token = "0x4006828")]
		public const short SeaTurtle = 625;

		// Token: 0x0400557C RID: 21884
		[global::Cpp2ILInjected.Token(Token = "0x4006829")]
		public const short Seahorse = 626;

		// Token: 0x0400557D RID: 21885
		[global::Cpp2ILInjected.Token(Token = "0x400682A")]
		public const short GoldSeahorse = 627;

		// Token: 0x0400557E RID: 21886
		[global::Cpp2ILInjected.Token(Token = "0x400682B")]
		public const short Dandelion = 628;

		// Token: 0x0400557F RID: 21887
		[global::Cpp2ILInjected.Token(Token = "0x400682C")]
		public const short IceMimic = 629;

		// Token: 0x04005580 RID: 21888
		[global::Cpp2ILInjected.Token(Token = "0x400682D")]
		public const short BloodMummy = 630;

		// Token: 0x04005581 RID: 21889
		[global::Cpp2ILInjected.Token(Token = "0x400682E")]
		public const short RockGolem = 631;

		// Token: 0x04005582 RID: 21890
		[global::Cpp2ILInjected.Token(Token = "0x400682F")]
		public const short MaggotZombie = 632;

		// Token: 0x04005583 RID: 21891
		[global::Cpp2ILInjected.Token(Token = "0x4006830")]
		public const short BestiaryGirl = 633;

		// Token: 0x04005584 RID: 21892
		[global::Cpp2ILInjected.Token(Token = "0x4006831")]
		public const short SporeBat = 634;

		// Token: 0x04005585 RID: 21893
		[global::Cpp2ILInjected.Token(Token = "0x4006832")]
		public const short SporeSkeleton = 635;

		// Token: 0x04005586 RID: 21894
		[global::Cpp2ILInjected.Token(Token = "0x4006833")]
		public const short HallowBoss = 636;

		// Token: 0x04005587 RID: 21895
		[global::Cpp2ILInjected.Token(Token = "0x4006834")]
		public const short TownCat = 637;

		// Token: 0x04005588 RID: 21896
		[global::Cpp2ILInjected.Token(Token = "0x4006835")]
		public const short TownDog = 638;

		// Token: 0x04005589 RID: 21897
		[global::Cpp2ILInjected.Token(Token = "0x4006836")]
		public const short GemSquirrelAmethyst = 639;

		// Token: 0x0400558A RID: 21898
		[global::Cpp2ILInjected.Token(Token = "0x4006837")]
		public const short GemSquirrelTopaz = 640;

		// Token: 0x0400558B RID: 21899
		[global::Cpp2ILInjected.Token(Token = "0x4006838")]
		public const short GemSquirrelSapphire = 641;

		// Token: 0x0400558C RID: 21900
		[global::Cpp2ILInjected.Token(Token = "0x4006839")]
		public const short GemSquirrelEmerald = 642;

		// Token: 0x0400558D RID: 21901
		[global::Cpp2ILInjected.Token(Token = "0x400683A")]
		public const short GemSquirrelRuby = 643;

		// Token: 0x0400558E RID: 21902
		[global::Cpp2ILInjected.Token(Token = "0x400683B")]
		public const short GemSquirrelDiamond = 644;

		// Token: 0x0400558F RID: 21903
		[global::Cpp2ILInjected.Token(Token = "0x400683C")]
		public const short GemSquirrelAmber = 645;

		// Token: 0x04005590 RID: 21904
		[global::Cpp2ILInjected.Token(Token = "0x400683D")]
		public const short GemBunnyAmethyst = 646;

		// Token: 0x04005591 RID: 21905
		[global::Cpp2ILInjected.Token(Token = "0x400683E")]
		public const short GemBunnyTopaz = 647;

		// Token: 0x04005592 RID: 21906
		[global::Cpp2ILInjected.Token(Token = "0x400683F")]
		public const short GemBunnySapphire = 648;

		// Token: 0x04005593 RID: 21907
		[global::Cpp2ILInjected.Token(Token = "0x4006840")]
		public const short GemBunnyEmerald = 649;

		// Token: 0x04005594 RID: 21908
		[global::Cpp2ILInjected.Token(Token = "0x4006841")]
		public const short GemBunnyRuby = 650;

		// Token: 0x04005595 RID: 21909
		[global::Cpp2ILInjected.Token(Token = "0x4006842")]
		public const short GemBunnyDiamond = 651;

		// Token: 0x04005596 RID: 21910
		[global::Cpp2ILInjected.Token(Token = "0x4006843")]
		public const short GemBunnyAmber = 652;

		// Token: 0x04005597 RID: 21911
		[global::Cpp2ILInjected.Token(Token = "0x4006844")]
		public const short HellButterfly = 653;

		// Token: 0x04005598 RID: 21912
		[global::Cpp2ILInjected.Token(Token = "0x4006845")]
		public const short Lavafly = 654;

		// Token: 0x04005599 RID: 21913
		[global::Cpp2ILInjected.Token(Token = "0x4006846")]
		public const short MagmaSnail = 655;

		// Token: 0x0400559A RID: 21914
		[global::Cpp2ILInjected.Token(Token = "0x4006847")]
		public const short TownBunny = 656;

		// Token: 0x0400559B RID: 21915
		[global::Cpp2ILInjected.Token(Token = "0x4006848")]
		public const short QueenSlimeBoss = 657;

		// Token: 0x0400559C RID: 21916
		[global::Cpp2ILInjected.Token(Token = "0x4006849")]
		public const short QueenSlimeMinionBlue = 658;

		// Token: 0x0400559D RID: 21917
		[global::Cpp2ILInjected.Token(Token = "0x400684A")]
		public const short QueenSlimeMinionPink = 659;

		// Token: 0x0400559E RID: 21918
		[global::Cpp2ILInjected.Token(Token = "0x400684B")]
		public const short QueenSlimeMinionPurple = 660;

		// Token: 0x0400559F RID: 21919
		[global::Cpp2ILInjected.Token(Token = "0x400684C")]
		public const short EmpressButterfly = 661;

		// Token: 0x040055A0 RID: 21920
		[global::Cpp2ILInjected.Token(Token = "0x400684D")]
		public const short PirateGhost = 662;

		// Token: 0x040055A1 RID: 21921
		[global::Cpp2ILInjected.Token(Token = "0x400684E")]
		public const short Princess = 663;

		// Token: 0x040055A2 RID: 21922
		[global::Cpp2ILInjected.Token(Token = "0x400684F")]
		public const short TorchGod = 664;

		// Token: 0x040055A3 RID: 21923
		[global::Cpp2ILInjected.Token(Token = "0x4006850")]
		public const short ChaosBallTim = 665;

		// Token: 0x040055A4 RID: 21924
		[global::Cpp2ILInjected.Token(Token = "0x4006851")]
		public const short VileSpitEaterOfWorlds = 666;

		// Token: 0x040055A5 RID: 21925
		[global::Cpp2ILInjected.Token(Token = "0x4006852")]
		public const short GoldenSlime = 667;

		// Token: 0x040055A6 RID: 21926
		[global::Cpp2ILInjected.Token(Token = "0x4006853")]
		public const short Deerclops = 668;

		// Token: 0x040055A7 RID: 21927
		[global::Cpp2ILInjected.Token(Token = "0x4006854")]
		public const short Stinkbug = 669;

		// Token: 0x040055A8 RID: 21928
		[global::Cpp2ILInjected.Token(Token = "0x4006855")]
		public const short TownSlimeBlue = 670;

		// Token: 0x040055A9 RID: 21929
		[global::Cpp2ILInjected.Token(Token = "0x4006856")]
		public const short ScarletMacaw = 671;

		// Token: 0x040055AA RID: 21930
		[global::Cpp2ILInjected.Token(Token = "0x4006857")]
		public const short BlueMacaw = 672;

		// Token: 0x040055AB RID: 21931
		[global::Cpp2ILInjected.Token(Token = "0x4006858")]
		public const short Toucan = 673;

		// Token: 0x040055AC RID: 21932
		[global::Cpp2ILInjected.Token(Token = "0x4006859")]
		public const short YellowCockatiel = 674;

		// Token: 0x040055AD RID: 21933
		[global::Cpp2ILInjected.Token(Token = "0x400685A")]
		public const short GrayCockatiel = 675;

		// Token: 0x040055AE RID: 21934
		[global::Cpp2ILInjected.Token(Token = "0x400685B")]
		public const short ShimmerSlime = 676;

		// Token: 0x040055AF RID: 21935
		[global::Cpp2ILInjected.Token(Token = "0x400685C")]
		public const short Shimmerfly = 677;

		// Token: 0x040055B0 RID: 21936
		[global::Cpp2ILInjected.Token(Token = "0x400685D")]
		public const short TownSlimeGreen = 678;

		// Token: 0x040055B1 RID: 21937
		[global::Cpp2ILInjected.Token(Token = "0x400685E")]
		public const short TownSlimeOld = 679;

		// Token: 0x040055B2 RID: 21938
		[global::Cpp2ILInjected.Token(Token = "0x400685F")]
		public const short TownSlimePurple = 680;

		// Token: 0x040055B3 RID: 21939
		[global::Cpp2ILInjected.Token(Token = "0x4006860")]
		public const short TownSlimeRainbow = 681;

		// Token: 0x040055B4 RID: 21940
		[global::Cpp2ILInjected.Token(Token = "0x4006861")]
		public const short TownSlimeRed = 682;

		// Token: 0x040055B5 RID: 21941
		[global::Cpp2ILInjected.Token(Token = "0x4006862")]
		public const short TownSlimeYellow = 683;

		// Token: 0x040055B6 RID: 21942
		[global::Cpp2ILInjected.Token(Token = "0x4006863")]
		public const short TownSlimeCopper = 684;

		// Token: 0x040055B7 RID: 21943
		[global::Cpp2ILInjected.Token(Token = "0x4006864")]
		public const short BoundTownSlimeOld = 685;

		// Token: 0x040055B8 RID: 21944
		[global::Cpp2ILInjected.Token(Token = "0x4006865")]
		public const short BoundTownSlimePurple = 686;

		// Token: 0x040055B9 RID: 21945
		[global::Cpp2ILInjected.Token(Token = "0x4006866")]
		public const short BoundTownSlimeYellow = 687;

		// Token: 0x040055BA RID: 21946
		[global::Cpp2ILInjected.Token(Token = "0x4006867")]
		public const short Count = 688;

		// Token: 0x040055BB RID: 21947
		[global::Cpp2ILInjected.Token(Token = "0x4006868")]
		public static readonly IdDictionary Search;

		// Token: 0x02000922 RID: 2338
		[global::Cpp2ILInjected.Token(Token = "0x20005E0")]
		public static class Sets
		{
			// Token: 0x06004C79 RID: 19577 RVA: 0x0002F894 File Offset: 0x0002DA94
			[global::Cpp2ILInjected.Token(Token = "0x6003567")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B2644", Offset = "0x13B2644", Length = "0x4A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "GetRedigitEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "GetLeinforsEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "GetGroxEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffsetCreation()
			{
				throw null;
			}

			// Token: 0x06004C7A RID: 19578 RVA: 0x0002F897 File Offset: 0x0002DA97
			[global::Cpp2ILInjected.Token(Token = "0x6003568")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B2AE4", Offset = "0x13B2AE4", Length = "0xBE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets.NPCBestiaryDrawModifiers), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetRedigitEntries()
			{
				throw null;
			}

			// Token: 0x06004C7B RID: 19579 RVA: 0x0002F89A File Offset: 0x0002DA9A
			[global::Cpp2ILInjected.Token(Token = "0x6003569")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B36C4", Offset = "0x13B36C4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetGroxEntries()
			{
				throw null;
			}

			// Token: 0x06004C7C RID: 19580 RVA: 0x0002F89D File Offset: 0x0002DA9D
			[global::Cpp2ILInjected.Token(Token = "0x600356A")]
			[global::Cpp2ILInjected.Address(RVA = "0x13A1FD0", Offset = "0x13A1FD0", Length = "0x10674")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets.NPCBestiaryDrawModifiers), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 683)]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetLeinforsEntries()
			{
				throw null;
			}

			// Token: 0x06004C7D RID: 19581 RVA: 0x0002F8A0 File Offset: 0x0002DAA0
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600356B")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B372C", Offset = "0x13B372C", Length = "0xEE6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCDebuffImmunityData), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int[])
			}, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int[])
			}, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(float),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(byte)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(Color) }, MemberParameters = new object[]
			{
				typeof(Color),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1351)]
			static Sets()
			{
				throw null;
			}

			// Token: 0x040089CC RID: 35276
			[global::Cpp2ILInjected.Token(Token = "0x4006869")]
			public static SetFactory Factory;

			// Token: 0x040089CD RID: 35277
			[global::Cpp2ILInjected.Token(Token = "0x400686A")]
			public static Dictionary<int, int> SpecialSpawningRules;

			// Token: 0x040089CE RID: 35278
			[global::Cpp2ILInjected.Token(Token = "0x400686B")]
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffset;

			// Token: 0x040089CF RID: 35279
			[global::Cpp2ILInjected.Token(Token = "0x400686C")]
			public static Dictionary<int, NPCDebuffImmunityData> DebuffImmunitySets;

			// Token: 0x040089D0 RID: 35280
			[global::Cpp2ILInjected.Token(Token = "0x400686D")]
			public static List<int> NormalGoldCritterBestiaryPriority;

			// Token: 0x040089D1 RID: 35281
			[global::Cpp2ILInjected.Token(Token = "0x400686E")]
			public static List<int> BossBestiaryPriority;

			// Token: 0x040089D2 RID: 35282
			[global::Cpp2ILInjected.Token(Token = "0x400686F")]
			public static List<int> TownNPCBestiaryPriority;

			// Token: 0x040089D3 RID: 35283
			[global::Cpp2ILInjected.Token(Token = "0x4006870")]
			public static bool[] DontDoHardmodeScaling;

			// Token: 0x040089D4 RID: 35284
			[global::Cpp2ILInjected.Token(Token = "0x4006871")]
			public static bool[] ReflectStarShotsInForTheWorthy;

			// Token: 0x040089D5 RID: 35285
			[global::Cpp2ILInjected.Token(Token = "0x4006872")]
			public static bool[] IsTownPet;

			// Token: 0x040089D6 RID: 35286
			[global::Cpp2ILInjected.Token(Token = "0x4006873")]
			public static bool[] IsTownSlime;

			// Token: 0x040089D7 RID: 35287
			[global::Cpp2ILInjected.Token(Token = "0x4006874")]
			public static bool[] CanConvertIntoCopperSlimeTownNPC;

			// Token: 0x040089D8 RID: 35288
			[global::Cpp2ILInjected.Token(Token = "0x4006875")]
			public static List<int> GoldCrittersCollection;

			// Token: 0x040089D9 RID: 35289
			[global::Cpp2ILInjected.Token(Token = "0x4006876")]
			public static bool[] ZappingJellyfish;

			// Token: 0x040089DA RID: 35290
			[global::Cpp2ILInjected.Token(Token = "0x4006877")]
			public static bool[] CantTakeLunchMoney;

			// Token: 0x040089DB RID: 35291
			[global::Cpp2ILInjected.Token(Token = "0x4006878")]
			public static Dictionary<int, int> RespawnEnemyID;

			// Token: 0x040089DC RID: 35292
			[global::Cpp2ILInjected.Token(Token = "0x4006879")]
			public static int[] TrailingMode;

			// Token: 0x040089DD RID: 35293
			[global::Cpp2ILInjected.Token(Token = "0x400687A")]
			public static bool[] IsDragonfly;

			// Token: 0x040089DE RID: 35294
			[global::Cpp2ILInjected.Token(Token = "0x400687B")]
			public static bool[] BelongsToInvasionOldOnesArmy;

			// Token: 0x040089DF RID: 35295
			[global::Cpp2ILInjected.Token(Token = "0x400687C")]
			public static bool[] TeleportationImmune;

			// Token: 0x040089E0 RID: 35296
			[global::Cpp2ILInjected.Token(Token = "0x400687D")]
			public static bool[] UsesNewTargetting;

			// Token: 0x040089E1 RID: 35297
			[global::Cpp2ILInjected.Token(Token = "0x400687E")]
			public static bool[] TakesDamageFromHostilesWithoutBeingFriendly;

			// Token: 0x040089E2 RID: 35298
			[global::Cpp2ILInjected.Token(Token = "0x400687F")]
			public static bool[] AllNPCs;

			// Token: 0x040089E3 RID: 35299
			[global::Cpp2ILInjected.Token(Token = "0x4006880")]
			public static bool[] HurtingBees;

			// Token: 0x040089E4 RID: 35300
			[global::Cpp2ILInjected.Token(Token = "0x4006881")]
			public static bool[] FighterUsesDD2PortalAppearEffect;

			// Token: 0x040089E5 RID: 35301
			[global::Cpp2ILInjected.Token(Token = "0x4006882")]
			public static float[] StatueSpawnedDropRarity;

			// Token: 0x040089E6 RID: 35302
			[global::Cpp2ILInjected.Token(Token = "0x4006883")]
			public static bool[] NoEarlymodeLootWhenSpawnedFromStatue;

			// Token: 0x040089E7 RID: 35303
			[global::Cpp2ILInjected.Token(Token = "0x4006884")]
			public static bool[] NeedsExpertScaling;

			// Token: 0x040089E8 RID: 35304
			[global::Cpp2ILInjected.Token(Token = "0x4006885")]
			public static bool[] ProjectileNPC;

			// Token: 0x040089E9 RID: 35305
			[global::Cpp2ILInjected.Token(Token = "0x4006886")]
			public static bool[] SavesAndLoads;

			// Token: 0x040089EA RID: 35306
			[global::Cpp2ILInjected.Token(Token = "0x4006887")]
			public static int[] TrailCacheLength;

			// Token: 0x040089EB RID: 35307
			[global::Cpp2ILInjected.Token(Token = "0x4006888")]
			public static bool[] UsesMultiplayerProximitySyncing;

			// Token: 0x040089EC RID: 35308
			[global::Cpp2ILInjected.Token(Token = "0x4006889")]
			public static bool[] NoMultiplayerSmoothingByType;

			// Token: 0x040089ED RID: 35309
			[global::Cpp2ILInjected.Token(Token = "0x400688A")]
			public static bool[] NoMultiplayerSmoothingByAI;

			// Token: 0x040089EE RID: 35310
			[global::Cpp2ILInjected.Token(Token = "0x400688B")]
			public static bool[] MPAllowedEnemies;

			// Token: 0x040089EF RID: 35311
			[global::Cpp2ILInjected.Token(Token = "0x400688C")]
			public static bool[] TownCritter;

			// Token: 0x040089F0 RID: 35312
			[global::Cpp2ILInjected.Token(Token = "0x400688D")]
			public static bool[] CountsAsCritter;

			// Token: 0x040089F1 RID: 35313
			[global::Cpp2ILInjected.Token(Token = "0x400688E")]
			public static bool[] HasNoPartyText;

			// Token: 0x040089F2 RID: 35314
			[global::Cpp2ILInjected.Token(Token = "0x400688F")]
			public static int[] HatOffsetY;

			// Token: 0x040089F3 RID: 35315
			[global::Cpp2ILInjected.Token(Token = "0x4006890")]
			public static int[] FaceEmote;

			// Token: 0x040089F4 RID: 35316
			[global::Cpp2ILInjected.Token(Token = "0x4006891")]
			public static int[] ExtraFramesCount;

			// Token: 0x040089F5 RID: 35317
			[global::Cpp2ILInjected.Token(Token = "0x4006892")]
			public static int[] AttackFrameCount;

			// Token: 0x040089F6 RID: 35318
			[global::Cpp2ILInjected.Token(Token = "0x4006893")]
			public static int[] DangerDetectRange;

			// Token: 0x040089F7 RID: 35319
			[global::Cpp2ILInjected.Token(Token = "0x4006894")]
			public static bool[] ShimmerImmunity;

			// Token: 0x040089F8 RID: 35320
			[global::Cpp2ILInjected.Token(Token = "0x4006895")]
			public static int[] ShimmerTransformToItem;

			// Token: 0x040089F9 RID: 35321
			[global::Cpp2ILInjected.Token(Token = "0x4006896")]
			public static bool[] ShimmerTownTransform;

			// Token: 0x040089FA RID: 35322
			[global::Cpp2ILInjected.Token(Token = "0x4006897")]
			public static int[] ShimmerTransformToNPC;

			// Token: 0x040089FB RID: 35323
			[global::Cpp2ILInjected.Token(Token = "0x4006898")]
			public static int[] AttackTime;

			// Token: 0x040089FC RID: 35324
			[global::Cpp2ILInjected.Token(Token = "0x4006899")]
			public static int[] AttackAverageChance;

			// Token: 0x040089FD RID: 35325
			[global::Cpp2ILInjected.Token(Token = "0x400689A")]
			public static int[] AttackType;

			// Token: 0x040089FE RID: 35326
			[global::Cpp2ILInjected.Token(Token = "0x400689B")]
			public static int[] PrettySafe;

			// Token: 0x040089FF RID: 35327
			[global::Cpp2ILInjected.Token(Token = "0x400689C")]
			public static Color[] MagicAuraColor;

			// Token: 0x04008A00 RID: 35328
			[global::Cpp2ILInjected.Token(Token = "0x400689D")]
			public static bool[] DemonEyes;

			// Token: 0x04008A01 RID: 35329
			[global::Cpp2ILInjected.Token(Token = "0x400689E")]
			public static bool[] Zombies;

			// Token: 0x04008A02 RID: 35330
			[global::Cpp2ILInjected.Token(Token = "0x400689F")]
			public static bool[] Skeletons;

			// Token: 0x04008A03 RID: 35331
			[global::Cpp2ILInjected.Token(Token = "0x40068A0")]
			public static int[] BossHeadTextures;

			// Token: 0x04008A04 RID: 35332
			[global::Cpp2ILInjected.Token(Token = "0x40068A1")]
			public static bool[] PositiveNPCTypesExcludedFromDeathTally;

			// Token: 0x04008A05 RID: 35333
			[global::Cpp2ILInjected.Token(Token = "0x40068A2")]
			public static bool[] ShouldBeCountedAsBoss;

			// Token: 0x04008A06 RID: 35334
			[global::Cpp2ILInjected.Token(Token = "0x40068A3")]
			public static bool[] DangerThatPreventsOtherDangers;

			// Token: 0x04008A07 RID: 35335
			[global::Cpp2ILInjected.Token(Token = "0x40068A4")]
			public static bool[] MustAlwaysDraw;

			// Token: 0x04008A08 RID: 35336
			[global::Cpp2ILInjected.Token(Token = "0x40068A5")]
			public static bool[] ExpandedCullDraw;

			// Token: 0x04008A09 RID: 35337
			[global::Cpp2ILInjected.Token(Token = "0x40068A6")]
			public static int[] ExtraTextureCount;

			// Token: 0x04008A0A RID: 35338
			[global::Cpp2ILInjected.Token(Token = "0x40068A7")]
			public static int[] NPCFramingGroup;

			// Token: 0x04008A0B RID: 35339
			[global::Cpp2ILInjected.Token(Token = "0x40068A8")]
			public static bool[] CanHitPastShimmer;

			// Token: 0x04008A0C RID: 35340
			[global::Cpp2ILInjected.Token(Token = "0x40068A9")]
			public static int[][] TownNPCsFramingGroups;

			// Token: 0x02000B79 RID: 2937
			[global::Cpp2ILInjected.Token(Token = "0x20005E1")]
			public struct NPCBestiaryDrawModifiers
			{
				// Token: 0x06005376 RID: 21366 RVA: 0x00030B54 File Offset: 0x0002ED54
				[global::Cpp2ILInjected.Token(Token = "0x600356C")]
				[global::Cpp2ILInjected.Address(RVA = "0x13C775C", Offset = "0x13C775C", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "GetRedigitEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "GetLeinforsEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 700)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				public NPCBestiaryDrawModifiers(int seriouslyWhyCantStructsHaveParameterlessConstructors)
				{
					throw null;
				}

				// Token: 0x04009097 RID: 37015
				[global::Cpp2ILInjected.Token(Token = "0x40068AA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public Vector2 Position;

				// Token: 0x04009098 RID: 37016
				[global::Cpp2ILInjected.Token(Token = "0x40068AB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				public float? PortraitPositionXOverride;

				// Token: 0x04009099 RID: 37017
				[global::Cpp2ILInjected.Token(Token = "0x40068AC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public float? PortraitPositionYOverride;

				// Token: 0x0400909A RID: 37018
				[global::Cpp2ILInjected.Token(Token = "0x40068AD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public float Rotation;

				// Token: 0x0400909B RID: 37019
				[global::Cpp2ILInjected.Token(Token = "0x40068AE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				public float Scale;

				// Token: 0x0400909C RID: 37020
				[global::Cpp2ILInjected.Token(Token = "0x40068AF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				public float? PortraitScale;

				// Token: 0x0400909D RID: 37021
				[global::Cpp2ILInjected.Token(Token = "0x40068B0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				public bool Hide;

				// Token: 0x0400909E RID: 37022
				[global::Cpp2ILInjected.Token(Token = "0x40068B1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
				public bool IsWet;

				// Token: 0x0400909F RID: 37023
				[global::Cpp2ILInjected.Token(Token = "0x40068B2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
				public int? Frame;

				// Token: 0x040090A0 RID: 37024
				[global::Cpp2ILInjected.Token(Token = "0x40068B3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
				public int? Direction;

				// Token: 0x040090A1 RID: 37025
				[global::Cpp2ILInjected.Token(Token = "0x40068B4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
				public int? SpriteDirection;

				// Token: 0x040090A2 RID: 37026
				[global::Cpp2ILInjected.Token(Token = "0x40068B5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
				public float Velocity;

				// Token: 0x040090A3 RID: 37027
				[global::Cpp2ILInjected.Token(Token = "0x40068B6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
				public string CustomTexturePath;
			}

			// Token: 0x02000B7A RID: 2938
			[global::Cpp2ILInjected.Token(Token = "0x20005E2")]
			private static class LocalBuffID
			{
				// Token: 0x040090A4 RID: 37028
				[global::Cpp2ILInjected.Token(Token = "0x40068B7")]
				public const int Confused = 31;

				// Token: 0x040090A5 RID: 37029
				[global::Cpp2ILInjected.Token(Token = "0x40068B8")]
				public const int Poisoned = 20;

				// Token: 0x040090A6 RID: 37030
				[global::Cpp2ILInjected.Token(Token = "0x40068B9")]
				public const int OnFire = 24;

				// Token: 0x040090A7 RID: 37031
				[global::Cpp2ILInjected.Token(Token = "0x40068BA")]
				public const int OnFire3 = 323;

				// Token: 0x040090A8 RID: 37032
				[global::Cpp2ILInjected.Token(Token = "0x40068BB")]
				public const int ShadowFlame = 153;

				// Token: 0x040090A9 RID: 37033
				[global::Cpp2ILInjected.Token(Token = "0x40068BC")]
				public const int Daybreak = 189;

				// Token: 0x040090AA RID: 37034
				[global::Cpp2ILInjected.Token(Token = "0x40068BD")]
				public const int Frostburn = 44;

				// Token: 0x040090AB RID: 37035
				[global::Cpp2ILInjected.Token(Token = "0x40068BE")]
				public const int Frostburn2 = 324;

				// Token: 0x040090AC RID: 37036
				[global::Cpp2ILInjected.Token(Token = "0x40068BF")]
				public const int CursedInferno = 39;

				// Token: 0x040090AD RID: 37037
				[global::Cpp2ILInjected.Token(Token = "0x40068C0")]
				public const int BetsysCurse = 203;

				// Token: 0x040090AE RID: 37038
				[global::Cpp2ILInjected.Token(Token = "0x40068C1")]
				public const int Ichor = 69;

				// Token: 0x040090AF RID: 37039
				[global::Cpp2ILInjected.Token(Token = "0x40068C2")]
				public const int Venom = 70;

				// Token: 0x040090B0 RID: 37040
				[global::Cpp2ILInjected.Token(Token = "0x40068C3")]
				public const int Oiled = 204;

				// Token: 0x040090B1 RID: 37041
				[global::Cpp2ILInjected.Token(Token = "0x40068C4")]
				public const int BoneJavelin = 169;

				// Token: 0x040090B2 RID: 37042
				[global::Cpp2ILInjected.Token(Token = "0x40068C5")]
				public const int TentacleSpike = 337;

				// Token: 0x040090B3 RID: 37043
				[global::Cpp2ILInjected.Token(Token = "0x40068C6")]
				public const int BloodButcherer = 344;
			}
		}
	}
}
