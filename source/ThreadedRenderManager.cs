using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Graphics.Light;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x0200022A RID: 554
[global::Cpp2ILInjected.Token(Token = "0x20002D7")]
public class ThreadedRenderManager
{
	// Token: 0x06000F7E RID: 3966 RVA: 0x00024977 File Offset: 0x00022B77
	[global::Cpp2ILInjected.Token(Token = "0x60010B7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4D094", Offset = "0xA4D094", Length = "0x514")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Thread),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
	private static string GetStackTrace(Thread t)
	{
		throw null;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0002497A File Offset: 0x00022B7A
	[global::Cpp2ILInjected.Token(Token = "0x60010B8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4D5A8", Offset = "0xA4D5A8", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTilesThreaded", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWallsThreaded", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	public static void GetTilePartition(int partitionIndex, int partitionCount, int firstTileX, int firstTileY, int lastTileX, int lastTileY, out int resultFirstTileX, out int resultFirstTileY, out int resultLastTileX, out int resultLastTileY)
	{
		throw null;
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x0002497D File Offset: 0x00022B7D
	[global::Cpp2ILInjected.Token(Token = "0x60010B9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4D5E0", Offset = "0xA4D5E0", Length = "0x22C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public ThreadedRenderManager()
	{
		throw null;
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x00024980 File Offset: 0x00022B80
	[global::Cpp2ILInjected.Token(Token = "0x60010BA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4DB30", Offset = "0xA4DB30", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "RestartThread", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void ThreadMonitor()
	{
		throw null;
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00024983 File Offset: 0x00022B83
	[global::Cpp2ILInjected.Token(Token = "0x60010BB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4DD00", Offset = "0xA4DD00", Length = "0x230")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void WaitAndProcessInOrder(ThreadedRenderManager.BatchProcessCallback callback, int numberOfThreads)
	{
		throw null;
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00024986 File Offset: 0x00022B86
	[global::Cpp2ILInjected.Token(Token = "0x60010BC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4DF30", Offset = "0xA4DF30", Length = "0x2C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "WaitBackgroundDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMapThreaded", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur1PassThreaded", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur2PassThreaded", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportToThreaded", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(LightMap)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
	{
		typeof(WaitHandle[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void WaitAndProcess(ThreadedRenderManager.BatchProcessCallback callback, int numberOfThreads)
	{
		throw null;
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00024989 File Offset: 0x00022B89
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60010BD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4E1F4", Offset = "0xA4E1F4", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	static ThreadedRenderManager()
	{
		throw null;
	}

	// Token: 0x04001B23 RID: 6947
	[global::Cpp2ILInjected.Token(Token = "0x4002078")]
	public static int PrefferedThreadCount;

	// Token: 0x04001B24 RID: 6948
	[global::Cpp2ILInjected.Token(Token = "0x4002079")]
	private const int MaxThreadCount = 3;

	// Token: 0x04001B25 RID: 6949
	[global::Cpp2ILInjected.Token(Token = "0x400207A")]
	public static ThreadedRenderManager Instance;

	// Token: 0x04001B26 RID: 6950
	[global::Cpp2ILInjected.Token(Token = "0x400207B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ThreadedRenderManager.RenderThreadInstance[] DrawThreads;

	// Token: 0x04001B27 RID: 6951
	[global::Cpp2ILInjected.Token(Token = "0x400207C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private AutoResetEvent[][] WaitHandles;

	// Token: 0x04001B28 RID: 6952
	[global::Cpp2ILInjected.Token(Token = "0x400207D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int[][] WaitThreads;

	// Token: 0x04001B29 RID: 6953
	[global::Cpp2ILInjected.Token(Token = "0x400207E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private Thread monitor;

	// Token: 0x0200080E RID: 2062
	// (Invoke) Token: 0x0600490D RID: 18701
	[global::Cpp2ILInjected.Token(Token = "0x20002D8")]
	public delegate void BatchProcessCallback(int index);

	// Token: 0x0200080F RID: 2063
	[global::Cpp2ILInjected.Token(Token = "0x20002D9")]
	public class RenderThreadInstance
	{
		// Token: 0x06004910 RID: 18704 RVA: 0x0002EF49 File Offset: 0x0002D149
		[global::Cpp2ILInjected.Token(Token = "0x60010C2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4D80C", Offset = "0xA4D80C", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "RunCritical", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExcludeThread", MemberParameters = new object[] { typeof(ManagedThread) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public RenderThreadInstance(int index)
		{
			throw null;
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x0002EF4C File Offset: 0x0002D14C
		[global::Cpp2ILInjected.Token(Token = "0x60010C3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4DC3C", Offset = "0xA4DC3C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager), Member = "ThreadMonitor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "RunCritical", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void RestartThread()
		{
			throw null;
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x0002EF4F File Offset: 0x0002D14F
		[global::Cpp2ILInjected.Token(Token = "0x60010C4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E3C0", Offset = "0xA4E3C0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawRockLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			throw null;
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x0002EF52 File Offset: 0x0002D152
		[global::Cpp2ILInjected.Token(Token = "0x60010C5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E478", Offset = "0xA4E478", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawMagmaLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			throw null;
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x0002EF55 File Offset: 0x0002D155
		[global::Cpp2ILInjected.Token(Token = "0x60010C6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E530", Offset = "0xA4E530", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawCurrentBackground(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			throw null;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x0002EF58 File Offset: 0x0002D158
		[global::Cpp2ILInjected.Token(Token = "0x60010C7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E5E8", Offset = "0xA4E5E8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTilesThreaded", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawTiles(TileDrawing parent, Microsoft.Xna.Framework.Vector2 screenPosition, Microsoft.Xna.Framework.Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			throw null;
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x0002EF5B File Offset: 0x0002D15B
		[global::Cpp2ILInjected.Token(Token = "0x60010C8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E6EC", Offset = "0xA4E6EC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWallsThreaded", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawWalls(WallDrawing parent, Microsoft.Xna.Framework.Vector2 screenPosition, Microsoft.Xna.Framework.Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			throw null;
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x0002EF5E File Offset: 0x0002D15E
		[global::Cpp2ILInjected.Token(Token = "0x60010C9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E7B8", Offset = "0xA4E7B8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMapThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ExportToMinimap(LightingEngine parent, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			throw null;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x0002EF61 File Offset: 0x0002D161
		[global::Cpp2ILInjected.Token(Token = "0x60010CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E85C", Offset = "0xA4E85C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur1PassThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void BlurPass1(LightMap parent, int start, int end)
		{
			throw null;
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x0002EF64 File Offset: 0x0002D164
		[global::Cpp2ILInjected.Token(Token = "0x60010CB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E8F0", Offset = "0xA4E8F0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur2PassThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void BlurPass2(LightMap parent, int start, int end)
		{
			throw null;
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x0002EF67 File Offset: 0x0002D167
		[global::Cpp2ILInjected.Token(Token = "0x60010CC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4E984", Offset = "0xA4E984", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportToThreaded", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ExportTo(TileLightScanner scanner, int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
		{
			throw null;
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x0002EF6A File Offset: 0x0002D16A
		[global::Cpp2ILInjected.Token(Token = "0x60010CD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4EA40", Offset = "0xA4EA40", Length = "0x720")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "get__currentTileDrawInfo", ReturnType = typeof(ThreadLocal<TileDrawInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur2Pass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ExportToMiniMap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur1Pass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawCurrentBackground", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawRockLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawMagmaLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public void DrawThread()
		{
			throw null;
		}

		// Token: 0x04007D1F RID: 32031
		[global::Cpp2ILInjected.Token(Token = "0x400207F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ThreadedRenderManager.RenderThreadInstance.DrawTask _task;

		// Token: 0x04007D20 RID: 32032
		[global::Cpp2ILInjected.Token(Token = "0x4002080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public LiquidRenderer waterRenderer;

		// Token: 0x04007D21 RID: 32033
		[global::Cpp2ILInjected.Token(Token = "0x4002081")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TileDrawing tileDrawing;

		// Token: 0x04007D22 RID: 32034
		[global::Cpp2ILInjected.Token(Token = "0x4002082")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public WallDrawing wallDrawing;

		// Token: 0x04007D23 RID: 32035
		[global::Cpp2ILInjected.Token(Token = "0x4002083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public LightingEngine lightingEngine;

		// Token: 0x04007D24 RID: 32036
		[global::Cpp2ILInjected.Token(Token = "0x4002084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public LightMap lightingMap;

		// Token: 0x04007D25 RID: 32037
		[global::Cpp2ILInjected.Token(Token = "0x4002085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TileLightScanner tileScanner;

		// Token: 0x04007D26 RID: 32038
		[global::Cpp2ILInjected.Token(Token = "0x4002086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public SpriteBatch spriteBatch;

		// Token: 0x04007D27 RID: 32039
		[global::Cpp2ILInjected.Token(Token = "0x4002087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public SpriteBatch spriteBatch2;

		// Token: 0x04007D28 RID: 32040
		[global::Cpp2ILInjected.Token(Token = "0x4002088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TileBatch tileBatch;

		// Token: 0x04007D29 RID: 32041
		[global::Cpp2ILInjected.Token(Token = "0x4002089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private AutoResetEvent startEvent;

		// Token: 0x04007D2A RID: 32042
		[global::Cpp2ILInjected.Token(Token = "0x400208A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public AutoResetEvent completeEvent;

		// Token: 0x04007D2B RID: 32043
		[global::Cpp2ILInjected.Token(Token = "0x400208B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public bool Active;

		// Token: 0x04007D2C RID: 32044
		[global::Cpp2ILInjected.Token(Token = "0x400208C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		public bool Complete;

		// Token: 0x04007D2D RID: 32045
		[global::Cpp2ILInjected.Token(Token = "0x400208D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public ManagedThread ThreadHandle;

		// Token: 0x04007D2E RID: 32046
		[global::Cpp2ILInjected.Token(Token = "0x400208E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Microsoft.Xna.Framework.Vector2 _screenPosition;

		// Token: 0x04007D2F RID: 32047
		[global::Cpp2ILInjected.Token(Token = "0x400208F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Microsoft.Xna.Framework.Vector2 _offSet;

		// Token: 0x04007D30 RID: 32048
		[global::Cpp2ILInjected.Token(Token = "0x4002090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private int _firstTileX;

		// Token: 0x04007D31 RID: 32049
		[global::Cpp2ILInjected.Token(Token = "0x4002091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private int _firstTileY;

		// Token: 0x04007D32 RID: 32050
		[global::Cpp2ILInjected.Token(Token = "0x4002092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int _lastTileX;

		// Token: 0x04007D33 RID: 32051
		[global::Cpp2ILInjected.Token(Token = "0x4002093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private int _lastTileY;

		// Token: 0x04007D34 RID: 32052
		[global::Cpp2ILInjected.Token(Token = "0x4002094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool _solidLayer;

		// Token: 0x04007D35 RID: 32053
		[global::Cpp2ILInjected.Token(Token = "0x4002095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
		private bool _forRenderTargets;

		// Token: 0x04007D36 RID: 32054
		[global::Cpp2ILInjected.Token(Token = "0x4002096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
		private bool _intoRenderTargets;

		// Token: 0x04007D37 RID: 32055
		[global::Cpp2ILInjected.Token(Token = "0x4002097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		private int _waterStyleOverride;

		// Token: 0x04007D38 RID: 32056
		[global::Cpp2ILInjected.Token(Token = "0x4002098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private int _scannerTileX;

		// Token: 0x04007D39 RID: 32057
		[global::Cpp2ILInjected.Token(Token = "0x4002099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private int _scannerTileY;

		// Token: 0x04007D3A RID: 32058
		[global::Cpp2ILInjected.Token(Token = "0x400209A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private LocalUserGameState state;

		// Token: 0x04007D3B RID: 32059
		[global::Cpp2ILInjected.Token(Token = "0x400209B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private int _index;

		// Token: 0x04007D3C RID: 32060
		[global::Cpp2ILInjected.Token(Token = "0x400209C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private int _diff;

		// Token: 0x04007D3D RID: 32061
		[global::Cpp2ILInjected.Token(Token = "0x400209D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public bool Running;

		// Token: 0x04007D3E RID: 32062
		[global::Cpp2ILInjected.Token(Token = "0x400209E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		// Token: 0x04007D3F RID: 32063
		[global::Cpp2ILInjected.Token(Token = "0x400209F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		// Token: 0x04007D40 RID: 32064
		[global::Cpp2ILInjected.Token(Token = "0x40020A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		// Token: 0x04007D41 RID: 32065
		[global::Cpp2ILInjected.Token(Token = "0x40020A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		// Token: 0x04007D42 RID: 32066
		[global::Cpp2ILInjected.Token(Token = "0x40020A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		// Token: 0x04007D43 RID: 32067
		[global::Cpp2ILInjected.Token(Token = "0x40020A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		// Token: 0x04007D44 RID: 32068
		[global::Cpp2ILInjected.Token(Token = "0x40020A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public Dictionary<Point, int> _chestPositions;

		// Token: 0x02000B55 RID: 2901
		[global::Cpp2ILInjected.Token(Token = "0x20002DA")]
		private enum DrawTask
		{
			// Token: 0x04008FEF RID: 36847
			[global::Cpp2ILInjected.Token(Token = "0x40020A6")]
			None,
			// Token: 0x04008FF0 RID: 36848
			[global::Cpp2ILInjected.Token(Token = "0x40020A7")]
			DrawTask_DrawTiles,
			// Token: 0x04008FF1 RID: 36849
			[global::Cpp2ILInjected.Token(Token = "0x40020A8")]
			DrawTask_DrawWalls,
			// Token: 0x04008FF2 RID: 36850
			[global::Cpp2ILInjected.Token(Token = "0x40020A9")]
			LightingNew_ExportToMiniMap,
			// Token: 0x04008FF3 RID: 36851
			[global::Cpp2ILInjected.Token(Token = "0x40020AA")]
			LightMap_BlurPass1,
			// Token: 0x04008FF4 RID: 36852
			[global::Cpp2ILInjected.Token(Token = "0x40020AB")]
			LightMap_BlurPass2,
			// Token: 0x04008FF5 RID: 36853
			[global::Cpp2ILInjected.Token(Token = "0x40020AC")]
			Background_RockLayer,
			// Token: 0x04008FF6 RID: 36854
			[global::Cpp2ILInjected.Token(Token = "0x40020AD")]
			Background_MagmaLayer,
			// Token: 0x04008FF7 RID: 36855
			[global::Cpp2ILInjected.Token(Token = "0x40020AE")]
			Background_CurrentLayer,
			// Token: 0x04008FF8 RID: 36856
			[global::Cpp2ILInjected.Token(Token = "0x40020AF")]
			TileScanner_ExportTo
		}
	}
}
