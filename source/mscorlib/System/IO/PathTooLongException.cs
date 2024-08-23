using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000475 RID: 1141
	[global::Cpp2ILInjected.Token(Token = "0x200053B")]
	[global::System.Serializable]
	public class PathTooLongException : IOException
	{
		// Token: 0x060024DD RID: 9437 RVA: 0x0001ABA3 File Offset: 0x00018DA3
		[global::Cpp2ILInjected.Token(Token = "0x6002781")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99CD8", Offset = "0x1B99CD8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PathTooLongException()
		{
			throw null;
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0001ABA6 File Offset: 0x00018DA6
		[global::Cpp2ILInjected.Token(Token = "0x6002782")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99D34", Offset = "0x1B99D34", Length = "0x24")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MonoIOError)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public PathTooLongException(string message)
		{
			throw null;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0001ABA9 File Offset: 0x00018DA9
		[global::Cpp2ILInjected.Token(Token = "0x6002783")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99D58", Offset = "0x1B99D58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected PathTooLongException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
