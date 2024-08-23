using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000041 RID: 65
	[global::Cpp2ILInjected.Token(Token = "0x2000083")]
	public interface IMeshModifier
	{
		// Token: 0x060004AB RID: 1195
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		[global::Cpp2ILInjected.Token(Token = "0x600052C")]
		void ModifyMesh(Mesh mesh);

		// Token: 0x060004AC RID: 1196
		[global::Cpp2ILInjected.Token(Token = "0x600052D")]
		void ModifyMesh(VertexHelper verts);
	}
}
