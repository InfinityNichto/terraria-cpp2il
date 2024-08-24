using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000423 RID: 1059
	[global::Cpp2ILInjected.Token(Token = "0x200061E")]
	public class DoubleStack<T1>
	{
		// Token: 0x060030B4 RID: 12468 RVA: 0x0002AB66 File Offset: 0x00028D66
		[global::Cpp2ILInjected.Token(Token = "0x60035D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x162093C", Offset = "0x162093C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public DoubleStack(int segmentSize = 1024, int initialSize = 0)
		{
			throw null;
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0002AB69 File Offset: 0x00028D69
		[global::Cpp2ILInjected.Token(Token = "0x60035D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1620A58", Offset = "0x1620A58", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void PushFront(T1 front)
		{
			throw null;
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0002AB6C File Offset: 0x00028D6C
		[global::Cpp2ILInjected.Token(Token = "0x60035D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1620BC0", Offset = "0x1620BC0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWire", MemberParameters = new object[]
		{
			typeof(DoubleStack<Point16>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public T1 PopFront()
		{
			throw null;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0002AB6F File Offset: 0x00028D6F
		[global::Cpp2ILInjected.Token(Token = "0x60035D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1620D38", Offset = "0x1620D38", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T1 PeekFront()
		{
			throw null;
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0002AB72 File Offset: 0x00028D72
		[global::Cpp2ILInjected.Token(Token = "0x60035D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1620DB8", Offset = "0x1620DB8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWire", MemberParameters = new object[]
		{
			typeof(DoubleStack<Point16>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void PushBack(T1 back)
		{
			throw null;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0002AB75 File Offset: 0x00028D75
		[global::Cpp2ILInjected.Token(Token = "0x60035D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1620F14", Offset = "0x1620F14", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T1 PopBack()
		{
			throw null;
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0002AB78 File Offset: 0x00028D78
		[global::Cpp2ILInjected.Token(Token = "0x60035D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1620FC4", Offset = "0x1620FC4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T1 PeekBack()
		{
			throw null;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0002AB7B File Offset: 0x00028D7B
		[global::Cpp2ILInjected.Token(Token = "0x60035D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1621044", Offset = "0x1621044", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "TripWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWire", MemberParameters = new object[]
		{
			typeof(DoubleStack<Point16>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear(bool quickClear = false)
		{
			throw null;
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x0002AB7E File Offset: 0x00028D7E
		[global::Cpp2ILInjected.Token(Token = "0x1700068B")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60035D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x16210B4", Offset = "0x16210B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040062BB RID: 25275
		[global::Cpp2ILInjected.Token(Token = "0x40076A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T1[][] _segmentList;

		// Token: 0x040062BC RID: 25276
		[global::Cpp2ILInjected.Token(Token = "0x40076A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _segmentSize;

		// Token: 0x040062BD RID: 25277
		[global::Cpp2ILInjected.Token(Token = "0x40076A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _segmentCount;

		// Token: 0x040062BE RID: 25278
		[global::Cpp2ILInjected.Token(Token = "0x40076A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _segmentShiftPosition;

		// Token: 0x040062BF RID: 25279
		[global::Cpp2ILInjected.Token(Token = "0x40076A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _start;

		// Token: 0x040062C0 RID: 25280
		[global::Cpp2ILInjected.Token(Token = "0x40076AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _end;

		// Token: 0x040062C1 RID: 25281
		[global::Cpp2ILInjected.Token(Token = "0x40076AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x040062C2 RID: 25282
		[global::Cpp2ILInjected.Token(Token = "0x40076AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _last;
	}
}
