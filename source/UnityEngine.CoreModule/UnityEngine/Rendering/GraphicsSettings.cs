using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E5 RID: 229
	[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
	[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
	[global::Cpp2ILInjected.Token(Token = "0x2000105")]
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600052A RID: 1322
		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public static extern bool lightsUseLinearIntensity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000559")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A168", Offset = "0x1F8A168", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}
	}
}
