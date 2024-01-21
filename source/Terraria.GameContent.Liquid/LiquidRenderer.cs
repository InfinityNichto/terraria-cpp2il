using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.GameContent.Liquid;

[Cpp2IlInjected.Token(Token = "0x200067A")]
public class LiquidRenderer
{
	[Cpp2IlInjected.Token(Token = "0x2000A5E")]
	private struct LiquidCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E3E")]
		public float LiquidLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008E3F")]
		public float VisibleLiquidLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E40")]
		public float Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E41")]
		public bool IsSolid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x4008E42")]
		public bool IsHalfBrick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x4008E43")]
		public bool HasLiquid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
		[Cpp2IlInjected.Token(Token = "0x4008E44")]
		public bool HasVisibleLiquid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E45")]
		public bool HasWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008E46")]
		public Point FrameOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008E47")]
		public bool HasLeftEdge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4008E48")]
		public bool HasRightEdge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4008E49")]
		public bool HasTopEdge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x4008E4A")]
		public bool HasBottomEdge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008E4B")]
		public float LeftWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008E4C")]
		public float RightWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008E4D")]
		public float BottomWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008E4E")]
		public float TopWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008E4F")]
		public float VisibleLeftWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4008E50")]
		public float VisibleRightWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4008E51")]
		public float VisibleBottomWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4008E52")]
		public float VisibleTopWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4008E53")]
		public byte Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4008E54")]
		public byte VisibleType;
	}

	[Cpp2IlInjected.Token(Token = "0x2000A5F")]
	private struct LiquidDrawCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E55")]
		public Rectangle SourceRectangle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E56")]
		public Vector2 LiquidOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008E57")]
		public bool IsVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008E58")]
		public float Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008E59")]
		public byte Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4008E5A")]
		public bool IsSurfaceLiquid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4008E5B")]
		public bool HasWall;
	}

	[Cpp2IlInjected.Token(Token = "0x2000A60")]
	private struct SpecialLiquidDrawCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E5C")]
		public int X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008E5D")]
		public int Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E5E")]
		public Rectangle SourceRectangle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008E5F")]
		public Vector2 LiquidOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008E60")]
		public bool IsVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008E61")]
		public float Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008E62")]
		public byte Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4008E63")]
		public bool IsSurfaceLiquid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4008E64")]
		public bool HasWall;
	}

	[Cpp2IlInjected.Token(Token = "0x4006D88")]
	public static LiquidRenderer Instance;

	[Cpp2IlInjected.Token(Token = "0x4006D89")]
	private const int ANIMATION_FRAME_COUNT = 16;

	[Cpp2IlInjected.Token(Token = "0x4006D8A")]
	private const int CACHE_PADDING = 2;

	[Cpp2IlInjected.Token(Token = "0x4006D8B")]
	private const int CACHE_PADDING_2 = 4;

	[Cpp2IlInjected.Token(Token = "0x4006D8C")]
	private static readonly int[] WATERFALL_LENGTH;

	[Cpp2IlInjected.Token(Token = "0x4006D8D")]
	private static readonly float[] DEFAULT_OPACITY;

	[Cpp2IlInjected.Token(Token = "0x4006D8E")]
	private static readonly byte[] WAVE_MASK_STRENGTH;

	[Cpp2IlInjected.Token(Token = "0x4006D8F")]
	private static readonly byte[] VISCOSITY_MASK;

	[Cpp2IlInjected.Token(Token = "0x4006D91")]
	public const float MIN_LIQUID_SIZE = 0.25f;

	[Cpp2IlInjected.Token(Token = "0x4006D92")]
	private static readonly Asset<Texture2D>[] _liquidTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006D93")]
	private LiquidCache[] _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006D94")]
	private LiquidDrawCache[] _drawCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006D95")]
	private SpecialLiquidDrawCache[] _drawCacheForShimmer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006D96")]
	private int _animationFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006D97")]
	private Rectangle _drawArea;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006D98")]
	private readonly UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006D99")]
	private Color[] _waveMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006D9A")]
	private float _frameState;

	[Cpp2IlInjected.Token(Token = "0x1700078F")]
	private static TileData Tiles
	{
		[Cpp2IlInjected.Token(Token = "0x600414A")]
		[Cpp2IlInjected.Address(RVA = "0x1050440", Offset = "0x1050440", VA = "0x1050440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000055")]
	public event Action<Color[], Rectangle> WaveFilters
	{
		[Cpp2IlInjected.Token(Token = "0x6004148")]
		[Cpp2IlInjected.Address(RVA = "0x10502E0", Offset = "0x10502E0", VA = "0x10502E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004149")]
		[Cpp2IlInjected.Address(RVA = "0x1050390", Offset = "0x1050390", VA = "0x1050390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600414B")]
	[Cpp2IlInjected.Address(RVA = "0x10504B8", Offset = "0x10504B8", VA = "0x10504B8")]
	public static void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600414C")]
	[Cpp2IlInjected.Address(RVA = "0x1050544", Offset = "0x1050544", VA = "0x1050544")]
	public LiquidRenderer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600414D")]
	[Cpp2IlInjected.Address(RVA = "0x1050670", Offset = "0x1050670", VA = "0x1050670")]
	public void PrepareAssets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600414E")]
	[Cpp2IlInjected.Address(RVA = "0x10508E8", Offset = "0x10508E8", VA = "0x10508E8")]
	private void InternalPrepareDraw(Rectangle drawArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600414F")]
	[Cpp2IlInjected.Address(RVA = "0x10521B8", Offset = "0x10521B8", VA = "0x10521B8")]
	public void DrawNormalLiquids(SpriteBatch spriteBatch, Vector2 drawOffset, int waterStyle, float globalAlpha, bool isBackgroundDraw)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004150")]
	[Cpp2IlInjected.Address(RVA = "0x1052F8C", Offset = "0x1052F8C", VA = "0x1052F8C")]
	public void DrawShimmer(SpriteBatch spriteBatch, Vector2 drawOffset, bool isBackgroundDraw)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004151")]
	[Cpp2IlInjected.Address(RVA = "0x10538B4", Offset = "0x10538B4", VA = "0x10538B4")]
	public static void SetShimmerVertexColors_Sparkle(ref VertexColors colors, float opacity, int x, int y, bool top)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004152")]
	[Cpp2IlInjected.Address(RVA = "0x105369C", Offset = "0x105369C", VA = "0x105369C")]
	public static void SetShimmerVertexColors(ref VertexColors colors, float opacity, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004153")]
	[Cpp2IlInjected.Address(RVA = "0x1053FF8", Offset = "0x1053FF8", VA = "0x1053FF8")]
	public static float GetShimmerWave(ref float worldPositionX, ref float worldPositionY)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004154")]
	[Cpp2IlInjected.Address(RVA = "0x1054108", Offset = "0x1054108", VA = "0x1054108")]
	public static Color GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6004155")]
	[Cpp2IlInjected.Address(RVA = "0x10539F0", Offset = "0x10539F0", VA = "0x10539F0")]
	public static void GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY, ref Color color, float opacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004156")]
	[Cpp2IlInjected.Address(RVA = "0x10542C0", Offset = "0x10542C0", VA = "0x10542C0")]
	public static float GetShimmerGlitterOpacity(bool top, float worldPositionX, float worldPositionY)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004157")]
	[Cpp2IlInjected.Address(RVA = "0x10544B8", Offset = "0x10544B8", VA = "0x10544B8")]
	private static uint SimpleWhiteNoise(uint x, uint y)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6004158")]
	[Cpp2IlInjected.Address(RVA = "0x10537B0", Offset = "0x10537B0", VA = "0x10537B0")]
	public int GetShimmerFrame(bool top, float worldPositionX, float worldPositionY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004159")]
	[Cpp2IlInjected.Address(RVA = "0x10544E4", Offset = "0x10544E4", VA = "0x10544E4")]
	public static Vector4 GetShimmerBaseColor(float worldPositionX, float worldPositionY)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600415A")]
	[Cpp2IlInjected.Address(RVA = "0x1053E70", Offset = "0x1053E70", VA = "0x1053E70")]
	public static void GetShimmerColor(float worldPositionX, float worldPositionY, ref Color baseColor, float opcacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600415B")]
	[Cpp2IlInjected.Address(RVA = "0x1054650", Offset = "0x1054650", VA = "0x1054650")]
	public bool HasFullWater(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600415C")]
	[Cpp2IlInjected.Address(RVA = "0x10546BC", Offset = "0x10546BC", VA = "0x10546BC")]
	public float GetVisibleLiquid(int x, int y)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600415D")]
	[Cpp2IlInjected.Address(RVA = "0x1054724", Offset = "0x1054724", VA = "0x1054724")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600415E")]
	[Cpp2IlInjected.Address(RVA = "0x10548A0", Offset = "0x10548A0", VA = "0x10548A0")]
	public void PrepareDraw(Rectangle drawArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600415F")]
	[Cpp2IlInjected.Address(RVA = "0x10548C0", Offset = "0x10548C0", VA = "0x10548C0")]
	public void SetWaveMaskData(ref Texture2D texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004160")]
	[Cpp2IlInjected.Address(RVA = "0x1054C14", Offset = "0x1054C14", VA = "0x1054C14")]
	public Rectangle GetCachedDrawArea()
	{
		return default(Rectangle);
	}
}
