using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Items;

namespace Terraria.IO
{
	// Token: 0x020003C4 RID: 964
	[global::Cpp2ILInjected.Token(Token = "0x200056A")]
	public static class ItemConversion_OldMobile
	{
		// Token: 0x06002F5F RID: 12127 RVA: 0x0002A767 File Offset: 0x00028967
		[global::Cpp2ILInjected.Token(Token = "0x60033CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340C1C", Offset = "0x1340C1C", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "LoadOld", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldMobile), Member = "GetCoinItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref short),
			typeof(ref short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ModifyItem(ref short itemId, ref short itemStack, ref byte prefix, bool chestConversion = false)
		{
			throw null;
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x0002A76A File Offset: 0x0002896A
		[global::Cpp2ILInjected.Token(Token = "0x60033CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1341244", Offset = "0x1341244", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemConversion_OldMobile), Member = "ModifyItem", MemberParameters = new object[]
		{
			typeof(ref short),
			typeof(ref short),
			typeof(ref byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static void GetCoinItem(int coinValue, ref short itemId, ref short itemStack)
		{
			throw null;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x0002A76D File Offset: 0x0002896D
		[global::Cpp2ILInjected.Token(Token = "0x60033CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1341320", Offset = "0x1341320", Length = "0x430")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool ModifyBodySlot(ref int slot)
		{
			throw null;
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0002A770 File Offset: 0x00028970
		[global::Cpp2ILInjected.Token(Token = "0x60033CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1341750", Offset = "0x1341750", Length = "0x5E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool ModifyHeadSlot(ref int slot)
		{
			throw null;
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0002A773 File Offset: 0x00028973
		[global::Cpp2ILInjected.Token(Token = "0x60033CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1341D30", Offset = "0x1341D30", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool ModifyLegSlot(ref int slot)
		{
			throw null;
		}

		// Token: 0x040032B5 RID: 12981
		[global::Cpp2ILInjected.Token(Token = "0x4003C6B")]
		public static int CompensatedCurrency;

		// Token: 0x020008F6 RID: 2294
		[global::Cpp2ILInjected.Token(Token = "0x200056B")]
		private enum ARMOR_BODY_SLOTS
		{
			// Token: 0x0400815A RID: 33114
			[global::Cpp2ILInjected.Token(Token = "0x4003C6D")]
			COPPER_CHAINMAIL = 1,
			// Token: 0x0400815B RID: 33115
			[global::Cpp2ILInjected.Token(Token = "0x4003C6E")]
			IRON_CHAINMAIL,
			// Token: 0x0400815C RID: 33116
			[global::Cpp2ILInjected.Token(Token = "0x4003C6F")]
			SILVER_CHAINMAIL,
			// Token: 0x0400815D RID: 33117
			[global::Cpp2ILInjected.Token(Token = "0x4003C70")]
			GOLD_CHAINMAIL,
			// Token: 0x0400815E RID: 33118
			[global::Cpp2ILInjected.Token(Token = "0x4003C71")]
			SHADOW_SCALEMAIL,
			// Token: 0x0400815F RID: 33119
			[global::Cpp2ILInjected.Token(Token = "0x4003C72")]
			METEOR_SUIT,
			// Token: 0x04008160 RID: 33120
			[global::Cpp2ILInjected.Token(Token = "0x4003C73")]
			NECRO_BREASTPLATE,
			// Token: 0x04008161 RID: 33121
			[global::Cpp2ILInjected.Token(Token = "0x4003C74")]
			JUNGLE_SHIRT,
			// Token: 0x04008162 RID: 33122
			[global::Cpp2ILInjected.Token(Token = "0x4003C75")]
			MOLTEN_BREASTPLATE,
			// Token: 0x04008163 RID: 33123
			[global::Cpp2ILInjected.Token(Token = "0x4003C76")]
			TUXEDO_SHIRT,
			// Token: 0x04008164 RID: 33124
			[global::Cpp2ILInjected.Token(Token = "0x4003C77")]
			PLUMBERS_SHIRT,
			// Token: 0x04008165 RID: 33125
			[global::Cpp2ILInjected.Token(Token = "0x4003C78")]
			HEROS_SHIRT,
			// Token: 0x04008166 RID: 33126
			[global::Cpp2ILInjected.Token(Token = "0x4003C79")]
			ARCHAEOLOGISTS_JACKET,
			// Token: 0x04008167 RID: 33127
			[global::Cpp2ILInjected.Token(Token = "0x4003C7A")]
			NINJA_SHIRT,
			// Token: 0x04008168 RID: 33128
			[global::Cpp2ILInjected.Token(Token = "0x4003C7B")]
			ROBE,
			// Token: 0x04008169 RID: 33129
			[global::Cpp2ILInjected.Token(Token = "0x4003C7C")]
			THE_DOCTORS_SHIRT,
			// Token: 0x0400816A RID: 33130
			[global::Cpp2ILInjected.Token(Token = "0x4003C7D")]
			COBALT_BREASTPLATE,
			// Token: 0x0400816B RID: 33131
			[global::Cpp2ILInjected.Token(Token = "0x4003C7E")]
			MYTHRIL_CHAINMAIL,
			// Token: 0x0400816C RID: 33132
			[global::Cpp2ILInjected.Token(Token = "0x4003C7F")]
			ADAMANTITE_BREASTPLATE,
			// Token: 0x0400816D RID: 33133
			[global::Cpp2ILInjected.Token(Token = "0x4003C80")]
			MINING_SHIRT,
			// Token: 0x0400816E RID: 33134
			[global::Cpp2ILInjected.Token(Token = "0x4003C81")]
			WEREWOLF,
			// Token: 0x0400816F RID: 33135
			[global::Cpp2ILInjected.Token(Token = "0x4003C82")]
			MERMAN,
			// Token: 0x04008170 RID: 33136
			[global::Cpp2ILInjected.Token(Token = "0x4003C83")]
			CLOWN_SHIRT,
			// Token: 0x04008171 RID: 33137
			[global::Cpp2ILInjected.Token(Token = "0x4003C84")]
			HALLOWED_PLATE_MAIL,
			// Token: 0x04008172 RID: 33138
			[global::Cpp2ILInjected.Token(Token = "0x4003C85")]
			SANTA_SHIRT,
			// Token: 0x04008173 RID: 33139
			[global::Cpp2ILInjected.Token(Token = "0x4003C86")]
			REDS_BREASTPLATE,
			// Token: 0x04008174 RID: 33140
			[global::Cpp2ILInjected.Token(Token = "0x4003C87")]
			FROST_BREASTPLATE,
			// Token: 0x04008175 RID: 33141
			[global::Cpp2ILInjected.Token(Token = "0x4003C88")]
			TIN_CHAINMAIL,
			// Token: 0x04008176 RID: 33142
			[global::Cpp2ILInjected.Token(Token = "0x4003C89")]
			LEAD_CHAINMAIL,
			// Token: 0x04008177 RID: 33143
			[global::Cpp2ILInjected.Token(Token = "0x4003C8A")]
			TUNGSTEN_CHAINMAIL,
			// Token: 0x04008178 RID: 33144
			[global::Cpp2ILInjected.Token(Token = "0x4003C8B")]
			PLATINUM_CHAINMAIL,
			// Token: 0x04008179 RID: 33145
			[global::Cpp2ILInjected.Token(Token = "0x4003C8C")]
			WOOD_BREASTPLATE,
			// Token: 0x0400817A RID: 33146
			[global::Cpp2ILInjected.Token(Token = "0x4003C8D")]
			EBONWOOD_BREASTPLATE,
			// Token: 0x0400817B RID: 33147
			[global::Cpp2ILInjected.Token(Token = "0x4003C8E")]
			RICH_MAHOGANY_BREASTPLATE,
			// Token: 0x0400817C RID: 33148
			[global::Cpp2ILInjected.Token(Token = "0x4003C8F")]
			PEARLWOOD_BREASTPLATE,
			// Token: 0x0400817D RID: 33149
			[global::Cpp2ILInjected.Token(Token = "0x4003C90")]
			RUNE_ROBE,
			// Token: 0x0400817E RID: 33150
			[global::Cpp2ILInjected.Token(Token = "0x4003C91")]
			CRIMSON_SCALEMAIL,
			// Token: 0x0400817F RID: 33151
			[global::Cpp2ILInjected.Token(Token = "0x4003C92")]
			ESKIMO_COAT,
			// Token: 0x04008180 RID: 33152
			[global::Cpp2ILInjected.Token(Token = "0x4003C93")]
			STEAMPUNK_SHIRT,
			// Token: 0x04008181 RID: 33153
			[global::Cpp2ILInjected.Token(Token = "0x4003C94")]
			BEE_SHIRT,
			// Token: 0x04008182 RID: 33154
			[global::Cpp2ILInjected.Token(Token = "0x4003C95")]
			PRINCESS_DRESS,
			// Token: 0x04008183 RID: 33155
			[global::Cpp2ILInjected.Token(Token = "0x4003C96")]
			PHARAOHS_ROBE,
			// Token: 0x04008184 RID: 33156
			[global::Cpp2ILInjected.Token(Token = "0x4003C97")]
			MUMMY_SHIRT,
			// Token: 0x04008185 RID: 33157
			[global::Cpp2ILInjected.Token(Token = "0x4003C98")]
			COWBOY_JACKET,
			// Token: 0x04008186 RID: 33158
			[global::Cpp2ILInjected.Token(Token = "0x4003C99")]
			PIRATE_SHIRT,
			// Token: 0x04008187 RID: 33159
			[global::Cpp2ILInjected.Token(Token = "0x4003C9A")]
			CACTUS_BREASTPLATE,
			// Token: 0x04008188 RID: 33160
			[global::Cpp2ILInjected.Token(Token = "0x4003C9B")]
			SHADEWOOD_BREASTPLATE,
			// Token: 0x04008189 RID: 33161
			[global::Cpp2ILInjected.Token(Token = "0x4003C9C")]
			ANCIENT_SHADOW_SCALEMAIL,
			// Token: 0x0400818A RID: 33162
			[global::Cpp2ILInjected.Token(Token = "0x4003C9D")]
			ANCIENT_COBALT_BREASTPLATE,
			// Token: 0x0400818B RID: 33163
			[global::Cpp2ILInjected.Token(Token = "0x4003C9E")]
			PINK_ESKIMO_COAT,
			// Token: 0x0400818C RID: 33164
			[global::Cpp2ILInjected.Token(Token = "0x4003C9F")]
			CHLOROPHYTE_PLATE_MAIL,
			// Token: 0x0400818D RID: 33165
			[global::Cpp2ILInjected.Token(Token = "0x4003CA0")]
			RAIN_COAT,
			// Token: 0x0400818E RID: 33166
			[global::Cpp2ILInjected.Token(Token = "0x4003CA1")]
			TIKI_SHIRT,
			// Token: 0x0400818F RID: 33167
			[global::Cpp2ILInjected.Token(Token = "0x4003CA2")]
			PALLADIUM_BREASTPLATE,
			// Token: 0x04008190 RID: 33168
			[global::Cpp2ILInjected.Token(Token = "0x4003CA3")]
			ORICHALCUM_BREASTPLATE,
			// Token: 0x04008191 RID: 33169
			[global::Cpp2ILInjected.Token(Token = "0x4003CA4")]
			TITANIUM_BREASTPLATE,
			// Token: 0x04008192 RID: 33170
			[global::Cpp2ILInjected.Token(Token = "0x4003CA5")]
			SAILOR_SHIRT,
			// Token: 0x04008193 RID: 33171
			[global::Cpp2ILInjected.Token(Token = "0x4003CA6")]
			AMETHYST_ROBE,
			// Token: 0x04008194 RID: 33172
			[global::Cpp2ILInjected.Token(Token = "0x4003CA7")]
			TOPAZ_ROBE,
			// Token: 0x04008195 RID: 33173
			[global::Cpp2ILInjected.Token(Token = "0x4003CA8")]
			SAPPHIRE_ROBE,
			// Token: 0x04008196 RID: 33174
			[global::Cpp2ILInjected.Token(Token = "0x4003CA9")]
			EMERALD_ROBE,
			// Token: 0x04008197 RID: 33175
			[global::Cpp2ILInjected.Token(Token = "0x4003CAA")]
			RUBY_ROBE,
			// Token: 0x04008198 RID: 33176
			[global::Cpp2ILInjected.Token(Token = "0x4003CAB")]
			DIAMOND_ROBE,
			// Token: 0x04008199 RID: 33177
			[global::Cpp2ILInjected.Token(Token = "0x4003CAC")]
			WHITE_TUXEDO_SHIRT,
			// Token: 0x0400819A RID: 33178
			[global::Cpp2ILInjected.Token(Token = "0x4003CAD")]
			TURTLE_SCALE_MAIL,
			// Token: 0x0400819B RID: 33179
			[global::Cpp2ILInjected.Token(Token = "0x4003CAE")]
			SPECTRE_ROBE,
			// Token: 0x0400819C RID: 33180
			[global::Cpp2ILInjected.Token(Token = "0x4003CAF")]
			SHROOMITE_BREASTPLATE,
			// Token: 0x0400819D RID: 33181
			[global::Cpp2ILInjected.Token(Token = "0x4003CB0")]
			CENXS_BREASTPLATE,
			// Token: 0x0400819E RID: 33182
			[global::Cpp2ILInjected.Token(Token = "0x4003CB1")]
			CROWNOS_BREASTPLATE,
			// Token: 0x0400819F RID: 33183
			[global::Cpp2ILInjected.Token(Token = "0x4003CB2")]
			WILLS_BREASTPLATE,
			// Token: 0x040081A0 RID: 33184
			[global::Cpp2ILInjected.Token(Token = "0x4003CB3")]
			JIMS_BREASTPLATE,
			// Token: 0x040081A1 RID: 33185
			[global::Cpp2ILInjected.Token(Token = "0x4003CB4")]
			AARONS_BREASTPLATE,
			// Token: 0x040081A2 RID: 33186
			[global::Cpp2ILInjected.Token(Token = "0x4003CB5")]
			D_TOWNS_BREASTPLATE,
			// Token: 0x040081A3 RID: 33187
			[global::Cpp2ILInjected.Token(Token = "0x4003CB6")]
			CENXS_DRESS,
			// Token: 0x040081A4 RID: 33188
			[global::Cpp2ILInjected.Token(Token = "0x4003CB7")]
			PUMPKIN_BREASTPLATE,
			// Token: 0x040081A5 RID: 33189
			[global::Cpp2ILInjected.Token(Token = "0x4003CB8")]
			NURSE_SHIRT,
			// Token: 0x040081A6 RID: 33190
			[global::Cpp2ILInjected.Token(Token = "0x4003CB9")]
			DYE_TRADER_ROBE,
			// Token: 0x040081A7 RID: 33191
			[global::Cpp2ILInjected.Token(Token = "0x4003CBA")]
			CYBORG_SHIRT,
			// Token: 0x040081A8 RID: 33192
			[global::Cpp2ILInjected.Token(Token = "0x4003CBB")]
			CREEPER_SHIRT,
			// Token: 0x040081A9 RID: 33193
			[global::Cpp2ILInjected.Token(Token = "0x4003CBC")]
			CAT_SHIRT,
			// Token: 0x040081AA RID: 33194
			[global::Cpp2ILInjected.Token(Token = "0x4003CBD")]
			GHOST_SHIRT,
			// Token: 0x040081AB RID: 33195
			[global::Cpp2ILInjected.Token(Token = "0x4003CBE")]
			PUMPKIN_SHIRT,
			// Token: 0x040081AC RID: 33196
			[global::Cpp2ILInjected.Token(Token = "0x4003CBF")]
			ROBOT_SHIRT,
			// Token: 0x040081AD RID: 33197
			[global::Cpp2ILInjected.Token(Token = "0x4003CC0")]
			UNICORN_SHIRT,
			// Token: 0x040081AE RID: 33198
			[global::Cpp2ILInjected.Token(Token = "0x4003CC1")]
			VAMPIRE_SHIRT,
			// Token: 0x040081AF RID: 33199
			[global::Cpp2ILInjected.Token(Token = "0x4003CC2")]
			LEPRECHAUN_SHIRT,
			// Token: 0x040081B0 RID: 33200
			[global::Cpp2ILInjected.Token(Token = "0x4003CC3")]
			PIXIE_SHIRT,
			// Token: 0x040081B1 RID: 33201
			[global::Cpp2ILInjected.Token(Token = "0x4003CC4")]
			PRINCESS_DRESS_HALLOWEEN,
			// Token: 0x040081B2 RID: 33202
			[global::Cpp2ILInjected.Token(Token = "0x4003CC5")]
			WITCH_DRESS,
			// Token: 0x040081B3 RID: 33203
			[global::Cpp2ILInjected.Token(Token = "0x4003CC6")]
			BRIDE_OF_FRANKENSTEIN_DRESS,
			// Token: 0x040081B4 RID: 33204
			[global::Cpp2ILInjected.Token(Token = "0x4003CC7")]
			KARATE_TORTOISE_SHIRT,
			// Token: 0x040081B5 RID: 33205
			[global::Cpp2ILInjected.Token(Token = "0x4003CC8")]
			SCARECROW_SHIRT,
			// Token: 0x040081B6 RID: 33206
			[global::Cpp2ILInjected.Token(Token = "0x4003CC9")]
			REAPER_ROBE,
			// Token: 0x040081B7 RID: 33207
			[global::Cpp2ILInjected.Token(Token = "0x4003CCA")]
			FOX_SHIRT,
			// Token: 0x040081B8 RID: 33208
			[global::Cpp2ILInjected.Token(Token = "0x4003CCB")]
			SPOOKY_BREASTPLATE,
			// Token: 0x040081B9 RID: 33209
			[global::Cpp2ILInjected.Token(Token = "0x4003CCC")]
			SPACE_CREATURE_SHIRT,
			// Token: 0x040081BA RID: 33210
			[global::Cpp2ILInjected.Token(Token = "0x4003CCD")]
			WOLF_SHIRT,
			// Token: 0x040081BB RID: 33211
			[global::Cpp2ILInjected.Token(Token = "0x4003CCE")]
			TREASURE_HUNTER_SHIRT,
			// Token: 0x040081BC RID: 33212
			[global::Cpp2ILInjected.Token(Token = "0x4003CCF")]
			DRYAD_COVERINGS,
			// Token: 0x040081BD RID: 33213
			[global::Cpp2ILInjected.Token(Token = "0x4003CD0")]
			DRAGON_BREASTPLATE,
			// Token: 0x040081BE RID: 33214
			[global::Cpp2ILInjected.Token(Token = "0x4003CD1")]
			TITAN_MAIL,
			// Token: 0x040081BF RID: 33215
			[global::Cpp2ILInjected.Token(Token = "0x4003CD2")]
			SPECTRAL_ARMOR,
			// Token: 0x040081C0 RID: 33216
			[global::Cpp2ILInjected.Token(Token = "0x4003CD3")]
			FABULOUS_TUTU,
			// Token: 0x040081C1 RID: 33217
			[global::Cpp2ILInjected.Token(Token = "0x4003CD4")]
			GEORGES_TUXEDO_SHIRT,
			// Token: 0x040081C2 RID: 33218
			[global::Cpp2ILInjected.Token(Token = "0x4003CD5")]
			DIRNDL,
			// Token: 0x040081C3 RID: 33219
			[global::Cpp2ILInjected.Token(Token = "0x4003CD6")]
			TIROLER,
			// Token: 0x040081C4 RID: 33220
			[global::Cpp2ILInjected.Token(Token = "0x4003CD7")]
			MRS_CLAUSE_SHIRT,
			// Token: 0x040081C5 RID: 33221
			[global::Cpp2ILInjected.Token(Token = "0x4003CD8")]
			TREE_SHIRT,
			// Token: 0x040081C6 RID: 33222
			[global::Cpp2ILInjected.Token(Token = "0x4003CD9")]
			PARKA_COAT,
			// Token: 0x040081C7 RID: 33223
			[global::Cpp2ILInjected.Token(Token = "0x4003CDA")]
			UGLY_SWEATER,
			// Token: 0x040081C8 RID: 33224
			[global::Cpp2ILInjected.Token(Token = "0x4003CDB")]
			ELF_SHIRT,
			// Token: 0x040081C9 RID: 33225
			[global::Cpp2ILInjected.Token(Token = "0x4003CDC")]
			BEETLE_SCALE_MAIL,
			// Token: 0x040081CA RID: 33226
			[global::Cpp2ILInjected.Token(Token = "0x4003CDD")]
			BEETLE_SHELL,
			// Token: 0x040081CB RID: 33227
			[global::Cpp2ILInjected.Token(Token = "0x4003CDE")]
			GI,
			// Token: 0x040081CC RID: 33228
			[global::Cpp2ILInjected.Token(Token = "0x4003CDF")]
			KIMONO,
			// Token: 0x040081CD RID: 33229
			[global::Cpp2ILInjected.Token(Token = "0x4003CE0")]
			GYPSY_ROBE,
			// Token: 0x040081CE RID: 33230
			[global::Cpp2ILInjected.Token(Token = "0x4003CE1")]
			BEE_BREASTPLATE,
			// Token: 0x040081CF RID: 33231
			[global::Cpp2ILInjected.Token(Token = "0x4003CE2")]
			ANGLER_VEST,
			// Token: 0x040081D0 RID: 33232
			[global::Cpp2ILInjected.Token(Token = "0x4003CE3")]
			SPIDER_BREASTPLATE,
			// Token: 0x040081D1 RID: 33233
			[global::Cpp2ILInjected.Token(Token = "0x4003CE4")]
			MERMAID_ADORNMENT,
			// Token: 0x040081D2 RID: 33234
			[global::Cpp2ILInjected.Token(Token = "0x4003CE5")]
			FISH_COSTUME_SHIRT,
			// Token: 0x040081D3 RID: 33235
			[global::Cpp2ILInjected.Token(Token = "0x4003CE6")]
			BOREAL_WOOD_BREASTPLATE,
			// Token: 0x040081D4 RID: 33236
			[global::Cpp2ILInjected.Token(Token = "0x4003CE7")]
			PALM_WOOD_BREASTPLATE,
			// Token: 0x040081D5 RID: 33237
			[global::Cpp2ILInjected.Token(Token = "0x4003CE8")]
			MYTHICALROBE
		}

		// Token: 0x020008F7 RID: 2295
		[global::Cpp2ILInjected.Token(Token = "0x200056C")]
		private enum ARMOR_HEAD_SLOTS
		{
			// Token: 0x040081D7 RID: 33239
			[global::Cpp2ILInjected.Token(Token = "0x4003CEA")]
			COPPER_HELMET = 1,
			// Token: 0x040081D8 RID: 33240
			[global::Cpp2ILInjected.Token(Token = "0x4003CEB")]
			IRON_HELMET,
			// Token: 0x040081D9 RID: 33241
			[global::Cpp2ILInjected.Token(Token = "0x4003CEC")]
			SILVER_HELMET,
			// Token: 0x040081DA RID: 33242
			[global::Cpp2ILInjected.Token(Token = "0x4003CED")]
			GOLD_HELMET,
			// Token: 0x040081DB RID: 33243
			[global::Cpp2ILInjected.Token(Token = "0x4003CEE")]
			SHADOW_HELMET,
			// Token: 0x040081DC RID: 33244
			[global::Cpp2ILInjected.Token(Token = "0x4003CEF")]
			METEOR_HELMET,
			// Token: 0x040081DD RID: 33245
			[global::Cpp2ILInjected.Token(Token = "0x4003CF0")]
			NECRO_HELMET,
			// Token: 0x040081DE RID: 33246
			[global::Cpp2ILInjected.Token(Token = "0x4003CF1")]
			JUNGLE_HAT,
			// Token: 0x040081DF RID: 33247
			[global::Cpp2ILInjected.Token(Token = "0x4003CF2")]
			MOLTEN_HELMET,
			// Token: 0x040081E0 RID: 33248
			[global::Cpp2ILInjected.Token(Token = "0x4003CF3")]
			GOGGLES,
			// Token: 0x040081E1 RID: 33249
			[global::Cpp2ILInjected.Token(Token = "0x4003CF4")]
			MINING_HELMET,
			// Token: 0x040081E2 RID: 33250
			[global::Cpp2ILInjected.Token(Token = "0x4003CF5")]
			SUNGLASSES,
			// Token: 0x040081E3 RID: 33251
			[global::Cpp2ILInjected.Token(Token = "0x4003CF6")]
			EMPTY_BUCKET,
			// Token: 0x040081E4 RID: 33252
			[global::Cpp2ILInjected.Token(Token = "0x4003CF7")]
			WIZARD_HAT,
			// Token: 0x040081E5 RID: 33253
			[global::Cpp2ILInjected.Token(Token = "0x4003CF8")]
			TOP_HAT,
			// Token: 0x040081E6 RID: 33254
			[global::Cpp2ILInjected.Token(Token = "0x4003CF9")]
			SUMMER_HAT,
			// Token: 0x040081E7 RID: 33255
			[global::Cpp2ILInjected.Token(Token = "0x4003CFA")]
			BUNNY_HOOD,
			// Token: 0x040081E8 RID: 33256
			[global::Cpp2ILInjected.Token(Token = "0x4003CFB")]
			PLUMBERS_HAT,
			// Token: 0x040081E9 RID: 33257
			[global::Cpp2ILInjected.Token(Token = "0x4003CFC")]
			HEROS_HAT,
			// Token: 0x040081EA RID: 33258
			[global::Cpp2ILInjected.Token(Token = "0x4003CFD")]
			FISH_BOWL,
			// Token: 0x040081EB RID: 33259
			[global::Cpp2ILInjected.Token(Token = "0x4003CFE")]
			ARCHAEOLOGISTS_HAT,
			// Token: 0x040081EC RID: 33260
			[global::Cpp2ILInjected.Token(Token = "0x4003CFF")]
			NINJA_HOOD,
			// Token: 0x040081ED RID: 33261
			[global::Cpp2ILInjected.Token(Token = "0x4003D00")]
			JUNGLE_ROSE,
			// Token: 0x040081EE RID: 33262
			[global::Cpp2ILInjected.Token(Token = "0x4003D01")]
			RED_HAT,
			// Token: 0x040081EF RID: 33263
			[global::Cpp2ILInjected.Token(Token = "0x4003D02")]
			ROBOT_HAT,
			// Token: 0x040081F0 RID: 33264
			[global::Cpp2ILInjected.Token(Token = "0x4003D03")]
			GOLD_CROWN,
			// Token: 0x040081F1 RID: 33265
			[global::Cpp2ILInjected.Token(Token = "0x4003D04")]
			DIVING_HELMET,
			// Token: 0x040081F2 RID: 33266
			[global::Cpp2ILInjected.Token(Token = "0x4003D05")]
			MIME_MASK,
			// Token: 0x040081F3 RID: 33267
			[global::Cpp2ILInjected.Token(Token = "0x4003D06")]
			COBALT_HAT,
			// Token: 0x040081F4 RID: 33268
			[global::Cpp2ILInjected.Token(Token = "0x4003D07")]
			COBALT_HELMET,
			// Token: 0x040081F5 RID: 33269
			[global::Cpp2ILInjected.Token(Token = "0x4003D08")]
			COBALT_MASK,
			// Token: 0x040081F6 RID: 33270
			[global::Cpp2ILInjected.Token(Token = "0x4003D09")]
			MYTHRIL_HOOD,
			// Token: 0x040081F7 RID: 33271
			[global::Cpp2ILInjected.Token(Token = "0x4003D0A")]
			MYTHRIL_HELMET,
			// Token: 0x040081F8 RID: 33272
			[global::Cpp2ILInjected.Token(Token = "0x4003D0B")]
			MYTHRIL_HAT,
			// Token: 0x040081F9 RID: 33273
			[global::Cpp2ILInjected.Token(Token = "0x4003D0C")]
			ADAMANTITE_HEADGEAR,
			// Token: 0x040081FA RID: 33274
			[global::Cpp2ILInjected.Token(Token = "0x4003D0D")]
			ADAMANTITE_HELMET,
			// Token: 0x040081FB RID: 33275
			[global::Cpp2ILInjected.Token(Token = "0x4003D0E")]
			ADAMANTITE_MASK,
			// Token: 0x040081FC RID: 33276
			[global::Cpp2ILInjected.Token(Token = "0x4003D0F")]
			WEREWOLF,
			// Token: 0x040081FD RID: 33277
			[global::Cpp2ILInjected.Token(Token = "0x4003D10")]
			MERMAN,
			// Token: 0x040081FE RID: 33278
			[global::Cpp2ILInjected.Token(Token = "0x4003D11")]
			CLOWN_HAT,
			// Token: 0x040081FF RID: 33279
			[global::Cpp2ILInjected.Token(Token = "0x4003D12")]
			HALLOWED_HELMET,
			// Token: 0x04008200 RID: 33280
			[global::Cpp2ILInjected.Token(Token = "0x4003D13")]
			HALLOWED_HEADGEAR,
			// Token: 0x04008201 RID: 33281
			[global::Cpp2ILInjected.Token(Token = "0x4003D14")]
			HALLOWED_MASK,
			// Token: 0x04008202 RID: 33282
			[global::Cpp2ILInjected.Token(Token = "0x4003D15")]
			SANTA_HAT,
			// Token: 0x04008203 RID: 33283
			[global::Cpp2ILInjected.Token(Token = "0x4003D16")]
			REDS_HELMET,
			// Token: 0x04008204 RID: 33284
			[global::Cpp2ILInjected.Token(Token = "0x4003D17")]
			FROST_HELMET,
			// Token: 0x04008205 RID: 33285
			[global::Cpp2ILInjected.Token(Token = "0x4003D18")]
			TIN_HELMET,
			// Token: 0x04008206 RID: 33286
			[global::Cpp2ILInjected.Token(Token = "0x4003D19")]
			LEAD_HELMET,
			// Token: 0x04008207 RID: 33287
			[global::Cpp2ILInjected.Token(Token = "0x4003D1A")]
			TUNGSTEN_HELMET,
			// Token: 0x04008208 RID: 33288
			[global::Cpp2ILInjected.Token(Token = "0x4003D1B")]
			PLATINUM_HELMET,
			// Token: 0x04008209 RID: 33289
			[global::Cpp2ILInjected.Token(Token = "0x4003D1C")]
			PLATINUM_CROWN,
			// Token: 0x0400820A RID: 33290
			[global::Cpp2ILInjected.Token(Token = "0x4003D1D")]
			WOOD_HELMET,
			// Token: 0x0400820B RID: 33291
			[global::Cpp2ILInjected.Token(Token = "0x4003D1E")]
			EBONWOOD_HELMET,
			// Token: 0x0400820C RID: 33292
			[global::Cpp2ILInjected.Token(Token = "0x4003D1F")]
			RICH_MAHOGANY_HELMET,
			// Token: 0x0400820D RID: 33293
			[global::Cpp2ILInjected.Token(Token = "0x4003D20")]
			PEARLWOOD_HELMET,
			// Token: 0x0400820E RID: 33294
			[global::Cpp2ILInjected.Token(Token = "0x4003D21")]
			RUNE_HAT,
			// Token: 0x0400820F RID: 33295
			[global::Cpp2ILInjected.Token(Token = "0x4003D22")]
			CRIMSON_HELMET,
			// Token: 0x04008210 RID: 33296
			[global::Cpp2ILInjected.Token(Token = "0x4003D23")]
			ESKIMO_HOOD,
			// Token: 0x04008211 RID: 33297
			[global::Cpp2ILInjected.Token(Token = "0x4003D24")]
			STEAMPUNK_HAT,
			// Token: 0x04008212 RID: 33298
			[global::Cpp2ILInjected.Token(Token = "0x4003D25")]
			BEE_HAT,
			// Token: 0x04008213 RID: 33299
			[global::Cpp2ILInjected.Token(Token = "0x4003D26")]
			PHARAOHS_MASK,
			// Token: 0x04008214 RID: 33300
			[global::Cpp2ILInjected.Token(Token = "0x4003D27")]
			TIARA,
			// Token: 0x04008215 RID: 33301
			[global::Cpp2ILInjected.Token(Token = "0x4003D28")]
			GREEN_CAP,
			// Token: 0x04008216 RID: 33302
			[global::Cpp2ILInjected.Token(Token = "0x4003D29")]
			MUSHROOM_CAP,
			// Token: 0x04008217 RID: 33303
			[global::Cpp2ILInjected.Token(Token = "0x4003D2A")]
			TAM_O_SHANTER,
			// Token: 0x04008218 RID: 33304
			[global::Cpp2ILInjected.Token(Token = "0x4003D2B")]
			MUMMY_MASK,
			// Token: 0x04008219 RID: 33305
			[global::Cpp2ILInjected.Token(Token = "0x4003D2C")]
			COWBOY_HAT,
			// Token: 0x0400821A RID: 33306
			[global::Cpp2ILInjected.Token(Token = "0x4003D2D")]
			PIRATE_HAT,
			// Token: 0x0400821B RID: 33307
			[global::Cpp2ILInjected.Token(Token = "0x4003D2E")]
			VIKING_HELMET,
			// Token: 0x0400821C RID: 33308
			[global::Cpp2ILInjected.Token(Token = "0x4003D2F")]
			CACTUS_HELMET,
			// Token: 0x0400821D RID: 33309
			[global::Cpp2ILInjected.Token(Token = "0x4003D30")]
			SHADEWOOD_HELMET,
			// Token: 0x0400821E RID: 33310
			[global::Cpp2ILInjected.Token(Token = "0x4003D31")]
			ANCIENT_IRON_HELMET,
			// Token: 0x0400821F RID: 33311
			[global::Cpp2ILInjected.Token(Token = "0x4003D32")]
			ANCIENT_GOLD_HELMET,
			// Token: 0x04008220 RID: 33312
			[global::Cpp2ILInjected.Token(Token = "0x4003D33")]
			ANCIENT_SHADOW_HELMET,
			// Token: 0x04008221 RID: 33313
			[global::Cpp2ILInjected.Token(Token = "0x4003D34")]
			ANCIENT_NECRO_HELMET,
			// Token: 0x04008222 RID: 33314
			[global::Cpp2ILInjected.Token(Token = "0x4003D35")]
			ANCIENT_COBALT_HELMET,
			// Token: 0x04008223 RID: 33315
			[global::Cpp2ILInjected.Token(Token = "0x4003D36")]
			PINK_ESKIMO_HOOD,
			// Token: 0x04008224 RID: 33316
			[global::Cpp2ILInjected.Token(Token = "0x4003D37")]
			CHLOROPHYTE_MASK,
			// Token: 0x04008225 RID: 33317
			[global::Cpp2ILInjected.Token(Token = "0x4003D38")]
			CHLOROPHYTE_HELMET,
			// Token: 0x04008226 RID: 33318
			[global::Cpp2ILInjected.Token(Token = "0x4003D39")]
			CHLOROPHYTE_HEADGEAR,
			// Token: 0x04008227 RID: 33319
			[global::Cpp2ILInjected.Token(Token = "0x4003D3A")]
			RAIN_HAT,
			// Token: 0x04008228 RID: 33320
			[global::Cpp2ILInjected.Token(Token = "0x4003D3B")]
			TIKI_MASK,
			// Token: 0x04008229 RID: 33321
			[global::Cpp2ILInjected.Token(Token = "0x4003D3C")]
			PALLADIUM_MASK,
			// Token: 0x0400822A RID: 33322
			[global::Cpp2ILInjected.Token(Token = "0x4003D3D")]
			PALLADIUM_HELMET,
			// Token: 0x0400822B RID: 33323
			[global::Cpp2ILInjected.Token(Token = "0x4003D3E")]
			PALLADIUM_HEADGEAR,
			// Token: 0x0400822C RID: 33324
			[global::Cpp2ILInjected.Token(Token = "0x4003D3F")]
			ORICHALCUM_MASK,
			// Token: 0x0400822D RID: 33325
			[global::Cpp2ILInjected.Token(Token = "0x4003D40")]
			ORICHALCUM_HELMET,
			// Token: 0x0400822E RID: 33326
			[global::Cpp2ILInjected.Token(Token = "0x4003D41")]
			ORICHALCUM_HEADGEAR,
			// Token: 0x0400822F RID: 33327
			[global::Cpp2ILInjected.Token(Token = "0x4003D42")]
			TITANIUM_MASK,
			// Token: 0x04008230 RID: 33328
			[global::Cpp2ILInjected.Token(Token = "0x4003D43")]
			TITANIUM_HELMET,
			// Token: 0x04008231 RID: 33329
			[global::Cpp2ILInjected.Token(Token = "0x4003D44")]
			TITANIUM_HEADGEAR,
			// Token: 0x04008232 RID: 33330
			[global::Cpp2ILInjected.Token(Token = "0x4003D45")]
			UMBRELLA_HAT,
			// Token: 0x04008233 RID: 33331
			[global::Cpp2ILInjected.Token(Token = "0x4003D46")]
			SKULL,
			// Token: 0x04008234 RID: 33332
			[global::Cpp2ILInjected.Token(Token = "0x4003D47")]
			BALLA_HAT,
			// Token: 0x04008235 RID: 33333
			[global::Cpp2ILInjected.Token(Token = "0x4003D48")]
			GANGSTA_HAT,
			// Token: 0x04008236 RID: 33334
			[global::Cpp2ILInjected.Token(Token = "0x4003D49")]
			SAILOR_HAT,
			// Token: 0x04008237 RID: 33335
			[global::Cpp2ILInjected.Token(Token = "0x4003D4A")]
			EYE_PATCH,
			// Token: 0x04008238 RID: 33336
			[global::Cpp2ILInjected.Token(Token = "0x4003D4B")]
			SKELETRON_MASK,
			// Token: 0x04008239 RID: 33337
			[global::Cpp2ILInjected.Token(Token = "0x4003D4C")]
			TURTLE_HELMET,
			// Token: 0x0400823A RID: 33338
			[global::Cpp2ILInjected.Token(Token = "0x4003D4D")]
			BEANIE,
			// Token: 0x0400823B RID: 33339
			[global::Cpp2ILInjected.Token(Token = "0x4003D4E")]
			SPECTRE_HOOD,
			// Token: 0x0400823C RID: 33340
			[global::Cpp2ILInjected.Token(Token = "0x4003D4F")]
			SWAT_HELMET,
			// Token: 0x0400823D RID: 33341
			[global::Cpp2ILInjected.Token(Token = "0x4003D50")]
			SHROOMITE_HEADGEAR,
			// Token: 0x0400823E RID: 33342
			[global::Cpp2ILInjected.Token(Token = "0x4003D51")]
			SHROOMITE_MASK,
			// Token: 0x0400823F RID: 33343
			[global::Cpp2ILInjected.Token(Token = "0x4003D52")]
			SHROOMITE_HELMET,
			// Token: 0x04008240 RID: 33344
			[global::Cpp2ILInjected.Token(Token = "0x4003D53")]
			CENXS_TIARA,
			// Token: 0x04008241 RID: 33345
			[global::Cpp2ILInjected.Token(Token = "0x4003D54")]
			CROWNOS_MASK,
			// Token: 0x04008242 RID: 33346
			[global::Cpp2ILInjected.Token(Token = "0x4003D55")]
			WILLS_HELMET,
			// Token: 0x04008243 RID: 33347
			[global::Cpp2ILInjected.Token(Token = "0x4003D56")]
			JIMS_HELMET,
			// Token: 0x04008244 RID: 33348
			[global::Cpp2ILInjected.Token(Token = "0x4003D57")]
			AARONS_HELMET,
			// Token: 0x04008245 RID: 33349
			[global::Cpp2ILInjected.Token(Token = "0x4003D58")]
			D_TOWNS_HELMET,
			// Token: 0x04008246 RID: 33350
			[global::Cpp2ILInjected.Token(Token = "0x4003D59")]
			PUMPKIN_HELMET,
			// Token: 0x04008247 RID: 33351
			[global::Cpp2ILInjected.Token(Token = "0x4003D5A")]
			NURSE_HAT,
			// Token: 0x04008248 RID: 33352
			[global::Cpp2ILInjected.Token(Token = "0x4003D5B")]
			WIZARDS_HAT,
			// Token: 0x04008249 RID: 33353
			[global::Cpp2ILInjected.Token(Token = "0x4003D5C")]
			GUY_FAWKES_MASK,
			// Token: 0x0400824A RID: 33354
			[global::Cpp2ILInjected.Token(Token = "0x4003D5D")]
			STEAM_PUNK_GOGGLES,
			// Token: 0x0400824B RID: 33355
			[global::Cpp2ILInjected.Token(Token = "0x4003D5E")]
			CYBORG_HELMET,
			// Token: 0x0400824C RID: 33356
			[global::Cpp2ILInjected.Token(Token = "0x4003D5F")]
			CREEPER_MASK,
			// Token: 0x0400824D RID: 33357
			[global::Cpp2ILInjected.Token(Token = "0x4003D60")]
			CAT_MASK,
			// Token: 0x0400824E RID: 33358
			[global::Cpp2ILInjected.Token(Token = "0x4003D61")]
			GHOST_MASK,
			// Token: 0x0400824F RID: 33359
			[global::Cpp2ILInjected.Token(Token = "0x4003D62")]
			PUMPKIN_MASK,
			// Token: 0x04008250 RID: 33360
			[global::Cpp2ILInjected.Token(Token = "0x4003D63")]
			ROBOT_MASK,
			// Token: 0x04008251 RID: 33361
			[global::Cpp2ILInjected.Token(Token = "0x4003D64")]
			UNICORN_MASK,
			// Token: 0x04008252 RID: 33362
			[global::Cpp2ILInjected.Token(Token = "0x4003D65")]
			VAMPIRE_MASK,
			// Token: 0x04008253 RID: 33363
			[global::Cpp2ILInjected.Token(Token = "0x4003D66")]
			WITCH_HAT,
			// Token: 0x04008254 RID: 33364
			[global::Cpp2ILInjected.Token(Token = "0x4003D67")]
			LEPRECHAUN_HAT,
			// Token: 0x04008255 RID: 33365
			[global::Cpp2ILInjected.Token(Token = "0x4003D68")]
			PRINCESS_HAT_HALLOWEEN,
			// Token: 0x04008256 RID: 33366
			[global::Cpp2ILInjected.Token(Token = "0x4003D69")]
			BRIDE_OF_FRANKENSTEIN_MASK,
			// Token: 0x04008257 RID: 33367
			[global::Cpp2ILInjected.Token(Token = "0x4003D6A")]
			KARATE_TORTOISE_MASK,
			// Token: 0x04008258 RID: 33368
			[global::Cpp2ILInjected.Token(Token = "0x4003D6B")]
			SCARECROW_HAT,
			// Token: 0x04008259 RID: 33369
			[global::Cpp2ILInjected.Token(Token = "0x4003D6C")]
			REAPER_HOOD,
			// Token: 0x0400825A RID: 33370
			[global::Cpp2ILInjected.Token(Token = "0x4003D6D")]
			FOX_MASK,
			// Token: 0x0400825B RID: 33371
			[global::Cpp2ILInjected.Token(Token = "0x4003D6E")]
			CAT_EARS,
			// Token: 0x0400825C RID: 33372
			[global::Cpp2ILInjected.Token(Token = "0x4003D6F")]
			SPOOKY_HELMET,
			// Token: 0x0400825D RID: 33373
			[global::Cpp2ILInjected.Token(Token = "0x4003D70")]
			SPACE_CREATURE_MASK,
			// Token: 0x0400825E RID: 33374
			[global::Cpp2ILInjected.Token(Token = "0x4003D71")]
			WOLF_MASK,
			// Token: 0x0400825F RID: 33375
			[global::Cpp2ILInjected.Token(Token = "0x4003D72")]
			JACK_O_LANTERN_MASK,
			// Token: 0x04008260 RID: 33376
			[global::Cpp2ILInjected.Token(Token = "0x4003D73")]
			DRAGON_MASK,
			// Token: 0x04008261 RID: 33377
			[global::Cpp2ILInjected.Token(Token = "0x4003D74")]
			TITAN_HELMET,
			// Token: 0x04008262 RID: 33378
			[global::Cpp2ILInjected.Token(Token = "0x4003D75")]
			SPECTRAL_HEADGEAR,
			// Token: 0x04008263 RID: 33379
			[global::Cpp2ILInjected.Token(Token = "0x4003D76")]
			FABULOUS_RIBBON,
			// Token: 0x04008264 RID: 33380
			[global::Cpp2ILInjected.Token(Token = "0x4003D77")]
			GEORGES_HAT,
			// Token: 0x04008265 RID: 33381
			[global::Cpp2ILInjected.Token(Token = "0x4003D78")]
			NEWYEARS_HAT,
			// Token: 0x04008266 RID: 33382
			[global::Cpp2ILInjected.Token(Token = "0x4003D79")]
			DIRNDL,
			// Token: 0x04008267 RID: 33383
			[global::Cpp2ILInjected.Token(Token = "0x4003D7A")]
			TIROLER,
			// Token: 0x04008268 RID: 33384
			[global::Cpp2ILInjected.Token(Token = "0x4003D7B")]
			GIANT_BOW,
			// Token: 0x04008269 RID: 33385
			[global::Cpp2ILInjected.Token(Token = "0x4003D7C")]
			REINDEER_ANTLERS,
			// Token: 0x0400826A RID: 33386
			[global::Cpp2ILInjected.Token(Token = "0x4003D7D")]
			MRS_CLAUSE_HAT,
			// Token: 0x0400826B RID: 33387
			[global::Cpp2ILInjected.Token(Token = "0x4003D7E")]
			PARKA_HOOD,
			// Token: 0x0400826C RID: 33388
			[global::Cpp2ILInjected.Token(Token = "0x4003D7F")]
			TREE_MASK,
			// Token: 0x0400826D RID: 33389
			[global::Cpp2ILInjected.Token(Token = "0x4003D80")]
			SNOW_HAT,
			// Token: 0x0400826E RID: 33390
			[global::Cpp2ILInjected.Token(Token = "0x4003D81")]
			ELF_HAT,
			// Token: 0x0400826F RID: 33391
			[global::Cpp2ILInjected.Token(Token = "0x4003D82")]
			FEZ,
			// Token: 0x04008270 RID: 33392
			[global::Cpp2ILInjected.Token(Token = "0x4003D83")]
			BEETLE_HELMET,
			// Token: 0x04008271 RID: 33393
			[global::Cpp2ILInjected.Token(Token = "0x4003D84")]
			BRAIN_MASK,
			// Token: 0x04008272 RID: 33394
			[global::Cpp2ILInjected.Token(Token = "0x4003D85")]
			FLESH_MASK,
			// Token: 0x04008273 RID: 33395
			[global::Cpp2ILInjected.Token(Token = "0x4003D86")]
			TWIN_MASK,
			// Token: 0x04008274 RID: 33396
			[global::Cpp2ILInjected.Token(Token = "0x4003D87")]
			SKELETRON_PRIME_MASK,
			// Token: 0x04008275 RID: 33397
			[global::Cpp2ILInjected.Token(Token = "0x4003D88")]
			BEE_MASK,
			// Token: 0x04008276 RID: 33398
			[global::Cpp2ILInjected.Token(Token = "0x4003D89")]
			PLANTERA_MASK,
			// Token: 0x04008277 RID: 33399
			[global::Cpp2ILInjected.Token(Token = "0x4003D8A")]
			GOLEM_MASK,
			// Token: 0x04008278 RID: 33400
			[global::Cpp2ILInjected.Token(Token = "0x4003D8B")]
			EATER_MASK,
			// Token: 0x04008279 RID: 33401
			[global::Cpp2ILInjected.Token(Token = "0x4003D8C")]
			EYE_MASK,
			// Token: 0x0400827A RID: 33402
			[global::Cpp2ILInjected.Token(Token = "0x4003D8D")]
			DESTROYER_MASK,
			// Token: 0x0400827B RID: 33403
			[global::Cpp2ILInjected.Token(Token = "0x4003D8E")]
			MAGIC_HAT,
			// Token: 0x0400827C RID: 33404
			[global::Cpp2ILInjected.Token(Token = "0x4003D8F")]
			SPECTRE_MASK,
			// Token: 0x0400827D RID: 33405
			[global::Cpp2ILInjected.Token(Token = "0x4003D90")]
			PEDDLERS_HAT,
			// Token: 0x0400827E RID: 33406
			[global::Cpp2ILInjected.Token(Token = "0x4003D91")]
			BEE_HEADGEAR,
			// Token: 0x0400827F RID: 33407
			[global::Cpp2ILInjected.Token(Token = "0x4003D92")]
			ANGLER_HAT,
			// Token: 0x04008280 RID: 33408
			[global::Cpp2ILInjected.Token(Token = "0x4003D93")]
			SPIDER_MASK,
			// Token: 0x04008281 RID: 33409
			[global::Cpp2ILInjected.Token(Token = "0x4003D94")]
			SEASHELL_HAIRPIN,
			// Token: 0x04008282 RID: 33410
			[global::Cpp2ILInjected.Token(Token = "0x4003D95")]
			KING_SLIME_MASK,
			// Token: 0x04008283 RID: 33411
			[global::Cpp2ILInjected.Token(Token = "0x4003D96")]
			FISH_COSTUME_MASK,
			// Token: 0x04008284 RID: 33412
			[global::Cpp2ILInjected.Token(Token = "0x4003D97")]
			BOREAL_WOOD_HELMET,
			// Token: 0x04008285 RID: 33413
			[global::Cpp2ILInjected.Token(Token = "0x4003D98")]
			PALM_WOOD_HELMET,
			// Token: 0x04008286 RID: 33414
			[global::Cpp2ILInjected.Token(Token = "0x4003D99")]
			DUKE_FISHRON_MASK,
			// Token: 0x04008287 RID: 33415
			[global::Cpp2ILInjected.Token(Token = "0x4003D9A")]
			MYTHICAL_LION_MASK
		}

		// Token: 0x020008F8 RID: 2296
		[global::Cpp2ILInjected.Token(Token = "0x200056D")]
		private enum ARMOR_LEG_SLOTS
		{
			// Token: 0x04008289 RID: 33417
			[global::Cpp2ILInjected.Token(Token = "0x4003D9C")]
			COPPER_GREAVES = 1,
			// Token: 0x0400828A RID: 33418
			[global::Cpp2ILInjected.Token(Token = "0x4003D9D")]
			IRON_GREAVES,
			// Token: 0x0400828B RID: 33419
			[global::Cpp2ILInjected.Token(Token = "0x4003D9E")]
			SILVER_GREAVES,
			// Token: 0x0400828C RID: 33420
			[global::Cpp2ILInjected.Token(Token = "0x4003D9F")]
			GOLD_GREAVES,
			// Token: 0x0400828D RID: 33421
			[global::Cpp2ILInjected.Token(Token = "0x4003DA0")]
			SHADOW_GREAVES,
			// Token: 0x0400828E RID: 33422
			[global::Cpp2ILInjected.Token(Token = "0x4003DA1")]
			METEOR_LEGGINGS,
			// Token: 0x0400828F RID: 33423
			[global::Cpp2ILInjected.Token(Token = "0x4003DA2")]
			NECRO_GREAVES,
			// Token: 0x04008290 RID: 33424
			[global::Cpp2ILInjected.Token(Token = "0x4003DA3")]
			JUNGLE_PANTS,
			// Token: 0x04008291 RID: 33425
			[global::Cpp2ILInjected.Token(Token = "0x4003DA4")]
			MOLTEN_GREAVES,
			// Token: 0x04008292 RID: 33426
			[global::Cpp2ILInjected.Token(Token = "0x4003DA5")]
			TUXEDO_PANTS,
			// Token: 0x04008293 RID: 33427
			[global::Cpp2ILInjected.Token(Token = "0x4003DA6")]
			PLUMBERS_PANTS,
			// Token: 0x04008294 RID: 33428
			[global::Cpp2ILInjected.Token(Token = "0x4003DA7")]
			HEROS_PANTS,
			// Token: 0x04008295 RID: 33429
			[global::Cpp2ILInjected.Token(Token = "0x4003DA8")]
			ARCHAEOLOGISTS_PANTS,
			// Token: 0x04008296 RID: 33430
			[global::Cpp2ILInjected.Token(Token = "0x4003DA9")]
			NINJA_PANTS,
			// Token: 0x04008297 RID: 33431
			[global::Cpp2ILInjected.Token(Token = "0x4003DAA")]
			THE_DOCTORS_PANTS,
			// Token: 0x04008298 RID: 33432
			[global::Cpp2ILInjected.Token(Token = "0x4003DAB")]
			COBALT_LEGGINGS,
			// Token: 0x04008299 RID: 33433
			[global::Cpp2ILInjected.Token(Token = "0x4003DAC")]
			MYTHRIL_GREAVES,
			// Token: 0x0400829A RID: 33434
			[global::Cpp2ILInjected.Token(Token = "0x4003DAD")]
			ADAMANTITE_LEGGINGS,
			// Token: 0x0400829B RID: 33435
			[global::Cpp2ILInjected.Token(Token = "0x4003DAE")]
			MINING_PANTS,
			// Token: 0x0400829C RID: 33436
			[global::Cpp2ILInjected.Token(Token = "0x4003DAF")]
			WEREWOLF,
			// Token: 0x0400829D RID: 33437
			[global::Cpp2ILInjected.Token(Token = "0x4003DB0")]
			MERMAN,
			// Token: 0x0400829E RID: 33438
			[global::Cpp2ILInjected.Token(Token = "0x4003DB1")]
			CLOWN_PANTS,
			// Token: 0x0400829F RID: 33439
			[global::Cpp2ILInjected.Token(Token = "0x4003DB2")]
			HALLOWED_GREAVES,
			// Token: 0x040082A0 RID: 33440
			[global::Cpp2ILInjected.Token(Token = "0x4003DB3")]
			SANTA_PANTS,
			// Token: 0x040082A1 RID: 33441
			[global::Cpp2ILInjected.Token(Token = "0x4003DB4")]
			REDS_LEGGINGS,
			// Token: 0x040082A2 RID: 33442
			[global::Cpp2ILInjected.Token(Token = "0x4003DB5")]
			FROST_LEGGINGS,
			// Token: 0x040082A3 RID: 33443
			[global::Cpp2ILInjected.Token(Token = "0x4003DB6")]
			TIN_GREAVES,
			// Token: 0x040082A4 RID: 33444
			[global::Cpp2ILInjected.Token(Token = "0x4003DB7")]
			LEAD_GREAVES,
			// Token: 0x040082A5 RID: 33445
			[global::Cpp2ILInjected.Token(Token = "0x4003DB8")]
			TUNGSTEN_GREAVES,
			// Token: 0x040082A6 RID: 33446
			[global::Cpp2ILInjected.Token(Token = "0x4003DB9")]
			PLATINUM_GREAVES,
			// Token: 0x040082A7 RID: 33447
			[global::Cpp2ILInjected.Token(Token = "0x4003DBA")]
			WOOD_GREAVES,
			// Token: 0x040082A8 RID: 33448
			[global::Cpp2ILInjected.Token(Token = "0x4003DBB")]
			EBONWOOD_GREAVES,
			// Token: 0x040082A9 RID: 33449
			[global::Cpp2ILInjected.Token(Token = "0x4003DBC")]
			RICH_MAHOGANY_GREAVES,
			// Token: 0x040082AA RID: 33450
			[global::Cpp2ILInjected.Token(Token = "0x4003DBD")]
			PEARLWOOD_GREAVES,
			// Token: 0x040082AB RID: 33451
			[global::Cpp2ILInjected.Token(Token = "0x4003DBE")]
			CRIMSON_GREAVES,
			// Token: 0x040082AC RID: 33452
			[global::Cpp2ILInjected.Token(Token = "0x4003DBF")]
			ESKIMO_PANTS,
			// Token: 0x040082AD RID: 33453
			[global::Cpp2ILInjected.Token(Token = "0x4003DC0")]
			STEAMPUNK_PANTS,
			// Token: 0x040082AE RID: 33454
			[global::Cpp2ILInjected.Token(Token = "0x4003DC1")]
			BEE_PANTS,
			// Token: 0x040082AF RID: 33455
			[global::Cpp2ILInjected.Token(Token = "0x4003DC2")]
			MUMMY_PANTS,
			// Token: 0x040082B0 RID: 33456
			[global::Cpp2ILInjected.Token(Token = "0x4003DC3")]
			COWBOY_PANTS,
			// Token: 0x040082B1 RID: 33457
			[global::Cpp2ILInjected.Token(Token = "0x4003DC4")]
			PIRATE_PANTS,
			// Token: 0x040082B2 RID: 33458
			[global::Cpp2ILInjected.Token(Token = "0x4003DC5")]
			CACTUS_LEGGINGS,
			// Token: 0x040082B3 RID: 33459
			[global::Cpp2ILInjected.Token(Token = "0x4003DC6")]
			SHADEWOOD_GREAVES,
			// Token: 0x040082B4 RID: 33460
			[global::Cpp2ILInjected.Token(Token = "0x4003DC7")]
			ANCIENT_SHADOW_GREAVES,
			// Token: 0x040082B5 RID: 33461
			[global::Cpp2ILInjected.Token(Token = "0x4003DC8")]
			ANCIENT_COBALT_LEGGINGS,
			// Token: 0x040082B6 RID: 33462
			[global::Cpp2ILInjected.Token(Token = "0x4003DC9")]
			PINK_ESKIMO_PANTS,
			// Token: 0x040082B7 RID: 33463
			[global::Cpp2ILInjected.Token(Token = "0x4003DCA")]
			CHLOROPHYTE_GREAVES,
			// Token: 0x040082B8 RID: 33464
			[global::Cpp2ILInjected.Token(Token = "0x4003DCB")]
			TIKI_PANTS,
			// Token: 0x040082B9 RID: 33465
			[global::Cpp2ILInjected.Token(Token = "0x4003DCC")]
			PALLADIUM_LEGGINGS,
			// Token: 0x040082BA RID: 33466
			[global::Cpp2ILInjected.Token(Token = "0x4003DCD")]
			ORICHALCUM_LEGGINGS,
			// Token: 0x040082BB RID: 33467
			[global::Cpp2ILInjected.Token(Token = "0x4003DCE")]
			TITANIUM_LEGGINGS,
			// Token: 0x040082BC RID: 33468
			[global::Cpp2ILInjected.Token(Token = "0x4003DCF")]
			SAILOR_PANTS,
			// Token: 0x040082BD RID: 33469
			[global::Cpp2ILInjected.Token(Token = "0x4003DD0")]
			WHITE_TUXEDO_PANTS,
			// Token: 0x040082BE RID: 33470
			[global::Cpp2ILInjected.Token(Token = "0x4003DD1")]
			TURTLE_LEGGINGS,
			// Token: 0x040082BF RID: 33471
			[global::Cpp2ILInjected.Token(Token = "0x4003DD2")]
			SPECTRE_PANTS,
			// Token: 0x040082C0 RID: 33472
			[global::Cpp2ILInjected.Token(Token = "0x4003DD3")]
			SHROOMITE_LEGGINGS,
			// Token: 0x040082C1 RID: 33473
			[global::Cpp2ILInjected.Token(Token = "0x4003DD4")]
			CENXS_LEGGINGS,
			// Token: 0x040082C2 RID: 33474
			[global::Cpp2ILInjected.Token(Token = "0x4003DD5")]
			CROWNOS_LEGGINGS,
			// Token: 0x040082C3 RID: 33475
			[global::Cpp2ILInjected.Token(Token = "0x4003DD6")]
			WILLS_LEGGINGS,
			// Token: 0x040082C4 RID: 33476
			[global::Cpp2ILInjected.Token(Token = "0x4003DD7")]
			JIMS_LEGGINGS,
			// Token: 0x040082C5 RID: 33477
			[global::Cpp2ILInjected.Token(Token = "0x4003DD8")]
			AARONS_LEGGINGS,
			// Token: 0x040082C6 RID: 33478
			[global::Cpp2ILInjected.Token(Token = "0x4003DD9")]
			D_TOWNS_LEGGINGS,
			// Token: 0x040082C7 RID: 33479
			[global::Cpp2ILInjected.Token(Token = "0x4003DDA")]
			CENXS_DRESS_PANTS,
			// Token: 0x040082C8 RID: 33480
			[global::Cpp2ILInjected.Token(Token = "0x4003DDB")]
			PUMPKIN_LEGGINGS,
			// Token: 0x040082C9 RID: 33481
			[global::Cpp2ILInjected.Token(Token = "0x4003DDC")]
			NURSE_PANTS,
			// Token: 0x040082CA RID: 33482
			[global::Cpp2ILInjected.Token(Token = "0x4003DDD")]
			CYBORG_PANTS,
			// Token: 0x040082CB RID: 33483
			[global::Cpp2ILInjected.Token(Token = "0x4003DDE")]
			CREEPER_PANTS,
			// Token: 0x040082CC RID: 33484
			[global::Cpp2ILInjected.Token(Token = "0x4003DDF")]
			CAT_PANTS,
			// Token: 0x040082CD RID: 33485
			[global::Cpp2ILInjected.Token(Token = "0x4003DE0")]
			PUMPKIN_PANTS,
			// Token: 0x040082CE RID: 33486
			[global::Cpp2ILInjected.Token(Token = "0x4003DE1")]
			ROBOT_PANTS,
			// Token: 0x040082CF RID: 33487
			[global::Cpp2ILInjected.Token(Token = "0x4003DE2")]
			UNICORN_PANTS,
			// Token: 0x040082D0 RID: 33488
			[global::Cpp2ILInjected.Token(Token = "0x4003DE3")]
			VAMPIRE_PANTS,
			// Token: 0x040082D1 RID: 33489
			[global::Cpp2ILInjected.Token(Token = "0x4003DE4")]
			LEPRECHAUN_PANTS,
			// Token: 0x040082D2 RID: 33490
			[global::Cpp2ILInjected.Token(Token = "0x4003DE5")]
			PIXIE_PANTS,
			// Token: 0x040082D3 RID: 33491
			[global::Cpp2ILInjected.Token(Token = "0x4003DE6")]
			WITCH_BOOTS,
			// Token: 0x040082D4 RID: 33492
			[global::Cpp2ILInjected.Token(Token = "0x4003DE7")]
			KARATE_TORTOISE_PANTS,
			// Token: 0x040082D5 RID: 33493
			[global::Cpp2ILInjected.Token(Token = "0x4003DE8")]
			SCARECROW_PANTS,
			// Token: 0x040082D6 RID: 33494
			[global::Cpp2ILInjected.Token(Token = "0x4003DE9")]
			FOX_PANTS,
			// Token: 0x040082D7 RID: 33495
			[global::Cpp2ILInjected.Token(Token = "0x4003DEA")]
			SPOOKY_LEGGINGS,
			// Token: 0x040082D8 RID: 33496
			[global::Cpp2ILInjected.Token(Token = "0x4003DEB")]
			SPACE_CREATURE_PANTS,
			// Token: 0x040082D9 RID: 33497
			[global::Cpp2ILInjected.Token(Token = "0x4003DEC")]
			WOLF_PANTS,
			// Token: 0x040082DA RID: 33498
			[global::Cpp2ILInjected.Token(Token = "0x4003DED")]
			TREASURE_HUNTER_PANTS,
			// Token: 0x040082DB RID: 33499
			[global::Cpp2ILInjected.Token(Token = "0x4003DEE")]
			DRYAD_LOINCLOTH,
			// Token: 0x040082DC RID: 33500
			[global::Cpp2ILInjected.Token(Token = "0x4003DEF")]
			MRS_CLAUSE_HEELS,
			// Token: 0x040082DD RID: 33501
			[global::Cpp2ILInjected.Token(Token = "0x4003DF0")]
			TREE_TRUNKS,
			// Token: 0x040082DE RID: 33502
			[global::Cpp2ILInjected.Token(Token = "0x4003DF1")]
			PARKA_PANTS,
			// Token: 0x040082DF RID: 33503
			[global::Cpp2ILInjected.Token(Token = "0x4003DF2")]
			ELF_PANTS,
			// Token: 0x040082E0 RID: 33504
			[global::Cpp2ILInjected.Token(Token = "0x4003DF3")]
			ROBE,
			// Token: 0x040082E1 RID: 33505
			[global::Cpp2ILInjected.Token(Token = "0x4003DF4")]
			RUNE_ROBE,
			// Token: 0x040082E2 RID: 33506
			[global::Cpp2ILInjected.Token(Token = "0x4003DF5")]
			PHARAOHS_ROBE,
			// Token: 0x040082E3 RID: 33507
			[global::Cpp2ILInjected.Token(Token = "0x4003DF6")]
			AMETHYST_ROBE,
			// Token: 0x040082E4 RID: 33508
			[global::Cpp2ILInjected.Token(Token = "0x4003DF7")]
			TOPAZ_ROBE,
			// Token: 0x040082E5 RID: 33509
			[global::Cpp2ILInjected.Token(Token = "0x4003DF8")]
			SAPPHIRE_ROBE,
			// Token: 0x040082E6 RID: 33510
			[global::Cpp2ILInjected.Token(Token = "0x4003DF9")]
			EMERALD_ROBE,
			// Token: 0x040082E7 RID: 33511
			[global::Cpp2ILInjected.Token(Token = "0x4003DFA")]
			RUBY_ROBE,
			// Token: 0x040082E8 RID: 33512
			[global::Cpp2ILInjected.Token(Token = "0x4003DFB")]
			DIAMOND_ROBE,
			// Token: 0x040082E9 RID: 33513
			[global::Cpp2ILInjected.Token(Token = "0x4003DFC")]
			PRINCESS_DRESS,
			// Token: 0x040082EA RID: 33514
			[global::Cpp2ILInjected.Token(Token = "0x4003DFD")]
			BEETLE_LEGGINGS,
			// Token: 0x040082EB RID: 33515
			[global::Cpp2ILInjected.Token(Token = "0x4003DFE")]
			GI,
			// Token: 0x040082EC RID: 33516
			[global::Cpp2ILInjected.Token(Token = "0x4003DFF")]
			KIMONO,
			// Token: 0x040082ED RID: 33517
			[global::Cpp2ILInjected.Token(Token = "0x4003E00")]
			GYPSY_ROBE,
			// Token: 0x040082EE RID: 33518
			[global::Cpp2ILInjected.Token(Token = "0x4003E01")]
			BEE_GREAVES,
			// Token: 0x040082EF RID: 33519
			[global::Cpp2ILInjected.Token(Token = "0x4003E02")]
			ANGLER_PANTS,
			// Token: 0x040082F0 RID: 33520
			[global::Cpp2ILInjected.Token(Token = "0x4003E03")]
			SPIDER_GREAVES,
			// Token: 0x040082F1 RID: 33521
			[global::Cpp2ILInjected.Token(Token = "0x4003E04")]
			MERMAID_TAIL,
			// Token: 0x040082F2 RID: 33522
			[global::Cpp2ILInjected.Token(Token = "0x4003E05")]
			FISH_COSTUME_FINSKIRT,
			// Token: 0x040082F3 RID: 33523
			[global::Cpp2ILInjected.Token(Token = "0x4003E06")]
			BOREAL_WOOD_GREAVES,
			// Token: 0x040082F4 RID: 33524
			[global::Cpp2ILInjected.Token(Token = "0x4003E07")]
			PALM_WOOD_GREAVES,
			// Token: 0x040082F5 RID: 33525
			[global::Cpp2ILInjected.Token(Token = "0x4003E08")]
			DRAGON_GREAVES,
			// Token: 0x040082F6 RID: 33526
			[global::Cpp2ILInjected.Token(Token = "0x4003E09")]
			TITAN_LEGGINGS,
			// Token: 0x040082F7 RID: 33527
			[global::Cpp2ILInjected.Token(Token = "0x4003E0A")]
			SPECTRAL_SUBLIGAR,
			// Token: 0x040082F8 RID: 33528
			[global::Cpp2ILInjected.Token(Token = "0x4003E0B")]
			FABULOUS_SLIPPERS,
			// Token: 0x040082F9 RID: 33529
			[global::Cpp2ILInjected.Token(Token = "0x4003E0C")]
			GEORGES_TUXEDO_PANTS,
			// Token: 0x040082FA RID: 33530
			[global::Cpp2ILInjected.Token(Token = "0x4003E0D")]
			DIRNDL,
			// Token: 0x040082FB RID: 33531
			[global::Cpp2ILInjected.Token(Token = "0x4003E0E")]
			TIROLER,
			// Token: 0x040082FC RID: 33532
			[global::Cpp2ILInjected.Token(Token = "0x4003E0F")]
			OSTARA_BOOTS,
			// Token: 0x040082FD RID: 33533
			[global::Cpp2ILInjected.Token(Token = "0x4003E10")]
			MYTHICALROBE
		}
	}
}
