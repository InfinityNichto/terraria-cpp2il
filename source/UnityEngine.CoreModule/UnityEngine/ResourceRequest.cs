using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C2 RID: 194
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	[StructLayout(0)]
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x00002995 File Offset: 0x00000B95
		[global::Cpp2ILInjected.Token(Token = "0x6000456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83A40", Offset = "0x1F83A40", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual Object GetResult()
		{
			throw null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00002998 File Offset: 0x00000B98
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		public Object asset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000457")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F83ABC", Offset = "0x1F83ABC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ThreadContentRequest", Member = "UpdateLoad", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000299B File Offset: 0x00000B9B
		[global::Cpp2ILInjected.Token(Token = "0x6000458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83AC8", Offset = "0x1F83AC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = ".ctor", ReturnType = typeof(void))]
		public ResourceRequest()
		{
			throw null;
		}

		// Token: 0x04000393 RID: 915
		[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string m_Path;

		// Token: 0x04000394 RID: 916
		[global::Cpp2ILInjected.Token(Token = "0x40003CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Type m_Type;
	}
}
