using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Buffers
{
	// Token: 0x02000545 RID: 1349
	[global::Cpp2ILInjected.Token(Token = "0x2000664")]
	public struct MemoryHandle : global::System.IDisposable
	{
		// Token: 0x06002D38 RID: 11576 RVA: 0x0001C2F2 File Offset: 0x0001A4F2
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15808", Offset = "0x1C15808", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Memory<>), Member = "Pin", ReturnType = typeof(MemoryHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public unsafe MemoryHandle(void* pointer, global::System.Runtime.InteropServices.GCHandle handle = default(global::System.Runtime.InteropServices.GCHandle), IPinnable pinnable = null)
		{
			throw null;
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x0001C2F5 File Offset: 0x0001A4F5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170007FB")]
		public unsafe void* Pointer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60031CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C15814", Offset = "0x1C15814", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0001C2F8 File Offset: 0x0001A4F8
		[global::Cpp2ILInjected.Token(Token = "0x60031CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1581C", Offset = "0x1C1581C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_11", MemberParameters = new object[] { "System.IOAsyncResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.Sockets.SocketError&"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveFrom", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.EndPoint&",
			"System.Net.Sockets.SocketError&"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendCallback", MemberParameters = new object[]
		{
			"System.Net.Sockets.SocketAsyncResult",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400163C RID: 5692
		[global::Cpp2ILInjected.Token(Token = "0x4001AAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe void* _pointer;

		// Token: 0x0400163D RID: 5693
		[global::Cpp2ILInjected.Token(Token = "0x4001AB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.Runtime.InteropServices.GCHandle _handle;

		// Token: 0x0400163E RID: 5694
		[global::Cpp2ILInjected.Token(Token = "0x4001AB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IPinnable _pinnable;
	}
}
