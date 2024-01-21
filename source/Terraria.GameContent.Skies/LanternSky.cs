using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x200065F")]
public class LanternSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A48")]
	private struct Lantern
	{
		[Cpp2IlInjected.Token(Token = "0x4008DD0")]
		private const int MAX_FRAMES_X = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008DD1")]
		public int Variant;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008DD2")]
		public int TimeUntilFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DD3")]
		public int TimeUntilFloatMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008DD4")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008DD5")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008DD6")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008DD7")]
		public float Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008DD8")]
		public int FrameHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008DD9")]
		public int FrameWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008DDA")]
		public float Speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008DDB")]
		public bool Active;

		[Cpp2IlInjected.Token(Token = "0x170008E2")]
		public Texture2D Texture
		{
			[Cpp2IlInjected.Token(Token = "0x60050B9")]
			[Cpp2IlInjected.Address(RVA = "0x39EB64", Offset = "0x39EB64", VA = "0x39EB64")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60050BA")]
			[Cpp2IlInjected.Address(RVA = "0x39EB6C", Offset = "0x39EB6C", VA = "0x39EB6C")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E3")]
		public float FloatAdjustedSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60050BB")]
			[Cpp2IlInjected.Address(RVA = "0x39EB94", Offset = "0x39EB94", VA = "0x39EB94")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050BC")]
		[Cpp2IlInjected.Address(RVA = "0x39EBB8", Offset = "0x39EBB8", VA = "0x39EBB8")]
		public Rectangle GetSourceRectangle()
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CDA")]
	private bool _active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4006CDB")]
	private bool _leaving;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CDC")]
	private float _opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CDD")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CDE")]
	private Lantern[] _lanterns;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CDF")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006CE0")]
	private int _lanternsDrawing;

	[Cpp2IlInjected.Token(Token = "0x4006CE1")]
	private const float slowDown = 0.5f;

	[Cpp2IlInjected.Token(Token = "0x6003FE7")]
	[Cpp2IlInjected.Address(RVA = "0x13C2408", Offset = "0x13C2408", VA = "0x13C2408", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE8")]
	[Cpp2IlInjected.Address(RVA = "0x13C2498", Offset = "0x13C2498", VA = "0x13C2498")]
	private void GenerateLanterns(bool onlyMissing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE9")]
	[Cpp2IlInjected.Address(RVA = "0x13C26CC", Offset = "0x13C26CC", VA = "0x13C26CC")]
	public void ResetLantern(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FEA")]
	[Cpp2IlInjected.Address(RVA = "0x13C2838", Offset = "0x13C2838", VA = "0x13C2838", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FEB")]
	[Cpp2IlInjected.Address(RVA = "0x13C2C90", Offset = "0x13C2C90", VA = "0x13C2C90", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FEC")]
	[Cpp2IlInjected.Address(RVA = "0x13C33A0", Offset = "0x13C33A0", VA = "0x13C33A0")]
	private void DrawLantern(SpriteBatch spriteBatch, Lantern lantern, Color opacity, Vector2 depthScale, Vector2 position, float alpha)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FED")]
	[Cpp2IlInjected.Address(RVA = "0x13C3990", Offset = "0x13C3990", VA = "0x13C3990", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FEE")]
	[Cpp2IlInjected.Address(RVA = "0x13C39D8", Offset = "0x13C39D8", VA = "0x13C39D8", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FEF")]
	[Cpp2IlInjected.Address(RVA = "0x13C39E4", Offset = "0x13C39E4", VA = "0x13C39E4", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF0")]
	[Cpp2IlInjected.Address(RVA = "0x13C39EC", Offset = "0x13C39EC", VA = "0x13C39EC", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF1")]
	[Cpp2IlInjected.Address(RVA = "0x13C39F8", Offset = "0x13C39F8", VA = "0x13C39F8")]
	public LanternSky()
	{
	}
}
