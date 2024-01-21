using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000660")]
public class MartianSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A49")]
	private abstract class IUfoController
	{
		[Cpp2IlInjected.Token(Token = "0x60050BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InitializeUfo(ref Ufo ufo);

		[Cpp2IlInjected.Token(Token = "0x60050BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Update(ref Ufo ufo);

		[Cpp2IlInjected.Token(Token = "0x60050BF")]
		[Cpp2IlInjected.Address(RVA = "0x13C5148", Offset = "0x13C5148", VA = "0x13C5148")]
		protected IUfoController()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A4A")]
	private class ZipBehavior : IUfoController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DDC")]
		private Vector2 _speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008DDD")]
		private int _ticks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008DDE")]
		private int _maxTicks;

		[Cpp2IlInjected.Token(Token = "0x60050C0")]
		[Cpp2IlInjected.Address(RVA = "0x13C5230", Offset = "0x13C5230", VA = "0x13C5230", Slot = "4")]
		public override void InitializeUfo(ref Ufo ufo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050C1")]
		[Cpp2IlInjected.Address(RVA = "0x13C54C4", Offset = "0x13C54C4", VA = "0x13C54C4", Slot = "5")]
		public override bool Update(ref Ufo ufo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60050C2")]
		[Cpp2IlInjected.Address(RVA = "0x13C51B0", Offset = "0x13C51B0", VA = "0x13C51B0")]
		public ZipBehavior()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A4B")]
	private class HoverBehavior : IUfoController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DDF")]
		private int _ticks;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008DE0")]
		private int _maxTicks;

		[Cpp2IlInjected.Token(Token = "0x60050C3")]
		[Cpp2IlInjected.Address(RVA = "0x13C4F98", Offset = "0x13C4F98", VA = "0x13C4F98", Slot = "4")]
		public override void InitializeUfo(ref Ufo ufo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050C4")]
		[Cpp2IlInjected.Address(RVA = "0x13C50E0", Offset = "0x13C50E0", VA = "0x13C50E0", Slot = "5")]
		public override bool Update(ref Ufo ufo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60050C5")]
		[Cpp2IlInjected.Address(RVA = "0x13C5140", Offset = "0x13C5140", VA = "0x13C5140")]
		public HoverBehavior()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A4C")]
	private struct Ufo
	{
		[Cpp2IlInjected.Token(Token = "0x4008DE1")]
		private const int MAX_FRAMES = 3;

		[Cpp2IlInjected.Token(Token = "0x4008DE2")]
		private const int FRAME_RATE = 4;

		[Cpp2IlInjected.Token(Token = "0x4008DE3")]
		public static UnifiedRandom Random;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008DE4")]
		private int _frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008DE5")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DE6")]
		private IUfoController _controller;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008DE7")]
		public Texture2D GlowTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008DE8")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008DE9")]
		public int FrameHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008DEA")]
		public int FrameWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008DEB")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008DEC")]
		public float Scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008DED")]
		public float Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008DEE")]
		public bool IsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008DEF")]
		public float Rotation;

		[Cpp2IlInjected.Token(Token = "0x170008E4")]
		public int Frame
		{
			[Cpp2IlInjected.Token(Token = "0x60050C6")]
			[Cpp2IlInjected.Address(RVA = "0x39EC44", Offset = "0x39EC44", VA = "0x39EC44")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60050C7")]
			[Cpp2IlInjected.Address(RVA = "0x39EC4C", Offset = "0x39EC4C", VA = "0x39EC4C")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E5")]
		public Texture2D Texture
		{
			[Cpp2IlInjected.Token(Token = "0x60050C8")]
			[Cpp2IlInjected.Address(RVA = "0x39EC70", Offset = "0x39EC70", VA = "0x39EC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60050C9")]
			[Cpp2IlInjected.Address(RVA = "0x39EC78", Offset = "0x39EC78", VA = "0x39EC78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E6")]
		public IUfoController Controller
		{
			[Cpp2IlInjected.Token(Token = "0x60050CA")]
			[Cpp2IlInjected.Address(RVA = "0x39ECA0", Offset = "0x39ECA0", VA = "0x39ECA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60050CB")]
			[Cpp2IlInjected.Address(RVA = "0x39ECA8", Offset = "0x39ECA8", VA = "0x39ECA8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050CC")]
		[Cpp2IlInjected.Address(RVA = "0x39ECC8", Offset = "0x39ECC8", VA = "0x39ECC8")]
		public Ufo(Texture2D texture, float depth = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050CD")]
		[Cpp2IlInjected.Address(RVA = "0x39ECD0", Offset = "0x39ECD0", VA = "0x39ECD0")]
		public Rectangle GetSourceRectangle()
		{
			return default(Rectangle);
		}

		[Cpp2IlInjected.Token(Token = "0x60050CE")]
		[Cpp2IlInjected.Address(RVA = "0x39ED1C", Offset = "0x39ED1C", VA = "0x39ED1C")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60050CF")]
		[Cpp2IlInjected.Address(RVA = "0x39ED38", Offset = "0x39ED38", VA = "0x39ED38")]
		public void AssignNewBehavior()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CE2")]
	private Ufo[] _ufos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CE3")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CE4")]
	private int _maxUfos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CE5")]
	private bool _active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4006CE6")]
	private bool _leaving;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CE7")]
	private int _activeUfos;

	[Cpp2IlInjected.Token(Token = "0x6003FF2")]
	[Cpp2IlInjected.Address(RVA = "0x13C3A74", Offset = "0x13C3A74", VA = "0x13C3A74", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF3")]
	[Cpp2IlInjected.Address(RVA = "0x13C3DFC", Offset = "0x13C3DFC", VA = "0x13C3DFC", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF4")]
	[Cpp2IlInjected.Address(RVA = "0x13C4780", Offset = "0x13C4780", VA = "0x13C4780")]
	private void GenerateUfos()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF5")]
	[Cpp2IlInjected.Address(RVA = "0x13C4CD8", Offset = "0x13C4CD8", VA = "0x13C4CD8", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF6")]
	[Cpp2IlInjected.Address(RVA = "0x13C4E0C", Offset = "0x13C4E0C", VA = "0x13C4E0C", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF7")]
	[Cpp2IlInjected.Address(RVA = "0x13C4E18", Offset = "0x13C4E18", VA = "0x13C4E18", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF8")]
	[Cpp2IlInjected.Address(RVA = "0x13C4E20", Offset = "0x13C4E20", VA = "0x13C4E20", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FF9")]
	[Cpp2IlInjected.Address(RVA = "0x13C4E2C", Offset = "0x13C4E2C", VA = "0x13C4E2C")]
	public MartianSky()
	{
	}
}
