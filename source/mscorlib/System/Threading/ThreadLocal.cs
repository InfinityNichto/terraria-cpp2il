using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000188 RID: 392
	[global::System.Diagnostics.DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x20001E3")]
	public class ThreadLocal<T> : global::System.IDisposable
	{
		// Token: 0x06001022 RID: 4130 RVA: 0x000172BB File Offset: 0x000154BB
		[global::Cpp2ILInjected.Token(Token = "0x6001165")]
		[global::Cpp2ILInjected.Address(RVA = "0x187CA54", Offset = "0x187CA54", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUserGameState", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.WallDrawing", Member = ".ctor", MemberParameters = new object[] { "Terraria.GameContent.TilePaintSystemV2" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public ThreadLocal(global::System.Func<T> valueFactory)
		{
			throw null;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000172BE File Offset: 0x000154BE
		[global::Cpp2ILInjected.Token(Token = "0x6001166")]
		[global::Cpp2ILInjected.Address(RVA = "0x187CB38", Offset = "0x187CB38", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Initialize(global::System.Func<T> valueFactory, bool trackAllValues)
		{
			throw null;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000172C1 File Offset: 0x000154C1
		[global::Cpp2ILInjected.Token(Token = "0x6001167")]
		[global::Cpp2ILInjected.Address(RVA = "0x187CBCC", Offset = "0x187CBCC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000172C4 File Offset: 0x000154C4
		[global::Cpp2ILInjected.Token(Token = "0x6001168")]
		[global::Cpp2ILInjected.Address(RVA = "0x187CC6C", Offset = "0x187CC6C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000172C7 File Offset: 0x000154C7
		[global::Cpp2ILInjected.Token(Token = "0x6001169")]
		[global::Cpp2ILInjected.Address(RVA = "0x187CCD8", Offset = "0x187CCD8", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000172CA File Offset: 0x000154CA
		[global::Cpp2ILInjected.Token(Token = "0x600116A")]
		[global::Cpp2ILInjected.Address(RVA = "0x187CF04", Offset = "0x187CF04", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000172CD File Offset: 0x000154CD
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000172D0 File Offset: 0x000154D0
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x170001A0")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600116B")]
			[global::Cpp2ILInjected.Address(RVA = "0x187CF2C", Offset = "0x187CF2C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ThreadedRenderManager.RenderThreadInstance", Member = "DrawThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawCurrentBackground", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector2"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawMagmaLayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector2"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawRockLayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector2"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawBackground", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__displayDollTileEntityPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__hatRackTileEntityPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__trainingDummyTileEntityPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__itemFrameTileEntityPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__foodPlatterTileEntityPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__weaponRackTileEntityPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__chestPositions", ReturnType = "System.Collections.Generic.Dictionary`2<Point, Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "get__rand", ReturnType = "Terraria.Utilities.UnifiedRandom")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "DrawTiles", MemberParameters = new object[]
			{
				"Microsoft.Xna.Framework.Vector2",
				"Microsoft.Xna.Framework.Vector2",
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "DrawLiquidBehindTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "Draw", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.WallDrawing", Member = "DrawWalls", MemberParameters = new object[]
			{
				"Microsoft.Xna.Framework.Vector2",
				"Microsoft.Xna.Framework.Vector2",
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.WallDrawing", Member = "DrawWalls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 47)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600116C")]
			[global::Cpp2ILInjected.Address(RVA = "0x187D000", Offset = "0x187D000", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x000172D3 File Offset: 0x000154D3
		[global::Cpp2ILInjected.Token(Token = "0x600116D")]
		[global::Cpp2ILInjected.Address(RVA = "0x187D0EC", Offset = "0x187D0EC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Debugger), Member = "NotifyOfCrossThreadDependency", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private T GetValueSlow()
		{
			throw null;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x000172D6 File Offset: 0x000154D6
		[global::Cpp2ILInjected.Token(Token = "0x600116E")]
		[global::Cpp2ILInjected.Address(RVA = "0x187D23C", Offset = "0x187D23C", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void SetValueSlow(T value, ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
		{
			throw null;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000172D9 File Offset: 0x000154D9
		[global::Cpp2ILInjected.Token(Token = "0x600116F")]
		[global::Cpp2ILInjected.Address(RVA = "0x187D520", Offset = "0x187D520", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void CreateLinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, int id, T value)
		{
			throw null;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x000172DC File Offset: 0x000154DC
		[global::Cpp2ILInjected.Token(Token = "0x170001A1")]
		public bool IsValueCreated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001170")]
			[global::Cpp2ILInjected.Address(RVA = "0x187D744", Offset = "0x187D744", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000172DF File Offset: 0x000154DF
		[global::Cpp2ILInjected.Token(Token = "0x6001171")]
		[global::Cpp2ILInjected.Address(RVA = "0x187D828", Offset = "0x187D828", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void GrowTable(ref ThreadLocal<T>.LinkedSlotVolatile[] table, int minLength)
		{
			throw null;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000172E2 File Offset: 0x000154E2
		[global::Cpp2ILInjected.Token(Token = "0x6001172")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DA00", Offset = "0x187DA00", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetNewTableSize(int minSize)
		{
			throw null;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000172E5 File Offset: 0x000154E5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001173")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DA40", Offset = "0x187DA40", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static ThreadLocal()
		{
			throw null;
		}

		// Token: 0x04000752 RID: 1874
		[global::Cpp2ILInjected.Token(Token = "0x4000965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Func<T> m_valueFactory;

		// Token: 0x04000753 RID: 1875
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000966")]
		private static ThreadLocal<T>.LinkedSlotVolatile[] ts_slotArray;

		// Token: 0x04000754 RID: 1876
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000967")]
		private static ThreadLocal<T>.FinalizationHelper ts_finalizationHelper;

		// Token: 0x04000755 RID: 1877
		[global::Cpp2ILInjected.Token(Token = "0x4000968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_idComplement;

		// Token: 0x04000756 RID: 1878
		[global::Cpp2ILInjected.Token(Token = "0x4000969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool m_initialized;

		// Token: 0x04000757 RID: 1879
		[global::Cpp2ILInjected.Token(Token = "0x400096A")]
		private static ThreadLocal<T>.IdManager s_idManager;

		// Token: 0x04000758 RID: 1880
		[global::Cpp2ILInjected.Token(Token = "0x400096B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ThreadLocal<T>.LinkedSlot m_linkedSlot;

		// Token: 0x04000759 RID: 1881
		[global::Cpp2ILInjected.Token(Token = "0x400096C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool m_trackAllValues;

		// Token: 0x020005A8 RID: 1448
		[global::Cpp2ILInjected.Token(Token = "0x20001E4")]
		private struct LinkedSlotVolatile
		{
			// Token: 0x0400189D RID: 6301
			[global::Cpp2ILInjected.Token(Token = "0x400096D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlot Value;
		}

		// Token: 0x020005A9 RID: 1449
		[global::Cpp2ILInjected.Token(Token = "0x20001E5")]
		private sealed class LinkedSlot
		{
			// Token: 0x06004020 RID: 16416 RVA: 0x0001FB17 File Offset: 0x0001DD17
			[global::Cpp2ILInjected.Token(Token = "0x6001174")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B040", Offset = "0x172B040", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal LinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
			{
				throw null;
			}

			// Token: 0x0400189E RID: 6302
			[global::Cpp2ILInjected.Token(Token = "0x400096E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlot Next;

			// Token: 0x0400189F RID: 6303
			[global::Cpp2ILInjected.Token(Token = "0x400096F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlot Previous;

			// Token: 0x040018A0 RID: 6304
			[global::Cpp2ILInjected.Token(Token = "0x4000970")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			// Token: 0x040018A1 RID: 6305
			[global::Cpp2ILInjected.Token(Token = "0x4000971")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal T Value;
		}

		// Token: 0x020005AA RID: 1450
		[global::Cpp2ILInjected.Token(Token = "0x20001E6")]
		private class IdManager
		{
			// Token: 0x06004021 RID: 16417 RVA: 0x0001FB1A File Offset: 0x0001DD1A
			[global::Cpp2ILInjected.Token(Token = "0x6001175")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BBF2C", Offset = "0x16BBF2C", Length = "0x1D8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<bool>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<bool>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			internal int GetId()
			{
				throw null;
			}

			// Token: 0x06004022 RID: 16418 RVA: 0x0001FB1D File Offset: 0x0001DD1D
			[global::Cpp2ILInjected.Token(Token = "0x6001176")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BC104", Offset = "0x16BC104", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<bool>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			internal void ReturnId(int id)
			{
				throw null;
			}

			// Token: 0x06004023 RID: 16419 RVA: 0x0001FB20 File Offset: 0x0001DD20
			[global::Cpp2ILInjected.Token(Token = "0x6001177")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BC214", Offset = "0x16BC214", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<bool>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public IdManager()
			{
				throw null;
			}

			// Token: 0x040018A2 RID: 6306
			[global::Cpp2ILInjected.Token(Token = "0x4000972")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int m_nextIdToTry;

			// Token: 0x040018A3 RID: 6307
			[global::Cpp2ILInjected.Token(Token = "0x4000973")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Collections.Generic.List<bool> m_freeIds;
		}

		// Token: 0x020005AB RID: 1451
		[global::Cpp2ILInjected.Token(Token = "0x20001E7")]
		private class FinalizationHelper
		{
			// Token: 0x06004024 RID: 16420 RVA: 0x0001FB23 File Offset: 0x0001DD23
			[global::Cpp2ILInjected.Token(Token = "0x6001178")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A2CB0", Offset = "0x16A2CB0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal FinalizationHelper(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, bool trackAllValues)
			{
				throw null;
			}

			// Token: 0x06004025 RID: 16421 RVA: 0x0001FB26 File Offset: 0x0001DD26
			[global::Cpp2ILInjected.Token(Token = "0x6001179")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A2CE0", Offset = "0x16A2CE0", Length = "0x234")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			protected override void Finalize()
			{
				throw null;
			}

			// Token: 0x040018A4 RID: 6308
			[global::Cpp2ILInjected.Token(Token = "0x4000974")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			// Token: 0x040018A5 RID: 6309
			[global::Cpp2ILInjected.Token(Token = "0x4000975")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private bool m_trackAllValues;
		}
	}
}
