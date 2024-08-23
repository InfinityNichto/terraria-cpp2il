using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020000E0 RID: 224
	[global::Cpp2ILInjected.Token(Token = "0x2000100")]
	internal struct MovedFromAttributeData
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x00002B4B File Offset: 0x00000D4B
		[global::Cpp2ILInjected.Token(Token = "0x600054F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89EF0", Offset = "0x1F89EF0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			throw null;
		}

		// Token: 0x040003DF RID: 991
		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string className;

		// Token: 0x040003E0 RID: 992
		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string nameSpace;

		// Token: 0x040003E1 RID: 993
		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string assembly;

		// Token: 0x040003E2 RID: 994
		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool classHasChanged;

		// Token: 0x040003E3 RID: 995
		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool nameSpaceHasChanged;

		// Token: 0x040003E4 RID: 996
		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public bool assemblyHasChanged;

		// Token: 0x040003E5 RID: 997
		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
		public bool autoUdpateAPI;
	}
}
