using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000124")]
	[Serializable]
	public struct Scene
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public int handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8CF74", Offset = "0x1F8CF74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CF7C", Offset = "0x1F8CF7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CF84", Offset = "0x1F8CF84", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		[SerializeField]
		[HideInInspector]
		[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_Handle;
	}
}
