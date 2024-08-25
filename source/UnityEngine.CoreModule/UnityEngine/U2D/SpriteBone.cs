using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	[Serializable]
	public struct SpriteBone
	{
		[NativeName("name")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_Name;

		[SerializeField]
		[NativeName("guid")]
		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private string m_Guid;

		[NativeName("position")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Vector3 m_Position;

		[SerializeField]
		[NativeName("rotation")]
		[global::Cpp2ILInjected.Token(Token = "0x4000403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Quaternion m_Rotation;

		[NativeName("length")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000404")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float m_Length;

		[NativeName("parentId")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000405")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int m_ParentId;

		[SerializeField]
		[NativeName("color")]
		[global::Cpp2ILInjected.Token(Token = "0x4000406")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Color32 m_Color;
	}
}
