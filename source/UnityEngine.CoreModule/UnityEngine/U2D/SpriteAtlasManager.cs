using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.U2D
{
	// Token: 0x020000D6 RID: 214
	[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000ED")]
	public class SpriteAtlasManager
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x00002AD3 File Offset: 0x00000CD3
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87B14", Offset = "0x1F87B14", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool RequestAtlas(string tag)
		{
			throw null;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060004F7 RID: 1271 RVA: 0x00002AD6 File Offset: 0x00000CD6
		// (remove) Token: 0x060004F8 RID: 1272 RVA: 0x00002AD9 File Offset: 0x00000CD9
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public static event Action<SpriteAtlas> atlasRegistered
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000515")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87BCC", Offset = "0x1F87BCC", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackImage", MemberParameters = new object[] { "UnityEngine.UI.Image" }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.Token(Token = "0x6000516")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87C9C", Offset = "0x1F87C9C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002ADC File Offset: 0x00000CDC
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87D6C", Offset = "0x1F87D6C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
			throw null;
		}

		// Token: 0x060004FA RID: 1274
		[global::Cpp2ILInjected.Token(Token = "0x6000518")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87DD8", Offset = "0x1F87DD8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void Register(SpriteAtlas spriteAtlas);

		// Token: 0x040003CA RID: 970
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000407")]
		private static Action<string, Action<SpriteAtlas>> atlasRequested;

		// Token: 0x040003CB RID: 971
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000408")]
		private static Action<SpriteAtlas> atlasRegistered;
	}
}
