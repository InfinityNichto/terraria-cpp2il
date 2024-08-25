using System;
using System.Collections;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x2000393")]
	internal class IllogicalCallContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700038E")]
		private global::System.Collections.Hashtable Datastore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B435A8", Offset = "0x1B435A8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IllogicalCallContext), Member = "FreeNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IllogicalCallContext), Member = "CreateCopy", ReturnType = typeof(IllogicalCallContext))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038F")]
		internal object HostContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4360C", Offset = "0x1B4360C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001D8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B43614", Offset = "0x1B43614", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000390")]
		internal bool HasUserData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4361C", Offset = "0x1B4361C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "IsDefaultFTContext", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B434F8", Offset = "0x1B434F8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IllogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void FreeNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43648", Offset = "0x1B43648", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IllogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public IllogicalCallContext CreateCopy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43888", Offset = "0x1B43888", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_IllogicalCallContext", ReturnType = typeof(IllogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IllogicalCallContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.Hashtable m_Datastore;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_HostContext;
	}
}
