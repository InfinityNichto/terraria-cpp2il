using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x200039F")]
	internal class CADMethodCallMessage : CADMessageBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x170003A1")]
		internal string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B46FC4", Offset = "0x1B46FC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40CFC", Offset = "0x1B40CFC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static CADMethodCallMessage Create(IMessage callMsg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B46FCC", Offset = "0x1B46FCC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodCallMessage), Member = "Create", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(CADMethodCallMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IDictionary),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "MarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "SaveLogicalCallContext", MemberParameters = new object[]
		{
			typeof(IMethodMessage),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal CADMethodCallMessage(IMethodCallMessage callMsg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B471B0", Offset = "0x1B471B0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "DeserializeObject", MemberParameters = new object[] { typeof(global::System.IO.MemoryStream) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal global::System.Collections.ArrayList GetArguments()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B472E0", Offset = "0x1B472E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		internal object[] GetArgs(global::System.Collections.ArrayList args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003A2")]
		internal int PropertiesCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B472F0", Offset = "0x1B472F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _uri;
	}
}
