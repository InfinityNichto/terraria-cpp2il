using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001B4")]
	[global::System.Serializable]
	public class AbandonedMutexException : global::System.SystemException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93BCC", Offset = "0x1C93BCC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AbandonedMutexException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93C30", Offset = "0x1C93C30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WaitHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AbandonedMutexException(int location, WaitHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93D54", Offset = "0x1C93D54", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected AbandonedMutexException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93CE8", Offset = "0x1C93CE8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetupException(int location, WaitHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40008F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int _mutexIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40008F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Mutex _mutex;
	}
}
