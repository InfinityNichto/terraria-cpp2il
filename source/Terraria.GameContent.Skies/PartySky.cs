using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x200065B")]
public class PartySky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A30")]
	private struct Balloon
	{
		[Cpp2IlInjected.Token(Token = "0x4008D98")]
		private const int MAX_FRAMES_X = 3;

		[Cpp2IlInjected.Token(Token = "0x4008D99")]
		private const int MAX_FRAMES_Y = 3;

		[Cpp2IlInjected.Token(Token = "0x4008D9A")]
		private const int FRAME_RATE = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D9B")]
		public int Variant;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008D9C")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D9D")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008D9E")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008D9F")]
		public int FrameHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008DA0")]
		public int FrameWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008DA1")]
		public float Speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008DA2")]
		public bool Active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008DA3")]
		private int _frameCounter;

		[Cpp2IlInjected.Token(Token = "0x170008DF")]
		public Texture2D Texture
		{
			[Cpp2IlInjected.Token(Token = "0x6005050")]
			[Cpp2IlInjected.Address(RVA = "0x39ED8C", Offset = "0x39ED8C", VA = "0x39ED8C")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6005051")]
			[Cpp2IlInjected.Address(RVA = "0x39ED94", Offset = "0x39ED94", VA = "0x39ED94")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E0")]
		public int Frame
		{
			[Cpp2IlInjected.Token(Token = "0x6005052")]
			[Cpp2IlInjected.Address(RVA = "0x39EDC4", Offset = "0x39EDC4", VA = "0x39EDC4")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6005053")]
			[Cpp2IlInjected.Address(RVA = "0x39EDCC", Offset = "0x39EDCC", VA = "0x39EDCC")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005054")]
		[Cpp2IlInjected.Address(RVA = "0x39EDF0", Offset = "0x39EDF0", VA = "0x39EDF0")]
		public Rectangle GetSourceRectangle()
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006CC3")]
	public static bool MultipleSkyWorkaroundFix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CC4")]
	private bool _active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4006CC5")]
	private bool _leaving;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CC6")]
	private float _opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CC7")]
	private Asset<Texture2D>[] _textures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CC8")]
	private Balloon[] _balloons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CC9")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006CCA")]
	private int _balloonsDrawing;

	[Cpp2IlInjected.Token(Token = "0x6003FC2")]
	[Cpp2IlInjected.Address(RVA = "0x13C75FC", Offset = "0x13C75FC", VA = "0x13C75FC", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC3")]
	[Cpp2IlInjected.Address(RVA = "0x13C7708", Offset = "0x13C7708", VA = "0x13C7708")]
	private void GenerateBalloons(bool onlyMissing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC4")]
	[Cpp2IlInjected.Address(RVA = "0x13C793C", Offset = "0x13C793C", VA = "0x13C793C")]
	public void ResetBalloon(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC5")]
	[Cpp2IlInjected.Address(RVA = "0x13C7AD4", Offset = "0x13C7AD4", VA = "0x13C7AD4")]
	private bool IsNearParty()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC6")]
	[Cpp2IlInjected.Address(RVA = "0x13C7BAC", Offset = "0x13C7BAC", VA = "0x13C7BAC", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC7")]
	[Cpp2IlInjected.Address(RVA = "0x13C7FD0", Offset = "0x13C7FD0", VA = "0x13C7FD0", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC8")]
	[Cpp2IlInjected.Address(RVA = "0x13C8978", Offset = "0x13C8978", VA = "0x13C8978", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC9")]
	[Cpp2IlInjected.Address(RVA = "0x13C89C0", Offset = "0x13C89C0", VA = "0x13C89C0", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FCA")]
	[Cpp2IlInjected.Address(RVA = "0x13C89CC", Offset = "0x13C89CC", VA = "0x13C89CC", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FCB")]
	[Cpp2IlInjected.Address(RVA = "0x13C89D4", Offset = "0x13C89D4", VA = "0x13C89D4", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FCC")]
	[Cpp2IlInjected.Address(RVA = "0x13C89E0", Offset = "0x13C89E0", VA = "0x13C89E0")]
	public PartySky()
	{
	}
}
