﻿using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public class DropdownList<T> : IDropdownList, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1621FB0", Offset = "0x1621FB0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropdownList<>), Member = "op_Explicit", MemberParameters = new object[] { "NaughtyAttributes.DropdownList`1<T>" }, ReturnType = typeof(DropdownList<object>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<KeyValuePair<object, object>>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropdownList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622030", Offset = "0x1622030", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropdownList<>), Member = "op_Explicit", MemberParameters = new object[] { "NaughtyAttributes.DropdownList`1<T>" }, ReturnType = typeof(DropdownList<object>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(string displayName, T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622114", Offset = "0x1622114", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<KeyValuePair<object, object>>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x162219C", Offset = "0x162219C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x16221B0", Offset = "0x16221B0", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropdownList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropdownList<>), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static explicit operator DropdownList<object>(DropdownList<T> target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private List<KeyValuePair<string, object>> values;
	}
}
