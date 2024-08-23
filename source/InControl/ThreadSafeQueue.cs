using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000063 RID: 99
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	internal class ThreadSafeQueue<T>
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00002F18 File Offset: 0x00001118
		[global::Cpp2ILInjected.Token(Token = "0x6000511")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DB2C", Offset = "0x187DB2C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ThreadSafeQueue()
		{
			throw null;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002F1B File Offset: 0x0000111B
		[global::Cpp2ILInjected.Token(Token = "0x6000512")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DBD4", Offset = "0x187DBD4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ThreadSafeQueue(int capacity)
		{
			throw null;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002F1E File Offset: 0x0000111E
		[global::Cpp2ILInjected.Token(Token = "0x6000513")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DC84", Offset = "0x187DC84", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Enqueue(T item)
		{
			throw null;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002F21 File Offset: 0x00001121
		[global::Cpp2ILInjected.Token(Token = "0x6000514")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DD60", Offset = "0x187DD60", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Dequeue(out T item)
		{
			throw null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002F24 File Offset: 0x00001124
		[global::Cpp2ILInjected.Token(Token = "0x6000515")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DEA0", Offset = "0x187DEA0", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public T Dequeue()
		{
			throw null;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002F27 File Offset: 0x00001127
		[global::Cpp2ILInjected.Token(Token = "0x6000516")]
		[global::Cpp2ILInjected.Address(RVA = "0x187DFCC", Offset = "0x187DFCC", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int Dequeue(ref IList<T> list)
		{
			throw null;
		}

		// Token: 0x040003A9 RID: 937
		[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object sync;

		// Token: 0x040003AA RID: 938
		[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Queue<T> data;
	}
}
