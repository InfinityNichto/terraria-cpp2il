using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200003A RID: 58
	[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	internal class UnityLogWriter : TextWriter
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002140 File Offset: 0x00000340
		[ThreadAndSerializationSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000074")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C43C", Offset = "0x1F6C43C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void WriteStringToUnityLog(string s)
		{
			throw null;
		}

		// Token: 0x0600006D RID: 109
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C480", Offset = "0x1F6C480", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void WriteStringToUnityLogImpl(string s);

		// Token: 0x0600006E RID: 110 RVA: 0x00002143 File Offset: 0x00000343
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C4BC", Offset = "0x1F6C4BC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClassLibraryInitializer), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityLogWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "SetOut", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Init()
		{
			throw null;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002146 File Offset: 0x00000346
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public override Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000077")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C58C", Offset = "0x1F6C58C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002149 File Offset: 0x00000349
		[global::Cpp2ILInjected.Token(Token = "0x6000078")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C594", Offset = "0x1F6C594", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(char value)
		{
			throw null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000214C File Offset: 0x0000034C
		[global::Cpp2ILInjected.Token(Token = "0x6000079")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C5E8", Offset = "0x1F6C5E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Write(string s)
		{
			throw null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000214F File Offset: 0x0000034F
		[global::Cpp2ILInjected.Token(Token = "0x600007A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C62C", Offset = "0x1F6C62C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002152 File Offset: 0x00000352
		[global::Cpp2ILInjected.Token(Token = "0x600007B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C534", Offset = "0x1F6C534", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityLogWriter), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnityLogWriter()
		{
			throw null;
		}
	}
}
