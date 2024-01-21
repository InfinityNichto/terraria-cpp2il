using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200044A")]
public struct PlayerDrawHeadSet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40063AE")]
	public int DrawDataCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40063AF")]
	public DrawData[] DrawData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40063B0")]
	public List<int> Dust;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40063B1")]
	public List<int> Gore;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40063B2")]
	public Player drawPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40063B3")]
	public int cHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40063B4")]
	public int cFace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40063B5")]
	public int cFaceHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40063B6")]
	public int cFaceFlower;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40063B7")]
	public int cUnicornHorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40063B8")]
	public int cAngelHalo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40063B9")]
	public int cBeard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40063BA")]
	public int skinVar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40063BB")]
	public int hairShaderPacked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40063BC")]
	public int skinDyePacked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40063BD")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40063BE")]
	public Color colorEyeWhites;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40063BF")]
	public Color colorEyes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40063C0")]
	public Color colorHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40063C1")]
	public Color colorHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40063C2")]
	public Color colorArmorHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40063C3")]
	public Color colorDisplayDollSkin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40063C4")]
	public SpriteEffects playerEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40063C5")]
	public Vector2 headVect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40063C6")]
	public Rectangle bodyFrameMemory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40063C7")]
	public bool fullHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x75")]
	[Cpp2IlInjected.Token(Token = "0x40063C8")]
	public bool hatHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x76")]
	[Cpp2IlInjected.Token(Token = "0x40063C9")]
	public bool hideHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x77")]
	[Cpp2IlInjected.Token(Token = "0x40063CA")]
	public bool helmetIsTall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40063CB")]
	public bool helmetIsOverFullHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40063CC")]
	public bool helmetIsNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
	[Cpp2IlInjected.Token(Token = "0x40063CD")]
	public bool drawUnicornHorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7B")]
	[Cpp2IlInjected.Token(Token = "0x40063CE")]
	public bool drawAngelHalo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40063CF")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40063D0")]
	public Vector2 hairOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40063D1")]
	public Vector2 helmetOffset;

	[Cpp2IlInjected.Token(Token = "0x17000624")]
	public Rectangle HairFrame
	{
		[Cpp2IlInjected.Token(Token = "0x60031DE")]
		[Cpp2IlInjected.Address(RVA = "0x39B454", Offset = "0x39B454", VA = "0x39B454")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60031DD")]
	[Cpp2IlInjected.Address(RVA = "0x39B44C", Offset = "0x39B44C", VA = "0x39B44C")]
	public void AddDrawData(ref DrawData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031DF")]
	[Cpp2IlInjected.Address(RVA = "0x39B474", Offset = "0x39B474", VA = "0x39B474")]
	public void BoringSetup(Player drawPlayer2, DrawData[] drawData, List<int> dust, List<int> gore, float X, float Y, float Alpha, float Scale)
	{
	}
}
