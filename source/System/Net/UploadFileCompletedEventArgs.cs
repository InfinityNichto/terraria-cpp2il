using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000180")]
	public class UploadFileCompletedEventArgs : AsyncCompletedEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60009FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0182C", Offset = "0x1F0182C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadFileCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FE")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072B0", Offset = "0x1F072B0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08858", Offset = "0x1F08858", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadFileCompletedEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40007A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
