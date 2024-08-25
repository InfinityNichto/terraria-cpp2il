using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x20003BB")]
	internal class ObjRefSurrogate : global::System.Runtime.Serialization.ISerializationSurrogate
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E374", Offset = "0x1B4E374", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void GetObjectData(object obj, global::System.Runtime.Serialization.SerializationInfo si, global::System.Runtime.Serialization.StreamingContext sc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E478", Offset = "0x1B4E478", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object SetObjectData(object obj, global::System.Runtime.Serialization.SerializationInfo si, global::System.Runtime.Serialization.StreamingContext sc, global::System.Runtime.Serialization.ISurrogateSelector selector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E4C4", Offset = "0x1B4E4C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ObjRefSurrogate()
		{
			throw null;
		}
	}
}
