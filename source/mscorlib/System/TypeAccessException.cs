﻿using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000111")]
	[global::System.Serializable]
	public class TypeAccessException : global::System.TypeLoadException
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50354", Offset = "0x1C50354", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MissingMetadataException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TypeAccessException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C503B0", Offset = "0x1C503B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected TypeAccessException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
