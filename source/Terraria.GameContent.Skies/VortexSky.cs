using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000667")]
public class VortexSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A52")]
	private struct Bolt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E09")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E0A")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E0B")]
		public int Life;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E0C")]
		public bool IsAlive;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006D0D")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006D0E")]
	private Asset<Texture2D> _planetTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006D0F")]
	private Asset<Texture2D> _bgTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006D10")]
	private Asset<Texture2D> _boltTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006D11")]
	private Asset<Texture2D> _flashTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006D12")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006D13")]
	private int _ticksUntilNextBolt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006D14")]
	private float _fadeOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006D15")]
	private Bolt[] _bolts;

	[Cpp2IlInjected.Token(Token = "0x6004038")]
	[Cpp2IlInjected.Address(RVA = "0x13CCF60", Offset = "0x13CCF60", VA = "0x13CCF60", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004039")]
	[Cpp2IlInjected.Address(RVA = "0x13CD2D8", Offset = "0x13CD2D8", VA = "0x13CD2D8", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600403A")]
	[Cpp2IlInjected.Address(RVA = "0x13CD5C0", Offset = "0x13CD5C0", VA = "0x13CD5C0", Slot = "12")]
	public override Color OnTileColor(Color inColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600403B")]
	[Cpp2IlInjected.Address(RVA = "0x13CD718", Offset = "0x13CD718", VA = "0x13CD718", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600403C")]
	[Cpp2IlInjected.Address(RVA = "0x13CE1A4", Offset = "0x13CE1A4", VA = "0x13CE1A4", Slot = "13")]
	public override float GetCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600403D")]
	[Cpp2IlInjected.Address(RVA = "0x13CE1CC", Offset = "0x13CE1CC", VA = "0x13CE1CC", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600403E")]
	[Cpp2IlInjected.Address(RVA = "0x13CE274", Offset = "0x13CE274", VA = "0x13CE274", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600403F")]
	[Cpp2IlInjected.Address(RVA = "0x13CE280", Offset = "0x13CE280", VA = "0x13CE280", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004040")]
	[Cpp2IlInjected.Address(RVA = "0x13CE28C", Offset = "0x13CE28C", VA = "0x13CE28C", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004041")]
	[Cpp2IlInjected.Address(RVA = "0x13CE2C0", Offset = "0x13CE2C0", VA = "0x13CE2C0")]
	public VortexSky()
	{
	}
}
