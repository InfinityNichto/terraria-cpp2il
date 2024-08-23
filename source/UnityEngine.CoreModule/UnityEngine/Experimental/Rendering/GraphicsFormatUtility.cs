using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000115 RID: 277
	[NativeHeader("Runtime/Graphics/Format.h")]
	[NativeHeader("Runtime/Graphics/TextureFormat.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200013A")]
	public class GraphicsFormatUtility
	{
		// Token: 0x060005D4 RID: 1492 RVA: 0x00002D52 File Offset: 0x00000F52
		[global::Cpp2ILInjected.Token(Token = "0x600060A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8ED2C", Offset = "0x1F8ED2C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			throw null;
		}

		// Token: 0x060005D5 RID: 1493
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600060B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EDB0", Offset = "0x1F8EDB0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB);

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002D55 File Offset: 0x00000F55
		[global::Cpp2ILInjected.Token(Token = "0x600060C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EDF4", Offset = "0x1F8EDF4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			throw null;
		}

		// Token: 0x060005D7 RID: 1495
		[FreeFunction]
		[global::Cpp2ILInjected.Token(Token = "0x600060D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EE78", Offset = "0x1F8EE78", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB);

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002D58 File Offset: 0x00000F58
		[global::Cpp2ILInjected.Token(Token = "0x600060E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EEBC", Offset = "0x1F8EEBC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new object[]
		{
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(RenderTextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			throw null;
		}

		// Token: 0x060005D9 RID: 1497
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600060F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EF44", Offset = "0x1F8EF44", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);

		// Token: 0x060005DA RID: 1498 RVA: 0x00002D5B File Offset: 0x00000F5B
		[global::Cpp2ILInjected.Token(Token = "0x6000610")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EF80", Offset = "0x1F8EF80", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GraphicsFormat)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
		{
			throw null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002D5E File Offset: 0x00000F5E
		[global::Cpp2ILInjected.Token(Token = "0x6000611")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8EFF4", Offset = "0x1F8EFF4", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GraphicsFormat)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
		{
			throw null;
		}

		// Token: 0x060005DC RID: 1500
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F1C4", Offset = "0x1F8F1C4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsSRGBFormat(GraphicsFormat format);

		// Token: 0x060005DD RID: 1501
		[FreeFunction("IsAnyCompressedTextureFormat", true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F200", Offset = "0x1F8F200", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool IsCompressedTextureFormat(TextureFormat format);

		// Token: 0x060005DE RID: 1502
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F23C", Offset = "0x1F8F23C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool CanDecompressFormat(GraphicsFormat format, bool wholeImage);

		// Token: 0x060005DF RID: 1503 RVA: 0x00002D61 File Offset: 0x00000F61
		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F280", Offset = "0x1F8F280", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool CanDecompressFormat(GraphicsFormat format)
		{
			throw null;
		}

		// Token: 0x060005E0 RID: 1504
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000616")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F2F8", Offset = "0x1F8F2F8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new object[] { typeof(RenderTextureDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsDepthFormat(GraphicsFormat format);

		// Token: 0x060005E1 RID: 1505
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000617")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F334", Offset = "0x1F8F334", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new object[] { typeof(RenderTextureDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsStencilFormat(GraphicsFormat format);

		// Token: 0x060005E2 RID: 1506
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000618")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F370", Offset = "0x1F8F370", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsPVRTCFormat(GraphicsFormat format);

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002D64 File Offset: 0x00000F64
		[global::Cpp2ILInjected.Token(Token = "0x6000619")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F3AC", Offset = "0x1F8F3AC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool IsCrunchFormat(TextureFormat format)
		{
			throw null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002D67 File Offset: 0x00000F67
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600061A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F3D0", Offset = "0x1F8F3D0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static GraphicsFormatUtility()
		{
			throw null;
		}

		// Token: 0x0400050F RID: 1295
		[global::Cpp2ILInjected.Token(Token = "0x400055E")]
		private static readonly GraphicsFormat[] tableNoStencil;

		// Token: 0x04000510 RID: 1296
		[global::Cpp2ILInjected.Token(Token = "0x400055F")]
		private static readonly GraphicsFormat[] tableStencil;
	}
}
