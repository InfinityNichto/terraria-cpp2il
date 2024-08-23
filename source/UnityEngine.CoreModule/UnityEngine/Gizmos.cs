using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000C7 RID: 199
	[StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D9")]
	public sealed class Gizmos
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x000029D7 File Offset: 0x00000BD7
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x6000474")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F841B4", Offset = "0x1F841B4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawCircleGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawOvalGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DrawLine(Vector3 from, Vector3 to)
		{
			throw null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000029DA File Offset: 0x00000BDA
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84248", Offset = "0x1F84248", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DrawSphere(Vector3 center, float radius)
		{
			throw null;
		}

		// Token: 0x170000E0 RID: 224
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x000029DD File Offset: 0x00000BDD
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		public static Color color
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000476")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F842E8", Offset = "0x1F842E8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawCircleGizmo", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawOvalGizmo", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnDrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000463 RID: 1123
		[global::Cpp2ILInjected.Token(Token = "0x6000477")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84204", Offset = "0x1F84204", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void DrawLine_Injected(ref Vector3 from, ref Vector3 to);

		// Token: 0x06000464 RID: 1124
		[global::Cpp2ILInjected.Token(Token = "0x6000478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8429C", Offset = "0x1F8429C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void DrawSphere_Injected(ref Vector3 center, float radius);

		// Token: 0x06000465 RID: 1125
		[global::Cpp2ILInjected.Token(Token = "0x6000479")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8432C", Offset = "0x1F8432C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void set_color_Injected(ref Color value);
	}
}
