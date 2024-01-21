using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000666")]
public class StardustSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A51")]
	private struct Star
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E03")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E04")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E05")]
		public int TextureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E06")]
		public float SinOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008E07")]
		public float AlphaFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008E08")]
		public float AlphaAmplitude;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006D06")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006D07")]
	private Asset<Texture2D> _planetTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006D08")]
	private Asset<Texture2D> _bgTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006D09")]
	private Asset<Texture2D>[] _starTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006D0A")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006D0B")]
	private Star[] _stars;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006D0C")]
	private float _fadeOpacity;

	[Cpp2IlInjected.Token(Token = "0x600402D")]
	[Cpp2IlInjected.Address(RVA = "0x13CB9D4", Offset = "0x13CB9D4", VA = "0x13CB9D4", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600402E")]
	[Cpp2IlInjected.Address(RVA = "0x13CBD70", Offset = "0x13CBD70", VA = "0x13CBD70", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600402F")]
	[Cpp2IlInjected.Address(RVA = "0x13CBE58", Offset = "0x13CBE58", VA = "0x13CBE58", Slot = "12")]
	public override Color OnTileColor(Color inColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6004030")]
	[Cpp2IlInjected.Address(RVA = "0x13CBFB0", Offset = "0x13CBFB0", VA = "0x13CBFB0", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004031")]
	[Cpp2IlInjected.Address(RVA = "0x13CCB44", Offset = "0x13CCB44", VA = "0x13CCB44", Slot = "13")]
	public override float GetCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004032")]
	[Cpp2IlInjected.Address(RVA = "0x13CCB6C", Offset = "0x13CCB6C", VA = "0x13CCB6C", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004033")]
	[Cpp2IlInjected.Address(RVA = "0x13CCE50", Offset = "0x13CCE50", VA = "0x13CCE50")]
	private int SortMethod(Star meteor1, Star meteor2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004034")]
	[Cpp2IlInjected.Address(RVA = "0x13CCEA0", Offset = "0x13CCEA0", VA = "0x13CCEA0", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004035")]
	[Cpp2IlInjected.Address(RVA = "0x13CCEAC", Offset = "0x13CCEAC", VA = "0x13CCEAC", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004036")]
	[Cpp2IlInjected.Address(RVA = "0x13CCEB8", Offset = "0x13CCEB8", VA = "0x13CCEB8", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004037")]
	[Cpp2IlInjected.Address(RVA = "0x13CCEEC", Offset = "0x13CCEEC", VA = "0x13CCEEC")]
	public StardustSky()
	{
	}
}
