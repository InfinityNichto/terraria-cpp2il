using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Sockets
{
	// Token: 0x0200021A RID: 538
	[global::Cpp2ILInjected.Token(Token = "0x2000309")]
	internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x000061C4 File Offset: 0x000043C4
		[global::Cpp2ILInjected.Token(Token = "0x6001441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34E18", Offset = "0x1E34E18", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SafeSocketHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandleMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
		{
			throw null;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000061C7 File Offset: 0x000043C7
		[global::Cpp2ILInjected.Token(Token = "0x6001442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34EDC", Offset = "0x1E34EDC", Length = "0x578")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Blocking_icall", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Shutdown_icall", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(SocketShutdown),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "cancel_blocking_socket_operation", MemberParameters = new object[] { typeof(Thread) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close_icall", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		protected override bool ReleaseHandle()
		{
			throw null;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000061CA File Offset: 0x000043CA
		[global::Cpp2ILInjected.Token(Token = "0x6001443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35454", Offset = "0x1E35454", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SafeSocketHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(Socket.WSABUF*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveFrom_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(Socket.WSABUF*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendTo_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe void RegisterForBlockingSyscall()
		{
			throw null;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000061CD File Offset: 0x000043CD
		[global::Cpp2ILInjected.Token(Token = "0x6001444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35594", Offset = "0x1E35594", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SafeSocketHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(Socket.WSABUF*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveFrom_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(Socket.WSABUF*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendTo_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public unsafe void UnRegisterForBlockingSyscall()
		{
			throw null;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000061D0 File Offset: 0x000043D0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E35754", Offset = "0x1E35754", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SafeSocketHandle()
		{
			throw null;
		}

		// Token: 0x04000CE8 RID: 3304
		[global::Cpp2ILInjected.Token(Token = "0x40010E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Thread> blocking_threads;

		// Token: 0x04000CE9 RID: 3305
		[global::Cpp2ILInjected.Token(Token = "0x40010E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<Thread, StackTrace> threads_stacktraces;

		// Token: 0x04000CEA RID: 3306
		[global::Cpp2ILInjected.Token(Token = "0x40010E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool in_cleanup;

		// Token: 0x04000CEB RID: 3307
		[global::Cpp2ILInjected.Token(Token = "0x40010E4")]
		private static bool THROW_ON_ABORT_RETRIES;
	}
}
