using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D0")]
public static class ItemConversion_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x20008F4")]
	private enum ARMOR_BODY_SLOTS
	{
		[Cpp2IlInjected.Token(Token = "0x4008164")]
		COPPER_CHAINMAIL = 1,
		[Cpp2IlInjected.Token(Token = "0x4008165")]
		IRON_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008166")]
		SILVER_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008167")]
		GOLD_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008168")]
		SHADOW_SCALEMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008169")]
		METEOR_SUIT,
		[Cpp2IlInjected.Token(Token = "0x400816A")]
		NECRO_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400816B")]
		JUNGLE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400816C")]
		MOLTEN_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400816D")]
		TUXEDO_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400816E")]
		PLUMBERS_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400816F")]
		HEROS_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x4008170")]
		ARCHAEOLOGISTS_JACKET,
		[Cpp2IlInjected.Token(Token = "0x4008171")]
		NINJA_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x4008172")]
		ROBE,
		[Cpp2IlInjected.Token(Token = "0x4008173")]
		THE_DOCTORS_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x4008174")]
		COBALT_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008175")]
		MYTHRIL_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008176")]
		ADAMANTITE_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008177")]
		MINING_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x4008178")]
		WEREWOLF,
		[Cpp2IlInjected.Token(Token = "0x4008179")]
		MERMAN,
		[Cpp2IlInjected.Token(Token = "0x400817A")]
		CLOWN_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400817B")]
		HALLOWED_PLATE_MAIL,
		[Cpp2IlInjected.Token(Token = "0x400817C")]
		SANTA_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400817D")]
		REDS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400817E")]
		FROST_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400817F")]
		TIN_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008180")]
		LEAD_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008181")]
		TUNGSTEN_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008182")]
		PLATINUM_CHAINMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008183")]
		WOOD_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008184")]
		EBONWOOD_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008185")]
		RICH_MAHOGANY_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008186")]
		PEARLWOOD_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008187")]
		RUNE_ROBE,
		[Cpp2IlInjected.Token(Token = "0x4008188")]
		CRIMSON_SCALEMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008189")]
		ESKIMO_COAT,
		[Cpp2IlInjected.Token(Token = "0x400818A")]
		STEAMPUNK_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400818B")]
		BEE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400818C")]
		PRINCESS_DRESS,
		[Cpp2IlInjected.Token(Token = "0x400818D")]
		PHARAOHS_ROBE,
		[Cpp2IlInjected.Token(Token = "0x400818E")]
		MUMMY_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400818F")]
		COWBOY_JACKET,
		[Cpp2IlInjected.Token(Token = "0x4008190")]
		PIRATE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x4008191")]
		CACTUS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008192")]
		SHADEWOOD_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008193")]
		ANCIENT_SHADOW_SCALEMAIL,
		[Cpp2IlInjected.Token(Token = "0x4008194")]
		ANCIENT_COBALT_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x4008195")]
		PINK_ESKIMO_COAT,
		[Cpp2IlInjected.Token(Token = "0x4008196")]
		CHLOROPHYTE_PLATE_MAIL,
		[Cpp2IlInjected.Token(Token = "0x4008197")]
		RAIN_COAT,
		[Cpp2IlInjected.Token(Token = "0x4008198")]
		TIKI_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x4008199")]
		PALLADIUM_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400819A")]
		ORICHALCUM_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400819B")]
		TITANIUM_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x400819C")]
		SAILOR_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x400819D")]
		AMETHYST_ROBE,
		[Cpp2IlInjected.Token(Token = "0x400819E")]
		TOPAZ_ROBE,
		[Cpp2IlInjected.Token(Token = "0x400819F")]
		SAPPHIRE_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081A0")]
		EMERALD_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081A1")]
		RUBY_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081A2")]
		DIAMOND_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081A3")]
		WHITE_TUXEDO_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081A4")]
		TURTLE_SCALE_MAIL,
		[Cpp2IlInjected.Token(Token = "0x40081A5")]
		SPECTRE_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081A6")]
		SHROOMITE_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081A7")]
		CENXS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081A8")]
		CROWNOS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081A9")]
		WILLS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081AA")]
		JIMS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081AB")]
		AARONS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081AC")]
		D_TOWNS_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081AD")]
		CENXS_DRESS,
		[Cpp2IlInjected.Token(Token = "0x40081AE")]
		PUMPKIN_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081AF")]
		NURSE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B0")]
		DYE_TRADER_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081B1")]
		CYBORG_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B2")]
		CREEPER_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B3")]
		CAT_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B4")]
		GHOST_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B5")]
		PUMPKIN_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B6")]
		ROBOT_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B7")]
		UNICORN_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B8")]
		VAMPIRE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081B9")]
		LEPRECHAUN_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081BA")]
		PIXIE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081BB")]
		PRINCESS_DRESS_HALLOWEEN,
		[Cpp2IlInjected.Token(Token = "0x40081BC")]
		WITCH_DRESS,
		[Cpp2IlInjected.Token(Token = "0x40081BD")]
		BRIDE_OF_FRANKENSTEIN_DRESS,
		[Cpp2IlInjected.Token(Token = "0x40081BE")]
		KARATE_TORTOISE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081BF")]
		SCARECROW_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081C0")]
		REAPER_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081C1")]
		FOX_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081C2")]
		SPOOKY_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081C3")]
		SPACE_CREATURE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081C4")]
		WOLF_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081C5")]
		TREASURE_HUNTER_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081C6")]
		DRYAD_COVERINGS,
		[Cpp2IlInjected.Token(Token = "0x40081C7")]
		DRAGON_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081C8")]
		TITAN_MAIL,
		[Cpp2IlInjected.Token(Token = "0x40081C9")]
		SPECTRAL_ARMOR,
		[Cpp2IlInjected.Token(Token = "0x40081CA")]
		FABULOUS_TUTU,
		[Cpp2IlInjected.Token(Token = "0x40081CB")]
		GEORGES_TUXEDO_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081CC")]
		DIRNDL,
		[Cpp2IlInjected.Token(Token = "0x40081CD")]
		TIROLER,
		[Cpp2IlInjected.Token(Token = "0x40081CE")]
		MRS_CLAUSE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081CF")]
		TREE_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081D0")]
		PARKA_COAT,
		[Cpp2IlInjected.Token(Token = "0x40081D1")]
		UGLY_SWEATER,
		[Cpp2IlInjected.Token(Token = "0x40081D2")]
		ELF_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081D3")]
		BEETLE_SCALE_MAIL,
		[Cpp2IlInjected.Token(Token = "0x40081D4")]
		BEETLE_SHELL,
		[Cpp2IlInjected.Token(Token = "0x40081D5")]
		GI,
		[Cpp2IlInjected.Token(Token = "0x40081D6")]
		KIMONO,
		[Cpp2IlInjected.Token(Token = "0x40081D7")]
		GYPSY_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40081D8")]
		BEE_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081D9")]
		ANGLER_VEST,
		[Cpp2IlInjected.Token(Token = "0x40081DA")]
		SPIDER_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081DB")]
		MERMAID_ADORNMENT,
		[Cpp2IlInjected.Token(Token = "0x40081DC")]
		FISH_COSTUME_SHIRT,
		[Cpp2IlInjected.Token(Token = "0x40081DD")]
		BOREAL_WOOD_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081DE")]
		PALM_WOOD_BREASTPLATE,
		[Cpp2IlInjected.Token(Token = "0x40081DF")]
		MYTHICALROBE
	}

	[Cpp2IlInjected.Token(Token = "0x20008F5")]
	private enum ARMOR_HEAD_SLOTS
	{
		[Cpp2IlInjected.Token(Token = "0x40081E1")]
		COPPER_HELMET = 1,
		[Cpp2IlInjected.Token(Token = "0x40081E2")]
		IRON_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081E3")]
		SILVER_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081E4")]
		GOLD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081E5")]
		SHADOW_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081E6")]
		METEOR_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081E7")]
		NECRO_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081E8")]
		JUNGLE_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081E9")]
		MOLTEN_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081EA")]
		GOGGLES,
		[Cpp2IlInjected.Token(Token = "0x40081EB")]
		MINING_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081EC")]
		SUNGLASSES,
		[Cpp2IlInjected.Token(Token = "0x40081ED")]
		EMPTY_BUCKET,
		[Cpp2IlInjected.Token(Token = "0x40081EE")]
		WIZARD_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081EF")]
		TOP_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081F0")]
		SUMMER_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081F1")]
		BUNNY_HOOD,
		[Cpp2IlInjected.Token(Token = "0x40081F2")]
		PLUMBERS_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081F3")]
		HEROS_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081F4")]
		FISH_BOWL,
		[Cpp2IlInjected.Token(Token = "0x40081F5")]
		ARCHAEOLOGISTS_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081F6")]
		NINJA_HOOD,
		[Cpp2IlInjected.Token(Token = "0x40081F7")]
		JUNGLE_ROSE,
		[Cpp2IlInjected.Token(Token = "0x40081F8")]
		RED_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081F9")]
		ROBOT_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081FA")]
		GOLD_CROWN,
		[Cpp2IlInjected.Token(Token = "0x40081FB")]
		DIVING_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081FC")]
		MIME_MASK,
		[Cpp2IlInjected.Token(Token = "0x40081FD")]
		COBALT_HAT,
		[Cpp2IlInjected.Token(Token = "0x40081FE")]
		COBALT_HELMET,
		[Cpp2IlInjected.Token(Token = "0x40081FF")]
		COBALT_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008200")]
		MYTHRIL_HOOD,
		[Cpp2IlInjected.Token(Token = "0x4008201")]
		MYTHRIL_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008202")]
		MYTHRIL_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008203")]
		ADAMANTITE_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x4008204")]
		ADAMANTITE_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008205")]
		ADAMANTITE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008206")]
		WEREWOLF,
		[Cpp2IlInjected.Token(Token = "0x4008207")]
		MERMAN,
		[Cpp2IlInjected.Token(Token = "0x4008208")]
		CLOWN_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008209")]
		HALLOWED_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400820A")]
		HALLOWED_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x400820B")]
		HALLOWED_MASK,
		[Cpp2IlInjected.Token(Token = "0x400820C")]
		SANTA_HAT,
		[Cpp2IlInjected.Token(Token = "0x400820D")]
		REDS_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400820E")]
		FROST_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400820F")]
		TIN_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008210")]
		LEAD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008211")]
		TUNGSTEN_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008212")]
		PLATINUM_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008213")]
		PLATINUM_CROWN,
		[Cpp2IlInjected.Token(Token = "0x4008214")]
		WOOD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008215")]
		EBONWOOD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008216")]
		RICH_MAHOGANY_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008217")]
		PEARLWOOD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008218")]
		RUNE_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008219")]
		CRIMSON_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400821A")]
		ESKIMO_HOOD,
		[Cpp2IlInjected.Token(Token = "0x400821B")]
		STEAMPUNK_HAT,
		[Cpp2IlInjected.Token(Token = "0x400821C")]
		BEE_HAT,
		[Cpp2IlInjected.Token(Token = "0x400821D")]
		PHARAOHS_MASK,
		[Cpp2IlInjected.Token(Token = "0x400821E")]
		TIARA,
		[Cpp2IlInjected.Token(Token = "0x400821F")]
		GREEN_CAP,
		[Cpp2IlInjected.Token(Token = "0x4008220")]
		MUSHROOM_CAP,
		[Cpp2IlInjected.Token(Token = "0x4008221")]
		TAM_O_SHANTER,
		[Cpp2IlInjected.Token(Token = "0x4008222")]
		MUMMY_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008223")]
		COWBOY_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008224")]
		PIRATE_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008225")]
		VIKING_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008226")]
		CACTUS_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008227")]
		SHADEWOOD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008228")]
		ANCIENT_IRON_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008229")]
		ANCIENT_GOLD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400822A")]
		ANCIENT_SHADOW_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400822B")]
		ANCIENT_NECRO_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400822C")]
		ANCIENT_COBALT_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400822D")]
		PINK_ESKIMO_HOOD,
		[Cpp2IlInjected.Token(Token = "0x400822E")]
		CHLOROPHYTE_MASK,
		[Cpp2IlInjected.Token(Token = "0x400822F")]
		CHLOROPHYTE_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008230")]
		CHLOROPHYTE_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x4008231")]
		RAIN_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008232")]
		TIKI_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008233")]
		PALLADIUM_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008234")]
		PALLADIUM_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008235")]
		PALLADIUM_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x4008236")]
		ORICHALCUM_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008237")]
		ORICHALCUM_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008238")]
		ORICHALCUM_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x4008239")]
		TITANIUM_MASK,
		[Cpp2IlInjected.Token(Token = "0x400823A")]
		TITANIUM_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400823B")]
		TITANIUM_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x400823C")]
		UMBRELLA_HAT,
		[Cpp2IlInjected.Token(Token = "0x400823D")]
		SKULL,
		[Cpp2IlInjected.Token(Token = "0x400823E")]
		BALLA_HAT,
		[Cpp2IlInjected.Token(Token = "0x400823F")]
		GANGSTA_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008240")]
		SAILOR_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008241")]
		EYE_PATCH,
		[Cpp2IlInjected.Token(Token = "0x4008242")]
		SKELETRON_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008243")]
		TURTLE_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008244")]
		BEANIE,
		[Cpp2IlInjected.Token(Token = "0x4008245")]
		SPECTRE_HOOD,
		[Cpp2IlInjected.Token(Token = "0x4008246")]
		SWAT_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008247")]
		SHROOMITE_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x4008248")]
		SHROOMITE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008249")]
		SHROOMITE_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400824A")]
		CENXS_TIARA,
		[Cpp2IlInjected.Token(Token = "0x400824B")]
		CROWNOS_MASK,
		[Cpp2IlInjected.Token(Token = "0x400824C")]
		WILLS_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400824D")]
		JIMS_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400824E")]
		AARONS_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400824F")]
		D_TOWNS_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008250")]
		PUMPKIN_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008251")]
		NURSE_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008252")]
		WIZARDS_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008253")]
		GUY_FAWKES_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008254")]
		STEAM_PUNK_GOGGLES,
		[Cpp2IlInjected.Token(Token = "0x4008255")]
		CYBORG_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008256")]
		CREEPER_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008257")]
		CAT_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008258")]
		GHOST_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008259")]
		PUMPKIN_MASK,
		[Cpp2IlInjected.Token(Token = "0x400825A")]
		ROBOT_MASK,
		[Cpp2IlInjected.Token(Token = "0x400825B")]
		UNICORN_MASK,
		[Cpp2IlInjected.Token(Token = "0x400825C")]
		VAMPIRE_MASK,
		[Cpp2IlInjected.Token(Token = "0x400825D")]
		WITCH_HAT,
		[Cpp2IlInjected.Token(Token = "0x400825E")]
		LEPRECHAUN_HAT,
		[Cpp2IlInjected.Token(Token = "0x400825F")]
		PRINCESS_HAT_HALLOWEEN,
		[Cpp2IlInjected.Token(Token = "0x4008260")]
		BRIDE_OF_FRANKENSTEIN_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008261")]
		KARATE_TORTOISE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008262")]
		SCARECROW_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008263")]
		REAPER_HOOD,
		[Cpp2IlInjected.Token(Token = "0x4008264")]
		FOX_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008265")]
		CAT_EARS,
		[Cpp2IlInjected.Token(Token = "0x4008266")]
		SPOOKY_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008267")]
		SPACE_CREATURE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008268")]
		WOLF_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008269")]
		JACK_O_LANTERN_MASK,
		[Cpp2IlInjected.Token(Token = "0x400826A")]
		DRAGON_MASK,
		[Cpp2IlInjected.Token(Token = "0x400826B")]
		TITAN_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400826C")]
		SPECTRAL_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x400826D")]
		FABULOUS_RIBBON,
		[Cpp2IlInjected.Token(Token = "0x400826E")]
		GEORGES_HAT,
		[Cpp2IlInjected.Token(Token = "0x400826F")]
		NEWYEARS_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008270")]
		DIRNDL,
		[Cpp2IlInjected.Token(Token = "0x4008271")]
		TIROLER,
		[Cpp2IlInjected.Token(Token = "0x4008272")]
		GIANT_BOW,
		[Cpp2IlInjected.Token(Token = "0x4008273")]
		REINDEER_ANTLERS,
		[Cpp2IlInjected.Token(Token = "0x4008274")]
		MRS_CLAUSE_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008275")]
		PARKA_HOOD,
		[Cpp2IlInjected.Token(Token = "0x4008276")]
		TREE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008277")]
		SNOW_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008278")]
		ELF_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008279")]
		FEZ,
		[Cpp2IlInjected.Token(Token = "0x400827A")]
		BEETLE_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400827B")]
		BRAIN_MASK,
		[Cpp2IlInjected.Token(Token = "0x400827C")]
		FLESH_MASK,
		[Cpp2IlInjected.Token(Token = "0x400827D")]
		TWIN_MASK,
		[Cpp2IlInjected.Token(Token = "0x400827E")]
		SKELETRON_PRIME_MASK,
		[Cpp2IlInjected.Token(Token = "0x400827F")]
		BEE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008280")]
		PLANTERA_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008281")]
		GOLEM_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008282")]
		EATER_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008283")]
		EYE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008284")]
		DESTROYER_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008285")]
		MAGIC_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008286")]
		SPECTRE_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008287")]
		PEDDLERS_HAT,
		[Cpp2IlInjected.Token(Token = "0x4008288")]
		BEE_HEADGEAR,
		[Cpp2IlInjected.Token(Token = "0x4008289")]
		ANGLER_HAT,
		[Cpp2IlInjected.Token(Token = "0x400828A")]
		SPIDER_MASK,
		[Cpp2IlInjected.Token(Token = "0x400828B")]
		SEASHELL_HAIRPIN,
		[Cpp2IlInjected.Token(Token = "0x400828C")]
		KING_SLIME_MASK,
		[Cpp2IlInjected.Token(Token = "0x400828D")]
		FISH_COSTUME_MASK,
		[Cpp2IlInjected.Token(Token = "0x400828E")]
		BOREAL_WOOD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x400828F")]
		PALM_WOOD_HELMET,
		[Cpp2IlInjected.Token(Token = "0x4008290")]
		DUKE_FISHRON_MASK,
		[Cpp2IlInjected.Token(Token = "0x4008291")]
		MYTHICAL_LION_MASK
	}

	[Cpp2IlInjected.Token(Token = "0x20008F6")]
	private enum ARMOR_LEG_SLOTS
	{
		[Cpp2IlInjected.Token(Token = "0x4008293")]
		COPPER_GREAVES = 1,
		[Cpp2IlInjected.Token(Token = "0x4008294")]
		IRON_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x4008295")]
		SILVER_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x4008296")]
		GOLD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x4008297")]
		SHADOW_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x4008298")]
		METEOR_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x4008299")]
		NECRO_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x400829A")]
		JUNGLE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x400829B")]
		MOLTEN_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x400829C")]
		TUXEDO_PANTS,
		[Cpp2IlInjected.Token(Token = "0x400829D")]
		PLUMBERS_PANTS,
		[Cpp2IlInjected.Token(Token = "0x400829E")]
		HEROS_PANTS,
		[Cpp2IlInjected.Token(Token = "0x400829F")]
		ARCHAEOLOGISTS_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082A0")]
		NINJA_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082A1")]
		THE_DOCTORS_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082A2")]
		COBALT_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082A3")]
		MYTHRIL_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082A4")]
		ADAMANTITE_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082A5")]
		MINING_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082A6")]
		WEREWOLF,
		[Cpp2IlInjected.Token(Token = "0x40082A7")]
		MERMAN,
		[Cpp2IlInjected.Token(Token = "0x40082A8")]
		CLOWN_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082A9")]
		HALLOWED_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082AA")]
		SANTA_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082AB")]
		REDS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082AC")]
		FROST_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082AD")]
		TIN_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082AE")]
		LEAD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082AF")]
		TUNGSTEN_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B0")]
		PLATINUM_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B1")]
		WOOD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B2")]
		EBONWOOD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B3")]
		RICH_MAHOGANY_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B4")]
		PEARLWOOD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B5")]
		CRIMSON_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082B6")]
		ESKIMO_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082B7")]
		STEAMPUNK_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082B8")]
		BEE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082B9")]
		MUMMY_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082BA")]
		COWBOY_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082BB")]
		PIRATE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082BC")]
		CACTUS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082BD")]
		SHADEWOOD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082BE")]
		ANCIENT_SHADOW_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082BF")]
		ANCIENT_COBALT_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082C0")]
		PINK_ESKIMO_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082C1")]
		CHLOROPHYTE_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082C2")]
		TIKI_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082C3")]
		PALLADIUM_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082C4")]
		ORICHALCUM_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082C5")]
		TITANIUM_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082C6")]
		SAILOR_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082C7")]
		WHITE_TUXEDO_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082C8")]
		TURTLE_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082C9")]
		SPECTRE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082CA")]
		SHROOMITE_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082CB")]
		CENXS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082CC")]
		CROWNOS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082CD")]
		WILLS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082CE")]
		JIMS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082CF")]
		AARONS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082D0")]
		D_TOWNS_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082D1")]
		CENXS_DRESS_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D2")]
		PUMPKIN_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082D3")]
		NURSE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D4")]
		CYBORG_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D5")]
		CREEPER_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D6")]
		CAT_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D7")]
		PUMPKIN_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D8")]
		ROBOT_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082D9")]
		UNICORN_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082DA")]
		VAMPIRE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082DB")]
		LEPRECHAUN_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082DC")]
		PIXIE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082DD")]
		WITCH_BOOTS,
		[Cpp2IlInjected.Token(Token = "0x40082DE")]
		KARATE_TORTOISE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082DF")]
		SCARECROW_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082E0")]
		FOX_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082E1")]
		SPOOKY_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082E2")]
		SPACE_CREATURE_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082E3")]
		WOLF_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082E4")]
		TREASURE_HUNTER_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082E5")]
		DRYAD_LOINCLOTH,
		[Cpp2IlInjected.Token(Token = "0x40082E6")]
		MRS_CLAUSE_HEELS,
		[Cpp2IlInjected.Token(Token = "0x40082E7")]
		TREE_TRUNKS,
		[Cpp2IlInjected.Token(Token = "0x40082E8")]
		PARKA_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082E9")]
		ELF_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082EA")]
		ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082EB")]
		RUNE_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082EC")]
		PHARAOHS_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082ED")]
		AMETHYST_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082EE")]
		TOPAZ_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082EF")]
		SAPPHIRE_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082F0")]
		EMERALD_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082F1")]
		RUBY_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082F2")]
		DIAMOND_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082F3")]
		PRINCESS_DRESS,
		[Cpp2IlInjected.Token(Token = "0x40082F4")]
		BEETLE_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x40082F5")]
		GI,
		[Cpp2IlInjected.Token(Token = "0x40082F6")]
		KIMONO,
		[Cpp2IlInjected.Token(Token = "0x40082F7")]
		GYPSY_ROBE,
		[Cpp2IlInjected.Token(Token = "0x40082F8")]
		BEE_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082F9")]
		ANGLER_PANTS,
		[Cpp2IlInjected.Token(Token = "0x40082FA")]
		SPIDER_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082FB")]
		MERMAID_TAIL,
		[Cpp2IlInjected.Token(Token = "0x40082FC")]
		FISH_COSTUME_FINSKIRT,
		[Cpp2IlInjected.Token(Token = "0x40082FD")]
		BOREAL_WOOD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082FE")]
		PALM_WOOD_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x40082FF")]
		DRAGON_GREAVES,
		[Cpp2IlInjected.Token(Token = "0x4008300")]
		TITAN_LEGGINGS,
		[Cpp2IlInjected.Token(Token = "0x4008301")]
		SPECTRAL_SUBLIGAR,
		[Cpp2IlInjected.Token(Token = "0x4008302")]
		FABULOUS_SLIPPERS,
		[Cpp2IlInjected.Token(Token = "0x4008303")]
		GEORGES_TUXEDO_PANTS,
		[Cpp2IlInjected.Token(Token = "0x4008304")]
		DIRNDL,
		[Cpp2IlInjected.Token(Token = "0x4008305")]
		TIROLER,
		[Cpp2IlInjected.Token(Token = "0x4008306")]
		OSTARA_BOOTS,
		[Cpp2IlInjected.Token(Token = "0x4008307")]
		MYTHICALROBE
	}

	[Cpp2IlInjected.Token(Token = "0x40032B7")]
	public static int CompensatedCurrency;

	[Cpp2IlInjected.Token(Token = "0x6002FD3")]
	[Cpp2IlInjected.Address(RVA = "0xE3E108", Offset = "0xE3E108", VA = "0xE3E108")]
	public static bool ModifyItem(ref short itemId, ref short itemStack, ref byte prefix, bool chestConversion = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FD4")]
	[Cpp2IlInjected.Address(RVA = "0xE3E5FC", Offset = "0xE3E5FC", VA = "0xE3E5FC")]
	private static void GetCoinItem(int coinValue, ref short itemId, ref short itemStack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FD5")]
	[Cpp2IlInjected.Address(RVA = "0xE3E6E8", Offset = "0xE3E6E8", VA = "0xE3E6E8")]
	public static bool ModifyBodySlot(ref int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FD6")]
	[Cpp2IlInjected.Address(RVA = "0xE3EED4", Offset = "0xE3EED4", VA = "0xE3EED4")]
	public static bool ModifyHeadSlot(ref int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FD7")]
	[Cpp2IlInjected.Address(RVA = "0xE3FA1C", Offset = "0xE3FA1C", VA = "0xE3FA1C")]
	public static bool ModifyLegSlot(ref int slot)
	{
		return default(bool);
	}
}
