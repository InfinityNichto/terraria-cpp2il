using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	// Token: 0x020000D5 RID: 213
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	[Serializable]
	public struct SpriteBone
	{
		// Token: 0x040003C3 RID: 963
		[NativeName("name")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_Name;

		// Token: 0x040003C4 RID: 964
		[SerializeField]
		[NativeName("guid")]
		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private string m_Guid;

		// Token: 0x040003C5 RID: 965
		[NativeName("position")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Vector3 m_Position;

		// Token: 0x040003C6 RID: 966
		[SerializeField]
		[NativeName("rotation")]
		[global::Cpp2ILInjected.Token(Token = "0x4000403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Quaternion m_Rotation;

		// Token: 0x040003C7 RID: 967
		[NativeName("length")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000404")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float m_Length;

		// Token: 0x040003C8 RID: 968
		[NativeName("parentId")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000405")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int m_ParentId;

		// Token: 0x040003C9 RID: 969
		[SerializeField]
		[NativeName("color")]
		[global::Cpp2ILInjected.Token(Token = "0x4000406")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Color32 m_Color;
	}
}
