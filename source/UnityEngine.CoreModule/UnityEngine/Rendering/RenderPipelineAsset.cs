using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F4 RID: 244
	[global::Cpp2ILInjected.Token(Token = "0x2000114")]
	public abstract class RenderPipelineAsset : ScriptableObject
	{
		// Token: 0x06000558 RID: 1368 RVA: 0x00002BF0 File Offset: 0x00000DF0
		[global::Cpp2ILInjected.Token(Token = "0x6000587")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B1B8", Offset = "0x1F8B1B8", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "PrepareRenderPipeline", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal RenderPipeline InternalCreatePipeline()
		{
			throw null;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00002BF3 File Offset: 0x00000DF3
		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		public virtual string[] renderingLayerMaskNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000588")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7CC", Offset = "0x1F8B7CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00002BF6 File Offset: 0x00000DF6
		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		public virtual string[] prefixedRenderingLayerMaskNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000589")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7D4", Offset = "0x1F8B7D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00002BF9 File Offset: 0x00000DF9
		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		public virtual Material defaultMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7DC", Offset = "0x1F8B7DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00002BFC File Offset: 0x00000DFC
		[global::Cpp2ILInjected.Token(Token = "0x17000128")]
		public virtual Shader autodeskInteractiveShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7E4", Offset = "0x1F8B7E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00002BFF File Offset: 0x00000DFF
		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public virtual Shader autodeskInteractiveTransparentShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7EC", Offset = "0x1F8B7EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00002C02 File Offset: 0x00000E02
		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		public virtual Shader autodeskInteractiveMaskedShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7F4", Offset = "0x1F8B7F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00002C05 File Offset: 0x00000E05
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		public virtual Shader terrainDetailLitShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B7FC", Offset = "0x1F8B7FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00002C08 File Offset: 0x00000E08
		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public virtual Shader terrainDetailGrassShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B804", Offset = "0x1F8B804", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00002C0B File Offset: 0x00000E0B
		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public virtual Shader terrainDetailGrassBillboardShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000590")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B80C", Offset = "0x1F8B80C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00002C0E File Offset: 0x00000E0E
		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public virtual Material defaultParticleMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000591")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B814", Offset = "0x1F8B814", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00002C11 File Offset: 0x00000E11
		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public virtual Material defaultLineMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000592")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B81C", Offset = "0x1F8B81C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00002C14 File Offset: 0x00000E14
		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public virtual Material defaultTerrainMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000593")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B824", Offset = "0x1F8B824", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00002C17 File Offset: 0x00000E17
		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		public virtual Material defaultUIMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000594")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B82C", Offset = "0x1F8B82C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00002C1A File Offset: 0x00000E1A
		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public virtual Material defaultUIOverdrawMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000595")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B834", Offset = "0x1F8B834", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00002C1D File Offset: 0x00000E1D
		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		public virtual Material defaultUIETC1SupportedMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000596")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B83C", Offset = "0x1F8B83C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00002C20 File Offset: 0x00000E20
		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public virtual Material default2DMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000597")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B844", Offset = "0x1F8B844", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00002C23 File Offset: 0x00000E23
		[global::Cpp2ILInjected.Token(Token = "0x17000135")]
		public virtual Material default2DMaskMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000598")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B84C", Offset = "0x1F8B84C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00002C26 File Offset: 0x00000E26
		[global::Cpp2ILInjected.Token(Token = "0x17000136")]
		public virtual Shader defaultShader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000599")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B854", Offset = "0x1F8B854", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00002C29 File Offset: 0x00000E29
		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		public virtual Shader defaultSpeedTree7Shader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B85C", Offset = "0x1F8B85C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00002C2C File Offset: 0x00000E2C
		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public virtual Shader defaultSpeedTree8Shader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8B864", Offset = "0x1F8B864", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600056D RID: 1389
		[global::Cpp2ILInjected.Token(Token = "0x600059C")]
		protected abstract RenderPipeline CreatePipeline();

		// Token: 0x0600056E RID: 1390 RVA: 0x00002C2F File Offset: 0x00000E2F
		[global::Cpp2ILInjected.Token(Token = "0x600059D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B86C", Offset = "0x1F8B86C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "PrepareRenderPipeline", MemberParameters = new object[] { typeof(RenderPipelineAsset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002C32 File Offset: 0x00000E32
		[global::Cpp2ILInjected.Token(Token = "0x600059E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B928", Offset = "0x1F8B928", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002C35 File Offset: 0x00000E35
		[global::Cpp2ILInjected.Token(Token = "0x600059F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B974", Offset = "0x1F8B974", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
		protected RenderPipelineAsset()
		{
			throw null;
		}
	}
}
