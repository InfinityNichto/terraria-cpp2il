using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public struct SkeletonBone
	{
		// Token: 0x04000002 RID: 2
		[NativeName("m_Name")]
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000003 RID: 3
		[NativeName("m_ParentName")]
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal string parentName;

		// Token: 0x04000004 RID: 4
		[NativeName("m_Position")]
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x04000005 RID: 5
		[NativeName("m_Rotation")]
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		// Token: 0x04000006 RID: 6
		[NativeName("m_Scale")]
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector3 scale;
	}
}
