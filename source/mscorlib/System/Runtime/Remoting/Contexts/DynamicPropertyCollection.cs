using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Contexts
{
	[global::Cpp2ILInjected.Token(Token = "0x2000366")]
	internal class DynamicPropertyCollection
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000365")]
		public bool HasProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39F2C", Offset = "0x1B39F2C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Identity), Member = "get_HasServerDynamicSinks", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Identity), Member = "NotifyClientDynamicSinks", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3A188", Offset = "0x1B3A188", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "RegisterDynamicProperty", MemberParameters = new object[]
		{
			typeof(IDynamicProperty),
			typeof(global::System.ContextBoundObject),
			typeof(Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DynamicPropertyCollection), Member = "FindProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public bool RegisterDynamicProperty(IDynamicProperty prop)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3A4B8", Offset = "0x1B3A4B8", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DynamicPropertyCollection), Member = "FindProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool UnregisterDynamicProperty(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3A76C", Offset = "0x1B3A76C", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Identity), Member = "NotifyClientDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public void NotifyMessage(bool start, global::System.Runtime.Remoting.Messaging.IMessage msg, bool client_site, bool async)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C534", Offset = "0x1B3C534", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new object[] { typeof(IDynamicProperty) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DynamicPropertyCollection), Member = "UnregisterDynamicProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int FindProperty(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3A61C", Offset = "0x1B3A61C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Identity), Member = "get_ClientDynamicProperties", ReturnType = typeof(DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Context), Member = "GetDynamicPropertyCollection", MemberParameters = new object[]
		{
			typeof(global::System.ContextBoundObject),
			typeof(Context)
		}, ReturnType = typeof(DynamicPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DynamicPropertyCollection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.ArrayList _properties;

		[global::Cpp2ILInjected.Token(Token = "0x2000367")]
		private class DynamicPropertyReg
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D05")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3C69C", Offset = "0x1B3C69C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DynamicPropertyReg()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000EB1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public IDynamicProperty Property;

			[global::Cpp2ILInjected.Token(Token = "0x4000EB2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public IDynamicMessageSink Sink;
		}
	}
}
