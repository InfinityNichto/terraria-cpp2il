using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Graphics.Light;

[Cpp2IlInjected.Token(Token = "0x200022C")]
public class ThreadedRenderManager
{
	[Cpp2IlInjected.Token(Token = "0x2000805")]
	public delegate void BatchProcessCallback(int index);

	[Cpp2IlInjected.Token(Token = "0x2000806")]
	public class RenderThreadInstance
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4C")]
		private enum DrawTask
		{
			[Cpp2IlInjected.Token(Token = "0x4008FDC")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4008FDD")]
			DrawTask_DrawTiles,
			[Cpp2IlInjected.Token(Token = "0x4008FDE")]
			DrawTask_DrawWalls,
			[Cpp2IlInjected.Token(Token = "0x4008FDF")]
			LightingNew_ExportToMiniMap,
			[Cpp2IlInjected.Token(Token = "0x4008FE0")]
			LightMap_BlurPass1,
			[Cpp2IlInjected.Token(Token = "0x4008FE1")]
			LightMap_BlurPass2,
			[Cpp2IlInjected.Token(Token = "0x4008FE2")]
			Background_RockLayer,
			[Cpp2IlInjected.Token(Token = "0x4008FE3")]
			Background_MagmaLayer,
			[Cpp2IlInjected.Token(Token = "0x4008FE4")]
			Background_CurrentLayer,
			[Cpp2IlInjected.Token(Token = "0x4008FE5")]
			TileScanner_ExportTo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D0C")]
		private DrawTask _task;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007D0D")]
		public LiquidRenderer waterRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007D0E")]
		public TileDrawing tileDrawing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007D0F")]
		public WallDrawing wallDrawing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007D10")]
		public LightingEngine lightingEngine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007D11")]
		public LightMap lightingMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007D12")]
		public TileLightScanner tileScanner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007D13")]
		public SpriteBatch spriteBatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007D14")]
		public SpriteBatch spriteBatch2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007D15")]
		public TileBatch tileBatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007D16")]
		private AutoResetEvent startEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007D17")]
		public AutoResetEvent completeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007D18")]
		public bool Active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4007D19")]
		public bool Complete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007D1A")]
		public ManagedThread ThreadHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007D1B")]
		private Vector2 _screenPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007D1C")]
		private Vector2 _offSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007D1D")]
		private int _firstTileX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007D1E")]
		private int _firstTileY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007D1F")]
		private int _lastTileX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007D20")]
		private int _lastTileY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007D21")]
		private bool _solidLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4007D22")]
		private bool _forRenderTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x4007D23")]
		private bool _intoRenderTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007D24")]
		private int _waterStyleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007D25")]
		private int _scannerTileX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4007D26")]
		private int _scannerTileY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4007D27")]
		private LocalUserGameState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4007D28")]
		private int _index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4007D29")]
		private int _diff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4007D2A")]
		public bool Running;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4007D2B")]
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4007D2C")]
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4007D2D")]
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4007D2E")]
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4007D2F")]
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4007D30")]
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4007D31")]
		public Dictionary<Point, int> _chestPositions;

		[Cpp2IlInjected.Token(Token = "0x6004946")]
		[Cpp2IlInjected.Address(RVA = "0x10CF164", Offset = "0x10CF164", VA = "0x10CF164")]
		public RenderThreadInstance(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004947")]
		[Cpp2IlInjected.Address(RVA = "0x10CF57C", Offset = "0x10CF57C", VA = "0x10CF57C")]
		public void RestartThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004948")]
		[Cpp2IlInjected.Address(RVA = "0x10CFF5C", Offset = "0x10CFF5C", VA = "0x10CFF5C")]
		public void DrawRockLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Vector2 drawOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004949")]
		[Cpp2IlInjected.Address(RVA = "0x10D0040", Offset = "0x10D0040", VA = "0x10D0040")]
		public void DrawMagmaLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Vector2 drawOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494A")]
		[Cpp2IlInjected.Address(RVA = "0x10D0124", Offset = "0x10D0124", VA = "0x10D0124")]
		public void DrawCurrentBackground(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Vector2 drawOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494B")]
		[Cpp2IlInjected.Address(RVA = "0x10D0208", Offset = "0x10D0208", VA = "0x10D0208")]
		public void DrawTiles(TileDrawing parent, Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494C")]
		[Cpp2IlInjected.Address(RVA = "0x10D0350", Offset = "0x10D0350", VA = "0x10D0350")]
		public void DrawWalls(WallDrawing parent, Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494D")]
		[Cpp2IlInjected.Address(RVA = "0x10D045C", Offset = "0x10D045C", VA = "0x10D045C")]
		public void ExportToMinimap(LightingEngine parent, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494E")]
		[Cpp2IlInjected.Address(RVA = "0x10D0530", Offset = "0x10D0530", VA = "0x10D0530")]
		public void BlurPass1(LightMap parent, int start, int end)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494F")]
		[Cpp2IlInjected.Address(RVA = "0x10D05EC", Offset = "0x10D05EC", VA = "0x10D05EC")]
		public void BlurPass2(LightMap parent, int start, int end)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004950")]
		[Cpp2IlInjected.Address(RVA = "0x10D06A8", Offset = "0x10D06A8", VA = "0x10D06A8")]
		public void ExportTo(TileLightScanner scanner, int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004951")]
		[Cpp2IlInjected.Address(RVA = "0x10D07AC", Offset = "0x10D07AC", VA = "0x10D07AC")]
		public void DrawThread()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001B2C")]
	public static int PrefferedThreadCount;

	[Cpp2IlInjected.Token(Token = "0x4001B2D")]
	private const int MaxThreadCount = 3;

	[Cpp2IlInjected.Token(Token = "0x4001B2E")]
	public static ThreadedRenderManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B2F")]
	public RenderThreadInstance[] DrawThreads;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001B30")]
	private AutoResetEvent[][] WaitHandles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001B31")]
	private int[][] WaitThreads;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001B32")]
	private Thread monitor;

	[Cpp2IlInjected.Token(Token = "0x6000F97")]
	[Cpp2IlInjected.Address(RVA = "0x10CE988", Offset = "0x10CE988", VA = "0x10CE988")]
	private static string GetStackTrace(Thread t)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000F98")]
	[Cpp2IlInjected.Address(RVA = "0x10CEEC0", Offset = "0x10CEEC0", VA = "0x10CEEC0")]
	public static void GetTilePartition(int partitionIndex, int partitionCount, int firstTileX, int firstTileY, int lastTileX, int lastTileY, out int resultFirstTileX, out int resultFirstTileY, out int resultLastTileX, out int resultLastTileY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F99")]
	[Cpp2IlInjected.Address(RVA = "0x10CEF20", Offset = "0x10CEF20", VA = "0x10CEF20")]
	public ThreadedRenderManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F9A")]
	[Cpp2IlInjected.Address(RVA = "0x10CF458", Offset = "0x10CF458", VA = "0x10CF458")]
	public void ThreadMonitor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F9B")]
	[Cpp2IlInjected.Address(RVA = "0x10CF648", Offset = "0x10CF648", VA = "0x10CF648")]
	public void WaitAndProcessInOrder(BatchProcessCallback callback, int numberOfThreads)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F9C")]
	[Cpp2IlInjected.Address(RVA = "0x10CFB48", Offset = "0x10CFB48", VA = "0x10CFB48")]
	public void WaitAndProcess(BatchProcessCallback callback, int numberOfThreads)
	{
	}
}
