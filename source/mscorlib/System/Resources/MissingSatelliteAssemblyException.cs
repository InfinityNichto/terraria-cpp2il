using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003ED RID: 1005
	[global::Cpp2ILInjected.Token(Token = "0x20004A7")]
	[global::System.Serializable]
	public class MissingSatelliteAssemblyException : global::System.SystemException
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x00019F76 File Offset: 0x00018176
		[global::Cpp2ILInjected.Token(Token = "0x60022C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75BC8", Offset = "0x1B75BC8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MissingSatelliteAssemblyException()
		{
			throw null;
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00019F79 File Offset: 0x00018179
		[global::Cpp2ILInjected.Token(Token = "0x60022C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75C24", Offset = "0x1B75C24", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "HandleSatelliteMissing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MissingSatelliteAssemblyException(string message, string cultureName)
		{
			throw null;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00019F7C File Offset: 0x0001817C
		[global::Cpp2ILInjected.Token(Token = "0x60022C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75C58", Offset = "0x1B75C58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected MissingSatelliteAssemblyException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x04000FE6 RID: 4070
		[global::Cpp2ILInjected.Token(Token = "0x40012F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _cultureName;
	}
}
