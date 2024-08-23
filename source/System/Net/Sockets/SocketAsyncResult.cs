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
	// Token: 0x0200021C RID: 540
	[global::Cpp2ILInjected.Token(Token = "0x200030B")]
	[StructLayout(0)]
	internal sealed class SocketAsyncResult : IOAsyncResult
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0000622D File Offset: 0x0000442D
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

		// Token: 0x0600122C RID: 4652 RVA: 0x00006230 File Offset: 0x00004430
		[global::Cpp2ILInjected.Token(Token = "0x6001465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35A40", Offset = "0x1E35A40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		public SocketAsyncResult()
		{
			throw null;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00006233 File Offset: 0x00004433
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

		// Token: 0x0600122E RID: 4654 RVA: 0x00006236 File Offset: 0x00004436
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00006239 File Offset: 0x00004439
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

		// Token: 0x06001230 RID: 4656 RVA: 0x0000623C File Offset: 0x0000443C
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

		// Token: 0x06001231 RID: 4657 RVA: 0x0000623F File Offset: 0x0000443F
		[global::Cpp2ILInjected.Token(Token = "0x600146A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35F50", Offset = "0x1E35F50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		internal override void CompleteDisposed()
		{
			throw null;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00006242 File Offset: 0x00004442
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

		// Token: 0x06001233 RID: 4659 RVA: 0x00006245 File Offset: 0x00004445
		[global::Cpp2ILInjected.Token(Token = "0x600146C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35F54", Offset = "0x1E35F54", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(bool synch)
		{
			throw null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00006248 File Offset: 0x00004448
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

		// Token: 0x06001235 RID: 4661 RVA: 0x0000624B File Offset: 0x0000444B
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

		// Token: 0x06001236 RID: 4662 RVA: 0x0000624E File Offset: 0x0000444E
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

		// Token: 0x06001237 RID: 4663 RVA: 0x00006251 File Offset: 0x00004451
		[global::Cpp2ILInjected.Token(Token = "0x6001470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E30BB4", Offset = "0x1E30BB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Socket s)
		{
			throw null;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00006254 File Offset: 0x00004454
		[global::Cpp2ILInjected.Token(Token = "0x6001471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E30DB0", Offset = "0x1E30DB0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Socket s, int total)
		{
			throw null;
		}

		// Token: 0x04000CFE RID: 3326
		[global::Cpp2ILInjected.Token(Token = "0x40010F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Socket socket;

		// Token: 0x04000CFF RID: 3327
		[global::Cpp2ILInjected.Token(Token = "0x40010F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public SocketOperation operation;

		// Token: 0x04000D00 RID: 3328
		[global::Cpp2ILInjected.Token(Token = "0x40010F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Exception DelayedException;

		// Token: 0x04000D01 RID: 3329
		[global::Cpp2ILInjected.Token(Token = "0x40010FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public EndPoint EndPoint;

		// Token: 0x04000D02 RID: 3330
		[global::Cpp2ILInjected.Token(Token = "0x40010FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public Memory<byte> Buffer;

		// Token: 0x04000D03 RID: 3331
		[global::Cpp2ILInjected.Token(Token = "0x40010FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int Offset;

		// Token: 0x04000D04 RID: 3332
		[global::Cpp2ILInjected.Token(Token = "0x40010FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public int Size;

		// Token: 0x04000D05 RID: 3333
		[global::Cpp2ILInjected.Token(Token = "0x40010FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public SocketFlags SockFlags;

		// Token: 0x04000D06 RID: 3334
		[global::Cpp2ILInjected.Token(Token = "0x40010FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Socket AcceptSocket;

		// Token: 0x04000D07 RID: 3335
		[global::Cpp2ILInjected.Token(Token = "0x4001100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public IPAddress[] Addresses;

		// Token: 0x04000D08 RID: 3336
		[global::Cpp2ILInjected.Token(Token = "0x4001101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public int Port;

		// Token: 0x04000D09 RID: 3337
		[global::Cpp2ILInjected.Token(Token = "0x4001102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public IList<ArraySegment<byte>> Buffers;

		// Token: 0x04000D0A RID: 3338
		[global::Cpp2ILInjected.Token(Token = "0x4001103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public bool ReuseSocket;

		// Token: 0x04000D0B RID: 3339
		[global::Cpp2ILInjected.Token(Token = "0x4001104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public int CurrentAddress;

		// Token: 0x04000D0C RID: 3340
		[global::Cpp2ILInjected.Token(Token = "0x4001105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public Socket AcceptedSocket;

		// Token: 0x04000D0D RID: 3341
		[global::Cpp2ILInjected.Token(Token = "0x4001106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int Total;

		// Token: 0x04000D0E RID: 3342
		[global::Cpp2ILInjected.Token(Token = "0x4001107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		internal int error;

		// Token: 0x04000D0F RID: 3343
		[global::Cpp2ILInjected.Token(Token = "0x4001108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public int EndCalled;

		// Token: 0x02000451 RID: 1105
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200030C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001ECF RID: 7887 RVA: 0x000084EC File Offset: 0x000066EC
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

			// Token: 0x06001ED0 RID: 7888 RVA: 0x000084EF File Offset: 0x000066EF
			[global::Cpp2ILInjected.Token(Token = "0x6001473")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35FCC", Offset = "0x1E35FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001ED1 RID: 7889 RVA: 0x000084F2 File Offset: 0x000066F2
			[global::Cpp2ILInjected.Token(Token = "0x6001474")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E35FD4", Offset = "0x1E35FD4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <Complete>b__27_0(object state)
			{
				throw null;
			}

			// Token: 0x0400137D RID: 4989
			[global::Cpp2ILInjected.Token(Token = "0x4001109")]
			public static readonly SocketAsyncResult.<>c <>9;

			// Token: 0x0400137E RID: 4990
			[global::Cpp2ILInjected.Token(Token = "0x400110A")]
			public static WaitCallback <>9__27_0;
		}
	}
}
