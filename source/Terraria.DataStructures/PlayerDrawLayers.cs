using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000449")]
public static class PlayerDrawLayers
{
	[Cpp2IlInjected.Token(Token = "0x40063AA")]
	private static List<DrawData> ctgSorter;

	[Cpp2IlInjected.Token(Token = "0x40063AB")]
	private static List<DrawData> modifiedDrawDataBackup;

	[Cpp2IlInjected.Token(Token = "0x40063AC")]
	private static int lastBatchTextureIndex;

	[Cpp2IlInjected.Token(Token = "0x40063AD")]
	private static EffectPass lastEffectPass;

	[Cpp2IlInjected.Token(Token = "0x17000623")]
	private static bool inBatchMode
	{
		[Cpp2IlInjected.Token(Token = "0x60031D7")]
		[Cpp2IlInjected.Address(RVA = "0x1049140", Offset = "0x1049140", VA = "0x1049140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600318A")]
	[Cpp2IlInjected.Address(RVA = "0x101DEC4", Offset = "0x101DEC4", VA = "0x101DEC4")]
	public static void DrawPlayer_extra_TorsoPlus(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600318B")]
	[Cpp2IlInjected.Address(RVA = "0x101DEE4", Offset = "0x101DEE4", VA = "0x101DEE4")]
	public static void DrawPlayer_extra_TorsoMinus(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600318C")]
	[Cpp2IlInjected.Address(RVA = "0x101DF04", Offset = "0x101DF04", VA = "0x101DF04")]
	public static void DrawPlayer_extra_MountPlus(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600318D")]
	[Cpp2IlInjected.Address(RVA = "0x101DF30", Offset = "0x101DF30", VA = "0x101DF30")]
	public static void DrawPlayer_extra_MountMinus(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600318E")]
	[Cpp2IlInjected.Address(RVA = "0x101DF5C", Offset = "0x101DF5C", VA = "0x101DF5C")]
	public static void DrawCompositeArmorPiece(ref PlayerDrawSet drawinfo, CompositePlayerDrawContext context, DrawData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600318F")]
	[Cpp2IlInjected.Address(RVA = "0x101E998", Offset = "0x101E998", VA = "0x101E998")]
	public static void DrawPlayer_01_BackHair(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003190")]
	[Cpp2IlInjected.Address(RVA = "0x101ED70", Offset = "0x101ED70", VA = "0x101ED70")]
	public static void DrawPlayer_02_MountBehindPlayer(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003191")]
	[Cpp2IlInjected.Address(RVA = "0x101F9C8", Offset = "0x101F9C8", VA = "0x101F9C8")]
	public static void DrawPlayer_03_Carpet(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003192")]
	[Cpp2IlInjected.Address(RVA = "0x101FD6C", Offset = "0x101FD6C", VA = "0x101FD6C")]
	public static void DrawPlayer_03_PortableStool(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003193")]
	[Cpp2IlInjected.Address(RVA = "0x1020084", Offset = "0x1020084", VA = "0x1020084")]
	public static void DrawPlayer_04_ElectrifiedDebuffBack(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003194")]
	[Cpp2IlInjected.Address(RVA = "0x10204B4", Offset = "0x10204B4", VA = "0x10204B4")]
	public static void DrawPlayer_05_ForbiddenSetRing(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003195")]
	[Cpp2IlInjected.Address(RVA = "0x1020C38", Offset = "0x1020C38", VA = "0x1020C38")]
	public static void DrawPlayer_01_3_BackHead(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003196")]
	[Cpp2IlInjected.Address(RVA = "0x1020FBC", Offset = "0x1020FBC", VA = "0x1020FBC")]
	public static void DrawPlayer_01_2_JimsCloak(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003197")]
	[Cpp2IlInjected.Address(RVA = "0x10212F4", Offset = "0x10212F4", VA = "0x10212F4")]
	public static void DrawPlayer_05_2_SafemanSun(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003198")]
	[Cpp2IlInjected.Address(RVA = "0x102193C", Offset = "0x102193C", VA = "0x102193C")]
	public static void DrawPlayer_06_WebbedDebuffBack(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003199")]
	[Cpp2IlInjected.Address(RVA = "0x1021CBC", Offset = "0x1021CBC", VA = "0x1021CBC")]
	public static void DrawPlayer_07_LeinforsHairShampoo(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600319A")]
	[Cpp2IlInjected.Address(RVA = "0x1022724", Offset = "0x1022724", VA = "0x1022724")]
	public static bool DrawPlayer_08_PlayerVisuallyHasFullArmorSet(PlayerDrawSet drawinfo, int head, int body, int legs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600319B")]
	[Cpp2IlInjected.Address(RVA = "0x1022788", Offset = "0x1022788", VA = "0x1022788")]
	public static void DrawPlayer_08_Backpacks(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600319C")]
	[Cpp2IlInjected.Address(RVA = "0x1023E00", Offset = "0x1023E00", VA = "0x1023E00")]
	public static void DrawPlayer_08_1_Tails(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600319D")]
	[Cpp2IlInjected.Address(RVA = "0x1024244", Offset = "0x1024244", VA = "0x1024244")]
	public static void DrawPlayer_10_BackAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600319E")]
	[Cpp2IlInjected.Address(RVA = "0x10249E0", Offset = "0x10249E0", VA = "0x10249E0")]
	public static void DrawPlayer_09_Wings(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600319F")]
	[Cpp2IlInjected.Address(RVA = "0x102A7A4", Offset = "0x102A7A4", VA = "0x102A7A4")]
	public static void DrawPlayer_12_1_BalloonFronts(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A0")]
	[Cpp2IlInjected.Address(RVA = "0x102B148", Offset = "0x102B148", VA = "0x102B148")]
	public static void DrawPlayer_11_Balloons(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A1")]
	[Cpp2IlInjected.Address(RVA = "0x102BAEC", Offset = "0x102BAEC", VA = "0x102BAEC")]
	public static void DrawPlayer_12_Skin(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A2")]
	[Cpp2IlInjected.Address(RVA = "0x102CC78", Offset = "0x102CC78", VA = "0x102CC78")]
	public static bool IsBottomOverridden(ref PlayerDrawSet drawinfo)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60031A3")]
	[Cpp2IlInjected.Address(RVA = "0x102D4A0", Offset = "0x102D4A0", VA = "0x102D4A0")]
	public static bool ShouldOverrideLegs_CheckPants(ref PlayerDrawSet drawinfo)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60031A4")]
	[Cpp2IlInjected.Address(RVA = "0x10212DC", Offset = "0x10212DC", VA = "0x10212DC")]
	public static bool ShouldOverrideLegs_CheckShoes(ref PlayerDrawSet drawinfo)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60031A5")]
	[Cpp2IlInjected.Address(RVA = "0x102C218", Offset = "0x102C218", VA = "0x102C218")]
	public static void DrawPlayer_12_Skin_Composite(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A6")]
	[Cpp2IlInjected.Address(RVA = "0x102D704", Offset = "0x102D704", VA = "0x102D704")]
	public static void DrawPlayer_12_SkinComposite_BackArmShirt(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A7")]
	[Cpp2IlInjected.Address(RVA = "0x102E930", Offset = "0x102E930", VA = "0x102E930")]
	public static void DrawPlayer_13_Leggings(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A8")]
	[Cpp2IlInjected.Address(RVA = "0x102FE84", Offset = "0x102FE84", VA = "0x102FE84")]
	private static void DrawSittingLongCoats(ref PlayerDrawSet drawinfo, int specialLegCoat, Texture2D textureToDraw, Color matchingColor, int shaderIndex = 0, bool glowmask = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031A9")]
	[Cpp2IlInjected.Address(RVA = "0x102CD34", Offset = "0x102CD34", VA = "0x102CD34")]
	private static void DrawSittingLegs(ref PlayerDrawSet drawinfo, Texture2D textureToDraw, Color matchingColor, int shaderIndex = 0, bool glowmask = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031AA")]
	[Cpp2IlInjected.Address(RVA = "0x103017C", Offset = "0x103017C", VA = "0x103017C")]
	public static void DrawPlayer_14_Shoes(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031AB")]
	[Cpp2IlInjected.Address(RVA = "0x10305CC", Offset = "0x10305CC", VA = "0x10305CC")]
	public static void DrawPlayer_14_2_GlassSlipperSparkles(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031AC")]
	[Cpp2IlInjected.Address(RVA = "0x1030C84", Offset = "0x1030C84", VA = "0x1030C84")]
	public static void DrawPlayer_15_SkinLongCoat(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031AD")]
	[Cpp2IlInjected.Address(RVA = "0x1031064", Offset = "0x1031064", VA = "0x1031064")]
	public static void DrawPlayer_16_ArmorLongCoat(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031AE")]
	[Cpp2IlInjected.Address(RVA = "0x10315E0", Offset = "0x10315E0", VA = "0x10315E0")]
	public static void DrawPlayer_17_Torso(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031AF")]
	[Cpp2IlInjected.Address(RVA = "0x103271C", Offset = "0x103271C", VA = "0x103271C")]
	public static void DrawPlayer_17_TorsoComposite(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B0")]
	[Cpp2IlInjected.Address(RVA = "0x1033194", Offset = "0x1033194", VA = "0x1033194")]
	public static void DrawPlayer_18_OffhandAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B1")]
	[Cpp2IlInjected.Address(RVA = "0x1033500", Offset = "0x1033500", VA = "0x1033500")]
	public static void DrawPlayer_JimsDroneRadio(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B2")]
	[Cpp2IlInjected.Address(RVA = "0x103383C", Offset = "0x103383C", VA = "0x103383C")]
	public static void DrawPlayer_19_WaistAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B3")]
	[Cpp2IlInjected.Address(RVA = "0x1033BB8", Offset = "0x1033BB8", VA = "0x1033BB8")]
	public static void DrawPlayer_20_NeckAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B4")]
	[Cpp2IlInjected.Address(RVA = "0x1033F14", Offset = "0x1033F14", VA = "0x1033F14")]
	public static void DrawPlayer_21_Head(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B5")]
	[Cpp2IlInjected.Address(RVA = "0x101A02C", Offset = "0x101A02C", VA = "0x101A02C")]
	public static int DrawPlayer_Head_GetTVScreen(Player plr)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60031B6")]
	[Cpp2IlInjected.Address(RVA = "0x103A224", Offset = "0x103A224", VA = "0x103A224")]
	private static int GetHatStacks(ref PlayerDrawSet drawinfo, int hatItemId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60031B7")]
	[Cpp2IlInjected.Address(RVA = "0x1039EE8", Offset = "0x1039EE8", VA = "0x1039EE8")]
	private static Vector2 DrawPlayer_21_Head_GetSpecialHatDrawPosition(ref PlayerDrawSet drawinfo, ref Vector2 helmetOffset, Vector2 hatOffset)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60031B8")]
	[Cpp2IlInjected.Address(RVA = "0x1038968", Offset = "0x1038968", VA = "0x1038968")]
	private static void DrawPlayer_21_Head_TheFace(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031B9")]
	[Cpp2IlInjected.Address(RVA = "0x103A27C", Offset = "0x103A27C", VA = "0x103A27C")]
	public static void DrawPlayer_21_1_Magiluminescence(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031BA")]
	[Cpp2IlInjected.Address(RVA = "0x103A65C", Offset = "0x103A65C", VA = "0x103A65C")]
	public static void DrawPlayer_22_FaceAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031BB")]
	[Cpp2IlInjected.Address(RVA = "0x101F684", Offset = "0x101F684", VA = "0x101F684")]
	public static void DrawTiedBalloons(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031BC")]
	[Cpp2IlInjected.Address(RVA = "0x1029D8C", Offset = "0x1029D8C", VA = "0x1029D8C")]
	public static void DrawStarboardRainbowTrail(ref PlayerDrawSet drawinfo, Vector2 commonWingPosPreFloor, Vector2 dirsVec)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031BD")]
	[Cpp2IlInjected.Address(RVA = "0x101EE80", Offset = "0x101EE80", VA = "0x101EE80")]
	public static void DrawMeowcartTrail(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031BE")]
	[Cpp2IlInjected.Address(RVA = "0x103B47C", Offset = "0x103B47C", VA = "0x103B47C")]
	public static void DrawPlayer_23_MountFront(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031BF")]
	[Cpp2IlInjected.Address(RVA = "0x103B50C", Offset = "0x103B50C", VA = "0x103B50C")]
	public static void DrawPlayer_24_Pulley(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C0")]
	[Cpp2IlInjected.Address(RVA = "0x103BB5C", Offset = "0x103BB5C", VA = "0x103BB5C")]
	public static void DrawPlayer_25_Shield(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C1")]
	[Cpp2IlInjected.Address(RVA = "0x103CE10", Offset = "0x103CE10", VA = "0x103CE10")]
	public static void DrawPlayer_26_SolarShield(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C2")]
	[Cpp2IlInjected.Address(RVA = "0x103D1C8", Offset = "0x103D1C8", VA = "0x103D1C8")]
	public static void DrawPlayer_27_HeldItem(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C3")]
	[Cpp2IlInjected.Address(RVA = "0x1040E2C", Offset = "0x1040E2C", VA = "0x1040E2C")]
	public static void DrawPlayer_28_ArmOverItem(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C4")]
	[Cpp2IlInjected.Address(RVA = "0x1042500", Offset = "0x1042500", VA = "0x1042500")]
	public static void DrawPlayer_28_ArmOverItemComposite(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C5")]
	[Cpp2IlInjected.Address(RVA = "0x1043C50", Offset = "0x1043C50", VA = "0x1043C50")]
	public static void DrawPlayer_29_OnhandAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C6")]
	[Cpp2IlInjected.Address(RVA = "0x1043FBC", Offset = "0x1043FBC", VA = "0x1043FBC")]
	public static void DrawPlayer_30_BladedGlove(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C7")]
	[Cpp2IlInjected.Address(RVA = "0x10445F4", Offset = "0x10445F4", VA = "0x10445F4")]
	public static void DrawPlayer_31_ProjectileOverArm(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C8")]
	[Cpp2IlInjected.Address(RVA = "0x1044628", Offset = "0x1044628", VA = "0x1044628")]
	public static void DrawPlayer_32_FrontAcc(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031C9")]
	[Cpp2IlInjected.Address(RVA = "0x1044A24", Offset = "0x1044A24", VA = "0x1044A24")]
	public static void DrawPlayer_32_FrontAcc_FrontPart(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031CA")]
	[Cpp2IlInjected.Address(RVA = "0x10451B8", Offset = "0x10451B8", VA = "0x10451B8")]
	public static void DrawPlayer_32_FrontAcc_BackPart(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031CB")]
	[Cpp2IlInjected.Address(RVA = "0x1045968", Offset = "0x1045968", VA = "0x1045968")]
	public static void DrawPlayer_33_FrozenOrWebbedDebuff(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031CC")]
	[Cpp2IlInjected.Address(RVA = "0x1046140", Offset = "0x1046140", VA = "0x1046140")]
	public static void DrawPlayer_34_ElectrifiedDebuffFront(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031CD")]
	[Cpp2IlInjected.Address(RVA = "0x1046570", Offset = "0x1046570", VA = "0x1046570")]
	public static void DrawPlayer_35_IceBarrier(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031CE")]
	[Cpp2IlInjected.Address(RVA = "0x10469D8", Offset = "0x10469D8", VA = "0x10469D8")]
	public static void DrawPlayer_36_CTG(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031CF")]
	[Cpp2IlInjected.Address(RVA = "0x10471F0", Offset = "0x10471F0", VA = "0x10471F0")]
	public static void DrawPlayer_37_BeetleBuff(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D0")]
	[Cpp2IlInjected.Address(RVA = "0x1047AE8", Offset = "0x1047AE8", VA = "0x1047AE8")]
	public static void DrawPlayer_38_EyebrellaCloud(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D1")]
	[Cpp2IlInjected.Address(RVA = "0x102D524", Offset = "0x102D524", VA = "0x102D524")]
	private static Vector2 GetCompositeOffset_BackArm(ref PlayerDrawSet drawinfo)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60031D2")]
	[Cpp2IlInjected.Address(RVA = "0x102D63C", Offset = "0x102D63C", VA = "0x102D63C")]
	private static Vector2 GetCompositeOffset_FrontArm(ref PlayerDrawSet drawinfo)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60031D3")]
	[Cpp2IlInjected.Address(RVA = "0x1048188", Offset = "0x1048188", VA = "0x1048188")]
	public static void DrawPlayer_TransformDrawData(ref PlayerDrawSet drawinfo, [Optional] Vector2[] positionalOffsets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D4")]
	[Cpp2IlInjected.Address(RVA = "0x1048A34", Offset = "0x1048A34", VA = "0x1048A34")]
	public static void DrawPlayer_ScaleDrawData(ref PlayerDrawSet drawinfo, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D5")]
	[Cpp2IlInjected.Address(RVA = "0x1048CAC", Offset = "0x1048CAC", VA = "0x1048CAC")]
	public static void DrawPlayer_AddSelectionGlow(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D6")]
	[Cpp2IlInjected.Address(RVA = "0x1049034", Offset = "0x1049034", VA = "0x1049034")]
	public static void DrawPlayer_MakeIntoFirstFractalAfterImage(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D8")]
	[Cpp2IlInjected.Address(RVA = "0x10491BC", Offset = "0x10491BC", VA = "0x10491BC")]
	public static void DrawPlayer_RenderAllLayers(ref PlayerDrawSet drawinfo, [Optional] Vector2[] positionalOffsets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031D9")]
	[Cpp2IlInjected.Address(RVA = "0x104A2F0", Offset = "0x104A2F0", VA = "0x104A2F0")]
	public static void DrawPlayer_DrawSelectionRect(ref PlayerDrawSet drawinfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031DA")]
	[Cpp2IlInjected.Address(RVA = "0x102E91C", Offset = "0x102E91C", VA = "0x102E91C")]
	private static bool IsArmorDrawnWhenInvisible(int torsoID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60031DB")]
	[Cpp2IlInjected.Address(RVA = "0x1048ED8", Offset = "0x1048ED8", VA = "0x1048ED8")]
	private static DrawData[] GetFlatColoredCloneData(ref PlayerDrawSet drawinfo, Vector2 offset, Color color)
	{
		return null;
	}
}
