using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000374 RID: 884
	[global::Cpp2ILInjected.Token(Token = "0x200041C")]
	internal sealed class SerObjectInfoCache
	{
		// Token: 0x06001E68 RID: 7784 RVA: 0x00019A3F File Offset: 0x00017C3F
		[global::Cpp2ILInjected.Token(Token = "0x60020A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B65320", Offset = "0x1B65320", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
		{
			throw null;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00019A42 File Offset: 0x00017C42
		[global::Cpp2ILInjected.Token(Token = "0x60020A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6535C", Offset = "0x1B6535C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SerObjectInfoCache(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x04000E40 RID: 3648
		[global::Cpp2ILInjected.Token(Token = "0x4001132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string fullTypeName;

		// Token: 0x04000E41 RID: 3649
		[global::Cpp2ILInjected.Token(Token = "0x4001133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string assemblyString;

		// Token: 0x04000E42 RID: 3650
		[global::Cpp2ILInjected.Token(Token = "0x4001134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal bool hasTypeForwardedFrom;

		// Token: 0x04000E43 RID: 3651
		[global::Cpp2ILInjected.Token(Token = "0x4001135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal global::System.Reflection.MemberInfo[] memberInfos;

		// Token: 0x04000E44 RID: 3652
		[global::Cpp2ILInjected.Token(Token = "0x4001136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string[] memberNames;

		// Token: 0x04000E45 RID: 3653
		[global::Cpp2ILInjected.Token(Token = "0x4001137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal global::System.Type[] memberTypes;
	}
}
