using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
	[NativeHeader("Modules/TextRendering/Public/Font.h")]
	[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
	[NativeClass("TextRendering::Font")]
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public sealed class Font : Object
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000024 RID: 36 RVA: 0x0000209E File Offset: 0x0000029E
		// (remove) Token: 0x06000025 RID: 37 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public static event Action<Font> textureRebuilt
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000024")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5AA8", Offset = "0x1FA5AA8", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "TrackText", MemberParameters = new object[] { "UnityEngine.UI.Text" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5B74", Offset = "0x1FA5B74", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "UntrackText", MemberParameters = new object[] { "UnityEngine.UI.Text" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public extern Material material
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000026")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5C40", Offset = "0x1FA5C40", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public extern bool dynamic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA4CEC", Offset = "0x1FA4CEC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public extern int fontSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5C7C", Offset = "0x1FA5C7C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020A4 File Offset: 0x000002A4
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5CB8", Offset = "0x1FA5CB8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeTextureRebuilt_Internal(Font font)
		{
			throw null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5D3C", Offset = "0x1FA5D3C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "IsValidChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool HasCharacter(char c)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5D80", Offset = "0x1FA5D80", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern bool HasCharacter(int c);

		// Token: 0x04000049 RID: 73
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		private static Action<Font> textureRebuilt;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000039 RID: 57
		[global::Cpp2ILInjected.Token(Token = "0x200000D")]
		public delegate void FontTextureRebuildCallback();
	}
}
