using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SceneManagement
{
	[global::Cpp2ILInjected.Token(Token = "0x2000122")]
	[Serializable]
	public struct LoadSceneParameters
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C790", Offset = "0x1F8C790", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LoadSceneParameters(LoadSceneMode mode)
		{
			throw null;
		}

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private LoadSceneMode m_LoadSceneMode;

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private LocalPhysicsMode m_LocalPhysicsMode;
	}
}
