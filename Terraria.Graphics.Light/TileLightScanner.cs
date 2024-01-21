using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.Graphics.Light;

[Cpp2IlInjected.Token(Token = "0x2000516")]
public class TileLightScanner
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006846")]
	private FastRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006847")]
	private bool _drawInvisibleWalls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006848")]
	private ThreadedRenderManager _threadManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006849")]
	private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

	[Cpp2IlInjected.Token(Token = "0x17000709")]
	private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
	{
		[Cpp2IlInjected.Token(Token = "0x600386B")]
		[Cpp2IlInjected.Address(RVA = "0x1513F1C", Offset = "0x1513F1C", VA = "0x1513F1C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003869")]
	[Cpp2IlInjected.Address(RVA = "0x150DE54", Offset = "0x150DE54", VA = "0x150DE54")]
	public TileLightScanner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600386A")]
	[Cpp2IlInjected.Address(RVA = "0x1513F18", Offset = "0x1513F18", VA = "0x1513F18")]
	private void ExportBatchFinished(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600386C")]
	[Cpp2IlInjected.Address(RVA = "0x1513FAC", Offset = "0x1513FAC", VA = "0x1513FAC")]
	private void ExportToThreaded(Rectangle area, LightMap outputMap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600386D")]
	[Cpp2IlInjected.Address(RVA = "0x1510530", Offset = "0x1510530", VA = "0x1510530")]
	public void ExportTo(Rectangle area, LightMap outputMap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600386E")]
	[Cpp2IlInjected.Address(RVA = "0x1514110", Offset = "0x1514110", VA = "0x1514110")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3952B0", Offset = "0x3952B0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3952B0", Offset = "0x3952B0")]
	public void ExportTo(int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600386F")]
	[Cpp2IlInjected.Address(RVA = "0x15190CC", Offset = "0x15190CC", VA = "0x15190CC")]
	private bool IsTileNullOrTouchingNull(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003870")]
	[Cpp2IlInjected.Address(RVA = "0x1510524", Offset = "0x1510524", VA = "0x1510524")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003871")]
	[Cpp2IlInjected.Address(RVA = "0x1519220", Offset = "0x1519220", VA = "0x1519220")]
	public LightMaskMode GetMaskMode(int x, int y)
	{
		return default(LightMaskMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6003872")]
	[Cpp2IlInjected.Address(RVA = "0x15192C0", Offset = "0x15192C0", VA = "0x15192C0")]
	private LightMaskMode GetTileMask(Tile tile)
	{
		return default(LightMaskMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6003873")]
	[Cpp2IlInjected.Address(RVA = "0x1519464", Offset = "0x1519464", VA = "0x1519464")]
	public void GetTileLight(int x, int y, out Vector3 outputColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003874")]
	[Cpp2IlInjected.Address(RVA = "0x151E628", Offset = "0x151E628", VA = "0x151E628")]
	private void ApplyLiquidLight(Tile tile, ref Vector3 lightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003875")]
	[Cpp2IlInjected.Address(RVA = "0x151937C", Offset = "0x151937C", VA = "0x151937C")]
	private bool LightIsBlocked(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003876")]
	[Cpp2IlInjected.Address(RVA = "0x151A680", Offset = "0x151A680", VA = "0x151A680")]
	private void ApplyWallLight(Tile tile, int x, int y, ref FastRandom localRandom, ref Vector3 lightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003877")]
	[Cpp2IlInjected.Address(RVA = "0x151ABB8", Offset = "0x151ABB8", VA = "0x151ABB8")]
	private void ApplyTileLight(Tile tile, int x, int y, ref FastRandom localRandom, ref Vector3 lightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003878")]
	[Cpp2IlInjected.Address(RVA = "0x15196AC", Offset = "0x15196AC", VA = "0x15196AC")]
	private void ApplySurfaceLight(Tile tile, int x, int y, ref Vector3 lightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003879")]
	[Cpp2IlInjected.Address(RVA = "0x151A034", Offset = "0x151A034", VA = "0x151A034")]
	private void ApplyHellLight(Tile tile, int x, int y, ref Vector3 lightColor)
	{
	}
}
