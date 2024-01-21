using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders;

[Cpp2IlInjected.Token(Token = "0x200058F")]
public class WaterShaderData : ScreenShaderData
{
	[Cpp2IlInjected.Token(Token = "0x200099C")]
	private struct Ripple
	{
		[Cpp2IlInjected.Token(Token = "0x4008C89")]
		private static readonly Rectangle[] RIPPLE_SHAPE_SOURCE_RECTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008C8A")]
		public readonly Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C8B")]
		public readonly Color WaveData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C8C")]
		public readonly Vector2 Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008C8D")]
		public readonly RippleShape Shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008C8E")]
		public readonly float Rotation;

		[Cpp2IlInjected.Token(Token = "0x170008C1")]
		public Rectangle SourceRectangle
		{
			[Cpp2IlInjected.Token(Token = "0x6004E27")]
			[Cpp2IlInjected.Address(RVA = "0x39CCD4", Offset = "0x39CCD4", VA = "0x39CCD4")]
			get
			{
				return default(Rectangle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E28")]
		[Cpp2IlInjected.Address(RVA = "0x39CCE8", Offset = "0x39CCE8", VA = "0x39CCE8")]
		public Ripple(Vector2 position, Color waveData, Vector2 size, RippleShape shape, float rotation)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006B15")]
	public const float DISTORTION_BUFFER_SCALE = 0.25f;

	[Cpp2IlInjected.Token(Token = "0x4006B16")]
	private const float WAVE_FRAMERATE = 1f / 60f;

	[Cpp2IlInjected.Token(Token = "0x4006B17")]
	private const int MAX_RIPPLES_QUEUED = 200;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4006B19")]
	public bool _useViscosityFilter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
	[Cpp2IlInjected.Token(Token = "0x4006B1A")]
	private bool _usingRenderTargets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4006B1B")]
	private Vector2 _lastDistortionDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4006B1C")]
	private float _progress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4006B1D")]
	private Ripple[] _rippleQueue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4006B1E")]
	private int _rippleQueueCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4006B1F")]
	private int _lastScreenWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4006B20")]
	private int _lastScreenHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4006B21")]
	public bool _useProjectileWaves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4006B22")]
	private bool _useNPCWaves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4006B23")]
	private bool _usePlayerWaves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
	[Cpp2IlInjected.Token(Token = "0x4006B24")]
	private bool _useRippleWaves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4006B25")]
	private bool _useCustomWaves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
	[Cpp2IlInjected.Token(Token = "0x4006B26")]
	private bool _clearNextFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4006B27")]
	private Texture2D[] _viscosityMaskChain;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4006B28")]
	private int _activeViscosityMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4006B29")]
	private Asset<Texture2D> _rippleShapeTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4006B2A")]
	private bool _isWaveBufferDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4006B2B")]
	private int _queuedSteps;

	[Cpp2IlInjected.Token(Token = "0x4006B2C")]
	private const int MAX_QUEUED_STEPS = 1;

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event Action<TileBatch> OnWaveDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6003BE1")]
		[Cpp2IlInjected.Address(RVA = "0x11A7218", Offset = "0x11A7218", VA = "0x11A7218")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003BE2")]
		[Cpp2IlInjected.Address(RVA = "0x11A72C8", Offset = "0x11A72C8", VA = "0x11A72C8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE3")]
	[Cpp2IlInjected.Address(RVA = "0x11A7378", Offset = "0x11A7378", VA = "0x11A7378")]
	public WaterShaderData(string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE4")]
	[Cpp2IlInjected.Address(RVA = "0x11A7684", Offset = "0x11A7684", VA = "0x11A7684", Slot = "6")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE5")]
	[Cpp2IlInjected.Address(RVA = "0x11A7A68", Offset = "0x11A7A68", VA = "0x11A7A68")]
	private void StepLiquids()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE6")]
	[Cpp2IlInjected.Address(RVA = "0x11A8110", Offset = "0x11A8110", VA = "0x11A8110")]
	private void DrawWaves()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE7")]
	[Cpp2IlInjected.Address(RVA = "0x11AA21C", Offset = "0x11AA21C", VA = "0x11AA21C")]
	private void PreDraw(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE8")]
	[Cpp2IlInjected.Address(RVA = "0x11AA49C", Offset = "0x11AA49C", VA = "0x11AA49C", Slot = "5")]
	public override void Apply()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE9")]
	[Cpp2IlInjected.Address(RVA = "0x11AA374", Offset = "0x11AA374", VA = "0x11AA374")]
	private void ValidateRenderTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BEA")]
	[Cpp2IlInjected.Address(RVA = "0x11AA9A4", Offset = "0x11AA9A4", VA = "0x11AA9A4")]
	private void InitRenderTargets(int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BEB")]
	[Cpp2IlInjected.Address(RVA = "0x11AA998", Offset = "0x11AA998", VA = "0x11AA998")]
	private void ReleaseRenderTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BEC")]
	[Cpp2IlInjected.Address(RVA = "0x11AAA04", Offset = "0x11AAA04", VA = "0x11AAA04")]
	public void QueueRipple(Vector2 position, float strength = 1f, RippleShape shape = RippleShape.Square, float rotation = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BED")]
	[Cpp2IlInjected.Address(RVA = "0x11AA0D8", Offset = "0x11AA0D8", VA = "0x11AA0D8")]
	public void QueueRipple(Vector2 position, float strength, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BEE")]
	[Cpp2IlInjected.Address(RVA = "0x11AA018", Offset = "0x11AA018", VA = "0x11AA018")]
	public void QueueRipple(Vector2 position, Color waveData, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
	{
	}
}
