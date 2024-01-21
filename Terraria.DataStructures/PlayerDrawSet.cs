using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000447")]
public struct PlayerDrawSet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400632B")]
	public int DrawDataCacheCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400632C")]
	public DrawData[] DrawDataCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400632D")]
	public List<int> DustCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400632E")]
	public List<int> GoreCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400632F")]
	public Player drawPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006330")]
	public float shadow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006331")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006332")]
	public int projectileDrawPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006333")]
	public Vector2 ItemLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006334")]
	public int armorAdjust;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006335")]
	public bool missingHand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4006336")]
	public bool missingArm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4006337")]
	public bool heldProjOverHand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006338")]
	public int skinVar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006339")]
	public bool fullHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400633A")]
	public bool drawsBackHairWithoutHeadgear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x400633B")]
	public bool hatHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x400633C")]
	public bool hideHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400633D")]
	public int hairDyePacked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400633E")]
	public int skinDyePacked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400633F")]
	public float mountOffSet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4006340")]
	public int cHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4006341")]
	public int cBody;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4006342")]
	public int cLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4006343")]
	public int cHandOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4006344")]
	public int cHandOff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4006345")]
	public int cBack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4006346")]
	public int cFront;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006347")]
	public int cShoe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4006348")]
	public int cFlameWaker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4006349")]
	public int cWaist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400634A")]
	public int cShield;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400634B")]
	public int cNeck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400634C")]
	public int cFace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400634D")]
	public int cBalloon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400634E")]
	public int cWings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400634F")]
	public int cCarpet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4006350")]
	public int cPortableStool;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4006351")]
	public int cFloatingTube;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4006352")]
	public int cUnicornHorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4006353")]
	public int cAngelHalo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4006354")]
	public int cBeard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4006355")]
	public int cLeinShampoo;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4006356")]
	public int cBackpack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4006357")]
	public int cTail;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4006358")]
	public int cFaceHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4006359")]
	public int cFaceFlower;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400635A")]
	public int cBalloonFront;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400635B")]
	public SpriteEffects playerEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400635C")]
	public SpriteEffects itemEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400635D")]
	public Color colorHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400635E")]
	public Color colorEyeWhites;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400635F")]
	public Color colorEyes;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4006360")]
	public Color colorHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4006361")]
	public Color colorBodySkin;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4006362")]
	public Color colorLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4006363")]
	public Color colorShirt;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4006364")]
	public Color colorUnderShirt;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4006365")]
	public Color colorPants;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4006366")]
	public Color colorShoes;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4006367")]
	public Color colorArmorHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4006368")]
	public Color colorArmorBody;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4006369")]
	public Color colorMount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400636A")]
	public Color colorArmorLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400636B")]
	public Color colorElectricity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400636C")]
	public Color colorDisplayDollSkin;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400636D")]
	public int headGlowMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400636E")]
	public int bodyGlowMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400636F")]
	public int armGlowMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006370")]
	public int legsGlowMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006371")]
	public Color headGlowColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006372")]
	public Color bodyGlowColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006373")]
	public Color armGlowColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4006374")]
	public Color legsGlowColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4006375")]
	public Color ArkhalisColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4006376")]
	public float stealth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4006377")]
	public Vector2 legVect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4006378")]
	public Vector2 bodyVect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4006379")]
	public Vector2 headVect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x400637A")]
	public Color selectionGlowColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400637B")]
	public float torsoOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400637C")]
	public bool hidesTopSkin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x145")]
	[Cpp2IlInjected.Token(Token = "0x400637D")]
	public bool hidesBottomSkin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400637E")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x400637F")]
	public Vector2 rotationOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4006380")]
	public Rectangle hairFrontFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4006381")]
	public Rectangle hairBackFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x4006382")]
	public bool backHairDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
	[Cpp2IlInjected.Token(Token = "0x4006383")]
	public Color itemColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
	[Cpp2IlInjected.Token(Token = "0x4006384")]
	public bool usesCompositeTorso;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
	[Cpp2IlInjected.Token(Token = "0x4006385")]
	public bool usesCompositeFrontHandAcc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
	[Cpp2IlInjected.Token(Token = "0x4006386")]
	public bool usesCompositeBackHandAcc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4006387")]
	public bool compShoulderOverFrontArm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4006388")]
	public Rectangle compBackShoulderFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4006389")]
	public Rectangle compFrontShoulderFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400638A")]
	public Rectangle compBackArmFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400638B")]
	public Rectangle compFrontArmFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400638C")]
	public Rectangle compTorsoFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400638D")]
	public float compositeBackArmRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x400638E")]
	public float compositeFrontArmRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x400638F")]
	public bool hideCompositeShoulders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x4006390")]
	public Vector2 frontShoulderOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x4006391")]
	public Vector2 backShoulderOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x4006392")]
	public WeaponDrawOrder weaponDrawOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4006393")]
	public bool weaponOverFrontArm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F1")]
	[Cpp2IlInjected.Token(Token = "0x4006394")]
	public bool isSitting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F2")]
	[Cpp2IlInjected.Token(Token = "0x4006395")]
	public bool isSleeping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Cpp2IlInjected.Token(Token = "0x4006396")]
	public float seatYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x4006397")]
	public int sittingIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x4006398")]
	public bool drawFrontAccInNeckAccLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4006399")]
	public Item heldItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x400639A")]
	public bool drawFloatingTube;

	[Cpp2IlInjected.FieldOffset(Offset = "0x205")]
	[Cpp2IlInjected.Token(Token = "0x400639B")]
	public bool drawUnicornHorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x206")]
	[Cpp2IlInjected.Token(Token = "0x400639C")]
	public bool drawAngelHalo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x207")]
	[Cpp2IlInjected.Token(Token = "0x400639D")]
	public Color floatingTubeColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x400639E")]
	public Vector2 hairOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x400639F")]
	public Vector2 helmetOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x40063A0")]
	public Vector2 legsOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Cpp2IlInjected.Token(Token = "0x40063A1")]
	public bool hideEntirePlayer;

	[Cpp2IlInjected.Token(Token = "0x17000622")]
	public Vector2 Center
	{
		[Cpp2IlInjected.Token(Token = "0x6003183")]
		[Cpp2IlInjected.Address(RVA = "0x39D6C8", Offset = "0x39D6C8", VA = "0x39D6C8")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003181")]
	[Cpp2IlInjected.Address(RVA = "0x39D64C", Offset = "0x39D64C", VA = "0x39D64C")]
	public void AddDrawData(ref DrawData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003182")]
	[Cpp2IlInjected.Address(RVA = "0x39D654", Offset = "0x39D654", VA = "0x39D654")]
	public void AddDrawData(DrawData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003184")]
	[Cpp2IlInjected.Address(RVA = "0x39D728", Offset = "0x39D728", VA = "0x39D728")]
	public void BoringSetup(Player player, DrawData[] drawData, List<int> dust, List<int> gore, Vector2 drawPosition, float shadowOpacity, float rotation, Vector2 rotationOrigin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003185")]
	[Cpp2IlInjected.Address(RVA = "0x39D778", Offset = "0x39D778", VA = "0x39D778")]
	private void AdjustmentsForWolfMount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003186")]
	[Cpp2IlInjected.Address(RVA = "0x39D780", Offset = "0x39D780", VA = "0x39D780")]
	private void CreateCompositeData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003187")]
	[Cpp2IlInjected.Address(RVA = "0x39D788", Offset = "0x39D788", VA = "0x39D788")]
	private void CreateCompositeData_DetermineShoulderOffsets(int armor, int targetFrameNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003188")]
	[Cpp2IlInjected.Address(RVA = "0x39D790", Offset = "0x39D790", VA = "0x39D790")]
	private Rectangle CreateCompositeFrameRect(Point pt)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003189")]
	[Cpp2IlInjected.Address(RVA = "0x39D7D0", Offset = "0x39D7D0", VA = "0x39D7D0")]
	private void UpdateCompositeArm(Player.CompositeArmData data, ref float rotation, ref Point frameIndex, int targetX)
	{
	}
}
