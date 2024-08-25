using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003EC")]
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E777B8", Offset = "0x1E777B8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000627")]
		public object Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ADB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E777F0", Offset = "0x1E777F0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000628")]
		public new object UserState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ADC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7780C", Offset = "0x1E7780C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400134E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object result;
	}
}
