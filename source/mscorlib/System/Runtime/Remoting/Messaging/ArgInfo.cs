using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x2000399")]
	internal class ArgInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001DA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44744", Offset = "0x1B44744", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnMessage), Member = "get_OutArgs", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ArgInfo(global::System.Reflection.MethodBase method, ArgInfoType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44898", Offset = "0x1B44898", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnMessage), Member = "get_OutArgs", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public object[] GetInOutArgs(object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int[] _paramMap;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _inoutArgCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000EF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Reflection.MethodBase _method;
	}
}
