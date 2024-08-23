using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000052 RID: 82
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	public sealed class QualitySettings : Object
	{
		// Token: 0x17000042 RID: 66
		// (set) Token: 0x06000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public static extern int vSyncCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73B9C", Offset = "0x1F73B9C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public static extern ColorSpace activeColorSpace
		{
			[NativeName("GetColorSpace")]
			[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
			[global::Cpp2ILInjected.Token(Token = "0x600017F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73BD8", Offset = "0x1F73BD8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
			{
				typeof(RenderTextureFormat),
				typeof(RenderTextureReadWrite)
			}, ReturnType = typeof(GraphicsFormat))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}
	}
}
