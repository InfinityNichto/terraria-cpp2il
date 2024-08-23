using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000147 RID: 327
	[global::Cpp2ILInjected.Token(Token = "0x200018E")]
	internal static class ParameterizedStrings
	{
		// Token: 0x06000EB2 RID: 3762 RVA: 0x00016EAA File Offset: 0x000150AA
		[global::Cpp2ILInjected.Token(Token = "0x6000F9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C86094", Offset = "0x1C86094", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings.LowLevelStack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			typeof(global::System.ParameterizedStrings.LowLevelStack),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static string Evaluate(string format, params global::System.ParameterizedStrings.FormatParam[] args)
		{
			throw null;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00016EAD File Offset: 0x000150AD
		[global::Cpp2ILInjected.Token(Token = "0x6000F9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C883F0", Offset = "0x1C883F0", Length = "0x7C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "Evaluate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			typeof(global::System.ParameterizedStrings.LowLevelStack),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings.LowLevelStack), Member = "Pop", ReturnType = typeof(global::System.ParameterizedStrings.FormatParam))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings.FormatParam), Member = "get_Object", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "GetDynamicOrStaticVariables", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref int)
		}, ReturnType = typeof(global::System.ParameterizedStrings.FormatParam[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			typeof(global::System.ParameterizedStrings.LowLevelStack),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings.LowLevelStack), Member = "Push", MemberParameters = new object[] { typeof(global::System.ParameterizedStrings.FormatParam) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static string EvaluateInternal(string format, ref int pos, global::System.ParameterizedStrings.FormatParam[] args, global::System.ParameterizedStrings.LowLevelStack stack, ref global::System.ParameterizedStrings.FormatParam[] dynamicVars, ref global::System.ParameterizedStrings.FormatParam[] staticVars)
		{
			throw null;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00016EB0 File Offset: 0x000150B0
		[global::Cpp2ILInjected.Token(Token = "0x6000F9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C890E0", Offset = "0x1C890E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool AsBool(int i)
		{
			throw null;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00016EB3 File Offset: 0x000150B3
		[global::Cpp2ILInjected.Token(Token = "0x6000FA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C890D8", Offset = "0x1C890D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int AsInt(bool b)
		{
			throw null;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00016EB6 File Offset: 0x000150B6
		[global::Cpp2ILInjected.Token(Token = "0x6000FA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C890EC", Offset = "0x1C890EC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string StringFromAsciiBytes(byte[] buffer, int offset, int length)
		{
			throw null;
		}

		// Token: 0x06000EB7 RID: 3767
		[global::Cpp2ILInjected.Token(Token = "0x6000FA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C891B0", Offset = "0x1C891B0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern int snprintf(byte* str, global::System.IntPtr size, string format, string arg1);

		// Token: 0x06000EB8 RID: 3768
		[global::Cpp2ILInjected.Token(Token = "0x6000FA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8927C", Offset = "0x1C8927C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern int snprintf(byte* str, global::System.IntPtr size, string format, int arg1);

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00016EB9 File Offset: 0x000150B9
		[global::Cpp2ILInjected.Token(Token = "0x6000FA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88CD4", Offset = "0x1C88CD4", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			typeof(global::System.ParameterizedStrings.LowLevelStack),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "snprintf", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(global::System.IntPtr),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "snprintf", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(global::System.IntPtr),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParameterizedStrings), Member = "StringFromAsciiBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private unsafe static string FormatPrintF(string format, object arg)
		{
			throw null;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00016EBC File Offset: 0x000150BC
		[global::Cpp2ILInjected.Token(Token = "0x6000FA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88FD4", Offset = "0x1C88FD4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			typeof(global::System.ParameterizedStrings.LowLevelStack),
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static global::System.ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref global::System.ParameterizedStrings.FormatParam[] dynamicVars, ref global::System.ParameterizedStrings.FormatParam[] staticVars, out int index)
		{
			throw null;
		}

		// Token: 0x040004F3 RID: 1267
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40006C4")]
		private static global::System.ParameterizedStrings.LowLevelStack _cachedStack;

		// Token: 0x0200059A RID: 1434
		[global::Cpp2ILInjected.Token(Token = "0x200018F")]
		public struct FormatParam
		{
			// Token: 0x06003FD8 RID: 16344 RVA: 0x0001FA42 File Offset: 0x0001DC42
			[global::Cpp2ILInjected.Token(Token = "0x6000FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89334", Offset = "0x1C89334", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public FormatParam(int value)
			{
				throw null;
			}

			// Token: 0x06003FD9 RID: 16345 RVA: 0x0001FA45 File Offset: 0x0001DC45
			[global::Cpp2ILInjected.Token(Token = "0x6000FA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89340", Offset = "0x1C89340", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private FormatParam(int intValue, string stringValue)
			{
				throw null;
			}

			// Token: 0x06003FDA RID: 16346 RVA: 0x0001FA48 File Offset: 0x0001DC48
			[global::Cpp2ILInjected.Token(Token = "0x6000FA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C86088", Offset = "0x1C86088", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static implicit operator global::System.ParameterizedStrings.FormatParam(int value)
			{
				throw null;
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06003FDB RID: 16347 RVA: 0x0001FA4B File Offset: 0x0001DC4B
			[global::Cpp2ILInjected.Token(Token = "0x17000165")]
			public int Int32
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000FA9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C8934C", Offset = "0x1C8934C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06003FDC RID: 16348 RVA: 0x0001FA4E File Offset: 0x0001DC4E
			[global::Cpp2ILInjected.Token(Token = "0x17000166")]
			public string String
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000FAA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C88C24", Offset = "0x1C88C24", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06003FDD RID: 16349 RVA: 0x0001FA51 File Offset: 0x0001DC51
			[global::Cpp2ILInjected.Token(Token = "0x17000167")]
			public object Object
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000FAB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C88C78", Offset = "0x1C88C78", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
				{
					typeof(string),
					typeof(ref int),
					typeof(global::System.ParameterizedStrings.FormatParam[]),
					"System.ParameterizedStrings.LowLevelStack",
					typeof(ref global::System.ParameterizedStrings.FormatParam[]),
					typeof(ref global::System.ParameterizedStrings.FormatParam[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001878 RID: 6264
			[global::Cpp2ILInjected.Token(Token = "0x40006C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly int _int32;

			// Token: 0x04001879 RID: 6265
			[global::Cpp2ILInjected.Token(Token = "0x40006C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly string _string;
		}

		// Token: 0x0200059B RID: 1435
		[global::Cpp2ILInjected.Token(Token = "0x2000190")]
		private sealed class LowLevelStack
		{
			// Token: 0x06003FDE RID: 16350 RVA: 0x0001FA54 File Offset: 0x0001DC54
			[global::Cpp2ILInjected.Token(Token = "0x6000FAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C88378", Offset = "0x1C88378", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "Evaluate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.ParameterizedStrings.FormatParam[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public LowLevelStack()
			{
				throw null;
			}

			// Token: 0x06003FDF RID: 16351 RVA: 0x0001FA57 File Offset: 0x0001DC57
			[global::Cpp2ILInjected.Token(Token = "0x6000FAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C88BB0", Offset = "0x1C88BB0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int),
				typeof(global::System.ParameterizedStrings.FormatParam[]),
				typeof(global::System.ParameterizedStrings.LowLevelStack),
				typeof(ref global::System.ParameterizedStrings.FormatParam[]),
				typeof(ref global::System.ParameterizedStrings.FormatParam[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public global::System.ParameterizedStrings.FormatParam Pop()
			{
				throw null;
			}

			// Token: 0x06003FE0 RID: 16352 RVA: 0x0001FA5A File Offset: 0x0001DC5A
			[global::Cpp2ILInjected.Token(Token = "0x6000FAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C88F28", Offset = "0x1C88F28", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int),
				typeof(global::System.ParameterizedStrings.FormatParam[]),
				typeof(global::System.ParameterizedStrings.LowLevelStack),
				typeof(ref global::System.ParameterizedStrings.FormatParam[]),
				typeof(ref global::System.ParameterizedStrings.FormatParam[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void Push(global::System.ParameterizedStrings.FormatParam item)
			{
				throw null;
			}

			// Token: 0x06003FE1 RID: 16353 RVA: 0x0001FA5D File Offset: 0x0001DC5D
			[global::Cpp2ILInjected.Token(Token = "0x6000FAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C883C8", Offset = "0x1C883C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x0400187A RID: 6266
			[global::Cpp2ILInjected.Token(Token = "0x40006C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.ParameterizedStrings.FormatParam[] _arr;

			// Token: 0x0400187B RID: 6267
			[global::Cpp2ILInjected.Token(Token = "0x40006C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _count;
		}
	}
}
