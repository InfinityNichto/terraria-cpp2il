using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000315 RID: 789
	[global::Cpp2ILInjected.Token(Token = "0x20003BB")]
	internal class ObjRefSurrogate : global::System.Runtime.Serialization.ISerializationSurrogate
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x0001944B File Offset: 0x0001764B
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

		// Token: 0x06001C5A RID: 7258 RVA: 0x0001944E File Offset: 0x0001764E
		[global::Cpp2ILInjected.Token(Token = "0x6001E93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E478", Offset = "0x1B4E478", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object SetObjectData(object obj, global::System.Runtime.Serialization.SerializationInfo si, global::System.Runtime.Serialization.StreamingContext sc, global::System.Runtime.Serialization.ISurrogateSelector selector)
		{
			throw null;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00019451 File Offset: 0x00017651
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
