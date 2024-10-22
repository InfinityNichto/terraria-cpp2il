﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/Texture.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200004A")]
	public class Texture : Object
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F250", Offset = "0x1F6F250", Length = "0x58")]
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
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
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
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
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
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
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
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTextureDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat),
			typeof(RenderTextureReadWrite)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Texture()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F2A8", Offset = "0x1F6F2A8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern int GetDataWidth();

		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F2E4", Offset = "0x1F6F2E4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern int GetDataHeight();

		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public virtual int width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000100")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F320", Offset = "0x1F6F320", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000101")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F35C", Offset = "0x1F6F35C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public virtual int height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000102")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F394", Offset = "0x1F6F394", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000103")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F3D0", Offset = "0x1F6F3D0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public virtual extern bool isReadable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000104")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F408", Offset = "0x1F6F408", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public extern TextureWrapMode wrapMode
		{
			[NativeName("GetWrapModeU")]
			[global::Cpp2ILInjected.Token(Token = "0x6000105")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F444", Offset = "0x1F6F444", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000106")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F480", Offset = "0x1F6F480", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "InitialiseTargets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		public extern FilterMode filterMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000107")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F4C4", Offset = "0x1F6F4C4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "InitialiseTargets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		public Vector2 texelSize
		{
			[NativeName("GetTexelSize")]
			[global::Cpp2ILInjected.Token(Token = "0x6000108")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6F508", Offset = "0x1F6F508", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F598", Offset = "0x1F6F598", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCompressedTextureFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "CanDecompressFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal bool ValidateFormat(TextureFormat format)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F820", Offset = "0x1F6F820", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6FA30", Offset = "0x1F6FA30", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "GetPixelBilinear", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new object[] { "T" }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal UnityException CreateNonReadableException(Texture t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6FB40", Offset = "0x1F6FB40", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new object[] { "T" }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal UnityException CreateNativeArrayLengthOverflowException()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6FBA8", Offset = "0x1F6FBA8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Texture()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F554", Offset = "0x1F6F554", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_texelSize_Injected(out Vector2 ret);

		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		public static readonly int GenerateAllMips;
	}
}
