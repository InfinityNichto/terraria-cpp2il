using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x200030B")]
	[StructLayout(0)]
	internal sealed class SocketAsyncResult : IOAsyncResult
	{
		[global::Cpp2ILInjected.Token(Token = "0x170004A1")]
		public IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001464")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35D00", Offset = "0x1E35D00", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginAccept", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(SocketFlags),
				typeof(ref SocketError),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(SocketFlags),
				typeof(ref EndPoint),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(SocketFlags),
				typeof(ref SocketError),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_Handle", ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A40", Offset = "0x1E35A40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		public SocketAsyncResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35D64", Offset = "0x1E35D64", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "Init", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Memory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35E18", Offset = "0x1E35E18", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginAccept", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004A2")]
		public SocketError ErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001468")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35E50", Offset = "0x1E35E50", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[]
			{
				typeof(IAsyncResult),
				typeof(ref SocketError)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[]
			{
				typeof(IAsyncResult),
				typeof(ref SocketError)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35ED0", Offset = "0x1E35ED0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref int),
			typeof(IAsyncResult)
		}, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new object[]
		{
			typeof(SocketAsyncResult),
			typeof(SocketAsyncEventArgs)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void CheckIfThrowDelayedException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600146A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35F50", Offset = "0x1E35F50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		internal override void CompleteDisposed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600146B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3127C", Offset = "0x1E3127C", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_4", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_5", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_7", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_9", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_11", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_12", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_14", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_16", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new object[] { typeof(Task<IPAddress[]>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "CompleteDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_CleanedUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "set_IsCompleted", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Complete()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600146C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35F54", Offset = "0x1E35F54", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(bool synch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600146D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E31CB0", Offset = "0x1E31CB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
		{
			typeof(SocketAsyncResult),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(int total)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600146E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35F60", Offset = "0x1E35F60", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Exception e, bool synch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600146F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E30BAC", Offset = "0x1E30BAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
		{
			typeof(SocketAsyncResult),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Exception e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E30BB4", Offset = "0x1E30BB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Socket s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E30DB0", Offset = "0x1E30DB0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Socket s, int total)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40010F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Socket socket;

		[global::Cpp2ILInjected.Token(Token = "0x40010F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public SocketOperation operation;

		[global::Cpp2ILInjected.Token(Token = "0x40010F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Exception DelayedException;

		[global::Cpp2ILInjected.Token(Token = "0x40010FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public EndPoint EndPoint;

		[global::Cpp2ILInjected.Token(Token = "0x40010FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public Memory<byte> Buffer;

		[global::Cpp2ILInjected.Token(Token = "0x40010FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int Offset;

		[global::Cpp2ILInjected.Token(Token = "0x40010FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public int Size;

		[global::Cpp2ILInjected.Token(Token = "0x40010FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public SocketFlags SockFlags;

		[global::Cpp2ILInjected.Token(Token = "0x40010FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Socket AcceptSocket;

		[global::Cpp2ILInjected.Token(Token = "0x4001100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public IPAddress[] Addresses;

		[global::Cpp2ILInjected.Token(Token = "0x4001101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public int Port;

		[global::Cpp2ILInjected.Token(Token = "0x4001102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public IList<ArraySegment<byte>> Buffers;

		[global::Cpp2ILInjected.Token(Token = "0x4001103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public bool ReuseSocket;

		[global::Cpp2ILInjected.Token(Token = "0x4001104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public int CurrentAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4001105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public Socket AcceptedSocket;

		[global::Cpp2ILInjected.Token(Token = "0x4001106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int Total;

		[global::Cpp2ILInjected.Token(Token = "0x4001107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		internal int error;

		[global::Cpp2ILInjected.Token(Token = "0x4001108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public int EndCalled;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200030C")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001472")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35F70", Offset = "0x1E35F70", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001473")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35FCC", Offset = "0x1E35FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001474")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35FD4", Offset = "0x1E35FD4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <Complete>b__27_0(object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001109")]
			public static readonly SocketAsyncResult.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400110A")]
			public static WaitCallback <>9__27_0;
		}
	}
}
