using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[NativeType(CodegenOptions.Custom, "MonoHumanBone")]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public struct HumanBone
	{
		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_BoneName;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private string m_HumanName;

		// Token: 0x0400000E RID: 14
		[NativeName("m_Limit")]
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public HumanLimit limit;
	}
}
