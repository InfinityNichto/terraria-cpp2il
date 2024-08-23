using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200046B RID: 1131
	[global::Cpp2ILInjected.Token(Token = "0x2000531")]
	internal static class Error
	{
		// Token: 0x0600248E RID: 9358 RVA: 0x0001AAB6 File Offset: 0x00018CB6
		[global::Cpp2ILInjected.Token(Token = "0x6002732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95B18", Offset = "0x1B95B18", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "get_Position", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "set_Position", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.Exception GetStreamIsClosed()
		{
			throw null;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0001AAB9 File Offset: 0x00018CB9
		[global::Cpp2ILInjected.Token(Token = "0x6002733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95B88", Offset = "0x1B95B88", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CompareTimeZoneFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "InternalReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.Exception GetEndOfFile()
		{
			throw null;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0001AABC File Offset: 0x00018CBC
		[global::Cpp2ILInjected.Token(Token = "0x6002734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95C00", Offset = "0x1B95C00", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "EnsureReadable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.Exception GetReadNotSupported()
		{
			throw null;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0001AABF File Offset: 0x00018CBF
		[global::Cpp2ILInjected.Token(Token = "0x6002735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95C6C", Offset = "0x1B95C6C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.Exception GetWriteNotSupported()
		{
			throw null;
		}
	}
}
