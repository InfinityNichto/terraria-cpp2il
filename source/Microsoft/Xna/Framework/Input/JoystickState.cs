using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200028E RID: 654
	[global::Cpp2ILInjected.Token(Token = "0x200034F")]
	public struct JoystickState
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x000257A2 File Offset: 0x000239A2
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x000257A5 File Offset: 0x000239A5
		[global::Cpp2ILInjected.Token(Token = "0x17000261")]
		public bool IsConnected
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015BB")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B234", Offset = "0xA9B234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015BC")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B23C", Offset = "0xA9B23C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x000257A8 File Offset: 0x000239A8
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x000257AB File Offset: 0x000239AB
		[global::Cpp2ILInjected.Token(Token = "0x17000262")]
		public int[] Axes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015BD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B248", Offset = "0xA9B248", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015BE")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B250", Offset = "0xA9B250", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x000257AE File Offset: 0x000239AE
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x000257B1 File Offset: 0x000239B1
		[global::Cpp2ILInjected.Token(Token = "0x17000263")]
		public ButtonState[] Buttons
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015BF")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B258", Offset = "0xA9B258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015C0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B260", Offset = "0xA9B260", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x000257B4 File Offset: 0x000239B4
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x000257B7 File Offset: 0x000239B7
		[global::Cpp2ILInjected.Token(Token = "0x17000264")]
		public JoystickHat[] Hats
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015C1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B268", Offset = "0xA9B268", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015C2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9B270", Offset = "0xA9B270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000257BA File Offset: 0x000239BA
		[global::Cpp2ILInjected.Token(Token = "0x60015C3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B278", Offset = "0xA9B278", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoystickState), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(JoystickState),
			typeof(JoystickState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoystickState), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "SequenceEqual", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
		{
			typeof(IEnumerable<Int32Enum>),
			typeof(IEnumerable<Int32Enum>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "SequenceEqual", MemberTypeParameters = new object[] { typeof(JoystickHat) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<JoystickHat>),
			typeof(IEnumerable<JoystickHat>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator ==(JoystickState left, JoystickState right)
		{
			throw null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000257BD File Offset: 0x000239BD
		[global::Cpp2ILInjected.Token(Token = "0x60015C4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B348", Offset = "0xA9B348", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JoystickState), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(JoystickState),
			typeof(JoystickState)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(JoystickState left, JoystickState right)
		{
			throw null;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000257C0 File Offset: 0x000239C0
		[global::Cpp2ILInjected.Token(Token = "0x60015C5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B380", Offset = "0xA9B380", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JoystickState), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(JoystickState),
			typeof(JoystickState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x000257C3 File Offset: 0x000239C3
		[global::Cpp2ILInjected.Token(Token = "0x60015C6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B410", Offset = "0xA9B410", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000257C6 File Offset: 0x000239C6
		[global::Cpp2ILInjected.Token(Token = "0x60015C7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B518", Offset = "0xA9B518", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JoystickHat), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001D54 RID: 7508
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400232E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool <IsConnected>k__BackingField;

		// Token: 0x04001D55 RID: 7509
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400232F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int[] <Axes>k__BackingField;

		// Token: 0x04001D56 RID: 7510
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ButtonState[] <Buttons>k__BackingField;

		// Token: 0x04001D57 RID: 7511
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private JoystickHat[] <Hats>k__BackingField;
	}
}
