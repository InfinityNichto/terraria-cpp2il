using System;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000118 RID: 280
	[global::Cpp2ILInjected.Token(Token = "0x200019F")]
	internal class InternalException : SystemException
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x000048CE File Offset: 0x00002ACE
		[global::Cpp2ILInjected.Token(Token = "0x6000A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E2F0", Offset = "0x1F0E2F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterlockedGate), Member = "Trigger", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterlockedGate), Member = "StartTriggering", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterlockedGate), Member = "FinishTriggering", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterlockedGate), Member = "StartSignaling", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterlockedGate), Member = "FinishSignaling", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new object[] { typeof(WebExceptionStatus) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalLog), Member = "ThreadContract", MemberParameters = new object[]
		{
			typeof(ThreadKinds),
			typeof(ThreadKinds),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
		internal InternalException()
		{
			throw null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000048D1 File Offset: 0x00002AD1
		[global::Cpp2ILInjected.Token(Token = "0x6000A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E2F8", Offset = "0x1F0E2F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		internal InternalException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
