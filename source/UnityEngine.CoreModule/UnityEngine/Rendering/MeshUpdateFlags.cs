using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	public enum MeshUpdateFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		Default = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		DontValidateIndices = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		DontResetBoneBounds = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		DontNotifyMeshUsers = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000437")]
		DontRecalculateBounds = 8
	}
}
