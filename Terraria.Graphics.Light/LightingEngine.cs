using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light;

[Cpp2IlInjected.Token(Token = "0x2000515")]
public class LightingEngine : ILightingEngine
{
	[Cpp2IlInjected.Token(Token = "0x200096A")]
	private enum EngineState
	{
		[Cpp2IlInjected.Token(Token = "0x4008BC1")]
		MinimapUpdate,
		[Cpp2IlInjected.Token(Token = "0x4008BC2")]
		ExportMetrics,
		[Cpp2IlInjected.Token(Token = "0x4008BC3")]
		Scan,
		[Cpp2IlInjected.Token(Token = "0x4008BC4")]
		Blur,
		[Cpp2IlInjected.Token(Token = "0x4008BC5")]
		Blur2
	}

	[Cpp2IlInjected.Token(Token = "0x200096B")]
	private struct PerFrameLight
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008BC6")]
		public Point Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BC7")]
		public Vector3 Color;

		[Cpp2IlInjected.Token(Token = "0x6004DAE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0800", Offset = "0x3A0800", VA = "0x3A0800")]
		public PerFrameLight(Point position, Vector3 color)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006839")]
	public const int AREA_PADDING = 20;

	[Cpp2IlInjected.Token(Token = "0x400683A")]
	private const int NON_VISIBLE_PADDING = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400683B")]
	private readonly List<PerFrameLight> _perFrameLights;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400683C")]
	private TileLightScanner _tileScanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400683D")]
	private LightMap _activeLightMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400683E")]
	private Rectangle _activeProcessedArea;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400683F")]
	private LightMap _workingLightMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006840")]
	private Rectangle _workingProcessedArea;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006841")]
	private readonly Stopwatch _timer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006842")]
	private EngineState _state;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006843")]
	private ThreadedRenderManager _threadManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006844")]
	private Rectangle screenRegionScan;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4006845")]
	private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

	[Cpp2IlInjected.Token(Token = "0x17000708")]
	private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
	{
		[Cpp2IlInjected.Token(Token = "0x6003864")]
		[Cpp2IlInjected.Address(RVA = "0x1512F88", Offset = "0x1512F88", VA = "0x1512F88")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003855")]
	[Cpp2IlInjected.Address(RVA = "0x15117B8", Offset = "0x15117B8", VA = "0x15117B8")]
	public LightingEngine()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003856")]
	[Cpp2IlInjected.Address(RVA = "0x15118F0", Offset = "0x15118F0", VA = "0x15118F0", Slot = "5")]
	public void AddLight(int x, int y, Vector3 color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003857")]
	[Cpp2IlInjected.Address(RVA = "0x15119C0", Offset = "0x15119C0", VA = "0x15119C0", Slot = "8")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003858")]
	[Cpp2IlInjected.Address(RVA = "0x1511A2C", Offset = "0x1511A2C", VA = "0x1511A2C", Slot = "9")]
	public LightMap GetLightMap(out Rectangle lightMapRegion)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003859")]
	[Cpp2IlInjected.Address(RVA = "0x1511A40", Offset = "0x1511A40", VA = "0x1511A40", Slot = "7")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394FE0", Offset = "0x394FE0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394FE0", Offset = "0x394FE0")]
	public Vector3 GetColor(int x, int y)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600385A")]
	[Cpp2IlInjected.Address(RVA = "0x1511B74", Offset = "0x1511B74", VA = "0x1511B74", Slot = "6")]
	public void ProcessArea(Rectangle area)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600385B")]
	[Cpp2IlInjected.Address(RVA = "0x1511F94", Offset = "0x1511F94", VA = "0x1511F94")]
	private void SetState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600385C")]
	[Cpp2IlInjected.Address(RVA = "0x15122D8", Offset = "0x15122D8", VA = "0x15122D8")]
	private void ProcessScan(Rectangle area)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600385D")]
	[Cpp2IlInjected.Address(RVA = "0x1512374", Offset = "0x1512374", VA = "0x1512374")]
	private void ProcessBlur()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600385E")]
	[Cpp2IlInjected.Address(RVA = "0x1512398", Offset = "0x1512398", VA = "0x1512398")]
	private void ProcessBlur2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600385F")]
	[Cpp2IlInjected.Address(RVA = "0x15123BC", Offset = "0x15123BC", VA = "0x15123BC")]
	private void Present()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003860")]
	[Cpp2IlInjected.Address(RVA = "0x151246C", Offset = "0x151246C", VA = "0x151246C")]
	private void UpdateLightDecay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003861")]
	[Cpp2IlInjected.Address(RVA = "0x1512CA8", Offset = "0x1512CA8", VA = "0x1512CA8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395094", Offset = "0x395094")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395094", Offset = "0x395094")]
	private void ApplyPerFrameLights()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003862")]
	[Cpp2IlInjected.Address(RVA = "0x1512E08", Offset = "0x1512E08", VA = "0x1512E08", Slot = "4")]
	public void Rebuild()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003863")]
	[Cpp2IlInjected.Address(RVA = "0x1512F84", Offset = "0x1512F84", VA = "0x1512F84")]
	private void ExportBatchFinished(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003865")]
	[Cpp2IlInjected.Address(RVA = "0x1513018", Offset = "0x1513018", VA = "0x1513018")]
	private void ExportToMiniMapThreaded(int firstTileX, int firstTileY, int lastTileX, int lastTileY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003866")]
	[Cpp2IlInjected.Address(RVA = "0x1513F08", Offset = "0x1513F08", VA = "0x1513F08", Slot = "10")]
	public Rectangle GetScanRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003867")]
	[Cpp2IlInjected.Address(RVA = "0x1513108", Offset = "0x1513108", VA = "0x1513108")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395148", Offset = "0x395148")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395148", Offset = "0x395148")]
	public void ExportToMiniMap(int left, int top, int right, int bottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003868")]
	[Cpp2IlInjected.Address(RVA = "0x1512010", Offset = "0x1512010", VA = "0x1512010")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3951FC", Offset = "0x3951FC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3951FC", Offset = "0x3951FC")]
	private void ExportToMiniMap()
	{
	}
}
