using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000469 RID: 1129
	[global::Cpp2ILInjected.Token(Token = "0x200052F")]
	[global::System.Serializable]
	public class DirectoryNotFoundException : IOException
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x0001AAA4 File Offset: 0x00018CA4
		[global::Cpp2ILInjected.Token(Token = "0x600272C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B959DC", Offset = "0x1B959DC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DirectoryNotFoundException()
		{
			throw null;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0001AAA7 File Offset: 0x00018CA7
		[global::Cpp2ILInjected.Token(Token = "0x600272D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95A5C", Offset = "0x1B95A5C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MonoIOError)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public DirectoryNotFoundException(string message)
		{
			throw null;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0001AAAA File Offset: 0x00018CAA
		[global::Cpp2ILInjected.Token(Token = "0x600272E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95A80", Offset = "0x1B95A80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected DirectoryNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
