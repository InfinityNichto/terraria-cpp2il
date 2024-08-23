using System;
using System.IO;
using System.IO.Enumeration;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x020003B4 RID: 948
	[global::Cpp2ILInjected.Token(Token = "0x2000461")]
	public abstract class CriticalFinalizerObject
	{
		// Token: 0x06001FA6 RID: 8102 RVA: 0x00019DA2 File Offset: 0x00017FA2
		[global::Cpp2ILInjected.Token(Token = "0x60021EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B704D0", Offset = "0x1B704D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Func<object, bool>),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Threading.ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Threading.ParameterizedThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Threading.ParameterizedThreadStart),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.InternalThread), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CriticalFinalizerObject()
		{
			throw null;
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00019DA5 File Offset: 0x00017FA5
		[global::Cpp2ILInjected.Token(Token = "0x60021F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72EA4", Offset = "0x1B72EA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.InternalThread), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}
	}
}
