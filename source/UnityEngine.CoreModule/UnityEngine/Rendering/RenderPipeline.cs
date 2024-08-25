using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	public abstract class RenderPipeline
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005A0")]
		protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

		[global::Cpp2ILInjected.Token(Token = "0x60005A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B97C", Offset = "0x1F8B97C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B980", Offset = "0x1F8B980", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B040", Offset = "0x1F8B040", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new object[]
		{
			typeof(RenderPipelineAsset),
			typeof(IntPtr),
			typeof(List<Camera.RenderRequest>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B0C0", Offset = "0x1F8B0C0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new object[]
		{
			typeof(RenderPipelineAsset),
			typeof(IntPtr),
			typeof(List<Camera.RenderRequest>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void InternalRenderWithRequests(ScriptableRenderContext context, List<Camera> cameras, List<Camera.RenderRequest> renderRequests)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public bool disposed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B9F0", Offset = "0x1F8B9F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B9F8", Offset = "0x1F8B9F8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AAD8", Offset = "0x1F8AAD8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BA04", Offset = "0x1F8BA04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000491")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <disposed>k__BackingField;
	}
}
