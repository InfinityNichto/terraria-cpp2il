using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x20003B6")]
	internal class MethodReturnDictionary : MessageDictionary
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4D1A0", Offset = "0x1B4D1A0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "get_Properties", ReturnType = typeof(global::System.Collections.IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnMessage), Member = "get_Properties", ReturnType = typeof(global::System.Collections.IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public MethodReturnDictionary(IMethodReturnMessage message)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001E74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4D834", Offset = "0x1B4D834", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		static MethodReturnDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F49")]
		public static string[] InternalReturnKeys;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4A")]
		public static string[] InternalExceptionKeys;
	}
}
