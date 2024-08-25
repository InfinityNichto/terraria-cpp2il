using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200018E")]
	internal static class ParameterizedStrings
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000F9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C890E0", Offset = "0x1C890E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool AsBool(int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C890D8", Offset = "0x1C890D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int AsInt(bool b)
		{
			throw null;
		}

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

		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40006C4")]
		private static global::System.ParameterizedStrings.LowLevelStack _cachedStack;

		[global::Cpp2ILInjected.Token(Token = "0x200018F")]
		public struct FormatParam
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89334", Offset = "0x1C89334", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public FormatParam(int value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000FA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89340", Offset = "0x1C89340", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private FormatParam(int intValue, string stringValue)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000FA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C86088", Offset = "0x1C86088", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static implicit operator global::System.ParameterizedStrings.FormatParam(int value)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40006C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly int _int32;

			[global::Cpp2ILInjected.Token(Token = "0x40006C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly string _string;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000190")]
		private sealed class LowLevelStack
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40006C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.ParameterizedStrings.FormatParam[] _arr;

			[global::Cpp2ILInjected.Token(Token = "0x40006C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _count;
		}
	}
}
