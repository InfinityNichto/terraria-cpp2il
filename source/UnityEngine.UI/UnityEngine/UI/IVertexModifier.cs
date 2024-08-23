using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	[Obsolete("Use IMeshModifier instead", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x2000082")]
	public interface IVertexModifier
	{
		// Token: 0x060004AA RID: 1194
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		[global::Cpp2ILInjected.Token(Token = "0x600052B")]
		void ModifyVertices(List<UIVertex> verts);
	}
}
