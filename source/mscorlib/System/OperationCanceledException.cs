using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B8 RID: 184
	[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
	[global::System.Serializable]
	public class OperationCanceledException : global::System.SystemException
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00015CC8 File Offset: 0x00013EC8
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00015CCB File Offset: 0x00013ECB
		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		public global::System.Threading.CancellationToken CancellationToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C44088", Offset = "0x1C44088", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C44090", Offset = "0x1C44090", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00015CCE File Offset: 0x00013ECE
		[global::Cpp2ILInjected.Token(Token = "0x60008C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44098", Offset = "0x1C44098", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetCanceled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "SetCanceled", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new object[] { "System.Threading.Tasks.Task`1<IPAddress[]>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public OperationCanceledException()
		{
			throw null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00015CD1 File Offset: 0x00013ED1
		[global::Cpp2ILInjected.Token(Token = "0x60008C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44168", Offset = "0x1C44168", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskCanceledException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public OperationCanceledException(string message)
		{
			throw null;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00015CD4 File Offset: 0x00013ED4
		[global::Cpp2ILInjected.Token(Token = "0x60008C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44188", Offset = "0x1C44188", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskCanceledException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
		{
			"T",
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryTakeWithNoTimeValidation", MemberParameters = new object[]
		{
			"T&",
			typeof(int),
			typeof(global::System.Threading.CancellationToken),
			typeof(global::System.Threading.CancellationTokenSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public OperationCanceledException(string message, global::System.Threading.CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00015CD7 File Offset: 0x00013ED7
		[global::Cpp2ILInjected.Token(Token = "0x60008C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C441B8", Offset = "0x1C441B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected OperationCanceledException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0400022F RID: 559
		[global::Cpp2ILInjected.Token(Token = "0x4000381")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		[global::System.NonSerialized]
		private global::System.Threading.CancellationToken _cancellationToken;
	}
}
