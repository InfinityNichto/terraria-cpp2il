﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	public sealed class Cubemap : Texture
	{
		// Token: 0x0600011C RID: 284
		[FreeFunction("CubemapScripting::Create")]
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70590", Offset = "0x1F70590", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex);

		// Token: 0x0600011D RID: 285 RVA: 0x0000228A File Offset: 0x0000048A
		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70604", Offset = "0x1F70604", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Internal_Create([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		public override extern bool isReadable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000126")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F706C4", Offset = "0x1F706C4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000228D File Offset: 0x0000048D
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70700", Offset = "0x1F70700", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mathf), Member = "IsPowerOfTwo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal bool ValidateFormat(TextureFormat format, int width)
		{
			throw null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002290 File Offset: 0x00000490
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F707C8", Offset = "0x1F707C8", Length = "0x11C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsPVRTCFormat", MemberParameters = new object[] { typeof(GraphicsFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mathf), Member = "IsPowerOfTwo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal bool ValidateFormat(GraphicsFormat format, int width)
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002293 File Offset: 0x00000493
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F708E4", Offset = "0x1F708E4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002296 File Offset: 0x00000496
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70984", Offset = "0x1F70984", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(DefaultFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Cubemap),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002299 File Offset: 0x00000499
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70A6C", Offset = "0x1F70A6C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Cubemap(int width, TextureFormat format, int mipCount)
		{
			throw null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000229C File Offset: 0x0000049C
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70C0C", Offset = "0x1F70C0C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Cubemap),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
			throw null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000229F File Offset: 0x0000049F
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70AE4", Offset = "0x1F70AE4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(bool),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Cubemap),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
		{
			throw null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000022A2 File Offset: 0x000004A2
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70D3C", Offset = "0x1F70D3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
		{
			throw null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000022A5 File Offset: 0x000004A5
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70D4C", Offset = "0x1F70D4C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Cubemap(int width, TextureFormat textureFormat, bool mipChain)
		{
			throw null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000022A8 File Offset: 0x000004A8
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70CE8", Offset = "0x1F70CE8", Length = "0x54")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
			throw null;
		}
	}
}