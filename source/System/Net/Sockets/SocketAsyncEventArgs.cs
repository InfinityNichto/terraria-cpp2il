using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x0200021B RID: 539
	[global::Cpp2ILInjected.Token(Token = "0x200030A")]
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x000061D3 File Offset: 0x000043D3
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x000061D6 File Offset: 0x000043D6
		[global::Cpp2ILInjected.Token(Token = "0x17000494")]
		public Socket AcceptSocket
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001446")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E357E8", Offset = "0x1E357E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001447")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E357F0", Offset = "0x1E357F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000061D9 File Offset: 0x000043D9
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x000061DC File Offset: 0x000043DC
		[global::Cpp2ILInjected.Token(Token = "0x17000495")]
		public int BytesTransferred
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001448")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E357F8", Offset = "0x1E357F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001449")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35800", Offset = "0x1E35800", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x000061DF File Offset: 0x000043DF
		[global::Cpp2ILInjected.Token(Token = "0x17000496")]
		private SocketAsyncOperation LastOperation
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600144A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35808", Offset = "0x1E35808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x000061E2 File Offset: 0x000043E2
		[global::Cpp2ILInjected.Token(Token = "0x17000497")]
		public EndPoint RemoteEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x600144B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35810", Offset = "0x1E35810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x000061E5 File Offset: 0x000043E5
		[MonoTODO("unused property")]
		[global::Cpp2ILInjected.Token(Token = "0x17000498")]
		public int SendPacketsSendSize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600144C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35818", Offset = "0x1E35818", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x000061E8 File Offset: 0x000043E8
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x000061EB File Offset: 0x000043EB
		[global::Cpp2ILInjected.Token(Token = "0x17000499")]
		public SocketError SocketError
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600144D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35820", Offset = "0x1E35820", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600144E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35828", Offset = "0x1E35828", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x000061EE File Offset: 0x000043EE
		[global::Cpp2ILInjected.Token(Token = "0x1700049A")]
		public SocketFlags SocketFlags
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600144F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35830", Offset = "0x1E35830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x000061F1 File Offset: 0x000043F1
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x000061F4 File Offset: 0x000043F4
		[global::Cpp2ILInjected.Token(Token = "0x1700049B")]
		public object UserToken
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001450")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35838", Offset = "0x1E35838", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001451")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35840", Offset = "0x1E35840", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001219 RID: 4633 RVA: 0x000061F7 File Offset: 0x000043F7
		// (remove) Token: 0x0600121A RID: 4634 RVA: 0x000061FA File Offset: 0x000043FA
		[global::Cpp2ILInjected.Token(Token = "0x1400000D")]
		public event EventHandler<SocketAsyncEventArgs> Completed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001452")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35848", Offset = "0x1E35848", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(HttpListener),
				typeof(IPAddress),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001453")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E358F8", Offset = "0x1E358F8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000061FD File Offset: 0x000043FD
		[global::Cpp2ILInjected.Token(Token = "0x6001454")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E359A8", Offset = "0x1E359A8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SocketAsyncEventArgs()
		{
			throw null;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00006200 File Offset: 0x00004400
		[global::Cpp2ILInjected.Token(Token = "0x6001455")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2E684", Offset = "0x1E2E684", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.TaskSocketAsyncEventArgs`1", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal SocketAsyncEventArgs(bool flowExecutionContext)
		{
			throw null;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00006203 File Offset: 0x00004403
		[global::Cpp2ILInjected.Token(Token = "0x6001456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A48", Offset = "0x1E35A48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00006206 File Offset: 0x00004406
		[global::Cpp2ILInjected.Token(Token = "0x6001457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A58", Offset = "0x1E35A58", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00006209 File Offset: 0x00004409
		[global::Cpp2ILInjected.Token(Token = "0x6001458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A6C", Offset = "0x1E35A6C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0000620C File Offset: 0x0000440C
		[global::Cpp2ILInjected.Token(Token = "0x6001459")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E31A1C", Offset = "0x1E31A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void SetBytesTransferred(int value)
		{
			throw null;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0000620F File Offset: 0x0000440F
		[global::Cpp2ILInjected.Token(Token = "0x1700049C")]
		internal Socket CurrentSocket
		{
			[global::Cpp2ILInjected.Token(Token = "0x600145A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35AD0", Offset = "0x1E35AD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00006212 File Offset: 0x00004412
		[global::Cpp2ILInjected.Token(Token = "0x600145B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35AD8", Offset = "0x1E35AD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetCurrentSocket(Socket socket)
		{
			throw null;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00006215 File Offset: 0x00004415
		[global::Cpp2ILInjected.Token(Token = "0x600145C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35AE0", Offset = "0x1E35AE0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void SetLastOperation(SocketAsyncOperation op)
		{
			throw null;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00006218 File Offset: 0x00004418
		[global::Cpp2ILInjected.Token(Token = "0x600145D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35BA0", Offset = "0x1E35BA0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Complete_internal()
		{
			throw null;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0000621B File Offset: 0x0000441B
		[global::Cpp2ILInjected.Token(Token = "0x600145E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35BC8", Offset = "0x1E35BC8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			throw null;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0000621E File Offset: 0x0000441E
		[global::Cpp2ILInjected.Token(Token = "0x1700049D")]
		public Memory<byte> MemoryBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600145F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35BF0", Offset = "0x1E35BF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00006221 File Offset: 0x00004421
		[global::Cpp2ILInjected.Token(Token = "0x1700049E")]
		public int Offset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001460")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35BFC", Offset = "0x1E35BFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00006224 File Offset: 0x00004424
		[global::Cpp2ILInjected.Token(Token = "0x1700049F")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001461")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35C04", Offset = "0x1E35C04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00006227 File Offset: 0x00004427
		[global::Cpp2ILInjected.Token(Token = "0x170004A0")]
		public IList<ArraySegment<byte>> BufferList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001462")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35C0C", Offset = "0x1E35C0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0000622A File Offset: 0x0000442A
		[global::Cpp2ILInjected.Token(Token = "0x6001463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35C14", Offset = "0x1E35C14", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(SocketFlags),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(SocketFlags),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void SetBuffer(Memory<byte> buffer)
		{
			throw null;
		}

		// Token: 0x04000CEC RID: 3308
		[global::Cpp2ILInjected.Token(Token = "0x40010E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x04000CED RID: 3309
		[global::Cpp2ILInjected.Token(Token = "0x40010E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int in_progress;

		// Token: 0x04000CEE RID: 3310
		[global::Cpp2ILInjected.Token(Token = "0x40010E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EndPoint remote_ep;

		// Token: 0x04000CEF RID: 3311
		[global::Cpp2ILInjected.Token(Token = "0x40010E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Socket current_socket;

		// Token: 0x04000CF0 RID: 3312
		[global::Cpp2ILInjected.Token(Token = "0x40010E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal SocketAsyncResult socket_async_result;

		// Token: 0x04000CF1 RID: 3313
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Socket <AcceptSocket>k__BackingField;

		// Token: 0x04000CF2 RID: 3314
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <BytesTransferred>k__BackingField;

		// Token: 0x04000CF3 RID: 3315
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private SocketAsyncOperation <LastOperation>k__BackingField;

		// Token: 0x04000CF4 RID: 3316
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int <SendPacketsSendSize>k__BackingField;

		// Token: 0x04000CF5 RID: 3317
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private SocketError <SocketError>k__BackingField;

		// Token: 0x04000CF6 RID: 3318
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SocketFlags <SocketFlags>k__BackingField;

		// Token: 0x04000CF7 RID: 3319
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private object <UserToken>k__BackingField;

		// Token: 0x04000CF8 RID: 3320
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private EventHandler<SocketAsyncEventArgs> Completed;

		// Token: 0x04000CF9 RID: 3321
		[global::Cpp2ILInjected.Token(Token = "0x40010F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Memory<byte> _buffer;

		// Token: 0x04000CFA RID: 3322
		[global::Cpp2ILInjected.Token(Token = "0x40010F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int _offset;

		// Token: 0x04000CFB RID: 3323
		[global::Cpp2ILInjected.Token(Token = "0x40010F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int _count;

		// Token: 0x04000CFC RID: 3324
		[global::Cpp2ILInjected.Token(Token = "0x40010F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _bufferIsExplicitArray;

		// Token: 0x04000CFD RID: 3325
		[global::Cpp2ILInjected.Token(Token = "0x40010F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private IList<ArraySegment<byte>> _bufferList;
	}
}
