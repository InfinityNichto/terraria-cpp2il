using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Telepathy
{
	// Token: 0x02000258 RID: 600
	[global::Cpp2ILInjected.Token(Token = "0x2000316")]
	public class SafeQueue<T>
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00024E27 File Offset: 0x00023027
		[global::Cpp2ILInjected.Token(Token = "0x170001CF")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600126E")]
			[global::Cpp2ILInjected.Address(RVA = "0x186314C", Offset = "0x186314C", Length = "0xE0")]
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
			get
			{
				throw null;
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00024E2A File Offset: 0x0002302A
		[global::Cpp2ILInjected.Token(Token = "0x600126F")]
		[global::Cpp2ILInjected.Address(RVA = "0x186322C", Offset = "0x186322C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server), Member = "Send", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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

		// Token: 0x06001119 RID: 4377 RVA: 0x00024E2D File Offset: 0x0002302D
		[global::Cpp2ILInjected.Token(Token = "0x6001270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1863308", Offset = "0x1863308", Length = "0x118")]
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
		public bool TryDequeue(out T result)
		{
			throw null;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00024E30 File Offset: 0x00023030
		[global::Cpp2ILInjected.Token(Token = "0x6001271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1863420", Offset = "0x1863420", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Common), Member = "SendLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TcpClient),
			typeof(SafeQueue<byte[]>),
			typeof(ManualResetEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool TryDequeueAll(out T[] result)
		{
			throw null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00024E33 File Offset: 0x00023033
		[global::Cpp2ILInjected.Token(Token = "0x6001272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1863530", Offset = "0x1863530", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00024E36 File Offset: 0x00023036
		[global::Cpp2ILInjected.Token(Token = "0x6001273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1863604", Offset = "0x1863604", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server.ClientToken", Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SafeQueue()
		{
			throw null;
		}

		// Token: 0x04001C38 RID: 7224
		[global::Cpp2ILInjected.Token(Token = "0x4002208")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Queue<T> queue;
	}
}
