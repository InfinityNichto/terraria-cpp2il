using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000069 RID: 105
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000082")]
	public class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00002DC5 File Offset: 0x00000FC5
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00002DC8 File Offset: 0x00000FC8
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public ObjectConstructor<object> ISerializableCreator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3194", Offset = "0x1CE3194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE319C", Offset = "0x1CE319C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002DCB File Offset: 0x00000FCB
		[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE31A4", Offset = "0x1CE31A4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		public JsonISerializableContract(Type underlyingType)
		{
			throw null;
		}

		// Token: 0x040001D8 RID: 472
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private ObjectConstructor<object> <ISerializableCreator>k__BackingField;
	}
}
