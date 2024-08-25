using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Items;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x200056A")]
	public static class ItemConversion_OldMobile
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4003C6B")]
		public static int CompensatedCurrency;

		[global::Cpp2ILInjected.Token(Token = "0x200056B")]
		private enum ARMOR_BODY_SLOTS
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003C6D")]
			COPPER_CHAINMAIL = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4003C6E")]
			IRON_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C6F")]
			SILVER_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C70")]
			GOLD_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C71")]
			SHADOW_SCALEMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C72")]
			METEOR_SUIT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C73")]
			NECRO_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C74")]
			JUNGLE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C75")]
			MOLTEN_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C76")]
			TUXEDO_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C77")]
			PLUMBERS_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C78")]
			HEROS_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C79")]
			ARCHAEOLOGISTS_JACKET,
			[global::Cpp2ILInjected.Token(Token = "0x4003C7A")]
			NINJA_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C7B")]
			ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C7C")]
			THE_DOCTORS_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C7D")]
			COBALT_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C7E")]
			MYTHRIL_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C7F")]
			ADAMANTITE_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C80")]
			MINING_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C81")]
			WEREWOLF,
			[global::Cpp2ILInjected.Token(Token = "0x4003C82")]
			MERMAN,
			[global::Cpp2ILInjected.Token(Token = "0x4003C83")]
			CLOWN_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C84")]
			HALLOWED_PLATE_MAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C85")]
			SANTA_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C86")]
			REDS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C87")]
			FROST_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C88")]
			TIN_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C89")]
			LEAD_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C8A")]
			TUNGSTEN_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C8B")]
			PLATINUM_CHAINMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C8C")]
			WOOD_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C8D")]
			EBONWOOD_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C8E")]
			RICH_MAHOGANY_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C8F")]
			PEARLWOOD_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C90")]
			RUNE_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C91")]
			CRIMSON_SCALEMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C92")]
			ESKIMO_COAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C93")]
			STEAMPUNK_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C94")]
			BEE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C95")]
			PRINCESS_DRESS,
			[global::Cpp2ILInjected.Token(Token = "0x4003C96")]
			PHARAOHS_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C97")]
			MUMMY_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C98")]
			COWBOY_JACKET,
			[global::Cpp2ILInjected.Token(Token = "0x4003C99")]
			PIRATE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C9A")]
			CACTUS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C9B")]
			SHADEWOOD_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C9C")]
			ANCIENT_SHADOW_SCALEMAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003C9D")]
			ANCIENT_COBALT_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003C9E")]
			PINK_ESKIMO_COAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003C9F")]
			CHLOROPHYTE_PLATE_MAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA0")]
			RAIN_COAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA1")]
			TIKI_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA2")]
			PALLADIUM_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA3")]
			ORICHALCUM_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA4")]
			TITANIUM_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA5")]
			SAILOR_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA6")]
			AMETHYST_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA7")]
			TOPAZ_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA8")]
			SAPPHIRE_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CA9")]
			EMERALD_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CAA")]
			RUBY_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CAB")]
			DIAMOND_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CAC")]
			WHITE_TUXEDO_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CAD")]
			TURTLE_SCALE_MAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CAE")]
			SPECTRE_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CAF")]
			SHROOMITE_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB0")]
			CENXS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB1")]
			CROWNOS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB2")]
			WILLS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB3")]
			JIMS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB4")]
			AARONS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB5")]
			D_TOWNS_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB6")]
			CENXS_DRESS,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB7")]
			PUMPKIN_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB8")]
			NURSE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CB9")]
			DYE_TRADER_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CBA")]
			CYBORG_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CBB")]
			CREEPER_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CBC")]
			CAT_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CBD")]
			GHOST_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CBE")]
			PUMPKIN_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CBF")]
			ROBOT_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC0")]
			UNICORN_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC1")]
			VAMPIRE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC2")]
			LEPRECHAUN_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC3")]
			PIXIE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC4")]
			PRINCESS_DRESS_HALLOWEEN,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC5")]
			WITCH_DRESS,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC6")]
			BRIDE_OF_FRANKENSTEIN_DRESS,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC7")]
			KARATE_TORTOISE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC8")]
			SCARECROW_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CC9")]
			REAPER_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CCA")]
			FOX_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CCB")]
			SPOOKY_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CCC")]
			SPACE_CREATURE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CCD")]
			WOLF_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CCE")]
			TREASURE_HUNTER_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CCF")]
			DRYAD_COVERINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD0")]
			DRAGON_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD1")]
			TITAN_MAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD2")]
			SPECTRAL_ARMOR,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD3")]
			FABULOUS_TUTU,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD4")]
			GEORGES_TUXEDO_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD5")]
			DIRNDL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD6")]
			TIROLER,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD7")]
			MRS_CLAUSE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD8")]
			TREE_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CD9")]
			PARKA_COAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CDA")]
			UGLY_SWEATER,
			[global::Cpp2ILInjected.Token(Token = "0x4003CDB")]
			ELF_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CDC")]
			BEETLE_SCALE_MAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CDD")]
			BEETLE_SHELL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CDE")]
			GI,
			[global::Cpp2ILInjected.Token(Token = "0x4003CDF")]
			KIMONO,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE0")]
			GYPSY_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE1")]
			BEE_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE2")]
			ANGLER_VEST,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE3")]
			SPIDER_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE4")]
			MERMAID_ADORNMENT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE5")]
			FISH_COSTUME_SHIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE6")]
			BOREAL_WOOD_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE7")]
			PALM_WOOD_BREASTPLATE,
			[global::Cpp2ILInjected.Token(Token = "0x4003CE8")]
			MYTHICALROBE
		}

		[global::Cpp2ILInjected.Token(Token = "0x200056C")]
		private enum ARMOR_HEAD_SLOTS
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003CEA")]
			COPPER_HELMET = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4003CEB")]
			IRON_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CEC")]
			SILVER_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CED")]
			GOLD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CEE")]
			SHADOW_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CEF")]
			METEOR_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF0")]
			NECRO_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF1")]
			JUNGLE_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF2")]
			MOLTEN_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF3")]
			GOGGLES,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF4")]
			MINING_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF5")]
			SUNGLASSES,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF6")]
			EMPTY_BUCKET,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF7")]
			WIZARD_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF8")]
			TOP_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CF9")]
			SUMMER_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CFA")]
			BUNNY_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003CFB")]
			PLUMBERS_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CFC")]
			HEROS_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CFD")]
			FISH_BOWL,
			[global::Cpp2ILInjected.Token(Token = "0x4003CFE")]
			ARCHAEOLOGISTS_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003CFF")]
			NINJA_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D00")]
			JUNGLE_ROSE,
			[global::Cpp2ILInjected.Token(Token = "0x4003D01")]
			RED_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D02")]
			ROBOT_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D03")]
			GOLD_CROWN,
			[global::Cpp2ILInjected.Token(Token = "0x4003D04")]
			DIVING_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D05")]
			MIME_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D06")]
			COBALT_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D07")]
			COBALT_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D08")]
			COBALT_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D09")]
			MYTHRIL_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D0A")]
			MYTHRIL_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D0B")]
			MYTHRIL_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D0C")]
			ADAMANTITE_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D0D")]
			ADAMANTITE_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D0E")]
			ADAMANTITE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D0F")]
			WEREWOLF,
			[global::Cpp2ILInjected.Token(Token = "0x4003D10")]
			MERMAN,
			[global::Cpp2ILInjected.Token(Token = "0x4003D11")]
			CLOWN_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D12")]
			HALLOWED_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D13")]
			HALLOWED_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D14")]
			HALLOWED_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D15")]
			SANTA_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D16")]
			REDS_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D17")]
			FROST_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D18")]
			TIN_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D19")]
			LEAD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D1A")]
			TUNGSTEN_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D1B")]
			PLATINUM_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D1C")]
			PLATINUM_CROWN,
			[global::Cpp2ILInjected.Token(Token = "0x4003D1D")]
			WOOD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D1E")]
			EBONWOOD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D1F")]
			RICH_MAHOGANY_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D20")]
			PEARLWOOD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D21")]
			RUNE_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D22")]
			CRIMSON_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D23")]
			ESKIMO_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D24")]
			STEAMPUNK_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D25")]
			BEE_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D26")]
			PHARAOHS_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D27")]
			TIARA,
			[global::Cpp2ILInjected.Token(Token = "0x4003D28")]
			GREEN_CAP,
			[global::Cpp2ILInjected.Token(Token = "0x4003D29")]
			MUSHROOM_CAP,
			[global::Cpp2ILInjected.Token(Token = "0x4003D2A")]
			TAM_O_SHANTER,
			[global::Cpp2ILInjected.Token(Token = "0x4003D2B")]
			MUMMY_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D2C")]
			COWBOY_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D2D")]
			PIRATE_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D2E")]
			VIKING_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D2F")]
			CACTUS_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D30")]
			SHADEWOOD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D31")]
			ANCIENT_IRON_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D32")]
			ANCIENT_GOLD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D33")]
			ANCIENT_SHADOW_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D34")]
			ANCIENT_NECRO_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D35")]
			ANCIENT_COBALT_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D36")]
			PINK_ESKIMO_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D37")]
			CHLOROPHYTE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D38")]
			CHLOROPHYTE_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D39")]
			CHLOROPHYTE_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D3A")]
			RAIN_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D3B")]
			TIKI_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D3C")]
			PALLADIUM_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D3D")]
			PALLADIUM_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D3E")]
			PALLADIUM_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D3F")]
			ORICHALCUM_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D40")]
			ORICHALCUM_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D41")]
			ORICHALCUM_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D42")]
			TITANIUM_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D43")]
			TITANIUM_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D44")]
			TITANIUM_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D45")]
			UMBRELLA_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D46")]
			SKULL,
			[global::Cpp2ILInjected.Token(Token = "0x4003D47")]
			BALLA_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D48")]
			GANGSTA_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D49")]
			SAILOR_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D4A")]
			EYE_PATCH,
			[global::Cpp2ILInjected.Token(Token = "0x4003D4B")]
			SKELETRON_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D4C")]
			TURTLE_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D4D")]
			BEANIE,
			[global::Cpp2ILInjected.Token(Token = "0x4003D4E")]
			SPECTRE_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D4F")]
			SWAT_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D50")]
			SHROOMITE_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D51")]
			SHROOMITE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D52")]
			SHROOMITE_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D53")]
			CENXS_TIARA,
			[global::Cpp2ILInjected.Token(Token = "0x4003D54")]
			CROWNOS_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D55")]
			WILLS_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D56")]
			JIMS_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D57")]
			AARONS_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D58")]
			D_TOWNS_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D59")]
			PUMPKIN_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D5A")]
			NURSE_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D5B")]
			WIZARDS_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D5C")]
			GUY_FAWKES_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D5D")]
			STEAM_PUNK_GOGGLES,
			[global::Cpp2ILInjected.Token(Token = "0x4003D5E")]
			CYBORG_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D5F")]
			CREEPER_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D60")]
			CAT_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D61")]
			GHOST_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D62")]
			PUMPKIN_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D63")]
			ROBOT_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D64")]
			UNICORN_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D65")]
			VAMPIRE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D66")]
			WITCH_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D67")]
			LEPRECHAUN_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D68")]
			PRINCESS_HAT_HALLOWEEN,
			[global::Cpp2ILInjected.Token(Token = "0x4003D69")]
			BRIDE_OF_FRANKENSTEIN_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D6A")]
			KARATE_TORTOISE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D6B")]
			SCARECROW_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D6C")]
			REAPER_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D6D")]
			FOX_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D6E")]
			CAT_EARS,
			[global::Cpp2ILInjected.Token(Token = "0x4003D6F")]
			SPOOKY_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D70")]
			SPACE_CREATURE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D71")]
			WOLF_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D72")]
			JACK_O_LANTERN_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D73")]
			DRAGON_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D74")]
			TITAN_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D75")]
			SPECTRAL_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D76")]
			FABULOUS_RIBBON,
			[global::Cpp2ILInjected.Token(Token = "0x4003D77")]
			GEORGES_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D78")]
			NEWYEARS_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D79")]
			DIRNDL,
			[global::Cpp2ILInjected.Token(Token = "0x4003D7A")]
			TIROLER,
			[global::Cpp2ILInjected.Token(Token = "0x4003D7B")]
			GIANT_BOW,
			[global::Cpp2ILInjected.Token(Token = "0x4003D7C")]
			REINDEER_ANTLERS,
			[global::Cpp2ILInjected.Token(Token = "0x4003D7D")]
			MRS_CLAUSE_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D7E")]
			PARKA_HOOD,
			[global::Cpp2ILInjected.Token(Token = "0x4003D7F")]
			TREE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D80")]
			SNOW_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D81")]
			ELF_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D82")]
			FEZ,
			[global::Cpp2ILInjected.Token(Token = "0x4003D83")]
			BEETLE_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D84")]
			BRAIN_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D85")]
			FLESH_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D86")]
			TWIN_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D87")]
			SKELETRON_PRIME_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D88")]
			BEE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D89")]
			PLANTERA_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D8A")]
			GOLEM_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D8B")]
			EATER_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D8C")]
			EYE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D8D")]
			DESTROYER_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D8E")]
			MAGIC_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D8F")]
			SPECTRE_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D90")]
			PEDDLERS_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D91")]
			BEE_HEADGEAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003D92")]
			ANGLER_HAT,
			[global::Cpp2ILInjected.Token(Token = "0x4003D93")]
			SPIDER_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D94")]
			SEASHELL_HAIRPIN,
			[global::Cpp2ILInjected.Token(Token = "0x4003D95")]
			KING_SLIME_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D96")]
			FISH_COSTUME_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D97")]
			BOREAL_WOOD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D98")]
			PALM_WOOD_HELMET,
			[global::Cpp2ILInjected.Token(Token = "0x4003D99")]
			DUKE_FISHRON_MASK,
			[global::Cpp2ILInjected.Token(Token = "0x4003D9A")]
			MYTHICAL_LION_MASK
		}

		[global::Cpp2ILInjected.Token(Token = "0x200056D")]
		private enum ARMOR_LEG_SLOTS
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003D9C")]
			COPPER_GREAVES = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4003D9D")]
			IRON_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003D9E")]
			SILVER_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003D9F")]
			GOLD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA0")]
			SHADOW_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA1")]
			METEOR_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA2")]
			NECRO_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA3")]
			JUNGLE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA4")]
			MOLTEN_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA5")]
			TUXEDO_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA6")]
			PLUMBERS_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA7")]
			HEROS_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA8")]
			ARCHAEOLOGISTS_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DA9")]
			NINJA_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DAA")]
			THE_DOCTORS_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DAB")]
			COBALT_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DAC")]
			MYTHRIL_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DAD")]
			ADAMANTITE_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DAE")]
			MINING_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DAF")]
			WEREWOLF,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB0")]
			MERMAN,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB1")]
			CLOWN_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB2")]
			HALLOWED_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB3")]
			SANTA_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB4")]
			REDS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB5")]
			FROST_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB6")]
			TIN_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB7")]
			LEAD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB8")]
			TUNGSTEN_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DB9")]
			PLATINUM_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DBA")]
			WOOD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DBB")]
			EBONWOOD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DBC")]
			RICH_MAHOGANY_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DBD")]
			PEARLWOOD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DBE")]
			CRIMSON_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DBF")]
			ESKIMO_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC0")]
			STEAMPUNK_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC1")]
			BEE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC2")]
			MUMMY_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC3")]
			COWBOY_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC4")]
			PIRATE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC5")]
			CACTUS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC6")]
			SHADEWOOD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC7")]
			ANCIENT_SHADOW_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC8")]
			ANCIENT_COBALT_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DC9")]
			PINK_ESKIMO_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DCA")]
			CHLOROPHYTE_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003DCB")]
			TIKI_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DCC")]
			PALLADIUM_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DCD")]
			ORICHALCUM_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DCE")]
			TITANIUM_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DCF")]
			SAILOR_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD0")]
			WHITE_TUXEDO_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD1")]
			TURTLE_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD2")]
			SPECTRE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD3")]
			SHROOMITE_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD4")]
			CENXS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD5")]
			CROWNOS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD6")]
			WILLS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD7")]
			JIMS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD8")]
			AARONS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DD9")]
			D_TOWNS_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DDA")]
			CENXS_DRESS_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DDB")]
			PUMPKIN_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DDC")]
			NURSE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DDD")]
			CYBORG_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DDE")]
			CREEPER_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DDF")]
			CAT_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE0")]
			PUMPKIN_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE1")]
			ROBOT_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE2")]
			UNICORN_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE3")]
			VAMPIRE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE4")]
			LEPRECHAUN_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE5")]
			PIXIE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE6")]
			WITCH_BOOTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE7")]
			KARATE_TORTOISE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE8")]
			SCARECROW_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DE9")]
			FOX_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DEA")]
			SPOOKY_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DEB")]
			SPACE_CREATURE_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DEC")]
			WOLF_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DED")]
			TREASURE_HUNTER_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DEE")]
			DRYAD_LOINCLOTH,
			[global::Cpp2ILInjected.Token(Token = "0x4003DEF")]
			MRS_CLAUSE_HEELS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF0")]
			TREE_TRUNKS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF1")]
			PARKA_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF2")]
			ELF_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF3")]
			ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF4")]
			RUNE_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF5")]
			PHARAOHS_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF6")]
			AMETHYST_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF7")]
			TOPAZ_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF8")]
			SAPPHIRE_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DF9")]
			EMERALD_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DFA")]
			RUBY_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DFB")]
			DIAMOND_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003DFC")]
			PRINCESS_DRESS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DFD")]
			BEETLE_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003DFE")]
			GI,
			[global::Cpp2ILInjected.Token(Token = "0x4003DFF")]
			KIMONO,
			[global::Cpp2ILInjected.Token(Token = "0x4003E00")]
			GYPSY_ROBE,
			[global::Cpp2ILInjected.Token(Token = "0x4003E01")]
			BEE_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003E02")]
			ANGLER_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003E03")]
			SPIDER_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003E04")]
			MERMAID_TAIL,
			[global::Cpp2ILInjected.Token(Token = "0x4003E05")]
			FISH_COSTUME_FINSKIRT,
			[global::Cpp2ILInjected.Token(Token = "0x4003E06")]
			BOREAL_WOOD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003E07")]
			PALM_WOOD_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003E08")]
			DRAGON_GREAVES,
			[global::Cpp2ILInjected.Token(Token = "0x4003E09")]
			TITAN_LEGGINGS,
			[global::Cpp2ILInjected.Token(Token = "0x4003E0A")]
			SPECTRAL_SUBLIGAR,
			[global::Cpp2ILInjected.Token(Token = "0x4003E0B")]
			FABULOUS_SLIPPERS,
			[global::Cpp2ILInjected.Token(Token = "0x4003E0C")]
			GEORGES_TUXEDO_PANTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003E0D")]
			DIRNDL,
			[global::Cpp2ILInjected.Token(Token = "0x4003E0E")]
			TIROLER,
			[global::Cpp2ILInjected.Token(Token = "0x4003E0F")]
			OSTARA_BOOTS,
			[global::Cpp2ILInjected.Token(Token = "0x4003E10")]
			MYTHICALROBE
		}
	}
}
