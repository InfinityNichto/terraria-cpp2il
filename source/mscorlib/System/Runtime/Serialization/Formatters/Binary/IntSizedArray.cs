﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000426")]
	[global::System.Serializable]
	internal sealed class IntSizedArray : global::System.ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600212F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B686D0", Offset = "0x1B686D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IntSizedArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F05C", Offset = "0x1B6F05C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IntSizedArray), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private IntSizedArray(IntSizedArray sizedArray)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002131")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F120", Offset = "0x1B6F120", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntSizedArray), Member = ".ctor", MemberParameters = new object[] { typeof(IntSizedArray) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000452")]
		internal int this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002132")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B68738", Offset = "0x1B68738", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002133")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B68788", Offset = "0x1B68788", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntSizedArray), Member = "IncreaseCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F178", Offset = "0x1B6F178", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IntSizedArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal void IncreaseCapacity(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int[] objects;

		[global::Cpp2ILInjected.Token(Token = "0x40011B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] negObjects;
	}
}
