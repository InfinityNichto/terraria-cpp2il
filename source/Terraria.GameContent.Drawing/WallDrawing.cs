using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;

namespace Terraria.GameContent.Drawing;

[Cpp2IlInjected.Token(Token = "0x200066D")]
public class WallDrawing
{
	[Cpp2IlInjected.Token(Token = "0x2000A57")]
	public class WallDrawInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E28")]
		public SpriteBatch wallSpriteBatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E29")]
		public SpriteBatch wallSpriteBatch2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E2A")]
		public TileBatch wallTileBatch;

		[Cpp2IlInjected.Token(Token = "0x60050E0")]
		[Cpp2IlInjected.Address(RVA = "0xF4C604", Offset = "0xF4C604", VA = "0xF4C604")]
		public WallDrawInfo()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006D70")]
	private TileData _tileArray;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006D71")]
	private TilePaintSystemV2 _paintSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006D72")]
	private VertexColors _glowPaintColors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006D73")]
	private Rectangle outlineLeftRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006D74")]
	private Rectangle outlineRightRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006D75")]
	private Rectangle outlineUpRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4006D76")]
	private Rectangle outlineDownRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4006D77")]
	private bool _shouldShowInvisibleWalls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006D78")]
	private EffectPass[] WallEffects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4006D79")]
	private ThreadedRenderManager _threadManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4006D7A")]
	public ThreadLocal<WallDrawInfo> _currentWallDrawInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4006D7B")]
	private int drawThreadTest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4006D7C")]
	private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

	[Cpp2IlInjected.Token(Token = "0x1700078E")]
	private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
	{
		[Cpp2IlInjected.Token(Token = "0x6004109")]
		[Cpp2IlInjected.Address(RVA = "0xF4C158", Offset = "0xF4C158", VA = "0xF4C158")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004103")]
	[Cpp2IlInjected.Address(RVA = "0xF49498", Offset = "0xF49498", VA = "0xF49498")]
	public WallDrawing(TilePaintSystemV2 paintSystem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004104")]
	[Cpp2IlInjected.Address(RVA = "0xF49758", Offset = "0xF49758", VA = "0xF49758")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004105")]
	[Cpp2IlInjected.Address(RVA = "0xF49804", Offset = "0xF49804", VA = "0xF49804")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3966EC", Offset = "0x3966EC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3966EC", Offset = "0x3966EC")]
	public void DrawWalls(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004106")]
	[Cpp2IlInjected.Address(RVA = "0xF4AF60", Offset = "0xF4AF60", VA = "0xF4AF60")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3967A0", Offset = "0x3967A0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3967A0", Offset = "0x3967A0")]
	public void DrawWalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004107")]
	[Cpp2IlInjected.Address(RVA = "0xF4B42C", Offset = "0xF4B42C", VA = "0xF4B42C")]
	private int DrawWallsThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004108")]
	[Cpp2IlInjected.Address(RVA = "0xF4C0F4", Offset = "0xF4C0F4", VA = "0xF4C0F4")]
	private void ProcessBatchFinished(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600410A")]
	[Cpp2IlInjected.Address(RVA = "0xF4BC24", Offset = "0xF4BC24", VA = "0xF4BC24")]
	private void WaitDrawThreads(int numThreads)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600410B")]
	[Cpp2IlInjected.Address(RVA = "0xF4AEB4", Offset = "0xF4AEB4", VA = "0xF4AEB4")]
	private void GetWallDrawTexture(ushort wallType, byte wallColor, out Texture2D drawTexture, out EffectPass pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600410C")]
	[Cpp2IlInjected.Address(RVA = "0xF4C1E8", Offset = "0xF4C1E8", VA = "0xF4C1E8")]
	protected bool FullTile(Tile tileCache, int x, int y)
	{
		return default(bool);
	}
}
