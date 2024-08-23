using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000033 RID: 51
	[DefaultMember("Item")]
	[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000036")]
	[StructLayout(0)]
	public class AnimationCurve : IEquatable<AnimationCurve>
	{
		// Token: 0x06000047 RID: 71
		[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AA94", Offset = "0x1F6AA94", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x06000048 RID: 72
		[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AAD0", Offset = "0x1F6AAD0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create(Keyframe[] keys);

		// Token: 0x06000049 RID: 73
		[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AB0C", Offset = "0x1F6AB0C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern bool Internal_Equals(IntPtr other);

		// Token: 0x0600004A RID: 74 RVA: 0x000020F2 File Offset: 0x000002F2
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AB50", Offset = "0x1F6AB50", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AC0C", Offset = "0x1F6AC0C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern float Evaluate(float time);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public Keyframe[] keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000054")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AC58", Offset = "0x1F6AC58", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldOperationProgress", Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetMaxResolution", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public extern int length
		{
			[NativeMethod("GetKeyCount", IsThreadSafe = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000055")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6ACD0", Offset = "0x1F6ACD0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldOperationProgress", Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600004E RID: 78
		[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AC94", Offset = "0x1F6AC94", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Keyframe[] GetKeys();

		// Token: 0x0600004F RID: 79 RVA: 0x000020F8 File Offset: 0x000002F8
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AD0C", Offset = "0x1F6AD0C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchStickControl", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new object[] { typeof(Keyframe[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AE08", Offset = "0x1F6AE08", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadFields", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnimationCurve), Member = "Linear", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(AnimationCurve))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AnimationCurve(params Keyframe[] keys)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000020FE File Offset: 0x000002FE
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AE58", Offset = "0x1F6AE58", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Settings", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUnityRunner", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AnimationCurve()
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002101 File Offset: 0x00000301
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AEA4", Offset = "0x1F6AEA4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002104 File Offset: 0x00000304
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AF6C", Offset = "0x1F6AF6C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(AnimationCurve other)
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002107 File Offset: 0x00000307
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B034", Offset = "0x1F6B034", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
