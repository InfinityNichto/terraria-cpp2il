using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200017D")]
	public class DownloadDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60009F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F007C8", Offset = "0x1F007C8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal DownloadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0720C", Offset = "0x1F0720C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F087B0", Offset = "0x1F087B0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DownloadDataCompletedEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400079D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
