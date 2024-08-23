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
	// Token: 0x0200004A RID: 74
	[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200004E")]
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		public override extern bool isReadable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F71468", Offset = "0x1F71468", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000135 RID: 309
		[FreeFunction("Texture2DArrayScripting::Create")]
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F714A4", Offset = "0x1F714A4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags);

		// Token: 0x06000136 RID: 310 RVA: 0x000022C6 File Offset: 0x000004C6
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71528", Offset = "0x1F71528", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Internal_Create([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000022C9 File Offset: 0x000004C9
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F715F8", Offset = "0x1F715F8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
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
		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			throw null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000022CC File Offset: 0x000004CC
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F716D4", Offset = "0x1F716D4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		internal bool ValidateFormat(GraphicsFormat format, int width, int height)
		{
			throw null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000022CF File Offset: 0x000004CF
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F717FC", Offset = "0x1F717FC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000022D2 File Offset: 0x000004D2
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71878", Offset = "0x1F71878", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000022D5 File Offset: 0x000004D5
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71918", Offset = "0x1F71918", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture2DArray),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
			throw null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000022D8 File Offset: 0x000004D8
		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71A48", Offset = "0x1F71A48", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = "ValidateIsNotCrunched", MemberParameters = new object[] { typeof(TextureCreationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture2DArray),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
		{
			throw null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000022DB File Offset: 0x000004DB
		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71B90", Offset = "0x1F71B90", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
			throw null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000022DE File Offset: 0x000004DE
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F71BA4", Offset = "0x1F71BA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
			throw null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000022E1 File Offset: 0x000004E1
		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F719F4", Offset = "0x1F719F4", Length = "0x54")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
			throw null;
		}
	}
}
