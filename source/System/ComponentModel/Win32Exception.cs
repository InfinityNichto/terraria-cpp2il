using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.ComponentModel
{
	// Token: 0x020002EF RID: 751
	[global::Cpp2ILInjected.Token(Token = "0x2000400")]
	[Serializable]
	public class Win32Exception : ExternalException, ISerializable
	{
		// Token: 0x060018FD RID: 6397 RVA: 0x00007481 File Offset: 0x00005681
		[global::Cpp2ILInjected.Token(Token = "0x6001BD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E899A8", Offset = "0x1E899A8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "set_PriorityClass", MemberParameters = new object[] { typeof(ProcessPriorityClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Win32Exception()
		{
			throw null;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00007484 File Offset: 0x00005684
		[global::Cpp2ILInjected.Token(Token = "0x6001BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E89A1C", Offset = "0x1E89A1C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkInformationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_5", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_7", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_14", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public Win32Exception(int error)
		{
			throw null;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00007487 File Offset: 0x00005687
		[global::Cpp2ILInjected.Token(Token = "0x6001BD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A348", Offset = "0x1E8A348", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "CreateExceptionFromError", MemberParameters = new object[] { typeof(SecurityStatusPal) }, ReturnType = typeof(Win32Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "AcquireCredentialsHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(NetworkCredential)
		}, ReturnType = typeof(SafeFreeCredentials))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public Win32Exception(int error, string message)
		{
			throw null;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0000748A File Offset: 0x0000568A
		[global::Cpp2ILInjected.Token(Token = "0x6001BD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A374", Offset = "0x1E8A374", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Win32Exception(string message)
		{
			throw null;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0000748D File Offset: 0x0000568D
		[global::Cpp2ILInjected.Token(Token = "0x6001BD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A3F0", Offset = "0x1E8A3F0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Win32Exception(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00007490 File Offset: 0x00005690
		[global::Cpp2ILInjected.Token(Token = "0x6001BDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A470", Offset = "0x1E8A470", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkInformationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected Win32Exception(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00007493 File Offset: 0x00005693
		[global::Cpp2ILInjected.Token(Token = "0x17000637")]
		public int NativeErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8A4F8", Offset = "0x1E8A4F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00007496 File Offset: 0x00005696
		[global::Cpp2ILInjected.Token(Token = "0x6001BDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A500", Offset = "0x1E8A500", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00007499 File Offset: 0x00005699
		[global::Cpp2ILInjected.Token(Token = "0x6001BDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E89A54", Offset = "0x1E89A54", Length = "0x8F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 86)]
		internal static string GetErrorMessage(int error)
		{
			throw null;
		}

		// Token: 0x04000F38 RID: 3896
		[global::Cpp2ILInjected.Token(Token = "0x4001378")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private readonly int nativeErrorCode;
	}
}
