﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200065E")]
	[global::System.Serializable]
	internal sealed class InternalStringComparer : EqualityComparer<string>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C153E0", Offset = "0x1C153E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode(string obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15400", Offset = "0x1C15400", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		public override bool Equals(string x, string y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15430", Offset = "0x1C15430", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		internal override int IndexOf(string[] array, string value, int startIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1549C", Offset = "0x1C1549C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EqualityComparer<>), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EqualityComparer<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InternalStringComparer()
		{
			throw null;
		}
	}
}
