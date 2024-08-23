using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A2 RID: 162
	[global::Cpp2ILInjected.Token(Token = "0x20000D2")]
	[global::System.Serializable]
	public class InvalidOperationException : global::System.SystemException
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x00015A37 File Offset: 0x00013C37
		[global::Cpp2ILInjected.Token(Token = "0x60007D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35358", Offset = "0x1C35358", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 44)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InvalidOperationException()
		{
			throw null;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00015A3A File Offset: 0x00013C3A
		[global::Cpp2ILInjected.Token(Token = "0x60007D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C353B4", Offset = "0x1C353B4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 508)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidOperationException(string message)
		{
			throw null;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00015A3D File Offset: 0x00013C3D
		[global::Cpp2ILInjected.Token(Token = "0x60007D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C353D8", Offset = "0x1C353D8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Array.SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Array.SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.HMAC), Member = "GetHashAlgorithmWithFipsFallback", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.Security.Cryptography.HashAlgorithm>),
			typeof(global::System.Func<global::System.Security.Cryptography.HashAlgorithm>)
		}, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FileBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Resources.ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(global::System.Resources.ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ArraySortHelper<>), Member = "Sort", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ArraySortHelper<>), Member = "BinarySearch", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			"T",
			"System.Collections.Generic.IComparer`1<T>"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ArraySortHelper<>), Member = "Sort", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			"System.Comparison`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ArraySortHelper<, >), Member = "Sort", MemberParameters = new object[]
		{
			"TKey[]",
			"TValue[]",
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<TKey>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ExceptionHelper", Member = "get_TimeoutException", ReturnType = "System.Net.WebException")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Exception),
			"System.Net.WebExceptionStatus",
			"System.Net.WebResponse"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Exception),
			"System.Net.WebExceptionStatus",
			"System.Net.WebResponse",
			"System.Net.WebExceptionInternalStatus"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public InvalidOperationException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00015A40 File Offset: 0x00013C40
		[global::Cpp2ILInjected.Token(Token = "0x60007D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C353FC", Offset = "0x1C353FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ProtocolViolationException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected InvalidOperationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
