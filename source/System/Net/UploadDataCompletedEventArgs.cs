using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200017F")]
	public class UploadDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60009F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01448", Offset = "0x1F01448", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FD")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07268", Offset = "0x1F07268", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08820", Offset = "0x1F08820", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadDataCompletedEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400079F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
