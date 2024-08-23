using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020000FF RID: 255
	[global::Cpp2ILInjected.Token(Token = "0x2000122")]
	[Serializable]
	public struct LoadSceneParameters
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x00002CB3 File Offset: 0x00000EB3
		[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C790", Offset = "0x1F8C790", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LoadSceneParameters(LoadSceneMode mode)
		{
			throw null;
		}

		// Token: 0x04000492 RID: 1170
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private LoadSceneMode m_LoadSceneMode;

		// Token: 0x04000493 RID: 1171
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private LocalPhysicsMode m_LocalPhysicsMode;
	}
}
