using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E5")]
public struct FinalFractalHelper
{
	[Cpp2IlInjected.Token(Token = "0x200095A")]
	public delegate void SpawnDustMethod(Vector2 centerPosition, float rotation, Vector2 velocity);

	[Cpp2IlInjected.Token(Token = "0x200095B")]
	public struct FinalFractalProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008B83")]
		public float trailWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008B84")]
		public Color trailColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B85")]
		public SpawnDustMethod dustMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B86")]
		public VertexStrip.StripColorFunction colorMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008B87")]
		public VertexStrip.StripHalfWidthFunction widthMethod;

		[Cpp2IlInjected.Token(Token = "0x6004D77")]
		[Cpp2IlInjected.Address(RVA = "0x3A0778", Offset = "0x3A0778", VA = "0x3A0778")]
		public FinalFractalProfile(float fullBladeLength, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D78")]
		[Cpp2IlInjected.Address(RVA = "0x3A0780", Offset = "0x3A0780", VA = "0x3A0780")]
		private void StripDust(Vector2 centerPosition, float rotation, Vector2 velocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D79")]
		[Cpp2IlInjected.Address(RVA = "0x3A079C", Offset = "0x3A079C", VA = "0x3A079C")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D7A")]
		[Cpp2IlInjected.Address(RVA = "0x3A07A4", Offset = "0x3A07A4", VA = "0x3A07A4")]
		private float StripWidth(float progressOnStrip)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400672A")]
	public const int TotalIllusions = 4;

	[Cpp2IlInjected.Token(Token = "0x400672B")]
	public const int FramesPerImportantTrail = 15;

	[Cpp2IlInjected.Token(Token = "0x400672C")]
	private static VertexStrip _vertexStrip;

	[Cpp2IlInjected.Token(Token = "0x400672D")]
	private static Dictionary<int, FinalFractalProfile> _fractalProfiles;

	[Cpp2IlInjected.Token(Token = "0x400672E")]
	private static FinalFractalProfile _defaultProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400672F")]
	private Asset<Texture2D> FinalFractalAsset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006730")]
	private Asset<Texture2D> MagicMissileTrailErosionAsset;

	[Cpp2IlInjected.Token(Token = "0x60036EE")]
	[Cpp2IlInjected.Address(RVA = "0x150B230", Offset = "0x150B230", VA = "0x150B230")]
	public static int GetRandomProfileIndex()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60036EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A0668", Offset = "0x3A0668", VA = "0x3A0668")]
	public void Draw(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036F0")]
	[Cpp2IlInjected.Address(RVA = "0x150BB84", Offset = "0x150BB84", VA = "0x150BB84")]
	public static FinalFractalProfile GetFinalFractalProfile(int usedSwordId)
	{
		return default(FinalFractalProfile);
	}

	[Cpp2IlInjected.Token(Token = "0x60036F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A0670", Offset = "0x3A0670", VA = "0x3A0670")]
	private Color StripColors(float progressOnStrip)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60036F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A0674", Offset = "0x3A0674", VA = "0x3A0674")]
	private float StripWidth(float progressOnStrip)
	{
		return default(float);
	}
}
