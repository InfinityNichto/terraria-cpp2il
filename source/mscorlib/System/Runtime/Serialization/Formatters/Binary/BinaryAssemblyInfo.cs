using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000359 RID: 857
	[global::Cpp2ILInjected.Token(Token = "0x2000401")]
	internal sealed class BinaryAssemblyInfo
	{
		// Token: 0x06001D96 RID: 7574 RVA: 0x000197C9 File Offset: 0x000179C9
		[global::Cpp2ILInjected.Token(Token = "0x6001FD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CC78", Offset = "0x1B5CC78", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryAssemblyInfo(string assemblyString)
		{
			throw null;
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000197CC File Offset: 0x000179CC
		[global::Cpp2ILInjected.Token(Token = "0x6001FD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CCA0", Offset = "0x1B5CCA0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryAssemblyInfo(string assemblyString, global::System.Reflection.Assembly assembly)
		{
			throw null;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000197CF File Offset: 0x000179CF
		[global::Cpp2ILInjected.Token(Token = "0x6001FD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CCCC", Offset = "0x1B5CCCC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "LoadAssemblyFromStringNoThrow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal global::System.Reflection.Assembly GetAssembly()
		{
			throw null;
		}

		// Token: 0x04000D6A RID: 3434
		[global::Cpp2ILInjected.Token(Token = "0x400105C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string assemblyString;

		// Token: 0x04000D6B RID: 3435
		[global::Cpp2ILInjected.Token(Token = "0x400105D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Reflection.Assembly assembly;
	}
}
