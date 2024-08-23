using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004C RID: 76
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000050")]
	public class RenderTexture : Texture
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600014A RID: 330
		// (set) Token: 0x0600014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public override extern int width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000152")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F720B0", Offset = "0x1F720B0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000153")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F720EC", Offset = "0x1F720EC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600014C RID: 332
		// (set) Token: 0x0600014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		public override extern int height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000154")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F72130", Offset = "0x1F72130", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000155")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7216C", Offset = "0x1F7216C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700003B RID: 59
		// (set) Token: 0x0600014E RID: 334
		[NativeProperty("ColorFormat")]
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public extern GraphicsFormat graphicsFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000156")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F721B0", Offset = "0x1F721B0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700003C RID: 60
		// (set) Token: 0x0600014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public extern GraphicsFormat depthStencilFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000157")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F721F4", Offset = "0x1F721F4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x06000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72238", Offset = "0x1F72238", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetMipMapCount(int count);

		// Token: 0x06000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7227C", Offset = "0x1F7227C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern void SetSRGBReadWrite(bool srgb);

		// Token: 0x06000152 RID: 338
		[FreeFunction("RenderTextureScripting::Create")]
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F722C0", Offset = "0x1F722C0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] RenderTexture rt);

		// Token: 0x06000153 RID: 339 RVA: 0x000022FC File Offset: 0x000004FC
		[NativeName("SetRenderTextureDescFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F722FC", Offset = "0x1F722FC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			throw null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000022FF File Offset: 0x000004FF
		[NativeName("GetRenderTextureDesc")]
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72384", Offset = "0x1F72384", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private RenderTextureDescriptor GetDescriptor()
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002302 File Offset: 0x00000502
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72440", Offset = "0x1F72440", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal RenderTexture()
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002305 File Offset: 0x00000505
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72494", Offset = "0x1F72494", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new object[] { typeof(RenderTextureDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RenderTexture(RenderTextureDescriptor desc)
		{
			throw null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002308 File Offset: 0x00000508
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F729E4", Offset = "0x1F729E4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new object[] { typeof(RenderTextureDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public RenderTexture(RenderTexture textureToCopy)
		{
			throw null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000230B File Offset: 0x0000050B
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72C34", Offset = "0x1F72C34", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public RenderTexture(int width, int height, int depth, DefaultFormat format)
		{
			throw null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000230E File Offset: 0x0000050E
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72CA8", Offset = "0x1F72CA8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format)
		{
			throw null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002311 File Offset: 0x00000511
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72D38", Offset = "0x1F72D38", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GraphicsFormat)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
			throw null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002314 File Offset: 0x00000514
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72FBC", Offset = "0x1F72FBC", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(GraphicsFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
			throw null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002317 File Offset: 0x00000517
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F731C0", Offset = "0x1F731C0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
			throw null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000231A File Offset: 0x0000051A
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73250", Offset = "0x1F73250", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
		{
			throw null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000231D File Offset: 0x0000051D
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F734D4", Offset = "0x1F734D4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenshotSetup", Member = "get_RenderTexture", ReturnType = typeof(RenderTexture))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		{
			throw null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002320 File Offset: 0x00000520
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73604", Offset = "0x1F73604", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat)
		}, ReturnType = typeof(void))]
		public RenderTexture(int width, int height, int depth)
		{
			throw null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002323 File Offset: 0x00000523
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73564", Offset = "0x1F73564", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
		{
			throw null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002326 File Offset: 0x00000526
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F732F8", Offset = "0x1F732F8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new object[]
		{
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GraphicsFormat)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002329 File Offset: 0x00000529
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72F38", Offset = "0x1F72F38", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
		{
			throw null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000232C File Offset: 0x0000052C
		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public RenderTextureDescriptor descriptor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F72BA4", Offset = "0x1F72BA4", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000232F File Offset: 0x0000052F
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7258C", Offset = "0x1F7258C", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTextureDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsStencilFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002332 File Offset: 0x00000532
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7360C", Offset = "0x1F7360C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72340", Offset = "0x1F72340", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc);

		// Token: 0x06000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F723FC", Offset = "0x1F723FC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetDescriptor_Injected(out RenderTextureDescriptor ret);
	}
}
