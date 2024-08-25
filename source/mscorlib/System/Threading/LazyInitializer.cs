using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001BB")]
	public static class LazyInitializer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x158FEAC", Offset = "0x158FEAC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "get_SerializationInfoTable", ReturnType = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static T EnsureInitialized<T>(ref T target) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x158FFB4", Offset = "0x158FFB4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static T EnsureInitializedCore<T>(ref T target) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x158FEF4", Offset = "0x158FEF4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Threading.Tasks.Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "get_AsyncActiveSemaphore", ReturnType = typeof(SemaphoreSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.SynchronousAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(SemaphoreSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadT61String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadTime", MemberParameters = new object[]
		{
			"System.Security.Cryptography.DerSequenceReader.DerTag",
			typeof(string)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			"System.Net.Sockets.SocketFlags",
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			"System.ReadOnlyMemory`1<Byte>",
			"System.Net.Sockets.SocketFlags",
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static T EnsureInitialized<T>(ref T target, global::System.Func<T> valueFactory) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15900A4", Offset = "0x15900A4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static T EnsureInitializedCore<T>(ref T target, global::System.Func<T> valueFactory) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x158FF50", Offset = "0x158FF50", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "get_ClientCertificates", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static T EnsureInitialized<T>(ref T target, ref object syncLock, global::System.Func<T> valueFactory) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x159012C", Offset = "0x159012C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureLockInitialized", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, global::System.Func<T> valueFactory) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93D80", Offset = "0x1C93D80", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T&",
			typeof(ref object),
			"System.Func`1<T>"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static object EnsureLockInitialized(ref object syncLock)
		{
			throw null;
		}
	}
}
