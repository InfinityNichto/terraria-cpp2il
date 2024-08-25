using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	[StructLayout(0)]
	public class ResourceRequest : AsyncOperation
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83A40", Offset = "0x1F83A40", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual Object GetResult()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83AC8", Offset = "0x1F83AC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = ".ctor", ReturnType = typeof(void))]
		public ResourceRequest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string m_Path;

		[global::Cpp2ILInjected.Token(Token = "0x40003CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Type m_Type;
	}
}
