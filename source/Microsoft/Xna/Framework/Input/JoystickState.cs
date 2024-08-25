using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	[global::Cpp2ILInjected.Token(Token = "0x200034F")]
	public struct JoystickState
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60015C6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B410", Offset = "0xA9B410", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400232E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool <IsConnected>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400232F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int[] <Axes>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ButtonState[] <Buttons>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private JoystickHat[] <Hats>k__BackingField;
	}
}
