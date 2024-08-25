using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x20003A0")]
	internal class CADMethodReturnMessage : CADMessageBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001DD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B472F8", Offset = "0x1B472F8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CADMethodCallMessage),
			typeof(ref byte[]),
			typeof(ref CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static CADMethodReturnMessage Create(IMessage callMsg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47378", Offset = "0x1B47378", Length = "0x368")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = "Create", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(CADMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IDictionary),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "MarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "GetMethod", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "GetSignature", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(bool)
		}, ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "SaveLogicalCallContext", MemberParameters = new object[]
		{
			typeof(IMethodMessage),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal CADMethodReturnMessage(IMethodReturnMessage retMsg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B476E0", Offset = "0x1B476E0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IMethodCallMessage),
			typeof(CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001DD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47810", Offset = "0x1B47810", Length = "0x10")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47820", Offset = "0x1B47820", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		internal object GetReturnValue(global::System.Collections.ArrayList args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47830", Offset = "0x1B47830", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IMethodCallMessage),
			typeof(CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.Exception GetException(global::System.Collections.ArrayList args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003A3")]
		internal int PropertiesCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B478CC", Offset = "0x1B478CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _returnValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000F14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private CADArgHolder _exception;

		[global::Cpp2ILInjected.Token(Token = "0x4000F15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.Type[] _sig;
	}
}
