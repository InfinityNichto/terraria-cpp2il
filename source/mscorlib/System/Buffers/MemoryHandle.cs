using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Buffers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000664")]
	public struct MemoryHandle : global::System.IDisposable
	{
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15808", Offset = "0x1C15808", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Memory<>), Member = "Pin", ReturnType = typeof(MemoryHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public unsafe MemoryHandle(void* pointer, global::System.Runtime.InteropServices.GCHandle handle = default(global::System.Runtime.InteropServices.GCHandle), IPinnable pinnable = null)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001AAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe void* _pointer;

		[global::Cpp2ILInjected.Token(Token = "0x4001AB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.Runtime.InteropServices.GCHandle _handle;

		[global::Cpp2ILInjected.Token(Token = "0x4001AB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IPinnable _pinnable;
	}
}
