using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x200030A")]
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A48", Offset = "0x1E35A48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A58", Offset = "0x1E35A58", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A6C", Offset = "0x1E35A6C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Dispose()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600145B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35AD8", Offset = "0x1E35AD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetCurrentSocket(Socket socket)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600145D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35BA0", Offset = "0x1E35BA0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Complete_internal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600145E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35BC8", Offset = "0x1E35BC8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40010E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x40010E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int in_progress;

		[global::Cpp2ILInjected.Token(Token = "0x40010E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EndPoint remote_ep;

		[global::Cpp2ILInjected.Token(Token = "0x40010E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Socket current_socket;

		[global::Cpp2ILInjected.Token(Token = "0x40010E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal SocketAsyncResult socket_async_result;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Socket <AcceptSocket>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <BytesTransferred>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private SocketAsyncOperation <LastOperation>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int <SendPacketsSendSize>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private SocketError <SocketError>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SocketFlags <SocketFlags>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private object <UserToken>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40010F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private EventHandler<SocketAsyncEventArgs> Completed;

		[global::Cpp2ILInjected.Token(Token = "0x40010F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Memory<byte> _buffer;

		[global::Cpp2ILInjected.Token(Token = "0x40010F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int _offset;

		[global::Cpp2ILInjected.Token(Token = "0x40010F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int _count;

		[global::Cpp2ILInjected.Token(Token = "0x40010F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _bufferIsExplicitArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private IList<ArraySegment<byte>> _bufferList;
	}
}
