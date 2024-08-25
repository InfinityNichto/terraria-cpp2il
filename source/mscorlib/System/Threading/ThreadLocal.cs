using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::System.Diagnostics.DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x20001E3")]
	public class ThreadLocal<T> : global::System.IDisposable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001172")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DA00", Offset = "0x187DA00", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetNewTableSize(int minSize)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Func<T> m_valueFactory;

		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000966")]
		private static ThreadLocal<T>.LinkedSlotVolatile[] ts_slotArray;

		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000967")]
		private static ThreadLocal<T>.FinalizationHelper ts_finalizationHelper;

		[global::Cpp2ILInjected.Token(Token = "0x4000968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_idComplement;

		[global::Cpp2ILInjected.Token(Token = "0x4000969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool m_initialized;

		[global::Cpp2ILInjected.Token(Token = "0x400096A")]
		private static ThreadLocal<T>.IdManager s_idManager;

		[global::Cpp2ILInjected.Token(Token = "0x400096B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ThreadLocal<T>.LinkedSlot m_linkedSlot;

		[global::Cpp2ILInjected.Token(Token = "0x400096C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool m_trackAllValues;

		[global::Cpp2ILInjected.Token(Token = "0x20001E4")]
		private struct LinkedSlotVolatile
		{
			[global::Cpp2ILInjected.Token(Token = "0x400096D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlot Value;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20001E5")]
		private sealed class LinkedSlot
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x400096E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlot Next;

			[global::Cpp2ILInjected.Token(Token = "0x400096F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlot Previous;

			[global::Cpp2ILInjected.Token(Token = "0x4000970")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			[global::Cpp2ILInjected.Token(Token = "0x4000971")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal T Value;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20001E6")]
		private class IdManager
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4000972")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int m_nextIdToTry;

			[global::Cpp2ILInjected.Token(Token = "0x4000973")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Collections.Generic.List<bool> m_freeIds;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20001E7")]
		private class FinalizationHelper
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001178")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A2CB0", Offset = "0x16A2CB0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal FinalizationHelper(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, bool trackAllValues)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000974")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			[global::Cpp2ILInjected.Token(Token = "0x4000975")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private bool m_trackAllValues;
		}
	}
}
