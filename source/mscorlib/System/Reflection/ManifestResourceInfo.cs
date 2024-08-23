using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000419 RID: 1049
	[global::Cpp2ILInjected.Token(Token = "0x20004D8")]
	public class ManifestResourceInfo
	{
		// Token: 0x06002118 RID: 8472 RVA: 0x0001A195 File Offset: 0x00018395
		[global::Cpp2ILInjected.Token(Token = "0x60023B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81E58", Offset = "0x1B81E58", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
		{
			throw null;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0001A198 File Offset: 0x00018398
		[global::Cpp2ILInjected.Token(Token = "0x170004A7")]
		public virtual Assembly ReferencedAssembly
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60023B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81E94", Offset = "0x1B81E94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x0001A19B File Offset: 0x0001839B
		[global::Cpp2ILInjected.Token(Token = "0x170004A8")]
		public virtual string FileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60023B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81E9C", Offset = "0x1B81E9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x0001A19E File Offset: 0x0001839E
		[global::Cpp2ILInjected.Token(Token = "0x170004A9")]
		public virtual ResourceLocation ResourceLocation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60023B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81EA4", Offset = "0x1B81EA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04001096 RID: 4246
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40013B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Assembly <ReferencedAssembly>k__BackingField;

		// Token: 0x04001097 RID: 4247
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40013B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <FileName>k__BackingField;

		// Token: 0x04001098 RID: 4248
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40013B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ResourceLocation <ResourceLocation>k__BackingField;
	}
}
