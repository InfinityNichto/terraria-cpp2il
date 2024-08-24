using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.Tile_Entities;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.ID;
using Terraria.ObjectData;
using Terraria.UI;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000669 RID: 1641
	[global::Cpp2ILInjected.Token(Token = "0x20009E8")]
	public class TileDrawing
	{
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x0002D7D0 File Offset: 0x0002B9D0
		// (set) Token: 0x06004052 RID: 16466 RVA: 0x0002D7D3 File Offset: 0x0002B9D3
		[global::Cpp2ILInjected.Token(Token = "0x17000858")]
		private int[] _specialsCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004ACE")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BC28", Offset = "0x86BC28", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "AddSpecialPoint", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(TileDrawing.TileCounterType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PreDrawTiles", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMasterTrophies", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTeleportationPylons", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVoidLenses", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawReverseVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004ACF")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BC74", Offset = "0x86BC74", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x0002D7D6 File Offset: 0x0002B9D6
		// (set) Token: 0x06004054 RID: 16468 RVA: 0x0002D7D9 File Offset: 0x0002B9D9
		[global::Cpp2ILInjected.Token(Token = "0x17000859")]
		private Point[][] _specialPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BCC4", Offset = "0x86BCC4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "AddSpecialPoint", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(TileDrawing.TileCounterType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = ".ctor", MemberParameters = new object[] { typeof(TilePaintSystemV2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMasterTrophies", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTeleportationPylons", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVoidLenses", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawReverseVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004AD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BD10", Offset = "0x86BD10", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0002D7DC File Offset: 0x0002B9DC
		[global::Cpp2ILInjected.Token(Token = "0x6004AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x86BD60", Offset = "0x86BD60", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CrawlToTopOfVineAndAddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CrawlToBottomOfReverseVineAndAddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void AddSpecialPoint(int x, int y, TileDrawing.TileCounterType type)
		{
			throw null;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x0002D7DF File Offset: 0x0002B9DF
		[global::Cpp2ILInjected.Token(Token = "0x1700085A")]
		private Dictionary<Point, int> _displayDollTileEntityPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BDD4", Offset = "0x86BDD4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearCachedTileDraws", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawEntities_DisplayDolls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x0002D7E2 File Offset: 0x0002B9E2
		[global::Cpp2ILInjected.Token(Token = "0x1700085B")]
		private Dictionary<Point, int> _hatRackTileEntityPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BE6C", Offset = "0x86BE6C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearCachedTileDraws", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawEntities_HatRacks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x0002D7E5 File Offset: 0x0002B9E5
		[global::Cpp2ILInjected.Token(Token = "0x1700085C")]
		private Dictionary<Point, int> _trainingDummyTileEntityPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BEB8", Offset = "0x86BEB8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearLegacyCachedDraws", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x0002D7E8 File Offset: 0x0002B9E8
		[global::Cpp2ILInjected.Token(Token = "0x1700085D")]
		private Dictionary<Point, int> _itemFrameTileEntityPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BF04", Offset = "0x86BF04", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearLegacyCachedDraws", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600405A RID: 16474 RVA: 0x0002D7EB File Offset: 0x0002B9EB
		[global::Cpp2ILInjected.Token(Token = "0x1700085E")]
		private Dictionary<Point, int> _foodPlatterTileEntityPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BF50", Offset = "0x86BF50", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearLegacyCachedDraws", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x0002D7EE File Offset: 0x0002B9EE
		[global::Cpp2ILInjected.Token(Token = "0x1700085F")]
		private Dictionary<Point, int> _weaponRackTileEntityPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BF9C", Offset = "0x86BF9C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearLegacyCachedDraws", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x0002D7F1 File Offset: 0x0002B9F1
		[global::Cpp2ILInjected.Token(Token = "0x17000860")]
		private Dictionary<Point, int> _chestPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BFE8", Offset = "0x86BFE8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ClearLegacyCachedDraws", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600405D RID: 16477 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		[global::Cpp2ILInjected.Token(Token = "0x17000861")]
		private UnifiedRandom _rand
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004ADA")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C034", Offset = "0x86C034", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitLivingTreeLeaf", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitLiquidDrops", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(byte),
				typeof(ushort)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitTreeLeaves", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnimatedTile_AdjustForVisionChangers", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(short),
				typeof(ushort),
				typeof(short),
				typeof(short),
				typeof(ref Color),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTeleportationPylons", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitAlchemyHerbParticles", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 106)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x0002D7F7 File Offset: 0x0002B9F7
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x0002D7FA File Offset: 0x0002B9FA
		[global::Cpp2ILInjected.Token(Token = "0x17000862")]
		private WindGrid _windGrid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004ADB")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C080", Offset = "0x86C080", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EnsureWindGridSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetWindGridPush", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetWindGridPush2Axis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(ref float),
				typeof(ref float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetWindGridPushComplex", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetHighestWindGridPushComplex", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004ADC")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C0CC", Offset = "0x86C0CC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x0002D7FD File Offset: 0x0002B9FD
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x0002D800 File Offset: 0x0002BA00
		[global::Cpp2ILInjected.Token(Token = "0x17000863")]
		private bool _shouldShowInvisibleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004ADD")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C11C", Offset = "0x86C11C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(TileDrawInfo),
				typeof(ushort),
				typeof(ref short),
				typeof(ref short),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref SpriteEffects),
				typeof(ref Texture2D),
				typeof(ref Rectangle),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(ushort),
				typeof(ref short),
				typeof(ref short),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref SpriteEffects),
				typeof(ref Texture2D),
				typeof(ref Rectangle),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Tile),
				typeof(ushort),
				typeof(ref short),
				typeof(ref short),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref SpriteEffects),
				typeof(ref Texture2D),
				typeof(ref Rectangle),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ushort),
				typeof(short),
				typeof(short),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004ADE")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C168", Offset = "0x86C168", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x0002D803 File Offset: 0x0002BA03
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x0002D806 File Offset: 0x0002BA06
		[global::Cpp2ILInjected.Token(Token = "0x17000864")]
		private bool _shouldShowInvisibleBlocks_LastFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004ADF")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C1B8", Offset = "0x86C1B8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004AE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C204", Offset = "0x86C204", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x0002D809 File Offset: 0x0002BA09
		[global::Cpp2ILInjected.Token(Token = "0x17000865")]
		private bool[] _tileSolid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C254", Offset = "0x86C254", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06004065 RID: 16485 RVA: 0x0002D80C File Offset: 0x0002BA0C
		[global::Cpp2ILInjected.Token(Token = "0x17000866")]
		private bool[] _tileSolidTop
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C2AC", Offset = "0x86C2AC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x0002D80F File Offset: 0x0002BA0F
		[global::Cpp2ILInjected.Token(Token = "0x17000867")]
		private Dust[] _dust
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C304", Offset = "0x86C304", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x0002D812 File Offset: 0x0002BA12
		[global::Cpp2ILInjected.Token(Token = "0x17000868")]
		private Gore[] _gore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x86C35C", Offset = "0x86C35C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0002D815 File Offset: 0x0002BA15
		[global::Cpp2ILInjected.Token(Token = "0x6004AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x86C3B4", Offset = "0x86C3B4", Length = "0x67C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DrawData>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public TileDrawing(TilePaintSystemV2 paintSystem)
		{
			throw null;
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0002D818 File Offset: 0x0002BA18
		[global::Cpp2ILInjected.Token(Token = "0x6004AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x86CA30", Offset = "0x86CA30", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_ScaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "PrepareForAreaDrawing", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void PreparePaintForTilesOnScreen()
		{
			throw null;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0002D81B File Offset: 0x0002BA1B
		[global::Cpp2ILInjected.Token(Token = "0x6004AE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x86CF98", Offset = "0x86CF98", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PreparePaintForTilesOnScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "WallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void PrepareForAreaDrawing(int firstTileX, int lastTileX, int firstTileY, int lastTileY, bool prepareLazily)
		{
			throw null;
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0002D81E File Offset: 0x0002BA1E
		[global::Cpp2ILInjected.Token(Token = "0x6004AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x86D170", Offset = "0x86D170", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "UpdateLeafFrequency", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EnsureWindGridSize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__windGrid", ReturnType = typeof(WindGrid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ShouldShowInvisibleWalls", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "set__shouldShowInvisibleBlocks", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks_LastFrame", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "set__shouldShowInvisibleBlocks_LastFrame", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_sectionManager", ReturnType = typeof(WorldSections))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSections), Member = "SetAllFramedSectionsAsNeedingRefresh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "UnloadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x0002D821 File Offset: 0x0002BA21
		[global::Cpp2ILInjected.Token(Token = "0x6004AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x86D81C", Offset = "0x86D81C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_Solid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_UpdateEveryFrame", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void PreDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
		{
			throw null;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x0002D824 File Offset: 0x0002BA24
		[global::Cpp2ILInjected.Token(Token = "0x6004AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x86D8E4", Offset = "0x86D8E4", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTileEntities", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_Solid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DefaultSamplerState", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawMultiTileVines", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawMultiTileGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawVoidLenses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTeleportationPylons", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawMasterTrophies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawVines", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawReverseVines", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawEntities_HatRacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawEntities_DisplayDolls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void PostDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
		{
			throw null;
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x0002D827 File Offset: 0x0002BA27
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x0002D82A File Offset: 0x0002BA2A
		[global::Cpp2ILInjected.Token(Token = "0x17000869")]
		public ThreadLocal<TileDrawInfo> _currentTileDrawInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x86BE20", Offset = "0x86BE20", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__displayDollTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__hatRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__trainingDummyTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__itemFrameTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__foodPlatterTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__weaponRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__chestPositions", ReturnType = typeof(Dictionary<Point, int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawLiquidBehindTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004AEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x87292C", Offset = "0x87292C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x0002D82D File Offset: 0x0002BA2D
		[global::Cpp2ILInjected.Token(Token = "0x6004AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x87297C", Offset = "0x87297C", Length = "0x484")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "GetTilePartition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(TileDrawing),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private int DrawTilesThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			throw null;
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x0002D830 File Offset: 0x0002BA30
		[global::Cpp2ILInjected.Token(Token = "0x6004AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x87AE8C", Offset = "0x87AE8C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		private void ProcessBatchFinished(int index)
		{
			throw null;
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x0002D833 File Offset: 0x0002BA33
		[global::Cpp2ILInjected.Token(Token = "0x1700086A")]
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004AEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x87AED4", Offset = "0x87AED4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.BatchProcessCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x0002D836 File Offset: 0x0002BA36
		[global::Cpp2ILInjected.Token(Token = "0x6004AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x87AF54", Offset = "0x87AF54", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void MergeDictionary(Dictionary<Point, int> dest, Dictionary<Point, int> src)
		{
			throw null;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x0002D839 File Offset: 0x0002BA39
		[global::Cpp2ILInjected.Token(Token = "0x6004AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x87B0CC", Offset = "0x87B0CC", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get_ProcessBatchFinishedCallback", ReturnType = typeof(ThreadedRenderManager.BatchProcessCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "WaitAndProcess", MemberParameters = new object[]
		{
			typeof(ThreadedRenderManager.BatchProcessCallback),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__displayDollTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "MergeDictionary", MemberParameters = new object[]
		{
			typeof(Dictionary<Point, int>),
			typeof(Dictionary<Point, int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__hatRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__trainingDummyTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__itemFrameTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__foodPlatterTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__weaponRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__chestPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void WaitDrawThreads(int numThreads)
		{
			throw null;
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x0002D83C File Offset: 0x0002BA3C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x872E00", Offset = "0x872E00", Length = "0x808C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTilesThreaded", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SettingsEnabled_TilesSwayInWind", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_NotRetro", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTile_LiquidBehindTile", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__itemFrameTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__hatRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEHatRack), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "CrawlToTopOfVineAndAddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__weaponRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEWeaponsRack), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__displayDollTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEDisplayDoll), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "CrawlToBottomOfReverseVineAndAddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "AddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawing.TileCounterType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EmitLiquidDrops", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__foodPlatterTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEFoodPlatter), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsTileDangerous", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(short),
			typeof(ushort),
			typeof(short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "IsTileSpelunkable", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "IsTileBiomeSightable", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__chestPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "FindChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__trainingDummyTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileOutlineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(ref Color),
			typeof(ref Texture2D),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "shine", MemberParameters = new object[]
		{
			typeof(ref Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetCactusType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToDirectionInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsRope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawXmasTree", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "bottomSlope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Modified", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawSingleTile_Flames", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "shine", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "GetPortalColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "blockType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 233)]
		public void DrawTiles(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			throw null;
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x0002D83F File Offset: 0x0002BA3F
		[global::Cpp2ILInjected.Token(Token = "0x6004AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x88F264", Offset = "0x88F264", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawLiquid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTile_LiquidBehindTile", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void DrawLiquidBehindTiles(int waterStyleOverride = -1)
		{
			throw null;
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x0002D842 File Offset: 0x0002BA42
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x88F688", Offset = "0x88F688", Length = "0x750")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_Solid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EnsureWindGridSize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "ClearLegacyCachedDraws", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "ClearCachedTileDraws", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gfxQuality", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_ScaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTilesThreaded", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawTileCracks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(HitTile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawSpecialTilesLegacy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObject), Member = "get_objectPreview", ReturnType = typeof(TileObjectPreviewData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_placementPreview", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureManager), Member = "get_Active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(TileObjectPreviewData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "DrawTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void Draw(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			throw null;
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x0002D845 File Offset: 0x0002BA45
		[global::Cpp2ILInjected.Token(Token = "0x6004AF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x87C998", Offset = "0x87C998", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "AddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawing.TileCounterType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CrawlToTopOfVineAndAddSpecialPoint(int j, int i)
		{
			throw null;
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x0002D848 File Offset: 0x0002BA48
		[global::Cpp2ILInjected.Token(Token = "0x6004AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x87CABC", Offset = "0x87CABC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "AddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawing.TileCounterType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CrawlToBottomOfReverseVineAndAddSpecialPoint(int j, int i)
		{
			throw null;
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x0002D84B File Offset: 0x0002BA4B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x891D90", Offset = "0x891D90", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int worldWidth, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0002D84E File Offset: 0x0002BA4E
		[global::Cpp2ILInjected.Token(Token = "0x6004AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x881234", Offset = "0x881234", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawRisingVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		private bool IsVisible(Tile tile)
		{
			throw null;
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0002D851 File Offset: 0x0002BA51
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x885BDC", Offset = "0x885BDC", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int tileX, int tileY, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0002D854 File Offset: 0x0002BA54
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8921A0", Offset = "0x8921A0", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HitTile), Member = "DrawFreshAnimations", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Texture2D GetTileDrawTexture(int tileX, int tileY, ushort tileType, short frameX, short frameY, byte tileColor, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x0002D857 File Offset: 0x0002BA57
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x887328", Offset = "0x887328", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawRisingVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0002D85A File Offset: 0x0002BA5A
		[global::Cpp2ILInjected.Token(Token = "0x6004AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x89234C", Offset = "0x89234C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, int paintOverride, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0002D85D File Offset: 0x0002BA5D
		[global::Cpp2ILInjected.Token(Token = "0x6004AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x881478", Offset = "0x881478", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int GetPalmTreeBiome(TileDrawInfo drawInfo, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0002D860 File Offset: 0x0002BA60
		[global::Cpp2ILInjected.Token(Token = "0x6004AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8920B4", Offset = "0x8920B4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeVariant", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int GetPalmTreeBiome(int tileX, int tileY)
		{
			throw null;
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0002D863 File Offset: 0x0002BA63
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8812BC", Offset = "0x8812BC", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetTreeBiome(TileDrawInfo drawInfo, int worldWidth)
		{
			throw null;
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0002D866 File Offset: 0x0002BA66
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x891EEC", Offset = "0x891EEC", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeVariant", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static int GetTreeBiome(int tileX, int tileY, int tileFrameX, int tileFrameY)
		{
			throw null;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0002D869 File Offset: 0x0002BA69
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x8927F8", Offset = "0x8927F8", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int GetTreeVariant(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x0002D86C File Offset: 0x0002BA6C
		[global::Cpp2ILInjected.Token(Token = "0x6004B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x8929B4", Offset = "0x8929B4", Length = "0xA28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSingleTile_Flames", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private TileDrawing.TileFlameData GetTileFlameData(int tileX, int tileY, int type, int tileFrameY)
		{
			throw null;
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x0002D86F File Offset: 0x0002BA6F
		[global::Cpp2ILInjected.Token(Token = "0x6004B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x887518", Offset = "0x887518", Length = "0x7D4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GraveyardVisualIntensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileFlameData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileDrawing.TileFlameData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomInt", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 246)]
		private void DrawSingleTile_Flames(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			throw null;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x0002D872 File Offset: 0x0002BA72
		[global::Cpp2ILInjected.Token(Token = "0x6004B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x892534", Offset = "0x892534", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsPalmOasisTree", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private int GetPalmTreeVariant(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x0002D875 File Offset: 0x0002BA75
		[global::Cpp2ILInjected.Token(Token = "0x6004B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x886A34", Offset = "0x886A34", Length = "0x8F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void DrawXmasTree(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			throw null;
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x0002D878 File Offset: 0x0002BA78
		[global::Cpp2ILInjected.Token(Token = "0x6004B06")]
		[global::Cpp2ILInjected.Address(RVA = "0x885D7C", Offset = "0x885D7C", Length = "0xCB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetFinalLight", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "TrackColors", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsRope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "frameNumber", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "GetSourceRect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "DrawLeftDecoration", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "DrawRightDecoration", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "DrawBumper", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "DrawBouncyBumper", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private void DrawTile_MinecartTrack(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			throw null;
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0002D87B File Offset: 0x0002BA7B
		[global::Cpp2ILInjected.Token(Token = "0x6004B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x87B478", Offset = "0x87B478", Length = "0x1520")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawLiquidBehindTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterfallManager", ReturnType = typeof(WaterfallManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = "CheckForWaterfall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterStyle", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_numActiveLiquidAlpha", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_activeLiquidAlpha", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_liquidAlpha", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawPartialLiquid", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(bool),
			typeof(TileDrawInfo),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(int),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private void DrawTile_LiquidBehindTile(bool solidLayer, bool inFrontOfPlayers, int waterStyleOverride, Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			throw null;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x0002D87E File Offset: 0x0002BA7E
		[global::Cpp2ILInjected.Token(Token = "0x6004B08")]
		[global::Cpp2ILInjected.Address(RVA = "0x89368C", Offset = "0x89368C", Length = "0x5F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "AddSpecialPoint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawing.TileCounterType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__weaponRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEWeaponsRack), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__hatRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEHatRack), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__foodPlatterTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEFoodPlatter), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__itemFrameTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__displayDollTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEDisplayDoll), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CacheSpecialDraws(int tileX, int tileY, ushort typeCache, short tileFrameX, short tileFrameY)
		{
			throw null;
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x0002D881 File Offset: 0x0002BA81
		[global::Cpp2ILInjected.Token(Token = "0x6004B09")]
		[global::Cpp2ILInjected.Address(RVA = "0x8933DC", Offset = "0x8933DC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "ShouldTileShine", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "shine", MemberParameters = new object[]
		{
			typeof(ref Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Color GetFinalLight(TileDrawInfo tileDrawInfo, ushort typeCache, Color tileLight)
		{
			throw null;
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0002D884 File Offset: 0x0002BA84
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x893C7C", Offset = "0x893C7C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetFinalLight", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool ShouldTileShine(ushort type, short frameX)
		{
			throw null;
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0002D887 File Offset: 0x0002BA87
		[global::Cpp2ILInjected.Token(Token = "0x6004B0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x87D2E8", Offset = "0x87D2E8", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnimatedTile_AdjustForVisionChangers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool IsTileDangerous(Player localPlayer, short sTileHeader, ushort typeCache, short tileFrameX)
		{
			throw null;
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x0002D88A File Offset: 0x0002BA8A
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x893D90", Offset = "0x893D90", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsTileDrawLayerSolid(ushort typeCache)
		{
			throw null;
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0002D88D File Offset: 0x0002BA8D
		[global::Cpp2ILInjected.Token(Token = "0x6004B0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x885A8C", Offset = "0x885A8C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "InSmartCursorHighlightArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Colors), Member = "GetSelectionGlowColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void GetTileOutlineInfo(int x, int y, ushort typeCache, ref Color tileLight, ref Texture2D highlightTexture, ref Color highlightColor)
		{
			throw null;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0002D890 File Offset: 0x0002BA90
		[global::Cpp2ILInjected.Token(Token = "0x6004B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x89350C", Offset = "0x89350C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_LiquidBehindTile", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void DrawPartialLiquid(SpriteBatch spriteBatch, bool behindBlocks, TileDrawInfo tileCache, ref Vector2 position, ref Rectangle liquidSize, int liquidType, ref VertexColors colors)
		{
			throw null;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0002D893 File Offset: 0x0002BA93
		[global::Cpp2ILInjected.Token(Token = "0x6004B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x893E38", Offset = "0x893E38", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool InAPlaceWithWind(int x, int y, int width, int height)
		{
			throw null;
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0002D896 File Offset: 0x0002BA96
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x88159C", Offset = "0x88159C", Length = "0x44F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetBigAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetSmallAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWaterAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animation), Member = "GetTemporaryFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "blockType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetBiomeInfluence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetCactusType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 179)]
		private void GetTileDrawData(int x, int y, TileDrawInfo tileCache, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
		{
			throw null;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0002D899 File Offset: 0x0002BA99
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x894148", Offset = "0x894148", Length = "0x44CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetBigAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetSmallAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWaterAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animation), Member = "GetTemporaryFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "blockType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetBiomeInfluence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetCactusType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 179)]
		private void GetTileDrawData(int x, int y, bool halfBrick, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
		{
			throw null;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x0002D89C File Offset: 0x0002BA9C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x898614", Offset = "0x898614", Length = "0x46FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawRisingVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetBigAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetSmallAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWaterAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileObjectData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animation), Member = "GetTemporaryFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "blockType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetBiomeInfluence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetCactusType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 181)]
		private void GetTileDrawData(int x, int y, Tile tileCache, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
		{
			throw null;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0002D89F File Offset: 0x0002BA9F
		[global::Cpp2ILInjected.Token(Token = "0x6004B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x89CD10", Offset = "0x89CD10", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool IsWindBlocked(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0002D8A2 File Offset: 0x0002BAA2
		[global::Cpp2ILInjected.Token(Token = "0x6004B14")]
		[global::Cpp2ILInjected.Address(RVA = "0x894070", Offset = "0x894070", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSpecialTilesLegacy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetWaterAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			throw null;
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0002D8A5 File Offset: 0x0002BAA5
		[global::Cpp2ILInjected.Token(Token = "0x6004B15")]
		[global::Cpp2ILInjected.Address(RVA = "0x893F94", Offset = "0x893F94", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetSmallAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			throw null;
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0002D8A8 File Offset: 0x0002BAA8
		[global::Cpp2ILInjected.Token(Token = "0x6004B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x893EB8", Offset = "0x893EB8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetBigAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			throw null;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0002D8AB File Offset: 0x0002BAAB
		[global::Cpp2ILInjected.Token(Token = "0x6004B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x86CC84", Offset = "0x86CC84", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PreparePaintForTilesOnScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawLiquidBehindTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EnsureWindGridSize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_sectionManager", ReturnType = typeof(WorldSections))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSections), Member = "get_AnyUnfinishedSections", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "DetailedDrawReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SectionTileFrameWithCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "DetailedDrawTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSections), Member = "get_AnyNeedRefresh", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RefreshSections", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void GetScreenDrawArea(Vector2 screenPosition, Vector2 offSet, out int firstTileX, out int lastTileX, out int firstTileY, out int lastTileY)
		{
			throw null;
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x0002D8AE File Offset: 0x0002BAAE
		[global::Cpp2ILInjected.Token(Token = "0x6004B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x88FE58", Offset = "0x88FE58", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClearCachedTileDraws", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__displayDollTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__hatRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearCachedTileDraws(bool solidLayer)
		{
			throw null;
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0002D8B1 File Offset: 0x0002BAB1
		[global::Cpp2ILInjected.Token(Token = "0x6004B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x87D258", Offset = "0x87D258", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		private void AddSpecialLegacyPoint(Point p)
		{
			throw null;
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0002D8B4 File Offset: 0x0002BAB4
		[global::Cpp2ILInjected.Token(Token = "0x6004B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x87D2A0", Offset = "0x87D2A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		private void AddSpecialLegacyPoint(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0002D8B7 File Offset: 0x0002BAB7
		[global::Cpp2ILInjected.Token(Token = "0x6004B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x88FDD8", Offset = "0x88FDD8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__chestPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__trainingDummyTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__foodPlatterTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__itemFrameTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__weaponRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ClearLegacyCachedDraws()
		{
			throw null;
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0002D8BA File Offset: 0x0002BABA
		[global::Cpp2ILInjected.Token(Token = "0x6004B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x89CE1C", Offset = "0x89CE1C", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private Color DrawTiles_GetLightOverride(int j, int i, short sTileHeader, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight, bool fullBrightBlock)
		{
			throw null;
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0002D8BD File Offset: 0x0002BABD
		[global::Cpp2ILInjected.Token(Token = "0x6004B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x87D588", Offset = "0x87D588", Length = "0x3B0C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetBHeader3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "ActiveAndWalkableTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2CircularEdge", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGorePerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Gore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EmitLivingTreeLeaf", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "RequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EmitAlchemyHerbParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 192)]
		private void DrawTiles_EmitParticles(int j, int i, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight)
		{
			throw null;
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x0002D8C0 File Offset: 0x0002BAC0
		[global::Cpp2ILInjected.Token(Token = "0x6004B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x89D060", Offset = "0x89D060", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EmitLivingTreeLeaf_Below", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EmitLivingTreeLeaf_Sideways", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void EmitLivingTreeLeaf(int i, int j, int leafGoreType)
		{
			throw null;
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x0002D8C3 File Offset: 0x0002BAC3
		[global::Cpp2ILInjected.Token(Token = "0x6004B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x89DA90", Offset = "0x89DA90", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitLivingTreeLeaf", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGorePerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Gore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void EmitLivingTreeLeaf_Below(int x, int y, int leafGoreType)
		{
			throw null;
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x0002D8C6 File Offset: 0x0002BAC6
		[global::Cpp2ILInjected.Token(Token = "0x6004B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x89DE50", Offset = "0x89DE50", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitLivingTreeLeaf", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGorePerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Gore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void EmitLivingTreeLeaf_Sideways(int x, int y, int leafGoreType)
		{
			throw null;
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x0002D8C9 File Offset: 0x0002BAC9
		[global::Cpp2ILInjected.Token(Token = "0x6004B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x87CBE0", Offset = "0x87CBE0", Length = "0x678")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterStyle", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private void EmitLiquidDrops(int j, int i, byte liquid, ushort typeCache)
		{
			throw null;
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x0002D8CC File Offset: 0x0002BACC
		[global::Cpp2ILInjected.Token(Token = "0x6004B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x89E128", Offset = "0x89E128", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawRisingVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SettingsEnabled_TilesSwayInWind", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private float GetWindCycle(int x, int y, double windCounter)
		{
			throw null;
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0002D8CF File Offset: 0x0002BACF
		[global::Cpp2ILInjected.Token(Token = "0x6004B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x89E378", Offset = "0x89E378", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SettingsEnabled_TilesSwayInWind", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool ShouldSwayInWind(int x, int y, ushort tileType, short frameX)
		{
			throw null;
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0002D8D2 File Offset: 0x0002BAD2
		[global::Cpp2ILInjected.Token(Token = "0x6004B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x86D440", Offset = "0x86D440", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void UpdateLeafFrequency()
		{
			throw null;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x0002D8D5 File Offset: 0x0002BAD5
		[global::Cpp2ILInjected.Token(Token = "0x6004B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x86D668", Offset = "0x86D668", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__windGrid", ReturnType = typeof(WindGrid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "SetSize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void EnsureWindGridSize()
		{
			throw null;
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
		[global::Cpp2ILInjected.Token(Token = "0x6004B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x89E470", Offset = "0x89E470", Length = "0x564")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetTreeLeaf", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Tile),
			typeof(Tile),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "DoesWindBlowAtThisHeight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomVector2", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGoreDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Gore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void EmitTreeLeaves(int tilePosX, int tilePosY, int grassPosX, int grassPosY)
		{
			throw null;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0002D8DB File Offset: 0x0002BADB
		[global::Cpp2ILInjected.Token(Token = "0x6004B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x88FEC4", Offset = "0x88FEC4", Length = "0x1ECC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetItemDrawFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref Texture2D),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_sunCircle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWaterAnimalCageFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Color),
			typeof(ref float),
			typeof(Item),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 85)]
		private void DrawSpecialTilesLegacy(Vector2 screenPosition, Vector2 offSet)
		{
			throw null;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0002D8DE File Offset: 0x0002BADE
		[global::Cpp2ILInjected.Token(Token = "0x6004B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x872554", Offset = "0x872554", Length = "0x3D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DefaultSamplerState", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__displayDollTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEDisplayDoll), Member = "Draw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void DrawEntities_DisplayDolls()
		{
			throw null;
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0002D8E1 File Offset: 0x0002BAE1
		[global::Cpp2ILInjected.Token(Token = "0x6004B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x872184", Offset = "0x872184", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DefaultSamplerState", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__hatRackTileEntityPositions", ReturnType = typeof(Dictionary<Point, int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEHatRack), Member = "Draw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void DrawEntities_HatRacks()
		{
			throw null;
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
		[global::Cpp2ILInjected.Token(Token = "0x6004B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x87043C", Offset = "0x87043C", Length = "0x1A98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetTreeFrame", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "EmitTreeLeaves", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "paintColor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetPalmTreeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeTopTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTreeBranchTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 77)]
		private void DrawTrees()
		{
			throw null;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0002D8E7 File Offset: 0x0002BAE7
		[global::Cpp2ILInjected.Token(Token = "0x6004B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x89E9D4", Offset = "0x89E9D4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTreeTopEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Texture2D GetTreeTopTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0002D8EA File Offset: 0x0002BAEA
		[global::Cpp2ILInjected.Token(Token = "0x6004B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x89EA88", Offset = "0x89EA88", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetTreeBranchEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Texture2D GetTreeBranchTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0002D8ED File Offset: 0x0002BAED
		[global::Cpp2ILInjected.Token(Token = "0x6004B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x86F3D4", Offset = "0x86F3D4", Length = "0x73C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawAnimatedTile_AdjustForVisionChangers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_GetLightOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindGridPush", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void DrawGrass()
		{
			throw null;
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x0002D8F0 File Offset: 0x0002BAF0
		[global::Cpp2ILInjected.Token(Token = "0x6004B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x86FB10", Offset = "0x86FB10", Length = "0x92C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawAnimatedTile_AdjustForVisionChangers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_GetLightOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsAlchemyPlantHarvestable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindGridPush2Axis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void DrawAnyDirectionalGrass()
		{
			throw null;
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x0002D8F3 File Offset: 0x0002BAF3
		[global::Cpp2ILInjected.Token(Token = "0x6004B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x89EB3C", Offset = "0x89EB3C", Length = "0x7D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsTileDangerous", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(short),
			typeof(ushort),
			typeof(short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "IsTileSpelunkable", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "IsTileBiomeSightable", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private void DrawAnimatedTile_AdjustForVisionChangers(int i, int j, short tileSHeader, ushort typeCache, short tileFrameX, short tileFrameY, ref Color tileLight, bool canDoDust)
		{
			throw null;
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x0002D8F6 File Offset: 0x0002BAF6
		[global::Cpp2ILInjected.Token(Token = "0x6004B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x89F314", Offset = "0x89F314", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawRisingVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetAverageWindGridPush", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__windGrid", ReturnType = typeof(WindGrid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "GetWindTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		private float GetWindGridPush(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame)
		{
			throw null;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x0002D8F9 File Offset: 0x0002BAF9
		[global::Cpp2ILInjected.Token(Token = "0x6004B31")]
		[global::Cpp2ILInjected.Address(RVA = "0x89F3A0", Offset = "0x89F3A0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__windGrid", ReturnType = typeof(WindGrid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "GetWindTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		private void GetWindGridPush2Axis(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame, out float pushX, out float pushY)
		{
			throw null;
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x0002D8FC File Offset: 0x0002BAFC
		[global::Cpp2ILInjected.Token(Token = "0x6004B32")]
		[global::Cpp2ILInjected.Address(RVA = "0x89F44C", Offset = "0x89F44C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetHighestWindGridPushComplex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__windGrid", ReturnType = typeof(WindGrid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "GetWindTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private float GetWindGridPushComplex(int i, int j, int pushAnimationTimeTotal, float totalPushForce, int loops, bool flipDirectionPerLoop)
		{
			throw null;
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0002D8FF File Offset: 0x0002BAFF
		[global::Cpp2ILInjected.Token(Token = "0x6004B33")]
		[global::Cpp2ILInjected.Address(RVA = "0x86ED54", Offset = "0x86ED54", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void DrawMasterTrophies()
		{
			throw null;
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x0002D902 File Offset: 0x0002BB02
		[global::Cpp2ILInjected.Token(Token = "0x6004B34")]
		[global::Cpp2ILInjected.Address(RVA = "0x86E3D4", Offset = "0x86E3D4", Length = "0x980")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "SpawnInWorldDust", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "InSmartCursorHighlightArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Colors), Member = "GetSelectionGlowColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void DrawTeleportationPylons()
		{
			throw null;
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x0002D905 File Offset: 0x0002BB05
		[global::Cpp2ILInjected.Token(Token = "0x6004B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x86E0CC", Offset = "0x86E0CC", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VoidLensHelper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VoidLensHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "InSmartCursorHighlightArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VoidLensHelper), Member = "DrawToDrawData", MemberParameters = new object[]
		{
			typeof(List<DrawData>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DrawData>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DrawData>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DrawData>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void DrawVoidLenses()
		{
			throw null;
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x0002D908 File Offset: 0x0002BB08
		[global::Cpp2ILInjected.Token(Token = "0x6004B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x86DDB8", Offset = "0x86DDB8", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "ClimbCatTail", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void DrawMultiTileGrass()
		{
			throw null;
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x0002D90B File Offset: 0x0002BB0B
		[global::Cpp2ILInjected.Token(Token = "0x6004B37")]
		[global::Cpp2ILInjected.Address(RVA = "0x89F548", Offset = "0x89F548", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int ClimbCatTail(int originx, int originy)
		{
			throw null;
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0002D90E File Offset: 0x0002BB0E
		[global::Cpp2ILInjected.Token(Token = "0x6004B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x86DB08", Offset = "0x86DB08", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DrawMultiTileVines()
		{
			throw null;
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x0002D911 File Offset: 0x0002BB11
		[global::Cpp2ILInjected.Token(Token = "0x6004B39")]
		[global::Cpp2ILInjected.Address(RVA = "0x871ED4", Offset = "0x871ED4", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void DrawVines()
		{
			throw null;
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0002D914 File Offset: 0x0002BB14
		[global::Cpp2ILInjected.Token(Token = "0x6004B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x87202C", Offset = "0x87202C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PostDrawTiles", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialsCount", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__specialPositions", ReturnType = typeof(Point[][]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawRisingVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void DrawReverseVines()
		{
			throw null;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x0002D917 File Offset: 0x0002BB17
		[global::Cpp2ILInjected.Token(Token = "0x6004B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x89F63C", Offset = "0x89F63C", Length = "0xA3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawAnimatedTile_AdjustForVisionChangers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_GetLightOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void DrawMultiTileGrassInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
		{
			throw null;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0002D91A File Offset: 0x0002BB1A
		[global::Cpp2ILInjected.Token(Token = "0x6004B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A115C", Offset = "0x8A115C", Length = "0xD48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVines", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindGridPush", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "IsTileBiomeSightable", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__shouldShowInvisibleBlocks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private void DrawVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
		{
			throw null;
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0002D91D File Offset: 0x0002BB1D
		[global::Cpp2ILInjected.Token(Token = "0x6004B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A1EA4", Offset = "0x8A1EA4", Length = "0x6F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawReverseVines", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindGridPush", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void DrawRisingVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
		{
			throw null;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0002D920 File Offset: 0x0002BB20
		[global::Cpp2ILInjected.Token(Token = "0x6004B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A259C", Offset = "0x8A259C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindGridPush", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		private float GetAverageWindGridPush(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame)
		{
			throw null;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x0002D923 File Offset: 0x0002BB23
		[global::Cpp2ILInjected.Token(Token = "0x6004B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A266C", Offset = "0x8A266C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__windGrid", ReturnType = typeof(WindGrid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "GetWindTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindGridPushComplex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(float))]
		private float GetHighestWindGridPushComplex(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame, int loops, bool swapLoopDir)
		{
			throw null;
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0002D926 File Offset: 0x0002BB26
		[global::Cpp2ILInjected.Token(Token = "0x6004B40")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A0078", Offset = "0x8A0078", Length = "0x10E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVines", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetWindCycle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetHighestWindGridPushComplex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsBelowANonHammeredPlatform", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawAnimatedTile_AdjustForVisionChangers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(ref Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_GetLightOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "GetTileFlameData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TileDrawing.TileFlameData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomInt", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private void DrawMultiTileVinesInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
		{
			throw null;
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x0002D929 File Offset: 0x0002BB29
		[global::Cpp2ILInjected.Token(Token = "0x6004B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x89D0B0", Offset = "0x89D0B0", Length = "0x9E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__rand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		private void EmitAlchemyHerbParticles(int j, int i, int style)
		{
			throw null;
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x0002D92C File Offset: 0x0002BB2C
		[global::Cpp2ILInjected.Token(Token = "0x6004B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x881094", Offset = "0x881094", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_GetLightOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private bool IsAlchemyPlantHarvestable(int style)
		{
			throw null;
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x0002D92F File Offset: 0x0002BB2F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A2760", Offset = "0x8A2760", Length = "0x115C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen.GetTreeFoliageDataMethod), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static TileDrawing()
		{
			throw null;
		}

		// Token: 0x04006D49 RID: 27977
		[global::Cpp2ILInjected.Token(Token = "0x4008552")]
		public const int MAX_SPECIALS = 9000;

		// Token: 0x04006D4A RID: 27978
		[global::Cpp2ILInjected.Token(Token = "0x4008553")]
		private const int MAX_SPECIALS_LEGACY = 1000;

		// Token: 0x04006D4B RID: 27979
		[global::Cpp2ILInjected.Token(Token = "0x4008554")]
		private const float FORCE_FOR_MIN_WIND = 0.08f;

		// Token: 0x04006D4C RID: 27980
		[global::Cpp2ILInjected.Token(Token = "0x4008555")]
		private const float FORCE_FOR_MAX_WIND = 1.2f;

		// Token: 0x04006D4D RID: 27981
		[global::Cpp2ILInjected.Token(Token = "0x4008556")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool[] cacheSpecialDrawTree;

		// Token: 0x04006D4E RID: 27982
		[global::Cpp2ILInjected.Token(Token = "0x4008557")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _leafFrequency;

		// Token: 0x04006D4F RID: 27983
		[global::Cpp2ILInjected.Token(Token = "0x4008558")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object specialLock;

		// Token: 0x04006D50 RID: 27984
		[global::Cpp2ILInjected.Token(Token = "0x4008559")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _specialTilesCount;

		// Token: 0x04006D51 RID: 27985
		[global::Cpp2ILInjected.Token(Token = "0x400855A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[] _specialTileX;

		// Token: 0x04006D52 RID: 27986
		[global::Cpp2ILInjected.Token(Token = "0x400855B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int[] _specialTileY;

		// Token: 0x04006D53 RID: 27987
		[global::Cpp2ILInjected.Token(Token = "0x400855C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object _specialLock;

		// Token: 0x04006D54 RID: 27988
		[global::Cpp2ILInjected.Token(Token = "0x400855D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private double _treeWindCounter;

		// Token: 0x04006D55 RID: 27989
		[global::Cpp2ILInjected.Token(Token = "0x400855E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private double _grassWindCounter;

		// Token: 0x04006D56 RID: 27990
		[global::Cpp2ILInjected.Token(Token = "0x400855F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private double _sunflowerWindCounter;

		// Token: 0x04006D57 RID: 27991
		[global::Cpp2ILInjected.Token(Token = "0x4008560")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private double _vineWindCounter;

		// Token: 0x04006D58 RID: 27992
		[global::Cpp2ILInjected.Token(Token = "0x4008561")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private TilePaintSystemV2 _paintSystem;

		// Token: 0x04006D59 RID: 27993
		[global::Cpp2ILInjected.Token(Token = "0x4008562")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ThreadedRenderManager _threadManager;

		// Token: 0x04006D5A RID: 27994
		[global::Cpp2ILInjected.Token(Token = "0x4008563")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Color _martianGlow;

		// Token: 0x04006D5B RID: 27995
		[global::Cpp2ILInjected.Token(Token = "0x4008564")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private Color _meteorGlow;

		// Token: 0x04006D5C RID: 27996
		[global::Cpp2ILInjected.Token(Token = "0x4008565")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Color _lavaMossGlow;

		// Token: 0x04006D5D RID: 27997
		[global::Cpp2ILInjected.Token(Token = "0x4008566")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private Color _kryptonMossGlow;

		// Token: 0x04006D5E RID: 27998
		[global::Cpp2ILInjected.Token(Token = "0x4008567")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Color _xenonMossGlow;

		// Token: 0x04006D5F RID: 27999
		[global::Cpp2ILInjected.Token(Token = "0x4008568")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private Color _argonMossGlow;

		// Token: 0x04006D60 RID: 28000
		[global::Cpp2ILInjected.Token(Token = "0x4008569")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Color _violetMossGlow;

		// Token: 0x04006D61 RID: 28001
		[global::Cpp2ILInjected.Token(Token = "0x400856A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private bool _isActiveAndNotPaused;

		// Token: 0x04006D62 RID: 28002
		[global::Cpp2ILInjected.Token(Token = "0x400856B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Player _localPlayer;

		// Token: 0x04006D63 RID: 28003
		[global::Cpp2ILInjected.Token(Token = "0x400856C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private Color _highQualityLightingRequirement;

		// Token: 0x04006D64 RID: 28004
		[global::Cpp2ILInjected.Token(Token = "0x400856D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		private Color _mediumQualityLightingRequirement;

		// Token: 0x04006D65 RID: 28005
		[global::Cpp2ILInjected.Token(Token = "0x400856E")]
		private static readonly Vector2 _zero;

		// Token: 0x04006D66 RID: 28006
		[global::Cpp2ILInjected.Token(Token = "0x400856F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x04006D67 RID: 28007
		[global::Cpp2ILInjected.Token(Token = "0x4008570")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private Vector3[] _glowPaintColorSlices;

		// Token: 0x04006D68 RID: 28008
		[global::Cpp2ILInjected.Token(Token = "0x4008571")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private VertexColors LiquidBehindTileColors;

		// Token: 0x04006D69 RID: 28009
		[global::Cpp2ILInjected.Token(Token = "0x4008572")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private VertexColors LiquidBehindTileColors2;

		// Token: 0x04006D6A RID: 28010
		[global::Cpp2ILInjected.Token(Token = "0x4008573")]
		private static WorldGen.GetTreeFoliageDataMethod GetCommonTreeFoliageDataInstance;

		// Token: 0x04006D6B RID: 28011
		[global::Cpp2ILInjected.Token(Token = "0x4008574")]
		private static WorldGen.GetTreeFoliageDataMethod GetGemTreeFoliageDataInstance;

		// Token: 0x04006D6C RID: 28012
		[global::Cpp2ILInjected.Token(Token = "0x4008575")]
		private static WorldGen.GetTreeFoliageDataMethod GetVanityTreeFoliageDataInstance;

		// Token: 0x04006D6D RID: 28013
		[global::Cpp2ILInjected.Token(Token = "0x4008576")]
		private static WorldGen.GetTreeFoliageDataMethod GetAshTreeFoliageDataInstance;

		// Token: 0x04006D6E RID: 28014
		[global::Cpp2ILInjected.Token(Token = "0x4008577")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private List<DrawData> _voidLensData;

		// Token: 0x02000A5E RID: 2654
		[global::Cpp2ILInjected.Token(Token = "0x20009E9")]
		public enum TileCounterType
		{
			// Token: 0x04008E23 RID: 36387
			[global::Cpp2ILInjected.Token(Token = "0x4008579")]
			Tree,
			// Token: 0x04008E24 RID: 36388
			[global::Cpp2ILInjected.Token(Token = "0x400857A")]
			DisplayDoll,
			// Token: 0x04008E25 RID: 36389
			[global::Cpp2ILInjected.Token(Token = "0x400857B")]
			HatRack,
			// Token: 0x04008E26 RID: 36390
			[global::Cpp2ILInjected.Token(Token = "0x400857C")]
			WindyGrass,
			// Token: 0x04008E27 RID: 36391
			[global::Cpp2ILInjected.Token(Token = "0x400857D")]
			MultiTileGrass,
			// Token: 0x04008E28 RID: 36392
			[global::Cpp2ILInjected.Token(Token = "0x400857E")]
			MultiTileVine,
			// Token: 0x04008E29 RID: 36393
			[global::Cpp2ILInjected.Token(Token = "0x400857F")]
			Vine,
			// Token: 0x04008E2A RID: 36394
			[global::Cpp2ILInjected.Token(Token = "0x4008580")]
			BiomeGrass,
			// Token: 0x04008E2B RID: 36395
			[global::Cpp2ILInjected.Token(Token = "0x4008581")]
			VoidLens,
			// Token: 0x04008E2C RID: 36396
			[global::Cpp2ILInjected.Token(Token = "0x4008582")]
			ReverseVine,
			// Token: 0x04008E2D RID: 36397
			[global::Cpp2ILInjected.Token(Token = "0x4008583")]
			TeleportationPylon,
			// Token: 0x04008E2E RID: 36398
			[global::Cpp2ILInjected.Token(Token = "0x4008584")]
			MasterTrophy,
			// Token: 0x04008E2F RID: 36399
			[global::Cpp2ILInjected.Token(Token = "0x4008585")]
			AnyDirectionalGrass,
			// Token: 0x04008E30 RID: 36400
			[global::Cpp2ILInjected.Token(Token = "0x4008586")]
			Count
		}

		// Token: 0x02000A5F RID: 2655
		[global::Cpp2ILInjected.Token(Token = "0x20009EA")]
		private struct TileFlameData
		{
			// Token: 0x04008E31 RID: 36401
			[global::Cpp2ILInjected.Token(Token = "0x4008587")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Texture2D flameTexture;

			// Token: 0x04008E32 RID: 36402
			[global::Cpp2ILInjected.Token(Token = "0x4008588")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public ulong flameSeed;

			// Token: 0x04008E33 RID: 36403
			[global::Cpp2ILInjected.Token(Token = "0x4008589")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int flameCount;

			// Token: 0x04008E34 RID: 36404
			[global::Cpp2ILInjected.Token(Token = "0x400858A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public Color flameColor;

			// Token: 0x04008E35 RID: 36405
			[global::Cpp2ILInjected.Token(Token = "0x400858B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int flameRangeXMin;

			// Token: 0x04008E36 RID: 36406
			[global::Cpp2ILInjected.Token(Token = "0x400858C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int flameRangeXMax;

			// Token: 0x04008E37 RID: 36407
			[global::Cpp2ILInjected.Token(Token = "0x400858D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int flameRangeYMin;

			// Token: 0x04008E38 RID: 36408
			[global::Cpp2ILInjected.Token(Token = "0x400858E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int flameRangeYMax;

			// Token: 0x04008E39 RID: 36409
			[global::Cpp2ILInjected.Token(Token = "0x400858F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float flameRangeMultX;

			// Token: 0x04008E3A RID: 36410
			[global::Cpp2ILInjected.Token(Token = "0x4008590")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public float flameRangeMultY;
		}
	}
}
