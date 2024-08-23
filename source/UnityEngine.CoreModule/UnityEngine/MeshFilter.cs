﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004F RID: 79
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000053")]
	public sealed class MeshFilter : Component
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00002335 File Offset: 0x00000535
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F737D4", Offset = "0x1F737D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DontStripMeshFilter()
		{
			throw null;
		}

		// Token: 0x1700003E RID: 62
		// (set) Token: 0x06000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public extern Mesh mesh
		{
			[NativeName("SetInstantiatedMesh")]
			[global::Cpp2ILInjected.Token(Token = "0x6000171")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F737D8", Offset = "0x1F737D8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}
	}
}