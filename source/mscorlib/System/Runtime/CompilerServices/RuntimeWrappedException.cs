using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003CD RID: 973
	[global::Cpp2ILInjected.Token(Token = "0x200047D")]
	[global::System.Serializable]
	public sealed class RuntimeWrappedException : global::System.Exception
	{
		// Token: 0x06001FCC RID: 8140 RVA: 0x00019E05 File Offset: 0x00018005
		[global::Cpp2ILInjected.Token(Token = "0x6002223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B735FC", Offset = "0x1B735FC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public RuntimeWrappedException(object thrownObject)
		{
			throw null;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00019E08 File Offset: 0x00018008
		[global::Cpp2ILInjected.Token(Token = "0x6002224")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7368C", Offset = "0x1B7368C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private RuntimeWrappedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00019E0B File Offset: 0x0001800B
		[global::Cpp2ILInjected.Token(Token = "0x6002225")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73784", Offset = "0x1B73784", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00019E0E File Offset: 0x0001800E
		[global::Cpp2ILInjected.Token(Token = "0x6002226")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73858", Offset = "0x1B73858", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RuntimeWrappedException()
		{
			throw null;
		}

		// Token: 0x04000FBA RID: 4026
		[global::Cpp2ILInjected.Token(Token = "0x40012B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private object _wrappedException;
	}
}
