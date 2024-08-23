using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000529 RID: 1321
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(QueueDebugView<>))]
	[global::System.Runtime.CompilerServices.TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[global::Cpp2ILInjected.Token(Token = "0x2000644")]
	[global::System.Serializable]
	public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06002C88 RID: 11400 RVA: 0x0001C0FA File Offset: 0x0001A2FA
		[global::Cpp2ILInjected.Token(Token = "0x6003104")]
		[global::Cpp2ILInjected.Address(RVA = "0x181DFC0", Offset = "0x181DFC0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.BufferPool", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.LegacyNetBufferPool", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Queue()
		{
			throw null;
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x0001C0FD File Offset: 0x0001A2FD
		[global::Cpp2ILInjected.Token(Token = "0x6003105")]
		[global::Cpp2ILInjected.Address(RVA = "0x181DFFC", Offset = "0x181DFFC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Queue(int capacity)
		{
			throw null;
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x0001C100 File Offset: 0x0001A300
		[global::Cpp2ILInjected.Token(Token = "0x170007E6")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003106")]
			[global::Cpp2ILInjected.Address(RVA = "0x181E0D0", Offset = "0x181E0D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x0001C103 File Offset: 0x0001A303
		[global::Cpp2ILInjected.Token(Token = "0x170007E7")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003107")]
			[global::Cpp2ILInjected.Address(RVA = "0x181E0D8", Offset = "0x181E0D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002C8C RID: 11404 RVA: 0x0001C106 File Offset: 0x0001A306
		[global::Cpp2ILInjected.Token(Token = "0x170007E8")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003108")]
			[global::Cpp2ILInjected.Address(RVA = "0x181E0E0", Offset = "0x181E0E0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x0001C109 File Offset: 0x0001A309
		[global::Cpp2ILInjected.Token(Token = "0x6003109")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E150", Offset = "0x181E150", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x0001C10C File Offset: 0x0001A30C
		[global::Cpp2ILInjected.Token(Token = "0x600310A")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E1B8", Offset = "0x181E1B8", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x0001C10F File Offset: 0x0001A30F
		[global::Cpp2ILInjected.Token(Token = "0x600310B")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E488", Offset = "0x181E488", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "QueuePostGenAction", MemberParameters = new object[] { "System.Action`1<StructureMap>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "Recycle", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.BufferPool", Member = "Recycle", MemberParameters = new object[] { "Terraria.DataStructures.CachedBuffer" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.LegacyNetBufferPool", Member = "ReturnBuffer", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			"System.Diagnostics.TraceLevel",
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public void Enqueue(T item)
		{
			throw null;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x0001C112 File Offset: 0x0001A312
		[global::Cpp2ILInjected.Token(Token = "0x600310C")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E520", Offset = "0x181E520", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Queue`1<T>" }, ReturnType = typeof(void))]
		public Queue<T>.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x0001C115 File Offset: 0x0001A315
		[global::Cpp2ILInjected.Token(Token = "0x600310D")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E540", Offset = "0x181E540", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Queue`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0001C118 File Offset: 0x0001A318
		[global::Cpp2ILInjected.Token(Token = "0x600310E")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E5A8", Offset = "0x181E5A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Queue`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x0001C11B File Offset: 0x0001A31B
		[global::Cpp2ILInjected.Token(Token = "0x600310F")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E610", Offset = "0x181E610", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "ConsumePostGenActions", MemberParameters = new object[] { "Terraria.WorldBuilding.StructureMap" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "GetBoolBuffer", ReturnType = "System.Boolean[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "GetIntBuffer", ReturnType = "System.Int32[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "GetUshortBuffer", ReturnType = "System.UInt16[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "GetFloatBuffer", ReturnType = "System.Single[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.BufferPool", Member = "Request", MemberParameters = new object[] { typeof(int) }, ReturnType = "Terraria.DataStructures.CachedBuffer")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.LegacyNetBufferPool", Member = "RequestBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "DequeueNextDirectory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			"System.Diagnostics.TraceLevel",
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public T Dequeue()
		{
			throw null;
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x0001C11E File Offset: 0x0001A31E
		[global::Cpp2ILInjected.Token(Token = "0x6003110")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E6A0", Offset = "0x181E6A0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public T Peek()
		{
			throw null;
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x0001C121 File Offset: 0x0001A321
		[global::Cpp2ILInjected.Token(Token = "0x6003111")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E6E0", Offset = "0x181E6E0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public T[] ToArray()
		{
			throw null;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0001C124 File Offset: 0x0001A324
		[global::Cpp2ILInjected.Token(Token = "0x6003112")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E798", Offset = "0x181E798", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetCapacity(int capacity)
		{
			throw null;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0001C127 File Offset: 0x0001A327
		[global::Cpp2ILInjected.Token(Token = "0x6003113")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E864", Offset = "0x181E864", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MoveNext(ref int index)
		{
			throw null;
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x0001C12A File Offset: 0x0001A32A
		[global::Cpp2ILInjected.Token(Token = "0x6003114")]
		[global::Cpp2ILInjected.Address(RVA = "0x181E884", Offset = "0x181E884", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ThrowForEmptyQueue()
		{
			throw null;
		}

		// Token: 0x04001628 RID: 5672
		[global::Cpp2ILInjected.Token(Token = "0x4001A8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _array;

		// Token: 0x04001629 RID: 5673
		[global::Cpp2ILInjected.Token(Token = "0x4001A8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _head;

		// Token: 0x0400162A RID: 5674
		[global::Cpp2ILInjected.Token(Token = "0x4001A8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _tail;

		// Token: 0x0400162B RID: 5675
		[global::Cpp2ILInjected.Token(Token = "0x4001A8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x0400162C RID: 5676
		[global::Cpp2ILInjected.Token(Token = "0x4001A8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x0400162D RID: 5677
		[global::Cpp2ILInjected.Token(Token = "0x4001A90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x02000661 RID: 1633
		[global::Cpp2ILInjected.Token(Token = "0x2000645")]
		[global::System.Serializable]
		public struct Enumerator : IEnumerator<T>, global::System.IDisposable, IEnumerator
		{
			// Token: 0x06004340 RID: 17216 RVA: 0x00020414 File Offset: 0x0001E614
			[global::Cpp2ILInjected.Token(Token = "0x6003115")]
			[global::Cpp2ILInjected.Address(RVA = "0x16486BC", Offset = "0x16486BC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			internal Enumerator(Queue<T> q)
			{
				throw null;
			}

			// Token: 0x06004341 RID: 17217 RVA: 0x00020417 File Offset: 0x0001E617
			[global::Cpp2ILInjected.Token(Token = "0x6003116")]
			[global::Cpp2ILInjected.Address(RVA = "0x16486D4", Offset = "0x16486D4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06004342 RID: 17218 RVA: 0x0002041A File Offset: 0x0001E61A
			[global::Cpp2ILInjected.Token(Token = "0x6003117")]
			[global::Cpp2ILInjected.Address(RVA = "0x16486E4", Offset = "0x16486E4", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x06004343 RID: 17219 RVA: 0x0002041D File Offset: 0x0001E61D
			[global::Cpp2ILInjected.Token(Token = "0x170007E9")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003118")]
				[global::Cpp2ILInjected.Address(RVA = "0x16487B8", Offset = "0x16487B8", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue<>.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "ToString", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = "ThrowEnumerationNotStartedOrEnded", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004344 RID: 17220 RVA: 0x00020420 File Offset: 0x0001E620
			[global::Cpp2ILInjected.Token(Token = "0x6003119")]
			[global::Cpp2ILInjected.Address(RVA = "0x16487EC", Offset = "0x16487EC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue<>.Enumerator), Member = "get_Current", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void ThrowEnumerationNotStartedOrEnded()
			{
				throw null;
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x06004345 RID: 17221 RVA: 0x00020423 File Offset: 0x0001E623
			[global::Cpp2ILInjected.Token(Token = "0x170007EA")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600311A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1648850", Offset = "0x1648850", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = "get_Current", ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004346 RID: 17222 RVA: 0x00020426 File Offset: 0x0001E626
			[global::Cpp2ILInjected.Token(Token = "0x600311B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648884", Offset = "0x1648884", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x04001ADA RID: 6874
			[global::Cpp2ILInjected.Token(Token = "0x4001A91")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly Queue<T> _q;

			// Token: 0x04001ADB RID: 6875
			[global::Cpp2ILInjected.Token(Token = "0x4001A92")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly int _version;

			// Token: 0x04001ADC RID: 6876
			[global::Cpp2ILInjected.Token(Token = "0x4001A93")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001ADD RID: 6877
			[global::Cpp2ILInjected.Token(Token = "0x4001A94")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _currentElement;
		}
	}
}
