﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004F4")]
	[global::System.Serializable]
	public sealed class TargetParameterCountException : global::System.ApplicationException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60024D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86988", Offset = "0x1B86988", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new object[]
		{
			typeof(Binder),
			typeof(object[]),
			typeof(ParameterInfo[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TargetParameterCountException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B869E4", Offset = "0x1B869E4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public TargetParameterCountException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86A08", Offset = "0x1B86A08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal TargetParameterCountException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
