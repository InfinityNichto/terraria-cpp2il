using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000122 RID: 290
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000147")]
	public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00002DA0 File Offset: 0x00000FA0
		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		public static PlayableOutputHandle Null
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000630")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8FA18", Offset = "0x1F8FA18", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayableOutput), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002DA3 File Offset: 0x00000FA3
		[global::Cpp2ILInjected.Token(Token = "0x6000631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FA70", Offset = "0x1F8FA70", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002DA6 File Offset: 0x00000FA6
		[global::Cpp2ILInjected.Token(Token = "0x6000632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FAA4", Offset = "0x1F8FAA4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayableOutput), Member = "Equals", MemberParameters = new object[] { typeof(PlayableOutput) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			throw null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002DA9 File Offset: 0x00000FA9
		[global::Cpp2ILInjected.Token(Token = "0x6000633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FB60", Offset = "0x1F8FB60", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object p)
		{
			throw null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002DAC File Offset: 0x00000FAC
		[global::Cpp2ILInjected.Token(Token = "0x6000634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FBD8", Offset = "0x1F8FBD8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(PlayableOutputHandle other)
		{
			throw null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002DAF File Offset: 0x00000FAF
		[global::Cpp2ILInjected.Token(Token = "0x6000635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FB2C", Offset = "0x1F8FB2C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			throw null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002DB2 File Offset: 0x00000FB2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FC58", Offset = "0x1F8FC58", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlayableOutputHandle()
		{
			throw null;
		}

		// Token: 0x040005C4 RID: 1476
		[global::Cpp2ILInjected.Token(Token = "0x4000613")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IntPtr m_Handle;

		// Token: 0x040005C5 RID: 1477
		[global::Cpp2ILInjected.Token(Token = "0x4000614")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal uint m_Version;

		// Token: 0x040005C6 RID: 1478
		[global::Cpp2ILInjected.Token(Token = "0x4000615")]
		private static readonly PlayableOutputHandle m_Null;
	}
}
