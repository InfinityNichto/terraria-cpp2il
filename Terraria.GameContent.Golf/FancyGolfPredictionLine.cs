using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.Graphics;

namespace Terraria.GameContent.Golf;

[Cpp2IlInjected.Token(Token = "0x200067C")]
public class FancyGolfPredictionLine
{
	[Cpp2IlInjected.Token(Token = "0x2000A64")]
	private class PredictionEntity : Entity
	{
		[Cpp2IlInjected.Token(Token = "0x60050F2")]
		[Cpp2IlInjected.Address(RVA = "0xE6AF0C", Offset = "0xE6AF0C", VA = "0xE6AF0C")]
		public PredictionEntity()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DA1")]
	private readonly List<Vector2> _positions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006DA2")]
	private readonly Entity _entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006DA3")]
	private readonly int _iterations;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006DA4")]
	private readonly Color[] _colors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006DA5")]
	private readonly BasicDebugDrawer _drawer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006DA6")]
	private float _time;

	[Cpp2IlInjected.Token(Token = "0x6004172")]
	[Cpp2IlInjected.Address(RVA = "0xE6AD7C", Offset = "0xE6AD7C", VA = "0xE6AD7C")]
	public FancyGolfPredictionLine(int iterations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004173")]
	[Cpp2IlInjected.Address(RVA = "0xE6AF14", Offset = "0xE6AF14", VA = "0xE6AF14")]
	public void Update(Entity golfBall, Vector2 impactVelocity, float roughLandResistance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004174")]
	[Cpp2IlInjected.Address(RVA = "0xE6B4EC", Offset = "0xE6B4EC", VA = "0xE6B4EC")]
	public void Draw(Camera camera, SpriteBatch spriteBatch, float chargeProgress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004175")]
	[Cpp2IlInjected.Address(RVA = "0xE6BF64", Offset = "0xE6BF64", VA = "0xE6BF64")]
	private Color GetColor(float travelledLength)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6004176")]
	[Cpp2IlInjected.Address(RVA = "0xE6BCB8", Offset = "0xE6BCB8", VA = "0xE6BCB8")]
	private Color GetColor2(float index)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6004177")]
	[Cpp2IlInjected.Address(RVA = "0xE6BE38", Offset = "0xE6BE38", VA = "0xE6BE38")]
	private float GetScale(float travelledLength)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004178")]
	[Cpp2IlInjected.Address(RVA = "0xE6B9AC", Offset = "0xE6B9AC", VA = "0xE6B9AC")]
	private void GetSectionLength(int startIndex, out float length, out float rotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004179")]
	[Cpp2IlInjected.Address(RVA = "0xE6BB64", Offset = "0xE6BB64", VA = "0xE6BB64")]
	private Vector2 GetPosition(float indexProgress)
	{
		return default(Vector2);
	}
}
