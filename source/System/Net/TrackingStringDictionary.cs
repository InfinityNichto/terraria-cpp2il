﻿using System;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200013A")]
	internal sealed class TrackingStringDictionary : StringDictionary
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000776")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7DCC", Offset = "0x1EE7DCC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = ".ctor", ReturnType = typeof(void))]
		internal TrackingStringDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000777")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7DE8", Offset = "0x1EE7DE8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = ".ctor", ReturnType = typeof(void))]
		internal TrackingStringDictionary(bool isReadOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
		internal bool IsChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000778")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7E10", Offset = "0x1EE7E10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000779")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7E18", Offset = "0x1EE7E18", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600077A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7E24", Offset = "0x1EE7E24", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Add(string key, string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600077B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7E94", Offset = "0x1EE7E94", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600077C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7F04", Offset = "0x1EE7F04", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Remove(string key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
		public override string this[string key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600077D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7F74", Offset = "0x1EE7F74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600077E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7F7C", Offset = "0x1EE7F7C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40005ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool _isReadOnly;

		[global::Cpp2ILInjected.Token(Token = "0x40005EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool _isChanged;
	}
}
