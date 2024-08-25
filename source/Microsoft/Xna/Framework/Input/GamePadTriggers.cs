using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	[global::Cpp2ILInjected.Token(Token = "0x2000348")]
	public struct GamePadTriggers
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000252")]
		public float Left
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001583")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A448", Offset = "0xA9A448", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001584")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A450", Offset = "0xA9A450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000253")]
		public float Right
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001585")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A458", Offset = "0xA9A458", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001586")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A460", Offset = "0xA9A460", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001587")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99278", Offset = "0xA99278", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public GamePadTriggers(float leftTrigger, float rightTrigger)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001588")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9959C", Offset = "0xA9959C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001589")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A468", Offset = "0xA9A468", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600158A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A480", Offset = "0xA9A480", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600158B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA998B4", Offset = "0xA998B4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600158C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99E10", Offset = "0xA99E10", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadState), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002313")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float <Left>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002314")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float <Right>k__BackingField;
	}
}
