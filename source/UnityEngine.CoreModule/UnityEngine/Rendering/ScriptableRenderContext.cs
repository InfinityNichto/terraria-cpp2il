using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
	[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000116")]
	public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AFAC", Offset = "0x1F8AFAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal ScriptableRenderContext(IntPtr ptr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AFB4", Offset = "0x1F8AFB4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new object[]
		{
			typeof(RenderPipelineAsset),
			typeof(IntPtr),
			typeof(List<Camera.RenderRequest>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableRenderContext), Member = "GetCameras_Internal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void GetCameras(List<Camera> results)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BA94", Offset = "0x1F8BA94", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScriptableRenderContext), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(ScriptableRenderContext other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BB04", Offset = "0x1F8BB04", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableRenderContext), Member = "Equals", MemberParameters = new object[] { typeof(ScriptableRenderContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BB7C", Offset = "0x1F8BB7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BA08", Offset = "0x1F8BA08", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScriptableRenderContext), Member = "GetCameras", MemberParameters = new object[] { typeof(List<Camera>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void GetCameras_Internal(Type listType, object resultList)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60005AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BBD8", Offset = "0x1F8BBD8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ScriptableRenderContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BB84", Offset = "0x1F8BB84", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList);

		[global::Cpp2ILInjected.Token(Token = "0x4000492")]
		private static readonly ShaderTagId kRenderTypeTag;

		[global::Cpp2ILInjected.Token(Token = "0x4000493")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IntPtr m_Ptr;
	}
}
