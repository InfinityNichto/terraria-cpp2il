using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000058 RID: 88
	[NativeHeader("Runtime/Graphics/ScreenManager.h")]
	[NativeHeader("Runtime/Graphics/WindowLayout.h")]
	[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public sealed class Screen
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000183 RID: 387
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		public static extern int width
		{
			[NativeMethod(Name = "GetWidth", IsThreadSafe = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73DD0", Offset = "0x1F73DD0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 47)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000184 RID: 388
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public static extern int height
		{
			[NativeMethod(Name = "GetHeight", IsThreadSafe = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600018C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73DF8", Offset = "0x1F73DF8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 50)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000185 RID: 389
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public static extern float dpi
		{
			[NativeName("GetDPI")]
			[global::Cpp2ILInjected.Token(Token = "0x600018D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73E20", Offset = "0x1F73E20", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetDeviceDPI", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004E RID: 78
		// (set) Token: 0x06000186 RID: 390
		[NativeProperty("ScreenTimeout")]
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public static extern int sleepTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73E48", Offset = "0x1F73E48", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUnityRunner", Member = "Awake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000187 RID: 391
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public static extern bool fullScreen
		{
			[NativeName("IsFullscreen")]
			[global::Cpp2ILInjected.Token(Token = "0x600018F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73E84", Offset = "0x1F73E84", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002377 File Offset: 0x00000577
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public static Rect safeArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000190")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73EAC", Offset = "0x1F73EAC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000189 RID: 393
		[global::Cpp2ILInjected.Token(Token = "0x6000191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73EF4", Offset = "0x1F73EF4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void get_safeArea_Injected(out Rect ret);
	}
}
