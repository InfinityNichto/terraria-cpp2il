using System;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000314 RID: 788
	[global::Cpp2ILInjected.Token(Token = "0x20003BA")]
	internal class RemotingSurrogate : global::System.Runtime.Serialization.ISerializationSurrogate
	{
		// Token: 0x06001C56 RID: 7254 RVA: 0x00019442 File Offset: 0x00017642
		[global::Cpp2ILInjected.Token(Token = "0x6001E8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E22C", Offset = "0x1B4E22C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Proxies.RealProxy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual void GetObjectData(object obj, global::System.Runtime.Serialization.SerializationInfo si, global::System.Runtime.Serialization.StreamingContext sc)
		{
			throw null;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00019445 File Offset: 0x00017645
		[global::Cpp2ILInjected.Token(Token = "0x6001E90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E334", Offset = "0x1B4E334", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object SetObjectData(object obj, global::System.Runtime.Serialization.SerializationInfo si, global::System.Runtime.Serialization.StreamingContext sc, global::System.Runtime.Serialization.ISurrogateSelector selector)
		{
			throw null;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00019448 File Offset: 0x00017648
		[global::Cpp2ILInjected.Token(Token = "0x6001E91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E36C", Offset = "0x1B4E36C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RemotingSurrogate()
		{
			throw null;
		}
	}
}
