using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200006F RID: 111
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	[global::System.Serializable]
	public sealed class CharEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<char>, global::System.IDisposable, global::System.ICloneable
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00015143 File Offset: 0x00013343
		[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBD88", Offset = "0x1BBBD88", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator", ReturnType = typeof(global::System.Collections.Generic.IEnumerator<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CharEnumerator(string str)
		{
			throw null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00015146 File Offset: 0x00013346
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBDB8", Offset = "0x1BBBDB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00015149 File Offset: 0x00013349
		[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBDC0", Offset = "0x1BBBDC0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001514C File Offset: 0x0001334C
		[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBE0C", Offset = "0x1BBBE0C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001514F File Offset: 0x0001334F
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BBBE24", Offset = "0x1BBBE24", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CharEnumerator), Member = "get_Current", ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00015152 File Offset: 0x00013352
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		public char Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BBBE88", Offset = "0x1BBBE88", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CharEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00015155 File Offset: 0x00013355
		[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBF1C", Offset = "0x1BBBF1C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00015158 File Offset: 0x00013358
		[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBF2C", Offset = "0x1BBBF2C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal CharEnumerator()
		{
			throw null;
		}

		// Token: 0x0400012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _str;

		// Token: 0x0400012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _index;

		// Token: 0x0400012F RID: 303
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private char _currentElement;
	}
}
