using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000637")]
	[global::System.Serializable]
	public class KeyNotFoundException : global::System.SystemException
	{
		[global::Cpp2ILInjected.Token(Token = "0x600309B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14F40", Offset = "0x1C14F40", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.SlotVector`1", Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.SlotVector`1", Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.SlotVector`1", Member = "get_Item", MemberParameters = new object[] { "ReLogic.Utilities.SlotId" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.SlotVector`1", Member = "set_Item", MemberParameters = new object[] { "ReLogic.Utilities.SlotId", "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Linq.JToken")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public KeyNotFoundException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600309C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14F9C", Offset = "0x1C14F9C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(KeyNotFoundException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "ThrowKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.KeyedCollection<, >), Member = "get_Item", MemberParameters = new object[] { "TKey" }, ReturnType = "TItem")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "get_Item", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.PlayerAction")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public KeyNotFoundException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600309D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14FC0", Offset = "0x1C14FC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected KeyNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
