using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000083")]
	public interface IMeshModifier
	{
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		[global::Cpp2ILInjected.Token(Token = "0x600052C")]
		void ModifyMesh(Mesh mesh);

		[global::Cpp2ILInjected.Token(Token = "0x600052D")]
		void ModifyMesh(VertexHelper verts);
	}
}
