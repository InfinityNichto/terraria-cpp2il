using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000664")]
public class SlimeSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A4F")]
	private struct Slime
	{
		[Cpp2IlInjected.Token(Token = "0x4008DF4")]
		private const int MAX_FRAMES = 4;

		[Cpp2IlInjected.Token(Token = "0x4008DF5")]
		private const int FRAME_RATE = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008DF6")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008DF7")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008DF8")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008DF9")]
		public int FrameHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008DFA")]
		public int FrameWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008DFB")]
		public float Speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008DFC")]
		public bool Active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008DFD")]
		private int _frame;

		[Cpp2IlInjected.Token(Token = "0x170008E7")]
		public Texture2D Texture
		{
			[Cpp2IlInjected.Token(Token = "0x60050D4")]
			[Cpp2IlInjected.Address(RVA = "0x39EE94", Offset = "0x39EE94", VA = "0x39EE94")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60050D5")]
			[Cpp2IlInjected.Address(RVA = "0x39EE9C", Offset = "0x39EE9C", VA = "0x39EE9C")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E8")]
		public int Frame
		{
			[Cpp2IlInjected.Token(Token = "0x60050D6")]
			[Cpp2IlInjected.Address(RVA = "0x39EEC0", Offset = "0x39EEC0", VA = "0x39EEC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60050D7")]
			[Cpp2IlInjected.Address(RVA = "0x39EEC8", Offset = "0x39EEC8", VA = "0x39EEC8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050D8")]
		[Cpp2IlInjected.Address(RVA = "0x39EEEC", Offset = "0x39EEEC", VA = "0x39EEEC")]
		public Rectangle GetSourceRectangle()
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CF9")]
	private Asset<Texture2D>[] _textures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CFA")]
	private Slime[] _slimes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CFB")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CFC")]
	private int _slimesRemaining;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CFD")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4006CFE")]
	private bool _isLeaving;

	[Cpp2IlInjected.Token(Token = "0x6004019")]
	[Cpp2IlInjected.Address(RVA = "0x13C8F58", Offset = "0x13C8F58", VA = "0x13C8F58", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600401A")]
	[Cpp2IlInjected.Address(RVA = "0x13C9148", Offset = "0x13C9148", VA = "0x13C9148")]
	private void GenerateSlimes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600401B")]
	[Cpp2IlInjected.Address(RVA = "0x13C9518", Offset = "0x13C9518", VA = "0x13C9518", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600401C")]
	[Cpp2IlInjected.Address(RVA = "0x13C999C", Offset = "0x13C999C", VA = "0x13C999C", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600401D")]
	[Cpp2IlInjected.Address(RVA = "0x13CA25C", Offset = "0x13CA25C", VA = "0x13CA25C", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600401E")]
	[Cpp2IlInjected.Address(RVA = "0x13CA278", Offset = "0x13CA278", VA = "0x13CA278", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600401F")]
	[Cpp2IlInjected.Address(RVA = "0x13CA284", Offset = "0x13CA284", VA = "0x13CA284", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004020")]
	[Cpp2IlInjected.Address(RVA = "0x13CA290", Offset = "0x13CA290", VA = "0x13CA290", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004021")]
	[Cpp2IlInjected.Address(RVA = "0x13CA298", Offset = "0x13CA298", VA = "0x13CA298")]
	public SlimeSky()
	{
	}
}
